Public Class AINote

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtNote.Text <> "" Then
            If AIDictionary.CheckNote() = 1 Then
                Com.CommandText = "update tbNote set My_Note='" & txtNote.Text & "' where word_id=" & AIDictionary.SelectIndex
            Else
                Com.CommandText = "insert into tbNote values(" & AIDictionary.SelectIndex & ",'" & txtNote.Text & "')"
            End If
            Dr = Com.ExecuteReader
            Dr.Close()
            AIDictionary.txtNote.Text = "    " & txtNote.Text
            AIDictionary.txtNote.Visible = True
            AIDictionary.lblMyNote.Visible = True
            AIDictionary.btnDelete.Visible = True
        End If
        Me.Close()
    End Sub


End Class