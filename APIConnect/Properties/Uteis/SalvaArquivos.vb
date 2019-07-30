Public Class SalvaArquivos

    Public Function SalvaArquivo(Emitente As Long, Data As Date, Tipo As String, texto As String, Nome As String)
        Call IniciaVar
        Dim iarq As Long
        Dim programa As Database
        Dim emitenteC As Recordset
        Dim XMLDocumento As Recordset
        Dim Contatexto As Long
        Tipo = UCase(Tipo)
        iarq = FreeFile()

        Contatexto = 0
        Contatexto = Len(texto)

        '    If Contatexto < 100 Then
        '        Beep
        '        MsgBox "Retorno do XML inválido, não salvar o xml Processado!!!", vbCritical, "Advertência"
        '        Exit Function
        '
        '    End If

        Open RetornaPastaArquivos(Emitente, Data, Tipo) & Nome For Output As iarq
    Print #iarq, texto
    Close #iarq
    
    Set programa = DBEngine.OpenDatabase(VarDados1)
    Set emitenteC = programa.OpenRecordset("SELECT * FROM EMITENTE where CodigoEmitente = " & Emitente)
    If (Replace(emitenteC!VersaoSistemaConnect, ".", "") > "310000001") Then
        Set XMLDocumento = programa.OpenRecordset("SELECT * FROM XMLDocumento WHERE ID = 0")
        XMLDocumento.AddNew
            XMLDocumento!Tipo = UCase(Tipo)
            XMLDocumento!texto = texto
            XMLDocumento.Update
            XMLDocumento.Close
            programa.Close
        End If
    End Function

    Public Function CriaPasta(Emitente As Long, mes As Date, Tipo As String)
        Call IniciaVar
        Call Chama_Certi(Emitente)
        Dim CamPasta As String
        CamPasta = CXMLPDF & "Proc\"
        Dim lngYear As Long
        Dim strMonth As String

        lngYear = Year(mes)
        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)
        If Not Dir(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & cnpjEmitente, vbDirectory) <> "" Then
            MkDir CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & cnpjEmitente
    End If
        If Not Dir(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & cnpjEmitente & "\" & Tipo, vbDirectory) <> "" Then
            MkDir CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & cnpjEmitente & "\" & Tipo
    End If
    End Function

    Public Function CriaPastaTransportes(Emitente As Long, mes As Date)
        Call IniciaVar
        Call Chama_Certi(Emitente)
        Dim CamPasta As String
        CamPasta = CXMLPDF & "Proc\"
        Dim lngYear As Long
        Dim strMonth As String

        lngYear = Year(mes)
        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)

        If Not Dir(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_Transp_" & strMonth & "_" & cnpjEmitente, vbDirectory) <> "" Then
            MkDir CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_Transp_" & strMonth & "_" & cnpjEmitente
    End If

    End Function

    Public Function RetornaPastaTransportes(Emitente As Long, mes As Date)
        Call IniciaVar
        Call Chama_Certi(Emitente)
        Dim CamPasta As String
        Call CriaPastaTransportes(Emitente, mes)
        CamPasta = CXMLPDF & "Proc\"
        Dim lngYear As Long
        Dim strMonth As String

        lngYear = Year(mes)
        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)

        On Error Resume Next
        RetornaPastaTransportes = CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_Transp_" & strMonth & "_" & cnpjEmitente & "\"

    End Function

    Public Function RetornaPastaArquivos(Emitente As Long, mes As Date, Tipo As String) As String
        Call CriaPasta(Emitente, mes, Tipo)
        Call IniciaVar
        Call Chama_Certi(Emitente)
        Dim CamPasta As String
        CamPasta = CXMLPDF & "Proc\"
        Dim lngYear As Long
        Dim strMonth As String

        lngYear = Year(mes)
        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)

        RetornaPastaArquivos = CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & cnpjEmitente & "\" & Tipo & "\"

    End Function


End Class
