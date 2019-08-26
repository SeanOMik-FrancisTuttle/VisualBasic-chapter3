' Program Name: Virtual Reality Headset
' Developer:    Sean Ervin
' Date:         January 28, 2019
' Purpose:      This application displays two vr equipment selections (vr headset
'               and vr earbud). The user can select a equipment option and close the window.

Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub BtnCrown_Click(sender As Object, e As EventArgs) Handles btnCrown.Click
        ' This code is executed when the user clicks the "VR Crown" button. It displays the
        ' crown picture, hides the earbud picture, and enables the "Exit Window" Button.

        picCrown.Visible = True
        picEarbud.Visible = False
        btnExit.Enabled = True ' Enable button
    End Sub

    Private Sub BtnEarbud_Click(sender As Object, e As EventArgs) Handles btnEarbud.Click
        ' This code is executed when the user clicks the "VR Earbud" button. It displays the
        ' earbud picture, hides the crown picture, and enables the "Exit Window" Button.

        picCrown.Visible = False
        picEarbud.Visible = True
        btnExit.Enabled = True ' Enable button
    End Sub
End Class
