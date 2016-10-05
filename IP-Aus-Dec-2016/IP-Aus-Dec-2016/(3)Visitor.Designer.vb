<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visitor
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblError1 = New System.Windows.Forms.Label()
        Me.lblError2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblForgetPassword = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(97, 26)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 57)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(95, 126)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 25)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Account"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(95, 174)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(106, 25)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(233, 128)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 29)
        Me.txtName.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtName, "Enter your Account")
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(233, 166)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(168, 29)
        Me.txtPassword.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtPassword, "Enter Your Password")
        '
        'lblError1
        '
        Me.lblError1.AutoSize = True
        Me.lblError1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError1.ForeColor = System.Drawing.Color.Red
        Me.lblError1.Location = New System.Drawing.Point(441, 131)
        Me.lblError1.Name = "lblError1"
        Me.lblError1.Size = New System.Drawing.Size(15, 20)
        Me.lblError1.TabIndex = 5
        Me.lblError1.Text = "*"
        '
        'lblError2
        '
        Me.lblError2.AutoSize = True
        Me.lblError2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError2.ForeColor = System.Drawing.Color.Red
        Me.lblError2.Location = New System.Drawing.Point(441, 176)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(15, 20)
        Me.lblError2.TabIndex = 6
        Me.lblError2.Text = "*"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(111, 300)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(119, 53)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.ToolTip1.SetToolTip(Me.btnLogin, "This is for you to log in")
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(227, 300)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(128, 53)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        Me.ToolTip1.SetToolTip(Me.btnRegister, "This is for you register a new account")
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(233, 210)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(163, 28)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show password"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Tick it for showing your password")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(351, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 53)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear the textboxes")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblForgetPassword
        '
        Me.lblForgetPassword.AutoSize = True
        Me.lblForgetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgetPassword.ForeColor = System.Drawing.Color.Blue
        Me.lblForgetPassword.Location = New System.Drawing.Point(228, 253)
        Me.lblForgetPassword.Name = "lblForgetPassword"
        Me.lblForgetPassword.Size = New System.Drawing.Size(211, 20)
        Me.lblForgetPassword.TabIndex = 11
        Me.lblForgetPassword.Text = "Forget Password? Click here"
        Me.ToolTip1.SetToolTip(Me.lblForgetPassword, "Let's go to find you password")
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Visitor", "HouseOwner", "Security"})
        Me.ComboBox1.Location = New System.Drawing.Point(233, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox1.TabIndex = 12
        '
        'Visitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblForgetPassword)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblError2)
        Me.Controls.Add(Me.lblError1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Visitor"
        Me.Text = "Visitor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblError1 As System.Windows.Forms.Label
    Friend WithEvents lblError2 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblForgetPassword As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
