<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddGolfer
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
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboGenders = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboShirtSizes = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(114, 187)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(125, 20)
        Me.txtZip.TabIndex = 77
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(114, 152)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(125, 20)
        Me.txtState.TabIndex = 76
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(114, 119)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(125, 20)
        Me.txtCity.TabIndex = 75
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(114, 57)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(125, 20)
        Me.txtLastName.TabIndex = 74
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(114, 21)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(125, 20)
        Me.txtFirstName.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Zip Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "First Name"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 372)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 30)
        Me.btnExit.TabIndex = 67
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(42, 372)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(56, 30)
        Me.btnSubmit.TabIndex = 66
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(114, 87)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(125, 20)
        Me.txtAddress.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Address"
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(114, 255)
        Me.txtEMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(125, 20)
        Me.txtEMail.TabIndex = 84
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(114, 222)
        Me.txtPhoneNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(125, 20)
        Me.txtPhoneNum.TabIndex = 83
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 293)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Shirt Size"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 258)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "E - Mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 224)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Phone Number"
        '
        'cboGenders
        '
        Me.cboGenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenders.FormattingEnabled = True
        Me.cboGenders.Location = New System.Drawing.Point(114, 327)
        Me.cboGenders.Name = "cboGenders"
        Me.cboGenders.Size = New System.Drawing.Size(125, 21)
        Me.cboGenders.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 330)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Gender"
        '
        'cboShirtSizes
        '
        Me.cboShirtSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShirtSizes.FormattingEnabled = True
        Me.cboShirtSizes.Location = New System.Drawing.Point(114, 290)
        Me.cboShirtSizes.Name = "cboShirtSizes"
        Me.cboShirtSizes.Size = New System.Drawing.Size(125, 21)
        Me.cboShirtSizes.TabIndex = 88
        '
        'frmAddGolfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 424)
        Me.Controls.Add(Me.cboShirtSizes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboGenders)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "frmAddGolfer"
        Me.Text = "frmAddGolfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEMail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboGenders As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboShirtSizes As ComboBox
End Class
