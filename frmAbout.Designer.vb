<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAbout
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
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblComment As System.Windows.Forms.Label
    'Public WithEvents _Line1_1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblTitle As System.Windows.Forms.Label
    'Public WithEvents _Line1_0 As Microsoft.VisualBasic.PowerPacks.LineShape
    Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents lblDisclaimer As System.Windows.Forms.Label
	Public WithEvents Line1 As LineShapeArray
    'Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me._Line1_1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me._Line1_0 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDisclaimer = New System.Windows.Forms.Label()
        Me.Line1 = New RaceLengthEditor.LineShapeArray(Me.components)
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me._Line1_1, Me._Line1_0})
        Me.ShapeContainer1.Size = New System.Drawing.Size(354, 220)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        '_Line1_1
        '
        Me._Line1_1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Line1.SetIndex(Me._Line1_1, CType(1, Short))
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.X1 = 5
        Me._Line1_1.X2 = 293
        Me._Line1_1.Y1 = 105
        Me._Line1_1.Y2 = 105
        '
        '_Line1_0
        '
        Me._Line1_0.BorderColor = System.Drawing.Color.White
        Me._Line1_0.BorderWidth = 2
        Me.Line1.SetIndex(Me._Line1_0, CType(0, Short))
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.X1 = 5
        Me._Line1_0.X2 = 293
        Me._Line1_0.Y1 = 105
        Me._Line1_0.Y2 = 105
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(15, 20)
        Me.Text1.MaxLength = 0
        Me.Text1.Multiline = True
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(331, 49)
        Me.Text1.TabIndex = 6
        Me.Text1.Text = "see Project/Properties/make/Comments for date stamp"
        Me.Text1.Visible = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(224, 168)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(84, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(224, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jim Clark, Spa 1967"
        '
        'lblComment
        '
        Me.lblComment.BackColor = System.Drawing.SystemColors.Control
        Me.lblComment.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblComment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComment.Location = New System.Drawing.Point(211, 128)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblComment.Size = New System.Drawing.Size(94, 17)
        Me.lblComment.TabIndex = 4
        Me.lblComment.Text = "10/5/01"
        Me.lblComment.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(8, 96)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(299, 32)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Application Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
        Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVersion.Location = New System.Drawing.Point(8, 128)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVersion.Size = New System.Drawing.Size(105, 17)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Version"
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.BackColor = System.Drawing.SystemColors.Control
        Me.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDisclaimer.ForeColor = System.Drawing.Color.Black
        Me.lblDisclaimer.Location = New System.Drawing.Point(16, 168)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDisclaimer.Size = New System.Drawing.Size(201, 43)
        Me.lblDisclaimer.TabIndex = 1
        Me.lblDisclaimer.Text = "     Author: Tony Whitley    tony_whitley@hotmail.com"
        Me.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAbout
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.cmdOK
        Me.ClientSize = New System.Drawing.Size(354, 220)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblDisclaimer)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(156, 129)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About MyApp"
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
End Class