<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ordering
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Message = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Design = New System.Windows.Forms.ComboBox()
        Me.ProductImage = New System.Windows.Forms.PictureBox()
        Me.Stock = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Product = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(25, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 285)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(400, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(472, 337)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(149, 25)
        Me.Price.TabIndex = 2
        '
        'Message
        '
        Me.Message.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.Location = New System.Drawing.Point(472, 277)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(149, 25)
        Me.Message.TabIndex = 3
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(472, 220)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(149, 25)
        Me.ID.TabIndex = 4
        '
        'Design
        '
        Me.Design.FormattingEnabled = True
        Me.Design.Location = New System.Drawing.Point(471, 307)
        Me.Design.Name = "Design"
        Me.Design.Size = New System.Drawing.Size(150, 24)
        Me.Design.TabIndex = 6
        '
        'ProductImage
        '
        Me.ProductImage.BackColor = System.Drawing.Color.Transparent
        Me.ProductImage.Location = New System.Drawing.Point(25, 113)
        Me.ProductImage.Name = "ProductImage"
        Me.ProductImage.Size = New System.Drawing.Size(338, 284)
        Me.ProductImage.TabIndex = 7
        Me.ProductImage.TabStop = False
        '
        'Stock
        '
        Me.Stock.AutoSize = True
        Me.Stock.BackColor = System.Drawing.Color.Transparent
        Me.Stock.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock.ForeColor = System.Drawing.Color.White
        Me.Stock.Location = New System.Drawing.Point(329, 13)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(85, 31)
        Me.Stock.TabIndex = 8
        Me.Stock.Text = "Label1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Regular", "Promo"})
        Me.ComboBox1.Location = New System.Drawing.Point(156, 407)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 24)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Text = "Regular"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(471, 250)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(151, 22)
        Me.NumericUpDown1.TabIndex = 10
        '
        'Product
        '
        Me.Product.AutoSize = True
        Me.Product.BackColor = System.Drawing.Color.Transparent
        Me.Product.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Product.Location = New System.Drawing.Point(20, 78)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(85, 31)
        Me.Product.TabIndex = 11
        Me.Product.Text = "Label2"
        '
        'Ordering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Stock
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(649, 453)
        Me.Controls.Add(Me.Product)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Stock)
        Me.Controls.Add(Me.ProductImage)
        Me.Controls.Add(Me.Design)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Ordering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordering"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Price As TextBox
    Friend WithEvents Message As TextBox
    Friend WithEvents ID As TextBox
    Friend WithEvents Design As ComboBox
    Friend WithEvents ProductImage As PictureBox
    Friend WithEvents Stock As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Product As Label
End Class
