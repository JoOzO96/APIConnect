Public Class Vendedor
    Private _codvendedor As String
    Private _nomevendedor As String
    Private _comi As Single
    Private _comis As Single

    Public Property codvendedor As String
        Get
            Return _codvendedor
        End Get
        Set(value As String)
            _codvendedor = value
        End Set
    End Property

    Public Property nomevendedor As String
        Get
            Return _nomevendedor
        End Get
        Set(value As String)
            _nomevendedor = value
        End Set
    End Property

    Public Property comi As Single
        Get
            Return _comi
        End Get
        Set(value As Single)
            _comi = value
        End Set
    End Property

    Public Property comis As Single
        Get
            Return _comis
        End Get
        Set(value As Single)
            _comis = value
        End Set
    End Property
End Class
