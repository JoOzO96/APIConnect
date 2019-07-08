Imports System.Data.OleDb
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class PedidoProdutoController
        Inherits ApiController

        ' GET: api/PedidoProduto
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/PedidoProduto/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/PedidoProduto
        Public Function PostValue(<FromBody()> ByVal value As Object) As String

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim json = value.ToString
            Dim listaPedido As List(Of PedidoProduto)
            Dim pedidoproduto As New PedidoProduto
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = pedidoproduto.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT TOP 1 * from [Pedido Produto] order by Pedido desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Pedido Produto")
            dados.Close()
            Try
                listaPedido = JsonConvert.DeserializeObject(Of List(Of PedidoProduto))(json)
                For i = 0 To listaPedido.Count - 1
                    dados.Open()
                    pedidoproduto = New PedidoProduto

                    pedidoproduto = listaPedido(i)
                    insert = RetornaInsert(fieldList, pedidoproduto, "[Pedido Produto]")
                    insert = insert.Replace("Codproduto", "[Cód Produto]")
                    insert = insert.Replace("Codpedido", "[Cód Pedido]")
                    insert = insert.Replace("Valorunitario", "[Valor Unitário]")
                    insert = insert.Replace("Valortotal", "[Valor Total]")
                    insert = insert.Replace("Codmecanico", "[Cód Mecanico]")


                    comando = New OleDbCommand(insert, dados)
                    'ds = New DataSet
                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    'comando = New OleDbCommand("SELECT TOP 1 * from Pedido order by Pedido desc", dados)
                    'da = New OleDbDataAdapter(comando)
                    'da.Fill(ds, "Pedido")
                    'comando.Dispose()
                    'controleCodigo.CodigoAndroid = pedido.Pedido
                    'controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Pedido")
                    'ds.Dispose()
                    'ds = Nothing
                    'da.Dispose()
                    'da = Nothing
                    'dados.Close()
                Next

                Return "nada"
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Function

        ' PUT: api/PedidoProduto/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/PedidoProduto/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace