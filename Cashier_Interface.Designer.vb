<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier_Interface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier_Interface))
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.OrderButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.ForeColor = System.Drawing.Color.Transparent
        Me.SettingsButton.Location = New System.Drawing.Point(1056, 4)
        Me.SettingsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(184, 75)
        Me.SettingsButton.TabIndex = 1
        Me.SettingsButton.Text = "SETTINGS"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'OrderButton
        '
        Me.OrderButton.BackColor = System.Drawing.Color.Transparent
        Me.OrderButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.ForeColor = System.Drawing.Color.Transparent
        Me.OrderButton.Location = New System.Drawing.Point(873, 4)
        Me.OrderButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(184, 75)
        Me.OrderButton.TabIndex = 2
        Me.OrderButton.Text = "ORDERS"
        Me.OrderButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 85)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 570)
        Me.Panel1.TabIndex = 3
        '
        'Cashier_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.CashierInterface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1357, 670)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.SettingsButton)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Cashier_Interface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BakeITHappen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SettingsButton As Button
    Friend WithEvents OrderButton As Button
    Friend WithEvents Panel1 As Panel
End Class
