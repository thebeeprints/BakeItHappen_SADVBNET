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
            Dim response = firebase.client.Get($"BakeITHappen/Users/{SignIn.getUser}")
            Dim data = response.ResultAs(Of UserDataModel)()

            Employee_Name.Text = $"{data.FullName}"
            Employee_ID.Text = data.ID

            If data.AccessType = "Administrator" Then
                Cashier_Role.Text = "Administrator"
            Else
                Cashier_Role.Text = "Employee"
            End If


            'Dim getPicQry = firebase.client.Get($"BakeITHappen/Employee/Images/{SignIn.getUser}")
            Dim getPicQry = firebase.client.Get($"BakeITHappen/Users/{SignIn.getUser}/Avatar")
            Dim picData = getPicQry.ResultAs(Of String)()
            CashierPicBox.Image = imgconverter.B64ToImg(picData)
        Catch ex As Exception
            MessageBox.Show($"An error has occurred: {ex.Message}")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cashier_Interface.Close()
        DailyAttendance.Show()
    End Sub

    Private Sub CashierPicBox_Click(sender As Object, e As EventArgs) Handles CashierPicBox.Click

    End Sub
End Class