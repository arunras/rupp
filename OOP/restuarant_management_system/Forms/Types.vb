Public Class frmType

    Private Sub Types_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _txtClear(Me)
        txtID.Text = _AutoID("tbl_types", "typ_id")
        _AddDataToListview(lvType, "Select * From tbl_types")
        txtName.Focus()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        _ClearSelectedIndexOfListView(lvType)
        _txtClear(Me)
        txtID.Text = _AutoID("tbl_types", "typ_id")
        txtName.Focus()
       
    End Sub

    Private Sub lvType_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvType.DoubleClick
        Dim index As Integer = _SelectedIndexOfListView(sender)
        If index > -1 Then
            FrmItems.cboTypeName.Text = lvType.Items(index).SubItems(1).Text
            Me.Close()
        End If
    End Sub

    Private Sub lvType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvType.SelectedIndexChanged

        Dim lst As ListViewItem

        For i As Integer = 0 To lvType.Items.Count - 1
            If lvType.Items(i).Selected Then
                lst = lvType.Items(i)
                With lst

                    txtID.Text = .Text
                    txtName.Text = .SubItems(lvcTypeName.Index).Text
                    txtValue.Text = .SubItems(lvcTypeValue.Index).Text
                    txtDescription.Text = .SubItems(lvcDescription.Index).Text

                End With
            End If
        Next

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If txtName.Text = "" Then
            MsgBox("Please complete type name", MsgBoxStyle.Information)

        ElseIf txtValue.Text = "" Then
            MsgBox("Please complete value type", MsgBoxStyle.Information)

        ElseIf _isDuplicate("tbl_types", "typ_id", txtID.Text) Then
            MsgBox("The type already exist", MsgBoxStyle.Information)

        Else
            Dim strDescription As String
            If (txtDescription.Text = "") Then strDescription = " "

            _AddDataToListview(lvType, txtID.Text, txtName.Text, txtValue.Text, txtDescription.Text)
            _SQLExecute("Insert Into tbl_types Values(" & txtID.Text & ", '" & txtName.Text & "', " & txtValue.Text & ", '" & txtDescription.Text & "') ")
            btnNew_Click(sender, e)

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim mresult As Integer

        If _SelectedIndexOfListView(lvType) < 0 Then
            MsgBox("Please select record you want to delete", MsgBoxStyle.Information)
        ElseIf _CheckRecord("tbl_types") = False Then
            MsgBox("No record to delete", MsgBoxStyle.Information)
        Else
            mresult = MsgBox("Are you sure want to delete", vbYesNo)
            If mresult = vbYes Then
                _DeleteListViewItem(lvType)
                _SQLExecute("Delete * From tbl_types WHERE typ_id=" & txtID.Text)
                btnNew_Click(sender, e)
            Else
                lvType.Focus()

            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        If _CheckNull(Me) Or _SelectedIndexOfListView(lvType) < 0 Then

            MsgBox("Select record you want to update", MsgBoxStyle.Information)

        ElseIf _CheckRecord("tbl_types") = False Then

            MsgBox("No record to update", MsgBoxStyle.Information)

        Else
            If txtName.Text = "" Then
                MsgBox("You could not blank type name", MsgBoxStyle.Exclamation)
                txtName.Focus()

            ElseIf txtValue.Text = "" Then
                MsgBox("You could not blank type value", MsgBoxStyle.Exclamation)
                txtValue.Focus()
           
            Else
                _UpdateDataInListView(lvType, txtID.Text, txtName.Text, txtValue.Text, txtDescription.Text)
                _SQLExecute("Update tbl_types Set typ_name='" & txtName.Text & "'," & "typ_value=" & txtValue.Text & "," & "typ_description='" & txtDescription.Text & "' WHERE typ_id=" & txtID.Text)
                btnNew_Click(sender, e)

            End If
        End If
    End Sub

   
  
    Private Sub txtValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValue.KeyPress
        _NumberOnly(e, True)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class