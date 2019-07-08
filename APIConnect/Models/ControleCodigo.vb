Public Class ControleCodigo
    Private _codigoBanco As Long
    Private _codigoAndroid As Long
    Private _mensagem As String

    Public Property CodigoBanco As Long
        Get
            Return _codigoBanco
        End Get
        Set(value As Long)
            _codigoBanco = value
        End Set
    End Property

    Public Property CodigoAndroid As Long
        Get
            Return _codigoAndroid
        End Get
        Set(value As Long)
            _codigoAndroid = value
        End Set
    End Property

    Public Property Mensagem As String
        Get
            Return _mensagem
        End Get
        Set(value As String)
            _mensagem = value
        End Set
    End Property
End Class
