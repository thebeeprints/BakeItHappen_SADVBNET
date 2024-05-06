<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manage
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
        Me.RegisterAccount_btn = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ViewAccounts_btn = New System.Windows.Forms.Button()
        Me.TotalAccounts_txt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RegisterAccount_btn
        '
        Me.RegisterAccount_btn.BackColor = System.Drawing.Color.Transparent
        Me.RegisterAccount_btn.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.RegisterAccount
        Me.RegisterAccount_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegisterAccount_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterAccount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterAccount_btn.Location = New System.Drawing.Point(131, 189)
        Me.RegisterAccount_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RegisterAccount_btn.Name = "RegisterAccount_btn"
        Me.RegisterAccount_btn.Size = New System.Drawing.Size(126, 119)
        Me.RegisterAccount_btn.TabIndex = 0
        Me.RegisterAccount_btn.UseVisualStyleBackColor = False
        '
        'ViewAccounts_btn
        '
        Me.ViewAccounts_btn.BackColor = System.Drawing.Color.Transparent
        Me.ViewAccounts_btn.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.ViewAccounts__1_
        Me.ViewAccounts_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ViewAccounts_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewAccounts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewAccounts_btn.Location = New System.Drawing.Point(370, 189)
        Me.ViewAccounts_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ViewAccounts_btn.Name = "ViewAccounts_btn"
        Me.ViewAccounts_btn.Size = New System.Drawing.Size(126, 119)
        Me.ViewAccounts_btn.TabIndex = 1
        Me.ViewAccounts_btn.UseVisualStyleBackColor = False
        '
        'TotalAccounts_txt
        '
        Me.TotalAccounts_txt.AutoSize = True
        Me.TotalAccounts_txt.BackColor = System.Drawing.Color.Transparent
        Me.TotalAccounts_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAccounts_txt.ForeColor = System.Drawing.Color.White
        Me.TotalAccounts_txt.Location = New System.Drawing.Point(649, 221)
        Me.TotalAccounts_txt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalAccounts_txt.Name = "TotalAccounts_txt"
        Me.TotalAccounts_txt.Size = New System.Drawing.Size(53, 55)
        Me.TotalAccounts_txt.TabIndex = 3
        Me.TotalAccounts_txt.Text = "0"
        '
        'Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Manage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(887, 416)
        Me.Controls.Add(Me.TotalAccounts_txt)
        Me.Controls.Add(Me.ViewAccounts_btn)
        Me.Controls.Add(Me.RegisterAccount_btn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Manage"
        Me.Text = "Manage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterAccount_btn As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ViewAccounts_btn As Button
    Friend WithEvents TotalAccounts_txt As Label
End Class
