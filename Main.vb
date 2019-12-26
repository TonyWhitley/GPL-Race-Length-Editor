Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class GPLRaceLengthEditor
	Inherits System.Windows.Forms.Form
	Dim iniFileName As String
	Dim track As Object
	Dim tracks As Short
	Dim CurrentLine As String
	Dim iniFile(2000) As String
	Dim iniFileSize As Short
	Dim editingEnable As Boolean
	Dim numberOfSets, activeSet As Object
	Dim altSet As Short
	
	' Option to order tracks alphabetically or by date.
	
	Private Structure TrackData
		Dim TrackNum As Short
        'UPGRADE_NOTE: name was upgraded to name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim GP_Name As String
        Dim shortname As String
        Dim trackDirectory As String
        Dim GP_Month As Short
        Dim GP_Day As Short
        Dim numberOfLaps As Short
        Dim startingGrid As Short
        Dim originalNumberOfLaps As Short
        'UPGRADE_NOTE: set was upgraded to set_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim set_Renamed As Short
    End Structure

    Enum raceType
        eOriginalGP
        eNovice
        eShort
        eLong
        eGP
    End Enum

    Dim Season(200) As TrackData
    Dim raceLengthPercents(raceType.eGP) As Single


    Private Sub btnRestoreFromBackup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnRestoreFromBackup.Click
        Dim fs As Object
        On Error Resume Next
        fs = CreateObject("Scripting.FileSystemObject")
        'UPGRADE_WARNING: Couldn't resolve default property of object fs.CopyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        fs.CopyFile(Dir1.Path & iniFileName & ".GPL RLE backup", Dir1.Path & iniFileName, True) ' True means that the existing file is overwritten
        On Error GoTo 0
        Call readIniFile()
        WriteModifiedInWriteModifiedIniFile.Enabled = True
        Timer1.Enabled = True ' Switch focus back to combo box
    End Sub

    'UPGRADE_WARNING: Event comboTracks.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub comboTracks_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles comboTracks.SelectedIndexChanged
        Dim i As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        track = comboTracks.SelectedIndex + 1
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtName.Text = Season(track).GP_Name
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtShortName.Text = Season(track).shortname
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtTrackDirectory.Text = Season(track).trackDirectory
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtMonth.Text = CStr(Season(track).GP_Month)
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtDay.Text = CStr(Season(track).GP_Day)
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtStartingGrid.Text = CStr(Season(track).startingGrid)
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtEventNum.Text = track
        For i = raceType.eOriginalGP To raceType.eGP
            txtLaps(i).Tag = True 'Set to indicate that it is about to be updated but not changed
        Next
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txtLaps(raceType.eGP).Text = CStr(Season(track).numberOfLaps)
        For i = raceType.eNovice To raceType.eGP
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtLaps(i).Text = CStr(Int(Season(track).numberOfLaps * raceLengthPercents(i) + 0.99))
        Next
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Season(track).originalNumberOfLaps <> 0 AndAlso Season(track).originalNumberOfLaps <> Season(track).numberOfLaps Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtLaps(raceType.eOriginalGP).Text = CStr(Season(track).originalNumberOfLaps)
            ResetToOriginal.Enabled = True
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtLaps(raceType.eOriginalGP).Text = CStr(Season(track).numberOfLaps)
            ResetToOriginal.Enabled = False
        End If
        For i = raceType.eOriginalGP To raceType.eGP
            txtLaps(i).Tag = False
        Next
    End Sub

    Private Sub readIniFile()
        Dim iniFileLine As String
        Dim numberOfSets, activeSet, altSet, currentSet As Int16

        On Error GoTo no_file
        FileOpen(1, Dir1.Path & "\" & iniFileName, OpenMode.Input)

        Call clearData()
        numberOfSets = 0
        activeSet = 0
        altSet = 0
        currentSet = 0
        tracks = 0

        While Not EOF(1)
            iniFileSize = iniFileSize + 1
            iniFileLine = LineInput(1)
            Debug.Print(iniFileLine)

            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, ;[Set). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, ";[Set") Then
                On Error GoTo 0
                iniFileLine = Mid(iniFileLine, Len(";[Set") + 1)
                'UPGRADE_WARNING: Couldn't resolve default property of object currentSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'VB6.SetItemString(comboActiveSet, currentSet, iniFileLine)
                'UPGRADE_WARNING: Couldn't resolve default property of object currentSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                currentSet = currentSet + 1 'Left$(iniFileLine$, 1)
                'iniFileLine$ = Mid$(iniFileLine$, 3)
            End If

            'UPGRADE_WARNING: Couldn't resolve default property of object currentSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If currentSet <> 0 AndAlso VB.Left(iniFileLine, 2) = ";#" Then
                iniFileLine = VB.Left(iniFileLine, 2)
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, [Event). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "[Event") Then
                comboTracks.Items.Add((Mid(iniFileLine, Len("[Event") + 1)))
                tracks = tracks + 1
                Season(tracks).originalNumberOfLaps = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object currentSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Season(tracks).set_Renamed = currentSet
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, name). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "name") Then
                Season(tracks).GP_Name = (Mid(iniFileLine, Len("name") + 2))
                While VB.Left(Season(tracks).GP_Name, 1) = " "
                    Season(tracks).GP_Name = Mid(Season(tracks).GP_Name, 2)
                End While
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, shortname). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "shortname") Then
                Season(tracks).shortname = (Mid(iniFileLine, Len("shortname") + 2))
                VB6.SetItemString(comboTracks, tracks - 1, Mid(iniFileLine, Len("shortname") + 2))
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, trackDirectory). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "trackDirectory") Then
                Season(tracks).trackDirectory = (Mid(iniFileLine, Len("trackDirectory") + 2))
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, month). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "month") Then
                Season(tracks).GP_Month = (Mid(iniFileLine, Len("month") + 2))
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, day). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "day") Then
                Season(tracks).GP_Day = (Mid(iniFileLine, Len("day") + 2))
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, numberOfLaps). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "numberOfLaps") Then
                Season(tracks).numberOfLaps = CShort(Mid(iniFileLine, Len("numberOfLaps") + 2))
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, startingGrid). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, "startingGrid") Then
                Season(tracks).startingGrid = CShort(Mid(iniFileLine, Len("startingGrid") + 2))
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object strStarts(iniFileLine$, ;originalNumberOfLaps). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If strStarts(iniFileLine, ";originalNumberOfLaps") Then
                Season(tracks).originalNumberOfLaps = CShort(Mid(iniFileLine, Len(";originalNumberOfLaps") + 2))
            End If
        End While
        FileClose(1)

        'comboTracks.Sorted = True
        comboTracks.SelectedIndex = 0

        Timer1.Enabled = True ' Switch focus back to combo box
        Call checkForChangedLaps(False)

no_file: ' Error trapping for .ini file not found
        On Error GoTo 0
    End Sub

    Public Sub mnuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmAbout.ShowDialog()
        frmAbout.Close()
        'UPGRADE_NOTE: Object frmAbout may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        frmAbout = Nothing
    End Sub

    Public Sub mnuUsing_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmUsing.ShowDialog()
        frmUsing.Close()
        'UPGRADE_NOTE: Object frmUsing may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        frmUsing = Nothing
    End Sub

    'UPGRADE_WARNING: Event Option1.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
        Return
        If eventSender.Checked Then
            Dim Index As Short = Option1.GetIndex(eventSender)
            If Index = 0 Then iniFileName = "\67Season.ini" Else iniFileName = "\gp.ini"
            Call readIniFile()
            Timer1.Enabled = True ' Switch focus back to combo box
        End If
    End Sub

    Private Sub ResetToOriginal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ResetToOriginal.Click
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Season(track).originalNumberOfLaps <> 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Season(track).numberOfLaps = Season(track).originalNumberOfLaps
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtLaps(raceType.eGP).Text = CStr(Season(track).numberOfLaps)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txtLaps(raceType.eOriginalGP).Text = CStr(Season(track).numberOfLaps)
        End If
        ResetToOriginal.Enabled = False
        WriteModifiedInWriteModifiedIniFile.Enabled = True
        comboTracks.Focus()
        Call checkForChangedLaps(False)
    End Sub

    Private Sub Dir1_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Dir1.Change
        iniFileList.Path = Dir1.DirList(Dir1.DirListIndex)
        Dir1.DirListIndex = Dir1.DirListCount - 1 'Ensures dir display scrolls to bottom
        If iniFileList.Items.Count Then Call readIniFile() Else Call clearData()
    End Sub

    Private Sub GPLRaceLengthEditor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim baseDir As String
        raceLengthPercents(raceType.eOriginalGP) = 1
        raceLengthPercents(raceType.eNovice) = 0.08
        raceLengthPercents(raceType.eShort) = 0.15
        raceLengthPercents(raceType.eLong) = 0.3
        raceLengthPercents(raceType.eGP) = 1

        lblModifidationStatus.Visible = False
        editingEnable = False

        'Move (Screen.Width - Width) / 2, (Screen.Height - Height) / 2 ' Centre the screen

        ' Set Title
        ' NOT NEEDED IN VB.NET App.Title = "GPL Race Length Editor"
        ' Load Registry Settings
        baseDir = GetSetting(My.Application.Info.Title, "Properties", "Seasons Directory", "\Sierra\GPL\seasons")
        iniFileName = GetSetting(My.Application.Info.Title, "Properties", "Ini file name", "\67Season.ini")

        On Error GoTo noPath
        Dir1.Path = baseDir
        Dir1.DirListIndex = Dir1.DirListCount - 1 'Ensures dir display scrolls to bottom

        iniFileList.Path = Dir1.Path
        'If iniFileList.ListCount Then Call readIniFile ' not necessary  - setting Dir1.path causes Dir1_change()

        scrlMoveTrackInSet.Visible = False
        Label3.Visible = False

        Exit Sub

noPath:
        baseDir = "C:\"
        Dir1.Path = baseDir
        Resume Next
    End Sub

    Private Sub GPLRaceLengthEditor_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FileClose(1)
        SaveSetting(My.Application.Info.Title, "Properties", "Seasons Directory", Dir1.Path)
        SaveSetting(My.Application.Info.Title, "Properties", "Ini file name", iniFileName)
    End Sub

    'UPGRADE_NOTE: scrlLaps.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
    'UPGRADE_WARNING: HScrollBar event scrlLaps.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub scrlLaps_Change(ByRef Index As Short, ByVal newScrollValue As Integer)
        'UPGRADE_WARNING: Can't resolve the name of control scrlLaps( Index ). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
        txtLaps(Index).Text = CStr(scrlLaps(Index).Value)
    End Sub


    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        comboTracks.Focus() ' Switch focus back to combo box
        Timer1.Enabled = False
    End Sub

    'UPGRADE_WARNING: Event txtLaps.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtLaps_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLaps.TextChanged
        Dim Index As Short = txtLaps.GetIndex(eventSender)
        Dim i As Object
        If Index < 1 Then Return

        scrlLaps(Index).Value = txtLaps(Index).Text
        If CBool(txtLaps(Index).Tag) = True Then Exit Sub 'Tag indicates that txtLaps(index) is being updated but not changed
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Season(track).originalNumberOfLaps = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Season(track).originalNumberOfLaps = Season(track).numberOfLaps
        End If
        If txtLaps(Index).Text <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Season(track).numberOfLaps = ((CDbl(txtLaps(Index).Text) / raceLengthPercents(Index)) - 0.45)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Season(track).numberOfLaps = 0
        End If
        For i = raceType.eOriginalGP To raceType.eGP
            txtLaps(i).Tag = True 'Set to indicate that it is about to be updated but not changed
        Next
        For i = raceType.eNovice To raceType.eGP
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If i <> Index Then txtLaps(i).Text = CStr(Int(Season(track).numberOfLaps * raceLengthPercents(i) + 0.99))
        Next
        For i = raceType.eOriginalGP To raceType.eGP
            txtLaps(i).Tag = False
        Next
        ResetToOriginal.Enabled = True
        WriteModifiedInWriteModifiedIniFile.Enabled = True
        Call checkForChangedLaps(False)
    End Sub

    Private Sub clearData()
        comboTracks.Items.Clear()
        comboTracks.Text = "Find .ini file first"
        'comboActiveSet.Items.Clear()
        'comboActiveSet.Text = "Find .ini file first"
    End Sub

    'UPGRADE_WARNING: Event txtStartingGrid.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtStartingGrid_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStartingGrid.TextChanged
        'If txtStartingGrid.Text <> "" Then Season(track).startingGrid = txtStartingGrid.Text
    End Sub

    Private Sub txtShortName_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShortName.Click
        txtShortName.SelectionStart = 0
        txtShortName.SelectionLength = Len(txtShortName.Text)
    End Sub

    Private Sub txtShortName_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtShortName.DoubleClick
        'If txtShortName.Locked = False Then
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If txtShortName.Text <> "" Then Season(track).shortname = txtShortName.Text
        '    txtShortName.Locked = True
        Timer1.Enabled = True ' Switch focus back to combo box
        'Else
        '    txtShortName.Locked = False
        '    txtShortName.SelStart = 0
        '    txtShortName.SelLength = Len(txtShortName.Text)
        'End If
    End Sub
    Private Sub txtName_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.Click
        txtName.SelectionStart = 0
        txtName.SelectionLength = Len(txtName.Text)
    End Sub
    Private Sub txtName_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.DoubleClick
        'If txtName.Locked = False Then
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If txtName.Text <> "" Then Season(track).GP_Name = txtName.Text
        '    txtName.Locked = True
        Timer1.Enabled = True ' Switch focus back to combo box
        'Else
        '    txtName.Locked = False
        '   txtName.SelStart = 0
        '    txtName.SelLength = Len(txtName.Text)
        'End If
    End Sub
    Private Sub txtTrackDirectory_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTrackDirectory.DoubleClick
        If txtTrackDirectory.ReadOnly = False Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If txtTrackDirectory.Text <> "" Then Season(track).trackDirectory = txtTrackDirectory.Text
            txtTrackDirectory.ReadOnly = True
            Timer1.Enabled = True ' Switch focus back to combo box
        Else
            txtTrackDirectory.ReadOnly = False
            txtTrackDirectory.SelectionStart = 0
            txtTrackDirectory.SelectionLength = Len(txtTrackDirectory.Text)
        End If
    End Sub

    Private Sub txtStartingGrid_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStartingGrid.DoubleClick
        If txtStartingGrid.ReadOnly = False Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If txtStartingGrid.Text <> "" Then Season(track).startingGrid = CShort(txtStartingGrid.Text)
            txtStartingGrid.ReadOnly = True
            Timer1.Enabled = True ' Switch focus back to combo box
        Else
            txtStartingGrid.ReadOnly = False
        End If
    End Sub
    Private Sub txtMonth_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMonth.DoubleClick
        If txtMonth.ReadOnly = False Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If txtMonth.Text <> "" Then Season(track).GP_Month = txtMonth.Text
            txtMonth.ReadOnly = True
            Timer1.Enabled = True ' Switch focus back to combo box
        Else
            txtMonth.ReadOnly = False
        End If
    End Sub
    Private Sub txtDay_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDay.DoubleClick
        If txtDay.ReadOnly = False Then
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If txtDay.Text <> "" Then Season(track).GP_Day = txtDay.Text
            txtDay.ReadOnly = True
            Timer1.Enabled = True ' Switch focus back to combo box
        Else
            txtDay.ReadOnly = False
        End If
    End Sub

    Private Sub txtStartingGrid_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtStartingGrid.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii <> 13 Then GoTo EventExitSub
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If txtStartingGrid.Text <> "" Then Season(track).startingGrid = CShort(txtStartingGrid.Text)
        txtStartingGrid.ReadOnly = True
EventExitSub:
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    'UPGRADE_NOTE: scrlMoveTrackInSet.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
    'UPGRADE_WARNING: VScrollBar event scrlMoveTrackInSet.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub scrlMoveTrackInSet_Change(ByVal newScrollValue As Integer)
        If CBool(scrlMoveTrackInSet.Tag) = True Then Exit Sub
        scrlMoveTrackInSet.Tag = True ' Indicates that value is being changed by the program, not user action
        If newScrollValue = 0 Then ' Up
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If track > 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                track = track - 1
                Call swapEntry()
                comboTracks.SelectedIndex = comboTracks.SelectedIndex - 1
            End If
        Else ' 2 => down
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If track < tracks Then
                Call swapEntry()
                comboTracks.SelectedIndex = comboTracks.SelectedIndex + 1
            End If
        End If
        newScrollValue = 1 ' Set it back to the middle
        scrlMoveTrackInSet.Tag = False
    End Sub
    Private Sub swapEntry()
        Dim swap As Object
        Dim temp As String
        Dim fromTrack As Object
        Dim toTrack As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        toTrack = track - 1
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        fromTrack = track
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        temp = VB6.GetItemString(comboTracks, toTrack)
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VB6.SetItemString(comboTracks, toTrack, VB6.GetItemString(comboTracks, fromTrack))
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VB6.SetItemString(comboTracks, fromTrack, temp)

        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        toTrack = track
        'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        fromTrack = track + 1
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        temp = Season(toTrack).GP_Name
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).GP_Name = Season(fromTrack).GP_Name
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).GP_Name = temp

        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        temp = Season(toTrack).shortname
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).shortname = Season(fromTrack).shortname
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).shortname = temp

        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        temp = Season(toTrack).trackDirectory
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).trackDirectory = Season(fromTrack).trackDirectory
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).trackDirectory = temp

        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        swap = Season(toTrack).GP_Month
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).GP_Month = Season(fromTrack).GP_Month
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).GP_Month = swap

        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        swap = Season(toTrack).GP_Day
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).GP_Day = Season(fromTrack).GP_Day
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).GP_Day = swap

        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        swap = Season(toTrack).numberOfLaps
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).numberOfLaps = Season(fromTrack).numberOfLaps
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).numberOfLaps = swap

        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        swap = Season(toTrack).originalNumberOfLaps
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).originalNumberOfLaps = Season(fromTrack).originalNumberOfLaps
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).originalNumberOfLaps = swap

        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        swap = Season(toTrack).startingGrid
        'UPGRADE_WARNING: Couldn't resolve default property of object toTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(toTrack).startingGrid = Season(fromTrack).startingGrid
        'UPGRADE_WARNING: Couldn't resolve default property of object fromTrack. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object swap. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Season(fromTrack).startingGrid = swap
    End Sub

    Private Sub WriteModifiedInWriteModifiedIniFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles WriteModifiedInWriteModifiedIniFile.Click
        Dim mods As Object
        Dim fs As Object
        ' Create backup file if one does not exsit
        On Error Resume Next
        fs = CreateObject("Scripting.FileSystemObject")
        'UPGRADE_WARNING: Couldn't resolve default property of object fs.CopyFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        fs.CopyFile(Dir1.Path & iniFileName, Dir1.Path & iniFileName & ".GPL RLE backup", False) ' False ensures that an existing file is not overwritten
        On Error GoTo 0

        ' Now write the revised .ini file
        FileOpen(1, Dir1.Path & iniFileName, OpenMode.Output)
        PrintLine(1, ";**********************************************")
        PrintLine(1, ";   This file was automatically generated by ")
        PrintLine(1, ";       " & My.Application.Info.Title & " V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision)
        PrintLine(1, ";**********************************************")
        'UPGRADE_WARNING: Couldn't resolve default property of object checkForChangedLaps(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mods. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mods = checkForChangedLaps(False)
        'UPGRADE_WARNING: Couldn't resolve default property of object mods. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If mods Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mods. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mods = 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mods. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PrintLine(1, "; " & mods & " race length has been changed:")
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object mods. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PrintLine(1, "; " & mods & " race lengths have been changed:")
            End If
            checkForChangedLaps(True)
        Else
            PrintLine(1, "; All race lengths are as originally specified")
        End If
        PrintLine(1, ";**********************************************")
        PrintLine(1, "")
        PrintLine(1, "[Season]")
        PrintLine(1, "name=GP")
        PrintLine(1, "Year=1967")
        PrintLine(1, "numEvents=" & tracks)

        For track = 1 To tracks
            PrintLine(1, "")
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "[Event" & track & "]")
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "name=" & Season(track).GP_Name)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "shortname=" & Season(track).shortname)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "trackDirectory=" & Season(track).trackDirectory)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "month=" & Season(track).GP_Month)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "day=" & Season(track).GP_Day)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "numberOfLaps=" & Season(track).numberOfLaps)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(1, "startingGrid=" & Season(track).startingGrid)
            'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Season(track).originalNumberOfLaps <> 0 AndAlso Season(track).originalNumberOfLaps <> Season(track).numberOfLaps Then
                'UPGRADE_WARNING: Couldn't resolve default property of object track. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PrintLine(1, ";originalNumberOfLaps=" & Season(track).originalNumberOfLaps)
            End If
        Next

        FileClose(1)
        WriteModifiedInWriteModifiedIniFile.Enabled = False
        Call readIniFile()
        Timer1.Enabled = True ' Switch focus back to combo box
    End Sub


    Private Function checkForChangedLaps(ByRef printNames As Boolean) As Object
        Dim i As Object
        Dim result As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        result = 0
        lblModifidationStatus.Text = "Laps have not been modified"
        lblModifidationStatus.BackColor = Color.LightGray
        lblModifidationStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        For i = 1 To tracks
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Season(i).originalNumberOfLaps <> 0 AndAlso Season(i).originalNumberOfLaps <> Season(i).numberOfLaps Then
                lblModifidationStatus.Text = "Laps have been modified"
                lblModifidationStatus.BackColor = Color.LightSalmon
                lblModifidationStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
                'UPGRADE_WARNING: Couldn't resolve default property of object result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                result = result + 1
                If printNames Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    PrintLine(1, "; Event " & i & " " & Season(i).GP_Name)
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    PrintLine(1, ";              changed from " & Season(i).originalNumberOfLaps & " laps to " & Season(i).numberOfLaps)
                End If
            End If
        Next
        lblModifidationStatus.Visible = True
        'UPGRADE_WARNING: Couldn't resolve default property of object result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object checkForChangedLaps. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        checkForChangedLaps = result
    End Function

    Private Function strStarts(ByRef strToBeTested As String, ByRef compareStr As String) As Object
        ' Return True if "strToBeTested" starts with "compareStr", case ignored
        'UPGRADE_WARNING: Couldn't resolve default property of object strStarts. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        strStarts = StrComp(VB.Left(strToBeTested, Len(compareStr)), compareStr, CompareMethod.Text) = 0
    End Function
    Private Sub scrlLaps_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles scrlLaps.Scroll
        Dim Index As Short = scrlLaps.GetIndex(eventSender)
        Select Case eventArgs.Type
            Case System.Windows.Forms.ScrollEventType.EndScroll
                scrlLaps_Change(Index, eventArgs.NewValue)
        End Select
    End Sub
    Private Sub scrlMoveTrackInSet_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles scrlMoveTrackInSet.Scroll
        Select Case eventArgs.Type
            Case System.Windows.Forms.ScrollEventType.EndScroll
                scrlMoveTrackInSet_Change(eventArgs.NewValue)
        End Select
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
        frmAbout.Close()
        'UPGRADE_NOTE: Object frmAbout may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        frmAbout = Nothing

    End Sub

    Private Sub UsingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsingToolStripMenuItem.Click
        frmUsing.ShowDialog()
        frmUsing.Close()
        'UPGRADE_NOTE: Object frmUsing may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        frmUsing = Nothing

    End Sub


    Private Sub BrowseSeasonsFolder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BrowseSeasonsFolder.Click
        GoTo SkipFolderOnly
        Me.SeasonsFolderBrowser.SelectedPath = Dir1.Path
        Me.SeasonsFolderBrowser.ShowDialog()
        'Dim baseDir As String
        Dir1.Path = Me.SeasonsFolderBrowser.SelectedPath
SkipFolderOnly:
        Me.OpenSeasonsFileDialog.InitialDirectory = Dir1.Path
        Me.OpenSeasonsFileDialog.ShowDialog()
        'Dim baseDir As String
        Dir1.Path = System.IO.Path.GetDirectoryName(Me.OpenSeasonsFileDialog.FileName)
        iniFileName = System.IO.Path.GetFileName(Me.OpenSeasonsFileDialog.FileName)
        Call readIniFile()
        Timer1.Enabled = True ' Switch focus back to combo box

    End Sub

End Class