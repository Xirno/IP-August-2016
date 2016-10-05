Imports System.Data.OleDb

Public Class HouseOwnerEditProfile

    Private Sub VisitorEditProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =..\HouseownerBooking.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from HouserOwner where Username='" & txtUsername.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblID.Text = dr("ID").ToString()
            txtUsername.Text = dr("Username").ToString()
            txtPassword.Text = dr("Password").ToString()
            txtSurName.Text = dr("Houseowner_Surname").ToString()
            txtGivenName.Text = dr("Houseowner_GivenName").ToString()
            txtAddress.Text = dr("Houseowner_address").ToString()
            txtIC.Text = dr("IC").ToString()
            txtMobile.Text = dr("Mobile").ToString()
            txtBirth.Text = dr("Dateofbirth").ToString()
        End If
        con.Close()
    End Sub





    Private Sub HouseOwnerEditProfile_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim obj2 As New HouseOwnerProfile
        obj2.StringPass = txtUsername.Text
        obj2.Show()


    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtPassword.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtUsername.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtSurName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtGivenName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtMobile.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtBirth.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtAddress.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtIC.Text.ToString() = "" Then
            MsgBox("do not empty")

        Else

            Dim con As New OleDb.OleDbConnection
            Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =..\HouseownerBooking.accdb"
            Dim sql As String
            sql = "Update HouserOwner set [Password]='" & txtPassword.Text & "',Username='" & txtUsername.Text & "',Houseowner_Surname='" & txtSurName.Text & "',Houseowner_GivenName='" & txtGivenName.Text & "',[IC]='" & txtIC.Text & "',[Mobile]='" & txtMobile.Text & "',[Dateofbirth]='" & txtBirth.Text & "',Houseowner_address='" & txtAddress.Text & "'where [ID]=" & lblID.Text & ""

            con = New OleDbConnection(str)
            Dim cmd As New OleDbCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Profile is updated")
            con.Close()
            Me.Close()
        End If
    End Sub
End Class