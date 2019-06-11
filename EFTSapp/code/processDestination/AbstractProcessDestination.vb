Public MustInherit Class AbstractProcessDestination

    'conditions

    Public MustOverride Function isValid(id As Guid) As Boolean
    Public MustOverride Function go(id As Guid) As Boolean

    Protected Sub New(destID As Integer)

    End Sub

End Class
