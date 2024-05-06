Public Class AdminInterface
    Private Sub AdminInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAdminDashboard()
    End Sub
    Private Sub Manage_Click(sender As Object, e As EventArgs) Handles Manage_btn.Click
        loadAdminManage()
    End Sub
    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings_btn.Click
        loadAdminSettings()
    End Sub
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard_btn.Click
        loadAdminDashboard()
    End Sub
    Private Sub loadAdminDashboard()
        AdminDashboard.TopLevel = False
        AdminDashboard.FormBorderStyle = FormBorderStyle.None
        AdminDashboard.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(AdminDashboard)
        AdminDashboard.Show()
    End Sub
    Private Sub loadAdminSettings()
        AdminSettings.TopLevel = False
        AdminSettings.FormBorderStyle = FormBorderStyle.None
        AdminSettings.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(AdminSettings)
        AdminSettings.Show()
    End Sub
    Private Sub loadAdminManage()
        Manage.TopLevel = False
        Manage.FormBorderStyle = FormBorderStyle.None
        Manage.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(Manage)
        Manage.Show()
    End Sub


End Class