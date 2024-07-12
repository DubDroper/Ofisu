Imports System.Runtime.InteropServices

Public Class RoundedForm
    Inherits Form

    ' Import the necessary API functions
    <DllImport("gdi32.dll", SetLastError:=True)>
    Private Shared Function CreateRoundRectRgn(
        nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer,
        nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
    End Function

    <DllImport("gdi32.dll", SetLastError:=True)>
    Private Shared Function DeleteObject(hObject As IntPtr) As Boolean
    End Function

    ' Override the OnPaint method
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Set the form region to a rounded rectangle
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, Width, Height, 15, 15)
        Me.Region = Region.FromHrgn(regionHandle)

        ' Clean up the region handle
        DeleteObject(regionHandle)
    End Sub
End Class
