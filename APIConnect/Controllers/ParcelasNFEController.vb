Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ParcelasNFEController
        Inherits ApiController

        ' GET: api/ParcelasNFE
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/ParcelasNFE/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/ParcelasNFE
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim json = value.ToString
            Dim listaParcelasNFE As List(Of ParcelasNFE)
            Dim parcelas As New ParcelasNFE
            Dim controleCodigo As ControleCodigo
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = parcelas.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT TOP 1 * from ParcelasNFE order by [CódNota] desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "ParcelasNFE")
            dados.Close()
            Try
                listaParcelasNFE = JsonConvert.DeserializeObject(Of List(Of ParcelasNFE))(json)
                For i = 0 To listaParcelasNFE.Count - 1
                    controleCodigo = New ControleCodigo
                    dados.Open()
                    parcelas = New ParcelasNFE

                    parcelas = listaParcelasNFE(i)
                    parcelas.codemitente = 1
                    da = Nothing
                    ds = Nothing
                    ds = New DataSet
                    comando = New OleDbCommand("SELECT * from ParcelasNFE WHERE [CÓDNOTA] = '" & parcelas.codnota & "' and codemitente = " & parcelas.codemitente & " order by [CódNota] desc", dados)
                    da = New OleDbDataAdapter(comando)
                    da.Fill(ds, "ParcelasNFE")
                    If (ds.Tables(0).Rows.Count = 0) Then
                        insert = RetornaInsert(fieldList, parcelas, "ParcelasNFE")
                    Else
                        insert = RetornaUpdate(fieldList, parcelas, "ParcelasNFE", "[CódNota]|CodEmitente", "'" & parcelas.codnota & "'|" & parcelas.codemitente)
                    End If
                    insert = insert.Replace("codnota", "[CódNota]")
                    comando = New OleDbCommand(insert, dados)
                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    comando = New OleDbCommand("SELECT TOP 1 * from ParcelasNFE order by [CódNota] desc", dados)
                    da = New OleDbDataAdapter(comando)
                    da.Fill(ds, "ParcelasNFE")

                    comando.Dispose()
                    controleCodigo.CodigoAndroid = parcelas.codnota
                    controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("CódNota")
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

        ' PUT: api/ParcelasNFE/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/ParcelasNFE/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace