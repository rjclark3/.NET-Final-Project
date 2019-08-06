Public Class frmEditSponsor
    Private Sub frmEditSponsor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboSponsors_Update()

        RefreshTxt()

    End Sub

    Private Sub cboSponsorsChange(sender As Object, e As EventArgs) Handles cboSponsors.SelectedIndexChanged

        Dim strSelect As String = ""
        Dim strName As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader


        ' open the database
        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Me.Close()

        End If



        ' Build the select statement using PK from name selected
        strSelect = "SELECT strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEMail FROM TSponsors Where intSponsorID = " & cboSponsors.SelectedValue

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load the data table from the reader
        dt.Load(drSourceTable)

        ' populate the text boxes with the data
        txtFirstName.Text = dt.Rows(0).Item(0).ToString
        txtLastName.Text = dt.Rows(0).Item(1).ToString
        txtAddress.Text = dt.Rows(0).Item(2).ToString
        txtCity.Text = dt.Rows(0).Item(3).ToString
        txtState.Text = dt.Rows(0).Item(4).ToString
        txtZip.Text = dt.Rows(0).Item(5).ToString
        txtPhoneNum.Text = dt.Rows(0).Item(6).ToString
        txtEMail.Text = dt.Rows(0).Item(7).ToString


        ' close the database connection
        CloseDatabaseConnection()


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

    Private Sub cboSponsors_Update()

        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Close()

        End If

        ' Show changes all at once at end (MUCH faster). 
        cboSponsors.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT intSponsorID, strLastName + ', ' + strFirstName as strName FROM TSponsors"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the player ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the players data.
        ' We are binding the column name to the combo box display and value members. 
        cboSponsors.ValueMember = "intSponsorID"
        cboSponsors.DisplayMember = "strName"
        cboSponsors.DataSource = dt

        ' Select the first item in the list by default
        If cboSponsors.Items.Count > 0 Then cboSponsors.SelectedIndex = 0

        ' Show any changes
        cboSponsors.EndUpdate()

        ' Clean up
        drSourceTable.Close()

        CloseDatabaseConnection()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSelect As String
        Dim strLastName As String = ""
        Dim strFirstName As String = ""
        Dim strAddress As String = ""
        Dim strCity As String = ""
        Dim strState As String = ""
        Dim strZip As String = ""
        Dim strPhoneNum As String = ""
        Dim strEMail As String = ""
        Dim intShirtSizeID As Integer = 0
        Dim intGenderID As Integer = 0
        Dim intNextHighestRecordID As Integer = 0
        Dim intNextHighestRecordID2 As Integer = 0

        ' thie will hold our Update statement
        Dim cmdUpdate As OleDb.OleDbCommand
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


            ' Build the select statement using PK from name selected
            strSelect = "Update TSponsors Set strFirstName = '" & strFirstName & "', " & "strLastName = '" & strLastName &
                "', " & "strStreetAddress = '" & strAddress & "', " & "strCity = '" & strCity & "', " &
                 "strState = '" & strState & "', " & "strZip = '" & strZip & "', " & "strPhoneNumber = '" & strPhoneNum & "', strEMail = '" & strEMail & "' " &
                 "Where intSponsorID = " & cboSponsors.SelectedValue.ToString  'strLastName, strAddress, strCity, strState, strZip FROM TSponsors Where intSponsorID = " & cboNames.SelectedValue


            ' execute the statement
            cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            ' Insert the row
            intRowsAffected = cmdUpdate.ExecuteNonQuery()

            ' have to let the user know what happened 
            If intRowsAffected = 1 Then
                MessageBox.Show("Update successful")
            Else
                MessageBox.Show("Update failed")
            End If

            ' close the database connection
            CloseDatabaseConnection()



        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strDelete As String = ""
        Dim strSelect As String = String.Empty
        Dim strName As String = ""
        Dim intRowsAffected As Integer
        Dim cmdDelete As OleDb.OleDbCommand ' this will be used for our Delete statement
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim result As DialogResult

        ' open the database
        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Me.Close()

        End If

        ' always ask before deleting!!!!
        result = MessageBox.Show("Are you sure you want to Delete Sponsor: Last Name-" & cboSponsors.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
        Select Case result
            Case DialogResult.Cancel
                MessageBox.Show("Action Canceled")
            Case DialogResult.No
                MessageBox.Show("Action Canceled")
            Case DialogResult.Yes


                ' Build the delete statement using PK from name selected
                ' must delete any child revords first

                strDelete = "Delete FROM TGolferEventYearSponsors Where intSponsorID = " & cboSponsors.SelectedValue.ToString

                ' Delete the record(s) 
                cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
                intRowsAffected = cmdDelete.ExecuteNonQuery()

                ' now we can delete the parent record
                strDelete = "Delete FROM TSponsors Where intSponsorID = " & cboSponsors.SelectedValue.ToString

                ' Delete the record(s) 
                cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
                intRowsAffected = cmdDelete.ExecuteNonQuery()

                ' Did it work?
                If intRowsAffected > 0 Then

                    ' Yes, success
                    MessageBox.Show("Delete successful")

                End If

                cboSponsors_Update()

        End Select


        ' close the database connection
        CloseDatabaseConnection()

        ' call the Form Load sub to refresh the combo box data after a delete
        RefreshTxt()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub



    Dim strSelect As String = ""
    Dim strName As String = ""
    Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
    Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
    Dim dt As DataTable = New DataTable ' this is the table we will load from our reader


    Private Sub RefreshTxt()

        ' open the database
        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Me.Close()

        End If




        ' Build the select statement using PK from name selected
        strSelect = "SELECT strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEMail FROM TSponsors Where intSponsorID = 1"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load the data table from the reader
        dt.Load(drSourceTable)

        ' populate the text boxes with the data
        txtFirstName.Text = dt.Rows(0).Item(0).ToString
        txtLastName.Text = dt.Rows(0).Item(1).ToString
        txtAddress.Text = dt.Rows(0).Item(2).ToString
        txtCity.Text = dt.Rows(0).Item(3).ToString
        txtState.Text = dt.Rows(0).Item(4).ToString
        txtZip.Text = dt.Rows(0).Item(5).ToString
        txtPhoneNum.Text = dt.Rows(0).Item(6).ToString
        txtEMail.Text = dt.Rows(0).Item(7).ToString

        ' close the database connection
        CloseDatabaseConnection()


    End Sub

End Class