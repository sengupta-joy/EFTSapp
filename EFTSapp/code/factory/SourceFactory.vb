Imports EFTSapp
Imports EFTSapp.code

Friend Class SourceFactory
    Friend Shared Function make(sourceID As Integer, sourceTP As SourceType) As AbstractProcessSource
        If sourceTP = SourceType.TCP_PORT Then
            Return New TCPProcessSource(sourceID)
        End If
    End Function
End Class
