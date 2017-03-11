#Region "Imports Block"
Option Strict Off
Option Explicit On

Imports System.IO
Imports System.Collections

Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbCommand
Imports System.Data.OleDb.OleDbDataReader
Imports System.Data.OleDb.OleDbDataAdapter
#End Region

Module AImodule

#Region "Declaration Block"
    Public Con As New OleDb.OleDbConnection
    Public Com As New OleDb.OleDbCommand
    Public Dr As OleDb.OleDbDataReader
    Public searchOption As Integer = 1
    Public searchOptionKE As Integer = 1
    Public searchOptionKK As Integer = 1
    Public searchOptionEE As Integer = 1

    'TTSAppMod
    Declare Function GetSysColor Lib "user32" (ByVal index As Integer) As Integer
    Public Const COLOR_BTNFACE As Short = 15
    Public Const COLOR_3DFACE As Short = COLOR_BTNFACE

    'data
    Dim tbKE As Hashtable
    Dim tbEE As Hashtable
    Dim tbKK As Hashtable
    Public arrWord(0) As String
#End Region

#Region "Open Connection Function"
    Sub openConnection()
        Try
            Con.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=EK.mdb"
            Con.Open()
            Com.Connection = Con
        Catch ex As Exception
            MsgBox("No Database!")
        End Try
    End Sub
#End Region
    
#Region "Load Words to List"
    Sub LoadEWord(ByVal listE As ListBox)
        Dim i As Integer
        Com.CommandText = "SELECT word FROM tblEK" ' WHERE word_id=1"
        Dr = Com.ExecuteReader
        Try
            listE.Items.Clear()
            While Dr.Read = True
                listE.Items.Add(Dr(0))
                If fSetting.rbFastSearch.Checked = True Then
                    ReDim Preserve arrWord(arrWord.Length)
                    arrWord(i) = Dr(0).ToString.ToLower
                    i += 1
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'Com.Dispose()
        Dr.Close()
        'AIDictionary1.gpSearchEngine.Text = "Search Engine"
        'AIDictionary1.Cursor = Cursors.Default
    End Sub

    Sub LoadKEWord(ByVal listE As ListBox)
        Com.CommandText = "SELECT Kword,kDefinition FROM tbKE" ' WHERE word_id=1"
        Dr = Com.ExecuteReader
        Try
            listE.Items.Clear()
            While Dr.Read = True
                listE.Items.Add(Dr(0))
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
        'Com.Dispose()
        Dr.Close()
        'AIDictionary1.gpSearchEngine.Text = "Search Engine"
        'AIDictionary1.Cursor = Cursors.Default
    End Sub

    Sub LoadKE(ByVal listName As ListBox)
        'On Error Resume Next
        tbKE = New Hashtable
        Com.CommandText = "SELECT kWord,kDefinition FROM tbKE" ' WHERE word_id=1"
        Dr = Com.ExecuteReader
        Try
            listName.Items.Clear()
            While Dr.Read = True
                'listName.Items.Add(Dr(0))
                tbKE.Add(Dr(0), Dr(1))
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Dr.Close()

        '''''''''''''
        Dim keys As ICollection = tbKE.Keys
        Dim keysArray(tbKE.Count - 1) As String
        keys.CopyTo(keysArray, 0)
        Array.Sort(keysArray)

        For Each key As String In keysArray
            listName.Items.Add(key)
        Next
    End Sub

    Sub SearchKE(ByVal key As String)

        If key <> "" Then
            If tbKE.ContainsKey(key) Then
                AIKE.txtDefinition.Text = tbKE(key) 'RemoveHTMLTags(dr1.Item(0))
            End If
        End If

    End Sub

    Sub LoadEEWord(ByVal listE As ListBox)
        Com.CommandText = "SELECT eWord FROM tbEE" ' WHERE word_id=1"
        Dr = Com.ExecuteReader
        Try
            listE.Items.Clear()
            While Dr.Read = True
                listE.Items.Add(Dr(0))
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
        'Com.Dispose()
        Dr.Close()
        'AIDictionary1.gpSearchEngine.Text = "Search Engine"
        'AIDictionary1.Cursor = Cursors.Default
    End Sub

    Sub LoadEE(ByVal listName As ListBox)
        'On Error Resume Next
        tbEE = New Hashtable

        Com.CommandText = "SELECT eWord,eDefinition FROM tbEE" ' WHERE word_id=1"
        Dr = Com.ExecuteReader
        Try
            listName.Items.Clear()
            While Dr.Read = True
                'listName.Items.Add(Dr(0))
                tbEE.Add(Dr(0), Dr(1))
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Dr.Close()

        '''''''''''''
        Dim keys As ICollection = tbEE.Keys
        Dim keysArray(tbEE.Count - 1) As String
        keys.CopyTo(keysArray, 0)
        Array.Sort(keysArray)

        For Each key As String In keysArray
            listName.Items.Add(key)
        Next
    End Sub

    Sub SearchEE(ByVal key As String)

        If key <> "" Then
            If tbEE.ContainsKey(key) Then
                AIEE.txtDefinition.Text = tbEE(key) 'RemoveHTMLTags(dr1.Item(0))
            End If
        End If

    End Sub

    Sub LoadKKWord(ByVal listE As ListBox)
        Com.CommandText = "SELECT kWord FROM tbKK" ' WHERE word_id=1"
        Dr = Com.ExecuteReader
        Try
            listE.Items.Clear()
            While Dr.Read = True
                listE.Items.Add(Dr(0))
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
        'Com.Dispose()
        Dr.Close()
        'AIDictionary1.gpSearchEngine.Text = "Search Engine"
        'AIDictionary1.Cursor = Cursors.Default
    End Sub

    Sub LoadKK(ByVal listName As ListBox)
        'On Error Resume Next
        tbKK = New Hashtable

        Com.CommandText = "SELECT kWord,kDefinition FROM tbKK" ' WHERE word_id=1"
        Dr = Com.ExecuteReader
        Try
            listName.Items.Clear()
            While Dr.Read = True
                'listName.Items.Add(Dr(0))
                tbKK.Add(Dr(0), Dr(1))
            End While
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Dr.Close()

        '''''''''''''
        Dim keys As ICollection = tbKK.Keys
        Dim keysArray(tbKK.Count - 1) As String
        keys.CopyTo(keysArray, 0)
        Array.Sort(keysArray)

        For Each key As String In keysArray
            listName.Items.Add(key)
        Next
    End Sub

    Sub SearchKK(ByVal key As String)

        If key <> "" Then
            If tbKK.ContainsKey(key) Then
                AIKK.txtDefinition.Text = tbKK(key) 'RemoveHTMLTags(dr1.Item(0))
            End If
        End If

    End Sub

#End Region

#Region "General Function"
    Sub FadeForm(ByVal FadeForm As Form, ByVal NumberOfSteps As Byte)
        Dim StepVal As Double = Convert.ToDouble(100.0F / NumberOfSteps)
        Dim dOpacity As Double = 100.0F
        Dim b As Byte = 0
        For b = 0 To NumberOfSteps
            FadeForm.Opacity = dOpacity / 100
            FadeForm.Refresh()
            dOpacity -= StepVal
        Next
    End Sub

    Function Field(ByVal fil As String) As String
        Dim f As String
        If fil = "" Then
            f = "'NA'"
        Else
            f = "'" & fil & "'"
        End If
        Return f
    End Function
#End Region

    
#Region "Using File Dictionary"

    Sub FileLoadToList(ByVal listE As ListBox, ByVal key As String)
        If tbKE.ContainsKey(key) Then
            listE.Items.Add(tbKE.Keys)
        End If
    End Sub

    Sub FileLoadEK(ByVal listName As ListBox)
        On Error Resume Next
        Dim fEK As New FileStream(Application.StartupPath & ("/AIDictionary/tbEK.txt"), FileMode.Open)
        Dim ekReader As New StreamReader(fEK)
        Dim eStr As String
        'Dim tbEK As New Hashtable
        Dim cols() As String
        Dim i As Integer

        While Not ekReader.EndOfStream
            i = i + 1
            eStr = ekReader.ReadLine
            cols = eStr.Split(";")
            tbKE.Add(cols(1), cols(2))
        End While

        Dim keys As ICollection = tbKE.Keys
        Dim keysArray(tbKE.Count - 1) As String
        keys.CopyTo(keysArray, 0)
        Array.Sort(keysArray)

        For Each key As String In keysArray
            listName.Items.Add(key)
        Next

        ekReader.Close()
        fEK.Close()
    End Sub


    Sub FileSearch(ByVal key As String)

        If key <> "" Then
            If tbKE.ContainsKey(key) Then
                AIDictionary.txtDefinition.Text = HTMLToText(tbKE(key)) 'RemoveHTMLTags(dr1.Item(0))
                Call FileFilterSearchedWord(key)
            End If
        End If

    End Sub

    'Filter words to listWord which like txtSearch
    Sub FileFilterSearchedWord(ByVal key As String)
        On Error Resume Next
        If key <> "" Then
            AIDictionary.listEWord.Items.Clear()
            AIDictionary.listEWord.Items.Add(key)
        End If
        If AIDictionary.listEWord.Items.Count <> 0 Then
            AIDictionary.listEWord.SelectedIndex = 0
        End If
    End Sub

    Sub LoadTbEK(ByVal listName As ListBox)
        Dim keys As ICollection = tbKE.Keys
        Dim keysArray(tbKE.Count - 1) As String
        keys.CopyTo(keysArray, 0)
        Array.Sort(keysArray)

        For Each key As String In keysArray
            listName.Items.Add(key)
        Next
    End Sub
#End Region

#Region "Speech Function"

#End Region

#Region "Function"
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

    Sub PlaySound(ByVal f As String)
        Try
            My.Computer.Audio.Play(Application.StartupPath & "\AIDictionary\" & f, AudioPlayMode.BackgroundLoop)
        Catch
            Exit Sub
        End Try
    End Sub
    Sub StopSound()
        My.Computer.Audio.Stop()
    End Sub

#End Region

End Module
