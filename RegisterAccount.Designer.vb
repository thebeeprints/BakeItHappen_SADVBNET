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
        Me.FullName = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Avatar
        '
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.Location = New System.Drawing.Point(42, 156)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(276, 204)
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        '
        'FullName
        '
        Me.FullName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName.ForeColor = System.Drawing.Color.SaddleBrown
        Me.FullName.Location = New System.Drawing.Point(378, 217)
        Me.FullName.Multiline = True
        Me.FullName.Name = "FullName"
        Me.FullName.Size = New System.Drawing.Size(336, 33)
        Me.FullName.TabIndex = 1
        Me.FullName.Text = "Juan Dela Cruz"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Username.Location = New System.Drawing.Point(377, 280)
        Me.Username.Multiline = True
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(336, 33)
        Me.Username.TabIndex = 2
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Password.Location = New System.Drawing.Point(777, 219)
        Me.Password.Multiline = True
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(336, 33)
        Me.Password.TabIndex = 3
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.ConfirmPassword.Location = New System.Drawing.Point(777, 282)
        Me.ConfirmPassword.Multiline = True
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.Size = New System.Drawing.Size(336, 33)
        Me.ConfirmPassword.TabIndex = 4
        '
        'Browse
        '
        Me.Browse.BackColor = System.Drawing.Color.Transparent
        Me.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Browse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ForeColor = System.Drawing.Color.White
        Me.Browse.Location = New System.Drawing.Point(106, 377)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(151, 40)
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
        Me.Register.Location = New System.Drawing.Point(926, 337)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(186, 40)
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
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(44, 36)
        Me.BackButton.TabIndex = 7
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'RegisterAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.RegisterAnAccount
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1183, 512)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.FullName)
        Me.Controls.Add(Me.Avatar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterAccount"
        Me.Text = "RegisterAccount"
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents FullName As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents ConfirmPassword As TextBox
    Friend WithEvents Browse As Button
    Friend WithEvents Register As Button
    Friend WithEvents BackButton As Button
End Class
