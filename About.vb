Public Class About
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MainTitle.Text = "Ofisu" Then
            MainTitle.Text = "Ofisu_"
        Else
            MainTitle.Text = "Ofisu"
        End If


        If CopyNotifLbl.Visible = True Then
            CopyNotifLbl.Visible = False
        Else

        End If

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slogan.Text = "Your humble companion."
        CopyNotifLbl.Visible = False
        Timer1.Start()
        Timer2.Start()

        Dim version As Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version
        VersionLbl.Text = $"Version {version.ToString()}"

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Slogan.Text = "Your humble companion." Then

            Slogan.Text = "Your _ companion."

        ElseIf Slogan.Text = "Your _ companion." Then

            Slogan.Text = "Your h companion."

        ElseIf Slogan.Text = "Your h companion." Then

            Slogan.Text = "Your h_ companion."

        ElseIf Slogan.Text = "Your h_ companion." Then

            Slogan.Text = "Your hu companion."

        ElseIf Slogan.Text = "Your hu companion." Then

            Slogan.Text = "Your hu_ companion."

        ElseIf Slogan.Text = "Your hu_ companion." Then

            Slogan.Text = "Your hum companion."

        ElseIf Slogan.Text = "Your hum companion." Then

            Slogan.Text = "Your hum_ companion."

        ElseIf Slogan.Text = "Your hum_ companion." Then

            Slogan.Text = "Your humb companion."

        ElseIf Slogan.Text = "Your humb companion." Then

            Slogan.Text = "Your humb_ companion."

        ElseIf Slogan.Text = "Your humb_ companion." Then

            Slogan.Text = "Your humbl companion."

        ElseIf Slogan.Text = "Your humbl companion." Then

            Slogan.Text = "Your humbl_ companion."

        ElseIf Slogan.Text = "Your humbl_ companion." Then

            Slogan.Text = "Your humble companion."
            Timer2.Stop()

        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitLinkLbl.LinkClicked
        Process.Start(New ProcessStartInfo With {
            .FileName = "https://github.com/DubDroper/Ofisu",
            .UseShellExecute = True
        })
    End Sub

    Private Sub MailLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MailLinkLbl.LinkClicked
        Clipboard.SetText("idroperex@gmail.com")
        CopyNotifLbl.Visible = True
    End Sub

    Private Sub CheckUpdateBtn_Click(sender As Object, e As EventArgs) Handles CheckUpdateBtn.Click

    End Sub
End Class