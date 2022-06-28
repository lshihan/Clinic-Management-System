Imports System.Data.OleDb
Public Class Form3
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdUpdate As New OleDbCommand
    Dim cmdSearch As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=create profile.mdb"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtICNO.Text <> "" Then
            cmdSearch.CommandText = "SELECT *from [Patient Profile] where [Identification ID] = '" + txtICNO.Text + "';"
            cmdSearch.Connection = cnnOLEDB

            Dim rd As OleDbDataReader = cmdSearch.ExecuteReader()

            If rd.Read = True Then
                txtPID.Text = rd(0).ToString
                txtFname.Text = rd(1).ToString
                txtIID.Text = rd(2).ToString
                txtGender.Text = rd(3).ToString
                rtxtAddress.Text = rd(4).ToString
                txtCnum.Text = rd(5).ToString
                txtEmail.Text = rd(6).ToString
                txtHeight.Text = rd(7).ToString
                txtWeight.Text = rd(8).ToString
                txtBT.Text = rd(9).ToString
                rtxtAllergies.Text = rd(10).ToString
                rtxtMTH.Text = rd(11).ToString
                rtxtPMG.Text = rd(12).ToString
            Else
                MessageBox.Show("Information not found in Database")

            End If
            rd.Close()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPID.Text <> "" And txtFname.Text <> "" And txtIID.Text <> "" And txtGender.Text <> "" And rtxtAddress.Text <> "" And txtCnum.Text <> "" And txtEmail.Text <> "" And txtHeight.Text <> "" And txtWeight.Text <> "" And txtBT.Text <> "" And rtxtAllergies.Text <> "" And rtxtMTH.Text <> "" And rtxtPMG.Text <> "" Then
            cmdUpdate.CommandText = "UPDATE [Patient Profile] SET [Medical Treatment History] = '" + rtxtMTH.Text + "' ,[Previous Medicine Given] = '" + rtxtPMG.Text + "' ;"
            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = cnnOLEDB
            cmdUpdate.ExecuteNonQuery()
            MsgBox(txtPID.Text & "" & "Record Updated.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCnum.Clear()
        txtEmail.Clear()
        txtFname.Clear()
        txtGender.Clear()
        txtHeight.Clear()
        txtIID.Clear()
        txtPID.Clear()
        txtWeight.Clear()
        rtxtAddress.Clear()
        rtxtAllergies.Clear()
        rtxtMTH.Clear()
        txtICNO.Clear()
        rtxtPMG.Clear()
    End Sub
End Class