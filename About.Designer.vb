<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainTitle = New System.Windows.Forms.Label()
        Me.Slogan = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GitLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.GitLogoPicBox = New System.Windows.Forms.PictureBox()
        Me.MailLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContactLbl = New System.Windows.Forms.Label()
        Me.CopyNotifLbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.VersionLbl = New System.Windows.Forms.Label()
        Me.CheckUpdateBtn = New System.Windows.Forms.Button()
        CType(Me.GitLogoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 800
        '
        'MainTitle
        '
        Me.MainTitle.AutoSize = True
        Me.MainTitle.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.MainTitle.ForeColor = System.Drawing.Color.White
        Me.MainTitle.Location = New System.Drawing.Point(53, 9)
        Me.MainTitle.Name = "MainTitle"
        Me.MainTitle.Size = New System.Drawing.Size(89, 32)
        Me.MainTitle.TabIndex = 0
        Me.MainTitle.Text = "Ofisu"
        '
        'Slogan
        '
        Me.Slogan.AutoSize = True
        Me.Slogan.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Slogan.ForeColor = System.Drawing.Color.White
        Me.Slogan.Location = New System.Drawing.Point(54, 41)
        Me.Slogan.Name = "Slogan"
        Me.Slogan.Size = New System.Drawing.Size(276, 26)
        Me.Slogan.TabIndex = 1
        Me.Slogan.Text = "Your humble companion."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(10, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 5)
        Me.Panel1.TabIndex = 2
        '
        'Timer2
        '
        '
        'GitLinkLbl
        '
        Me.GitLinkLbl.AutoSize = True
        Me.GitLinkLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GitLinkLbl.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GitLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GitLinkLbl.Location = New System.Drawing.Point(17, 166)
        Me.GitLinkLbl.Name = "GitLinkLbl"
        Me.GitLinkLbl.Size = New System.Drawing.Size(350, 22)
        Me.GitLinkLbl.TabIndex = 3
        Me.GitLinkLbl.TabStop = True
        Me.GitLinkLbl.Text = "https://github.com/DubDroper/Ofisu"
        '
        'GitLogoPicBox
        '
        Me.GitLogoPicBox.Image = Global.Ofisu.My.Resources.Resources.git_logo
        Me.GitLogoPicBox.Location = New System.Drawing.Point(132, 97)
        Me.GitLogoPicBox.Name = "GitLogoPicBox"
        Me.GitLogoPicBox.Size = New System.Drawing.Size(120, 66)
        Me.GitLogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GitLogoPicBox.TabIndex = 4
        Me.GitLogoPicBox.TabStop = False
        '
        'MailLinkLbl
        '
        Me.MailLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.MailLinkLbl.AutoSize = True
        Me.MailLinkLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MailLinkLbl.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.MailLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.MailLinkLbl.LinkColor = System.Drawing.Color.White
        Me.MailLinkLbl.Location = New System.Drawing.Point(149, 228)
        Me.MailLinkLbl.Name = "MailLinkLbl"
        Me.MailLinkLbl.Size = New System.Drawing.Size(200, 22)
        Me.MailLinkLbl.TabIndex = 5
        Me.MailLinkLbl.TabStop = True
        Me.MailLinkLbl.Text = "idroperex@gmail.com"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(10, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 5)
        Me.Panel2.TabIndex = 6
        '
        'ContactLbl
        '
        Me.ContactLbl.AutoSize = True
        Me.ContactLbl.Font = New System.Drawing.Font("Consolas", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ContactLbl.ForeColor = System.Drawing.Color.White
        Me.ContactLbl.Location = New System.Drawing.Point(35, 226)
        Me.ContactLbl.Name = "ContactLbl"
        Me.ContactLbl.Size = New System.Drawing.Size(108, 26)
        Me.ContactLbl.TabIndex = 7
        Me.ContactLbl.Text = "Contact:"
        '
        'CopyNotifLbl
        '
        Me.CopyNotifLbl.AutoSize = True
        Me.CopyNotifLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyNotifLbl.ForeColor = System.Drawing.Color.Lime
        Me.CopyNotifLbl.Location = New System.Drawing.Point(144, 252)
        Me.CopyNotifLbl.Name = "CopyNotifLbl"
        Me.CopyNotifLbl.Size = New System.Drawing.Size(213, 17)
        Me.CopyNotifLbl.TabIndex = 8
        Me.CopyNotifLbl.Text = "Copied to clipboard successfully!"
        Me.CopyNotifLbl.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(10, 274)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(364, 5)
        Me.Panel3.TabIndex = 9
        '
        'VersionLbl
        '
        Me.VersionLbl.AutoSize = True
        Me.VersionLbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VersionLbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.VersionLbl.ForeColor = System.Drawing.Color.White
        Me.VersionLbl.Location = New System.Drawing.Point(0, 324)
        Me.VersionLbl.Name = "VersionLbl"
        Me.VersionLbl.Padding = New System.Windows.Forms.Padding(8, 0, 0, 8)
        Me.VersionLbl.Size = New System.Drawing.Size(80, 27)
        Me.VersionLbl.TabIndex = 10
        Me.VersionLbl.Text = "Version"
        '
        'CheckUpdateBtn
        '
        Me.CheckUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CheckUpdateBtn.FlatAppearance.BorderSize = 3
        Me.CheckUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CheckUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckUpdateBtn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckUpdateBtn.ForeColor = System.Drawing.Color.Transparent
        Me.CheckUpdateBtn.Location = New System.Drawing.Point(107, 285)
        Me.CheckUpdateBtn.Name = "CheckUpdateBtn"
        Me.CheckUpdateBtn.Size = New System.Drawing.Size(171, 36)
        Me.CheckUpdateBtn.TabIndex = 11
        Me.CheckUpdateBtn.Text = "Check for Update"
        Me.CheckUpdateBtn.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 351)
        Me.Controls.Add(Me.CheckUpdateBtn)
        Me.Controls.Add(Me.VersionLbl)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CopyNotifLbl)
        Me.Controls.Add(Me.ContactLbl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MailLinkLbl)
        Me.Controls.Add(Me.GitLogoPicBox)
        Me.Controls.Add(Me.GitLinkLbl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Slogan)
        Me.Controls.Add(Me.MainTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Ofisu"
        Me.TopMost = True
        CType(Me.GitLogoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents MainTitle As Label
    Friend WithEvents Slogan As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GitLinkLbl As LinkLabel
    Friend WithEvents GitLogoPicBox As PictureBox
    Friend WithEvents MailLinkLbl As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContactLbl As Label
    Friend WithEvents CopyNotifLbl As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents VersionLbl As Label
    Friend WithEvents CheckUpdateBtn As Button
End Class
