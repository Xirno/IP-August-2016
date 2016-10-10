Imports System.Data.OleDb

Public Class FoundPassword

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPass.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.Close()

    End Sub

    Private Sub FoundPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from [" & lblRole.Text & "]where Accountname='" & lblAccountName.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()


        If dr.Read Then

            lblAccountName.Text = dr("AccountName").ToString()
            lblPassword.Text = dr("Password").ToString()
            

        Else

            con.Close()
            MsgBox("Sorry, No AccountName exists", MsgBoxStyle.OkOnly, "invalid AccountName")
            Me.Close()
            Login.Show()
        End If


    End Sub
End Class