Public Class ParcelasNFE
    Private _codnota As String
    Private _dvenci As Date
    Private _vparce As Double
    Private _nfc As String
    Private _fatura As String
    Private _codemitente As Long
    Private _diave As Long
    Private _valorboleto As Double
    Private _gerarboleto As Boolean

    Public Property codnota As String
        Get
            Return _codnota
        End Get
        Set(value As String)
            _codnota = value
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

    Public Property vparce As Double
        Get
            Return _vparce
        End Get
        Set(value As Double)
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

    Public Property fatura As String
        Get
            Return _fatura
        End Get
        Set(value As String)
            _fatura = value
        End Set
    End Property

    Public Property codemitente As Long
        Get
            Return _codemitente
        End Get
        Set(value As Long)
            _codemitente = value
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

    Public Property valorboleto As Double
        Get
            Return _valorboleto
        End Get
        Set(value As Double)
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
End Class
