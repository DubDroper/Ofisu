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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MatBtnCloseMain = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MatBtnMinMain = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.MaterialLabel2)
        Me.MainPanel.Controls.Add(Me.MaterialFlatButton3)
        Me.MainPanel.Controls.Add(Me.MaterialFlatButton2)
        Me.MainPanel.Controls.Add(Me.MaterialFlatButton1)
        Me.MainPanel.Location = New System.Drawing.Point(5, 35)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1230, 679)
        Me.MainPanel.TabIndex = 0
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(27, 24)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(166, 36)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "Start Progress Bar"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Icon = Nothing
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(27, 72)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(158, 36)
        Me.MaterialFlatButton2.TabIndex = 1
        Me.MaterialFlatButton2.Text = "Stop Progress Bar"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.AutoSize = True
        Me.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton3.Depth = 0
        Me.MaterialFlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton3.Icon = Nothing
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(27, 120)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Primary = False
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(164, 36)
        Me.MaterialFlatButton3.TabIndex = 2
        Me.MaterialFlatButton3.Text = "RESET Progress Bar"
        Me.MaterialFlatButton3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 34)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1240, 1)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 4
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(309, 51)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(137, 19)
        Me.MaterialLabel2.TabIndex = 5
        Me.MaterialLabel2.Text = "Progress Bar Value"
        '
        'MatBtnCloseMain
        '
        Me.MatBtnCloseMain.AutoSize = True
        Me.MatBtnCloseMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MatBtnCloseMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MatBtnCloseMain.Depth = 0
        Me.MatBtnCloseMain.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MatBtnCloseMain.FlatAppearance.BorderSize = 2
        Me.MatBtnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MatBtnCloseMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatBtnCloseMain.Icon = Nothing
        Me.MatBtnCloseMain.Location = New System.Drawing.Point(1198, -14)
        Me.MatBtnCloseMain.MouseState = MaterialSkin.MouseState.HOVER
        Me.MatBtnCloseMain.Name = "MatBtnCloseMain"
        Me.MatBtnCloseMain.Primary = True
        Me.MatBtnCloseMain.Size = New System.Drawing.Size(30, 36)
        Me.MatBtnCloseMain.TabIndex = 5
        Me.MatBtnCloseMain.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "x"
        Me.MatBtnCloseMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MatBtnCloseMain.UseVisualStyleBackColor = True
        '
        'MatBtnMinMain
        '
        Me.MatBtnMinMain.AutoSize = True
        Me.MatBtnMinMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MatBtnMinMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MatBtnMinMain.Depth = 0
        Me.MatBtnMinMain.FlatAppearance.BorderSize = 0
        Me.MatBtnMinMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MatBtnMinMain.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatBtnMinMain.Icon = Nothing
        Me.MatBtnMinMain.Location = New System.Drawing.Point(1167, -22)
        Me.MatBtnMinMain.MouseState = MaterialSkin.MouseState.HOVER
        Me.MatBtnMinMain.Name = "MatBtnMinMain"
        Me.MatBtnMinMain.Primary = True
        Me.MatBtnMinMain.Size = New System.Drawing.Size(27, 36)
        Me.MatBtnMinMain.TabIndex = 6
        Me.MatBtnMinMain.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "_"
        Me.MatBtnMinMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MatBtnMinMain.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1240, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.MatBtnMinMain)
        Me.Controls.Add(Me.MatBtnCloseMain)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1240, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1240, 720)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ofisu"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MatBtnCloseMain As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MatBtnMinMain As MaterialSkin.Controls.MaterialRaisedButton
End Class
