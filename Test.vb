Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response

Public Class Test
    Dim client As IFirebaseClient
    Dim imgconverter As New ImageBase64Converter()
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim config As New FirebaseConfig() With {
            .AuthSecret = "",
            .BasePath = "https://bakeithappen-db-default-rtdb.asia-southeast1.firebasedatabase.app/"
            }
        Try
            client = New FireSharp.FirebaseClient(config)
        Catch ex As Exception
            MessageBox.Show("There is a problem with your internet connection. Please try again.")
        End Try

        LoadProducts()
    End Sub


    Private Sub LoadProducts()
        Dim response As FirebaseResponse = client.Get("BakeITHappen/Products/")
        If response.Body <> "null" Then
            Dim data = response.ResultAs(Of Dictionary(Of String, ProductDataModel))()
            For Each product In data
                AddProductToFlowLayoutPanel(product.Value)
            Next
        End If
    End Sub

    Private Sub AddProductToFlowLayoutPanel(product As ProductDataModel)
        Dim panel As New Panel With {
            .BorderStyle = BorderStyle.FixedSingle,
            .Width = 150,
            .Height = 200
        }

        '' add product name
        'Dim namelabel As New Label With {
        '    .Text = product.ProductName
        '}


        '' Add product price
        'Dim priceLabel As New Label With {
        '    .Text = product.ProductPrice.ToString(),
        '    .Location = New Point(10, 40)
        '}

        '' Add product image (assuming image is stored as URL)
        Dim pictureBox As New PictureBox With {
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Width = 150,
            .Height = 100
        }
        ''.Location = New Point(-20, 0)
        Dim myImg As Image = imgconverter.B64ToImg(product.ProductImage)
        pictureBox.Image = myImg
        'pictureBox.Controls.Add(namelabel)
        panel.Controls.Add(pictureBox)

        'FlowLayoutPanel1.Controls.Add(pictureBox)
        FlowLayoutPanel1.Controls.Add(panel)
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Stocks.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateProduct.Show()
        Me.Hide()
    End Sub
End Class