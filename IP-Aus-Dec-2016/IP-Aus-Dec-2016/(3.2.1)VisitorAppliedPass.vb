Public Class VisitorAppliedPass

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnNext1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext1.Click

        TabControl1.SelectTab(1)

    End Sub

    Private Sub btnBack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack1.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub btnNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext2.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub btnBack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub btnNext3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext3.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub btnBack3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack3.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub btnGo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo1.Click
        TabControl1.SelectTab(0)
    End Sub
End Class