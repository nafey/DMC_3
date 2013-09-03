Imports System.Data.OleDb
Imports System.Data

Public Class frmDeckMaker

#Region "Properties and Members"
    Private deckselected As Boolean

    Private objConnection As New OleDbConnection(My.Settings.DMCCardDatabaseConnectionString)
    Private objAdapter As New OleDbDataAdapter
    Private objDataSet As New Data.DataSet
    Private objDataView As New Data.DataView

    Private dtst As New DataSet
    Private dtv As New DataView
    Private dta As New OleDbDataAdapter
    Private con As New OleDbConnection(My.Settings.DMCCardDatabaseConnectionString)

    Private all As New DataSet
    Private alldtv As New DataView
    Private alldta As New OleDbDataAdapter
    Private allcon As New OleDbConnection(My.Settings.DMCCardDatabaseConnectionString)

#End Region

#Region "Subroutines and Functions"
    'loads the description DataSet
    Private Sub allloader()
        'loads alldtv for description
        alldta.SelectCommand = New OleDbCommand
        alldta.SelectCommand.Connection = allcon
        alldta.SelectCommand.CommandText = "Select [Card Name], Type, Civilization, Race, Cost, Power, [Rules Text], [Flavor Text] ,Rarity, Set FROM Cardlist "

        allcon.Open()
        alldta.Fill(all)
        allcon.Close()

        alldtv.Table = all.Tables.Item(0)
        alldtv.Sort = "[Card Name]"

    End Sub

    'adds A card to favourites
    Private Sub AddToFavourites(ByVal Name As String)
        'Only if does not exist already in th favstring
        If Not My.Settings.FavString.Split(New Char() {";"}).Contains(Name) Then
            My.Settings.FavString &= Name & ";"
            Me.dgvFavLoader()
        End If
    End Sub

    'Removes a name
    Private Sub RemoveFromFavourites(ByVal Name As String)
        'Adds all the members of FavString to an array
        Dim str() As String
        str = My.Settings.FavString.Split(";")

        'Clears FS
        My.Settings.FavString = ""

        'Checks which of the card needs to be removed
        For Each s As String In str
            If s = Name Then
                'and removes it
                str(Array.IndexOf(str, s)) = ""
            End If
        Next

        'Reconstructs the FS
        For Each s As String In str
            If s <> "" Then
                My.Settings.FavString &= s & ";"
            End If
        Next

        'and loads the DgvFav
        Me.dgvFavLoader()

    End Sub

    'Fills the dataset and shows the result in provided dgv
    Private Sub dgvSearchLoader()
        'This is the query builder
        Dim query As String = "WHERE "

        'Adds the Card Name query...
        query &= "[Card Name] LIKE '%" & txtName.Text & "%' "

        'Civ query...
        If lstCiv.SelectedItems.Count > 0 Then

            For i As Integer = 0 To Me.lstCiv.SelectedIndices.Count - 1
                query &= "AND Civilization LIKE '%" & Me.lstCiv.SelectedItems.Item(i) & "%' "
            Next
        End If

        'Type Query...
        If cmbType.Text <> "" Then
            query &= "AND Type LIKE '%" & cmbType.Text & "%' "
        End If

        'Race Query...
        If cmbRace.Text <> "" Then
            query &= "AND Race LIKE '%" & cmbRace.Text & "%' "
        End If

        'Cost Query...
        If cmbCostOp.Text <> "" Then
            query &= "AND Cost " & cmbCostOp.Text & " " & Me.nupCost.Value & " "
        End If

        'Power Query...
        If cmbPowerOp.Text <> "" Then
            query &= "AND Power " & Me.cmbPowerOp.Text & " " & Me.nupPower.Value & " "
        End If

        'Rules Query...
        If txtRules.Text <> "" Then
            query &= "AND [Rules Text] LIKE '%" & Me.txtRules.Text & "%' "
        End If

        'Ability Query...
        If cmbAbility.Text <> "" Then
            query &= "AND [Rules Text] LIKE '%" & Me.cmbAbility.Text & "]%' "
        End If

        'Set Query...
        If cmbSet.Text <> "" Then
            query &= "AND Set LIKE '%" & Me.cmbSet.Text & "%' "
        End If


        'Creates the Select command for Adapter
        objAdapter.SelectCommand = New OleDbCommand
        objAdapter.SelectCommand.Connection = objConnection

        objAdapter.SelectCommand.CommandText = "Select [Card Name], Type, Civilization, Race, Cost, Power, [Rules Text], [Flavor Text] ,Rarity, Set FROM Cardlist " & query

        'Empties the Data Set so that it could be filled by search
        objDataSet.Clear()
        'Opens the Connection fills the Data Set and Closes the Connection
        objConnection.Open()
        objAdapter.Fill(objDataSet)
        objConnection.Close()

        'Sets the Data View which will be used to populate DataGridView
        objDataView = New DataView(Me.objDataSet.Tables(0))
        objDataView.Sort() = "[Card Name]"


        'Generates the Data Grid View
        With dgvSearch
            .AutoGenerateColumns = True

            .DataSource = objDataView
            Me.tbpageSearch.Text = "Search(" & Me.dgvSearch.RowCount & " Cards)"


            .Columns(0).Width = 150
            .Columns(1).Width = 90
            .Columns(2).Width = 90
            .Columns(3).Width = 100
            .Columns(4).Width = 40
            .Columns(5).Width = 50
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False

        End With

        Me.dgvSearch.Focus()

        tbcSearch_N_Fav.SelectedIndex = 0

    End Sub

    'Fills the Fav dgv
    Private Sub dgvFavLoader()

        Dim que As String = "Select [Card Name], Type, Civilization, Race, Cost, Power, [Rules Text], [Flavor Text] ,Rarity, Set FROM Cardlist WHERE [Card Name] LIKE 'Nafey' "

        For Each Str As String In My.Settings.FavString.Split(New Char() {";"}, StringSplitOptions.RemoveEmptyEntries)

            que &= "OR [Card Name] LIKE '" & Str & "' "

        Next

        dta.SelectCommand = New OleDbCommand
        dta.SelectCommand.Connection = con
        dta.SelectCommand.CommandText = que

        dtst.Clear()

        con.Open()
        dta.Fill(dtst)
        con.Close()

        dtv.Table = dtst.Tables(0)
        dtv.Sort = "[Card Name]"


        With dgvFav
            .AutoGenerateColumns = True

            .DataSource = dtv
            Me.tbpageFav.Text = "Favourites(" & Me.dgvFav.RowCount & " Cards)"


            .Columns(0).Width = 150
            .Columns(1).Width = 90
            .Columns(2).Width = 90
            .Columns(3).Width = 100
            .Columns(4).Width = 40
            .Columns(5).Width = 50
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False

        End With
    End Sub

    'Loads a deck
    Private Sub DeckLoader(ByVal File As String)
        'reads all the card to a collection
        Dim Str() As String
        Str = Split(My.Computer.FileSystem.ReadAllText(File).ToString, vbCrLf)

        'Empties the Deck
        Me.lstDeck.Items.Clear()

        'Shows the Deck in deck view
        For Each s As String In Str
            If Not s = "" And Me.alldtv.Find(s) > 0 Then
                Me.AddToDeck(s)
            End If
        Next

        'Set the LastDeck setting to this file
        My.Settings.LastDeck = File
        Dim a As String

        'Shows deck name
        a = File.Substring(File.LastIndexOf("\"))
        a = a.Substring(1, a.Length - 6)
        Me.lstDeck.Columns(0).Text = "Card Name(" & a & ")"

    End Sub

    'Saves the Deck to a deck file
    Private Sub deckSaver(ByVal File As String)
        'Converts the deck to a string 
        Dim Str As String = ""

        For Each a As ListViewItem In Me.lstDeck.Items

            For i As Integer = 1 To a.SubItems(1).Text

                Str &= a.SubItems.Item(0).Text & vbCrLf

            Next

        Next

        'and writes it into a file
        My.Computer.FileSystem.WriteAllText(File, Str, False)

    End Sub

    'Introduces new card
    Private Sub AddToDeck(ByVal Name As String)

        If Me.checkExistence(Name) = True Then

            Dim i As Integer = getsPosition(Name)

            If Me.lstDeck.Items.Item(i).SubItems.Item(1).Text < 4 Then
                Me.lstDeck.Items.Item(i).SubItems.Item(1).Text += 1
            Else
                MessageBox.Show("You cant keep more than four copies of same card in a deck", "Deck Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            Me.lstDeck.Items.Add(Name)
            Me.lstDeck.Items.Item(Me.lstDeck.Items.Count - 1).SubItems.Add("1")
        End If

        Dim cardcount As Integer = 0
        For Each a As ListViewItem In Me.lstDeck.Items
            cardcount += a.SubItems(1).Text
        Next

        hdrCopies.Text = "Copies(" & cardcount.ToString & " )"


    End Sub

    'returns true if cardExists
    Private Function checkExistence(ByVal mem As String) As String
        For Each entry As ListViewItem In Me.lstDeck.Items
            If entry.Text = mem Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    'retruns the posn of card in list View
    Private Function getsPosition(ByVal mem As String) As Integer
        For Each entry As ListViewItem In Me.lstDeck.Items
            If entry.Text = mem Then
                Return Me.lstDeck.Items.IndexOf(entry)
            End If
        Next
    End Function

    'Prepares the Description for any paramed card
    Private Function Descript(ByVal Naam As String)
        'Prepares the String which would be shown in TxtDescription
        Dim descrp As String
        Dim i As Integer = alldtv.Find(Naam)
        descrp = "Name: " & alldtv.Item(i).Row.Item(0).ToString & ControlChars.CrLf & _
                "Type: " & alldtv.Item(i).Row.Item(1).ToString & ControlChars.CrLf & _
                "Civilization: " & alldtv.Item(i).Row.Item(2).ToString & ControlChars.CrLf & _
                "Race: " & alldtv.Item(i).Row.Item(3).ToString & ControlChars.CrLf & _
                "Cost: " & alldtv.Item(i).Row.Item(4).ToString & ControlChars.CrLf & _
                "Power: " & alldtv.Item(i).Row.Item(5).ToString & ControlChars.CrLf & _
                "Rules Text: " & alldtv.Item(i).Row.Item(6).ToString & ControlChars.CrLf & _
                "Rarity: " & alldtv.Item(i).Row.Item(8).ToString & ControlChars.CrLf & _
                "Set: " & alldtv.Item(i).Row.Item(9).ToString

        Return descrp
    End Function

    'Removes cards from Deck
    Private Sub RemoveFromDeck(ByVal Index As Integer)


        If Me.lstDeck.Items.Item(Index).SubItems.Item(1).Text > 1 Then

            Me.lstDeck.Items.Item(Index).SubItems.Item(1).Text -= 1

        Else

            Me.lstDeck.Items.RemoveAt(Index)

            If Index > 0 Then
                Me.lstDeck.FocusedItem = Me.lstDeck.Items.Item(Index - 1)
            End If
        End If


    End Sub
#End Region

#Region "Events"
    'at form load performs form startup operations
    Private Sub frmDeckMake_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fills the dgvSearch 

        Me.dgvSearchLoader()
        Me.dgvFavLoader()
        Me.allloader()
        If My.Settings.LastDeck <> "" Then
            Me.DeckLoader(My.Settings.LastDeck)
        End If

        'For i = 0 To 1249
        '    If My.Computer.FileSystem.FileExists(System.Windows.Forms.Application.StartupPath & "\Images\" & Me.dgvSearch.Item(0, i).Value.ToString() & ".jpg") = False Then
        '        MessageBox.Show(Me.dgvSearch.Item(0, i).Value.ToString)
        '    End If
        'Next



    End Sub

    Private Sub dgvSearch_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellDoubleClick
        Me.AddToDeck(Me.dgvSearch.Item(0, e.RowIndex).Value.ToString)
    End Sub

    'descripts the selected card in text box
    Private Sub dgvSearch_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellEnter
        If Me.dgvSearch.SelectedRows.Count > 0 Then
            Dim i As Integer = Me.dgvSearch.SelectedRows.Item(0).Index
            'Fills the textbox with description
            Me.txtDescription.Text = Descript(Me.dgvSearch(0, i).Value.ToString)
        End If
    End Sub

    'sorts the objview so that its entry matches the dgv
    Private Sub dgvSearch_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSearch.ColumnHeaderMouseClick
        'Whenever the column header is clicked the objview is sorted to match the data gridview
        Me.objDataView.Sort = Me.dgvSearch.Columns.Item(e.ColumnIndex).Name
    End Sub

    'Searches when btnSearch is clicked
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        ' performs a search
        Me.dgvSearchLoader()
        Me.dgvSearch.Focus()
        Me.tbcSearch_N_Fav.SelectedIndex = 0

    End Sub

    'Resets all the fields
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'Resets every search field...
        Me.txtName.Text = ""
        Me.lstCiv.SelectedItems.Clear()
        Me.cmbType.Text = ""
        Me.cmbRace.Text = ""
        Me.cmbCostOp.Text = ""
        Me.nupCost.Value = 0
        Me.cmbPowerOp.Text = ""
        Me.nupPower.Value = 0
        Me.txtRules.Text = ""
        Me.cmbAbility.Text = ""
        Me.cmbSet.Text = ""

        'and then performs an all inclusive search
        Me.dgvSearchLoader()

        Me.dgvSearch.Focus()
        Me.tbcSearch_N_Fav.SelectedIndex = 0

    End Sub

    'changes the background color mathcing the cards civ
    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        'This part sees what is the Civ of selected card...
        Dim str() As String
        str = Me.txtDescription.Text.Split(ControlChars.CrLf)
        Dim s As String = str(0).Substring(6)
        s = Me.alldtv.Item(Me.alldtv.Find(s)).Item("Civilization").ToString

        'and this part sets the background color which corresponds to the civ of selected card
        Select Case s
            Case "Darkness"
                Me.txtDescription.BackColor = Color.LightGray
            Case "Fire"
                Me.txtDescription.BackColor = Color.LightSalmon
            Case "Light"
                Me.txtDescription.BackColor = Color.LightYellow
            Case "Nature"
                Me.txtDescription.BackColor = Color.LightGreen
            Case "Water"
                Me.txtDescription.BackColor = Color.LightBlue
            Case Else
                Me.txtDescription.BackColor = Color.WhiteSmoke
        End Select

        Try
            Dim srt As String = str(0).Substring(6)

            Me.picCard.ImageLocation = System.Windows.Forms.Application.StartupPath & "\Images\" & srt & ".jpg"
        Catch ex As Exception

        End Try
    End Sub

    'This Part adds a name to favString on Middle click
    Private Sub dgvSearch_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSearch.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Middle And Me.dgvSearch.SelectedRows.Count > 0 Then
            Me.AddToFavourites(Me.dgvSearch.Item(0, e.RowIndex).Value.ToString)
            Me.dgvSearch.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    'Adds the description for dgvFav
    Private Sub dgvFav_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFav.CellEnter
        If Me.dgvFav.SelectedRows.Count > 0 Then
            Dim i As Integer = Me.dgvFav.SelectedRows.Item(0).Index
            'Fills the textbox with description
            Me.txtDescription.Text = Descript(Me.dgvFav(0, i).Value.ToString)
        End If
    End Sub

    'This part removes a card from fav on middle click
    Private Sub dgvFav_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvFav.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Middle And Me.dgvFav.SelectedRows.Count > 0 Then
            Me.RemoveFromFavourites(Me.dgvFav.Item(0, e.RowIndex).Value.ToString)
        End If
    End Sub

    'Adds a card name  to favString
    Private Sub btnAddFav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFav.Click

        If Me.dgvSearch.SelectedRows.Count > 0 Then
            Me.AddToFavourites(Me.dgvSearch.SelectedRows.Item(0).Cells.Item(0).Value.ToString)
        End If


    End Sub

    'Removes a Card From fav List
    Private Sub btnRemFav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemFav.Click
        If Me.dgvFav.SelectedRows.Count > 0 Then
            Me.RemoveFromFavourites(Me.dgvFav.Item(0, Me.dgvFav.SelectedRows.Item(0).Index).Value.ToString)
        End If
    End Sub

    'add a card
    Private Sub btnAddDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDeck.Click
        If Me.deckselected = False Then
            Me.AddToDeck(Me.dgvSearch.SelectedRows(0).Cells(0).Value.ToString)
        ElseIf Me.deckselected = True Then
            Me.AddToDeck(Me.lstDeck.Items.Item(Me.lstDeck.SelectedIndices.Item(0)).SubItems.Item(0).Text.ToString)
        End If

    End Sub

    'remove a card from deck
    Private Sub btnRemoveDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDeck.Click
        If Me.lstDeck.SelectedIndices.Count > 0 Then
            Me.RemoveFromDeck(Me.lstDeck.SelectedIndices.Item(0))
        End If

        lstDeck.Focus()
    End Sub

    'save deck button
    Private Sub btnSaveDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDeck.Click
        If Me.sfdDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.deckSaver(Me.sfdDialog.FileName)
        End If
    End Sub

    Private Sub lstDeck_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDeck.GotFocus
        Me.deckselected = True
    End Sub

    'Descript on mouse click on deck
    Private Sub lstDeck_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstDeck.MouseClick
        If Me.lstDeck.SelectedIndices.Item(0) >= 0 Then
            Me.txtDescription.Text = Descript(Me.lstDeck.SelectedItems.Item(0).SubItems(0).Text)
        End If
    End Sub

    'load deck on click
    Private Sub btnLoadDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadDeck.Click

        If ofdDeck.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.DeckLoader(ofdDeck.FileName)
        End If

    End Sub

    'Clears the Deck
    Private Sub btnClearDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearDeck.Click
        'Clear Items
        Me.lstDeck.Items.Clear()


        Me.lstDeck.Columns.Item(0).Text = "Card Name"
        Me.lstDeck.Columns.Item(1).Text = "Copies"
    End Sub

    'opens Deck analyser
    Private Sub btnAnalyseDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyseDeck.Click
        'Only if more than 0 card in deck
        If Me.lstDeck.Items.Count > 0 Then

            'the list to be used by Analyser is prepared 
            Dim CardCollection As New List(Of String)

            'the list is populated 
            For i As Integer = 0 To Me.lstDeck.Items.Count - 1
                For j As Integer = 1 To Me.lstDeck.Items.Item(i).SubItems.Item(1).Text
                    CardCollection.Add(Me.lstDeck.Items.Item(i).SubItems.Item(0).Text)
                Next
            Next

            'Analyser's Data Sorce is provided
            frmDeckAnalyser.data = Me.alldtv

            'Anlyser's Deck list is Provided
            frmDeckAnalyser.CardColl = CardCollection

            'Analyser is shown
            frmDeckAnalyser.ShowDialog()
        Else
            MsgBox("Please add some card to your Deck", MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub

    'This part ensures that a search is performed whenever the Enter is Pressed
#Region " Enter Click"

    Private Sub txtName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.dgvSearchLoader()

        End If
    End Sub

    Private Sub cmbType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbType.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.dgvSearchLoader()

        End If
    End Sub

    Private Sub cmbRace_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRace.KeyDown
        If e.KeyCode = Keys.Enter Then

            Me.dgvSearchLoader()

        End If
    End Sub

    Private Sub txtRules_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRules.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.dgvSearchLoader()

        End If
    End Sub

    Private Sub cmbAbility_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAbility.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.dgvSearchLoader()

        End If
    End Sub

    Private Sub cmbSet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.dgvSearchLoader()

        End If
    End Sub
#End Region


    Private Sub btnUseDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUseDeck.Click
        'The list of cards in deck
        Dim Collection(0) As String

        'Creates the list
        For i As Integer = 0 To Me.lstDeck.Items.Count - 1
            For j As Integer = 1 To Me.lstDeck.Items.Item(i).SubItems.Item(1).Text

                Collection(Collection.Count - 1) = Me.lstDeck.Items.Item(i).SubItems.Item(0).Text
                ReDim Preserve Collection(Collection.Count())
            Next
        Next

        ReDim Preserve Collection(Collection.Count - 2)
        'Only if deck has more than or equal to 40
        If Collection.Count >= 40 Then

            frmBattleZone.Intialize(Collection, alldtv)

            frmBattleZone.Show()
            Me.Hide()

        Else
            MsgBox("Put at least 40 cards in your deck")
        End If

    End Sub

    Private Sub lstDeck_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDeck.SelectedIndexChanged
        If Me.lstDeck.SelectedIndices.Count > 0 Then
            Me.txtDescription.Text = Descript(Me.lstDeck.SelectedItems.Item(0).SubItems(0).Text)
        End If
    End Sub

    Private Sub dgvFav_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFav.GotFocus
        Me.deckselected = False
    End Sub


    Private Sub dgvSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSearch.GotFocus
        Me.deckselected = False
    End Sub

#End Region

End Class
