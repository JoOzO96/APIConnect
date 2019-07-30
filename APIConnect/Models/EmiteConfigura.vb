Public Class EmiteConfigura
    Private _codemitente As Long
    Private _exibirdadosced As Boolean
    Private _filtratextoescrita As Boolean
    Private _exibirdadoslaquentloja As Boolean
    Private _diascarenciajuros As Byte
    Private _exibirdadosalternativa As Boolean
    Private _usaconversaoentrada As Boolean
    Private _valorboletospadrao As Double
    Private _exibirdadosconversaoproduto As Boolean
    Private _descontoapenasproduto As Boolean
    Private _alterarobspedidofechado As Boolean
    Private _imprimirnfsservicodireto As Boolean
    Private _exibirdadosilha As Boolean
    Private _exibirdadosrestaurante As Boolean
    Private _exibirdadosconnect As Boolean
    Private _exibirmensagemeconomizou As Boolean
    Private _obscte As String
    Private _bloquearquantidadenegativa As Boolean
    Private _utilizarpontos As Boolean
    Private _usarepsonlx300 As Boolean
    Private _produtopredominantecte As String
    Private _produtocomponentecte As String
    Private _produtoaidf As String
    Private _exibirdadosoliveira As Boolean
    Private _ocultavencibarrapedido As Boolean
    Private _emitenfse As Boolean
    Private _exibirdadoshs As Boolean
    Private _exibircustoletras As Boolean
    Private _nfseusuario As String
    Private _nfsesenha As String
    Private _nfsecancelamento As String
    Private _nfseconsultalote As String
    Private _nfseconsultafaixa As String
    Private _nfseconsultarps As String
    Private _nfseconsultaprestados As String
    Private _nfseconsultaenvioloterps As String
    Private _nfseconsultaenviorps As String
    Private _nfseconsultasequencialote As String
    Private _exibirvendedorcupom As Boolean
    Private _caixapadrao As Long
    Private _cadastroduplicadosclientes As Boolean
    Private _ocultarcestnota As Boolean
    Private _naoalteracustoentrada As Boolean
    Private _exibirdadosmiotto As Boolean
    Private _exibirdadosvestbem As Boolean
    Private _exibirdadosestilo As Boolean
    Private _contacaixaveiculosvenda As String
    Private _exibirdadostrattore As Boolean
    Private _contacaixachequelaca As String
    Private _contacaixachequebaixa As String
    Private _utilizaimportacaoautomatica As Boolean
    Private _gerablocok As Boolean
    Private _cstpadraocadastro As String
    Private _converteimpostoentrada As Boolean
    Private _codnaturezadevolucao As String
    Private _exibirdadoskitintas As Boolean
    Private _fretenota As String
    Private _exibirdadosinnovar As Boolean
    Private _usarfatorconversao As Boolean
    Private _forcarcfopentrada As Boolean
    Private _geranotalote As Boolean

    Public Property codemitente As Long
        Get
            Return _codemitente
        End Get
        Set(value As Long)
            _codemitente = value
        End Set
    End Property

    Public Property exibirdadosced As Boolean
        Get
            Return _exibirdadosced
        End Get
        Set(value As Boolean)
            _exibirdadosced = value
        End Set
    End Property

    Public Property filtratextoescrita As Boolean
        Get
            Return _filtratextoescrita
        End Get
        Set(value As Boolean)
            _filtratextoescrita = value
        End Set
    End Property

    Public Property exibirdadoslaquentloja As Boolean
        Get
            Return _exibirdadoslaquentloja
        End Get
        Set(value As Boolean)
            _exibirdadoslaquentloja = value
        End Set
    End Property

    Public Property diascarenciajuros As Byte
        Get
            Return _diascarenciajuros
        End Get
        Set(value As Byte)
            _diascarenciajuros = value
        End Set
    End Property

    Public Property exibirdadosalternativa As Boolean
        Get
            Return _exibirdadosalternativa
        End Get
        Set(value As Boolean)
            _exibirdadosalternativa = value
        End Set
    End Property

    Public Property usaconversaoentrada As Boolean
        Get
            Return _usaconversaoentrada
        End Get
        Set(value As Boolean)
            _usaconversaoentrada = value
        End Set
    End Property

    Public Property valorboletospadrao As Double
        Get
            Return _valorboletospadrao
        End Get
        Set(value As Double)
            _valorboletospadrao = value
        End Set
    End Property

    Public Property exibirdadosconversaoproduto As Boolean
        Get
            Return _exibirdadosconversaoproduto
        End Get
        Set(value As Boolean)
            _exibirdadosconversaoproduto = value
        End Set
    End Property

    Public Property descontoapenasproduto As Boolean
        Get
            Return _descontoapenasproduto
        End Get
        Set(value As Boolean)
            _descontoapenasproduto = value
        End Set
    End Property

    Public Property alterarobspedidofechado As Boolean
        Get
            Return _alterarobspedidofechado
        End Get
        Set(value As Boolean)
            _alterarobspedidofechado = value
        End Set
    End Property

    Public Property imprimirnfsservicodireto As Boolean
        Get
            Return _imprimirnfsservicodireto
        End Get
        Set(value As Boolean)
            _imprimirnfsservicodireto = value
        End Set
    End Property

    Public Property exibirdadosilha As Boolean
        Get
            Return _exibirdadosilha
        End Get
        Set(value As Boolean)
            _exibirdadosilha = value
        End Set
    End Property

    Public Property exibirdadosrestaurante As Boolean
        Get
            Return _exibirdadosrestaurante
        End Get
        Set(value As Boolean)
            _exibirdadosrestaurante = value
        End Set
    End Property

    Public Property exibirdadosconnect As Boolean
        Get
            Return _exibirdadosconnect
        End Get
        Set(value As Boolean)
            _exibirdadosconnect = value
        End Set
    End Property

    Public Property exibirmensagemeconomizou As Boolean
        Get
            Return _exibirmensagemeconomizou
        End Get
        Set(value As Boolean)
            _exibirmensagemeconomizou = value
        End Set
    End Property

    Public Property obscte As String
        Get
            Return _obscte
        End Get
        Set(value As String)
            _obscte = value
        End Set
    End Property

    Public Property bloquearquantidadenegativa As Boolean
        Get
            Return _bloquearquantidadenegativa
        End Get
        Set(value As Boolean)
            _bloquearquantidadenegativa = value
        End Set
    End Property

    Public Property utilizarpontos As Boolean
        Get
            Return _utilizarpontos
        End Get
        Set(value As Boolean)
            _utilizarpontos = value
        End Set
    End Property

    Public Property usarepsonlx300 As Boolean
        Get
            Return _usarepsonlx300
        End Get
        Set(value As Boolean)
            _usarepsonlx300 = value
        End Set
    End Property

    Public Property produtopredominantecte As String
        Get
            Return _produtopredominantecte
        End Get
        Set(value As String)
            _produtopredominantecte = value
        End Set
    End Property

    Public Property produtocomponentecte As String
        Get
            Return _produtocomponentecte
        End Get
        Set(value As String)
            _produtocomponentecte = value
        End Set
    End Property

    Public Property produtoaidf As String
        Get
            Return _produtoaidf
        End Get
        Set(value As String)
            _produtoaidf = value
        End Set
    End Property

    Public Property exibirdadosoliveira As Boolean
        Get
            Return _exibirdadosoliveira
        End Get
        Set(value As Boolean)
            _exibirdadosoliveira = value
        End Set
    End Property

    Public Property ocultavencibarrapedido As Boolean
        Get
            Return _ocultavencibarrapedido
        End Get
        Set(value As Boolean)
            _ocultavencibarrapedido = value
        End Set
    End Property

    Public Property emitenfse As Boolean
        Get
            Return _emitenfse
        End Get
        Set(value As Boolean)
            _emitenfse = value
        End Set
    End Property

    Public Property exibirdadoshs As Boolean
        Get
            Return _exibirdadoshs
        End Get
        Set(value As Boolean)
            _exibirdadoshs = value
        End Set
    End Property

    Public Property exibircustoletras As Boolean
        Get
            Return _exibircustoletras
        End Get
        Set(value As Boolean)
            _exibircustoletras = value
        End Set
    End Property

    Public Property nfseusuario As String
        Get
            Return _nfseusuario
        End Get
        Set(value As String)
            _nfseusuario = value
        End Set
    End Property

    Public Property nfsesenha As String
        Get
            Return _nfsesenha
        End Get
        Set(value As String)
            _nfsesenha = value
        End Set
    End Property

    Public Property nfsecancelamento As String
        Get
            Return _nfsecancelamento
        End Get
        Set(value As String)
            _nfsecancelamento = value
        End Set
    End Property

    Public Property nfseconsultalote As String
        Get
            Return _nfseconsultalote
        End Get
        Set(value As String)
            _nfseconsultalote = value
        End Set
    End Property

    Public Property nfseconsultafaixa As String
        Get
            Return _nfseconsultafaixa
        End Get
        Set(value As String)
            _nfseconsultafaixa = value
        End Set
    End Property

    Public Property nfseconsultarps As String
        Get
            Return _nfseconsultarps
        End Get
        Set(value As String)
            _nfseconsultarps = value
        End Set
    End Property

    Public Property nfseconsultaprestados As String
        Get
            Return _nfseconsultaprestados
        End Get
        Set(value As String)
            _nfseconsultaprestados = value
        End Set
    End Property

    Public Property nfseconsultaenvioloterps As String
        Get
            Return _nfseconsultaenvioloterps
        End Get
        Set(value As String)
            _nfseconsultaenvioloterps = value
        End Set
    End Property

    Public Property nfseconsultaenviorps As String
        Get
            Return _nfseconsultaenviorps
        End Get
        Set(value As String)
            _nfseconsultaenviorps = value
        End Set
    End Property

    Public Property nfseconsultasequencialote As String
        Get
            Return _nfseconsultasequencialote
        End Get
        Set(value As String)
            _nfseconsultasequencialote = value
        End Set
    End Property

    Public Property exibirvendedorcupom As Boolean
        Get
            Return _exibirvendedorcupom
        End Get
        Set(value As Boolean)
            _exibirvendedorcupom = value
        End Set
    End Property

    Public Property caixapadrao As Long
        Get
            Return _caixapadrao
        End Get
        Set(value As Long)
            _caixapadrao = value
        End Set
    End Property

    Public Property cadastroduplicadosclientes As Boolean
        Get
            Return _cadastroduplicadosclientes
        End Get
        Set(value As Boolean)
            _cadastroduplicadosclientes = value
        End Set
    End Property

    Public Property ocultarcestnota As Boolean
        Get
            Return _ocultarcestnota
        End Get
        Set(value As Boolean)
            _ocultarcestnota = value
        End Set
    End Property

    Public Property naoalteracustoentrada As Boolean
        Get
            Return _naoalteracustoentrada
        End Get
        Set(value As Boolean)
            _naoalteracustoentrada = value
        End Set
    End Property

    Public Property exibirdadosmiotto As Boolean
        Get
            Return _exibirdadosmiotto
        End Get
        Set(value As Boolean)
            _exibirdadosmiotto = value
        End Set
    End Property

    Public Property exibirdadosvestbem As Boolean
        Get
            Return _exibirdadosvestbem
        End Get
        Set(value As Boolean)
            _exibirdadosvestbem = value
        End Set
    End Property

    Public Property exibirdadosestilo As Boolean
        Get
            Return _exibirdadosestilo
        End Get
        Set(value As Boolean)
            _exibirdadosestilo = value
        End Set
    End Property

    Public Property contacaixaveiculosvenda As String
        Get
            Return _contacaixaveiculosvenda
        End Get
        Set(value As String)
            _contacaixaveiculosvenda = value
        End Set
    End Property

    Public Property exibirdadostrattore As Boolean
        Get
            Return _exibirdadostrattore
        End Get
        Set(value As Boolean)
            _exibirdadostrattore = value
        End Set
    End Property

    Public Property contacaixachequelaca As String
        Get
            Return _contacaixachequelaca
        End Get
        Set(value As String)
            _contacaixachequelaca = value
        End Set
    End Property

    Public Property contacaixachequebaixa As String
        Get
            Return _contacaixachequebaixa
        End Get
        Set(value As String)
            _contacaixachequebaixa = value
        End Set
    End Property

    Public Property utilizaimportacaoautomatica As Boolean
        Get
            Return _utilizaimportacaoautomatica
        End Get
        Set(value As Boolean)
            _utilizaimportacaoautomatica = value
        End Set
    End Property

    Public Property gerablocok As Boolean
        Get
            Return _gerablocok
        End Get
        Set(value As Boolean)
            _gerablocok = value
        End Set
    End Property

    Public Property cstpadraocadastro As String
        Get
            Return _cstpadraocadastro
        End Get
        Set(value As String)
            _cstpadraocadastro = value
        End Set
    End Property

    Public Property converteimpostoentrada As Boolean
        Get
            Return _converteimpostoentrada
        End Get
        Set(value As Boolean)
            _converteimpostoentrada = value
        End Set
    End Property

    Public Property codnaturezadevolucao As String
        Get
            Return _codnaturezadevolucao
        End Get
        Set(value As String)
            _codnaturezadevolucao = value
        End Set
    End Property

    Public Property exibirdadoskitintas As Boolean
        Get
            Return _exibirdadoskitintas
        End Get
        Set(value As Boolean)
            _exibirdadoskitintas = value
        End Set
    End Property

    Public Property fretenota As String
        Get
            Return _fretenota
        End Get
        Set(value As String)
            _fretenota = value
        End Set
    End Property

    Public Property exibirdadosinnovar As Boolean
        Get
            Return _exibirdadosinnovar
        End Get
        Set(value As Boolean)
            _exibirdadosinnovar = value
        End Set
    End Property

    Public Property usarfatorconversao As Boolean
        Get
            Return _usarfatorconversao
        End Get
        Set(value As Boolean)
            _usarfatorconversao = value
        End Set
    End Property

    Public Property forcarcfopentrada As Boolean
        Get
            Return _forcarcfopentrada
        End Get
        Set(value As Boolean)
            _forcarcfopentrada = value
        End Set
    End Property

    Public Property geranotalote As Boolean
        Get
            Return _geranotalote
        End Get
        Set(value As Boolean)
            _geranotalote = value
        End Set
    End Property
End Class