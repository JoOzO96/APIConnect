Public Class DadosEnvio
    Private _tipodocumento As String
    Private _nomedocumento As String
    Private _emaildestinatario As String
    Private _assunto As String
    Private _mensagem As String
    Private _arquivo As String

    Public Property tipodocumento As String
        Get
            Return _tipodocumento
        End Get
        Set(value As String)
            _tipodocumento = value
        End Set
    End Property

    Public Property nomedocumento As String
        Get
            Return _nomedocumento
        End Get
        Set(value As String)
            _nomedocumento = value
        End Set
    End Property

    Public Property emaildestinatario As String
        Get
            Return _emaildestinatario
        End Get
        Set(value As String)
            _emaildestinatario = value
        End Set
    End Property

    Public Property assunto As String
        Get
            Return _assunto
        End Get
        Set(value As String)
            _assunto = value
        End Set
    End Property

    Public Property mensagem As String
        Get
            Return _mensagem
        End Get
        Set(value As String)
            _mensagem = value
        End Set
    End Property

    Public Property arquivo As String
        Get
            Return _arquivo
        End Get
        Set(value As String)
            _arquivo = value
        End Set
    End Property
End Class
