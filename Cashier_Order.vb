Imports FireSharp.Response
Imports Microsoft.VisualBasic.Logging

Public Class Cashier_Order
    Dim firebase As New FireBaseApp()
    Dim imgconverter As New ImageBase64Converter()
    Dim productsData As Dictionary(Of String, ProductDataModel)
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




        'If PaymentEmbedded Then
        '    Panel1.Controls.Clear()
        'Else
        '    Dim paymentInstance As New Payment()
        '    paymentInstance.TopLevel = False
        '    paymentInstance.FormBorderStyle = FormBorderStyle.None
        '    paymentInstance.Dock = DockStyle.Fill
        '    Panel1.Controls.Add(paymentInstance)
        '    paymentInstance.Show()
        '    PaymentEmbedded = True
        'End If
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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
End Class