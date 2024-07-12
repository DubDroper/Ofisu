Imports MaterialSkin
Public Class Main
    Inherits RoundedForm

    Private materialSkinManager As MaterialSkinManager

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MaterialLabel2.Text = "Progress Bar2 Value: " & ProgressBar1.Value.ToString

        If ProgressBar1.Value < 100 Then

            'MaterialProgressBar1.Value = MaterialProgressBar1.Value + 10
            ProgressBar1.Value = ProgressBar1.Value + 1

        ElseIf ProgressBar1.Value = 100 Then

            Timer1.Stop()

        End If

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click

        Timer1.Start()

    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click

        Timer1.Stop()

    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click

        ProgressBar1.Value = 0
        MaterialLabel2.Text = "Progress Bar2 Value: " & ProgressBar1.Value.ToString

    End Sub

    Private Sub MatBtnCloseMain_Click(sender As Object, e As EventArgs) Handles MatBtnCloseMain.Click

        Me.Close()

    End Sub

    Private Sub MatBtnMinMain_Click(sender As Object, e As EventArgs) Handles MatBtnMinMain.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class
