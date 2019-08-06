Public Class frmAddExistingGolfer

    Private Sub frmAddExistingGolfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboGolfers_Update()

        cboEvents_Update()

    End Sub



    Private Sub cboGolfers_Update()

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
        cboGolfers.BeginUpdate()

        ' Build the select statement
        strSelect = "SELECT intGolferID, strLastName + ', ' + strFirstName as strName FROM TGolfers"

        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load table from data reader
        dt.Load(drSourceTable)

        ' Add the item to the combo box. We need the player ID associated with the name so 
        ' when we click on the name we can then use the ID to pull the rest of the players data.
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








    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
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
        strSelect = "SELECT MAX(intGolferEventYearID) + 1 AS intNextHighestRecordID FROM TGolferEventYears"


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

        strSelect = "Select intGolferID From TGolferEventYears WHERE intEventYearID = " & cboEvents.SelectedValue

        ' Execute command
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        'Read Result
        drSourceTable.Read()

        Dim blnResult As Boolean = True

        For i As Integer = 0 To drSourceTable.FieldCount - 1

            If cboGolfers.SelectedValue = CInt(drSourceTable.Item(0)) Then
                MessageBox.Show("This Golfer is already in this event")
                blnResult = False
            End If

        Next

        If blnResult = True Then

            strInsert = "Insert into TGolferEventYears ( intGolferEventYearID, intGolferID, intEventYearID )" &
                " Values (" & intNextHighestRecordID & "," & cboGolfers.SelectedValue & "," & cboEvents.SelectedValue & ")"

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


            intRowsAffected = cmdInsert.ExecuteNonQuery()

            If intRowsAffected > 0 Then
                MessageBox.Show("Golfer has been added!")
                Me.Close()
            End If

            CloseDatabaseConnection()

        End If

    End Sub

    Private Sub btnNewGolfer_Click(sender As Object, e As EventArgs) Handles btnNewGolfer.Click

        Dim frmNewGolf As New frmAddGolfer

        frmNewGolf.ShowDialog()

        frmAddExistingGolfer_Load(sender, e)

    End Sub
End Class