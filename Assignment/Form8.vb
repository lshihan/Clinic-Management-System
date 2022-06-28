﻿Imports System.Data.OleDb
Public Class Form8
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdInsert As New OleDbCommand
    Dim cmdUpdate As New OleDbCommand
    Dim cmdSearch As New OleDbCommand
    Dim cmdDelete As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=create profile.mdb"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtNID.Text <> "" And lblFname.Text <> "" And txtIID.Text <> "" And txtGender.Text <> "" And rtxtAddress.Text <> "" And txtCnum.Text <> "" And txtEmail.Text <> "" And txtPw.Text <> "" Then
            cmdInsert.CommandText = "Insert Into [Nurse Profile] values('" + txtNID.Text + "','" + txtFname.Text + "'," + txtIID.Text + ",'" + txtGender.Text + "','" + rtxtAddress.Text + "'," + txtCnum.Text + ",'" + txtEmail.Text + "','" + txtPw.Text + "')"
            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = cnnOLEDB
            cmdInsert.ExecuteNonQuery()
            MsgBox("Profile Created Successfully")

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtNID.Text <> "" And txtFname.Text <> "" And txtIID.Text <> "" And txtGender.Text <> "" And rtxtAddress.Text <> "" And txtCnum.Text <> "" And txtEmail.Text <> "" And txtPw.Text <> "" Then
            cmdUpdate.CommandText = "UPDATE [Nurse Profile] SET [Password]= '" + txtPw.Text + "' ;"
            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = cnnOLEDB
            cmdUpdate.ExecuteNonQuery()
            MsgBox(txtNID.Text & "" & "Record Updated.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtNID.Text <> "" Then
            cmdSearch.CommandText = "SELECT *from[Nurse Profile] Where [Staff ID] ='" + txtNID.Text + "';"
            cmdSearch.Connection = cnnOLEDB

            Dim rd As OleDbDataReader = cmdSearch.ExecuteReader()

            If rd.Read = True Then
                txtNID.Text = rd(0).ToString
                txtFname.Text = rd(1).ToString
                txtIID.Text = rd(2).ToString
                txtGender.Text = rd(3).ToString
                rtxtAddress.Text = rd(4).ToString
                txtCnum.Text = rd(5).ToString
                txtEmail.Text = rd(6).ToString
                txtPw.Text = rd(7).ToString

            Else
                MessageBox.Show("Information not found in Database")

            End If
            rd.Close()

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtNID.Text <> "" Then
            cmdDelete.CommandText = "Delete from [Nurse Profile] Where [Staff ID]='" + txtNID.Text + "';"
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.Connection = cnnOLEDB
            cmdDelete.ExecuteNonQuery()
            MsgBox("Successfully Deleted")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCnum.Clear()
        txtNID.Clear()
        txtEmail.Clear()
        txtFname.Clear()
        txtGender.Clear()
        txtIID.Clear()
        txtPw.Clear()
        rtxtAddress.Clear()
    End Sub
End Class