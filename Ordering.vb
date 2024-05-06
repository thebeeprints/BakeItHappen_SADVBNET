Imports System.Reflection.Emit
Imports System.Xml
Imports FireSharp.Response

Public Class Ordering
    Dim ping As New Ping()
    Dim imgConverter As New ImageBase64Converter()
    Dim firebase As New FireBaseApp()
    Private reg As Decimal
    Private promo As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'VALIDATIONS
        If Stock.Text <= 0 Then
            MessageBox.Show("Product is out of stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If NumericUpDown1.Value > Stock.Text Then
            MessageBox.Show("Insufficient stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If NumericUpDown1.Value <= 0 Then
            MessageBox.Show("Please input a valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(Price.Text) Then
            MessageBox.Show("Please choose category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(DesignBox.Text) Then
            MessageBox.Show("Please choose design", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'VALIDATIONS


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
            PrintReceipt.DataGridView1.Rows(existingRowIndex).Cells(2).Value = updatedQuantity
            PrintReceipt.DataGridView1.Rows(existingRowIndex).Cells(3).Value = updatedTotalPrice

        Else
            Cashier_Order.DataGridView1.Rows.Add(ID.Text, Product.Text, Price.Text, NumericUpDown1.Value, NumericUpDown1.Value * Val(Price.Text))
            Cashier_Interface.LoadCashierOrder()
            PrintReceipt.DataGridView1.Rows.Add(Product.Text, Price.Text, NumericUpDown1.Value, NumericUpDown1.Value * Val(Price.Text))
        End If

        Cashier_Order.ProdMsg = ProdMsg_txt.Text
        Cashier_Order.ProdDesign = DesignBox.Text
        Me.Close()

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value < 0 Then
            NumericUpDown1.Value = 0
        End If

    End Sub

    Private Sub Ordering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Value = 1
        loadProdDesign()
    End Sub
    Private Sub loadProdDesign()
        If ping.CheckForInternetConnection() Then
            Dim design = firebase.client.Get($"BakeITHappen/Product Design/{ID.Text}")
            Dim result = design.ResultAs(Of List(Of String))()
            DesignBox.Items.Clear()
            DesignBox.Items.AddRange(result.ToArray())
        Else
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Sub GetProductData(T As ProductDataModel)
        ID.Text = T.ID
        Product.Text = T.ProductName
        Stock.Text = T.ProductStock
        reg = T.ProductPrice
        promo = T.ProductPromoPrice
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

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.SelectedItem = "Promo" Then
            Price.Text = promo
        ElseIf ComboBox1.SelectedItem = "Regular" Then
            Price.Text = reg
        End If
    End Sub
End Class