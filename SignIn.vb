Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class SignIn

    Private Sub HideButton_Click_1(sender As Object, e As EventArgs) Handles HideButton.Click
        If TextBox1.UseSystemPasswordChar = False Then
            TextBox1.UseSystemPasswordChar = True
        ElseIf TextBox1.UseSystemPasswordChar = True Then
            TextBox1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            HideButton.Visible = False
        Else
            HideButton.Visible = True

        End If
    End Sub


    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideButton.Visible = False

    End Sub

    Private Sub Sign_In_Click(sender As Object, e As EventArgs) Handles Sign_In.Click

    End Sub
End Class