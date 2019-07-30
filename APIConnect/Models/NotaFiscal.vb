Public Class NotaFiscal
    Private _codnota As String
    Private _codemitente As Long
    Private _codtipo As Byte
    Private _codcliente As Long
    Private _nomecliente As String
    Private _cgccpf As String
    Private _marc As Boolean
    Private _cnpj As String
    Private _cpf As String
    Private _endereco As String
    Private _cep As String
    Private _codcidade As Long
    Private _bairro As String
    Private _fonefax As String
    Private _inscesta As String
    Private _saida As String
    Private _venda As String
    Private _materia As String
    Private _dataemissao As Date
    Private _datasaida As Date
    Private _hora As Date
    Private _codinstituicao As Byte
    Private _praca As String
    Private _fatura As String
    Private _vencimento As Date
    Private _valor As Double
    Private _baseicms As Double
    Private _valoricms As Double
    Private _icmssub As Double
    Private _valoricmssub As Double
    Private _valordosprodutos As Double
    Private _valorseguro As Double
    Private _despesas As Double
    Private _valordoipi As Double
    Private _codtransportador As Long
    Private _valorfrete As Double
    Private _valornota As Double
    Private _observacao As String
    Private _pesobruto As Long
    Private _pesoliquido As Long
    Private _quantidade As Integer
    Private _especie As String
    Private _marca As String
    Private _numero As String
    Private _complemento As String
    Private _codvendedor As String
    Private _firma As String
    Private _desconto As Single
    Private _cf As String
    Private _tran As String
    Private _cancela As Boolean
    Private _simnao As Boolean
    Private _nnota As String
    Private _dupli As Boolean
    Private _norconti As String
    Private _chave As String
    Private _protocolo As String
    Private _recibo As String
    Private _emidesti As String
    Private _issqn As Double
    Private _vissqn As Double
    Private _pedido As Long
    Private _protocoloc As String
    Private _envemail As Boolean
    Private _notaref As String
    Private _chaveref As String
    Private _obsfisco As String
    Private _justicancelamento As String
    Private _funrural As Double
    Private _reajustadas As Double
    Private _valorfun As Double
    Private _valortributos As Double
    Private _totaltributos As Double
    Private _agrupa As Boolean
    Private _codpgto As Long
    Private _baseimpo As Double
    Private _desaduaneira As Double
    Private _valoimpor As Double
    Private _valoriof As Double
    Private _gerabloqueto As Boolean
    Private _finalidade As String
    Private _presencial As String
    Private _destioperacao As String
    Private _codplanocontas As Long
    Private _codcentrocustos As String
    Private _emailnota As String
    Private _ccocupom As String
    Private _placavei As String
    Private _operacaosefaz As Boolean
    Private _estonodenfe As Boolean

    Public Property codnota As String
        Get
            Return _codnota
        End Get
        Set(value As String)
            _codnota = value
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

    Public Property codtipo As Byte
        Get
            Return _codtipo
        End Get
        Set(value As Byte)
            _codtipo = value
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

    Public Property nomecliente As String
        Get
            Return _nomecliente
        End Get
        Set(value As String)
            _nomecliente = value
        End Set
    End Property

    Public Property cgccpf As String
        Get
            Return _cgccpf
        End Get
        Set(value As String)
            _cgccpf = value
        End Set
    End Property

    Public Property marc As Boolean
        Get
            Return _marc
        End Get
        Set(value As Boolean)
            _marc = value
        End Set
    End Property

    Public Property cnpj As String
        Get
            Return _cnpj
        End Get
        Set(value As String)
            _cnpj = value
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

    Public Property endereco As String
        Get
            Return _endereco
        End Get
        Set(value As String)
            _endereco = value
        End Set
    End Property

    Public Property cep As String
        Get
            Return _cep
        End Get
        Set(value As String)
            _cep = value
        End Set
    End Property

    Public Property codcidade As Long
        Get
            Return _codcidade
        End Get
        Set(value As Long)
            _codcidade = value
        End Set
    End Property

    Public Property bairro As String
        Get
            Return _bairro
        End Get
        Set(value As String)
            _bairro = value
        End Set
    End Property

    Public Property fonefax As String
        Get
            Return _fonefax
        End Get
        Set(value As String)
            _fonefax = value
        End Set
    End Property

    Public Property inscesta As String
        Get
            Return _inscesta
        End Get
        Set(value As String)
            _inscesta = value
        End Set
    End Property

    Public Property saida As String
        Get
            Return _saida
        End Get
        Set(value As String)
            _saida = value
        End Set
    End Property

    Public Property venda As String
        Get
            Return _venda
        End Get
        Set(value As String)
            _venda = value
        End Set
    End Property

    Public Property materia As String
        Get
            Return _materia
        End Get
        Set(value As String)
            _materia = value
        End Set
    End Property

    Public Property dataemissao As Date
        Get
            Return _dataemissao
        End Get
        Set(value As Date)
            _dataemissao = value
        End Set
    End Property

    Public Property datasaida As Date
        Get
            Return _datasaida
        End Get
        Set(value As Date)
            _datasaida = value
        End Set
    End Property

    Public Property hora As Date
        Get
            Return _hora
        End Get
        Set(value As Date)
            _hora = value
        End Set
    End Property

    Public Property codinstituicao As Byte
        Get
            Return _codinstituicao
        End Get
        Set(value As Byte)
            _codinstituicao = value
        End Set
    End Property

    Public Property praca As String
        Get
            Return _praca
        End Get
        Set(value As String)
            _praca = value
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

    Public Property vencimento As Date
        Get
            Return _vencimento
        End Get
        Set(value As Date)
            _vencimento = value
        End Set
    End Property

    Public Property valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property

    Public Property baseicms As Double
        Get
            Return _baseicms
        End Get
        Set(value As Double)
            _baseicms = value
        End Set
    End Property

    Public Property valoricms As Double
        Get
            Return _valoricms
        End Get
        Set(value As Double)
            _valoricms = value
        End Set
    End Property

    Public Property icmssub As Double
        Get
            Return _icmssub
        End Get
        Set(value As Double)
            _icmssub = value
        End Set
    End Property

    Public Property valoricmssub As Double
        Get
            Return _valoricmssub
        End Get
        Set(value As Double)
            _valoricmssub = value
        End Set
    End Property

    Public Property valordosprodutos As Double
        Get
            Return _valordosprodutos
        End Get
        Set(value As Double)
            _valordosprodutos = value
        End Set
    End Property

    Public Property valorseguro As Double
        Get
            Return _valorseguro
        End Get
        Set(value As Double)
            _valorseguro = value
        End Set
    End Property

    Public Property despesas As Double
        Get
            Return _despesas
        End Get
        Set(value As Double)
            _despesas = value
        End Set
    End Property

    Public Property valordoipi As Double
        Get
            Return _valordoipi
        End Get
        Set(value As Double)
            _valordoipi = value
        End Set
    End Property

    Public Property codtransportador As Long
        Get
            Return _codtransportador
        End Get
        Set(value As Long)
            _codtransportador = value
        End Set
    End Property

    Public Property valorfrete As Double
        Get
            Return _valorfrete
        End Get
        Set(value As Double)
            _valorfrete = value
        End Set
    End Property

    Public Property valornota As Double
        Get
            Return _valornota
        End Get
        Set(value As Double)
            _valornota = value
        End Set
    End Property

    Public Property observacao As String
        Get
            Return _observacao
        End Get
        Set(value As String)
            _observacao = value
        End Set
    End Property

    Public Property pesobruto As Long
        Get
            Return _pesobruto
        End Get
        Set(value As Long)
            _pesobruto = value
        End Set
    End Property

    Public Property pesoliquido As Long
        Get
            Return _pesoliquido
        End Get
        Set(value As Long)
            _pesoliquido = value
        End Set
    End Property

    Public Property quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property

    Public Property especie As String
        Get
            Return _especie
        End Get
        Set(value As String)
            _especie = value
        End Set
    End Property

    Public Property marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property

    Public Property complemento As String
        Get
            Return _complemento
        End Get
        Set(value As String)
            _complemento = value
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

    Public Property firma As String
        Get
            Return _firma
        End Get
        Set(value As String)
            _firma = value
        End Set
    End Property

    Public Property desconto As Single
        Get
            Return _desconto
        End Get
        Set(value As Single)
            _desconto = value
        End Set
    End Property

    Public Property cf As String
        Get
            Return _cf
        End Get
        Set(value As String)
            _cf = value
        End Set
    End Property

    Public Property tran As String
        Get
            Return _tran
        End Get
        Set(value As String)
            _tran = value
        End Set
    End Property

    Public Property cancela As Boolean
        Get
            Return _cancela
        End Get
        Set(value As Boolean)
            _cancela = value
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

    Public Property nnota As String
        Get
            Return _nnota
        End Get
        Set(value As String)
            _nnota = value
        End Set
    End Property

    Public Property dupli As Boolean
        Get
            Return _dupli
        End Get
        Set(value As Boolean)
            _dupli = value
        End Set
    End Property

    Public Property norconti As String
        Get
            Return _norconti
        End Get
        Set(value As String)
            _norconti = value
        End Set
    End Property

    Public Property chave As String
        Get
            Return _chave
        End Get
        Set(value As String)
            _chave = value
        End Set
    End Property

    Public Property protocolo As String
        Get
            Return _protocolo
        End Get
        Set(value As String)
            _protocolo = value
        End Set
    End Property

    Public Property recibo As String
        Get
            Return _recibo
        End Get
        Set(value As String)
            _recibo = value
        End Set
    End Property

    Public Property emidesti As String
        Get
            Return _emidesti
        End Get
        Set(value As String)
            _emidesti = value
        End Set
    End Property

    Public Property issqn As Double
        Get
            Return _issqn
        End Get
        Set(value As Double)
            _issqn = value
        End Set
    End Property

    Public Property vissqn As Double
        Get
            Return _vissqn
        End Get
        Set(value As Double)
            _vissqn = value
        End Set
    End Property

    Public Property pedido As Long
        Get
            Return _pedido
        End Get
        Set(value As Long)
            _pedido = value
        End Set
    End Property

    Public Property protocoloc As String
        Get
            Return _protocoloc
        End Get
        Set(value As String)
            _protocoloc = value
        End Set
    End Property

    Public Property envemail As Boolean
        Get
            Return _envemail
        End Get
        Set(value As Boolean)
            _envemail = value
        End Set
    End Property

    Public Property notaref As String
        Get
            Return _notaref
        End Get
        Set(value As String)
            _notaref = value
        End Set
    End Property

    Public Property chaveref As String
        Get
            Return _chaveref
        End Get
        Set(value As String)
            _chaveref = value
        End Set
    End Property

    Public Property obsfisco As String
        Get
            Return _obsfisco
        End Get
        Set(value As String)
            _obsfisco = value
        End Set
    End Property

    Public Property justicancelamento As String
        Get
            Return _justicancelamento
        End Get
        Set(value As String)
            _justicancelamento = value
        End Set
    End Property

    Public Property funrural As Double
        Get
            Return _funrural
        End Get
        Set(value As Double)
            _funrural = value
        End Set
    End Property

    Public Property reajustadas As Double
        Get
            Return _reajustadas
        End Get
        Set(value As Double)
            _reajustadas = value
        End Set
    End Property

    Public Property valorfun As Double
        Get
            Return _valorfun
        End Get
        Set(value As Double)
            _valorfun = value
        End Set
    End Property

    Public Property valortributos As Double
        Get
            Return _valortributos
        End Get
        Set(value As Double)
            _valortributos = value
        End Set
    End Property

    Public Property totaltributos As Double
        Get
            Return _totaltributos
        End Get
        Set(value As Double)
            _totaltributos = value
        End Set
    End Property

    Public Property agrupa As Boolean
        Get
            Return _agrupa
        End Get
        Set(value As Boolean)
            _agrupa = value
        End Set
    End Property

    Public Property codpgto As Long
        Get
            Return _codpgto
        End Get
        Set(value As Long)
            _codpgto = value
        End Set
    End Property

    Public Property baseimpo As Double
        Get
            Return _baseimpo
        End Get
        Set(value As Double)
            _baseimpo = value
        End Set
    End Property

    Public Property desaduaneira As Double
        Get
            Return _desaduaneira
        End Get
        Set(value As Double)
            _desaduaneira = value
        End Set
    End Property

    Public Property valoimpor As Double
        Get
            Return _valoimpor
        End Get
        Set(value As Double)
            _valoimpor = value
        End Set
    End Property

    Public Property valoriof As Double
        Get
            Return _valoriof
        End Get
        Set(value As Double)
            _valoriof = value
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

    Public Property finalidade As String
        Get
            Return _finalidade
        End Get
        Set(value As String)
            _finalidade = value
        End Set
    End Property

    Public Property presencial As String
        Get
            Return _presencial
        End Get
        Set(value As String)
            _presencial = value
        End Set
    End Property

    Public Property destioperacao As String
        Get
            Return _destioperacao
        End Get
        Set(value As String)
            _destioperacao = value
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

    Public Property emailnota As String
        Get
            Return _emailnota
        End Get
        Set(value As String)
            _emailnota = value
        End Set
    End Property

    Public Property ccocupom As String
        Get
            Return _ccocupom
        End Get
        Set(value As String)
            _ccocupom = value
        End Set
    End Property

    Public Property placavei As String
        Get
            Return _placavei
        End Get
        Set(value As String)
            _placavei = value
        End Set
    End Property

    Public Property operacaosefaz As Boolean
        Get
            Return _operacaosefaz
        End Get
        Set(value As Boolean)
            _operacaosefaz = value
        End Set
    End Property

    Public Property estonodenfe As Boolean
        Get
            Return _estonodenfe
        End Get
        Set(value As Boolean)
            _estonodenfe = value
        End Set
    End Property
End Class