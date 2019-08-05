Imports System.Data.OleDb
Imports System.Xml

Module SalvaArquivos
    Public Function SalvaArquivo(Emitente As Long, Data As Date, Tipo As String, texto As String, Nome As String)
        Dim iarq As Long
        Dim dir As System.IO.Directory
        Dim dados As New OleDbConnection
        Dim comando As New OleDbCommand
        Dim ds As New DataSet
        Tipo = UCase(Tipo)
        iarq = FreeFile()
        Dim xml As New XmlDocument

        Dim oArquivo As System.IO.File
        Dim oEscrever As System.IO.StreamWriter

        'oArquivo.Create(RetornaPastaArquivos(Emitente, Data, Tipo) & Nome)
        xml.LoadXml(texto)

        xml.Save(RetornaPastaArquivos(Emitente, Data, Tipo) & Nome)



        'Set programa = DBEngine.OpenDatabase(VarDados1)
        'Set emitenteC = programa.OpenRecordset("SELECT * FROM EMITENTE where CodigoEmitente = " & Emitente)
        'If (Replace(emitenteC!VersaoSistemaConnect, ".", "") > "310000001") Then
        '    Set XMLDocumento = programa.OpenRecordset("SELECT * FROM XMLDocumento WHERE ID = 0")
        '    XMLDocumento.AddNew
        '        XMLDocumento!Tipo = UCase(Tipo)
        '        XMLDocumento!texto = texto
        '        XMLDocumento.Update
        '        XMLDocumento.Close
        '        programa.Close
        '    End If
    End Function


    Public Function CriaPasta(Emitente As Long, mes As Date, Tipo As String)
        Dim CamPasta As String
        CamPasta = "C:\CGeral\XML\Proc\"
        Dim lngYear As Long
        Dim strMonth As String
        Dim dir As System.IO.Directory
        lngYear = Year(mes)
        Dim objemitente As New Emitente

        objemitente = RetornaEmitente(Emitente)

        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)
        If Not dir.Exists(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & objemitente.cnpjemi) Then
            dir.CreateDirectory(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & objemitente.cnpjemi)
        End If
        If Not dir.Exists(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & objemitente.cnpjemi & "\" & Tipo) Then
            dir.CreateDirectory(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & objemitente.cnpjemi & "\" & Tipo)
        End If
    End Function

    Public Function CriaPastaTransportes(Emitente As Long, mes As Date)

        'Call Chama_Certi(Emitente)
        Dim CamPasta As String
        CamPasta = "C:\CGeral\XML\Proc\"
        Dim lngYear As Long
        Dim strMonth As String
        Dim dir As System.IO.Directory
        lngYear = Year(mes)
        Dim objemitente As New Emitente

        objemitente = RetornaEmitente(Emitente)
        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)

        If Not dir.Exists(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_Transp_" & strMonth & "_" & objemitente.cnpjemi) Then
            dir.CreateDirectory(CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_Transp_" & strMonth & "_" & objemitente.cnpjemi)
        End If

    End Function

    Public Function RetornaPastaTransportes(Emitente As Long, mes As Date)
        Dim CamPasta As String
        Call CriaPastaTransportes(Emitente, mes)
        CamPasta = "C:\CGeral\XML\Proc\"
        Dim lngYear As Long
        Dim strMonth As String
        Dim objemitente As New Emitente

        objemitente = RetornaEmitente(Emitente)

        lngYear = Year(mes)
        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)

        On Error Resume Next
        RetornaPastaTransportes = CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_Transp_" & strMonth & "_" & objemitente.cnpjemi & "\"

    End Function

    Public Function RetornaPastaArquivos(Emitente As Long, mes As Date, Tipo As String) As String
        Call CriaPasta(Emitente, mes, Tipo)
        Dim CamPasta As String
        CamPasta = "C:\CGeral\XML\Proc\"
        Dim lngYear As Long
        Dim strMonth As String
        Dim objemitente As New Emitente

        objemitente = RetornaEmitente(Emitente)
        lngYear = Year(mes)
        strMonth = StrConv(Format(mes, "MMMM"), vbProperCase)
        CriaPasta(Emitente, mes, Tipo)
        RetornaPastaArquivos = CamPasta & lngYear & "_" & StrConv(Format(mes, "MM"), vbProperCase) & "_" & strMonth & "_" & objemitente.cnpjemi & "\" & Tipo & "\"

    End Function


End Module
