Imports System.Data.OleDb
Public Class SecurityApproval
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source ="
    Dim dataFile As String = "..\VisitorPass.accdb"
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection
    Private Sub SecurityApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
    End Sub

    Private Sub btnGood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGood.Click
        Dim sqlQuery As String = "INSERT INTO VisitorApproved (Visitor_ID, FirstName, lastName, IC, Gender,MobileNo, Address) SELECT ID, FirstName, LastName, IC, Gender, MobileNo, VisitorAddress FROM Visitor WHERE ID = " & lblVisitorID.Text & ";"
        connString = provider & dataFile
        conn.ConnectionString = connString
        If MsgBox("Are you sure you want to approve this visit ?", vbYesNo, "Confirm") = vbYes Then
            conn.Open()
            Dim sqlCommand As New OleDbCommand(sqlQuery, conn)
            sqlCommand.ExecuteNonQuery()
            MsgBox("The visit has been approved.")
            conn.Close()
            Me.Hide()
        End If        
    End Sub

    Private Sub btnBad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBad.Click
        Dim sqlQuery As String = "INSERT INTO VisitorRejected (Visitor_ID, FirstName, lastName, IC, Gender,MobileNo, Address) SELECT ID, FirstName, LastName, IC, Gender, MobileNo, VisitorAddress FROM Visitor WHERE ID = " & lblVisitorID.Text & ";"       
        connString = provider & dataFile
        conn.ConnectionString = connString
        If MsgBox("Are you sure you want to reject this visit ?", vbYesNo, "Confirm") = vbYes Then
            conn.Open()
            Dim sqlCommand As New OleDbCommand(sqlQuery, conn)
            sqlCommand.ExecuteNonQuery()
            MsgBox("The visit has been rejected.")
            conn.Close()
            Me.Hide()
        End If
    End Sub
End Class