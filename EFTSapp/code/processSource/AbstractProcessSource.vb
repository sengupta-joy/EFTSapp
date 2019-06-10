Imports EFTSapp.code

Public MustInherit Class AbstractProcessSource

    Private _lu As DateTime
    Private _sourceType As SourceType
    Private _config As Dictionary(Of String, String)

    Public Property LastUsed As DateTime
        Get
            Return _lu
        End Get
        Protected Set(value As DateTime)
            _lu = value
        End Set
    End Property
    Public ReadOnly Property Configurations As Dictionary(Of String, String)
        Get
            Return _config
        End Get
    End Property
    Public ReadOnly Property SourceType As SourceType
        Get
            Return _sourceType
        End Get
    End Property

    Public Sub New(sourceID As Integer)

    End Sub

    Public MustOverride Sub start()
    Public MustOverride Sub reset()


End Class
