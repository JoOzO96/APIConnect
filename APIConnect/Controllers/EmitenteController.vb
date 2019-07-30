Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class EmitenteController
        Inherits ApiController

        ' GET: api/Emitente
        Public Function GetValues() As Emitente
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from Emitente", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Emitente")

            Dim emitente As New Emitente
            Dim fieldList() = emitente.GetType().GetProperties
            Dim nomeCampo As String


            For i = 0 To ds.Tables(0).Rows.Count - 1
                emitente = New Emitente
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
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
                        emitente = colocaDadosObjeto(emitente, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                        'fieldList(j).SetValue(cliente, ds.Tables(0).Rows(i)(nomeCampo))
                    End If
                Next
            Next

            dados.Close()

            Return emitente

        End Function

        ' GET: api/Emitente/5
        Public Function GetValue(ByVal id As Integer) As String

        End Function

        ' POST: api/Emitente
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Emitente/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Emitente/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace