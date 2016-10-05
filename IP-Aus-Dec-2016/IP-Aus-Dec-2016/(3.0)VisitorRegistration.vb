Imports System.Data.OleDb

Public Class VisitorRegistration

    
    Private Sub Visitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtpassword.UseSystemPasswordChar = True

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        lblErrorName.Text = ""
        lblErrorPassword.Text = ""
        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        Dim sql As String = "Select * from Visitor where Name = '" & txtName.Text & "'"
        Dim Name1 As String


        con = New OleDbConnection(str)
        Dim cmd As OleDbCommand
        Dim r As OleDbDataReader

        con.Open()
        cmd = New OleDbCommand(sql, con)
        r = cmd.ExecuteReader

        If r.Read Then
            Name1 = r("Name")
            lblErrorName.Text = "visitor account already exists"
            con.Close()
        ElseIf txtName.Text.Trim() = "" Then
            lblErrorName.Text = "please write your name"
        ElseIf txtpassword.Text.Trim() = "" Then
            lblErrorPassword.Text = "please write your password"
        Else
            con.Close()
            con.Open()
            Dim sql2 As String
            sql2 = "insert into Visitor(Name,[Password]) values ('" & txtName.Text & "','" & txtpassword.Text & "')"
            Dim cmd2 = New OleDbCommand(sql2, con)
            cmd2.ExecuteNonQuery()
            MsgBox("Account is Registered")
            Me.Close()
        End If

    End Sub

    Private Sub btnRegister_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
End Class