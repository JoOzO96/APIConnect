Public Class PedidoProduto


    Private _pedido As Long
    Private _codproduto As String
    Private _codpedido As Double
    Private _quantidade As Single
    Private _valorunitario As Double
    Private _valortotal As Double
    Private _desconto As Double
    Private _quanti As Single
    Private _lucro As Single
    Private _custo As Double
    Private _descri As String
    Private _tamanho As String
    Private _desvalor As Single
    Private _totalimposto As Double
    Private _porimposto As Single
    Private _eminota As Boolean
    Private _datas As Date
    Private _emitenota As Boolean
    Private _modelo As String
    Private _marca As String
    Private _desenho As String
    Private _nserie As String
    Private _dot As String
    Private _retirada As Single
    Private _saldoret As Single
    Private _totalimpostoest As Double
    Private _comip As Single
    Private _vcomi As Single
    Private _eminotaagru As Boolean
    Private _codcor As Long
    Private _pp As Byte
    Private _p As Byte
    Private _m As Byte
    Private _g As Byte
    Private _gg As Byte

    Public Property pedido As Long
        Get
            Return _pedido
        End Get
        Set(value As Long)
            _pedido = value
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

    Public Property codpedido As Double
        Get
            Return _codpedido
        End Get
        Set(value As Double)
            _codpedido = value
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

    Public Property desconto As Double
        Get
            Return _desconto
        End Get
        Set(value As Double)
            _desconto = value
        End Set
    End Property

    Public Property quanti As Single
        Get
            Return _quanti
        End Get
        Set(value As Single)
            _quanti = value
        End Set
    End Property

    Public Property lucro As Single
        Get
            Return _lucro
        End Get
        Set(value As Single)
            _lucro = value
        End Set
    End Property

    Public Property custo As Double
        Get
            Return _custo
        End Get
        Set(value As Double)
            _custo = value
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

    Public Property tamanho As String
        Get
            Return _tamanho
        End Get
        Set(value As String)
            _tamanho = value
        End Set
    End Property

    Public Property desvalor As Single
        Get
            Return _desvalor
        End Get
        Set(value As Single)
            _desvalor = value
        End Set
    End Property

    Public Property totalimposto As Double
        Get
            Return _totalimposto
        End Get
        Set(value As Double)
            _totalimposto = value
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

    Public Property eminota As Boolean
        Get
            Return _eminota
        End Get
        Set(value As Boolean)
            _eminota = value
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

    Public Property emitenota As Boolean
        Get
            Return _emitenota
        End Get
        Set(value As Boolean)
            _emitenota = value
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

    Public Property marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property desenho As String
        Get
            Return _desenho
        End Get
        Set(value As String)
            _desenho = value
        End Set
    End Property

    Public Property nserie As String
        Get
            Return _nserie
        End Get
        Set(value As String)
            _nserie = value
        End Set
    End Property

    Public Property dot As String
        Get
            Return _dot
        End Get
        Set(value As String)
            _dot = value
        End Set
    End Property

    Public Property retirada As Single
        Get
            Return _retirada
        End Get
        Set(value As Single)
            _retirada = value
        End Set
    End Property

    Public Property saldoret As Single
        Get
            Return _saldoret
        End Get
        Set(value As Single)
            _saldoret = value
        End Set
    End Property

    Public Property totalimpostoest As Double
        Get
            Return _totalimpostoest
        End Get
        Set(value As Double)
            _totalimpostoest = value
        End Set
    End Property

    Public Property comip As Single
        Get
            Return _comip
        End Get
        Set(value As Single)
            _comip = value
        End Set
    End Property

    Public Property vcomi As Single
        Get
            Return _vcomi
        End Get
        Set(value As Single)
            _vcomi = value
        End Set
    End Property

    Public Property eminotaagru As Boolean
        Get
            Return _eminotaagru
        End Get
        Set(value As Boolean)
            _eminotaagru = value
        End Set
    End Property
End Class
