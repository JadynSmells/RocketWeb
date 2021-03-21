<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Browser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AdrBG = New System.Windows.Forms.Panel()
        Me.AdrText = New System.Windows.Forms.TextBox()
        Me.AddressMarginL = New System.Windows.Forms.Panel()
        Me.HomeHover = New System.Windows.Forms.PictureBox()
        Me.HomeNormal = New System.Windows.Forms.PictureBox()
        Me.ReloadHover = New System.Windows.Forms.PictureBox()
        Me.Reload = New System.Windows.Forms.PictureBox()
        Me.ForwardHover = New System.Windows.Forms.PictureBox()
        Me.ForwardNormal = New System.Windows.Forms.PictureBox()
        Me.BackHover = New System.Windows.Forms.PictureBox()
        Me.BackNormal = New System.Windows.Forms.PictureBox()
        Me.FavouriteSelectedHover = New System.Windows.Forms.PictureBox()
        Me.FavouriteSelected = New System.Windows.Forms.PictureBox()
        Me.FavouriteHover = New System.Windows.Forms.PictureBox()
        Me.FavouriteNormal = New System.Windows.Forms.PictureBox()
        Me.AddressMarginR = New System.Windows.Forms.Panel()
        Me.MenuHover = New System.Windows.Forms.PictureBox()
        Me.MenuNormal = New System.Windows.Forms.PictureBox()
        Me.FavouritesChecker = New System.Windows.Forms.Timer(Me.components)
        Me.AddressUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BrowserPanel = New System.Windows.Forms.Panel()
        Me.Favourites = New System.Windows.Forms.ListBox()
        Me.FullscreenPanelHide = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.AdrBG.SuspendLayout()
        Me.AddressMarginL.SuspendLayout()
        CType(Me.HomeHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReloadHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForwardHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForwardNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FavouriteSelectedHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FavouriteSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FavouriteHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FavouriteNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddressMarginR.SuspendLayout()
        CType(Me.MenuHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AdrBG)
        Me.Panel1.Controls.Add(Me.AddressMarginL)
        Me.Panel1.Controls.Add(Me.FavouriteSelectedHover)
        Me.Panel1.Controls.Add(Me.FavouriteSelected)
        Me.Panel1.Controls.Add(Me.FavouriteHover)
        Me.Panel1.Controls.Add(Me.FavouriteNormal)
        Me.Panel1.Controls.Add(Me.AddressMarginR)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 50)
        Me.Panel1.TabIndex = 2
        '
        'AdrBG
        '
        Me.AdrBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.AdrBG.Controls.Add(Me.AdrText)
        Me.AdrBG.Location = New System.Drawing.Point(152, 0)
        Me.AdrBG.Name = "AdrBG"
        Me.AdrBG.Size = New System.Drawing.Size(559, 50)
        Me.AdrBG.TabIndex = 13
        '
        'AdrText
        '
        Me.AdrText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AdrText.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.AdrText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AdrText.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdrText.Location = New System.Drawing.Point(17, 15)
        Me.AdrText.Name = "AdrText"
        Me.AdrText.Size = New System.Drawing.Size(551, 17)
        Me.AdrText.TabIndex = 14
        '
        'AddressMarginL
        '
        Me.AddressMarginL.Controls.Add(Me.HomeHover)
        Me.AddressMarginL.Controls.Add(Me.HomeNormal)
        Me.AddressMarginL.Controls.Add(Me.ReloadHover)
        Me.AddressMarginL.Controls.Add(Me.Reload)
        Me.AddressMarginL.Controls.Add(Me.ForwardHover)
        Me.AddressMarginL.Controls.Add(Me.ForwardNormal)
        Me.AddressMarginL.Controls.Add(Me.BackHover)
        Me.AddressMarginL.Controls.Add(Me.BackNormal)
        Me.AddressMarginL.Location = New System.Drawing.Point(0, 0)
        Me.AddressMarginL.Name = "AddressMarginL"
        Me.AddressMarginL.Size = New System.Drawing.Size(152, 50)
        Me.AddressMarginL.TabIndex = 12
        '
        'HomeHover
        '
        Me.HomeHover.Image = CType(resources.GetObject("HomeHover.Image"), System.Drawing.Image)
        Me.HomeHover.Location = New System.Drawing.Point(117, 12)
        Me.HomeHover.Name = "HomeHover"
        Me.HomeHover.Size = New System.Drawing.Size(29, 27)
        Me.HomeHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HomeHover.TabIndex = 13
        Me.HomeHover.TabStop = False
        '
        'HomeNormal
        '
        Me.HomeNormal.Image = CType(resources.GetObject("HomeNormal.Image"), System.Drawing.Image)
        Me.HomeNormal.Location = New System.Drawing.Point(117, 12)
        Me.HomeNormal.Name = "HomeNormal"
        Me.HomeNormal.Size = New System.Drawing.Size(29, 27)
        Me.HomeNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HomeNormal.TabIndex = 12
        Me.HomeNormal.TabStop = False
        '
        'ReloadHover
        '
        Me.ReloadHover.Image = CType(resources.GetObject("ReloadHover.Image"), System.Drawing.Image)
        Me.ReloadHover.Location = New System.Drawing.Point(82, 12)
        Me.ReloadHover.Name = "ReloadHover"
        Me.ReloadHover.Size = New System.Drawing.Size(29, 27)
        Me.ReloadHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ReloadHover.TabIndex = 11
        Me.ReloadHover.TabStop = False
        '
        'Reload
        '
        Me.Reload.Image = CType(resources.GetObject("Reload.Image"), System.Drawing.Image)
        Me.Reload.Location = New System.Drawing.Point(82, 12)
        Me.Reload.Name = "Reload"
        Me.Reload.Size = New System.Drawing.Size(29, 27)
        Me.Reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Reload.TabIndex = 10
        Me.Reload.TabStop = False
        '
        'ForwardHover
        '
        Me.ForwardHover.Image = CType(resources.GetObject("ForwardHover.Image"), System.Drawing.Image)
        Me.ForwardHover.Location = New System.Drawing.Point(47, 12)
        Me.ForwardHover.Name = "ForwardHover"
        Me.ForwardHover.Size = New System.Drawing.Size(29, 27)
        Me.ForwardHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ForwardHover.TabIndex = 3
        Me.ForwardHover.TabStop = False
        '
        'ForwardNormal
        '
        Me.ForwardNormal.Image = CType(resources.GetObject("ForwardNormal.Image"), System.Drawing.Image)
        Me.ForwardNormal.Location = New System.Drawing.Point(47, 12)
        Me.ForwardNormal.Name = "ForwardNormal"
        Me.ForwardNormal.Size = New System.Drawing.Size(29, 27)
        Me.ForwardNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ForwardNormal.TabIndex = 2
        Me.ForwardNormal.TabStop = False
        '
        'BackHover
        '
        Me.BackHover.Image = CType(resources.GetObject("BackHover.Image"), System.Drawing.Image)
        Me.BackHover.Location = New System.Drawing.Point(12, 12)
        Me.BackHover.Name = "BackHover"
        Me.BackHover.Size = New System.Drawing.Size(29, 27)
        Me.BackHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackHover.TabIndex = 1
        Me.BackHover.TabStop = False
        '
        'BackNormal
        '
        Me.BackNormal.Image = CType(resources.GetObject("BackNormal.Image"), System.Drawing.Image)
        Me.BackNormal.Location = New System.Drawing.Point(12, 12)
        Me.BackNormal.Name = "BackNormal"
        Me.BackNormal.Size = New System.Drawing.Size(29, 27)
        Me.BackNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackNormal.TabIndex = 0
        Me.BackNormal.TabStop = False
        '
        'FavouriteSelectedHover
        '
        Me.FavouriteSelectedHover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavouriteSelectedHover.Image = CType(resources.GetObject("FavouriteSelectedHover.Image"), System.Drawing.Image)
        Me.FavouriteSelectedHover.Location = New System.Drawing.Point(724, 12)
        Me.FavouriteSelectedHover.Name = "FavouriteSelectedHover"
        Me.FavouriteSelectedHover.Size = New System.Drawing.Size(29, 27)
        Me.FavouriteSelectedHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FavouriteSelectedHover.TabIndex = 9
        Me.FavouriteSelectedHover.TabStop = False
        '
        'FavouriteSelected
        '
        Me.FavouriteSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavouriteSelected.Image = CType(resources.GetObject("FavouriteSelected.Image"), System.Drawing.Image)
        Me.FavouriteSelected.Location = New System.Drawing.Point(724, 12)
        Me.FavouriteSelected.Name = "FavouriteSelected"
        Me.FavouriteSelected.Size = New System.Drawing.Size(29, 27)
        Me.FavouriteSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FavouriteSelected.TabIndex = 8
        Me.FavouriteSelected.TabStop = False
        '
        'FavouriteHover
        '
        Me.FavouriteHover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavouriteHover.Image = CType(resources.GetObject("FavouriteHover.Image"), System.Drawing.Image)
        Me.FavouriteHover.Location = New System.Drawing.Point(724, 12)
        Me.FavouriteHover.Name = "FavouriteHover"
        Me.FavouriteHover.Size = New System.Drawing.Size(29, 27)
        Me.FavouriteHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FavouriteHover.TabIndex = 7
        Me.FavouriteHover.TabStop = False
        '
        'FavouriteNormal
        '
        Me.FavouriteNormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavouriteNormal.Image = CType(resources.GetObject("FavouriteNormal.Image"), System.Drawing.Image)
        Me.FavouriteNormal.Location = New System.Drawing.Point(724, 12)
        Me.FavouriteNormal.Name = "FavouriteNormal"
        Me.FavouriteNormal.Size = New System.Drawing.Size(29, 27)
        Me.FavouriteNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FavouriteNormal.TabIndex = 6
        Me.FavouriteNormal.TabStop = False
        '
        'AddressMarginR
        '
        Me.AddressMarginR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressMarginR.Controls.Add(Me.MenuHover)
        Me.AddressMarginR.Controls.Add(Me.MenuNormal)
        Me.AddressMarginR.Location = New System.Drawing.Point(710, 0)
        Me.AddressMarginR.Name = "AddressMarginR"
        Me.AddressMarginR.Size = New System.Drawing.Size(90, 50)
        Me.AddressMarginR.TabIndex = 13
        '
        'MenuHover
        '
        Me.MenuHover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuHover.Image = CType(resources.GetObject("MenuHover.Image"), System.Drawing.Image)
        Me.MenuHover.Location = New System.Drawing.Point(49, 12)
        Me.MenuHover.Name = "MenuHover"
        Me.MenuHover.Size = New System.Drawing.Size(29, 27)
        Me.MenuHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuHover.TabIndex = 5
        Me.MenuHover.TabStop = False
        '
        'MenuNormal
        '
        Me.MenuNormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuNormal.Image = CType(resources.GetObject("MenuNormal.Image"), System.Drawing.Image)
        Me.MenuNormal.Location = New System.Drawing.Point(49, 12)
        Me.MenuNormal.Name = "MenuNormal"
        Me.MenuNormal.Size = New System.Drawing.Size(29, 27)
        Me.MenuNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuNormal.TabIndex = 4
        Me.MenuNormal.TabStop = False
        '
        'FavouritesChecker
        '
        Me.FavouritesChecker.Enabled = True
        '
        'AddressUpdate
        '
        Me.AddressUpdate.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 2)
        Me.Panel2.TabIndex = 6
        '
        'BrowserPanel
        '
        Me.BrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowserPanel.Location = New System.Drawing.Point(0, 72)
        Me.BrowserPanel.Name = "BrowserPanel"
        Me.BrowserPanel.Size = New System.Drawing.Size(800, 378)
        Me.BrowserPanel.TabIndex = 7
        '
        'Favourites
        '
        Me.Favourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Favourites.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Favourites.ColumnWidth = 250
        Me.Favourites.Dock = System.Windows.Forms.DockStyle.Top
        Me.Favourites.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Favourites.FormattingEnabled = True
        Me.Favourites.ItemHeight = 20
        Me.Favourites.Location = New System.Drawing.Point(0, 50)
        Me.Favourites.Margin = New System.Windows.Forms.Padding(6)
        Me.Favourites.MultiColumn = True
        Me.Favourites.Name = "Favourites"
        Me.Favourites.Size = New System.Drawing.Size(800, 20)
        Me.Favourites.TabIndex = 5
        '
        'FullscreenPanelHide
        '
        Me.FullscreenPanelHide.Enabled = True
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BrowserPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Favourites)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Browser"
        Me.Text = "Rocket"
        Me.Panel1.ResumeLayout(False)
        Me.AdrBG.ResumeLayout(False)
        Me.AdrBG.PerformLayout()
        Me.AddressMarginL.ResumeLayout(False)
        CType(Me.HomeHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReloadHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForwardHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForwardNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FavouriteSelectedHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FavouriteSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FavouriteHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FavouriteNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddressMarginR.ResumeLayout(False)
        CType(Me.MenuHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuHover As PictureBox
    Friend WithEvents MenuNormal As PictureBox
    Friend WithEvents FavouriteHover As PictureBox
    Friend WithEvents FavouriteNormal As PictureBox
    Friend WithEvents FavouriteSelectedHover As PictureBox
    Friend WithEvents FavouriteSelected As PictureBox
    Friend WithEvents FavouritesChecker As Timer
    Friend WithEvents AddressMarginL As Panel
    Friend WithEvents ReloadHover As PictureBox
    Friend WithEvents Reload As PictureBox
    Friend WithEvents ForwardHover As PictureBox
    Friend WithEvents ForwardNormal As PictureBox
    Friend WithEvents BackHover As PictureBox
    Friend WithEvents BackNormal As PictureBox
    Friend WithEvents AddressMarginR As Panel
    Friend WithEvents AddressUpdate As Timer
    Friend WithEvents HomeNormal As PictureBox
    Friend WithEvents HomeHover As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BrowserPanel As Panel
    Friend WithEvents Favourites As ListBox
    Friend WithEvents AdrBG As Panel
    Friend WithEvents AdrText As TextBox
    Friend WithEvents FullscreenPanelHide As Timer
End Class
