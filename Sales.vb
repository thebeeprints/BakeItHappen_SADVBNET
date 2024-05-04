Public Class Sales
    Dim firebase As New FireBaseApp()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DailySaleValue.Text = firebase.client.Get($"BakeITHappen/Sales/Daily Sales/{Cashier_Order.curDay}/").ResultAs(Of String)
        OverallSaleValue.Text = firebase.client.Get($"BakeITHappen/Sales/Overall Sales/").ResultAs(Of String)
    End Sub
End Class