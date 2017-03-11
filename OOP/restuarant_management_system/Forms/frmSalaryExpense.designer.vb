<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalaryExpense
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMessage = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTotalExpense = New System.Windows.Forms.TextBox
        Me.dgEmployeeList = New System.Windows.Forms.DataGridView
        Me.dgID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgGender = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgBirthdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgPosition = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgBaseSalary = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgBonusFine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgTotalSalary = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtExpenseID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.txtShow = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFilter = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtDate = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salaries Expense"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 511)
        Me.Panel1.TabIndex = 1
        '
        'lblMessage
        '
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(24, 471)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(674, 13)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Restaurant.My.Resources.Resources.bottom
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(800, 462)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Restaurant.My.Resources.Resources.btndelete1
        Me.btnDelete.Location = New System.Drawing.Point(41, 462)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Restaurant.My.Resources.Resources.btnedit
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(122, 462)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Image = Global.Restaurant.My.Resources.Resources.btnsave
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(704, 462)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(74, 30)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&OK"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTotalExpense)
        Me.GroupBox2.Controls.Add(Me.dgEmployeeList)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 343)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(578, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Salary Expense"
        '
        'txtTotalExpense
        '
        Me.txtTotalExpense.Location = New System.Drawing.Point(691, 316)
        Me.txtTotalExpense.Name = "txtTotalExpense"
        Me.txtTotalExpense.Size = New System.Drawing.Size(171, 20)
        Me.txtTotalExpense.TabIndex = 1
        '
        'dgEmployeeList
        '
        Me.dgEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmployeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgID, Me.dgName, Me.dgGender, Me.dgBirthdate, Me.dgPosition, Me.dgBaseSalary, Me.dgBonusFine, Me.dgTotalSalary})
        Me.dgEmployeeList.Location = New System.Drawing.Point(11, 29)
        Me.dgEmployeeList.Name = "dgEmployeeList"
        Me.dgEmployeeList.Size = New System.Drawing.Size(851, 281)
        Me.dgEmployeeList.TabIndex = 0
        '
        'dgID
        '
        Me.dgID.HeaderText = "ID"
        Me.dgID.Name = "dgID"
        '
        'dgName
        '
        Me.dgName.HeaderText = "Name"
        Me.dgName.Name = "dgName"
        Me.dgName.ReadOnly = True
        '
        'dgGender
        '
        Me.dgGender.HeaderText = "Gender"
        Me.dgGender.Name = "dgGender"
        Me.dgGender.ReadOnly = True
        '
        'dgBirthdate
        '
        Me.dgBirthdate.HeaderText = "Birthdate"
        Me.dgBirthdate.Name = "dgBirthdate"
        Me.dgBirthdate.ReadOnly = True
        '
        'dgPosition
        '
        Me.dgPosition.HeaderText = "Position"
        Me.dgPosition.Name = "dgPosition"
        Me.dgPosition.ReadOnly = True
        '
        'dgBaseSalary
        '
        Me.dgBaseSalary.HeaderText = "Base Salary"
        Me.dgBaseSalary.Name = "dgBaseSalary"
        '
        'dgBonusFine
        '
        Me.dgBonusFine.HeaderText = "Bonus/Fine"
        Me.dgBonusFine.Name = "dgBonusFine"
        '
        'dgTotalSalary
        '
        Me.dgTotalSalary.HeaderText = "Total Salary"
        Me.dgTotalSalary.Name = "dgTotalSalary"
        Me.dgTotalSalary.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExpenseID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.txtShow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboFilter)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtDate)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Data"
        '
        'txtExpenseID
        '
        Me.txtExpenseID.Location = New System.Drawing.Point(84, 20)
        Me.txtExpenseID.Name = "txtExpenseID"
        Me.txtExpenseID.Size = New System.Drawing.Size(138, 20)
        Me.txtExpenseID.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Expense ID:"
        '
        'btnShow
        '
        Me.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShow.Image = Global.Restaurant.My.Resources.Resources.preview
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(744, 16)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 30)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "&Show"
        Me.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShow.UseVisualStyleBackColor = True
        Me.btnShow.Visible = False
        '
        'txtShow
        '
        Me.txtShow.Location = New System.Drawing.Point(570, 20)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(147, 20)
        Me.txtShow.TabIndex = 5
        Me.txtShow.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Filter:"
        Me.Label3.Visible = False
        '
        'cboFilter
        '
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Location = New System.Drawing.Point(431, 20)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(121, 21)
        Me.cboFilter.TabIndex = 3
        Me.cboFilter.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date:"
        '
        'dtDate
        '
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(268, 21)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(102, 20)
        Me.dtDate.TabIndex = 1
        '
        'frmSalaryExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(919, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSalaryExpense"
        Me.Text = "Salary Expense"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgEmployeeList As System.Windows.Forms.DataGridView
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtShow As System.Windows.Forms.TextBox
    Friend WithEvents dgID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgGender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBirthdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgPosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBaseSalary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgBonusFine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgTotalSalary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalExpense As System.Windows.Forms.TextBox
    Friend WithEvents txtExpenseID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
