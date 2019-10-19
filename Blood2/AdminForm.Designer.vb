<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Me.EHospital = New System.Windows.Forms.Button()
        Me.BloodDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet = New Blood2.BloodDataSet()
        Me.NewAdmin = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.BloodDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EHospital
        '
        Me.EHospital.Location = New System.Drawing.Point(103, 95)
        Me.EHospital.Name = "EHospital"
        Me.EHospital.Size = New System.Drawing.Size(132, 31)
        Me.EHospital.TabIndex = 0
        Me.EHospital.Text = "Delete Users"
        Me.EHospital.UseVisualStyleBackColor = True
        '
        'BloodDataSetBindingSource
        '
        Me.BloodDataSetBindingSource.DataSource = Me.BloodDataSet
        Me.BloodDataSetBindingSource.Position = 0
        '
        'BloodDataSet
        '
        Me.BloodDataSet.DataSetName = "BloodDataSet"
        Me.BloodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NewAdmin
        '
        Me.NewAdmin.Location = New System.Drawing.Point(280, 92)
        Me.NewAdmin.Name = "NewAdmin"
        Me.NewAdmin.Size = New System.Drawing.Size(153, 36)
        Me.NewAdmin.TabIndex = 4
        Me.NewAdmin.Text = "Add New Admin"
        Me.NewAdmin.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AccessibleName = "dgv"
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(103, 235)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(773, 150)
        Me.dgv.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(467, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "View tables"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(813, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 577)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.NewAdmin)
        Me.Controls.Add(Me.EHospital)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        CType(Me.BloodDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EHospital As Button
    Friend WithEvents NewAdmin As Button
    Friend WithEvents BloodDataSetBindingSource As BindingSource
    Friend WithEvents BloodDataSet As BloodDataSet
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
