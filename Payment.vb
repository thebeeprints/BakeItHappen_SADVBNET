Public Class Payment
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Cashier_Order.TextBox1.Text
        TextBox1.ReadOnly = True


    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cashier_Order.ProceedTransaction()
    End Sub
End Class