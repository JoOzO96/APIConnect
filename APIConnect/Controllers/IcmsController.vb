Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class IcmsController
        Inherits ApiController

        ' GET: api/Icms
        Public Function GetValues() As List(Of Icms)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from ICMS", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "ICMS")

            Dim icms As New Icms
            Dim fieldList() = icms.GetType().GetProperties
            Dim nomeCampo As String

            Dim _icms As New List(Of Icms)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                icms = New Icms
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
                    If (nomeCampo.Equals("codicms")) Then
                        nomeCampo = "Cód Icms"
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                        icms = colocaDadosObjeto(icms, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                        'fieldList(j).SetValue(cliente, ds.Tables(0).Rows(i)(nomeCampo))
                    End If
                Next
                _icms.Add(icms)
                icms = Nothing
            Next

            dados.Close()
            dados = Nothing
            fieldList = Nothing
            Return _icms
            _icms = Nothing

        End Function

        ' GET: api/Icms/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Icms
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Icms/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Icms/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace