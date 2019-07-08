Public Class Cidade
    Private _codcidade As Long
    Private _nomecidade As String
    Private _uf As String
    Private _codnacionaluf As String
    Private _codnacionalcidade As String
    Private _pais As String
    Private _codnacionalpais As String
    Private _cep As String

    Public Property codcidade As Long
        Get
            Return _codcidade
        End Get
        Set(value As Long)
            _codcidade = value
        End Set
    End Property

    Public Property nomecidade As String
        Get
            Return _nomecidade
        End Get
        Set(value As String)
            _nomecidade = value
        End Set
    End Property

    Public Property uf As String
        Get
            Return _uf
        End Get
        Set(value As String)
            _uf = value
        End Set
    End Property

    Public Property codnacionaluf As String
        Get
            Return _codnacionaluf
        End Get
        Set(value As String)
            _codnacionaluf = value
        End Set
    End Property

    Public Property codnacionalcidade As String
        Get
            Return _codnacionalcidade
        End Get
        Set(value As String)
            _codnacionalcidade = value
        End Set
    End Property

    Public Property pais As String
        Get
            Return _pais
        End Get
        Set(value As String)
            _pais = value
        End Set
    End Property

    Public Property codnacionalpais As String
        Get
            Return _codnacionalpais
        End Get
        Set(value As String)
            _codnacionalpais = value
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
End Class