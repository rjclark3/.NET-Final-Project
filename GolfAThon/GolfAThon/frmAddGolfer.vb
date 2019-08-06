Public Class frmAddGolfer
    Private result As DialogResult

    Private Sub frmAddGolfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboShirtSizes_Update()

        cboGenders_Update()

    End Sub


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
        Dim intShirtSizeID As Integer = 0
        Dim intGenderID As Integer = 0
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

            strSelect = "SELECT MAX(intGolferID) + 1 AS intNextHighestRecordID FROM TGolfers"

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

            strInsert = "Insert into TGolfers ( intGolferID, strLastName, strFirstName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEMail, intShirtSizeID, intGenderID )" &
                " Values (" & intNextHighestRecordID & ",'" & strLastName & "', '" & strFirstName & "', '" & strAddress & "','" _
                            & strCity & "', '" & strState & "'," & "'" & strZip & "', '" & strPhoneNum & "', '" & strEMail & "', " & cboShirtSizes.SelectedValue & ", " & cboGenders.SelectedValue & ")"

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


            intRowsAffected = cmdInsert.ExecuteNonQuery()

            If intRowsAffected > 0 Then
                MessageBox.Show("Golfer has been added")
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



    Private Sub cboShirtSizes_Update()

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
        cboShirtSizes.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT intShirtSizeID, strShirtSizeDesc FROM TShirtSizes"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the player ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the players data.
        ' We are binding the column name to the combo box display and value members. 
        cboShirtSizes.ValueMember = "intShirtSizeID"
        cboShirtSizes.DisplayMember = "strShirtSizeDesc"
        cboShirtSizes.DataSource = dt



        ' Select the first item in the list by default
        If cboShirtSizes.Items.Count > 0 Then cboShirtSizes.SelectedIndex = 0

        ' Show any changes
        cboShirtSizes.EndUpdate()

        ' Clean up
        drSourceTable.Close()

        CloseDatabaseConnection()
    End Sub

    Private Sub cboGenders_Update()

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
        cboGenders.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT intGenderID, strGenderDesc FROM TGenders"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the player ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the players data.
        ' We are binding the column name to the combo box display and value members. 
        cboGenders.ValueMember = "intGenderID"
        cboGenders.DisplayMember = "strGenderDesc"
        cboGenders.DataSource = dt



        ' Select the first item in the list by default
        If cboGenders.Items.Count > 0 Then cboGenders.SelectedIndex = 0

        ' Show any changes
        cboGenders.EndUpdate()

        ' Clean up
        drSourceTable.Close()

        CloseDatabaseConnection()
    End Sub

End Class