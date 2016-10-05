Imports System.Data.OleDb

Public Class HouseOwnerLogin
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =..\HouseownerBooking.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "Select * from  HouserOwner where Username='" & txtUsername.Text & "' and [Password]='" & txtPassword.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim obj As New HouseOwnerProfile
        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()



        If dr.Read Then
            txtUsername.Text = dr("Username").ToString()
            txtPassword.Text = dr("Password").ToString()
            obj.StringPass = txtUsername.Text
            MsgBox("Welcome To My Profile !")
            obj.Show()
            HouseOwnerProfile.lblUsername.Text = txtUsername.Text
            Me.Hide()
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
