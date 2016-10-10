Imports System.Data.OleDb

Public Class Security_CurrentVisitor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from CurrentVisitor"
        ' where [Visitor_ID]='" & TextBox1.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataSet

        Try
            con.Open()
            da.Fill(dt, "CurrrentVisitor")
            DataGridView1.DataSource = dt.Tables(0)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Security_CurrentVisitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class