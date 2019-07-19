Imports System.Net
Imports System.Web.Http
Imports System.Data.OleDb

Namespace Controllers
    Public Class ProdutoController
        Inherits ApiController

        ' GET: api/Produto
        Public Function GetValues() As List(Of Produto)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from Produto WHERE inativo = false", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Produto")

            Dim produto As New Produto
            Dim fieldList() = produto.GetType().GetProperties
            Dim nomeCampo As String

            Dim _produto As New List(Of Produto)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                produto = New Produto
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
                    If (nomeCampo.Equals("codproduto")) Then
                        nomeCampo = "Cod Produto"
                    ElseIf (nomeCampo.Equals("codfornecedor")) Then
                        nomeCampo = "Cod Fornecedor"
                    ElseIf (nomeCampo.Equals("valorcompra")) Then
                        nomeCampo = "Valor Compra"
                    ElseIf (nomeCampo.Equals("valoravista")) Then
                        nomeCampo = "Valor Avista"
                    ElseIf (nomeCampo.Equals("valorprazo")) Then
                        nomeCampo = "Valor Prazo"
                    ElseIf (nomeCampo.Equals("codgrupo")) Then
                        nomeCampo = "Cod Grupo"
                    ElseIf (nomeCampo.Equals("codicms")) Then
                        nomeCampo = "Cod Icms"
                    ElseIf (nomeCampo.Equals("dificms")) Then
                        nomeCampo = "Dif ICMS"
                    ElseIf (nomeCampo.Equals("perprazo")) Then
                        nomeCampo = "Per Prazo"
                    ElseIf (nomeCampo.Equals("codpis")) Then
                        nomeCampo = "códPIS"
                    ElseIf (nomeCampo.Equals("codcofins")) Then
                        nomeCampo = "CódCOFINS"
                    ElseIf (nomeCampo.Equals("codcofinse")) Then
                        nomeCampo = "códCOFINSE"
                    ElseIf (nomeCampo.Equals("codipi")) Then
                        nomeCampo = "CódIPI"
                    ElseIf (nomeCampo.Equals("carencia")) Then
                        nomeCampo = "carência"
                    ElseIf (nomeCampo.Equals("aplicacao")) Then
                        nomeCampo = "Aplicação"
                    ElseIf (nomeCampo.Equals("concentracao")) Then
                        nomeCampo = "Concentração"
                    ElseIf (nomeCampo.Equals("formulacao")) Then
                        nomeCampo = "Formulação"
                    ElseIf (nomeCampo.Equals("comentario")) Then
                        nomeCampo = "Comentário"
                    ElseIf (nomeCampo.Equals("codsubgrupo")) Then
                        nomeCampo = "CódSubGrupo"
                    ElseIf (nomeCampo.Equals("maximo")) Then
                        nomeCampo = "máximo"
                    ElseIf (nomeCampo.Equals("codpise")) Then
                        nomeCampo = "CódPisE"
                    ElseIf (nomeCampo.Equals("codipise")) Then
                        nomeCampo = "CódIPISE"
                    ElseIf (nomeCampo.Equals("comissao")) Then
                        nomeCampo = "Comissão"
                    ElseIf (nomeCampo.Equals("maquina")) Then
                        nomeCampo = "máquina"
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                        produto = colocaDadosObjeto(produto, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                    End If
                Next
                _produto.Add(produto)
                produto = Nothing
            Next

            dados.Close()
            dados = Nothing
            fieldList = Nothing

            Return _produto
            _produto = Nothing

        End Function

        ' GET: api/Produto/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Produto
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Produto/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Produto/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace