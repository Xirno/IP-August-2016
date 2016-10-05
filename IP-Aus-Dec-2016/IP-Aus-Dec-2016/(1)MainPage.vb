Public Class MainPage


    Private Sub btnHouseOwner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHouseOwner.Click


        HouseOwnerLogin.Show()
        Me.Hide()


    End Sub

    Private Sub btnSecurity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecurity.Click

        Security.Show()

        Me.Hide()

    End Sub

    Private Sub MainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnVisitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisitor.Click

        Visitor.Show()
        Me.Hide()

    End Sub
End Class