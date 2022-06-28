Public Class Form7
    Private Sub btnNurse_Click(sender As Object, e As EventArgs) Handles btnNurse.Click
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLO_Click(sender As Object, e As EventArgs) Handles btnLO.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class