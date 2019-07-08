Imports System.Net
Imports System.Web.Http
Imports System.Data.OleDb

Namespace Controllers
    Public Class FormaPagamentoController
        Inherits ApiController

        ' GET: api/FormaPagamento
        Public Function GetValues() As List(Of FormaPagamento)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from Pgto", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "Pgto")

            Dim formaPagamento As New FormaPagamento
            Dim fieldList() = formaPagamento.GetType().GetProperties
            Dim nomeCampo As String

            Dim _formaPagamento As New List(Of FormaPagamento)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                formaPagamento = New FormaPagamento
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
                    If (nomeCampo.Equals("codigo")) Then
                        nomeCampo = "Código"
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                        formaPagamento = colocaDadosObjeto(formaPagamento, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                    End If
                Next
                _formaPagamento.Add(formaPagamento)
                formaPagamento = Nothing
            Next

            dados.Close()
            dados = Nothing
            fieldList = Nothing
            Return _formaPagamento
            _formaPagamento = Nothing
        End Function

        ' GET: api/FormaPagamento/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/FormaPagamento
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/FormaPagamento/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/FormaPagamento/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace