Imports System.ComponentModel
Imports System.IO
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient

Public Class Main
    Inherits RoundedForm

    Private isDragging As Boolean
    Private clickOffset As Point
    Private configFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ofisu_Config.ini")
    Private isMainDbOnline As Boolean
    Private isMainDbOnlinePicBoxColor As Boolean

    ' MySQL connection parameters
    Private dbServer As String
    Private dbName As String
    Private dbUserId As String
    Private dbPassword As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        isMainDbOnlinePicBoxColor = False

        ' Check and create configuration file if necessary
        CheckAndCreateConfigFile()

        ' Attach event handlers for Main (form) movement
        AddHandler Me.MouseDown, AddressOf MainForm_MouseDown
        AddHandler Me.MouseMove, AddressOf MainForm_MouseMove
        AddHandler Me.MouseUp, AddressOf MainForm_MouseUp

        ' Attach event handlers for MainBackgroundImg movement
        AddHandler MainBackgroundImg.MouseDown, AddressOf MainBackgroundImg_MouseDown
        AddHandler MainBackgroundImg.MouseMove, AddressOf MainBackgroundImg_MouseMove
        AddHandler MainBackgroundImg.MouseUp, AddressOf MainBackgroundImg_MouseUp

        ' Start the MySQL connection check in the background
        Task.Run(AddressOf CheckMySqlConnection)

    End Sub

    Private Sub CheckAndCreateConfigFile()
        If Not File.Exists(configFilePath) Then
            ' Create the configuration file with default parameters
            Using writer As New StreamWriter(configFilePath)
                writer.WriteLine("[MySqlDB]")
                writer.WriteLine("Server=your_server")
                writer.WriteLine("Database=your_database")
                writer.WriteLine("User Id=your_user_id")
                writer.WriteLine("Password=your_password")
                ' Add other default parameters here
                writer.WriteLine()
                writer.WriteLine("[OtherParameters]")
                writer.WriteLine("Parameter1=value1")
                writer.WriteLine("Parameter2=value2")
                ' Add more parameters as needed
            End Using
        Else
            ' Load the parameters from the configuration file
            LoadConfigParameters()
        End If
    End Sub

    Private Sub LoadConfigParameters()
        ' Read and load parameters from the configuration file
        Dim lines As String() = File.ReadAllLines(configFilePath)
        For Each line As String In lines
            ' Parse each line and load parameters
            If line.StartsWith("Server=") Then
                dbServer = line.Substring("Server=".Length)
            ElseIf line.StartsWith("Database=") Then
                dbName = line.Substring("Database=".Length)
            ElseIf line.StartsWith("User Id=") Then
                dbUserId = line.Substring("User Id=".Length)
            ElseIf line.StartsWith("Password=") Then
                dbPassword = line.Substring("Password=".Length)
            End If
        Next
    End Sub

    Private Async Sub CheckMySqlConnection()
        ' Construct connection string using the loaded parameters
        Dim connectionString As String = $"Server={dbServer};Database={dbName};User Id={dbUserId};Password={dbPassword}"

        ' Attempt to connect to the MySQL database
        Using connection As New MySqlConnection(connectionString)
            Try
                Await connection.OpenAsync()
                DbIsOnline()
            Catch ex As Exception
                DbIsOffline()

            End Try
        End Using
    End Sub

    Private Sub DbIsOnline()
        isMainDbOnline = True
        isMainDbOnlinePicBoxColor = True
        Timer3.Stop()
        isMainDbOnlinePicBox.Image = My.Resources.GreenCircle1

    End Sub

    Private Sub DbIsOffline()
        isMainDbOnline = False
        isMainDbOnlinePicBoxColor = False
        Timer3.Stop()
        isMainDbOnlinePicBox.Image = My.Resources.RedCircle1
    End Sub

    ' Event handler for MouseDown
    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = True
            clickOffset = New Point(e.X, e.Y)
        End If
    End Sub

    ' Event handler for MouseMove
    Private Sub MainForm_MouseMove(sender As Object, e As MouseEventArgs)
        If isDragging Then
            Dim newLocation As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newLocation.Offset(-clickOffset.X, -clickOffset.Y)
            Me.Location = newLocation
        End If
    End Sub

    ' Event handler for MouseUp
    Private Sub MainForm_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    ' Event handler for MouseDown for MainBackgroundImg
    Private Sub MainBackgroundImg_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = True
            clickOffset = New Point(e.X, e.Y)
        End If
    End Sub

    ' Event handler for MouseMove for MainBackgroundImg
    Private Sub MainBackgroundImg_MouseMove(sender As Object, e As MouseEventArgs)
        If isDragging Then
            Dim newLocation As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newLocation.Offset(-clickOffset.X, -clickOffset.Y)
            Me.Location = newLocation
        End If
    End Sub

    ' Event handler for MouseUp for MainBackgroundImg
    Private Sub MainBackgroundImg_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If MainTitle.Text = "Ofisu" Then
            MainTitle.Text = "Ofisu_"
        Else
            MainTitle.Text = "Ofisu"
        End If

        If isMainDbOnline = True Then
            DBnamelbl.Text = dbName & " host " & dbServer
        Else
        End If
    End Sub

    Private Sub MatBtnCloseMain_Click(sender As Object, e As EventArgs) Handles MatBtnCloseMain.Click
        Me.Close()
    End Sub

    Private Sub MatBtnMinMain_Click(sender As Object, e As EventArgs) Handles MatBtnMinMain.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If isMainDbOnlinePicBoxColor = True Then

            isMainDbOnlinePicBox.Image = My.Resources.RedCircle1
            isMainDbOnlinePicBoxColor = False
        Else

            isMainDbOnlinePicBox.Image = My.Resources.GreenCircle1
            isMainDbOnlinePicBoxColor = True
        End If

    End Sub

    Private Sub AboutBtn_Click(sender As Object, e As EventArgs) Handles AboutBtn.Click
        About.Show()
    End Sub

End Class
