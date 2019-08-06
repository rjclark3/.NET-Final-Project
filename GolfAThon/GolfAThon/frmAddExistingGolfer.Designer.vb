<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddExistingGolfer
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboEvents = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboGolfers = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnNewGolfer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(97, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 23)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Event:"
        '
        'cboEvents
        '
        Me.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEvents.FormattingEnabled = True
        Me.cboEvents.Location = New System.Drawing.Point(150, 217)
        Me.cboEvents.Name = "cboEvents"
        Me.cboEvents.Size = New System.Drawing.Size(121, 21)
        Me.cboEvents.TabIndex = 115
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(101, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 13)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Which Event Would you like to attend?"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Golfer:"
        '
        'cboGolfers
        '
        Me.cboGolfers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGolfers.FormattingEnabled = True
        Me.cboGolfers.Location = New System.Drawing.Point(79, 40)
        Me.cboGolfers.Name = "cboGolfers"
        Me.cboGolfers.Size = New System.Drawing.Size(232, 21)
        Me.cboGolfers.TabIndex = 117
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(286, 342)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 30)
        Me.btnExit.TabIndex = 120
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(23, 342)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(56, 30)
        Me.btnSubmit.TabIndex = 119
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnNewGolfer
        '
        Me.btnNewGolfer.Location = New System.Drawing.Point(150, 342)
        Me.btnNewGolfer.Name = "btnNewGolfer"
        Me.btnNewGolfer.Size = New System.Drawing.Size(68, 30)
        Me.btnNewGolfer.TabIndex = 121
        Me.btnNewGolfer.Text = "New Golfer"
        Me.btnNewGolfer.UseVisualStyleBackColor = True
        '
        'frmAddExistingGolfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 450)
        Me.Controls.Add(Me.btnNewGolfer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboGolfers)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboEvents)
        Me.Controls.Add(Me.Label11)
        Me.Name = "frmAddExistingGolfer"
        Me.Text = "frmAddExistentGolfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents cboEvents As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboGolfers As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnNewGolfer As Button
End Class
