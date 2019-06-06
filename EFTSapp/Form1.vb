Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As Series = Chart1.Series(0)
        s.ChartType = SeriesChartType.Line
        s.Color = Color.Red
        s.Points.AddY(My.Application.Info.WorkingSet / 1024 / 1024)

        Dim setting As New Settings()
        DataGridView1.DataSource = setting.Process

        Service.start(setting)

        'Dim inf As String
        'inf = "Mem Usage: " & x.WorkingSet64 / 1024 & " K" & vbCrLf _
        '    & "Paged Memory: " & x.PagedMemorySize64 / 1024 & " K"

        'ToolStripStatusLabel1.Text = inf

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub tmrUIRefresh_Tick(sender As Object, e As EventArgs) Handles tmrUIRefresh.Tick
        Dim x As Process = Process.GetCurrentProcess()
        ToolStripStatusLabel1.Text = (My.Application.Info.WorkingSet / 1024).ToString() + "KB"

        Dim workerThreads, portThreads As Integer
        Threading.ThreadPool.GetMaxThreads(workerThreads, portThreads)
        ProgressBar1.Maximum = workerThreads
        Threading.ThreadPool.GetAvailableThreads(workerThreads, portThreads)

        Try
            ProgressBar1.Value = Process.GetCurrentProcess().Threads.Count

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
End Class
