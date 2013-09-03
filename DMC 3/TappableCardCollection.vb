Public Class TappableCardCollection
    Inherits Global.DMC_3.CardCollection

    Private TapList As New List(Of Boolean)

    Public ReadOnly Property IsTapped(ByVal Index As Integer) As Boolean
        Get
            If Me.TapList.Count >= Index Then
                Return TapList(Index)
            Else
                Return False
            End If
        End Get
    End Property

    Public Sub Tap_Untap(ByVal Card As Card)
        If Me.TapList(Me.List.IndexOf(Card)) = True Then
            'untap the card
            Me.TapList(Me.List.IndexOf(Card)) = False

            'untap the image
            If Me.Cast = True Then
                Me.Component.Item(Me.List.IndexOf(Card)) = GetUntappedImage(Card)

            End If
        ElseIf Me.TapList(Me.List.IndexOf(Card)) = False Then
            'tap the card
            Me.TapList(Me.List.IndexOf(Card)) = True

            'tap the image
            If Me.Cast = True Then
                Me.Component.Item(Me.List.IndexOf(Card)) = GetTappedImage(Card)

            End If
        End If
    End Sub

    Public Sub UntapAll()

    End Sub

    Public Shadows Sub Add(ByVal Card As Card, Optional ByVal Tapped As Boolean = False)
        'add the card to the collection
        MyBase.Add(Card)

        'adds its tap position to tap list
        TapList.Add(Tapped)


        If Cast = True Then
            'taps its image if its tapped
            If Tapped = True Then
                If My.Computer.FileSystem.FileExists(System.Windows.Forms.Application.StartupPath & "\Images\" & Card.Name & ".jpg") Then
                    Me.Component.Item(Me.Component.Count) = GetTappedImage(Image.FromFile(System.Windows.Forms.Application.StartupPath & "\Images\" & Card.Name & ".jpg"))
                Else
                    Me.Component.Item(Me.Component.Count) = GetTappedImage(My.Resources.CardBack)
                End If
            End If

        End If
    End Sub

    Public Shadows Sub Insert(ByVal Index As Integer, ByVal Card As Card, Optional ByVal Tapped As Boolean = False)
        MyBase.Insert(Index, Card)
        TapList.Insert(Index, Tapped)
        If Cast = True Then
            If Tapped = True Then
                If My.Computer.FileSystem.FileExists(System.Windows.Forms.Application.StartupPath & "\Images\" & Card.Name & ".jpg") Then
                    Me.Component.Item(Index) = GetTappedImage(Image.FromFile(System.Windows.Forms.Application.StartupPath & "\Images\" & Card.Name & ".jpg"))
                Else
                    Me.Component.Item(Index) = GetTappedImage(My.Resources.CardBack)
                End If
            End If
        End If

    End Sub

    Public Shadows Sub Remove(ByVal Card As Card)
        Dim i As Integer = Me.List.IndexOf(Card)
        MyBase.Remove(Card)

        Me.TapList.RemoveAt(i)
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        MyBase.RemoveAt(index)
        Me.TapList.RemoveAt(index)
    End Sub

    Private Overloads Function GetTappedImage(ByVal Image As Image) As Image
        'Gets tapped representation of passed image
        Dim MasterImage As New Bitmap(Image.Height, Image.Height)
        Dim gr As Graphics = Graphics.FromImage(MasterImage)
        Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        gr.DrawImage(Image, 0, CInt((MasterImage.Height - Image.Height) / 2), Image.Width, Image.Height)
        Return MasterImage
    End Function

    Private Overloads Function GetUntappedImage(ByVal Image As Image) As Image
        'Gets from files the image which corresponds to given image
        Return GetImage(Me.Item(Me.Component.IndexOf(Image)))
    End Function

    Private Overloads Function GetTappedImage(ByVal Card As Card) As Image
        'Gets the Image which Corresponds to card
        Dim Image As Image = GetImage(Card)

        'Returns its tapped Version
        Dim MasterImage As New Bitmap(Image.Height, Image.Height)
        Dim gr As Graphics = Graphics.FromImage(MasterImage)
        Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        gr.DrawImage(Image, 0, CInt((MasterImage.Height - Image.Height) / 2), Image.Width, Image.Height)
        Return MasterImage
    End Function

    Private Overloads Function GetUntappedImage(ByVal Card As Card) As Image
        'Returns the image which has the same name as Card
        Return GetImage(Card)
    End Function


End Class
