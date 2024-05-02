Public Class Cashier_Interface
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Me.Hide()
        Cashier_Order.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub SettingdButton_Click(sender As Object, e As EventArgs) Handles SettingdButton.Click
        Me.Hide()
        Cashier_Settings.Show()
    End Sub
End Class