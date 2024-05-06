Public Class Manage
    Dim firebase As New FireBaseApp()
    Dim ping As New Ping()
    Private Sub RegisterAccount_Click(sender As Object, e As EventArgs) Handles RegisterAccount_btn.Click
        AdminInterface.Close()
        Me.Close()
        RegisterAccount.Show()


    End Sub

    Private Sub ViewAccounts_Click(sender As Object, e As EventArgs) Handles ViewAccounts_btn.Click
        AdminInterface.Hide()
        ViewAccounts.Show()
    End Sub

    Private Sub Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ping.CheckForInternetConnection Then
            MessageBox.Show("There is a problem with your internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim accountCount = firebase.GetData(Of UserDataModel)("BakeITHappen/Users/")
        TotalAccounts_txt.Text = $"{accountCount.Count}"
    End Sub
End Class