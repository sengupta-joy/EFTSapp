Public NotInheritable Class MessageProcessQueue

    Private Shared _msgQue As Dictionary(Of Guid, Dictionary(Of String, Object))

    Shared Sub New()
        _msgQue = New Dictionary(Of Guid, Dictionary(Of String, Object))
    End Sub

    Private Sub New()

    End Sub

    Public Shared Function InsertNew() As Guid
        Dim id = Guid.NewGuid()
        _msgQue.Add(id, New Dictionary(Of String, Object)())
        Return id
    End Function

    Public Shared Sub addItem(id As Guid, key As String, value As Object)
        Dim queue = _msgQue.FirstOrDefault(Function(x) x.Key = id).Value

        If Not queue Is Nothing Then
            queue.Add(key, value)
        End If
    End Sub

    Public Shared Sub updateItem(id As Guid, key As String, value As Object)
        Dim queue = _msgQue.FirstOrDefault(Function(x) x.Key = id).Value

        If Not queue Is Nothing Then
            queue(key) = value
        End If
    End Sub

    Public Shared Sub removeItem(id As Guid, key As String)
        Dim queue = _msgQue.FirstOrDefault(Function(x) x.Key = id).Value

        If Not queue Is Nothing Then
            queue.Remove(key)
        End If
    End Sub

    Public Shared Sub removeItem(id As Guid)
        _msgQue.Remove(id)
    End Sub
End Class

