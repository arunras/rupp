Public Class FrmAttendances

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    
    Private Sub FrmAttendances_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        cboWorkTime.Text = "Morning"
       
    End Sub

    Private Sub cboWorkTime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorkTime.SelectedIndexChanged
        ' MsgBox(cboWorkTime.SelectedIndex)
    End Sub

    Private Sub dgEmployee_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEmployee.CellContentClick

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        ' Dim str1 As String

        If cboWorkTime.Text = "" Then
            MsgBox("Please select work time")
            cboWorkTime.Focus()
        ElseIf cboShowBy.Text = "" Then
            MsgBox("Please select type you want to show")
        Else
            '_AddRecordDg(dgEmployee,"Select emp_id,emp_name,emp_gender WHERE emp_"
        End If
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
       
    End Sub
End Class