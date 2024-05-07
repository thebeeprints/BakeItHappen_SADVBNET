<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.Sign_In = New System.Windows.Forms.Button()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.HideButton = New System.Windows.Forms.PictureBox()
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_txt
        '
        Me.username_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.username_txt.Location = New System.Drawing.Point(337, 323)
        Me.username_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(433, 39)
        Me.username_txt.TabIndex = 0
        Me.username_txt.Text = "Username"
        '
        'Sign_In
        '
        Me.Sign_In.BackColor = System.Drawing.Color.PeachPuff
        Me.Sign_In.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sign_In.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sign_In.Location = New System.Drawing.Point(435, 465)
        Me.Sign_In.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sign_In.Name = "Sign_In"
        Me.Sign_In.Size = New System.Drawing.Size(189, 46)
        Me.Sign_In.TabIndex = 2
        Me.Sign_In.Text = "Sign In"
        Me.Sign_In.UseVisualStyleBackColor = False
        '
        'password_txt
        '
        Me.password_txt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.password_txt.Location = New System.Drawing.Point(338, 406)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(433, 39)
        Me.password_txt.TabIndex = 6
        Me.password_txt.Text = "Password"
        Me.password_txt.UseSystemPasswordChar = True
        '
        'HideButton
        '
        Me.HideButton.BackColor = System.Drawing.Color.Transparent
        Me.HideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HideButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideButton.Image = Global.BakeItHappen_SADVBNET.My.Resources.Resources.HideUnhide__1_
        Me.HideButton.Location = New System.Drawing.Point(722, 402)
        Me.HideButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(51, 44)
        Me.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HideButton.TabIndex = 7
        Me.HideButton.TabStop = False
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BakeItHappen_SADVBNET.My.Resources.Resources.LOADING_FORM__1_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 582)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.Sign_In)
        Me.Controls.Add(Me.username_txt)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BakeITHappen"
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_txt As TextBox
    Friend WithEvents Sign_In As Button
    Friend WithEvents password_txt As TextBox
    Friend WithEvents HideButton As PictureBox
End Class
