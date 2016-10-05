<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorApplyPass
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtVehicleNumber = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtNumberOfDay = New System.Windows.Forms.TextBox()
        Me.txtHouseOwnerLoc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtVisitReason = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lblMobileNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblVisitorID = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(837, 83)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 116)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date Of Visit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HouseOwner Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Visit Reason"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number(s) of Day(s)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtVehicleNumber)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtNumberOfDay)
        Me.GroupBox1.Controls.Add(Me.txtHouseOwnerLoc)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtVisitReason)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 213)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visitor Pass for apply"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(544, 25)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(191, 29)
        Me.txtTime.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(495, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Time"
        '
        'txtVehicleNumber
        '
        Me.txtVehicleNumber.Location = New System.Drawing.Point(190, 148)
        Me.txtVehicleNumber.Name = "txtVehicleNumber"
        Me.txtVehicleNumber.Size = New System.Drawing.Size(263, 29)
        Me.txtVehicleNumber.TabIndex = 19
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(299, 29)
        Me.DateTimePicker1.TabIndex = 14
        '
        'txtNumberOfDay
        '
        Me.txtNumberOfDay.Location = New System.Drawing.Point(189, 116)
        Me.txtNumberOfDay.Name = "txtNumberOfDay"
        Me.txtNumberOfDay.Size = New System.Drawing.Size(71, 29)
        Me.txtNumberOfDay.TabIndex = 8
        '
        'txtHouseOwnerLoc
        '
        Me.txtHouseOwnerLoc.Location = New System.Drawing.Point(190, 87)
        Me.txtHouseOwnerLoc.Name = "txtHouseOwnerLoc"
        Me.txtHouseOwnerLoc.Size = New System.Drawing.Size(547, 29)
        Me.txtHouseOwnerLoc.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 20)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Vehicle Number"
        '
        'txtVisitReason
        '
        Me.txtVisitReason.Location = New System.Drawing.Point(190, 57)
        Me.txtVisitReason.Name = "txtVisitReason"
        Me.txtVisitReason.Size = New System.Drawing.Size(545, 29)
        Me.txtVisitReason.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(837, 318)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(175, 127)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Send For Applying"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(299, 31)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Visitor Apply Gate Pass"
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(837, 195)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(175, 127)
        Me.btnClearAll.TabIndex = 15
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLastName)
        Me.GroupBox2.Controls.Add(Me.lbl7)
        Me.GroupBox2.Controls.Add(Me.lblMobileNumber)
        Me.GroupBox2.Controls.Add(Me.lblAddress)
        Me.GroupBox2.Controls.Add(Me.lblGender)
        Me.GroupBox2.Controls.Add(Me.lblFirstName)
        Me.GroupBox2.Controls.Add(Me.lblVisitorID)
        Me.GroupBox2.Controls.Add(Me.lbl6)
        Me.GroupBox2.Controls.Add(Me.lbl4)
        Me.GroupBox2.Controls.Add(Me.lbl1)
        Me.GroupBox2.Controls.Add(Me.lbl3)
        Me.GroupBox2.Controls.Add(Me.lbl2)
        Me.GroupBox2.Controls.Add(Me.lbl5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 240)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visitor Details"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(517, 77)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(28, 24)
        Me.lblLastName.TabIndex = 25
        Me.lblLastName.Text = "---"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(341, 77)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(94, 24)
        Me.lbl7.TabIndex = 24
        Me.lbl7.Text = "LastName"
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNumber.Location = New System.Drawing.Point(184, 200)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(28, 24)
        Me.lblMobileNumber.TabIndex = 23
        Me.lblMobileNumber.Text = "---"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(185, 156)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(28, 24)
        Me.lblAddress.TabIndex = 22
        Me.lblAddress.Text = "---"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(184, 121)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(28, 24)
        Me.lblGender.TabIndex = 21
        Me.lblGender.Text = "---"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(184, 82)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(28, 24)
        Me.lblFirstName.TabIndex = 20
        Me.lblFirstName.Text = "---"
        '
        'lblVisitorID
        '
        Me.lblVisitorID.AutoSize = True
        Me.lblVisitorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitorID.Location = New System.Drawing.Point(184, 44)
        Me.lblVisitorID.Name = "lblVisitorID"
        Me.lblVisitorID.Size = New System.Drawing.Size(28, 24)
        Me.lblVisitorID.TabIndex = 19
        Me.lblVisitorID.Text = "---"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(341, 44)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(110, 24)
        Me.lbl6.TabIndex = 16
        Me.lbl6.Text = "VisitorPhoto"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(14, 156)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(80, 24)
        Me.lbl4.TabIndex = 14
        Me.lbl4.Text = "Address"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(18, 44)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(83, 24)
        Me.lbl1.TabIndex = 10
        Me.lbl1.Text = "Visitor ID"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(17, 121)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(74, 24)
        Me.lbl3.TabIndex = 13
        Me.lbl3.Text = "Gender"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(17, 82)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(96, 24)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "FirstName"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(14, 200)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(141, 24)
        Me.lbl5.TabIndex = 12
        Me.lbl5.Text = "Mobile Number"
        '
        'VisitorApplyPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 595)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "VisitorApplyPass"
        Me.Text = "VisitorApplyPass"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtHouseOwnerLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtVisitReason As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumberOfDay As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents txtVehicleNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMobileNumber As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblVisitorID As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
