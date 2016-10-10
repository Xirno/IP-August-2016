Imports System.Data.OleDb

Public Class Login

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        MainPage.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        lblError1.Text = ""
        lblError2.Text = ""

        If ComboBox1.SelectedItem = "" Then

            MsgBox("Please Select Your Role ", MsgBoxStyle.OkOnly, "Try Again !")
        Else
            Dim con As New OleDb.OleDbConnection
            Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
            con = New OleDbConnection(str)
            Dim sql As String = "select * from [" & ComboBox1.Text & "] where AccountName='" & txtName.Text.Trim() & "'and [Password]='" & txtPassword.Text.Trim() & "'"
            Dim cmd As OleDbCommand
            Dim dr As OleDbDataReader
            Dim obj As New VisitorProfile
            Dim obj2 As New HouseOwnerProfile
            Dim obj3 As New SecurityControlPanel
            cmd = New OleDbCommand(sql, con)
            con.Open()
            dr = cmd.ExecuteReader()

            Try

                If txtName.Text.Trim().ToString() = "" Then
                    lblError2.Text = ""
                    lblError1.Text = "pls write name"
                ElseIf txtPassword.Text.Trim().ToString() = "" Then
                    lblError1.Text = ""
                    lblError2.Text = "pls write password"

                    'ElseIf Not dr.HasRows = txtName.Text.Trim() Then
                    '    lblError1.Text = "your Account is incorrect"
                    ' ElseIf Not dr.HasRows = txtPassword.Text.Trim() Then
                    '      lblError2.Text = "your Password is incorrect"
                    '   ElseIf Not ComboBox1.SelectedItem Then



                ElseIf Not dr.HasRows Then

                    MsgBox("Sorry Please try again !", MsgBoxStyle.OkOnly, "Invalid Login")

                ElseIf dr.Read Then

                    If ComboBox1.Text = "Visitor" Then
                        txtName.Text = dr("AccountName").ToString()
                        txtPassword.Text = dr("Password").ToString()
                        obj.StringPass = txtName.Text
                        MsgBox("welcome")
                        obj.Show()
                        VisitorProfile.lblwelcome.Text = txtName.Text
                        Me.Hide()
                    ElseIf ComboBox1.Text = "HouserOwner" Then
                        txtName.Text = dr("AccountName").ToString()
                        txtPassword.Text = dr("Password").ToString()
                        obj2.StringPass = txtName.Text
                        MsgBox("Welcome To My Profile !")
                        obj2.Show()
                        HouseOwnerProfile.lblUsername.Text = txtName.Text
                        Me.Hide()

                    ElseIf ComboBox1.Text = "Security" Then


                        Dim Name As String = txtName.Text
                        Dim pass As String = txtPassword.Text
                        Dim FirstName As String = ""
                        Name = dr("AccountName").ToString
                        pass = dr("Password").ToString



                        obj3.StringPass = txtName.Text
                        MsgBox("Welcome To Security Profile")
                        obj3.Show()
                        SecurityControlPanel.lblName.Text = txtName.Text
                        Me.Hide()
                        con.Close()
                    Else
                        con.Close()
                        MsgBox("Sorry Please try again", MsgBoxStyle.OkOnly, "invalid login")
                    End If

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        VisitorRegistration.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Visitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtName.Text = ""
        txtPassword.Text = ""

    End Sub

    Private Sub Visitor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        e.Cancel = True

    End Sub

    Private Sub lblForgetPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblForgetPassword.Click

        FindPassword.Show()

    End Sub

    Private Sub lblForgetPassword_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblForgetPassword.MouseHover

        lblForgetPassword.Font = New Font(lblForgetPassword.Font, FontStyle.Underline)

    End Sub

    Private Sub lblForgetPassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblForgetPassword.MouseLeave

        lblForgetPassword.Font = New Font(lblForgetPassword.Font, FontStyle.Regular)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class