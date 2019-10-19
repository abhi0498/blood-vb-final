<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonorPage
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
        Me.loc = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.phno = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.TextBox()
        Me.bgroup = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sout = New System.Windows.Forms.Button()
        Me.DonorDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'DonorDetails
        '
        Me.DonorDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DonorDetails.Controls.Add(Me.sout)
        Me.DonorDetails.Controls.Add(Me.Button2)
        Me.DonorDetails.Controls.Add(Me.loc)
        Me.DonorDetails.Controls.Add(Me.lname)
        Me.DonorDetails.Controls.Add(Me.phno)
        Me.DonorDetails.Controls.Add(Me.city)
        Me.DonorDetails.Controls.Add(Me.bgroup)
        Me.DonorDetails.Controls.Add(Me.fname)
        Me.DonorDetails.Controls.Add(Me.Label10)
        Me.DonorDetails.Controls.Add(Me.Label7)
        Me.DonorDetails.Controls.Add(Me.Label6)
        Me.DonorDetails.Controls.Add(Me.Label5)
        Me.DonorDetails.Controls.Add(Me.Label4)
        Me.DonorDetails.Controls.Add(Me.Label3)
        Me.DonorDetails.Controls.Add(Me.Label2)
        Me.DonorDetails.Controls.Add(Me.Label1)
        Me.DonorDetails.Controls.Add(Me.Button1)
        Me.DonorDetails.Location = New System.Drawing.Point(309, 12)
        Me.DonorDetails.Name = "DonorDetails"
        Me.DonorDetails.Size = New System.Drawing.Size(468, 652)
        Me.DonorDetails.TabIndex = 0
        Me.DonorDetails.TabStop = False
        Me.DonorDetails.Text = "Donor Details"
        '
        'loc
        '
        Me.loc.AccessibleName = "locality"
        Me.loc.Location = New System.Drawing.Point(263, 343)
        Me.loc.Name = "loc"
        Me.loc.Size = New System.Drawing.Size(100, 22)
        Me.loc.TabIndex = 16
        '
        'lname
        '
        Me.lname.AccessibleName = "lname"
        Me.lname.Location = New System.Drawing.Point(263, 228)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(100, 22)
        Me.lname.TabIndex = 15
        '
        'phno
        '
        Me.phno.AccessibleName = "phno"
        Me.phno.Location = New System.Drawing.Point(263, 447)
        Me.phno.Name = "phno"
        Me.phno.Size = New System.Drawing.Size(100, 22)
        Me.phno.TabIndex = 14
        '
        'city
        '
        Me.city.AccessibleName = "city"
        Me.city.Location = New System.Drawing.Point(263, 396)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(100, 22)
        Me.city.TabIndex = 13
        '
        'bgroup
        '
        Me.bgroup.AccessibleName = "bgroup"
        Me.bgroup.Location = New System.Drawing.Point(263, 290)
        Me.bgroup.Name = "bgroup"
        Me.bgroup.Size = New System.Drawing.Size(100, 22)
        Me.bgroup.TabIndex = 12
        '
        'fname
        '
        Me.fname.AccessibleName = "fname"
        Me.fname.Location = New System.Drawing.Point(263, 169)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(100, 22)
        Me.fname.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Label10"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 452)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone No.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Locality:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Blood Group:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(326, 540)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 56)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Delete my account"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sout
        '
        Me.sout.Location = New System.Drawing.Point(376, 11)
        Me.sout.Name = "sout"
        Me.sout.Size = New System.Drawing.Size(86, 34)
        Me.sout.TabIndex = 18
        Me.sout.Text = "Sign-out"
        Me.sout.UseVisualStyleBackColor = True
        '
        'DonorPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 688)
        Me.Controls.Add(Me.DonorDetails)
        Me.Name = "DonorPage"
        Me.Text = "DonorPage"
        Me.DonorDetails.ResumeLayout(False)
        Me.DonorDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DonorDetails As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents loc As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents phno As TextBox
    Friend WithEvents city As TextBox
    Friend WithEvents bgroup As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents sout As Button
    Friend WithEvents Button2 As Button
End Class
