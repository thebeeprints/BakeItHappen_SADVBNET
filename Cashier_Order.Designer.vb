<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier_Order
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Del_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.finish_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdQuant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Search_txt = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(859, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(685, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date"
        '
        'SearchButton
        '
        Me.SearchButton.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.MagnifyingGlass__1_
        Me.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Location = New System.Drawing.Point(152, 74)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(22, 20)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(237, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sort by"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Del_btn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.finish_btn)
        Me.Panel1.Controls.Add(Me.clear_btn)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(426, 71)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 347)
        Me.Panel1.TabIndex = 2
        '
        'Del_btn
        '
        Me.Del_btn.Location = New System.Drawing.Point(111, 200)
        Me.Del_btn.Name = "Del_btn"
        Me.Del_btn.Size = New System.Drawing.Size(75, 23)
        Me.Del_btn.TabIndex = 5
        Me.Del_btn.Text = "Delete"
        Me.Del_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(399, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sub Total"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(460, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'finish_btn
        '
        Me.finish_btn.Location = New System.Drawing.Point(473, 244)
        Me.finish_btn.Name = "finish_btn"
        Me.finish_btn.Size = New System.Drawing.Size(87, 23)
        Me.finish_btn.TabIndex = 2
        Me.finish_btn.Text = "Confirm"
        Me.finish_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.Location = New System.Drawing.Point(18, 201)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(87, 23)
        Me.clear_btn.TabIndex = 1
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdID, Me.ProdName, Me.ProdPrice, Me.ProdQuant, Me.ProdTotal})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(542, 168)
        Me.DataGridView1.TabIndex = 0
        '
        'ProdID
        '
        Me.ProdID.HeaderText = "ID"
        Me.ProdID.Name = "ProdID"
        Me.ProdID.ReadOnly = True
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "Name"
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        '
        'ProdPrice
        '
        Me.ProdPrice.HeaderText = "Price"
        Me.ProdPrice.Name = "ProdPrice"
        Me.ProdPrice.ReadOnly = True
        '
        'ProdQuant
        '
        Me.ProdQuant.HeaderText = "Quantity"
        Me.ProdQuant.Name = "ProdQuant"
        Me.ProdQuant.ReadOnly = True
        '
        'ProdTotal
        '
        Me.ProdTotal.HeaderText = "Total"
        Me.ProdTotal.Name = "ProdTotal"
        Me.ProdTotal.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Alphabetical", "Price Low", "Price High"})
        Me.ComboBox1.Location = New System.Drawing.Point(305, 74)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(119, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Search_txt
        '
        Me.Search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Search_txt.Location = New System.Drawing.Point(4, 74)
        Me.Search_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Search_txt.Multiline = True
        Me.Search_txt.Name = "Search_txt"
        Me.Search_txt.Size = New System.Drawing.Size(143, 19)
        Me.Search_txt.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 98)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(418, 319)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'Cashier_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.CashierOrderFinal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 423)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Search_txt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Cashier_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashierInterface"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Search_txt As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents clear_btn As Button
    Friend WithEvents finish_btn As Button
    Friend WithEvents ProdID As DataGridViewTextBoxColumn
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents ProdPrice As DataGridViewTextBoxColumn
    Friend WithEvents ProdQuant As DataGridViewTextBoxColumn
    Friend WithEvents ProdTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Del_btn As Button
End Class
