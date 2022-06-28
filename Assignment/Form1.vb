Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLO_Click(sender As Object, e As EventArgs) Handles btnLO.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class
