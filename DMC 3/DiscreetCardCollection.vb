Public Class DiscreetCardCollection
    Inherits Global.DMC_3.CardCollection
    Private VisibleList As New List(Of Boolean)
    Private _AreNewCardsVisible As Boolean
    Private counter As Integer = 1
    Private numberCards As Boolean

    Public Property CardsAreNumbered() As Boolean
        Get
            Return numberCards
        End Get
        Set(ByVal value As Boolean)
            numberCards = value
        End Set
    End Property

    Public Property AreNewCardsVisible() As Boolean
        Get
            Return Me._AreNewCardsVisible
        End Get
        Set(ByVal value As Boolean)
            Me._AreNewCardsVisible = value
        End Set
    End Property

    Public ReadOnly Property IsVisible(ByVal card As Card) As Boolean
        Get
            Return Me.VisibleList.Item(Me.IndexOf(card))
        End Get
    End Property

    Public Sub ClearCounter()
        counter = 0
    End Sub

    Public Sub Hide_Show(ByVal Card As Card)
        'If card is visible
        If IsVisible(Card) Then

            'hide the card
            VisibleList.Item(IndexOf(Card)) = False

            'hide the image
            If Cast = True Then

                Me.Component.Item(IndexOf(Card)) = My.Resources.CardBack

            End If

            'if Card not visible
        ElseIf Not IsVisible(Card) Then

            'Show the Card
            VisibleList.Item(IndexOf(Card)) = True

            'Show the Image
            If Cast = True Then

                Me.Component.Item(IndexOf(Card)) = Me.GetImage(Card)

            End If

        End If
    End Sub

    Public Sub Hide_Show(ByVal Visible As Boolean, ByVal Card As Card)
        If Visible Then
            'Show the Card
            VisibleList.Item(IndexOf(Card)) = True

            'Show the Image
            If Cast = True Then

                Me.Component.Item(IndexOf(Card)) = Me.GetImage(Card)

            End If
        ElseIf Not Visible Then

            'hide the card
            VisibleList.Item(IndexOf(Card)) = False

            'hide the image
            If Cast = True Then

                Me.Component.Item(IndexOf(Card)) = My.Resources.CardBack

            End If
        End If
    End Sub

    Public Sub HideAll_ShowAll()

        For i As Integer = 0 To Me.Count - 1
            Me.Hide_Show(Not Me.AreNewCardsVisible, Me.Item(i))
        Next
        AreNewCardsVisible = Not Me.AreNewCardsVisible
        Me.Component.Invalidate()
    End Sub

    Public Sub Shuffle()

        Dim generator As New Random
        Dim randomValue As Integer

        For i As Integer = 0 To Me.Count - 1
            randomValue = generator.Next(0, Me.Count - 1)
            Dim card As New Card(Me.Item(randomValue).Name)
            Me.Item(randomValue) = Me.Item(i)
            Me.Item(i) = card
        Next

        If Cast = True Then
            For Each Card As Card In Me
                Me.Component.Item(IndexOf(Card)) = GetImage(Card)
            Next
        End If



    End Sub

    Public Shadows Sub Add(ByVal Card As Card, ByVal Shown As Boolean)
        MyBase.Add(Card)

        VisibleList.Add(Shown)
        If Cast = True Then
            If Shown = False Then
                Me.Component.Item(Me.Component.Count - 1) = GetNumberedImage(counter, My.Resources.CardBack)
                counter += 1
            End If
        End If

    End Sub

    Public Shadows Sub Add(ByVal Card As Card)
        Me.Add(Card, AreNewCardsVisible)
    End Sub

    Public Shadows Sub Insert(ByVal index As Integer, ByVal Card As Card)
        Me.Insert(index, Card, Me.AreNewCardsVisible)
    End Sub

    Public Shadows Sub Insert(ByVal Index As Integer, ByVal Card As Card, ByVal Shown As Boolean)
        MyBase.Insert(Index, Card)
        Me.VisibleList.Insert(Index, Shown)

        If Cast = True Then
            If Shown = False Then
                Me.Component.Item(Index) = GetNumberedImage(counter, My.Resources.CardBack)
                counter += 1
            End If
        End If
    End Sub

    Public Shadows Sub Remove(ByVal Card As Card)
        Dim i As Integer = Me.List.IndexOf(Card)
        MyBase.Remove(Card)

        Me.VisibleList.RemoveAt(i)
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        MyBase.RemoveAt(index)

        Me.VisibleList.RemoveAt(index)
    End Sub

    Public Function GetNumberedImage(ByVal Index As Integer, ByVal Image As Image) As Image
        If CardsAreNumbered Then
            Dim gfx As Graphics = Graphics.FromImage(Image)
            Dim font As New Font("Arial", 32)
            Dim brush As New SolidBrush(Color.White)
            Dim drFrmt As New StringFormat

            gfx.DrawString(Index, font, brush, 0, 0)
        End If

        Return Image
    End Function

    Protected Shadows Function GetImage(ByVal Card As Card)
        If Me.VisibleList.Item(IndexOf(Card)) = False Then
            Return My.Resources.CardBack
        Else
            Return MyBase.GetImage(Card)
        End If
    End Function

End Class
