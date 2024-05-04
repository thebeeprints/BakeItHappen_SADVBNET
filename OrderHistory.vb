﻿Imports FireSharp.Response
Imports Newtonsoft.Json

Public Class OrderHistory
    Dim firebase As New FireBaseApp()
    Private previousTransactIDs As New List(Of String)
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub OrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        DataGridView1.ReadOnly = True
        DataGridView2.ReadOnly = True
        Dim transID As FirebaseResponse = firebase.client.Get($"BakeITHappen/Orders/{Cashier_Order.curDay}/")
        Dim result = transID.ResultAs(Of Dictionary(Of String, List(Of OrderDataModel)))()

        If result Is Nothing Then
            Exit Sub
        End If

        Dim transactIDs As List(Of String) = transID.ResultAs(Of Dictionary(Of String, List(Of OrderDataModel)))().Keys.ToList

        Dim newTransID = transactIDs.Except(previousTransactIDs).ToList()
        For Each transactID As String In newTransID
            DataGridView1.Rows.Add(transactID)
        Next
        previousTransactIDs = transactIDs


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim dataArray As List(Of OrderDataModel) = RetrieveList(Of OrderDataModel)($"BakeITHappen/Orders/{Cashier_Order.curDay}/{DataGridView1.CurrentRow.Cells(0).Value}/")
        DataGridView2.DataSource = dataArray
        DataGridView2.Columns("TransacID").HeaderText = "Transaction ID"
        DataGridView2.Columns("ProductID").HeaderText = "Product ID"
        DataGridView2.Columns("ProductName").HeaderText = "Product Name"
        DataGridView2.Columns("ProductPrice").HeaderText = "Product Price"
        DataGridView2.Columns("ProductQuantity").HeaderText = "Product Quantity"
        DataGridView2.Columns("ProductTotal").HeaderText = "Product Total"
    End Sub


    Public Function RetrieveList(Of T)(path As String) As List(Of T)
        Dim response = firebase.client.Get(path)

        If response.Body IsNot Nothing Then
            Dim data As List(Of T) = JsonConvert.DeserializeObject(Of List(Of T))(response.Body)
            If data IsNot Nothing Then
                Return data
            End If
        End If

        Return New List(Of T)()
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class