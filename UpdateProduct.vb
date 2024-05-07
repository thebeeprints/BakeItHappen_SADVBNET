Imports FireSharp.Response
Imports System.ComponentModel

Public Class UpdateProduct
    Dim ping As New Ping()
    Dim firebase As New FireBaseApp()
    Dim imgconverter As New ImageBase64Converter()
    Dim productsData As Dictionary(Of String, ProductDataModel)
    Dim curProduct As New ProductDataModel()
    Dim curDesign As New List(Of String)
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles conf_btn.Click
        If Not ping.CheckForInternetConnection Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Try
            curDesign = firebase.client.Get($"BakeITHappen/Product Design/{curProduct.ID}").ResultAs(Of List(Of String))()

            curProduct.ProductPrice = Reg_New_Price.Text
            curProduct.ProductPromoPrice = Promo_New_Price.Text
            curDesign.Add(Reg_New_Des.Text)
            Dim updateData = firebase.client.Update($"BakeITHappen/Products/{curProduct.ID}", curProduct).ResultAs(Of ProductDataModel)()
            Dim updateDesign = firebase.client.Set($"BakeITHappen/Product Design/{curProduct.ID}", curDesign)
            MessageBox.Show($"{curProduct.ProductName} info update success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show($"{ex.Message}")
        End Try
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).Clear()
            If TypeOf ctrl Is ComboBox Then CType(ctrl, ComboBox).Items.Clear()
        Next

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        AdminInterface.Show()

    End Sub

    Private Sub UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ping.CheckForInternetConnection Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        productsData = LoadingForm.GetProductsData()
        If productsData Is Nothing Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        LoadProducts()

    End Sub

    Private Sub LoadProducts()
        For Each product In productsData
            AddProductToFlowLayoutPanel(product.Value)
        Next
        Label3.Text = $"Total Products: {productsData.Count}"
        Cursor = Cursors.Default
    End Sub
    Private Sub AddProductToFlowLayoutPanel(product As ProductDataModel)
        Dim pictureBox As New PictureBox With {
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Width = 230,
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
            .Width = pictureBox.Width,
            .Text = product.ProductName,
            .BackColor = ColorTranslator.FromHtml("#602A0F"),
            .ForeColor = Color.White,
            .Font = New Font("Arial", 12, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter
        }

        Dim myImg As Image = imgconverter.B64ToImg(product.ProductImage)
        pictureBox.Image = myImg
        pictureBox.Controls.Add(productPrice)
        pictureBox.Controls.Add(productName)
        FlowLayoutPanel1.Controls.Add(pictureBox)
        AddHandler pictureBox.Click, AddressOf PictureBox_Click
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)
        Dim productData As ProductDataModel = DirectCast(clickedPictureBox.Tag, ProductDataModel)
        curProduct = productData
        loadProdInfo()
        loadProdDesign()
    End Sub
    Private Sub loadProdInfo()
        ProdName.Text = curProduct.ProductName
        ProdID.Text = curProduct.ID
        Promo_Cur_Price.Text = curProduct.ProductPromoPrice
        Reg_Cur_Price.Text = curProduct.ProductPrice
    End Sub
    Private Sub loadProdDesign()
        If ping.CheckForInternetConnection() Then
            Dim design = firebase.client.Get($"BakeITHappen/Product Design/{curProduct.ID}")
            Dim result = design.ResultAs(Of List(Of String))()
            Reg_Cur_Des.Items.Clear()
            Reg_Cur_Des.Items.AddRange(result.ToArray())
            Reg_Cur_Des.SelectedIndex = 0
            Promo_Cur_Des.Items.Clear()
            Promo_Cur_Des.Items.AddRange(result.ToArray())
            Promo_Cur_Des.SelectedIndex = 0
        Else
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
End Class