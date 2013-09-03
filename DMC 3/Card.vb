Public Class Card

    Private Shared src As New DataView
    Private Row As New List(Of String)
    Private Base() As String


    Public Shared Property Source() As DataView
        Get
            Return src
        End Get
        Set(ByVal value As DataView)
            src = value
        End Set
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return Row.Item(0).ToString
        End Get
    End Property

    Public ReadOnly Property Civilization() As String()
        Get
            Return Row.Item(1).ToString.Split("/")
        End Get
    End Property

    Public ReadOnly Property Type() As String
        Get
            Return Row.Item(2).ToString
        End Get
    End Property

    Public ReadOnly Property Race() As String
        Get
            Return Row.Item(3).ToString
        End Get
    End Property

    Public ReadOnly Property Cost() As Integer
        Get
            Return Row.Item(4).ToString
        End Get
    End Property

    Public ReadOnly Property Power() As String
        Get
            Return Row.Item(5).ToString
        End Get
    End Property

    Public ReadOnly Property RulesText() As String
        Get
            Return Row.Item(6).ToString
        End Get
    End Property

    Public ReadOnly Property Rarity() As String
        Get
            Return Row.Item(7).ToString
        End Get
    End Property

    Public ReadOnly Property _Set() As String
        Get
            Return Row.Item(8).ToString
        End Get
    End Property

    Public Property BaseCreatures() As String()
        Get
            Return Base
        End Get
        Set(ByVal value As String())
            Base = value
        End Set
    End Property

    'Constructor

    Public Sub New(ByVal Name As String)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Card Name").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Civilization").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Type").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Race").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Cost").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Power").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Rules Text").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Rarity").ToString)
        Row.Add(Card.Source.Item(Card.Source.Find(Name)).Item("Set").ToString)
    End Sub

    Public Shadows Function ToString()
        Return Me.Name
    End Function

End Class
