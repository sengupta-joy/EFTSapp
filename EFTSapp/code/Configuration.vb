Imports System.Data.Common

Friend Class Configuration

    Public Property DBConns As New DataTable
    Public Property Process As List(Of APPProcessor)


    Public Shared Function getConfig() As Configuration
        Return New Configuration()
    End Function


    Private Sub New()
        readSettings()
    End Sub


    Private Sub readSettings()
        logWriter.write("loading connection strings")
        DBConns = getConnectionString()
        logWriter.write("loading connection strings done")

        logWriter.write("loading process")
        Process = readProcess()
        logWriter.write("loading process done")
    End Sub
    Private Function getConnectionString() As DataTable

        Dim sql As String = "select * from tbl_Connection"
        Dim result As New SqlResult
        Dim dt As New DataTable()

        dt.Columns.Add("name")
        dt.Columns.Add("type")
        dt.Columns.Add("constr")

        result = db.SelectData(sql)

        logWriter.write(result.Data.Tables(0).Rows.Count.ToString() + " connection strings found")

        For Each r As DataRow In result.Data.Tables(0).Rows
            dt.Rows.Add(r("Connection_Name"), r("Connection_Type"), r("Connection_String"))
            logWriter.write("Connection " + r("Connection_Name") + " loaded")
        Next

        Return dt
    End Function
    Private Function readProcess() As List(Of APPProcessor)
        Dim sql As String = "select * from tbl_procs"
        Dim res As SqlResult
        Dim resp As New List(Of APPProcessor)

        res = db.SelectData(sql)
        If res.Success Then
            logWriter.write(res.Data.Tables(0).Rows.Count.ToString() + " process found")
            For Each r As DataRow In res.Data.Tables(0).Rows
                resp.Add(New APPProcessor(r(0)))
                logWriter.write("Process " + r("proc_name") + " loaded")
            Next
        Else
            logWriter.write("loading process failed")
        End If

        res = Nothing

        Return resp
    End Function
    Public Function getProcess(id As Integer) As Object
        Dim sql As String = "select * from tbl_procs"
        Dim result = db.SelectData(sql)
        Dim dp As APPProcessor
        Dim resp As New List(Of APPProcessor)

        Try
            For Each r As DataRow In result.Data.Tables(0).Rows
                dp = New APPProcessor(r(0))
                resp.Add(dp)
            Next
        Catch ex As Exception

        End Try

        Return resp
    End Function
End Class
