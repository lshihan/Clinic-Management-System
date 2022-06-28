<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnLO = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLO
        '
        Me.btnLO.Location = New System.Drawing.Point(660, 354)
        Me.btnLO.Name = "btnLO"
        Me.btnLO.Size = New System.Drawing.Size(86, 42)
        Me.btnLO.TabIndex = 13
        Me.btnLO.Text = "LogOut"
        Me.btnLO.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(566, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Bill"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Update"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Create"
        '
        'btnBill
        '
        Me.btnBill.BackgroundImage = CType(resources.GetObject("btnBill.BackgroundImage"), System.Drawing.Image)
        Me.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBill.Location = New System.Drawing.Point(490, 144)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(184, 158)
        Me.btnBill.TabIndex = 9
        Me.btnBill.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Location = New System.Drawing.Point(297, 144)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(166, 158)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.BackgroundImage = CType(resources.GetObject("btnCreate.BackgroundImage"), System.Drawing.Image)
        Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreate.Location = New System.Drawing.Point(91, 144)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(171, 158)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 494)
        Me.Controls.Add(Me.btnLO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBill)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "Form1"
        Me.Text = "Nurse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLO As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBill As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreate As Button
End Class
