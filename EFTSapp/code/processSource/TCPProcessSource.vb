Imports EFTSapp

Friend Class TCPProcessSource : Inherits AbstractProcessSource

    Private sourceID As Integer

    Public Sub New(sourceID As Integer)
        MyBase.New(sourceID)
    End Sub

    Public Overrides Sub start()

    End Sub

    Public Overrides Sub reset()

    End Sub
End Class
