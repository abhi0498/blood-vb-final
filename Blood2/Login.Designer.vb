<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.AdminBtn = New System.Windows.Forms.Button()
        Me.DonorBtn = New System.Windows.Forms.Button()
        Me.HospitalBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AdminFP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AdminBtn
        '
        Me.AdminBtn.Location = New System.Drawing.Point(48, 374)
        Me.AdminBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AdminBtn.Name = "AdminBtn"
        Me.AdminBtn.Size = New System.Drawing.Size(136, 45)
        Me.AdminBtn.TabIndex = 0
        Me.AdminBtn.Text = "Admin Login"
        Me.AdminBtn.UseVisualStyleBackColor = True
        '
        'DonorBtn
        '
        Me.DonorBtn.Location = New System.Drawing.Point(821, 374)
        Me.DonorBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DonorBtn.Name = "DonorBtn"
        Me.DonorBtn.Size = New System.Drawing.Size(135, 45)
        Me.DonorBtn.TabIndex = 2
        Me.DonorBtn.Text = "Donor Login"
        Me.DonorBtn.UseVisualStyleBackColor = True
        '
        'HospitalBtn
        '
        Me.HospitalBtn.Location = New System.Drawing.Point(474, 374)
        Me.HospitalBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HospitalBtn.Name = "HospitalBtn"
        Me.HospitalBtn.Size = New System.Drawing.Size(130, 45)
        Me.HospitalBtn.TabIndex = 3
        Me.HospitalBtn.Text = "Hospital Login"
        Me.HospitalBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(153, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Login Details"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(380, 234)
        Me.Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.ShortcutsEnabled = False
        Me.Password.Size = New System.Drawing.Size(190, 24)
        Me.Password.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(380, 156)
        Me.User.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(190, 24)
        Me.User.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Username"
        '
        'AdminFP
        '
        Me.AdminFP.Location = New System.Drawing.Point(810, 34)
        Me.AdminFP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AdminFP.Name = "AdminFP"
        Me.AdminFP.Size = New System.Drawing.Size(172, 40)
        Me.AdminFP.TabIndex = 16
        Me.AdminFP.Text = "Forgot Password"
        Me.AdminFP.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1179, 703)
        Me.Controls.Add(Me.AdminFP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HospitalBtn)
        Me.Controls.Add(Me.DonorBtn)
        Me.Controls.Add(Me.AdminBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdminBtn As Button
    Friend WithEvents DonorBtn As Button
    Friend WithEvents HospitalBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents User As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AdminFP As Button
End Class
