Public Class frmMain

    Public Structure RECT
        Friend Left As Integer
        Friend Top As Integer
        Friend Right As Integer
        Friend Bottom As Integer
    End Structure
    Public Structure POINT
        Friend x As Integer
        Friend y As Integer
    End Structure

    ' Get a handle to an application window.
    Declare Auto Function FindWindow Lib "USER32.DLL" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    ' Activate an application window.
    Declare Auto Function SetForegroundWindow Lib "USER32.DLL" (ByVal hWnd As IntPtr) As Boolean
    Declare Auto Function GetWindowRect Lib "USER32.DLL" (ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    Declare Auto Function SetCursorPos Lib "USER32.DLL" (ByVal X As Int16, ByVal Y As Int16) As Boolean
    Declare Auto Function GetCursorPos Lib "USER32.DLL" (ByRef lpPoint As POINT) As Boolean

    Private Class Material
        Friend Property MaterialName As String = ""
        Friend Property Description As String = ""
        Friend Property ShortDescription As String = ""
        Friend Property SoundFilePath As String = ""
        Friend Property TextureFilePath As String = ""
        Friend Property Health As Integer = 0
        Friend Property MaterialFilePath As String = ""
        Friend Property ParticleColor As Color = SystemColors.Control
        Friend Property Category As String = "other"
        Friend Property Price As Integer = 0
        Friend Property Rarity As String = ""
    End Class

    Private Materials As New List(Of Material)
    Private MaterialsLock As New Object

    Private Delegate Sub UpdateStatusCallback(ByVal StatusText As String, ByVal Progress As Double)
    Private Delegate Sub AddMaterialCallback(ByVal ToAdd As Material)
    Private Delegate Sub FinishedListingCallback()
    Private Delegate Sub RefreshListCallback()

    ''' <summary>
    ''' Update the status and progress bar. Cross-thread safe.
    ''' </summary>
    ''' <param name="StatusText">Status text, or null char to not update status.</param>
    ''' <param name="Progress">Progress percentage (0-100), or less than zero to not update progress.</param>
    ''' <remarks></remarks>
    Private Sub UpdateStatus(ByVal StatusText As String, ByVal Progress As Double)
        If Me.InvokeRequired Then
            Dim d As New UpdateStatusCallback(AddressOf UpdateStatus)
            Me.BeginInvoke(d, New Object() {StatusText, Progress})
        Else
            If StatusText = ControlChars.NullChar And Progress < 0 Then
                tspgbProgress.Visible = False
            End If

            If StatusText <> ControlChars.NullChar Then
                tsslStatus.Text = StatusText
            End If

            If Progress >= 0 Then
                tspgbProgress.Visible = True
                tspgbProgress.Value = CInt(Progress)
            End If
        End If
    End Sub

    Private Sub AddMaterial(ByVal ToAdd As Material)
        SyncLock MaterialsLock
            Materials.Add(ToAdd)
        End SyncLock
    End Sub

    Private Sub AddItem(ByVal NewMaterial As Material)
        Dim TN As New TreeNode
        TN.Text = NewMaterial.MaterialName
        TN.Tag = NewMaterial

        If tvwMaterials.Nodes("root").Nodes(NewMaterial.Category) Is Nothing Then
            Dim TC As New TreeNode
            tvwMaterials.Nodes("root").Nodes.Add(NewMaterial.Category, NewMaterial.Category)
        End If
        tvwMaterials.Nodes("root").Nodes(NewMaterial.Category).Nodes.Add(TN)

    End Sub

    Private Sub RefreshList()
        If Me.InvokeRequired Then
            Dim d As New RefreshListCallback(AddressOf RefreshList)
            Me.BeginInvoke(d)
        Else
            ClearTree()
            For Each M As Material In Materials
                AddItem(M)
            Next
            tsslStatus.Text = Materials.Count.ToString & " items"
        End If

    End Sub

    Private Sub ClearTree()
        tvwMaterials.Nodes.Clear()
        tvwMaterials.Nodes.Add("root", "Starbound")
        tvwMaterials.Nodes("root").Expand()
    End Sub

    Private Sub FinishedListing()
        If Me.InvokeRequired Then
            Dim d As New FinishedListingCallback(AddressOf FinishedListing)
            Me.BeginInvoke(d)
        Else
            tspgbProgress.Visible = False
            LoadAssetsToolStripMenuItem.Enabled = True
            RefreshList()
        End If
    End Sub

    Private Sub StartLoadingMaterials(ByVal MaterialsPath As String)
        LoadAssetsToolStripMenuItem.Enabled = False
        tstbSearch.Text = ""
        Materials = New List(Of Material)
        Dim T As New Threading.Thread(New Threading.ParameterizedThreadStart(AddressOf LoadMaterials))
        T.Start(MaterialsPath)
    End Sub

    Private Sub LoadMaterials(ByVal MaterialsPath As Object)
        Dim MaterialsFiles As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Dim ObjectsFiles As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

        UpdateStatus("Listing materials...", 0)

        MaterialsFiles = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CombinePath(CStr(MaterialsPath), ".\tiles"), FileIO.SearchOption.SearchAllSubDirectories, New String() {"*.material"})
        ObjectsFiles = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CombinePath(CStr(MaterialsPath), ".\objects"), FileIO.SearchOption.SearchAllSubDirectories, New String() {"*.object"})

        For I As Integer = 0 To MaterialsFiles.Count - 1
            UpdateStatus("Loading " & MaterialsFiles(I), 100 * (I / (MaterialsFiles.Count + ObjectsFiles.Count)))
            AddMaterial(LoadMaterial(MaterialsFiles(I)))
        Next
        UpdateStatus("Listing objects...", -1)
        For I As Integer = 0 To ObjectsFiles.Count - 1
            UpdateStatus("Loading " & ObjectsFiles(I), 100 * ((I + MaterialsFiles.Count) / (MaterialsFiles.Count + ObjectsFiles.Count)))
            AddMaterial(LoadMaterial(ObjectsFiles(I)))
        Next
        FinishedListing()
    End Sub

    Private Function LoadMaterial(ByVal MaterialPath As String) As Material
        Dim M As New Material
        Dim F As System.IO.StreamReader
        Dim CurLine As String, LineParts() As String, ColorParts() As String

        F = My.Computer.FileSystem.OpenTextFileReader(MaterialPath)

        M.MaterialFilePath = MaterialPath

        While Not F.EndOfStream
            CurLine = F.ReadLine()
            LineParts = CurLine.Split(New Char() {":"c}, 2) 'Split at colon
            If LineParts.Length = 2 Then
                LineParts(0) = LineParts(0).Replace("""", "") 'Remove quotes
                If LineParts(1).EndsWith(",") Then
                    LineParts(1) = LineParts(1).Substring(0, LineParts(1).Length - 1) 'Remove trailing comma
                End If
                LineParts(1) = LineParts(1).Replace("""", "") 'Remove quotes
                LineParts(0) = LineParts(0).Trim() 'Trim whitespace
                LineParts(1) = LineParts(1).Trim() 'Trim whitespace

                Select Case LineParts(0).ToLower
                    Case "materialname", "objectname"
                        M.MaterialName = LineParts(1)
                    Case "particlecolor"
                        'Chop off brackets
                        LineParts(1) = LineParts(1).Substring(1, LineParts(1).Length - 2)
                        ColorParts = LineParts(1).Split(","c)
                        If ColorParts.Length = 4 Then
                            M.ParticleColor = Color.FromArgb(CInt(Val(ColorParts(3))), CInt(Val(ColorParts(0))), CInt(Val(ColorParts(1))), CInt(Val(ColorParts(2))))
                        End If
                    Case "description"
                        M.Description = LineParts(1)
                    Case "shortdescription"
                        M.ShortDescription = LineParts(1)
                    Case "footstepsound"
                        M.SoundFilePath = My.Computer.FileSystem.CombinePath(My.Settings.AssetsFolder, "." & LineParts(1).Replace("/"c, "\"c))
                    Case "health"
                        M.Health = CInt(Val(LineParts(1)))
                    Case "texture", "inventoryicon", "image", "dualimage"
                        If LineParts(1).Contains(":") Then
                            LineParts(1) = LineParts(1).Substring(0, LineParts(1).IndexOf(":"))
                        End If
                        M.TextureFilePath = My.Computer.FileSystem.CombinePath(GetPath(M.MaterialFilePath), LineParts(1))
                    Case "category"
                        M.Category = LineParts(1)
                    Case "rarity"
                        M.Rarity = LineParts(1)
                    Case "price"
                        M.Price = CInt(Val(LineParts(1)))
                End Select
            End If
        End While
        F.Close()
        Return M
    End Function

    Private Sub LoadSettings()
        SplitContainer1.SplitterDistance = My.Settings.SplitDistance
        LoadOnStartToolStripMenuItem.Checked = My.Settings.LoadOnStart
    End Sub

    Private Sub SaveSettings()
        My.Settings.SplitDistance = SplitContainer1.SplitterDistance
    End Sub

    Private Function GetPath(ByVal FilePath As String) As String
        If FilePath.EndsWith("\") Then Return FilePath
        If FilePath.Contains("\") Then
            Return FilePath.Substring(0, FilePath.LastIndexOf("\"))
        Else
            Return FilePath
        End If
    End Function

    Private Sub ShowInExplorer(ByVal Filename As String)
        System.Diagnostics.Process.Start("explorer.exe", "/select," & Filename)
    End Sub

    Private Sub OpenFile(ByVal Filename As String)
        System.Diagnostics.Process.Start(Filename)
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSettings()
        If My.Settings.LoadOnStart Then
            StartLoadingMaterials(My.Settings.AssetsFolder)
        End If
    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        If txtFootstepSound.Text <> "" Then
            If My.Computer.FileSystem.FileExists(txtFootstepSound.Text) Then
                My.Computer.Audio.Play(txtFootstepSound.Text, AudioPlayMode.Background)
            Else
                Console.WriteLine("Sound file does not exist!")
            End If
        End If
    End Sub

    Private Sub picTexture_Click(sender As Object, e As EventArgs)
        OpenFile(txtTexture.Text)
    End Sub

    Private Sub tstbSearch_TextChanged(sender As Object, e As EventArgs) Handles tstbSearch.TextChanged
        If Materials.Count > 0 AndAlso tstbSearch.Text <> "" Then
            Dim MCount As Integer = 0
            tsslStatus.Text = "Searching..."
            ClearTree()
            For Each M As Material In Materials
                If M.MaterialName.ToLower.Contains(tstbSearch.Text.ToLower) OrElse _
                        M.ShortDescription.ToLower.Contains(tstbSearch.Text.ToLower) OrElse _
                        M.Description.ToLower.Contains(tstbSearch.Text.ToLower) Then
                    MCount += 1
                    AddItem(M)
                End If
            Next
            tsslStatus.Text = MCount.ToString & " items"
        Else
            RefreshList()
        End If
    End Sub

    Private Sub tvwMaterials_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvwMaterials.AfterSelect
        If e.Node.Tag IsNot Nothing Then
            Dim M As Material = CType(e.Node.Tag, Material)

            txtName.Text = M.MaterialName
            txtShortDescription.Text = M.ShortDescription
            txtDescription.Text = M.Description
            txtCategory.Text = M.Category
            txtFootstepSound.Text = M.SoundFilePath
            txtPrice.Text = M.Price.ToString
            txtMaterialFile.Text = M.MaterialFilePath
            txtRarity.Text = M.Rarity
            txtHealth.Text = M.Health.ToString
            txtTexture.Text = M.TextureFilePath
            Try
                picTexture.Image = New Bitmap(txtTexture.Text)
            Catch ex As Exception
                picTexture.Image = Nothing
            End Try
        Else
            txtName.Text = ""
            txtShortDescription.Text = ""
            txtDescription.Text = ""
            txtCategory.Text = ""
            txtFootstepSound.Text = ""
            txtPrice.Text = ""
            txtMaterialFile.Text = ""
            txtRarity.Text = ""
            txtHealth.Text = ""
            txtTexture.Text = ""
            picTexture.Image = Nothing
        End If

    End Sub

    Private Sub tvwMaterials_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvwMaterials.NodeMouseDoubleClick
        If e.Node.Tag IsNot Nothing Then
            ViewRawAssetToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub chkZoom_CheckedChanged(sender As Object, e As EventArgs) Handles chkZoom.CheckedChanged
        If chkZoom.Checked Then
            picTexture.SizeMode = PictureBoxSizeMode.Zoom
        Else
            picTexture.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub

    Private Sub tstbSpawnQuantity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        tstbSpawnQuantity.Text = CInt(Val(tstbSpawnQuantity.Text)).ToString
    End Sub

    Private Sub SetAssetsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAssetsFolderToolStripMenuItem.Click
        Dim FBD As New FolderBrowserDialog
        With FBD
            .Description = "Select your Starbound unpacked assets forlder"
            .ShowNewFolderButton = False
            .SelectedPath = My.Settings.AssetsFolder
        End With
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.AssetsFolder = FBD.SelectedPath
        End If
    End Sub

    Private Sub LoadAssetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAssetsToolStripMenuItem.Click
        StartLoadingMaterials(My.Settings.AssetsFolder)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SpawnItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpawnItemToolStripMenuItem.Click
        Dim StarboundWindowHandle As IntPtr
        Dim OutputString As New System.Text.StringBuilder
        Dim SBSize As RECT
        Dim CurrentCursuorPos As POINT

        If txtName.Text <> "" Then

            StarboundWindowHandle = FindWindow("SDL_app", "Starbound - Beta")
            If StarboundWindowHandle <> IntPtr.Zero Then
                GetCursorPos(CurrentCursuorPos)
                GetWindowRect(StarboundWindowHandle, SBSize)
                'Console.WriteLine("Left: {0}, Right: {1}, Top: {2}, Bottom: {3}", SBSize.Left, SBSize.Right, SBSize.Top, SBSize.Bottom)
                'Console.WriteLine("{0}, {1}", CShort((SBSize.Right - SBSize.Left) \ 2 + SBSize.Left), CShort((SBSize.Bottom - SBSize.Top) \ 2 + SBSize.Top))
                'MsgBox("Starbound window: " & StarboundWindowHandle.ToString) '
                SetForegroundWindow(StarboundWindowHandle)
                SetCursorPos(CShort((SBSize.Right - SBSize.Left) \ 2 + SBSize.Left), CShort((SBSize.Bottom - SBSize.Top) \ 2 + SBSize.Top))
                'Threading.Thread.Sleep(100)
                OutputString.Append("/spawnitem ")
                OutputString.Append(txtName.Text)
                OutputString.Append(" ")
                OutputString.Append(tstbSpawnQuantity.ToString)
                SendKeys.SendWait(OutputString.ToString)
                Console.WriteLine(OutputString.ToString)
                Threading.Thread.Sleep(100)
                SendKeys.SendWait("{ENTER}")
                Threading.Thread.Sleep(250)
                SetCursorPos(CShort(CurrentCursuorPos.x), CShort(CurrentCursuorPos.y))
                SetForegroundWindow(Me.Handle)
            Else
                MsgBox("Can't find Starbound window!", MsgBoxStyle.Exclamation, "Can't Find Window")
            End If
        End If

    End Sub

    Private Sub tstbSpawnQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tstbSpawnQuantity.KeyPress
        If e.KeyChar = ControlChars.Cr Or e.KeyChar = ControlChars.Lf Then
            SpawnItemToolStripMenuItem.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        tstbSearch.Focus()
    End Sub

    Private Sub OpenInExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInExplorerToolStripMenuItem.Click
        If tvwMaterials.SelectedNode IsNot Nothing AndAlso tvwMaterials.SelectedNode.Tag IsNot Nothing Then
            ShowInExplorer(CType(tvwMaterials.SelectedNode.Tag, Material).MaterialFilePath)
        End If
    End Sub

    Private Sub ViewImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImageToolStripMenuItem.Click
        If tvwMaterials.SelectedNode IsNot Nothing AndAlso tvwMaterials.SelectedNode.Tag IsNot Nothing Then
            OpenFile(CType(tvwMaterials.SelectedNode.Tag, Material).TextureFilePath)
        End If
    End Sub

    Private Sub LoadOnStartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadOnStartToolStripMenuItem.Click
        My.Settings.LoadOnStart = LoadOnStartToolStripMenuItem.Checked
    End Sub

    Private Sub ViewRawAssetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRawAssetToolStripMenuItem.Click
        If tvwMaterials.SelectedNode IsNot Nothing AndAlso tvwMaterials.SelectedNode.Tag IsNot Nothing Then
            Dim AF As System.IO.StreamReader
            Dim M As Material = CType(tvwMaterials.SelectedNode.Tag, Material)
            Dim X As New frmView
            Dim AD As String
            AF = My.Computer.FileSystem.OpenTextFileReader(M.MaterialFilePath)
            AD = AF.ReadToEnd()
            AF.Close()
            X.txtAsset.Text = AD.Replace(ControlChars.Lf, ControlChars.CrLf)
            X.txtAsset.SelectionStart = 0
            X.txtAsset.SelectionLength = 0
            X.Text = M.MaterialName
            X.Show(Me)
        End If
    End Sub

    Private Sub SpawnItemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SpawnItemToolStripMenuItem1.Click
        SpawnItemToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ShowInExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowInExplorerToolStripMenuItem.Click
        OpenInExplorerToolStripMenuItem.PerformClick()
    End Sub

    Private Sub OpenImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenImageToolStripMenuItem.Click
        ViewImageToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ViewRawAssetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewRawAssetToolStripMenuItem1.Click
        ViewRawAssetToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ExpandAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpandAllToolStripMenuItem.Click
        tvwMaterials.ExpandAll()
    End Sub

    Private Sub CollapseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollapseAllToolStripMenuItem.Click
        tvwMaterials.CollapseAll()
    End Sub
End Class
