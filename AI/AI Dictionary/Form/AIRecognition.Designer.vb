<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AIRecognition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIRecognition))
        Me.gbRecMenu = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.txtRecorder = New System.Windows.Forms.TextBox
        Me.pbBanner = New System.Windows.Forms.PictureBox
        Me.SaveFileDialogText = New System.Windows.Forms.SaveFileDialog
        Me.gbRecMenu.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRecMenu
        '
        Me.gbRecMenu.Controls.Add(Me.btnSave)
        Me.gbRecMenu.Controls.Add(Me.btnStop)
        Me.gbRecMenu.Controls.Add(Me.btnStart)
        Me.gbRecMenu.Location = New System.Drawing.Point(1, 44)
        Me.gbRecMenu.Name = "gbRecMenu"
        Me.gbRecMenu.Size = New System.Drawing.Size(732, 56)
        Me.gbRecMenu.TabIndex = 1
        Me.gbRecMenu.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = Global.AI_Dictionary.My.Resources.Resources.save_button
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(621, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 45)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "រក្សាទុក"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.Location = New System.Drawing.Point(132, 9)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(111, 45)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = " ឈប់"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStart.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(15, 9)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(111, 45)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "ផ្តើម"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtRecorder
        '
        Me.txtRecorder.BackColor = System.Drawing.Color.Black
        Me.txtRecorder.ForeColor = System.Drawing.Color.Lime
        Me.txtRecorder.Location = New System.Drawing.Point(12, 104)
        Me.txtRecorder.Multiline = True
        Me.txtRecorder.Name = "txtRecorder"
        Me.txtRecorder.Size = New System.Drawing.Size(710, 396)
        Me.txtRecorder.TabIndex = 0
        '
        'pbBanner
        '
        Me.pbBanner.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pbBanner.BackgroundImage = Global.AI_Dictionary.My.Resources.Resources.b_Speech
        Me.pbBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBanner.Location = New System.Drawing.Point(1, 1)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(732, 50)
        Me.pbBanner.TabIndex = 2
        Me.pbBanner.TabStop = False
        Me.pbBanner.Tag = ""
        '
        'AIRecognition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 512)
        Me.Controls.Add(Me.pbBanner)
        Me.Controls.Add(Me.txtRecorder)
        Me.Controls.Add(Me.gbRecMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AIRecognition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIRecognition"
        Me.gbRecMenu.ResumeLayout(False)
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbRecMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtRecorder As System.Windows.Forms.TextBox
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialogText As System.Windows.Forms.SaveFileDialog
End Class
