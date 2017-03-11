Public Class frmSalaryExpense

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If txtShow.Text.Trim <> "" Then
            Dim sql As String = "SELECT E.emp_id, E.emp_name, E.emp_gender, format(E.emp_birthdate,'dd-mm-yyyy'), P.pos_name, P.pos_salary" _
                                        & " FROM tbl_employee AS E INNER JOIN tbl_positions AS P ON E.pos_id = P.pos_id"
            If cboFilter.SelectedIndex = 1 Then
                sql = sql & " WHERE P.pos_name LIKE " & _sqlFillLIKE(txtShow.Text)
            Else
                sql = sql & " WHERE E.emp_name LIKE " & _sqlFillLIKE(txtShow.Text)
            End If
            _AddRecordDg(dgEmployeeList, sql)
            Call AddTotalSalary()
        End If
        
    End Sub
    Sub AddTotalSalary()
        Dim sum As Double
        For i As Integer = 0 To dgEmployeeList.Rows.Count - 2
            If Val(dgEmployeeList.Rows(i).Cells(0).Value) <> 0 Then
                dgEmployeeList.Rows(i).Cells(7).Value = Val(dgEmployeeList.Rows(i).Cells(5).Value) + Val(dgEmployeeList.Rows(i).Cells(6).Value)
                sum += Val(dgEmployeeList.Rows(i).Cells(7).Value)
            End If
        Next
        txtTotalExpense.Text = sum
    End Sub
    Private Sub frmSalaryExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtExpenseID.Text = _AutoID("tbl_expenses", "exp_id")
        Call AddComboFilter()
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilter.SelectedIndexChanged

        If sender.selectedIndex = 0 Then
            _AddRecordDg(dgEmployeeList, "SELECT E.emp_id, E.emp_name, E.emp_gender, format(E.emp_birthdate,'dd-mm-yyyy'), P.pos_name, P.pos_salary" _
                                        & " FROM tbl_employee AS E INNER JOIN tbl_positions AS P ON E.pos_id = P.pos_id")
            txtShow.Visible = False
            btnShow.Visible = False
            Call AddTotalSalary()
        Else
            txtShow.Visible = True
            btnShow.Visible = True
            txtShow.Focus()
        End If
    End Sub
    Sub AddComboFilter()
        With cboFilter.Items
            .Add("All")
            .Add("Position")
            .Add("Name")
        End With
        cboFilter.Text = cboFilter.Items(0)
    End Sub


    Private Sub dgEmployeeList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEmployeeList.CellEndEdit

        If e.ColumnIndex = 6 Then
            dgEmployeeList.CurrentRow.Cells(6).Value = Val(dgEmployeeList.CurrentRow.Cells(6).Value)
            AddTotalSalary()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgEmployeeList_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEmployeeList.CellLeave
        If e.ColumnIndex = 6 Then
            dgEmployeeList.CurrentRow.Cells(6).Value = Val(dgEmployeeList.CurrentRow.Cells(6).Value)
        End If
    End Sub

    Private Sub dgEmployeeList_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEmployeeList.RowLeave
        dgEmployeeList.CurrentRow.Cells(6).Value = Val(dgEmployeeList.CurrentRow.Cells(6).Value)
    End Sub

   
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        With dgEmployeeList
            If .Rows.Count - 1 > 0 Then
                For i As Integer = 0 To .Rows.Count - 2
                    _SQLExecute("INSERT INTO tbl_expense_details VALUES(" & txtExpenseID.Text & "," & .Rows(i).Cells(0).Value & ",-1," & .Rows(i).Cells(7).Value & ",'salary expenses')")
                Next
            End If
        End With
        _SQLExecute("INSERT INTO tbl_expenses VALUES(" & txtExpenseID.Text & ",#" & dtDate.Text & "#," & txtTotalExpense.Text & ",'salary expenses')")

    End Sub

    Private Sub btnOk_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.MouseHover
        lblMessage.Text = "Please look at the salary carefully, you can save but cannot edit or delete it"
    End Sub

    Private Sub btnOk_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.MouseLeave
        lblMessage.Text = ""
    End Sub
End Class