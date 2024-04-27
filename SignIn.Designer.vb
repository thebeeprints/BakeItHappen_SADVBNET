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
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Sign_In = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HideButton = New System.Windows.Forms.PictureBox()
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(337, 320)
        Me.Username.Multiline = True
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(433, 44)
        Me.Username.TabIndex = 0
        '
        'Sign_In
        '
        Me.Sign_In.BackColor = System.Drawing.Color.PeachPuff
        Me.Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sign_In.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sign_In.Location = New System.Drawing.Point(435, 465)
        Me.Sign_In.Name = "Sign_In"
        Me.Sign_In.Size = New System.Drawing.Size(190, 46)
        Me.Sign_In.TabIndex = 2
        Me.Sign_In.Text = "Sign In"
        Me.Sign_In.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(337, 403)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(433, 44)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'HideButton
        '
        Me.HideButton.BackColor = System.Drawing.Color.Transparent
        Me.HideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HideButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideButton.Image = Global.BakeItHappen_SADVBNET.My.Resources.Resources.HideUnhide__1_
        Me.HideButton.Location = New System.Drawing.Point(719, 403)
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
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Sign_In)
        Me.Controls.Add(Me.Username)
        Me.DoubleBuffered = True
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignIn"
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents Sign_In As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents HideButton As PictureBox
End Class
