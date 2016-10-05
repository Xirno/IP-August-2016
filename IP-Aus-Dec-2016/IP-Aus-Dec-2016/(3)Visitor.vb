Imports System.Data.OleDb

Public Class Visitor
    
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        MainPage.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        lblError1.Text = ""
        lblError2.Text = ""

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from visitor where AccountName='" & txtName.Text & "' and [password]='" & txtPassword.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim obj As New VisitorProfile
        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()


        If txtName.Text.Trim() = "" Then
            lblError1.Text = "pls write name"
        ElseIf txtPassword.Text.Trim() = "" Then
            lblError2.Text = "pls write password"
            'ElseIf Not dr.HasRows = txtName.Text.Trim() Then
            '    lblError1.Text = "your Account is incorrect"
            ' ElseIf Not dr.HasRows = txtPassword.Text.Trim() Then
            '      lblError2.Text = "your Password is incorrect"
        ElseIf Not dr.HasRows Then

            MsgBox("Sorry Please try again !", MsgBoxStyle.OkOnly, "Invalid Login")

        ElseIf dr.Read Then

            txtName.Text = dr("AccountName").ToString()
            txtPassword.Text = dr("Password").ToString()
            obj.StringPass = txtName.Text
            MsgBox("welcome")
            obj.Show()
            VisitorProfile.lblwelcome.Text = txtName.Text
            Me.Hide()

        Else
            con.Close()
            MsgBox("Sorry Please try again", MsgBoxStyle.OkOnly, "invalid login")


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

        VisitorHistory.Show()

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