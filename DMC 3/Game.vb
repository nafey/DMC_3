Public Module Game


#Region "Mems and Props"
    Private _deck As New Global.DMC_3.DiscreetCardCollection With {.AreNewCardsVisible = False, .CardsAreNumbered = False}
    Private _hand As New Global.DMC_3.CardCollection
    Private _mana As New Global.DMC_3.TappableCardCollection
    Private _zone As New Global.DMC_3.TappableCardCollection
    Private _grave As New Global.DMC_3.CardCollection
    Private _shield As New Global.DMC_3.DiscreetCardCollection With {.AreNewCardsVisible = False, .CardsAreNumbered = True}

    Public Property Deck() As DiscreetCardCollection
        Get
            Return _deck
        End Get
        Set(ByVal value As DiscreetCardCollection)
            _deck = value
        End Set
    End Property

    Public Property ManaZone() As TappableCardCollection
        Get
            Return _mana
        End Get
        Set(ByVal value As TappableCardCollection)
            _mana = value
        End Set
    End Property

    Public Property Hand() As CardCollection
        Get
            Return _hand
        End Get
        Set(ByVal value As CardCollection)
            _hand = value
        End Set
    End Property

    Public Property BattleZone() As TappableCardCollection
        Get
            Return _zone
        End Get
        Set(ByVal value As TappableCardCollection)
            _zone = value
        End Set
    End Property

    Public Property Graveyard() As CardCollection
        Get
            Return _grave
        End Get
        Set(ByVal value As CardCollection)
            _grave = value
        End Set
    End Property

    Public Property Shield() As DiscreetCardCollection
        Get
            Return _shield
        End Get
        Set(ByVal value As DiscreetCardCollection)
            _shield = value
        End Set
    End Property



    Private _oppDeck As New Global.DMC_3.DiscreetCardCollection
    Private _oppHand As New Global.DMC_3.DiscreetCardCollection
    Private _oppMana As New Global.DMC_3.TappableCardCollection
    Private _oppZone As New Global.DMC_3.TappableCardCollection
    Private _oppGrave As New Global.DMC_3.CardCollection
    Private _oppShield As New Global.DMC_3.DiscreetCardCollection

    Public Property OppDeck() As Global.DMC_3.DiscreetCardCollection
        Get
            Return _oppDeck
        End Get
        Set(ByVal value As Global.DMC_3.DiscreetCardCollection)
            _oppDeck = value
        End Set
    End Property

    Public Property OppHand() As Global.DMC_3.DiscreetCardCollection
        Get
            Return _oppHand
        End Get
        Set(ByVal value As Global.DMC_3.DiscreetCardCollection)
            _oppHand = value
        End Set
    End Property

    Public Property OppMana() As Global.DMC_3.TappableCardCollection
        Get
            Return _oppMana
        End Get
        Set(ByVal value As Global.DMC_3.TappableCardCollection)
            _oppMana = value
        End Set
    End Property

    Public Property OppBattleZone() As Global.DMC_3.TappableCardCollection
        Get
            Return _oppZone
        End Get
        Set(ByVal value As Global.DMC_3.TappableCardCollection)
            _oppZone = value
        End Set
    End Property

    Public Property OppGrave() As Global.DMC_3.CardCollection
        Get
            Return _oppGrave
        End Get
        Set(ByVal value As Global.DMC_3.CardCollection)
            _oppGrave = value
        End Set
    End Property

    Public Property OppShield() As Global.DMC_3.DiscreetCardCollection
        Get
            Return _oppShield
        End Get
        Set(ByVal value As Global.DMC_3.DiscreetCardCollection)
            _oppShield = value
        End Set
    End Property

#End Region

    'Transfers a card from one place to another
    Public Sub Transfer(ByVal Card As Card, ByVal From As Object, ByVal Unto As Object)
        From.Remove(Card)
        Unto.Insert(0, Card)
    End Sub

    Public Sub Draw()
        If Deck.Count > 0 Then
            Transfer(Deck.Item(Deck.Count - 1), Deck, Hand)
        End If

    End Sub

    Public Sub Summon(ByVal Card As Card)
        Dim interimCost As Integer = Card.Cost
        'Exceptionate


        'Cost Exists

        'Civ Exists

        'Tap Civ

        'Tap Cost
    End Sub


    'Public Function Compare(ByVal civ As String

    Public Function Exceptionate(ByVal Card As Card)
        Dim result As Integer = Card.Cost

        'Fill in with exception thingies

        Return result


    End Function

    Private Structure ManaRule
        Public Enum Race_Civ_Type
            Race = 0
            Civ = 1
            Type = 2
        End Enum

        Public RuleType As Race_Civ_Type
        Public AffectsString() As String
        Public CostEffect As Integer

    End Structure

End Module

