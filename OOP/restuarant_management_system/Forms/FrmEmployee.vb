Public Class frmEmployee
    'about pos_id in cboPositionID
    'about stoped_work_date

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        FrmPossition.ShowDialog()
        cboPosition.Items.Clear()
        _FillCombobox(cboPosition, "Select pos_name From tbl_positions ")
    End Sub

    
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        _ClearSelectedIndexOfListView(lvEmployee)
        _txtClear(Me)
        txtID.Text = _AutoID("tbl_employee", "emp_id")
        txtName.Focus()

    End Sub

   
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If txtName.Text = "" Then
            MsgBox("Please complete employee name", vbInformation)
        ElseIf cboPosition.Text = "" Then
            MsgBox("Please select employee position", vbInformation)
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please complete employee address", vbInformation)
        ElseIf cboGender.Text = "" Then
            MsgBox("Please select employee gender", vbInformation)
        ElseIf _isDuplicate("tbl_employee", "emp_id", txtID.Text) Then
            MsgBox("This employee already exist", vbInformation)
        Else
            Dim strPhone As String = txtPhone.Text
            Dim strEmail As String = txtEmail.Text

            If (txtPhone.Text = "") Then strPhone = " "
            If (txtEmail.Text = "") Then strEmail = " "
            _AddDataToListview(lvEmployee, txtID.Text, txtName.Text, cboGender.Text, dtBirthdate.Text, dtStartedWork.Text, cboPositionID.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text)
            _SQLExecute("Insert Into tbl_employee(emp_id,emp_name,emp_gender,emp_birthdate,emp_phone,emp_email,emp_address,emp_started_work_date,pos_id) Values (" & txtID.Text & ",'" & txtName.Text & "','" & cboGender.Text & "', # " & dtBirthdate.Text & " #,'" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtAddress.Text & "',# " & dtStartedWork.Text & " #," & cboPositionID.Text & ")")
            btnNew_Click(sender, e)

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim mresult As Integer

        If txtName.Text <> "" Or _SelectedIndexOfListView(lvEmployee) <> -1 Then

            mresult = MsgBox("Are you sure want to delete this employee information", vbYesNo)
            If mresult = vbYes Then
                _DeleteListViewItem(lvEmployee)
                _SQLExecute("Delete * From tbl_employee WHERE emp_id=" & txtID.Text)
                '????
                btnNew_Click(sender, e)
            Else
                lvEmployee.Focus()

            End If

        ElseIf _CheckRecord("tbl_employee") = False Then

            MsgBox("No record to delete", vbInformation)
        Else
            MsgBox("Please select record you want to delete", vbInformation)

        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

       
        If txtName.Text <> "" And txtAddress.Text <> "" Or _SelectedIndexOfListView(lvEmployee) <> -1 Then

            _UpdateDataInListView(lvEmployee, txtID.Text, txtName.Text, cboGender.Text, dtBirthdate.Text, dtStartedWork.Text, cboPosition.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text)
            _SQLExecute("UPDATE tbl_employee SET emp_name='" & txtName.Text & "'," & "emp_gender='" & cboGender.Text & "'," & " emp_birthdate= #" & dtBirthdate.Value.Date & "# ," & " emp_phone= '" & txtPhone.Text & "', " & "emp_email='" & txtEmail.Text & "', " & "emp_address= '" & txtAddress.Text & "', " & " emp_started_work_date= # " & dtStartedWork.Value.Date & " #," & "pos_id=" & txtID.Text & " Where emp_id=" & txtID.Text)

        ElseIf _CheckRecord("tbl_employee") = False Then

            MsgBox("No record to update", vbInformation)
        Else
            MsgBox("Please select record you want to update", vbInformation)

        End If
    End Sub

   
    Private Sub frmEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        
        'set auto ID in txtID
        txtID.Text = _AutoID("tbl_employee", "emp_id")

        cboGender.SelectedIndex = 0        

        'cboPositionID.Text = txtID.Text

        txtName.Focus()

        'select position name to put in to cboGender from tbl_position
        _FillCombobox(cboPosition, "Select pos_name From tbl_positions")


        ' cboPosition.SelectedIndex = 0

        'take all data from tbl_positions to view in listview position
        _AddDataToListview(lvEmployee, "Select emp_id,emp_name,emp_gender,emp_birthdate,emp_started_work_date,pos_id,emp_address,emp_phone,emp_email From tbl_employee")

    End Sub


    Private Sub lvEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvEmployee.SelectedIndexChanged

        Dim lst As ListViewItem

        For i As Integer = 0 To lvEmployee.Items.Count - 1

            If lvEmployee.Items(i).Selected Then
                lst = lvEmployee.Items(i)

                With lst

                    txtID.Text = .Text
                    txtName.Text = .SubItems(1).Text
                    cboGender.Text = .SubItems(2).Text
                    dtBirthdate.Text = .SubItems(3).Text
                    dtStartedWork.Text = .SubItems(4).Text
                    cboPosition.Text = .SubItems(5).Text
                    txtAddress.Text = .SubItems(6).Text
                    txtPhone.Text = .SubItems(7).Text
                    txtEmail.Text = .SubItems(8).Text

                End With

            End If

        Next
    End Sub

    Private Sub cboPosition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPosition.SelectedIndexChanged

        _FillCombobox(cboPositionID, "Select pos_id From tbl_positions Where pos_name='" & cboPosition.Text & "' ")
        cboPositionID.Text = cboPositionID.Items(0)


    End Sub
End Class