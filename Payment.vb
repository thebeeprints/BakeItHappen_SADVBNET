Imports FireSharp.Response

Public Class Payment
    Dim firebase As New FireBaseApp()
    Private TransacID As String
    Dim ping As New Ping()
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Total_txt.Text = Cashier_Order.TextBox1.Text
        'TextBox1.Text = "100"
        Total_txt.ReadOnly = True

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(cash_txt.Text) <= Val(Total_txt.Text) Then
            MessageBox.Show("Insufficient Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            change_txt.Text = Val(cash_txt.Text) - Val(Total_txt.Text)
            Await Task.Delay(500)
            Cashier_Order.DecreaseProductStock()
            Cashier_Order.ProceedTransaction()
            saveTransac()
            PrintReceipt.Show()
            Cashier_Order.DataGridView1.Rows.Clear()
            Cashier_Order.TextBox1.Clear()
            Me.Close()
        End If

    End Sub

    Private Sub saveTransac()
        If ping.CheckForInternetConnection() Then
            Dim payment As New TransactionDataModel() With {
                .TransactionID = TransacID,
                .TransactionDate = Now.ToString("MM/dd/yyyy"),
                .TransactionTime = Now.ToString("HH:mm"),
                .TransactionTotal = Total_txt.Text,
                .TransactionPayment = cash_txt.Text,
                .TransactionChange = change_txt.Text
                }
            Dim transac As FirebaseResponse = firebase.client.Set($"BakeITHappen/Transactions/{TransacID}", payment)
        Else
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Public Sub SetTransacID(id As String)
        TransacID = id
    End Sub

    Public Function GetTransacID()
        Return TransacID
    End Function
End Class