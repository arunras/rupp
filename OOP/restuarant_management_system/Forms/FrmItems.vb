Public Class FrmItems

    Private Sub FrmItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _OpenConnection()
        txtFoodDrinkID.Text = _AutoID("tbl_items", "ite_id")
        _FillCombobox(cboTypeName, "SELECT typ_name FROM tbl_types")
        cboFilter.Text = cboFilter.Items(0)
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            If txtFoodDrinkName.Text.Trim = "" Or txtUnitPrice.Text = "" Or cboTypeName.Text = "" Then
                MsgBox("Some data missing! Please complete it", , "Message")
            Else
                _SQLExecute("INSERT INTO tbl_items VALUES(" & txtFoodDrinkID.Text & "," & _sqlField(txtFoodDrinkName.Text) & "," & _sqlField(txtDescription.Text) & ")")
                _SQLExecute("INSERT INTO tbl_item_prices  VALUES(" & txtFoodDrinkID.Text & "," & txtTypeID.Text & "," & txtUnitPrice.Text & ")")
                _AddDataToListview(lstFoodDrink, txtFoodDrinkID.Text, txtFoodDrinkName.Text, cboTypeName.Text, txtUnitPrice.Text, txtDescription.Text)

                btnNew_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub lstFoodDrink_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles lstFoodDrink.ColumnWidthChanged
        Exit Sub
    End Sub

    Private Sub lstFoodDrink_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFoodDrink.DoubleClick
        Dim index As Integer = _SelectedIndexOfListView(sender)
        If index > -1 Then
            frmImport.cboProductID.Text = sender.items(index).subItems(0).text
            Me.Close()
        End If
    End Sub

    Private Sub lstFoodDrink_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFoodDrink.SelectedIndexChanged
        Dim index As Integer = _SelectedIndexOfListView(sender)
        If index > -1 Then
            With sender.items(index)
                txtFoodDrinkID.Text = .subitems(0).text
                txtFoodDrinkName.Text = .subitems(1).text
                cboTypeName.Text = .subitems(2).text
                txtUnitPrice.Text = .subitems(3).text
                txtDescription.Text = .subitems(4).text
            End With
        End If
    End Sub

    Private Sub btnBrowType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowType.Click
        frmType.ShowDialog()

    End Sub

    Private Sub btnShowProductCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowProductCost.Click
        frmProductCost.ShowDialog()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        _txtClear(Me)
        txtFoodDrinkID.Text = _AutoID("tbl_items", "ite_id")
        txtFoodDrinkName.Focus()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If txtFilter.Text.Trim <> "" Then
            Dim strsql As String = "SELECT I.ite_id, I.ite_name, T.typ_name, P.ite_price,I.ite_description" _
                                & " FROM (tbl_items  AS I INNER JOIN tbl_item_prices AS P ON I.ite_id = P.ite_id)" _
                                & " INNER JOIN tbl_types AS T ON P.typ_id = T.typ_id "
            Select Case cboFilter.Text
                Case "All"
                    strsql = strsql
                Case "Food Drink ID"
                    strsql = strsql & " WHERE I.ite_id LIKE " & txtFilter.Text
                Case "Food Drink Name"
                    strsql = strsql & " WHERE I.ite_name LIKE " & _sqlFillLIKE(txtFilter.Text)
                Case "Type"
                    strsql = strsql & " WHERE T.typ_name LIKE " & _sqlFillLIKE(txtFilter.Text)
                Case "Sale Price"
                    strsql = strsql & " WHERE P.ite_price= " & txtFilter.Text
                Case "Description"
                    strsql = strsql & " WHERE I.ite_description LIKE " & _sqlFillLIKE(txtFilter.Text)
            End Select
            strsql = strsql & " ORDER BY I.ite_id"
            _AddDataToListview(lstFoodDrink, strsql)
        End If
        
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim fdid As String = txtFoodDrinkID.Text
        Dim tid As String = txtTypeID.Text
        If fdid <> "" And tid.Trim <> "" Then
            Try
                If MsgBox("Do you want to delet this item?", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                    _SQLExecute("DELETE FROM tbl_items WHERE ite_id=" & fdid)
                    _SQLExecute("DELETE FROM tbl_item_prices WHERE ite_id=" & fdid & " AND typ_id=" & tid)
                    _DeleteListViewItem(lstFoodDrink)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim fdid As String = txtFoodDrinkID.Text
        Dim tid As String = txtTypeID.Text
        Dim tid_old As Integer
        Dim index As Integer = _SelectedIndexOfListView(lstFoodDrink)
        If index > -1 Then
            Dim dr As OleDb.OleDbDataReader
            dr = _SQLReader("SELECT typ_id FROM tbl_types WHERE typ_name=" & _sqlField(lstFoodDrink.Items(index).SubItems(2).Text))
            If dr.HasRows Then
                While dr.Read
                    tid_old = dr(0)
                End While

            End If
            dr.Close()
        End If
        If fdid.Trim <> "" And tid.Trim <> "" And txtFoodDrinkName.Text.Trim <> "" Then
            Try
                _SQLExecute("UPDATE tbl_items SET ite_name= " & _sqlField(txtFoodDrinkName.Text) & ",ite_description=" & _sqlField(txtDescription.Text) & " WHERE ite_id=" & fdid)
                _SQLExecute("UPDATE tbl_item_prices SET  typ_id=" & tid & ",ite_price=" & txtUnitPrice.Text & " WHERE ite_id=" & fdid & " AND typ_id= " & tid_old)
                _UpdateDataInListView(lstFoodDrink, txtFoodDrinkID.Text, txtFoodDrinkName.Text, cboTypeName.Text, txtUnitPrice.Text, txtDescription.Text)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cboTypeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeName.SelectedIndexChanged
        _CompareTextInComboToItList(sender)
        Try
            Dim dr As OleDb.OleDbDataReader
            dr = _SQLReader("SELECT typ_id, typ_value FROM tbl_types WHERE typ_name=" & _sqlField(cboTypeName.Text))
            If dr.HasRows Then
                While dr.Read
                    txtTypeID.Text = dr(0)
                    txtTypeValue.Text = dr(1)

                End While
            End If
            dr.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilter.SelectedIndexChanged
        If sender.text = "All" Then
            _AddDataToListview(lstFoodDrink, "SELECT I.ite_id, I.ite_name, T.typ_name, P.ite_price, I.ite_description" _
                                & " FROM (tbl_items  AS I INNER JOIN tbl_item_prices AS P ON I.ite_id = P.ite_id)" _
                                & " INNER JOIN tbl_types AS T ON P.typ_id = T.typ_id ORDER BY I.ite_id;")
            txtFilter.Visible = False
            Label8.Visible = False
        Else
            txtFilter.Visible = True
            Label8.Visible = True
            Label8.Text = sender.text
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class