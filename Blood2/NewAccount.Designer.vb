<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAccount
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.AddAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Account Type"
        '
        'Type
        '
        Me.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"Hospital", "Donor"})
        Me.Type.Location = New System.Drawing.Point(385, 120)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(188, 24)
        Me.Type.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(385, 193)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(188, 22)
        Me.Pass.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(385, 68)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(188, 22)
        Me.user.TabIndex = 15
        '
        'AddAdmin
        '
        Me.AddAdmin.Location = New System.Drawing.Point(307, 279)
        Me.AddAdmin.Name = "AddAdmin"
        Me.AddAdmin.Size = New System.Drawing.Size(171, 33)
        Me.AddAdmin.TabIndex = 14
        Me.AddAdmin.Text = "Add Account"
        Me.AddAdmin.UseVisualStyleBackColor = True
        '
        'NewAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.AddAdmin)
        Me.Name = "NewAccount"
        Me.Text = "NewAccount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Type As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents AddAdmin As Button
End Class
