Friend Class Service
    Friend Shared Sub start(setting As Settings)

        For Each p In setting.Process
            p.start()
        Next

    End Sub
End Class
