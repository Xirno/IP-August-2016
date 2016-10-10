<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoundPassword
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
        Me.lblacc = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblacc
        '
        Me.lblacc.AutoSize = True
        Me.lblacc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc.Location = New System.Drawing.Point(46, 104)
        Me.lblacc.Name = "lblacc"
        Me.lblacc.Size = New System.Drawing.Size(185, 31)
        Me.lblacc.TabIndex = 0
        Me.lblacc.Text = "AccountName"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(46, 154)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(134, 31)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Password"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(351, 104)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(47, 31)
        Me.lblAccountName.TabIndex = 2
        Me.lblAccountName.Text = "***"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(351, 154)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(47, 31)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "***"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(321, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "You found your password"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(459, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 81)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Go to Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(46, 22)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(58, 31)
        Me.lblRole.TabIndex = 6
        Me.lblRole.Text = "****"
        '
        'FoundPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 315)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblacc)
        Me.Name = "FoundPassword"
        Me.Text = "FoundPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblacc As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblAccountName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblRole As System.Windows.Forms.Label
End Class
