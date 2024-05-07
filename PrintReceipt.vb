Imports System.Drawing.Printing

Public Class PrintReceipt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", Me.Width, Me.Height)
        PrintPreviewDialog1.ClientSize = Me.Size
        PrintPreviewDialog1.ShowDialog()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).Clear()
        Next
        Payment.ClearTxtBox()
        Me.Close()
    End Sub

    Private Sub PrintReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ClearSelection()
        CashierName_txt.Text = SignIn.getFullName
        CashierID_txt.Text = Payment.GetTransacID
        date_txt.Text = Now.ToString("MMMM dd, yyyy")
        time_txt.Text = Now.ToString("HH:mm")
        total_txt.Text = Payment.Total_txt.Text
        cash_txt.Text = Payment.cash_txt.Text
        change_txt.Text = Payment.change_txt.Text
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Button1.BackColor = Color.White
        Me.FormBorderStyle = FormBorderStyle.None
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Button1.BackColor = ColorTranslator.FromHtml("#602A0F")
        Dim printArea As New RectangleF(e.PageBounds.Left, e.PageBounds.Top, e.PageBounds.Width, e.PageBounds.Height)
        e.Graphics.DrawImage(bmp, printArea)
    End Sub


    Private Sub PrintPreviewDialog1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles PrintPreviewDialog1.FormClosed

    End Sub
End Class