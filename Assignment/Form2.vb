Imports System.Data.OleDb
Public Class Form2
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdInsert As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=create profile.mdb"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtPID.Text <> "" And txtFname.Text <> "" And txtIID.Text <> "" And txtGender.Text <> "" And rtxtAddress.Text <> "" And txtCnum.Text <> "" And txtEmail.Text <> "" And txtHeight.Text <> "" And txtWeight.Text <> "" And txtBT.Text <> "" And rtxtAllergies.Text <> "" And rtxtMTH.Text <> "" And rtxtPMG.Text <> "" Then
            cmdInsert.CommandText = "Insert Into [Patient Profile] values('" + txtPID.Text + "','" + txtFname.Text + "'," + txtIID.Text + ",'" + txtGender.Text + "','" + rtxtAddress.Text + "'," + txtCnum.Text + ",'" + txtEmail.Text + "'," + txtHeight.Text + "," + txtWeight.Text + ", '" + txtBT.Text + "' ,'" + rtxtAllergies.Text + "','" + rtxtMTH.Text + "', '" + rtxtPMG.Text + "')"
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = cnnOLEDB
            cmdInsert.ExecuteNonQuery()
            MsgBox("Profile Created Successfully")
        Else
            MsgBox("Not enough information")
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
        txtBT.Clear()
        rtxtAddress.Clear()
        rtxtAllergies.Clear()
        rtxtMTH.Clear()
    End Sub

    Private Sub txtPID_TextChanged(sender As Object, e As EventArgs) Handles txtPID.TextChanged

    End Sub
End Class