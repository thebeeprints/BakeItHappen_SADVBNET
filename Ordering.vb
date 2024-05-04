Imports System.Reflection.Emit
Imports FireSharp.Response

Public Class Ordering
    Dim imgConverter As New ImageBase64Converter()
    Dim firebase As New FireBaseApp()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NumericUpDown1.Value <= 0 Then
            MessageBox.Show("Please input a valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim existingRowIndex As Integer = -1

        For Each row As DataGridViewRow In Cashier_Order.DataGridView1.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = ID.Text Then
                existingRowIndex = row.Index
                Exit For
            End If
        Next
        If existingRowIndex <> -1 Then

            Dim currentQuantity As Integer = CInt(Cashier_Order.DataGridView1.Rows(existingRowIndex).Cells(3).Value)
            Dim currentTotalPrice As Decimal = CDec(Cashier_Order.DataGridView1.Rows(existingRowIndex).Cells(4).Value)
            Dim updatedQuantity As Integer = currentQuantity + NumericUpDown1.Value
            Dim updatedTotalPrice As Decimal = currentTotalPrice + NumericUpDown1.Value * Val(Price.Text)

            Cashier_Order.DataGridView1.Rows(existingRowIndex).Cells(3).Value = updatedQuantity
            Cashier_Order.DataGridView1.Rows(existingRowIndex).Cells(4).Value = updatedTotalPrice
        Else
            Cashier_Order.DataGridView1.Rows.Add(ID.Text, Product.Text, Price.Text, NumericUpDown1.Value, NumericUpDown1.Value * Val(Price.Text))
        End If
        Me.Close()

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value < 0 Then
            NumericUpDown1.Value = 0
        End If

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