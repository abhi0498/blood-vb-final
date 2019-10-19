<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenReport
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bgroup = New System.Windows.Forms.TextBox()
        Me.patient = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.dt = New System.Windows.Forms.TextBox()
        Me.donor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Add "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bgroup
        '
        Me.bgroup.AccessibleName = "locality"
        Me.bgroup.Location = New System.Drawing.Point(276, 178)
        Me.bgroup.Name = "bgroup"
        Me.bgroup.Size = New System.Drawing.Size(100, 22)
        Me.bgroup.TabIndex = 41
        '
        'patient
        '
        Me.patient.AccessibleName = "lname"
        Me.patient.Location = New System.Drawing.Point(276, 124)
        Me.patient.Name = "patient"
        Me.patient.Size = New System.Drawing.Size(100, 22)
        Me.patient.TabIndex = 40
        '
        'quantity
        '
        Me.quantity.AccessibleName = "city"
        Me.quantity.Location = New System.Drawing.Point(276, 292)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(100, 22)
        Me.quantity.TabIndex = 39
        '
        'dt
        '
        Me.dt.AccessibleName = "bgroup"
        Me.dt.Location = New System.Drawing.Point(276, 234)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(100, 22)
        Me.dt.TabIndex = 38
        '
        'donor
        '
        Me.donor.AccessibleName = "fname"
        Me.donor.Location = New System.Drawing.Point(276, 65)
        Me.donor.Name = "donor"
        Me.donor.Size = New System.Drawing.Size(100, 22)
        Me.donor.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Blood Group:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Date(YYYY/MM/DD):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Patient Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Donor Name:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(472, 65)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(666, 249)
        Me.dgv.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(508, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 27)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GenReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 490)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bgroup)
        Me.Controls.Add(Me.patient)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.donor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "GenReport"
        Me.Text = "GenReport"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents bgroup As TextBox
    Friend WithEvents patient As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents dt As TextBox
    Friend WithEvents donor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Button2 As Button
End Class
