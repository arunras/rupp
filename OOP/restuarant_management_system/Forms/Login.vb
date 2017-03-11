Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim security As New clsEncryptDecrypt
        Dim username As String = txtUserName.Text
        Dim passwd As String = security.encryptString(txtPassword.Text)
        If username.Trim = "" Then
            txtUserName.Focus()
        ElseIf txtPassword.Text.Trim = "" Then
            txtPassword.Focus()
        Else
            Try
                _OpenConnection()
                Dim dr As OleDb.OleDbDataReader
                dr = _SQLReader("SELECT use_permition FROM tbl_users WHERE use_name=" & _sqlField(username) & " AND use_password=" & _sqlField(passwd))
                If dr.HasRows Then
                    While dr.Read
                        userPermision = dr(0).ToString
                    End While
                    frmMain.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid user account", , "Message")
                    txtUserName.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
