<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DonorSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtable = New System.Windows.Forms.DataGridView()
        Me.bgroup = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.locality = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtable
        '
        Me.dtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtable.Location = New System.Drawing.Point(12, 122)
        Me.dtable.Name = "dtable"
        Me.dtable.RowHeadersWidth = 51
        Me.dtable.RowTemplate.Height = 24
        Me.dtable.Size = New System.Drawing.Size(952, 316)
        Me.dtable.TabIndex = 0
        '
        'bgroup
        '
        Me.bgroup.Location = New System.Drawing.Point(264, 68)
        Me.bgroup.Name = "bgroup"
        Me.bgroup.Size = New System.Drawing.Size(214, 22)
        Me.bgroup.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(540, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search Donors"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'locality
        '
        Me.locality.Location = New System.Drawing.Point(264, 12)
        Me.locality.Name = "locality"
        Me.locality.Size = New System.Drawing.Size(214, 22)
        Me.locality.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Locality"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Blood Group"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(729, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 50)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Generate Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(906, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 50)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "View Report"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DonorSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 662)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.locality)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bgroup)
        Me.Controls.Add(Me.dtable)
        Me.Name = "DonorSearch"
        Me.Text = "HospitalForm"
        CType(Me.dtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtable As DataGridView
    Friend WithEvents bgroup As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents locality As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
