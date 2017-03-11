Public Class fSetting

    Private Sub rbFastSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFastSearch.CheckedChanged

        If rbFastSearch.Checked = True Then
            'pbLoading.Visible = True
            AIDictionary.btnSearch.Enabled = False
            'fSetting.gbSearchEngine.Text = "កំពុងទាញទិន្នន័យ..."
            'lblLoading.Text = "កំពុងទាញទិន្នន័យ..."

            Cursor = Cursors.WaitCursor
            Call LoadEWord(AIDictionary.listEWord)

            AIDictionary.Text = ""
            AIDictionary.Focus()
            searchOption = 2

            Cursor = Cursors.Default
            gbSearchEngine.Text = "រកពាក្យបែប"
            lblLoading.Text = ""
            'pbLoading.Visible = False
            Me.Close()
        Else
            Exit Sub
        End If
        
    End Sub

    Private Sub rbFilterSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFilterSearch.CheckedChanged
        If rbFilterSearch.Checked = True Then
            'btnSearch.Enabled = True
            AIDictionary.listEWord.Items.Clear()
            AIDictionary.txtSearch.Text = ""
            AIDictionary.txtDefinition.Text = ""
            AIDictionary.txtSearch.Focus()
            searchOption = 1
        Else
            Exit Sub
        End If
        AIDictionary.HideNote()
    End Sub

End Class