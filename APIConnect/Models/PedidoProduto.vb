Public Class PedidoProduto

    Private _codmecanico As String 'Cód Mecanico
    Private _codpedido As Double 'Cód Pedido
    Private _codproduto As String 'Cód Produto
    Private _comip As Double
    Private _conta As Integer
    Private _custo As Double
    Private _datas As Date
    Private _desconto As Double
    Private _descri As String
    Private _desenho As String
    Private _desvalor As Double
    Private _dot As String
    Private _eminota As Boolean
    Private _eminotaagru As Boolean
    Private _lucro As Double
    Private _marca As String
    Private _modelo As String
    Private _nserie As String
    Private _pedido As Long
    Private _porimposto As Double
    Private _quanti As Double
    Private _quantidade As Double
    Private _retirada As Double
    Private _saldoret As Double
    Private _tamanho As String
    Private _totalimposto As Double
    Private _totalimpostoest As Double
    Private _valortotal As Double 'Valor Total
    Private _valorunitario As Double 'Valor Unitário

    Public Property Codmecanico As String
        Get
            Return _codmecanico
        End Get
        Set(value As String)
            _codmecanico = value
        End Set
    End Property

    Public Property Codpedido As Double
        Get
            Return _codpedido
        End Get
        Set(value As Double)
            _codpedido = value
        End Set
    End Property

    Public Property Codproduto As String
        Get
            Return _codproduto
        End Get
        Set(value As String)
            _codproduto = value
        End Set
    End Property

    Public Property Comip As Double
        Get
            Return _comip
        End Get
        Set(value As Double)
            _comip = value
        End Set
    End Property

    Public Property Conta As Integer
        Get
            Return _conta
        End Get
        Set(value As Integer)
            _conta = value
        End Set
    End Property

    Public Property Custo As Double
        Get
            Return _custo
        End Get
        Set(value As Double)
            _custo = value
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

    Public Property Desconto As Double
        Get
            Return _desconto
        End Get
        Set(value As Double)
            _desconto = value
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

    Public Property Desenho As String
        Get
            Return _desenho
        End Get
        Set(value As String)
            _desenho = value
        End Set
    End Property

    Public Property Desvalor As Double
        Get
            Return _desvalor
        End Get
        Set(value As Double)
            _desvalor = value
        End Set
    End Property

    Public Property Dot As String
        Get
            Return _dot
        End Get
        Set(value As String)
            _dot = value
        End Set
    End Property

    Public Property Eminota As Boolean
        Get
            Return _eminota
        End Get
        Set(value As Boolean)
            _eminota = value
        End Set
    End Property

    Public Property Eminotaagru As Boolean
        Get
            Return _eminotaagru
        End Get
        Set(value As Boolean)
            _eminotaagru = value
        End Set
    End Property

    Public Property Lucro As Double
        Get
            Return _lucro
        End Get
        Set(value As Double)
            _lucro = value
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

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property Nserie As String
        Get
            Return _nserie
        End Get
        Set(value As String)
            _nserie = value
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

    Public Property Porimposto As Double
        Get
            Return _porimposto
        End Get
        Set(value As Double)
            _porimposto = value
        End Set
    End Property

    Public Property Quanti As Double
        Get
            Return _quanti
        End Get
        Set(value As Double)
            _quanti = value
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

    Public Property Retirada As Double
        Get
            Return _retirada
        End Get
        Set(value As Double)
            _retirada = value
        End Set
    End Property

    Public Property Saldoret As Double
        Get
            Return _saldoret
        End Get
        Set(value As Double)
            _saldoret = value
        End Set
    End Property

    Public Property Tamanho As String
        Get
            Return _tamanho
        End Get
        Set(value As String)
            _tamanho = value
        End Set
    End Property

    Public Property Totalimposto As Double
        Get
            Return _totalimposto
        End Get
        Set(value As Double)
            _totalimposto = value
        End Set
    End Property

    Public Property Totalimpostoest As Double
        Get
            Return _totalimpostoest
        End Get
        Set(value As Double)
            _totalimpostoest = value
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

    Public Property Valorunitario As Double
        Get
            Return _valorunitario
        End Get
        Set(value As Double)
            _valorunitario = value
        End Set
    End Property
End Class
