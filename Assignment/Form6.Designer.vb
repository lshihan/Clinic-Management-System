<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.rbtnAdmin = New System.Windows.Forms.RadioButton()
        Me.rbtnDoctor = New System.Windows.Forms.RadioButton()
        Me.rbtnNurse = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(336, 277)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(101, 42)
        Me.btnLogin.TabIndex = 15
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPw
        '
        Me.txtPw.Location = New System.Drawing.Point(348, 171)
        Me.txtPw.Name = "txtPw"
        Me.txtPw.Size = New System.Drawing.Size(100, 22)
        Me.txtPw.TabIndex = 14
        '
        'txtSID
        '
        Me.txtSID.Location = New System.Drawing.Point(348, 131)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(100, 22)
        Me.txtSID.TabIndex = 13
        '
        'rbtnAdmin
        '
        Me.rbtnAdmin.AutoSize = True
        Me.rbtnAdmin.Location = New System.Drawing.Point(437, 226)
        Me.rbtnAdmin.Name = "rbtnAdmin"
        Me.rbtnAdmin.Size = New System.Drawing.Size(112, 21)
        Me.rbtnAdmin.TabIndex = 12
        Me.rbtnAdmin.TabStop = True
        Me.rbtnAdmin.Text = "Administrator"
        Me.rbtnAdmin.UseVisualStyleBackColor = True
        '
        'rbtnDoctor
        '
        Me.rbtnDoctor.AutoSize = True
        Me.rbtnDoctor.Location = New System.Drawing.Point(348, 226)
        Me.rbtnDoctor.Name = "rbtnDoctor"
        Me.rbtnDoctor.Size = New System.Drawing.Size(71, 21)
        Me.rbtnDoctor.TabIndex = 11
        Me.rbtnDoctor.TabStop = True
        Me.rbtnDoctor.Text = "Doctor"
        Me.rbtnDoctor.UseVisualStyleBackColor = True
        '
        'rbtnNurse
        '
        Me.rbtnNurse.AutoSize = True
        Me.rbtnNurse.Location = New System.Drawing.Point(255, 226)
        Me.rbtnNurse.Name = "rbtnNurse"
        Me.rbtnNurse.Size = New System.Drawing.Size(67, 21)
        Me.rbtnNurse.TabIndex = 10
        Me.rbtnNurse.TabStop = True
        Me.rbtnNurse.Text = "Nurse"
        Me.rbtnNurse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Staff ID :"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(469, 174)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(129, 21)
        Me.chkShow.TabIndex = 16
        Me.chkShow.Text = "Show Password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPw)
        Me.Controls.Add(Me.txtSID)
        Me.Controls.Add(Me.rbtnAdmin)
        Me.Controls.Add(Me.rbtnDoctor)
        Me.Controls.Add(Me.rbtnNurse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "OCEANA CLINIC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPw As TextBox
    Friend WithEvents txtSID As TextBox
    Friend WithEvents rbtnAdmin As RadioButton
    Friend WithEvents rbtnDoctor As RadioButton
    Friend WithEvents rbtnNurse As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShow As CheckBox
End Class
