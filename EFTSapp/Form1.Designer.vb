<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblThreadCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tmrUIRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogPath = New System.Windows.Forms.Button()
        Me.lblLogPath = New System.Windows.Forms.Label()
        Me.lblLogSize = New System.Windows.Forms.Label()
        Me.nmLogSize = New System.Windows.Forms.NumericUpDown()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.txtLogFormat = New System.Windows.Forms.TextBox()
        Me.chkLogEnable = New System.Windows.Forms.CheckBox()
        Me.chkLogChangeDirOnStart = New System.Windows.Forms.CheckBox()
        Me.btnLogSave = New System.Windows.Forms.Button()
        Me.fldDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.nmLogSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 403)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Controls.Add(Me.lblThreadCount)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 377)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Memory"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(11, 71)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(773, 300)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        '
        'lblThreadCount
        '
        Me.lblThreadCount.AutoSize = True
        Me.lblThreadCount.Location = New System.Drawing.Point(50, 26)
        Me.lblThreadCount.Name = "lblThreadCount"
        Me.lblThreadCount.Size = New System.Drawing.Size(17, 13)
        Me.lblThreadCount.TabIndex = 2
        Me.lblThreadCount.Text = "lbl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Threads"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(118, 22)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(666, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 377)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Process"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(786, 371)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnClear)
        Me.TabPage3.Controls.Add(Me.btnLogSave)
        Me.TabPage3.Controls.Add(Me.chkLogChangeDirOnStart)
        Me.TabPage3.Controls.Add(Me.chkLogEnable)
        Me.TabPage3.Controls.Add(Me.txtLogFormat)
        Me.TabPage3.Controls.Add(Me.lblFormat)
        Me.TabPage3.Controls.Add(Me.nmLogSize)
        Me.TabPage3.Controls.Add(Me.lblLogSize)
        Me.TabPage3.Controls.Add(Me.lblLogPath)
        Me.TabPage3.Controls.Add(Me.btnLogPath)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 377)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Logs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tmrUIRefresh
        '
        Me.tmrUIRefresh.Interval = 1000
        '
        'btnLogPath
        '
        Me.btnLogPath.Location = New System.Drawing.Point(9, 20)
        Me.btnLogPath.Name = "btnLogPath"
        Me.btnLogPath.Size = New System.Drawing.Size(26, 23)
        Me.btnLogPath.TabIndex = 0
        Me.btnLogPath.Text = "..."
        Me.btnLogPath.UseVisualStyleBackColor = True
        '
        'lblLogPath
        '
        Me.lblLogPath.AutoSize = True
        Me.lblLogPath.Location = New System.Drawing.Point(41, 25)
        Me.lblLogPath.Name = "lblLogPath"
        Me.lblLogPath.Size = New System.Drawing.Size(57, 13)
        Me.lblLogPath.TabIndex = 1
        Me.lblLogPath.Text = "lblLogPath"
        '
        'lblLogSize
        '
        Me.lblLogSize.AutoSize = True
        Me.lblLogSize.Location = New System.Drawing.Point(9, 50)
        Me.lblLogSize.Name = "lblLogSize"
        Me.lblLogSize.Size = New System.Drawing.Size(91, 13)
        Me.lblLogSize.TabIndex = 2
        Me.lblLogSize.Text = "Log max size (KB)"
        '
        'nmLogSize
        '
        Me.nmLogSize.Location = New System.Drawing.Point(106, 48)
        Me.nmLogSize.Maximum = New Decimal(New Integer() {102400, 0, 0, 0})
        Me.nmLogSize.Minimum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nmLogSize.Name = "nmLogSize"
        Me.nmLogSize.Size = New System.Drawing.Size(120, 20)
        Me.nmLogSize.TabIndex = 3
        Me.nmLogSize.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(9, 74)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(39, 13)
        Me.lblFormat.TabIndex = 4
        Me.lblFormat.Text = "Format"
        '
        'txtLogFormat
        '
        Me.txtLogFormat.Location = New System.Drawing.Point(106, 75)
        Me.txtLogFormat.Name = "txtLogFormat"
        Me.txtLogFormat.Size = New System.Drawing.Size(173, 20)
        Me.txtLogFormat.TabIndex = 5
        Me.txtLogFormat.Text = "dd/MM/yyyy hh:mm:ss.fff tt"
        '
        'chkLogEnable
        '
        Me.chkLogEnable.AutoSize = True
        Me.chkLogEnable.Checked = True
        Me.chkLogEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLogEnable.Location = New System.Drawing.Point(12, 108)
        Me.chkLogEnable.Name = "chkLogEnable"
        Me.chkLogEnable.Size = New System.Drawing.Size(96, 17)
        Me.chkLogEnable.TabIndex = 6
        Me.chkLogEnable.Text = "Enable logging"
        Me.chkLogEnable.UseVisualStyleBackColor = True
        '
        'chkLogChangeDirOnStart
        '
        Me.chkLogChangeDirOnStart.AutoSize = True
        Me.chkLogChangeDirOnStart.Checked = True
        Me.chkLogChangeDirOnStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLogChangeDirOnStart.Location = New System.Drawing.Point(12, 132)
        Me.chkLogChangeDirOnStart.Name = "chkLogChangeDirOnStart"
        Me.chkLogChangeDirOnStart.Size = New System.Drawing.Size(159, 17)
        Me.chkLogChangeDirOnStart.TabIndex = 7
        Me.chkLogChangeDirOnStart.Text = "Create new folder on startup"
        Me.chkLogChangeDirOnStart.UseVisualStyleBackColor = True
        '
        'btnLogSave
        '
        Me.btnLogSave.Location = New System.Drawing.Point(9, 175)
        Me.btnLogSave.Name = "btnLogSave"
        Me.btnLogSave.Size = New System.Drawing.Size(75, 23)
        Me.btnLogSave.TabIndex = 8
        Me.btnLogSave.Text = "Save"
        Me.btnLogSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(90, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Reload"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.nmLogSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tmrUIRefresh As Timer
    Friend WithEvents lblThreadCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblLogPath As Label
    Friend WithEvents btnLogPath As Button
    Friend WithEvents txtLogFormat As TextBox
    Friend WithEvents lblFormat As Label
    Friend WithEvents nmLogSize As NumericUpDown
    Friend WithEvents lblLogSize As Label
    Friend WithEvents btnLogSave As Button
    Friend WithEvents chkLogChangeDirOnStart As CheckBox
    Friend WithEvents chkLogEnable As CheckBox
    Friend WithEvents fldDlg As FolderBrowserDialog
    Friend WithEvents btnClear As Button
End Class
