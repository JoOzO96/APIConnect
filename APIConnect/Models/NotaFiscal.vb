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
    Private _endereço As String
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

    Public Property Codnota As String
        Get
            Return _codnota
        End Get
        Set(value As String)
            _codnota = value
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

    Public Property Codtipo As Byte
        Get
            Return _codtipo
        End Get
        Set(value As Byte)
            _codtipo = value
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

    Public Property Nomecliente As String
        Get
            Return _nomecliente
        End Get
        Set(value As String)
            _nomecliente = value
        End Set
    End Property

    Public Property Cgccpf As String
        Get
            Return _cgccpf
        End Get
        Set(value As String)
            _cgccpf = value
        End Set
    End Property

    Public Property Marc As Boolean
        Get
            Return _marc
        End Get
        Set(value As Boolean)
            _marc = value
        End Set
    End Property

    Public Property Cnpj As String
        Get
            Return _cnpj
        End Get
        Set(value As String)
            _cnpj = value
        End Set
    End Property

    Public Property Cpf As String
        Get
            Return _cpf
        End Get
        Set(value As String)
            _cpf = value
        End Set
    End Property

    Public Property Endereço As String
        Get
            Return _endereço
        End Get
        Set(value As String)
            _endereço = value
        End Set
    End Property

    Public Property Cep As String
        Get
            Return _cep
        End Get
        Set(value As String)
            _cep = value
        End Set
    End Property

    Public Property Codcidade As Long
        Get
            Return _codcidade
        End Get
        Set(value As Long)
            _codcidade = value
        End Set
    End Property

    Public Property Bairro As String
        Get
            Return _bairro
        End Get
        Set(value As String)
            _bairro = value
        End Set
    End Property

    Public Property Fonefax As String
        Get
            Return _fonefax
        End Get
        Set(value As String)
            _fonefax = value
        End Set
    End Property

    Public Property Inscesta As String
        Get
            Return _inscesta
        End Get
        Set(value As String)
            _inscesta = value
        End Set
    End Property

    Public Property Saida As String
        Get
            Return _saida
        End Get
        Set(value As String)
            _saida = value
        End Set
    End Property

    Public Property Venda As String
        Get
            Return _venda
        End Get
        Set(value As String)
            _venda = value
        End Set
    End Property

    Public Property Materia As String
        Get
            Return _materia
        End Get
        Set(value As String)
            _materia = value
        End Set
    End Property

    Public Property Dataemissao As Date
        Get
            Return _dataemissao
        End Get
        Set(value As Date)
            _dataemissao = value
        End Set
    End Property

    Public Property Datasaida As Date
        Get
            Return _datasaida
        End Get
        Set(value As Date)
            _datasaida = value
        End Set
    End Property

    Public Property Hora As Date
        Get
            Return _hora
        End Get
        Set(value As Date)
            _hora = value
        End Set
    End Property

    Public Property Codinstituicao As Byte
        Get
            Return _codinstituicao
        End Get
        Set(value As Byte)
            _codinstituicao = value
        End Set
    End Property

    Public Property Praca As String
        Get
            Return _praca
        End Get
        Set(value As String)
            _praca = value
        End Set
    End Property

    Public Property Fatura As String
        Get
            Return _fatura
        End Get
        Set(value As String)
            _fatura = value
        End Set
    End Property

    Public Property Vencimento As Date
        Get
            Return _vencimento
        End Get
        Set(value As Date)
            _vencimento = value
        End Set
    End Property

    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property

    Public Property Baseicms As Double
        Get
            Return _baseicms
        End Get
        Set(value As Double)
            _baseicms = value
        End Set
    End Property

    Public Property Valoricms As Double
        Get
            Return _valoricms
        End Get
        Set(value As Double)
            _valoricms = value
        End Set
    End Property

    Public Property Icmssub As Double
        Get
            Return _icmssub
        End Get
        Set(value As Double)
            _icmssub = value
        End Set
    End Property

    Public Property Valoricmssub As Double
        Get
            Return _valoricmssub
        End Get
        Set(value As Double)
            _valoricmssub = value
        End Set
    End Property

    Public Property Valordosprodutos As Double
        Get
            Return _valordosprodutos
        End Get
        Set(value As Double)
            _valordosprodutos = value
        End Set
    End Property

    Public Property Valorseguro As Double
        Get
            Return _valorseguro
        End Get
        Set(value As Double)
            _valorseguro = value
        End Set
    End Property

    Public Property Despesas As Double
        Get
            Return _despesas
        End Get
        Set(value As Double)
            _despesas = value
        End Set
    End Property

    Public Property Valordoipi As Double
        Get
            Return _valordoipi
        End Get
        Set(value As Double)
            _valordoipi = value
        End Set
    End Property

    Public Property Codtransportador As Long
        Get
            Return _codtransportador
        End Get
        Set(value As Long)
            _codtransportador = value
        End Set
    End Property

    Public Property Valorfrete As Double
        Get
            Return _valorfrete
        End Get
        Set(value As Double)
            _valorfrete = value
        End Set
    End Property

    Public Property Valornota As Double
        Get
            Return _valornota
        End Get
        Set(value As Double)
            _valornota = value
        End Set
    End Property

    Public Property Observacao As String
        Get
            Return _observacao
        End Get
        Set(value As String)
            _observacao = value
        End Set
    End Property

    Public Property Pesobruto As Long
        Get
            Return _pesobruto
        End Get
        Set(value As Long)
            _pesobruto = value
        End Set
    End Property

    Public Property Pesoliquido As Long
        Get
            Return _pesoliquido
        End Get
        Set(value As Long)
            _pesoliquido = value
        End Set
    End Property

    Public Property Quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property

    Public Property Especie As String
        Get
            Return _especie
        End Get
        Set(value As String)
            _especie = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property

    Public Property Complemento As String
        Get
            Return _complemento
        End Get
        Set(value As String)
            _complemento = value
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

    Public Property Firma As String
        Get
            Return _firma
        End Get
        Set(value As String)
            _firma = value
        End Set
    End Property

    Public Property Desconto As Single
        Get
            Return _desconto
        End Get
        Set(value As Single)
            _desconto = value
        End Set
    End Property

    Public Property Cf As String
        Get
            Return _cf
        End Get
        Set(value As String)
            _cf = value
        End Set
    End Property

    Public Property Tran As String
        Get
            Return _tran
        End Get
        Set(value As String)
            _tran = value
        End Set
    End Property

    Public Property Cancela As Boolean
        Get
            Return _cancela
        End Get
        Set(value As Boolean)
            _cancela = value
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

    Public Property Nnota As String
        Get
            Return _nnota
        End Get
        Set(value As String)
            _nnota = value
        End Set
    End Property

    Public Property Dupli As Boolean
        Get
            Return _dupli
        End Get
        Set(value As Boolean)
            _dupli = value
        End Set
    End Property

    Public Property Norconti As String
        Get
            Return _norconti
        End Get
        Set(value As String)
            _norconti = value
        End Set
    End Property

    Public Property Chave As String
        Get
            Return _chave
        End Get
        Set(value As String)
            _chave = value
        End Set
    End Property

    Public Property Protocolo As String
        Get
            Return _protocolo
        End Get
        Set(value As String)
            _protocolo = value
        End Set
    End Property

    Public Property Recibo As String
        Get
            Return _recibo
        End Get
        Set(value As String)
            _recibo = value
        End Set
    End Property

    Public Property Emidesti As String
        Get
            Return _emidesti
        End Get
        Set(value As String)
            _emidesti = value
        End Set
    End Property

    Public Property Issqn As Double
        Get
            Return _issqn
        End Get
        Set(value As Double)
            _issqn = value
        End Set
    End Property

    Public Property Vissqn As Double
        Get
            Return _vissqn
        End Get
        Set(value As Double)
            _vissqn = value
        End Set
    End Property

    Public Property Pedido As Long
        Get
            Return _pedido
        End Get
        Set(value As Long)
            _pedido = value
        End Set
    End Property

    Public Property Protocoloc As String
        Get
            Return _protocoloc
        End Get
        Set(value As String)
            _protocoloc = value
        End Set
    End Property

    Public Property Envemail As Boolean
        Get
            Return _envemail
        End Get
        Set(value As Boolean)
            _envemail = value
        End Set
    End Property

    Public Property Notaref As String
        Get
            Return _notaref
        End Get
        Set(value As String)
            _notaref = value
        End Set
    End Property

    Public Property Chaveref As String
        Get
            Return _chaveref
        End Get
        Set(value As String)
            _chaveref = value
        End Set
    End Property

    Public Property Obsfisco As String
        Get
            Return _obsfisco
        End Get
        Set(value As String)
            _obsfisco = value
        End Set
    End Property

    Public Property Justicancelamento As String
        Get
            Return _justicancelamento
        End Get
        Set(value As String)
            _justicancelamento = value
        End Set
    End Property

    Public Property Funrural As Double
        Get
            Return _funrural
        End Get
        Set(value As Double)
            _funrural = value
        End Set
    End Property

    Public Property Reajustadas As Double
        Get
            Return _reajustadas
        End Get
        Set(value As Double)
            _reajustadas = value
        End Set
    End Property

    Public Property Valorfun As Double
        Get
            Return _valorfun
        End Get
        Set(value As Double)
            _valorfun = value
        End Set
    End Property

    Public Property Valortributos As Double
        Get
            Return _valortributos
        End Get
        Set(value As Double)
            _valortributos = value
        End Set
    End Property

    Public Property Totaltributos As Double
        Get
            Return _totaltributos
        End Get
        Set(value As Double)
            _totaltributos = value
        End Set
    End Property

    Public Property Agrupa As Boolean
        Get
            Return _agrupa
        End Get
        Set(value As Boolean)
            _agrupa = value
        End Set
    End Property

    Public Property Codpgto As Long
        Get
            Return _codpgto
        End Get
        Set(value As Long)
            _codpgto = value
        End Set
    End Property

    Public Property Baseimpo As Double
        Get
            Return _baseimpo
        End Get
        Set(value As Double)
            _baseimpo = value
        End Set
    End Property

    Public Property Desaduaneira As Double
        Get
            Return _desaduaneira
        End Get
        Set(value As Double)
            _desaduaneira = value
        End Set
    End Property

    Public Property Valoimpor As Double
        Get
            Return _valoimpor
        End Get
        Set(value As Double)
            _valoimpor = value
        End Set
    End Property

    Public Property Valoriof As Double
        Get
            Return _valoriof
        End Get
        Set(value As Double)
            _valoriof = value
        End Set
    End Property

    Public Property Gerabloqueto As Boolean
        Get
            Return _gerabloqueto
        End Get
        Set(value As Boolean)
            _gerabloqueto = value
        End Set
    End Property

    Public Property Finalidade As String
        Get
            Return _finalidade
        End Get
        Set(value As String)
            _finalidade = value
        End Set
    End Property

    Public Property Presencial As String
        Get
            Return _presencial
        End Get
        Set(value As String)
            _presencial = value
        End Set
    End Property

    Public Property Destioperacao As String
        Get
            Return _destioperacao
        End Get
        Set(value As String)
            _destioperacao = value
        End Set
    End Property

    Public Property Codplanocontas As Long
        Get
            Return _codplanocontas
        End Get
        Set(value As Long)
            _codplanocontas = value
        End Set
    End Property

    Public Property Codcentrocustos As String
        Get
            Return _codcentrocustos
        End Get
        Set(value As String)
            _codcentrocustos = value
        End Set
    End Property

    Public Property Emailnota As String
        Get
            Return _emailnota
        End Get
        Set(value As String)
            _emailnota = value
        End Set
    End Property

    Public Property Ccocupom As String
        Get
            Return _ccocupom
        End Get
        Set(value As String)
            _ccocupom = value
        End Set
    End Property

    Public Property Placavei As String
        Get
            Return _placavei
        End Get
        Set(value As String)
            _placavei = value
        End Set
    End Property

    Public Property Operacaosefaz As Boolean
        Get
            Return _operacaosefaz
        End Get
        Set(value As Boolean)
            _operacaosefaz = value
        End Set
    End Property

    Public Property Estonodenfe As Boolean
        Get
            Return _estonodenfe
        End Get
        Set(value As Boolean)
            _estonodenfe = value
        End Set
    End Property
End Class
