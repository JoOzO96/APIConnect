Imports System.Data.OleDb
Imports System.Net
Imports System.Web.Http
Imports Newtonsoft.Json

Namespace Controllers
    Public Class ClienteAnimaisController
        Inherits ApiController

        ' GET: api/ClienteAnimais
        Public Function GetValues() As List(Of ClienteAnimais)

            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet

            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT * from ClienteAnimais", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "ClienteAnimais")

            Dim clienteAnimais As New ClienteAnimais
            Dim fieldList() = clienteAnimais.GetType().GetProperties
            Dim nomeCampo As String

            Dim _clienteAnimais As New List(Of ClienteAnimais)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                clienteAnimais = New ClienteAnimais
                For j = 0 To fieldList.Length - 1
                    nomeCampo = fieldList(j).Name.ToLower
                    If Not nomeCampo.Equals("cadastroandroid") And Not nomeCampo.Equals("alteradoandroid") Then
                        If Not IsDBNull(ds.Tables(0).Rows(i)(nomeCampo)) Then
                            clienteAnimais = colocaDadosObjeto(clienteAnimais, fieldList(j), ds.Tables(0).Rows(i)(nomeCampo))
                        End If
                    End If
                Next
                _clienteAnimais.Add(clienteAnimais)
                clienteAnimais = Nothing
            Next

            dados.Close()
            dados = Nothing
            fieldList = Nothing
            Return _clienteAnimais
            _clienteAnimais = Nothing

        End Function

        ' GET: api/ClienteAnimais/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/ClienteAnimais
        Public Function PostValue(<FromBody()> ByVal value As Object) As List(Of ControleCodigo)
            Dim dados As New OleDbConnection
            Dim comando As New OleDbCommand
            Dim ds As New DataSet
            Dim dsLog As New DataSet
            Dim json = value.ToString
            Dim listaClienteAnimais As List(Of ClienteAnimais)
            Dim clienteAnimal As New ClienteAnimais
            Dim controleCodigo As ControleCodigo
            Dim listcontrolecodigo As New List(Of ControleCodigo)
            Dim insert As String

            Dim fieldList = clienteAnimal.GetType().GetProperties().ToList
            dados.ConnectionString = RetornaConexao()
            dados.Open()
            comando = New OleDbCommand("SELECT TOP 1 * from ClienteAnimais order by [idclienteanimal] desc", dados)
            Dim da As New OleDbDataAdapter(comando)
            da.Fill(ds, "ClienteAnimais")
            comando = New OleDbCommand("INSERT INTO XMLDocumento (Tipo,texto) VALUES ('JSONCLIENTEANIMAL','" & value.ToString.Replace(vbCrLf, "") & "')", dados)
            comando.ExecuteNonQuery()

            Try
                listaClienteAnimais = JsonConvert.DeserializeObject(Of List(Of ClienteAnimais))(json)
                For i = 0 To listaClienteAnimais.Count - 1
                    controleCodigo = New ControleCodigo

                    clienteAnimal = New ClienteAnimais

                    clienteAnimal = listaClienteAnimais(i)
                    If clienteAnimal.alteradoandroid = True Then

                        insert = RetornaUpdate(fieldList, clienteAnimal, "ClienteAnimais", "[idclienteanimal]", clienteAnimal.idclienteanimal)

                        da = Nothing
                        ds = Nothing
                        comando = Nothing
                        comando = New OleDbCommand(insert, dados)
                        Dim numerodelinhas = comando.ExecuteNonQuery()
                        comando = New OleDbCommand("SELECT TOP 1 * from ClienteAnimais WHERE [idclienteanimal] = " & clienteAnimal.idclienteanimal & "  order by [idclienteanimal] desc", dados)
                        da = New OleDbDataAdapter(comando)
                        ds = New DataSet
                        da.Fill(ds, "Cliente")

                        comando.Dispose()
                        controleCodigo.CodigoAndroid = clienteAnimal.idclienteanimal
                        controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("idclienteanimal")


                    Else

                        insert = RetornaInsert(fieldList, clienteAnimal, "ClienteAnimais")
                        comando = New OleDbCommand(insert, dados)
                        Dim numerodelinhas = comando.ExecuteNonQuery()
                        da = Nothing
                        ds = Nothing
                        comando = Nothing
                        comando = New OleDbCommand("SELECT TOP 1 * from ClienteAnimalAndroid order by [idclienteanimal] desc", dados)
                        da = New OleDbDataAdapter(comando)
                        ds = New DataSet
                        da.Fill(ds, "ClienteAnimalAndroid")

                        comando.Dispose()
                        controleCodigo.CodigoAndroid = clienteAnimal.idclienteanimal
                        controleCodigo.CodigoBanco = ds.Tables(0).Rows(0)("idclienteanimal")


                    End If
                    listcontrolecodigo.Add(controleCodigo)
                    da = Nothing
                    ds = Nothing
                    comando = Nothing

                Next
                dados.Close()
                Return listcontrolecodigo
            Catch ex As Exception
                dados.Close()
                controleCodigo = New ControleCodigo
                controleCodigo.Mensagem = ex.Message & " - " & ex.StackTrace & " - " & insert
                listcontrolecodigo.Add(controleCodigo)
                Return listcontrolecodigo
            End Try
        End Function

        ' PUT: api/ClienteAnimais/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/ClienteAnimais/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace