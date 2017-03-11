<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItems
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.txtFilter = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboFilter = New System.Windows.Forms.ComboBox
        Me.lstFoodDrink = New System.Windows.Forms.ListView
        Me.lvcFoodDrinkID = New System.Windows.Forms.ColumnHeader
        Me.lvcFDName = New System.Windows.Forms.ColumnHeader
        Me.lvcTypeName = New System.Windows.Forms.ColumnHeader
        Me.lvcSalePrice = New System.Windows.Forms.ColumnHeader
        Me.lvcDescription = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnShowProductCost = New System.Windows.Forms.Button
        Me.btnBrowType = New System.Windows.Forms.Button
        Me.cboTypeName = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFoodDrinkName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFoodDrinkID = New System.Windows.Forms.TextBox
        Me.txtTypeValue = New System.Windows.Forms.TextBox
        Me.txtTypeID = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food and Drink"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTypeValue)
        Me.Panel1.Controls.Add(Me.txtTypeID)
        Me.Panel1.Location = New System.Drawing.Point(29, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 483)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnShow)
        Me.GroupBox2.Controls.Add(Me.txtFilter)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboFilter)
        Me.GroupBox2.Controls.Add(Me.lstFoodDrink)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(691, 274)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Food Drink List"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(178, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Label8"
        '
        'btnShow
        '
        Me.btnShow.Image = Global.Restaurant.My.Resources.Resources.preview
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(384, 18)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 30)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "&Show"
        Me.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.BackColor = System.Drawing.SystemColors.Window
        Me.txtFilter.Location = New System.Drawing.Point(269, 24)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(106, 20)
        Me.txtFilter.TabIndex = 3
        Me.txtFilter.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Filter:"
        '
        'cboFilter
        '
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Items.AddRange(New Object() {"All", "Food Drink ID", "Food Drink Name", "Type", "Sale Price", "Description"})
        Me.cboFilter.Location = New System.Drawing.Point(51, 24)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(121, 21)
        Me.cboFilter.TabIndex = 1
        '
        'lstFoodDrink
        '
        Me.lstFoodDrink.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcFoodDrinkID, Me.lvcFDName, Me.lvcTypeName, Me.lvcSalePrice, Me.lvcDescription})
        Me.lstFoodDrink.FullRowSelect = True
        Me.lstFoodDrink.GridLines = True
        Me.lstFoodDrink.Location = New System.Drawing.Point(10, 57)
        Me.lstFoodDrink.MultiSelect = False
        Me.lstFoodDrink.Name = "lstFoodDrink"
        Me.lstFoodDrink.Size = New System.Drawing.Size(670, 216)
        Me.lstFoodDrink.TabIndex = 0
        Me.lstFoodDrink.UseCompatibleStateImageBehavior = False
        Me.lstFoodDrink.View = System.Windows.Forms.View.Details
        '
        'lvcFoodDrinkID
        '
        Me.lvcFoodDrinkID.Text = "ID"
        Me.lvcFoodDrinkID.Width = 70
        '
        'lvcFDName
        '
        Me.lvcFDName.Text = "F-D-Name"
        Me.lvcFDName.Width = 160
        '
        'lvcTypeName
        '
        Me.lvcTypeName.Text = "Type Name"
        Me.lvcTypeName.Width = 100
        '
        'lvcSalePrice
        '
        Me.lvcSalePrice.Text = "Sale Price"
        Me.lvcSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvcSalePrice.Width = 70
        '
        'lvcDescription
        '
        Me.lvcDescription.Text = "Description"
        Me.lvcDescription.Width = 250
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnInsert)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnShowProductCost)
        Me.GroupBox1.Controls.Add(Me.btnBrowType)
        Me.GroupBox1.Controls.Add(Me.cboTypeName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFoodDrinkName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFoodDrinkID)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 155)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Food Drink Infomation"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Restaurant.My.Resources.Resources.l_del
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(595, 80)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.Restaurant.My.Resources.Resources.Update
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(595, 114)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Image = Global.Restaurant.My.Resources.Resources.MenuBar_Plus
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(595, 46)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 30)
        Me.btnInsert.TabIndex = 26
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = Global.Restaurant.My.Resources.Resources.btnnew
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(595, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 30)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "&New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnShowProductCost
        '
        Me.btnShowProductCost.Location = New System.Drawing.Point(516, 46)
        Me.btnShowProductCost.Name = "btnShowProductCost"
        Me.btnShowProductCost.Size = New System.Drawing.Size(31, 23)
        Me.btnShowProductCost.TabIndex = 22
        Me.btnShowProductCost.Text = "..."
        Me.btnShowProductCost.UseVisualStyleBackColor = True
        '
        'btnBrowType
        '
        Me.btnBrowType.Location = New System.Drawing.Point(516, 17)
        Me.btnBrowType.Name = "btnBrowType"
        Me.btnBrowType.Size = New System.Drawing.Size(31, 23)
        Me.btnBrowType.TabIndex = 12
        Me.btnBrowType.Text = "..."
        Me.btnBrowType.UseVisualStyleBackColor = True
        '
        'cboTypeName
        '
        Me.cboTypeName.FormattingEnabled = True
        Me.cboTypeName.Location = New System.Drawing.Point(374, 18)
        Me.cboTypeName.Name = "cboTypeName"
        Me.cboTypeName.Size = New System.Drawing.Size(136, 21)
        Me.cboTypeName.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sale Price:"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(374, 48)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(136, 20)
        Me.txtUnitPrice.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(110, 79)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(437, 20)
        Me.txtDescription.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Food Drink Name:"
        '
        'txtFoodDrinkName
        '
        Me.txtFoodDrinkName.Location = New System.Drawing.Point(110, 49)
        Me.txtFoodDrinkName.Name = "txtFoodDrinkName"
        Me.txtFoodDrinkName.Size = New System.Drawing.Size(182, 20)
        Me.txtFoodDrinkName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Food Drink ID:"
        '
        'txtFoodDrinkID
        '
        Me.txtFoodDrinkID.BackColor = System.Drawing.SystemColors.Window
        Me.txtFoodDrinkID.Location = New System.Drawing.Point(110, 19)
        Me.txtFoodDrinkID.Name = "txtFoodDrinkID"
        Me.txtFoodDrinkID.ReadOnly = True
        Me.txtFoodDrinkID.Size = New System.Drawing.Size(182, 20)
        Me.txtFoodDrinkID.TabIndex = 0
        Me.txtFoodDrinkID.TabStop = False
        '
        'txtTypeValue
        '
        Me.txtTypeValue.Location = New System.Drawing.Point(601, 12)
        Me.txtTypeValue.Name = "txtTypeValue"
        Me.txtTypeValue.Size = New System.Drawing.Size(138, 20)
        Me.txtTypeValue.TabIndex = 21
        Me.txtTypeValue.Visible = False
        '
        'txtTypeID
        '
        Me.txtTypeID.Location = New System.Drawing.Point(159, 12)
        Me.txtTypeID.Name = "txtTypeID"
        Me.txtTypeID.Size = New System.Drawing.Size(138, 20)
        Me.txtTypeID.TabIndex = 11
        Me.txtTypeID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.Restaurant.My.Resources.Resources.bottom
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(724, 516)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(828, 533)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmItems"
        Me.Text = "Food and Drink"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFoodDrinkName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFoodDrinkID As System.Windows.Forms.TextBox
    Friend WithEvents cboTypeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowType As System.Windows.Forms.Button
    Friend WithEvents txtTypeID As System.Windows.Forms.TextBox
    Friend WithEvents lstFoodDrink As System.Windows.Forms.ListView
    Friend WithEvents btnShowProductCost As System.Windows.Forms.Button
    Friend WithEvents txtTypeValue As System.Windows.Forms.TextBox
    Friend WithEvents lvcFoodDrinkID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcFDName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcSalePrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcTypeName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
