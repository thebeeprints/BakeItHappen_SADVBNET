Public Class RegisterAccount
    Dim ping As New Ping()
    Dim firebase As New FireBaseApp()
    Dim IMGtoB64 As New ImageBase64Converter()
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdminInterface.Show()
        Me.Hide()

    End Sub

    Private Sub RegisterAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccessType_Combo.SelectedIndex = 1
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        'VALIDATIONS
        If Not ping.CheckForInternetConnection() Then
            MessageBox.Show("There is a problem with your internet connnection. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If Not AreFieldsFilledOut() Then
            MessageBox.Show("Please fill out all the informations", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'VALIDATIONS
        If Password_txt.Text <> ConfirmPassword_txt.Text Then
            MatchPass_txt.Visible = True
        Else
            MatchPass_txt.Visible = False
            Dim IDGen = firebase.client.Get("BakeITHappen/LatestID").ResultAs(Of Integer)()
            IDGen += 1
            MessageBox.Show(IDGen)
            Dim IMGDATA As String = IMGtoB64.ImgToB64(Avatar_PcBx)

            Dim existingUser = firebase.client.Get($"BakeITHappen/Users/{Username_txt.Text.ToLower()}")
            If existingUser.Body <> "null" Then
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim account As New UserDataModel() With {
                .ID = IDGen,
                .Username = Username_txt.Text.ToLower(),
                .Password = Password_txt.Text,
                .FullName = FullName_txt.Text,
                .AccessType = AccessType_Combo.SelectedItem,
                .Avatar = IMGDATA
            }
            Try
                Dim response = firebase.InsertData(account, $"BakeITHappen/Users/{Username_txt.Text}/")
                Dim updateID = firebase.client.Set(Of Integer)("BakeITHappen/LatestID", IDGen)
            Catch ex As Exception
                MessageBox.Show("Account registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            MessageBox.Show("Account registration successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).Clear()
                AccessType_Combo.SelectedIndex = 0
            Next
            Avatar_PcBx.Image = Nothing
        End If
    End Sub

    Private Sub Password_txt_TextChanged(sender As Object, e As EventArgs) Handles Password_txt.TextChanged
        If Password_txt.Text = "" Then
            HideButton.Visible = False
        Else
            HideButton.Visible = True
        End If
    End Sub

    Private Sub HideButton_Click(sender As Object, e As EventArgs) Handles HideButton.Click
        Password_txt.UseSystemPasswordChar = Not Password_txt.UseSystemPasswordChar
        ConfirmPassword_txt.UseSystemPasswordChar = Not ConfirmPassword_txt.UseSystemPasswordChar
    End Sub

    Private Function AreFieldsFilledOut() As Boolean
        If String.IsNullOrWhiteSpace(Username_txt.Text) OrElse
           String.IsNullOrWhiteSpace(FullName_txt.Text) OrElse
           String.IsNullOrWhiteSpace(Password_txt.Text) OrElse
           String.IsNullOrWhiteSpace(AccessType_Combo.Text) OrElse
           Avatar_PcBx.Image Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim opf As New OpenFileDialog()

        opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;"
        If opf.ShowDialog() = DialogResult.OK Then
            Avatar_PcBx.Image = Image.FromFile(opf.FileName)
        End If
    End Sub
End Class