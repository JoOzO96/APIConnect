Imports System.Net
Imports System.Web.Http
Imports System.Xml
Imports Newtonsoft.Json

Namespace Controllers
    Public Class EnviaEmailController
        Inherits ApiController

        ' GET: api/EnviaEmail
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/EnviaEmail/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/EnviaEmail
        Public Function PostValue(<FromBody()> ByVal value As Object) As String
            If value.ToString <> Nothing Then

                Dim json = value.ToString
                Dim dadosenvio As New DadosEnvio
                Dim textoEnvio As String
                Dim emitente As Emitente
                Dim cont As Long
                Dim eMailRemetente As String
                Dim nomeRemetente As String
                Dim eMailDestinatario As String
                Dim assunto As String
                Dim mensagem As String
                Dim arquivo As String
                Dim smtpCliente As String
                Dim smtpPorta As String
                Dim smtpSSL As String
                Dim smtpUsuario As String
                Dim smtpSenha As String
                Dim html As String
                Dim confirmacao As String
                Dim msgResultado As String
                Dim cResultado As Long
                Dim enviado As Boolean
                Dim pdf As String
                Dim xmlCaminho As String
                dadosenvio = JsonConvert.DeserializeObject(Of DadosEnvio)(json)
                emitente = RetornaEmitente(1)
                cont = 0
                eMailRemetente = "cfs@xmax.com.br" 'emitente.emailemi
                nomeRemetente = emitente.fantasia
                eMailDestinatario = dadosenvio.emaildestinatario
                assunto = dadosenvio.assunto
                mensagem = dadosenvio.mensagem
                arquivo = dadosenvio.arquivo
                smtpCliente = "mail.xmax.com.br" 'emitente.server
                smtpPorta = "587" 'emitente.porta
                smtpSSL = "1" 'emitente.autenticacao
                smtpUsuario = "cfs@xmax.com.br" 'emitente.usuario
                smtpSenha = "cfs60479282" 'emitente.senha
                html = "0"
                confirmacao = "1"
                msgResultado = ""
                cResultado = 0
                enviado = False
                pdf = Split(arquivo, ";")(1)
                xmlCaminho = Split(arquivo, ";")(0)
                If dadosenvio.tipodocumento = "NFE" Then


                    Dim objAssembly As Reflection.Assembly
                    Dim objTemp As New Object
                    Dim xml As New XmlDocument
                    xml.Load(xmlCaminho)
                    objAssembly = objAssembly.LoadFrom(GetInstallDirectory("NFe_Util_2G.dll"))
                    objTemp = objAssembly.CreateInstance("NFe_Util_2G.Util", True)
                    objTemp.geraPdfDANFE(xml.InnerXml, "", "S", "S", "N", "", "L", "[ARQUIVO=" + pdf + "]", msgResultado)
                    cResultado = objTemp.EnvEmail(eMailRemetente, nomeRemetente, eMailDestinatario, "", assunto, mensagem, arquivo, smtpCliente, smtpPorta, smtpSSL, smtpUsuario, smtpSenha, html, confirmacao, msgResultado)
                    Return cResultado & "-" & msgResultado
                End If
            End If
        End Function

        ' PUT: api/EnviaEmail/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/EnviaEmail/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace