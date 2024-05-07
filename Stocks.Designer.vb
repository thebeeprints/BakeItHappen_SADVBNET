<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stocks
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Back = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddProducts_btn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.stock_lbl = New System.Windows.Forms.Label()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.stockinput_txt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Transparent
        Me.Back.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Arrow1
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Back.Location = New System.Drawing.Point(15, 15)
        Me.Back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(43, 32)
        Me.Back.TabIndex = 0
        Me.Back.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.AddProducts_btn)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Location = New System.Drawing.Point(-3, 63)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 39)
        Me.Panel1.TabIndex = 1
        '
        'AddProducts_btn
        '
        Me.AddProducts_btn.BackColor = System.Drawing.Color.SaddleBrown
        Me.AddProducts_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddProducts_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProducts_btn.ForeColor = System.Drawing.Color.White
        Me.AddProducts_btn.Location = New System.Drawing.Point(909, 5)
        Me.AddProducts_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddProducts_btn.Name = "AddProducts_btn"
        Me.AddProducts_btn.Size = New System.Drawing.Size(229, 27)
        Me.AddProducts_btn.TabIndex = 7
        Me.AddProducts_btn.Text = "Add product"
        Me.AddProducts_btn.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ID", "Alphabetical", "Stock Low", "Stock High"})
        Me.ComboBox1.Location = New System.Drawing.Point(333, 6)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(241, 28)
        Me.ComboBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(260, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sort by"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.TextBox1.Location = New System.Drawing.Point(13, 7)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 27)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Search"
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Transparent
        Me.Search.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.MagnifyingGlass__1_
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Search.Location = New System.Drawing.Point(196, 7)
        Me.Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(28, 23)
        Me.Search.TabIndex = 3
        Me.Search.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(0, 101)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1148, 318)
        Me.Panel2.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdID, Me.ProdName, Me.ProdStock})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(772, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'ProdID
        '
        Me.ProdID.HeaderText = "Product ID"
        Me.ProdID.MinimumWidth = 6
        Me.ProdID.Name = "ProdID"
        Me.ProdID.ReadOnly = True
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "Name"
        Me.ProdName.MinimumWidth = 6
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        '
        'ProdStock
        '
        Me.ProdStock.HeaderText = "Stock"
        Me.ProdStock.MinimumWidth = 6
        Me.ProdStock.Name = "ProdStock"
        Me.ProdStock.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.stock_lbl)
        Me.Panel3.Controls.Add(Me.update_btn)
        Me.Panel3.Controls.Add(Me.stockinput_txt)
        Me.Panel3.Location = New System.Drawing.Point(769, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(379, 318)
        Me.Panel3.TabIndex = 1
        '
        'stock_lbl
        '
        Me.stock_lbl.AutoSize = True
        Me.stock_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_lbl.ForeColor = System.Drawing.Color.SaddleBrown
        Me.stock_lbl.Location = New System.Drawing.Point(154, 199)
        Me.stock_lbl.Name = "stock_lbl"
        Me.stock_lbl.Size = New System.Drawing.Size(71, 23)
        Me.stock_lbl.TabIndex = 12
        Me.stock_lbl.Text = "Stock:"
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.Color.MistyRose
        Me.update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.SaddleBrown
        Me.update_btn.Location = New System.Drawing.Point(115, 265)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(148, 29)
        Me.update_btn.TabIndex = 11
        Me.update_btn.Text = "Update Stock"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'stockinput_txt
        '
        Me.stockinput_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockinput_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.stockinput_txt.Location = New System.Drawing.Point(139, 222)
        Me.stockinput_txt.Name = "stockinput_txt"
        Me.stockinput_txt.Size = New System.Drawing.Size(100, 31)
        Me.stockinput_txt.TabIndex = 8
        Me.stockinput_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(56, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.ProductStock
        Me.ClientSize = New System.Drawing.Size(1147, 418)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Stocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stocks"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AddProducts_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProdID As DataGridViewTextBoxColumn
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents ProdStock As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents stock_lbl As Label
    Friend WithEvents update_btn As Button
    Friend WithEvents stockinput_txt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
