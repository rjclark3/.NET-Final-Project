<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnNewGolfer = New System.Windows.Forms.Button()
        Me.btnSponsorGolfer = New System.Windows.Forms.Button()
        Me.cboEvents = New System.Windows.Forms.ComboBox()
        Me.lstSponsors = New System.Windows.Forms.ListBox()
        Me.btnEditGolfer = New System.Windows.Forms.Button()
        Me.btnEditSponsor = New System.Windows.Forms.Button()
        Me.btnNewSponsor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewGolfer
        '
        Me.btnNewGolfer.Location = New System.Drawing.Point(102, 281)
        Me.btnNewGolfer.Name = "btnNewGolfer"
        Me.btnNewGolfer.Size = New System.Drawing.Size(112, 61)
        Me.btnNewGolfer.TabIndex = 0
        Me.btnNewGolfer.Text = "New Golfer"
        Me.btnNewGolfer.UseVisualStyleBackColor = True
        '
        'btnSponsorGolfer
        '
        Me.btnSponsorGolfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSponsorGolfer.Location = New System.Drawing.Point(298, 116)
        Me.btnSponsorGolfer.Name = "btnSponsorGolfer"
        Me.btnSponsorGolfer.Size = New System.Drawing.Size(174, 120)
        Me.btnSponsorGolfer.TabIndex = 1
        Me.btnSponsorGolfer.Text = "I Want to Sponsor a Golfer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSponsorGolfer.UseVisualStyleBackColor = True
        '
        'cboEvents
        '
        Me.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEvents.FormattingEnabled = True
        Me.cboEvents.Location = New System.Drawing.Point(696, 44)
        Me.cboEvents.Name = "cboEvents"
        Me.cboEvents.Size = New System.Drawing.Size(121, 21)
        Me.cboEvents.TabIndex = 2
        '
        'lstSponsors
        '
        Me.lstSponsors.FormattingEnabled = True
        Me.lstSponsors.Items.AddRange(New Object() {"Sponsor" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Pledge Amount" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Golfer" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Golfer Raise Amount", "_________________________________________________________________________________" &
                "___________________"})
        Me.lstSponsors.Location = New System.Drawing.Point(529, 105)
        Me.lstSponsors.Name = "lstSponsors"
        Me.lstSponsors.Size = New System.Drawing.Size(435, 433)
        Me.lstSponsors.TabIndex = 3
        '
        'btnEditGolfer
        '
        Me.btnEditGolfer.Location = New System.Drawing.Point(102, 357)
        Me.btnEditGolfer.Name = "btnEditGolfer"
        Me.btnEditGolfer.Size = New System.Drawing.Size(112, 61)
        Me.btnEditGolfer.TabIndex = 5
        Me.btnEditGolfer.Text = "Edit / Delete Golfer"
        Me.btnEditGolfer.UseVisualStyleBackColor = True
        '
        'btnEditSponsor
        '
        Me.btnEditSponsor.Location = New System.Drawing.Point(325, 357)
        Me.btnEditSponsor.Name = "btnEditSponsor"
        Me.btnEditSponsor.Size = New System.Drawing.Size(112, 61)
        Me.btnEditSponsor.TabIndex = 17
        Me.btnEditSponsor.Text = "Edit Sponsor"
        Me.btnEditSponsor.UseVisualStyleBackColor = True
        '
        'btnNewSponsor
        '
        Me.btnNewSponsor.Location = New System.Drawing.Point(325, 281)
        Me.btnNewSponsor.Name = "btnNewSponsor"
        Me.btnNewSponsor.Size = New System.Drawing.Size(112, 61)
        Me.btnNewSponsor.TabIndex = 16
        Me.btnNewSponsor.Text = "New Sponsor"
        Me.btnNewSponsor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(643, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Event:"
        '
        'btnSignUp
        '
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(67, 116)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(174, 120)
        Me.btnSignUp.TabIndex = 23
        Me.btnSignUp.Text = "Sign up to golf in an event"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 561)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditSponsor)
        Me.Controls.Add(Me.btnNewSponsor)
        Me.Controls.Add(Me.btnEditGolfer)
        Me.Controls.Add(Me.lstSponsors)
        Me.Controls.Add(Me.cboEvents)
        Me.Controls.Add(Me.btnSponsorGolfer)
        Me.Controls.Add(Me.btnNewGolfer)
        Me.Name = "frmMain"
        Me.Text = "Golf A' Thon"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewGolfer As Button
    Friend WithEvents btnSponsorGolfer As Button
    Friend WithEvents cboEvents As ComboBox
    Friend WithEvents lstSponsors As ListBox
    Friend WithEvents btnEditGolfer As Button
    Friend WithEvents btnEditSponsor As Button
    Friend WithEvents btnNewSponsor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignUp As Button
End Class
