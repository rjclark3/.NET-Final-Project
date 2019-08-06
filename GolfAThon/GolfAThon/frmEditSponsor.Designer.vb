<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditSponsor
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
        Me.cboEvent = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSponsors = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboEvent
        '
        Me.cboEvent.FormattingEnabled = True
        Me.cboEvent.Location = New System.Drawing.Point(262, -35)
        Me.cboEvent.Name = "cboEvent"
        Me.cboEvent.Size = New System.Drawing.Size(121, 21)
        Me.cboEvent.TabIndex = 10
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(122, 335)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 30)
        Me.btnDelete.TabIndex = 135
        Me.btnDelete.Text = "Delete Golfer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(155, 297)
        Me.txtEMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(125, 20)
        Me.txtEMail.TabIndex = 153
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(155, 264)
        Me.txtPhoneNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(125, 20)
        Me.txtPhoneNum.TabIndex = 152
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(155, 129)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(125, 20)
        Me.txtAddress.TabIndex = 148
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(155, 229)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(125, 20)
        Me.txtZip.TabIndex = 151
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(155, 194)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(125, 20)
        Me.txtState.TabIndex = 150
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(155, 161)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(125, 20)
        Me.txtCity.TabIndex = 149
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(155, 99)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(125, 20)
        Me.txtLastName.TabIndex = 147
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(155, 63)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(125, 20)
        Me.txtFirstName.TabIndex = 146
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 300)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "E - Mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 266)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 144
        Me.Label9.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Zip Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "First Name"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 335)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 30)
        Me.btnExit.TabIndex = 137
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(44, 335)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(56, 30)
        Me.btnSubmit.TabIndex = 136
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 23)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Sponsor:"
        '
        'cboSponsors
        '
        Me.cboSponsors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSponsors.FormattingEnabled = True
        Me.cboSponsors.Location = New System.Drawing.Point(75, 21)
        Me.cboSponsors.Name = "cboSponsors"
        Me.cboSponsors.Size = New System.Drawing.Size(232, 21)
        Me.cboSponsors.TabIndex = 154
        '
        'frmEditSponsor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 389)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboSponsors)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboEvent)
        Me.Name = "frmEditSponsor"
        Me.Text = "Edit Sponsors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEvent As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtEMail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cboSponsors As ComboBox
End Class
