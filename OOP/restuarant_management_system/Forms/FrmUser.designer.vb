<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtFullName = New System.Windows.Forms.TextBox
        Me.txtUserPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstUser = New System.Windows.Forms.ListView
        Me.lvcUserID = New System.Windows.Forms.ColumnHeader
        Me.lvcUserName = New System.Windows.Forms.ColumnHeader
        Me.lvcUserFullName = New System.Windows.Forms.ColumnHeader
        Me.lvcPermision = New System.Windows.Forms.ColumnHeader
        Me.lvcPassword = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radAdmin = New System.Windows.Forms.RadioButton
        Me.radStockKeeper = New System.Windows.Forms.RadioButton
        Me.radUser = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Account"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(120, 84)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(209, 20)
        Me.txtUserName.TabIndex = 1
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(120, 110)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(209, 20)
        Me.txtFullName.TabIndex = 2
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(120, 136)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPassword.Size = New System.Drawing.Size(209, 20)
        Me.txtUserPassword.TabIndex = 3
        Me.txtUserPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name Login:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User Full Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "User Password"
        '
        'lstUser
        '
        Me.lstUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcUserID, Me.lvcUserName, Me.lvcUserFullName, Me.lvcPermision, Me.lvcPassword})
        Me.lstUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUser.FullRowSelect = True
        Me.lstUser.GridLines = True
        Me.lstUser.Location = New System.Drawing.Point(21, 241)
        Me.lstUser.MultiSelect = False
        Me.lstUser.Name = "lstUser"
        Me.lstUser.Size = New System.Drawing.Size(445, 161)
        Me.lstUser.TabIndex = 7
        Me.lstUser.UseCompatibleStateImageBehavior = False
        Me.lstUser.View = System.Windows.Forms.View.Details
        '
        'lvcUserID
        '
        Me.lvcUserID.Text = "User ID"
        '
        'lvcUserName
        '
        Me.lvcUserName.Text = "User Name"
        Me.lvcUserName.Width = 120
        '
        'lvcUserFullName
        '
        Me.lvcUserFullName.Text = "User Full Name"
        Me.lvcUserFullName.Width = 150
        '
        'lvcPermision
        '
        Me.lvcPermision.Text = "Permision"
        Me.lvcPermision.Width = 100
        '
        'lvcPassword
        '
        Me.lvcPassword.Text = "Password"
        Me.lvcPassword.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radAdmin)
        Me.GroupBox1.Controls.Add(Me.radStockKeeper)
        Me.GroupBox1.Controls.Add(Me.radUser)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 47)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Permision"
        '
        'radAdmin
        '
        Me.radAdmin.AutoSize = True
        Me.radAdmin.Location = New System.Drawing.Point(212, 19)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(54, 17)
        Me.radAdmin.TabIndex = 2
        Me.radAdmin.TabStop = True
        Me.radAdmin.Text = "Admin"
        Me.radAdmin.UseVisualStyleBackColor = True
        '
        'radStockKeeper
        '
        Me.radStockKeeper.AutoSize = True
        Me.radStockKeeper.Location = New System.Drawing.Point(107, 19)
        Me.radStockKeeper.Name = "radStockKeeper"
        Me.radStockKeeper.Size = New System.Drawing.Size(90, 17)
        Me.radStockKeeper.TabIndex = 1
        Me.radStockKeeper.TabStop = True
        Me.radStockKeeper.Text = "Stock Keeper"
        Me.radStockKeeper.UseVisualStyleBackColor = True
        '
        'radUser
        '
        Me.radUser.AutoSize = True
        Me.radUser.Location = New System.Drawing.Point(28, 19)
        Me.radUser.Name = "radUser"
        Me.radUser.Size = New System.Drawing.Size(47, 17)
        Me.radUser.TabIndex = 0
        Me.radUser.TabStop = True
        Me.radUser.Text = "User"
        Me.radUser.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtUserID)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnInsert)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lstUser)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUserPassword)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Location = New System.Drawing.Point(49, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 416)
        Me.Panel1.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "User ID:"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserID.Location = New System.Drawing.Point(120, 58)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(209, 20)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Restaurant.My.Resources.Resources.l_del
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(391, 120)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.Restaurant.My.Resources.Resources.Update
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(391, 156)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.Restaurant.My.Resources.Resources.MenuBar_Plus
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(391, 87)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 30)
        Me.btnInsert.TabIndex = 6
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = Global.Restaurant.My.Resources.Resources.btnnew
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(391, 55)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 30)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "&New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Restaurant.My.Resources.Resources.bottom
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(467, 420)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 451)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmUser"
        Me.Text = "User Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstUser As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents radStockKeeper As System.Windows.Forms.RadioButton
    Friend WithEvents radUser As System.Windows.Forms.RadioButton
    Friend WithEvents lvcUserName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcUserFullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcPassword As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcPermision As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lvcUserID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
