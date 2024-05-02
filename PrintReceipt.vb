Imports System.Drawing.Printing

Public Class PrintReceipt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", Me.Width, Me.Height)
        PrintPreviewDialog1.ClientSize = Me.Size
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Button1.BackColor = Color.White
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub PrintPreviewDialog1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles PrintPreviewDialog1.FormClosed
        Button1.BackColor = ColorTranslator.FromHtml("#602A0F")
    End Sub
End Class