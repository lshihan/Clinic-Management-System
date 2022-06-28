Imports System.Data.OleDb
Public Class Form4
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdSearch As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=create profile.mdb"
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtICNO.Text <> "" Then
            cmdSearch.CommandText = "SELECT *from [Patient Profile] where [Identification ID] = '" + txtICNO.Text + "';"
            cmdSearch.Connection = cnnOLEDB

            Dim rd As OleDbDataReader = cmdSearch.ExecuteReader()

            If rd.Read = True Then
                lblPID.Text = rd(0).ToString
                lblFname.Text = rd(1).ToString
                rtxtMed.Text = rd(12).ToString
            Else
                MessageBox.Show("Information not found in Database")

            End If
            rd.Close()

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        Dim price As Integer
        If chk1.Checked = True Then
            price += 100
        End If

        If chk2.Checked = True Then
            price += 50
        End If

        If chk3.Checked = True Then
            price += 120
        End If

        If chk4.Checked = True Then
            price += 75
        End If

        If txtAmount.Text <> "" Then
            price += 10 * (txtAmount.Text)
        End If
        lblTotal.Text = (price + 30)
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        If txtPaid.Text <> "" Then
            lblChange.Text = (txtPaid.Text - lblTotal.Text)
        End If
    End Sub
End Class
