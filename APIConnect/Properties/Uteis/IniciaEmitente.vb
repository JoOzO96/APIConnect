﻿Imports System.Data.OleDb

Module IniciaEmitente
    Public Function RetornaEmitente(codEmitente As Long) As Emitente
        Dim dados As New OleDbConnection
        Dim comando As New OleDbCommand
        Dim ds As New DataSet

        dados.ConnectionString = RetornaConexao()
        dados.Open()
        comando = New OleDbCommand("SELECT * from Emitente Where Codigoemitente = " & codEmitente, dados)
        Dim da As New OleDbDataAdapter(comando)
        da.Fill(ds, "Emitente")

        Dim emitente As New Emitente
        Dim fieldList() = emitente.GetType().GetProperties
        Dim nomeCampo As String


        For i = 0 To ds.Tables(0).Rows.Count - 1
            emitente = New Emitente
            For j = 0 To fieldList.Length - 1
                nomeCampo = fieldList(j).Name.ToLower
                If (nomeCampo.Equals("emailemi")) Then
                    nomeCampo = "E-mailEmi"
                End If
                If (nomeCampo.Equals("modulo")) Then
                    nomeCampo = "Módulo"
                End If
                If (nomeCampo.Equals("codhistorico")) Then
                    nomeCampo = "Cód Histórico"
                End If

                If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                    emitente = colocaDadosObjeto(emitente, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                End If
            Next
        Next

        Return emitente
    End Function
End Module
