Imports System.Data.OleDb

Public Class SecurityControlPanel

    Public Property StringPass As String


    Private Sub lblLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLog.Click
        Security.Show()
        Security.txtUser.Clear()
        Security.txtPass.Clear()
        Me.Close()
    End Sub

    Private Sub BtnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVer.Click
        SecurityVerification.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        VisitorApplyPass.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblName.Text = StringPass
        Timer1.Enabled = True

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from Security where Accountname='" & lblName.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()

        If dr.Read Then

            lblName.Text = dr("AccountName").ToString()
            Label1.Text = dr("FName").ToString()
            Label2.Text = dr("Age").ToString()

        Else
            con.Close()
            MsgBox("Sorry, Please try again and login", MsgBoxStyle.OkOnly, "invalid Login")
            Me.Close()

        End If
        con.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.TimeOfDay.ToString()
    End Sub

    Private Sub lblTime_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName.Click

    End Sub
End Class