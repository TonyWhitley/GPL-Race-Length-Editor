; Script generated with the Venis Install Wizard

; Define your application name
!define APPNAME "GPL Race Length Editor"
!define APPNAMEANDVERSION "GPL Race Length Editor 1.0.24"

; Main Install settings
Name "${APPNAMEANDVERSION}"
InstallDir "c:\GPL Race Length Editor"
OutFile "..\RaceLengthEditorInstaller.exe"

; Modern interface settings
!include "MUI.nsh"

!define MUI_ABORTWARNING

!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

; Set languages (first is default language)
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_RESERVEFILE_LANGDLL

Section "GPL Race Length Editor" Section1

	; Set Section properties
	SetOverwrite on

	; Set Section Files and Shortcuts
	SetOutPath "$INSTDIR\"
	File "publish\setup.exe"
	File "publish\RaceLengthEditor.application"
	File "publish\autorun.inf"
	File "publish\Application Files\RaceLengthEditor_2_0_0_3\Microsoft.VisualBasic.PowerPacks.dll.deploy"
	File "publish\Application Files\RaceLengthEditor_2_0_0_3\Microsoft.VisualBasic.PowerPacks.Vs.dll.deploy"
	File "publish\Application Files\RaceLengthEditor_2_0_0_3\RaceLengthEditor.application"
	File "publish\Application Files\RaceLengthEditor_2_0_0_3\RaceLengthEditor.exe.deploy"
	File "publish\Application Files\RaceLengthEditor_2_0_0_3\RaceLengthEditor.exe.manifest"
	File "publish\Application Files\RaceLengthEditor_2_0_0_3\RED_NOSE.ICO.deploy"
	CreateShortCut "$DESKTOP\GPL Race Length Editor.lnk" "$INSTDIR\setup.exe"
	CreateDirectory "$SMPROGRAMS\GPL Race Length Editor"
	CreateShortCut "$SMPROGRAMS\GPL Race Length Editor\GPL Race Length Editor.lnk" "$INSTDIR\setup.exe"

SectionEnd

; Modern install component descriptions
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
	!insertmacro MUI_DESCRIPTION_TEXT ${Section1} ""
!insertmacro MUI_FUNCTION_DESCRIPTION_END

; eof