Imports FireSharp.Response
Imports System.ComponentModel
Public Class Stocks
    Dim ping As New Ping()
    Dim firebase As New FireBaseApp()
    Dim productsData As Dictionary(Of String, ProductDataModel)
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        AdminInterface.Show()
    End Sub
    Private Sub LoadProducts()
        productsData = LoadingForm.GetProductsData()
        If productsData Is Nothing Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For Each product In productsData
            DataGridView1.Rows.Add(product.Value.ProductName, product.Value.ProductPrice, product.Value.ProductPromoPrice, product.Value.ProductStock)
        Next
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BacktoUpdating_Click(sender As Object, e As EventArgs) Handles BacktoUpdating.Click

    End Sub
End Class