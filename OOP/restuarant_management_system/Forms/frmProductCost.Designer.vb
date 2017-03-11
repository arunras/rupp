<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductCost
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
        Me.lvProduct = New System.Windows.Forms.ListView
        Me.lvcProductID = New System.Windows.Forms.ColumnHeader
        Me.lvcProductName = New System.Windows.Forms.ColumnHeader
        Me.lvcType = New System.Windows.Forms.ColumnHeader
        Me.lvcCost = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvProduct
        '
        Me.lvProduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvcProductID, Me.lvcProductName, Me.lvcType, Me.lvcCost})
        Me.lvProduct.GridLines = True
        Me.lvProduct.Location = New System.Drawing.Point(51, 45)
        Me.lvProduct.Name = "lvProduct"
        Me.lvProduct.Size = New System.Drawing.Size(605, 331)
        Me.lvProduct.TabIndex = 4
        Me.lvProduct.UseCompatibleStateImageBehavior = False
        Me.lvProduct.View = System.Windows.Forms.View.Details
        '
        'lvcProductID
        '
        Me.lvcProductID.Text = "ID"
        Me.lvcProductID.Width = 100
        '
        'lvcProductName
        '
        Me.lvcProductName.Text = "Product Name"
        Me.lvcProductName.Width = 200
        '
        'lvcType
        '
        Me.lvcType.Text = "Type"
        Me.lvcType.Width = 150
        '
        'lvcCost
        '
        Me.lvcCost.Text = "Cost"
        Me.lvcCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lvcCost.Width = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Product Cost"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(94, 397)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(392, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "When you see the product cost you have imported, you can set its price for sold.." & _
            "."
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Restaurant.My.Resources.Resources.close_d
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(532, 392)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmProductCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 463)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProductCost"
        Me.Text = "Product Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvProduct As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvcProductID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcProductName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcType As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvcCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
