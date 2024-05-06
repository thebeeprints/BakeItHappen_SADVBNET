<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyAttendance
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
        Me.AttendanceGrid = New System.Windows.Forms.DataGridView()
        Me.TimeIn = New System.Windows.Forms.Button()
        Me.TimeOut = New System.Windows.Forms.Button()
        CType(Me.AttendanceGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AttendanceGrid
        '
        Me.AttendanceGrid.AllowUserToAddRows = False
        Me.AttendanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendanceGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttendanceGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AttendanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.AttendanceGrid.Location = New System.Drawing.Point(28, 118)
        Me.AttendanceGrid.Name = "AttendanceGrid"
        Me.AttendanceGrid.RowHeadersVisible = False
        Me.AttendanceGrid.RowHeadersWidth = 51
        Me.AttendanceGrid.RowTemplate.Height = 24
        Me.AttendanceGrid.Size = New System.Drawing.Size(736, 225)
        Me.AttendanceGrid.TabIndex = 0
        '
        'TimeIn
        '
        Me.TimeIn.BackColor = System.Drawing.Color.SaddleBrown
        Me.TimeIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TimeIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeIn.ForeColor = System.Drawing.Color.White
        Me.TimeIn.Location = New System.Drawing.Point(231, 372)
        Me.TimeIn.Name = "TimeIn"
        Me.TimeIn.Size = New System.Drawing.Size(156, 42)
        Me.TimeIn.TabIndex = 1
        Me.TimeIn.Text = "Time In"
        Me.TimeIn.UseVisualStyleBackColor = False
        '
        'TimeOut
        '
        Me.TimeOut.BackColor = System.Drawing.Color.SaddleBrown
        Me.TimeOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TimeOut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeOut.ForeColor = System.Drawing.Color.White
        Me.TimeOut.Location = New System.Drawing.Point(404, 372)
        Me.TimeOut.Name = "TimeOut"
        Me.TimeOut.Size = New System.Drawing.Size(156, 42)
        Me.TimeOut.TabIndex = 2
        Me.TimeOut.Text = "Time Out"
        Me.TimeOut.UseVisualStyleBackColor = False
        '
        'DailyAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.DailyAttendance
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimeOut)
        Me.Controls.Add(Me.TimeIn)
        Me.Controls.Add(Me.AttendanceGrid)
        Me.DoubleBuffered = True
        Me.Name = "DailyAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DailyAttendance"
        CType(Me.AttendanceGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AttendanceGrid As DataGridView
    Friend WithEvents TimeIn As Button
    Friend WithEvents TimeOut As Button
End Class
