Friend Class Service

    Private _cnfg As Configuration

    Public Property config As Configuration
        Get
            Return _cnfg
        End Get
        Private Set(value As Configuration)
            _cnfg = value
        End Set
    End Property


    Public Sub New()
        logWriter.write("Loading configuration")
        config = Configuration.getConfig()
        logWriter.write("Loading configuration completed")
    End Sub

    Public Sub start()

        For Each p As APPProcessor In config.Process
            p.start()
        Next

    End Sub
End Class
