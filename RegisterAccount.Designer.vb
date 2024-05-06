<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterAccount
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
        Me.Avatar_PcBx = New System.Windows.Forms.PictureBox()
        Me.FullName_txt = New System.Windows.Forms.TextBox()
        Me.Username_txt = New System.Windows.Forms.TextBox()
        Me.Password_txt = New System.Windows.Forms.TextBox()
        Me.ConfirmPassword_txt = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.AccessType_Combo = New System.Windows.Forms.ComboBox()
        Me.MatchPass_txt = New System.Windows.Forms.Label()
        Me.HideButton = New System.Windows.Forms.PictureBox()
        CType(Me.Avatar_PcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Avatar_PcBx
        '
        Me.Avatar_PcBx.BackColor = System.Drawing.Color.Transparent
        Me.Avatar_PcBx.Location = New System.Drawing.Point(43, 156)
        Me.Avatar_PcBx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Avatar_PcBx.Name = "Avatar_PcBx"
        Me.Avatar_PcBx.Size = New System.Drawing.Size(276, 204)
        Me.Avatar_PcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar_PcBx.TabIndex = 0
        Me.Avatar_PcBx.TabStop = False
        '
        'FullName_txt
        '
        Me.FullName_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.FullName_txt.Location = New System.Drawing.Point(379, 217)
        Me.FullName_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FullName_txt.Multiline = True
        Me.FullName_txt.Name = "FullName_txt"
        Me.FullName_txt.Size = New System.Drawing.Size(336, 34)
        Me.FullName_txt.TabIndex = 1
        '
        'Username_txt
        '
        Me.Username_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Username_txt.Location = New System.Drawing.Point(377, 281)
        Me.Username_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Username_txt.Multiline = True
        Me.Username_txt.Name = "Username_txt"
        Me.Username_txt.Size = New System.Drawing.Size(336, 34)
        Me.Username_txt.TabIndex = 2
        '
        'Password_txt
        '
        Me.Password_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Password_txt.Location = New System.Drawing.Point(777, 219)
        Me.Password_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.Size = New System.Drawing.Size(336, 31)
        Me.Password_txt.TabIndex = 3
        Me.Password_txt.UseSystemPasswordChar = True
        '
        'ConfirmPassword_txt
        '
        Me.ConfirmPassword_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.ConfirmPassword_txt.Location = New System.Drawing.Point(777, 282)
        Me.ConfirmPassword_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConfirmPassword_txt.Name = "ConfirmPassword_txt"
        Me.ConfirmPassword_txt.Size = New System.Drawing.Size(336, 31)
        Me.ConfirmPassword_txt.TabIndex = 4
        Me.ConfirmPassword_txt.UseSystemPasswordChar = True
        '
        'Browse
        '
        Me.Browse.BackColor = System.Drawing.Color.Transparent
        Me.Browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Browse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.Color.White
        Me.Browse.Location = New System.Drawing.Point(107, 377)
        Me.Browse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(151, 39)
        Me.Browse.TabIndex = 5
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.Register.BackColor = System.Drawing.Color.Transparent
        Me.Register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Register.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Register.Location = New System.Drawing.Point(925, 337)
        Me.Register.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(187, 39)
        Me.Register.TabIndex = 6
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Arrow
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.SaddleBrown
        Me.BackButton.Location = New System.Drawing.Point(17, 20)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(44, 36)
        Me.BackButton.TabIndex = 7
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'AccessType_Combo
        '
        Me.AccessType_Combo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessType_Combo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.AccessType_Combo.FormattingEnabled = True
        Me.AccessType_Combo.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.AccessType_Combo.Location = New System.Drawing.Point(379, 343)
        Me.AccessType_Combo.Name = "AccessType_Combo"
        Me.AccessType_Combo.Size = New System.Drawing.Size(336, 31)
        Me.AccessType_Combo.TabIndex = 8
        '
        'MatchPass_txt
        '
        Me.MatchPass_txt.AutoSize = True
        Me.MatchPass_txt.BackColor = System.Drawing.Color.Transparent
        Me.MatchPass_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatchPass_txt.ForeColor = System.Drawing.Color.Red
        Me.MatchPass_txt.Location = New System.Drawing.Point(827, 316)
        Me.MatchPass_txt.Name = "MatchPass_txt"
        Me.MatchPass_txt.Size = New System.Drawing.Size(200, 20)
        Me.MatchPass_txt.TabIndex = 9
        Me.MatchPass_txt.Text = "Password do not match"
        Me.MatchPass_txt.Visible = False
        '
        'HideButton
        '
        Me.HideButton.BackColor = System.Drawing.Color.Transparent
        Me.HideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HideButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideButton.Image = Global.BakeItHappen_SADVBNET.My.Resources.Resources.HideUnhide__1_
        Me.HideButton.Location = New System.Drawing.Point(1079, 218)
        Me.HideButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(34, 32)
        Me.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HideButton.TabIndex = 10
        Me.HideButton.TabStop = False
        Me.HideButton.Visible = False
        '
        'RegisterAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.Reg_an_Acc
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1183, 512)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.MatchPass_txt)
        Me.Controls.Add(Me.AccessType_Combo)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ConfirmPassword_txt)
        Me.Controls.Add(Me.Password_txt)
        Me.Controls.Add(Me.Username_txt)
        Me.Controls.Add(Me.FullName_txt)
        Me.Controls.Add(Me.Avatar_PcBx)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "RegisterAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterAccount"
        CType(Me.Avatar_PcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Avatar_PcBx As PictureBox
    Friend WithEvents FullName_txt As TextBox
    Friend WithEvents Username_txt As TextBox
    Friend WithEvents Password_txt As TextBox
    Friend WithEvents ConfirmPassword_txt As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents Register As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents AccessType_Combo As ComboBox
    Friend WithEvents MatchPass_txt As Label
    Friend WithEvents HideButton As PictureBox
End Class
