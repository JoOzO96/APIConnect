Imports System.Net
Imports System.Web.Http
Imports System.Data.OleDb

Namespace Controllers
    Public Class VendedorController
        Inherits ApiController

        ' GET: api/Vendedor
        Public Function GetValues() As List(Of Vendedor)
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from Vendedor", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Vendedor")

            Dim vendedor As New Vendedor
            Dim fieldList() = vendedor.GetType().GetProperties
            Dim nomeCampo As String

            Dim _vendedor As New List(Of Vendedor)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                vendedor = New Vendedor
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
                    If (nomeCampo.Equals("codvendedor")) Then
                        nomeCampo = "Cód Vendedor"
                    ElseIf (nomeCampo.Equals("nomevendedor")) Then
                        nomeCampo = "Nome Vendedor"
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                        vendedor = colocaDadosObjeto(vendedor, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                    End If
                Next
                _vendedor.Add(vendedor)
                vendedor = Nothing
            Next

            dados.Close()
            dados = Nothing
            fieldList = Nothing
            Return _vendedor
            _vendedor = Nothing
        End Function

        ' GET: api/Vendedor/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Vendedor
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Vendedor/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Vendedor/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace