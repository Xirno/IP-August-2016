Public Class FindPassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Then

            MsgBox("Please Select Your Role")
        ElseIf txtAccountName1.Text = "" Then

            MsgBox("Please Write Your Account Name")

        Else
            FoundPassword.lblAccountName.Text = txtAccountName1.Text
            FoundPassword.lblRole.Text = ComboBox1.Text
            FoundPassword.Show()

        End If

        txtAccountName1.Text = ""

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
End Class