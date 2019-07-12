Public Class NotaProduto
    Private _codnota As String
    Private _codemitente As Long
    Private _codigo As String
    Private _auto As Long
    Private _quantidade As Double
    Private _valorunitario As Double
    Private _valortotal As Double
    Private _valornota As Double
    Private _valoripi As Double
    Private _aliqicms As Double
    Private _aliqipi As Double
    Private _codicms As String
    Private _peso As Single
    Private _cfop As String
    Private _bicms As Double
    Private _vicms As Double
    Private _descopro As Double
    Private _mvap As Single
    Private _vbcst As Double
    Private _vsst As Double
    Private _vseguro As Double
    Private _descri As String
    Private _vfrete As Double
    Private _codtipo As Byte
    Private _codpis As String
    Private _porpis As Single
    Private _codcofins As String
    Private _porcofins As Single
    Private _codipi As String
    Private _sst As String
    Private _voutros As Double
    Private _totaltribpro As Double
    Private _porimposto As Single
    Private _pesoliq As Single
    Private _datas As Date
    Private _cstpis As Single
    Private _vpis As Double
    Private _cstcofins As Single
    Private _vcofins As Double
    Private _vcusto As Double
    Private _totaltribest As Double
    Private _comple As String
    Private _ncmproduto As String

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

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Auto As Long
        Get
            Return _auto
        End Get
        Set(value As Long)
            _auto = value
        End Set
    End Property

    Public Property quantidade As Double
        Get
            Return _quantidade
        End Get
        Set(value As Double)
            _quantidade = value
        End Set
    End Property

    Public Property valorunitario As Double
        Get
            Return _valorunitario
        End Get
        Set(value As Double)
            _valorunitario = value
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

    Public Property valornota As Double
        Get
            Return _valornota
        End Get
        Set(value As Double)
            _valornota = value
        End Set
    End Property

    Public Property valoripi As Double
        Get
            Return _valoripi
        End Get
        Set(value As Double)
            _valoripi = value
        End Set
    End Property

    Public Property aliqicms As Double
        Get
            Return _aliqicms
        End Get
        Set(value As Double)
            _aliqicms = value
        End Set
    End Property

    Public Property aliqipi As Double
        Get
            Return _aliqipi
        End Get
        Set(value As Double)
            _aliqipi = value
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

    Public Property peso As Single
        Get
            Return _peso
        End Get
        Set(value As Single)
            _peso = value
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

    Public Property bicms As Double
        Get
            Return _bicms
        End Get
        Set(value As Double)
            _bicms = value
        End Set
    End Property

    Public Property vicms As Double
        Get
            Return _vicms
        End Get
        Set(value As Double)
            _vicms = value
        End Set
    End Property

    Public Property descopro As Double
        Get
            Return _descopro
        End Get
        Set(value As Double)
            _descopro = value
        End Set
    End Property

    Public Property mvap As Single
        Get
            Return _mvap
        End Get
        Set(value As Single)
            _mvap = value
        End Set
    End Property

    Public Property vbcst As Double
        Get
            Return _vbcst
        End Get
        Set(value As Double)
            _vbcst = value
        End Set
    End Property

    Public Property vsst As Double
        Get
            Return _vsst
        End Get
        Set(value As Double)
            _vsst = value
        End Set
    End Property

    Public Property vseguro As Double
        Get
            Return _vseguro
        End Get
        Set(value As Double)
            _vseguro = value
        End Set
    End Property

    Public Property descri As String
        Get
            Return _descri
        End Get
        Set(value As String)
            _descri = value
        End Set
    End Property

    Public Property vfrete As Double
        Get
            Return _vfrete
        End Get
        Set(value As Double)
            _vfrete = value
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

    Public Property codpis As String
        Get
            Return _codpis
        End Get
        Set(value As String)
            _codpis = value
        End Set
    End Property

    Public Property porpis As Single
        Get
            Return _porpis
        End Get
        Set(value As Single)
            _porpis = value
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

    Public Property porcofins As Single
        Get
            Return _porcofins
        End Get
        Set(value As Single)
            _porcofins = value
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

    Public Property sst As String
        Get
            Return _sst
        End Get
        Set(value As String)
            _sst = value
        End Set
    End Property

    Public Property voutros As Double
        Get
            Return _voutros
        End Get
        Set(value As Double)
            _voutros = value
        End Set
    End Property

    Public Property totaltribpro As Double
        Get
            Return _totaltribpro
        End Get
        Set(value As Double)
            _totaltribpro = value
        End Set
    End Property

    Public Property porimposto As Single
        Get
            Return _porimposto
        End Get
        Set(value As Single)
            _porimposto = value
        End Set
    End Property

    Public Property pesoliq As Single
        Get
            Return _pesoliq
        End Get
        Set(value As Single)
            _pesoliq = value
        End Set
    End Property

    Public Property datas As Date
        Get
            Return _datas
        End Get
        Set(value As Date)
            _datas = value
        End Set
    End Property

    Public Property cstpis As Single
        Get
            Return _cstpis
        End Get
        Set(value As Single)
            _cstpis = value
        End Set
    End Property

    Public Property vpis As Double
        Get
            Return _vpis
        End Get
        Set(value As Double)
            _vpis = value
        End Set
    End Property

    Public Property cstcofins As Single
        Get
            Return _cstcofins
        End Get
        Set(value As Single)
            _cstcofins = value
        End Set
    End Property

    Public Property vcofins As Double
        Get
            Return _vcofins
        End Get
        Set(value As Double)
            _vcofins = value
        End Set
    End Property

    Public Property vcusto As Double
        Get
            Return _vcusto
        End Get
        Set(value As Double)
            _vcusto = value
        End Set
    End Property

    Public Property totaltribest As Double
        Get
            Return _totaltribest
        End Get
        Set(value As Double)
            _totaltribest = value
        End Set
    End Property

    Public Property comple As String
        Get
            Return _comple
        End Get
        Set(value As String)
            _comple = value
        End Set
    End Property

    Public Property ncmproduto As String
        Get
            Return _ncmproduto
        End Get
        Set(value As String)
            _ncmproduto = value
        End Set
    End Property
End Class
