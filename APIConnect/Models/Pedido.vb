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
    Private _nfe As Boolean
    Private _dife As Long
    Private _comis As Double
    Private _vpago As Double
    Private _troco As Double
    Private _codhistorico As String
    Private _descvalor As Long
    Private _codmecanico As String
    Private _valorservico As Double
    Private _descoservico As Long
    Private _juntapedido As Boolean
    Private _km As String
    Private _nparc As Long
    Private _ncf As String
    Private _comi As Double
    Private _desvalor As Long
    Private _cpf As String
    Private _parce As Long
    Private _impressora As String
    Private _inicialp As Long
    Private _finalp As Long
    Private _totalp As Long
    Private _gerabloqueto As Boolean
    Private _gerabloqueto1 As Boolean
    Private _codplanocontas As Long
    Private _codcentrocustos As String
    Private _documento As Boolean
    Private _codproduto As String
    Private _mensagem As Boolean
    Private _estornop As Boolean
    Private _baixaf As Boolean
    Private _acreboleto As Long
    Private _aparelho As String
    Private _defeito As String
    Private _pedidoreferencia As Long
    Private _enderecopedido As String
    Private _nfce As Boolean
    Private _nfcee As Boolean
    Private _juridica As Boolean
    Private _ajuste As String
    Private _dataentrega As Date
    Private _nnotaservico As String
    Private _codbandeira As Long
    Private _orcamentofinalizado As Boolean
    Private _coddigitador As String
    Private _horasdemotor As Long
    Private _horasdetrilha As Long
    Private _especial As Boolean
    Private _carga As Boolean
    Private _enviadoemailnfse As Boolean
    Private _rota As String
    Private _geradoautomatico As Boolean
    Private _geradoexterno As Boolean

    Public Property pedido As Long
        Get
            Return _pedido
        End Get
        Set(value As Long)
            _pedido = value
        End Set
    End Property

    Public Property codpedido As Long
        Get
            Return _codpedido
        End Get
        Set(value As Long)
            _codpedido = value
        End Set
    End Property

    Public Property codcliente As Long
        Get
            Return _codcliente
        End Get
        Set(value As Long)
            _codcliente = value
        End Set
    End Property

    Public Property data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Public Property codvendedor As String
        Get
            Return _codvendedor
        End Get
        Set(value As String)
            _codvendedor = value
        End Set
    End Property

    Public Property formadepagamento As String
        Get
            Return _formadepagamento
        End Get
        Set(value As String)
            _formadepagamento = value
        End Set
    End Property

    Public Property frete As Double
        Get
            Return _frete
        End Get
        Set(value As Double)
            _frete = value
        End Set
    End Property

    Public Property valortotal As Double
        Get
            Return _valortotal
        End Get
        Set(value As Double)
            _valortotal = value
        End Set
    End Property

    Public Property entrada As Double
        Get
            Return _entrada
        End Get
        Set(value As Double)
            _entrada = value
        End Set
    End Property

    Public Property orpedi As String
        Get
            Return _orpedi
        End Get
        Set(value As String)
            _orpedi = value
        End Set
    End Property

    Public Property codbanco As Long
        Get
            Return _codbanco
        End Get
        Set(value As Long)
            _codbanco = value
        End Set
    End Property

    Public Property obs As String
        Get
            Return _obs
        End Get
        Set(value As String)
            _obs = value
        End Set
    End Property

    Public Property desconto As Long
        Get
            Return _desconto
        End Get
        Set(value As Long)
            _desconto = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property

    Public Property venci1 As Date
        Get
            Return _venci1
        End Get
        Set(value As Date)
            _venci1 = value
        End Set
    End Property

    Public Property valor1 As Double
        Get
            Return _valor1
        End Get
        Set(value As Double)
            _valor1 = value
        End Set
    End Property

    Public Property dias As Long
        Get
            Return _dias
        End Get
        Set(value As Long)
            _dias = value
        End Set
    End Property

    Public Property juro As Long
        Get
            Return _juro
        End Get
        Set(value As Long)
            _juro = value
        End Set
    End Property

    Public Property simnao As Boolean
        Get
            Return _simnao
        End Get
        Set(value As Boolean)
            _simnao = value
        End Set
    End Property

    Public Property pgto As Long
        Get
            Return _pgto
        End Get
        Set(value As Long)
            _pgto = value
        End Set
    End Property

    Public Property cheque As String
        Get
            Return _cheque
        End Get
        Set(value As String)
            _cheque = value
        End Set
    End Property

    Public Property data1 As Date
        Get
            Return _data1
        End Get
        Set(value As Date)
            _data1 = value
        End Set
    End Property

    Public Property notafisca As String
        Get
            Return _notafisca
        End Get
        Set(value As String)
            _notafisca = value
        End Set
    End Property

    Public Property via As Long
        Get
            Return _via
        End Get
        Set(value As Long)
            _via = value
        End Set
    End Property

    Public Property baixa As Boolean
        Get
            Return _baixa
        End Get
        Set(value As Boolean)
            _baixa = value
        End Set
    End Property

    Public Property veiculo As String
        Get
            Return _veiculo
        End Get
        Set(value As String)
            _veiculo = value
        End Set
    End Property

    Public Property placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property

    Public Property ano As String
        Get
            Return _ano
        End Get
        Set(value As String)
            _ano = value
        End Set
    End Property

    Public Property nparce As Long
        Get
            Return _nparce
        End Get
        Set(value As Long)
            _nparce = value
        End Set
    End Property

    Public Property codinstituicao As Long
        Get
            Return _codinstituicao
        End Get
        Set(value As Long)
            _codinstituicao = value
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

    Public Property codcaixa As Long
        Get
            Return _codcaixa
        End Get
        Set(value As Long)
            _codcaixa = value
        End Set
    End Property

    Public Property servicosolicitado As String
        Get
            Return _servicosolicitado
        End Get
        Set(value As String)
            _servicosolicitado = value
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

    Public Property codstatus As String
        Get
            Return _codstatus
        End Get
        Set(value As String)
            _codstatus = value
        End Set
    End Property

    Public Property nfe As Boolean
        Get
            Return _nfe
        End Get
        Set(value As Boolean)
            _nfe = value
        End Set
    End Property

    Public Property dife As Long
        Get
            Return _dife
        End Get
        Set(value As Long)
            _dife = value
        End Set
    End Property

    Public Property comis As Double
        Get
            Return _comis
        End Get
        Set(value As Double)
            _comis = value
        End Set
    End Property

    Public Property vpago As Double
        Get
            Return _vpago
        End Get
        Set(value As Double)
            _vpago = value
        End Set
    End Property

    Public Property troco As Double
        Get
            Return _troco
        End Get
        Set(value As Double)
            _troco = value
        End Set
    End Property

    Public Property codhistorico As String
        Get
            Return _codhistorico
        End Get
        Set(value As String)
            _codhistorico = value
        End Set
    End Property

    Public Property descvalor As Long
        Get
            Return _descvalor
        End Get
        Set(value As Long)
            _descvalor = value
        End Set
    End Property

    Public Property codmecanico As String
        Get
            Return _codmecanico
        End Get
        Set(value As String)
            _codmecanico = value
        End Set
    End Property

    Public Property valorservico As Double
        Get
            Return _valorservico
        End Get
        Set(value As Double)
            _valorservico = value
        End Set
    End Property

    Public Property descoservico As Long
        Get
            Return _descoservico
        End Get
        Set(value As Long)
            _descoservico = value
        End Set
    End Property

    Public Property juntapedido As Boolean
        Get
            Return _juntapedido
        End Get
        Set(value As Boolean)
            _juntapedido = value
        End Set
    End Property

    Public Property km As String
        Get
            Return _km
        End Get
        Set(value As String)
            _km = value
        End Set
    End Property

    Public Property nparc As Long
        Get
            Return _nparc
        End Get
        Set(value As Long)
            _nparc = value
        End Set
    End Property

    Public Property ncf As String
        Get
            Return _ncf
        End Get
        Set(value As String)
            _ncf = value
        End Set
    End Property

    Public Property comi As Double
        Get
            Return _comi
        End Get
        Set(value As Double)
            _comi = value
        End Set
    End Property

    Public Property desvalor As Long
        Get
            Return _desvalor
        End Get
        Set(value As Long)
            _desvalor = value
        End Set
    End Property

    Public Property cpf As String
        Get
            Return _cpf
        End Get
        Set(value As String)
            _cpf = value
        End Set
    End Property

    Public Property parce As Long
        Get
            Return _parce
        End Get
        Set(value As Long)
            _parce = value
        End Set
    End Property

    Public Property impressora As String
        Get
            Return _impressora
        End Get
        Set(value As String)
            _impressora = value
        End Set
    End Property

    Public Property inicialp As Long
        Get
            Return _inicialp
        End Get
        Set(value As Long)
            _inicialp = value
        End Set
    End Property

    Public Property finalp As Long
        Get
            Return _finalp
        End Get
        Set(value As Long)
            _finalp = value
        End Set
    End Property

    Public Property totalp As Long
        Get
            Return _totalp
        End Get
        Set(value As Long)
            _totalp = value
        End Set
    End Property

    Public Property gerabloqueto As Boolean
        Get
            Return _gerabloqueto
        End Get
        Set(value As Boolean)
            _gerabloqueto = value
        End Set
    End Property

    Public Property gerabloqueto1 As Boolean
        Get
            Return _gerabloqueto1
        End Get
        Set(value As Boolean)
            _gerabloqueto1 = value
        End Set
    End Property

    Public Property codplanocontas As Long
        Get
            Return _codplanocontas
        End Get
        Set(value As Long)
            _codplanocontas = value
        End Set
    End Property

    Public Property codcentrocustos As String
        Get
            Return _codcentrocustos
        End Get
        Set(value As String)
            _codcentrocustos = value
        End Set
    End Property

    Public Property documento As Boolean
        Get
            Return _documento
        End Get
        Set(value As Boolean)
            _documento = value
        End Set
    End Property

    Public Property codproduto As String
        Get
            Return _codproduto
        End Get
        Set(value As String)
            _codproduto = value
        End Set
    End Property

    Public Property mensagem As Boolean
        Get
            Return _mensagem
        End Get
        Set(value As Boolean)
            _mensagem = value
        End Set
    End Property

    Public Property estornop As Boolean
        Get
            Return _estornop
        End Get
        Set(value As Boolean)
            _estornop = value
        End Set
    End Property

    Public Property baixaf As Boolean
        Get
            Return _baixaf
        End Get
        Set(value As Boolean)
            _baixaf = value
        End Set
    End Property

    Public Property acreboleto As Long
        Get
            Return _acreboleto
        End Get
        Set(value As Long)
            _acreboleto = value
        End Set
    End Property

    Public Property aparelho As String
        Get
            Return _aparelho
        End Get
        Set(value As String)
            _aparelho = value
        End Set
    End Property

    Public Property defeito As String
        Get
            Return _defeito
        End Get
        Set(value As String)
            _defeito = value
        End Set
    End Property

    Public Property pedidoreferencia As Long
        Get
            Return _pedidoreferencia
        End Get
        Set(value As Long)
            _pedidoreferencia = value
        End Set
    End Property

    Public Property enderecopedido As String
        Get
            Return _enderecopedido
        End Get
        Set(value As String)
            _enderecopedido = value
        End Set
    End Property

    Public Property nfce As Boolean
        Get
            Return _nfce
        End Get
        Set(value As Boolean)
            _nfce = value
        End Set
    End Property

    Public Property nfcee As Boolean
        Get
            Return _nfcee
        End Get
        Set(value As Boolean)
            _nfcee = value
        End Set
    End Property

    Public Property juridica As Boolean
        Get
            Return _juridica
        End Get
        Set(value As Boolean)
            _juridica = value
        End Set
    End Property

    Public Property ajuste As String
        Get
            Return _ajuste
        End Get
        Set(value As String)
            _ajuste = value
        End Set
    End Property

    Public Property dataentrega As Date
        Get
            Return _dataentrega
        End Get
        Set(value As Date)
            _dataentrega = value
        End Set
    End Property

    Public Property nnotaservico As String
        Get
            Return _nnotaservico
        End Get
        Set(value As String)
            _nnotaservico = value
        End Set
    End Property

    Public Property codbandeira As Long
        Get
            Return _codbandeira
        End Get
        Set(value As Long)
            _codbandeira = value
        End Set
    End Property

    Public Property orcamentofinalizado As Boolean
        Get
            Return _orcamentofinalizado
        End Get
        Set(value As Boolean)
            _orcamentofinalizado = value
        End Set
    End Property

    Public Property coddigitador As String
        Get
            Return _coddigitador
        End Get
        Set(value As String)
            _coddigitador = value
        End Set
    End Property

    Public Property horasdemotor As Long
        Get
            Return _horasdemotor
        End Get
        Set(value As Long)
            _horasdemotor = value
        End Set
    End Property

    Public Property horasdetrilha As Long
        Get
            Return _horasdetrilha
        End Get
        Set(value As Long)
            _horasdetrilha = value
        End Set
    End Property

    Public Property especial As Boolean
        Get
            Return _especial
        End Get
        Set(value As Boolean)
            _especial = value
        End Set
    End Property

    Public Property carga As Boolean
        Get
            Return _carga
        End Get
        Set(value As Boolean)
            _carga = value
        End Set
    End Property

    Public Property enviadoemailnfse As Boolean
        Get
            Return _enviadoemailnfse
        End Get
        Set(value As Boolean)
            _enviadoemailnfse = value
        End Set
    End Property

    Public Property rota As String
        Get
            Return _rota
        End Get
        Set(value As String)
            _rota = value
        End Set
    End Property

    Public Property geradoautomatico As Boolean
        Get
            Return _geradoautomatico
        End Get
        Set(value As Boolean)
            _geradoautomatico = value
        End Set
    End Property

    Public Property geradoexterno As Boolean
        Get
            Return _geradoexterno
        End Get
        Set(value As Boolean)
            _geradoexterno = value
        End Set
    End Property
End Class
