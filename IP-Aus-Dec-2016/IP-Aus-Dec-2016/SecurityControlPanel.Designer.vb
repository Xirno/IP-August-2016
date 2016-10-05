<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityControlPanel
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.BtnVer = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(475, 358)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "Time"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.ForeColor = System.Drawing.Color.Blue
        Me.lblLog.Location = New System.Drawing.Point(475, 144)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(98, 13)
        Me.lblLog.TabIndex = 9
        Me.lblLog.Text = "Click here to logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(78, 304)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(218, 47)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply for Visitor Gate Pass"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'BtnVer
        '
        Me.BtnVer.Location = New System.Drawing.Point(78, 177)
        Me.BtnVer.Name = "BtnVer"
        Me.BtnVer.Size = New System.Drawing.Size(218, 47)
        Me.BtnVer.TabIndex = 6
        Me.BtnVer.Text = "Verify Visitor gate Pass"
        Me.BtnVer.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'SecurityControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 467)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.BtnVer)
        Me.Name = "SecurityControlPanel"
        Me.Text = "SecurityControlPanel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents lblLog As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents BtnVer As Button
    Friend WithEvents Timer1 As Timer
End Class
