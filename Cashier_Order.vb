Imports System.ComponentModel
Imports FireSharp.Response
Imports Microsoft.VisualBasic.Logging

Public Class Cashier_Order
    Dim ping As New Ping()
    Dim firebase As New FireBaseApp()
    Dim imgconverter As New ImageBase64Converter()
    Dim productsData As Dictionary(Of String, ProductDataModel)
    Public curDay As String = $"{Now.Month}{Now.Day:D2}{Now.Year}"


    Public ProdMsg As String
    Public ProdDesign As String
    Private Sub Cashier_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productsData = LoadingForm.GetProductsData()
        If productsData Is Nothing Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        LoadProducts()
        Cursor = Cursors.Default
        Search_txt.TabIndex = 0
    End Sub
    Private Sub LoadProducts()
        For Each product In productsData
            AddProductToFlowLayoutPanel(product.Value)
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub AddProductToFlowLayoutPanel(product As ProductDataModel)
        Dim pictureBox As New PictureBox With {
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Width = 200,
            .Height = 250,
            .Cursor = Cursors.Hand,
            .Tag = product
        }
        Dim productPrice As New Label With {
            .Text = product.ProductPrice.ToString(),
            .BackColor = ColorTranslator.FromHtml("#602A0F"),
            .Dock = DockStyle.Bottom,
            .ForeColor = Color.White,
            .Font = New Font("Arial", 12, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter
        }
        Dim productName As New Label With {
            .Width = pictureBox.Width, '200
            .TextAlign = ContentAlignment.MiddleCenter,
            .Text = product.ProductName,
            .BackColor = ColorTranslator.FromHtml("#602A0F"),
            .ForeColor = Color.White,
            .Font = New Font("Arial", 12, FontStyle.Bold)
        }

        Dim myImg As Image = imgconverter.B64ToImg(product.ProductImage)
        pictureBox.Image = myImg
        pictureBox.Controls.Add(productPrice)
        pictureBox.Controls.Add(productName)
        FlowLayoutPanel1.Controls.Add(pictureBox)
        AddHandler pictureBox.Click, AddressOf PictureBox_Click


    End Sub
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim productData As ProductDataModel = DirectCast(clickedPictureBox.Tag, ProductDataModel)
        Ordering.GetProductData(productData)
        Ordering.Show()

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Cursor = Cursors.WaitCursor
        FlowLayoutPanel1.Controls.Clear()

        Dim searchText As String = Search_txt.Text.ToLower()
        Dim filteredProducts = productsData.Where(Function(p) p.Value.ProductName.ToLower().Contains(searchText))

        For Each product In filteredProducts
            AddProductToFlowLayoutPanel(product.Value)
        Next

        If Search_txt.Text = "" Then
            FlowLayoutPanel1.Controls.Clear()
            LoadProducts()
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim sortedProducts
        Dim SortMethod = ComboBox1.SelectedItem.ToString()
        If SortMethod = "Alphabetical" Then
            sortedProducts = productsData.OrderBy(Function(p) p.Value.ProductName)
            ShowProducts(sortedProducts)
        End If
        If SortMethod = "Price Low" Then
            sortedProducts = productsData.OrderBy(Function(p) p.Value.ProductPrice)
            ShowProducts(sortedProducts)
        End If
        If SortMethod = "Price High" Then
            sortedProducts = productsData.OrderByDescending(Function(p) p.Value.ProductPrice)
            ShowProducts(sortedProducts)
        End If
    End Sub

    Private Sub ShowProducts(sortedProduct As IOrderedEnumerable(Of KeyValuePair(Of String, ProductDataModel)))
        FlowLayoutPanel1.Controls.Clear()
        Cursor = Cursors.WaitCursor
        For Each product In sortedProduct
            AddProductToFlowLayoutPanel(product.Value)
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        DataGridView1.Rows.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub finish_btn_Click(sender As Object, e As EventArgs) Handles finish_btn.Click
        Payment.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = True
    End Sub


    Public Sub ProceedTransaction()
        If ping.CheckForInternetConnection() Then
            Dim totalDailySale As Integer = 0
            Dim transaction As String = $"{Now.Day}{Now.Hour}{Now.Minute}{Now.Second}"
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim order As New OrderDataModel With {
                .TransacID = transaction,
                .ProductID = row.Cells(0).Value.ToString(),
                .ProductName = row.Cells(1).Value.ToString(),
                .ProductPrice = row.Cells(2).Value.ToString(),
                .ProductQuantity = row.Cells(3).Value.ToString(),
                .ProdutDesign = ProdDesign,
                .ProductMessage = ProdMsg,
                .ProductTotal = row.Cells(4).Value.ToString()
            }
                firebase.client.Set($"BakeITHappen/Orders/{curDay}/{transaction}/{row.Index}", order)
            Next
            Payment.SetTransacID(transaction)
            Try
                Dim response As FirebaseResponse = firebase.client.Get($"BakeITHappen/Sales/Daily Sales/{curDay}/")
                If response.Body <> "null" Then
                    totalDailySale = response.ResultAs(Of Integer)()
                End If
            Catch ex As Exception
                Return
            End Try

            For Each row As DataGridViewRow In DataGridView1.Rows
                totalDailySale += CInt(row.Cells(4).Value)
            Next
            firebase.client.Set(Of Integer)($"BakeITHappen/Sales/Daily Sales/{curDay}/", totalDailySale)


            Dim overAllSaleData As Decimal = firebase.client.Get($"BakeITHappen/Sales/Overall Sales/").ResultAs(Of Integer)()
            If Val(TextBox1.Text) > 0 Then
                overAllSaleData += Val(TextBox1.Text)
                firebase.client.Set(Of Integer)($"BakeITHappen/Sales/Overall Sales/", overAllSaleData)
            End If

        Else
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles Del_btn.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            total += CDec(row.Cells(4).Value)
        Next

        TextBox1.Text = total.ToString()

    End Sub


    Public Sub DecreaseProductStock()
        If Not ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim response As FirebaseResponse = firebase.client.Get($"BakeITHappen/Products/{row.Cells(0).Value}/ProductStock")
                Dim currentStock As Integer = response.ResultAs(Of Integer)()
                Dim updatedStock As Integer = currentStock - row.Cells(3).Value
                Dim productID As String = row.Cells(0).Value
                Dim quantity As Integer = CInt(row.Cells(3).Value)
                If productsData.ContainsKey(productID) Then
                    Dim product As ProductDataModel = productsData(productID)
                    product.ProductStock = updatedStock
                End If
                firebase.client.Set($"BakeITHappen/Products/{row.Cells(0).Value}/ProductStock", updatedStock)
            Next
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Public Function getDatainDataGrid()
        Return DataGridView1.DataSource
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_txt.Text = DateTime.Now.ToString("hh:mm:ss tt")
        date_txt.Text = DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub Cashier_Order_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Cashier_Interface.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class