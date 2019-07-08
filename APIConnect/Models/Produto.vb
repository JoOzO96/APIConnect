Public Class Produto
    Private _aliqcide As String
    Private _ano As String
    Private _anomodelo As String
    Private _anp As String
    Private _aplicacao As String   'Aplicação
    Private _ativo As String
    Private _carencia As String  'Carência
    Private _cfop As String
    Private _chassis As String
    Private _classe As String
    Private _codicms As String 'Cod Icms
    Private _codcest As String
    Private _codcofins As String 'CódCOFINS
    Private _codcofinse As String 'CódCOFINSE
    Private _codeauto As Boolean
    Private _codemitente As Integer
    Private _codfornecedor As String 'Cod Fornecedor
    Private _codgrupo As String 'Cod Grupo
    Private _codifeanp As String
    Private _codipi As String 'CódIPI
    Private _codipise As String 'CódIPISE
    Private _codpis As String 'CódPIS
    Private _codpise As String 'CódPisE
    Private _codproduto As String 'Cod Produto
    Private _codsubgrupo As String 'CódSubGrupo
    Private _combustivel As String
    Private _comentario As String 'Comentário
    Private _comissao As Single    'Comissão
    Private _compra As Boolean
    Private _concentracao As String 'Concentração
    Private _conversao As String
    Private _conversao1 As String
    Private _conversao2 As String
    Private _cor As String
    Private _cstcofins As String
    Private _cstcofinse As String
    Private _cstpis As String
    Private _cstpise As String
    Private _cusope As Single
    Private _custo As Decimal
    Private _custo1 As Decimal
    Private _custoimpostos As Decimal
    Private _custosobrelucro As Decimal
    Private _dataalte As Date
    Private _datacad As Date
    Private _datacompra As Date
    Private _datavencimentoprocuracao As Date
    Private _datavenda As Date
    Private _descobal As Single
    Private _desconto As Single
    Private _despesas As Decimal
    Private _dificms As Single 'Dif ICMS
    Private _divisao As Single
    Private _dosagem As String
    Private _ean As String
    Private _embala As String
    Private _equipamento As String
    Private _especietipo As String
    Private _fitoxidade As String
    Private _formulacao As String 'Formulação
    Private _frete As Single
    Private _imposobrelucro As Single
    Private _inativo As Boolean
    Private _infadicionais As String
    Private _infespecifica As String
    Private _ipi As Single
    Private _letras As String
    Private _locregistro As String
    Private _maquina As Boolean 'máquina
    Private _marca As String
    Private _markup As Decimal
    Private _maximo As Single 'máximo
    Private _mercadoria As String
    Private _minimo As Single
    Private _modelo As String
    Private _montapedido As Boolean
    Private _mva As Single
    Private _mvafora As Single
    Private _ncm As String
    Private _numero As String 'Número
    Private _numeroori As String
    Private _obs As String
    Private _obsproduto As String
    Private _oleosoja As Boolean
    Private _perconsumidor As Decimal
    Private _perprazo As Single 'Per Prazo
    Private _peso As Single
    Private _pesoc As Single
    Private _placa As String
    Private _porcofins As Double
    Private _porcofinse As Double
    Private _porpis As Double
    Private _porpise As Double
    Private _porsimples As Double
    Private _porsub As Double
    Private _prateleira As String
    Private _produtocereais As Boolean
    Private _produtoconversao As Boolean
    Private _produtonaofiscal As Boolean
    Private _produtotanque As Boolean
    Private _produtotrigo As Boolean
    Private _quantidade As Single
    Private _quantidadeconversao As Single
    Private _redu As Double
    Private _reentrada As String
    Private _renavan As String
    Private _sittrib As String
    Private _tamanho As String
    Private _taxafora As Double
    Private _tortasoja As Boolean
    Private _total As Decimal
    Private _toxidade As String
    Private _unid As String
    Private _vaca As Boolean
    Private _valodificms As Decimal
    Private _valoipi As Decimal
    Private _valorcompra As Decimal 'Valor Compra
    Private _valoravista As Decimal 'Valor Avista
    Private _valorconsumidor As Decimal
    Private _valorprazo As Decimal 'Valor Prazo
    Private _valortaxa As Decimal
    Private _vcofins As Decimal
    Private _vcofinse As Decimal
    Private _veiculo As Boolean
    Private _vfrete As Decimal
    Private _vimpsimples As Decimal
    Private _vpis As Decimal
    Private _vpise As Decimal
    Private _vsubsti As Decimal

    Public Property aliqcide As Decimal
        Get
            Return _aliqcide
        End Get
        Set(value As Decimal)
            _aliqcide = value
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

    Public Property anomodelo As String
        Get
            Return _anomodelo
        End Get
        Set(value As String)
            _anomodelo = value
        End Set
    End Property

    Public Property anp As String
        Get
            Return _anp
        End Get
        Set(value As String)
            _anp = value
        End Set
    End Property

    Public Property aplicacao As String
        Get
            Return _aplicacao
        End Get
        Set(value As String)
            _aplicacao = value
        End Set
    End Property

    Public Property ativo As String
        Get
            Return _ativo
        End Get
        Set(value As String)
            _ativo = value
        End Set
    End Property

    Public Property carencia As String
        Get
            Return _carencia
        End Get
        Set(value As String)
            _carencia = value
        End Set
    End Property

    Public Property cfop As String
        Get
            Return _cfop
        End Get
        Set(value As String)
            _cfop = value
        End Set
    End Property

    Public Property chassis As String
        Get
            Return _chassis
        End Get
        Set(value As String)
            _chassis = value
        End Set
    End Property

    Public Property classe As String
        Get
            Return _classe
        End Get
        Set(value As String)
            _classe = value
        End Set
    End Property

    Public Property codicms As String
        Get
            Return _codicms
        End Get
        Set(value As String)
            _codicms = value
        End Set
    End Property

    Public Property codcest As String
        Get
            Return _codcest
        End Get
        Set(value As String)
            _codcest = value
        End Set
    End Property

    Public Property codcofins As String
        Get
            Return _codcofins
        End Get
        Set(value As String)
            _codcofins = value
        End Set
    End Property

    Public Property codcofinse As String
        Get
            Return _codcofinse
        End Get
        Set(value As String)
            _codcofinse = value
        End Set
    End Property

    Public Property codeauto As Boolean
        Get
            Return _codeauto
        End Get
        Set(value As Boolean)
            _codeauto = value
        End Set
    End Property

    Public Property codemitente As Integer
        Get
            Return _codemitente
        End Get
        Set(value As Integer)
            _codemitente = value
        End Set
    End Property

    Public Property codfornecedor As String
        Get
            Return _codfornecedor
        End Get
        Set(value As String)
            _codfornecedor = value
        End Set
    End Property

    Public Property codgrupo As String
        Get
            Return _codgrupo
        End Get
        Set(value As String)
            _codgrupo = value
        End Set
    End Property

    Public Property codifeanp As String
        Get
            Return _codifeanp
        End Get
        Set(value As String)
            _codifeanp = value
        End Set
    End Property

    Public Property codipi As String
        Get
            Return _codipi
        End Get
        Set(value As String)
            _codipi = value
        End Set
    End Property

    Public Property codipise As String
        Get
            Return _codipise
        End Get
        Set(value As String)
            _codipise = value
        End Set
    End Property

    Public Property codpis As String
        Get
            Return _codpis
        End Get
        Set(value As String)
            _codpis = value
        End Set
    End Property

    Public Property codpise As String
        Get
            Return _codpise
        End Get
        Set(value As String)
            _codpise = value
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

    Public Property codsubgrupo As String
        Get
            Return _codsubgrupo
        End Get
        Set(value As String)
            _codsubgrupo = value
        End Set
    End Property

    Public Property combustivel As String
        Get
            Return _combustivel
        End Get
        Set(value As String)
            _combustivel = value
        End Set
    End Property

    Public Property comentario As String
        Get
            Return _comentario
        End Get
        Set(value As String)
            _comentario = value
        End Set
    End Property

    Public Property comissao As Single
        Get
            Return _comissao
        End Get
        Set(value As Single)
            _comissao = value
        End Set
    End Property

    Public Property compra As Boolean
        Get
            Return _compra
        End Get
        Set(value As Boolean)
            _compra = value
        End Set
    End Property

    Public Property concentracao As String
        Get
            Return _concentracao
        End Get
        Set(value As String)
            _concentracao = value
        End Set
    End Property

    Public Property conversao As String
        Get
            Return _conversao
        End Get
        Set(value As String)
            _conversao = value
        End Set
    End Property

    Public Property conversao1 As String
        Get
            Return _conversao1
        End Get
        Set(value As String)
            _conversao1 = value
        End Set
    End Property

    Public Property conversao2 As String
        Get
            Return _conversao2
        End Get
        Set(value As String)
            _conversao2 = value
        End Set
    End Property

    Public Property cOr As String
        Get
            Return _cor
        End Get
        Set(value As String)
            _cor = value
        End Set
    End Property

    Public Property cstcofins As String
        Get
            Return _cstcofins
        End Get
        Set(value As String)
            _cstcofins = value
        End Set
    End Property

    Public Property cstcofinse As String
        Get
            Return _cstcofinse
        End Get
        Set(value As String)
            _cstcofinse = value
        End Set
    End Property

    Public Property cstpis As String
        Get
            Return _cstpis
        End Get
        Set(value As String)
            _cstpis = value
        End Set
    End Property

    Public Property cstpise As String
        Get
            Return _cstpise
        End Get
        Set(value As String)
            _cstpise = value
        End Set
    End Property

    Public Property cusope As Single
        Get
            Return _cusope
        End Get
        Set(value As Single)
            _cusope = value
        End Set
    End Property

    Public Property custo As Decimal
        Get
            Return _custo
        End Get
        Set(value As Decimal)
            _custo = value
        End Set
    End Property

    Public Property custo1 As Decimal
        Get
            Return _custo1
        End Get
        Set(value As Decimal)
            _custo1 = value
        End Set
    End Property

    Public Property custoimpostos As Decimal
        Get
            Return _custoimpostos
        End Get
        Set(value As Decimal)
            _custoimpostos = value
        End Set
    End Property

    Public Property custosobrelucro As Decimal
        Get
            Return _custosobrelucro
        End Get
        Set(value As Decimal)
            _custosobrelucro = value
        End Set
    End Property

    Public Property dataalte As Date
        Get
            Return _dataalte
        End Get
        Set(value As Date)
            _dataalte = value
        End Set
    End Property

    Public Property datacad As Date
        Get
            Return _datacad
        End Get
        Set(value As Date)
            _datacad = value
        End Set
    End Property

    Public Property datacompra As Date
        Get
            Return _datacompra
        End Get
        Set(value As Date)
            _datacompra = value
        End Set
    End Property

    Public Property datavencimentoprocuracao As Date
        Get
            Return _datavencimentoprocuracao
        End Get
        Set(value As Date)
            _datavencimentoprocuracao = value
        End Set
    End Property

    Public Property datavenda As Date
        Get
            Return _datavenda
        End Get
        Set(value As Date)
            _datavenda = value
        End Set
    End Property

    Public Property descobal As Single
        Get
            Return _descobal
        End Get
        Set(value As Single)
            _descobal = value
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

    Public Property despesas As Decimal
        Get
            Return _despesas
        End Get
        Set(value As Decimal)
            _despesas = value
        End Set
    End Property

    Public Property dificms As Single
        Get
            Return _dificms
        End Get
        Set(value As Single)
            _dificms = value
        End Set
    End Property

    Public Property divisao As Single
        Get
            Return _divisao
        End Get
        Set(value As Single)
            _divisao = value
        End Set
    End Property

    Public Property dosagem As String
        Get
            Return _dosagem
        End Get
        Set(value As String)
            _dosagem = value
        End Set
    End Property

    Public Property ean As String
        Get
            Return _ean
        End Get
        Set(value As String)
            _ean = value
        End Set
    End Property

    Public Property embala As String
        Get
            Return _embala
        End Get
        Set(value As String)
            _embala = value
        End Set
    End Property

    Public Property equipamento As String
        Get
            Return _equipamento
        End Get
        Set(value As String)
            _equipamento = value
        End Set
    End Property

    Public Property especietipo As String
        Get
            Return _especietipo
        End Get
        Set(value As String)
            _especietipo = value
        End Set
    End Property

    Public Property fitoxidade As String
        Get
            Return _fitoxidade
        End Get
        Set(value As String)
            _fitoxidade = value
        End Set
    End Property

    Public Property formulacao As String
        Get
            Return _formulacao
        End Get
        Set(value As String)
            _formulacao = value
        End Set
    End Property

    Public Property frete As Single
        Get
            Return _frete
        End Get
        Set(value As Single)
            _frete = value
        End Set
    End Property

    Public Property imposobrelucro As Single
        Get
            Return _imposobrelucro
        End Get
        Set(value As Single)
            _imposobrelucro = value
        End Set
    End Property

    Public Property inativo As Boolean
        Get
            Return _inativo
        End Get
        Set(value As Boolean)
            _inativo = value
        End Set
    End Property

    Public Property infadicionais As String
        Get
            Return _infadicionais
        End Get
        Set(value As String)
            _infadicionais = value
        End Set
    End Property

    Public Property infespecifica As String
        Get
            Return _infespecifica
        End Get
        Set(value As String)
            _infespecifica = value
        End Set
    End Property

    Public Property ipi As Single
        Get
            Return _ipi
        End Get
        Set(value As Single)
            _ipi = value
        End Set
    End Property

    Public Property letras As String
        Get
            Return _letras
        End Get
        Set(value As String)
            _letras = value
        End Set
    End Property

    Public Property locregistro As String
        Get
            Return _locregistro
        End Get
        Set(value As String)
            _locregistro = value
        End Set
    End Property

    Public Property maquina As Boolean
        Get
            Return _maquina
        End Get
        Set(value As Boolean)
            _maquina = value
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

    Public Property markup As Decimal
        Get
            Return _markup
        End Get
        Set(value As Decimal)
            _markup = value
        End Set
    End Property

    Public Property maximo As Single
        Get
            Return _maximo
        End Get
        Set(value As Single)
            _maximo = value
        End Set
    End Property

    Public Property mercadoria As String
        Get
            Return _mercadoria
        End Get
        Set(value As String)
            _mercadoria = value
        End Set
    End Property

    Public Property minimo As Single
        Get
            Return _minimo
        End Get
        Set(value As Single)
            _minimo = value
        End Set
    End Property

    Public Property modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property montapedido As Boolean
        Get
            Return _montapedido
        End Get
        Set(value As Boolean)
            _montapedido = value
        End Set
    End Property

    Public Property mva As Single
        Get
            Return _mva
        End Get
        Set(value As Single)
            _mva = value
        End Set
    End Property

    Public Property mvafora As Single
        Get
            Return _mvafora
        End Get
        Set(value As Single)
            _mvafora = value
        End Set
    End Property

    Public Property ncm As String
        Get
            Return _ncm
        End Get
        Set(value As String)
            _ncm = value
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

    Public Property numeroori As String
        Get
            Return _numeroori
        End Get
        Set(value As String)
            _numeroori = value
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

    Public Property obsproduto As String
        Get
            Return _obsproduto
        End Get
        Set(value As String)
            _obsproduto = value
        End Set
    End Property

    Public Property oleosoja As Boolean
        Get
            Return _oleosoja
        End Get
        Set(value As Boolean)
            _oleosoja = value
        End Set
    End Property

    Public Property perconsumidor As Decimal
        Get
            Return _perconsumidor
        End Get
        Set(value As Decimal)
            _perconsumidor = value
        End Set
    End Property

    Public Property perprazo As Single
        Get
            Return _perprazo
        End Get
        Set(value As Single)
            _perprazo = value
        End Set
    End Property

    Public Property peso As Single
        Get
            Return _peso
        End Get
        Set(value As Single)
            _peso = value
        End Set
    End Property

    Public Property pesoc As Single
        Get
            Return _pesoc
        End Get
        Set(value As Single)
            _pesoc = value
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

    Public Property porcofins As Double
        Get
            Return _porcofins
        End Get
        Set(value As Double)
            _porcofins = value
        End Set
    End Property

    Public Property porcofinse As Double
        Get
            Return _porcofinse
        End Get
        Set(value As Double)
            _porcofinse = value
        End Set
    End Property

    Public Property porpis As Double
        Get
            Return _porpis
        End Get
        Set(value As Double)
            _porpis = value
        End Set
    End Property

    Public Property porpise As Double
        Get
            Return _porpise
        End Get
        Set(value As Double)
            _porpise = value
        End Set
    End Property

    Public Property porsimples As Double
        Get
            Return _porsimples
        End Get
        Set(value As Double)
            _porsimples = value
        End Set
    End Property

    Public Property porsub As Double
        Get
            Return _porsub
        End Get
        Set(value As Double)
            _porsub = value
        End Set
    End Property

    Public Property prateleira As String
        Get
            Return _prateleira
        End Get
        Set(value As String)
            _prateleira = value
        End Set
    End Property

    Public Property produtocereais As Boolean
        Get
            Return _produtocereais
        End Get
        Set(value As Boolean)
            _produtocereais = value
        End Set
    End Property

    Public Property produtoconversao As Boolean
        Get
            Return _produtoconversao
        End Get
        Set(value As Boolean)
            _produtoconversao = value
        End Set
    End Property

    Public Property produtonaofiscal As Boolean
        Get
            Return _produtonaofiscal
        End Get
        Set(value As Boolean)
            _produtonaofiscal = value
        End Set
    End Property

    Public Property produtotanque As Boolean
        Get
            Return _produtotanque
        End Get
        Set(value As Boolean)
            _produtotanque = value
        End Set
    End Property

    Public Property produtotrigo As Boolean
        Get
            Return _produtotrigo
        End Get
        Set(value As Boolean)
            _produtotrigo = value
        End Set
    End Property

    Public Property quantidade As Single
        Get
            Return _quantidade
        End Get
        Set(value As Single)
            _quantidade = value
        End Set
    End Property

    Public Property quantidadeconversao As Single
        Get
            Return _quantidadeconversao
        End Get
        Set(value As Single)
            _quantidadeconversao = value
        End Set
    End Property

    Public Property redu As Double
        Get
            Return _redu
        End Get
        Set(value As Double)
            _redu = value
        End Set
    End Property

    Public Property reentrada As String
        Get
            Return _reentrada
        End Get
        Set(value As String)
            _reentrada = value
        End Set
    End Property

    Public Property renavan As String
        Get
            Return _renavan
        End Get
        Set(value As String)
            _renavan = value
        End Set
    End Property

    Public Property sittrib As String
        Get
            Return _sittrib
        End Get
        Set(value As String)
            _sittrib = value
        End Set
    End Property

    Public Property tamanho As String
        Get
            Return _tamanho
        End Get
        Set(value As String)
            _tamanho = value
        End Set
    End Property

    Public Property taxafora As Double
        Get
            Return _taxafora
        End Get
        Set(value As Double)
            _taxafora = value
        End Set
    End Property

    Public Property tortasoja As Boolean
        Get
            Return _tortasoja
        End Get
        Set(value As Boolean)
            _tortasoja = value
        End Set
    End Property

    Public Property total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property

    Public Property toxidade As String
        Get
            Return _toxidade
        End Get
        Set(value As String)
            _toxidade = value
        End Set
    End Property

    Public Property unid As String
        Get
            Return _unid
        End Get
        Set(value As String)
            _unid = value
        End Set
    End Property

    Public Property vaca As Boolean
        Get
            Return _vaca
        End Get
        Set(value As Boolean)
            _vaca = value
        End Set
    End Property

    Public Property valodificms As Decimal
        Get
            Return _valodificms
        End Get
        Set(value As Decimal)
            _valodificms = value
        End Set
    End Property

    Public Property valoipi As Decimal
        Get
            Return _valoipi
        End Get
        Set(value As Decimal)
            _valoipi = value
        End Set
    End Property

    Public Property valorcompra As Decimal
        Get
            Return _valorcompra
        End Get
        Set(value As Decimal)
            _valorcompra = value
        End Set
    End Property

    Public Property valoravista As Decimal
        Get
            Return _valoravista
        End Get
        Set(value As Decimal)
            _valoravista = value
        End Set
    End Property

    Public Property valorconsumidor As Decimal
        Get
            Return _valorconsumidor
        End Get
        Set(value As Decimal)
            _valorconsumidor = value
        End Set
    End Property

    Public Property valorprazo As Decimal
        Get
            Return _valorprazo
        End Get
        Set(value As Decimal)
            _valorprazo = value
        End Set
    End Property

    Public Property valortaxa As Decimal
        Get
            Return _valortaxa
        End Get
        Set(value As Decimal)
            _valortaxa = value
        End Set
    End Property

    Public Property vcofins As Decimal
        Get
            Return _vcofins
        End Get
        Set(value As Decimal)
            _vcofins = value
        End Set
    End Property

    Public Property vcofinse As Decimal
        Get
            Return _vcofinse
        End Get
        Set(value As Decimal)
            _vcofinse = value
        End Set
    End Property

    Public Property veiculo As Boolean
        Get
            Return _veiculo
        End Get
        Set(value As Boolean)
            _veiculo = value
        End Set
    End Property

    Public Property vfrete As Decimal
        Get
            Return _vfrete
        End Get
        Set(value As Decimal)
            _vfrete = value
        End Set
    End Property

    Public Property vimpsimples As Decimal
        Get
            Return _vimpsimples
        End Get
        Set(value As Decimal)
            _vimpsimples = value
        End Set
    End Property

    Public Property vpis As Decimal
        Get
            Return _vpis
        End Get
        Set(value As Decimal)
            _vpis = value
        End Set
    End Property

    Public Property vpise As Decimal
        Get
            Return _vpise
        End Get
        Set(value As Decimal)
            _vpise = value
        End Set
    End Property

    Public Property vsubsti As Decimal
        Get
            Return _vsubsti
        End Get
        Set(value As Decimal)
            _vsubsti = value
        End Set
    End Property
End Class
