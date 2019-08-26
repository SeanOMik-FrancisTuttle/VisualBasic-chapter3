' Program Name: International Snacks
' Developer:    Sean Ervin
' Date:         January 28, 2019
' Purpose:      This application displays four food options (bean burrito, falafel,
'               greek yogurt, and spring rolls). The user can select a food option and close the window.

Public Class Form1
    Private Sub BtnBurrito_Click(sender As Object, e As EventArgs) Handles btnBurrito.Click
        ' When the Bean Burrito button is clicked, it hides all images, shows the Bean Burrito image
        ' and enables the select button.
        hideEverything()

        picBurrito.Visible = True
        btnSelect.Enabled = True
    End Sub

    Private Sub BtnFalafel_Click(sender As Object, e As EventArgs) Handles btnFalafel.Click
        ' When the Falafel button is clicked, it hides all images, shows the Falafel image
        ' and enables the select button.
        hideEverything()

        picFalafel.Visible = True
        btnSelect.Enabled = True
    End Sub

    Private Sub BtnGreekYogurt_Click(sender As Object, e As EventArgs) Handles btnGreekYogurt.Click
        ' When the Greek Yogurt button is clicked, it hides all images, shows the greek yogurt image
        ' and enables the select button.
        hideEverything()

        picGreekYogurt.Visible = True
        btnSelect.Enabled = True
    End Sub

    Private Sub BtnSpringRolls_Click(sender As Object, e As EventArgs) Handles btnSpringRolls.Click
        ' When the Spring Rolls button is clicked, it hides all images, shows the Spring Rolls image
        ' and enables the select button.
        hideEverything()

        picSpringRolls.Visible = True
        btnSelect.Enabled = True
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Shows the confirm label, disables all buttons (burrito, falafel, greek yogurt, and spring rolls).
        lblConfirm.Visible = True
        btnBurrito.Enabled = False
        btnFalafel.Enabled = False
        btnGreekYogurt.Enabled = False
        btnSpringRolls.Enabled = False
    End Sub

    Private Sub hideEverything()
        ' This hides all the images (greek yogurt, falafel, burrito, spring rolls).
        picGreekYogurt.Visible = False
        picFalafel.Visible = False
        picBurrito.Visible = False
        picSpringRolls.Visible = False
    End Sub
End Class
