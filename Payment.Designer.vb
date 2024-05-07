<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Total_txt = New System.Windows.Forms.TextBox()
        Me.cash_txt = New System.Windows.Forms.TextBox()
        Me.change_txt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Arrow
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(12, 10)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(37, 30)
        Me.BackButton.TabIndex = 0
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Total_txt
        '
        Me.Total_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Total_txt.Location = New System.Drawing.Point(127, 119)
        Me.Total_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Total_txt.Multiline = True
        Me.Total_txt.Name = "Total_txt"
        Me.Total_txt.Size = New System.Drawing.Size(393, 26)
        Me.Total_txt.TabIndex = 1
        Me.Total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cash_txt
        '
        Me.cash_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cash_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cash_txt.Location = New System.Drawing.Point(127, 190)
        Me.cash_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cash_txt.Multiline = True
        Me.cash_txt.Name = "cash_txt"
        Me.cash_txt.Size = New System.Drawing.Size(393, 26)
        Me.cash_txt.TabIndex = 2
        Me.cash_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'change_txt
        '
        Me.change_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.change_txt.Location = New System.Drawing.Point(127, 255)
        Me.change_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.change_txt.Multiline = True
        Me.change_txt.Name = "change_txt"
        Me.change_txt.ReadOnly = True
        Me.change_txt.Size = New System.Drawing.Size(393, 26)
        Me.change_txt.TabIndex = 3
        Me.change_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(247, 313)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Check Out"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Payment
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(649, 382)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.change_txt)
        Me.Controls.Add(Me.cash_txt)
        Me.Controls.Add(Me.Total_txt)
        Me.Controls.Add(Me.BackButton)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents Total_txt As TextBox
    Friend WithEvents cash_txt As TextBox
    Friend WithEvents change_txt As TextBox
    Friend WithEvents Button2 As Button
End Class
