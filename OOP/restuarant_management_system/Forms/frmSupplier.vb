Public Class frmSupplier

    
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        _ClearSelectedIndexOfListView(lvSupplier)
        _txtClear(Me)
        txtID.Text = _AutoID("tbl_suppliers", "sup_id")
        txtName.Focus()
       
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If txtName.Text = "" Then
            MsgBox("Please complete supplier name", vbInformation)
            txtName.Focus()
        ElseIf txtCompany.Text = "" Then
            MsgBox("Please complete supplier company", vbInformation)
            txtCompany.Focus()
        ElseIf txtPhone.Text = "" Then
            MsgBox("Please complete supplier phone number", vbInformation)
            txtPhone.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please complete supplier address", vbInformation)
            txtPhone.Focus()
        ElseIf _isDuplicate("tbl_suppliers", "sup_id", txtID.Text) Then
            MsgBox("This supplier already exist", vbInformation)
        Else
            Dim strEmail As String = txtEmail.Text
            If (txtEmail.Text = "") Then strEmail = " "

            _AddDataToListview(lvSupplier, txtID.Text, txtName.Text, txtCompany.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text)
            _SQLExecute("Insert Into tbl_suppliers(sup_id,sup_name,sup_company,sup_phone,sup_email,sup_address) Values (" & txtID.Text & ",'" & txtName.Text & "','" & txtCompany.Text & "', '" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtAddress.Text & "')")
            btnNew_Click(sender, e)

        End If
        
    End Sub

    Private Sub frmSupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnNew_Click(sender, e)
        txtID.Text = _AutoID("tbl_suppliers", "sup_id")
        _AddDataToListview(lvSupplier, "Select sup_id,sup_name,sup_company,sup_phone,sup_email,sup_address From tbl_suppliers")
        txtName.Focus()
        cboFilter.Text = "All"

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim mresult As Integer

        If _SelectedIndexOfListView(lvSupplier) < 0 Then

            MsgBox("Please select record you want to delete", vbInformation)

        ElseIf _CheckRecord("tbl_suppliers") = False Then

            MsgBox("No record to delete", vbInformation)

        Else

            mresult = MsgBox("Are you sure want to delete this supplier", vbYesNo)
            If mresult = vbYes Then
                _DeleteListViewItem(lvSupplier)
                _SQLExecute("Delete * From tbl_suppliers Where sup_id= " & txtID.Text)
                btnNew_Click(sender, e)
            Else
                'record still select
                lvSupplier.Focus()
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If _CheckNull(Me) Or _SelectedIndexOfListView(lvSupplier) < 0 Then

            MsgBox("Select record you want to update", vbInformation)

        ElseIf _CheckRecord("tbl_suppliers") = False Then

            MsgBox("No record to update", vbInformation)

        Else
            If txtName.Text = "" Then
                MsgBox("You could not blank supplier name", MsgBoxStyle.Exclamation)
                txtName.Focus()
            ElseIf txtCompany.Text = "" Then
                MsgBox("You could not blank supplier company", MsgBoxStyle.Exclamation)
                cboFilter.Focus()
            ElseIf txtAddress.Text = "" Then
                MsgBox("You could not blank supplier address", MsgBoxStyle.Exclamation)
                txtAddress.Focus()
            Else
                _UpdateDataInListView(lvSupplier, txtID.Text, txtName.Text, txtCompany.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text)
                _SQLExecute("Update tbl_suppliers Set sup_name='" & txtName.Text & "'," & "sup_company='" & txtCompany.Text & "'," & "sup_phone='" & txtPhone.Text & "', " & "sup_email='" & txtEmail.Text & "'," & "sup_address='" & txtAddress.Text & "' WHERE sup_id=" & txtID.Text)

            End If
        End If
    End Sub

    Private Sub lvSupplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSupplier.DoubleClick
        Dim index As Integer = _SelectedIndexOfListView(sender)
        If index > -1 Then
            frmImport.cboSupplierID.Text = sender.Items(index).SubItems(0).Text
            Me.Close()
        End If
    End Sub

    Private Sub lvSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvSupplier.SelectedIndexChanged
        Dim lst As ListViewItem

        For i As Integer = 0 To lvSupplier.Items.Count - 1
            If lvSupplier.Items(i).Selected Then
                lst = lvSupplier.Items(i)
                With lst
                    txtID.Text = .Text
                    txtName.Text = .SubItems(lvcName.Index).Text
                    txtCompany.Text = .SubItems(lvcComapy.Index).Text
                    txtPhone.Text = .SubItems(lvcPhone.Index).Text
                    txtEmail.Text = .SubItems(lvcEmail.Index).Text
                    txtAddress.Text = .SubItems(lvcAddress.Index).Text
                End With
                Exit For
            End If
        Next
    End Sub

    
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim i As Integer
        Dim strField As String

        If cboFilter.Text = cboFilter.Items(0).ToString Then

            _AddDataToListview(lvSupplier, "Select sup_id,sup_name,sup_company,sup_phone,sup_email,sup_address From tbl_suppliers")
            Exit Sub
        End If

        For i = 1 To cboFilter.Items.Count - 1
            If cboFilter.Text = cboFilter.Items(i).ToString And txtFilter.Text <> "" Then
                If cboFilter.Text = "Name" Then
                    strField = "sup_name"
                ElseIf cboFilter.Text = "ID" Then
                    strField = "sup_id"
                Else
                    strField = "sup_company"
                End If
                Try
                    _AddDataToListview(lvSupplier, "Select sup_id,sup_name,sup_company,sup_phone,sup_email,sup_address From tbl_suppliers WHERE " & strField & " like '%" & txtFilter.Text & "%'")
                Catch ex As Exception
                End Try
                Try                
                    _AddDataToListview(lvSupplier, "Select sup_id,sup_name,sup_company,sup_phone,sup_email,sup_address From tbl_suppliers WHERE " & strField & "=" & txtFilter.Text)
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class