Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class NotaProdutoController
        Inherits ApiController

        ' GET: api/NotaProduto
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/NotaProduto/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/NotaProduto
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim json = value.ToString
            Dim listaNotaProduto As List(Of NotaProduto)
            Dim notaProduto As New NotaProduto
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = notaProduto.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT TOP 1 * from [Nota Produto] order by [Cód Nota] desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Nota Produto")
            dados.Close()
            Try
                listaNotaProduto = JsonConvert.DeserializeObject(Of List(Of NotaProduto))(json)
                dados.Open()
                comando = New OleDbCommand("DELETE * FROM [NOTA PRODUTO] WHERE [CÓD NOTA] = '" & listaNotaProduto(0).codnota & "'", dados)
                comando.ExecuteNonQuery()
                dados.Close()

                For i = 0 To listaNotaProduto.Count - 1
                    Dim controleCodigo = New ControleCodigo
                    dados.Open()
                    notaProduto = New NotaProduto
                    notaProduto = listaNotaProduto(i)
                    notaProduto.codemitente = 1
                    If (notaProduto.Auto > 0) Then
                        insert = RetornaUpdate(fieldList, notaProduto, "[Nota Produto]", "auto", notaProduto.Auto)
                        comando = New OleDbCommand("SELECT TOP 1 * from [Nota Produto] where auto = " & notaProduto.Auto & " order by [Cód Nota] desc", dados)
                        da = Nothing
                        ds = Nothing
                        ds = New DataSet
                        da = New OleDbDataAdapter(comando)
                        da.Fill(ds, "Nota Produto")
                    Else

                        insert = RetornaInsert(fieldList, notaProduto, "[Nota Produto]")
                    End If
                    insert = insert.Replace("codnota", "[Cód Nota]")
                    insert = insert.Replace("valorunitario", "[Valor Unitário]")
                    insert = insert.Replace("valortotal", "[Valor Total]")
                    insert = insert.Replace("valornota", "[Valor Nota]")
                    insert = insert.Replace("valoripi", "[Valor IPI]")
                    insert = insert.Replace("aliqicms", "[Aliq ICMS]")
                    insert = insert.Replace("aliqipi", "[Aliq IPI]")
                    insert = insert.Replace("codicms", "[Cód ICMS]")
                    insert = insert.Replace("codtipo", "[Cód Tipo]")
                    insert = insert.Replace("codpis", "[CódPIS]")
                    insert = insert.Replace("codcofins", "[CódCOFINS]")
                    insert = insert.Replace("codipi", "[CódIPI]")
                    insert = insert.Replace("codigo", "[código]")
                    comando = New OleDbCommand(insert, dados)
                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    controleCodigo.CodigoAndroid = notaProduto.Auto
                    controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Auto")
                    listcontrolecodigo.Add(controleCodigo)
                Next
                Return listcontrolecodigo
            Catch ex As Exception
                Dim controleCodigo = New ControleCodigo
                controleCodigo.CodigoAndroid = 0
                controleCodigo.CodigoBanco = 0
                controleCodigo.Mensagem = ex.Message
                listcontrolecodigo.Add(controleCodigo)
                Return listcontrolecodigo
                Console.WriteLine(ex.Message)
            End Try

        End Function

        ' PUT: api/NotaProduto/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/NotaProduto/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace