Imports System.Data.OleDb
Public Class Security
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim conn As OleDbConnection = New OleDbConnection



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="

        dataFile = "..\VisitorPass.accdb"
        connString = provider & dataFile
        conn.ConnectionString = connString

        If txtUser.Text = "" Then
            lblError1.Text = "You must enter an ID!"
            lblError2.Text = ""


        ElseIf txtPass.Text = "" Then
            lblError1.Text = ""
            lblError2.Text = "You must enter a Password!"
        Else
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Security WHERE SecID='" & txtUser.Text & "' AND [Pass]=" & txtPass.Text & "", conn)

            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Dim userFound As Boolean = False
            Dim FirstName As String = ""



            While dr.Read
                userFound = True
                FirstName = dr("FName").ToString
            End While


            If userFound = True Then
                SecurityControlPanel.Show()
                SecurityControlPanel.Label1.Text = "Welcome, " & FirstName
                Me.Close()
            Else
                MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
            End If
            conn.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        MainPage.Show()
        Me.Close()

    End Sub
End Class
