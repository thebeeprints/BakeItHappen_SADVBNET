Imports FireSharp.Response
Imports Microsoft.VisualBasic.Logging

Public Class Cashier_Order
    Dim firebase As New FireBaseApp()
    Dim imgconverter As New ImageBase64Converter()
    Dim productsData As Dictionary(Of String, ProductDataModel)
    Dim orderList As New List(Of OrderDataModel)()
    Public curDay As String = $"{Now.Month}{Now.Day:D2}{Now.Year}"
    Private Sub Cashier_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.Default
        LoadProducts()
        FlowLayoutPanel1.UseWaitCursor = False
        Search_txt.TabIndex = 0
    End Sub
    Private Sub LoadProducts()
        Dim res As FirebaseResponse = firebase.client.Get("BakeITHappen/Products/")
        If res.Body <> "null" Then
            productsData = res.ResultAs(Of Dictionary(Of String, ProductDataModel))()
            For Each product In productsData
                AddProductToFlowLayoutPanel(product.Value)
            Next
            Cursor = Cursors.Default
        End If
    End Sub




    Private Sub AddProductToFlowLayoutPanel(product As ProductDataModel)
        Dim pictureBox As New PictureBox With {
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Width = 180,
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
            .Width = 180,
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
        Ordering.Show()
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim productData As ProductDataModel = DirectCast(clickedPictureBox.Tag, ProductDataModel)
        Ordering.GetProductData(productData)
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
            SortProducts(sortedProducts)
        End If
        If SortMethod = "Price Low" Then
            sortedProducts = productsData.OrderBy(Function(p) p.Value.ProductPrice)
            SortProducts(sortedProducts)
        End If
        If SortMethod = "Price High" Then
            sortedProducts = productsData.OrderByDescending(Function(p) p.Value.ProductPrice)
            SortProducts(sortedProducts)
        End If
    End Sub

    Private Sub SortProducts(sortedProduct As IOrderedEnumerable(Of KeyValuePair(Of String, ProductDataModel)))
        FlowLayoutPanel1.Controls.Clear()
        Cursor = Cursors.WaitCursor
        For Each product In sortedProduct
            AddProductToFlowLayoutPanel(product.Value)
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        DataGridView1.Rows.Clear()

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
        Dim totalDailySale As Integer = 0
        Dim transaction As String = $"{Now.Day}{Now.Hour}{Now.Minute}{Now.Second}"
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim order As New OrderDataModel With {
                .TransacID = transaction,
                .ProductID = row.Cells(0).Value.ToString(),
                .ProductName = row.Cells(1).Value.ToString(),
                .ProductPrice = row.Cells(2).Value.ToString(),
                .ProductQuantity = row.Cells(3).Value.ToString(),
                .ProductTotal = row.Cells(4).Value.ToString()
            }
            firebase.client.Set($"BakeITHappen/Orders/{curDay}/{transaction}/{row.Index}", order)
        Next
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
        If totalDailySale > 0 Then
            Dim overAllSale As Integer = 0
            overAllSale += totalDailySale
            firebase.client.Set(Of Integer)($"BakeITHappen/Sales/Overall Sales/", overAllSale)
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
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim response As FirebaseResponse = firebase.client.Get($"BakeITHappen/Products/{row.Cells(0).Value}/ProductStock")
                Dim currentStock As Integer = response.ResultAs(Of Integer)()
                Dim updatedStock As Integer = currentStock - row.Cells(3).Value
                firebase.client.Set($"BakeITHappen/Products/{row.Cells(0).Value}/ProductStock", updatedStock)
            Next
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub
End Class