<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSales
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPay = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lvFoodDrinkOrder = New System.Windows.Forms.ListView
        Me.lvcTable = New System.Windows.Forms.ColumnHeader
        Me.lvcFoodDrinkID = New System.Windows.Forms.ColumnHeader
        Me.lvcFoodDrinkName = New System.Windows.Forms.ColumnHeader
        Me.lvcUnitPrice = New System.Windows.Forms.ColumnHeader
        Me.lvcQuantity = New System.Windows.Forms.ColumnHeader
        Me.lvcAmount = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cboSaleIDList = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSaleID = New System.Windows.Forms.TextBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboQty = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboTableNumber = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboFoodDrinkName = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFoodDrinkID = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbotypeName = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 519)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnPay)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(57, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(754, 318)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Sale"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Restaurant.My.Resources.Resources.bottom
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(645, 281)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Image = Global.Restaurant.My.Resources.Resources.Today
        Me.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPay.Location = New System.Drawing.Point(472, 281)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 30)
        Me.btnPay.TabIndex = 11
        Me.btnPay.Text = "&Pay"
        Me.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.lvFoodDrinkOrder)
        Me.GroupBox4.Location = New System.Drawing.Point(176, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 263)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Food Drink Order:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalAmount.Location = New System.Drawing.Point(381, 233)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(163, 20)
        Me.txtTotalAmount.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(291, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total Amount:"
        '
        'lvFoodDrinkOrder
        '
        Me.lvFoodDrinkOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcTable, Me.lvcFoodDrinkID, Me.lvcFoodDrinkName, Me.lvcUnitPrice, Me.lvcQuantity, Me.lvcAmount})
        Me.lvFoodDrinkOrder.FullRowSelect = True
        Me.lvFoodDrinkOrder.GridLines = True
        Me.lvFoodDrinkOrder.Location = New System.Drawing.Point(14, 19)
        Me.lvFoodDrinkOrder.Name = "lvFoodDrinkOrder"
        Me.lvFoodDrinkOrder.Size = New System.Drawing.Size(530, 211)
        Me.lvFoodDrinkOrder.TabIndex = 0
        Me.lvFoodDrinkOrder.UseCompatibleStateImageBehavior = False
        Me.lvFoodDrinkOrder.View = System.Windows.Forms.View.Details
        '
        'lvcTable
        '
        Me.lvcTable.Text = "No"
        '
        'lvcFoodDrinkID
        '
        Me.lvcFoodDrinkID.Text = "Food Drink ID"
        Me.lvcFoodDrinkID.Width = 100
        '
        'lvcFoodDrinkName
        '
        Me.lvcFoodDrinkName.Text = "Food Drink Name"
        Me.lvcFoodDrinkName.Width = 120
        '
        'lvcUnitPrice
        '
        Me.lvcUnitPrice.Text = "Unit Price"
        Me.lvcUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lvcQuantity
        '
        Me.lvcQuantity.Text = "Qty"
        Me.lvcQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvcAmount
        '
        Me.lvcAmount.Text = "Amount"
        Me.lvcAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvcAmount.Width = 100
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboSaleIDList)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(139, 272)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sale ID:"
        '
        'cboSaleIDList
        '
        Me.cboSaleIDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSaleIDList.FormattingEnabled = True
        Me.cboSaleIDList.Location = New System.Drawing.Point(12, 17)
        Me.cboSaleIDList.Name = "cboSaleIDList"
        Me.cboSaleIDList.Size = New System.Drawing.Size(116, 255)
        Me.cboSaleIDList.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbotypeName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSaleID)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboQty)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboTableNumber)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboFoodDrinkName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboFoodDrinkID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 141)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items"
        '
        'txtSaleID
        '
        Me.txtSaleID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSaleID.Location = New System.Drawing.Point(125, 23)
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.ReadOnly = True
        Me.txtSaleID.Size = New System.Drawing.Size(163, 20)
        Me.txtSaleID.TabIndex = 32
        '
        'btnNew
        '
        Me.btnNew.Image = Global.Restaurant.My.Resources.Resources.btnnew
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(646, 17)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 29)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "&New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Restaurant.My.Resources.Resources.l_del
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(646, 98)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.Restaurant.My.Resources.Resources.Update
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(516, 111)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.Restaurant.My.Resources.Resources.MenuBar_Plus
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(646, 55)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 30)
        Me.btnInsert.TabIndex = 29
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtUnitPrice.Location = New System.Drawing.Point(404, 52)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.ReadOnly = True
        Me.txtUnitPrice.Size = New System.Drawing.Size(163, 20)
        Me.txtUnitPrice.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Unit Price"
        '
        'cboQty
        '
        Me.cboQty.FormattingEnabled = True
        Me.cboQty.Location = New System.Drawing.Point(404, 82)
        Me.cboQty.Name = "cboQty"
        Me.cboQty.Size = New System.Drawing.Size(164, 21)
        Me.cboQty.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Quantity:"
        '
        'cboTableNumber
        '
        Me.cboTableNumber.FormattingEnabled = True
        Me.cboTableNumber.Location = New System.Drawing.Point(404, 22)
        Me.cboTableNumber.Name = "cboTableNumber"
        Me.cboTableNumber.Size = New System.Drawing.Size(164, 21)
        Me.cboTableNumber.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Table Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sale ID:"
        '
        'cboFoodDrinkName
        '
        Me.cboFoodDrinkName.FormattingEnabled = True
        Me.cboFoodDrinkName.Location = New System.Drawing.Point(125, 82)
        Me.cboFoodDrinkName.Name = "cboFoodDrinkName"
        Me.cboFoodDrinkName.Size = New System.Drawing.Size(164, 21)
        Me.cboFoodDrinkName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Food Drink Name:"
        '
        'cboFoodDrinkID
        '
        Me.cboFoodDrinkID.FormattingEnabled = True
        Me.cboFoodDrinkID.Location = New System.Drawing.Point(125, 52)
        Me.cboFoodDrinkID.Name = "cboFoodDrinkID"
        Me.cboFoodDrinkID.Size = New System.Drawing.Size(164, 21)
        Me.cboFoodDrinkID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Food Drink ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food and Drinks Sale"
        '
        'cbotypeName
        '
        Me.cbotypeName.FormattingEnabled = True
        Me.cbotypeName.Location = New System.Drawing.Point(125, 112)
        Me.cbotypeName.Name = "cbotypeName"
        Me.cbotypeName.Size = New System.Drawing.Size(164, 21)
        Me.cbotypeName.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Type Name"
        '
        'FrmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSales"
        Me.Text = "Food and Drink Sale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboFoodDrinkName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFoodDrinkID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboQty As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboTableNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSaleIDList As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lvFoodDrinkOrder As System.Windows.Forms.ListView
    Friend WithEvents lvcTable As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcFoodDrinkID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcFoodDrinkName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcUnitPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtSaleID As System.Windows.Forms.TextBox
    Friend WithEvents cbotypeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
