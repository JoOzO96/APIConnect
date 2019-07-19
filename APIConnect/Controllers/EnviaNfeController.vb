Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class EnviaNfeController
        Inherits ApiController

        ' GET: api/EnviaNfe
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/EnviaNfe/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/EnviaNfe
        Public Function PostValue(<FromBody()> ByVal value As Object) As ControleCodigo

            Dim json = value.ToString
            Dim notaFiscal As NotaFiscal
            Dim xml As String
            Dim controle As New ControleCodigo
            notaFiscal = JsonConvert.DeserializeObject(Of NotaFiscal)(json)


            xml = GeraXmlNfe(notaFiscal.Codnota, notaFiscal.Codemitente)
            controle.CodigoAndroid = 0
            controle.CodigoBanco = 0
            controle.Mensagem = xml

            Return controle



        End Function

        ' PUT: api/EnviaNfe/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/EnviaNfe/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace