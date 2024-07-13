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
        CType(Me.isMainDbOnlinePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainBackgroundImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.AboutBtn.Location = New System.Drawing.Point(1108, 5)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(33, 24)
        Me.AboutBtn.TabIndex = 9
        Me.AboutBtn.Text = "?"
        Me.AboutBtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1240, 720)
        Me.ControlBox = False
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
End Class
