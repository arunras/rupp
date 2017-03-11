Public Class fNewEE

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtKword.Text = "" And txtKdefinition.Text = "" Then
            fMessage.ShowDialog()
            Exit Sub
        Else
            Call NewEWord()
        End If

    End Sub

    Sub NewEWord()
        Dim Kword As String = txtKword.Text
        Dim Kdef As String = txtKdefinition.Text

        Com.CommandText = "INSERT INTO tbEE (eWord,eDefinition) VALUES(" & Field(Kword) & "," & Field(Kdef) & ")"
        Com.ExecuteNonQuery()

        MsgBox("Insert success!", MsgBoxStyle.Information, "New word")

        txtKword.Text = ""
        txtKdefinition.Text = ""
        txtKword.Focus()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class