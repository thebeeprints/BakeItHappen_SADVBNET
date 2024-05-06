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
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.FullName_txt = New System.Windows.Forms.TextBox()
        Me.Username_txt = New System.Windows.Forms.TextBox()
        Me.Password_txt = New System.Windows.Forms.TextBox()
        Me.ConfirmPassword_txt = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Avatar
        '
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.Location = New System.Drawing.Point(32, 127)
        Me.Avatar.Margin = New System.Windows.Forms.Padding(2)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(207, 166)
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        '
        'FullName_txt
        '
        Me.FullName_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.FullName_txt.Location = New System.Drawing.Point(284, 176)
        Me.FullName_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.FullName_txt.Multiline = True
        Me.FullName_txt.Name = "FullName_txt"
        Me.FullName_txt.Size = New System.Drawing.Size(253, 28)
        Me.FullName_txt.TabIndex = 1
        '
        'Username_txt
        '
        Me.Username_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Username_txt.Location = New System.Drawing.Point(283, 228)
        Me.Username_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Username_txt.Multiline = True
        Me.Username_txt.Name = "Username_txt"
        Me.Username_txt.Size = New System.Drawing.Size(253, 28)
        Me.Username_txt.TabIndex = 2
        '
        'Password_txt
        '
        Me.Password_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Password_txt.Location = New System.Drawing.Point(583, 178)
        Me.Password_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Password_txt.Multiline = True
        Me.Password_txt.Name = "Password_txt"
        Me.Password_txt.Size = New System.Drawing.Size(253, 28)
        Me.Password_txt.TabIndex = 3
        '
        'ConfirmPassword_txt
        '
        Me.ConfirmPassword_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.ConfirmPassword_txt.Location = New System.Drawing.Point(583, 229)
        Me.ConfirmPassword_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.ConfirmPassword_txt.Multiline = True
        Me.ConfirmPassword_txt.Name = "ConfirmPassword_txt"
        Me.ConfirmPassword_txt.Size = New System.Drawing.Size(253, 28)
        Me.ConfirmPassword_txt.TabIndex = 4
        '
        'Browse
        '
        Me.Browse.BackColor = System.Drawing.Color.Transparent
        Me.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Browse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.Color.White
        Me.Browse.Location = New System.Drawing.Point(80, 306)
        Me.Browse.Margin = New System.Windows.Forms.Padding(2)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(113, 32)
        Me.Browse.TabIndex = 5
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.Register.BackColor = System.Drawing.Color.Transparent
        Me.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Register.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Register.Location = New System.Drawing.Point(694, 274)
        Me.Register.Margin = New System.Windows.Forms.Padding(2)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(140, 32)
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
        Me.BackButton.Location = New System.Drawing.Point(13, 16)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(33, 29)
        Me.BackButton.TabIndex = 7
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'RegisterAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.RegisterAnAccount
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(887, 416)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ConfirmPassword_txt)
        Me.Controls.Add(Me.Password_txt)
        Me.Controls.Add(Me.Username_txt)
        Me.Controls.Add(Me.FullName_txt)
        Me.Controls.Add(Me.Avatar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RegisterAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterAccount"
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents FullName_txt As TextBox
    Friend WithEvents Username_txt As TextBox
    Friend WithEvents Password_txt As TextBox
    Friend WithEvents ConfirmPassword_txt As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents Register As Button
    Friend WithEvents BackButton As Button
End Class
