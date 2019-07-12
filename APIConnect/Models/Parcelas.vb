Public Class Parcelas

    Private _codpedido As Long
    Private _dvenci As Date
    Private _vparce As Single
    Private _nfc As String
    Private _diave As Long
    Private _fatura As String
    Private _valorboleto As Single
    Private _gerarboleto As Boolean
    Private _codbanco As Byte

    Public Property codpedido As Long
        Get
            Return _codpedido
        End Get
        Set(value As Long)
            _codpedido = value
        End Set
    End Property

    Public Property dvenci As Date
        Get
            Return _dvenci
        End Get
        Set(value As Date)
            _dvenci = value
        End Set
    End Property

    Public Property vparce As Single
        Get
            Return _vparce
        End Get
        Set(value As Single)
            _vparce = value
        End Set
    End Property

    Public Property nfc As String
        Get
            Return _nfc
        End Get
        Set(value As String)
            _nfc = value
        End Set
    End Property

    Public Property diave As Long
        Get
            Return _diave
        End Get
        Set(value As Long)
            _diave = value
        End Set
    End Property

    Public Property fatura As String
        Get
            Return _fatura
        End Get
        Set(value As String)
            _fatura = value
        End Set
    End Property

    Public Property valorboleto As Single
        Get
            Return _valorboleto
        End Get
        Set(value As Single)
            _valorboleto = value
        End Set
    End Property

    Public Property gerarboleto As Boolean
        Get
            Return _gerarboleto
        End Get
        Set(value As Boolean)
            _gerarboleto = value
        End Set
    End Property

    Public Property codbanco As Byte
        Get
            Return _codbanco
        End Get
        Set(value As Byte)
            _codbanco = value
        End Set
    End Property
End Class
