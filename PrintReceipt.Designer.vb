<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintReceipt
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintReceipt))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdQuant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.CashierName_txt = New System.Windows.Forms.Label()
        Me.CashierID_txt = New System.Windows.Forms.Label()
        Me.date_txt = New System.Windows.Forms.Label()
        Me.time_txt = New System.Windows.Forms.Label()
        Me.total_txt = New System.Windows.Forms.Label()
        Me.cash_txt = New System.Windows.Forms.Label()
        Me.change_txt = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(179, 626)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdName, Me.ProdPrice, Me.ProdQuant, Me.ProdTotal})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView1.Location = New System.Drawing.Point(45, 235)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(489, 212)
        Me.DataGridView1.TabIndex = 1
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "Name"
        Me.ProdName.MinimumWidth = 6
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        '
        'ProdPrice
        '
        Me.ProdPrice.HeaderText = "Price"
        Me.ProdPrice.MinimumWidth = 6
        Me.ProdPrice.Name = "ProdPrice"
        Me.ProdPrice.ReadOnly = True
        '
        'ProdQuant
        '
        Me.ProdQuant.HeaderText = "Quantity"
        Me.ProdQuant.MinimumWidth = 6
        Me.ProdQuant.Name = "ProdQuant"
        Me.ProdQuant.ReadOnly = True
        '
        'ProdTotal
        '
        Me.ProdTotal.HeaderText = "Total"
        Me.ProdTotal.MinimumWidth = 6
        Me.ProdTotal.Name = "ProdTotal"
        Me.ProdTotal.ReadOnly = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'CashierName_txt
        '
        Me.CashierName_txt.AutoSize = True
        Me.CashierName_txt.BackColor = System.Drawing.Color.Transparent
        Me.CashierName_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashierName_txt.Location = New System.Drawing.Point(183, 166)
        Me.CashierName_txt.Name = "CashierName_txt"
        Me.CashierName_txt.Size = New System.Drawing.Size(0, 20)
        Me.CashierName_txt.TabIndex = 2
        '
        'CashierID_txt
        '
        Me.CashierID_txt.AutoSize = True
        Me.CashierID_txt.BackColor = System.Drawing.Color.Transparent
        Me.CashierID_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashierID_txt.Location = New System.Drawing.Point(83, 198)
        Me.CashierID_txt.Name = "CashierID_txt"
        Me.CashierID_txt.Size = New System.Drawing.Size(0, 20)
        Me.CashierID_txt.TabIndex = 3
        '
        'date_txt
        '
        Me.date_txt.AutoSize = True
        Me.date_txt.BackColor = System.Drawing.Color.Transparent
        Me.date_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_txt.Location = New System.Drawing.Point(430, 166)
        Me.date_txt.Name = "date_txt"
        Me.date_txt.Size = New System.Drawing.Size(0, 20)
        Me.date_txt.TabIndex = 4
        '
        'time_txt
        '
        Me.time_txt.AutoSize = True
        Me.time_txt.BackColor = System.Drawing.Color.Transparent
        Me.time_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_txt.Location = New System.Drawing.Point(431, 198)
        Me.time_txt.Name = "time_txt"
        Me.time_txt.Size = New System.Drawing.Size(0, 20)
        Me.time_txt.TabIndex = 5
        '
        'total_txt
        '
        Me.total_txt.AutoSize = True
        Me.total_txt.BackColor = System.Drawing.Color.Transparent
        Me.total_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_txt.Location = New System.Drawing.Point(270, 481)
        Me.total_txt.Name = "total_txt"
        Me.total_txt.Size = New System.Drawing.Size(0, 20)
        Me.total_txt.TabIndex = 6
        '
        'cash_txt
        '
        Me.cash_txt.AutoSize = True
        Me.cash_txt.BackColor = System.Drawing.Color.Transparent
        Me.cash_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cash_txt.Location = New System.Drawing.Point(270, 522)
        Me.cash_txt.Name = "cash_txt"
        Me.cash_txt.Size = New System.Drawing.Size(0, 20)
        Me.cash_txt.TabIndex = 7
        '
        'change_txt
        '
        Me.change_txt.AutoSize = True
        Me.change_txt.BackColor = System.Drawing.Color.Transparent
        Me.change_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_txt.Location = New System.Drawing.Point(270, 565)
        Me.change_txt.Name = "change_txt"
        Me.change_txt.Size = New System.Drawing.Size(0, 20)
        Me.change_txt.TabIndex = 8
        '
        'PrintReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.PrintReceipt
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(581, 703)
        Me.Controls.Add(Me.change_txt)
        Me.Controls.Add(Me.cash_txt)
        Me.Controls.Add(Me.total_txt)
        Me.Controls.Add(Me.time_txt)
        Me.Controls.Add(Me.date_txt)
        Me.Controls.Add(Me.CashierID_txt)
        Me.Controls.Add(Me.CashierName_txt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PrintReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BakeITHappen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents ProdPrice As DataGridViewTextBoxColumn
    Friend WithEvents ProdQuant As DataGridViewTextBoxColumn
    Friend WithEvents ProdTotal As DataGridViewTextBoxColumn
    Friend WithEvents CashierName_txt As Label
    Friend WithEvents CashierID_txt As Label
    Friend WithEvents date_txt As Label
    Friend WithEvents time_txt As Label
    Friend WithEvents total_txt As Label
    Friend WithEvents cash_txt As Label
    Friend WithEvents change_txt As Label
End Class
