Option Strict Off
Option Explicit On
Friend Class frmUsing
    Inherits System.Windows.Forms.Form


    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    'UPGRADE_ISSUE: Frame event Frame1.Click was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    Private Sub Frame1_Click()
        Me.Close()
    End Sub

End Class