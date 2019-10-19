<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.BloodDataSet = New Blood2.BloodDataSet()
        Me.BloodDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet1 = New Blood2.BloodDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NewHospital = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.BloodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BloodDataSet
        '
        Me.BloodDataSet.DataSetName = "BloodDataSet"
        Me.BloodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BloodDataSetBindingSource
        '
        Me.BloodDataSetBindingSource.DataSource = Me.BloodDataSet
        Me.BloodDataSetBindingSource.Position = 0
        '
        'BloodDataSet1
        '
        Me.BloodDataSet1.DataSetName = "BloodDataSet"
        Me.BloodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(634, 230)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 66)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NewHospital
        '
        Me.NewHospital.Location = New System.Drawing.Point(855, 230)
        Me.NewHospital.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NewHospital.Name = "NewHospital"
        Me.NewHospital.Size = New System.Drawing.Size(198, 66)
        Me.NewHospital.TabIndex = 5
        Me.NewHospital.Text = "Hospital /Donor Signup"
        Me.NewHospital.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1269, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(381, 710)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About Us"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1202, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NewHospital)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Home"
        Me.Text = "Blood Donation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BloodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BloodDataSetBindingSource As BindingSource
    Friend WithEvents BloodDataSet As BloodDataSet
    Friend WithEvents BloodDataSet1 As BloodDataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents NewHospital As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
