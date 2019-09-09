Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class EmiteConfiguraController
        Inherits ApiController

        ' GET: api/EmiteConfigura
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/EmiteConfigura/5
        Public Function GetValue(ByVal id As Integer) As EmiteConfigura
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from EmiteConfigura Where CodEmitente = " & id, dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "EmiteConfigura")

            Dim emiteConfigura As New EmiteConfigura
            Dim fieldList() = emiteConfigura.GetType().GetProperties
            Dim nomeCampo As String


            For i = 0 To ds.Tables(0).Rows.Count - 1
                emiteConfigura = New EmiteConfigura
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower

                    Try
                        If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                            emiteConfigura = colocaDadosObjeto(emiteConfigura, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                        End If
                    Catch ex As Exception

                    End Try

                Next
            Next

            dados.Close()

            Return emiteConfigura
        End Function

        ' POST: api/EmiteConfigura
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/EmiteConfigura/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/EmiteConfigura/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace