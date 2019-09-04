Imports System.Xml

Module Util

    Public Function RetornaValorNodoXML(xmlRecebido As String, nodo As String, nomePai As String, Optional nomefilho As String = "") As String
        Dim xml As New XmlDocument
        Dim xmlNode As XmlNode
        Dim nodoPai As XmlNode
        Dim retorno As String
        Try
            If nomePai = "" Then
                xmlRecebido = "<connect>" & xmlRecebido & "</connect>"
            End If
            xml.LoadXml(Replace(xmlRecebido, "xmlns=", "xmlns:c="))
        Catch ex As Exception
            If InStr(ex.Message, "Há vários elementos") Then
                xmlRecebido = "<connect>" & xmlRecebido & "</connect>"
                xml.LoadXml(Replace(xmlRecebido, "xmlns=", "xmlns:c="))
            End If
        End Try
        Try
            retorno = ""
            If nomefilho <> "" Then
                nodoPai = xml.SelectSingleNode("//" & nomePai & "/" & nomefilho)
                For i = 0 To nodoPai.ChildNodes.Count - 1
                    If (nodo.ToUpper = nodoPai.ChildNodes.Item(i).Name.ToUpper) Then
                        retorno = nodoPai.ChildNodes.Item(i).InnerText
                    End If
                Next
            ElseIf (nomePai = "") Then
                retorno = xml.SelectSingleNode("/connect/" & nodo).InnerText
            Else
                nodoPai = xml.SelectSingleNode("//" & nomePai)
                For i = 0 To nodoPai.ChildNodes.Count - 1
                    If (nodo.ToUpper = nodoPai.ChildNodes.Item(i).Name.ToUpper) Then
                        retorno = nodoPai.ChildNodes.Item(i).InnerText
                    End If
                Next
            End If
        Catch ex As Exception
            Return ""
        End Try


        Return retorno
    End Function

    Public Function RetornaValorAtributoXML(XMLRecebido As String, NomePai As String, NomeFilho As String, IDAtributo As String)

        'On Error Resume Next
        Dim xml As New XmlDocument
        Dim ListNodos As XmlNodeList
        Dim nodoPai As XmlNode
        Dim nodofilho As XmlNode

        xml.loadXML(XMLRecebido)
        xml.LoadXml(Replace(XMLRecebido, "xmlns=", "xmlns:c="))

        If NomeFilho <> "" Then
            RetornaValorAtributoXML = xml.SelectSingleNode("//" & NomePai & "/" & NomeFilho).Attributes.GetNamedItem(IDAtributo).InnerText
        Else
            RetornaValorAtributoXML = xml.SelectSingleNode("//" & NomePai).Attributes.GetNamedItem(IDAtributo).InnerText
        End If


    End Function

    Function GetInstallDirectory(ByVal usProgName As String) As String
        Dim files() As String
        'files = System.IO.Directory.GetFiles(
        '    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
        '    "MSACESS.EXE", System.IO.SearchOption.AllDirectories)
        Try
            files = IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\Microsoft Office", usProgName, IO.SearchOption.AllDirectories)
        Catch ex As Exception

        End Try

        Return files(0)
    End Function

    Public Function colocaDadosObjeto(obj As Object, field As Object, valor As Object) As Object
        Try
            field.SetValue(obj, valor)
            Return obj
        Catch ex As Exception
            Debug.Print(field.Name & Chr(13) & Chr(10) & " -" & ex.Message)
            Return obj
        End Try
    End Function

    Public Function retornaDadosObjeto(obj As Object, field As Object, i As Long) As Object
        Try
            Return field(i).GetValue(obj)
        Catch ex As Exception
            Debug.Print(field(i).Name & Chr(13) & Chr(10) & " -" & ex.Message)
            Return ""
        End Try
    End Function

    Public Function RetornaInsert(field As List(Of Reflection.PropertyInfo), dados As Object, tabela As String) As String
        Dim insert As String
        Dim camposTabela As String = ""
        Dim dadosTabela As String = ""
        insert = "INSERT INTO " & tabela & "("

        If tabela = "Pedido" Then
            For i = 0 To field.Count - 1
                If field(i).Name = "pedido" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If

        If tabela = "Cliente" Then

            For i = 0 To field.Count - 1
                If field(i).Name = "codigo" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next
            For i = 0 To field.Count - 1
                If field(i).Name = "cadastroAndroid" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next
            For i = 0 To field.Count - 1
                If field(i).Name = "alteradoAndroid" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If

        If tabela = "[Pedido Produto]" Then
            For i = 0 To field.Count - 1
                If field(i).Name = "Conta" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If
        If tabela = "[Nota Produto]" Then
            For i = 0 To field.Count - 1
                If field(i).Name = "Auto" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If




        For i = 0 To field.Count - 1
            camposTabela += field(i).Name
            If (i <> field.Count - 1) Then
                camposTabela += ","
            End If
        Next

        For i = 0 To field.Count - 1

            Dim dado = retornaDadosObjeto(dados, field, i)

            If field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.DATETIME") Then

                dadosTabela = dadosTabela & "#"
                dadosTabela = dadosTabela & Format(dado, "MM/dd/yyyy")
                dadosTabela = dadosTabela & "#"
            Else

                If (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.STRING")) Then
                    dadosTabela = dadosTabela & "'"
                End If
                If dado Is Nothing Then
                Else
                    If (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.DOUBLE")) Or (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.SINGLE")) Or (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.DECIMAL")) Then
                        dadosTabela = dadosTabela & Replace(dado.ToString, ",", ".")
                    Else
                        dadosTabela = dadosTabela & dado.ToString
                    End If

                End If
                If (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.STRING")) Then
                    dadosTabela = dadosTabela & "'"
                End If
            End If
            If (i <> field.Count - 1) Then
                dadosTabela = dadosTabela & ","
            End If

            dado = Nothing

        Next
        insert = insert & camposTabela & ") VALUES (" & dadosTabela & ")"
        Return insert
    End Function

    Public Function RetornaUpdate(field As List(Of Reflection.PropertyInfo), dados As Object, tabela As String, campo As String, valor As String) As String
        Dim update As String
        Dim valores As String = ""
        Dim camposTabela As String = ""
        Dim dadosTabela As String = ""
        update = "UPDATE " & tabela & " SET "

        If tabela = "Pedido" Then

            For i = 0 To field.Count - 1
                If field(i).Name = "Pedido" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If

        If tabela = "Cliente" Then

            For i = 0 To field.Count - 1
                If field(i).Name = "codigo" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next
            For i = 0 To field.Count - 1
                If field(i).Name = "cadastroAndroid" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next
            For i = 0 To field.Count - 1
                If field(i).Name = "alteradoAndroid" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If

        If tabela = "[Pedido Produto]" Then

            For i = 0 To field.Count - 1
                If field(i).Name = "Conta" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If

        If tabela = "[Nota Produto]" Then

            For i = 0 To field.Count - 1
                If field(i).Name = "Auto" Then
                    field.RemoveAt(i)
                    Exit For
                End If
            Next

        End If



        For i = 0 To field.Count - 1
            camposTabela = field(i).Name

            Dim dado = retornaDadosObjeto(dados, field, i)

            If field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.DATETIME") Then

                dadosTabela = "#"
                dadosTabela = dadosTabela & Format(dado, "yyyy-MM-dd")
                dadosTabela = dadosTabela & "#"
            Else

                If (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.STRING")) Then
                    dadosTabela = "'"
                End If
                If dado Is Nothing Then
                Else
                    If (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.DOUBLE")) Or (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.SINGLE")) Or (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.DECIMAL")) Then
                        dadosTabela = dadosTabela & Replace(dado.ToString, ",", ".")
                    Else
                        dadosTabela = dadosTabela & dado.ToString
                    End If

                End If
                If (field(i).PropertyType.FullName.ToUpper.Equals("SYSTEM.STRING")) Then
                    dadosTabela = dadosTabela & "'"
                End If
            End If
            If (i <> field.Count - 1) Then
                dadosTabela = dadosTabela & ","
            End If

            dado = Nothing
            valores = valores & camposTabela & " = " & dadosTabela
            dadosTabela = ""
        Next

        If (campo.Contains("|")) Then
            Dim campos() As String
            Dim valorUpdate() As String
            Dim filtro As String
            campos = Split(campo, "|")
            valorUpdate = Split(valor, "|")
            filtro = ""
            For i = 0 To UBound(campos)
                filtro += campos(i) + " = " + valorUpdate(i)

                If (i <> UBound(campos)) Then
                    filtro += " and "
                End If
            Next


            update = update & " " & valores & " WHERE " & filtro
        Else
            update = update & " " & valores & " WHERE " & campo & " = " & valor
        End If


        Return update
    End Function


End Module
