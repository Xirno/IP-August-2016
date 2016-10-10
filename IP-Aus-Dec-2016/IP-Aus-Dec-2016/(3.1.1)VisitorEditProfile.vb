Imports System.Data.OleDb
Imports System.IO

Public Class VisitorEditProfile

    Private Sub VisitorEditProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection
        Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        con = New OleDbConnection(str)
        Dim sql As String = "select * from visitor where AccountName='" & txtName.Text & "'"
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        con.Open()
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblID2.Text = dr("ID").ToString()
            txtPassword.Text = dr("Password").ToString()
            txtFirstName.Text = dr("FirstName").ToString()
            txtLastName.Text = dr("LastName").ToString()
            txtIC.Text = dr("IC").ToString()
            txtMobileNO.Text = dr("MobileNo").ToString()
            txtDateOfBirth.Text = dr("DateOfBirth").ToString()
            txtVisitorAddress.Text = dr("VisitorAddress").ToString()
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        If txtPassword.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtFirstName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtFirstName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtLastName.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtMobileNO.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtDateOfBirth.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtVisitorAddress.Text.ToString() = "" Then
            MsgBox("do not empty")
        ElseIf txtIC.Text.ToString() = "" Then
            MsgBox("do not empty")
       
        Else
            Dim gender As String
            If RadioButton1.Checked Then
                gender = "Male"
            Else
                gender = "Female"
            End If


            Dim fsr As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fsr)
            Dim imgbuffer(fsr.Length) As Byte
            br.Read(imgbuffer, 0, fsr.Length)
            fsr.Close()
            Using con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb")
                con.Open()
                Dim sql As String
                sql = "Update Visitor set AccountName='" & txtName.Text & "',[Password]='" & txtPassword.Text & "',FirstName='" & txtFirstName.Text & "',LastName='" & txtLastName.Text & "',[IC]='" & txtIC.Text & "',Gender='" & gender & "',[MobileNo]='" & txtMobileNO.Text & "',[DateOfBirth]='" & txtDateOfBirth.Text & "',VisitorAddress='" & txtVisitorAddress.Text & "',[Image]= @imgfile  where [ID]=" & lblID2.Text & ""

                Using cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@imgfile", imgbuffer)

                    cmd.ExecuteNonQuery()
                    'cmd.Dispose()
                    MsgBox("profile is updated")
                    con.Close()

                End Using
            End Using

            Me.Close()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub

    Private Sub VisitorEditProfile_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim obj1 As New VisitorProfile
        obj1.StringPass = txtName.Text
        obj1.Show()
        'e.Cancel = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) |*.*"

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        ' If OpenFileDialog1.FileName <> Nothing Or OpenFileDialog1.FileName <> "" Then

        '    txtImageNme.Text = OpenFileDialog1.FileName.Substring( _
        '   OpenFileDialog1.FileName.LastIndexOf("\") + 1, _
        '  '  '   (OpenFileDialog1.FileName.IndexOf(".", 0) - (OpenFileDialog1.FileName).LastIndexOf("\") + 1))

        '  End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click



        '   Try
        ''      Dim cmd As New OleDbCommand
        ''      Dim Sql As String
        ' Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\VisitorPass.accdb"
        ''     con = New OleDbConnection(str)
        ''
        ''     Dim fsr As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
        '      Dim br As New BinaryReader(fsr)
        ''     Dim imgbuffer(fsr.Length) As Byte
        '     con.Open()
        ''     br.Read(imgbuffer, 0, fsr.Length)
        ''fsr.Close()

        '  '   Sql = "insert into visitor (ImageName, [Image]) values (@imgname,@imgfile) "
        '     cmd.CommandText = Sql
        '     cmd.Connection = con
        '    '  cmd.Parameters.AddWithValue("@imagename", txtImageNme.Text)
        ''  cmd.Parameters.AddWithValue("@imgfile", imgbuffer)
        '    cmd.ExecuteNonQuery()
        '   '   cmd.Dispose()
        '   MsgBox("picture is Saved ")

        '  Catch ex As Exception

        '    MessageBox.Show(ex.Message)

        ' End Try

    End Sub
End Class