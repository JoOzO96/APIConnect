Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class NfeController
        Inherits ApiController

        ' GET: api/Nfe
        Public Function GetValues() As String
            Return GeraXmlNfe()
        End Function

        ' GET: api/Nfe/5
        Public Function GetValue(ByVal id As Integer) As String
            'Return GeraTagIde()
        End Function

        ' POST: api/Nfe
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Nfe/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Nfe/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace