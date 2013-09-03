Public Class CardCollection
    Inherits Collections.CollectionBase
    Protected WithEvents MIDDisp As New MultipleImageDisplayer
    Protected Cast As Boolean = False

    Public Property Component() As MultipleImageDisplayer
        Get
            Return MIDDisp
        End Get
        Set(ByVal value As MultipleImageDisplayer)
            MIDDisp = value
            Cast = True

        End Set
    End Property

    Default Public Property Item(ByVal index As Integer) As Card
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Card)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Overridable Shadows Sub Clear()
        MyBase.Clear()
        If Cast = True Then
            Me.Component.Clear()
        End If
    End Sub

    Public Overridable Sub Add(ByVal Card As Card)
        Me.List.Add(Card)
        If Cast = True Then
            Me.Component.Add(Me.GetImage(Card))
        End If
    End Sub

    Public Overridable Sub Insert(ByVal Index As Integer, ByVal Card As Card)
        Me.List.Insert(Index, Card)
        If Cast = True Then
            Me.Component.Insert(Index, GetImage(Card))
        End If
    End Sub

    Public Overridable Sub Remove(ByVal Card As Card)
        Dim i As Integer = Me.List.IndexOf(Card)
        Me.List.Remove(Card)
        If Cast = True Then
            Component.RemoveAt(i)
        End If
    End Sub

    Public Overridable Shadows Sub RemoveAt(ByVal index As Integer)
        Me.List.RemoveAt(index)
        If Cast = True Then
            Component.RemoveAt(index)
        End If
    End Sub

    Public Function IndexOf(ByVal Card As Card) As Integer
        Return Me.List.IndexOf(Card)
    End Function

    Protected Function GetImage(ByVal Card As Card) As Image
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Images\" & Card.Name & ".jpg") Then
            Return Image.FromFile(Application.StartupPath & "\Images\" & Card.Name & ".jpg")
        Else
            Return My.Resources.CardBack
        End If
    End Function
End Class
