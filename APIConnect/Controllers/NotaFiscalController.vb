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
                    'da = Nothing
                    'ds = Nothing
                    'comando = New OleDbCommand("SELECT * from [Nota Fiscal] where [Cód Nota] = '" & nota.Codnota & "' and Codemitente = " & nota.Codemitente & " order by [Cód Nota] desc", dados)
                    'da = New OleDbDataAdapter(comando)
                    'da.Fill(ds, "Nota Fiscal")
                    Dim dtv As DataView = ds.Tables(0).DefaultView
                    dtv.RowFilter = " [Cód Nota] = '" + nota.Codnota + "' and Codemitente = " & nota.Codemitente
                    If (dtv.Count > 0) Then
                        controleCodigo = New ControleCodigo
                        If (ds.Tables(0).Rows(0)("Protocolo").Equals("")) Then

                            nota.Codtransportador() = 1
                            insert = RetornaUpdate(fieldList, nota, "[Nota Fiscal]", "[Cód Nota]", "'" & nota.Codnota & "'")
                            insert = insert.Replace("Codnota", "[Cód Nota]")
                            insert = insert.Replace("Codtipo", "[Cód Tipo]")
                            insert = insert.Replace("Codcliente", "[Cód Cliente]")
                            insert = insert.Replace("Nomecliente", "[Nome Cliente]")
                            insert = insert.Replace("Endereco", "[Endereço]")
                            insert = insert.Replace("Codcidade", "[Cód Cidade]")
                            insert = insert.Replace("Fonefax", "[Fone/Fax]")
                            insert = insert.Replace("Inscesta", "[Insc Esta]")
                            insert = insert.Replace("Saida", "[Saída]")
                            insert = insert.Replace("Dataemissao", "[Data emissão]")
                            insert = insert.Replace("Datasaida", "[Data Saída]")
                            insert = insert.Replace("Codinstituicao", "[Cód Instituição]")
                            insert = insert.Replace("Praca", "[Praça]")
                            insert = insert.Replace("Baseicms", "[Base ICMS]")
                            insert = insert.Replace("Valoricms", "[Valor ICMS]")
                            insert = insert.Replace("Icmssub", "[ICMS Sub]")
                            insert = insert.Replace("[Valor ICMS]sub", "[Valor ICMS Sub]")
                            insert = insert.Replace("Valordosprodutos", "[Valor dos Produtos]")
                            insert = insert.Replace("Valorseguro", "[Valor Seguro]")
                            insert = insert.Replace("Valordoipi", "[Valor do IPI]")
                            insert = insert.Replace("Codtransportador", "[Cód Transportador]")
                            insert = insert.Replace("Valorfrete", "[Valor Frete]")
                            insert = insert.Replace("Valornota", "[Valor Nota]")
                            insert = insert.Replace("Observacao", "[Observação]")
                            insert = insert.Replace("Pesobruto", "[Peso Bruto]")
                            insert = insert.Replace("Pesoliquido", "[Peso Líquido]")
                            insert = insert.Replace("Especie", "[Espécie]")
                            insert = insert.Replace("Numero", "[Número]")
                            insert = insert.Replace("Codvendedor", "[Cód Vendedor]")
                            insert = insert.Replace("Simnao", "[Sim/Não]")
                            comando = New OleDbCommand(insert, dados)
                            Dim numerodelinhas = comando.ExecuteNonQuery()
                            controleCodigo.CodigoAndroid = nota.Codnota
                            controleCodigo.CodigoBanco = nota.Codnota
                            controleCodigo.Mensagem = "NF-e atualizada, tentando novo envio."
                        Else
                            controleCodigo.CodigoAndroid = 0
                            controleCodigo.CodigoBanco = 0
                            controleCodigo.Mensagem = "Nota já enviada, não e possível realizar alterações."
                        End If
                    Else
                        controleCodigo = New ControleCodigo
                        'nota = New NotaFiscal

                        nota.Codtipo = 1
                        nota.Codtransportador() = 1
                        insert = RetornaInsert(fieldList, nota, "[Nota Fiscal]")
                        insert = insert.Replace("Codnota", "[Cód Nota]")
                        insert = insert.Replace("Codtipo", "[Cód Tipo]")
                        insert = insert.Replace("Codcliente", "[Cód Cliente]")
                        insert = insert.Replace("Nomecliente", "[Nome Cliente]")
                        insert = insert.Replace("Endereco", "[Endereço]")
                        insert = insert.Replace("Codcidade", "[Cód Cidade]")
                        insert = insert.Replace("Fonefax", "[Fone/Fax]")
                        insert = insert.Replace("Inscesta", "[Insc Esta]")
                        insert = insert.Replace("Saida", "[Saída]")
                        insert = insert.Replace("Dataemissao", "[Data emissão]")
                        insert = insert.Replace("Datasaida", "[Data Saída]")
                        insert = insert.Replace("Codinstituicao", "[Cód Instituição]")
                        insert = insert.Replace("Praca", "[Praça]")
                        insert = insert.Replace("Baseicms", "[Base ICMS]")
                        insert = insert.Replace("Valoricms", "[Valor ICMS]")
                        insert = insert.Replace("Icmssub", "[ICMS Sub]")
                        insert = insert.Replace("[Valor ICMS]sub", "[Valor ICMS Sub]")
                        insert = insert.Replace("Valordosprodutos", "[Valor dos Produtos]")
                        insert = insert.Replace("Valorseguro", "[Valor Seguro]")
                        insert = insert.Replace("Valordoipi", "[Valor do IPI]")
                        insert = insert.Replace("Codtransportador", "[Cód Transportador]")
                        insert = insert.Replace("Valorfrete", "[Valor Frete]")
                        insert = insert.Replace("Valornota", "[Valor Nota]")
                        insert = insert.Replace("Observacao", "[Observação]")
                        insert = insert.Replace("Pesobruto", "[Peso Bruto]")
                        insert = insert.Replace("Pesoliquido", "[Peso Líquido]")
                        insert = insert.Replace("Especie", "[Espécie]")
                        insert = insert.Replace("Numero", "[Número]")
                        insert = insert.Replace("Codvendedor", "[Cód Vendedor]")
                        insert = insert.Replace("Simnao", "[Sim/Não]")

                        comando = New OleDbCommand(insert, dados)
                        Dim numerodelinhas = comando.ExecuteNonQuery()
                        comando = New OleDbCommand("SELECT TOP 1 * from [Nota Fiscal] order by [Cód nota] desc", dados)
                        da = New OleDbDataAdapter(comando)
                        da.Fill(ds, "Nota Fiscal")

                        comando.Dispose()
                        controleCodigo.CodigoAndroid = nota.Codnota
                        controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("Cód Nota")

                        ds.Dispose()
                        ds = Nothing
                        da.Dispose()
                        da = Nothing
                    End If
                    listcontrolecodigo.Add(controleCodigo)
                Next
                dados.Close()
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