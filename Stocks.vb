Imports FireSharp.Response
Imports System.ComponentModel
Public Class Stocks
    Dim ping As New Ping()
    Dim firebase As New FireBaseApp()
    Dim productsData As Dictionary(Of String, ProductDataModel)
    Dim imgconverter As New ImageBase64Converter()
    Private productID As String
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddProducts_btn.Visible = False
        fieldControl(False)
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
            DataGridView1.Rows.Add(product.Value.ID, product.Value.ProductName, product.Value.ProductStock)
        Next
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BacktoUpdating_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub fieldControl(cmd As Boolean)
        PictureBox1.Visible = cmd
        stock_lbl.Visible = cmd
        stockinput_txt.Visible = cmd
        update_btn.Visible = cmd
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        fieldControl(True)
        productID = DataGridView1.CurrentRow.Cells(0).Value
        Dim productPic = imgconverter.B64ToImg(productsData(productID).ProductImage)
        PictureBox1.Controls.Clear()
        Dim productName As New Label With {
             .Width = PictureBox1.Width,
            .Text = productsData(productID).ProductName,
            .BackColor = ColorTranslator.FromHtml("#602A0F"),
            .ForeColor = Color.White,
            .Font = New Font("Arial", 12, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleLeft
        }
        PictureBox1.Controls.Add(productName)
        PictureBox1.Image = productPic

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        If Not ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim updateStock = firebase.client.Set(Of Integer)($"BakeITHappen/Products/{productID}/ProductStock", Integer.Parse(stockinput_txt.Text))
        productsData(productID).ProductStock = Integer.Parse(stockinput_txt.Text)
        If updateStock.StatusCode = Net.HttpStatusCode.OK Then
            MessageBox.Show("Stock updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.Rows.Clear()
            LoadProducts()
        Else
            MessageBox.Show("An error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Sub ShowProducts(sortedProduct As IOrderedEnumerable(Of KeyValuePair(Of String, ProductDataModel)))
        DataGridView1.Rows.Clear()
        Cursor = Cursors.WaitCursor
        For Each product In sortedProduct
            DataGridView1.Rows.Add(product.Value.ID, product.Value.ProductName, product.Value.ProductStock)
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sortedProducts
        Dim SortMethod = ComboBox1.SelectedItem.ToString()
        If SortMethod = "ID" Then
            sortedProducts = productsData.OrderBy(Function(p) p.Value.ID)
            ShowProducts(sortedProducts)
        End If
        If SortMethod = "Alphabetical" Then
            sortedProducts = productsData.OrderBy(Function(p) p.Value.ProductName)
            ShowProducts(sortedProducts)
        End If
        If SortMethod = "Stock Low" Then
            sortedProducts = productsData.OrderBy(Function(p) p.Value.ProductStock)
            ShowProducts(sortedProducts)
        End If
        If SortMethod = "Stock High" Then
            sortedProducts = productsData.OrderByDescending(Function(p) p.Value.ProductStock)
            ShowProducts(sortedProducts)
        End If
    End Sub
End Class