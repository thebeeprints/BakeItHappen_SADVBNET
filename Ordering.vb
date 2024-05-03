Imports System.Reflection.Emit

Public Class Ordering
    Dim imgConverter As New ImageBase64Converter()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        If NumericUpDown1.Value < 0 Then
            NumericUpDown1.Value = 0
        End If
        'ErrorProvider1.SetError(NumericUpDown1, String.Empty)
        'Label1.Text = holdstockML - NumericUpDown1.Value

    End Sub

    Private Sub Ordering_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GetProductData(T As ProductDataModel)
        ID.Text = T.ID
        Product.Text = T.ProductName
        Stock.Text = T.ProductStock
        Price.Text = T.ProductPrice
        ProductImage.Image = imgConverter.B64ToImg(T.ProductImage)
        ProductImage.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Price.KeyPress
        e.Handled = True
    End Sub

    Private Sub Ordering_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ID.Clear()
        Product.Text = Nothing
        Stock.Text = Nothing
        Price.Text = Nothing
        ProductImage.Image = Nothing
    End Sub
End Class