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
        Me.Settings_btn = New System.Windows.Forms.Button()
        Me.Manage_btn = New System.Windows.Forms.Button()
        Me.Dashboard_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Settings_btn
        '
        Me.Settings_btn.BackColor = System.Drawing.Color.Transparent
        Me.Settings_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings_btn.ForeColor = System.Drawing.Color.White
        Me.Settings_btn.Location = New System.Drawing.Point(719, 0)
        Me.Settings_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Settings_btn.Name = "Settings_btn"
        Me.Settings_btn.Size = New System.Drawing.Size(168, 59)
        Me.Settings_btn.TabIndex = 0
        Me.Settings_btn.Text = "SETTINGS"
        Me.Settings_btn.UseVisualStyleBackColor = False
        '
        'Manage_btn
        '
        Me.Manage_btn.BackColor = System.Drawing.Color.Transparent
        Me.Manage_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Manage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Manage_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Manage_btn.ForeColor = System.Drawing.Color.White
        Me.Manage_btn.Location = New System.Drawing.Point(554, 0)
        Me.Manage_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Manage_btn.Name = "Manage_btn"
        Me.Manage_btn.Size = New System.Drawing.Size(168, 59)
        Me.Manage_btn.TabIndex = 1
        Me.Manage_btn.Text = "MANAGE"
        Me.Manage_btn.UseVisualStyleBackColor = False
        '
        'Dashboard_btn
        '
        Me.Dashboard_btn.BackColor = System.Drawing.Color.Transparent
        Me.Dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard_btn.ForeColor = System.Drawing.Color.White
        Me.Dashboard_btn.Location = New System.Drawing.Point(386, 0)
        Me.Dashboard_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Dashboard_btn.Name = "Dashboard_btn"
        Me.Dashboard_btn.Size = New System.Drawing.Size(168, 59)
        Me.Dashboard_btn.TabIndex = 2
        Me.Dashboard_btn.Text = "DASHBOARD"
        Me.Dashboard_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 416)
        Me.Panel1.TabIndex = 3
        '
        'AdminInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.AdminInterface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(888, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dashboard_btn)
        Me.Controls.Add(Me.Manage_btn)
        Me.Controls.Add(Me.Settings_btn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "AdminInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Interface"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Settings_btn As Button
    Friend WithEvents Manage_btn As Button
    Friend WithEvents Dashboard_btn As Button
    Friend WithEvents Panel1 As Panel
End Class
