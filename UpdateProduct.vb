Public Class UpdateProduct
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.HorizontalScroll.Visible = False
    End Sub
End Class