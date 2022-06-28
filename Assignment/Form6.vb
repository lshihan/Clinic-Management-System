Imports System.Data.OleDb
Public Class Form6
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdSearch As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=create profile.mdb"
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open()
        txtPw.UseSystemPasswordChar = True
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtSID.Text <> "" And txtPw.Text <> "" And rbtnDoctor.Checked Then

            cmdSearch.CommandText = "SELECT *from [Doctor Profile] where [Staff ID]= '" + txtSID.Text + "' and [Password] = '" + txtPw.Text + "' ;"
            cmdSearch.Connection = cnnOLEDB


            Dim rd As OleDbDataReader = cmdSearch.ExecuteReader()

            If rd.Read = True Then
                Form5.Show()
                Me.Hide()
            Else
                MsgBox("Login Failed")
            End If
            rd.Close()


        ElseIf txtSID.Text <> "" And txtPw.Text <> "" And rbtnNurse.Checked Then
            cmdSearch.CommandText = "SELECT *from[Nurse Profile] where [Staff ID] = '" + txtSID.Text + "' and [Password] ='" + txtPw.Text + "' ;"
            cmdSearch.Connection = cnnOLEDB


            Dim rd As OleDbDataReader = cmdSearch.ExecuteReader()

            If rd.Read = True Then
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Login Failed")
            End If
            rd.Close()



        ElseIf txtSID.Text <> "" And txtPw.Text <> "" And rbtnAdmin.Checked Then
            cmdSearch.CommandText = "SELECT *from[Admin Profile] where [Staff ID] = '" + txtSID.Text + "' and [Password] ='" + txtPw.Text + "' ;"
            cmdSearch.Connection = cnnOLEDB


            Dim rd As OleDbDataReader = cmdSearch.ExecuteReader()

            If rd.Read = True Then
                Form7.Show()
                Me.Hide()

            Else
                MsgBox("Login Failed")
            End If
            rd.Close()
        Else
            MsgBox("ID and Password must be filled!")

        End If

    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If txtPw.UseSystemPasswordChar = True Then
            txtPw.UseSystemPasswordChar = False
        Else
            txtPw.UseSystemPasswordChar = True
        End If
    End Sub
End Class