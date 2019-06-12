Imports System.Threading
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Diagnostics.Runtime

Public Class Form1
    Dim srv As Service

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logWriter.write("Application started")
        srv = New Service()

        srv.start()
        setupUI()

        tmrUIRefresh.Enabled = True



    End Sub

    Private Sub test()

    End Sub

    Sub setupUI()
        Dim s As Series = Chart1.Series(0)

        s.ChartType = SeriesChartType.Line
        s.Color = Color.Red
        s.Points.AddY(My.Application.Info.WorkingSet / 1024 / 1024)

        loadLogs()
    End Sub



    Private Sub tmrUIRefresh_Tick(sender As Object, e As EventArgs) Handles tmrUIRefresh.Tick
        Dim x As Process = Process.GetCurrentProcess()

        ToolStripStatusLabel1.Text = (My.Application.Info.WorkingSet / 1024).ToString() + "KB"
        'logWriter.write("Memory consumption " + ToolStripStatusLabel1.Text)
        Dim workerThreads, portThreads As Integer
        Threading.ThreadPool.GetMaxThreads(workerThreads, portThreads)
        ProgressBar1.Maximum = workerThreads
        Threading.ThreadPool.GetAvailableThreads(workerThreads, portThreads)

        For Each t As ProcessThread In x.Threads


            If System.Threading.Thread.CurrentThread Is t Then
                MsgBox(t.Id)
            End If

        Next

        Try
            ProgressBar1.Value = x.Threads.Count

        Catch ex As Exception

        End Try

        lblThreadCount.Text = "(" + ProgressBar1.Value.ToString() + "/" + workerThreads.ToString() + ")"
        Dim s As Series = Chart1.Series(0)
        s.ChartType = SeriesChartType.Line
        s.Color = Color.Red
        s.Points.AddY(My.Application.Info.WorkingSet / 1024 / 1024)
        If s.Points.Count > 100 Then
            s.Points.RemoveAt(0)
        End If

        DataGridView1.DataSource = srv.config.Process
        DataGridView1.Refresh()
        GC.Collect()
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resp = MsgBox("Do you want to close", vbYesNo + vbApplicationModal + vbInformation)

        If resp = MsgBoxResult.Yes Then
            logWriter.write("Stopping service")
            End
        ElseIf resp = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub loadLogs()
        Dim config = LoggingUtility.getLogConfig()

        lblLogPath.Text = config("log_path")
        nmLogSize.Value = config("log_size")
        txtLogFormat.Text = config("log_format")
        chkLogEnable.Checked = config("log_enable")
        chkLogChangeDirOnStart.Checked = config("log_rename_onStart")
    End Sub

    Private Sub btnLogPath_Click(sender As Object, e As EventArgs) Handles btnLogPath.Click
        Dim r = fldDlg.ShowDialog()
        If r = DialogResult.OK Then
            lblLogPath.Text = fldDlg.SelectedPath
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub


End Class
