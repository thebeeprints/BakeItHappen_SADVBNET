Imports FirebaseAdmin

Public Class AdminOrders
    Dim ping As New Ping()
    Dim firebase As New FireBaseApp()
    Dim productList As New List(Of OrderDataModel)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AdminOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim orders = firebase.client.Get("BakeITHappen/Orders/")
        Dim result = orders.ResultAs(Of Dictionary(Of String, Dictionary(Of String, List(Of OrderDataModel))))

        For Each dateOrders In result
            For Each transacOrders In dateOrders.Value
                productList.AddRange(transacOrders.Value)
            Next
        Next
        DataGridView1.DataSource = productList
    End Sub


End Class