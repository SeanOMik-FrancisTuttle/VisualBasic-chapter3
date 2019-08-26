Public Class Form1
    ' USE CASE DEFINITION
    ' 
    ' 1. User clicks "View date, start location, and details" button
    ' 2. Text is displayed showing the view date, start location, and 
    '      details.
    ' 3. The user can then press the exit button.

    ' When the user clicks the "View date, start location, and details" button,
    '    it displays text about the event by changing a labels text.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblInfo.Text = "October 30, 2018" + Environment.NewLine + "Open ""Mic""" + Environment.NewLine + "Start Time: 9:00PM"
    End Sub

    ' When the user clicks the "Exit Window" button, it checks if
    '    the info has been viewed, and if it has then it exits the window.
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If (lblInfo.Text IsNot "") Then
            End
        End If
    End Sub
End Class
