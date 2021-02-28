Public Class frmSpringBreak
    Private Sub btnMyrtleBeach_Click(sender As Object, e As EventArgs) Handles btnMyrtleBeach.Click
        picMyrtle.Visible = True
        picKeyWest.Visible = False
        picVenice.Visible = False
    End Sub

    Private Sub btnKeyWest_Click(sender As Object, e As EventArgs) Handles btnKeyWest.Click
        picMyrtle.Visible = False
        picKeyWest.Visible = True
        picVenice.Visible = False
    End Sub

    Private Sub btnVeniceBeach_Click(sender As Object, e As EventArgs) Handles btnVeniceBeach.Click
        picMyrtle.Visible = False
        picKeyWest.Visible = False
        picVenice.Visible = True
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        btnMyrtleBeach.Enabled = False
        btnKeyWest.Enabled = False
        btnVeniceBeach.Enabled = False
        btnPurchase.Enabled = False
        btnPurchase.Visible = False
        lblEnjoy.Visible = True
    End Sub
End Class
