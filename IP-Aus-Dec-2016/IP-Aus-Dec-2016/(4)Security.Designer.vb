<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Security
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblError2 = New System.Windows.Forms.Label()
        Me.lblError1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblError2
        '
        Me.lblError2.ForeColor = System.Drawing.Color.Red
        Me.lblError2.Location = New System.Drawing.Point(161, 191)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(161, 45)
        Me.lblError2.TabIndex = 13
        '
        'lblError1
        '
        Me.lblError1.ForeColor = System.Drawing.Color.Red
        Me.lblError1.Location = New System.Drawing.Point(161, 120)
        Me.lblError1.Name = "lblError1"
        Me.lblError1.Size = New System.Drawing.Size(161, 45)
        Me.lblError1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 39)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(161, 168)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(161, 20)
        Me.txtPass.TabIndex = 10
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(161, 93)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(161, 20)
        Me.txtUser.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 367)
        Me.Controls.Add(Me.lblError2)
        Me.Controls.Add(Me.lblError1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Security"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblError2 As Label
    Friend WithEvents lblError1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
