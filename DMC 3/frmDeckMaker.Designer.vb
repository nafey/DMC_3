<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeckMaker))
        Me.dgvSearch = New System.Windows.Forms.DataGridView
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.tbcSearch_N_Fav = New System.Windows.Forms.TabControl
        Me.tbpageSearch = New System.Windows.Forms.TabPage
        Me.tbpageFav = New System.Windows.Forms.TabPage
        Me.dgvFav = New System.Windows.Forms.DataGridView
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.picCard = New System.Windows.Forms.PictureBox
        Me.lstDeck = New System.Windows.Forms.ListView
        Me.hdrName = New System.Windows.Forms.ColumnHeader
        Me.hdrCopies = New System.Windows.Forms.ColumnHeader
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RedoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.grbxTasks = New System.Windows.Forms.GroupBox
        Me.btnClearDeck = New System.Windows.Forms.Button
        Me.btnUseDeck = New System.Windows.Forms.Button
        Me.btnAnalyseDeck = New System.Windows.Forms.Button
        Me.btnSaveDeck = New System.Windows.Forms.Button
        Me.btnLoadDeck = New System.Windows.Forms.Button
        Me.btnRemoveDeck = New System.Windows.Forms.Button
        Me.btnAddDeck = New System.Windows.Forms.Button
        Me.btnAddFav = New System.Windows.Forms.Button
        Me.btnRemFav = New System.Windows.Forms.Button
        Me.grbxSearch = New System.Windows.Forms.GroupBox
        Me.nupPower = New System.Windows.Forms.NumericUpDown
        Me.nupCost = New System.Windows.Forms.NumericUpDown
        Me.lstCiv = New System.Windows.Forms.ListBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cmbSet = New System.Windows.Forms.ComboBox
        Me.cmbAbility = New System.Windows.Forms.ComboBox
        Me.txtRules = New System.Windows.Forms.TextBox
        Me.cmbPowerOp = New System.Windows.Forms.ComboBox
        Me.cmbCostOp = New System.Windows.Forms.ComboBox
        Me.cmbRace = New System.Windows.Forms.ComboBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblSetBox = New System.Windows.Forms.Label
        Me.lblAbilityBox = New System.Windows.Forms.Label
        Me.lblRulesBox = New System.Windows.Forms.Label
        Me.lblPowerBox = New System.Windows.Forms.Label
        Me.lblCostBox = New System.Windows.Forms.Label
        Me.lblRaceBox = New System.Windows.Forms.Label
        Me.lblTypeBox = New System.Windows.Forms.Label
        Me.lblCivBox = New System.Windows.Forms.Label
        Me.lblNameBox = New System.Windows.Forms.Label
        Me.ofdDeck = New System.Windows.Forms.OpenFileDialog
        Me.sfdDialog = New System.Windows.Forms.SaveFileDialog
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcSearch_N_Fav.SuspendLayout()
        Me.tbpageSearch.SuspendLayout()
        Me.tbpageFav.SuspendLayout()
        CType(Me.dgvFav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxTasks.SuspendLayout()
        Me.grbxSearch.SuspendLayout()
        CType(Me.nupPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.AllowUserToResizeRows = False
        Me.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSearch.ColumnHeadersHeight = 20
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSearch.Location = New System.Drawing.Point(3, 3)
        Me.dgvSearch.MultiSelect = False
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.RowHeadersVisible = False
        Me.dgvSearch.RowHeadersWidth = 14
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSearch.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(254, 296)
        Me.dgvSearch.TabIndex = 0
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(444, 317)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(338, 232)
        Me.txtDescription.TabIndex = 1
        '
        'tbcSearch_N_Fav
        '
        Me.tbcSearch_N_Fav.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcSearch_N_Fav.Controls.Add(Me.tbpageSearch)
        Me.tbcSearch_N_Fav.Controls.Add(Me.tbpageFav)
        Me.tbcSearch_N_Fav.Location = New System.Drawing.Point(17, 4)
        Me.tbcSearch_N_Fav.MaximumSize = New System.Drawing.Size(400, 4000)
        Me.tbcSearch_N_Fav.Name = "tbcSearch_N_Fav"
        Me.tbcSearch_N_Fav.SelectedIndex = 0
        Me.tbcSearch_N_Fav.Size = New System.Drawing.Size(268, 328)
        Me.tbcSearch_N_Fav.TabIndex = 0
        '
        'tbpageSearch
        '
        Me.tbpageSearch.Controls.Add(Me.dgvSearch)
        Me.tbpageSearch.Location = New System.Drawing.Point(4, 22)
        Me.tbpageSearch.Name = "tbpageSearch"
        Me.tbpageSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpageSearch.Size = New System.Drawing.Size(260, 302)
        Me.tbpageSearch.TabIndex = 0
        Me.tbpageSearch.Text = "Search"
        Me.tbpageSearch.UseVisualStyleBackColor = True
        '
        'tbpageFav
        '
        Me.tbpageFav.Controls.Add(Me.dgvFav)
        Me.tbpageFav.Location = New System.Drawing.Point(4, 22)
        Me.tbpageFav.Name = "tbpageFav"
        Me.tbpageFav.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpageFav.Size = New System.Drawing.Size(260, 302)
        Me.tbpageFav.TabIndex = 1
        Me.tbpageFav.Text = "Favourites"
        Me.tbpageFav.UseVisualStyleBackColor = True
        '
        'dgvFav
        '
        Me.dgvFav.AllowUserToAddRows = False
        Me.dgvFav.AllowUserToDeleteRows = False
        Me.dgvFav.AllowUserToResizeRows = False
        Me.dgvFav.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvFav.ColumnHeadersHeight = 20
        Me.dgvFav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFav.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvFav.Location = New System.Drawing.Point(3, 3)
        Me.dgvFav.MultiSelect = False
        Me.dgvFav.Name = "dgvFav"
        Me.dgvFav.ReadOnly = True
        Me.dgvFav.RowHeadersVisible = False
        Me.dgvFav.RowHeadersWidth = 14
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dgvFav.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFav.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFav.Size = New System.Drawing.Size(254, 296)
        Me.dgvFav.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(137, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(137, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(136, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(136, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(115, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 552)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(794, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'picCard
        '
        Me.picCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCard.Image = Global.DMC_3.My.Resources.Resources.CardBack
        Me.picCard.Location = New System.Drawing.Point(560, 4)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(222, 307)
        Me.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard.TabIndex = 6
        Me.picCard.TabStop = False
        '
        'lstDeck
        '
        Me.lstDeck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstDeck.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hdrName, Me.hdrCopies})
        Me.lstDeck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDeck.FullRowSelect = True
        Me.lstDeck.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstDeck.HideSelection = False
        Me.lstDeck.Location = New System.Drawing.Point(12, 338)
        Me.lstDeck.MultiSelect = False
        Me.lstDeck.Name = "lstDeck"
        Me.lstDeck.Size = New System.Drawing.Size(269, 211)
        Me.lstDeck.TabIndex = 2
        Me.lstDeck.UseCompatibleStateImageBehavior = False
        Me.lstDeck.View = System.Windows.Forms.View.Details
        '
        'hdrName
        '
        Me.hdrName.Text = "Card Name"
        Me.hdrName.Width = 170
        '
        'hdrCopies
        '
        Me.hdrCopies.Text = "Copies"
        Me.hdrCopies.Width = 92
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.OpenToolStripMenuItem1, Me.toolStripSeparator6, Me.SaveToolStripMenuItem1, Me.SaveAsToolStripMenuItem1, Me.toolStripSeparator7, Me.PrintToolStripMenuItem1, Me.PrintPreviewToolStripMenuItem1, Me.toolStripSeparator8, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Image = CType(resources.GetObject("NewToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.NewToolStripMenuItem1.Text = "&New"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Image = CType(resources.GetObject("OpenToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.OpenToolStripMenuItem1.Text = "&Open"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(134, 6)
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Image = CType(resources.GetObject("SaveToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.SaveToolStripMenuItem1.Text = "&Save"
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.SaveAsToolStripMenuItem1.Text = "Save &As"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(134, 6)
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Image = CType(resources.GetObject("PrintToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.PrintToolStripMenuItem1.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem1
        '
        Me.PrintPreviewToolStripMenuItem1.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem1.Name = "PrintPreviewToolStripMenuItem1"
        Me.PrintPreviewToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.PrintPreviewToolStripMenuItem1.Text = "Print Pre&view"
        '
        'toolStripSeparator8
        '
        Me.toolStripSeparator8.Name = "toolStripSeparator8"
        Me.toolStripSeparator8.Size = New System.Drawing.Size(134, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem1, Me.RedoToolStripMenuItem1, Me.toolStripSeparator9, Me.CutToolStripMenuItem1, Me.CopyToolStripMenuItem1, Me.PasteToolStripMenuItem1, Me.toolStripSeparator10, Me.SelectAllToolStripMenuItem1})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem1.Text = "&Edit"
        '
        'UndoToolStripMenuItem1
        '
        Me.UndoToolStripMenuItem1.Name = "UndoToolStripMenuItem1"
        Me.UndoToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.UndoToolStripMenuItem1.Text = "&Undo"
        '
        'RedoToolStripMenuItem1
        '
        Me.RedoToolStripMenuItem1.Name = "RedoToolStripMenuItem1"
        Me.RedoToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.RedoToolStripMenuItem1.Text = "&Redo"
        '
        'toolStripSeparator9
        '
        Me.toolStripSeparator9.Name = "toolStripSeparator9"
        Me.toolStripSeparator9.Size = New System.Drawing.Size(114, 6)
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.Image = CType(resources.GetObject("CutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.CutToolStripMenuItem1.Text = "Cu&t"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Image = CType(resources.GetObject("CopyToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.CopyToolStripMenuItem1.Text = "&Copy"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Image = CType(resources.GetObject("PasteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.PasteToolStripMenuItem1.Text = "&Paste"
        '
        'toolStripSeparator10
        '
        Me.toolStripSeparator10.Name = "toolStripSeparator10"
        Me.toolStripSeparator10.Size = New System.Drawing.Size(114, 6)
        '
        'SelectAllToolStripMenuItem1
        '
        Me.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1"
        Me.SelectAllToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.SelectAllToolStripMenuItem1.Text = "Select &All"
        '
        'ToolsToolStripMenuItem1
        '
        Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem1.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem1
        '
        Me.CustomizeToolStripMenuItem1.Name = "CustomizeToolStripMenuItem1"
        Me.CustomizeToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CustomizeToolStripMenuItem1.Text = "&Customize"
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.OptionsToolStripMenuItem1.Text = "&Options"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem1, Me.IndexToolStripMenuItem1, Me.SearchToolStripMenuItem1, Me.toolStripSeparator11, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'ContentsToolStripMenuItem1
        '
        Me.ContentsToolStripMenuItem1.Name = "ContentsToolStripMenuItem1"
        Me.ContentsToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.ContentsToolStripMenuItem1.Text = "&Contents"
        '
        'IndexToolStripMenuItem1
        '
        Me.IndexToolStripMenuItem1.Name = "IndexToolStripMenuItem1"
        Me.IndexToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.IndexToolStripMenuItem1.Text = "&Index"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.SearchToolStripMenuItem1.Text = "&Search"
        '
        'toolStripSeparator11
        '
        Me.toolStripSeparator11.Name = "toolStripSeparator11"
        Me.toolStripSeparator11.Size = New System.Drawing.Size(115, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.AboutToolStripMenuItem1.Text = "&About..."
        '
        'grbxTasks
        '
        Me.grbxTasks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbxTasks.Controls.Add(Me.btnClearDeck)
        Me.grbxTasks.Controls.Add(Me.btnUseDeck)
        Me.grbxTasks.Controls.Add(Me.btnAnalyseDeck)
        Me.grbxTasks.Controls.Add(Me.btnSaveDeck)
        Me.grbxTasks.Controls.Add(Me.btnLoadDeck)
        Me.grbxTasks.Controls.Add(Me.btnRemoveDeck)
        Me.grbxTasks.Controls.Add(Me.btnAddDeck)
        Me.grbxTasks.Controls.Add(Me.btnAddFav)
        Me.grbxTasks.Controls.Add(Me.btnRemFav)
        Me.grbxTasks.Location = New System.Drawing.Point(291, 329)
        Me.grbxTasks.Name = "grbxTasks"
        Me.grbxTasks.Size = New System.Drawing.Size(147, 220)
        Me.grbxTasks.TabIndex = 7
        Me.grbxTasks.TabStop = False
        '
        'btnClearDeck
        '
        Me.btnClearDeck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearDeck.Location = New System.Drawing.Point(5, 84)
        Me.btnClearDeck.Name = "btnClearDeck"
        Me.btnClearDeck.Size = New System.Drawing.Size(140, 23)
        Me.btnClearDeck.TabIndex = 8
        Me.btnClearDeck.Text = "Clear Deck"
        Me.btnClearDeck.UseVisualStyleBackColor = True
        '
        'btnUseDeck
        '
        Me.btnUseDeck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUseDeck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseDeck.Location = New System.Drawing.Point(4, 181)
        Me.btnUseDeck.Name = "btnUseDeck"
        Me.btnUseDeck.Size = New System.Drawing.Size(141, 33)
        Me.btnUseDeck.TabIndex = 7
        Me.btnUseDeck.Text = "Use Deck"
        Me.btnUseDeck.UseVisualStyleBackColor = True
        '
        'btnAnalyseDeck
        '
        Me.btnAnalyseDeck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnalyseDeck.Location = New System.Drawing.Point(5, 157)
        Me.btnAnalyseDeck.Name = "btnAnalyseDeck"
        Me.btnAnalyseDeck.Size = New System.Drawing.Size(140, 23)
        Me.btnAnalyseDeck.TabIndex = 6
        Me.btnAnalyseDeck.Text = "Analyse Deck"
        Me.btnAnalyseDeck.UseVisualStyleBackColor = True
        '
        'btnSaveDeck
        '
        Me.btnSaveDeck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveDeck.Location = New System.Drawing.Point(4, 60)
        Me.btnSaveDeck.Name = "btnSaveDeck"
        Me.btnSaveDeck.Size = New System.Drawing.Size(69, 23)
        Me.btnSaveDeck.TabIndex = 5
        Me.btnSaveDeck.Text = "Save Deck"
        Me.btnSaveDeck.UseVisualStyleBackColor = True
        '
        'btnLoadDeck
        '
        Me.btnLoadDeck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadDeck.Location = New System.Drawing.Point(74, 60)
        Me.btnLoadDeck.Name = "btnLoadDeck"
        Me.btnLoadDeck.Size = New System.Drawing.Size(71, 23)
        Me.btnLoadDeck.TabIndex = 4
        Me.btnLoadDeck.Text = "Load Deck"
        Me.btnLoadDeck.UseVisualStyleBackColor = True
        '
        'btnRemoveDeck
        '
        Me.btnRemoveDeck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveDeck.Location = New System.Drawing.Point(5, 133)
        Me.btnRemoveDeck.Name = "btnRemoveDeck"
        Me.btnRemoveDeck.Size = New System.Drawing.Size(141, 23)
        Me.btnRemoveDeck.TabIndex = 3
        Me.btnRemoveDeck.Text = "Remove from Deck"
        Me.btnRemoveDeck.UseVisualStyleBackColor = True
        '
        'btnAddDeck
        '
        Me.btnAddDeck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDeck.Location = New System.Drawing.Point(4, 109)
        Me.btnAddDeck.Name = "btnAddDeck"
        Me.btnAddDeck.Size = New System.Drawing.Size(141, 23)
        Me.btnAddDeck.TabIndex = 2
        Me.btnAddDeck.Text = "Add to Deck"
        Me.btnAddDeck.UseVisualStyleBackColor = True
        '
        'btnAddFav
        '
        Me.btnAddFav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddFav.Location = New System.Drawing.Point(4, 11)
        Me.btnAddFav.Name = "btnAddFav"
        Me.btnAddFav.Size = New System.Drawing.Size(141, 23)
        Me.btnAddFav.TabIndex = 1
        Me.btnAddFav.Text = "Add to Favourites"
        Me.btnAddFav.UseVisualStyleBackColor = True
        '
        'btnRemFav
        '
        Me.btnRemFav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemFav.Location = New System.Drawing.Point(4, 36)
        Me.btnRemFav.Name = "btnRemFav"
        Me.btnRemFav.Size = New System.Drawing.Size(141, 23)
        Me.btnRemFav.TabIndex = 0
        Me.btnRemFav.Text = "Remove from Favourites"
        Me.btnRemFav.UseVisualStyleBackColor = True
        '
        'grbxSearch
        '
        Me.grbxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbxSearch.Controls.Add(Me.nupPower)
        Me.grbxSearch.Controls.Add(Me.nupCost)
        Me.grbxSearch.Controls.Add(Me.lstCiv)
        Me.grbxSearch.Controls.Add(Me.btnReset)
        Me.grbxSearch.Controls.Add(Me.btnSearch)
        Me.grbxSearch.Controls.Add(Me.cmbSet)
        Me.grbxSearch.Controls.Add(Me.cmbAbility)
        Me.grbxSearch.Controls.Add(Me.txtRules)
        Me.grbxSearch.Controls.Add(Me.cmbPowerOp)
        Me.grbxSearch.Controls.Add(Me.cmbCostOp)
        Me.grbxSearch.Controls.Add(Me.cmbRace)
        Me.grbxSearch.Controls.Add(Me.cmbType)
        Me.grbxSearch.Controls.Add(Me.txtName)
        Me.grbxSearch.Controls.Add(Me.lblSetBox)
        Me.grbxSearch.Controls.Add(Me.lblAbilityBox)
        Me.grbxSearch.Controls.Add(Me.lblRulesBox)
        Me.grbxSearch.Controls.Add(Me.lblPowerBox)
        Me.grbxSearch.Controls.Add(Me.lblCostBox)
        Me.grbxSearch.Controls.Add(Me.lblRaceBox)
        Me.grbxSearch.Controls.Add(Me.lblTypeBox)
        Me.grbxSearch.Controls.Add(Me.lblCivBox)
        Me.grbxSearch.Controls.Add(Me.lblNameBox)
        Me.grbxSearch.Location = New System.Drawing.Point(291, 4)
        Me.grbxSearch.Name = "grbxSearch"
        Me.grbxSearch.Size = New System.Drawing.Size(252, 307)
        Me.grbxSearch.TabIndex = 2
        Me.grbxSearch.TabStop = False
        Me.grbxSearch.Text = "Search"
        '
        'nupPower
        '
        Me.nupPower.Increment = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nupPower.Location = New System.Drawing.Point(185, 162)
        Me.nupPower.Maximum = New Decimal(New Integer() {16000, 0, 0, 0})
        Me.nupPower.Name = "nupPower"
        Me.nupPower.Size = New System.Drawing.Size(55, 20)
        Me.nupPower.TabIndex = 7
        '
        'nupCost
        '
        Me.nupCost.Location = New System.Drawing.Point(74, 162)
        Me.nupCost.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.nupCost.Name = "nupCost"
        Me.nupCost.Size = New System.Drawing.Size(35, 20)
        Me.nupCost.TabIndex = 5
        '
        'lstCiv
        '
        Me.lstCiv.FormattingEnabled = True
        Me.lstCiv.Items.AddRange(New Object() {"Darkness", "Fire", "Light", "Nature", "Water"})
        Me.lstCiv.Location = New System.Drawing.Point(51, 38)
        Me.lstCiv.Name = "lstCiv"
        Me.lstCiv.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstCiv.Size = New System.Drawing.Size(195, 69)
        Me.lstCiv.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(140, 270)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(6, 270)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(105, 23)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmbSet
        '
        Me.cmbSet.AutoCompleteCustomSource.AddRange(New String() {"", "Base Set", "Evo-Crushinators of Doom", "Rampage of the Super Warriors", "Shadowclash of Blinding Light", "Survivors of Megapocalypse", "Stomp-A-Trons of Invincible Wrath", "Thundercharge of Ultra Destruction", "Epic Dragon of Hyperchaos", "Fatal Brood of Infinte Ruin", "Shockwaves of Shattered Rainbow", "Blastoplosion of Gigantic Rage", "Thrash of Hybrid Mega Creatures", "Eternal Phoenix", "Generation Gear", "Secret of Hidden Gear", "Origin of Perfect Gear", "The Over-Technocross"})
        Me.cmbSet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSet.FormattingEnabled = True
        Me.cmbSet.Items.AddRange(New Object() {"Base Set", "Evo-Crushinators of Doom", "Rampage of the Super Warriors", "Shadowclash of Blinding Light", "Survivors of Megapocalypse", "Stomp-A-Trons of Invincible Wrath", "Thundercharge of Ultra Destruction", "Epic Dragons of Hyperchaos", "Fatal Brood of Infinte Ruin", "Shockwaves of Shattered Rainbow", "Blastoplosion of Gigantic Rage", "Thrash of Hybrid Mega Creatures", "Eternal Phoenix", "Generation Gear", "Secret of the Hidden Gear", "Origin of the Perfect Gear", "The Over-Technocross"})
        Me.cmbSet.Location = New System.Drawing.Point(51, 243)
        Me.cmbSet.Name = "cmbSet"
        Me.cmbSet.Size = New System.Drawing.Size(195, 21)
        Me.cmbSet.TabIndex = 10
        '
        'cmbAbility
        '
        Me.cmbAbility.AutoCompleteCustomSource.AddRange(New String() {"Accelerator", "Blocker", "Charger", "Crew Breaker", "Double Breaker", "G Zero", "Metamorph", "Power Attacker", "Saver", "Shield Trigger", "Silent Skill", "Slayer", "Speed Attacker", "Stealth", "Strike Back", "Survivor", "Sympathy", "Tap", "Triple Breaker", "Turbo Rush", "Wave Striker"})
        Me.cmbAbility.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAbility.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAbility.FormattingEnabled = True
        Me.cmbAbility.Items.AddRange(New Object() {"Accelerator", "Blocker", "Charger", "Crew Breaker", "Double Breaker", "G Zero", "Metamorph", "Power Attacker", "Saver", "Shield Trigger", "Silent Skill", "Slayer", "Speed Attacker", "Stealth", "Strike Back", "Survivor", "Sympathy", "Tap", "Triple Breaker", "Turbo Rush", "Wave Striker"})
        Me.cmbAbility.Location = New System.Drawing.Point(51, 216)
        Me.cmbAbility.Name = "cmbAbility"
        Me.cmbAbility.Size = New System.Drawing.Size(195, 21)
        Me.cmbAbility.TabIndex = 9
        '
        'txtRules
        '
        Me.txtRules.Location = New System.Drawing.Point(74, 190)
        Me.txtRules.Name = "txtRules"
        Me.txtRules.Size = New System.Drawing.Size(172, 20)
        Me.txtRules.TabIndex = 8
        '
        'cmbPowerOp
        '
        Me.cmbPowerOp.FormattingEnabled = True
        Me.cmbPowerOp.Items.AddRange(New Object() {"=", "<", ">", "<=", ">=", "<>"})
        Me.cmbPowerOp.Location = New System.Drawing.Point(147, 161)
        Me.cmbPowerOp.Name = "cmbPowerOp"
        Me.cmbPowerOp.Size = New System.Drawing.Size(32, 21)
        Me.cmbPowerOp.TabIndex = 6
        '
        'cmbCostOp
        '
        Me.cmbCostOp.FormattingEnabled = True
        Me.cmbCostOp.Items.AddRange(New Object() {"=", "<", ">", "<=", ">=", "<>"})
        Me.cmbCostOp.Location = New System.Drawing.Point(37, 162)
        Me.cmbCostOp.Name = "cmbCostOp"
        Me.cmbCostOp.Size = New System.Drawing.Size(31, 21)
        Me.cmbCostOp.TabIndex = 4
        '
        'cmbRace
        '
        Me.cmbRace.AutoCompleteCustomSource.AddRange(New String() {"Angel Command", "Armored Dragon", "Armored Wyvern", "Armorloid", "Balloon Mushroom", "Beast Folk", "Berserker", "Big Muscle", "Brain Jacker", "Chimera", "Colony Beetle", "Cosmo Walker", "Cyber Cluster", "Cyber Lord", "Cyber Moon", "Cyber Virus", "Dark Lord", "Death Puppet", "Demon Command", "Devil Mask", "Dragonoid", "Dune Gecko", "Earth Dragon", "Earth Eater", "Featheroid", "Fire Bird", "Fish", "Gargoyle", "Gel Fish", "Ghost", "Giant", "Giant Insect", "Gladiator", "Guardian", "Hedrian", "Horned Beast", "Human", "Humanoid", "Initiate", "Leviathan", "Light Bringer", "Liquid People", "Living Dead", "Machine Eater", "Mecha Del Sol", "Mecha Thunder", "Melt Warrior", "Merfolk", "Mystery Totem", "Naga", "Pandora Box", "Parasite Worm", "Pegasus", "Phoenix", "Rainbow Phantom", "Rock Beast", "Sea Hacker", "Sea Faerie", "Soltrooper", "Spirit Quartz", "Splash Queen", "StarLight Tree", "Starnoid", "Survivor", "Tree  Folk" & Global.Microsoft.VisualBasic.ChrW(9), "Volcano Dragon", "Wild Veggies", "Wonder Trick", "Xenoparts", "Zombie Dragon"})
        Me.cmbRace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbRace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRace.FormattingEnabled = True
        Me.cmbRace.Items.AddRange(New Object() {"Angel Command", "Armored Dragon", "Armored Wyvern", "Armorloid", "Balloon Mushroom", "Beast Folk", "Berserker", "Big Muscle", "Brain Jacker", "Chimera", "Colony Beetle", "Cosmo Walker", "Cyber Cluster", "Cyber Lord", "Cyber Moon", "Cyber Virus", "Dark Lord", "Death Puppet", "Demon Command", "Devil Mask", "Dragonoid", "Dune Gecko", "Earth Dragon", "Earth Eater", "Featheroid", "Fire Bird", "Fish", "Gargoyle", "Gel Fish", "Ghost", "Giant", "Giant Insect", "Gladiator", "Guardian", "Hedrian", "Horned Beast", "Human", "Humanoid", "Initiate", "Leviathan", "Light Bringer", "Liquid People", "Living Dead", "Machine Eater", "Mecha Del Sol", "Mecha Thunder", "Melt Warrior", "Merfolk", "Mystery Totem", "Naga", "Pandora Box", "Parasite Worm", "Pegasus", "Phoenix", "Rainbow Phantom", "Rock Beast", "Sea Hacker", "Sea Faerie", "Soltrooper", "Spirit Quartz", "Splash Queen", "StarLight Tree", "Starnoid", "Survivor", "Tree  Folk" & Global.Microsoft.VisualBasic.ChrW(9), "Volcano Dragon", "Wild Veggies", "Wonder Trick", "Xenoparts", "Zombie Dragon"})
        Me.cmbRace.Location = New System.Drawing.Point(51, 136)
        Me.cmbRace.Name = "cmbRace"
        Me.cmbRace.Size = New System.Drawing.Size(195, 21)
        Me.cmbRace.TabIndex = 3
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Creature", "Spell", "Cross Gear", "Evolution Creature", "Evolution Cross Gear"})
        Me.cmbType.Location = New System.Drawing.Point(51, 111)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(195, 21)
        Me.cmbType.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AutoCompleteCustomSource.AddRange(New String() {"Abduction Charger", "Absorbing Serigel", "Accident Eye", "Acid Reflux, the Fleshboiler", "Admiral Queen", "Adomis, the Oracle", "Adventure Boar", "Aegis, Sage of Fire and Lightning", "Aeris, Flight Elemental", "Aerodactyl Kooza", "Aeropica", "Agira, the Warlord Crawler", "Akashic First, Electro-Dragon", "Akashic Second, Electro-Spirit", "Akashic Third, the Electro-Bandit", "Alcadeias, Lord of Spirits", "Alek, Solidity Enforcer", "Aless, the Oracle", "Alphadios, Lord of Spirits", "Amber Grass", "Amber Piercer", "Ambush Scorpion", "Ancient Giant", "Ancient Horn, the Watcher", "Angler Cluster", "Animatrain, the Daring Beast", "Apocalypse Day", "Apocalypse Vise", "Aqua Agent", "Aqua Bouncer", "Aqua Deformer", "Aqua Fencer", "Aqua Grappler", "Aqua Guard", "Aqua Hulcus", "Aqua Jolter", "Aqua Knight", "Aqua Master", "Aqua Meister", "Aqua Moon Age", "Aqua Officer", "Aqua Patrol", "Aqua Ranger", "Aqua Rider", "Aqua Shooter", "Aqua Skydiver", "Aqua Sniper", "Aqua Soldier", "Aqua Spy", "Aqua Strummer", "Aqua Surfer", "Aqua Trickster", "Aqua Vehicle", "Aqua Wizard", "Arc Bine, the Astounding", "Ardent Lunatron", "Arissa, Apostle of the Holy Strike", "Armored Blaster Valdios", "Armored Cannon Balbaro", "Armored Decimator Valkaizer", "Armored Raider Gandaval", "Armored Scout Gestuchar", "Armored Transport Galiacruse", "Armored Walker Urherion", "Armored Warrior Quelos", "Artisan Picora", "Asra, Vizier of Safety", "Assault Soldier Rugeeza", "Asteria, Spirit of Heaven's Blessing", "Astral Tempest", "Astral Warper", "Astrocomet Dragon", "Astronaut Skyterror", "Asylum, the Dragon Paladin", "Atomic Giganto", "Aura Blast", "Aura Pegasus, Avatar of Life", "Aurora of Reversal", "Aus Luke, Apostle of Lightblades", "Automated Weaponmaster Machai", "Automobile Man", "Auzesu, the Demonic Holy Spirit", "Avalanche Giant", "Azaghast, Tyrant of Shadows", "Baby Zoppe", "Bad Tambourine", "Badlands Lizard", "Baira, the Hidden Lunatic", "Bajura's Soul", "Bakkra Horn, the Silent", "Balesk Baj, the Timeburner", "Balforce, the Demonic Holy Spirit", "Ballas, Vizier of Electrons", "Ballom, Master of Death", "Balloonshroom Q", "Ballus, Dogfight Enforcer Q", "Balza, Seeker of Hyperpearls", "Bangren, Ancient Arhat", "Baraga, Blade of Gloom", "Baraid, the Explorer", "Barkwhip, the Smasher", "Bat Doctor, Shadow of Undeath", "Batias, the Patroller", "Battery Cluster", "Battleship Mutant", "Bazagazeal Dragon", "Bazooka Mutant", "Beinz Sayla, Guardian of Cleansing Light", "Belix, the Explorer", "Belmol, the Explorer", "Benzo, the Hidden Fury", "Beratcha, the Hidden Glutton", "Berochika, Channeler of Suns", "Betrale, the Explorer", "Bex, the Oracle", "Biancus", "Billion-Degree Dragon", "Bind Shadow", "Bingole, the Explorer", "Bix, Guardian of the Sacred Mountain", "Black Feather, Shadow of Rage", "Bladerush Skyterror Q", "Blasto, Explosive Soldier", "Blaze Cannon", "Blaze, the Super Soul", "Blazosaur Q", "Bliss Totem, Avatar of Luck", "Blizzard of Spears", "Bloodwing Mantis", "Bloody Squito", "Bloody Symbol", "Bluum Erkis, Flare Guardian", "Bodacious Giant", "Bolberg Cross Dragon", "Bolgash Dragon", "Bolmeteus Steel Dragon", "Bolshack Dragon", "Boltail Dragon", "Bolzard Dragon", "Bombat, General of Speed", "Bombazar, Dragon of Destiny", "Bombersaur", "Bonds of Justice", "Bone Assassin, the Ripper", "Bone Piercer", "Bone Reaper, Devourer of Bones", "Bone Spider", "Bone Waller, the Sturdy Barricade", "Bonfire Lizard", "Boomerang Comet", "Brad, Super Kickin' Dynamo", "Brad's Cutter", "Brain Serum", "Brave Bell", "Brawler Zyler", "Breiga, the Wicked Protector", "Brock, the Screw Soldier", "Broken Horn, the Barracading", "Bronze-Arm Tribe", "Brood Shell", "Brother Lizard", "Bruiser Dragon", "Brutal Charge", "Brutal Revenger", "Bubble Lamp", "Bubble Scarab", "Bulgluf, the Spydroid", "Buoyant Blowfish", "Burning Mane", "Burning Power", "Burnwisp Lizard", "Burst Shot", "Buu, the Invoked", "Buzz Betocchi", "Bye Bye Amoeba", "Byulah, Thief of the Red Wind", "Cabalt, the Patroller", "Calgo, Vizier of Rainclouds", "Candy Cluster", "Candy Drop", "Cannon Shell", "Cannonball Sling", "Cannoneer Bargon", "Cantankerous Giant", "Carbonite Scarab", "Carnival Totem", "Carrier Shell", "Cataclysmic Eruption", "Cavalry General Curatops", "Cavern Raider", "Cetibols", "Chain Helix", "Chains of Sacrifice", "Chaos Fish", "Chaos Strike", "Chaos Worm", "Chaotic Skyterror", "Charge Whipper", "Charmilia, the Enticer", "Chekicul, Vizier of Endurance", "Chen Treg, Vizier of Blades", "Chilias, the Oracle", "Chitta Peloru", "Choya, the Unheeding", "Clearlo, Grace Enforcer", "Cliffcrush Giant", "Clobber Totem", "Clone Factory", "Cloned Blade", "Cloned Deflector", "Cloned Nightmare", "Cloned Spike-Horn", "Cloned Spiral", "Cocco Lupia", "Coiling Vines", "Coliseum Shell", "Colossus Boost", "Comet Eye, The Spectral Spud", "Comet Missile", "Command Device", "Commanding Leopard Horn", "Conversion of Life and Spiritual Energy", "Cool Reaction", "Copper Locust", "Coral Jel", "Core-Crash Lizard", "Corile", "Corpse Charger", "Cosmic Darts", "Cosmic Nebula", "Cosmic Wing", "Cosmogold, Spectral Knight", "Courtney, Fairy of the Summer Breeze", "Crack Crawler", "Cradle of Growth", "Cragsaur", "Cranium Clamp", "Crash Lizard", "Crasher Burn", "Cratersaur", "Crath Lade, Merciless King", "Craze Valkyrie, the Drastic", "Creeping Plague", "Creis Dober, Guardian of the Barrier", "Crescent Anemone", "Crimson Back Dragon", "Crimson Divine Dragon, Garwind", "Crimson Hammer", "Crimson Rifle", "Crisis Boulder", "Critical Blade", "Crow Winger", "Crowd Mayfly", "Cruel Naga, Avatar of Fate", "Cryptic Totem", "Crystal Jouster", "Crystal Lancer", "Crystal Memory", "Crystal Paladin", "Crystal Spinslicer", "Crystal Zweilancer", "Cubela, the Prophet", "Cubic, the Prophet", "Curious Eye", "Cursed Pincher", "Cutthroat Skyterror", "Cyclolink, Spectral Knight", "Cyclone Panic", "Cyclone Totem", "Daidalos, General of Fury", "Dance of the Sproutlings", "Dandy Eggplant", "Dark Clown", "Dark Divine Dragon Belzarogue", "Dark Divine Dragon Zanbajir", "Dark Mare, the Debilitating Shadow", "Dark Raven, Shadow of Grief", "Dark Reversal", "Dark Titan Maginn", "Darkpact", "Dava Torey, Seeker of Clouds", "Dawn Giant", "Deadly Fighter Braid Claw", "Death Chaser", "Death Cruzer, the Annihilator", "Death Harp", "Death Phoenix, Avatar of Doom", "Death Smoke", "Death Waltz, Demon of Death", "Deathblade Beetle", "Deathblood, Mysterious Demon", "Deathliger, Lion of Chaos", "Dedreen, the Hidden Corrupter", "Dejiron", "Deklowaz, the Terminator", "Dekurose's Brooch", "Delorin, the Surprise Treasure", "Demonic Protector", "Demonic Queen Meigas", "Denden Percussion", "Devil Momo, Counterattack Puppet", "Dew Mushroom", "Dia Nork, Moonlight Guardian", "Diablost, the Shady General", "Diamond Cutter", "Diamondia, the Blizzard Rider", "Dimension Gate", "Dimension Splitter", "Dione", "Dive Juggler", "Divine Riptide", "Doboulgyser, Giant Rock Beast", "Dogarn, the Marauder", "Dolgazer, Veteran of Hard Battle", "Dolmarks, the Shadow Warrior", "Dolunka", "Dome Shell", "Dorballom, Lord of Demons", "Dorberos, the Imprisoning Fiend", "Doroshia, the Missionary", "Dracobarrier", "Dracodance Totem", "Draglide", "Dream Pirate, Shadow of Theft", "Dreaming Moon Knife", "Drill Bowgun", "Drill Squall", "Drum Spirit", "Dual Shock Dragon", "Dynamite Peak", "Earth Ripper, Talon of Rage", "Earthstomp Giant", "Eldritch Poison", "Electro Explorer Syrion", "Elf-X", "Elixia, Pureblade Elemental", "Elupheus, Lord of Spirits", "Emeral", "Emerald Claw", "Emerald Grass", "Emerald Mist", "Emergency Typhoon", "Emperor Maroll", "Emperor of Death, Belzeber", "Emperor Quazla", "Enchanted Soil", "Endless Puppet, Lord of Magic", "Energy Charger", "Energy Stream", "Engbelt, the Spydroid", "Engineer Kipo", "Enigmatic Cascade", "Essence Elf", "Estol, Vizier of Aqua", "Eternal Phoenix, Phoenix of the Dragon Flame", "Ethel, Star Sea Elemental", "Eureka Charger", "Evil Incarnate", "Eviscerating Warrior Lumez", "Evolution Blueprint", "Evolution Totem", "Explode Catastrophe", "Exploding Cactus", "Explosion Lizard", "Explosive Dude Joe", "Explosive Fighter Ucarn", "Explosive Trooper Zalmez", "Extreme Crawler", "Factory Shell Q", "Faerie Child", "Faerie Gift", "Faerie Life", "Faerie Scoop", "Fallen Monk of the Bloodstained Soil, Zahaku", "Fantasy Fish", "Fatal Attacker Horvath", "Fear Fang", "Feather Horn, the Tracker", "Ferrosaturn, Spectral Knight", "Fever Nuts", "Fifi, the Awakened Dragon Fairy", "Fighter Dual Fang", "Fighter of Whirlwind Vinja", "Final Dragarmor", "Fire Blade", "Fire Sweeper Burning Hellion", "Firebird Missile", "Fists of Forever", "Flame Lance Trap", "Flame Trooper Goliac", "Flametropus", "Flohdani, the Spydroid", "Flood Valve", "Flowing Anger Man", "Fluorogill Manta", "Fokker, Rider of the North Wind", "Fonch, the Oracle", "Forbidding Totem", "Forbos, Sanctum Guardian Q", "Forced Frenzy", "Forest Hornet", "Fort Megacluster", "Fortification against Barrage and Ambush", "Fortress Shell", "Frantic Chieftain", "Freezing Icehammer", "Frei, Vizier of Air", "Frost Specter, Shadow of Age", "Fruit of Eternity", "Fu Reil, Seeker of Storms", "Full Defensor", "Full Throttle Sargeant", "Funeral Song of the Beasts", "Funky Wizard", "Funnoo, Officer of Bloody Winds", "Funny Crawler", "Furious Onslaught", "Fury Totem", "Future Slash", "Gabzagul, Warlord of Pain", "Gachack, Mechanical Doll", "Gaiacrush Crawler", "Gajirabute, Vile Centurion", "Galek, the Shadow Warrior", "Galklife Dragon", "Gallia Zohl, Iron Guardian Q", "Galsaur", "Gamaa, the Assassination Puppet", "Gamil, Knight of Hatred", "Gandar, Seeker of Explosions", "Gandaval's Stapler", "Gankloak, Rogue Commando", "Garabon, the Glider", "Garatyano", "Gardner, the Invoked", "Gariel, Elemental of Sunbeams", "Garkago Dragon", "Gashi Gashi, the Brave Puppet", "Gate Lady", "Gatling Skyterror", "Gaulezal Dragon", "Gaulzaganta, Spirit of the Forested Summit", "Gazarias Dragon", "Gazer Eyes, Shadow of Secrets", "Gedora, Lord of Demons", "General Dark Fiend", "Geoshine, Spectral Knight", "Gezary, Undercover Doll", "Ghastly Drain", "Ghost Punish", "Ghost Touch", "Gigabalza", "Gigaberos", "Gigabolver", "Gigabuster", "Gigaclaws", "Gigadeus", "Gigagiele", "Gigagriff", "Gigakail", "Gigaling Q", "Gigamantis", "Gigamente", "Gigandura", "Gigappi Ponto", "Gigarayze", "Gigargon", "Gigaroaster", "Gigasander", "Gigaslug", "Gigastand", "Gigavrand", "Gigazoul", "Gigio's Hammer", "Giriel, Ghastly Warrior", "Glais Mejicula, the Extreme", "Glena Vuele, the Hypnotic", "Glorious Heaven's Arm", "Glory Muscle", "Glory Snow", "Glory Stone", "Gnarvash, Merchant of Blood", "Golden Wing Striker", "Gonta, the Warrior Savage", "Gran Gure, Space Guardian", "Gran Siris, Milky Way Guardian", "Grand Cross Catastrophe", "Grape Globbo", "Grave Worm Q", "Gray Balloon, Shadow of Greed", "Great Vegetable King, Big Nasdeen", "Green Divine Dragon Dagradolgran", "Green Divine Dragon Magragran", "Gregoria, Princess of War", "Gregorian Worm", "Grim Soul, Shadow of Reversal", "Grinning Axe, the Monstrosity", "Grinning Hunger", "Ground Giant", "Guardian of the Sacred Weapons, Rein Seius", "Gulan Rias, Speed Guardian", "Guncloak's Magnifying Glass", "Gyasuka, the Malicious Madman", "Gyulcas, Sage of the East Wind", "Hammerhead Cluster", "Hang Worm, Fetid Larva", "Hanusa, Radiance Elemental", "Hatchet Vanguard", "Hawkeye Lunatron", "Hazard Crawler", "Hazard Hopper", "Hazaria, Duke of Thorns", "Headlong Giant", "Hearty Cap'n Polligon", "Heaven's Gate", "Heavyweight Dragon", "Hell Double Claw", "Hell's Scrapper", "Hide and Seek", "Hokira", "Holy Awe", "Hopeless Vortex", "Horned Mutant", "Horrid Worm", "Hourglass Mutant", "Howlsk, the Gigantic Avatar", "Hungry Gauntlet", "Hunter Cluster", "Hunter Fish", "Hunter of the West Wind, Sharion", "Hunter, the Invoked", "Hurlosaur", "Hurricane Crawler", "Hustle Ball Tribe", "Hustle Berry", "Hydro Hurricane", "Hydrooze, the Mutant Emperor", "Hypersprint Warior Uzesol", "Hypersquid Walter", "Hysteria Lizard", "Ice Medusa", "Ice Vapor, Shadow of Anguish", "Iere, Vizier of Bullets", "Ikaz, the Spydroid", "Illusion Fish", "Illusionary Merfolk", "Illusory Berry", "Immortal Baron, Vorg", "Immortal Blade", "Impact Absorber", "Impossible Tunnel", "Infernal Command", "Innocent Hunter, Blade of All", "Innocent, the Invoked", "Inspect Seed", "Intense Evil", "Invincible Abyss", "Invincible Aura", "Invincible Cataclysm", "Invincible Scissors", "Invincible Suit", "Invincible Technology", "Invincible Unity", "Iocant, the Oracle", "Irvine, the Purger", "Jabaha's Automaton", "Jack Viper, Shadow of Doom", "Jagila, the Hidden Pillager", "Jenny, the Dismantling Puppet", "Jet Black War Demon, Dulanzames", "Jewel Spider", "Jiggly Totem", "Jil Warka, Time Guardian", "Jiruba, Precision Shooter", "Joe's Toolkit", "Judgement of the Flame Spear and the Water Blade", "Junkatz, Rabid Doll", "Justice Jamming", "Kachua, Keeper of the Icegate", "Kaemira, the Oracle", "Kalchia, the Patroller", "Kalute, Vizier of Eternity", "Kamikaze, Chainsaw Warrior", "Kanesill, the Explorer", "Karate Potato", "Keen, the Mobile Sage", "Keeper of the Sunlit Abyss", "Kejila, the Hidden Horror", "Kelp Candle", "Kibinok", "Kilstine, Nebula Elemental", "King Aquakamui", "King Benthos", "King Coral", "King Depthcon", "King Mazelan", "King Nautilus", "King Neptas", "King Oquanos", "King Ponitas", "King Ripped-Hide", "King Triumphant", "King Tsunami", "Kip Chippotto", "Kipo's Contraption", "Kizar Basiku, the Outrageous", "Klujadras", "Kolon, the Oracle", "Kooc Pollon", "Kulus, Soulshine Enforcer", "Kuukai, Finder of Karma", "Kyrstron, Lair Delver", "Kyuroro", "La Byle, Seeker of the Winds", "La Guile, Seeker of Skyfire", "La Ura Giga, Sky Guardian", "Ladia Bale, the Inspirational", "Lagoon Mermaid", "Laguna, Lightning Enforcer", "Lah, Purification Enforcer", "Lalicious", "Lamiel, Destiny Enforcer", "Langren, the Lone Wolf", "Larba Geer, the Immaculate", "Laser Whip", "Laser Wing", "Launch Locust", "Lava Walker Executo", "Laveil, Seeker of Catastrophe", "Le Quist, the Oracle", "Leaping Tornado Horn", "Legacy Shell", "Legendary Bynor", "Legionnaire Lizard", "Leila, Butterfly Shogun of Death", "Lemik, Vizier of Thought", "Lena, Vizier of Brilliance", "Light Weapon Dominica", "Light Weapon Glacier", "Light Weapon Marianna", "Light Weapon Melania", "Light Weapon Sveta", "Lightning Charger", "Lightning Grass", "Lioness Saucer", "Liquid Scope", "Live and Breathe", "Living Citadel Vosh", "Lockdown Lizard", "Locomotiver", "Logic Cube", "Logic Sphere", "Lok, Vizier of Hunting", "Lone Tear, Shadow of Solitude", "Lord of Legend Sword", "Lost Soul", "Lu Gila, Silver Rift Guardian", "Lucky Ball", "Lukia Lex, Pinnacle Guardian", "Luna Cosmoview", "Luna Eclipse", "Luna Photon", "Luna Revolver Wheel", "Luna Starbase", "Luna Trident Tower", "Lunar Charger", "Lupa, Poison-Tipped Doll", "Lurking Eel", "Macho Melon", "Mad Guitar", "Madrillon Fish", "Magical Pot", "Magma Colossus", "Magma Gazer", "Magmadragon Jagalzor", "Magmadragon Melgars", "Magmadragon Ogrist Vhal", "Magmarex", "Magris, Vizier of Magnetism", "Malibu Dancer", "Malta, the Prophet", "Malulu, Fairy of the Snowy Valley", "Mana Bonanza", "Mana Crisis", "Mana Nexus", "Marching Motherboard", "Marine Flower", "Marine Scramble", "Marinomancer", "Marrow Ooze, the Twister", "Marshall Queen", "Martial Law", "Marushias, Spirit of the Sun", "Masked Horror, Shadow of Scorn", "Masked Pomegranate", "Matchless Lord of Fear, Galumta", "Maximum Defense", "Mechadragon's Breath", "Mega Assault Wyvern", "Mega Detonator", "Megaria, Empress of Dread", "Melcap, the Ghostly Sage", "Melnia, the Aqua Shadow", "Melodic Hunter", "Meloppe", "Merlee, the Oracle", "Messa Bahna, Expanse Guardian", "Messiah, the Battlemaster", "Mestapo, the Patroller", "Metal Cook, the Exploding Flame Chef", "Metal Cook's Timer", "Metalchaos Dragon", "Metalwing Skyterror", "Meteorage Lizard", "Meteosaur", "Mettza Iron", "Mezger, Commando Leader", "Miar, Comet Elemental", "Micute, the Oracle", "Midnight Crawler", "Miele, Vizier of Lightning", "Migalo, Vizier of Spycraft", "Migasa, Adept of Chaos", "Mighty Bandit, Ace of Thieves", "Mighty Shouter", "Mihail, Celestial Elemental", "Mikay, Rattling Doll", "Milieus, the Daystretcher", "Milky Way, the Paladin", "Milliapod, Solitary Treasure", "Milporo", "Mind Capture", "Mind Reset", "Minelord Skyterror", "Mini Titan Gett", "Mint Mirage", "Miracle Portal", "Miracle Quest", "Miraculous Meltdown", "Miraculous Plague", "Miraculous Rebirth", "Miraculous Snare", "Miraculous Truce", "Mirumeru, the Love Fairy", "Misha, Channeler of Suns", "Missile Boy", "Missile Soldier Ultimo", "Mist Rias, Sonic Guardian", "Mizoy, the Oracle", "Mobile Forest", "Mobile Saint Meermax", "Moby, the Powerful Artilleryman", "Mongrel Man", "Moon Horn", "Moonlight Flash", "Moonlight, the Fallen Noble", "Moontear, Spectral Knight", "Moors, the Dirty Digger Puppet", "Morbid Medicine", "Moritz, the Purger", "Motorcycle Mutant", "Mudman", "Mulch Charger", "Mummy Wrap, Shadow of Fatigue", "Muramasa, Duke of Blades", "Muramasa's Knife", "Muscle Charger", "Mykee's Pliers", "Mysterious, Armed Soldier", "Mystic Dreamscape", "Mystic Inscription", "Mystic Magician", "Mystic Treasure Chest", "Nariel, the Oracle", "Nastasha, Channeler of Suns", "Natural Snare", "Necrodragon Bryzenaga", "Necrodragon Galbazeek", "Necrodragon Giland", "Necrodragon Izorist Vhal", "Necrodragon Jagraveen", "Necrodragon Zalva", "Nemonex, Bajula's Robomantis", "Neo Sledgehammer", "Neo Wave Catastrophe", "Neon Cluster", "Nereiz, the Patroller", "Nexus Charger", "Nial, Vizier of Dexterity", "Nicolaus, the Purger", "Night Master, Shadow of Decay", "Nightmare Invader", "Nightmare Machine", "Ninja Pumpkin", "Niofa, Horned Protector", "Niyaari, the Puppet Bomb", "Noble Enforcer", "Nocturnal Giant", "Nomad Hero Gigio", "Nomad Warrior El Gigio", "Nostalgia Fish", "Obsidian Scarab", "Ochappi, Pure Hearted Faerie", "Octillion Force", "Onslaughter Triceps", "Ophanis, Spirit of the Unified Five", "Ortegear, Spirit of Holy Weaponry", "Otherworldly Warrior Naglu", "Ouks, Vizier of Restoration", "Overload Cluster", "Pacific Champion", "Pacific Dominator", "Pakurio", "Pala Olesis, Morning Guardian", "Pangaea's Song", "Pangaea's Will", "Para Proxion, Star Orb Guardian", "Paradise Aroma", "Paradise Horn", "Paradise of Sacred Birds and Crystal", "Parole, the Life Saving Puppet", "Parshia, the Missionary", "Patrial Flame", "Pattern Egg", "Pekotan", "Peppi Pepper", "Petrova, Channeler of Suns", "Phal Eega, Dawn Guardian", "Phalangi Drum", "Phantasm Clutch", "Phantasmal Horror Gigazabal", "Phantasmal Horror Gigazald", "Phantom Dragon's Flame", "Phantom Fish", "Phantomach, the Gigatrooper", "Pharzi, the Oracle", "Photocide, Lord of the Wastes", "Picora's Wrench", "Pierr, Psycho Doll", "Pilotz, the Invoked", "Pincer Scarab", "Pinpoint Lunatron", "Pippie Kuppie", "Pixie Cocoon", "Plasma Chaser", "Pocopen, the Counterattacking Fairy", "Pointa, the Aqua Shadow", "Poison Worm", "Poisonous Dahlia", "Poisonous Mushroom", "Pokolul", "Polaris, the Prophet", "Poltalester, the Spydroid", "Popple, Flowerpetal Dancer", "Pouch Shell", "Power Blazer", "Powered Mask", "Powered Stallion", "Proclamation of Death", "Promephius Q", "Prominence Catastrophe", "Propeller Mutant", "Protective Force", "Protective Soldier Blanka", "Proteus, Spirit of Holy Force", "Prowling Elephish", "Proxion, the Prophet", "Psychic Shaper", "Psyshroom", "Pulpy Goobie", "Pulsar Tree", "Punch Trooper Bronks", "Punish Hold", "Purgatory Force", "Purple Piercer", "Pyrofighter Magnus", "Pyuzero, Prince of the South Wind", "Q-tronic Gargantua", "Q-tronic Hypermind", "Quake Staff", "Quakesaur", "Queen Maiden, the Eternal", "Queen of Protection", "Quick Avocado", "Quick Defense", "Quillspike Rumbler", "Quixotic Hero Swine Snout", "Ra Vu, Seeker of Lightning", "Radioactive Horn, the Strange", "Raging Bamboo", "Raging Dash-Horn", "Rain of Arrows", "Rainbow Gate", "Rainbow Stone", "Rapid Reincarnation", "Raptor Fish", "Rayla, Truth Enforcer", "Raza Vega, Thunder Guardian", "Razorpine Tree", "Re Bil, Seeker of Archery", "Reality Void", "Reap and Sow", "Recon Operation", "Red Ridaz', Explosive Daredevils", "Red-Eye Scorpion", "Regi Pael, Purple Shrine Guardian", "Rei Lin, the Smile Fairy", "Reincarnal, the Paladin", "Relentless Blitz", "Rentia, the Missionary", "Reso Pacos, Clear Sky Guardian", "Reusol, the Oracle", "Reverse Armor", "Revival Soldier", "Reviving Vital Horn", "Revolver Fish", "Rias, the Apostle of Recovery", "Rieille, the Prophet", "Rikabu, the Dismantler", "Rikabu's Screwdriver", "Rimuel, Cloudbreak Elemental", "Ripple Lotus Q", "Riptide Charger", "Rise and Shine", "Roar of the Earth", "Roaring Attacker Frendios", "Roaring Great-Horn", "Rocketdive Skyterror", "Rodi Gale, Night Guardian", "Rollicking Totem", "Rom, Vizier of Tendrils", "Rondobil, the Explorer", "Root Charger", "Rosa Rossa", "Rothus, the Traveler", "Roulette of Ruin", "Royal Durian", "Rubels, the Missionary", "Ruby Grass", "Rumble Gate", "Rumblesaur Q", "Rumbling Terahorn", "Rustle, Apostle of the Waltz", "Ruthless Skyterror", "Ryokudou, the Principle Defender", "Ryudmila, Channeler of Suns", "Sabermask Scarab", "Saliva Worm", "Sanfist, the Savage Vizier", "Sapian Tark, Flame Dervish", "Sarius, Vizier of Suppression", "Sasha, Channeler of Suns", "Saucer-Head Shark", "Savage Cluster", "Scalpel Spider", "Scarlet Skyterror", "Scheming Hands", "Schuka, Duke of Amnesia", "Scissor Eye", "Scissor Scarab", "Scout Cluster", "Scowling Tomato", "Scratchclaw", "Scream Slicer, Shadow of Fear", "Screaming Sunburst", "Screw Rocket", "Screwhead Lizard", "Sea Mutant Dormel", "Sea Slug", "Seamine", "Searing Wave", "Senatine Jade Tree", "Senia, Orchard Avenger", "Seven's Tower", "Shadow Moon, Cursed Shade", "Shallow Operation", "Shaman Broccoli", "Shaman Totem", "Shaman, the Invoked", "Shell Cauldron", "Shining Defense", "Shock Hurricane", "Shock Trooper Mykee", "Shout Corn", "Shtra", "Shubain, the Avenger", "Sieg Balicula, the Intense", "Siege Roller Bagash", "Silver Axe", "Silver Fist", "Silvermoon Trailblazer", "Simian Warrior Grash", "Sinister General Damudo", "Siren Concerto", "Siri, Glory Elemental", "Sirius, the Patroller", "Skeleton Soldier, the Defiled", "Skeleton Thief, the Revealer", "Skullcutter, Swarm Leader", "Skullsweeper Q", "Sky Crusher, the Agitator", "Sky Jet", "Sky Soldier Wingraios", "Skyscraper Shell", "Skysword, the Savage Vizier", "Slaphappy Soldier Galback", "Slash and Burn", "Slash Charger", "Slime Veil", "Slumber Shell", "Smash Horn Q", "Smash Warrior Stagrandu", "Smile Angler", "Snake Attack", "Snaptongue Lizard", "Sniff Mushroom", "Snip Striker Bullraizer", "Snipe Bug", "Sniper Mosquito", "Snork La, Shrine Guardian", "Soaring Wing Horn", "Soderlight, the Cold Blade", "Sol Galla, Halo Guardian", "Solar Grass", "Solar Ray", "Solar Trap", "Solario, the Patroller", "Solid Horn", "Solidskin Fish", "Sonic Wing", "Sopian", "Soul Gulp", "Soul Phoenix, Avatar of Unity", "Soulswap", "Space Titanica", "Spark Chemist, Shadow of Whim", "Sparkle Flower", "Spastic Missile", "Spectral Horn Glitalis", "Sphere of Wonder", "Spikestrike Ichthys Q", "Spinal Parasite", "Spinning Terror, the Wretched", "Spinning Totem", "Spiral Aura", "Spiral Gate", "Spiral Grass", "Spiral Lance", "Spiritual Star Dragon", "Spiritual Water", "Splash Zebrafish", "Splinterclaw Wasp", "Split-Head Hydroturtle Q", "Sporeblast Erengi", "Squawking Lunatron", "Stained Glass", "Stallob, the Lifequasher", "Stampeding Longhorn", "Static Warp", "Steam Rumbler Kain", "Steam Star", "Steamroller Mutant", "Steel Smasher", "Steel-Turret Cluster", "Stinger Ball", "Stinger Horn, the Delver", "Stinger Worm", "Stomach Garden", "Stonesaur", "Storm Shell", "Storm Wrangler, the Furious", "Strange Insect Gyunair", "Stratosphere Giant", "Stronghold of Lightning and Flame", "Stubborn Jasper", "Stunning Totem", "Submarine Labor", "Submarine Project", "Sundrop Armor", "Super Divine Dragon Abas Nonaris", "Super Divine Dragon Bramgreil", "Super Dragon Valkyrias", "Super Explosive Volcanodon", "Super Necrodragon Abzo Dolba", "Super Terradragon Bailas Gale", "Supersonic Jet Pack", "Supporting Tulip", "Surfy, the Patroller", "Surprise Totem", "Swamp Worm", "Sword Butterfly", "Sword of Benevolent Life", "Sword of Malevolent Death", "Syforce, Aurora Elemental", "Synapse Cube", "Syrius, Firmament Elemental", "Szubs Kin, Twilight Guardian", "Tagtapp, the Retaliator", "Tajimal, Vizier of Aqua", "Tangle Fist, the Weaver", "Tank Mutant", "Tanzanyte, the Awakener", "Taunting Skyterror", "Techno Totem", "Tekorax", "Teleportation", "Telescope Horn", "Telitol, the Explorer", "Tempest Baby", "Tentacle Cluster", "Tentacle Worm", "Ten-Ton Crunch", "Terradragon Anrist Vhal", "Terradragon Arque Delacerna", "Terradragon Cusdalf", "Terradragon Dakma Balgarow", "Terradragon Gamiratar", "Terradragon Regarion", "Terror Pit", "The Grave of Angels and Demons", "Thirst for the Hunt", "Thorny Mandra", "Thought Probe", "Thrash Crawler", "Three-Eyed Dragonfly", "Three-Faced Ashura Fang", "Throwing Totem", "Thrumiss, Zephyr Guardian", "Thunder Net", "Tick Tick, Swift Viral Swordfighter", "Tide Patroller", "Time Scout", "Time Tripper, the Congesting Shadow", "Titanium Cluster", "Toel, Vizier of Hope", "Toppo Runba", "Torchclencher", "Torcon", "Tornado Flame", "Toronbo, the Bone Fracturing Puppet", "Torpedo Cluster", "Torpedo Skyterror", "Totto Pipicchi", "Tower Shell", "Toxic Vibe", "Toxic Wasp", "Tra Rion, Penumbra Guardian", "Tragic Swamp", "Transmogrify", "Treasure Chance", "Trench Scarab", "Trenchdive Shark", "Tri-horn Shepherd", "Triple Brain", "Trixo, Wicked Doll", "Tropic Crawler", "Tropico", "Trouble Keyboard", "Trox, General of Destruction", "Tsunami Catastrophe", "Tulk, the Oracle", "Turtle Horn, the Imposing", "Twin Turbo", "Twin-Cannon Skyterror", "Twitch Horn, the Aggressor", "Typhoon Bazooka", "Typhoon Crawler", "Tyrant Kuwazari", "Tyrant Worm", "Uberdragon Bajula", "Uberdragon Jabaha", "Ularus, Punishment Elemental", "Ulex, the Dauntless", "Uliya, the Entrancer", "Ultimate Dragon", "Ultimate Force", "Ultra Mantis, Scourge of Fate", "Ultracide Worm", "Uncanny Turnip", "Unicorn Fish", "Unified Resistance", "Unleashed Getchell", "Upheaval", "Ur Pale, Seeker of Sunlight", "Uranus, the Paladin", "Urth, Purifying Elemental", "Vacuum Gel", "Valiant Spark", "Valiant Warrior Exorious", "Valkerios Dragon", "Valkrowzer, Ultra Rock Beast", "Valkyer, Starstorm Elemental", "Vampire Silphy", "Variable Poker", "Vashuna, Sword Dancer", "Venom Capsule", "Venom Charger", "Venom Worm", "Vess, the Oracle", "Vikorakys", "Vile Mulder, Wing of the Void", "Vine Charger", "Virtual Tripwire", "Volcanic Arrows", "Volcano Charger", "Volcano Smog, Deceptive Shade", "Vorg's Engine", "Voyager, the Paladin", "Vreemah, Freaky Mojo Totem", "Wailing Shadow Belbetphlo", "Wandering Braineater", "Warlord Ailzonius", "Warped Lunatron", "Wave Crawler", "Wave Lance", "Wave Rifle", "Webius, the Patroller", "Western Barrel, Shadow of Riots", "Whip Scorpion", "Whirling Warrior Malian", "Whisking Whirlwind", "Whispering Totem", "Wild Racer Chief Garan", "Wily Carpenter", "Wind Axe, the Warrior Savage", "Windmill Mutant", "Wingeye Moth", "Wise Starnoid, Avatar of Hope", "Wisp Howler, Shadow of Tears", "World Tree, Root of Life", "Wrangle, the Heretical Treasure", "Writhing Bone Ghoul", "Wyn, the Oracle", "X Revolver Dragon", "Xeno Mantis", "Yuliana, Channeler of Suns", "Yuluk, the Oracle", "Yuuki, the Invoked", "Zack Ranba, the Sword Attacker", "Zagaan, Knight of Darkness", "Zaltan", "Zamaru, Treasure of Darkness", "Zemechis, the Missionary", "Zepimeteus", "Zeppelin Crawler", "Zereem Crawler", "Zero Nemesis, Shadow of Panic", "Zombie Carnival", "Zorvaz, the Bonecrusher", "Zyler's Lighter"})
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Location = New System.Drawing.Point(77, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 20)
        Me.txtName.TabIndex = 0
        '
        'lblSetBox
        '
        Me.lblSetBox.AutoSize = True
        Me.lblSetBox.Location = New System.Drawing.Point(9, 246)
        Me.lblSetBox.Name = "lblSetBox"
        Me.lblSetBox.Size = New System.Drawing.Size(26, 13)
        Me.lblSetBox.TabIndex = 8
        Me.lblSetBox.Text = "Set:"
        '
        'lblAbilityBox
        '
        Me.lblAbilityBox.AutoSize = True
        Me.lblAbilityBox.Location = New System.Drawing.Point(9, 219)
        Me.lblAbilityBox.Name = "lblAbilityBox"
        Me.lblAbilityBox.Size = New System.Drawing.Size(37, 13)
        Me.lblAbilityBox.TabIndex = 7
        Me.lblAbilityBox.Text = "Ability:"
        '
        'lblRulesBox
        '
        Me.lblRulesBox.AutoSize = True
        Me.lblRulesBox.Location = New System.Drawing.Point(9, 193)
        Me.lblRulesBox.Name = "lblRulesBox"
        Me.lblRulesBox.Size = New System.Drawing.Size(61, 13)
        Me.lblRulesBox.TabIndex = 6
        Me.lblRulesBox.Text = "Rules Text:"
        '
        'lblPowerBox
        '
        Me.lblPowerBox.AutoSize = True
        Me.lblPowerBox.Location = New System.Drawing.Point(107, 166)
        Me.lblPowerBox.Name = "lblPowerBox"
        Me.lblPowerBox.Size = New System.Drawing.Size(40, 13)
        Me.lblPowerBox.TabIndex = 5
        Me.lblPowerBox.Text = "Power:"
        '
        'lblCostBox
        '
        Me.lblCostBox.AutoSize = True
        Me.lblCostBox.Location = New System.Drawing.Point(8, 166)
        Me.lblCostBox.Name = "lblCostBox"
        Me.lblCostBox.Size = New System.Drawing.Size(31, 13)
        Me.lblCostBox.TabIndex = 4
        Me.lblCostBox.Text = "Cost:"
        '
        'lblRaceBox
        '
        Me.lblRaceBox.AutoSize = True
        Me.lblRaceBox.Location = New System.Drawing.Point(7, 139)
        Me.lblRaceBox.Name = "lblRaceBox"
        Me.lblRaceBox.Size = New System.Drawing.Size(36, 13)
        Me.lblRaceBox.TabIndex = 3
        Me.lblRaceBox.Text = "Race:"
        '
        'lblTypeBox
        '
        Me.lblTypeBox.AutoSize = True
        Me.lblTypeBox.Location = New System.Drawing.Point(7, 112)
        Me.lblTypeBox.Name = "lblTypeBox"
        Me.lblTypeBox.Size = New System.Drawing.Size(34, 13)
        Me.lblTypeBox.TabIndex = 2
        Me.lblTypeBox.Text = "Type:"
        '
        'lblCivBox
        '
        Me.lblCivBox.AutoSize = True
        Me.lblCivBox.Location = New System.Drawing.Point(9, 62)
        Me.lblCivBox.Name = "lblCivBox"
        Me.lblCivBox.Size = New System.Drawing.Size(25, 13)
        Me.lblCivBox.TabIndex = 1
        Me.lblCivBox.Text = "Civ:"
        '
        'lblNameBox
        '
        Me.lblNameBox.AutoSize = True
        Me.lblNameBox.Location = New System.Drawing.Point(8, 20)
        Me.lblNameBox.Name = "lblNameBox"
        Me.lblNameBox.Size = New System.Drawing.Size(63, 13)
        Me.lblNameBox.TabIndex = 0
        Me.lblNameBox.Text = "Card Name:"
        '
        'ofdDeck
        '
        Me.ofdDeck.DefaultExt = "*.deck"
        Me.ofdDeck.Filter = "Decks (*.deck) |*.deck|All files (*.*)|*.*"
        Me.ofdDeck.InitialDirectory = "\Deck"
        '
        'sfdDialog
        '
        Me.sfdDialog.DefaultExt = "*.deck"
        Me.sfdDialog.Filter = "Decks (*.deck) |*.deck|All files (*.*)|*.*"
        Me.sfdDialog.InitialDirectory = "\Deck"
        '
        'frmDeckMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 574)
        Me.Controls.Add(Me.grbxTasks)
        Me.Controls.Add(Me.lstDeck)
        Me.Controls.Add(Me.picCard)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbcSearch_N_Fav)
        Me.Controls.Add(Me.grbxSearch)
        Me.Controls.Add(Me.txtDescription)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmDeckMaker"
        Me.Text = " Duel Masters Civilizations 3.0 Deck Maker"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcSearch_N_Fav.ResumeLayout(False)
        Me.tbpageSearch.ResumeLayout(False)
        Me.tbpageFav.ResumeLayout(False)
        CType(Me.dgvFav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxTasks.ResumeLayout(False)
        Me.grbxSearch.ResumeLayout(False)
        Me.grbxSearch.PerformLayout()
        CType(Me.nupPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents tbcSearch_N_Fav As System.Windows.Forms.TabControl
    Friend WithEvents tbpageSearch As System.Windows.Forms.TabPage
    Friend WithEvents tbpageFav As System.Windows.Forms.TabPage
    Friend WithEvents dgvFav As System.Windows.Forms.DataGridView
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents picCard As System.Windows.Forms.PictureBox
    Friend WithEvents lstDeck As System.Windows.Forms.ListView
    Friend WithEvents hdrName As System.Windows.Forms.ColumnHeader
    Friend WithEvents hdrCopies As System.Windows.Forms.ColumnHeader
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grbxTasks As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddFav As System.Windows.Forms.Button
    Friend WithEvents btnRemFav As System.Windows.Forms.Button
    Friend WithEvents grbxSearch As System.Windows.Forms.GroupBox
    Friend WithEvents nupPower As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents lstCiv As System.Windows.Forms.ListBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbSet As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAbility As System.Windows.Forms.ComboBox
    Friend WithEvents txtRules As System.Windows.Forms.TextBox
    Friend WithEvents cmbPowerOp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCostOp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRace As System.Windows.Forms.ComboBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblSetBox As System.Windows.Forms.Label
    Friend WithEvents lblAbilityBox As System.Windows.Forms.Label
    Friend WithEvents lblRulesBox As System.Windows.Forms.Label
    Friend WithEvents lblPowerBox As System.Windows.Forms.Label
    Friend WithEvents lblCostBox As System.Windows.Forms.Label
    Friend WithEvents lblRaceBox As System.Windows.Forms.Label
    Friend WithEvents lblTypeBox As System.Windows.Forms.Label
    Friend WithEvents lblCivBox As System.Windows.Forms.Label
    Friend WithEvents lblNameBox As System.Windows.Forms.Label
    Friend WithEvents btnAddDeck As System.Windows.Forms.Button
    Friend WithEvents btnRemoveDeck As System.Windows.Forms.Button
    Friend WithEvents btnLoadDeck As System.Windows.Forms.Button
    Friend WithEvents ofdDeck As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnSaveDeck As System.Windows.Forms.Button
    Friend WithEvents btnAnalyseDeck As System.Windows.Forms.Button
    Friend WithEvents btnUseDeck As System.Windows.Forms.Button
    Friend WithEvents btnClearDeck As System.Windows.Forms.Button

End Class
