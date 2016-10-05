Imports System.Data.OleDb
Public Class SecurityVerification
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source ="
    Dim dataFile As String = "..\VisitorPass.accdb"
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        HouseOwnerProfile.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDGV()
    End Sub
    Public Sub LoadDGV()
        Dim sqlQuery As String = "SELECT * from Visitor_ApplyPass"
        Dim sqlCommand As New OleDbCommand
        Dim sqlAdapter As New OleDbDataAdapter
        Dim table As New DataTable



        connString = provider & dataFile
        conn.ConnectionString = connString
        conn.Open()
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(table)
        End With

        DataGridView1.Rows.Clear()
        For i = 0 To table.Rows.Count - 1
            With DataGridView1
                .Rows.Add(table.Rows(i)("Visitor_ID"), table.Rows(i)("Visit_Reason"), table.Rows(i)("Number_Of_Days"), table.Rows(i)("Vehicle_Number"), table.Rows(i)("Time"))
            End With
        Next
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim dr As OleDbDataReader
        connString = provider & dataFile
        conn.ConnectionString = connString
        Try
            If e.ColumnIndex = 5 Then
                conn.Open()
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                Dim i As Integer = row.Cells(0).Value
                Dim str As String
                str = "SELECT * FROM Visitor WHERE ID = " & i & ""
                Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    SecurityApproval.lblVisitorID.Text = dr("ID").ToString
                    SecurityApproval.lblFirstName.Text = dr("FirstName").ToString
                    SecurityApproval.lblLastName.Text = dr("LastName").ToString
                    SecurityApproval.lblGender.Text = dr("Gender").ToString
                    SecurityApproval.lblAddress.Text = dr("VisitorAddress").ToString
                End While
                conn.Close()
                SecurityApproval.Show()
            End If
        Catch o As Exception
            MsgBox(o.Message)
        End Try

    End Sub
End Class