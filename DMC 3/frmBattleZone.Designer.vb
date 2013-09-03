<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattleZone
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBattleZone))
        Me.CountUpdate = New System.Windows.Forms.Panel
        Me.lblOppMana = New System.Windows.Forms.Label
        Me.lblYouMana = New System.Windows.Forms.Label
        Me.lblOppDeck = New System.Windows.Forms.Label
        Me.lblYouDeck = New System.Windows.Forms.Label
        Me.lblOppGrave = New System.Windows.Forms.Label
        Me.lblYouGrave = New System.Windows.Forms.Label
        Me.lblOppHand = New System.Windows.Forms.Label
        Me.lblYouHand = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ctxHand = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiHandSummon = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiHandToGrave = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiHandToManaZone = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiHandToShield = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiHandToDeck = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.midOppBattleZone = New DMC_3.MultipleImageDisplayer
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.midOppShield = New DMC_3.MultipleImageDisplayer
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.midOppDeck = New DMC_3.MultipleImageDisplayer
        Me.tbcTopYour = New System.Windows.Forms.TabControl
        Me.tbpgBattleZone = New System.Windows.Forms.TabPage
        Me.midBattleZone = New DMC_3.MultipleImageDisplayer
        Me.tbpgShield = New System.Windows.Forms.TabPage
        Me.midShield = New DMC_3.MultipleImageDisplayer
        Me.tbpgDeck = New System.Windows.Forms.TabPage
        Me.midDeck = New DMC_3.MultipleImageDisplayer
        Me.tbcBottomYour = New System.Windows.Forms.TabControl
        Me.tbpgHand = New System.Windows.Forms.TabPage
        Me.midHand = New DMC_3.MultipleImageDisplayer
        Me.tbpgManaZone = New System.Windows.Forms.TabPage
        Me.midManaZone = New DMC_3.MultipleImageDisplayer
        Me.tbpgGrave = New System.Windows.Forms.TabPage
        Me.midGraveYard = New DMC_3.MultipleImageDisplayer
        Me.ctxManaZone = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiMZTap_Untap = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiMZtoHand = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiMZtoGY = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiMZtoShield = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiMZtoBZ = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxGraveYard = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiGYtoBZ = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiGYtoHand = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiGYtoMZ = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiGYtoShield = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxBattleZone = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiBZTap_Untap = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiBZtoGY = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiBZtoHand = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiBZtoMZ = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiBZtoShield = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiBZtoTOD = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiBZAttack = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxShield = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiShieldBreak = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiShieldPeek = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiShieldtoBZ = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiShieldShow = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiShieldtoGY = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiShieldtoMZ = New System.Windows.Forms.ToolStripMenuItem
        Me.ctxDeck = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiDeckSeeDeck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDeckSeeCard = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDecktoHand = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDecktoHandShow = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDecktoBZ = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDecktoMZ = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDecktoGY = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiDeckShuffle = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.midOppGrave = New DMC_3.MultipleImageDisplayer
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.midOppMana = New DMC_3.MultipleImageDisplayer
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.midOppHand = New DMC_3.MultipleImageDisplayer
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.tblMIDHolder = New System.Windows.Forms.TableLayoutPanel
        Me.mtsGame = New System.Windows.Forms.MenuStrip
        Me.mtsFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileResetGame = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileSoftReset = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileLoadDeck = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileSaveGame = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileLoadGame = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileMakeLog = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileGameExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsFileYourName = New System.Windows.Forms.ToolStripTextBox
        Me.mtsGameplay = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPShuffle = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPDraw = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPDrawDraw = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPDrawDrawShow = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPTODto = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPTODtoMZ = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPTODtoShield = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPFlip = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPDiscard = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPShow = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPShowDeckTopCard = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPShowDeck = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPShowHand = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPPlaceShield = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPUntapAllCards = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsGPTurnEnd = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mtsHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.txtWrite = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.rtfAll = New System.Windows.Forms.RichTextBox
        Me.mtsGPEndTurn = New System.Windows.Forms.ToolStripMenuItem
        Me.ofdDeck = New System.Windows.Forms.OpenFileDialog
        Me.chkATM = New System.Windows.Forms.CheckBox
        Me.grbxConnect = New System.Windows.Forms.GroupBox

        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnConnect = New System.Windows.Forms.Button
        Me.btnListen = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTheirIp = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtYourIP = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CountUpdate.SuspendLayout()
        Me.ctxHand.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.tbcTopYour.SuspendLayout()
        Me.tbpgBattleZone.SuspendLayout()
        Me.tbpgShield.SuspendLayout()
        Me.tbpgDeck.SuspendLayout()
        Me.tbcBottomYour.SuspendLayout()
        Me.tbpgHand.SuspendLayout()
        Me.tbpgManaZone.SuspendLayout()
        Me.tbpgGrave.SuspendLayout()
        Me.ctxManaZone.SuspendLayout()
        Me.ctxGraveYard.SuspendLayout()
        Me.ctxBattleZone.SuspendLayout()
        Me.ctxShield.SuspendLayout()
        Me.ctxDeck.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tblMIDHolder.SuspendLayout()
        Me.mtsGame.SuspendLayout()
        Me.grbxConnect.SuspendLayout()
        '  CType(Me.wskConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CountUpdate
        '
        Me.CountUpdate.Controls.Add(Me.lblOppMana)
        Me.CountUpdate.Controls.Add(Me.lblYouMana)
        Me.CountUpdate.Controls.Add(Me.lblOppDeck)
        Me.CountUpdate.Controls.Add(Me.lblYouDeck)
        Me.CountUpdate.Controls.Add(Me.lblOppGrave)
        Me.CountUpdate.Controls.Add(Me.lblYouGrave)
        Me.CountUpdate.Controls.Add(Me.lblOppHand)
        Me.CountUpdate.Controls.Add(Me.lblYouHand)
        Me.CountUpdate.Controls.Add(Me.Label6)
        Me.CountUpdate.Controls.Add(Me.Label5)
        Me.CountUpdate.Controls.Add(Me.Label4)
        Me.CountUpdate.Controls.Add(Me.Label3)
        Me.CountUpdate.Controls.Add(Me.Label2)
        Me.CountUpdate.Controls.Add(Me.Label1)
        Me.CountUpdate.Location = New System.Drawing.Point(8, 273)
        Me.CountUpdate.Name = "CountUpdate"
        Me.CountUpdate.Size = New System.Drawing.Size(100, 92)
        Me.CountUpdate.TabIndex = 3
        '
        'lblOppMana
        '
        Me.lblOppMana.AutoSize = True
        Me.lblOppMana.Location = New System.Drawing.Point(83, 75)
        Me.lblOppMana.Name = "lblOppMana"
        Me.lblOppMana.Size = New System.Drawing.Size(13, 13)
        Me.lblOppMana.TabIndex = 13
        Me.lblOppMana.Text = "0"
        '
        'lblYouMana
        '
        Me.lblYouMana.AutoSize = True
        Me.lblYouMana.Location = New System.Drawing.Point(56, 75)
        Me.lblYouMana.Name = "lblYouMana"
        Me.lblYouMana.Size = New System.Drawing.Size(13, 13)
        Me.lblYouMana.TabIndex = 12
        Me.lblYouMana.Text = "0"
        '
        'lblOppDeck
        '
        Me.lblOppDeck.AutoSize = True
        Me.lblOppDeck.Location = New System.Drawing.Point(83, 59)
        Me.lblOppDeck.Name = "lblOppDeck"
        Me.lblOppDeck.Size = New System.Drawing.Size(13, 13)
        Me.lblOppDeck.TabIndex = 11
        Me.lblOppDeck.Text = "0"
        '
        'lblYouDeck
        '
        Me.lblYouDeck.AutoSize = True
        Me.lblYouDeck.Location = New System.Drawing.Point(56, 59)
        Me.lblYouDeck.Name = "lblYouDeck"
        Me.lblYouDeck.Size = New System.Drawing.Size(13, 13)
        Me.lblYouDeck.TabIndex = 10
        Me.lblYouDeck.Text = "0"
        '
        'lblOppGrave
        '
        Me.lblOppGrave.AutoSize = True
        Me.lblOppGrave.Location = New System.Drawing.Point(83, 42)
        Me.lblOppGrave.Name = "lblOppGrave"
        Me.lblOppGrave.Size = New System.Drawing.Size(13, 13)
        Me.lblOppGrave.TabIndex = 9
        Me.lblOppGrave.Text = "0"
        '
        'lblYouGrave
        '
        Me.lblYouGrave.AutoSize = True
        Me.lblYouGrave.Location = New System.Drawing.Point(56, 42)
        Me.lblYouGrave.Name = "lblYouGrave"
        Me.lblYouGrave.Size = New System.Drawing.Size(13, 13)
        Me.lblYouGrave.TabIndex = 8
        Me.lblYouGrave.Text = "0"
        '
        'lblOppHand
        '
        Me.lblOppHand.AutoSize = True
        Me.lblOppHand.Location = New System.Drawing.Point(83, 25)
        Me.lblOppHand.Name = "lblOppHand"
        Me.lblOppHand.Size = New System.Drawing.Size(13, 13)
        Me.lblOppHand.TabIndex = 7
        Me.lblOppHand.Text = "0"
        '
        'lblYouHand
        '
        Me.lblYouHand.AutoSize = True
        Me.lblYouHand.Location = New System.Drawing.Point(56, 25)
        Me.lblYouHand.Name = "lblYouHand"
        Me.lblYouHand.Size = New System.Drawing.Size(13, 13)
        Me.lblYouHand.TabIndex = 6
        Me.lblYouHand.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Deck"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mana"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Grave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Opp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You"
        '
        'ctxHand
        '
        Me.ctxHand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiHandSummon, Me.tsmiHandToGrave, Me.tsmiHandToManaZone, Me.tsmiHandToShield, Me.tsmiHandToDeck})
        Me.ctxHand.Name = "cxtStandardMid"
        Me.ctxHand.ShowImageMargin = False
        Me.ctxHand.Size = New System.Drawing.Size(141, 114)
        '
        'tsmiHandSummon
        '
        Me.tsmiHandSummon.Name = "tsmiHandSummon"
        Me.tsmiHandSummon.Size = New System.Drawing.Size(140, 22)
        Me.tsmiHandSummon.Text = "Summon"
        '
        'tsmiHandToGrave
        '
        Me.tsmiHandToGrave.Name = "tsmiHandToGrave"
        Me.tsmiHandToGrave.Size = New System.Drawing.Size(140, 22)
        Me.tsmiHandToGrave.Text = "Put in Grave Yard"
        '
        'tsmiHandToManaZone
        '
        Me.tsmiHandToManaZone.Name = "tsmiHandToManaZone"
        Me.tsmiHandToManaZone.Size = New System.Drawing.Size(140, 22)
        Me.tsmiHandToManaZone.Text = "Play as Mana "
        '
        'tsmiHandToShield
        '
        Me.tsmiHandToShield.Name = "tsmiHandToShield"
        Me.tsmiHandToShield.Size = New System.Drawing.Size(140, 22)
        Me.tsmiHandToShield.Text = "Play as Shield"
        '
        'tsmiHandToDeck
        '
        Me.tsmiHandToDeck.Name = "tsmiHandToDeck"
        Me.tsmiHandToDeck.Size = New System.Drawing.Size(140, 22)
        Me.tsmiHandToDeck.Text = "Put on Top of Deck"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(67, 15)
        Me.TabControl1.Location = New System.Drawing.Point(2, 159)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(513, 155)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.midOppBattleZone)
        Me.TabPage1.Location = New System.Drawing.Point(4, 19)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(505, 132)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Battle Zone"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'midOppBattleZone
        '
        Me.midOppBattleZone.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midOppBattleZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midOppBattleZone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midOppBattleZone.Location = New System.Drawing.Point(3, 3)
        Me.midOppBattleZone.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midOppBattleZone.Name = "midOppBattleZone"
        Me.midOppBattleZone.SelectedIndex = -1
        Me.midOppBattleZone.Size = New System.Drawing.Size(499, 126)
        Me.midOppBattleZone.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.midOppShield)
        Me.TabPage2.Location = New System.Drawing.Point(4, 19)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(505, 132)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Shield"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'midOppShield
        '
        Me.midOppShield.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midOppShield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midOppShield.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midOppShield.Location = New System.Drawing.Point(3, 3)
        Me.midOppShield.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midOppShield.Name = "midOppShield"
        Me.midOppShield.SelectedIndex = -1
        Me.midOppShield.Size = New System.Drawing.Size(499, 126)
        Me.midOppShield.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.midOppDeck)
        Me.TabPage3.Location = New System.Drawing.Point(4, 19)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(505, 132)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Deck"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'midOppDeck
        '
        Me.midOppDeck.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midOppDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midOppDeck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midOppDeck.Location = New System.Drawing.Point(0, 0)
        Me.midOppDeck.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midOppDeck.Name = "midOppDeck"
        Me.midOppDeck.SelectedIndex = -1
        Me.midOppDeck.Size = New System.Drawing.Size(505, 132)
        Me.midOppDeck.TabIndex = 1
        '
        'tbcTopYour
        '
        Me.tbcTopYour.Controls.Add(Me.tbpgBattleZone)
        Me.tbcTopYour.Controls.Add(Me.tbpgShield)
        Me.tbcTopYour.Controls.Add(Me.tbpgDeck)
        Me.tbcTopYour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcTopYour.ItemSize = New System.Drawing.Size(67, 15)
        Me.tbcTopYour.Location = New System.Drawing.Point(2, 316)
        Me.tbcTopYour.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcTopYour.Name = "tbcTopYour"
        Me.tbcTopYour.SelectedIndex = 0
        Me.tbcTopYour.Size = New System.Drawing.Size(513, 155)
        Me.tbcTopYour.TabIndex = 0
        '
        'tbpgBattleZone
        '
        Me.tbpgBattleZone.Controls.Add(Me.midBattleZone)
        Me.tbpgBattleZone.Location = New System.Drawing.Point(4, 19)
        Me.tbpgBattleZone.Name = "tbpgBattleZone"
        Me.tbpgBattleZone.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgBattleZone.Size = New System.Drawing.Size(505, 132)
        Me.tbpgBattleZone.TabIndex = 0
        Me.tbpgBattleZone.Text = "Battle Zone"
        Me.tbpgBattleZone.UseVisualStyleBackColor = True
        '
        'midBattleZone
        '
        Me.midBattleZone.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midBattleZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midBattleZone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midBattleZone.Location = New System.Drawing.Point(3, 3)
        Me.midBattleZone.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midBattleZone.Name = "midBattleZone"
        Me.midBattleZone.SelectedIndex = -1
        Me.midBattleZone.Size = New System.Drawing.Size(499, 126)
        Me.midBattleZone.TabIndex = 0
        '
        'tbpgShield
        '
        Me.tbpgShield.Controls.Add(Me.midShield)
        Me.tbpgShield.Location = New System.Drawing.Point(4, 19)
        Me.tbpgShield.Name = "tbpgShield"
        Me.tbpgShield.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgShield.Size = New System.Drawing.Size(505, 132)
        Me.tbpgShield.TabIndex = 1
        Me.tbpgShield.Text = "Shield"
        Me.tbpgShield.UseVisualStyleBackColor = True
        '
        'midShield
        '
        Me.midShield.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midShield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midShield.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midShield.Location = New System.Drawing.Point(3, 3)
        Me.midShield.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midShield.Name = "midShield"
        Me.midShield.SelectedIndex = -1
        Me.midShield.Size = New System.Drawing.Size(499, 126)
        Me.midShield.TabIndex = 0
        '
        'tbpgDeck
        '
        Me.tbpgDeck.Controls.Add(Me.midDeck)
        Me.tbpgDeck.Location = New System.Drawing.Point(4, 19)
        Me.tbpgDeck.Name = "tbpgDeck"
        Me.tbpgDeck.Size = New System.Drawing.Size(505, 132)
        Me.tbpgDeck.TabIndex = 2
        Me.tbpgDeck.Text = "Deck"
        Me.tbpgDeck.UseVisualStyleBackColor = True
        '
        'midDeck
        '
        Me.midDeck.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midDeck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midDeck.Location = New System.Drawing.Point(0, 0)
        Me.midDeck.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midDeck.Name = "midDeck"
        Me.midDeck.SelectedIndex = -1
        Me.midDeck.Size = New System.Drawing.Size(505, 132)
        Me.midDeck.TabIndex = 1
        '
        'tbcBottomYour
        '
        Me.tbcBottomYour.Controls.Add(Me.tbpgHand)
        Me.tbcBottomYour.Controls.Add(Me.tbpgManaZone)
        Me.tbcBottomYour.Controls.Add(Me.tbpgGrave)
        Me.tbcBottomYour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcBottomYour.ItemSize = New System.Drawing.Size(42, 15)
        Me.tbcBottomYour.Location = New System.Drawing.Point(2, 473)
        Me.tbcBottomYour.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcBottomYour.Name = "tbcBottomYour"
        Me.tbcBottomYour.SelectedIndex = 0
        Me.tbcBottomYour.Size = New System.Drawing.Size(513, 157)
        Me.tbcBottomYour.TabIndex = 0
        '
        'tbpgHand
        '
        Me.tbpgHand.Controls.Add(Me.midHand)
        Me.tbpgHand.Location = New System.Drawing.Point(4, 19)
        Me.tbpgHand.Name = "tbpgHand"
        Me.tbpgHand.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgHand.Size = New System.Drawing.Size(505, 134)
        Me.tbpgHand.TabIndex = 0
        Me.tbpgHand.Text = "Hand"
        Me.tbpgHand.UseVisualStyleBackColor = True
        '
        'midHand
        '
        Me.midHand.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midHand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midHand.Location = New System.Drawing.Point(3, 3)
        Me.midHand.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midHand.Name = "midHand"
        Me.midHand.SelectedIndex = -1
        Me.midHand.Size = New System.Drawing.Size(499, 128)
        Me.midHand.TabIndex = 1
        '
        'tbpgManaZone
        '
        Me.tbpgManaZone.Controls.Add(Me.midManaZone)
        Me.tbpgManaZone.Location = New System.Drawing.Point(4, 19)
        Me.tbpgManaZone.Name = "tbpgManaZone"
        Me.tbpgManaZone.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgManaZone.Size = New System.Drawing.Size(505, 134)
        Me.tbpgManaZone.TabIndex = 1
        Me.tbpgManaZone.Text = "Mana Zone"
        Me.tbpgManaZone.UseVisualStyleBackColor = True
        '
        'midManaZone
        '
        Me.midManaZone.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midManaZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midManaZone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midManaZone.Location = New System.Drawing.Point(3, 3)
        Me.midManaZone.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midManaZone.Name = "midManaZone"
        Me.midManaZone.SelectedIndex = -1
        Me.midManaZone.Size = New System.Drawing.Size(499, 128)
        Me.midManaZone.TabIndex = 1
        '
        'tbpgGrave
        '
        Me.tbpgGrave.Controls.Add(Me.midGraveYard)
        Me.tbpgGrave.Location = New System.Drawing.Point(4, 19)
        Me.tbpgGrave.Name = "tbpgGrave"
        Me.tbpgGrave.Size = New System.Drawing.Size(505, 134)
        Me.tbpgGrave.TabIndex = 2
        Me.tbpgGrave.Text = "Grave Yard"
        Me.tbpgGrave.UseVisualStyleBackColor = True
        '
        'midGraveYard
        '
        Me.midGraveYard.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midGraveYard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midGraveYard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midGraveYard.Location = New System.Drawing.Point(0, 0)
        Me.midGraveYard.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midGraveYard.Name = "midGraveYard"
        Me.midGraveYard.SelectedIndex = -1
        Me.midGraveYard.Size = New System.Drawing.Size(505, 134)
        Me.midGraveYard.TabIndex = 1
        '
        'ctxManaZone
        '
        Me.ctxManaZone.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMZTap_Untap, Me.tsmiMZtoHand, Me.tsmiMZtoGY, Me.tsmiMZtoShield, Me.tsmiMZtoBZ})
        Me.ctxManaZone.Name = "ctxManaZone"
        Me.ctxManaZone.ShowImageMargin = False
        Me.ctxManaZone.Size = New System.Drawing.Size(135, 114)
        '
        'tsmiMZTap_Untap
        '
        Me.tsmiMZTap_Untap.Name = "tsmiMZTap_Untap"
        Me.tsmiMZTap_Untap.Size = New System.Drawing.Size(134, 22)
        Me.tsmiMZTap_Untap.Text = "Tap/Untap"
        '
        'tsmiMZtoHand
        '
        Me.tsmiMZtoHand.Name = "tsmiMZtoHand"
        Me.tsmiMZtoHand.Size = New System.Drawing.Size(134, 22)
        Me.tsmiMZtoHand.Text = "Send to Hand"
        '
        'tsmiMZtoGY
        '
        Me.tsmiMZtoGY.Name = "tsmiMZtoGY"
        Me.tsmiMZtoGY.Size = New System.Drawing.Size(134, 22)
        Me.tsmiMZtoGY.Text = "Put in Graveyard"
        '
        'tsmiMZtoShield
        '
        Me.tsmiMZtoShield.Name = "tsmiMZtoShield"
        Me.tsmiMZtoShield.Size = New System.Drawing.Size(134, 22)
        Me.tsmiMZtoShield.Text = "Play as Shield"
        '
        'tsmiMZtoBZ
        '
        Me.tsmiMZtoBZ.Name = "tsmiMZtoBZ"
        Me.tsmiMZtoBZ.Size = New System.Drawing.Size(134, 22)
        Me.tsmiMZtoBZ.Text = "Put in Battle Zone"
        '
        'ctxGraveYard
        '
        Me.ctxGraveYard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiGYtoBZ, Me.tsmiGYtoHand, Me.tsmiGYtoMZ, Me.tsmiGYtoShield})
        Me.ctxGraveYard.Name = "ctxGrave"
        Me.ctxGraveYard.ShowImageMargin = False
        Me.ctxGraveYard.Size = New System.Drawing.Size(132, 92)
        '
        'tsmiGYtoBZ
        '
        Me.tsmiGYtoBZ.Name = "tsmiGYtoBZ"
        Me.tsmiGYtoBZ.Size = New System.Drawing.Size(131, 22)
        Me.tsmiGYtoBZ.Text = "Put in BattleZone"
        '
        'tsmiGYtoHand
        '
        Me.tsmiGYtoHand.Name = "tsmiGYtoHand"
        Me.tsmiGYtoHand.Size = New System.Drawing.Size(131, 22)
        Me.tsmiGYtoHand.Text = "Send to Hand"
        Me.tsmiGYtoHand.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tsmiGYtoMZ
        '
        Me.tsmiGYtoMZ.Name = "tsmiGYtoMZ"
        Me.tsmiGYtoMZ.Size = New System.Drawing.Size(131, 22)
        Me.tsmiGYtoMZ.Text = "Play as Mana"
        '
        'tsmiGYtoShield
        '
        Me.tsmiGYtoShield.Name = "tsmiGYtoShield"
        Me.tsmiGYtoShield.Size = New System.Drawing.Size(131, 22)
        Me.tsmiGYtoShield.Text = "Play as Shield"
        '
        'ctxBattleZone
        '
        Me.ctxBattleZone.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiBZTap_Untap, Me.tsmiBZtoGY, Me.tsmiBZtoHand, Me.tsmiBZtoMZ, Me.tsmiBZtoShield, Me.tsmiBZtoTOD, Me.tsmiBZAttack})
        Me.ctxBattleZone.Name = "ctxBattleZone"
        Me.ctxBattleZone.ShowImageMargin = False
        Me.ctxBattleZone.Size = New System.Drawing.Size(141, 158)
        '
        'tsmiBZTap_Untap
        '
        Me.tsmiBZTap_Untap.Name = "tsmiBZTap_Untap"
        Me.tsmiBZTap_Untap.Size = New System.Drawing.Size(140, 22)
        Me.tsmiBZTap_Untap.Text = "Tap/Untap"
        '
        'tsmiBZtoGY
        '
        Me.tsmiBZtoGY.Name = "tsmiBZtoGY"
        Me.tsmiBZtoGY.Size = New System.Drawing.Size(140, 22)
        Me.tsmiBZtoGY.Text = "Put in Graveyard"
        '
        'tsmiBZtoHand
        '
        Me.tsmiBZtoHand.Name = "tsmiBZtoHand"
        Me.tsmiBZtoHand.Size = New System.Drawing.Size(140, 22)
        Me.tsmiBZtoHand.Text = "Send to Hand"
        '
        'tsmiBZtoMZ
        '
        Me.tsmiBZtoMZ.Name = "tsmiBZtoMZ"
        Me.tsmiBZtoMZ.Size = New System.Drawing.Size(140, 22)
        Me.tsmiBZtoMZ.Text = "Play as Mana"
        '
        'tsmiBZtoShield
        '
        Me.tsmiBZtoShield.Name = "tsmiBZtoShield"
        Me.tsmiBZtoShield.Size = New System.Drawing.Size(140, 22)
        Me.tsmiBZtoShield.Text = "Play as Shield"
        '
        'tsmiBZtoTOD
        '
        Me.tsmiBZtoTOD.Name = "tsmiBZtoTOD"
        Me.tsmiBZtoTOD.Size = New System.Drawing.Size(140, 22)
        Me.tsmiBZtoTOD.Text = "Put on Top of Deck"
        '
        'tsmiBZAttack
        '
        Me.tsmiBZAttack.Name = "tsmiBZAttack"
        Me.tsmiBZAttack.Size = New System.Drawing.Size(140, 22)
        Me.tsmiBZAttack.Text = "Attack"
        '
        'ctxShield
        '
        Me.ctxShield.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiShieldBreak, Me.tsmiShieldPeek, Me.tsmiShieldtoBZ, Me.tsmiShieldShow, Me.tsmiShieldtoGY, Me.tsmiShieldtoMZ})
        Me.ctxShield.Name = "ctxShield"
        Me.ctxShield.ShowImageMargin = False
        Me.ctxShield.Size = New System.Drawing.Size(171, 136)
        '
        'tsmiShieldBreak
        '
        Me.tsmiShieldBreak.Name = "tsmiShieldBreak"
        Me.tsmiShieldBreak.Size = New System.Drawing.Size(170, 22)
        Me.tsmiShieldBreak.Text = "Break this Shield"
        '
        'tsmiShieldPeek
        '
        Me.tsmiShieldPeek.Name = "tsmiShieldPeek"
        Me.tsmiShieldPeek.Size = New System.Drawing.Size(170, 22)
        Me.tsmiShieldPeek.Text = "View your Shield"
        '
        'tsmiShieldtoBZ
        '
        Me.tsmiShieldtoBZ.Name = "tsmiShieldtoBZ"
        Me.tsmiShieldtoBZ.Size = New System.Drawing.Size(170, 22)
        Me.tsmiShieldtoBZ.Text = "Put in Battlezone"
        '
        'tsmiShieldShow
        '
        Me.tsmiShieldShow.Name = "tsmiShieldShow"
        Me.tsmiShieldShow.Size = New System.Drawing.Size(170, 22)
        Me.tsmiShieldShow.Text = "Show Shield to Opponent"
        '
        'tsmiShieldtoGY
        '
        Me.tsmiShieldtoGY.Name = "tsmiShieldtoGY"
        Me.tsmiShieldtoGY.Size = New System.Drawing.Size(170, 22)
        Me.tsmiShieldtoGY.Text = "Send to Graveyard"
        '
        'tsmiShieldtoMZ
        '
        Me.tsmiShieldtoMZ.Name = "tsmiShieldtoMZ"
        Me.tsmiShieldtoMZ.Size = New System.Drawing.Size(170, 22)
        Me.tsmiShieldtoMZ.Text = "Play as Mana"
        '
        'ctxDeck
        '
        Me.ctxDeck.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDeckSeeDeck, Me.tsmiDeckSeeCard, Me.tsmiDecktoHand, Me.tsmiDecktoHandShow, Me.tsmiDecktoBZ, Me.tsmiDecktoMZ, Me.tsmiDecktoGY, Me.tsmiDeckShuffle})
        Me.ctxDeck.Name = "ContextMenuStrip1"
        Me.ctxDeck.ShowImageMargin = False
        Me.ctxDeck.Size = New System.Drawing.Size(165, 180)
        '
        'tsmiDeckSeeDeck
        '
        Me.tsmiDeckSeeDeck.Name = "tsmiDeckSeeDeck"
        Me.tsmiDeckSeeDeck.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDeckSeeDeck.Text = "See/Hide Your Deck"
        '
        'tsmiDeckSeeCard
        '
        Me.tsmiDeckSeeCard.Name = "tsmiDeckSeeCard"
        Me.tsmiDeckSeeCard.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDeckSeeCard.Text = "Look at this Card only"
        '
        'tsmiDecktoHand
        '
        Me.tsmiDecktoHand.Name = "tsmiDecktoHand"
        Me.tsmiDecktoHand.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDecktoHand.Text = "Send to Hand"
        '
        'tsmiDecktoHandShow
        '
        Me.tsmiDecktoHandShow.Name = "tsmiDecktoHandShow"
        Me.tsmiDecktoHandShow.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDecktoHandShow.Text = "Send to Hand and Show"
        '
        'tsmiDecktoBZ
        '
        Me.tsmiDecktoBZ.Name = "tsmiDecktoBZ"
        Me.tsmiDecktoBZ.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDecktoBZ.Text = "Put in Battle Zone"
        '
        'tsmiDecktoMZ
        '
        Me.tsmiDecktoMZ.Name = "tsmiDecktoMZ"
        Me.tsmiDecktoMZ.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDecktoMZ.Text = "Play as Mana"
        '
        'tsmiDecktoGY
        '
        Me.tsmiDecktoGY.Name = "tsmiDecktoGY"
        Me.tsmiDecktoGY.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDecktoGY.Text = "Send to Graveyard"
        '
        'tsmiDeckShuffle
        '
        Me.tsmiDeckShuffle.Name = "tsmiDeckShuffle"
        Me.tsmiDeckShuffle.Size = New System.Drawing.Size(164, 22)
        Me.tsmiDeckShuffle.Text = "Shuffle"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.midOppGrave)
        Me.TabPage6.Location = New System.Drawing.Point(4, 19)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(505, 132)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Grave Yard"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'midOppGrave
        '
        Me.midOppGrave.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midOppGrave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midOppGrave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midOppGrave.Location = New System.Drawing.Point(0, 0)
        Me.midOppGrave.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midOppGrave.Name = "midOppGrave"
        Me.midOppGrave.SelectedIndex = -1
        Me.midOppGrave.Size = New System.Drawing.Size(505, 132)
        Me.midOppGrave.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.midOppMana)
        Me.TabPage5.Location = New System.Drawing.Point(4, 19)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(505, 132)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Mana Zone"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'midOppMana
        '
        Me.midOppMana.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midOppMana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midOppMana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midOppMana.Location = New System.Drawing.Point(3, 3)
        Me.midOppMana.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midOppMana.Name = "midOppMana"
        Me.midOppMana.SelectedIndex = -1
        Me.midOppMana.Size = New System.Drawing.Size(499, 126)
        Me.midOppMana.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.midOppHand)
        Me.TabPage4.Location = New System.Drawing.Point(4, 19)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(505, 132)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Hand"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'midOppHand
        '
        Me.midOppHand.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.midOppHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.midOppHand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.midOppHand.Location = New System.Drawing.Point(3, 3)
        Me.midOppHand.MinimumSize = New System.Drawing.Size(60, 60)
        Me.midOppHand.Name = "midOppHand"
        Me.midOppHand.SelectedIndex = -1
        Me.midOppHand.Size = New System.Drawing.Size(499, 126)
        Me.midOppHand.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ItemSize = New System.Drawing.Size(42, 15)
        Me.TabControl2.Location = New System.Drawing.Point(2, 2)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(513, 155)
        Me.TabControl2.TabIndex = 1
        '
        'tblMIDHolder
        '
        Me.tblMIDHolder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblMIDHolder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.tblMIDHolder.ColumnCount = 1
        Me.tblMIDHolder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMIDHolder.Controls.Add(Me.TabControl2, 0, 0)
        Me.tblMIDHolder.Controls.Add(Me.tbcBottomYour, 0, 3)
        Me.tblMIDHolder.Controls.Add(Me.TabControl1, 0, 1)
        Me.tblMIDHolder.Controls.Add(Me.tbcTopYour, 0, 2)
        Me.tblMIDHolder.Location = New System.Drawing.Point(269, 25)
        Me.tblMIDHolder.Margin = New System.Windows.Forms.Padding(1)
        Me.tblMIDHolder.Name = "tblMIDHolder"
        Me.tblMIDHolder.RowCount = 4
        Me.tblMIDHolder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMIDHolder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMIDHolder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMIDHolder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMIDHolder.Size = New System.Drawing.Size(517, 632)
        Me.tblMIDHolder.TabIndex = 6
        '
        'mtsGame
        '
        Me.mtsGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsFile, Me.mtsGameplay, Me.mtsHelp})
        Me.mtsGame.Location = New System.Drawing.Point(0, 0)
        Me.mtsGame.Name = "mtsGame"
        Me.mtsGame.Size = New System.Drawing.Size(788, 24)
        Me.mtsGame.TabIndex = 7
        Me.mtsGame.Text = "File"
        '
        'mtsFile
        '
        Me.mtsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsFileResetGame, Me.mtsFileSoftReset, Me.mtsFileLoadDeck, Me.mtsFileSaveGame, Me.mtsFileLoadGame, Me.mtsFileMakeLog, Me.mtsFileGameExit, Me.mtsFileYourName})
        Me.mtsFile.Name = "mtsFile"
        Me.mtsFile.Size = New System.Drawing.Size(35, 20)
        Me.mtsFile.Text = "File"
        '
        'mtsFileResetGame
        '
        Me.mtsFileResetGame.Name = "mtsFileResetGame"
        Me.mtsFileResetGame.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mtsFileResetGame.Size = New System.Drawing.Size(229, 22)
        Me.mtsFileResetGame.Text = "Reset Game"
        '
        'mtsFileSoftReset
        '
        Me.mtsFileSoftReset.Name = "mtsFileSoftReset"
        Me.mtsFileSoftReset.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mtsFileSoftReset.Size = New System.Drawing.Size(229, 22)
        Me.mtsFileSoftReset.Text = "Soft Reset Game"
        '
        'mtsFileLoadDeck
        '
        Me.mtsFileLoadDeck.Name = "mtsFileLoadDeck"
        Me.mtsFileLoadDeck.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mtsFileLoadDeck.Size = New System.Drawing.Size(229, 22)
        Me.mtsFileLoadDeck.Text = "Load Deck"
        '
        'mtsFileSaveGame
        '
        Me.mtsFileSaveGame.Name = "mtsFileSaveGame"
        Me.mtsFileSaveGame.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mtsFileSaveGame.Size = New System.Drawing.Size(229, 22)
        Me.mtsFileSaveGame.Text = "Save Game"
        '
        'mtsFileLoadGame
        '
        Me.mtsFileLoadGame.Name = "mtsFileLoadGame"
        Me.mtsFileLoadGame.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mtsFileLoadGame.Size = New System.Drawing.Size(229, 22)
        Me.mtsFileLoadGame.Text = "Load Game"
        '
        'mtsFileMakeLog
        '
        Me.mtsFileMakeLog.Name = "mtsFileMakeLog"
        Me.mtsFileMakeLog.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mtsFileMakeLog.Size = New System.Drawing.Size(229, 22)
        Me.mtsFileMakeLog.Text = "Make Log"
        '
        'mtsFileGameExit
        '
        Me.mtsFileGameExit.Name = "mtsFileGameExit"
        Me.mtsFileGameExit.Size = New System.Drawing.Size(229, 22)
        Me.mtsFileGameExit.Text = "Exit"
        '
        'mtsFileYourName
        '
        Me.mtsFileYourName.Name = "mtsFileYourName"
        Me.mtsFileYourName.Size = New System.Drawing.Size(100, 21)
        Me.mtsFileYourName.Text = Global.DMC_3.My.MySettings.Default.YourName
        '
        'mtsGameplay
        '
        Me.mtsGameplay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsGPShuffle, Me.mtsGPDraw, Me.mtsGPTODto, Me.mtsGPFlip, Me.mtsGPDiscard, Me.mtsGPShow, Me.mtsGPPlaceShield, Me.mtsGPUntapAllCards, Me.mtsGPTurnEnd})
        Me.mtsGameplay.Name = "mtsGameplay"
        Me.mtsGameplay.Size = New System.Drawing.Size(66, 20)
        Me.mtsGameplay.Text = "Gameplay"
        '
        'mtsGPShuffle
        '
        Me.mtsGPShuffle.Name = "mtsGPShuffle"
        Me.mtsGPShuffle.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPShuffle.Text = "Shuffle"
        '
        'mtsGPDraw
        '
        Me.mtsGPDraw.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsGPDrawDraw, Me.mtsGPDrawDrawShow})
        Me.mtsGPDraw.Name = "mtsGPDraw"
        Me.mtsGPDraw.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPDraw.Text = "Draw"
        '
        'mtsGPDrawDraw
        '
        Me.mtsGPDrawDraw.Name = "mtsGPDrawDraw"
        Me.mtsGPDrawDraw.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mtsGPDrawDraw.Size = New System.Drawing.Size(191, 22)
        Me.mtsGPDrawDraw.Text = "Draw"
        '
        'mtsGPDrawDrawShow
        '
        Me.mtsGPDrawDrawShow.Name = "mtsGPDrawDrawShow"
        Me.mtsGPDrawDrawShow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mtsGPDrawDrawShow.Size = New System.Drawing.Size(191, 22)
        Me.mtsGPDrawDrawShow.Text = "Draw and Show"
        '
        'mtsGPTODto
        '
        Me.mtsGPTODto.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsGPTODtoMZ, Me.mtsGPTODtoShield})
        Me.mtsGPTODto.Name = "mtsGPTODto"
        Me.mtsGPTODto.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPTODto.Text = "Send top card to..."
        '
        'mtsGPTODtoMZ
        '
        Me.mtsGPTODtoMZ.Name = "mtsGPTODtoMZ"
        Me.mtsGPTODtoMZ.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.mtsGPTODtoMZ.Size = New System.Drawing.Size(146, 22)
        Me.mtsGPTODtoMZ.Text = "Mana Zone"
        '
        'mtsGPTODtoShield
        '
        Me.mtsGPTODtoShield.Name = "mtsGPTODtoShield"
        Me.mtsGPTODtoShield.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mtsGPTODtoShield.Size = New System.Drawing.Size(146, 22)
        Me.mtsGPTODtoShield.Text = "Shield"
        '
        'mtsGPFlip
        '
        Me.mtsGPFlip.Name = "mtsGPFlip"
        Me.mtsGPFlip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mtsGPFlip.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPFlip.Text = "Flip a coin"
        '
        'mtsGPDiscard
        '
        Me.mtsGPDiscard.Name = "mtsGPDiscard"
        Me.mtsGPDiscard.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mtsGPDiscard.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPDiscard.Text = "Discard at Random"
        '
        'mtsGPShow
        '
        Me.mtsGPShow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsGPShowDeckTopCard, Me.mtsGPShowDeck, Me.mtsGPShowHand})
        Me.mtsGPShow.Name = "mtsGPShow"
        Me.mtsGPShow.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPShow.Text = "Reveal to Opponent your..."
        '
        'mtsGPShowDeckTopCard
        '
        Me.mtsGPShowDeckTopCard.Name = "mtsGPShowDeckTopCard"
        Me.mtsGPShowDeckTopCard.Size = New System.Drawing.Size(157, 22)
        Me.mtsGPShowDeckTopCard.Text = "Top Card of Deck"
        '
        'mtsGPShowDeck
        '
        Me.mtsGPShowDeck.Name = "mtsGPShowDeck"
        Me.mtsGPShowDeck.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.mtsGPShowDeck.Size = New System.Drawing.Size(157, 22)
        Me.mtsGPShowDeck.Text = "Deck"
        '
        'mtsGPShowHand
        '
        Me.mtsGPShowHand.Name = "mtsGPShowHand"
        Me.mtsGPShowHand.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.mtsGPShowHand.Size = New System.Drawing.Size(157, 22)
        Me.mtsGPShowHand.Text = "Hand"
        '
        'mtsGPPlaceShield
        '
        Me.mtsGPPlaceShield.Name = "mtsGPPlaceShield"
        Me.mtsGPPlaceShield.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.mtsGPPlaceShield.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPPlaceShield.Text = "Place your Shield"
        '
        'mtsGPUntapAllCards
        '
        Me.mtsGPUntapAllCards.Name = "mtsGPUntapAllCards"
        Me.mtsGPUntapAllCards.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mtsGPUntapAllCards.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPUntapAllCards.Text = "Untap All cards"
        '
        'mtsGPTurnEnd
        '
        Me.mtsGPTurnEnd.Name = "mtsGPTurnEnd"
        Me.mtsGPTurnEnd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mtsGPTurnEnd.Size = New System.Drawing.Size(208, 22)
        Me.mtsGPTurnEnd.Text = "End Turn"
        '
        'mtsHelp
        '
        Me.mtsHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsHelpAbout})
        Me.mtsHelp.Name = "mtsHelp"
        Me.mtsHelp.Size = New System.Drawing.Size(40, 20)
        Me.mtsHelp.Text = "Help"
        '
        'mtsHelpAbout
        '
        Me.mtsHelpAbout.Name = "mtsHelpAbout"
        Me.mtsHelpAbout.Size = New System.Drawing.Size(103, 22)
        Me.mtsHelpAbout.Text = "About"
        '
        'txtWrite
        '
        Me.txtWrite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWrite.Location = New System.Drawing.Point(8, 600)
        Me.txtWrite.Multiline = True
        Me.txtWrite.Name = "txtWrite"
        Me.txtWrite.Size = New System.Drawing.Size(194, 57)
        Me.txtWrite.TabIndex = 9
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.Location = New System.Drawing.Point(208, 600)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(57, 55)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'rtfAll
        '
        Me.rtfAll.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rtfAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtfAll.Location = New System.Drawing.Point(0, 407)
        Me.rtfAll.Name = "rtfAll"
        Me.rtfAll.ReadOnly = True
        Me.rtfAll.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtfAll.Size = New System.Drawing.Size(248, 205)
        Me.rtfAll.TabIndex = 11
        Me.rtfAll.Text = ""
        '
        'mtsGPEndTurn
        '
        Me.mtsGPEndTurn.Name = "mtsGPEndTurn"
        Me.mtsGPEndTurn.Size = New System.Drawing.Size(219, 22)
        Me.mtsGPEndTurn.Text = "End Turn"
        '
        'ofdDeck
        '
        Me.ofdDeck.DefaultExt = "deck"
        Me.ofdDeck.FileName = "OpenFileDialog1"
        Me.ofdDeck.Filter = """Deck files (*.deck)|*.deck|All Files (*.*)|*.*"""
        Me.ofdDeck.InitialDirectory = "\Decks"
        Me.ofdDeck.Title = "Select your deck"
        '
        'chkATM
        '
        Me.chkATM.AutoSize = True
        Me.chkATM.Checked = True
        Me.chkATM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkATM.Location = New System.Drawing.Point(8, 369)
        Me.chkATM.Name = "chkATM"
        Me.chkATM.Size = New System.Drawing.Size(100, 17)
        Me.chkATM.TabIndex = 12
        Me.chkATM.Text = "Auto Tap Mana"
        Me.chkATM.UseVisualStyleBackColor = True
        '
        'grbxConnect
        '
        '    Me.grbxConnect.Controls.Add(Me.wskConnection)
        Me.grbxConnect.Controls.Add(Me.lblStatus)
        Me.grbxConnect.Controls.Add(Me.Label9)
        Me.grbxConnect.Controls.Add(Me.btnConnect)
        Me.grbxConnect.Controls.Add(Me.btnListen)
        Me.grbxConnect.Controls.Add(Me.Label8)
        Me.grbxConnect.Controls.Add(Me.txtTheirIp)
        Me.grbxConnect.Controls.Add(Me.Label7)
        Me.grbxConnect.Controls.Add(Me.txtYourIP)
        Me.grbxConnect.Location = New System.Drawing.Point(110, 267)
        Me.grbxConnect.Name = "grbxConnect"
        Me.grbxConnect.Size = New System.Drawing.Size(155, 119)
        Me.grbxConnect.TabIndex = 13
        Me.grbxConnect.TabStop = False
        Me.grbxConnect.Text = "Connect"
        '
        'wskConnection
        '
        'Me.wskConnection.Enabled = True
        'Me.wskConnection.Location = New System.Drawing.Point(121, 88)
        'Me.wskConnection.Name = "wskConnection"
        'Me.wskConnection.OcxState = CType(resources.GetObject("wskConnection.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.wskConnection.Size = New System.Drawing.Size(28, 28)
        'Me.wskConnection.TabIndex = 8
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(42, 96)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(79, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Not Connected"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Status:"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(80, 65)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(72, 23)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(6, 65)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(67, 23)
        Me.btnListen.TabIndex = 4
        Me.btnListen.Text = "Listen"
        Me.btnListen.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Their IP"
        '
        'txtTheirIp
        '
        Me.txtTheirIp.Location = New System.Drawing.Point(46, 38)
        Me.txtTheirIp.Name = "txtTheirIp"
        Me.txtTheirIp.Size = New System.Drawing.Size(106, 20)
        Me.txtTheirIp.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Your IP"
        '
        'txtYourIP
        '
        Me.txtYourIP.Location = New System.Drawing.Point(46, 12)
        Me.txtYourIP.Name = "txtYourIP"
        Me.txtYourIP.ReadOnly = True
        Me.txtYourIP.Size = New System.Drawing.Size(106, 20)
        Me.txtYourIP.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 28)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 239)
        Me.TextBox1.TabIndex = 14
        '
        'frmBattleZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 662)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkATM)
        Me.Controls.Add(Me.mtsGame)
        Me.Controls.Add(Me.tblMIDHolder)
        Me.Controls.Add(Me.txtWrite)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.grbxConnect)
        Me.Controls.Add(Me.CountUpdate)
        Me.Controls.Add(Me.rtfAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mtsGame
        Me.MinimumSize = New System.Drawing.Size(80, 34)
        Me.Name = "frmBattleZone"
        Me.Text = "Duel Masters Civilization 3.0 Battle Zone"
        Me.TransparencyKey = System.Drawing.Color.Purple
        Me.CountUpdate.ResumeLayout(False)
        Me.CountUpdate.PerformLayout()
        Me.ctxHand.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.tbcTopYour.ResumeLayout(False)
        Me.tbpgBattleZone.ResumeLayout(False)
        Me.tbpgShield.ResumeLayout(False)
        Me.tbpgDeck.ResumeLayout(False)
        Me.tbcBottomYour.ResumeLayout(False)
        Me.tbpgHand.ResumeLayout(False)
        Me.tbpgManaZone.ResumeLayout(False)
        Me.tbpgGrave.ResumeLayout(False)
        Me.ctxManaZone.ResumeLayout(False)
        Me.ctxGraveYard.ResumeLayout(False)
        Me.ctxBattleZone.ResumeLayout(False)
        Me.ctxShield.ResumeLayout(False)
        Me.ctxDeck.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tblMIDHolder.ResumeLayout(False)
        Me.mtsGame.ResumeLayout(False)
        Me.mtsGame.PerformLayout()
        Me.grbxConnect.ResumeLayout(False)
        Me.grbxConnect.PerformLayout()
        'CType(Me.wskConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CountUpdate As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblYouGrave As System.Windows.Forms.Label
    Friend WithEvents lblOppHand As System.Windows.Forms.Label
    Friend WithEvents lblYouHand As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOppMana As System.Windows.Forms.Label
    Friend WithEvents lblYouMana As System.Windows.Forms.Label
    Friend WithEvents lblOppDeck As System.Windows.Forms.Label
    Friend WithEvents lblYouDeck As System.Windows.Forms.Label
    Friend WithEvents lblOppGrave As System.Windows.Forms.Label
    Friend WithEvents ctxHand As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiHandSummon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHandToGrave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHandToDeck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHandToManaZone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHandToShield As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents midOppHand As DMC_3.MultipleImageDisplayer
    Friend WithEvents midOppMana As DMC_3.MultipleImageDisplayer
    Friend WithEvents midOppGrave As DMC_3.MultipleImageDisplayer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents midOppBattleZone As DMC_3.MultipleImageDisplayer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents midOppShield As DMC_3.MultipleImageDisplayer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents midOppDeck As DMC_3.MultipleImageDisplayer
    Friend WithEvents tbcTopYour As System.Windows.Forms.TabControl
    Friend WithEvents tbpgBattleZone As System.Windows.Forms.TabPage
    Friend WithEvents midBattleZone As DMC_3.MultipleImageDisplayer
    Friend WithEvents tbpgShield As System.Windows.Forms.TabPage
    Friend WithEvents midShield As DMC_3.MultipleImageDisplayer
    Friend WithEvents tbpgDeck As System.Windows.Forms.TabPage
    Friend WithEvents midDeck As DMC_3.MultipleImageDisplayer
    Friend WithEvents tbcBottomYour As System.Windows.Forms.TabControl
    Friend WithEvents tbpgHand As System.Windows.Forms.TabPage
    Friend WithEvents midHand As DMC_3.MultipleImageDisplayer
    Friend WithEvents tbpgManaZone As System.Windows.Forms.TabPage
    Friend WithEvents midManaZone As DMC_3.MultipleImageDisplayer
    Friend WithEvents tbpgGrave As System.Windows.Forms.TabPage
    Friend WithEvents midGraveYard As DMC_3.MultipleImageDisplayer
    Friend WithEvents ctxManaZone As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiMZTap_Untap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMZtoBZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMZtoGY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMZtoHand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMZtoShield As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxGraveYard As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiGYtoBZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGYtoHand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGYtoMZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGYtoShield As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxBattleZone As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiBZTap_Untap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiBZtoGY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiBZtoHand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiBZtoMZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiBZtoShield As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiBZtoTOD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiBZAttack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxShield As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiShieldPeek As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiShieldShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiShieldtoBZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiShieldtoGY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiShieldtoMZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiShieldBreak As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxDeck As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiDeckSeeDeck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDecktoHand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDecktoHandShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDecktoBZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDeckSeeCard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDecktoMZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDecktoGY As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDeckShuffle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents tblMIDHolder As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents mtsGame As System.Windows.Forms.MenuStrip
    Friend WithEvents mtsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGameplay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtWrite As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents rtfAll As System.Windows.Forms.RichTextBox
    Friend WithEvents mtsFileResetGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsFileSoftReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsFileLoadDeck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsFileSaveGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsFileLoadGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsFileMakeLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsFileGameExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPShuffle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPDraw As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPDrawDraw As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPDrawDrawShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPTODto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPFlip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPDiscard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPTODtoMZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPTODtoShield As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPShowDeckTopCard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPShowDeck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPShowHand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPPlaceShield As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPUntapAllCards As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPEndTurn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsGPTurnEnd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdDeck As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mtsFileYourName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents chkATM As System.Windows.Forms.CheckBox
    Friend WithEvents grbxConnect As System.Windows.Forms.GroupBox
    Friend WithEvents txtYourIP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTheirIp As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnListen As System.Windows.Forms.Button

    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
