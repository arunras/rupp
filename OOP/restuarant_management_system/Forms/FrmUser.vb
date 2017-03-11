Public Class FrmUser

    Private Sub FrmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _OpenConnection()
        btnNew_Click(sender, e)
        _AddDataToListview(lstUser, "SELECT * FROM tbl_users")
        'Dim de As New clsEncryptDecrypt
        'MsgBox(de.decryptString(lstUser.Items(1).SubItems(4).Text))
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        _txtClear(Me)
        txtUserID.Text = _AutoID("tbl_users", "use_id")
        radUser.Checked = True
        btnUpdate.Enabled = False
        txtUserName.Focus()
    End Sub

    Private Sub txtFullName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFullName.KeyPress
        _CharacterOnly(e, True)
    End Sub
    
    
    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress, txtUserPassword.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack Then
            Exit Sub
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub lstUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUser.SelectedIndexChanged
        Dim index As Integer = _SelectedIndexOfListView(sender)
        If index > -1 Then
            With lstUser.Items(index)
                txtUserID.Text = .SubItems(0).Text
                txtUserName.Text = .SubItems(1).Text
                txtFullName.Text = .SubItems(2).Text
                Call RadPermisionChecked(.SubItems(3).Text)
                Dim DecEnc As New clsEncryptDecrypt
                Dim passwd As String = DecEnc.decryptString(.SubItems(4).Text)
                txtUserPassword.Text = passwd
            End With
        End If
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If _CheckNull(Me) Then
            MsgBox("Some data needed", MsgBoxStyle.Information, "Message Alert")
            Exit Sub
        Else
            If _isDuplicate("tbl_users", "use_name", txtUserName.Text) Then
            Else
                Dim Permision As String = PermisionTextChecked()
                Dim EncDec As New clsEncryptDecrypt
                Dim passwd As String = EncDec.encryptString(txtUserPassword.Text)
                'MsgBox(passwd)
                'Exit Sub
                _SQLExecute("INSERT INTO tbl_users VAlUES(" & txtUserID.Text & "," & _sqlField(txtUserName.Text) & "," & _sqlField(txtFullName.Text) & "," & _sqlField(Permision) & "," & _sqlField(passwd) & ")")
                _AddDataToListview(lstUser, txtUserID.Text, txtUserName.Text, txtFullName.Text, Permision, passwd)
                btnNew_Click(sender, e)
            End If
            
        End If
    End Sub

    Sub RadPermisionChecked(ByVal permision As String)
        Select Case permision
            Case radAdmin.Text
                radAdmin.Checked = True
            Case radStockKeeper.Text
                radStockKeeper.Checked = True
            Case radUser.Text
                radUser.Checked = True
        End Select
    End Sub

    Function PermisionTextChecked() As String
        If radAdmin.Checked Then
            Return radAdmin.Text
        ElseIf radStockKeeper.Checked Then
            Return radStockKeeper.Text
        Else
            Return radUser.Text
        End If
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If _CheckNull(Me) Then
            MsgBox("Please selecte user from user list to delete.")
            Exit Sub
        Else
            Try
                If MsgBox("Do you really want to delete this user?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Wanning") = MsgBoxResult.Yes Then
                    _SQLExecute("DELETE * FROM tbl_users WHERE use_id=" & txtUserID.Text)
                    _DeleteListViewItem(lstUser)
                    With lstUser.Items(0)
                        .Selected = True
                        txtUserID.Text = .SubItems(0).Text
                        txtUserName.Text = .SubItems(1).Text
                        txtFullName.Text = .SubItems(2).Text
                        RadPermisionChecked(.SubItems(3).Text)

                        Dim DecEnc As New clsEncryptDecrypt
                        Dim passwd As String = DecEnc.decryptString(.SubItems(4).Text)
                        txtUserPassword.Text = passwd
                    End With
                End If
                
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If _CheckNull(Me) Then
            MsgBox("Please select a user and change or missing data", MsgBoxStyle.Information, "Message")
            Exit Sub
        Else
            Try
                Dim permision As String = PermisionTextChecked()
                Dim enc As New clsEncryptDecrypt
                Dim passwd As String = enc.encryptString(txtUserPassword.Text)
                _SQLExecute("UPDATE tbl_users SET use_name=" & _sqlField(txtUserName.Text) & "," _
                    & "use_real_name=" & _sqlField(txtFullName.Text) & " ,use_permition=" & _sqlField(permision) _
                    & ",use_password=" & _sqlField(passwd) & " WHERE use_id=" & txtUserID.Text)
                _UpdateDataInListView(lstUser, txtUserID.Text, txtUserName.Text, txtFullName.Text, permision, passwd)
                MsgBox("Update successfully!", MsgBoxStyle.Information, "Message")
                btnUpdate.Enabled = False
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtUserName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.Leave, txtFullName.Leave, txtUserPassword.Leave
        If Trim(sender.text) = "" Then
            btnUpdate.Enabled = False
            sender.focus()
        Else
            btnUpdate.Enabled = True

        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class