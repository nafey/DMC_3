Imports System.Math
Public Class frmDeckAnalyser
    Public data As DataView
    Private Y As Integer
    Private CC As New List(Of String)
    Private BoxImage As Bitmap

    Public Sub Analyse()

        Dim average As Double = 0
        Dim Creatures As Integer = 0
        Dim Spell As Integer = 0
        Dim others As Integer = 0
        Dim Fire As Integer = 0
        Dim Water As Integer = 0
        Dim Nature As Integer = 0
        Dim Darkness As Integer = 0
        Dim Light As Integer = 0
        Dim Rainbow As Integer = 0

        For Each Card As String In Me.CardColl

            average += Me.data.Item(Me.data.Find(Card)).Item(4)

            Select Case Me.data.Item(Me.data.Find(Card)).Item(1)
                Case "Creature"
                    Creatures += 1
                Case "Spell"
                    Spell += 1
                Case Else
                    others += 1
            End Select

            Select Case Me.data.Item(Me.data.Find(Card)).Item(2)
                Case "Fire"
                    Fire += 1
                Case "Water"
                    Water += 1
                Case "Nature"
                    Nature += 1
                Case "Darkness"
                    Darkness += 1
                Case "Light"
                    Light += 1
                Case Else
                    Rainbow += 1
            End Select

        Next

        average = average / Me.CardColl.Count

        Me.txtAnalyse.Text = "Average = " & average & ControlChars.CrLf & ControlChars.CrLf & _
        "Creatures = " & Creatures & ControlChars.CrLf & _
        "Spells = " & Spell & ControlChars.CrLf & _
        "Others = " & others & ControlChars.CrLf & ControlChars.CrLf & _
        "Fire = " & Fire & ControlChars.CrLf & _
        "Water = " & Water & ControlChars.CrLf & _
        "Nature = " & Nature & ControlChars.CrLf & _
        "Darkness = " & Darkness & ControlChars.CrLf & _
        "Light = " & Light & ControlChars.CrLf & _
        "Rainbow = " & Rainbow



    End Sub

    Public Sub Descript()
        Dim c As String
        c = Me.CardColl.Item(0)
        Me.txtDeck.Text = Me.CardCount(c) & "x " & c

        For Each Card As String In Me.CardColl
            If c <> Card Then
                Me.txtDeck.Text &= ControlChars.CrLf & Me.CardCount(Card) & "x " & Card
                c = Card
            End If
        Next

    End Sub

    Public ReadOnly Property CardCount(ByVal Name As String) As Integer
        Get
            Dim result As Integer = 0
            For Each Card As String In CardColl
                If Card = Name Then
                    result += 1
                End If
            Next
            Return result
        End Get
    End Property

    Public Property CardColl() As List(Of String)
        Get
            Return CC
        End Get
        Set(ByVal value As List(Of String))
            CC = value
        End Set
    End Property

    Private Sub picDeck_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picDeck.Paint

        e.Graphics.DrawImage(BoxImage, 0, Y)
        If BoxImage.Height > Me.picDeck.Height Then
            Me.vscrDeck.Maximum = Me.BoxImage.Height - Me.picDeck.Height
            Me.vscrDeck.Minimum = 0
            Me.vscrDeck.LargeChange = CInt(Me.vscrDeck.Maximum / 3)
            Me.vscrDeck.SmallChange = CInt(Me.vscrDeck.Maximum / 4)
            Me.vscrDeck.Maximum += Me.vscrDeck.LargeChange

            Me.vscrDeck.Visible = True
        End If

    End Sub

    Private Sub frmDeckAnalyser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Cursor = Cursors.WaitCursor
        BoxImage = New Bitmap(360, (CInt(CardColl.Count / 4)) * 124)
        Dim gr As Graphics = Graphics.FromImage(BoxImage)

        For i = 0 To CardColl.Count - 1

            Dim Img As Image
            Try
                Img = Image.FromFile(System.Windows.Forms.Application.StartupPath & "\Images\" & CardColl.Item(i).ToString & ".jpg")
            Catch ex As Exception
                Img = My.Resources.CardBack
            End Try

            Dim rect As Rectangle
            rect.X = (i Mod 4) * 90
            rect.Y = ((i - (i Mod 4)) / 4) * 124
            rect.Width = 90
            rect.Height = 124

            gr.DrawImage(Img, rect)

        Next

        Descript()

        Analyse()


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub vscrDeck_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vscrDeck.Scroll
        Y = -e.NewValue
        Me.picDeck.Invalidate()
    End Sub
End Class