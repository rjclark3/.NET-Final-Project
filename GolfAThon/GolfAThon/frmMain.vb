' **************************************************************************************
' <Rodney Clark>
' Golf A Thon
' <12/8/2018>
' This will allow you to create golfers and sponsors for the golf a thon
' **************************************************************************************
Public Class frmMain
    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            Dim strSelect As String = ""
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' open the DB
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

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try


    End Sub
    Private Sub cboEvents_Update()

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

    End Sub

    Private Sub btnNewGolfer_Click(sender As Object, e As EventArgs) Handles btnNewGolfer.Click

        Dim frmNewGolf As New frmAddGolfer

        frmNewGolf.ShowDialog()

        frmMain_Load(sender, e)

    End Sub

    Private Sub btnNewSponsor_Click(sender As Object, e As EventArgs) Handles btnNewSponsor.Click

        Dim frmNewSponsor As New frmAddSponsor

        frmNewSponsor.ShowDialog()

        frmMain_Load(sender, e)

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        frmAddExistingGolfer.ShowDialog()

        frmMain_Load(sender, e)

    End Sub

    Private Sub btnEditGolfer_Click(sender As Object, e As EventArgs) Handles btnEditGolfer.Click

        frmUpdateGolfer.ShowDialog()

        frmMain_Load(sender, e)

    End Sub

    Private Sub btnEditSponsor_Click(sender As Object, e As EventArgs) Handles btnEditSponsor.Click

        frmEditSponsor.ShowDialog()

        frmMain_Load(sender, e)

    End Sub

    Private Sub btnSponsorGolfer_Click(sender As Object, e As EventArgs) Handles btnSponsorGolfer.Click

        frmSponsorGolfer.ShowDialog()

        frmMain_Load(sender, e)

    End Sub

    Private Sub cboEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvents.SelectedIndexChanged

        Dim intRowCount As Integer = 0

        intRowCount = GetRowCount(intRowCount)

        GetLstData(intRowCount)



    End Sub



    Private Function GetRowCount(intRowCount As Integer)

        Dim strSelect As String = ""
        Dim strSponsorName As String = ""
        Dim strGolferName As String = ""
        Dim strPledgeAmount As String = ""
        Dim strGolferRaised As String = ""
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
        strSelect = "Select Count(intEventYearID)
                        From TGolferEventYearSponsors 
                        Where intEventYearID = " & cboEvents.SelectedValue &
                        "Group by intEventYearID"


        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load the data table from the reader
        dt.Load(drSourceTable)

        drSourceTable = cmdSelect.ExecuteReader

        intRowCount = dt.Rows(0).Item(0).ToString


        CloseDatabaseConnection()

        Return intRowCount
    End Function



    Private Sub GetLstData(intRowCount As Integer)

        Dim strSelect As String = ""
        Dim strSponsorName As String = ""
        Dim strGolferName As String = ""
        Dim strPledgeAmount As String = ""
        Dim strGolferRaised As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

        lstSponsors.Items.Clear()
        lstSponsors.Items.Add("Sponsor                  Pledge Amount                        Golfer                Golfer Raised Amount")
        lstSponsors.Items.Add("__________________________________________________________________________________________________")

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
        strSelect = "Select TS.strLastName + ', ' + TS.strFirstName as strSponsorName,
                        monPledgeAmount as SponsorPledgeAmount, TG.strLastName + ', ' 
                        + TG.strFirstName as strGolferName,  monPledgeAmount as GolferRaised
                        From TSponsors as TS
                        Join TGolferEventYearSponsors as TGES
                        On TGES.intSponsorID = TS.intSponsorID
                        Join TGolfers as TG
                        On TGES.intGolferID = TG.intGolferID
                        Where TGES.intEventYearID = " & cboEvents.SelectedValue &
                        "Group by TS.strLastName, TS.strFirstName, TGES.monPledgeAmount, TG.strLastName, TG.strFirstName, TGES.monPledgeAmount"


        ' Retrieve all the records 
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader

        ' load the data table from the reader
        dt.Load(drSourceTable)

        drSourceTable = cmdSelect.ExecuteReader


        Dim i As Integer = 0

        For i = 0 To intRowCount - 1

            ' populate the list box with the data
            strSponsorName = dt.Rows(i).Item(0).ToString
            strPledgeAmount = dt.Rows(i).Item(1).ToString
            strGolferName = dt.Rows(i).Item(2).ToString
            strGolferRaised = dt.Rows(i).Item(3).ToString

            lstSponsors.Items.Add(strSponsorName & "                        " & strPledgeAmount &
                                  "                              " & strGolferName & "                             " & strGolferRaised)

        Next

        ' close the database connection
        CloseDatabaseConnection()

    End Sub
End Class
