﻿Public Class Stocks
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        AdminInterface.Show()
    End Sub
End Class