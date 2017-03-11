Public Class frmImport

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        frmSupplier.ShowDialog()

    End Sub

    Private Sub cboSupplierID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSupplierID.SelectedIndexChanged
        cboSupplierName.Text = cboSupplierName.Items(cboSupplierID.SelectedIndex)
        
    End Sub
    Sub SupplierInfo()
        Try
            Dim dr As OleDb.OleDbDataReader
            dr = _SQLReader("SELECT sup_company,sup_phone,sup_email,sup_address FROM tbl_suppliers WHERE sup_id=" & cboSupplierID.Text)
            If dr.HasRows Then
                While dr.Read
                    txtCompany.Text = dr(0).ToString
                    txtPhone.Text = dr(1).ToString
                    txtEmail.Text = dr(2).ToString
                    txtAddress.Text = dr(3).ToString
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub
    Private Sub cboSupplierName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSupplierName.SelectedIndexChanged
        cboSupplierID.Text = cboSupplierID.Items(cboSupplierName.SelectedIndex)
        SupplierInfo()
    End Sub

    Private Sub frmImport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _OpenConnection()
        txtImportID.Text = _AutoID("tbl_import", "imp_id")
        _FillCombobox("SELECT sup_id,sup_name FROM tbl_suppliers", cboSupplierID, cboSupplierName)
        _FillCombobox("SELECT ite_id,ite_name FROM tbl_items", cboProductID, cboProductName)
        _FillCombobox("SELECT typ_id,typ_name,typ_value FROM tbl_types", cboTypeID, cboTypeName, cboTypeValue)
    End Sub

    Private Sub btnProBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProBrowse.Click
        FrmItems.ShowDialog()
    End Sub

    Private Sub cboProductID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProductID.SelectedIndexChanged
        cboProductName.Text = cboProductName.Items(cboProductID.SelectedIndex)
        ReadItemDescription()

    End Sub

    Sub ReadItemDescription()
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader("SELECT ite_description FROM tbl_items WHERE ite_id=" & cboProductID.Text)
        If dr.HasRows Then
            While dr.Read
                txtDescription.Text = dr(0).ToString
            End While
        End If
    End Sub

    Private Sub cboProductName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProductName.SelectedIndexChanged
        cboProductID.Text = cboProductID.Items(cboProductName.SelectedIndex)
        ReadItemDescription()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If txtUnitPrice.Text.Trim <> "" And txtQTy.Text.Trim <> "" Then
            Dim row As Integer = lvFoodDrink.Items.Count - 1
            If row >= 0 Then
                For i As Integer = 0 To row
                    If cboProductID.Text = lvFoodDrink.Items(i).SubItems(0).Text And cboTypeID.Text = lvFoodDrink.Items(i).SubItems(5).Text Then
                        MsgBox("This item is added allready. Please add another item.")
                        Exit Sub
                    End If
                Next
                Dim amount As Single = Val(txtUnitPrice.Text) * Val(txtQTy.Text)
                _AddDataToListview(lvFoodDrink, cboProductID.Text, cboProductName.Text, cboTypeName.Text, txtUnitPrice.Text, txtDescription.Text, cboTypeID.Text, cboTypeValue.Text, txtQTy.Text, amount)
            Else
                Dim amount As Single = Val(txtUnitPrice.Text) * Val(txtQTy.Text)
                _AddDataToListview(lvFoodDrink, cboProductID.Text, cboProductName.Text, cboTypeName.Text, txtUnitPrice.Text, txtDescription.Text, cboTypeID.Text, cboTypeValue.Text, txtQTy.Text, amount)
            End If
            
        Else
            MsgBox("Please set data info especially the cost and quantity")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim tran As OleDb.OleDbTransaction
        Dim totalAmount As Single = 0
        'tran = Con.BeginTransaction
        'Try
        Dim row As Integer = lvFoodDrink.Items.Count - 1
        Dim exp_id As Integer = _AutoID("tbl_expenses", "exp_id")
        If row >= 0 Then
            With lvFoodDrink


                For i As Integer = 0 To row
                    Dim ite_id As Integer = Val(.Items(i).SubItems(0).Text)
                    Dim typ_id As Integer = Val(.Items(i).SubItems(5).Text)

                    _SQLExecute("INSERT INTO tbl_import_details VALUES(" & txtImportID.Text & "," & ite_id & "," & typ_id & "," & .Items(i).SubItems(7).Text & "," & .Items(i).SubItems(3).Text & "," & .Items(i).SubItems(8).Text & ")")

                    totalAmount += Val(.Items(i).SubItems(8).Text)
                    ' add to stock
                    Dim dr As OleDb.OleDbDataReader
                    Dim has As Boolean = False
                    Dim old_qty As Integer
                    dr = _SQLReader("SELECT sto_qty FROM tbl_stocks WHERE ite_id= " & ite_id & " AND typ_id=" & typ_id)
                    If dr.HasRows Then
                        has = True
                        While dr.Read
                            old_qty = dr(0)
                        End While

                        dr.Close()

                    End If
                    If has Then
                        _SQLExecute("UPDATE tbl_stocks SET sto_qty=" & (old_qty + Val(txtQTy.Text)) & ",'imported on " & dtImportDate.Text & "' WHERE ite_id= " & ite_id & " AND typ_id=" & typ_id)
                        _SQLExecute("INSERT INTO tbl_stock_details(ite_id,typ_id,sto_qty_begin,sto_qty_change,sto_qty_end,sto_description,sto_date) VALUES(" & ite_id & "," & typ_id & "," & old_qty & "," & txtQTy.Text & "," & (old_qty + Val(txtQTy.Text)) & ",'Impored', #" & dtImportDate.Text & "#)")

                    Else
                        _SQLExecute("INSERT INTO tbl_stocks(ite_id,typ_id,sto_qty,sto_description) VALUES(" & ite_id & "," & typ_id & "," & txtQTy.Text & ", 'imported on " & dtImportDate.Text & "')")
                        _SQLExecute("INSERT INTO tbl_stock_details(ite_id,typ_id,sto_qty_begin,sto_qty_change,sto_qty_end,sto_description,sto_date) VALUES(" & ite_id & "," & typ_id & "," & 0 & "," & txtQTy.Text & "," & (Val(txtQTy.Text)) & ",'first Impored', #" & dtImportDate.Text & "#)")
                    End If

                    _SQLExecute("INSERT INTO tbl_expense_details VALUES(" & exp_id & "," & ite_id & "," & typ_id & "," & .Items(i).SubItems(8).Text & ",'imported expense')")

                Next

            End With
            _SQLExecute("INSERT INTO tbl_import VALUES(" & txtImportID.Text & ",#" & dtImportDate.Text & "#," & cboSupplierID.Text & "," & totalAmount & ")")
            _SQLExecute("INSErT INTO tbl_expenses VALUES(" & exp_id & ",#" & dtImportDate.Text & "#," & totalAmount & ",'imported expenses')")
            MsgBox("Data has been save", , "Message")
        Else
            MsgBox("No record yet", , "Message")
        End If


        'tran.Commit()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'tran.Rollback()
        'End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        _DeleteListViewItem(lvFoodDrink)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim index As Integer = _SelectedIndexOfListView(lvFoodDrink)
        If index > -1 Then
            Dim amount As Single = Val(txtUnitPrice.Text) * Val(txtQTy.Text)
            _UpdateDataInListView(lvFoodDrink, cboProductID.Text, cboProductName.Text, cboTypeName.Text, txtUnitPrice.Text, txtDescription.Text, cboTypeID.Text, cboTypeValue.Text, txtQTy.Text, amount)
        End If
    End Sub

    Private Sub cboTypeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeName.SelectedIndexChanged
        cboTypeID.Text = cboTypeID.Items(cboTypeName.SelectedIndex).ToString
        cboTypeValue.Text = cboTypeValue.Items(cboTypeName.SelectedIndex).ToString

    End Sub

    Private Sub lvFoodDrink_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvFoodDrink.SelectedIndexChanged
        Dim index As Integer = _SelectedIndexOfListView(sender)
        If index > -1 Then
            'Dim amount As Single = Val(txtUnitPrice.Text) * Val(txtQTy.Text)
            With lvFoodDrink.Items(index)
                cboProductID.Text = .SubItems(0).Text
                cboTypeID.Text = .SubItems(5).Text
                txtUnitPrice.Text = .SubItems(3).Text
                txtQTy.Text = .SubItems(7).Text
            End With

            '_UpdateDataInListView(sender, cboProductID.Text, cboProductName.Text, cboTypeName.Text, txtUnitPrice.Text, txtDescription.Text, cboTypeID.Text, cboTypeValue.Text, txtQTy.Text, amount)
        End If
    End Sub

    Private Sub txtQTy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQTy.KeyPress, txtUnitPrice.KeyPress
        _NumberOnly(e, True)
    End Sub
End Class