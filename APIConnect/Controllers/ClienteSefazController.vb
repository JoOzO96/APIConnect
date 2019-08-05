Imports System.Net
Imports System.Web.Http
Imports System.Xml

Namespace Controllers
    Public Class ClienteSefazController
        Inherits ApiController

        ' GET: api/ClienteSefaz
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/ClienteSefaz/5
        Public Function GetValue(ByVal id As String) As List(Of InfCadastro)
            Dim xml As New XmlDocument
            Dim infCad As XmlNodeList
            Dim objeto As XmlNode
            Dim infCadastro As InfCadastro
            Dim listainfCadastro As New List(Of InfCadastro)
            Dim retorno As String
            Dim i As Long

            retorno = ConsultaCNPJ(id)
            retorno = Replace(retorno, "xmlns=" & Chr(34) & "http://www.portalfiscal.inf.br/nfe" & Chr(34), "xmlns:c=" & Chr(34) & "http://www.portalfiscal.inf.br/nfe" & Chr(34))

            If InStr(retorno, "retConsCad") Then
                SalvaArquivo(1, Now(), "SEFAZ", retorno, id & ".xml")
                xml.LoadXml(retorno)

                infCad = xml.SelectNodes("//infCad")

                    For Each objeto In infCad

                        infCadastro = New InfCadastro
                        infCadastro.Ie = RetornaValorNodoXML(objeto.InnerXml, "IE", "")
                        infCadastro.Cnpj = RetornaValorNodoXML(objeto.InnerXml, "CNPJ", "")
                        infCadastro.Uf = RetornaValorNodoXML(objeto.InnerXml, "UF", "")
                        infCadastro.Csit = RetornaValorNodoXML(objeto.InnerXml, "cSit", "")
                        infCadastro.Indcrednfe = RetornaValorNodoXML(objeto.InnerXml, "indCredNFe", "")
                        infCadastro.Indcredcte = RetornaValorNodoXML(objeto.InnerXml, "indCredCTe", "")
                        infCadastro.Xnome = RetornaValorNodoXML(objeto.InnerXml, "xNome", "")
                        infCadastro.Xfant = RetornaValorNodoXML(objeto.InnerXml, "xFant", "")
                        infCadastro.Xregapur = RetornaValorNodoXML(objeto.InnerXml, "xRegApur", "")
                        infCadastro.Cnae = RetornaValorNodoXML(objeto.InnerXml, "CNAE", "")
                        infCadastro.Diniativ = RetornaValorNodoXML(objeto.InnerXml, "dIniAtiv", "")
                        infCadastro.Xlgr = RetornaValorNodoXML(objeto.InnerXml, "Xlgr", "ender")
                        infCadastro.Nro = RetornaValorNodoXML(objeto.InnerXml, "Nro", "ender")
                        infCadastro.Xbairro = RetornaValorNodoXML(objeto.InnerXml, "Xbairro", "ender")
                        infCadastro.Xcpl = RetornaValorNodoXML(objeto.InnerXml, "Xcpl", "ender")
                        infCadastro.Cmun = RetornaValorNodoXML(objeto.InnerXml, "Cmun", "ender")
                        infCadastro.Xmun = RetornaValorNodoXML(objeto.InnerXml, "Xmun", "ender")
                        infCadastro.Cep = RetornaValorNodoXML(objeto.InnerXml, "Cep", "ender")


                        listainfCadastro.Add(infCadastro)
                    Next


                    Return listainfCadastro
                Else
                    infCadastro = New InfCadastro
                    infCadastro.erro = retorno
                    listainfCadastro.Add(infCadastro)
                    Return listainfCadastro
                End If
        End Function

        ' POST: api/ClienteSefaz
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/ClienteSefaz/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/ClienteSefaz/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace