Imports System.Data.OleDb

Public Class VisitorProfile

    Public Property StringPass As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditProfile.Click

        VisitorEditProfile.txtName.Text = lblwelcome.Text
        VisitorEditProfile.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyPass.Click


        VisitorApplyPass.Show()
        VisitorApplyPass.lblVisitorID.Text = lblID.Text
        'VisitorApplyPass.lblFirstName.Text = lblFirstName.Text
        'VisitorApplyPass.lblLastName.Text = lblLastName.Text
        'VisitorApplyPass.lblAddress.Text = lblVisitorAddress.Text
        'VisitorApplyPass.lblMobileNumber.Text = lblMobileNo.Text


    End Sub

    Private Sub VisitorProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Show()
        lblwelcome.Text = StringPass
        '   lblpassword.Text = Visitor.txtPassword.Text

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from visitor where Accountname='" & lblwelcome.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()


        If dr.Read Then

            lblwelcome.Text = dr("AccountName").ToString()
            lblpassword.Text = dr("Password").ToString()
            lblID.Text = dr("ID").ToString()
            lblFirstName.Text = dr("FirstName").ToString()
            lblLastName.Text = dr("LastName").ToString()
            lblIC.Text = dr("IC").ToString()
            lblGender.Text = dr("Gender").ToString()
            lblMobileNo.Text = dr("MobileNo").ToString()
            lblDateOfBirth.Text = dr("DateOfBirth").ToString()
            lblVisitorAddress.Text = dr("VisitorAddress").ToString()
            Dim data As Byte() = DirectCast(dr("Image"), Byte())
            Dim ms As New System.IO.MemoryStream(data)
            PictureBox1.Image = Image.FromStream(MS)

        Else

            con.Close()
            MsgBox("Sorry, Please try again and login", MsgBoxStyle.OkOnly, "invalid Login")
            Me.Close()

        End If
        con.Close()

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

        MsgBox("Logged out")
        Login.Show()
        Me.Close()
    End Sub

    Private Sub lblpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpassword.Click

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGender.Click

    End Sub

    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click

        VisitorHistory.Show()
        VisitorHistory.lblvisitorID.Text = lblID.Text

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        VisitorAppliedPass.Show()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        VisitorFromHouseOwner.Show()

    End Sub
End Class