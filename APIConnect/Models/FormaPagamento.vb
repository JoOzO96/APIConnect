Public Class FormaPagamento
    Private _codigo As Long 'Código
    Private _pagamento As String
    Private _prazo As Boolean
    Private _cartao As Boolean
    Private _codcaixa As Long
    Private _encaixa As Boolean
    Private _fechamento As Boolean
    Private _cheque As Boolean
    Private _listapre As String
    Private _naolancareceber As Boolean

    Public Property codigo As Long
        Get
            Return _codigo
        End Get
        Set(value As Long)
            _codigo = value
        End Set
    End Property

    Public Property pagamento As String
        Get
            Return _pagamento
        End Get
        Set(value As String)
            _pagamento = value
        End Set
    End Property

    Public Property prazo As Boolean
        Get
            Return _prazo
        End Get
        Set(value As Boolean)
            _prazo = value
        End Set
    End Property

    Public Property cartao As Boolean
        Get
            Return _cartao
        End Get
        Set(value As Boolean)
            _cartao = value
        End Set
    End Property

    Public Property codcaixa As Long
        Get
            Return _codcaixa
        End Get
        Set(value As Long)
            _codcaixa = value
        End Set
    End Property

    Public Property encaixa As Boolean
        Get
            Return _encaixa
        End Get
        Set(value As Boolean)
            _encaixa = value
        End Set
    End Property

    Public Property fechamento As Boolean
        Get
            Return _fechamento
        End Get
        Set(value As Boolean)
            _fechamento = value
        End Set
    End Property

    Public Property cheque As Boolean
        Get
            Return _cheque
        End Get
        Set(value As Boolean)
            _cheque = value
        End Set
    End Property

    Public Property listapre As String
        Get
            Return _listapre
        End Get
        Set(value As String)
            _listapre = value
        End Set
    End Property

    Public Property naolancareceber As Boolean
        Get
            Return _naolancareceber
        End Get
        Set(value As Boolean)
            _naolancareceber = value
        End Set
    End Property
End Class
