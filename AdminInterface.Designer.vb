<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Settings = New System.Windows.Forms.Button()
        Me.Manage = New System.Windows.Forms.Button()
        Me.Dashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.Transparent
        Me.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings.ForeColor = System.Drawing.Color.White
        Me.Settings.Location = New System.Drawing.Point(959, 0)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(224, 73)
        Me.Settings.TabIndex = 0
        Me.Settings.Text = "SETTINGS"
        Me.Settings.UseVisualStyleBackColor = False
        '
        'Manage
        '
        Me.Manage.BackColor = System.Drawing.Color.Transparent
        Me.Manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Manage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Manage.ForeColor = System.Drawing.Color.White
        Me.Manage.Location = New System.Drawing.Point(738, 0)
        Me.Manage.Name = "Manage"
        Me.Manage.Size = New System.Drawing.Size(224, 73)
        Me.Manage.TabIndex = 1
        Me.Manage.Text = "MANAGE"
        Me.Manage.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.Dashboard.BackColor = System.Drawing.Color.Transparent
        Me.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard.ForeColor = System.Drawing.Color.White
        Me.Dashboard.Location = New System.Drawing.Point(515, 0)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(224, 73)
        Me.Dashboard.TabIndex = 2
        Me.Dashboard.Text = "DASHBOARD"
        Me.Dashboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1183, 512)
        Me.Panel1.TabIndex = 3
        '
        'AdminInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.AdminInterface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dashboard)
        Me.Controls.Add(Me.Manage)
        Me.Controls.Add(Me.Settings)
        Me.DoubleBuffered = True
        Me.Name = "AdminInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminInterface"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Settings As Button
    Friend WithEvents Manage As Button
    Friend WithEvents Dashboard As Button
    Friend WithEvents Panel1 As Panel
End Class
