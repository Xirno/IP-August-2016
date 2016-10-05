Imports System.Data.OleDb

Public Class VisitorApplyPass

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub VisitorApplyPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        ' Dim sql As String = "Select * from Visitor_ApplyPass"

        con = New OleDbConnection(str)
        ' Dim cmd As OleDbCommand
        ' Dim r As OleDbDataReader
        con.Open()
        ' cmd = New OleDbCommand(sql, con)
        ' r = cmd.ExecuteReader

        If txtHouseOwnerLoc.Text = "" Then
            MsgBox("no empty")
        ElseIf txtNumberOfDay.Text = "" Then
            MsgBox("no empty")
        ElseIf txtTime.Text = "" Then
            MsgBox("no empty")
        ElseIf txtVehicleNumber.Text = "" Then
            MsgBox("no empty")
        ElseIf txtVisitReason.Text = "" Then
            MsgBox("no empty")
        Else

            Dim sql2 As String
            sql2 = "insert into Visitor_ApplyPass([Visitor_ID],Visit_Reason,HouseOwner_location,[Number_Of_Days],Vehicle_Number,[Time]) values ('" & lblVisitorID.Text & "','" & txtVisitReason.Text & "','" & txtHouseOwnerLoc.Text & "','" & txtNumberOfDay.Text & "','" & txtVehicleNumber.Text & "','" & txtTime.Text & "')"
            Dim cmd2 = New OleDbCommand(sql2, con)

            cmd2.ExecuteNonQuery()
            MsgBox("The Visitor Gate Pass details are sent, please waiting for security approval")
            Me.Close()

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click


        txtHouseOwnerLoc.Clear()
        txtHouseOwnerLoc.Clear()
        txtNumberOfDay.Clear()
        txtTime.Clear()
        txtVehicleNumber.Clear()
        txtVisitReason.Clear()

    End Sub
End Class