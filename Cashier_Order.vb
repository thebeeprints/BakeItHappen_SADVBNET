Imports FireSharp.Response

Public Class Cashier_Order
    Dim firebase As New FireBaseApp()
    Dim imgconverter As New ImageBase64Converter()

    Private Sub Cashier_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        FlowLayoutPanel1.UseWaitCursor = False
        TextBox1.TabIndex = 0
    End Sub
    Private Sub LoadProducts()
        Dim res As FirebaseResponse = firebase.client.Get("BakeITHappen/Products/")
        If res.Body <> "null" Then
            Dim data = res.ResultAs(Of Dictionary(Of String, ProductDataModel))()
            For Each product In data
                AddProductToFlowLayoutPanel(product.Value)
            Next
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
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

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
End Class