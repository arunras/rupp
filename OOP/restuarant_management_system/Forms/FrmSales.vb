Public Class FrmSales

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
        txtSaleID.Text = _AutoID("tbl_sales", "sal_id")
        cboTableNumber.Focus()
    End Sub

    Private Sub FrmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnNew_Click(sender, e)
        Try
            _FillCombobox(cboSaleIDList, "SELECT sal_id FROM tbl_sales WHERE sal_status=0")
            _FillCombobox("SELECT ite_id,ite_name FROM tbl_items", cboFoodDrinkID, cboFoodDrinkName)
            _FillCombobox(cboTableNumber, "SELECT tab_name FROM tbl_tables")
            _FillCombobox(cbotypeName, "SELECT typ_name FROM tbl_types")
            Call FillQty()
        Catch ex As Exception

        End Try
     
    End Sub
    Sub FillQty()
        With cboQty.Items
            For i As Integer = 1 To 20
                .Add(i)
            Next

        End With
        cboQty.Text = cboQty.Items(0)
    End Sub
    Private Sub cboSaleIDList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSaleIDList.SelectedIndexChanged
        Dim sql As String = "SELECT * FROM QSaleItem"
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader(sql)
        Dim id As Integer = 1
        If dr.HasRows Then
            While dr.Read
                _AddDataToListview(lvFoodDrinkOrder, id, dr(0), dr(1), dr(2), dr(3), dr(4))
                id = id + 1
            End While
        End If
    End Sub

    Private Sub cboFoodDrinkID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFoodDrinkID.SelectedIndexChanged
        cboFoodDrinkName.Text = cboFoodDrinkName.Items(cboFoodDrinkID.SelectedIndex)
    End Sub

    Private Sub cboFoodDrinkName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFoodDrinkName.SelectedIndexChanged
        cboFoodDrinkID.Text = cboFoodDrinkID.Items(cboFoodDrinkID.SelectedIndex)
    End Sub

    Private Sub cboQty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboQty.KeyPress
        _NumberOnly(e, True)
    End Sub

    Sub TotalAmount()
        With lvFoodDrinkOrder
            Dim row As Integer = .Items.Count - 1
            Dim amount As Double
            For i As Integer = 0 To row
                amount = amount + Val(.Items(row).SubItems(5).Text)
            Next
            txtTotalAmount.Text = amount
        End With

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim fd_id As Integer = Val(cboFoodDrinkID.Text)
        Dim sal_id As Integer = Val(txtSaleID.Text)
        Dim typ_id As Integer
        Dim tab_num As String = cboTableNumber.Text
        Dim tab_id As Integer
        Dim qty As Integer = Val(cboQty.Text)
        Dim dr As OleDb.OleDbDataReader
        dr = _SQLReader("SELECT typ_id FROM tbl_types WHERE typ_name=" & _sqlField(cboTableNumber.Text))
        If dr.HasRows Then
            While dr.Read
                typ_id = dr(0)
            End While

        End If
        dr.Close()
        dr = _SQLReader("SELECT tab_id FROM tbl_tables WHERE tab_name=" & _sqlField(tab_num))
        If dr.HasRows Then
            While dr.Read
                tab_id = dr(0)
            End While
        End If
        dr.Close()
        If fd_id And typ_id And tab_num.Trim <> "" And qty Then
            Dim has As Boolean = False
            dr = _SQLReader("SELECT sal_id FROM tbl_sales WHERE sal_id=" & sal_id)
            If dr.HasRows Then
                has = True
            End If
            If Not has Then
                _SQLExecute("INSERT INTO tbl_sales VALUES(" & sal_id & ",#" & Now & "#," & tab_id & "," & txtTotalAmount.Text & ",0)")
            End If
            _SQLExecute("INSERT INTO tbl_sale_details VALUES(" & sal_id & "," & fd_id & "," & typ_id & "," & cboQty.Text & "," & txtUnitPrice.Text & ")")
            _AddDataToListview(lvFoodDrinkOrder, lvFoodDrinkOrder.Items.Count + 1, fd_id, cboFoodDrinkName.Text, txtUnitPrice.Text, cboQty.Text, (Val(txtUnitPrice.Text) * (Val(cboQty.Text))))
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtSaleID.Text <> "" And cboFoodDrinkID.Text <> "" Then
            If MsgBox("Delete this item?", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                _SQLExecute("DELETE FROM tbl_sale_details WHERE sal_id=" & txtSaleID.Text & " AND ite_id=" & cboFoodDrinkID.Text)

                Dim sql As String = "SELECT * FROM QSaleItem"
                Dim dr As OleDb.OleDbDataReader
                dr = _SQLReader(sql)
                Dim id As Integer = 1
                If dr.HasRows Then
                    While dr.Read

                        _AddDataToListview(lvFoodDrinkOrder, id, dr(0), dr(1), dr(2), dr(3), dr(4))
                        id = id + 1
                    End While
                End If
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        If lvFoodDrinkOrder.Items.Count > 0 Then
            _SQLExecute("UPDATE tbl_sales SET sal_status=1 WHERE sal_id=" & txtSaleID.Text)
            cboFoodDrinkID.Items.RemoveAt(cboFoodDrinkID.SelectedIndex)
            lvFoodDrinkOrder.Items.Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cbotypeName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotypeName.SelectedIndexChanged
        Dim dr As OleDb.OleDbDataReader
        Dim typ_id As Integer
        dr = _SQLReader("SELECT typ_id FROM tbl_types WHERE typ_name= " & _sqlField(cbotypeName.Text))
        If dr.HasRows Then
            While dr.Read
                typ_id = dr(0)
            End While
        End If
        dr.Close()
        dr = _SQLReader("SELECT ite_price FROM tbl_item_prices WHERE ite_id=" & cboFoodDrinkID.Text & " AND typ_id=" & typ_id)
        If dr.HasRows Then
            While dr.Read
                txtUnitPrice.Text = dr(0).ToString

            End While
        End If
        dr.Close()
    End Sub
End Class