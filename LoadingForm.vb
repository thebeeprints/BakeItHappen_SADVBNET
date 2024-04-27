Imports System.Reflection.Emit

Public Class LoadingForm
    Dim i As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        i += 1
        Label1.Text = "Process " & i & " % completed..."
        If i >= 100 Then
            Timer1.Enabled = False
            SignIn.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 100
        Label1.Text = ""
        i = 1

    End Sub

End Class
