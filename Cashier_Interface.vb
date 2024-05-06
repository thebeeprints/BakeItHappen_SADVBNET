Imports Microsoft.VisualBasic.ApplicationServices

Public Class Cashier_Interface
    Private CashierOrderInstance As New Cashier_Order()
    Private CashierSettings As New Cashier_Settings()
    Private receipt As New PrintReceipt()

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        LoadCashierOrder()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        LoadCashierSettings()
    End Sub

    Private Sub Cashier_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadCashierSettings()
        LoadCashierOrder()
    End Sub

    Public Sub LoadCashierOrder()
        Cashier_Order.TopLevel = False
        Cashier_Order.FormBorderStyle = FormBorderStyle.None
        Cashier_Order.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add( Cashier_Order)
        Cashier_Order.Show()
    End Sub

    Public Sub LoadCashierSettings()
        CashierSettings.TopLevel = False
        CashierSettings.FormBorderStyle = FormBorderStyle.None
        CashierSettings.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(CashierSettings)
        CashierSettings.Show()
    End Sub

End Class