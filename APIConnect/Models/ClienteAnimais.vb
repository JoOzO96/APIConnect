Public Class ClienteAnimais
    Private _idclienteanimal As Long
    Private _codcliente As Long
    Private _nomeanimal As String
    Private _datanascimentoanimal As Date
    Private _especieanimal As String
    Private _sexoanimal As String
    Private _racaanimal As String
    Private _pelagem As String
    Private _pesoanimal As Single
    Private _situacaoanimal As String
    Private _obsanimal As String
    Private _cadastroAndroid As Boolean
    Private _alteradoAndroid As Boolean

    Public Property codcliente As Long
        Get
            Return _codcliente
        End Get
        Set(value As Long)
            _codcliente = value
        End Set
    End Property

    Public Property nomeanimal As String
        Get
            Return _nomeanimal
        End Get
        Set(value As String)
            _nomeanimal = value
        End Set
    End Property

    Public Property datanascimentoanimal As Date
        Get
            Return _datanascimentoanimal
        End Get
        Set(value As Date)
            _datanascimentoanimal = value
        End Set
    End Property

    Public Property especieanimal As String
        Get
            Return _especieanimal
        End Get
        Set(value As String)
            _especieanimal = value
        End Set
    End Property

    Public Property sexoanimal As String
        Get
            Return _sexoanimal
        End Get
        Set(value As String)
            _sexoanimal = value
        End Set
    End Property

    Public Property racaanimal As String
        Get
            Return _racaanimal
        End Get
        Set(value As String)
            _racaanimal = value
        End Set
    End Property

    Public Property pelagem As String
        Get
            Return _pelagem
        End Get
        Set(value As String)
            _pelagem = value
        End Set
    End Property

    Public Property pesoanimal As Single
        Get
            Return _pesoanimal
        End Get
        Set(value As Single)
            _pesoanimal = value
        End Set
    End Property

    Public Property situacaoanimal As String
        Get
            Return _situacaoanimal
        End Get
        Set(value As String)
            _situacaoanimal = value
        End Set
    End Property

    Public Property obsanimal As String
        Get
            Return _obsanimal
        End Get
        Set(value As String)
            _obsanimal = value
        End Set
    End Property

    Public Property cadastroandroid As Boolean
        Get
            Return _cadastroAndroid
        End Get
        Set(value As Boolean)
            _cadastroAndroid = value
        End Set
    End Property

    Public Property alteradoandroid As Boolean
        Get
            Return _alteradoAndroid
        End Get
        Set(value As Boolean)
            _alteradoAndroid = value
        End Set
    End Property

    Public Property idclienteanimal As Long
        Get
            Return _idclienteanimal
        End Get
        Set(value As Long)
            _idclienteanimal = value
        End Set
    End Property
End Class
