#Region "AI Global"
Option Strict Off
Option Explicit On

#End Region

Public Class AIRecognition

#Region "AI Recognition Declaration"

    '=====Recognition========================================================================================'
    Dim WithEvents RecoContext As SpeechLib.SpSharedRecoContext
    Dim Grammar As SpeechLib.ISpeechRecoGrammar

    Dim m_bRecoRunning As Boolean
    Dim m_cChars As Short
    '=====End Recognition========================================================================================'

#End Region

#Region "AI Recognition Function"

    Sub StartRecord()
        System.Diagnostics.Debug.Assert(Not m_bRecoRunning, "sfsd")

        If (RecoContext Is Nothing) Then
            Debug.Print("Initializing SAPI reco context object...")
            RecoContext = New SpeechLib.SpSharedRecoContext
            Grammar = RecoContext.CreateGrammar(1)
            Grammar.DictationLoad()
        End If

        Grammar.DictationSetState(SpeechLib.SpeechRuleState.SGDSActive)
        SetState(True)
    End Sub

    Sub StopRecord()
        System.Diagnostics.Debug.Assert(m_bRecoRunning, "")
        Grammar.DictationSetState(SpeechLib.SpeechRuleState.SGDSInactive)
        SetState(False)
    End Sub

    Private Sub RecoContext_Recognition(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal RecognitionType As SpeechLib.SpeechRecognitionType, ByVal Result As SpeechLib.ISpeechRecoResult) Handles RecoContext.Recognition
        Dim strText As String
        strText = Result.PhraseInfo.GetText
        Debug.Print("Recognition: " & strText & ", " & StreamNumber & ", " & StreamPosition)
        txtRecorder.SelectionStart = m_cChars
        txtRecorder.SelectedText = strText & " "
        m_cChars = m_cChars + 1 + Len(strText)
    End Sub

    Private Sub SetState(ByVal bNewState As Boolean)
        m_bRecoRunning = bNewState
        btnStart.Enabled = Not m_bRecoRunning
        btnStop.Enabled = m_bRecoRunning
    End Sub

    Sub SaveToText(ByVal tb As TextBox)
        'Dim fs As New FileStream(Application.StartupPath & ("/myNotepad.txt"), FileMode.Create

        SaveFileDialogText.Filter = "Text File (*.txt)|*.txt"
        SaveFileDialogText.Title = "AIDictionary SaveFile"
        SaveFileDialogText.FileName = "*.txt"
        If SaveFileDialogText.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim sw As New System.IO.StreamWriter(SaveFileDialogText.FileName)
            'Dim sw As New StreamWriter(fs)
            Dim data As String = tb.Text
            sw.Write(data)
            sw.Close()
            'fs.Close()

        End If
    End Sub
#End Region

#Region "AI Recognition Control Events"

    Private Sub AIRecognition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        SetState(False)
        m_cChars = 0
        txtRecorder.Focus()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Call StartRecord()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Call StopRecord()
    End Sub

#End Region

    
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error Resume Next
        If txtRecorder.Text = "" Then
            fMessage.ShowDialog()
            Exit Sub
        Else
            Call SaveToText(txtRecorder)
        End If

    End Sub
End Class