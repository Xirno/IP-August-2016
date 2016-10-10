<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.btnHouseOwner = New System.Windows.Forms.Button()
        Me.btnSecurity = New System.Windows.Forms.Button()
        Me.btnVisitor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHouseOwner
        '
        Me.btnHouseOwner.Enabled = False
        Me.btnHouseOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouseOwner.Location = New System.Drawing.Point(85, 107)
        Me.btnHouseOwner.Name = "btnHouseOwner"
        Me.btnHouseOwner.Size = New System.Drawing.Size(521, 99)
        Me.btnHouseOwner.TabIndex = 0
        Me.btnHouseOwner.Text = "HouseOwner"
        Me.btnHouseOwner.UseVisualStyleBackColor = True
        '
        'btnSecurity
        '
        Me.btnSecurity.Enabled = False
        Me.btnSecurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecurity.Location = New System.Drawing.Point(85, 203)
        Me.btnSecurity.Name = "btnSecurity"
        Me.btnSecurity.Size = New System.Drawing.Size(521, 99)
        Me.btnSecurity.TabIndex = 1
        Me.btnSecurity.Text = "Security"
        Me.btnSecurity.UseVisualStyleBackColor = True
        '
        'btnVisitor
        '
        Me.btnVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitor.Location = New System.Drawing.Point(85, 297)
        Me.btnVisitor.Name = "btnVisitor"
        Me.btnVisitor.Size = New System.Drawing.Size(521, 99)
        Me.btnVisitor.TabIndex = 2
        Me.btnVisitor.Text = "Login"
        Me.btnVisitor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Visitor Gate Pass System"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 420)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVisitor)
        Me.Controls.Add(Me.btnSecurity)
        Me.Controls.Add(Me.btnHouseOwner)
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHouseOwner As System.Windows.Forms.Button
    Friend WithEvents btnSecurity As System.Windows.Forms.Button
    Friend WithEvents btnVisitor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
