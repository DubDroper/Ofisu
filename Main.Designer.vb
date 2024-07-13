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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MatBtnCloseMain = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainProBar = New System.Windows.Forms.ProgressBar()
        Me.MatBtnMinMain = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MainTitle = New System.Windows.Forms.Label()
        Me.isMainDbOnlinePicBox = New System.Windows.Forms.PictureBox()
        Me.MainBackgroundImg = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.AboutBtn = New System.Windows.Forms.Button()
        Me.DBnamelbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TimeDateLbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TaskListBox = New System.Windows.Forms.ListBox()
        Me.TaskTxtBox = New System.Windows.Forms.TextBox()
        Me.btnCompleteTask = New System.Windows.Forms.Button()
        Me.btnDeleteTask = New System.Windows.Forms.Button()
        Me.MainPanel.SuspendLayout()
        CType(Me.isMainDbOnlinePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainBackgroundImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.Panel3)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Location = New System.Drawing.Point(5, 35)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1230, 660)
        Me.MainPanel.TabIndex = 0
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
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 600
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
        'Timer3
        '
        Me.Timer3.Enabled = True
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1054, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 49)
        Me.Panel1.TabIndex = 0
        '
        'TimeDateLbl
        '
        Me.TimeDateLbl.AutoSize = True
        Me.TimeDateLbl.Font = New System.Drawing.Font("Roboto Lt", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeDateLbl.ForeColor = System.Drawing.Color.White
        Me.TimeDateLbl.Location = New System.Drawing.Point(-1, 26)
        Me.TimeDateLbl.Name = "TimeDateLbl"
        Me.TimeDateLbl.Size = New System.Drawing.Size(162, 17)
        Me.TimeDateLbl.TabIndex = 0
        Me.TimeDateLbl.Text = "00-00-0000 00:00:00"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TimeDateLbl)
        Me.Panel2.Location = New System.Drawing.Point(3, -8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 54)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnDeleteTask)
        Me.Panel3.Controls.Add(Me.btnCompleteTask)
        Me.Panel3.Controls.Add(Me.TaskTxtBox)
        Me.Panel3.Controls.Add(Me.TaskListBox)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnAddTask)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(531, 300)
        Me.Panel3.TabIndex = 1
        '
        'btnAddTask
        '
        Me.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddTask.FlatAppearance.BorderSize = 3
        Me.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTask.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddTask.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddTask.Location = New System.Drawing.Point(415, 5)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(113, 31)
        Me.btnAddTask.TabIndex = 12
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = True
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
        'TaskListBox
        '
        Me.TaskListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TaskListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskListBox.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TaskListBox.ForeColor = System.Drawing.Color.White
        Me.TaskListBox.FormattingEnabled = True
        Me.TaskListBox.ItemHeight = 15
        Me.TaskListBox.Items.AddRange(New Object() {"TASK 1", "TASK 10", "TASK 11", "TASK 2", "TASK 3", "TASK 4", "TASK 5", "TASK 6", "TASK 7", "TASK 8", "TASK 9"})
        Me.TaskListBox.Location = New System.Drawing.Point(3, 42)
        Me.TaskListBox.Name = "TaskListBox"
        Me.TaskListBox.Size = New System.Drawing.Size(525, 212)
        Me.TaskListBox.TabIndex = 14
        '
        'TaskTxtBox
        '
        Me.TaskTxtBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TaskTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TaskTxtBox.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TaskTxtBox.ForeColor = System.Drawing.Color.White
        Me.TaskTxtBox.Location = New System.Drawing.Point(63, 5)
        Me.TaskTxtBox.MaxLength = 128
        Me.TaskTxtBox.Multiline = True
        Me.TaskTxtBox.Name = "TaskTxtBox"
        Me.TaskTxtBox.Size = New System.Drawing.Size(346, 31)
        Me.TaskTxtBox.TabIndex = 15
        Me.TaskTxtBox.WordWrap = False
        '
        'btnCompleteTask
        '
        Me.btnCompleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCompleteTask.FlatAppearance.BorderSize = 3
        Me.btnCompleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompleteTask.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCompleteTask.ForeColor = System.Drawing.Color.Transparent
        Me.btnCompleteTask.Location = New System.Drawing.Point(8, 260)
        Me.btnCompleteTask.Name = "btnCompleteTask"
        Me.btnCompleteTask.Size = New System.Drawing.Size(253, 31)
        Me.btnCompleteTask.TabIndex = 16
        Me.btnCompleteTask.Text = "Complete Task"
        Me.btnCompleteTask.UseVisualStyleBackColor = True
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDeleteTask.FlatAppearance.BorderSize = 3
        Me.btnDeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTask.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteTask.ForeColor = System.Drawing.Color.Transparent
        Me.btnDeleteTask.Location = New System.Drawing.Point(270, 260)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(253, 31)
        Me.btnDeleteTask.TabIndex = 17
        Me.btnDeleteTask.Text = "Delete Task"
        Me.btnDeleteTask.UseVisualStyleBackColor = True
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
        Me.MainPanel.ResumeLayout(False)
        CType(Me.isMainDbOnlinePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainBackgroundImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
End Class
