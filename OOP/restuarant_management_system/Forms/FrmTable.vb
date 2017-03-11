Public Class FrmTable

  
    Private Sub FrmTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Text = _AutoID("tbl_tables", "tab_id")
        _AddDataToListview(lvTable, "SELECT * FROM tbl_tables")
        txtName.Focus()
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        _ClearSelectedIndexOfListView(lvTable)
        _txtClear(Me)
        txtID.Text = _AutoID("tbl_tables", "tab_id")
        txtName.Focus()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If txtName.Text = "" Then
            MsgBox("Please complete table name", MsgBoxStyle.Information)

      
        ElseIf _isDuplicate("tbl_tables", "tab_id", txtID.Text) Then
            MsgBox("The table already exist", MsgBoxStyle.Information)

        Else
            Dim strPositon As String
            If (txtPosition.Text = "") Then strPositon = " "

            _AddDataToListview(lvTable, txtID.Text, txtName.Text, txtPosition.Text)
            _SQLExecute("INSERT INTO tbl_tables VALUES(" & txtID.Text & ", '" & txtName.Text & "','" & txtPosition.Text & "') ")
            btnNew_Click(sender, e)

        End If
    End Sub

    Private Sub lvTable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvTable.SelectedIndexChanged
        Dim lst As ListViewItem

        For i As Integer = 0 To lvTable.Items.Count - 1
            If lvTable.Items(i).Selected Then
                lst = lvTable.Items(i)
                With lst

                    txtID.Text = .Text
                    txtName.Text = .SubItems(lvcTableName.Index).Text
                    txtPosition.Text = .SubItems(lvcPosition.Index).Text

                End With
            End If
        Next

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim mresult As Integer

        If _SelectedIndexOfListView(lvTable) < 0 Then
            MsgBox("Please select record you want to delete", MsgBoxStyle.Information)
        ElseIf _CheckRecord("tbl_tables") = False Then
            MsgBox("No record to delete", MsgBoxStyle.Information)
        Else
            mresult = MsgBox("Are you sure?", vbYesNo)
            If mresult = vbYes Then
                _DeleteListViewItem(lvTable)
                _SQLExecute("DELETE * FROM tbl_tables WHERE tab_id=" & txtID.Text)
                btnNew_Click(sender, e)
            Else
                lvTable.Focus()

            End If
        End If

    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click



        If _CheckNull(Me) Or _SelectedIndexOfListView(lvTable) < 0 Then

            MsgBox("Select record you want to update", MsgBoxStyle.Information)

        ElseIf _CheckRecord("tbl_tables") = False Then

            MsgBox("No record to update", MsgBoxStyle.Information)

        Else

            If txtName.Text = "" Then
                MsgBox("You could not blank table name", MsgBoxStyle.Exclamation)
                txtName.Focus()
            ElseIf txtPosition.Text = "" Then
                MsgBox("You could not blank table position", MsgBoxStyle.Exclamation)
                txtPosition.Focus()
            
            Else
                _UpdateDataInListView(lvTable, txtID.Text, txtName.Text, txtPosition.Text)
                _SQLExecute("UPDATE tbl_tables SET tab_name='" & txtName.Text & "'," & " tab_where='" & txtPosition.Text & "' WHERE tab_id=" & txtID.Text)
                btnNew_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class