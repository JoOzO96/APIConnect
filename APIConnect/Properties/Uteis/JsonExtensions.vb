Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json.Linq

Public Module JsonExtensions

    <Extension>
    Public Function FindTokens(containerToken As JToken, name As String) _
                        As List(Of JToken)

        Dim matches = New List(Of JToken)()
        FindTokens(containerToken, name, matches)
        Return matches

    End Function

    Private Sub FindTokens(containerToken As JToken, name As String,
                           matches As List(Of JToken))

        If containerToken.Type = JTokenType.[Object] Then
            For Each child As JProperty In containerToken.Children(Of JProperty)()
                If child.Name = name Then
                    matches.Add(child.Value)
                End If
                FindTokens(child.Value, name, matches)
            Next
        ElseIf containerToken.Type = JTokenType.Array Then
            For Each child As JToken In containerToken.Children()
                FindTokens(child, name, matches)
            Next
        End If

    End Sub

End Module