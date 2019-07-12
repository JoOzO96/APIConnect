Public Class Icms

    Private _codicms As String
    Private _percentual As String
    Private _percen As Single
    Private _percentualsimples As Single
    Private _percentualdificms As Single

    Public Property codicms As String
        Get
            Return _codicms
        End Get
        Set(value As String)
            _codicms = value
        End Set
    End Property

    Public Property percentual As String
        Get
            Return _percentual
        End Get
        Set(value As String)
            _percentual = value
        End Set
    End Property

    Public Property percen As Single
        Get
            Return _percen
        End Get
        Set(value As Single)
            _percen = value
        End Set
    End Property

    Public Property percentualsimples As Single
        Get
            Return _percentualsimples
        End Get
        Set(value As Single)
            _percentualsimples = value
        End Set
    End Property

    Public Property percentualdificms As Single
        Get
            Return _percentualdificms
        End Get
        Set(value As Single)
            _percentualdificms = value
        End Set
    End Property
End Class
