Imports System.Net
Imports System.Web.Http
Imports System.Data.OleDb

Namespace Controllers
    Public Class MacController
        Inherits ApiController

        ' GET: api/Mac
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Mac/5
        Public Function GetValue(ByVal id As String) As String
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from ListaMac Where Mac = '" & id & "'", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "ListaMac")


            If (ds.Tables(0).Rows.Count > 0) Then
                Return ds.Tables(0).Rows(0)("ip")
            Else
                comando = New OleDbCommand("INSERT INTO MAC(MAC) VALUES ('" & id & "')", dados)
                comando.ExecuteNonQuery()

                Return Nothing
            End If

        End Function

        ' POST: api/Mac
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Mac/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Mac/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace