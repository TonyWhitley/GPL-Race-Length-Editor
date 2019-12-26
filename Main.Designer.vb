<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class GPLRaceLengthEditor
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Public WithEvents txtStartingGrid As System.Windows.Forms.TextBox
    Public WithEvents txtDay As System.Windows.Forms.TextBox
    Public WithEvents txtMonth As System.Windows.Forms.TextBox
    Public WithEvents txtTrackDirectory As System.Windows.Forms.TextBox
    Public WithEvents txtShortName As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtNametxtName As System.Windows.Forms.GroupBox
    Public WithEvents scrlMoveTrackInSet As System.Windows.Forms.VScrollBar
    Public WithEvents btnRestoreFromBackup As System.Windows.Forms.Button
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents ResetToOriginal As System.Windows.Forms.Button
    Public WithEvents _txtLaps_4 As System.Windows.Forms.TextBox
    Public WithEvents _txtLaps_3 As System.Windows.Forms.TextBox
    Public WithEvents _txtLaps_2 As System.Windows.Forms.TextBox
    Public WithEvents _txtLaps_1 As System.Windows.Forms.TextBox
    Public WithEvents _txtLaps_0 As System.Windows.Forms.TextBox
    Public WithEvents _scrlLaps_1 As System.Windows.Forms.HScrollBar
    Public WithEvents _scrlLaps_2 As System.Windows.Forms.HScrollBar
    Public WithEvents _scrlLaps_3 As System.Windows.Forms.HScrollBar
    Public WithEvents _scrlLaps_4 As System.Windows.Forms.HScrollBar
    Public WithEvents _Label5_4 As System.Windows.Forms.Label
    Public WithEvents _Label5_3 As System.Windows.Forms.Label
    Public WithEvents _Label5_2 As System.Windows.Forms.Label
    Public WithEvents _Label5_1 As System.Windows.Forms.Label
    Public WithEvents _Label5_0 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents WriteModifiedInWriteModifiedIniFile As System.Windows.Forms.Button
    Public WithEvents txtEventNum As System.Windows.Forms.TextBox
    Public WithEvents comboTracks As System.Windows.Forms.ComboBox
    Public WithEvents Dir1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblModifidationStatus As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label5 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Option1 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
    Public WithEvents scrlLaps As Microsoft.VisualBasic.Compatibility.VB6.HScrollBarArray
    Public WithEvents txtLaps As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GPLRaceLengthEditor))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStartingGrid = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtTrackDirectory = New System.Windows.Forms.TextBox()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        Me.BrowseSeasonsFolder = New System.Windows.Forms.Button()
        Me.txtNametxtName = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.scrlMoveTrackInSet = New System.Windows.Forms.VScrollBar()
        Me.btnRestoreFromBackup = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.ResetToOriginal = New System.Windows.Forms.Button()
        Me._txtLaps_4 = New System.Windows.Forms.TextBox()
        Me._txtLaps_3 = New System.Windows.Forms.TextBox()
        Me._txtLaps_2 = New System.Windows.Forms.TextBox()
        Me._txtLaps_1 = New System.Windows.Forms.TextBox()
        Me._txtLaps_0 = New System.Windows.Forms.TextBox()
        Me._scrlLaps_1 = New System.Windows.Forms.HScrollBar()
        Me._scrlLaps_2 = New System.Windows.Forms.HScrollBar()
        Me._scrlLaps_3 = New System.Windows.Forms.HScrollBar()
        Me._scrlLaps_4 = New System.Windows.Forms.HScrollBar()
        Me._Label5_4 = New System.Windows.Forms.Label()
        Me._Label5_3 = New System.Windows.Forms.Label()
        Me._Label5_2 = New System.Windows.Forms.Label()
        Me._Label5_1 = New System.Windows.Forms.Label()
        Me._Label5_0 = New System.Windows.Forms.Label()
        Me.WriteModifiedInWriteModifiedIniFile = New System.Windows.Forms.Button()
        Me.txtEventNum = New System.Windows.Forms.TextBox()
        Me.comboTracks = New System.Windows.Forms.ComboBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Dir1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblModifidationStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label5 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Option1 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.scrlLaps = New Microsoft.VisualBasic.Compatibility.VB6.HScrollBarArray(Me.components)
        Me.txtLaps = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me.iniFileList = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.SeasonsFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSeasonsFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtNametxtName.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Option1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrlLaps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLaps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Location = New System.Drawing.Point(122, 47)
        Me.txtName.MaxLength = 0
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(270, 24)
        Me.txtName.TabIndex = 48
        Me.txtName.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtName, "Double click to edit then double click to commit")
        '
        'txtStartingGrid
        '
        Me.txtStartingGrid.AcceptsReturn = True
        Me.txtStartingGrid.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartingGrid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartingGrid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStartingGrid.Location = New System.Drawing.Point(353, 107)
        Me.txtStartingGrid.MaxLength = 0
        Me.txtStartingGrid.Name = "txtStartingGrid"
        Me.txtStartingGrid.ReadOnly = True
        Me.txtStartingGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartingGrid.Size = New System.Drawing.Size(28, 24)
        Me.txtStartingGrid.TabIndex = 42
        Me.txtStartingGrid.TabStop = False
        Me.txtStartingGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtStartingGrid, "Double click to edit then double click to commit")
        '
        'txtDay
        '
        Me.txtDay.AcceptsReturn = True
        Me.txtDay.BackColor = System.Drawing.SystemColors.Window
        Me.txtDay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDay.Location = New System.Drawing.Point(62, 107)
        Me.txtDay.MaxLength = 0
        Me.txtDay.Name = "txtDay"
        Me.txtDay.ReadOnly = True
        Me.txtDay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDay.Size = New System.Drawing.Size(28, 24)
        Me.txtDay.TabIndex = 40
        Me.txtDay.TabStop = False
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtDay, "Double click to edit then double click to commit")
        '
        'txtMonth
        '
        Me.txtMonth.AcceptsReturn = True
        Me.txtMonth.BackColor = System.Drawing.SystemColors.Window
        Me.txtMonth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMonth.Location = New System.Drawing.Point(179, 107)
        Me.txtMonth.MaxLength = 0
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.ReadOnly = True
        Me.txtMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMonth.Size = New System.Drawing.Size(28, 24)
        Me.txtMonth.TabIndex = 38
        Me.txtMonth.TabStop = False
        Me.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtMonth, "Double click to edit then double click to commit")
        '
        'txtTrackDirectory
        '
        Me.txtTrackDirectory.AcceptsReturn = True
        Me.txtTrackDirectory.BackColor = System.Drawing.SystemColors.Window
        Me.txtTrackDirectory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrackDirectory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTrackDirectory.Location = New System.Drawing.Point(122, 74)
        Me.txtTrackDirectory.MaxLength = 0
        Me.txtTrackDirectory.Name = "txtTrackDirectory"
        Me.txtTrackDirectory.ReadOnly = True
        Me.txtTrackDirectory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTrackDirectory.Size = New System.Drawing.Size(270, 24)
        Me.txtTrackDirectory.TabIndex = 36
        Me.txtTrackDirectory.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtTrackDirectory, "Double click to edit then double click to commit")
        '
        'txtShortName
        '
        Me.txtShortName.AcceptsReturn = True
        Me.txtShortName.BackColor = System.Drawing.SystemColors.Window
        Me.txtShortName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShortName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtShortName.Location = New System.Drawing.Point(122, 20)
        Me.txtShortName.MaxLength = 0
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.ReadOnly = True
        Me.txtShortName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtShortName.Size = New System.Drawing.Size(270, 24)
        Me.txtShortName.TabIndex = 34
        Me.txtShortName.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtShortName, "Double click to edit then double click to commit")
        '
        'BrowseSeasonsFolder
        '
        Me.BrowseSeasonsFolder.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BrowseSeasonsFolder.Location = New System.Drawing.Point(33, 29)
        Me.BrowseSeasonsFolder.Name = "BrowseSeasonsFolder"
        Me.BrowseSeasonsFolder.Size = New System.Drawing.Size(135, 66)
        Me.BrowseSeasonsFolder.TabIndex = 53
        Me.BrowseSeasonsFolder.Text = "Click HERE to browse for the 'season' file "
        Me.ToolTip1.SetToolTip(Me.BrowseSeasonsFolder, "All tracks is usually 67season.ini or for World Championship tracks select gp.ini" &
        "")
        Me.BrowseSeasonsFolder.UseVisualStyleBackColor = False
        '
        'txtNametxtName
        '
        Me.txtNametxtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtNametxtName.Controls.Add(Me.txtName)
        Me.txtNametxtName.Controls.Add(Me.txtStartingGrid)
        Me.txtNametxtName.Controls.Add(Me.txtDay)
        Me.txtNametxtName.Controls.Add(Me.txtMonth)
        Me.txtNametxtName.Controls.Add(Me.txtTrackDirectory)
        Me.txtNametxtName.Controls.Add(Me.txtShortName)
        Me.txtNametxtName.Controls.Add(Me.Label4)
        Me.txtNametxtName.Controls.Add(Me.Label10)
        Me.txtNametxtName.Controls.Add(Me.Label9)
        Me.txtNametxtName.Controls.Add(Me.Label7)
        Me.txtNametxtName.Controls.Add(Me.Label8)
        Me.txtNametxtName.Controls.Add(Me.Label6)
        Me.txtNametxtName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNametxtName.Location = New System.Drawing.Point(14, 81)
        Me.txtNametxtName.Name = "txtNametxtName"
        Me.txtNametxtName.Padding = New System.Windows.Forms.Padding(0)
        Me.txtNametxtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNametxtName.Size = New System.Drawing.Size(406, 144)
        Me.txtNametxtName.TabIndex = 33
        Me.txtNametxtName.TabStop = False
        Me.txtNametxtName.Text = "Track information"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(37, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(245, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(101, 21)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Starting Grid"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(17, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(37, 19)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Day"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(5, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(114, 19)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Track Directory"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(96, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Month"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(15, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Short Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'scrlMoveTrackInSet
        '
        Me.scrlMoveTrackInSet.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrlMoveTrackInSet.LargeChange = 1
        Me.scrlMoveTrackInSet.Location = New System.Drawing.Point(713, 9)
        Me.scrlMoveTrackInSet.Maximum = 2
        Me.scrlMoveTrackInSet.Name = "scrlMoveTrackInSet"
        Me.scrlMoveTrackInSet.Size = New System.Drawing.Size(10, 28)
        Me.scrlMoveTrackInSet.TabIndex = 31
        Me.scrlMoveTrackInSet.TabStop = True
        Me.scrlMoveTrackInSet.Tag = "False"
        Me.scrlMoveTrackInSet.Value = 1
        '
        'btnRestoreFromBackup
        '
        Me.btnRestoreFromBackup.BackColor = System.Drawing.SystemColors.Control
        Me.btnRestoreFromBackup.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRestoreFromBackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRestoreFromBackup.Location = New System.Drawing.Point(452, 447)
        Me.btnRestoreFromBackup.Name = "btnRestoreFromBackup"
        Me.btnRestoreFromBackup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRestoreFromBackup.Size = New System.Drawing.Size(199, 28)
        Me.btnRestoreFromBackup.TabIndex = 23
        Me.btnRestoreFromBackup.TabStop = False
        Me.btnRestoreFromBackup.Text = "Restore from backup"
        Me.btnRestoreFromBackup.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.ResetToOriginal)
        Me.Frame2.Controls.Add(Me._txtLaps_4)
        Me.Frame2.Controls.Add(Me._txtLaps_3)
        Me.Frame2.Controls.Add(Me._txtLaps_2)
        Me.Frame2.Controls.Add(Me._txtLaps_1)
        Me.Frame2.Controls.Add(Me._txtLaps_0)
        Me.Frame2.Controls.Add(Me._scrlLaps_1)
        Me.Frame2.Controls.Add(Me._scrlLaps_2)
        Me.Frame2.Controls.Add(Me._scrlLaps_3)
        Me.Frame2.Controls.Add(Me._scrlLaps_4)
        Me.Frame2.Controls.Add(Me._Label5_4)
        Me.Frame2.Controls.Add(Me._Label5_3)
        Me.Frame2.Controls.Add(Me._Label5_2)
        Me.Frame2.Controls.Add(Me._Label5_1)
        Me.Frame2.Controls.Add(Me._Label5_0)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(14, 232)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(195, 199)
        Me.Frame2.TabIndex = 7
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Number of laps"
        '
        'ResetToOriginal
        '
        Me.ResetToOriginal.BackColor = System.Drawing.SystemColors.Control
        Me.ResetToOriginal.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetToOriginal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetToOriginal.Location = New System.Drawing.Point(9, 163)
        Me.ResetToOriginal.Name = "ResetToOriginal"
        Me.ResetToOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ResetToOriginal.Size = New System.Drawing.Size(151, 33)
        Me.ResetToOriginal.TabIndex = 18
        Me.ResetToOriginal.TabStop = False
        Me.ResetToOriginal.Text = "Reset to original"
        Me.ResetToOriginal.UseVisualStyleBackColor = False
        '
        '_txtLaps_4
        '
        Me._txtLaps_4.AcceptsReturn = True
        Me._txtLaps_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtLaps_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtLaps_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLaps.SetIndex(Me._txtLaps_4, CType(4, Short))
        Me._txtLaps_4.Location = New System.Drawing.Point(117, 135)
        Me._txtLaps_4.MaxLength = 0
        Me._txtLaps_4.Name = "_txtLaps_4"
        Me._txtLaps_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtLaps_4.Size = New System.Drawing.Size(42, 24)
        Me._txtLaps_4.TabIndex = 16
        Me._txtLaps_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtLaps_3
        '
        Me._txtLaps_3.AcceptsReturn = True
        Me._txtLaps_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtLaps_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtLaps_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLaps.SetIndex(Me._txtLaps_3, CType(3, Short))
        Me._txtLaps_3.Location = New System.Drawing.Point(117, 108)
        Me._txtLaps_3.MaxLength = 0
        Me._txtLaps_3.Name = "_txtLaps_3"
        Me._txtLaps_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtLaps_3.Size = New System.Drawing.Size(42, 24)
        Me._txtLaps_3.TabIndex = 14
        Me._txtLaps_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtLaps_2
        '
        Me._txtLaps_2.AcceptsReturn = True
        Me._txtLaps_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtLaps_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtLaps_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLaps.SetIndex(Me._txtLaps_2, CType(2, Short))
        Me._txtLaps_2.Location = New System.Drawing.Point(117, 81)
        Me._txtLaps_2.MaxLength = 0
        Me._txtLaps_2.Name = "_txtLaps_2"
        Me._txtLaps_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtLaps_2.Size = New System.Drawing.Size(42, 24)
        Me._txtLaps_2.TabIndex = 12
        Me._txtLaps_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtLaps_1
        '
        Me._txtLaps_1.AcceptsReturn = True
        Me._txtLaps_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtLaps_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtLaps_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLaps.SetIndex(Me._txtLaps_1, CType(1, Short))
        Me._txtLaps_1.Location = New System.Drawing.Point(117, 54)
        Me._txtLaps_1.MaxLength = 0
        Me._txtLaps_1.Name = "_txtLaps_1"
        Me._txtLaps_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtLaps_1.Size = New System.Drawing.Size(42, 24)
        Me._txtLaps_1.TabIndex = 10
        Me._txtLaps_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_txtLaps_0
        '
        Me._txtLaps_0.AcceptsReturn = True
        Me._txtLaps_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtLaps_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtLaps_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLaps.SetIndex(Me._txtLaps_0, CType(0, Short))
        Me._txtLaps_0.Location = New System.Drawing.Point(117, 28)
        Me._txtLaps_0.MaxLength = 0
        Me._txtLaps_0.Name = "_txtLaps_0"
        Me._txtLaps_0.ReadOnly = True
        Me._txtLaps_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtLaps_0.Size = New System.Drawing.Size(42, 24)
        Me._txtLaps_0.TabIndex = 8
        Me._txtLaps_0.TabStop = False
        Me._txtLaps_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_scrlLaps_1
        '
        Me._scrlLaps_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrlLaps.SetIndex(Me._scrlLaps_1, CType(1, Short))
        Me._scrlLaps_1.LargeChange = 1
        Me._scrlLaps_1.Location = New System.Drawing.Point(93, 54)
        Me._scrlLaps_1.Maximum = 32767
        Me._scrlLaps_1.Name = "_scrlLaps_1"
        Me._scrlLaps_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._scrlLaps_1.Size = New System.Drawing.Size(89, 17)
        Me._scrlLaps_1.TabIndex = 27
        Me._scrlLaps_1.TabStop = True
        '
        '_scrlLaps_2
        '
        Me._scrlLaps_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrlLaps.SetIndex(Me._scrlLaps_2, CType(2, Short))
        Me._scrlLaps_2.LargeChange = 1
        Me._scrlLaps_2.Location = New System.Drawing.Point(93, 81)
        Me._scrlLaps_2.Maximum = 32767
        Me._scrlLaps_2.Name = "_scrlLaps_2"
        Me._scrlLaps_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._scrlLaps_2.Size = New System.Drawing.Size(89, 17)
        Me._scrlLaps_2.TabIndex = 28
        Me._scrlLaps_2.TabStop = True
        '
        '_scrlLaps_3
        '
        Me._scrlLaps_3.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrlLaps.SetIndex(Me._scrlLaps_3, CType(3, Short))
        Me._scrlLaps_3.LargeChange = 1
        Me._scrlLaps_3.Location = New System.Drawing.Point(93, 108)
        Me._scrlLaps_3.Maximum = 32767
        Me._scrlLaps_3.Name = "_scrlLaps_3"
        Me._scrlLaps_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._scrlLaps_3.Size = New System.Drawing.Size(89, 17)
        Me._scrlLaps_3.TabIndex = 29
        Me._scrlLaps_3.TabStop = True
        '
        '_scrlLaps_4
        '
        Me._scrlLaps_4.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrlLaps.SetIndex(Me._scrlLaps_4, CType(4, Short))
        Me._scrlLaps_4.LargeChange = 1
        Me._scrlLaps_4.Location = New System.Drawing.Point(93, 135)
        Me._scrlLaps_4.Maximum = 32767
        Me._scrlLaps_4.Name = "_scrlLaps_4"
        Me._scrlLaps_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._scrlLaps_4.Size = New System.Drawing.Size(89, 17)
        Me._scrlLaps_4.TabIndex = 30
        Me._scrlLaps_4.TabStop = True
        '
        '_Label5_4
        '
        Me._Label5_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label5_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.SetIndex(Me._Label5_4, CType(4, Short))
        Me._Label5_4.Location = New System.Drawing.Point(9, 136)
        Me._Label5_4.Name = "_Label5_4"
        Me._Label5_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label5_4.Size = New System.Drawing.Size(75, 19)
        Me._Label5_4.TabIndex = 17
        Me._Label5_4.Text = "GP"
        Me._Label5_4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label5_3
        '
        Me._Label5_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label5_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.SetIndex(Me._Label5_3, CType(3, Short))
        Me._Label5_3.Location = New System.Drawing.Point(9, 109)
        Me._Label5_3.Name = "_Label5_3"
        Me._Label5_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label5_3.Size = New System.Drawing.Size(75, 19)
        Me._Label5_3.TabIndex = 15
        Me._Label5_3.Text = "Long"
        Me._Label5_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label5_2
        '
        Me._Label5_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label5_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.SetIndex(Me._Label5_2, CType(2, Short))
        Me._Label5_2.Location = New System.Drawing.Point(9, 82)
        Me._Label5_2.Name = "_Label5_2"
        Me._Label5_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label5_2.Size = New System.Drawing.Size(75, 19)
        Me._Label5_2.TabIndex = 13
        Me._Label5_2.Text = "Short"
        Me._Label5_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label5_1
        '
        Me._Label5_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label5_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.SetIndex(Me._Label5_1, CType(1, Short))
        Me._Label5_1.Location = New System.Drawing.Point(9, 55)
        Me._Label5_1.Name = "_Label5_1"
        Me._Label5_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label5_1.Size = New System.Drawing.Size(75, 19)
        Me._Label5_1.TabIndex = 11
        Me._Label5_1.Text = "Novice"
        Me._Label5_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label5_0
        '
        Me._Label5_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label5_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label5_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.SetIndex(Me._Label5_0, CType(0, Short))
        Me._Label5_0.Location = New System.Drawing.Point(9, 28)
        Me._Label5_0.Name = "_Label5_0"
        Me._Label5_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label5_0.Size = New System.Drawing.Size(75, 19)
        Me._Label5_0.TabIndex = 9
        Me._Label5_0.Text = "Original GP"
        Me._Label5_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'WriteModifiedInWriteModifiedIniFile
        '
        Me.WriteModifiedInWriteModifiedIniFile.BackColor = System.Drawing.SystemColors.Control
        Me.WriteModifiedInWriteModifiedIniFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.WriteModifiedInWriteModifiedIniFile.Enabled = False
        Me.WriteModifiedInWriteModifiedIniFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WriteModifiedInWriteModifiedIniFile.Location = New System.Drawing.Point(23, 447)
        Me.WriteModifiedInWriteModifiedIniFile.Name = "WriteModifiedInWriteModifiedIniFile"
        Me.WriteModifiedInWriteModifiedIniFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WriteModifiedInWriteModifiedIniFile.Size = New System.Drawing.Size(217, 28)
        Me.WriteModifiedInWriteModifiedIniFile.TabIndex = 6
        Me.WriteModifiedInWriteModifiedIniFile.TabStop = False
        Me.WriteModifiedInWriteModifiedIniFile.Text = "Write modified .ini file"
        Me.WriteModifiedInWriteModifiedIniFile.UseVisualStyleBackColor = False
        '
        'txtEventNum
        '
        Me.txtEventNum.AcceptsReturn = True
        Me.txtEventNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtEventNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEventNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEventNum.Location = New System.Drawing.Point(326, 30)
        Me.txtEventNum.MaxLength = 0
        Me.txtEventNum.Name = "txtEventNum"
        Me.txtEventNum.ReadOnly = True
        Me.txtEventNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEventNum.Size = New System.Drawing.Size(28, 24)
        Me.txtEventNum.TabIndex = 3
        Me.txtEventNum.TabStop = False
        Me.txtEventNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'comboTracks
        '
        Me.comboTracks.BackColor = System.Drawing.SystemColors.Window
        Me.comboTracks.Cursor = System.Windows.Forms.Cursors.Default
        Me.comboTracks.ForeColor = System.Drawing.SystemColors.WindowText
        Me.comboTracks.Location = New System.Drawing.Point(14, 29)
        Me.comboTracks.Name = "comboTracks"
        Me.comboTracks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.comboTracks.Size = New System.Drawing.Size(207, 26)
        Me.comboTracks.TabIndex = 2
        Me.comboTracks.Text = "Find .ini file first"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.BrowseSeasonsFolder)
        Me.Frame1.Controls.Add(Me.Dir1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(452, 81)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(205, 306)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = """Seasons"" file"
        '
        'Dir1
        '
        Me.Dir1.BackColor = System.Drawing.SystemColors.Window
        Me.Dir1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dir1.Enabled = False
        Me.Dir1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Dir1.FormattingEnabled = True
        Me.Dir1.IntegralHeight = False
        Me.Dir1.Location = New System.Drawing.Point(18, 110)
        Me.Dir1.Name = "Dir1"
        Me.Dir1.Size = New System.Drawing.Size(163, 175)
        Me.Dir1.TabIndex = 1
        Me.Dir1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(520, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(137, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Move up/down the order:"
        '
        'lblModifidationStatus
        '
        Me.lblModifidationStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.lblModifidationStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblModifidationStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblModifidationStatus.Location = New System.Drawing.Point(289, 441)
        Me.lblModifidationStatus.Name = "lblModifidationStatus"
        Me.lblModifidationStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblModifidationStatus.Size = New System.Drawing.Size(106, 40)
        Me.lblModifidationStatus.TabIndex = 25
        Me.lblModifidationStatus.Text = "Laps have not been modified"
        Me.lblModifidationStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(233, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Event #"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Option1
        '
        '
        'scrlLaps
        '
        '
        'txtLaps
        '
        '
        'iniFileList
        '
        Me.iniFileList.BackColor = System.Drawing.SystemColors.Window
        Me.iniFileList.Cursor = System.Windows.Forms.Cursors.Default
        Me.iniFileList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.iniFileList.FormattingEnabled = True
        Me.iniFileList.Location = New System.Drawing.Point(367, 301)
        Me.iniFileList.Name = "iniFileList"
        Me.iniFileList.Pattern = "67season.ini"
        Me.iniFileList.Size = New System.Drawing.Size(87, 40)
        Me.iniFileList.TabIndex = 5
        Me.iniFileList.TabStop = False
        Me.iniFileList.Visible = False
        '
        'SeasonsFolderBrowser
        '
        Me.SeasonsFolderBrowser.Description = """Seasons"" directory"
        Me.SeasonsFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.SeasonsFolderBrowser.ShowNewFolderButton = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 28)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'About
        '
        Me.About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.About.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsingToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(53, 24)
        Me.About.Text = "Help"
        '
        'UsingToolStripMenuItem
        '
        Me.UsingToolStripMenuItem.Name = "UsingToolStripMenuItem"
        Me.UsingToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.UsingToolStripMenuItem.Text = "Using"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenSeasonsFileDialog
        '
        Me.OpenSeasonsFileDialog.FileName = "67season.ini"
        Me.OpenSeasonsFileDialog.Filter = "GPL season files|*.ini"
        '
        'GPLRaceLengthEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(671, 498)
        Me.Controls.Add(Me.iniFileList)
        Me.Controls.Add(Me.txtNametxtName)
        Me.Controls.Add(Me.scrlMoveTrackInSet)
        Me.Controls.Add(Me.btnRestoreFromBackup)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.WriteModifiedInWriteModifiedIniFile)
        Me.Controls.Add(Me.txtEventNum)
        Me.Controls.Add(Me.comboTracks)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblModifidationStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 34)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "GPLRaceLengthEditor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPL Race Length Editor"
        Me.txtNametxtName.ResumeLayout(False)
        Me.txtNametxtName.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Option1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrlLaps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLaps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents iniFileList As VB6.FileListBox
    Friend WithEvents SeasonsFolderBrowser As FolderBrowserDialog
    Friend WithEvents BrowseSeasonsFolder As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents About As ToolStripMenuItem
    Friend WithEvents UsingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenSeasonsFileDialog As OpenFileDialog
#End Region
End Class