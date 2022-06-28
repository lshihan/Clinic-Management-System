Imports System.Data.OleDb
Public Class Form5
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdUpdate As New OleDbCommand
    Dim cmdSearch As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=create profile.mdb"
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtICNO.Text <> "" Then
            cmdSearch.CommandText = "SELECT *from [Patient Profile] where [Identification ID] = '" + txtICNO.Text + "';"
            cmdSearch.Connection = cnnOLEDB


            Dim rd As OleDbDataReader = cmdSearch.ExecuteReader()

            If rd.Read = True Then
                txtPID.Text = rd(0).ToString
                txtFname.Text = rd(1).ToString
                txtHeight.Text = rd(7).ToString
                txtWeight.Text = rd(8).ToString
                txtBT.Text = rd(9).ToString
                rtxtAllergies.Text = rd(10).ToString
                rtxtPMTR.Text = rd(11).ToString
                rtxtMI.Text = rd(12).ToString

            Else
                MessageBox.Show("Information not found in Database")

            End If
            rd.Close()

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If rtxtCMTR.Text <> "" And rtxtMI.Text <> "" And txtPID.Text <> "" And txtFname.Text <> "" And txtHeight.Text <> "" And txtICNO.Text And rtxtAllergies.Text <> "" And txtWeight.Text <> "" Then
            cmdUpdate.CommandText = "UPDATE [Patient Profile] SET [Medical Treatment History] = '" + rtxtCMTR.Text + "',[Previous Medicine Given] = '" + rtxtMI.Text + "' ;"
            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = cnnOLEDB
            cmdUpdate.ExecuteNonQuery()
            MsgBox(txtICNO.Text & "" & "Record Updated.")

        End If

    End Sub

    Private Sub btnLO_Click(sender As Object, e As EventArgs) Handles btnLO.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPID.Clear()
        txtFname.Clear()
        txtHeight.Clear()
        txtWeight.Clear()
        txtBT.Clear()
        rtxtAllergies.Clear()
        rtxtPMTR.Clear()
        rtxtCMTR.Clear()
        rtxtMI.Clear()
    End Sub
End Class