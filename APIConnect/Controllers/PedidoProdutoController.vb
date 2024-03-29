﻿Imports System.Data.OleDb
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
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)

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
            comando = New OleDbCommand("INSERT INTO XMLDocumento (Tipo,texto) VALUES ('JSONPEDIDOPRODUTO','" & value.ToString.Replace(vbCrLf, "") & "')", dados)
            comando.ExecuteNonQuery()
            dados.Close()
            Try
                listaPedido = JsonConvert.DeserializeObject(Of List(Of PedidoProduto))(json)
                For i = 0 To listaPedido.Count - 1
                    Dim controleCodigo = New ControleCodigo
                    dados.Open()
                    pedidoproduto = New PedidoProduto

                    pedidoproduto = listaPedido(i)
                    pedidoproduto.Eminota = True
                    insert = RetornaInsert(fieldList, pedidoproduto, "[Pedido Produto]")
                    insert = insert.Replace("codproduto", "[Cód Produto]")
                    insert = insert.Replace("codpedido", "[Cód Pedido]")
                    insert = insert.Replace("valorunitario", "[Valor Unitário]")
                    insert = insert.Replace("valortotal", "[Valor Total]")
                    insert = insert.Replace("codmecanico", "[Cód Mecanico]")


                    comando = New OleDbCommand(insert, dados)
                    'ds = New DataSet
                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    'comando = New OleDbCommand("SELECT TOP 1 * from Pedido order by Pedido desc", dados)
                    'da = New OleDbDataAdapter(comando)
                    'da.Fill(ds, "Pedido")
                    'comando.Dispose()
                    controleCodigo.CodigoAndroid = pedidoproduto.Pedido
                    controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Pedido")
                    'ds.Dispose()
                    'ds = Nothing
                    'da.Dispose()
                    'da = Nothing
                    'dados.Close()
                    listcontrolecodigo.Add(controleCodigo)
                    dados.Close()
                Next

                Return listcontrolecodigo
            Catch ex As Exception
                Dim controleCodigo = New ControleCodigo
                controleCodigo.CodigoAndroid = 0
                controleCodigo.CodigoBanco = 0
                If (ex.Message.Contains("unknown field name")) Then
                    controleCodigo.Mensagem = RetornaCampoQueFalta(ex.Message, pedidoproduto, "[Pedido Produto]")
                    comando = New OleDbCommand(controleCodigo.Mensagem, dados)
                    comando.ExecuteNonQuery()
                    System.Diagnostics.Debug.WriteLine("Banco.execute " & Chr(34) & controleCodigo.Mensagem & Chr(34))
                Else
                    controleCodigo.Mensagem = ex.Message & " - " & ex.StackTrace & " - " & insert
                End If
                dados.Close()
                listcontrolecodigo.Add(controleCodigo)
                Return listcontrolecodigo
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