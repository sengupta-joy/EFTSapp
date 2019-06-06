Imports System.Data.Common

Friend Class Settings

    Public Property DBConns As New Dictionary(Of String, DbConnection)
    Public Property Process As List(Of DataProcessor)

    Private conn As OleDb.OleDbConnection


    Public Sub New()
        connectDB()
        readSettings()
        disconnectDB()
    End Sub
    Private Sub connectDB()
        Dim path = Application.StartupPath
        conn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\config.accdb;Persist Security Info=False;")

        Try
            conn.Open()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
    Private Sub disconnectDB()
        Try
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub readSettings()
        DBConns = getConnectionString()
        Process = readProcess()
    End Sub



    Private Function getConnectionString() As Dictionary(Of String, DbConnection)

        Dim sql As String = "select * from tbl_Connection"
        Dim dt As New DataTable("")
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        Dim cn As DbConnection
        Dim resp As New Dictionary(Of String, DbConnection)()

        Try
            da.Fill(dt)

            For Each r As DataRow In dt.Rows

                If r(3) = "SQL" Then
                    cn = New SqlClient.SqlConnection(r(2))
                    resp.Add(r(1), cn)
                ElseIf r(3) = "ODBC" Then
                    cn = New Odbc.OdbcConnection(r(2))
                    resp.Add(r(1), cn)
                ElseIf r(3) = "OLEDB" Then
                    cn = New OleDb.OleDbConnection(r(2))
                    resp.Add(r(1), cn)
                End If

                cn.Open()
            Next
        Catch ex As Exception

        End Try

        Return resp
    End Function

    Private Function readProcess() As List(Of DataProcessor)
        Dim sql As String = "select * from tbl_procs"
        Dim dt As New DataTable("")
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        Dim dp As DataProcessor
        Dim resp As New List(Of DataProcessor)

        Try
            da.Fill(dt)
            For Each r As DataRow In dt.Rows
                dp = New DataProcessor()
                dp.ID = r(0)
                dp.Name = r(1)

                resp.Add(dp)
            Next
        Catch ex As Exception

        End Try

        Return resp
    End Function
End Class
