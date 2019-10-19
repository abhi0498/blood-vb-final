<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.AddAdmin = New System.Windows.Forms.Button()
        Me.NewAdminU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewAdminP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddAdmin
        '
        Me.AddAdmin.Location = New System.Drawing.Point(327, 309)
        Me.AddAdmin.Name = "AddAdmin"
        Me.AddAdmin.Size = New System.Drawing.Size(100, 33)
        Me.AddAdmin.TabIndex = 0
        Me.AddAdmin.Text = "Add"
        Me.AddAdmin.UseVisualStyleBackColor = True
        '
        'NewAdminU
        '
        Me.NewAdminU.Location = New System.Drawing.Point(387, 97)
        Me.NewAdminU.Name = "NewAdminU"
        Me.NewAdminU.Size = New System.Drawing.Size(188, 22)
        Me.NewAdminU.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New Admin Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Admin Password"
        '
        'NewAdminP
        '
        Me.NewAdminP.Location = New System.Drawing.Point(387, 186)
        Me.NewAdminP.Name = "NewAdminP"
        Me.NewAdminP.Size = New System.Drawing.Size(188, 22)
        Me.NewAdminP.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Add New Admin"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 463)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NewAdminP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewAdminU)
        Me.Controls.Add(Me.AddAdmin)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddAdmin As Button
    Friend WithEvents NewAdminU As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NewAdminP As TextBox
    Friend WithEvents Label4 As Label
End Class
