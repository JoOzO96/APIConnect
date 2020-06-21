Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class NotaFiscalController
        Inherits ApiController

        ' GET: api/NotaFiscal
        Public Function GetValues() As ControleCodigo
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from [Nota Fiscal] order by [Cód Nota] desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Nota Fiscal")
            Dim controlecodigo = New ControleCodigo

            controlecodigo.CodigoAndroid = 0
            If (ds.Tables(0).Rows.Count = 0) Then
                controlecodigo.CodigoBanco = 0
            Else
                controlecodigo.CodigoBanco = ds.Tables(0).Rows(0)("Cód Nota")
            End If

            controlecodigo.Mensagem = "Ultima nota no banco"
            Return controlecodigo
        End Function

        ' GET: api/NotaFiscal/5
        Public Function GetValue(ByVal id As Integer) As String


            Return ""
        End Function

        ' POST: api/NotaFiscal
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim json = value.ToString
            Dim listaNota As List(Of NotaFiscal)
            Dim nota As New NotaFiscal
            Dim controleCodigo As ControleCodigo
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = nota.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from [Nota Fiscal] order by [Cód Nota] desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Nota Fiscal")

            Try
                listaNota = JsonConvert.DeserializeObject(Of List(Of NotaFiscal))(json)
                For i = 0 To listaNota.Count - 1
                    nota = listaNota(i)
                    da = Nothing
                    ds = Nothing
                    comando = New OleDbCommand("SELECT * from [Nota Fiscal] where [Cód Nota] = '" & nota.codnota & "' and Codemitente = " & nota.codemitente & " order by [Cód Nota] desc", dados)
                    da = New OleDbDataAdapter(comando)
                    ds = New DataSet
                    da.Fill(ds, "Nota Fiscal")
                    Dim dtv As DataView = ds.Tables(0).DefaultView
                    dtv.RowFilter = " [Cód Nota] = '" + nota.Codnota + "' and Codemitente = " & nota.Codemitente
                    If (dtv.Count > 0) Then
                        controleCodigo = New ControleCodigo
                        If (ds.Tables(0).Rows(0)("Protocolo").Equals("") Or IsDBNull(ds.Tables(0).Rows(0)("Protocolo"))) Then

                            nota.codtransportador() = 1
                            insert = RetornaUpdate(fieldList, nota, "[Nota Fiscal]", "[Cód Nota]", "'" & nota.codnota & "'")
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
                            insert = insert.Replace("codvendedor", "[Cód Vendedor]")
                            insert = insert.Replace("simnao", "[Sim/Não]")

                            comando = New OleDbCommand(insert, dados)
                            Dim numerodelinhas = comando.ExecuteNonQuery()
                            controleCodigo.CodigoAndroid = nota.codnota
                            controleCodigo.CodigoBanco = nota.codnota
                            controleCodigo.Mensagem = "NF-e atualizada, tentando novo envio."
                        Else
                            controleCodigo.CodigoAndroid = 0
                            controleCodigo.CodigoBanco = 0
                            controleCodigo.Mensagem = "Nota já enviada, não e possível realizar alterações. Protocolo : " & ds.Tables(0).Rows(0)("Protocolo")
                        End If
                    Else
                        controleCodigo = New ControleCodigo
                        'nota = New NotaFiscal

                        insert = RetornaInsert(fieldList, nota, "[Nota Fiscal]")
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
                        comando = New OleDbCommand("SELECT TOP 1 * from [Nota Fiscal] order by [Cód nota] desc", dados)
                        da = New OleDbDataAdapter(comando)
                        da.Fill(ds, "Nota Fiscal")

                        comando.Dispose()
                        controleCodigo.CodigoAndroid = nota.Codnota
                        controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Cód Nota")
                        controleCodigo.Mensagem = "NF-e atualizada, tentando novo envio."
                        ds.Dispose()
                        ds = Nothing
                        da.Dispose()
                        da = Nothing
                    End If
                    listcontrolecodigo.Add(controleCodigo)
                Next
                dados.Close()
                System.Threading.Thread.Sleep(1000)
                Return listcontrolecodigo
            Catch ex As Exception
                dados.Close()
                controleCodigo = New ControleCodigo
                Dim sql As String
                sql = "SELECT * from [Nota Fiscal] where [Cód Nota] = '" & nota.Codnota & "' and Codemitente = " & nota.Codemitente & " order by [Cód Nota] desc"
                controleCodigo.Mensagem = ex.Message & " - " & sql
                listcontrolecodigo.Add(controleCodigo)
                Return listcontrolecodigo
            End Try



        End Function

        ' PUT: api/NotaFiscal/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/NotaFiscal/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace