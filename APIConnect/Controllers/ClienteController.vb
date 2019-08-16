Imports System.Net
Imports System.Web.Http
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Web.Http.Results
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ClienteController
        Inherits ApiController

        ' GET: api/Cliente
        Public Function GetValues() As List(Of Cliente)
            'Try

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from cliente", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Cliente")

            Dim cliente As New Cliente
            Dim fieldList() = cliente.GetType().GetProperties
            Dim nomeCampo As String

            Dim _cliente As New List(Of Cliente)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                cliente = New Cliente
                For j = 0 To fieldList.Length - 1

                    nomeCampo = fieldList(j).Name.ToLower
                    If Not nomeCampo.Equals("cadastroandroid") And Not nomeCampo.Equals("alteradoandroid") Then
                        If (nomeCampo.Equals("codigo")) Then
                            nomeCampo = "Código"
                        ElseIf (nomeCampo.Equals("nomecliente")) Then
                            nomeCampo = "Nome Cliente"
                        ElseIf (nomeCampo.Equals("datanasc")) Then
                            nomeCampo = "Data Nasc"
                        ElseIf (nomeCampo.Equals("codprofissao")) Then
                            nomeCampo = "Cód Profissao"
                        ElseIf (nomeCampo.Equals("codcidade")) Then
                            nomeCampo = "Cod Cidade"
                        ElseIf (nomeCampo.Equals("responsavel")) Then
                            nomeCampo = "Responsável"
                        ElseIf (nomeCampo.Equals("codvendedor")) Then
                            nomeCampo = "Cód Vendedor"
                        ElseIf (nomeCampo.Equals("conjuge")) Then
                            nomeCampo = "conjugê"
                        ElseIf (nomeCampo.Equals("codigopgto")) Then
                            nomeCampo = "CódigoPgto"
                        End If

                        If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                            cliente = colocaDadosObjeto(cliente, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                            'fieldList(j).SetValue(cliente, ds.Tables(0).Rows(i)(nomeCampo))
                        End If
                    End If
                Next
                _cliente.Add(cliente)
            Next

            dados.Close()

            Return _cliente
            'Catch ex As Exception



            'Console.Write("" & ex.Message)

            'End Try
        End Function

        ' GET: api/Cliente/5
        Public Function GetValue(ByVal id As String) As JsonResult(Of List(Of Cliente))
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            dados.ConnectionString = RetornaConexao()
            dados.Open()

            comando = New OleDbCommand("SELECT * from ListaMac WHERE [Mac] = '" & id & "'", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "ListaMac")
            If (ds.Tables(0).Rows.Count > 0) Then
                If ds.Tables(0).Rows(0)("CodVendedor") = "" Then
                    comando = New OleDbCommand("SELECT * from cliente WHERE [Cód Vendedor] = '" & ds.Tables(0).Rows(0)("CodVendedor") & "'", dados)
                Else
                    comando = New OleDbCommand("SELECT * from cliente", dados)
                End If
            Else
                    comando = New OleDbCommand("SELECT * from cliente", dados)
            End If
            ds = New DataSet
            da = New OleDbDataAdapter(comando)
            da.Fill(ds, "Cliente")

            Dim cliente As New Cliente
            Dim fieldList() = cliente.GetType().GetProperties
            Dim nomeCampo As String

            Dim _cliente As New List(Of Cliente)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                cliente = New Cliente
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
                    If Not nomeCampo.Equals("cadastroandroid") And Not nomeCampo.Equals("alteradoandroid") Then
                        If (nomeCampo.Equals("codigo")) Then
                            nomeCampo = "Código"
                        ElseIf (nomeCampo.Equals("nomecliente")) Then
                            nomeCampo = "Nome Cliente"
                        ElseIf (nomeCampo.Equals("datanasc")) Then
                            nomeCampo = "Data Nasc"
                        ElseIf (nomeCampo.Equals("codprofissao")) Then
                            nomeCampo = "Cód Profissao"
                        ElseIf (nomeCampo.Equals("codcidade")) Then
                            nomeCampo = "Cod Cidade"
                        ElseIf (nomeCampo.Equals("responsavel")) Then
                            nomeCampo = "Responsável"
                        ElseIf (nomeCampo.Equals("codvendedor")) Then
                            nomeCampo = "Cód Vendedor"
                        ElseIf (nomeCampo.Equals("conjuge")) Then
                            nomeCampo = "conjugê"
                        ElseIf (nomeCampo.Equals("codigopgto")) Then
                            nomeCampo = "CódigoPgto"
                        End If

                        If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                            cliente = colocaDadosObjeto(cliente, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                            'fieldList(j).SetValue(cliente, ds.Tables(0).Rows(i)(nomeCampo))
                        End If
                    End If
                Next
                _cliente.Add(cliente)
            Next

            dados.Close()
            Return Json(_cliente)
            'Return _cliente
        End Function

        ' POST: api/Cliente
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim json = value.ToString
            Dim listaCliente As List(Of Cliente)
            Dim cliente As New Cliente
            Dim controleCodigo As ControleCodigo
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = cliente.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT TOP 1 * from Cliente order by [Código] desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Cliente")
            dados.Close()
            Try
                listaCliente = JsonConvert.DeserializeObject(Of List(Of Cliente))(json)
                For i = 0 To listaCliente.Count - 1
                    controleCodigo = New ControleCodigo
                    dados.Open()
                    cliente = New Cliente

                    cliente = listaCliente(i)
                    If cliente.alteradoAndroid = True Then
                        cliente.codprofissao = 1
                        insert = RetornaUpdate(fieldList, cliente, "Cliente", "[Código]", cliente.codigo)
                        insert = insert.Replace("codigo", "[Código]")
                        insert = insert.Replace("nomecliente", "[nome cliente]")
                        insert = insert.Replace("codprofissao", "[Cód Profissao]")
                        insert = insert.Replace("codcidade", "[Cod Cidade]")
                        insert = insert.Replace("codvendedor", "[Cód Vendedor]")
                        insert = insert.Replace("responsavel", "[Responsável]")
                        insert = insert.Replace("conjuge", "[Conjugê]")
                        insert = insert.Replace("[Código]pgto", "[CódigoPgto]")

                        comando = New OleDbCommand(insert, dados)
                        Dim numerodelinhas = comando.ExecuteNonQuery()
                        comando = New OleDbCommand("SELECT TOP 1 * from Cliente WHERE [Código] = " & cliente.codigo & "  order by [Código] desc", dados)
                        da = New OleDbDataAdapter(comando)
                        da.Fill(ds, "Cliente")

                        comando.Dispose()
                        controleCodigo.CodigoAndroid = cliente.codigo
                        controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Código")

                        ds.Dispose()
                        ds = Nothing
                        da.Dispose()
                        da = Nothing
                        dados.Close()
                    Else
                        cliente.codprofissao = 1
                        insert = RetornaInsert(fieldList, cliente, "Cliente")
                        insert = insert.Replace("codigo", "[Código]")
                        insert = insert.Replace("nomecliente", "[nome cliente]")
                        insert = insert.Replace("codprofissao", "[Cód Profissao]")
                        insert = insert.Replace("codcidade", "[Cod Cidade]")
                        insert = insert.Replace("codvendedor", "[Cód Vendedor]")
                        insert = insert.Replace("responsavel", "[Responsável]")
                        insert = insert.Replace("conjuge", "[Conjugê]")
                        insert = insert.Replace("[Código]pgto", "[CódigoPgto]")

                        comando = New OleDbCommand(insert, dados)
                        Dim numerodelinhas = comando.ExecuteNonQuery()
                        ds.Dispose()
                        ds = Nothing
                        da.Dispose()
                        da = Nothing
                        dados.Close()
                        dados.Open()
                        ds = New DataSet
                        comando = New OleDbCommand("SELECT TOP 1 * from ClienteAndroid order by [Código] desc", dados)
                        da = New OleDbDataAdapter(comando)
                        da.Fill(ds, "ClienteAndroid")

                        comando.Dispose()
                        controleCodigo.CodigoAndroid = cliente.codigo
                        controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Código")

                        ds.Dispose()
                        ds = Nothing
                        da.Dispose()
                        da = Nothing
                        dados.Close()
                    End If
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

        ' PUT: api/Cliente/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Cliente/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace