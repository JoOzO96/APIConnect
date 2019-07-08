Imports System.Data.OleDb
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class PedidoController
        Inherits ApiController

        ' GET: api/Pedido
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Pedido/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Pedido
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim json = value.ToString
            Dim listaPedido As List(Of Pedido)
            Dim pedido As New Pedido
            Dim controleCodigo As ControleCodigo
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = pedido.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT TOP 1 * from Pedido order by Pedido desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Pedido")
            dados.Close()
            Try
                listaPedido = JsonConvert.DeserializeObject(Of List(Of Pedido))(json)
                For i = 0 To listaPedido.Count - 1
                    dados.Open()
                    controleCodigo = New ControleCodigo
                    pedido = New Pedido

                    pedido = listaPedido(i)
                    insert = RetornaInsert(fieldList, pedido, "Pedido")
                    insert = insert.Replace("Codcliente", "[Cód cliente]")
                    insert = insert.Replace("Codvendedor", "[Cód Vendedor]")
                    insert = insert.Replace("Valortotal", "[Valor Total]")
                    insert = insert.Replace("Simnao", "[Sim/Não]")
                    insert = insert.Replace("Codpedido", "[Cód Pedido]")
                    insert = insert.Replace("Formadepagamento", "[Forma de Pagamento]")
                    insert = insert.Replace("Codbanco", "[Cód Banco]")
                    insert = insert.Replace("Codhistorico", "[Cód Histórico]")
                    insert = insert.Replace("Codproduto", "[Cod Produto]")
                    insert = insert.Replace("Codinstituicao", "[Cód Instituição]")

                    comando = New OleDbCommand(insert, dados)
                    ds = New DataSet
                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    comando = New OleDbCommand("SELECT TOP 1 * from Pedido order by Pedido desc", dados)
                    da = New OleDbDataAdapter(comando)
                    da.Fill(ds, "Pedido")

                    comando.Dispose()
                    controleCodigo.CodigoAndroid = pedido.Pedido
                    controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Pedido")

                    ds.Dispose()
                    ds = Nothing
                    da.Dispose()
                    da = Nothing
                    dados.Close()
                    listcontrolecodigo.Add(controleCodigo)
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try


            Return listcontrolecodigo
        End Function

        ' PUT: api/Pedido/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Pedido/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace