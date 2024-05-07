Imports System.ComponentModel
Imports System.Reflection.Emit
Imports FireSharp.Response
Public Class LoadingForm
    Dim i As Integer
    Dim firebase As New FireBaseApp()
    Dim ping As New Ping()
    Dim productsData As Dictionary(Of String, ProductDataModel)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label1.Text = "Process " & ProgressBar1.Value & "% completed..."
        If ProgressBar1.Value = 80 Then
            Timer1.Stop()
            LoadProducts()
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            SignIn.Show()
            Me.Hide()
        End If
    End Sub

    Public Sub LoadProducts()
        If Not ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim res As FirebaseResponse = firebase.client.Get("BakeITHappen/Products/")
            If res.Body <> "null" Then
                productsData = res.ResultAs(Of Dictionary(Of String, ProductDataModel))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Timer1.Start()
    End Sub

    Public Function GetProductsData() As Dictionary(Of String, ProductDataModel)
        Return productsData
    End Function

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class