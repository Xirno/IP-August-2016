Imports System.Data.OleDb

Public Class VisitorEditProfile

    Private Sub VisitorEditProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from visitor where AccountName='" & txtName.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblID2.Text = dr("ID").ToString()
            txtPassword.Text = dr("Password").ToString()
            txtFirstName.Text = dr("FirstName").ToString()
            txtLastName.Text = dr("LastName").ToString()
            txtIC.Text = dr("IC").ToString()
            txtGender.Text = dr("Gender").ToString()
            txtMobileNO.Text = dr("MobileNo").ToString()
            txtDateOfBirth.Text = dr("DateOfBirth").ToString()
            txtVisitorAddress.Text = dr("VisitorAddress").ToString()
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click






        If txtPassword.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtFirstName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtFirstName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtLastName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtGender.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtMobileNO.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtDateOfBirth.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtVisitorAddress.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtIC.Text.ToString() = "" Then
            MsgBox("do not empty")
       
        Else

            Dim con As New OleDb.OleDbConnection
            Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
            Dim sql As String
            sql = "Update Visitor set AccountName='" & txtName.Text & "',[Password]='" & txtPassword.Text & "',FirstName='" & txtFirstName.Text & "',LastName='" & txtLastName.Text & "',[IC]='" & txtIC.Text & "',Gender='" & txtGender.Text & "',[MobileNo]='" & txtMobileNO.Text & "',[DateOfBirth]='" & txtDateOfBirth.Text & "',VisitorAddress='" & txtVisitorAddress.Text & "'where [ID]=" & lblID2.Text & ""
            con = New OleDbConnection(str)
            Dim cmd As New OleDbCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("profile is updated")
            con.Close()
            Me.Close()
        End If
       








    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()


    End Sub

    Private Sub VisitorEditProfile_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim obj1 As New VisitorProfile
        obj1.StringPass = txtName.Text
        obj1.Show()
        'e.Cancel = True

    End Sub
End Class