Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class SignIn
    Private ping As New Ping()
    Public isUserAdmin As Boolean = False
    Private user As UserDataModel
    Dim firebase As New FireBaseApp()

    Private Sub HideButton_Click_1(sender As Object, e As EventArgs) Handles HideButton.Click
        password_txt.UseSystemPasswordChar = Not password_txt.UseSystemPasswordChar
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged
        If password_txt.Text = "" Then
            HideButton.Visible = False
        Else
            HideButton.Visible = True
        End If
    End Sub


    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideButton.Visible = False
        username_txt.TabIndex = 0
        password_txt.TabIndex = 1
        Sign_In.TabIndex = 2
    End Sub

    Private Async Sub Sign_In_Click(sender As Object, e As EventArgs) Handles Sign_In.Click
        If ping.CheckForInternetConnection Then

            Try
                Dim loginData = firebase.GetData(Of UserDataModel)($"BakeITHappen/Users/")
                user = loginData(username_txt.Text.ToLower())
                If user.Password = password_txt.Text Then
                    Await Task.Delay(500)
                    If user.AccessType = "Administrator" Then
                        isUserAdmin = True
                        AdminInterface.Show()
                    Else
                        'Cashier_Settings.Show()
                        'DailyAttendance.Show()
                        Cursor = Cursors.WaitCursor
                        Await Task.Delay(1000)
                        Cursor = Cursors.Default
                        Cashier_Interface.Show()
                    End If
                    Me.Hide()
                Else
                    MessageBox.Show("Incorrect Username or Password")
                End If
            Catch ex As Exception
                MessageBox.Show($"Incorrect Username or Password")
                Exit Sub
            End Try

            username_txt.Text = "Username"
            password_txt.Text = "Password"
        Else
            MessageBox.Show("There is a problem with you internet connection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub


    Public Function getUser()
        If user Is Nothing Then
            Return "null"
        Else
            Return user.Username
        End If
    End Function
    Public Function getID()
        If user Is Nothing Then
            Return "null"
        Else
            Return user.ID
        End If
    End Function
    Public Function getFullName()
        If user Is Nothing Then
            Return "null"
        Else
            Return $"{user.FirstName} {user.LastName}"
        End If
    End Function

End Class