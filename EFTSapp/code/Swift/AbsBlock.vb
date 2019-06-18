Public MustInherit Class absBlock
    Protected _nm As String

    Public ReadOnly Property Name As String
        Get
            Return _nm
        End Get
    End Property

    Public Sub New(blockName As String)
        _nm = blockName
    End Sub


End Class
