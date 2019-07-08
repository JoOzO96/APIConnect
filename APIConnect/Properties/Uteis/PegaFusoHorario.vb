Module PegaFusoHorario
    Public Function PegaTimeZone() As String
        Dim curTimeZone As TimeZone = TimeZone.CurrentTimeZone
        Dim currentOffset As TimeSpan = curTimeZone.GetUtcOffset(DateTime.Now)
        Return currentOffset.ToString

    End Function
End Module
