Module appModule
    Private conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\config.accdb;Persist Security Info=False;"


    Public db As New OLEDBDataLayer(conn)
    Public logWriterObj As New LogWritter()



End Module
