Imports System.Threading
Imports EFTSapp
Imports EFTSapp.code

Public Class APPProcessor

    Private _newID As Integer
    Private _newName As String
    Private _newSrc As AbstractProcessSource
    Private _newDest As New List(Of AbstractProcessDestination)

    Public Property ID As Integer
        Get
            Return _newID
        End Get
        Private Set(value As Integer)
            _newID = value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _newName
        End Get
        Private Set(value As String)
            _newName = value
        End Set
    End Property
    Public Property Source As AbstractProcessSource
        Get
            Return _newSrc
        End Get
        Private Set(value As AbstractProcessSource)
            _newSrc = value
        End Set
    End Property

    Public ReadOnly Property Destinatons As List(Of AbstractProcessDestination)
        Get
            Return _newDest
        End Get
    End Property

    Public Sub New(ProcessID As Integer)
        Try
            Dim sql As String = "select *                                   " +
                                        "from   tbl_procs p                         " +
                                        "       inner join tbl_source s           " +
                                        "           on p.proc_source=s.source_id    " +
                                        "where  p.id=" + ProcessID.ToString()
            Dim resp = db.SelectData(sql)
            If resp.Success Then

                Dim sourceID = resp.Data.Tables(0).Rows(0)("source_id")
                Dim sourceType = resp.Data.Tables(0).Rows(0)("source_type")
                Source = SourceFactory.make(sourceID, sourceType)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub start()
        Source.start()
    End Sub
    Public Function restart()

    End Function

    Public Function checkHealth()

    End Function

End Class
