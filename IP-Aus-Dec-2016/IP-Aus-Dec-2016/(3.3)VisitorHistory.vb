Imports System.Data.OleDb

Public Class VisitorHistory

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click



        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)

        'where Visitor_ID='" & txtSearch.Text.Trim() & "'"
        '[" & ComboBox1.Text & "]
        'Dim dr As OleDbDataReader
        ds.Tables.Add(dt)
        Dim da As OleDbDataAdapter   
        con.Open()

        Try
            da = New OleDbDataAdapter("select * from VisitorPassHistory where Visitor_ID like '%" & lblvisitorID.Text & "%'", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub VisitorHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txtSearch.Clear()
        txtVisitorName.Clear()
        txtGatePass.Clear()
        txtVisitAddress.Clear()
        txtTimeIn.Clear()
        txtTimeOut.Clear()
        txtVisitDate.Clear()
        txtApproved.Clear()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtVisitorName.Text = row.Cells("Visitor_Name").Value.ToString
            txtVisitAddress.Text = row.Cells("Visit_Address").Value.ToString
            txtGatePass.Text = row.Cells("GatePassNo").Value.ToString
            txtTimeIn.Text = row.Cells("Time_In").Value.ToString
            txtTimeOut.Text = row.Cells("Time_Out").Value.ToString
            txtVisitDate.Text = row.Cells("Visit_Date").Value.ToString
            txtApproved.Text = row.Cells("Approved_By").Value.ToString


        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub lblvisitorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvisitorID.Click

    End Sub
End Class