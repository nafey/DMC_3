Public Class frmBattleZone
    
#Region "Properties and Members"
    Private All() As String
    Private Source As New DataView
    Private rtfText As String = ""


    Private _MySelectedCC As Object
    Public Property MySelectedCC() As Object
        Get
            Return _MySelectedCC
        End Get
        Set(ByVal value As Object)
            _MySelectedCC = value
        End Set
    End Property


    Private _IsConnected As Boolean
    Public Property IsConnected() As Boolean
        Get
            Return _IsConnected
        End Get
        Set(ByVal value As Boolean)
            _IsConnected = value
        End Set
    End Property

#End Region

#Region "Subs and Functions"
    Public Sub Intialize(ByVal List() As String, ByVal dtv As DataView)
        ReDim All(List.Count - 1)
        For i As Integer = 0 To List.Count - 1
            All(i) = List(i)
        Next
        ReDim Preserve All(All.Count - 1)
        Me.Source = dtv
    End Sub

#End Region

#Region "Group Subs"
    'Updates the countupdate to show the current number of cards in each zone
    Private Sub CountUpdater(ByVal sender As Object, ByVal e As System.EventArgs) Handles midDeck.Paint, midGraveYard.Paint, midHand.Paint, midManaZone.Paint, midOppDeck.Paint, midOppGrave.Paint, midOppHand.Paint, midOppMana.Paint
        Me.lblOppDeck.Text = Me.midOppDeck.Count
        Me.lblOppGrave.Text = Me.midOppGrave.Count
        Me.lblOppHand.Text = Me.midOppHand.Count
        Me.lblOppMana.Text = Me.midOppMana.Count
        Me.lblYouDeck.Text = Me.midDeck.Count
        Me.lblYouGrave.Text = Me.midGraveYard.Count
        Me.lblYouHand.Text = Me.midHand.Count
        Me.lblYouMana.Text = Me.midManaZone.Count
    End Sub

    'This blocks sets the Selected MySelectedMid
    Private Sub mid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles midBattleZone.Enter, midHand.Enter, midShield.Enter, midDeck.Enter, midManaZone.Enter, midGraveYard.Enter
        If sender Is midBattleZone Then
            Me.MySelectedCC = Game.BattleZone
        ElseIf sender Is midHand Then
            Me.MySelectedCC = Game.Hand
        ElseIf sender Is midShield Then
            Me.MySelectedCC = Game.Shield
        ElseIf sender Is midDeck Then
            Me.MySelectedCC = Game.Deck
        ElseIf sender Is midManaZone Then
            Me.MySelectedCC = Game.ManaZone
        ElseIf sender Is midGraveYard Then
            Me.MySelectedCC = Game.Graveyard
        End If
    End Sub
#End Region

    'The Resting Places of all functionality of all context menus
#Region "Context Menus"

    'Handles the functionality of hand context menu
#Region "ctxHand"
    'shows the context menu
    Private Sub midHand_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles midHand.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right And midHand.SelectedIndex <> -1 Then
            Me.ctxHand.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub tsmiHandSummon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHandSummon.Click

    End Sub

    Private Sub tsmiToGrave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHandToGrave.Click
        Transfer(Game.Hand.Item(Me.midHand.SelectedIndex), Game.Hand, Game.Graveyard)
    End Sub

    Private Sub tsmiToDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHandToDeck.Click
        Transfer(Game.Hand.Item(Me.midHand.SelectedIndex), Game.Hand, Game.Deck)
    End Sub

    Private Sub tsmiToManaZone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHandToManaZone.Click
        Transfer(Game.Hand.Item(Me.midHand.SelectedIndex), Game.Hand, Game.ManaZone)
    End Sub

    Private Sub tsmiToShield_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHandToShield.Click
        Transfer(Game.Hand.Item(Me.midHand.SelectedIndex), Game.Hand, Game.Shield)
    End Sub

#End Region

    'Handles the functionality of ManaZone context menu
#Region "ctxManaZone"
    Private Sub midManaZone_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles midManaZone.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right And midManaZone.SelectedIndex <> -1 Then
            ctxManaZone.Show(MousePosition.X, MousePosition.Y)

        End If
    End Sub

    Private Sub tsmiMZTap_Untap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiMZTap_Untap.Click
        Game.ManaZone.Tap_Untap(Game.ManaZone(Me.midManaZone.SelectedIndex))
    End Sub

    Private Sub tsmiMZtoBZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiMZtoBZ.Click
        Game.Transfer(Game.ManaZone(Me.midManaZone.SelectedIndex), ManaZone, BattleZone)
    End Sub

    Private Sub tsmiMZtoGY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiMZtoGY.Click
        Game.Transfer(Game.ManaZone(Me.midManaZone.SelectedIndex), ManaZone, Graveyard)
    End Sub

    Private Sub tsmiMZtoHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiMZtoHand.Click
        Game.Transfer(Game.ManaZone(Me.midManaZone.SelectedIndex), ManaZone, Hand)
    End Sub

    Private Sub tsmiMZtoShield_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiMZtoShield.Click
        Game.Transfer(Game.ManaZone(Me.midManaZone.SelectedIndex), ManaZone, Shield)
    End Sub
#End Region

    'Handles the functionality of Graveyard context menu
#Region "ctxGraveYard"

    Private Sub midGraveYard_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles midGraveYard.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right And midGraveYard.SelectedIndex <> -1 Then
            Me.ctxGraveYard.Show(MousePosition.X, MousePosition.Y)

        End If
    End Sub

    Private Sub tsmiGYtoBZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGYtoBZ.Click
        Transfer(Graveyard(midGraveYard.SelectedIndex), Graveyard, BattleZone)
    End Sub

    Private Sub tsmiGYtoHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGYtoHand.Click
        Transfer(Graveyard(midGraveYard.SelectedIndex), Graveyard, Hand)
    End Sub

    Private Sub tsmiGYtoMZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGYtoMZ.Click
        Transfer(Graveyard(midGraveYard.SelectedIndex), Graveyard, ManaZone)
    End Sub

    Private Sub tsmiGYtoShield_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiGYtoShield.Click
        Transfer(Graveyard(midGraveYard.SelectedIndex), Graveyard, Shield)
    End Sub

#End Region

    'Handles the functionality of Battle Zone context menu
#Region "ctxBattleZone"
    Private Sub midBattleZone_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles midBattleZone.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right And midBattleZone.SelectedIndex <> -1 Then
            ctxBattleZone.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub tsmiBZTap_Untap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBZTap_Untap.Click
        BattleZone.Tap_Untap(BattleZone(midBattleZone.SelectedIndex))
    End Sub

    Private Sub tsmiBZtoGY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBZtoGY.Click
        Transfer(BattleZone(midBattleZone.SelectedIndex), BattleZone, Graveyard)
    End Sub

    Private Sub tsmiBZtoHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBZtoHand.Click
        Transfer(BattleZone(midBattleZone.SelectedIndex), BattleZone, Hand)
    End Sub

    Private Sub tsmiBZtoMZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBZtoMZ.Click
        Transfer(BattleZone(midBattleZone.SelectedIndex), BattleZone, ManaZone)
    End Sub

    Private Sub tsmiBZtoShield_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBZtoShield.Click
        Transfer(BattleZone(midBattleZone.SelectedIndex), BattleZone, Shield)
    End Sub

    Private Sub tsmiBZtoTOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBZtoTOD.Click
        Transfer(BattleZone(midBattleZone.SelectedIndex), BattleZone, Deck)
    End Sub

    Private Sub tsmiBZAttack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiBZAttack.Click

    End Sub
#End Region

    'Handles the functionality of Shield context menu
#Region "ctxShield"
    Private Sub midShield_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles midShield.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right And midShield.SelectedIndex <> -1 Then
            ctxShield.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub tsmiShieldBreak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiShieldBreak.Click

    End Sub

    Private Sub tsmiShieldPeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiShieldPeek.Click

    End Sub

    Private Sub tsmiShieldShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiShieldShow.Click

    End Sub

    Private Sub tsmiShieldtoBZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiShieldtoBZ.Click
        Transfer(Shield(midShield.SelectedIndex), Shield, BattleZone)
    End Sub

    Private Sub tsmiShieldtoGY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiShieldtoGY.Click
        Transfer(Shield(midShield.SelectedIndex), Shield, Graveyard)
    End Sub

    Private Sub tsmiShieldtoMZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiShieldtoMZ.Click
        Transfer(Shield(midShield.SelectedIndex), Shield, ManaZone)
    End Sub

#End Region

    'Handles the functionality of Deck context menu
#Region "ctxDeck"

    Private Sub midDeck_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles midDeck.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right And midDeck.SelectedIndex <> -1 Then
            ctxDeck.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub tsmiDeckSeeDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDeckSeeDeck.Click
        Deck.HideAll_ShowAll()
    End Sub

    Private Sub tsmiDeckSeeCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDeckSeeCard.Click
        Deck.Hide_Show(Deck(midDeck.SelectedIndex))
    End Sub

    Private Sub tsmiDecktoHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDecktoHand.Click
        Transfer(Deck(Me.midDeck.SelectedIndex), Deck, Hand)
    End Sub

    Private Sub tsmiDecktoHandShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDecktoHandShow.Click

    End Sub

    Private Sub tsmiDecktoMZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDecktoMZ.Click
        Transfer(Deck(Me.midDeck.SelectedIndex), Deck, ManaZone)
    End Sub

    Private Sub tsmiDecktoGY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDecktoGY.Click
        Transfer(Deck(Me.midDeck.SelectedIndex), Deck, Graveyard)
    End Sub

    Private Sub tsmiDecktoBZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDecktoBZ.Click
        Transfer(Deck(midDeck.SelectedIndex), Deck, BattleZone)
    End Sub

    Private Sub tsmiDeckShuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiDeckShuffle.Click
        Deck.Shuffle()
    End Sub
#End Region

#End Region

    'The Functionality of MenuStrip
#Region "MenuStrip"
    Private Sub mtsFileResetGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsFileResetGame.Click
        'hides BattleZone
        Global.DMC_3.frmDeckMaker.Show()

        'Shows Deck Maker
        Me.Hide()
    End Sub

    Private Sub mtsGPDrawDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPDrawDraw.Click
        Draw()
    End Sub

    Private Sub mtsFileSoftReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsFileSoftReset.Click
        'Clears all fields
        Game.Deck.Clear()
        Game.BattleZone.Clear()
        Game.Graveyard.Clear()
        Game.Hand.Clear()
        Game.ManaZone.Clear()
        Game.Shield.Clear()
        Game.OppDeck.Clear()
        Game.OppGrave.Clear()
        Game.OppHand.Clear()
        Game.OppMana.Clear()
        Game.OppShield.Clear()
        Game.OppBattleZone.Clear()

        'Resets the hidhing properties of all discreet Card fields
        Game.Deck.AreNewCardsVisible = False
        Game.Shield.AreNewCardsVisible = False
        Game.OppDeck.AreNewCardsVisible = False
        Game.OppHand.AreNewCardsVisible = False
        Game.OppShield.AreNewCardsVisible = False

        'Refills the deck with members intial array
        For Each Str As String In All
            Game.Deck.Add(New Card(Str))
        Next

        'shuffles the deck
        Game.Deck.Shuffle()
    End Sub

    Private Sub mstFileLoadDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsFileLoadDeck.Click
        'only if user selects a file
        If ofdDeck.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Sets the intial as the blueprint of deck from selected file
            All = My.Computer.FileSystem.ReadAllText(ofdDeck.FileName).Split(vbCr)

            'this boolean is first cycle skipper
            Dim a As Boolean = True
            For Each Str As String In All

                'this block could only be entered after first loop
                If a = False Then

                    'if a deck member is not empty then ....
                    If Str <> "" Then
                        'then delete the first char of its name because it tends to be a bad char
                        All(Array.IndexOf(All, Str)) = Str.Substring(1)

                    End If
                End If

                'first loop catcher
                a = False
            Next

            'Deletes the last member of intial list which tends to be an empty string
            ReDim Preserve All(All.Count - 2)

            'Resets the game
            mtsFileSoftReset_Click(sender, e)
        End If
    End Sub

    Private Sub mtsGPShuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPShuffle.Click
        Deck.Shuffle()
    End Sub

    Private Sub mtsGPTODtoMZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPTODtoMZ.Click
        If Deck.Count > 0 Then
            Transfer(Deck.Item(0), Deck, ManaZone)
        End If
    End Sub

    Private Sub mtsGPTODtoShield_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPTODtoShield.Click
        If Deck.Count > 0 Then
            Transfer(Deck.Item(0), Deck, Shield)
        End If
    End Sub

    Private Sub mtsGPFlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPFlip.Click
        Dim generator As New Random
        Dim randomValue As Integer
        randomValue = generator.Next(0, 1)
        If randomValue = True Then

        ElseIf randomValue = False Then

        End If
    End Sub

    Private Sub mtsGPDrawDrawShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPDrawDrawShow.Click

    End Sub

    Private Sub mtsGPDiscard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPDiscard.Click
        'only if more than zero card in hand
        If Hand.Count > 0 Then
            'random generator
            Dim generator As New Random
            'the random value ..
            Dim randomValue As Integer
            'is given a definite number
            randomValue = generator.Next(0, Hand.Count)
            'if random value = hand.count then it is decreased by 1
            If randomValue = Hand.Count Then randomValue -= 1
            'tranfer
            Transfer(Hand.Item(randomValue), Hand, Graveyard)
        End If
    End Sub

    Private Sub mtsGPPlaceShield_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPPlaceShield.Click
        'Places five cards in shield only if it has zero cards
        If Shield.Count = 0 Then
            For i = 0 To 4
                Transfer(Deck(i), Deck, Shield)
            Next
        End If
    End Sub

    Private Sub mtsGPUntapAllCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsGPUntapAllCards.Click
        For Each Card As Card In BattleZone
            If BattleZone.IsTapped(BattleZone.IndexOf(Card)) Then
                BattleZone.Tap_Untap(Card)
            End If
        Next

        For Each Card As Card In ManaZone
            If ManaZone.IsTapped(ManaZone.IndexOf(Card)) Then
                ManaZone.Tap_Untap(Card)
            End If
        Next
    End Sub

    Private Sub mtsFileYourName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsFileYourName.TextChanged
        My.Settings.YourName = mtsFileYourName.Text
    End Sub

    Private Sub mtsHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsHelpAbout.Click

    End Sub
#End Region

    'Contains code to establish connection over winsock
    '#Region "Winsock"

    '    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
    '        If Me.btnConnect.Text = "Connect" Then
    '            wskConnection.Connect(Me.txtTheirIp.Text, 2222)
    '            lblStatus.Text = "Connecting"
    '            btnListen.Enabled = False
    '            btnConnect.Text = "Disconnect"
    '        Else
    '            wskConnection.Close()
    '            lblStatus.Text = "Not Connected"
    '            btnListen.Enabled = True
    '            btnConnect.Text = "Connect"
    '        End If

    '    End Sub

    '    Private Sub btnListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListen.Click
    '        If btnListen.Text = "Listen" Then

    '            wskConnection.LocalPort = 2222
    '            wskConnection.Listen()

    '            lblStatus.Text = "Listening"
    '            btnConnect.Enabled = False
    '            btnListen.Text = "Stop"
    '        Else
    '            wskConnection.Close()
    '            lblStatus.Text = "Not Connected"
    '            btnConnect.Enabled = True
    '            btnListen.Text = "Listen"
    '        End If
    '    End Sub

    '    Private Sub wskConnection_ConnectEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wskConnection.ConnectEvent
    '        lblStatus.Text = "Connect"
    '        btnConnect.Text = "Disconnect"
    '        btnConnect.Enabled = True
    '        btnListen.Enabled = False
    '    End Sub

    '    Private Sub wskConnection_ConnectionRequest(ByVal sender As System.Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent) Handles wskConnection.ConnectionRequest
    '        wskConnection.Close()
    '        wskConnection.Accept(e.requestID)

    '        lblStatus.Text = "Connected"
    '        btnConnect.Text = "Disconnect"
    '        btnConnect.Enabled = True
    '        btnListen.Enabled = False
    '    End Sub
    '#End Region


    '    Private Sub frmBattleZone_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '        'Closes everything
    '        System.Windows.Forms.Application.Exit()
    '    End Sub

    '    Private Sub frmBattleZone_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '        'Data source for card data initialization
    '        Card.Source = Me.Source
    '        Game.Deck.Component = midDeck
    '        Game.Graveyard.Component = midGraveYard
    '        Game.Hand.Component = midHand
    '        Game.ManaZone.Component = midManaZone
    '        Game.Shield.Component = midShield
    '        Game.BattleZone.Component = midBattleZone
    '        Game.OppShield.Component = midOppShield
    '        Game.OppMana.Component = midOppMana
    '        Game.OppHand.Component = midOppHand
    '        Game.OppGrave.Component = midOppGrave
    '        Game.OppDeck.Component = midOppDeck
    '        Game.OppBattleZone.Component = midOppBattleZone

    '        For Each Name As String In All
    '            Dim card As New Card(Name)
    '            ''''to do : Add deck builder
    '            Game.Deck.Add(card)

    '        Next

    '        Game.Deck.Shuffle()

    '        txtYourIP.Text = wskConnection.LocalIP
    '    End Sub

    '    'Taps mana card on doubleclick
    '    Private Sub midManaZone_ImageDoubleClicked(ByVal Image As System.Drawing.Image, ByVal index As System.Int32) Handles midManaZone.ImageDoubleClicked
    '        ManaZone.Tap_Untap(Game.ManaZone.Item(index))
    '    End Sub

    '    'Taps battlezone card on doubleclick
    '    Private Sub midBattleZone_ImageDoubleClicked(ByVal Image As System.Drawing.Image, ByVal index As System.Int32) Handles midBattleZone.ImageDoubleClicked
    '        BattleZone.Tap_Untap(Game.BattleZone.Item(index))
    '    End Sub

    '    Private Function wskConnection() As Object
    '        Throw New NotImplementedException
    '    End Function


End Class