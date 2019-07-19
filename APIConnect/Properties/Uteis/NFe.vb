Imports System.Data.OleDb

Module NFe
    Public Function ConsultaCNPJ(cnpj As String) As String
        Dim conexao As New OleDbConnection
        Dim comando As New OleDbCommand
        Dim ds As New DataSet
        Dim dsEmitente As New DataSet
        Dim nfe As Object
        Dim objAssembly As Reflection.Assembly
        Dim objTemp As New Object

        objAssembly = objAssembly.LoadFrom(GetInstallDirectory("NFe_Util_2G.dll"))
        objTemp = objAssembly.CreateInstance("NFe_Util_2G.Util", True)

        Dim msgDados As String
        Dim msgRetWS As String
        Dim msgResultado As String
        Dim siglaUF As String
        Dim nomeCertificado As String
        Dim cResultado As Long
        Dim proxy As String
        Dim usuario As String
        Dim senha As String
        Dim tipoAmbiente As Integer
        Dim versao As String
        proxy = ""
        usuario = ""
        senha = ""
        msgDados = ""
        msgRetWS = ""
        msgResultado = ""
        Dim tpArgumento As String
        Dim argumento As String

        conexao.ConnectionString = RetornaConexao()
        conexao.Open()
        comando = New OleDbCommand("SELECT * FROM EMITENTE", conexao)
        Dim da As New OleDbDataAdapter(comando)
        da.Fill(ds, "Emitente")


        nomeCertificado = ds.Tables(0).Rows(0)("CertiEmi")
        siglaUF = ds.Tables(0).Rows(0)("UF")
        tipoAmbiente = ds.Tables(0).Rows(0)("Hambiente")
        versao = "4.00"
        If cnpj.Length = 14 Then
            tpArgumento = "1"
        Else
            tpArgumento = "2"
        End If
        argumento = cnpj

        cResultado = objTemp.ConsultaCad2G(siglaUF, tipoAmbiente, nomeCertificado, versao, msgDados, msgRetWS, msgResultado, tpArgumento, argumento, proxy, usuario, senha)
        If cResultado = "111" Or cResultado = "112" Then
            Return msgRetWS
        Else
            Return msgResultado
        End If

    End Function

    Public Function GeraXmlNfe(codnota As String, codemitente As String) As String
        Dim nfe As New NFe_Util_2G.Util
        Dim conexao As New OleDbConnection
        Dim comando As New OleDbCommand
        Dim ds As New DataSet
        Dim dsEmitente As New DataSet
        Dim dsDesti As New DataSet
        Dim dsIcms As New DataSet
        Dim dsCest As New DataSet
        Dim dsTabelaIcms As New DataSet
        Dim imposto As String
        Dim Detalhes As String
        Dim TotISSQN As String
        codemitente = 1

        Dim xmlnfe As String
        Dim versao As String
        versao = "0.0.1b"
        'dados do identificador
        Dim ide As String
        Dim ide_cUF As String
        Dim ide_cNF As String
        Dim ide_natOp As String
        Dim ide_indPag As Long
        Dim ide_mode As Long
        Dim ide_serie As Long
        Dim ide_nNF As Long
        Dim ide_dEmi As String
        Dim ide_dSaiEnt As String
        Dim ide_tpNF As Long
        Dim ide_cMunFG As String
        Dim ide_tpImp As Long
        Dim ide_cDV As Long
        Dim ide_tpAmb As Long
        Dim ide_finNFe As Long
        Dim ide_tpEmis As Long
        Dim ide_procEmi As Long
        Dim ide_verProc As String
        Dim ide_NFrefS As String
        Dim ide_hSaiEnt As String
        Dim ide_dhCont As String
        Dim ide_xJust As String
        Dim indPres As String
        Dim idDest As String

        'dados emitente
        Dim emi As String
        Dim emi_CPF As String
        Dim emi_xNome As String
        Dim emi_xFant As String
        Dim emi_xLgr As String
        Dim emi_nro As String
        Dim emi_xCpl As String
        Dim emi_xBairro As String
        Dim emi_cMun As String
        Dim emi_xMun As String
        Dim emi_UF As String
        Dim emi_CEP As String
        Dim emi_cPais As String
        Dim emi_xPais As String
        Dim emi_fone As String
        Dim emi_IE As String
        Dim emi_IEST As String
        Dim emi_IM As String
        Dim emi_CNAE As String
        Dim emi_CRT As String

        'dados destinatario
        Dim dest As String
        Dim dest_CNPJ As String = ""
        Dim dest_CPF As String = ""
        Dim dest_xNome As String = ""
        Dim dest_xFant As String
        Dim dest_xLgr As String
        Dim dest_nro As String
        Dim dest_xCpl As String
        Dim dest_xBairro As String
        Dim dest_cMun As String
        Dim dest_xMun As String
        Dim dest_UF As String
        Dim dest_CEP As String
        Dim dest_cPais As String
        Dim dest_xPais As String
        Dim dest_fone As String
        Dim dest_IE As String
        Dim dest_IESUF As String
        Dim dest_eMail As String
        Dim idEstrangeiro As String = ""
        Dim im As String
        Dim indIEDest As String
        Dim indFinal As Integer

        'dados dos produtos
        Dim prod As String
        Dim Prod_cProd As String
        Dim Prod_cEAN As String
        Dim Prod_xProd As String
        Dim Prod_NCM As String
        Dim Prod_ExTIPI As String
        Dim Prod_genero As Long
        Dim Prod_CFOP As Long
        Dim Prod_uCOM As String
        Dim Prod_qCom As Double
        Dim Prod_vUnCom As Double
        Dim Prod_vProd As Double
        Dim Prod_cEANTrib As String
        Dim Prod_uTrib As String
        Dim Prod_qTrib As Double
        Dim Prod_vUnTrib As Double
        Dim Prod_vFrete As Double
        Dim Prod_vSeguro As Double
        Dim Prod_DI As String
        Dim Prod_vDesc As Double
        Dim Prod_DetEspecifico As String
        Dim Prod_infAdProd As String
        Dim Prod_vOutro As Double
        Dim Prod_VtotTrib As Double
        Dim Prod_indTot As Integer
        Dim Prod_xPed As String
        Dim Prod_nItemPed As Integer
        Dim pDevol_Opc As Double
        Dim vIPIDevol_Opc As Double
        Dim NVE_Opc As String
        Dim detExport_Opc As String
        Dim nFCI_Opc As String
        Dim CodCEST As String
        Dim Prod_DetEstpecifico As String

        'dados do ICMS
        Dim icms As String
        Dim ICMS_orig As String
        Dim ICMS_CST As String
        Dim ICMS_modBC As Long
        Dim ICMS_pRedBC As Double
        Dim ICMS_vBC As Double
        Dim ICMS_pICMS As Double
        Dim ICMS_vICMS As Double
        Dim ICMS_modBCST As Long
        Dim ICMS_pMVAST As Double
        Dim ICMS_pRedBCST As Double
        Dim icms_BCST As Double
        Dim ICMS_pICMSST As Double
        Dim ICMS_vICMSST As Double
        Dim ICMS_vBCSTRet As Double
        Dim ICMS_vICMSSRet As Double
        Dim icms_vbcsrdest As Double
        Dim ICMS_vICMSSTDest As Double
        Dim ICMS_motDesICMS As Integer
        Dim ICMS_pBCOp As Double
        Dim ICMS_UFST As String
        Dim ICMS_pCredSN As Double
        Dim icms_vTotTrib As Double
        Dim ICMS_vCredICMSSN As Double
        Dim icms_vbcst As Double
        Dim vICMSDeson As Double
        Dim vICMSOp As Double
        Dim pDif As Double
        Dim vICMSDif As Double
        Dim ICMS_vBCFCP As Double
        Dim ICMS_pFCP As Double
        Dim ICMS_vFCP As Double
        Dim ICMS_vBCFCPST As Double
        Dim ICMS_pFCPST As Double
        Dim ICMS_vFCPST As Double
        Dim ICMS_vBCFCPSTRet As Double
        Dim ICMS_pFCPSTRet As Double
        Dim ICMS_vFCPSTRet As Double
        Dim ICMS_pST As Double
        Dim ICMSUFDest As String
        Dim ICMS_vBCSTDest As Double
        Dim ICMS_vICMSOp As Double
        Dim ICMS_pDif As Double
        Dim ICMS_vICMSDif As Double
        Dim Porice As Single
        Dim ValorDesti As Double
        Dim ValorOrigem As Double
        Dim ICMS_vICMSDeson As Double

        'dados do PIS
        Dim pis As String
        Dim pis_AliqProd As String
        Dim pis_CST As String
        Dim pis_vBC As Double
        Dim pis_pPIS As Double
        Dim pis_vPIS As Double
        Dim pis_qBCProd As Double
        Dim pis_vAliqProd As Double
        Dim pisst As String
        Dim pisst_vBC As Double
        Dim pisst_pPIS As Double
        Dim pisst_qBCProd As Double
        Dim pisst_vAliqProd As Double
        Dim pisst_vPIS As Double


        'dados do COFINS
        Dim cofins As String
        Dim cofins_CST As String
        Dim cofins_vBC As Double
        Dim cofins_pCOFINS As Double
        Dim cofins_vCOFINS As Double
        Dim cofins_qBCProd As Double
        Dim cofins_vAliqProd As Double
        Dim cofinsst_vBC As Double
        Dim cofinsst_pPIS As Double
        Dim cofinsst_qBCProd As Double
        Dim cofinsst_vAliqProd As Double
        Dim cofinsst_vPIS As Double
        Dim cofinsst As String
        Dim cofins_vPIS As String
        Dim cofins_pPIS As String
        Dim cofinsst_pCOFINS As String
        Dim cofinsst_vCOFINS As String
        Dim cofins_AliqProd As String

        'dados do IPI


        Dim ipi As String
        Dim ipi_clEnq As String
        Dim ipi_CNPJProd As String
        Dim ipi_cSelo As String
        Dim ipi_qSelo As Double
        Dim ipi_cEnq As String
        Dim ipi_CST As String
        Dim ipi_vBC As Double
        Dim ipi_pIPI As Double
        Dim ipi_qUnid As Double
        Dim ipi_vUnid As Double
        Dim ipi_vIPI As Double

        'dados do ISSQN
        Dim issqn As String
        Dim issqn_vBC As Double
        Dim issqn_vAliq As Double
        Dim issqn_vISSQN As Double
        Dim totICMS_vISSQN As Double
        Dim totICMS_vISSQNBC As Double
        Dim vDeducao_Opc As Double
        Dim vOutro_Opc As Double
        Dim vDescIncond_Opc As Double
        Dim vDescCond_Opc As Double
        Dim vISSRet_Opc As Double
        Dim indISS As Integer
        Dim cServico_Opc As String
        Dim cMun_Opc As String
        Dim cPais_Opc As String
        Dim nProcesso_Opc As String
        Dim indIncentivo As Integer
        Dim issqn_cMunFG As String
        Dim issqn_cListServ As String
        Dim issqn_cSitTrib As String

        'totais da nota
        Dim Total As String
        Dim totICMS As String
        Dim totICMS_vBC As Double
        Dim totICMS_vICMS As Double
        Dim totICMS_vBCST As Double
        Dim totICMS_vST As Double
        Dim totICMS_vProd As Double
        Dim totICMS_vFrete As Double
        Dim totICMS_vSeg As Double
        Dim totICMS_vDesc As Double
        Dim totICMS_vII As Double
        Dim totICMS_vIPI As Double
        Dim totICMS_vPIS As Double
        Dim totICMS_vCOFINS As Double
        Dim totICMS_vOutro As Double
        Dim totICMS_vNF As Double
        Dim totICMS_vTotTrib As Double
        Dim totICMS_vICMSUFDest As Double
        Dim totICMS_vICMSUFRemet As Double
        Dim totICMS_vFCPUFDest As Double
        Dim totalICMS_vFCP As Double
        Dim totalICMS_vFCPST As Double
        Dim totalICMS_vFCPUSTRet As Double
        Dim totalICMS_vIPIDevol As Double
        Dim vTotTrib As Double
        Dim vFCP As Double
        Dim vFCPST As Double
        Dim vFCPSTRet As Double
        Dim vIPIDevol As Double

        'dados do EFETIVO

        Dim efet As String
        Dim efet_orig As String
        Dim efet_cst As String
        Dim efet_vBCSTRet As Double
        Dim efet_pST As Double
        Dim efet_vICMSSbustituto As Double
        Dim efet_vICMSSTRet As Double
        Dim efet_vBCFCPSTRet As Double
        Dim efet_pFCPSTRet As Double
        Dim efet_vFCPSTRet As Double
        Dim efet_pRedBCEfet As Double
        Dim efet_vBCEfet As Double
        Dim efet_pICMSEfet As Double
        Dim efet_vICMSEfet As Double
        Dim efet_vBCSTDest As Double
        Dim efet_vICMSSTDest As Double

        ' dados do pagamento
        Dim cobr As String
        Dim pagto As String
        Dim dup As String
        Dim dup_nDup As String
        Dim dup_vDup As String
        Dim dup_dVenc As String
        Dim cobr_nfat As String
        Dim cobr_vOrig As Double
        Dim cobr_vDesc As Double
        Dim cobr_vLiq As Double
        Dim pagto_tPag As String
        Dim pagto_vPag As Double
        Dim pagto_CNPJ_Opc As String
        Dim pagto_tBand_Opc As String = ""
        Dim pagto_cAut_Opc As String = ""
        Dim nDup As Long
        Dim valorParcelasCalculado As Double
        Dim valorDiferenca As Double

        'dados responsavel tecnico
        Dim resp_cnpj As String
        Dim resp_xContato As String
        Dim resp_email As String
        Dim resp_fone As String
        Dim resp_idCSRT As String = ""
        Dim resp_CSRT As String = ""
        Dim resp_chaveNFe As String = ""
        Dim responsavelTecnico As String


        Dim DetPag As String, indPag As String, tpIntegra_Opc As String, vTroco As Double, MeioPag As String

        conexao.ConnectionString = RetornaConexao()
        conexao.Open()
        comando = New OleDbCommand("SELECT [Nota Fiscal].[Cód Nota], [Nota Fiscal].CodEmitente, [Nota Fiscal].[Cód Tipo], [Tipo Natureza].[Natureza Operação] AS Natu, [Nota Fiscal].[Data emissão] AS Datae, " &
                                   "[Nota Fiscal].[Data Saída] AS DataS, [Nota Fiscal].Saída, [Tipo Natureza].Pagamento, [Nota Fiscal].NorConti, [Nota Fiscal].Hora, [Nota Fiscal].NotaRef, [Nota Fiscal].ChaveRef, " &
                                   "Left([codmuni],2) AS codUF, Left([CodNacionalCIDADE],2) AS CodUFDEs, [Nota Fiscal].BaseImpo, [Nota Fiscal].DesAduaneira, [Nota Fiscal].ValoImpor, [Nota Fiscal].ValorIOF, " &
                                   "[Nota Fiscal].Finalidade, [Tipo Natureza].OcultarTributos, [Nota Fiscal].CCOCupom, [Nota Fiscal].codpgto, Pgto.MeioPgtoNFe, [Nota Fiscal].ConsumidorFinal, " &
                                   "Emitente.CodMuni, Emitente.Serie, Emitente.CNPJEmi " &
                                   "FROM Emitente INNER JOIN (Pgto INNER JOIN ([Tipo Natureza] INNER JOIN (Cidade INNER JOIN [Nota Fiscal] ON Cidade.[Cód Cidade] = [Nota Fiscal].[Cód Cidade]) ON " &
                                   "[Tipo Natureza].[Cód Tipo] = [Nota Fiscal].[Cód Tipo]) ON Pgto.Código = [Nota Fiscal].CodPgto) ON Emitente.CodigoEmitente = [Nota Fiscal].CodEmitente WHERE [CÓD NOTA] = '" & codnota &
                                   "' ORDER BY [Nota Fiscal].[Cód Nota]", conexao)
        Dim da As New OleDbDataAdapter(comando)
        da.Fill(ds, "Emitente")

        'indFinal = ds.Tables(0).Rows(0)("ConsumidorFinal")

        ide_cUF = ds.Tables(0).Rows(0)("CodUF")        ' código da UF - tabela do IBGE: 35 - SP, 43 - RS, etc. (vide página 141 do manual)
        ide_natOp = Left(ds.Tables(0).Rows(0)("natu"), 40)        ' naturez da operação
        ide_indPag = ds.Tables(0).Rows(0)("Pagamento")        ' 0=pagamento à vista, 1=prazo, 2=outros
        ide_mode = 55        ' modelo da nota fiscal eletronica
        ide_serie = CInt(ds.Tables(0).Rows(0)("Serie"))        ' série única = 0
        ide_nNF = codnota        ' número da NF-e
        ide_dEmi = Format(ds.Tables(0).Rows(0)("Datae"), "yyyy-mm-dd") & "T" & Format(ds.Tables(0).Rows(0)("Hora"), "HH:MM:ss") & PegaTimeZone()        'Gide![dataE]         ' data de emissão

        If IsDBNull(ds.Tables(0).Rows(0)("Datas")) Then
            ide_dSaiEnt = ""        'Dat2  'Gide![dataE]         ' data de emissão
        Else
            ide_dSaiEnt = Format(ds.Tables(0).Rows(0)("Datas"), "yyyy-mm-dd") & "T" & Format(ds.Tables(0).Rows(0)("Hora"), "HH:MM:ss") & PegaTimeZone()    'Gide![dataE]         ' data de emissão
        End If

        ide_tpNF = ds.Tables(0).Rows(0)("saída")        ' 0= entrada, 1 = saída

        If IsDBNull(ds.Tables(0).Rows(0)("Hora")) Then

        Else
            ide_hSaiEnt = ds.Tables(0).Rows(0)("Hora")
        End If
        ide_cMunFG = 4320909        ' código do município do IBGE de ocorrência do FG do ICMS (vide página 141 do manual)
        ide_tpImp = 1        ' orientação da impressão 1-retrato/2-paisagem
        ide_tpAmb = 2        ' ambiente de envio da NF-e 1-produção / 2 - homologação

        If IsDBNull(ds.Tables(0).Rows(0)("CodUFDEs")) Or ds.Tables(0).Rows(0)("CodUFDEs") = "" Then
            idDest = 1
        Else
            If ds.Tables(0).Rows(0)("CodUFDEs") = Left(ds.Tables(0).Rows(0)("CodMuni"), 2) Then
                idDest = 1
            Else
                idDest = 2
            End If
            If ide_cUF = "EX" Then
                idDest = 3
            End If
        End If
        'OPERCAO PRESENCIAL

        indPres = 1
        ide_finNFe = ds.Tables(0).Rows(0)("Finalidade")
        ide_finNFe = 1


        ide_tpEmis = ds.Tables(0).Rows(0)("NorConti")        ' forma de emissão da NF-e 1- normal, 2 - contingência FS, 3 - contingência SCAN, etc.
        ide_procEmi = 0        ' identificação do processo de emissão da NF-e 0 - aplicação do contribuinte
        ide_verProc = "NFe_Util_2G"        ' identificação da vesão do processo de emissão
        ide_NFrefS = ""        ' incializar variável

        If ide_tpEmis = 1 Then
            ide_xJust = ""
        Else
            ide_dhCont = ds.Tables(0).Rows(0)("Datae")        ' data e hora de entrada em contingência - informar quanto tpEmis diferente de 1
            ide_xJust = "FALTA DE CONEXAO DE INTERNET"
        End If


        Dim cUF, Ano, mes, Modelo, Serie, numero, tpEmis, codigoseguranca As String
        Dim msgResul As String
        Dim cNF As String
        Dim cDV As String
        Dim chaveNfe As String = ""
        Dim emi_cnpj As String
        emi_cnpj = ds.Tables(0).Rows(0)("cnpjemi")
        cUF = Trim(Str(ide_cUF))
        Ano = Format(ds.Tables(0).Rows(0)("Datae"), "yy")
        mes = Format(Month(ds.Tables(0).Rows(0)("Datae")), "00")
        Modelo = Trim(Str(ide_mode))
        Serie = Trim(Str(ide_serie))
        numero = Trim(Str(ide_nNF))
        tpEmis = Trim(Str(ide_tpEmis))
        msgResul = ""
        codigoseguranca = "CONNECT"
        cNF = ""
        cDV = ""

        nfe.CriaChaveNFe2G(cUF, Ano, mes, emi_cnpj, Modelo, Serie, numero, tpEmis, codigoseguranca, msgResul, cNF, cDV, chaveNfe)

        ide_cNF = Val(cNF)        ' código numérico que compõe a chave de acesso
        ide_cDV = Val(cDV)        ' DV da chave de acesso da NF-e


        ide = nfe.identificador400(ide_cUF, ide_cNF, ide_natOp, ide_mode, ide_serie, ide_nNF, ide_dEmi, ide_dSaiEnt, ide_tpNF, idDest, ide_cMunFG, ide_NFrefS, ide_tpImp, ide_tpEmis, ide_cDV, ide_tpAmb, ide_finNFe, 0, indPres, ide_procEmi, ide_verProc, ide_dhCont, ide_xJust)


        comando = New OleDbCommand("SELECT *FROM Emitente WHERE CodigoEmitente = " & codemitente, conexao)
        da = New OleDbDataAdapter(comando)
        dsEmitente = New DataSet
        da.Fill(dsEmitente, "Emitente")
        emi_cnpj = dsEmitente.Tables(0).Rows(0)("CNPJEmi")
        If IsDBNull(dsEmitente.Tables(0).Rows(0)("CPFEmi")) Then
            emi_CPF = ""        'Emit![CPFEmi]                             ' CPF do emitente, uso exclusivo do Fisco
        Else
            emi_CPF = dsEmitente.Tables(0).Rows(0)("CPFEmi")        ' CPF do emitente, uso exclusivo do Fisco
        End If
        emi_xNome = dsEmitente.Tables(0).Rows(0)("Emitente")        ' Razão social do emitente, evitar caracteres acentuados e &
        emi_xFant = dsEmitente.Tables(0).Rows(0)("Fantasia")        ' Nome fantasia
        emi_xLgr = dsEmitente.Tables(0).Rows(0)("Endereco")        ' logradouro
        If IsDBNull(dsEmitente.Tables(0).Rows(0)("numero")) Or dsEmitente.Tables(0).Rows(0)("numero") = "" Then
            emi_nro = "S/N"
        Else
            emi_nro = dsEmitente.Tables(0).Rows(0)("numero")        ' número, informar S/N quano inexistente para erro de Schema XML
        End If
        emi_xCpl = dsEmitente.Tables(0).Rows(0)("complemento")        ' complemento do endereço, o conteúdo pode ser omitido
        If IsDBNull(dsEmitente.Tables(0).Rows(0)("Bairro")) Or dsEmitente.Tables(0).Rows(0)("Bairro") = "" Then
            emi_xBairro = ""        'Emit![IESUB]                          ' Inscrição Estadual do ST
        Else
            emi_xBairro = dsEmitente.Tables(0).Rows(0)("Bairro")
        End If        ' bairro
        emi_cMun = dsEmitente.Tables(0).Rows(0)("CodMuni")        ' código do município (vide página 141 do manual), deve ser compatível com a UF
        emi_xMun = dsEmitente.Tables(0).Rows(0)("Municipio")        ' nome do município
        emi_UF = dsEmitente.Tables(0).Rows(0)("Uf")        ' sigla da UF
        emi_CEP = dsEmitente.Tables(0).Rows(0)("CEP")        ' CEP - sem máscara
        emi_cPais = dsEmitente.Tables(0).Rows(0)("CodPais")        ' código do pais - deve fixo em 1058 - Brasil
        emi_xPais = dsEmitente.Tables(0).Rows(0)("Pais")        ' nome do pais (Brasil ou BRASIL)
        If IsDBNull(dsEmitente.Tables(0).Rows(0)("fone")) Or dsEmitente.Tables(0).Rows(0)("fone") = "" Then
            emi_fone = ""
        Else
            emi_fone = dsEmitente.Tables(0).Rows(0)("fone")        ' número do telefone sem máscara
        End If
        emi_IE = dsEmitente.Tables(0).Rows(0)("IEEmi")        ' Inscrição Estadual do emitente sem máscara
        If IsDBNull(dsEmitente.Tables(0).Rows(0)("IESUB")) Then
            emi_IEST = ""        'Emit![IESUB]                          ' Inscrição Estadual do ST
        Else
            emi_IEST = dsEmitente.Tables(0).Rows(0)("IESUB")
        End If
        If IsDBNull(dsEmitente.Tables(0).Rows(0)("IMEmi")) Then
            emi_IM = ""        'Emit![IMEmi") Then                            ' Inscrição Municipal
        Else
            emi_IM = dsEmitente.Tables(0).Rows(0)("IMEmi")
        End If
        If IsDBNull(dsEmitente.Tables(0).Rows(0)("CNAEemi")) Then
            emi_CNAE = ""        'Emit![IMEmi")                            ' Código do CNAE
        Else
            emi_CNAE = dsEmitente.Tables(0).Rows(0)("CNAEemi")
        End If
        emi_CRT = dsEmitente.Tables(0).Rows(0)("Tributa")        ' Código do CRT: 1-Simples Nacional;
        '                2-Simples Nacional - excesso de sublimite de receita bruta;
        '                3 - Regime Normal.

        '       gera grupo emi
        '
        emi = nfe.emitente2G(emi_cnpj, emi_CPF, emi_xNome, emi_xFant, emi_xLgr, emi_nro, emi_xCpl, emi_xBairro, emi_cMun, emi_xMun, emi_UF, emi_CEP, emi_cPais, emi_xPais, emi_fone, emi_IE, emi_IEST, emi_IM, emi_CNAE, emi_CRT)

        comando = New OleDbCommand("SELECT [Nota Fiscal].[Cód Nota], [Nota Fiscal].CodEmitente, [Nota Fiscal].[Nome Cliente] AS Nome1, [Nota Fiscal].[Nome Cliente] AS Fantasia, " &
                                   "[Nota Fiscal].Endereço, [Nota Fiscal].nUMERO AS NUme, [Nota Fiscal].CNPJ AS CGC, [Nota Fiscal].[Insc Esta] AS INSC, [Nota Fiscal].Bairro, " &
                                   "[Nota Fiscal].Observação AS Complemento, [Nota Fiscal].[Fone/Fax] AS Fone, '' AS SuFrama, Cidade.CodNacionalUf, Cidade.Uf, Cidade.CodNacionalCidade, " &
                                   "Cidade.[Nome Cidade] AS NomeCidade, Cidade.Pais, Cidade.CodNacionalPais, [Nota Fiscal].CEP, [Nota Fiscal].CPF, [Nota Fiscal].[Valor do IPI] AS VIPI, " &
                                   "[Nota Fiscal].Despesas AS VDesp, [Nota Fiscal].[Valor Seguro] AS VSeg, [Nota Fiscal].[Valor Frete] AS VFrete, [Nota Fiscal].Desconto AS VDesc, " &
                                   "[Nota Fiscal].[ICMS Sub] AS TSub, [Nota Fiscal].[Valor ICMS Sub] AS VSub, Cliente.Email, [Nota Fiscal].ISSQN, [Nota Fiscal].VISSQN, [Nota Fiscal].Valorfun, " &
                                   "Cliente.OcultaCEST FROM Cliente RIGHT JOIN (Cidade INNER JOIN [Nota Fiscal] ON Cidade.[Cód Cidade] = [Nota Fiscal].[Cód Cidade]) ON Cliente.Código = " &
                                   "[Nota Fiscal].[Cód Cliente] WHERE [CÓD NOTA] = '" & codnota & "'", conexao)
        da = New OleDbDataAdapter(comando)
        dsDesti = New DataSet
        da.Fill(dsDesti, "Cliente")


        If 1 = 2 Then
            dest_xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"        ' Razão social do destinatario, evitar caracteres acentuados e &
            dest_CNPJ = "99999999000191"
            dest_IE = ""
            dest_CPF = ""
            indIEDest = "9"
        Else
            If dsDesti.Tables(0).Rows(0)("Uf") = "EX" Then
                dest_CPF = ""
                dest_CNPJ = ""        ' CNPJ do destinatario sem máscara de formatação
            Else
                If IsDBNull(dsDesti.Tables(0).Rows(0)("CGC")) Then
                    dest_CPF = dsDesti.Tables(0).Rows(0)("CPF")
                Else
                    dest_CNPJ = dsDesti.Tables(0).Rows(0)("CGC")        ' CNPJ do destinatario sem máscara de formatação
                End If
            End If

            indIEDest = "9"
            dest_xNome = dsDesti.Tables(0).Rows(0)("Nome1")        ' Razão social do destinatario, evitar caracteres acentuados e &
            dest_xNome = Replace(dest_xNome, "&", "E")

            If IsDBNull(dsDesti.Tables(0).Rows(0)("INSC")) Or UCase(dsDesti.Tables(0).Rows(0)("INSC").ToString) = "" Then
                dest_IE = ""
                indIEDest = "9"
            Else
                If UCase(dsDesti.Tables(0).Rows(0)("INSC")) = "ISENTO" Then
                    'If Desti![Uf") <> "RS" Then
                    indIEDest = "2"
                Else
                    dest_IE = UCase(dsDesti.Tables(0).Rows(0)("INSC"))        ' Inscrição Estadual do destinatario sem máscara
                    dest_IE = Replace(dest_IE, "-", "")
                    dest_IE = Replace(dest_IE, "/", "")
                    dest_IE = Replace(dest_IE, " ", "")
                    dest_IE = Replace(dest_IE, ".", "")
                    'dest_IE = Replace(dest_IE, "ISENTO", "")
                    dest_IE = Replace(dest_IE, "ISENTA", "")
                    indIEDest = "1"
                End If
            End If
        End If
        dest_xFant = dsDesti.Tables(0).Rows(0)("Fantasia")        ' Nome fantasia
        dest_xLgr = dsDesti.Tables(0).Rows(0)("Endereço")        ' logradouro
        If IsDBNull(dsDesti.Tables(0).Rows(0)("Nume")) Then
            dest_nro = "S/N"        'dsDesti.Tables(0).Rows(0)("Complemento")           ' complemento do endereço, o conteúdo pode ser omitido
        Else
            dest_nro = dsDesti.Tables(0).Rows(0)("Nume")        ' número, informar S/N quano inexistente para erro de Schema XML
        End If
        If IsDBNull(dsDesti.Tables(0).Rows(0)("complemento")) Then
            dest_xCpl = ""        'dsDesti.Tables(0).Rows(0)("Complemento")           ' complemento do endereço, o conteúdo pode ser omitido
        Else
            dest_xCpl = ""        'dsDesti.Tables(0).Rows(0)("Complemento")
        End If
        If IsDBNull(dsDesti.Tables(0).Rows(0)("Bairro")) Or dsDesti.Tables(0).Rows(0)("Bairro") = "" Then
            dest_xBairro = "Centro"
        Else
            dest_xBairro = dsDesti.Tables(0).Rows(0)("Bairro")        ' bairro                    ' CEP - sem máscara
        End If
        dest_cMun = dsDesti.Tables(0).Rows(0)("CodNacionalCidade")        ' código do município (vide página 141 do manual), deve ser compatível com a UF
        dest_xMun = dsDesti.Tables(0).Rows(0)("NomeCidade")        ' nome do município
        dest_UF = dsDesti.Tables(0).Rows(0)("Uf")        ' sigla da UF
        If IsDBNull(dsDesti.Tables(0).Rows(0)("CEP")) Then
            dest_CEP = ""
        Else
            dest_CEP = dsDesti.Tables(0).Rows(0)("CEP")        ' CEP - sem máscara
        End If
        dest_cPais = dsDesti.Tables(0).Rows(0)("CodNacionalPais")        ' código do pais - deve fixo em 1058 - Brasil
        dest_xPais = dsDesti.Tables(0).Rows(0)("Pais")        ' nome do pais (Brasil ou BRASIL)
        If IsDBNull(dsDesti.Tables(0).Rows(0)("fone")) Or dsDesti.Tables(0).Rows(0)("fone") = "" Then
            dest_fone = ""
        Else
            dest_fone = dsDesti.Tables(0).Rows(0)("fone")        ' número do telefone sem máscara
            dest_fone = Replace(dest_fone, "-", "")
            dest_fone = Replace(dest_fone, "/", "")
            dest_fone = Replace(dest_fone, " ", "")
        End If

        If IsDBNull(dsDesti.Tables(0).Rows(0)("suframa")) Then
            dest_IESUF = ""        'dsDesti.Tables(0).Rows(0)("suframa")              ' Inscrição SUFRAMA
        Else
            dest_IESUF = dsDesti.Tables(0).Rows(0)("suframa")
        End If
        If IsDBNull(dsDesti.Tables(0).Rows(0)("Email")) Then
            dest_eMail = ""
        Else
            dest_eMail = dsDesti.Tables(0).Rows(0)("Email")        ' e-mail do destinatário
        End If

        dest = nfe.destinatario310(dest_CNPJ, dest_CPF, idEstrangeiro, dest_xNome, dest_xLgr, dest_nro, dest_xCpl, dest_xBairro, dest_cMun, dest_xMun, dest_UF, dest_CEP, dest_cPais, dest_xPais, dest_fone, indIEDest, dest_IE, dest_IESUF, im, dest_eMail)


        Prod_vSeguro = 0
        totICMS_vBC = 0
        totICMS_vICMS = 0
        totICMS_vBCST = 0
        totICMS_vST = 0
        totICMS_vProd = 0
        totICMS_vFrete = 0
        totICMS_vSeg = 0
        totICMS_vDesc = 0
        totICMS_vII = 0
        totICMS_vIPI = 0
        totICMS_vPIS = 0
        totICMS_vCOFINS = 0
        totICMS_vOutro = 0
        totICMS_vTotTrib = 0
        totICMS_vISSQN = 0
        vTotTrib = 0
        totICMS_vNF = 0
        totICMS_vISSQNBC = 0
        totICMS_vICMSUFDest = 0
        totICMS_vICMSUFRemet = 0
        totICMS_vFCPUFDest = 0
        totalICMS_vFCP = 0
        totalICMS_vFCPST = 0
        totalICMS_vFCPUSTRet = 0
        totalICMS_vIPIDevol = 0

        comando = New OleDbCommand("SELECT [Nota Produto].[Cód Nota], [Nota Produto].Auto, [Nota Produto].CodEmitente, Produto.[Cod Produto] AS [Cód Produto], " &
                                   "[Nota Produto].descri AS Descricao, Produto.Unid, [Nota Produto].Quantidade, Right([Sst],2) AS CST, Produto.Origem, Produto.EAN, " &
                                   "Produto.NCM, '00' AS GEne, Produto.InfAdicionais AS Infade1, Produto.InfEspecifica AS DESP1, [Nota Produto].[Valor Unitário], " &
                                   "[Nota Produto].[Valor Total], [Nota Produto].[Aliq ICMS], [Nota Produto].VICMS AS ICMS, [Nota Produto].CFOP, [Nota Produto].MvaP, " &
                                   "[Nota Produto].[Valor Nota], [Nota Produto].BICMS, [Nota Produto].VBCST, [Nota Produto].VSST, [Nota Produto].DescoPro, [Nota Produto].VSeguro, " &
                                   "[Nota Produto].Voutros, [Nota Produto].CódIPI, [Nota Produto].[Valor IPI] AS VIPI, [Nota Produto].[Aliq IPI] AS AIPI, Produto.Redu, " &
                                   "[Nota Produto].CódPIS, Produto.CSTPIS, [Nota Produto].PORPIS, Produto.VPIS, [Nota Produto].CódCOFINS, Produto.CSTCOFINS, " &
                                   "[Nota Produto].PORCOFINS, Produto.VCOFINS, [Nota Produto].Vfrete, Produto.ANP, [TotalTribPro]+[TotalTribEst] AS Vimpo, [Nota Produto].SST, " &
                                   "Produto.[Cod Icms], ICMS.Percen, Produto.CodCEST, Produto.DescANP, Produto.QuantidadeConversao, Produto.UniTributacao, Produto.GlP, Produto.GlPN, " &
                                   "Produto.GlPNi, Produto.vBCSTRet, Produto.pST, Produto.vICMSSTRet, Produto.vBCFCPSTRet, Produto.pFCPSTRet, Produto.pRedBCEfet, Produto.vBCEfet, " &
                                   "Produto.pICMSEfet, Produto.vICMSEfet FROM (ICMS INNER JOIN Produto ON ICMS.[Cód ICMS] = Produto.[Cod Icms]) INNER JOIN [Nota Produto] ON " &
                                   "Produto.[Cod Produto] = [Nota Produto].código WHERE [CÓD NOTA] = '" & codnota & "' ORDER BY [Nota Produto].[Cód Nota], [Nota Produto].Auto", conexao)
        da = New OleDbDataAdapter(comando)
        dsIcms = New DataSet
        da.Fill(dsIcms, "ICMS")

        For i = 0 To dsIcms.Tables(0).Rows.Count - 1

            Prod_cProd = dsIcms.Tables(0).Rows(0)("Cód Produto")        ' código do produto
            If IsDBNull(dsIcms.Tables(0).Rows(0)("EAN")) Then
                Prod_cEAN = "SEM GTIN"
            Else
                If Left(dsIcms.Tables(0).Rows(0)("EAN"), 2) <> "10" Then
                    Prod_cEAN = dsIcms.Tables(0).Rows(0)("EAN")        ' código EAN (0, 8,12, 13 ou 14 caracteres), o conteúdo pode ser omitido se não tiver EAN
                Else
                    Prod_cEAN = "SEM GTIN"
                End If
            End If
                Prod_xProd = Left(dsIcms.Tables(0).Rows(0)("Descricao"), 110)       ' código do produto, espaços em branco consecutivos ou no início ou fim do campo podem gerar erro de Schema XML, além de caracteres reservados do XML <>&"'

            If IsDBNull(dsIcms.Tables(0).Rows(0)("NCM")) Or dsIcms.Tables(0).Rows(0)("NCM") = "00000000" Then
                Prod_NCM = "00000000"
            Else
                Prod_NCM = dsIcms.Tables(0).Rows(0)("NCM")        ' código NCM, pode ser omitido se não sujeito ao IPI
            End If
            If Not IsDBNull(dsIcms.Tables(0).Rows(0)("CodCEST")) Then
                CodCEST = dsIcms.Tables(0).Rows(0)("CodCEST")
            End If


            If IsDBNull(CodCEST) Or CodCEST = "" Then
                Dim NCMa As String
                NCMa = Prod_NCM
                'Cont = 0
                For j = 8 To 1
                    comando = New OleDbCommand("SELECT *FROM CEST WHERE Left([NCM]," & j & ") = '" & Left(NCMa, j) & "'", conexao)
                    da.Fill(dsCest, "CEST")
                    If dsCest.Tables(0).Rows.Count > 0 Then
                        CodCEST = dsCest.Tables(0).Rows(0)("cest")
                        Exit For
                    End If
                Next
            End If
            'If dsIcms.Tables(0).Rows(0)("OcultaCEST") = -1 Then
            '    CodCEST = ""
            'End If
            If IsDBNull(dsIcms.Tables(0).Rows(0)("gene")) Then
                Prod_genero = "00"
            Else
                Prod_genero = dsIcms.Tables(0).Rows(0)("gene")       ' informar as duas primeiras posições do NCM
            End If

            Prod_ExTIPI = ""        ' ExTipi, especialização do código NCM, informar apenas se existir
            Prod_CFOP = dsIcms.Tables(0).Rows(0)("CFOP")        ' CFOP do operação, causa erro de XML se informado um código inexistente
            If IsDBNull(dsIcms.Tables(0).Rows(0)("Unid")) Then
                Prod_uCOM = "UN"
            Else
                Prod_uCOM = dsIcms.Tables(0).Rows(0)("Unid")       ' unidade de comercialização
            End If
            Prod_qCom = Format(dsIcms.Tables(0).Rows(0)("Quantidade"), "0.000")
            Prod_vUnCom = Format(dsIcms.Tables(0).Rows(0)("Valor Unitário"), "0.0000")

            If ide_finNFe = 2 Then
                Prod_vProd = Format(dsIcms.Tables(0).Rows(0)("Valor Total"), "0.0000")
            Else
                Prod_vProd = Format((Prod_qCom * Prod_vUnCom), "0.00")        ' valor do total do item
            End If

            If IsDBNull(dsIcms.Tables(0).Rows(0)("EAN")) Then
                Prod_cEANTrib = "SEM GTIN"
            Else
                If dsIcms.Tables(0).Rows(0)("EAN") = "" Or Left(dsIcms.Tables(0).Rows(0)("EAN"), 2) = "10" Then
                    Prod_cEANTrib = "SEM GTIN"
                Else
                    Prod_cEANTrib = dsIcms.Tables(0).Rows(0)("EAN")        ' código EAN (0, 8,12, 13 ou 14 caracteres), o conteúdo pode ser omitido se não tiver EAN, em geral é o mesmo código do EAN de comercialização
                End If
            End If
            If IsDBNull(dsIcms.Tables(0).Rows(0)("UniTributacao")) Then
                If IsDBNull(dsIcms.Tables(0).Rows(0)("Unid")) Or dsIcms.Tables(0).Rows(0)("Unid") = "" Then
                    Prod_uTrib = "UN"
                Else
                    Prod_uTrib = dsIcms.Tables(0).Rows(0)("Unid")
                End If
            Else
                Prod_uTrib = dsIcms.Tables(0).Rows(0)("UniTributacao")       ' unidade de tributação, na maioria dos casos é idêntico  ao vUnCom, pode diferente nos casos de produtos sujeitos a ST em que a unidade de pauta é diferente da unidade de comercialização
            End If        ' Ex. unidade de comercialização = 1 pack de lata de cerveja => unidade de tributação = 1 lata (preço de pauta)


            Prod_qTrib = Format(dsIcms.Tables(0).Rows(0)("Quantidade"), "0.000")
            Prod_vUnTrib = Format(dsIcms.Tables(0).Rows(0)("Valor Unitário"), "0.0000")

            If IsDBNull(dsIcms.Tables(0).Rows(0)("Vfrete")) Then
                Prod_vFrete = 0
            Else
                Prod_vFrete = Format(dsIcms.Tables(0).Rows(0)("Vfrete"), "0.0000")        ' valor do frete, se cobrado do cliente deve ser rateado entre os itens de produto
            End If
            Prod_vSeguro = Format(dsIcms.Tables(0).Rows(0)("VSeguro"), "0.0000")        ' valor do seguro, se cobrado do cliente deve ser rateado entre os itens de produto
            Prod_vDesc = Format(dsIcms.Tables(0).Rows(0)("DescoPro"), "0.00")        ' valor do desconto concedido
            Prod_DI = ""        ' dados da importação, informar apenas no caso de NF de entrada (importação)

            If IsDBNull(dsIcms.Tables(0).Rows(0)("desp1")) Then
                Prod_DetEspecifico = ""
            Else
                Prod_DetEspecifico = dsIcms.Tables(0).Rows(0)("desp1")        ' dados específicos, informar para medicamento, veículos novos, armamentos e combustíveis.
            End If
            If IsDBNull(dsIcms.Tables(0).Rows(0)("infade1")) Then
                Prod_infAdProd = ""
            Else
                Prod_infAdProd = dsIcms.Tables(0).Rows(0)("infade1")        ' informações adicionais do produto
            End If

            Prod_vOutro = Format(dsIcms.Tables(0).Rows(0)("Voutros"), "0.0000")        ' valor de outras despesas
            Prod_indTot = 1        ' indicador se o valor do item será totalizado no valor total dos produtos
            Prod_xPed = ""        ' número do pedido, uso exclusivo do usuário
            Prod_nItemPed = 0        ' número do item do pedido, uso exclusivo do usuário



            NVE_Opc = ""
            detExport_Opc = ""
            nFCI_Opc = ""
            Dim IndEscala As String, CNPJFab As String, CbendF As String, Rastro As String
            IndEscala = ""
            CNPJFab = ""
            CbendF = ""
            Rastro = ""

            '
            '   gera grupo do produto
            '
            prod = ""
            '    prod = objNFeUtil.produto2G(Prod_cProd, Prod_cEAN, Prod_xProd, Prod_NCM, Prod_ExTIPI, Prod_CFOP, Prod_uCOM, Prod_qCom, Prod_vUnCom, Prod_vProd, Prod_cEANTrib, Prod_uTrib, Prod_qTrib, Prod_vUnTrib, Prod_vFrete, Prod_vSeguro, Prod_vDesc, Prod_vOutro, Prod_indTot, Prod_DI, Prod_DetEstpecifico, Prod_xPed, Prod_nItemPed)
            '    Prod = objNFeUtil.produto310(Prod_cProd, Prod_cEAN, Prod_xProd, Prod_NCM, NVE_Opc, Prod_ExTIPI, Prod_CFOP, Prod_uCOM, Prod_qCom, Prod_vUnCom, Prod_vProd, Prod_cEANTrib, Prod_uTrib, Prod_qTrib, Prod_vUnTrib, Prod_vFrete, Prod_vSeguro, Prod_vDesc, Prod_vOutro, Prod_indTot, Prod_DI, detExport_Opc, Prod_DetEstpecifico, Prod_xPed, Prod_nItemPed, nFCI_Opc)

            prod = nfe.produto400(Prod_cProd, Prod_cEAN, Prod_xProd, Prod_NCM, NVE_Opc, CodCEST, IndEscala, CNPJFab, "", Prod_ExTIPI, Prod_CFOP, Prod_uCOM, Prod_qCom, Prod_vUnCom, Prod_vProd, Prod_cEANTrib, Prod_uTrib, Prod_qTrib, Prod_vUnTrib, Prod_vFrete, Prod_vSeguro, Prod_vDesc, Prod_vOutro, Prod_indTot, Prod_DI, detExport_Opc, Prod_DetEstpecifico, Prod_xPed, Prod_nItemPed, nFCI_Opc, Rastro)


            'MsgBox "Grupo de produto " + Prod, vbInformation, "Resultado"
            '
            '
            '=========dados do ICMS (grupo N01 do Manual de integração - páginas 100)=====================
            '

            If emi_CRT = 1 Then
                ICMS_orig = dsIcms.Tables(0).Rows(0)("Origem")
                If dsIcms.Tables(0).Rows(0)("GlP") > 0 Then
                    ICMS_CST = "S60"
                Else
                    ICMS_CST = dsIcms.Tables(0).Rows(0)("SST")
                End If
                ICMS_pCredSN = dsEmitente.Tables(0).Rows(0)("PerApro")
                ICMS_vCredICMSSN = Prod_vProd * ICMS_pCredSN / 100
            Else
                ICMS_orig = dsIcms.Tables(0).Rows(0)("Origem")        ' Tabela A - origem da mercadoria 0=nacional
                If IsDBNull(dsIcms.Tables(0).Rows(0)("SST")) Then
                    ICMS_CST = "60"
                Else
                    If IsDBNull(dsIcms.Tables(0).Rows(0)("GlP")) Then
                        ICMS_CST = Right(dsIcms.Tables(0).Rows(0)("SST"), 2)
                    Else
                        If dsIcms.Tables(0).Rows(0)("GlP") > 0 Then
                            ICMS_CST = "S60"
                        Else
                            ICMS_CST = Right(dsIcms.Tables(0).Rows(0)("SST"), 2)        ' Tabela B - CST=00-tributação normal
                        End If
                    End If
                End If
            End If

            ICMS_modBC = 3        ' modalidade de determinação da BC = 3-valor da operação
            ICMS_pRedBC = dsIcms.Tables(0).Rows(0)("redu")        ' percentual de redução da BC
            If dsIcms.Tables(0).Rows(0)("SST") <> "101" And dsIcms.Tables(0).Rows(0)("SST") <> "201" Then
                ICMS_pCredSN = 0
                ICMS_vCredICMSSN = 0
            End If
            If dsIcms.Tables(0).Rows(0)("BICMS") > 0 And ICMS_pCredSN = 0 Then
                ICMS_vBC = Format(dsIcms.Tables(0).Rows(0)("BICMS"), "0.00")        ' valor da BC do ICMS = vProd + vFrete + vSeguro
            Else
                ICMS_vBC = 0
            End If

            If dsIcms.Tables(0).Rows(0)("ICMS") > 0 Then
                ICMS_pICMS = dsIcms.Tables(0).Rows(0)("Aliq ICMS")        ' alíquota do ICMS
                ICMS_vICMS = Format(dsIcms.Tables(0).Rows(0)("ICMS"), "0.00")        'Format(ICMS_vBC * ICMS_pICMS / 100, "0.00") 'Pro![ICMS]                    ' valor do ICMS
            Else
                ICMS_pICMS = 0        ' alíquota do ICMS
                ICMS_vICMS = 0        ' valor do ICMS
            End If
            If emi_CRT > 1 Then
                ICMS_pICMS = dsIcms.Tables(0).Rows(0)("Aliq ICMS")        ' alíquota do ICMS
                ICMS_vICMS = Format(dsIcms.Tables(0).Rows(0)("ICMS"), "0.00")        'Format(ICMS_vBC * ICMS_pICMS / 100, "0.00") 'dsIcms.Tables(0).Rows(0)("ICMS]                    ' valor do ICMS
            End If
            If dsIcms.Tables(0).Rows(0)("BICMS") = 0 And dsIcms.Tables(0).Rows(0)("ICMS") > 0 Then
                ICMS_vICMS = Format(dsIcms.Tables(0).Rows(0)("ICMS"), "0.00")
            End If
            ICMS_modBCST = 4        ' modalidade de determinação da BC ICMS ST
            If dsIcms.Tables(0).Rows(0)("MvaP") > 0 Then
                ICMS_pMVAST = dsIcms.Tables(0).Rows(0)("MvaP")        ' percentual de valor de margem e valor adicionado
            Else
                ICMS_pMVAST = 0
            End If
            ICMS_pRedBCST = 0        ' percentual de redução da BC do ICMS ST
            If dsIcms.Tables(0).Rows(0)("MvaP") > 0 Then
                icms_vbcst = Format(dsIcms.Tables(0).Rows(0)("VBCST"), "0.00")        ' BC do ICMS ST
            Else
                icms_vbcst = 0
            End If

            ICMS_pICMSST = 0        ' percentual do ICMSST
            If dsIcms.Tables(0).Rows(0)("MvaP") > 0 Then
                ICMS_vICMSST = Format(dsIcms.Tables(0).Rows(0)("VSST"), "0.00")        ' valor do ICMS ST devido
            Else
                ICMS_vICMSST = 0
            End If

            ICMS_vBCSTRet = 0
            ICMS_vICMSSRet = 0
            icms_vbcsrdest = 0
            ICMS_vICMSSTDest = 0
            ICMS_motDesICMS = 0
            ICMS_pBCOp = 0
            ICMS_UFST = ""
            issqn_vBC = 0
            issqn_vAliq = 0
            issqn_vISSQN = 0

            If ds.Tables(0).Rows(0)("OcultarTributos") = -1 Then
                icms_vTotTrib = 0
            Else
                icms_vTotTrib = Format(dsIcms.Tables(0).Rows(0)("vimpo"), "0.00")
            End If
            totICMS_vTotTrib = totICMS_vTotTrib + icms_vTotTrib

            issqn = ""
            icms = ""

            ICMS_vBCFCP = 0
            ICMS_pFCP = 0
            ICMS_vFCP = 0
            ICMS_vBCFCPST = 0
            ICMS_pFCPST = 0
            ICMS_vFCPST = 0
            ICMS_vBCFCPSTRet = 0
            ICMS_pFCPSTRet = 0
            ICMS_vFCPSTRet = 0
            ICMS_pST = 0

            If dsIcms.Tables(0).Rows(0)("Cod Icms") = "06" Then
                issqn_vBC = Format(dsIcms.Tables(0).Rows(0)("Valor Total"), "0.00")
                issqn_vAliq = Format(dsIcms.Tables(0).Rows(0)("Percen"), "0.00")
                issqn_vISSQN = Format((dsIcms.Tables(0).Rows(0)("Valor Total") * dsIcms.Tables(0).Rows(0)("Percen") / 100), "0.00")
                issqn_cMunFG = emi_cMun
                issqn_cListServ = "14.04"
                issqn_cSitTrib = "N"
                indISS = 1
                indIncentivo = 2
                issqn = nfe.ISSQN310(issqn_vBC, issqn_vAliq, issqn_vISSQN, issqn_cMunFG, issqn_cListServ, vDeducao_Opc, vOutro_Opc, vDescIncond_Opc, vDescCond_Opc, vISSRet_Opc, indISS, cServico_Opc, cMun_Opc, cPais_Opc, nProcesso_Opc, indIncentivo)
            Else
                If ICMS_CST = "60" Or ICMS_CST = "500" Then

                    efet_orig = ICMS_orig
                    efet_cst = ICMS_CST
                    If indFinal = 0 Then
                        efet_vBCSTRet = dsIcms.Tables(0).Rows(0)("vBCSTRet") * Prod_qTrib
                        efet_pST = 18
                        efet_vICMSSbustituto = (efet_vBCSTRet * efet_pST) / 100   'ver isso
                        efet_vICMSSTRet = efet_vBCSTRet * efet_pST / 100
                        efet_vBCFCPSTRet = 0
                        efet_pFCPSTRet = 0
                        efet_vFCPSTRet = 0
                        efet_pRedBCEfet = 0
                        efet_vBCEfet = 0
                        efet_pICMSEfet = 0
                        efet_vICMSEfet = 0
                        efet_vBCSTDest = 0
                        efet_vICMSSTDest = 0
                    Else
                        efet_vBCSTRet = 0
                        efet_pST = 0
                        efet_vICMSSbustituto = 0    'ver isso
                        efet_vICMSSTRet = 0
                        efet_vBCFCPSTRet = 0
                        efet_pFCPSTRet = 0
                        efet_vFCPSTRet = 0
                        efet_pRedBCEfet = dsIcms.Tables(0).Rows(0)("pRedBCEfet")
                        efet_vBCEfet = dsIcms.Tables(0).Rows(0)("vBCEfet") * Prod_qTrib
                        efet_pICMSEfet = 18
                        efet_vICMSEfet = efet_vBCEfet * efet_pICMSEfet / 100
                        efet_vBCSTDest = 0
                        efet_vICMSSTDest = 0
                    End If
                    icms = nfe.icmsEfetNT201805(efet_orig, efet_cst, efet_vBCSTRet, efet_pST, efet_vICMSSbustituto, efet_vICMSSTRet, efet_vBCFCPSTRet, efet_pFCPSTRet, efet_vFCPSTRet, efet_pRedBCEfet, efet_vBCEfet, efet_pICMSEfet, efet_vICMSEfet, efet_vBCSTDest, efet_vICMSSTDest)

                Else
                    icms = nfe.icms400(ICMS_orig, ICMS_CST, ICMS_modBC, ICMS_pRedBC, ICMS_vBC, ICMS_pICMS, ICMS_vICMS, ICMS_modBCST, ICMS_pMVAST, ICMS_pRedBCST, icms_vbcst, ICMS_pICMSST, ICMS_vICMSST, ICMS_vBCSTRet, ICMS_vICMSSRet, ICMS_vBCSTDest, ICMS_vICMSSTDest, ICMS_motDesICMS, ICMS_pBCOp, ICMS_UFST, ICMS_pCredSN, ICMS_vCredICMSSN, ICMS_vICMSDeson, ICMS_vICMSOp, ICMS_pDif, ICMS_vICMSDif, ICMS_vBCFCP, ICMS_pFCP, ICMS_vFCP, ICMS_vBCFCPST, ICMS_pFCPST, ICMS_vFCPST, ICMS_vBCFCPSTRet, ICMS_pFCPSTRet, ICMS_vFCPSTRet, ICMS_pST)
                End If
            End If


            'MsgBox "Grupo de Tributos/ICMS " + ICMS, vbInformation, "Resultado"

            '
            '=========dados do PIS (grupo Q do Manual de Integração - páginas 110) =============
            '
            pis = ""
            If Not IsDBNull(dsIcms.Tables(0).Rows(0)("CódPIS")) Then
                pis_CST = dsIcms.Tables(0).Rows(0)("CódPIS")

                pisst_vBC = 0
                pisst_pPIS = 0
                pisst_qBCProd = 0
                pisst_vAliqProd = 0
                pisst_vPIS = 0
                pisst = ""
                If dsIcms.Tables(0).Rows(0)("VPIS") = 0 Then
                    pis_vBC = (dsIcms.Tables(0).Rows(0)("Valor Total") - dsIcms.Tables(0).Rows(0)("DescoPro"))
                    pis_pPIS = dsIcms.Tables(0).Rows(0)("porpis")
                    pis_vPIS = Format((pis_vBC * pis_pPIS) / 100, "0.00")
                Else
                    pis_qBCProd = Prod_qTrib
                    pis_vAliqProd = dsIcms.Tables(0).Rows(0)("VPIS")
                    pis_vPIS = Format(pis_vAliqProd * pis_qBCProd, "0.00")
                End If
                If pis_CST = "05" Then
                    pisst_vBC = Prod_qTrib
                    pisst_pPIS = dsIcms.Tables(0).Rows(0)("VPIS")
                    pisst_qBCProd = 0
                    pisst_vAliqProd = dsIcms.Tables(0).Rows(0)("VPIS")
                    pisst_vPIS = Format(pis_vAliqProd * pis_qBCProd, "0.00")
                    '
                    ' chamada da DLL para criar o grupo PIS ST
                    '
                    pisst = nfe.PISST(pisst_vBC, pisst_pPIS, pisst_vPIS, pisst_qBCProd, pisst_vAliqProd)
                End If
                If pis_CST = "04" Or pis_CST = "05" Or pis_CST = "06" Or pis_CST = "07" Or pis_CST = "08" Or pis_CST = "09" Or pis_CST = "99" Then
                    pis_vBC = 0
                    pis_pPIS = 0
                    pis_vPIS = 0
                    pis_qBCProd = 0
                    pis_vAliqProd = 0
                    pis_vPIS = 0
                End If

                '
                '   gera grupo do PIS
                '
                pis = nfe.PIS(pis_CST, pis_vBC, pis_pPIS, pis_vPIS, pis_qBCProd, pis_AliqProd)
            Else
                Exit Function
            End If

            'MsgBox "Grupo de Tributos/PIS " + PIS, vbInformation, "Resultado"

            '
            '=========dados do IPI (grupo Q do Manual de Integração - páginas 110) =============
            '
            ipi = ""
            If dsIcms.Tables(0).Rows(0)("VIPI") > 0 Then
                If IsDBNull(dsIcms.Tables(0).Rows(0)("CódIPI")) Then

                    Exit Function
                End If
                ipi_clEnq = ""
                ipi_CNPJProd = ""
                ipi_cSelo = ""
                ipi_qSelo = 0
                ipi_cEnq = "999"
                ipi_CST = dsIcms.Tables(0).Rows(0)("CódIPI")
                ipi_vBC = dsIcms.Tables(0).Rows(0)("Valor Total")
                ipi_pIPI = dsIcms.Tables(0).Rows(0)("AIPI")
                ipi_qUnid = 0
                ipi_vUnid = 0
                ipi_vIPI = dsIcms.Tables(0).Rows(0)("VIPI")
                '
                ' chamada da DLL para criar o grupo IPI
                '
                ipi = nfe.IPI400(ipi_CNPJProd, ipi_cSelo, ipi_qSelo, ipi_cEnq, ipi_CST, ipi_vBC, ipi_pIPI, ipi_vIPI, ipi_qUnid, ipi_vUnid)
            Else
                If emi_CRT = 3 Then
                    If Not IsDBNull(dsIcms.Tables(0).Rows(0)("CódIPI")) Then
                        If IsDBNull(dsIcms.Tables(0).Rows(0)("CódIPI")) Then

                            Exit Function
                        End If
                        ipi_clEnq = ""
                        ipi_CNPJProd = ""
                        ipi_cSelo = ""
                        ipi_qSelo = 0
                        ipi_cEnq = "999"
                        ipi_CST = dsIcms.Tables(0).Rows(0)("CódIPI")
                        ipi_vBC = 0
                        ipi_pIPI = 0
                        ipi_qUnid = 0
                        ipi_vUnid = 0
                        ipi_vIPI = 0
                        '
                        ' chamada da DLL para criar o grupo IPI
                        '
                        ipi = nfe.IPI400(ipi_CNPJProd, ipi_cSelo, ipi_qSelo, ipi_cEnq, ipi_CST, ipi_vBC, ipi_pIPI, ipi_vIPI, ipi_qUnid, ipi_vUnid)
                    End If
                End If
            End If

            '
            '========dados do COFINS (grupo s do Manual de Integração - páginas 113) ============
            '
            cofins = ""
            If Not IsDBNull(dsIcms.Tables(0).Rows(0)("CódCOFINS")) Then
                cofins_CST = dsIcms.Tables(0).Rows(0)("CódCOFINS")

                cofinsst_vBC = 0
                cofinsst_pPIS = 0
                cofinsst_qBCProd = 0
                cofinsst_vAliqProd = 0
                cofinsst_vPIS = 0
                cofinsst = ""
                If cofins_CST = "05" Then
                    cofinsst_vBC = Prod_qTrib
                    cofinsst_pPIS = dsIcms.Tables(0).Rows(0)("VPIS")
                    cofinsst_qBCProd = 0
                    cofinsst_vAliqProd = dsIcms.Tables(0).Rows(0)("VCOFINS")
                    cofinsst_vPIS = Format(cofins_vAliqProd * cofins_qBCProd, "0.00")
                    '
                    ' chamada da DLL para criar o grupo PIS ST
                    '
                    cofinsst = nfe.COFINSST(cofinsst_vBC, cofinsst_pCOFINS, cofinsst_vCOFINS, cofinsst_qBCProd, cofinsst_vAliqProd)
                End If
                If dsIcms.Tables(0).Rows(0)("VCOFINS") = 0 Then
                    cofins_vBC = (dsIcms.Tables(0).Rows(0)("Valor Total") - dsIcms.Tables(0).Rows(0)("DescoPro"))
                    cofins_pCOFINS = dsIcms.Tables(0).Rows(0)("porcofins")
                    cofins_vCOFINS = Format((cofins_vBC * cofins_pCOFINS) / 100, "0.00")
                Else
                    cofins_qBCProd = Prod_qTrib
                    cofins_vAliqProd = dsIcms.Tables(0).Rows(0)("VCOFINS")
                    cofins_vCOFINS = Format(cofins_vAliqProd * cofins_qBCProd, "0.00")
                End If

                If cofins_CST = "04" Or cofins_CST = "05" Or cofins_CST = "06" Or cofins_CST = "07" Or cofins_CST = "08" Or cofins_CST = "09" Then
                    cofins_vBC = 0
                    cofins_pPIS = 0
                    cofins_vPIS = 0
                    cofins_qBCProd = 0
                    cofins_vAliqProd = 0
                    cofins_vPIS = 0
                End If

                '
                '   gera grupo do COFINS
                '
                cofins = nfe.COFINS(cofins_CST, cofins_vBC, cofins_pCOFINS, cofins_vCOFINS, cofins_qBCProd, cofins_AliqProd)
            Else

                Exit Function
            End If

            'MsgBox "Grupo de Tributos/COFINS " + COFINS, vbInformation, "Resultado"


            Dim vBCUFDest As Double, pFCPUFDest As Double, pICMSUFDest As Double, pICMSInter As Double, pICMSInterPart As Double, vFCPUFDest As Double, vICMSUFDest As Double, vICMSUFRemet As Double
            Dim ICMSUFDes As String, vBCFCPUFDest As Double

            ICMSUFDest = ""

            vBCUFDest = 0
            pFCPUFDest = 0
            pICMSUFDest = 0
            pICMSInter = 0
            pICMSInterPart = 0
            vFCPUFDest = 0
            vICMSUFDest = 0
            vICMSUFRemet = 0
            vBCFCPUFDest = 0

            If dsIcms.Tables(0).Rows(0)("Cod Icms") <> "06" Then
                If Prod_CFOP <> 5933 Then
                    If Prod_CFOP <> 6949 Then
                        If Prod_CFOP <> 6933 Then
                            If emi_CRT <> 1 Then
                                If IsDBNull(dest_IE) Or dest_IE = "" Then
                                    If dest_UF <> emi_UF Then
                                        If ds.Tables(0).Rows(0)("saída") = "1" Then


                                            comando = New OleDbCommand("select *from TabelaICMS where [UFdestino] = " & "'" & dest_UF & "'", conexao)
                                            da = New OleDbDataAdapter(comando)
                                            dsIcms = New DataSet
                                            da.Fill(dsTabelaIcms, "TabelaICMS")


                                            Porice = (dsTabelaIcms.Tables(0).Rows(0)("ICMSDestino") - dsIcms.Tables(0).Rows(0)("Aliq ICMS"))

                                            If ICMS_pRedBC > 0 Then
                                                ValorDesti = (((Prod_vProd) * ICMS_pRedBC / 100) * Porice / 100) * dsTabelaIcms.Tables(0).Rows(0)("PorDestino") / 100
                                                ValorOrigem = (((Prod_vProd) * ICMS_pRedBC / 100) * Porice / 100) * dsTabelaIcms.Tables(0).Rows(0)("PorOrigem") / 100
                                            Else
                                                ValorDesti = ((Prod_vProd) * Porice / 100) * dsTabelaIcms.Tables(0).Rows(0)("PorDestino") / 100
                                                ValorOrigem = ((Prod_vProd) * Porice / 100) * dsTabelaIcms.Tables(0).Rows(0)("PorOrigem") / 100
                                            End If


                                            'Me.Observação = Me.Observação + "VALOR DE ICMS ORIGEM R$ " & Format(ValorOrigem, "0.00") & " VALOR ICMS DESTINO R$ " & Format(ValorDesti, "0.00")
                                            vBCUFDest = Prod_vProd
                                            pFCPUFDest = 0
                                            pICMSUFDest = dsTabelaIcms.Tables(0).Rows(0)("ICMSDestino")
                                            pICMSInter = dsTabelaIcms.Tables(0).Rows(0)("ICMSOrigem")
                                            pICMSInterPart = dsTabelaIcms.Tables(0).Rows(0)("PorDestino")
                                            vFCPUFDest = 0
                                            vICMSUFDest = ValorDesti
                                            vICMSUFRemet = ValorOrigem
                                            ICMSUFDest = nfe.ICMSUFDest400(vBCUFDest, vBCFCPUFDest, pFCPUFDest, pICMSUFDest, pICMSInter, pICMSInterPart, vFCPUFDest, vICMSUFDest, vICMSUFRemet)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If



            imposto = nfe.impostoNT2015003(icms_vTotTrib, icms, ipi, "", pis, "", cofins, "", issqn, ICMSUFDest)

            ' imposto = objNFeUtil.imposto(ICMS, IPI, II, PIS, PISST, COFINS, COFINSST, ISSQN)



            '
            '   atualização de total
            '
            '    MsgBox ICMS_vICMS
            totICMS_vBC = totICMS_vBC + ICMS_vBC
            totICMS_vICMS = totICMS_vICMS + ICMS_vICMS
            totICMS_vBCST = totICMS_vBCST + icms_vbcst
            totICMS_vST = totICMS_vST + ICMS_vICMSST
            totICMS_vProd = totICMS_vProd + Prod_vProd
            totICMS_vFrete = totICMS_vFrete + Prod_vFrete
            totICMS_vSeg = totICMS_vSeg + Prod_vSeguro
            totICMS_vDesc = totICMS_vDesc + Prod_vDesc
            totICMS_vCOFINS = totICMS_vCOFINS + cofins_vCOFINS
            totICMS_vPIS = totICMS_vPIS + pis_vPIS
            totICMS_vISSQN = totICMS_vISSQN + issqn_vISSQN
            totICMS_vISSQNBC = totICMS_vISSQNBC + issqn_vBC
            totICMS_vICMSUFDest = totICMS_vICMSUFDest + ValorDesti
            totICMS_vICMSUFRemet = totICMS_vICMSUFRemet + ValorOrigem
            totICMS_vFCPUFDest = totICMS_vFCPUFDest + vFCPUFDest

            pDevol_Opc = 0
            vIPIDevol_Opc = 0
            Detalhes = Detalhes + nfe.detalhe310(i, prod, imposto, "", pDevol_Opc, vIPIDevol_Opc)

        Next


        'totICMS_vIPI = dsIcms.Tables(0).Rows(0)("VIPI")
        'totICMS_vSeg = dsIcms.Tables(0).Rows(0)("vseg")
        'totICMS_vDesc = totICMS_vDesc
        'totICMS_vOutro = dsIcms.Tables(0).Rows(0)("Vdesp")
        'totICMS_vFrete = dsIcms.Tables(0).Rows(0)("Vfrete")
        'totICMS_vProd = totICMS_vProd - totICMS_vISSQNBC

        totICMS_vNF = totICMS_vProd + totICMS_vISSQNBC + totICMS_vFrete + totICMS_vST + totICMS_vIPI + totICMS_vSeg + totICMS_vOutro - totICMS_vDesc        '- Desti![Valorfun]



        'MsgBox Cont
        'total As String
        'totICMS As String

        Dim dCompet As String
        If totICMS_vISSQNBC > 0 Then
            dCompet = "2015-03-12"
            TotISSQN = nfe.totalISS310(totICMS_vISSQNBC, totICMS_vISSQNBC, totICMS_vISSQN, totICMS_vPIS, totICMS_vCOFINS, dCompet, 0, 0, 0, 0, 0, "")
            'totalISS = objNFeUtil.totalISS310(totalISS_vServ_Opc, totalISS_vBC_Opc, totalISS_vISS_Opc, totalISS_vPIS_Opc, totalISS_vCOFINS_Opc, totalISS_dCompet, totalISS_vDeducao_Opc, totalISS_vOutro_Opc, totalISS_vDescIncond_Opc, totalISS_vDescCond_Opc, totalISS_vISSRet_Opc, totalISS_cRegTrib_Opc)

        Else
            TotISSQN = ""
        End If
        '
        '========dados do total do nota
        '
        '
        totICMS = nfe.totalICMS400(totICMS_vBC, totICMS_vICMS, totICMS_vBCST, totICMS_vST, totICMS_vProd, totICMS_vFrete, totICMS_vSeg, totICMS_vDesc, totICMS_vII, totICMS_vIPI, totICMS_vPIS, totICMS_vCOFINS, totICMS_vOutro, totICMS_vNF, totICMS_vTotTrib, 0, totICMS_vICMSUFDest, totICMS_vICMSUFRemet, totICMS_vFCPUFDest, vFCP, vFCPST, vFCPSTRet, vIPIDevol)

        'totICMS = objNFeUtil.totalICMSNT2015003(totICMS_vBC, totICMS_vICMS, totICMS_vBCST, totICMS_vST, totICMS_vProd, totICMS_vFrete, totICMS_vSeg, totICMS_vDesc, totICMS_vII, totICMS_vIPI, totICMS_vPIS, totICMS_vCOFINS, totICMS_vOutro, totICMS_vNF, totICMS_vTotTrib, totalICMS_vICMSDeson, totICMS_vICMSUFDest, totICMS_vICMSUFRemet, totICMS_vFCPUFDest, vFCP, vFCPST, vFCPSTRet, vIPIDevol)

        'totalICMS = objNFeUtil.totalICMSNT2015003(totalICMS_vBC, totalICMS_vICMS, totalICMS_vBCST, totalICMS_vST, totalICMS_vProd, totalICMS_vFrete, totalICMS_vSeg, totalICMS_vDesc, totalICMS_vII, totalICMS_vIPI, totalICMS_vPIS, totalICMS_vCOFINS, totalICMS_vOutro, totalICMS_vNF, totalICMS_vTotTrib, totalICMS_vICMSDeson, totalICMS_vICMSUFDest, totalICMS_vICMSUFRemet, totalICMS_vFCPUFDest)

        Total = nfe.total(totICMS, TotISSQN, "")        ' total da NF-e sem os valors de ISSQN e RetTributos


        resp_cnpj = "09602527000160"
        resp_xContato = "ELDER PANISSON FONTANA"
        resp_email = "elderpf@bol.com.br"
        resp_fone = "5433443036"

        responsavelTecnico = nfe.infRespTec(resp_cnpj, resp_xContato, resp_email, resp_fone, resp_idCSRT, resp_CSRT, resp_chaveNFe)




        If ide_finNFe = 3 Or ide_finNFe = 4 Then
            cobr = ""
            DetPag = nfe.detPag("", "90", 0, "", "", "", "")
            pagto = nfe.pagamento400(DetPag, 0)

        Else

            dup = ""
            comando = New OleDbCommand("SELECT *FROM ParcelasNFE where [Códnota] =" & "'" & codnota & "'" & " AND [CodEmitente] = " & codemitente & " ORDER BY DVENCI", conexao)
            da = New OleDbDataAdapter(comando)
            ds = New DataSet
            da.Fill(ds, "ParcelasNFE")
            nDup = 1

            For i = 0 To ds.Tables(0).Rows.Count - 1
                valorParcelasCalculado = valorParcelasCalculado + (Format(ds.Tables(0).Rows(i)("VParce"), "0.00") * 100) / 100
            Next

            If totICMS_vNF <> valorParcelasCalculado Then
                valorDiferenca = totICMS_vNF - (valorParcelasCalculado)
            End If

            For i = 0 To ds.Tables(0).Rows.Count - 1

                dup_nDup = Format(nDup, "000")
                If ds.Tables(0).Rows.Count = nDup Then
                    dup_vDup = ds.Tables(0).Rows(i)("VParce") + (valorDiferenca)
                Else
                    dup_vDup = ds.Tables(0).Rows(i)("VParce")
                End If
                dup_dVenc = ds.Tables(0).Rows(i)("DVEnci")

                dup = dup + nfe.dup(dup_nDup, dup_dVenc, dup_vDup)
                nDup = nDup + 1
            Next

            cobr_nfat = codnota
            cobr_vOrig = totICMS_vNF
            cobr_vDesc = 0
            cobr_vLiq = totICMS_vNF
            cobr = nfe.cobr(cobr_nfat, cobr_vOrig, cobr_vDesc, cobr_vLiq, dup)


            'MeioPag = Gide!MeioPgtoNFe
            If MeioPag <> vbNull Then

            End If
            If IsDBNull(MeioPag) Then
                MeioPag = "05"
            End If
            pagto = ""

            'If Date > #7/30/2018# Then
            If ide_indPag = 2 Then
                indPag = ""
            Else
                indPag = ide_indPag
            End If
            'Else
            '   indPag = ""
            'End If
            If ide_finNFe = 3 Or ide_finNFe = 4 Then
                pagto_tPag = 90
            Else
                pagto_tPag = MeioPag
            End If
            pagto_vPag = totICMS_vNF
            tpIntegra_Opc = ""
            pagto_CNPJ_Opc = ""
            pagto_tBand_Opc = ""
            pagto_cAut_Opc = ""
            vTroco = 0
            '

            If ide_finNFe = 1 Or ide_finNFe = 2 Then
                DetPag = nfe.detPag(indPag, pagto_tPag, pagto_vPag, tpIntegra_Opc, pagto_CNPJ_Opc, pagto_tBand_Opc, pagto_cAut_Opc)
                pagto = nfe.pagamento400(DetPag, vTroco)
            Else
                DetPag = nfe.detPag("", pagto_tPag, 0, "", "", "", "")
                pagto = nfe.pagamento400(DetPag, 0)
            End If
        End If





        'nfe = nfe.NFe201805(versao, chaveNfe, ide, emi, "", dest, Retirada, Entrega, Detalhes, Total, transp, cobr, pagto, infAdic, exporta, Compr, "", "", responsavelTecnico)
        xmlnfe = nfe.NFe201805(versao, chaveNfe, ide, emi, "", dest, "", "", "", "", "", cobr, pagto, "", "", "", "", "", responsavelTecnico)

        Return xmlnfe

    End Function

End Module
