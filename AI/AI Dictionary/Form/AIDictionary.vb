#Region "Global AI"
Option Strict Off
Option Explicit On
'=====Imports========================================================================================'
Imports System.IO
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Text.StringBuilder
Imports System.Text

Imports System.DateTime
Imports System.Environment
Imports SpeechLib
'=====End Imports========================================================================================'
#End Region

Public Class AIDictionary

#Region "AID Declaration"
    Dim pattern As String = "abcdefghijklmnopqrstuvwxyz"
    Dim arrPattern(25) As String
    Dim arrSearch(0) As String
    Dim matchIndex As Integer = 0
    Dim strM As String = ""
    Dim getWord As String
    Dim strText As String = ""
    Dim result As New SortedList
    Public SelectIndex As Integer
    Dim prefixSearch As Boolean = False
#End Region

#Region "AI Speech Declaration"
    '=====Speech========================================================================================'
    Public WithEvents vow As New SpVoice 'Public Voice = New SpeechLib.SpVoice
    Dim m_speakFlags As SpeechVoiceSpeakFlags
    Const DefaultFmt = "SAFT22kHz16BitMono" ' This is the default format we will use.
    Private m_bSpeaking As Boolean ' m_speaking indicates whether a speak task is in progress
    Private m_bPaused As Boolean ' m_paused indicates whether Voice.Pause is called

    Public vowRate As Integer = 1
    '=====End Speech========================================================================================'
#End Region

#Region "English-Khmer Function"
    'Filter words to listWord which like txtSearch
    Sub FilterSearchedWord(ByVal key As String)
        On Error Resume Next
        If key <> "" Then
            Com.CommandText = "SELECT word,definition FROM tblEK WHERE word LIKE " & "'%" & key & "%'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = Com.ExecuteReader
            listEWord.Items.Clear()
            Do While dr1.Read = True
                listEWord.Items.Add(dr1.Item(0))
            Loop
            dr1.Close()
        End If
        If listEWord.Items.Count <> 0 Then
            listEWord.SelectedIndex = 0
        End If
    End Sub

    'Search Engine(Option)
    Sub SearchEngine(ByVal key As String)
        If searchOption = 1 Then
            Call SearchFilter(key)
            'btnSearch.Enabled = True
        ElseIf searchOption = 2 Then
            Call SearchFast(key)
            'btnSearch.Enabled = False
        End If
    End Sub
    'Search Engine like filter
    Sub SearchFilter(ByVal key As String)
        If key <> "" Then
            Com.CommandText = "SELECT * FROM tblEK WHERE word = " & "'" & key & "'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = Com.ExecuteReader
            If dr1.Read = True Then
                ''ListEWords.SelectedIndex = ListEWords.FindString(txtSearch.Text)
                SelectIndex = dr1(0)
                txtDefinition.Text = HTMLToText(dr1.Item(2)) 'RemoveHTMLTags(dr1.Item(0))
                IO.File.WriteAllText(Application.StartupPath & "\AIDictionary\temp.html", dr1.Item(2), System.Text.Encoding.UTF8)
                wbDisplay.Url = New Uri(Application.StartupPath & "\AIDictionary\temp.html")
                dr1.Close()
                HasNote()
            Else
                HideNote()
                dr1.Close()
            End If
        End If
    End Sub

    'Fast search by keypress on txtSearch (Fast)
    Sub SearchFast(ByVal key As String)
        If key <> "" Then
            Com.CommandText = "SELECT * FROM tblEK WHERE word = " & "'" & key & "'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = Com.ExecuteReader
            If dr1.Read = True Then
                ''ListEWords.SelectedIndex = ListEWords.FindString(txtSearch.Text)
                SelectIndex = dr1(0)
                txtDefinition.Text = HTMLToText(dr1.Item(2)) 'RemoveHTMLTags(dr1.Item(0))
                IO.File.WriteAllText(Application.StartupPath & "\AIDictionary\temp.html", dr1.Item(2), System.Text.Encoding.UTF8)
                wbDisplay.Url = New Uri(Application.StartupPath & "\AIDictionary\temp.html")
                dr1.Close()
                HasNote()
                prefixSearch = True
            Else
                dr1.Close()
                HideNote()
                prefixSearch = False
            End If
        End If
    End Sub



#End Region

#Region "AI English-Khmer Control Events"

    Private Sub AIDictionary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerTime.Enabled = True
        txtSearch.Focus()
        'Call speach()
        'Call openConnection()
        'Call LoadEWord(listEWord)
        txtSearch.Focus()
        'Me.Text = Me.Text & "  " & String.Format("{0:hh:mm:ss tt}", Date.Now)
        Clipboard.Clear()
    End Sub

    Private Sub TimerTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTime.Tick
        lblTime.Text = Now.ToLongTimeString.ToString()
    End Sub


    Private Sub AIDictionary_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Clipboard.Clear()
        Application.Exit()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim t As String = txtSearch.Text.Replace("'", "")
        t = t.Trim
        t.Replace("'", "")
        Call FilterSearchedWord(t)
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        Dim hasSuffix As Boolean = False
        Dim st As String = ""
        strText = txtSearch.Text.ToLower

        If searchOption = 1 Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                Call btnSearch_Click(sender, e)
                listEWord.Focus()
            End If
        ElseIf searchOption = 2 Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                If prefixSearch = False Then
                    hasSuffix = CheckSuffix(strText)
                    CreateArrPattern(strText)
                    If hasSuffix = 1 Then
                        strMatch(arrSearch)
                    End If

                    ReplaceChar(strText)
                    ReverseChar(strText)
                    DeleteChar(strText)
                    InsertChar(strText)
                    SortArr(strText)

                    If cboWord.Visible = True Then
                        cboWord.DroppedDown = True
                        Cursor = Cursors.Default
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub listEWord_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listEWord.SelectedIndexChanged
        Dim t As String = listEWord.SelectedItem
        If searchOption = 1 Then
            'txtSearch.Text = t
            'txtSearch.Select()
        End If
        If t <> "" Then
            t = t.Replace("'", "")
        End If
        Call SearchEngine(t)
    End Sub


    Private Sub btnSpeak_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSpeak.MouseDown
        btnSpeak.Width = 30
        btnSpeak.Height = 25
        Cursor = Cursors.WaitCursor
    End Sub

    Private Sub btnSpeak_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpeak.MouseLeave
        btnSpeak.BackgroundImage = AI_Dictionary.My.Resources.Resources.Speak1
    End Sub

    Private Sub btnSpeak_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSpeak.MouseMove
        btnSpeak.BackgroundImage = AI_Dictionary.My.Resources.Resources.speak2
        btnSpeak.BackColor = Color.Transparent
    End Sub

    Private Sub btnSpeak_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSpeak.MouseUp
        btnSpeak.Width = 25
        btnSpeak.Height = 25
    End Sub

    Private Sub tbSpeakRate_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSpeakRate.Scroll
        vowRate = tbSpeakRate.Value
        ToolTip1.UseAnimation = True
        ToolTip1.SetToolTip(tbSpeakRate, tbSpeakRate.Value)
    End Sub

    Private Sub btnNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNote.Click
        If txtSearch.Text <> "" Then
            If CheckNote() = 1 Then
                AINote.txtNote.Text = "   " & getWord
                AINote.txtNote.Focus()
            End If
            AINote.Show()
        Else
            'MsgBox("សូមជ្រើសរើសពាក្យជាមុន សំវាប់កត់ត្រាបន្ថែម", MsgBoxStyle.Information)
            fMessage.ShowDialog()
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Com.CommandText = "delete from tbNote where word_id=" & SelectIndex
        Dr = Com.ExecuteReader
        Dr.Close()
        HideNote()
    End Sub
    Public Sub HideNote()
        txtNote.Text = ""
        txtNote.Visible = False
        lblMyNote.Visible = False
        btnDelete.Visible = False
        'txtSearch.Focus()
    End Sub
    Private Sub cboWord_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboWord.SelectedIndexChanged
        listEWord.SelectedIndex = listEWord.FindString(cboWord.Text)
        SelectIndex = listEWord.SelectedIndex + 1
        'HasNote()
        'Dim t As String = listEWord.SelectedItem
        'Call Search(t)
        cboWord.Visible = False
        txtSearch.Visible = True
        txtSearch.Text = cboWord.Text
        txtSearch.Focus()
    End Sub

    Private Sub cboWord_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboWord.TextChanged
        cboWord.Visible = False
        txtSearch.Visible = True
        txtSearch.Text = cboWord.Text
        txtSearch.Focus()
        'btnNote.Visible = False
    End Sub

    Private Sub btnEE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEE.Click
        AIEE.ShowDialog()
    End Sub

    Private Sub btnKK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKK.Click
        AIKK.ShowDialog()
    End Sub

    Private Sub btnKE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKE.Click
        AIKE.ShowDialog()
    End Sub

    Private Sub btnAIRecognition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAIRecognition.Click
        AIRecognition.ShowDialog()
    End Sub

    Private Sub btnAISpeech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAISpeech.Click
        AISpeech.ShowDialog()
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        fSetting.ShowDialog()
    End Sub

    Private Sub btnSpeak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeak.Click
        Application.DoEvents()
        Call speakWord()
        Cursor = Cursors.Default
    End Sub

    Private Sub txtSearch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSearch.MouseClick
        Call pasteClipboard(txtSearch)
        If searchOption = 1 Then
            Call btnSearch_Click(sender, e)
        End If
        Clipboard.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        On Error Resume Next
        If txtSearch.Text <> "" Then
            If searchOption = 2 Then
                listEWord.SelectedIndex = listEWord.FindString(txtSearch.Text)
                SelectIndex = listEWord.SelectedIndex + 1
                Dim t As String = listEWord.SelectedItem
                Call SearchEngine(Trim(txtSearch.Text))
            Else
                'something()
            End If
        Else
            txtDefinition.Text = ""
            HideNote()
        End If

    End Sub


#End Region '"end AI Control Events"

#Region "AI Speech"

    'English-Khmer Speech
    Sub speakWord()
        vow.Rate = vowRate
        vow.Volume = 100
        Try
            vow.Speak(listEWord.SelectedItem, SpeechVoiceSpeakFlags.SVSFDefault)
            'vox.Speak(txtDefinition.Text, SpeechVoiceSpeakFlags.SVSFDefault)
        Catch ex As Exception
            vow.Rate = -3
            vow.Speak("Sarkal Vichealai Pumin Phnom Penh Departement Porraameen Vichea Artificial Intelligenct " _
                     & " AI Dictionary", SpeechVoiceSpeakFlags.SVSFDefault)
        End Try
    End Sub

#End Region

#Region "Probability Function (Anal)"

    Public Sub strMatch(ByVal arrMatch() As String)
        Dim alreadyExist As Boolean
        Dim returnSearch As Integer
        Dim Probab As Double
        Dim key As String = ""
        Dim i As Integer

        For k As Integer = 0 To arrMatch.Length - 1
            If arrMatch(k) <> "" Then
                key &= arrMatch(k)
            End If
        Next
        key = Trim(key)

        returnSearch = BinarySearch(key)
        If returnSearch = 1 Then
            If result.Count > 0 Then
                For i = 0 To result.Count - 1
                    If result.ContainsValue(key) Then
                        alreadyExist = True
                        Exit For
                    End If
                Next
            End If
            If alreadyExist <> True Then
                Probab = Fuzzy(key)
                Probab = Probab + 0.000001 'to make it's format 0.00000
                If result.ContainsKey(Probab) Then
                    If key.Substring(0, 1) = strText.Substring(0, 1) Then
                        Probab = Probab + result.Count * 0.00003
                    Else
                        Probab = Probab + result.Count * 0.0000001
                    End If
                End If
                result.Add(Probab, key)
            End If
        End If
    End Sub
    Public Function BinarySearch(ByVal key As String) As Integer
        Dim lowIndex As Integer = 0
        Dim highIndex As Integer = arrWord.GetUpperBound(0)
        Dim midIndex As Integer

        While lowIndex <= highIndex
            midIndex = (lowIndex + highIndex) / 2
            If key = arrWord(midIndex) Then
                Return 1
            ElseIf key > arrWord(midIndex) Then
                lowIndex = midIndex + 1
            ElseIf key < arrWord(midIndex) Then
                highIndex = midIndex - 1
            End If
        End While
        Return -1
    End Function
    Public Function Fuzzy(ByVal key As String) As Double
        Dim p As Double
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim arrMatch(0) As String
        ReDim Preserve arrMatch(key.Length - 1)
        For x As Integer = 0 To key.Length - 1
            arrMatch(x) = key.Substring(x, 1)
        Next

        While (i < arrMatch.Length)
            If i = 0 Then
                If arrMatch(i) = arrSearch(j) Then
                    p = p + 1
                ElseIf arrMatch(i) = arrSearch(j + 1) Then
                    p = p + 0.75
                End If
            ElseIf i = arrMatch.Length - 1 Then
                If arrMatch.Length = arrSearch.Length Then
                    If arrMatch(i) = arrSearch(j) Then
                        p = p + 1
                    ElseIf arrMatch(i) = arrSearch(j - 1) Then
                        p = p + 0.75
                    End If
                ElseIf arrMatch.Length > arrSearch.Length Then
                    If arrMatch(i) = arrSearch(j - 1) Then
                        p = p + 0.75
                    End If
                ElseIf arrMatch.Length < arrSearch.Length Then
                    If arrMatch(i) = arrSearch(i + 1) Then
                        p = p + 0.75
                    End If
                End If
            ElseIf i > 0 And i < arrMatch.Length - 1 Then
                If j < arrSearch.Length - 1 Then
                    If arrMatch(i) = arrSearch(j) Then
                        p = p + 1
                    ElseIf arrMatch(i) = arrSearch(j - 1) Or arrMatch(i) = arrSearch(j + 1) Then
                        p = p + 0.75
                    End If
                Else
                    If arrMatch(i) = arrSearch(j) Then
                        p = p + 1
                    ElseIf arrMatch(i) = arrSearch(j - 1) Then
                        p = p + 0.75
                    End If
                End If
            End If
            i = i + 1
            j = j + 1
        End While
        p = (p * 100) / arrSearch.Length
        Return p
    End Function

    Private Function CheckSuffix(ByVal Text As String) As Boolean
        Dim mStr As String = ""
        If Text.Length > 3 Then
            mStr = Text.Substring(Text.Length - 3, 3)
            If mStr = "ies" Or mStr = "ied" Then
                strText = Text.Substring(0, Text.Length - 3) & "y"
                Return 1
            End If
        End If
        If Text.Length > 2 Then
            mStr = Text.Substring(Text.Length - 2, 2)
            If mStr = "ed" Or mStr = "es" Then
                strText = Text.Substring(0, Text.Length - 2)
                Return 1
            End If
        End If
    End Function
    Private Sub CreateArrPattern(ByVal Text As String)
        For i As Integer = 0 To pattern.Length - 1
            arrPattern(i) = pattern.Substring(i, 1)
        Next

        'create array Search words
        ReDim arrSearch(Text.Length - 1)
        For j As Integer = 0 To Text.Length - 1
            arrSearch(j) = Text.Substring(j, 1)
        Next
    End Sub
    Public Sub InsertChar(ByVal key As String)
        key = Trim(key)
        Dim arrCompare(arrSearch.Length) As String
        For k As Integer = 0 To arrPattern.Length - 1
            For r As Integer = 0 To arrSearch.Length - 1
                arrCompare(r) = arrSearch(r)
            Next
            arrCompare(arrCompare.Length - 1) = arrPattern(k)
            For x As Integer = arrCompare.Length - 1 To 0 Step -1
                Dim t As Char
                If x < arrCompare.Length - 1 Then
                    t = arrCompare(x)
                    arrCompare(x) = arrCompare(x + 1)
                    arrCompare(x + 1) = t
                End If
                strMatch(arrCompare)
            Next
        Next
    End Sub


    Private Sub DeleteChar(ByVal key As String)
        Dim arrCompare(key.Length - 1) As String
        For x As Integer = arrCompare.Length - 1 To 0 Step -1
            For i As Integer = 0 To arrSearch.Length - 1
                arrCompare(i) = arrSearch(i)
            Next
            'x = 0
            arrCompare(x) = " "
            strMatch(arrCompare)
        Next
    End Sub

    Private Sub ReplaceChar(ByVal key As String)
        key = Trim(key)
        For k As Integer = 0 To arrPattern.Length - 1
            For x As Integer = arrSearch.Length - 1 To 0 Step -1
                Dim arrCompare(arrSearch.Length - 1) As String
                For i As Integer = 0 To arrSearch.Length - 1
                    arrCompare(i) = arrSearch(i)
                Next
                arrCompare(x) = arrPattern(k)
                strMatch(arrCompare)
            Next
        Next
    End Sub

    Private Sub ReverseChar(ByVal key As String)
        key = Trim(key)
        For i = arrSearch.Length - 1 To 1 Step -1
            Dim t As Char
            Dim arrCompare(arrSearch.Length - 1) As String
            For x As Integer = 0 To arrSearch.Length - 1
                arrCompare(x) = arrSearch(x)
            Next
            t = arrCompare(i)
            arrCompare(i) = arrCompare(i - 1)
            arrCompare(i - 1) = t
            strMatch(arrCompare)
        Next
    End Sub

    Public Sub SortArr(ByVal key As String)
        Dim sx(0) As String
        Dim i As Integer
        Dim j As Integer = 0
        Dim sm As String = ""
        For Each Val As String In result.Values
            ReDim Preserve sx(i)
            sx(i) = Val
            i = i + 1
        Next

        'For Each k As String In result.Keys
        '    sx(j) = sx(j) & vbTab & k.Substring(0, 5)
        '    j = j + 1
        'Next
        'For x As Integer = sx.Length - 1 To 0 Step -1
        '    sm &= sx(x) & vbCrLf
        'Next
        'MsgBox(sm)

        result.Clear()
        cboWord.Items.Clear()
        For index As Integer = sx.Length - 1 To 0 Step -1
            If sx(index) <> "" Then
                cboWord.Items.Add(sx(index))
            End If
        Next
        If cboWord.Items.Count > 0 Then
            txtSearch.Visible = False
            cboWord.Text = txtSearch.Text
            cboWord.Visible = True
            cboWord.Focus()
        Else
            cboWord.Visible = False
            txtSearch.Visible = True
            txtSearch.Focus()
        End If
    End Sub

    Sub HasNote()
        If CheckNote() = 1 Then
            lblMyNote.Visible = True
            txtNote.Text = "   " & getWord
            txtNote.Visible = True
            btnDelete.Visible = True
        Else
            HideNote()
        End If
    End Sub
    Public Function CheckNote() As Integer
        Dim dr2 As OleDb.OleDbDataReader
        Com.CommandText = "Select My_Note from tbNote where word_id=" & CInt(SelectIndex)
        getWord = ""
        dr2 = Com.ExecuteReader
        If dr2.Read = True Then
            getWord = dr2(0)
            dr2.Close()
            Return 1
        End If
        dr2.Close()
        Return -1
    End Function

#End Region '"end Probability Function (Anal)"


    Private Sub lblRUPP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("AI Dictionary" & vbCrLf & vbCrLf & "Copyright (c) 2011 AID Team. All rights reserved.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "About AIDictionary")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        fAbout.ShowDialog()
    End Sub

End Class