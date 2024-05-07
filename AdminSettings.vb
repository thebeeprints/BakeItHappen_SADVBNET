Public Class AdminSettings
    Dim firebase As New FireBaseApp()
    Dim ping As New Ping()
    Dim imgconverter As New ImageBase64Converter()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()

    End Sub

    Private Sub AdminSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getEmployeeData()
    End Sub


    Public Sub getEmployeeData()
        If Not Ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim response = firebase.client.Get($"BakeITHappen/Users/{SignIn.getUser}")
            Dim data = response.ResultAs(Of UserDataModel)()
            FullName_txt.Text += $" {data.FullName}"
            Role_txt.Text += $" {data.AccessType}"
            ID_txt.Text += $" {data.ID}"
            username_txt.Text += $" {data.Username}"

            'Dim getPicQry = firebase.client.Get($"BakeITHappen/Employee/Images/{SignIn.getUser}")
            Dim getPicQry = firebase.client.Get($"BakeITHappen/Users/{SignIn.getUser}/Avatar")
            Dim picData = getPicQry.ResultAs(Of String)()
            PictureBox1.Image = imgconverter.B64ToImg(picData)
        Catch ex As Exception
            MessageBox.Show($"An error has occurred: {ex.Message}")
        End Try

    End Sub
End Class