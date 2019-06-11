Imports System.Threading
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Diagnostics.Runtime

Public Class Form1
    Dim srv As Service

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        DataGridView1.DataSource = srv.config.Process
    End Sub



    Private Sub tmrUIRefresh_Tick(sender As Object, e As EventArgs) Handles tmrUIRefresh.Tick
        Dim x As Process = Process.GetCurrentProcess()

        ToolStripStatusLabel1.Text = (My.Application.Info.WorkingSet / 1024).ToString() + "KB"

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
        GC.Collect()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class
