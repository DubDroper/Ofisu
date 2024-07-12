Public Class Main
    Inherits RoundedForm

    Private WithEvents MainPanel As RoundedPanel

    Public Sub New()
        InitializeComponent()

        ' Initialize the custom rounded panel
        MainPanel = New RoundedPanel()
        MainPanel.Size = New Size(1220, 700)
        MainPanel.BackColor = Color.LightBlue

        ' Center the panel within the form
        MainPanel.Location = New Point((Me.ClientSize.Width - MainPanel.Width) / 2, (Me.ClientSize.Height - MainPanel.Height) / 2)

        ' Add the rounded panel to the form
        Me.Controls.Add(MainPanel)

        ' Add an event handler to resize and recenter the panel when the form is resized
        AddHandler Me.Resize, AddressOf MainForm_Resize
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs)
        ' Center the panel within the form when the form is resized
        MainPanel.Location = New Point((Me.ClientSize.Width - MainPanel.Width) / 2, (Me.ClientSize.Height - MainPanel.Height) / 2)
    End Sub


    ' Your existing code for Main form
End Class
