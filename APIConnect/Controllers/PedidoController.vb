﻿Imports System.Data.OleDb
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
            comando = New OleDbCommand("INSERT INTO XMLDocumento (Tipo,texto) VALUES ('JSONPEDIDO','" & value.ToString.Replace(vbCrLf, "") & "')", dados)
            comando.ExecuteNonQuery()
            dados.Close()
            Try
                json = json.Replace(Chr(34) & "dataentrega" & Chr(34) & ": 0,", Chr(34) & "dataentrega" & Chr(34) & ": " & Chr(34) & Format(Today, "yyyy-MM-dd") & "T00:00:00" & Chr(34) & ",")
                listaPedido = JsonConvert.DeserializeObject(Of List(Of Pedido))(json)
                For i = 0 To listaPedido.Count - 1
                    dados.Open()
                    controleCodigo = New ControleCodigo
                    pedido = New Pedido

                    pedido = listaPedido(i)
                    pedido.geradoexterno = True
                    If (pedido.total) = 0 Then
                        pedido.total = pedido.valortotal
                    End If
                    If (pedido.rota = "" Or pedido.rota = vbNull) Then
                        pedido.rota = CInt(pedido.codvendedor)
                    End If
                    If (pedido.formadepagamento) <> "" Then
                        pedido.pgto = pedido.formadepagamento
                        pedido.formadepagamento = ""
                    End If
                    pedido.codstatus = 2
                    pedido.orpedi = "2"
                    'pedido.dataentrega = Format(Now, "dd/MM/yyyy")
                    pedido.baixa = True
                    insert = RetornaInsert(fieldList, pedido, "Pedido")
                    insert = insert.Replace("codcliente", "[Cód cliente]")
                    insert = insert.Replace("codvendedor", "[Cód Vendedor]")
                    insert = insert.Replace("valortotal", "[Valor Total]")
                    insert = insert.Replace("simnao", "[Sim/Não]")
                    insert = insert.Replace("codpedido", "[Cód Pedido]")
                    insert = insert.Replace("formadepagamento", "[Forma de Pagamento]")
                    insert = insert.Replace("codbanco", "[Cód Banco]")
                    insert = insert.Replace("codhistorico", "[Cód Histórico]")
                    insert = insert.Replace("codproduto", "[Cod Produto]")
                    insert = insert.Replace("codinstituicao", "[Cód Instituição]")
                    insert = insert.Replace("codmecanico", "[Cód Mecanico]")

                    comando = New OleDbCommand(insert, dados)
                    ds = New DataSet
                    Dim numerodelinhas = comando.ExecuteNonQuery()
                    comando = New OleDbCommand("SELECT TOP 1 * from PedidoAndroid order by Pedido desc", dados)
                    da = New OleDbDataAdapter(comando)
                    da.Fill(ds, "PedidoAndroid")

                    comando.Dispose()
                    controleCodigo.CodigoAndroid = pedido.pedido
                    controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Pedido")

                    ds.Dispose()
                    ds = Nothing
                    da.Dispose()
                    da = Nothing
                    dados.Close()
                    listcontrolecodigo.Add(controleCodigo)
                Next
            Catch ex As Exception
                controleCodigo = New ControleCodigo
                If (ex.Message.Contains("unknown field name")) Then
                    controleCodigo.Mensagem = RetornaCampoQueFalta(ex.Message, pedido, "Pedido")
                    comando = New OleDbCommand(controleCodigo.Mensagem, dados)
                    comando.ExecuteNonQuery()
                    System.Diagnostics.Debug.WriteLine("Banco.execute " & Chr(34) & controleCodigo.Mensagem & Chr(34))
                Else
                    controleCodigo.Mensagem = ex.Message & " - " & ex.StackTrace & " - " & insert
                End If
                dados.Close()
                listcontrolecodigo.Add(controleCodigo)
                Return listcontrolecodigo
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