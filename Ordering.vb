Imports System.Reflection.Emit

Public Class Ordering
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        If NumericUpDown1.Value < 0 Then
            NumericUpDown1.Value = 0
        End If
        'ErrorProvider1.SetError(NumericUpDown1, String.Empty)
        'Label1.Text = holdstockML - NumericUpDown1.Value

    End Sub
End Class