<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.UpdateProduct_btn = New System.Windows.Forms.Button()
        Me.Orders_btn = New System.Windows.Forms.Button()
        Me.Stock_btn = New System.Windows.Forms.Button()
        Me.ViewSales_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UpdateProduct_btn
        '
        Me.UpdateProduct_btn.BackColor = System.Drawing.Color.Transparent
        Me.UpdateProduct_btn.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.UpdateProducts
        Me.UpdateProduct_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateProduct_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateProduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateProduct_btn.ForeColor = System.Drawing.Color.White
        Me.UpdateProduct_btn.Location = New System.Drawing.Point(96, 191)
        Me.UpdateProduct_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateProduct_btn.Name = "UpdateProduct_btn"
        Me.UpdateProduct_btn.Size = New System.Drawing.Size(90, 90)
        Me.UpdateProduct_btn.TabIndex = 0
        Me.UpdateProduct_btn.UseVisualStyleBackColor = False
        '
        'Orders_btn
        '
        Me.Orders_btn.BackColor = System.Drawing.Color.Transparent
        Me.Orders_btn.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Orders
        Me.Orders_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Orders_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Orders_btn.ForeColor = System.Drawing.Color.White
        Me.Orders_btn.Location = New System.Drawing.Point(306, 191)
        Me.Orders_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Orders_btn.Name = "Orders_btn"
        Me.Orders_btn.Size = New System.Drawing.Size(90, 90)
        Me.Orders_btn.TabIndex = 1
        Me.Orders_btn.UseVisualStyleBackColor = False
        '
        'Stock_btn
        '
        Me.Stock_btn.BackColor = System.Drawing.Color.Transparent
        Me.Stock_btn.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Stock__2_
        Me.Stock_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Stock_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Stock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stock_btn.ForeColor = System.Drawing.Color.White
        Me.Stock_btn.Location = New System.Drawing.Point(509, 191)
        Me.Stock_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Stock_btn.Name = "Stock_btn"
        Me.Stock_btn.Size = New System.Drawing.Size(90, 90)
        Me.Stock_btn.TabIndex = 2
        Me.Stock_btn.UseVisualStyleBackColor = False
        '
        'ViewSales_btn
        '
        Me.ViewSales_btn.BackColor = System.Drawing.Color.Transparent
        Me.ViewSales_btn.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Sales__1_
        Me.ViewSales_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ViewSales_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewSales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewSales_btn.ForeColor = System.Drawing.Color.White
        Me.ViewSales_btn.Location = New System.Drawing.Point(712, 191)
        Me.ViewSales_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewSales_btn.Name = "ViewSales_btn"
        Me.ViewSales_btn.Size = New System.Drawing.Size(90, 90)
        Me.ViewSales_btn.TabIndex = 3
        Me.ViewSales_btn.UseVisualStyleBackColor = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.AdminDashboard
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 378)
        Me.Controls.Add(Me.ViewSales_btn)
        Me.Controls.Add(Me.Stock_btn)
        Me.Controls.Add(Me.Orders_btn)
        Me.Controls.Add(Me.UpdateProduct_btn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpdateProduct_btn As Button
    Friend WithEvents Orders_btn As Button
    Friend WithEvents Stock_btn As Button
    Friend WithEvents ViewSales_btn As Button
End Class
