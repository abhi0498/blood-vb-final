<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.oldPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.AddAdmin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.newPass = New System.Windows.Forms.TextBox()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Old Password"
        '
        'oldPass
        '
        Me.oldPass.Location = New System.Drawing.Point(385, 184)
        Me.oldPass.Name = "oldPass"
        Me.oldPass.Size = New System.Drawing.Size(188, 22)
        Me.oldPass.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(385, 59)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(188, 22)
        Me.user.TabIndex = 6
        '
        'AddAdmin
        '
        Me.AddAdmin.Location = New System.Drawing.Point(347, 340)
        Me.AddAdmin.Name = "AddAdmin"
        Me.AddAdmin.Size = New System.Drawing.Size(171, 33)
        Me.AddAdmin.TabIndex = 5
        Me.AddAdmin.Text = "Change Password"
        Me.AddAdmin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "New Password"
        '
        'newPass
        '
        Me.newPass.Location = New System.Drawing.Point(385, 261)
        Me.newPass.Name = "newPass"
        Me.newPass.Size = New System.Drawing.Size(188, 22)
        Me.newPass.TabIndex = 10
        '
        'Type
        '
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"Admin", "Hospital", "Donor"})
        Me.Type.Location = New System.Drawing.Point(385, 111)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(188, 24)
        Me.Type.TabIndex = 12
        Me.Type.Text = "Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Account Type"
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.newPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.oldPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.AddAdmin)
        Me.Name = "ForgotPassword"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents oldPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents AddAdmin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents newPass As TextBox
    Friend WithEvents Type As ComboBox
    Friend WithEvents Label4 As Label
End Class
