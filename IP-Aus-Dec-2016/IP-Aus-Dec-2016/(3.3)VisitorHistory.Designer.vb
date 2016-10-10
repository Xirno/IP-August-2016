<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorHistory
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblSeach = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblvisitorID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVisitAddress = New System.Windows.Forms.TextBox()
        Me.txtApproved = New System.Windows.Forms.TextBox()
        Me.txtVisitDate = New System.Windows.Forms.TextBox()
        Me.txtVisitorName = New System.Windows.Forms.TextBox()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
        Me.txtTimeIn = New System.Windows.Forms.TextBox()
        Me.txtGatePass = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(886, 217)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 66)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Load"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(697, 226)
        Me.DataGridView1.TabIndex = 1
        '
        'lblSeach
        '
        Me.lblSeach.AutoSize = True
        Me.lblSeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeach.Location = New System.Drawing.Point(748, 57)
        Me.lblSeach.Name = "lblSeach"
        Me.lblSeach.Size = New System.Drawing.Size(109, 25)
        Me.lblSeach.TabIndex = 2
        Me.lblSeach.Text = "Search by"
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.Location = New System.Drawing.Point(40, 9)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(231, 25)
        Me.lblHistory.TabIndex = 4
        Me.lblHistory.Text = "Visitor History Records"
        '
        'txtSearch
        '
        Me.txtSearch.Enabled = False
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(748, 104)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(245, 31)
        Me.txtSearch.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Visit_Address", "GatePassNo", "Time In", "Time Out", "Approved by"})
        Me.ComboBox1.Location = New System.Drawing.Point(863, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 32)
        Me.ComboBox1.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(748, 217)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 66)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(345, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(104, 25)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "VisitorID :"
        '
        'lblvisitorID
        '
        Me.lblvisitorID.AutoSize = True
        Me.lblvisitorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvisitorID.Location = New System.Drawing.Point(474, 9)
        Me.lblvisitorID.Name = "lblvisitorID"
        Me.lblvisitorID.Size = New System.Drawing.Size(32, 25)
        Me.lblvisitorID.TabIndex = 8
        Me.lblvisitorID.Text = "'''''"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Visit Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Visitor Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(644, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Approved By"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Time In"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(351, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Time Out"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Gate Pass ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(644, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Visit Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVisitAddress)
        Me.GroupBox1.Controls.Add(Me.txtApproved)
        Me.GroupBox1.Controls.Add(Me.txtVisitDate)
        Me.GroupBox1.Controls.Add(Me.txtVisitorName)
        Me.GroupBox1.Controls.Add(Me.txtTimeOut)
        Me.GroupBox1.Controls.Add(Me.txtTimeIn)
        Me.GroupBox1.Controls.Add(Me.txtGatePass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(983, 334)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visitor Visited History"
        '
        'txtVisitAddress
        '
        Me.txtVisitAddress.Enabled = False
        Me.txtVisitAddress.Location = New System.Drawing.Point(172, 248)
        Me.txtVisitAddress.Name = "txtVisitAddress"
        Me.txtVisitAddress.Size = New System.Drawing.Size(776, 31)
        Me.txtVisitAddress.TabIndex = 23
        '
        'txtApproved
        '
        Me.txtApproved.Enabled = False
        Me.txtApproved.Location = New System.Drawing.Point(785, 74)
        Me.txtApproved.Name = "txtApproved"
        Me.txtApproved.Size = New System.Drawing.Size(163, 31)
        Me.txtApproved.TabIndex = 22
        '
        'txtVisitDate
        '
        Me.txtVisitDate.Enabled = False
        Me.txtVisitDate.Location = New System.Drawing.Point(785, 150)
        Me.txtVisitDate.Name = "txtVisitDate"
        Me.txtVisitDate.Size = New System.Drawing.Size(163, 31)
        Me.txtVisitDate.TabIndex = 21
        '
        'txtVisitorName
        '
        Me.txtVisitorName.Enabled = False
        Me.txtVisitorName.Location = New System.Drawing.Point(475, 77)
        Me.txtVisitorName.Name = "txtVisitorName"
        Me.txtVisitorName.Size = New System.Drawing.Size(163, 31)
        Me.txtVisitorName.TabIndex = 20
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Enabled = False
        Me.txtTimeOut.Location = New System.Drawing.Point(475, 153)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(163, 31)
        Me.txtTimeOut.TabIndex = 19
        '
        'txtTimeIn
        '
        Me.txtTimeIn.Enabled = False
        Me.txtTimeIn.Location = New System.Drawing.Point(172, 150)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.Size = New System.Drawing.Size(163, 31)
        Me.txtTimeIn.TabIndex = 18
        '
        'txtGatePass
        '
        Me.txtGatePass.Enabled = False
        Me.txtGatePass.Location = New System.Drawing.Point(172, 74)
        Me.txtGatePass.Name = "txtGatePass"
        Me.txtGatePass.Size = New System.Drawing.Size(163, 31)
        Me.txtGatePass.TabIndex = 17
        '
        'VisitorHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 659)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblvisitorID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSeach)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "VisitorHistory"
        Me.Text = "VisitorHistory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblSeach As System.Windows.Forms.Label
    Friend WithEvents lblHistory As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblvisitorID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVisitAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtApproved As System.Windows.Forms.TextBox
    Friend WithEvents txtVisitDate As System.Windows.Forms.TextBox
    Friend WithEvents txtVisitorName As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeIn As System.Windows.Forms.TextBox
    Friend WithEvents txtGatePass As System.Windows.Forms.TextBox
End Class
