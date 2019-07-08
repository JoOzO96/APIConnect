Public Class Pedido
    Private _pedido As Long
    Private _codpedido As Long
    Private _codcliente As Long
    Private _data As Date
    Private _codvendedor As String
    Private _formadepagamento As String
    Private _frete As Double
    Private _valortotal As Double
    Private _entrada As Double
    Private _orpedi As String
    Private _codbanco As Long
    Private _obs As String
    Private _desconto As Long
    Private _nome As String
    Private _total As Double
    Private _venci1 As Date
    Private _valor1 As Double
    Private _dias As Long
    Private _juro As Long
    Private _simnao As Boolean
    Private _pgto As Long
    Private _cheque As String
    Private _data1 As Date
    Private _notafisca As String
    Private _via As Long
    Private _baixa As Boolean
    Private _veiculo As String
    Private _placa As String
    Private _ano As String
    Private _nparce As Long
    Private _codinstituicao As Long
    Private _nfc As String
    Private _codcaixa As Long
    Private _codemitente As Long
    Private _codstatus As String
    Private _servicosolicitado As String

    Public Property Pedido As Long
        Get
            Return _pedido
        End Get
        Set(value As Long)
            _pedido = value
        End Set
    End Property

    Public Property Codpedido As Long
        Get
            Return _codpedido
        End Get
        Set(value As Long)
            _codpedido = value
        End Set
    End Property

    Public Property Codcliente As Long
        Get
            Return _codcliente
        End Get
        Set(value As Long)
            _codcliente = value
        End Set
    End Property

    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Public Property Codvendedor As String
        Get
            Return _codvendedor
        End Get
        Set(value As String)
            _codvendedor = value
        End Set
    End Property

    Public Property Formadepagamento As String
        Get
            Return _formadepagamento
        End Get
        Set(value As String)
            _formadepagamento = value
        End Set
    End Property

    Public Property Frete As Double
        Get
            Return _frete
        End Get
        Set(value As Double)
            _frete = value
        End Set
    End Property

    Public Property Valortotal As Double
        Get
            Return _valortotal
        End Get
        Set(value As Double)
            _valortotal = value
        End Set
    End Property

    Public Property Entrada As Double
        Get
            Return _entrada
        End Get
        Set(value As Double)
            _entrada = value
        End Set
    End Property

    Public Property Orpedi As String
        Get
            Return _orpedi
        End Get
        Set(value As String)
            _orpedi = value
        End Set
    End Property

    Public Property Codbanco As Long
        Get
            Return _codbanco
        End Get
        Set(value As Long)
            _codbanco = value
        End Set
    End Property

    Public Property Obs As String
        Get
            Return _obs
        End Get
        Set(value As String)
            _obs = value
        End Set
    End Property

    Public Property Desconto As Long
        Get
            Return _desconto
        End Get
        Set(value As Long)
            _desconto = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property

    Public Property Venci1 As Date
        Get
            Return _venci1
        End Get
        Set(value As Date)
            _venci1 = value
        End Set
    End Property

    Public Property Valor1 As Double
        Get
            Return _valor1
        End Get
        Set(value As Double)
            _valor1 = value
        End Set
    End Property

    Public Property Dias As Long
        Get
            Return _dias
        End Get
        Set(value As Long)
            _dias = value
        End Set
    End Property

    Public Property Juro As Long
        Get
            Return _juro
        End Get
        Set(value As Long)
            _juro = value
        End Set
    End Property

    Public Property Simnao As Boolean
        Get
            Return _simnao
        End Get
        Set(value As Boolean)
            _simnao = value
        End Set
    End Property

    Public Property Pgto As Long
        Get
            Return _pgto
        End Get
        Set(value As Long)
            _pgto = value
        End Set
    End Property

    Public Property Cheque As String
        Get
            Return _cheque
        End Get
        Set(value As String)
            _cheque = value
        End Set
    End Property

    Public Property Data1 As Date
        Get
            Return _data1
        End Get
        Set(value As Date)
            _data1 = value
        End Set
    End Property

    Public Property Notafisca As String
        Get
            Return _notafisca
        End Get
        Set(value As String)
            _notafisca = value
        End Set
    End Property

    Public Property Via As Long
        Get
            Return _via
        End Get
        Set(value As Long)
            _via = value
        End Set
    End Property

    Public Property Baixa As Boolean
        Get
            Return _baixa
        End Get
        Set(value As Boolean)
            _baixa = value
        End Set
    End Property

    Public Property Veiculo As String
        Get
            Return _veiculo
        End Get
        Set(value As String)
            _veiculo = value
        End Set
    End Property

    Public Property Placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property

    Public Property Ano As String
        Get
            Return _ano
        End Get
        Set(value As String)
            _ano = value
        End Set
    End Property

    Public Property Nparce As Long
        Get
            Return _nparce
        End Get
        Set(value As Long)
            _nparce = value
        End Set
    End Property

    Public Property Codinstituicao As Long
        Get
            Return _codinstituicao
        End Get
        Set(value As Long)
            _codinstituicao = value
        End Set
    End Property

    Public Property Nfc As String
        Get
            Return _nfc
        End Get
        Set(value As String)
            _nfc = value
        End Set
    End Property

    Public Property Codcaixa As Long
        Get
            Return _codcaixa
        End Get
        Set(value As Long)
            _codcaixa = value
        End Set
    End Property

    Public Property Servicosolicitado As String
        Get
            Return _servicosolicitado
        End Get
        Set(value As String)
            _servicosolicitado = value
        End Set
    End Property

    Public Property Codemitente As Long
        Get
            Return _codemitente
        End Get
        Set(value As Long)
            _codemitente = value
        End Set
    End Property

    Public Property Codstatus As String
        Get
            Return _codstatus
        End Get
        Set(value As String)
            _codstatus = value
        End Set
    End Property
End Class
