<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AIEE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIEE))
        Me.tbSpeakRate = New System.Windows.Forms.TrackBar
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnSpeak = New System.Windows.Forms.Button
        Me.txtDefinition = New System.Windows.Forms.TextBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.pbBanner = New System.Windows.Forms.PictureBox
        Me.listEWord = New System.Windows.Forms.ListBox
        Me.btnNew = New System.Windows.Forms.Button
        CType(Me.tbSpeakRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSpeakRate
        '
        Me.tbSpeakRate.AutoSize = False
        Me.tbSpeakRate.Location = New System.Drawing.Point(341, 68)
        Me.tbSpeakRate.Minimum = -10
        Me.tbSpeakRate.Name = "tbSpeakRate"
        Me.tbSpeakRate.Size = New System.Drawing.Size(121, 29)
        Me.tbSpeakRate.TabIndex = 135
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = Global.AI_Dictionary.My.Resources.Resources.Search
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(216, 72)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(25, 25)
        Me.btnSearch.TabIndex = 133
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSpeak
        '
        Me.btnSpeak.BackColor = System.Drawing.Color.Transparent
        Me.btnSpeak.BackgroundImage = CType(resources.GetObject("btnSpeak.BackgroundImage"), System.Drawing.Image)
        Me.btnSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSpeak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSpeak.FlatAppearance.BorderSize = 0
        Me.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeak.Location = New System.Drawing.Point(306, 70)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(25, 25)
        Me.btnSpeak.TabIndex = 132
        Me.btnSpeak.UseVisualStyleBackColor = False
        '
        'txtDefinition
        '
        Me.txtDefinition.Font = New System.Drawing.Font("Khmer OS System", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefinition.Location = New System.Drawing.Point(218, 101)
        Me.txtDefinition.Multiline = True
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.ReadOnly = True
        Me.txtDefinition.Size = New System.Drawing.Size(505, 404)
        Me.txtDefinition.TabIndex = 130
        Me.txtDefinition.Text = "សាកលវិទ្យាល័យភូមិន្ទភ្នំពេញ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    ដេប៉ាតឺម៉ង់ ព័ត៌មានវិទ្យា" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Artificial In" & _
            "telligence"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 73)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 129
        '
        'pbBanner
        '
        Me.pbBanner.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pbBanner.BackgroundImage = Global.AI_Dictionary.My.Resources.Resources.b_EE
        Me.pbBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBanner.Location = New System.Drawing.Point(1, 1)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(732, 50)
        Me.pbBanner.TabIndex = 137
        Me.pbBanner.TabStop = False
        Me.pbBanner.Tag = ""
        '
        'listEWord
        '
        Me.listEWord.Font = New System.Drawing.Font("Khmer OS System", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listEWord.FormattingEnabled = True
        Me.listEWord.ItemHeight = 24
        Me.listEWord.Location = New System.Drawing.Point(12, 101)
        Me.listEWord.Name = "listEWord"
        Me.listEWord.Size = New System.Drawing.Size(200, 388)
        Me.listEWord.TabIndex = 138
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Khmer OS System", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Blue
        Me.btnNew.Location = New System.Drawing.Point(641, 64)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(81, 31)
        Me.btnNew.TabIndex = 139
        Me.btnNew.Text = "បញ្ចូលពក្យថ្មី"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'AIEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.listEWord)
        Me.Controls.Add(Me.pbBanner)
        Me.Controls.Add(Me.tbSpeakRate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.txtDefinition)
        Me.Controls.Add(Me.txtSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AIEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIEE"
        CType(Me.tbSpeakRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSpeakRate As System.Windows.Forms.TrackBar
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSpeak As System.Windows.Forms.Button
    Friend WithEvents txtDefinition As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
    Friend WithEvents listEWord As System.Windows.Forms.ListBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
