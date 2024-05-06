Public Class AdminDashboard
    Private Sub Orders_Click(sender As Object, e As EventArgs) Handles Orders_btn.Click
        OrderHistory.Show()
        AdminInterface.Hide()

    End Sub

    Private Sub Stock_Click(sender As Object, e As EventArgs) Handles Stock_btn.Click
        Stocks.Show()
        AdminInterface.Hide()
    End Sub

    Private Sub UpdateProduct_Click(sender As Object, e As EventArgs) Handles UpdateProduct_btn.Click
        UpdateProduct.Show()
        AdminInterface.Hide()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ViewSales_btn_Click(sender As Object, e As EventArgs) Handles ViewSales_btn.Click
        Sales.Show()
        AdminInterface.Hide()
    End Sub
End Class