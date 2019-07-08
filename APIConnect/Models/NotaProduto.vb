Public Class NotaProduto
    Private _codnota As String
    Private _codemitente As Long
    Private _codigo As String
    Private _auto As Long
    Private _quantidade As Double
    Private _valorunitário As Double
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
    Private _códpis As String
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

    Public Property Codigo As String
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

    Public Property Quantidade As Double
        Get
            Return _quantidade
        End Get
        Set(value As Double)
            _quantidade = value
        End Set
    End Property

    Public Property Valorunitário As Double
        Get
            Return _valorunitário
        End Get
        Set(value As Double)
            _valorunitário = value
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

    Public Property Valornota As Double
        Get
            Return _valornota
        End Get
        Set(value As Double)
            _valornota = value
        End Set
    End Property

    Public Property Valoripi As Double
        Get
            Return _valoripi
        End Get
        Set(value As Double)
            _valoripi = value
        End Set
    End Property

    Public Property Aliqicms As Double
        Get
            Return _aliqicms
        End Get
        Set(value As Double)
            _aliqicms = value
        End Set
    End Property

    Public Property Aliqipi As Double
        Get
            Return _aliqipi
        End Get
        Set(value As Double)
            _aliqipi = value
        End Set
    End Property

    Public Property Codicms As String
        Get
            Return _codicms
        End Get
        Set(value As String)
            _codicms = value
        End Set
    End Property

    Public Property Peso As Single
        Get
            Return _peso
        End Get
        Set(value As Single)
            _peso = value
        End Set
    End Property

    Public Property Cfop As String
        Get
            Return _cfop
        End Get
        Set(value As String)
            _cfop = value
        End Set
    End Property

    Public Property Bicms As Double
        Get
            Return _bicms
        End Get
        Set(value As Double)
            _bicms = value
        End Set
    End Property

    Public Property Vicms As Double
        Get
            Return _vicms
        End Get
        Set(value As Double)
            _vicms = value
        End Set
    End Property

    Public Property Descopro As Double
        Get
            Return _descopro
        End Get
        Set(value As Double)
            _descopro = value
        End Set
    End Property

    Public Property Mvap As Single
        Get
            Return _mvap
        End Get
        Set(value As Single)
            _mvap = value
        End Set
    End Property

    Public Property Vbcst As Double
        Get
            Return _vbcst
        End Get
        Set(value As Double)
            _vbcst = value
        End Set
    End Property

    Public Property Vsst As Double
        Get
            Return _vsst
        End Get
        Set(value As Double)
            _vsst = value
        End Set
    End Property

    Public Property Vseguro As Double
        Get
            Return _vseguro
        End Get
        Set(value As Double)
            _vseguro = value
        End Set
    End Property

    Public Property Descri As String
        Get
            Return _descri
        End Get
        Set(value As String)
            _descri = value
        End Set
    End Property

    Public Property Vfrete As Double
        Get
            Return _vfrete
        End Get
        Set(value As Double)
            _vfrete = value
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

    Public Property Códpis As String
        Get
            Return _códpis
        End Get
        Set(value As String)
            _códpis = value
        End Set
    End Property

    Public Property Porpis As Single
        Get
            Return _porpis
        End Get
        Set(value As Single)
            _porpis = value
        End Set
    End Property

    Public Property Codcofins As String
        Get
            Return _codcofins
        End Get
        Set(value As String)
            _codcofins = value
        End Set
    End Property

    Public Property Porcofins As Single
        Get
            Return _porcofins
        End Get
        Set(value As Single)
            _porcofins = value
        End Set
    End Property

    Public Property Codipi As String
        Get
            Return _codipi
        End Get
        Set(value As String)
            _codipi = value
        End Set
    End Property

    Public Property Sst As String
        Get
            Return _sst
        End Get
        Set(value As String)
            _sst = value
        End Set
    End Property

    Public Property Voutros As Double
        Get
            Return _voutros
        End Get
        Set(value As Double)
            _voutros = value
        End Set
    End Property

    Public Property Totaltribpro As Double
        Get
            Return _totaltribpro
        End Get
        Set(value As Double)
            _totaltribpro = value
        End Set
    End Property

    Public Property Porimposto As Single
        Get
            Return _porimposto
        End Get
        Set(value As Single)
            _porimposto = value
        End Set
    End Property

    Public Property Pesoliq As Single
        Get
            Return _pesoliq
        End Get
        Set(value As Single)
            _pesoliq = value
        End Set
    End Property

    Public Property Datas As Date
        Get
            Return _datas
        End Get
        Set(value As Date)
            _datas = value
        End Set
    End Property

    Public Property Cstpis As Single
        Get
            Return _cstpis
        End Get
        Set(value As Single)
            _cstpis = value
        End Set
    End Property

    Public Property Vpis As Double
        Get
            Return _vpis
        End Get
        Set(value As Double)
            _vpis = value
        End Set
    End Property

    Public Property Cstcofins As Single
        Get
            Return _cstcofins
        End Get
        Set(value As Single)
            _cstcofins = value
        End Set
    End Property

    Public Property Vcofins As Double
        Get
            Return _vcofins
        End Get
        Set(value As Double)
            _vcofins = value
        End Set
    End Property

    Public Property Vcusto As Double
        Get
            Return _vcusto
        End Get
        Set(value As Double)
            _vcusto = value
        End Set
    End Property

    Public Property Totaltribest As Double
        Get
            Return _totaltribest
        End Get
        Set(value As Double)
            _totaltribest = value
        End Set
    End Property

    Public Property Comple As String
        Get
            Return _comple
        End Get
        Set(value As String)
            _comple = value
        End Set
    End Property

    Public Property Ncmproduto As String
        Get
            Return _ncmproduto
        End Get
        Set(value As String)
            _ncmproduto = value
        End Set
    End Property
End Class
