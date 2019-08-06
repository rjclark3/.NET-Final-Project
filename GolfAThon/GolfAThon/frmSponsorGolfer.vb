Public Class frmSponsorGolfer
    Private Sub frmSponsorGolfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Close()

        End If

        cboEvents_Update()

        cboGolfers_Update()

        cboSponsors_Update()

        cboSponsorTypes_Update()

        cboPaymentTypes_Update()

        CloseDatabaseConnection()

    End Sub

    Private Sub cboGolfers_Update()

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
        cboGolfers.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT TG.intGolferID, TG.strLastName + ', ' + TG.strFirstName as strName FROM TGolfers as TG JOIN TGolferEventYears as TGE ON TG.intGolferID = TGE.intGolferID WHERE TGE.intEventYearID = " & cboEvents.SelectedValue

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the Golfer ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the Golfers data.
        ' We are binding the column name to the combo box display and value members. 
        cboGolfers.ValueMember = "intGolferID"
        cboGolfers.DisplayMember = "strName"
        cboGolfers.DataSource = dt

        ' Select the first item in the list by default
        If cboGolfers.Items.Count > 0 Then cboGolfers.SelectedIndex = 0

        ' Show any changes
        cboGolfers.EndUpdate()

        ' Clean up
        drSourceTable.Close()

        CloseDatabaseConnection()

    End Sub

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






    Private Sub cboSponsorTypes_Update()

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
        cboSponsorTypes.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT intSponsorTypeID, strSponsorTypeDesc FROM TSponsorTypes"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the Golfer ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the Golfers data.
        ' We are binding the column name to the combo box display and value members. 
        cboSponsorTypes.ValueMember = "intSponsorTypeID"
        cboSponsorTypes.DisplayMember = "strSponsorTypeDesc"
        cboSponsorTypes.DataSource = dt



        ' Select the first item in the list by default
        If cboSponsorTypes.Items.Count > 0 Then cboSponsorTypes.SelectedIndex = 0

        ' Show any changes
        cboSponsorTypes.EndUpdate()

        ' Clean up
        drSourceTable.Close()

        CloseDatabaseConnection()

    End Sub

    Private Sub cboPaymentTypes_Update()

        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Close()

        End If

        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

        ' Show changes all at once at end (MUCH faster). 
        cboPaymentTypes.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT intPaymentTypeID, strPaymentTypeDesc FROM TPaymentTypes"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the Golfer ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the Golfers data.
        ' We are binding the column name to the combo box display and value members. 
        cboPaymentTypes.ValueMember = "intPaymentTypeID"
        cboPaymentTypes.DisplayMember = "strPaymentTypeDesc"
        cboPaymentTypes.DataSource = dt



        ' Select the first item in the list by default
        If cboPaymentTypes.Items.Count > 0 Then cboPaymentTypes.SelectedIndex = 0

        ' Show any changes
        cboPaymentTypes.EndUpdate()

        ' Clean up
        drSourceTable.Close()

        CloseDatabaseConnection()

    End Sub

    Private Sub cboEvents_Update()

        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Close()

        End If

        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

        ' Show changes all at once at end (MUCH faster). 
        cboEvents.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT intEventYearID, intEventYear FROM TEventYears"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the player ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the players data.
        ' We are binding the column name to the combo box display and value members. 
        cboEvents.ValueMember = "intEventYearID"
        cboEvents.DisplayMember = "intEventYear"
        cboEvents.DataSource = dt



        ' Select the first item in the list by default
        If cboEvents.Items.Count > 0 Then cboEvents.SelectedIndex = 0

        ' Show any changes
        cboEvents.EndUpdate()

        ' Clean up
        drSourceTable.Close()

        CloseDatabaseConnection()

    End Sub

    Private Sub cboEventsChange(sender As Object, e As EventArgs) Handles cboEvents.SelectedIndexChanged

        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Close()

        End If

        cboEvents.ResetText()

        cboGolfers_Update()

        CloseDatabaseConnection()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSelect As String
        Dim strInsert As String
        Dim intNextHighestRecordID As Integer = 0
        Dim cmdSelect As OleDb.OleDbCommand
        Dim cmdInsert As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim intRowsAffected As Integer

        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Close()

        End If
        strSelect = "SELECT MAX(intGolferEventYearSponsorID) AS intNextHighestRecordID FROM TGolferEventYearSponsors"

        If IsNumeric(txtPledge.Text) Then
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
                intNextHighestRecordID = CInt(drSourceTable.Item(0)) + 1

            End If

            strSelect = "Select TGES.intGolferID
                    From TGolferEventYearSponsors as TGES 
                    JOIN TGolfers as TG 
                    ON TG.intGolferID = TGES.intGolferID
                    WHERE TGES.intEventYearID = " & cboEvents.SelectedValue

            ' Execute command
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            'Read Result
            drSourceTable.Read()

            Dim blnResult As Boolean = True

            For i As Integer = 0 To drSourceTable.FieldCount - 1

                If cboGolfers.SelectedValue = CInt(drSourceTable.Item(0)) Then

                    MessageBox.Show("This Golfer is already sponsored in this event")
                    blnResult = False

                End If

            Next


            'Boolean value for if they have paid or not
            Dim blnPaid As Integer

            If blnResult = True Then

                If chkPayment.Checked = True Then

                    blnPaid = 1

                Else

                    blnPaid = 2

                End If

                '
                'Insert a sponsorship into TGolferEventYearSponsors
                '
                strInsert = "Insert into TGolferEventYearSponsors ( intGolferEventYearSponsorID, intGolferID, intEventYearID, intSponsorID, monPledgeAmount,  intSponsorTypeID, intPaymentTypeID , blnPaid)" &
                    " Values (" & intNextHighestRecordID & "," & cboGolfers.SelectedValue.ToString & "," & cboEvents.SelectedValue.ToString & "," & cboSponsors.SelectedValue.ToString & "," & txtPledge.Text & "," & cboSponsorTypes.SelectedValue.ToString & "," & cboPaymentTypes.SelectedValue.ToString & "," & blnPaid & ")"

                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


                intRowsAffected = cmdInsert.ExecuteNonQuery()

                If intRowsAffected > 0 Then
                    MessageBox.Show("Thank you for your support!")
                    Close()

                End If
            End If

        Else

            MessageBox.Show("Please Enter a numeric value for the pledge amount")

        End If

        CloseDatabaseConnection()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class