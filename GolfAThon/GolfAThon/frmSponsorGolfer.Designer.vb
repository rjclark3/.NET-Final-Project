<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSponsorGolfer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEvents = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSponsors = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboGolfers = New System.Windows.Forms.ComboBox()
        Me.cboSponsorTypes = New System.Windows.Forms.ComboBox()
        Me.cboPaymentTypes = New System.Windows.Forms.ComboBox()
        Me.txtPledge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkPayment = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(102, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Event:"
        '
        'cboEvents
        '
        Me.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEvents.FormattingEnabled = True
        Me.cboEvents.Location = New System.Drawing.Point(155, 25)
        Me.cboEvents.Name = "cboEvents"
        Me.cboEvents.Size = New System.Drawing.Size(121, 21)
        Me.cboEvents.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(35, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 23)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Sponsor:"
        '
        'cboSponsors
        '
        Me.cboSponsors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSponsors.FormattingEnabled = True
        Me.cboSponsors.Location = New System.Drawing.Point(94, 101)
        Me.cboSponsors.Name = "cboSponsors"
        Me.cboSponsors.Size = New System.Drawing.Size(232, 21)
        Me.cboSponsors.TabIndex = 156
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(35, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Golfer:"
        '
        'cboGolfers
        '
        Me.cboGolfers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGolfers.FormattingEnabled = True
        Me.cboGolfers.Location = New System.Drawing.Point(94, 297)
        Me.cboGolfers.Name = "cboGolfers"
        Me.cboGolfers.Size = New System.Drawing.Size(232, 21)
        Me.cboGolfers.TabIndex = 158
        '
        'cboSponsorTypes
        '
        Me.cboSponsorTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSponsorTypes.FormattingEnabled = True
        Me.cboSponsorTypes.Location = New System.Drawing.Point(155, 158)
        Me.cboSponsorTypes.Name = "cboSponsorTypes"
        Me.cboSponsorTypes.Size = New System.Drawing.Size(121, 21)
        Me.cboSponsorTypes.TabIndex = 160
        '
        'cboPaymentTypes
        '
        Me.cboPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentTypes.FormattingEnabled = True
        Me.cboPaymentTypes.Location = New System.Drawing.Point(155, 200)
        Me.cboPaymentTypes.Name = "cboPaymentTypes"
        Me.cboPaymentTypes.Size = New System.Drawing.Size(121, 21)
        Me.cboPaymentTypes.TabIndex = 161
        '
        'txtPledge
        '
        Me.txtPledge.Location = New System.Drawing.Point(154, 247)
        Me.txtPledge.Name = "txtPledge"
        Me.txtPledge.Size = New System.Drawing.Size(172, 20)
        Me.txtPledge.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "Sponsor Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Payment Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Pledge Amount"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(53, 372)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 49)
        Me.btnSubmit.TabIndex = 166
        Me.btnSubmit.Text = "Sponsor This Golfer!"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(243, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 49)
        Me.btnExit.TabIndex = 167
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkPayment
        '
        Me.chkPayment.AutoSize = True
        Me.chkPayment.Location = New System.Drawing.Point(130, 339)
        Me.chkPayment.Name = "chkPayment"
        Me.chkPayment.Size = New System.Drawing.Size(180, 17)
        Me.chkPayment.TabIndex = 168
        Me.chkPayment.Text = "The Payment has been received"
        Me.chkPayment.UseVisualStyleBackColor = True
        '
        'frmSponsorGolfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 449)
        Me.Controls.Add(Me.chkPayment)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPledge)
        Me.Controls.Add(Me.cboPaymentTypes)
        Me.Controls.Add(Me.cboSponsorTypes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboGolfers)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboSponsors)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEvents)
        Me.Name = "frmSponsorGolfer"
        Me.Text = "frmSponsorGolfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboEvents As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboSponsors As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboGolfers As ComboBox
    Friend WithEvents cboSponsorTypes As ComboBox
    Friend WithEvents cboPaymentTypes As ComboBox
    Friend WithEvents txtPledge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkPayment As CheckBox
End Class
