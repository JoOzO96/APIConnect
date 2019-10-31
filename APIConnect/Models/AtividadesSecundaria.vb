Public Class AtividadesSecundaria
    Private _text As String
    Private _code As String

    Public Property text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    Public Property code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property
End Class