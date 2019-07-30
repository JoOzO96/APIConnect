Public Class Emitente
    Private _carne As Boolean
    Private _numerocaracter As Long
    Private _serie As String
    Private _pedisimples As Boolean
    Private _entradaresumida As Boolean
    Private _industria As Boolean
    Private _tipoetiqueta As String
    Private _mostratamanho As Boolean
    Private _recibofiscal As Boolean
    Private _placacf As Boolean
    Private _precopedido As Boolean
    Private _pedidofiscal As Boolean
    Private _servicocupom As Boolean
    Private _margeminferior As Long
    Private _mostrarservico As Boolean
    Private _orgaestoque As Boolean
    Private _liberadatare As Boolean
    Private _emitentepadrao As Boolean
    Private _emitentenfce As Boolean
    Private _tokennfce As String
    Private _pincerti As String
    Private _liberacaixa As Boolean
    Private _viarecibo As Byte
    Private _viaduplicata As Byte
    Private _codcedente As String
    Private _juromes As Single
    Private _codpraca As Long
    Private _agencia As String
    Private _conta As String
    Private _unidadeatendimento As String
    Private _nbanco As String
    Private _nomebanco As String
    Private _codcanaltransmissao As Long
    Private _codcarteira As String
    Private _tipoimpressaoboleto As String
    Private _postartitulo As Boolean
    Private _emissaoboleto As String
    Private _diasprotesto As String
    Private _juropordiaatrazo As Double
    Private _descontoboleto As Double
    Private _tipodesconto As String
    Private _tipojuro As String
    Private _postoagencia As String
    Private _versaosistema As String
    Private _clientepedido As Long
    Private _fusohorario As String
    Private _numeparcela As Byte
    Private _naolancacaixa As Boolean
    Private _senhadesconto As String
    Private _senhaparcela As String
    Private _senhaproduto As String
    Private _senhacaixa As String
    Private _senhadevedor As String
    Private _dadosimpressora As Boolean
    Private _produtocomprar As Boolean
    Private _mostrafunrural As Boolean
    Private _codhistorico As String
    Private _limitedesconto As Single
    Private _alterarvalorunitario As Boolean
    Private _imprimeobs020 As Boolean
    Private _senhareceber As String
    Private _emitentelaticinio As Boolean
    Private _bloqueianota As Boolean
    Private _horacaixa As Boolean
    Private _ato As Boolean
    Private _xml As Boolean
    Private _emaildados As String
    Private _dadospneus As Boolean
    Private _produtocomposto As Boolean
    Private _permitirestorno As Boolean
    Private _diastravamento As Byte
    Private _emitesistemas As Boolean
    Private _emitecapaboleto As Boolean
    Private _mensagemboleto As String
    Private _notaservico As String
    Private _notaservicopm As Boolean
    Private _duplicatapedido As Boolean
    Private _protestoautomatico As String
    Private _mensagempedido As Boolean
    Private _entradacodigoforne As Boolean
    Private _bloqueiamovimentacao As Boolean
    Private _datasatrazadascaixa As Boolean
    Private _chequebaixadata As Boolean
    Private _codigoboleto As Byte
    Private _exibiraparelho As Boolean
    Private _duplicatabematech As Boolean
    Private _mostrarcustolista As Boolean
    Private _listadeprecozero As Boolean
    Private _exibirlogo As Boolean
    Private _anobase As Long
    Private _utilizarmarkup As Boolean
    Private _aredondavenda As Boolean
    Private _lancaapenascontaspagarentrada As Boolean
    Private _carneboleto As Boolean
    Private _lancavalorentrada As Boolean
    Private _importaentradaean As Boolean
    Private _valorfretepedido As Double
    Private _pedidopoleto As Boolean
    Private _contacaixacheque As String
    Private _contacaixaveiculos As String
    Private _taxacelic As Single
    Private _pedidoautoprazo As Boolean
    Private _usarbarrabalanca As Boolean
    Private _licencamdfe As String
    Private _versaomdfe As String
    Private _numerocopiacfe As Byte
    Private _baixacomposicaosaida As Boolean
    Private _vendedorpadrao As String
    Private _ocultardadosemitente As Boolean
    Private _tipodeentrada As Byte
    Private _ocultaminimo As Boolean
    Private _formatacodigo As Boolean
    Private _numerocopiapedido As Byte
    Private _ocultarlogo As Boolean
    Private _liberartotalprodupedido As Boolean
    Private _mostraendepedido As Boolean
    Private _taxaimpostolucro As Single
    Private _menucereais As Byte
    Private _natentradapadrao As String
    Private _bloquearcondicional As Boolean
    Private _abrirnfcevenda As Boolean
    Private _movimentanotapedido As Boolean
    Private _licencacte As String
    Private _bancopadrao As Long
    Private _boletoservico As Boolean
    Private _rntrcemperesa As String
    Private _cpfmotorista As String
    Private _nomemotorista As String
    Private _mostraprodutocomquantidade As Boolean
    Private _acumularvendasinicio As Boolean
    Private _naosomarquantinfe As Boolean
    Private _imprimircapacarne As Boolean
    Private _porcentagemavista As Single
    Private _porcentagemprazo As Single
    Private _versaosistemaconnect As String
    Private _recalcularlucro As Boolean
    Private _exibirmarcalista As Boolean
    Private _filtralistapreco As Boolean
    Private _bloquearclientecpf As Boolean
    Private _usarvalormediocompra As Boolean
    Private _enviarinformacoelivro As Boolean
    Private _numeroseapa As String
    Private _exibiroriginallista As Boolean
    Private _ocultarprateleiralista As Boolean
    Private _exibircodigofabricante As Boolean
    Private _exibirdadoszanatta As Boolean
    Private _exibirselosetiquetas As Boolean
    Private _confirmarimpressaonfce As Boolean
    Private _codigomovimento As String
    Private _exibirdadospadrao As Boolean
    Private _utilizarsalvamentoauto As Boolean
    Private _exibirdadosfoco As Boolean
    Private _emitirncfepedidosempre As Boolean
    Private _exibirdadosbenevenuto As Boolean
    Private _exibirdadoslaquent As Boolean
    Private _exibirdadoscrol As Boolean
    Private _formatadecimais As String
    Private _buscarvendedorcliente As Boolean
    Private _exibirdadosstarfrio As Boolean
    Private _exibirdadosedificare As Boolean
    Private _pedidopallun As Boolean
    Private _importaricmsentrada As Boolean
    Private _duasviasnfceprazo As Boolean
    Private _bloquearvendanegativa As Boolean
    Private _exibirdadosidentita As Boolean
    Private _grupopadraoentrada As String
    Private _exibirdadoszepel As Boolean
    Private _contacaixapadraoentrada As String
    Private _exibirdataentrega As Boolean
    Private _chamaimportaarquivos As Boolean
    Private _exibirdadoskadini As Boolean
    Private _emailextranotas As String
    Private _emitedanfea4 As Boolean
    Private _profissaopadrao As Long
    Private _pgtopadrao As Long
    Private _exibirdadostruck As Boolean
    Private _exibirdadosmannes As Boolean
    Private _exibirdadosalencastro As Boolean
    Private _mantervalormaiorentrada As Boolean
    Private _exibirdadosclauciane As Boolean
    Private _bancopadraoentrada As Long
    Private _exibirdadoselizandra As Boolean
    Private _quantidadefixapedido As Long
    Private _exibirdadosagrocampo As Boolean
    Private _recalcularparcelanfe As Boolean
    Private _exibirdadoslubritap As Boolean
    Private _exibirdadosalger As Boolean
    Private _visualizarboleto As Boolean
    Private _exibirdadosstilo As Boolean
    Private _exibirdadosgasparin As Boolean
    Private _exibirdadosmarcolin As Boolean
    Private _aliquotaiss As Double
    Private _nomecertificadonfse As String

    Public Property carne As Boolean
        Get
            Return _carne
        End Get
        Set(value As Boolean)
            _carne = value
        End Set
    End Property

    Public Property numerocaracter As Long
        Get
            Return _numerocaracter
        End Get
        Set(value As Long)
            _numerocaracter = value
        End Set
    End Property

    Public Property serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = value
        End Set
    End Property

    Public Property pedisimples As Boolean
        Get
            Return _pedisimples
        End Get
        Set(value As Boolean)
            _pedisimples = value
        End Set
    End Property

    Public Property entradaresumida As Boolean
        Get
            Return _entradaresumida
        End Get
        Set(value As Boolean)
            _entradaresumida = value
        End Set
    End Property

    Public Property industria As Boolean
        Get
            Return _industria
        End Get
        Set(value As Boolean)
            _industria = value
        End Set
    End Property

    Public Property tipoetiqueta As String
        Get
            Return _tipoetiqueta
        End Get
        Set(value As String)
            _tipoetiqueta = value
        End Set
    End Property

    Public Property mostratamanho As Boolean
        Get
            Return _mostratamanho
        End Get
        Set(value As Boolean)
            _mostratamanho = value
        End Set
    End Property

    Public Property recibofiscal As Boolean
        Get
            Return _recibofiscal
        End Get
        Set(value As Boolean)
            _recibofiscal = value
        End Set
    End Property

    Public Property placacf As Boolean
        Get
            Return _placacf
        End Get
        Set(value As Boolean)
            _placacf = value
        End Set
    End Property

    Public Property precopedido As Boolean
        Get
            Return _precopedido
        End Get
        Set(value As Boolean)
            _precopedido = value
        End Set
    End Property

    Public Property pedidofiscal As Boolean
        Get
            Return _pedidofiscal
        End Get
        Set(value As Boolean)
            _pedidofiscal = value
        End Set
    End Property

    Public Property servicocupom As Boolean
        Get
            Return _servicocupom
        End Get
        Set(value As Boolean)
            _servicocupom = value
        End Set
    End Property

    Public Property margeminferior As Long
        Get
            Return _margeminferior
        End Get
        Set(value As Long)
            _margeminferior = value
        End Set
    End Property

    Public Property mostrarservico As Boolean
        Get
            Return _mostrarservico
        End Get
        Set(value As Boolean)
            _mostrarservico = value
        End Set
    End Property

    Public Property orgaestoque As Boolean
        Get
            Return _orgaestoque
        End Get
        Set(value As Boolean)
            _orgaestoque = value
        End Set
    End Property

    Public Property liberadatare As Boolean
        Get
            Return _liberadatare
        End Get
        Set(value As Boolean)
            _liberadatare = value
        End Set
    End Property

    Public Property emitentepadrao As Boolean
        Get
            Return _emitentepadrao
        End Get
        Set(value As Boolean)
            _emitentepadrao = value
        End Set
    End Property

    Public Property emitentenfce As Boolean
        Get
            Return _emitentenfce
        End Get
        Set(value As Boolean)
            _emitentenfce = value
        End Set
    End Property

    Public Property tokennfce As String
        Get
            Return _tokennfce
        End Get
        Set(value As String)
            _tokennfce = value
        End Set
    End Property

    Public Property pincerti As String
        Get
            Return _pincerti
        End Get
        Set(value As String)
            _pincerti = value
        End Set
    End Property

    Public Property liberacaixa As Boolean
        Get
            Return _liberacaixa
        End Get
        Set(value As Boolean)
            _liberacaixa = value
        End Set
    End Property

    Public Property viarecibo As Byte
        Get
            Return _viarecibo
        End Get
        Set(value As Byte)
            _viarecibo = value
        End Set
    End Property

    Public Property viaduplicata As Byte
        Get
            Return _viaduplicata
        End Get
        Set(value As Byte)
            _viaduplicata = value
        End Set
    End Property

    Public Property codcedente As String
        Get
            Return _codcedente
        End Get
        Set(value As String)
            _codcedente = value
        End Set
    End Property

    Public Property juromes As Single
        Get
            Return _juromes
        End Get
        Set(value As Single)
            _juromes = value
        End Set
    End Property

    Public Property codpraca As Long
        Get
            Return _codpraca
        End Get
        Set(value As Long)
            _codpraca = value
        End Set
    End Property

    Public Property agencia As String
        Get
            Return _agencia
        End Get
        Set(value As String)
            _agencia = value
        End Set
    End Property

    Public Property conta As String
        Get
            Return _conta
        End Get
        Set(value As String)
            _conta = value
        End Set
    End Property

    Public Property unidadeatendimento As String
        Get
            Return _unidadeatendimento
        End Get
        Set(value As String)
            _unidadeatendimento = value
        End Set
    End Property

    Public Property nbanco As String
        Get
            Return _nbanco
        End Get
        Set(value As String)
            _nbanco = value
        End Set
    End Property

    Public Property nomebanco As String
        Get
            Return _nomebanco
        End Get
        Set(value As String)
            _nomebanco = value
        End Set
    End Property

    Public Property codcanaltransmissao As Long
        Get
            Return _codcanaltransmissao
        End Get
        Set(value As Long)
            _codcanaltransmissao = value
        End Set
    End Property

    Public Property codcarteira As String
        Get
            Return _codcarteira
        End Get
        Set(value As String)
            _codcarteira = value
        End Set
    End Property

    Public Property tipoimpressaoboleto As String
        Get
            Return _tipoimpressaoboleto
        End Get
        Set(value As String)
            _tipoimpressaoboleto = value
        End Set
    End Property

    Public Property postartitulo As Boolean
        Get
            Return _postartitulo
        End Get
        Set(value As Boolean)
            _postartitulo = value
        End Set
    End Property

    Public Property emissaoboleto As String
        Get
            Return _emissaoboleto
        End Get
        Set(value As String)
            _emissaoboleto = value
        End Set
    End Property

    Public Property diasprotesto As String
        Get
            Return _diasprotesto
        End Get
        Set(value As String)
            _diasprotesto = value
        End Set
    End Property

    Public Property juropordiaatrazo As Double
        Get
            Return _juropordiaatrazo
        End Get
        Set(value As Double)
            _juropordiaatrazo = value
        End Set
    End Property

    Public Property descontoboleto As Double
        Get
            Return _descontoboleto
        End Get
        Set(value As Double)
            _descontoboleto = value
        End Set
    End Property

    Public Property tipodesconto As String
        Get
            Return _tipodesconto
        End Get
        Set(value As String)
            _tipodesconto = value
        End Set
    End Property

    Public Property tipojuro As String
        Get
            Return _tipojuro
        End Get
        Set(value As String)
            _tipojuro = value
        End Set
    End Property

    Public Property postoagencia As String
        Get
            Return _postoagencia
        End Get
        Set(value As String)
            _postoagencia = value
        End Set
    End Property

    Public Property versaosistema As String
        Get
            Return _versaosistema
        End Get
        Set(value As String)
            _versaosistema = value
        End Set
    End Property

    Public Property clientepedido As Long
        Get
            Return _clientepedido
        End Get
        Set(value As Long)
            _clientepedido = value
        End Set
    End Property

    Public Property fusohorario As String
        Get
            Return _fusohorario
        End Get
        Set(value As String)
            _fusohorario = value
        End Set
    End Property

    Public Property numeparcela As Byte
        Get
            Return _numeparcela
        End Get
        Set(value As Byte)
            _numeparcela = value
        End Set
    End Property

    Public Property naolancacaixa As Boolean
        Get
            Return _naolancacaixa
        End Get
        Set(value As Boolean)
            _naolancacaixa = value
        End Set
    End Property

    Public Property senhadesconto As String
        Get
            Return _senhadesconto
        End Get
        Set(value As String)
            _senhadesconto = value
        End Set
    End Property

    Public Property senhaparcela As String
        Get
            Return _senhaparcela
        End Get
        Set(value As String)
            _senhaparcela = value
        End Set
    End Property

    Public Property senhaproduto As String
        Get
            Return _senhaproduto
        End Get
        Set(value As String)
            _senhaproduto = value
        End Set
    End Property

    Public Property senhacaixa As String
        Get
            Return _senhacaixa
        End Get
        Set(value As String)
            _senhacaixa = value
        End Set
    End Property

    Public Property senhadevedor As String
        Get
            Return _senhadevedor
        End Get
        Set(value As String)
            _senhadevedor = value
        End Set
    End Property

    Public Property dadosimpressora As Boolean
        Get
            Return _dadosimpressora
        End Get
        Set(value As Boolean)
            _dadosimpressora = value
        End Set
    End Property

    Public Property produtocomprar As Boolean
        Get
            Return _produtocomprar
        End Get
        Set(value As Boolean)
            _produtocomprar = value
        End Set
    End Property

    Public Property mostrafunrural As Boolean
        Get
            Return _mostrafunrural
        End Get
        Set(value As Boolean)
            _mostrafunrural = value
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

    Public Property limitedesconto As Single
        Get
            Return _limitedesconto
        End Get
        Set(value As Single)
            _limitedesconto = value
        End Set
    End Property

    Public Property alterarvalorunitario As Boolean
        Get
            Return _alterarvalorunitario
        End Get
        Set(value As Boolean)
            _alterarvalorunitario = value
        End Set
    End Property

    Public Property imprimeobs020 As Boolean
        Get
            Return _imprimeobs020
        End Get
        Set(value As Boolean)
            _imprimeobs020 = value
        End Set
    End Property

    Public Property senhareceber As String
        Get
            Return _senhareceber
        End Get
        Set(value As String)
            _senhareceber = value
        End Set
    End Property

    Public Property emitentelaticinio As Boolean
        Get
            Return _emitentelaticinio
        End Get
        Set(value As Boolean)
            _emitentelaticinio = value
        End Set
    End Property

    Public Property bloqueianota As Boolean
        Get
            Return _bloqueianota
        End Get
        Set(value As Boolean)
            _bloqueianota = value
        End Set
    End Property

    Public Property horacaixa As Boolean
        Get
            Return _horacaixa
        End Get
        Set(value As Boolean)
            _horacaixa = value
        End Set
    End Property

    Public Property ato As Boolean
        Get
            Return _ato
        End Get
        Set(value As Boolean)
            _ato = value
        End Set
    End Property

    Public Property xml As Boolean
        Get
            Return _xml
        End Get
        Set(value As Boolean)
            _xml = value
        End Set
    End Property

    Public Property emaildados As String
        Get
            Return _emaildados
        End Get
        Set(value As String)
            _emaildados = value
        End Set
    End Property

    Public Property dadospneus As Boolean
        Get
            Return _dadospneus
        End Get
        Set(value As Boolean)
            _dadospneus = value
        End Set
    End Property

    Public Property produtocomposto As Boolean
        Get
            Return _produtocomposto
        End Get
        Set(value As Boolean)
            _produtocomposto = value
        End Set
    End Property

    Public Property permitirestorno As Boolean
        Get
            Return _permitirestorno
        End Get
        Set(value As Boolean)
            _permitirestorno = value
        End Set
    End Property

    Public Property diastravamento As Byte
        Get
            Return _diastravamento
        End Get
        Set(value As Byte)
            _diastravamento = value
        End Set
    End Property

    Public Property emitesistemas As Boolean
        Get
            Return _emitesistemas
        End Get
        Set(value As Boolean)
            _emitesistemas = value
        End Set
    End Property

    Public Property emitecapaboleto As Boolean
        Get
            Return _emitecapaboleto
        End Get
        Set(value As Boolean)
            _emitecapaboleto = value
        End Set
    End Property

    Public Property mensagemboleto As String
        Get
            Return _mensagemboleto
        End Get
        Set(value As String)
            _mensagemboleto = value
        End Set
    End Property

    Public Property notaservico As String
        Get
            Return _notaservico
        End Get
        Set(value As String)
            _notaservico = value
        End Set
    End Property

    Public Property notaservicopm As Boolean
        Get
            Return _notaservicopm
        End Get
        Set(value As Boolean)
            _notaservicopm = value
        End Set
    End Property

    Public Property duplicatapedido As Boolean
        Get
            Return _duplicatapedido
        End Get
        Set(value As Boolean)
            _duplicatapedido = value
        End Set
    End Property

    Public Property protestoautomatico As String
        Get
            Return _protestoautomatico
        End Get
        Set(value As String)
            _protestoautomatico = value
        End Set
    End Property

    Public Property mensagempedido As Boolean
        Get
            Return _mensagempedido
        End Get
        Set(value As Boolean)
            _mensagempedido = value
        End Set
    End Property

    Public Property entradacodigoforne As Boolean
        Get
            Return _entradacodigoforne
        End Get
        Set(value As Boolean)
            _entradacodigoforne = value
        End Set
    End Property

    Public Property bloqueiamovimentacao As Boolean
        Get
            Return _bloqueiamovimentacao
        End Get
        Set(value As Boolean)
            _bloqueiamovimentacao = value
        End Set
    End Property

    Public Property datasatrazadascaixa As Boolean
        Get
            Return _datasatrazadascaixa
        End Get
        Set(value As Boolean)
            _datasatrazadascaixa = value
        End Set
    End Property

    Public Property chequebaixadata As Boolean
        Get
            Return _chequebaixadata
        End Get
        Set(value As Boolean)
            _chequebaixadata = value
        End Set
    End Property

    Public Property codigoboleto As Byte
        Get
            Return _codigoboleto
        End Get
        Set(value As Byte)
            _codigoboleto = value
        End Set
    End Property

    Public Property exibiraparelho As Boolean
        Get
            Return _exibiraparelho
        End Get
        Set(value As Boolean)
            _exibiraparelho = value
        End Set
    End Property

    Public Property duplicatabematech As Boolean
        Get
            Return _duplicatabematech
        End Get
        Set(value As Boolean)
            _duplicatabematech = value
        End Set
    End Property

    Public Property mostrarcustolista As Boolean
        Get
            Return _mostrarcustolista
        End Get
        Set(value As Boolean)
            _mostrarcustolista = value
        End Set
    End Property

    Public Property listadeprecozero As Boolean
        Get
            Return _listadeprecozero
        End Get
        Set(value As Boolean)
            _listadeprecozero = value
        End Set
    End Property

    Public Property exibirlogo As Boolean
        Get
            Return _exibirlogo
        End Get
        Set(value As Boolean)
            _exibirlogo = value
        End Set
    End Property

    Public Property anobase As Long
        Get
            Return _anobase
        End Get
        Set(value As Long)
            _anobase = value
        End Set
    End Property

    Public Property utilizarmarkup As Boolean
        Get
            Return _utilizarmarkup
        End Get
        Set(value As Boolean)
            _utilizarmarkup = value
        End Set
    End Property

    Public Property aredondavenda As Boolean
        Get
            Return _aredondavenda
        End Get
        Set(value As Boolean)
            _aredondavenda = value
        End Set
    End Property

    Public Property lancaapenascontaspagarentrada As Boolean
        Get
            Return _lancaapenascontaspagarentrada
        End Get
        Set(value As Boolean)
            _lancaapenascontaspagarentrada = value
        End Set
    End Property

    Public Property carneboleto As Boolean
        Get
            Return _carneboleto
        End Get
        Set(value As Boolean)
            _carneboleto = value
        End Set
    End Property

    Public Property lancavalorentrada As Boolean
        Get
            Return _lancavalorentrada
        End Get
        Set(value As Boolean)
            _lancavalorentrada = value
        End Set
    End Property

    Public Property importaentradaean As Boolean
        Get
            Return _importaentradaean
        End Get
        Set(value As Boolean)
            _importaentradaean = value
        End Set
    End Property

    Public Property valorfretepedido As Double
        Get
            Return _valorfretepedido
        End Get
        Set(value As Double)
            _valorfretepedido = value
        End Set
    End Property

    Public Property pedidopoleto As Boolean
        Get
            Return _pedidopoleto
        End Get
        Set(value As Boolean)
            _pedidopoleto = value
        End Set
    End Property

    Public Property contacaixacheque As String
        Get
            Return _contacaixacheque
        End Get
        Set(value As String)
            _contacaixacheque = value
        End Set
    End Property

    Public Property contacaixaveiculos As String
        Get
            Return _contacaixaveiculos
        End Get
        Set(value As String)
            _contacaixaveiculos = value
        End Set
    End Property

    Public Property taxacelic As Single
        Get
            Return _taxacelic
        End Get
        Set(value As Single)
            _taxacelic = value
        End Set
    End Property

    Public Property pedidoautoprazo As Boolean
        Get
            Return _pedidoautoprazo
        End Get
        Set(value As Boolean)
            _pedidoautoprazo = value
        End Set
    End Property

    Public Property usarbarrabalanca As Boolean
        Get
            Return _usarbarrabalanca
        End Get
        Set(value As Boolean)
            _usarbarrabalanca = value
        End Set
    End Property

    Public Property licencamdfe As String
        Get
            Return _licencamdfe
        End Get
        Set(value As String)
            _licencamdfe = value
        End Set
    End Property

    Public Property versaomdfe As String
        Get
            Return _versaomdfe
        End Get
        Set(value As String)
            _versaomdfe = value
        End Set
    End Property

    Public Property numerocopiacfe As Byte
        Get
            Return _numerocopiacfe
        End Get
        Set(value As Byte)
            _numerocopiacfe = value
        End Set
    End Property

    Public Property baixacomposicaosaida As Boolean
        Get
            Return _baixacomposicaosaida
        End Get
        Set(value As Boolean)
            _baixacomposicaosaida = value
        End Set
    End Property

    Public Property vendedorpadrao As String
        Get
            Return _vendedorpadrao
        End Get
        Set(value As String)
            _vendedorpadrao = value
        End Set
    End Property

    Public Property ocultardadosemitente As Boolean
        Get
            Return _ocultardadosemitente
        End Get
        Set(value As Boolean)
            _ocultardadosemitente = value
        End Set
    End Property

    Public Property tipodeentrada As Byte
        Get
            Return _tipodeentrada
        End Get
        Set(value As Byte)
            _tipodeentrada = value
        End Set
    End Property

    Public Property ocultaminimo As Boolean
        Get
            Return _ocultaminimo
        End Get
        Set(value As Boolean)
            _ocultaminimo = value
        End Set
    End Property

    Public Property formatacodigo As Boolean
        Get
            Return _formatacodigo
        End Get
        Set(value As Boolean)
            _formatacodigo = value
        End Set
    End Property

    Public Property numerocopiapedido As Byte
        Get
            Return _numerocopiapedido
        End Get
        Set(value As Byte)
            _numerocopiapedido = value
        End Set
    End Property

    Public Property ocultarlogo As Boolean
        Get
            Return _ocultarlogo
        End Get
        Set(value As Boolean)
            _ocultarlogo = value
        End Set
    End Property

    Public Property liberartotalprodupedido As Boolean
        Get
            Return _liberartotalprodupedido
        End Get
        Set(value As Boolean)
            _liberartotalprodupedido = value
        End Set
    End Property

    Public Property mostraendepedido As Boolean
        Get
            Return _mostraendepedido
        End Get
        Set(value As Boolean)
            _mostraendepedido = value
        End Set
    End Property

    Public Property taxaimpostolucro As Single
        Get
            Return _taxaimpostolucro
        End Get
        Set(value As Single)
            _taxaimpostolucro = value
        End Set
    End Property

    Public Property menucereais As Byte
        Get
            Return _menucereais
        End Get
        Set(value As Byte)
            _menucereais = value
        End Set
    End Property

    Public Property natentradapadrao As String
        Get
            Return _natentradapadrao
        End Get
        Set(value As String)
            _natentradapadrao = value
        End Set
    End Property

    Public Property bloquearcondicional As Boolean
        Get
            Return _bloquearcondicional
        End Get
        Set(value As Boolean)
            _bloquearcondicional = value
        End Set
    End Property

    Public Property abrirnfcevenda As Boolean
        Get
            Return _abrirnfcevenda
        End Get
        Set(value As Boolean)
            _abrirnfcevenda = value
        End Set
    End Property

    Public Property movimentanotapedido As Boolean
        Get
            Return _movimentanotapedido
        End Get
        Set(value As Boolean)
            _movimentanotapedido = value
        End Set
    End Property

    Public Property licencacte As String
        Get
            Return _licencacte
        End Get
        Set(value As String)
            _licencacte = value
        End Set
    End Property

    Public Property bancopadrao As Long
        Get
            Return _bancopadrao
        End Get
        Set(value As Long)
            _bancopadrao = value
        End Set
    End Property

    Public Property boletoservico As Boolean
        Get
            Return _boletoservico
        End Get
        Set(value As Boolean)
            _boletoservico = value
        End Set
    End Property

    Public Property rntrcemperesa As String
        Get
            Return _rntrcemperesa
        End Get
        Set(value As String)
            _rntrcemperesa = value
        End Set
    End Property

    Public Property cpfmotorista As String
        Get
            Return _cpfmotorista
        End Get
        Set(value As String)
            _cpfmotorista = value
        End Set
    End Property

    Public Property nomemotorista As String
        Get
            Return _nomemotorista
        End Get
        Set(value As String)
            _nomemotorista = value
        End Set
    End Property

    Public Property mostraprodutocomquantidade As Boolean
        Get
            Return _mostraprodutocomquantidade
        End Get
        Set(value As Boolean)
            _mostraprodutocomquantidade = value
        End Set
    End Property

    Public Property acumularvendasinicio As Boolean
        Get
            Return _acumularvendasinicio
        End Get
        Set(value As Boolean)
            _acumularvendasinicio = value
        End Set
    End Property

    Public Property naosomarquantinfe As Boolean
        Get
            Return _naosomarquantinfe
        End Get
        Set(value As Boolean)
            _naosomarquantinfe = value
        End Set
    End Property

    Public Property imprimircapacarne As Boolean
        Get
            Return _imprimircapacarne
        End Get
        Set(value As Boolean)
            _imprimircapacarne = value
        End Set
    End Property

    Public Property porcentagemavista As Single
        Get
            Return _porcentagemavista
        End Get
        Set(value As Single)
            _porcentagemavista = value
        End Set
    End Property

    Public Property porcentagemprazo As Single
        Get
            Return _porcentagemprazo
        End Get
        Set(value As Single)
            _porcentagemprazo = value
        End Set
    End Property

    Public Property versaosistemaconnect As String
        Get
            Return _versaosistemaconnect
        End Get
        Set(value As String)
            _versaosistemaconnect = value
        End Set
    End Property

    Public Property recalcularlucro As Boolean
        Get
            Return _recalcularlucro
        End Get
        Set(value As Boolean)
            _recalcularlucro = value
        End Set
    End Property

    Public Property exibirmarcalista As Boolean
        Get
            Return _exibirmarcalista
        End Get
        Set(value As Boolean)
            _exibirmarcalista = value
        End Set
    End Property

    Public Property filtralistapreco As Boolean
        Get
            Return _filtralistapreco
        End Get
        Set(value As Boolean)
            _filtralistapreco = value
        End Set
    End Property

    Public Property bloquearclientecpf As Boolean
        Get
            Return _bloquearclientecpf
        End Get
        Set(value As Boolean)
            _bloquearclientecpf = value
        End Set
    End Property

    Public Property usarvalormediocompra As Boolean
        Get
            Return _usarvalormediocompra
        End Get
        Set(value As Boolean)
            _usarvalormediocompra = value
        End Set
    End Property

    Public Property enviarinformacoelivro As Boolean
        Get
            Return _enviarinformacoelivro
        End Get
        Set(value As Boolean)
            _enviarinformacoelivro = value
        End Set
    End Property

    Public Property numeroseapa As String
        Get
            Return _numeroseapa
        End Get
        Set(value As String)
            _numeroseapa = value
        End Set
    End Property

    Public Property exibiroriginallista As Boolean
        Get
            Return _exibiroriginallista
        End Get
        Set(value As Boolean)
            _exibiroriginallista = value
        End Set
    End Property

    Public Property ocultarprateleiralista As Boolean
        Get
            Return _ocultarprateleiralista
        End Get
        Set(value As Boolean)
            _ocultarprateleiralista = value
        End Set
    End Property

    Public Property exibircodigofabricante As Boolean
        Get
            Return _exibircodigofabricante
        End Get
        Set(value As Boolean)
            _exibircodigofabricante = value
        End Set
    End Property

    Public Property exibirdadoszanatta As Boolean
        Get
            Return _exibirdadoszanatta
        End Get
        Set(value As Boolean)
            _exibirdadoszanatta = value
        End Set
    End Property

    Public Property exibirselosetiquetas As Boolean
        Get
            Return _exibirselosetiquetas
        End Get
        Set(value As Boolean)
            _exibirselosetiquetas = value
        End Set
    End Property

    Public Property confirmarimpressaonfce As Boolean
        Get
            Return _confirmarimpressaonfce
        End Get
        Set(value As Boolean)
            _confirmarimpressaonfce = value
        End Set
    End Property

    Public Property codigomovimento As String
        Get
            Return _codigomovimento
        End Get
        Set(value As String)
            _codigomovimento = value
        End Set
    End Property

    Public Property exibirdadospadrao As Boolean
        Get
            Return _exibirdadospadrao
        End Get
        Set(value As Boolean)
            _exibirdadospadrao = value
        End Set
    End Property

    Public Property utilizarsalvamentoauto As Boolean
        Get
            Return _utilizarsalvamentoauto
        End Get
        Set(value As Boolean)
            _utilizarsalvamentoauto = value
        End Set
    End Property

    Public Property exibirdadosfoco As Boolean
        Get
            Return _exibirdadosfoco
        End Get
        Set(value As Boolean)
            _exibirdadosfoco = value
        End Set
    End Property

    Public Property emitirncfepedidosempre As Boolean
        Get
            Return _emitirncfepedidosempre
        End Get
        Set(value As Boolean)
            _emitirncfepedidosempre = value
        End Set
    End Property

    Public Property exibirdadosbenevenuto As Boolean
        Get
            Return _exibirdadosbenevenuto
        End Get
        Set(value As Boolean)
            _exibirdadosbenevenuto = value
        End Set
    End Property

    Public Property exibirdadoslaquent As Boolean
        Get
            Return _exibirdadoslaquent
        End Get
        Set(value As Boolean)
            _exibirdadoslaquent = value
        End Set
    End Property

    Public Property exibirdadoscrol As Boolean
        Get
            Return _exibirdadoscrol
        End Get
        Set(value As Boolean)
            _exibirdadoscrol = value
        End Set
    End Property

    Public Property formatadecimais As String
        Get
            Return _formatadecimais
        End Get
        Set(value As String)
            _formatadecimais = value
        End Set
    End Property

    Public Property buscarvendedorcliente As Boolean
        Get
            Return _buscarvendedorcliente
        End Get
        Set(value As Boolean)
            _buscarvendedorcliente = value
        End Set
    End Property

    Public Property exibirdadosstarfrio As Boolean
        Get
            Return _exibirdadosstarfrio
        End Get
        Set(value As Boolean)
            _exibirdadosstarfrio = value
        End Set
    End Property

    Public Property exibirdadosedificare As Boolean
        Get
            Return _exibirdadosedificare
        End Get
        Set(value As Boolean)
            _exibirdadosedificare = value
        End Set
    End Property

    Public Property pedidopallun As Boolean
        Get
            Return _pedidopallun
        End Get
        Set(value As Boolean)
            _pedidopallun = value
        End Set
    End Property

    Public Property importaricmsentrada As Boolean
        Get
            Return _importaricmsentrada
        End Get
        Set(value As Boolean)
            _importaricmsentrada = value
        End Set
    End Property

    Public Property duasviasnfceprazo As Boolean
        Get
            Return _duasviasnfceprazo
        End Get
        Set(value As Boolean)
            _duasviasnfceprazo = value
        End Set
    End Property

    Public Property bloquearvendanegativa As Boolean
        Get
            Return _bloquearvendanegativa
        End Get
        Set(value As Boolean)
            _bloquearvendanegativa = value
        End Set
    End Property

    Public Property exibirdadosidentita As Boolean
        Get
            Return _exibirdadosidentita
        End Get
        Set(value As Boolean)
            _exibirdadosidentita = value
        End Set
    End Property

    Public Property grupopadraoentrada As String
        Get
            Return _grupopadraoentrada
        End Get
        Set(value As String)
            _grupopadraoentrada = value
        End Set
    End Property

    Public Property exibirdadoszepel As Boolean
        Get
            Return _exibirdadoszepel
        End Get
        Set(value As Boolean)
            _exibirdadoszepel = value
        End Set
    End Property

    Public Property contacaixapadraoentrada As String
        Get
            Return _contacaixapadraoentrada
        End Get
        Set(value As String)
            _contacaixapadraoentrada = value
        End Set
    End Property

    Public Property exibirdataentrega As Boolean
        Get
            Return _exibirdataentrega
        End Get
        Set(value As Boolean)
            _exibirdataentrega = value
        End Set
    End Property

    Public Property chamaimportaarquivos As Boolean
        Get
            Return _chamaimportaarquivos
        End Get
        Set(value As Boolean)
            _chamaimportaarquivos = value
        End Set
    End Property

    Public Property exibirdadoskadini As Boolean
        Get
            Return _exibirdadoskadini
        End Get
        Set(value As Boolean)
            _exibirdadoskadini = value
        End Set
    End Property

    Public Property emailextranotas As String
        Get
            Return _emailextranotas
        End Get
        Set(value As String)
            _emailextranotas = value
        End Set
    End Property

    Public Property emitedanfea4 As Boolean
        Get
            Return _emitedanfea4
        End Get
        Set(value As Boolean)
            _emitedanfea4 = value
        End Set
    End Property

    Public Property profissaopadrao As Long
        Get
            Return _profissaopadrao
        End Get
        Set(value As Long)
            _profissaopadrao = value
        End Set
    End Property

    Public Property pgtopadrao As Long
        Get
            Return _pgtopadrao
        End Get
        Set(value As Long)
            _pgtopadrao = value
        End Set
    End Property

    Public Property exibirdadostruck As Boolean
        Get
            Return _exibirdadostruck
        End Get
        Set(value As Boolean)
            _exibirdadostruck = value
        End Set
    End Property

    Public Property exibirdadosmannes As Boolean
        Get
            Return _exibirdadosmannes
        End Get
        Set(value As Boolean)
            _exibirdadosmannes = value
        End Set
    End Property

    Public Property exibirdadosalencastro As Boolean
        Get
            Return _exibirdadosalencastro
        End Get
        Set(value As Boolean)
            _exibirdadosalencastro = value
        End Set
    End Property

    Public Property mantervalormaiorentrada As Boolean
        Get
            Return _mantervalormaiorentrada
        End Get
        Set(value As Boolean)
            _mantervalormaiorentrada = value
        End Set
    End Property

    Public Property exibirdadosclauciane As Boolean
        Get
            Return _exibirdadosclauciane
        End Get
        Set(value As Boolean)
            _exibirdadosclauciane = value
        End Set
    End Property

    Public Property bancopadraoentrada As Long
        Get
            Return _bancopadraoentrada
        End Get
        Set(value As Long)
            _bancopadraoentrada = value
        End Set
    End Property

    Public Property exibirdadoselizandra As Boolean
        Get
            Return _exibirdadoselizandra
        End Get
        Set(value As Boolean)
            _exibirdadoselizandra = value
        End Set
    End Property

    Public Property quantidadefixapedido As Long
        Get
            Return _quantidadefixapedido
        End Get
        Set(value As Long)
            _quantidadefixapedido = value
        End Set
    End Property

    Public Property exibirdadosagrocampo As Boolean
        Get
            Return _exibirdadosagrocampo
        End Get
        Set(value As Boolean)
            _exibirdadosagrocampo = value
        End Set
    End Property

    Public Property recalcularparcelanfe As Boolean
        Get
            Return _recalcularparcelanfe
        End Get
        Set(value As Boolean)
            _recalcularparcelanfe = value
        End Set
    End Property

    Public Property exibirdadoslubritap As Boolean
        Get
            Return _exibirdadoslubritap
        End Get
        Set(value As Boolean)
            _exibirdadoslubritap = value
        End Set
    End Property

    Public Property exibirdadosalger As Boolean
        Get
            Return _exibirdadosalger
        End Get
        Set(value As Boolean)
            _exibirdadosalger = value
        End Set
    End Property

    Public Property visualizarboleto As Boolean
        Get
            Return _visualizarboleto
        End Get
        Set(value As Boolean)
            _visualizarboleto = value
        End Set
    End Property

    Public Property exibirdadosstilo As Boolean
        Get
            Return _exibirdadosstilo
        End Get
        Set(value As Boolean)
            _exibirdadosstilo = value
        End Set
    End Property

    Public Property exibirdadosgasparin As Boolean
        Get
            Return _exibirdadosgasparin
        End Get
        Set(value As Boolean)
            _exibirdadosgasparin = value
        End Set
    End Property

    Public Property exibirdadosmarcolin As Boolean
        Get
            Return _exibirdadosmarcolin
        End Get
        Set(value As Boolean)
            _exibirdadosmarcolin = value
        End Set
    End Property

    Public Property aliquotaiss As Double
        Get
            Return _aliquotaiss
        End Get
        Set(value As Double)
            _aliquotaiss = value
        End Set
    End Property

    Public Property nomecertificadonfse As String
        Get
            Return _nomecertificadonfse
        End Get
        Set(value As String)
            _nomecertificadonfse = value
        End Set
    End Property
End Class
