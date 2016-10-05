Imports System.Data.OleDb
Public Class HouseOwnerBookingForVisitor


    Dim sql As String
    Dim objcmd As New OleDbCommand
    Dim r As OleDbDataReader
    Dim visitorID As Integer
    Dim Surname As String
    Dim Givenname As String
    Dim password As Integer
    Dim visitplace As String
    Dim timeIn As Date
    Dim timeOut As Date
    Dim visitdate As DateTime
    Dim Username As String




    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        visitorID = txtID.Text
        Username = txtUsername.Text
        Surname = txtSurName.Text
        Givenname = txtGivenName.Text
        password = txtPassword.Text
        visitplace = txtVisitPlace.Text
        timeIn = txtTimeIn.Text.ToString
        timeOut = txtTimeOut.Text
        visitdate = DateTimePicker1.Text


        Dim sql2 As String
        Dim con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =..\HouseownerBooking.accdb")

        sql = "Select * from  HouseownerVisitor where Visitor_Surname='" & txtSurName.Text & "'"


        Dim r As OleDbDataReader

        con.Open()
        objcmd = New OleDbCommand(sql, con)
        r = objcmd.ExecuteReader()

        If r.Read Then
            Username = r("Houseowner_account")
            lblOutput.Text = "This Surname had been already exists"
            con.Close()
        Else
            Dim gender As String

            If RadioButton1.Checked Then
                gender = "Male"
            Else
                gender = "Female"

            End If

            sql2 = "INSERT INTO HouseownerVisitor(ID,Visitor_Surname,Visitor_GivenName,[Password],Visit_Place,[Time_In],[Time_Out],gender) values('" & txtID.Text & "','" & txtSurName.Text & "','" & txtGivenName.Text & "','" & txtPassword.Text & "','" & txtVisitPlace.Text & "','" & txtTimeIn.Text & "','" & txtTimeOut.Text & "','" & gender & "')"

            objcmd = New OleDbCommand(sql2, con)
            objcmd.ExecuteNonQuery()
            MsgBox("Record Had Saving")
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub HouseOwner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class