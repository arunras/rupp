<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class AISpeech
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
    Public WithEvents VisemePicture As System.Windows.Forms.PictureBox
    Public WithEvents chkShowEvents As System.Windows.Forms.CheckBox
    Public WithEvents StopBtn As System.Windows.Forms.Button
    Public WithEvents chkSpFlagNLPSpeakPunc As System.Windows.Forms.CheckBox
    Public WithEvents chkSpFlagPurgeBeforeSpeak As System.Windows.Forms.CheckBox
    Public WithEvents chkSpFlagAync As System.Windows.Forms.CheckBox
    Public WithEvents chkSpFlagIsFilename As System.Windows.Forms.CheckBox
    Public WithEvents chkSpFlagPersistXML As System.Windows.Forms.CheckBox
    Public WithEvents chkSpFlagIsXML As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents AudioOutputCB As System.Windows.Forms.ComboBox
    Public WithEvents txtMainBox As System.Windows.Forms.TextBox
    Public WithEvents ResetBtn As System.Windows.Forms.Button
    Public WithEvents MouthImgList As System.Windows.Forms.ImageList
    Public WithEvents DebugTxtBox As System.Windows.Forms.TextBox
    Public WithEvents SkipBtn As System.Windows.Forms.Button
    Public ComDlgOpen As System.Windows.Forms.OpenFileDialog
    Public ComDlgSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents FormatCB As System.Windows.Forms.ComboBox
    Public WithEvents RateSldr As Axmscomctl.AxSlider
    Public WithEvents VoiceCB As System.Windows.Forms.ComboBox
    Public WithEvents PauseBtn As System.Windows.Forms.Button
    Public WithEvents SpeakBtn As System.Windows.Forms.Button
    Public WithEvents VolumeSldr As Axmscomctl.AxSlider
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AISpeech))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.VisemePicture = New System.Windows.Forms.PictureBox
        Me.chkShowEvents = New System.Windows.Forms.CheckBox
        Me.StopBtn = New System.Windows.Forms.Button
        Me.chkSpFlagNLPSpeakPunc = New System.Windows.Forms.CheckBox
        Me.chkSpFlagPurgeBeforeSpeak = New System.Windows.Forms.CheckBox
        Me.chkSpFlagAync = New System.Windows.Forms.CheckBox
        Me.chkSpFlagIsFilename = New System.Windows.Forms.CheckBox
        Me.chkSpFlagPersistXML = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkSpFlagIsXML = New System.Windows.Forms.CheckBox
        Me.AudioOutputCB = New System.Windows.Forms.ComboBox
        Me.txtMainBox = New System.Windows.Forms.TextBox
        Me.ResetBtn = New System.Windows.Forms.Button
        Me.MouthImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.DebugTxtBox = New System.Windows.Forms.TextBox
        Me.SkipBtn = New System.Windows.Forms.Button
        Me.ComDlgOpen = New System.Windows.Forms.OpenFileDialog
        Me.ComDlgSave = New System.Windows.Forms.SaveFileDialog
        Me.FormatCB = New System.Windows.Forms.ComboBox
        Me.RateSldr = New Axmscomctl.AxSlider
        Me.VoiceCB = New System.Windows.Forms.ComboBox
        Me.PauseBtn = New System.Windows.Forms.Button
        Me.SpeakBtn = New System.Windows.Forms.Button
        Me.VolumeSldr = New Axmscomctl.AxSlider
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.menuFileOpenText = New System.Windows.Forms.ToolStripMenuItem
        Me.menuFileSpeakWave = New System.Windows.Forms.ToolStripMenuItem
        Me.menuFileSaveToWave = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblVolume = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSpeakAsType = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.nudSkip = New System.Windows.Forms.NumericUpDown
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.wbSpeak = New System.Windows.Forms.WebBrowser
        Me.OpenFileDialogSpeech = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialogSpeech = New System.Windows.Forms.SaveFileDialog
        Me.TimerElape = New System.Windows.Forms.Timer(Me.components)
        Me.pbBanner = New System.Windows.Forms.PictureBox
        CType(Me.VisemePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.RateSldr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeSldr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisemePicture
        '
        Me.VisemePicture.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.VisemePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VisemePicture.Cursor = System.Windows.Forms.Cursors.Default
        Me.VisemePicture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisemePicture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VisemePicture.Location = New System.Drawing.Point(549, 12)
        Me.VisemePicture.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.VisemePicture.Name = "VisemePicture"
        Me.VisemePicture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VisemePicture.Size = New System.Drawing.Size(214, 97)
        Me.VisemePicture.TabIndex = 27
        Me.VisemePicture.TabStop = False
        '
        'chkShowEvents
        '
        Me.chkShowEvents.BackColor = System.Drawing.SystemColors.Control
        Me.chkShowEvents.Checked = True
        Me.chkShowEvents.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowEvents.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkShowEvents.Font = New System.Drawing.Font("Khmer OS Fasthand", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowEvents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkShowEvents.Location = New System.Drawing.Point(8, -2)
        Me.chkShowEvents.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkShowEvents.Name = "chkShowEvents"
        Me.chkShowEvents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShowEvents.Size = New System.Drawing.Size(119, 25)
        Me.chkShowEvents.TabIndex = 25
        Me.chkShowEvents.Text = "បង្ហញព្រឹត្តិការ"
        Me.chkShowEvents.UseVisualStyleBackColor = False
        '
        'StopBtn
        '
        Me.StopBtn.BackColor = System.Drawing.Color.Transparent
        Me.StopBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.StopBtn.Enabled = False
        Me.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopBtn.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopBtn.ForeColor = System.Drawing.Color.Blue
        Me.StopBtn.Location = New System.Drawing.Point(67, 93)
        Me.StopBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StopBtn.Size = New System.Drawing.Size(100, 30)
        Me.StopBtn.TabIndex = 2
        Me.StopBtn.Text = "ឈប់"
        Me.StopBtn.UseVisualStyleBackColor = False
        '
        'chkSpFlagNLPSpeakPunc
        '
        Me.chkSpFlagNLPSpeakPunc.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpFlagNLPSpeakPunc.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagNLPSpeakPunc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagNLPSpeakPunc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagNLPSpeakPunc.Location = New System.Drawing.Point(254, 48)
        Me.chkSpFlagNLPSpeakPunc.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkSpFlagNLPSpeakPunc.Name = "chkSpFlagNLPSpeakPunc"
        Me.chkSpFlagNLPSpeakPunc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagNLPSpeakPunc.Size = New System.Drawing.Size(109, 20)
        Me.chkSpFlagNLPSpeakPunc.TabIndex = 24
        Me.chkSpFlagNLPSpeakPunc.Text = "NLPSpeakPunc"
        Me.chkSpFlagNLPSpeakPunc.UseVisualStyleBackColor = False
        '
        'chkSpFlagPurgeBeforeSpeak
        '
        Me.chkSpFlagPurgeBeforeSpeak.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpFlagPurgeBeforeSpeak.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagPurgeBeforeSpeak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagPurgeBeforeSpeak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagPurgeBeforeSpeak.Location = New System.Drawing.Point(254, 20)
        Me.chkSpFlagPurgeBeforeSpeak.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkSpFlagPurgeBeforeSpeak.Name = "chkSpFlagPurgeBeforeSpeak"
        Me.chkSpFlagPurgeBeforeSpeak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagPurgeBeforeSpeak.Size = New System.Drawing.Size(118, 20)
        Me.chkSpFlagPurgeBeforeSpeak.TabIndex = 22
        Me.chkSpFlagPurgeBeforeSpeak.Text = "PurgeBeforeSpeak"
        Me.chkSpFlagPurgeBeforeSpeak.UseVisualStyleBackColor = False
        '
        'chkSpFlagAync
        '
        Me.chkSpFlagAync.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpFlagAync.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagAync.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagAync.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagAync.Location = New System.Drawing.Point(137, 48)
        Me.chkSpFlagAync.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkSpFlagAync.Name = "chkSpFlagAync"
        Me.chkSpFlagAync.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagAync.Size = New System.Drawing.Size(109, 20)
        Me.chkSpFlagAync.TabIndex = 20
        Me.chkSpFlagAync.Text = "FlagsAsync"
        Me.chkSpFlagAync.UseVisualStyleBackColor = False
        '
        'chkSpFlagIsFilename
        '
        Me.chkSpFlagIsFilename.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpFlagIsFilename.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagIsFilename.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagIsFilename.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagIsFilename.Location = New System.Drawing.Point(137, 20)
        Me.chkSpFlagIsFilename.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkSpFlagIsFilename.Name = "chkSpFlagIsFilename"
        Me.chkSpFlagIsFilename.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagIsFilename.Size = New System.Drawing.Size(78, 20)
        Me.chkSpFlagIsFilename.TabIndex = 23
        Me.chkSpFlagIsFilename.Text = "IsFilename"
        Me.chkSpFlagIsFilename.UseVisualStyleBackColor = False
        '
        'chkSpFlagPersistXML
        '
        Me.chkSpFlagPersistXML.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpFlagPersistXML.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagPersistXML.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagPersistXML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagPersistXML.Location = New System.Drawing.Point(14, 48)
        Me.chkSpFlagPersistXML.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkSpFlagPersistXML.Name = "chkSpFlagPersistXML"
        Me.chkSpFlagPersistXML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagPersistXML.Size = New System.Drawing.Size(82, 20)
        Me.chkSpFlagPersistXML.TabIndex = 21
        Me.chkSpFlagPersistXML.Text = "PersistXML"
        Me.chkSpFlagPersistXML.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkSpFlagIsXML)
        Me.Frame1.Controls.Add(Me.chkSpFlagPersistXML)
        Me.Frame1.Controls.Add(Me.chkSpFlagPurgeBeforeSpeak)
        Me.Frame1.Controls.Add(Me.chkSpFlagAync)
        Me.Frame1.Controls.Add(Me.chkSpFlagNLPSpeakPunc)
        Me.Frame1.Controls.Add(Me.chkSpFlagIsFilename)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(159, 32)
        Me.Frame1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(394, 80)
        Me.Frame1.TabIndex = 18
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Speak Flags"
        Me.Frame1.Visible = False
        '
        'chkSpFlagIsXML
        '
        Me.chkSpFlagIsXML.BackColor = System.Drawing.SystemColors.Control
        Me.chkSpFlagIsXML.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSpFlagIsXML.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSpFlagIsXML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSpFlagIsXML.Location = New System.Drawing.Point(14, 20)
        Me.chkSpFlagIsXML.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkSpFlagIsXML.Name = "chkSpFlagIsXML"
        Me.chkSpFlagIsXML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSpFlagIsXML.Size = New System.Drawing.Size(75, 20)
        Me.chkSpFlagIsXML.TabIndex = 19
        Me.chkSpFlagIsXML.Text = "IsXML"
        Me.chkSpFlagIsXML.UseVisualStyleBackColor = False
        '
        'AudioOutputCB
        '
        Me.AudioOutputCB.BackColor = System.Drawing.SystemColors.Window
        Me.AudioOutputCB.Cursor = System.Windows.Forms.Cursors.Default
        Me.AudioOutputCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AudioOutputCB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioOutputCB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AudioOutputCB.Location = New System.Drawing.Point(67, 138)
        Me.AudioOutputCB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.AudioOutputCB.Name = "AudioOutputCB"
        Me.AudioOutputCB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AudioOutputCB.Size = New System.Drawing.Size(142, 22)
        Me.AudioOutputCB.TabIndex = 17
        '
        'txtMainBox
        '
        Me.txtMainBox.AcceptsReturn = True
        Me.txtMainBox.BackColor = System.Drawing.Color.Black
        Me.txtMainBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMainBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainBox.ForeColor = System.Drawing.Color.White
        Me.txtMainBox.HideSelection = False
        Me.txtMainBox.Location = New System.Drawing.Point(7, 25)
        Me.txtMainBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtMainBox.MaxLength = 0
        Me.txtMainBox.Multiline = True
        Me.txtMainBox.Name = "txtMainBox"
        Me.txtMainBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMainBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMainBox.Size = New System.Drawing.Size(529, 301)
        Me.txtMainBox.TabIndex = 0
        Me.txtMainBox.Text = "Enter text you wish spoken here."
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.Color.Transparent
        Me.ResetBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.Blue
        Me.ResetBtn.Location = New System.Drawing.Point(67, 163)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ResetBtn.Size = New System.Drawing.Size(100, 30)
        Me.ResetBtn.TabIndex = 7
        Me.ResetBtn.Text = "សារថ្មី"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'MouthImgList
        '
        Me.MouthImgList.ImageStream = CType(resources.GetObject("MouthImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MouthImgList.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MouthImgList.Images.SetKeyName(0, "bmpMIC2.bmp")
        Me.MouthImgList.Images.SetKeyName(1, "bmpMIC3.bmp")
        Me.MouthImgList.Images.SetKeyName(2, "bmpMIC4.bmp")
        Me.MouthImgList.Images.SetKeyName(3, "bmpMIC5.bmp")
        Me.MouthImgList.Images.SetKeyName(4, "bmpMIC6.bmp")
        Me.MouthImgList.Images.SetKeyName(5, "bmpMIC7.bmp")
        Me.MouthImgList.Images.SetKeyName(6, "bmpMIC8.bmp")
        Me.MouthImgList.Images.SetKeyName(7, "bmpMIC9.bmp")
        Me.MouthImgList.Images.SetKeyName(8, "bmpMIC10.bmp")
        Me.MouthImgList.Images.SetKeyName(9, "bmpMIC11.bmp")
        Me.MouthImgList.Images.SetKeyName(10, "bmpMIC12.bmp")
        Me.MouthImgList.Images.SetKeyName(11, "bmpMIC13.bmp")
        Me.MouthImgList.Images.SetKeyName(12, "bmpMICEYECLOSED.bmp")
        Me.MouthImgList.Images.SetKeyName(13, "bmpMICEYENARROW.bmp")
        Me.MouthImgList.Images.SetKeyName(14, "bmpMICFULL.bmp")
        '
        'DebugTxtBox
        '
        Me.DebugTxtBox.AcceptsReturn = True
        Me.DebugTxtBox.BackColor = System.Drawing.Color.Black
        Me.DebugTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DebugTxtBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebugTxtBox.ForeColor = System.Drawing.Color.Lime
        Me.DebugTxtBox.Location = New System.Drawing.Point(7, 22)
        Me.DebugTxtBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DebugTxtBox.MaxLength = 0
        Me.DebugTxtBox.Multiline = True
        Me.DebugTxtBox.Name = "DebugTxtBox"
        Me.DebugTxtBox.ReadOnly = True
        Me.DebugTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DebugTxtBox.Size = New System.Drawing.Size(529, 65)
        Me.DebugTxtBox.TabIndex = 26
        Me.DebugTxtBox.Text = "Show Events..."
        Me.DebugTxtBox.WordWrap = False
        '
        'SkipBtn
        '
        Me.SkipBtn.BackColor = System.Drawing.Color.Transparent
        Me.SkipBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.SkipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SkipBtn.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkipBtn.ForeColor = System.Drawing.Color.Blue
        Me.SkipBtn.Location = New System.Drawing.Point(67, 128)
        Me.SkipBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SkipBtn.Name = "SkipBtn"
        Me.SkipBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SkipBtn.Size = New System.Drawing.Size(54, 30)
        Me.SkipBtn.TabIndex = 4
        Me.SkipBtn.Text = "រំលង"
        Me.SkipBtn.UseVisualStyleBackColor = False
        '
        'FormatCB
        '
        Me.FormatCB.BackColor = System.Drawing.SystemColors.Window
        Me.FormatCB.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FormatCB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatCB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormatCB.Location = New System.Drawing.Point(67, 108)
        Me.FormatCB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FormatCB.Name = "FormatCB"
        Me.FormatCB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FormatCB.Size = New System.Drawing.Size(142, 22)
        Me.FormatCB.TabIndex = 15
        '
        'RateSldr
        '
        Me.RateSldr.Location = New System.Drawing.Point(67, 52)
        Me.RateSldr.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RateSldr.Name = "RateSldr"
        Me.RateSldr.OcxState = CType(resources.GetObject("RateSldr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.RateSldr.Size = New System.Drawing.Size(114, 28)
        Me.RateSldr.TabIndex = 11
        '
        'VoiceCB
        '
        Me.VoiceCB.BackColor = System.Drawing.SystemColors.Window
        Me.VoiceCB.Cursor = System.Windows.Forms.Cursors.Default
        Me.VoiceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VoiceCB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoiceCB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.VoiceCB.Location = New System.Drawing.Point(67, 22)
        Me.VoiceCB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.VoiceCB.Name = "VoiceCB"
        Me.VoiceCB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VoiceCB.Size = New System.Drawing.Size(142, 22)
        Me.VoiceCB.TabIndex = 9
        '
        'PauseBtn
        '
        Me.PauseBtn.BackColor = System.Drawing.Color.Transparent
        Me.PauseBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.PauseBtn.Enabled = False
        Me.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PauseBtn.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseBtn.ForeColor = System.Drawing.Color.Blue
        Me.PauseBtn.Location = New System.Drawing.Point(67, 58)
        Me.PauseBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PauseBtn.Size = New System.Drawing.Size(100, 30)
        Me.PauseBtn.TabIndex = 3
        Me.PauseBtn.Text = "ផ្អាក"
        Me.PauseBtn.UseVisualStyleBackColor = False
        '
        'SpeakBtn
        '
        Me.SpeakBtn.BackColor = System.Drawing.Color.Transparent
        Me.SpeakBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.SpeakBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpeakBtn.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeakBtn.ForeColor = System.Drawing.Color.Blue
        Me.SpeakBtn.Location = New System.Drawing.Point(67, 22)
        Me.SpeakBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SpeakBtn.Name = "SpeakBtn"
        Me.SpeakBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SpeakBtn.Size = New System.Drawing.Size(100, 30)
        Me.SpeakBtn.TabIndex = 1
        Me.SpeakBtn.Text = "និយាយ"
        Me.SpeakBtn.UseVisualStyleBackColor = False
        '
        'VolumeSldr
        '
        Me.VolumeSldr.Location = New System.Drawing.Point(67, 79)
        Me.VolumeSldr.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.VolumeSldr.Name = "VolumeSldr"
        Me.VolumeSldr.OcxState = CType(resources.GetObject("VolumeSldr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VolumeSldr.Size = New System.Drawing.Size(114, 22)
        Me.VolumeSldr.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(15, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "សំលេង"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(15, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ទំរង់"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(15, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "សំលេង"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(15, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ល្បឿន"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "សូស័ព្ទ"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileOpenText, Me.menuFileSpeakWave, Me.menuFileSaveToWave})
        Me.menuFile.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuFile.Image = Global.AI_Dictionary.My.Resources.Resources.file2
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(79, 26)
        Me.menuFile.Text = "ឯកសារ"
        '
        'menuFileOpenText
        '
        Me.menuFileOpenText.Image = Global.AI_Dictionary.My.Resources.Resources.file
        Me.menuFileOpenText.Name = "menuFileOpenText"
        Me.menuFileOpenText.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menuFileOpenText.Size = New System.Drawing.Size(242, 26)
        Me.menuFileOpenText.Text = "បើកអត្ថបទ"
        '
        'menuFileSpeakWave
        '
        Me.menuFileSpeakWave.Image = Global.AI_Dictionary.My.Resources.Resources.Speak1
        Me.menuFileSpeakWave.Name = "menuFileSpeakWave"
        Me.menuFileSpeakWave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.menuFileSpeakWave.Size = New System.Drawing.Size(242, 26)
        Me.menuFileSpeakWave.Text = "បើកឯកសារសំលេង"
        '
        'menuFileSaveToWave
        '
        Me.menuFileSaveToWave.Image = Global.AI_Dictionary.My.Resources.Resources.saveWav
        Me.menuFileSaveToWave.Name = "menuFileSaveToWave"
        Me.menuFileSaveToWave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuFileSaveToWave.Size = New System.Drawing.Size(242, 26)
        Me.menuFileSaveToWave.Text = "រក្សាឯកសារជាសំលេង"
        '
        'MainMenu1
        '
        Me.MainMenu1.BackColor = System.Drawing.SystemColors.Control
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MainMenu1.Size = New System.Drawing.Size(794, 30)
        Me.MainMenu1.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVolume)
        Me.GroupBox1.Controls.Add(Me.lblRate)
        Me.GroupBox1.Controls.Add(Me.VoiceCB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RateSldr)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.VolumeSldr)
        Me.GroupBox1.Controls.Add(Me.AudioOutputCB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.FormatCB)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS System", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(560, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 176)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ជំរើស"
        '
        'lblVolume
        '
        Me.lblVolume.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolume.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVolume.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.ForeColor = System.Drawing.Color.Red
        Me.lblVolume.Location = New System.Drawing.Point(185, 79)
        Me.lblVolume.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVolume.Size = New System.Drawing.Size(30, 20)
        Me.lblVolume.TabIndex = 19
        Me.lblVolume.Text = "100"
        '
        'lblRate
        '
        Me.lblRate.BackColor = System.Drawing.SystemColors.Control
        Me.lblRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Red
        Me.lblRate.Location = New System.Drawing.Point(185, 56)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRate.Size = New System.Drawing.Size(24, 20)
        Me.lblRate.TabIndex = 18
        Me.lblRate.Text = "1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSpeakAsType)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Fasthand", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 52)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "និយាយតាមសរសេរ"
        '
        'txtSpeakAsType
        '
        Me.txtSpeakAsType.BackColor = System.Drawing.Color.Black
        Me.txtSpeakAsType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeakAsType.ForeColor = System.Drawing.Color.White
        Me.txtSpeakAsType.Location = New System.Drawing.Point(6, 22)
        Me.txtSpeakAsType.Name = "txtSpeakAsType"
        Me.txtSpeakAsType.Size = New System.Drawing.Size(529, 22)
        Me.txtSpeakAsType.TabIndex = 0
        Me.txtSpeakAsType.Text = "Speak As You Type..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMainBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Khmer OS Fasthand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(543, 338)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "អានអត្ថបទ"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.nudSkip)
        Me.GroupBox4.Controls.Add(Me.SpeakBtn)
        Me.GroupBox4.Controls.Add(Me.PauseBtn)
        Me.GroupBox4.Controls.Add(Me.SkipBtn)
        Me.GroupBox4.Controls.Add(Me.ResetBtn)
        Me.GroupBox4.Controls.Add(Me.StopBtn)
        Me.GroupBox4.Font = New System.Drawing.Font("Khmer OS System", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(560, 224)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 204)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "បញ្ជា"
        '
        'nudSkip
        '
        Me.nudSkip.Location = New System.Drawing.Point(128, 127)
        Me.nudSkip.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSkip.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nudSkip.Name = "nudSkip"
        Me.nudSkip.Size = New System.Drawing.Size(39, 31)
        Me.nudSkip.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.wbSpeak)
        Me.GroupBox5.Controls.Add(Me.DebugTxtBox)
        Me.GroupBox5.Controls.Add(Me.chkShowEvents)
        Me.GroupBox5.Controls.Add(Me.VisemePicture)
        Me.GroupBox5.Font = New System.Drawing.Font("Khmer OS System", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(11, 446)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(770, 114)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ព្រឹត្តិការ"
        '
        'wbSpeak
        '
        Me.wbSpeak.Location = New System.Drawing.Point(581, 16)
        Me.wbSpeak.MinimumSize = New System.Drawing.Size(21, 20)
        Me.wbSpeak.Name = "wbSpeak"
        Me.wbSpeak.ScrollBarsEnabled = False
        Me.wbSpeak.Size = New System.Drawing.Size(155, 88)
        Me.wbSpeak.TabIndex = 28
        '
        'OpenFileDialogSpeech
        '
        Me.OpenFileDialogSpeech.FileName = "OpenFileDialog1"
        '
        'pbBanner
        '
        Me.pbBanner.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pbBanner.BackgroundImage = Global.AI_Dictionary.My.Resources.Resources.b_Speech
        Me.pbBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBanner.Location = New System.Drawing.Point(78, 2)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(714, 30)
        Me.pbBanner.TabIndex = 130
        Me.pbBanner.TabStop = False
        Me.pbBanner.Tag = ""
        '
        'AISpeech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.pbBanner)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(223, 243)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "AISpeech"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AI Speech"
        CType(Me.VisemePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.RateSldr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeSldr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents menuFileOpenText As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents menuFileSpeakWave As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents menuFileSaveToWave As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSpeakAsType As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents nudSkip As System.Windows.Forms.NumericUpDown
    Friend WithEvents wbSpeak As System.Windows.Forms.WebBrowser
    Public WithEvents lblVolume As System.Windows.Forms.Label
    Public WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogSpeech As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialogSpeech As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TimerElape As System.Windows.Forms.Timer
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
#End Region
End Class