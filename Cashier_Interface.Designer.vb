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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SettingdButton = New System.Windows.Forms.Button()
        Me.OrderButton = New System.Windows.Forms.Button()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.time_lbl)
        Me.Panel1.Location = New System.Drawing.Point(-7, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 500)
        Me.Panel1.TabIndex = 0
        '
        'SettingdButton
        '
        Me.SettingdButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingdButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingdButton.ForeColor = System.Drawing.Color.Transparent
        Me.SettingdButton.Location = New System.Drawing.Point(929, 0)
        Me.SettingdButton.Name = "SettingdButton"
        Me.SettingdButton.Size = New System.Drawing.Size(184, 75)
        Me.SettingdButton.TabIndex = 1
        Me.SettingdButton.Text = "SETTINGS"
        Me.SettingdButton.UseVisualStyleBackColor = False
        '
        'OrderButton
        '
        Me.OrderButton.BackColor = System.Drawing.Color.Transparent
        Me.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.ForeColor = System.Drawing.Color.Transparent
        Me.OrderButton.Location = New System.Drawing.Point(746, 1)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(184, 75)
        Me.OrderButton.TabIndex = 2
        Me.OrderButton.Text = "ORDERS"
        Me.OrderButton.UseVisualStyleBackColor = False
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_lbl.Location = New System.Drawing.Point(267, 2)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(603, 93)
        Me.time_lbl.TabIndex = 0
        Me.time_lbl.Text = "00 : 00 : 00 AM"
        '
        'Cashier_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.CashierInterface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1114, 574)
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.SettingdButton)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Cashier_Interface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier_Interface"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SettingdButton As Button
    Friend WithEvents OrderButton As Button
    Friend WithEvents time_lbl As Label
End Class
