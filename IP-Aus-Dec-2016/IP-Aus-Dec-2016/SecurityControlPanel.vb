Public Class SecurityControlPanel

    Private Sub lblLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLog.Click
        Security.Show()
        Security.txtUser.Clear()
        Security.txtPass.Clear()
        Me.Close()
    End Sub

    Private Sub BtnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVer.Click
        SecurityVerification.Show()
        Me.Hide()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        VisitorApplyPass.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
    End Sub
End Class