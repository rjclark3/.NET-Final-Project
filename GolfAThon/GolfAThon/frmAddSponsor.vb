Public Class frmAddSponsor

    Private Sub btnSubmit_Click_1(sender As Object, e As EventArgs) Handles btnSubmit.Click


        Dim strSelect As String
        Dim strInsert As String
        Dim strLastName As String = ""
        Dim strFirstName As String = ""
        Dim strAddress As String = ""
        Dim strCity As String = ""
        Dim strState As String = ""
        Dim strZip As String = ""
        Dim strPhoneNum As String = ""
        Dim strEMail As String = ""
        Dim intNextHighestRecordID As Integer = 0
        Dim cmdSelect As OleDb.OleDbCommand
        Dim cmdInsert As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim intRowsAffected As Integer




        If Validation() = True Then

            strLastName = txtLastName.Text
            strFirstName = txtFirstName.Text
            strAddress = txtAddress.Text
            strCity = txtCity.Text
            strState = txtState.Text
            strZip = txtZip.Text
            strPhoneNum = txtPhoneNum.Text
            strEMail = txtEMail.Text

            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Close()

            End If

            strSelect = "SELECT MAX(intSponsorID) + 1 AS intNextHighestRecordID FROM TSponsors"

            ' Execute command
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            'Read Result
            drSourceTable.Read()

            If drSourceTable.IsDBNull(0) = True Then

                'yes, start numbering at 1
                intNextHighestRecordID = 1

            Else

                'No, get the next highest ID
                intNextHighestRecordID = CInt(drSourceTable.Item(0))

            End If

            strInsert = "Insert into TSponsors ( intSponsorID, strLastName, strFirstName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEMail )" &
                " Values (" & intNextHighestRecordID & ",'" & strLastName & "', '" & strFirstName & "', '" & strAddress & "','" _
                            & strCity & "', '" & strState & "'," & "'" & strZip & "', '" & strPhoneNum & "', '" & strEMail & "')"

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


            intRowsAffected = cmdInsert.ExecuteNonQuery()

            If intRowsAffected > 0 Then
                MessageBox.Show("Sponsor has been added")
                Me.Close()
            End If

            CloseDatabaseConnection()


        End If



    End Sub

    Public Function Validation() As Boolean

        ' loop through the textboxes and clear them in case they have data in them after a delete
        For Each cntrl As Control In Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.BackColor = Color.White
                If cntrl.Text = String.Empty Then
                    cntrl.BackColor = Color.Yellow
                    cntrl.Focus()
                    Return False
                End If

                If txtLastName.Text = "" Then
                    txtFirstName.Focus()
                    MessageBox.Show("Please enter a Last Name")
                    Return False
                End If

                If txtFirstName.Text = "" Then
                    txtFirstName.Focus()
                    MessageBox.Show("Please enter a First Name")
                    Return False
                End If

                If txtAddress.Text = "" Then
                    txtAddress.Focus()
                    MessageBox.Show("Please enter an address")
                    Return False
                End If

                If txtCity.Text = "" Then
                    txtCity.Focus()
                    MessageBox.Show("Please enter a City")
                    Return False
                End If

                If txtState.Text = "" Then
                    txtState.Focus()
                    MessageBox.Show("Please enter a State")
                    Return False
                End If

                If txtZip.Text = "" Then
                    txtZip.Focus()
                    MessageBox.Show("Please enter a Zip Code")
                    Return False
                End If

                If txtPhoneNum.Text = "" Then
                    txtZip.Focus()
                    MessageBox.Show("Please enter a Phone Number")
                    Return False
                End If

                If txtEMail.Text = "" Then
                    txtZip.Focus()
                    MessageBox.Show("Please enter an E Mail")
                    Return False
                End If



            End If
        Next

        'this is good so return true
        Return True

    End Function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class