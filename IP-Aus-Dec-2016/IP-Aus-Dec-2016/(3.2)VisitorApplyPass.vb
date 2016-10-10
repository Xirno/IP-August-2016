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
        ElseIf txtVehicleNumber.Text = "" Then
            MsgBox("no empty")
        ElseIf txtVisitReason.Text = "" Then
            MsgBox("no empty")
        Else
           
            Dim sql2 As String
            sql2 = "insert into Visitor_ApplyPass([Visitor_ID],Visit_Reason,HouseOwner_Name,HouseOwner_location,[Number_Of_Days],Vehicle_Number,[Time],Date_Of_Visit) values ('" & lblVisitorID.Text & "','" & txtVisitReason.Text & "','" & txtHouseOwnerName.Text & "','" & txtHouseOwnerLoc.Text & "','" & txtNumberOfDay.Text & "','" & txtVehicleNumber.Text & "','" & txtTimeIn.Text & "','" & txtDateOfVisit.Text & "')"
            Dim cmd2 = New OleDbCommand(sql2, con)

            cmd2.ExecuteNonQuery()
            MsgBox("The Visitor Gate Pass details are sent, please waiting for security approval")
            Me.Close()

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click

        txtTimeIn.Clear()
        txtHouseOwnerLoc.Clear()
        txtHouseOwnerLoc.Clear()
        txtNumberOfDay.Clear()
        txtVehicleNumber.Clear()
        txtVisitReason.Clear()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        txtDateOfVisit.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

        Dim time1 As String = Format(DateTimePicker2.Value, "h:mm:ss tt")
        txtTimeIn.Text = time1

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        txtTimeIn.Text = TimeOfDay.ToString("h:mm:ss tt")

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub
End Class