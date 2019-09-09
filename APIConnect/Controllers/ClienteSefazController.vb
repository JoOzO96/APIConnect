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
            Dim infEnder As XmlNodeList
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
                    infCadastro.ie = RetornaValorNodoXML(objeto.InnerXml, "IE", "")
                    infCadastro.cnpj = RetornaValorNodoXML(objeto.InnerXml, "CNPJ", "")
                    infCadastro.uf = RetornaValorNodoXML(objeto.InnerXml, "UF", "")
                    infCadastro.csit = RetornaValorNodoXML(objeto.InnerXml, "cSit", "")
                    infCadastro.indcrednfe = RetornaValorNodoXML(objeto.InnerXml, "indCredNFe", "")
                    infCadastro.indcredcte = RetornaValorNodoXML(objeto.InnerXml, "indCredCTe", "")
                    infCadastro.xnome = RetornaValorNodoXML(objeto.InnerXml, "xNome", "")
                    infCadastro.xfant = RetornaValorNodoXML(objeto.InnerXml, "xFant", "")
                    infCadastro.xregapur = RetornaValorNodoXML(objeto.InnerXml, "xRegApur", "")
                    infCadastro.cnae = RetornaValorNodoXML(objeto.InnerXml, "CNAE", "")
                    infCadastro.diniativ = RetornaValorNodoXML(objeto.InnerXml, "dIniAtiv", "")
                    infEnder = xml.SelectNodes("//ender")
                    infCadastro.xlgr = RetornaValorNodoXML(infEnder.Item(0).InnerXml, "xLgr", "")
                    infCadastro.nro = RetornaValorNodoXML(infEnder.Item(0).InnerXml, "nro", "")
                    infCadastro.xbairro = RetornaValorNodoXML(infEnder.Item(0).InnerXml, "xBairro", "")
                    infCadastro.xcpl = RetornaValorNodoXML(infEnder.Item(0).InnerXml, "xCpl", "")
                    infCadastro.cmun = RetornaValorNodoXML(infEnder.Item(0).InnerXml, "cMun", "")
                    infCadastro.xmun = RetornaValorNodoXML(infEnder.Item(0).InnerXml, "xMun", "")
                    infCadastro.cep = RetornaValorNodoXML(infEnder.Item(0).InnerXml, "CEP", "")
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