<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.btnLO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnNurse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLO
        '
        Me.btnLO.Location = New System.Drawing.Point(505, 387)
        Me.btnLO.Name = "btnLO"
        Me.btnLO.Size = New System.Drawing.Size(119, 42)
        Me.btnLO.TabIndex = 115
        Me.btnLO.Text = "LogOut"
        Me.btnLO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 52)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Profile Managements"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(405, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 183)
        Me.Button2.TabIndex = 113
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnNurse
        '
        Me.btnNurse.BackgroundImage = CType(resources.GetObject("btnNurse.BackgroundImage"), System.Drawing.Image)
        Me.btnNurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNurse.Location = New System.Drawing.Point(182, 127)
        Me.btnNurse.Name = "btnNurse"
        Me.btnNurse.Size = New System.Drawing.Size(172, 183)
        Me.btnNurse.TabIndex = 112
        Me.btnNurse.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNurse)
        Me.Name = "Form7"
        Me.Text = "Administrator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLO As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnNurse As Button
End Class
