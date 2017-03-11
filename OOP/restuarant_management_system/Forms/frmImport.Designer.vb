<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtImportID = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtImportDate = New System.Windows.Forms.DateTimePicker
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lvFoodDrink = New System.Windows.Forms.ListView
        Me.lvcFoodDrinkID = New System.Windows.Forms.ColumnHeader
        Me.lvcFDName = New System.Windows.Forms.ColumnHeader
        Me.lvcTypeName = New System.Windows.Forms.ColumnHeader
        Me.lvcSalePrice = New System.Windows.Forms.ColumnHeader
        Me.lvcDescription = New System.Windows.Forms.ColumnHeader
        Me.lvcTypeID = New System.Windows.Forms.ColumnHeader
        Me.lvcTypeValue = New System.Windows.Forms.ColumnHeader
        Me.lvcQty = New System.Windows.Forms.ColumnHeader
        Me.lvcAmount = New System.Windows.Forms.ColumnHeader
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtQTy = New System.Windows.Forms.TextBox
        Me.btnProBrowse = New System.Windows.Forms.Button
        Me.cboTypeName = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.cboProductName = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboProductID = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboTypeValue = New System.Windows.Forms.ComboBox
        Me.cboTypeID = New System.Windows.Forms.ComboBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboSupplierName = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboSupplierID = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.txtImportID)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.dtImportDate)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(28, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 511)
        Me.Panel1.TabIndex = 0
        '
        'txtImportID
        '
        Me.txtImportID.BackColor = System.Drawing.SystemColors.Window
        Me.txtImportID.Location = New System.Drawing.Point(308, 50)
        Me.txtImportID.Name = "txtImportID"
        Me.txtImportID.ReadOnly = True
        Me.txtImportID.Size = New System.Drawing.Size(180, 20)
        Me.txtImportID.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(248, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Import ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(43, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Date:"
        '
        'dtImportDate
        '
        Me.dtImportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtImportDate.Location = New System.Drawing.Point(101, 49)
        Me.dtImportDate.Name = "dtImportDate"
        Me.dtImportDate.Size = New System.Drawing.Size(126, 20)
        Me.dtImportDate.TabIndex = 28
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Restaurant.My.Resources.Resources.l_del
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(728, 470)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lvFoodDrink)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(809, 188)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product List"
        '
        'lvFoodDrink
        '
        Me.lvFoodDrink.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcFoodDrinkID, Me.lvcFDName, Me.lvcTypeName, Me.lvcSalePrice, Me.lvcDescription, Me.lvcTypeID, Me.lvcTypeValue, Me.lvcQty, Me.lvcAmount})
        Me.lvFoodDrink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFoodDrink.FullRowSelect = True
        Me.lvFoodDrink.GridLines = True
        Me.lvFoodDrink.Location = New System.Drawing.Point(24, 17)
        Me.lvFoodDrink.Name = "lvFoodDrink"
        Me.lvFoodDrink.Size = New System.Drawing.Size(758, 160)
        Me.lvFoodDrink.TabIndex = 1
        Me.lvFoodDrink.UseCompatibleStateImageBehavior = False
        Me.lvFoodDrink.View = System.Windows.Forms.View.Details
        '
        'lvcFoodDrinkID
        '
        Me.lvcFoodDrinkID.Text = "ID"
        Me.lvcFoodDrinkID.Width = 70
        '
        'lvcFDName
        '
        Me.lvcFDName.Text = "Product Name"
        Me.lvcFDName.Width = 160
        '
        'lvcTypeName
        '
        Me.lvcTypeName.Text = "Type Name"
        Me.lvcTypeName.Width = 100
        '
        'lvcSalePrice
        '
        Me.lvcSalePrice.Text = "Cost"
        Me.lvcSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvcSalePrice.Width = 70
        '
        'lvcDescription
        '
        Me.lvcDescription.Text = "Description"
        Me.lvcDescription.Width = 150
        '
        'lvcTypeID
        '
        Me.lvcTypeID.Text = "TypeID"
        Me.lvcTypeID.Width = 0
        '
        'lvcTypeValue
        '
        Me.lvcTypeValue.Text = "Type Value"
        Me.lvcTypeValue.Width = 0
        '
        'lvcQty
        '
        Me.lvcQty.Text = "Quantity"
        Me.lvcQty.Width = 91
        '
        'lvcAmount
        '
        Me.lvcAmount.Text = "Amount"
        Me.lvcAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvcAmount.Width = 100
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Restaurant.My.Resources.Resources.MenuBar_Plus
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(623, 470)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboSupplierName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboSupplierID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(794, 195)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Information"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(262, 22)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(19, 51)
        Me.btnBrowse.TabIndex = 25
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Restaurant.My.Resources.Resources.l_del
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(601, 120)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Restaurant.My.Resources.Resources.Update
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(601, 154)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.Restaurant.My.Resources.Resources.MenuBar_Plus
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(601, 86)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 30)
        Me.btnInsert.TabIndex = 22
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtQTy)
        Me.GroupBox2.Controls.Add(Me.btnProBrowse)
        Me.GroupBox2.Controls.Add(Me.cboTypeName)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.cboProductName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboProductID)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboTypeValue)
        Me.GroupBox2.Controls.Add(Me.cboTypeID)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 111)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Information"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(276, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Quantity"
        '
        'txtQTy
        '
        Me.txtQTy.Location = New System.Drawing.Point(344, 76)
        Me.txtQTy.Name = "txtQTy"
        Me.txtQTy.Size = New System.Drawing.Size(136, 20)
        Me.txtQTy.TabIndex = 30
        '
        'btnProBrowse
        '
        Me.btnProBrowse.Location = New System.Drawing.Point(255, 18)
        Me.btnProBrowse.Name = "btnProBrowse"
        Me.btnProBrowse.Size = New System.Drawing.Size(19, 51)
        Me.btnProBrowse.TabIndex = 26
        Me.btnProBrowse.Text = "..."
        Me.btnProBrowse.UseVisualStyleBackColor = True
        '
        'cboTypeName
        '
        Me.cboTypeName.FormattingEnabled = True
        Me.cboTypeName.Location = New System.Drawing.Point(344, 19)
        Me.cboTypeName.Name = "cboTypeName"
        Me.cboTypeName.Size = New System.Drawing.Size(136, 21)
        Me.cboTypeName.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(276, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Unit Cost"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(344, 49)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(136, 20)
        Me.txtUnitPrice.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(276, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Type:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(82, 75)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(167, 20)
        Me.txtDescription.TabIndex = 22
        '
        'cboProductName
        '
        Me.cboProductName.FormattingEnabled = True
        Me.cboProductName.Location = New System.Drawing.Point(82, 48)
        Me.cboProductName.Name = "cboProductName"
        Me.cboProductName.Size = New System.Drawing.Size(167, 21)
        Me.cboProductName.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Name:"
        '
        'cboProductID
        '
        Me.cboProductID.FormattingEnabled = True
        Me.cboProductID.Location = New System.Drawing.Point(82, 19)
        Me.cboProductID.Name = "cboProductID"
        Me.cboProductID.Size = New System.Drawing.Size(167, 21)
        Me.cboProductID.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ID:"
        '
        'cboTypeValue
        '
        Me.cboTypeValue.FormattingEnabled = True
        Me.cboTypeValue.Location = New System.Drawing.Point(316, 19)
        Me.cboTypeValue.Name = "cboTypeValue"
        Me.cboTypeValue.Size = New System.Drawing.Size(136, 21)
        Me.cboTypeValue.TabIndex = 29
        Me.cboTypeValue.Visible = False
        '
        'cboTypeID
        '
        Me.cboTypeID.FormattingEnabled = True
        Me.cboTypeID.Location = New System.Drawing.Point(403, 19)
        Me.cboTypeID.Name = "cboTypeID"
        Me.cboTypeID.Size = New System.Drawing.Size(136, 21)
        Me.cboTypeID.TabIndex = 28
        Me.cboTypeID.Visible = False
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Location = New System.Drawing.Point(601, 51)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(180, 20)
        Me.txtAddress.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(541, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Location = New System.Drawing.Point(601, 22)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(541, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "E-mail"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone.Location = New System.Drawing.Point(343, 51)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(180, 20)
        Me.txtPhone.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Phone:"
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompany.Location = New System.Drawing.Point(343, 22)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(180, 20)
        Me.txtCompany.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Company:"
        '
        'cboSupplierName
        '
        Me.cboSupplierName.FormattingEnabled = True
        Me.cboSupplierName.Location = New System.Drawing.Point(92, 51)
        Me.cboSupplierName.Name = "cboSupplierName"
        Me.cboSupplierName.Size = New System.Drawing.Size(167, 21)
        Me.cboSupplierName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'cboSupplierID
        '
        Me.cboSupplierID.FormattingEnabled = True
        Me.cboSupplierID.Location = New System.Drawing.Point(92, 22)
        Me.cboSupplierID.Name = "cboSupplierID"
        Me.cboSupplierID.Size = New System.Drawing.Size(167, 21)
        Me.cboSupplierID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Imports"
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmImport"
        Me.Text = "Import Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSupplierID As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboProductName As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboProductID As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboTypeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents lvFoodDrink As System.Windows.Forms.ListView
    Friend WithEvents lvcFoodDrinkID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcFDName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcSalePrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcTypeID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcTypeValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnProBrowse As System.Windows.Forms.Button
    Friend WithEvents cboTypeValue As System.Windows.Forms.ComboBox
    Friend WithEvents cboTypeID As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtQTy As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtImportDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtImportID As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
