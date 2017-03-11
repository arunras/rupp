﻿Public Class AIKK

#Region "English-English Function"
    'Filter words to listWord which like txtSearch
    Sub FilterSearchedWord(ByVal key As String)
        'On Error Resume Next
        If key <> "" Then
            Com.CommandText = "SELECT kWord,kDefinition FROM tbKK WHERE kWord LIKE " & "'%" & key & "%'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = Com.ExecuteReader
            listKWord.Items.Clear()
            Do While dr1.Read = True
                listKWord.Items.Add(dr1.Item(0))
            Loop
            dr1.Close()
        End If
        If listKWord.Items.Count <> 0 Then
            listKWord.SelectedIndex = 0
        End If
    End Sub

    'Search Engine(Option)

    Sub SearchEngine(ByVal key As String)
        Call SearchFilter(key)
    End Sub
    
    'Search Engine like filter
    Sub SearchFilter(ByVal key As String)
        If key <> "" Then
            Com.CommandText = "SELECT eDefinition FROM tbEE WHERE eWord = " & "'" & key & "'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = Com.ExecuteReader
            If dr1.Read = True Then
                ''listKWords.SelectedIndex = listKWords.FindString(txtSearch.Text)
                txtDefinition.Text = HTMLToText(dr1.Item(0)) 'RemoveHTMLTags(dr1.Item(0))
                dr1.Close()
            End If
        End If
    End Sub

    'Fast search by keypress on txtSearch (Fast)
    Sub SearchFast(ByVal key As String)
        If key <> "" Then
            Com.CommandText = "SELECT eDefinition FROM tbEE WHERE eWord = " & "'" & key & "'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = Com.ExecuteReader
            If dr1.Read = True Then
                ''listKWords.SelectedIndex = listKWords.FindString(txtSearch.Text)
                txtDefinition.Text = dr1.Item(0) 'RemoveHTMLTags(dr1.Item(0))
            End If
            dr1.Close()
        End If
    End Sub

    Sub pasteClipboard(ByVal txt As TextBox)
        If (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) Then
            txt.Text = Clipboard.GetDataObject().GetData(DataFormats.Text).ToString()
        Else
            'txt.Text = "The clipboad does not contain any text"
            'Clipboard.Clear()
        End If
    End Sub

    Function HTMLToText(ByVal html As String) As String
        Dim h2t As New Chilkat.HtmlToText()

        '  Any string argument automatically begins the 30-day trial.
        Dim success As Boolean
        success = h2t.UnlockComponent("30-day trial")
        If (success <> True) Then
            MsgBox(h2t.LastErrorText)
            Return 0
            Exit Function
        End If
        '  Set the HTML:
        'Dim html As String
        'html = "<html><body><p><font color=blue>This is a test.</font></p><blockquote>Here is text within a blockquote</blockquote></body></html>"
        Dim plainText As String
        plainText = h2t.ToText(html)
        Return plainText
        'txtDefinition.Text = TextBox1.Text & plainText & vbCrLf
    End Function

#End Region

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        fNewKK.ShowDialog()
    End Sub

    Private Sub AIKK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call openConnection()
        Clipboard.Clear()
        listKWord.Items.Clear()
        Call LoadKK(listKWord)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim t As String = txtSearch.Text.Replace("'", "")
        t = t.Trim
        t.Replace("'", "")
        Call FilterSearchedWord(t)
    End Sub

    Private Sub listKWord_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listKWord.SelectedIndexChanged
        Dim t As String = listKWord.SelectedItem
        Call SearchKK(t)
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            listKWord.Focus()
            Call btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub txtSearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSearch.MouseClick

        Call pasteClipboard(txtSearch)
        Call btnSearch_Click(sender, e)

    End Sub

End Class