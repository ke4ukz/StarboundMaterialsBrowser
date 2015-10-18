<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tspgbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvwMaterials = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SpawnItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRawAssetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtShortDescription = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtHealth = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.picColor = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTexture = New System.Windows.Forms.TextBox()
        Me.txtFootstepSound = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaterialFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRarity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.picTexture = New System.Windows.Forms.PictureBox()
        Me.chkZoom = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadAssetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAssetsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadOnStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpawnItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstbSpawnQuantity = New System.Windows.Forms.ToolStripTextBox()
        Me.OpenInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRawAssetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstbSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExpandAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollapseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTexture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspgbProgress, Me.tsslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 653)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(892, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tspgbProgress
        '
        Me.tspgbProgress.Name = "tspgbProgress"
        Me.tspgbProgress.Size = New System.Drawing.Size(100, 16)
        Me.tspgbProgress.Visible = False
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(101, 17)
        Me.tsslStatus.Text = "No Assets Loaded"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvwMaterials)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(892, 626)
        Me.SplitContainer1.SplitterDistance = 379
        Me.SplitContainer1.TabIndex = 4
        '
        'tvwMaterials
        '
        Me.tvwMaterials.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvwMaterials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwMaterials.FullRowSelect = True
        Me.tvwMaterials.Location = New System.Drawing.Point(0, 0)
        Me.tvwMaterials.Name = "tvwMaterials"
        Me.tvwMaterials.Size = New System.Drawing.Size(379, 626)
        Me.tvwMaterials.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpawnItemToolStripMenuItem1, Me.ShowInExplorerToolStripMenuItem, Me.OpenImageToolStripMenuItem, Me.ViewRawAssetToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ExpandAllToolStripMenuItem, Me.CollapseAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 164)
        '
        'SpawnItemToolStripMenuItem1
        '
        Me.SpawnItemToolStripMenuItem1.Name = "SpawnItemToolStripMenuItem1"
        Me.SpawnItemToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.SpawnItemToolStripMenuItem1.Text = "&Spawn Item"
        '
        'ShowInExplorerToolStripMenuItem
        '
        Me.ShowInExplorerToolStripMenuItem.Name = "ShowInExplorerToolStripMenuItem"
        Me.ShowInExplorerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ShowInExplorerToolStripMenuItem.Text = "Show in &Explorer"
        '
        'OpenImageToolStripMenuItem
        '
        Me.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem"
        Me.OpenImageToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenImageToolStripMenuItem.Text = "&Open Image"
        '
        'ViewRawAssetToolStripMenuItem1
        '
        Me.ViewRawAssetToolStripMenuItem1.Name = "ViewRawAssetToolStripMenuItem1"
        Me.ViewRawAssetToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ViewRawAssetToolStripMenuItem1.Text = "&View Raw Asset"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtShortDescription, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDescription, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtHealth, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCategory, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.picColor, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTexture, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFootstepSound, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMaterialFile, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRarity, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrice, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdPlay, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.picTexture, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.chkZoom, 2, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(509, 626)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Short Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Health"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Category"
        '
        'txtName
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtName, 2)
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtName.Location = New System.Drawing.Point(99, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(407, 20)
        Me.txtName.TabIndex = 9
        '
        'txtShortDescription
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtShortDescription, 2)
        Me.txtShortDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtShortDescription.Location = New System.Drawing.Point(99, 33)
        Me.txtShortDescription.Name = "txtShortDescription"
        Me.txtShortDescription.ReadOnly = True
        Me.txtShortDescription.Size = New System.Drawing.Size(407, 20)
        Me.txtShortDescription.TabIndex = 10
        '
        'txtDescription
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtDescription, 2)
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDescription.Location = New System.Drawing.Point(99, 63)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(407, 20)
        Me.txtDescription.TabIndex = 11
        '
        'txtHealth
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtHealth, 2)
        Me.txtHealth.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtHealth.Location = New System.Drawing.Point(99, 93)
        Me.txtHealth.Name = "txtHealth"
        Me.txtHealth.ReadOnly = True
        Me.txtHealth.Size = New System.Drawing.Size(407, 20)
        Me.txtHealth.TabIndex = 12
        '
        'txtCategory
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtCategory, 2)
        Me.txtCategory.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCategory.Location = New System.Drawing.Point(99, 153)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(407, 20)
        Me.txtCategory.TabIndex = 13
        '
        'picColor
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.picColor, 2)
        Me.picColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picColor.Location = New System.Drawing.Point(99, 123)
        Me.picColor.Name = "picColor"
        Me.picColor.Size = New System.Drawing.Size(407, 24)
        Me.picColor.TabIndex = 14
        Me.picColor.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Texture"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Footstep Sound"
        '
        'txtTexture
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtTexture, 2)
        Me.txtTexture.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTexture.Location = New System.Drawing.Point(99, 183)
        Me.txtTexture.Name = "txtTexture"
        Me.txtTexture.ReadOnly = True
        Me.txtTexture.Size = New System.Drawing.Size(407, 20)
        Me.txtTexture.TabIndex = 17
        '
        'txtFootstepSound
        '
        Me.txtFootstepSound.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFootstepSound.Location = New System.Drawing.Point(99, 213)
        Me.txtFootstepSound.Name = "txtFootstepSound"
        Me.txtFootstepSound.ReadOnly = True
        Me.txtFootstepSound.Size = New System.Drawing.Size(347, 20)
        Me.txtFootstepSound.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Material File"
        '
        'txtMaterialFile
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtMaterialFile, 2)
        Me.txtMaterialFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtMaterialFile.Location = New System.Drawing.Point(99, 243)
        Me.txtMaterialFile.Name = "txtMaterialFile"
        Me.txtMaterialFile.ReadOnly = True
        Me.txtMaterialFile.Size = New System.Drawing.Size(407, 20)
        Me.txtMaterialFile.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Rarity"
        '
        'txtRarity
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtRarity, 2)
        Me.txtRarity.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRarity.Location = New System.Drawing.Point(99, 273)
        Me.txtRarity.Name = "txtRarity"
        Me.txtRarity.ReadOnly = True
        Me.txtRarity.Size = New System.Drawing.Size(407, 20)
        Me.txtRarity.TabIndex = 23
        '
        'txtPrice
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrice, 2)
        Me.txtPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPrice.Location = New System.Drawing.Point(99, 303)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(407, 20)
        Me.txtPrice.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Price"
        '
        'cmdPlay
        '
        Me.cmdPlay.Location = New System.Drawing.Point(452, 213)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(54, 23)
        Me.cmdPlay.TabIndex = 26
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'picTexture
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.picTexture, 2)
        Me.picTexture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picTexture.Location = New System.Drawing.Point(3, 333)
        Me.picTexture.Name = "picTexture"
        Me.picTexture.Size = New System.Drawing.Size(443, 270)
        Me.picTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTexture.TabIndex = 27
        Me.picTexture.TabStop = False
        '
        'chkZoom
        '
        Me.chkZoom.AutoSize = True
        Me.chkZoom.Checked = True
        Me.chkZoom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkZoom.Location = New System.Drawing.Point(452, 333)
        Me.chkZoom.Name = "chkZoom"
        Me.chkZoom.Size = New System.Drawing.Size(53, 17)
        Me.chkZoom.TabIndex = 28
        Me.chkZoom.Text = "Zoom"
        Me.chkZoom.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ItemToolStripMenuItem, Me.SearchToolStripMenuItem, Me.tstbSearch})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 27)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadAssetsToolStripMenuItem, Me.SetAssetsFolderToolStripMenuItem, Me.LoadOnStartToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadAssetsToolStripMenuItem
        '
        Me.LoadAssetsToolStripMenuItem.Name = "LoadAssetsToolStripMenuItem"
        Me.LoadAssetsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadAssetsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LoadAssetsToolStripMenuItem.Text = "&Load Assets"
        '
        'SetAssetsFolderToolStripMenuItem
        '
        Me.SetAssetsFolderToolStripMenuItem.Name = "SetAssetsFolderToolStripMenuItem"
        Me.SetAssetsFolderToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SetAssetsFolderToolStripMenuItem.Text = "&Set Assets Folder"
        '
        'LoadOnStartToolStripMenuItem
        '
        Me.LoadOnStartToolStripMenuItem.CheckOnClick = True
        Me.LoadOnStartToolStripMenuItem.Name = "LoadOnStartToolStripMenuItem"
        Me.LoadOnStartToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LoadOnStartToolStripMenuItem.Text = "Load On Start"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpawnItemToolStripMenuItem, Me.tstbSpawnQuantity, Me.OpenInExplorerToolStripMenuItem, Me.ViewImageToolStripMenuItem, Me.ViewRawAssetToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.ItemToolStripMenuItem.Text = "&Item"
        '
        'SpawnItemToolStripMenuItem
        '
        Me.SpawnItemToolStripMenuItem.Name = "SpawnItemToolStripMenuItem"
        Me.SpawnItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.SpawnItemToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SpawnItemToolStripMenuItem.Text = "&Spawn Item"
        '
        'tstbSpawnQuantity
        '
        Me.tstbSpawnQuantity.Name = "tstbSpawnQuantity"
        Me.tstbSpawnQuantity.Size = New System.Drawing.Size(100, 23)
        Me.tstbSpawnQuantity.Text = "1"
        '
        'OpenInExplorerToolStripMenuItem
        '
        Me.OpenInExplorerToolStripMenuItem.Name = "OpenInExplorerToolStripMenuItem"
        Me.OpenInExplorerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenInExplorerToolStripMenuItem.Text = "Show in &Explorer"
        '
        'ViewImageToolStripMenuItem
        '
        Me.ViewImageToolStripMenuItem.Name = "ViewImageToolStripMenuItem"
        Me.ViewImageToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ViewImageToolStripMenuItem.Text = "&Open Image"
        '
        'ViewRawAssetToolStripMenuItem
        '
        Me.ViewRawAssetToolStripMenuItem.Name = "ViewRawAssetToolStripMenuItem"
        Me.ViewRawAssetToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ViewRawAssetToolStripMenuItem.Text = "View &Raw Asset"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.ShowShortcutKeys = False
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(57, 23)
        Me.SearchToolStripMenuItem.Text = "&Search:"
        '
        'tstbSearch
        '
        Me.tstbSearch.Name = "tstbSearch"
        Me.tstbSearch.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(158, 6)
        '
        'ExpandAllToolStripMenuItem
        '
        Me.ExpandAllToolStripMenuItem.Name = "ExpandAllToolStripMenuItem"
        Me.ExpandAllToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExpandAllToolStripMenuItem.Text = "Expand All"
        '
        'CollapseAllToolStripMenuItem
        '
        Me.CollapseAllToolStripMenuItem.Name = "CollapseAllToolStripMenuItem"
        Me.CollapseAllToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CollapseAllToolStripMenuItem.Text = "Collapse All"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 675)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Starbound Materials Browser"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTexture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tspgbProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtShortDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtHealth As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents picColor As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTexture As System.Windows.Forms.TextBox
    Friend WithEvents txtFootstepSound As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMaterialFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRarity As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents tvwMaterials As System.Windows.Forms.TreeView
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents picTexture As System.Windows.Forms.PictureBox
    Friend WithEvents chkZoom As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadAssetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAssetsFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpawnItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRawAssetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstbSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstbSpawnQuantity As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LoadOnStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SpawnItemToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowInExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRawAssetToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExpandAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollapseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
