<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminSettings
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
        Me.Role_txt = New System.Windows.Forms.Label()
        Me.FullName_txt = New System.Windows.Forms.Label()
        Me.ID_txt = New System.Windows.Forms.Label()
        Me.username_txt = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(112, 170)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.LogOut
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(843, 169)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 208)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Role_txt
        '
        Me.Role_txt.AutoSize = True
        Me.Role_txt.BackColor = System.Drawing.Color.Transparent
        Me.Role_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role_txt.ForeColor = System.Drawing.Color.White
        Me.Role_txt.Location = New System.Drawing.Point(437, 233)
        Me.Role_txt.Name = "Role_txt"
        Me.Role_txt.Size = New System.Drawing.Size(70, 27)
        Me.Role_txt.TabIndex = 2
        Me.Role_txt.Text = "Role:"
        '
        'FullName_txt
        '
        Me.FullName_txt.AutoSize = True
        Me.FullName_txt.BackColor = System.Drawing.Color.Transparent
        Me.FullName_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName_txt.ForeColor = System.Drawing.Color.White
        Me.FullName_txt.Location = New System.Drawing.Point(437, 260)
        Me.FullName_txt.Name = "FullName_txt"
        Me.FullName_txt.Size = New System.Drawing.Size(130, 27)
        Me.FullName_txt.TabIndex = 4
        Me.FullName_txt.Text = "Full Name:"
        '
        'ID_txt
        '
        Me.ID_txt.AutoSize = True
        Me.ID_txt.BackColor = System.Drawing.Color.Transparent
        Me.ID_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_txt.ForeColor = System.Drawing.Color.White
        Me.ID_txt.Location = New System.Drawing.Point(437, 288)
        Me.ID_txt.Name = "ID_txt"
        Me.ID_txt.Size = New System.Drawing.Size(43, 27)
        Me.ID_txt.TabIndex = 6
        Me.ID_txt.Text = "ID:"
        '
        'username_txt
        '
        Me.username_txt.AutoSize = True
        Me.username_txt.BackColor = System.Drawing.Color.Transparent
        Me.username_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txt.ForeColor = System.Drawing.Color.White
        Me.username_txt.Location = New System.Drawing.Point(437, 314)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(134, 27)
        Me.username_txt.TabIndex = 8
        Me.username_txt.Text = "Username:"
        '
        'AdminSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Settings
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1183, 512)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.ID_txt)
        Me.Controls.Add(Me.FullName_txt)
        Me.Controls.Add(Me.Role_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminSettings"
        Me.Text = "Settings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Role_txt As Label
    Friend WithEvents FullName_txt As Label
    Friend WithEvents ID_txt As Label
    Friend WithEvents username_txt As Label
End Class
