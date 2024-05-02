Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class SignIn
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

    End Sub

    Private Sub Sign_In_Click(sender As Object, e As EventArgs) Handles Sign_In.Click
        Try
            Dim loginData = firebase.GetData(Of UserDataModel)($"BakeITHappen/Users/")


            user = loginData(username_txt.Text.ToLower())
            If user.Password = password_txt.Text Then
                Threading.Thread.Sleep(1000)
                If user.AccessType = "Administrator" Then
                    isUserAdmin = True
                    AdminInterface.Show()
                Else
                    Cashier_Settings.Show()
                    'DailyAttendance.Show()

                    'Cashier_Interface.Show()
                End If
                Me.Hide()
            Else
                MessageBox.Show("Incorrect Username or Password")
            End If
        Catch ex As Exception
            MessageBox.Show($"Incorrect Username or Password")
            Exit Sub
        End Try


    End Sub


    Public Function getUser()
        Return user.Username
    End Function
    Public Function getID()
        Return user.ID
    End Function


End Class