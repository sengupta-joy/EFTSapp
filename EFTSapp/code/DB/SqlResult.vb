Public Class SqlResult
    Private _ds As DataSet
    Private _succ As Boolean
    Private _msg As String

    Public Sub New()
        Success = False
        _ds = New DataSet()
    End Sub


    Public ReadOnly Property Data As DataSet
        Get
            Return _ds
        End Get
    End Property
    Public Property Success As Boolean
        Get
            Return _succ
        End Get
        Set(value As Boolean)
            _succ = value
        End Set
    End Property
    Public Property Message As String
        Get
            Return _msg
        End Get
        Set(value As String)
            _msg = value
        End Set
    End Property



End Class
