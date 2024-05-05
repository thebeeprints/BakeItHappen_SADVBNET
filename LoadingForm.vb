Imports System.Reflection.Emit

Public Class LoadingForm
    Dim i As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label1.Text = "Process " & ProgressBar1.Value & "% completed..."

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            SignIn.Show()
            Me.Hide()
        End If


    End Sub


End Class
