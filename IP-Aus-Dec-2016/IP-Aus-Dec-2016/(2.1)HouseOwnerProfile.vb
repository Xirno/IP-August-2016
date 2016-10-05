
Imports System.Data.OleDb
Public Class HouseOwnerProfile
    Public Property StringPass As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsername.Text = StringPass
        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =..\HouseownerBooking.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "Select * from  HouserOwner where Username='" & lblUsername.Text & "' "
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblUsername.Text = dr("Username").ToString()
            lblPassword.Text = dr("Password").ToString()
            lblSurname.Text = dr("Houseowner_Surname").ToString()
            lblGivenName.Text = dr("Houseowner_GivenName").ToString()
            lblAddress.Text = dr("Houseowner_address").ToString()


        End If
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        HouseOwnerBookingForVisitor.Show()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub
End Class