Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports System.Xml
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
            Dim xmlAssinado As New XmlDocument
            Dim json = value.ToString
            Dim notaFiscal As NotaFiscal
            Dim xml As String
            Dim controle As New ControleCodigo
            Dim retornoValidacao As String
            Dim retornoEnvio As String
            Dim insert As String
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            notaFiscal = JsonConvert.DeserializeObject(Of NotaFiscal)(json)
            Dim fieldList = notaFiscal.GetType().GetProperties().ToList

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from [Nota Fiscal] WHERE [CÓD NOTA] = '" & notaFiscal.Codnota & "' and CODEMITENTE = " & notaFiscal.Codemitente, dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Nota Fiscal")

            If ds.Tables(0).Rows(0)("Protocolo") = "" Or IsDBNull(ds.Tables(0).Rows(0)("Protocolo")) Then
                xml = GeraXmlNfe(notaFiscal.codnota, notaFiscal.codemitente)
                retornoValidacao = ValidaNFE(xml)

                If retornoValidacao = "1" Then

                    retornoEnvio = EnviaNFE(xml)

                    If (RetornaValorNodoXML(retornoEnvio, "cStat", "protNFe", "infProt") = "100") Then

                        xmlAssinado.LoadXml(retornoEnvio)

                        notaFiscal.chave = RetornaValorNodoXML(xmlAssinado.InnerXml, "chNFe", "protNFe", "infProt")
                        notaFiscal.recibo = "SINCRONO"
                        notaFiscal.protocolo = RetornaValorNodoXML(xmlAssinado.InnerXml, "nProt", "protNFe", "infProt")

                        insert = RetornaUpdate(fieldList, notaFiscal, "[Nota Fiscal]", "[Cód Nota]", "'" & notaFiscal.codnota & "'")
                        insert = insert.Replace("codnota", "[Cód Nota]")
                        insert = insert.Replace("codtipo", "[Cód Tipo]")
                        insert = insert.Replace("codcliente", "[Cód Cliente]")
                        insert = insert.Replace("nomecliente", "[Nome Cliente]")
                        insert = insert.Replace("endereco", "[Endereço]")
                        insert = insert.Replace("codcidade", "[Cód Cidade]")
                        insert = insert.Replace("fonefax", "[Fone/Fax]")
                        insert = insert.Replace("inscesta", "[Insc Esta]")
                        insert = insert.Replace("saida", "[Saída]")
                        insert = insert.Replace("dataemissao", "[Data emissão]")
                        insert = insert.Replace("data[Saída]", "[Data Saída]")
                        insert = insert.Replace("codinstituicao", "[Cód Instituição]")
                        insert = insert.Replace("praca", "[Praça]")
                        insert = insert.Replace("baseicms", "[Base ICMS]")
                        insert = insert.Replace("valoricms", "[Valor ICMS]")
                        insert = insert.Replace("icmssub", "[ICMS Sub]")
                        insert = insert.Replace("[Valor ICMS]sub", "[Valor ICMS Sub]")
                        insert = insert.Replace("valordosprodutos", "[Valor dos Produtos]")
                        insert = insert.Replace("valorseguro", "[Valor Seguro]")
                        insert = insert.Replace("valordoipi", "[Valor do IPI]")
                        insert = insert.Replace("codtransportador", "[Cód Transportador]")
                        insert = insert.Replace("valorfrete", "[Valor Frete]")
                        insert = insert.Replace("valornota", "[Valor Nota]")
                        insert = insert.Replace("observacao", "[Observação]")
                        insert = insert.Replace("pesobruto", "[Peso Bruto]")
                        insert = insert.Replace("pesoliquido", "[Peso Líquido]")
                        insert = insert.Replace("especie", "[Espécie]")
                        insert = insert.Replace("numero", "[Número]")
                        insert = insert.Replace("codvendedor", "[Cód Vendedor]")
                        insert = insert.Replace("simnao", "[Sim/Não]")

                        comando = New OleDbCommand(insert, dados)
                        Dim numerodelinhas = comando.ExecuteNonQuery()

                        controle.CodigoAndroid = 0
                        controle.CodigoBanco = 0
                        controle.Mensagem = JsonConvert.SerializeObject(notaFiscal)

                    Else
                        If (retornoEnvio = Nothing) Then
                            controle.CodigoAndroid = 0
                            controle.CodigoBanco = 0
                            controle.Mensagem = "Erro não especificado"
                        Else
                            controle.CodigoAndroid = 0
                            controle.CodigoBanco = 0
                            controle.Mensagem = retornoEnvio
                        End If
                    End If
                Else

                    controle.CodigoAndroid = 0
                    controle.CodigoBanco = 0
                    controle.Mensagem = retornoValidacao
                End If
            Else
                controle.CodigoAndroid = 0
                controle.CodigoBanco = 0
                controle.Mensagem = "100 - Autorizado o uso da NF-e"
            End If

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