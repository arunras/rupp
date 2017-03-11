Imports System.Data.OleDb

Public Class FrmPossition
    Dim dr As OleDbDataReader

    Private Sub txtSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalary.KeyPress
        _NumberOnly(e, True)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'clear text in all textbox on form
        _txtClear(Me)
        'set auto ID
        txtID.Text = _AutoID("tbl_positions", "pos_id")
        txtName.Focus()

    End Sub

    Private Sub FrmPossition_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'set auto ID in txtID
        txtID.Text = _AutoID("tbl_positions", "pos_id")
        txtName.Focus()
        'take all data from tbl_positions to view in listview position
        _AddDataToListview(lvPosition, "SELECT * FROM tbl_positions")

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If txtName.Text = "" Then

            MsgBox("Please complete position name")

        ElseIf txtSalary.Text = "" Then

            MsgBox("Please complete position salary")

        ElseIf _isDuplicate("tbl_positions", "pos_id", txtID.Text) Then

            MsgBox("This position already exist", vbInformation)
        Else
            _AddDataToListview(lvPosition, txtID.Text, txtName.Text, txtSalary.Text, txtDescription.Text)
            _SQLExecute("Insert Into tbl_positions Values(" & txtID.Text & "," & _sqlField(txtName.Text) & "," & txtSalary.Text & "," & _sqlField(txtDescription.Text) & ")")
            'after add item in to tbl_position then add to cboPosition in frmEmployee

            btnNew_Click(sender, e)

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim mresult As Integer

        If txtName.Text <> "" And txtSalary.Text <> "" Or _SelectedIndexOfListView(lvPosition) <> -1 Then

            mresult = MsgBox("Are you sure want to delete this position information?", vbYesNo)

            If mresult = vbYes Then
                _DeleteListViewItem(lvPosition)
                _SQLExecute("DELETE * FROM tbl_positions WHERE pos_id=" & txtID.Text)
                btnNew_Click(sender, e)
            Else
                lvPosition.Focus()
            End If

        ElseIf Not _CheckRecord("tbl_positions") Then
            MsgBox("No record to delete")
        Else
            MsgBox("Please select position you want to delete")
        End If

    End Sub

    Private Sub lvPosition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPosition.SelectedIndexChanged

        Dim lst As ListViewItem
        For i As Integer = 0 To lvPosition.Items.Count - 1
            If lvPosition.Items(i).Selected Then
                lst = lvPosition.Items(i)
                With lst
                    txtID.Text = .Text
                    txtName.Text = .SubItems(1).Text
                    txtSalary.Text = .SubItems(2).Text
                    txtDescription.Text = .SubItems(3).Text
                End With
            End If
        Next

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        

        If txtName.Text <> "" And txtSalary.Text <> "" Or _SelectedIndexOfListView(lvPosition) <> -1 Then

            _UpdateDataInListView(lvPosition, txtID.Text, txtName.Text, txtSalary.Text, txtDescription.Text)
            _SQLExecute("UPDATE tbl_positions SET pos_name='" & txtName.Text & "', " & "pos_salary=" & txtSalary.Text & "," & "pos_description='" & txtDescription.Text & "' WHERE pos_id= " & txtID.Text & " ")

        ElseIf Not _CheckRecord("tbl_positions") Then

            MsgBox("No record to update")
        Else
            MsgBox("Please select record you want to update")
        End If

    End Sub

 
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class