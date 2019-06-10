Public MustInherit Class AbstractProcessSource

    Private _lu As DateTime

    Public Property LastUsed As DateTime
        Get
            Return _lu
        End Get
        Protected Set(value As DateTime)
            _lu = value
        End Set
    End Property

    Public Property Configurations

    Public MustOverride Sub start()
    Public MustOverride Sub reset()


End Class
