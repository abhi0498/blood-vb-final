<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonorForm
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
        Me.DonorDetails = New System.Windows.Forms.GroupBox()
        Me.DonorName = New System.Windows.Forms.Label()
        Me.DonorDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'DonorDetails
        '
        Me.DonorDetails.Controls.Add(Me.DonorName)
        Me.DonorDetails.Location = New System.Drawing.Point(616, 12)
        Me.DonorDetails.Name = "DonorDetails"
        Me.DonorDetails.Size = New System.Drawing.Size(315, 534)
        Me.DonorDetails.TabIndex = 0
        Me.DonorDetails.TabStop = False
        Me.DonorDetails.Text = "Donor Details"
        '
        'DonorName
        '
        Me.DonorName.AutoSize = True
        Me.DonorName.Location = New System.Drawing.Point(17, 77)
        Me.DonorName.Name = "DonorName"
        Me.DonorName.Size = New System.Drawing.Size(51, 17)
        Me.DonorName.TabIndex = 0
        Me.DonorName.Text = "Label1"
        '
        'DonorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 569)
        Me.Controls.Add(Me.DonorDetails)
        Me.Name = "DonorForm"
        Me.Text = "DonorForm"
        Me.DonorDetails.ResumeLayout(False)
        Me.DonorDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DonorDetails As GroupBox
    Friend WithEvents DonorName As Label
End Class
