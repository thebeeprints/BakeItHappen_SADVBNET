Imports System.IO
Imports FirebaseAdmin.Messaging

Public Class Cashier_Settings
    Dim firebase As New FireBaseApp()
    Dim imgconverter As New ImageBase64Converter()
    Dim ping As New Ping()
    Private Sub Cashier_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getEmployeeData()
    End Sub
    Public Sub getEmployeeData()
        If Not ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim response = firebase.client.Get($"BakeITHappen/Users/{SignIn.getID}")
            Dim data = response.ResultAs(Of UserDataModel)()

            Employee_Name.Text = $"{data.FirstName} {data.LastName}"
            Employee_ID.Text = data.ID

            If data.AccessType = "Administrator" Then
                Cashier_Role.Text = "Administrator"
            Else
                Cashier_Role.Text = "Employee"
            End If


            Dim getPicQry = firebase.client.Get($"BakeITHappen/Employee/Images/{SignIn.getID}")
            Dim picData = getPicQry.ResultAs(Of EmployeeImageDataModel)()
            CashierPicBox.Image = imgconverter.B64ToImg(picData.Image)
        Catch ex As Exception
            MessageBox.Show($"An error has occurred: {ex.Message}")
        End Try

    End Sub
End Class