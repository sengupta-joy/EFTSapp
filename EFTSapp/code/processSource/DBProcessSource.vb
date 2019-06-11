Imports EFTSapp

Friend Class DBProcessSource
    Inherits AbstractProcessSource

    Public Sub New(sourceID As Integer, process As APPProcessor)
        MyBase.New(sourceID, process)
    End Sub

    Public Overrides Sub start()

    End Sub

    Public Overrides Sub reset()

    End Sub
End Class
