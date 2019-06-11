Imports EFTSapp
Imports EFTSapp.code

Public MustInherit Class AbstractProcessSource

    Private _sourceID As Integer
    Private _lu As DateTime
    Private _sourceType As SourceType
    Private _config As Dictionary(Of String, String)
    Private _mainProcess As APPProcessor

    Public Property SourceID As Integer
        Get
            Return _sourceID
        End Get
        Private Set(value As Integer)
            _sourceID = value
        End Set
    End Property



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

    Public Property MainProcess As APPProcessor
        Get
            Return _mainProcess
        End Get
        Private Set(value As APPProcessor)
            _mainProcess = value
        End Set
    End Property

    Public Sub New(sourceID As Integer, process As APPProcessor)
        Me.SourceID = sourceID
        Me.MainProcess = process
        _config = New Dictionary(Of String, String)()

        Dim sql As String = "SELECT tbl_config.* FROM tbl_source INNER JOIN tbl_config ON tbl_source.source_id = tbl_config.source_id WHERE (((tbl_source.Source_ID)=" + sourceID.ToString() + "))"
        Dim res = db.SelectData(sql)

        If res.Success Then
            For Each row In res.Data.Tables(0).Rows
                Configurations.Add(row("config_name"), row("config_value"))
            Next
        End If

    End Sub

    Public MustOverride Sub start()
    Public MustOverride Sub reset()


End Class
