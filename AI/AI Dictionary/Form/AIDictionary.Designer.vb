<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AIDictionary
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIDictionary))
        Me.gbBanner = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblTime = New System.Windows.Forms.Label
        Me.PanelMenu = New System.Windows.Forms.Panel
        Me.btnNote = New System.Windows.Forms.Button
        Me.btnEE = New System.Windows.Forms.Button
        Me.btnKK = New System.Windows.Forms.Button
        Me.btnKE = New System.Windows.Forms.Button
        Me.btnAIRecognition = New System.Windows.Forms.Button
        Me.btnAISpeech = New System.Windows.Forms.Button
        Me.btnEK = New System.Windows.Forms.Button
        Me.pbBanner = New System.Windows.Forms.PictureBox
        Me.cboWord = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.listEWord = New System.Windows.Forms.ListBox
        Me.txtDefinition = New System.Windows.Forms.TextBox
        Me.btnSpeak = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnSetting = New System.Windows.Forms.Button
        Me.tbSpeakRate = New System.Windows.Forms.TrackBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblMyNote = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.wbDisplay = New System.Windows.Forms.WebBrowser
        Me.gbBanner.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSpeakRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBanner
        '
        Me.gbBanner.BackColor = System.Drawing.Color.Transparent
        Me.gbBanner.Controls.Add(Me.PictureBox2)
        Me.gbBanner.Controls.Add(Me.lblTime)
        Me.gbBanner.Controls.Add(Me.PanelMenu)
        Me.gbBanner.Controls.Add(Me.pbBanner)
        Me.gbBanner.Location = New System.Drawing.Point(-1, -8)
        Me.gbBanner.Name = "gbBanner"
        Me.gbBanner.Size = New System.Drawing.Size(886, 150)
        Me.gbBanner.TabIndex = 100
        Me.gbBanner.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.AI_Dictionary.My.Resources.Resources.AIWelcome2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(798, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 85)
        Me.PictureBox2.TabIndex = 121
        Me.PictureBox2.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(794, 74)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(13, 20)
        Me.lblTime.TabIndex = 120
        Me.lblTime.Text = " "
        Me.lblTime.Visible = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.btnNote)
        Me.PanelMenu.Controls.Add(Me.btnEE)
        Me.PanelMenu.Controls.Add(Me.btnKK)
        Me.PanelMenu.Controls.Add(Me.btnKE)
        Me.PanelMenu.Controls.Add(Me.btnAIRecognition)
        Me.PanelMenu.Controls.Add(Me.btnAISpeech)
        Me.PanelMenu.Controls.Add(Me.btnEK)
        Me.PanelMenu.Location = New System.Drawing.Point(3, 96)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(881, 50)
        Me.PanelMenu.TabIndex = 3
        '
        'btnNote
        '
        Me.btnNote.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNote.Location = New System.Drawing.Point(734, 5)
        Me.btnNote.Name = "btnNote"
        Me.btnNote.Size = New System.Drawing.Size(133, 40)
        Me.btnNote.TabIndex = 120
        Me.btnNote.Text = "កត់ត្រាបន្ថែម"
        Me.btnNote.UseVisualStyleBackColor = False
        '
        'btnEE
        '
        Me.btnEE.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEE.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEE.ForeColor = System.Drawing.Color.White
        Me.btnEE.Location = New System.Drawing.Point(356, 5)
        Me.btnEE.Name = "btnEE"
        Me.btnEE.Size = New System.Drawing.Size(140, 40)
        Me.btnEE.TabIndex = 14
        Me.btnEE.Text = "អង់គ្លេស-អង់គ្លេស"
        Me.btnEE.UseVisualStyleBackColor = False
        '
        'btnKK
        '
        Me.btnKK.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnKK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKK.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKK.ForeColor = System.Drawing.Color.White
        Me.btnKK.Location = New System.Drawing.Point(240, 5)
        Me.btnKK.Name = "btnKK"
        Me.btnKK.Size = New System.Drawing.Size(110, 40)
        Me.btnKK.TabIndex = 13
        Me.btnKK.Text = "ខ្មែរ-ខ្មែរ"
        Me.btnKK.UseVisualStyleBackColor = False
        '
        'btnKE
        '
        Me.btnKE.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnKE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKE.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKE.ForeColor = System.Drawing.Color.White
        Me.btnKE.Location = New System.Drawing.Point(124, 5)
        Me.btnKE.Name = "btnKE"
        Me.btnKE.Size = New System.Drawing.Size(110, 40)
        Me.btnKE.TabIndex = 12
        Me.btnKE.Text = "ខ្មែរ-អង់គ្លេស"
        Me.btnKE.UseVisualStyleBackColor = False
        '
        'btnAIRecognition
        '
        Me.btnAIRecognition.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAIRecognition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAIRecognition.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAIRecognition.ForeColor = System.Drawing.Color.White
        Me.btnAIRecognition.Location = New System.Drawing.Point(618, 5)
        Me.btnAIRecognition.Name = "btnAIRecognition"
        Me.btnAIRecognition.Size = New System.Drawing.Size(110, 40)
        Me.btnAIRecognition.TabIndex = 11
        Me.btnAIRecognition.Text = "AI ស្តាប់តាម"
        Me.btnAIRecognition.UseVisualStyleBackColor = False
        '
        'btnAISpeech
        '
        Me.btnAISpeech.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAISpeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAISpeech.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAISpeech.ForeColor = System.Drawing.Color.White
        Me.btnAISpeech.Location = New System.Drawing.Point(502, 5)
        Me.btnAISpeech.Name = "btnAISpeech"
        Me.btnAISpeech.Size = New System.Drawing.Size(110, 40)
        Me.btnAISpeech.TabIndex = 10
        Me.btnAISpeech.Text = "AI និយាយ"
        Me.btnAISpeech.UseVisualStyleBackColor = False
        '
        'btnEK
        '
        Me.btnEK.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEK.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEK.ForeColor = System.Drawing.Color.White
        Me.btnEK.Location = New System.Drawing.Point(8, 5)
        Me.btnEK.Name = "btnEK"
        Me.btnEK.Size = New System.Drawing.Size(110, 40)
        Me.btnEK.TabIndex = 9
        Me.btnEK.Text = "អង់គ្លេស-ខ្មែរ"
        Me.btnEK.UseVisualStyleBackColor = False
        '
        'pbBanner
        '
        Me.pbBanner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pbBanner.BackgroundImage = Global.AI_Dictionary.My.Resources.Resources.b_kh
        Me.pbBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBanner.Location = New System.Drawing.Point(3, 10)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(881, 85)
        Me.pbBanner.TabIndex = 0
        Me.pbBanner.TabStop = False
        '
        'cboWord
        '
        Me.cboWord.FormattingEnabled = True
        Me.cboWord.Location = New System.Drawing.Point(12, 150)
        Me.cboWord.Name = "cboWord"
        Me.cboWord.Size = New System.Drawing.Size(199, 24)
        Me.cboWord.TabIndex = 115
        Me.cboWord.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 153)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 0
        '
        'listEWord
        '
        Me.listEWord.FormattingEnabled = True
        Me.listEWord.ItemHeight = 16
        Me.listEWord.Location = New System.Drawing.Point(12, 181)
        Me.listEWord.Name = "listEWord"
        Me.listEWord.Size = New System.Drawing.Size(200, 420)
        Me.listEWord.TabIndex = 3
        '
        'txtDefinition
        '
        Me.txtDefinition.Font = New System.Drawing.Font("Khmer OS System", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefinition.Location = New System.Drawing.Point(222, 181)
        Me.txtDefinition.Multiline = True
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(647, 420)
        Me.txtDefinition.TabIndex = 2
        Me.txtDefinition.Text = "សាកលវិទ្យាល័យភូមិន្ទភ្នំពេញ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    ដេប៉ាតឺម៉ង់ ព័ត៌មានវិទ្យា" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Artificial In" & _
            "telligence"
        '
        'btnSpeak
        '
        Me.btnSpeak.BackColor = System.Drawing.Color.Transparent
        Me.btnSpeak.BackgroundImage = CType(resources.GetObject("btnSpeak.BackgroundImage"), System.Drawing.Image)
        Me.btnSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSpeak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSpeak.FlatAppearance.BorderSize = 0
        Me.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeak.Location = New System.Drawing.Point(306, 150)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(25, 25)
        Me.btnSpeak.TabIndex = 103
        Me.btnSpeak.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = Global.AI_Dictionary.My.Resources.Resources.Search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(216, 152)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(25, 25)
        Me.btnSearch.TabIndex = 109
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Khmer OS System", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSetting.Location = New System.Drawing.Point(808, 148)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(61, 25)
        Me.btnSetting.TabIndex = 111
        Me.btnSetting.Text = "កំណត់"
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'tbSpeakRate
        '
        Me.tbSpeakRate.AutoSize = False
        Me.tbSpeakRate.Location = New System.Drawing.Point(341, 148)
        Me.tbSpeakRate.Minimum = -10
        Me.tbSpeakRate.Name = "tbSpeakRate"
        Me.tbSpeakRate.Size = New System.Drawing.Size(121, 29)
        Me.tbSpeakRate.TabIndex = 112
        '
        'lblMyNote
        '
        Me.lblMyNote.AutoSize = True
        Me.lblMyNote.BackColor = System.Drawing.Color.White
        Me.lblMyNote.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyNote.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMyNote.Location = New System.Drawing.Point(227, 469)
        Me.lblMyNote.Name = "lblMyNote"
        Me.lblMyNote.Size = New System.Drawing.Size(80, 27)
        Me.lblMyNote.TabIndex = 119
        Me.lblMyNote.Text = "កំណត់ត្រា"
        Me.lblMyNote.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(602, 463)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 35)
        Me.btnDelete.TabIndex = 118
        Me.btnDelete.Text = "លប់"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNote.Font = New System.Drawing.Font("Khmer OS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtNote.Location = New System.Drawing.Point(232, 499)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ReadOnly = True
        Me.txtNote.Size = New System.Drawing.Size(431, 90)
        Me.txtNote.TabIndex = 117
        Me.txtNote.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AI_Dictionary.My.Resources.Resources.Cflag120
        Me.PictureBox1.Location = New System.Drawing.Point(747, 508)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 93)
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'TimerTime
        '
        '
        'wbDisplay
        '
        Me.wbDisplay.Location = New System.Drawing.Point(222, 181)
        Me.wbDisplay.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbDisplay.Name = "wbDisplay"
        Me.wbDisplay.Size = New System.Drawing.Size(663, 419)
        Me.wbDisplay.TabIndex = 120
        Me.wbDisplay.Url = New System.Uri("", System.UriKind.Relative)
        Me.wbDisplay.Visible = False
        '
        'AIDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.lblMyNote)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.wbDisplay)
        Me.Controls.Add(Me.cboWord)
        Me.Controls.Add(Me.tbSpeakRate)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.txtDefinition)
        Me.Controls.Add(Me.listEWord)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.gbBanner)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "AIDictionary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AI Dictionary"
        Me.gbBanner.ResumeLayout(False)
        Me.gbBanner.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSpeakRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbBanner As System.Windows.Forms.GroupBox
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents btnEE As System.Windows.Forms.Button
    Friend WithEvents btnKK As System.Windows.Forms.Button
    Friend WithEvents btnKE As System.Windows.Forms.Button
    Friend WithEvents btnAIRecognition As System.Windows.Forms.Button
    Friend WithEvents btnAISpeech As System.Windows.Forms.Button
    Friend WithEvents btnEK As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents listEWord As System.Windows.Forms.ListBox
    Friend WithEvents txtDefinition As System.Windows.Forms.TextBox
    Friend WithEvents btnSpeak As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents tbSpeakRate As System.Windows.Forms.TrackBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblMyNote As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents cboWord As System.Windows.Forms.ComboBox
    Friend WithEvents btnNote As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerTime As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents wbDisplay As System.Windows.Forms.WebBrowser
End Class
