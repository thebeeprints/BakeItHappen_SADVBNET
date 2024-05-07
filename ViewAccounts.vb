Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports FirebaseAdmin.Auth

Public Class ViewAccounts
    Dim firebase As New FireBaseApp()
    Dim ping As New Ping()
    Dim accountData
    Private Sub ViewAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a probelem with your internet connection. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        LoadAccounts()
        no_of_acc.Text += $"{accountData.Count}"
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DataGridView1.Rows.Clear()
        LoadAccounts(Search_txt.Text)
    End Sub

    Private Sub LoadAccounts(Optional ByVal searchText As String = "")
        accountData = firebase.GetData(Of UserDataModel)("BakeITHappen/Users/")
        If accountData Is Nothing Then
            MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        For Each kvp As KeyValuePair(Of String, UserDataModel) In accountData
            Dim data = kvp.Value

            If data.Username.Contains(searchText) OrElse data.ID.ToString().Contains(searchText) Then
                DataGridView1.Rows.Add(data.ID, data.Username, data.FullName, data.Password, data.AccessType)
            End If
        Next
        Search_txt.Clear()
    End Sub
    Private Sub Search_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search_txt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            DataGridView1.Rows.Clear()
            LoadAccounts(Search_txt.Text)
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        AdminInterface.Show()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        DataGridView1.Rows.Clear()
        For Each kvp As KeyValuePair(Of String, UserDataModel) In accountData
            Dim data = kvp.Value
            If ComboBox1.Text = data.AccessType Or ComboBox1.Text = "All" Then
                DataGridView1.Rows.Add(data.ID, data.Username, data.FullName, data.Password, data.AccessType)
            End If
        Next
    End Sub
End Class