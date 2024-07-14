Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tsp
Imports System.Diagnostics
Imports System.Management

Public Class Main
    Inherits RoundedForm

    Private isDragging As Boolean
    Private clickOffset As Point
    Private configFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ofisu_Config.ini")
    Private isMainDbOnline As Boolean
    Private isMainDbOnlinePicBoxColor As Boolean
    Private isTasksFetched As Boolean

    ' MySQL connection parameters
    Private dbServer As String
    Private dbName As String
    Private dbUserId As String
    Private dbPassword As String

    Private connectionString As String

    'Performance Counters
    Private performanceCounterCPU As PerformanceCounter
    Private performanceCounterRAM As PerformanceCounter

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeRessourceCounters()

        isMainDbOnlinePicBoxColor = False
        isTasksFetched = False

        ' Check and create configuration file if necessary
        CheckAndCreateConfigFile()
        connectionString = $"Server={dbServer};Database={dbName};User Id={dbUserId};Password={dbPassword}"

        ' Attach event handlers for Main (form) movement
        AddHandler Me.MouseDown, AddressOf MainForm_MouseDown
        AddHandler Me.MouseMove, AddressOf MainForm_MouseMove
        AddHandler Me.MouseUp, AddressOf MainForm_MouseUp

        ' Attach event handlers for MainBackgroundImg movement
        AddHandler MainBackgroundImg.MouseDown, AddressOf MainBackgroundImg_MouseDown
        AddHandler MainBackgroundImg.MouseMove, AddressOf MainBackgroundImg_MouseMove
        AddHandler MainBackgroundImg.MouseUp, AddressOf MainBackgroundImg_MouseUp

        ' Start the MySQL connection check in the background
        'Task.Run(AddressOf CheckMySqlConnection)
        CheckMySqlConnection()



    End Sub

    Friend Sub InitializeRessourceCounters()

        ' Initialize PerformanceCounters
        performanceCounterCPU = New PerformanceCounter("Processor", "% Processor Time", "_Total")
        performanceCounterRAM = New PerformanceCounter("Memory", "% Committed Bytes In Use")

        ' Get disk volume information
        Dim drives As DriveInfo() = DriveInfo.GetDrives()
        For Each drive As DriveInfo In drives
            If drive.IsReady Then
                Dim volumeLabel As String = drive.VolumeLabel
                Dim totalSize As Long = drive.TotalSize
                Dim availableSpace As Long = drive.AvailableFreeSpace
                Dim usedSpacePercent As Double = (1.0 - (CDbl(availableSpace) / CDbl(totalSize))) * 100.0

                ' Example: Display information or store it as needed
                'Console.WriteLine($"Drive {drive.Name}: {volumeLabel}, Total Size: {totalSize} bytes, Available Space: {availableSpace} bytes, Used Space: {usedSpacePercent}%")
            End If
        Next
        Timer4.Start()
    End Sub

    Private Sub FetchTasks()
        TaskListBox.Items.Clear()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID, TaskName, isCompleted FROM Task"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim taskName As String = reader.GetString("TaskName")
                        Dim isCompleted As Boolean = reader.GetBoolean("isCompleted")
                        Dim taskText As String = If(isCompleted, "[Complete] ", "") & taskName
                        TaskListBox.Items.Add(taskText)
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub UpdateDateTimeLabel()
        ' Get the current date and time
        Dim currentDateTime As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")

        ' Set the label's text to the current date and time
        TimeDateLbl.Text = currentDateTime

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

        UpdateDateTimeLabel()

        If MainTitle.Text = "Ofisu" Then
            MainTitle.Text = "Ofisu_"
        Else
            MainTitle.Text = "Ofisu"
        End If

        If isMainDbOnline = True Then
            DBnamelbl.Text = dbName & " host " & dbServer

            If isTasksFetched = False Then
                FetchTasks()
                isTasksFetched = True
            Else

            End If

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

    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click

        If TaskTxtBox.Text <> "...Add new task here..." Then
            Dim task As String = TaskTxtBox.Text

            If Not String.IsNullOrWhiteSpace(task) Then
                TaskListBox.Items.Add(task)
                TaskTxtBox.Clear()
            End If

        Else

        End If

    End Sub

    Private Sub btnCompleteTask_Click(sender As Object, e As EventArgs) Handles btnCompleteTask.Click

        If TaskListBox.SelectedItem IsNot Nothing Then
            Dim taskText As String = TaskListBox.SelectedItem.ToString()
            Dim taskName As String = taskText.Replace("[Complete] ", "")
            MarkTaskAsCompleted(taskName)
            FetchTasks()
        End If

        'Dim item As String
        'item = TaskListBox.SelectedItem

        'TaskListBox.Items.Remove(item)
        'TaskListBox.Items.Add("[Complete] " & item)


    End Sub

    Private Sub MarkTaskAsCompleted(taskName As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Task SET isCompleted = TRUE, CompletedTime = @CompletedTime WHERE TaskName = @TaskName"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@TaskName", taskName)
                cmd.Parameters.AddWithValue("@CompletedTime", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnDeleteTask_Click(sender As Object, e As EventArgs) Handles btnDeleteTask.Click

        If TaskListBox.SelectedItem IsNot Nothing Then
            Dim taskText As String = TaskListBox.SelectedItem.ToString()
            Dim taskName As String = taskText.Replace("[Complete] ", "")
            DeleteTask(taskName)
            FetchTasks()
        End If

        'While TaskListBox.SelectedItems.Count > 0
        '    TaskListBox.Items.Remove(TaskListBox.SelectedItem)
        'End While

    End Sub

    Private Sub DeleteTask(taskName As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "DELETE FROM Task WHERE TaskName = @TaskName"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@TaskName", taskName)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub TaskTxtBox_Click(sender As Object, e As EventArgs) Handles TaskTxtBox.Click
        If TaskTxtBox.Text = "" Then

        ElseIf TaskTxtBox.Text = "...Add new task here..." Then

            TaskTxtBox.Clear()

        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        ' Update CPU and RAM usage
        Dim cpuUsage As Single = performanceCounterCPU.NextValue()
        Dim formattedCpuUsage As String = cpuUsage.ToString("00.00") & "%"
        Dim ramUsage As Single = performanceCounterRAM.NextValue()
        Dim formattedRamUsage As String = ramUsage.ToString("00.00") & "%"

        ' Example: Update UI elements or store the values as needed
        'Console.WriteLine($"CPU Usage: {cpuUsage}%")
        'Console.WriteLine($"RAM Usage: {ramUsage}%")

        CpuUsageLbl.Text = "CPU Usage: " & formattedCpuUsage
        RamUsageLbl.Text = "RAM Usage: " & formattedRamUsage

    End Sub
End Class
