<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckAnalyser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeckAnalyser))
        Me.picDeck = New System.Windows.Forms.PictureBox
        Me.vscrDeck = New System.Windows.Forms.VScrollBar
        Me.txtDeck = New System.Windows.Forms.TextBox
        Me.txtAnalyse = New System.Windows.Forms.TextBox
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDeck
        '
        Me.picDeck.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picDeck.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picDeck.Location = New System.Drawing.Point(13, 13)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(360, 420)
        Me.picDeck.TabIndex = 0
        Me.picDeck.TabStop = False
        Me.picDeck.Tag = ""
        '
        'vscrDeck
        '
        Me.vscrDeck.Location = New System.Drawing.Point(373, 13)
        Me.vscrDeck.Name = "vscrDeck"
        Me.vscrDeck.Size = New System.Drawing.Size(17, 420)
        Me.vscrDeck.TabIndex = 1
        Me.vscrDeck.Visible = False
        '
        'txtDeck
        '
        Me.txtDeck.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDeck.Location = New System.Drawing.Point(394, 13)
        Me.txtDeck.Multiline = True
        Me.txtDeck.Name = "txtDeck"
        Me.txtDeck.ReadOnly = True
        Me.txtDeck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDeck.Size = New System.Drawing.Size(217, 220)
        Me.txtDeck.TabIndex = 2
        '
        'txtAnalyse
        '
        Me.txtAnalyse.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtAnalyse.Location = New System.Drawing.Point(394, 240)
        Me.txtAnalyse.Multiline = True
        Me.txtAnalyse.Name = "txtAnalyse"
        Me.txtAnalyse.ReadOnly = True
        Me.txtAnalyse.Size = New System.Drawing.Size(217, 193)
        Me.txtAnalyse.TabIndex = 3
        '
        'frmDeckAnalyser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 447)
        Me.Controls.Add(Me.txtAnalyse)
        Me.Controls.Add(Me.txtDeck)
        Me.Controls.Add(Me.vscrDeck)
        Me.Controls.Add(Me.picDeck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeckAnalyser"
        Me.Text = "Deck Analyser"
        Me.TopMost = True
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDeck As System.Windows.Forms.PictureBox
    Friend WithEvents vscrDeck As System.Windows.Forms.VScrollBar
    Friend WithEvents txtDeck As System.Windows.Forms.TextBox
    Friend WithEvents txtAnalyse As System.Windows.Forms.TextBox
End Class
