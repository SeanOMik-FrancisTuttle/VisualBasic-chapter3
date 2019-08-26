' Program Name: Latte Selection
' Developer:    Sean Ervin
' Date:         January 28, 2019
' Purpose:      This application displays two latte flavors (pumpkin spice
'               and mocha). The user can select a latte flavor.

Public Class Form1
    Private Sub BtnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        ' This code is executed when the user clicks the "Pumpkin Spice" button. It displays the
        ' pumpkin picture, hides the mocha picture, and enables the "Selected Latte" Button.

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True ' Enable button
    End Sub

    Private Sub BtnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This code is executed when the user clicks the "Mocha" button. It displays the
        ' mocha picture, hides the pumpkin picture, and enables the "Selected Latte" Button.

        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True ' Enable button
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' This code is executed when the user clicks the "Select Latte" button. it disables the
        ' "Pumpkin Spice" button, the "Select Latte" button, and the "Mocha" button. It hides the
        ' Instructions label, displays the Confrimation label, and enables the Exit Window button.

        btnMocha.Enabled = False
        btnPumpkin.Enabled = False
        btnSelect.Enabled = False
        lblChoose.Visible = False
        lblEnjoy.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user clicks the "Exit Window" button. It closes
        ' the window and terminated the program.

        Close()
    End Sub
End Class
