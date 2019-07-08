Public Class Mac
    Private mac As String
    Private ip As String
    Private codvendedor As String

    Public Property Mac1 As String
        Get
            Return mac
        End Get
        Set(value As String)
            mac = value
        End Set
    End Property

    Public Property Ip1 As String
        Get
            Return ip
        End Get
        Set(value As String)
            ip = value
        End Set
    End Property

    Public Property Codvendedor1 As String
        Get
            Return codvendedor
        End Get
        Set(value As String)
            codvendedor = value
        End Set
    End Property
End Class
