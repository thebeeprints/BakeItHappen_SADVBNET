<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RegisterAccount = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ViewAccounts = New System.Windows.Forms.Button()
        Me.TotalAccounts = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RegisterAccount
        '
        Me.RegisterAccount.BackColor = System.Drawing.Color.Transparent
        Me.RegisterAccount.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.RegisterAccount
        Me.RegisterAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegisterAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterAccount.Location = New System.Drawing.Point(175, 233)
        Me.RegisterAccount.Name = "RegisterAccount"
        Me.RegisterAccount.Size = New System.Drawing.Size(168, 146)
        Me.RegisterAccount.TabIndex = 0
        Me.RegisterAccount.UseVisualStyleBackColor = False
        '
        'ViewAccounts
        '
        Me.ViewAccounts.BackColor = System.Drawing.Color.Transparent
        Me.ViewAccounts.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.ViewAccounts__1_
        Me.ViewAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ViewAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewAccounts.Location = New System.Drawing.Point(493, 233)
        Me.ViewAccounts.Name = "ViewAccounts"
        Me.ViewAccounts.Size = New System.Drawing.Size(168, 146)
        Me.ViewAccounts.TabIndex = 1
        Me.ViewAccounts.UseVisualStyleBackColor = False
        '
        'TotalAccounts
        '
        Me.TotalAccounts.AutoSize = True
        Me.TotalAccounts.BackColor = System.Drawing.Color.Transparent
        Me.TotalAccounts.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAccounts.ForeColor = System.Drawing.Color.White
        Me.TotalAccounts.Location = New System.Drawing.Point(862, 302)
        Me.TotalAccounts.Name = "TotalAccounts"
        Me.TotalAccounts.Size = New System.Drawing.Size(65, 32)
        Me.TotalAccounts.TabIndex = 3
        Me.TotalAccounts.Text = "777"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(864, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Value:"
        '
        'Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Manage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1183, 512)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalAccounts)
        Me.Controls.Add(Me.ViewAccounts)
        Me.Controls.Add(Me.RegisterAccount)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Manage"
        Me.Text = "Manage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterAccount As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ViewAccounts As Button
    Friend WithEvents TotalAccounts As Label
    Friend WithEvents Label1 As Label
End Class
