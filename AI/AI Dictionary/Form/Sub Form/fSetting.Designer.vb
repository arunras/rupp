<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSetting))
        Me.gbSearchEngine = New System.Windows.Forms.GroupBox
        Me.pbLoading = New System.Windows.Forms.PictureBox
        Me.lblLoading = New System.Windows.Forms.Label
        Me.rbFilterSearch = New System.Windows.Forms.RadioButton
        Me.rbFastSearch = New System.Windows.Forms.RadioButton
        Me.lblRUPP = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbSearchEngine.SuspendLayout()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSearchEngine
        '
        Me.gbSearchEngine.Controls.Add(Me.pbLoading)
        Me.gbSearchEngine.Controls.Add(Me.lblLoading)
        Me.gbSearchEngine.Controls.Add(Me.rbFilterSearch)
        Me.gbSearchEngine.Controls.Add(Me.rbFastSearch)
        Me.gbSearchEngine.Location = New System.Drawing.Point(22, 50)
        Me.gbSearchEngine.Name = "gbSearchEngine"
        Me.gbSearchEngine.Size = New System.Drawing.Size(189, 115)
        Me.gbSearchEngine.TabIndex = 0
        Me.gbSearchEngine.TabStop = False
        Me.gbSearchEngine.Text = "រកពាក្យបែប"
        '
        'pbLoading
        '
        Me.pbLoading.BackColor = System.Drawing.Color.Transparent
        Me.pbLoading.Image = CType(resources.GetObject("pbLoading.Image"), System.Drawing.Image)
        Me.pbLoading.Location = New System.Drawing.Point(100, 2)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(60, 59)
        Me.pbLoading.TabIndex = 117
        Me.pbLoading.TabStop = False
        Me.pbLoading.Visible = False
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.ForeColor = System.Drawing.Color.Red
        Me.lblLoading.Location = New System.Drawing.Point(95, 26)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(16, 27)
        Me.lblLoading.TabIndex = 2
        Me.lblLoading.Text = " "
        '
        'rbFilterSearch
        '
        Me.rbFilterSearch.AutoSize = True
        Me.rbFilterSearch.Checked = True
        Me.rbFilterSearch.Location = New System.Drawing.Point(18, 61)
        Me.rbFilterSearch.Name = "rbFilterSearch"
        Me.rbFilterSearch.Size = New System.Drawing.Size(158, 31)
        Me.rbFilterSearch.TabIndex = 1
        Me.rbFilterSearch.TabStop = True
        Me.rbFilterSearch.Text = "រកដោយច្រោះពាក្យ"
        Me.rbFilterSearch.UseVisualStyleBackColor = True
        '
        'rbFastSearch
        '
        Me.rbFastSearch.AutoSize = True
        Me.rbFastSearch.Location = New System.Drawing.Point(18, 24)
        Me.rbFastSearch.Name = "rbFastSearch"
        Me.rbFastSearch.Size = New System.Drawing.Size(87, 31)
        Me.rbFastSearch.TabIndex = 0
        Me.rbFastSearch.Text = "រករហ័ស"
        Me.rbFastSearch.UseVisualStyleBackColor = True
        '
        'lblRUPP
        '
        Me.lblRUPP.AutoSize = True
        Me.lblRUPP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblRUPP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRUPP.Font = New System.Drawing.Font("Khmer OS Battambang", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUPP.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRUPP.Location = New System.Drawing.Point(0, 0)
        Me.lblRUPP.Name = "lblRUPP"
        Me.lblRUPP.Size = New System.Drawing.Size(237, 36)
        Me.lblRUPP.TabIndex = 109
        Me.lblRUPP.Text = "សាកលវិទ្យាល័យភូមិន្ទភ្នំពេញ"
        '
        'fSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 190)
        Me.Controls.Add(Me.lblRUPP)
        Me.Controls.Add(Me.gbSearchEngine)
        Me.Font = New System.Drawing.Font("Khmer OS System", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "fSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "កំណត់"
        Me.gbSearchEngine.ResumeLayout(False)
        Me.gbSearchEngine.PerformLayout()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSearchEngine As System.Windows.Forms.GroupBox
    Friend WithEvents rbFastSearch As System.Windows.Forms.RadioButton
    Friend WithEvents rbFilterSearch As System.Windows.Forms.RadioButton
    Friend WithEvents lblRUPP As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents pbLoading As System.Windows.Forms.PictureBox
End Class
