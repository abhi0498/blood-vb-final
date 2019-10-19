<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTables
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
        Me.Patient = New System.Windows.Forms.DataGridView()
        Me.Donor = New System.Windows.Forms.DataGridView()
        Me.Donations = New System.Windows.Forms.DataGridView()
        Me.Accounts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Patient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patient
        '
        Me.Patient.AllowUserToAddRows = False
        Me.Patient.AllowUserToDeleteRows = False
        Me.Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Patient.Location = New System.Drawing.Point(12, 45)
        Me.Patient.Name = "Patient"
        Me.Patient.ReadOnly = True
        Me.Patient.RowHeadersWidth = 51
        Me.Patient.RowTemplate.Height = 24
        Me.Patient.Size = New System.Drawing.Size(576, 296)
        Me.Patient.TabIndex = 0
        '
        'Donor
        '
        Me.Donor.AllowUserToAddRows = False
        Me.Donor.AllowUserToDeleteRows = False
        Me.Donor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Donor.Location = New System.Drawing.Point(624, 45)
        Me.Donor.Name = "Donor"
        Me.Donor.ReadOnly = True
        Me.Donor.RowHeadersWidth = 51
        Me.Donor.RowTemplate.Height = 24
        Me.Donor.Size = New System.Drawing.Size(591, 296)
        Me.Donor.TabIndex = 1
        '
        'Donations
        '
        Me.Donations.AllowUserToAddRows = False
        Me.Donations.AllowUserToDeleteRows = False
        Me.Donations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Donations.Location = New System.Drawing.Point(12, 461)
        Me.Donations.Name = "Donations"
        Me.Donations.ReadOnly = True
        Me.Donations.RowHeadersWidth = 51
        Me.Donations.RowTemplate.Height = 24
        Me.Donations.Size = New System.Drawing.Size(576, 296)
        Me.Donations.TabIndex = 2
        '
        'Accounts
        '
        Me.Accounts.AllowUserToAddRows = False
        Me.Accounts.AllowUserToDeleteRows = False
        Me.Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Accounts.Location = New System.Drawing.Point(624, 461)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.ReadOnly = True
        Me.Accounts.RowHeadersWidth = 51
        Me.Accounts.RowTemplate.Height = 24
        Me.Accounts.Size = New System.Drawing.Size(591, 296)
        Me.Accounts.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Patients"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(618, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Donors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Blood Donations"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(618, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "User Accounts"
        '
        'ViewTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 791)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Accounts)
        Me.Controls.Add(Me.Donations)
        Me.Controls.Add(Me.Donor)
        Me.Controls.Add(Me.Patient)
        Me.Name = "ViewTables"
        Me.Text = "View Tables"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Patient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Patient As DataGridView
    Friend WithEvents Donor As DataGridView
    Friend WithEvents Donations As DataGridView
    Friend WithEvents Accounts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
