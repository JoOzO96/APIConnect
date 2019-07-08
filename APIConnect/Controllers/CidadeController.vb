Imports System.Net
Imports System.Web.Http
Imports System.Data.OleDb

Namespace Controllers
    Public Class CidadeController
        Inherits ApiController

        ' GET: api/Cidade
        Public Function GetValues() As List(Of Cidade)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from Cidade", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Cidade")

            Dim cidade As New Cidade
            Dim fieldList() = cidade.GetType().GetProperties
            Dim nomeCampo As String

            Dim _cidade As New List(Of Cidade)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                cidade = New Cidade
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
                    If (nomeCampo.Equals("codcidade")) Then
                        nomeCampo = "Cód Cidade"
                    ElseIf (nomeCampo.Equals("nomecidade")) Then
                        nomeCampo = "Nome Cidade"
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                        cidade = colocaDadosObjeto(cidade, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                        'fieldList(j).SetValue(cliente, ds.Tables(0).Rows(i)(nomeCampo))
                    End If
                Next
                _cidade.Add(cidade)
                cidade = Nothing
            Next

            dados.Close()
            dados = Nothing
            fieldList = Nothing
            Return _cidade
            _cidade = Nothing

        End Function

        ' GET: api/Cidade/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Cidade
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Cidade/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Cidade/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace