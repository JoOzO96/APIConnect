Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ParcelasController
        Inherits ApiController

        ' GET: api/Parcelas
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Parcelas/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Parcelas
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim json = value.ToString
            Dim listaParcelas As List(Of Parcelas)
            Dim parcelas As New Parcelas
            Dim controleCodigo As ControleCodigo
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = parcelas.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT TOP 1 * from Parcelas order by [Cód Pedido] desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Parcelas")
            comando = New OleDbCommand("INSERT INTO XMLDocumento (Tipo,texto) VALUES ('JSONPARCELAS','" & value.ToString.Replace(vbCrLf, "") & "')", dados)
            comando.ExecuteNonQuery()
            dados.Close()
            Try
                listaParcelas = JsonConvert.DeserializeObject(Of List(Of Parcelas))(json)
                For i = 0 To listaParcelas.Count - 1
                    controleCodigo = New ControleCodigo
                    dados.Open()
                    parcelas = New Parcelas

                    parcelas = listaParcelas(i)

                    insert = RetornaInsert(fieldList, parcelas, "Parcelas")
                    insert = insert.Replace("codpedido", "[Cód Pedido]")
                    comando = New OleDbCommand(insert, dados)
                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    comando = New OleDbCommand("SELECT TOP 1 * from Parcelas order by [Cód Pedido] desc", dados)
                    da = New OleDbDataAdapter(comando)
                    da.Fill(ds, "Parcelas")

                    comando.Dispose()
                    controleCodigo.CodigoAndroid = parcelas.codpedido
                    controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Cód Pedido")
                    dados.Close()
                    listcontrolecodigo.Add(controleCodigo)
                Next

                Return listcontrolecodigo
            Catch ex As Exception
                controleCodigo = New ControleCodigo
                controleCodigo.Mensagem = ex.Message & " - " & insert
                listcontrolecodigo.Add(controleCodigo)
                Return listcontrolecodigo
            End Try

        End Function

        ' PUT: api/Parcelas/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Parcelas/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace