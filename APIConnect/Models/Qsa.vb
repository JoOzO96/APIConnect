Public Class Qsa
    Private _qual As String
    Private _nome As String

    Public Property qual As String
        Get
            Return _qual
        End Get
        Set(value As String)
            _qual = value
        End Set
    End Property

    Public Property nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property
End Class