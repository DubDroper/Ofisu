<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits RoundedForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.DBnamelbl = New System.Windows.Forms.Label()
        Me.AboutBtn = New System.Windows.Forms.Button()
        Me.isMainDbOnlinePicBox = New System.Windows.Forms.PictureBox()
        Me.MainTitle = New System.Windows.Forms.Label()
        Me.MatBtnMinMain = New System.Windows.Forms.Button()
        Me.MatBtnCloseMain = New System.Windows.Forms.Button()
        Me.MainProBar = New System.Windows.Forms.ProgressBar()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDeleteTask = New System.Windows.Forms.Button()
        Me.btnCompleteTask = New System.Windows.Forms.Button()
        Me.TaskTxtBox = New System.Windows.Forms.TextBox()
        Me.TaskListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TimeDateLbl = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RamUsageLbl = New System.Windows.Forms.Label()
        Me.CpuUsageLbl = New System.Windows.Forms.Label()
        Me.MainBackgroundImg = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TaskCreatedDateLbl = New System.Windows.Forms.Label()
        Me.TaskCompleteDateLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.isMainDbOnlinePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.MainBackgroundImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'DBnamelbl
        '
        Me.DBnamelbl.AutoSize = True
        Me.DBnamelbl.ForeColor = System.Drawing.Color.White
        Me.DBnamelbl.Location = New System.Drawing.Point(25, 700)
        Me.DBnamelbl.Name = "DBnamelbl"
        Me.DBnamelbl.Size = New System.Drawing.Size(10, 13)
        Me.DBnamelbl.TabIndex = 10
        Me.DBnamelbl.Text = " "
        '
        'AboutBtn
        '
        Me.AboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.AboutBtn.FlatAppearance.BorderSize = 0
        Me.AboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutBtn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AboutBtn.ForeColor = System.Drawing.Color.Transparent
        Me.AboutBtn.Location = New System.Drawing.Point(1108, -18)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(33, 47)
        Me.AboutBtn.TabIndex = 9
        Me.AboutBtn.Text = "?"
        Me.AboutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AboutBtn.UseVisualStyleBackColor = True
        '
        'isMainDbOnlinePicBox
        '
        Me.isMainDbOnlinePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.isMainDbOnlinePicBox.Image = Global.Ofisu.My.Resources.Resources.RedCircle1
        Me.isMainDbOnlinePicBox.Location = New System.Drawing.Point(10, 701)
        Me.isMainDbOnlinePicBox.Margin = New System.Windows.Forms.Padding(0)
        Me.isMainDbOnlinePicBox.Name = "isMainDbOnlinePicBox"
        Me.isMainDbOnlinePicBox.Size = New System.Drawing.Size(12, 12)
        Me.isMainDbOnlinePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.isMainDbOnlinePicBox.TabIndex = 8
        Me.isMainDbOnlinePicBox.TabStop = False
        Me.isMainDbOnlinePicBox.Tag = ""
        '
        'MainTitle
        '
        Me.MainTitle.AutoSize = True
        Me.MainTitle.BackColor = System.Drawing.Color.Transparent
        Me.MainTitle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTitle.ForeColor = System.Drawing.Color.White
        Me.MainTitle.Location = New System.Drawing.Point(13, 8)
        Me.MainTitle.Name = "MainTitle"
        Me.MainTitle.Size = New System.Drawing.Size(54, 19)
        Me.MainTitle.TabIndex = 7
        Me.MainTitle.Text = "Ofisu"
        '
        'MatBtnMinMain
        '
        Me.MatBtnMinMain.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.MatBtnMinMain.FlatAppearance.BorderSize = 0
        Me.MatBtnMinMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MatBtnMinMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MatBtnMinMain.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatBtnMinMain.ForeColor = System.Drawing.Color.Transparent
        Me.MatBtnMinMain.Location = New System.Drawing.Point(1147, -16)
        Me.MatBtnMinMain.Name = "MatBtnMinMain"
        Me.MatBtnMinMain.Size = New System.Drawing.Size(33, 41)
        Me.MatBtnMinMain.TabIndex = 6
        Me.MatBtnMinMain.Text = "-"
        Me.MatBtnMinMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MatBtnMinMain.UseVisualStyleBackColor = True
        '
        'MatBtnCloseMain
        '
        Me.MatBtnCloseMain.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.MatBtnCloseMain.FlatAppearance.BorderSize = 0
        Me.MatBtnCloseMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MatBtnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MatBtnCloseMain.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MatBtnCloseMain.ForeColor = System.Drawing.Color.Transparent
        Me.MatBtnCloseMain.Location = New System.Drawing.Point(1185, -18)
        Me.MatBtnCloseMain.Name = "MatBtnCloseMain"
        Me.MatBtnCloseMain.Size = New System.Drawing.Size(33, 48)
        Me.MatBtnCloseMain.TabIndex = 6
        Me.MatBtnCloseMain.Text = "x"
        Me.MatBtnCloseMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MatBtnCloseMain.UseVisualStyleBackColor = True
        '
        'MainProBar
        '
        Me.MainProBar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MainProBar.Location = New System.Drawing.Point(0, 34)
        Me.MainProBar.MarqueeAnimationSpeed = 10
        Me.MainProBar.Name = "MainProBar"
        Me.MainProBar.Size = New System.Drawing.Size(1240, 1)
        Me.MainProBar.Step = 1
        Me.MainProBar.TabIndex = 4
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.Panel3)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.Panel5)
        Me.MainPanel.Location = New System.Drawing.Point(5, 36)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1230, 660)
        Me.MainPanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TaskCompleteDateLbl)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TaskCreatedDateLbl)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnDeleteTask)
        Me.Panel3.Controls.Add(Me.btnCompleteTask)
        Me.Panel3.Controls.Add(Me.TaskTxtBox)
        Me.Panel3.Controls.Add(Me.TaskListBox)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnAddTask)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(515, 298)
        Me.Panel3.TabIndex = 1
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDeleteTask.FlatAppearance.BorderSize = 3
        Me.btnDeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTask.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteTask.ForeColor = System.Drawing.Color.Transparent
        Me.btnDeleteTask.Location = New System.Drawing.Point(162, 264)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(153, 31)
        Me.btnDeleteTask.TabIndex = 17
        Me.btnDeleteTask.Text = "Delete Task"
        Me.btnDeleteTask.UseVisualStyleBackColor = True
        '
        'btnCompleteTask
        '
        Me.btnCompleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCompleteTask.FlatAppearance.BorderSize = 3
        Me.btnCompleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompleteTask.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCompleteTask.ForeColor = System.Drawing.Color.Transparent
        Me.btnCompleteTask.Location = New System.Drawing.Point(3, 264)
        Me.btnCompleteTask.Name = "btnCompleteTask"
        Me.btnCompleteTask.Size = New System.Drawing.Size(153, 31)
        Me.btnCompleteTask.TabIndex = 16
        Me.btnCompleteTask.Text = "Complete Task"
        Me.btnCompleteTask.UseVisualStyleBackColor = True
        '
        'TaskTxtBox
        '
        Me.TaskTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TaskTxtBox.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TaskTxtBox.ForeColor = System.Drawing.Color.White
        Me.TaskTxtBox.Location = New System.Drawing.Point(63, 5)
        Me.TaskTxtBox.MaxLength = 128
        Me.TaskTxtBox.Multiline = True
        Me.TaskTxtBox.Name = "TaskTxtBox"
        Me.TaskTxtBox.Size = New System.Drawing.Size(398, 31)
        Me.TaskTxtBox.TabIndex = 15
        Me.TaskTxtBox.Text = "...Add new task here..."
        Me.TaskTxtBox.WordWrap = False
        '
        'TaskListBox
        '
        Me.TaskListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TaskListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TaskListBox.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TaskListBox.ForeColor = System.Drawing.Color.White
        Me.TaskListBox.FormattingEnabled = True
        Me.TaskListBox.HorizontalScrollbar = True
        Me.TaskListBox.ItemHeight = 20
        Me.TaskListBox.Location = New System.Drawing.Point(3, 40)
        Me.TaskListBox.Name = "TaskListBox"
        Me.TaskListBox.Size = New System.Drawing.Size(312, 222)
        Me.TaskListBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ToDo:"
        '
        'btnAddTask
        '
        Me.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddTask.FlatAppearance.BorderSize = 3
        Me.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTask.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddTask.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddTask.Location = New System.Drawing.Point(467, 5)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(34, 31)
        Me.btnAddTask.TabIndex = 12
        Me.btnAddTask.Text = "+"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1058, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 38)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TimeDateLbl)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 31)
        Me.Panel2.TabIndex = 1
        '
        'TimeDateLbl
        '
        Me.TimeDateLbl.AutoSize = True
        Me.TimeDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeDateLbl.ForeColor = System.Drawing.Color.White
        Me.TimeDateLbl.Location = New System.Drawing.Point(-1, 8)
        Me.TimeDateLbl.Name = "TimeDateLbl"
        Me.TimeDateLbl.Size = New System.Drawing.Size(161, 17)
        Me.TimeDateLbl.TabIndex = 0
        Me.TimeDateLbl.Text = "00-00-0000 00:00:00"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Location = New System.Drawing.Point(1065, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(157, 59)
        Me.Panel5.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel4.Controls.Add(Me.RamUsageLbl)
        Me.Panel4.Controls.Add(Me.CpuUsageLbl)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(151, 52)
        Me.Panel4.TabIndex = 1
        '
        'RamUsageLbl
        '
        Me.RamUsageLbl.AutoSize = True
        Me.RamUsageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RamUsageLbl.ForeColor = System.Drawing.Color.White
        Me.RamUsageLbl.Location = New System.Drawing.Point(2, 29)
        Me.RamUsageLbl.Name = "RamUsageLbl"
        Me.RamUsageLbl.Size = New System.Drawing.Size(82, 17)
        Me.RamUsageLbl.TabIndex = 2
        Me.RamUsageLbl.Text = "Ram Usage"
        '
        'CpuUsageLbl
        '
        Me.CpuUsageLbl.AutoSize = True
        Me.CpuUsageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpuUsageLbl.ForeColor = System.Drawing.Color.White
        Me.CpuUsageLbl.Location = New System.Drawing.Point(2, 3)
        Me.CpuUsageLbl.Name = "CpuUsageLbl"
        Me.CpuUsageLbl.Size = New System.Drawing.Size(78, 17)
        Me.CpuUsageLbl.TabIndex = 1
        Me.CpuUsageLbl.Text = "Cpu Usage"
        '
        'MainBackgroundImg
        '
        Me.MainBackgroundImg.BackColor = System.Drawing.Color.Transparent
        Me.MainBackgroundImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainBackgroundImg.Image = CType(resources.GetObject("MainBackgroundImg.Image"), System.Drawing.Image)
        Me.MainBackgroundImg.InitialImage = Nothing
        Me.MainBackgroundImg.Location = New System.Drawing.Point(58, -53)
        Me.MainBackgroundImg.Name = "MainBackgroundImg"
        Me.MainBackgroundImg.Size = New System.Drawing.Size(1040, 937)
        Me.MainBackgroundImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainBackgroundImg.TabIndex = 0
        Me.MainBackgroundImg.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(321, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Created on:"
        '
        'TaskCreatedDateLbl
        '
        Me.TaskCreatedDateLbl.AutoSize = True
        Me.TaskCreatedDateLbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TaskCreatedDateLbl.ForeColor = System.Drawing.Color.White
        Me.TaskCreatedDateLbl.Location = New System.Drawing.Point(321, 69)
        Me.TaskCreatedDateLbl.Name = "TaskCreatedDateLbl"
        Me.TaskCreatedDateLbl.Size = New System.Drawing.Size(180, 19)
        Me.TaskCreatedDateLbl.TabIndex = 19
        Me.TaskCreatedDateLbl.Text = "00-00-0000 00:00:00"
        '
        'TaskCompleteDateLbl
        '
        Me.TaskCompleteDateLbl.AutoSize = True
        Me.TaskCompleteDateLbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TaskCompleteDateLbl.ForeColor = System.Drawing.Color.White
        Me.TaskCompleteDateLbl.Location = New System.Drawing.Point(321, 133)
        Me.TaskCompleteDateLbl.Name = "TaskCompleteDateLbl"
        Me.TaskCompleteDateLbl.Size = New System.Drawing.Size(180, 19)
        Me.TaskCompleteDateLbl.TabIndex = 21
        Me.TaskCompleteDateLbl.Text = "00-00-0000 00:00:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(321, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Completed on:"
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1240, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.DBnamelbl)
        Me.Controls.Add(Me.AboutBtn)
        Me.Controls.Add(Me.isMainDbOnlinePicBox)
        Me.Controls.Add(Me.MainTitle)
        Me.Controls.Add(Me.MatBtnMinMain)
        Me.Controls.Add(Me.MatBtnCloseMain)
        Me.Controls.Add(Me.MainProBar)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MainBackgroundImg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1240, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1240, 720)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ofisu"
        CType(Me.isMainDbOnlinePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.MainBackgroundImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MainProBar As ProgressBar
    Friend WithEvents MatBtnCloseMain As Button
    Friend WithEvents MatBtnMinMain As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MainTitle As Label
    Friend WithEvents MainBackgroundImg As PictureBox
    Friend WithEvents isMainDbOnlinePicBox As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents AboutBtn As Button
    Friend WithEvents DBnamelbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimeDateLbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddTask As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TaskListBox As ListBox
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents btnCompleteTask As Button
    Friend WithEvents TaskTxtBox As TextBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CpuUsageLbl As Label
    Friend WithEvents RamUsageLbl As Label
    Friend WithEvents TaskCompleteDateLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TaskCreatedDateLbl As Label
    Friend WithEvents Label2 As Label
End Class
