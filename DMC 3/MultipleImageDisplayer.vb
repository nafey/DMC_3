Public Class MultipleImageDisplayer

#Region "Mems"
    Private ImageList As New List(Of Image)
    Private Xcoor As Integer = 0
    Private Hght As Integer = 0
    Private _selectedIndex As Integer = -1


    Public Event ImageClicked(ByVal Image As Image, ByVal index As Integer)
    Public Event ImageDoubleClicked(ByVal Image As Image, ByVal index As Integer)
    Public Event SelectedIndexChanged(ByVal index As Integer)

    Public Property Item(ByVal index As Integer) As Image
        Get
            Return ImageList.Item(index)
        End Get
        Set(ByVal value As Image)
            ImageList.Item(index) = value
            Me.Invalidate()
        End Set
    End Property

    Public Property SelectedIndex() As Integer
        Get
            Return _selectedIndex
        End Get
        Set(ByVal value As Integer)
            _selectedIndex = value
            RaiseEvent SelectedIndexChanged(_selectedIndex)
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub Add(ByVal Image As Image)
        ImageList.Add(Image)

        Me.Invalidate()
    End Sub

    Public Sub RemoveAt(ByVal index As Integer)
        ImageList.RemoveAt(index)

        Me.Invalidate()

        If Me.SelectedIndex >= Me.Count Then
            Me.SelectedIndex -= 1
        End If
    End Sub

    Public Sub Clear()
        ImageList.Clear()
        Me.Invalidate()
    End Sub

    Public Sub Insert(ByVal index As Integer, ByVal Image As Image)
        ImageList.Insert(index, Image)

        Me.Invalidate()
    End Sub

    Public Function IndexOf(ByVal Image As Image) As Integer
        Return Me.ImageList.IndexOf(Image)
    End Function

    Public Function Count() As Integer
        Return Me.ImageList.Count
    End Function
#End Region

#Region "Events"

    Private Sub MultipleImageDisplayer_ImageClicked(ByVal Image As System.Drawing.Image, ByVal index As Integer) Handles Me.ImageClicked
        Me.Invalidate()
    End Sub

    Private Sub MultipleImageDisplayer_ImageDoubleClicked(ByVal Image As System.Drawing.Image, ByVal index As Integer) Handles Me.ImageDoubleClicked
        Me.Invalidate()
    End Sub

    Private Sub MultipleImageDisplayer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Hght = Me.Height - Me.HScrollBar1.Height
    End Sub

    Private Sub MultipleImageDisplayer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Dim x As Integer = 0
        For Each Image As Image In Me.ImageList
            Dim Rect As New Rectangle(Xcoor + x, 0, CInt(Hght * Image.Width / Image.Height), Hght)
            x += Hght * (Image.Width / Image.Height + 1 / 10)
            If Rect.Contains(e.Location) Then
                Me.SelectedIndex = ImageList.IndexOf(Image)
                RaiseEvent ImageClicked(Image, ImageList.IndexOf(Image))
                Exit Sub
            End If
        Next
        Me.SelectedIndex = -1

    End Sub

    Private Sub MultipleImageDisplayer_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Dim x As Integer = 0
        For Each Image As Image In Me.ImageList
            Dim Rect As New Rectangle(Xcoor + x, 0, CInt(Hght * Image.Width / Image.Height), Hght)
            x += Hght * (Image.Width / Image.Height + 1 / 10)
            If Rect.Contains(e.Location) Then
                Me.SelectedIndex = ImageList.IndexOf(Image)
                RaiseEvent ImageDoubleClicked(Image, ImageList.IndexOf(Image))
                Exit For
            End If
        Next
        Me.SelectedIndex = -1

    End Sub

    Private Sub MultipleImageDisplayer_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim x As Integer = 0

        For Each Image As Image In ImageList
            e.Graphics.DrawImage(Image, Xcoor + x, 0, CInt(Hght * Image.Width / Image.Height), Hght)
            x += Hght * (Image.Width / Image.Height + 1 / 10)
        Next

        If x > Me.Width Then
            Me.HScrollBar1.Minimum = 0
            Me.HScrollBar1.Maximum = x - Width
            Me.HScrollBar1.LargeChange = CInt(Me.HScrollBar1.Maximum / 5)
            Me.HScrollBar1.SmallChange = CInt(Me.HScrollBar1.Maximum / 10)
            Me.HScrollBar1.Maximum += Me.HScrollBar1.LargeChange

            Me.HScrollBar1.Visible = True
        Else
            Me.HScrollBar1.Visible = False
        End If
    End Sub

    Private Sub MultipleImageDisplayer_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Hght = Me.Height - Me.HScrollBar1.Height
        Me.Invalidate()
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        Xcoor = -e.NewValue
        Me.Invalidate()
    End Sub
#End Region

End Class
