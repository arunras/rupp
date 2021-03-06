Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Public Class AISpeech
    Inherits System.Windows.Forms.Form

#Region "AI Speech Recognition Declaration"
    ' First, declare the main SAPI object we are using in this sample. It is
    ' created inside Form_Load and released inside Form_Unload.
    Dim WithEvents Voice As SpeechLib.SpVoice
    Dim vox As SpeechLib.SpVoice

    ' Speak flags is a combination of bit flags. These individual bits correspond
    ' to check boxes on the UI. So m_speakFlags should always be kept in sync
    ' with the state of those check boxes.
    Dim m_speakFlags As SpeechLib.SpeechVoiceSpeakFlags

    ' This is the default format we will use.
    Const DefaultFmt As String = "SAFT22kHz16BitMono"

    ' We will disable the output combo box and show this if there's no audio output.
    Const NoAudioOutput As String = "No audio ouput object available"

    ' We will enable/disable menu items and buttons based on current state
    ' m_speaking indicates whether a speak task is in progress
    ' m_paused indicates whether Voice.Pause is called
    Private m_bSpeaking As Boolean
    Private m_bPaused As Boolean
    Private btnPauseResume As Boolean

#End Region

#Region "AI Control Events"

    Private Sub AudioOutputCB_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AudioOutputCB.SelectedIndexChanged
        On Error GoTo ErrHandler

        ' change the output to the selected one
        Voice.AudioOutput = Voice.GetAudioOutputs().Item(AudioOutputCB.SelectedIndex)

        ' changing output may have also changed the format, so call function
        ' FormatCB_Click to make sure we are using the format as selected
        FormatCB_SelectedIndexChanged(FormatCB, New System.EventArgs())
        Exit Sub

ErrHandler:
        AddDebugInfo("Set audio output error: ", Err.Description)
    End Sub

    Private Sub FormatCB_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FormatCB.SelectedIndexChanged
        On Error GoTo ErrHandler

        ' Note: AllowAudioOutputFormatChangesOnNextSet is a hidden property, VB
        ' object browser doesn't show it by default. To see it, you can go to
        ' VB object viewer, right click and turn on the "show hidden members".
        Voice.AllowAudioOutputFormatChangesOnNextSet = False

        ' The format Type is associated with the selected list item as a long.
        Voice.AudioOutputStream.Format.Type = VB6.GetItemData(FormatCB, FormatCB.SelectedIndex)

        ' Currently you have to call this so that SAPI picks up the new format.
        Voice.AudioOutputStream = Voice.AudioOutputStream

        Exit Sub

ErrHandler:
        AddDebugInfo("Set format error: ", Err.Description)
    End Sub

    Public Sub menuFileOpenText_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileOpenText.Click
        Call openTextFile()
    End Sub

    Public Sub menuFileSaveToWave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileSaveToWave.Click
        Call SaveToWav()
    End Sub

    Public Sub menuFileSpeakWave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles menuFileSpeakWave.Click
        Call SpeakWavFile()
    End Sub

    Private Sub PauseBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PauseBtn.Click
        Select Case PauseBtn.Text
            Case "ផ្អាក"
                AddDebugInfo("Pause")
                Voice.Pause()
                SetSpeakingState(m_bSpeaking, True)
                switchGIF("Speaker1.gif")

            Case "បន្ត"
                AddDebugInfo("Resume")
                Voice.Resume()
                SetSpeakingState(m_bSpeaking, False)
                switchGIF("Speaker.gif")
        End Select

    End Sub

    Private Sub RateSldr_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RateSldr.Scroll
        Voice.Rate = RateSldr.Value
        lblRate.Text = RateSldr.Value

        ToolTip1.UseAnimation = True
        ToolTip1.SetToolTip(RateSldr, RateSldr.Value)
    End Sub

    Private Sub ResetBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ResetBtn.Click
        'set output to default
        AudioOutputCB.SelectedIndex = 0
        'UPGRADE_NOTE: Object Voice.AudioOutput may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Voice.AudioOutput = Nothing

        'use default voice
        VoiceCB.SelectedIndex = 0

        'Format to default
        FormatCB.Text = DefaultFmt

        'reset main text field
        txtMainBox.Text = "Enter text you wish spoken here."

        'reset volume and rate
        VolumeSldr.Value = 100
        VolumeSldr_Scroll(VolumeSldr, New System.EventArgs())

        RateSldr.Value = 0
        RateSldr_Scroll(RateSldr, New System.EventArgs())

        ' reset speak flags
        m_speakFlags = SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync Or SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak Or SpeechLib.SpeechVoiceSpeakFlags.SVSFIsXML
        chkSpFlagAync.CheckState = System.Windows.Forms.CheckState.Checked
        chkSpFlagPurgeBeforeSpeak.CheckState = System.Windows.Forms.CheckState.Checked
        chkSpFlagIsXML.CheckState = System.Windows.Forms.CheckState.Checked
        chkSpFlagIsFilename.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkSpFlagNLPSpeakPunc.CheckState = System.Windows.Forms.CheckState.Unchecked
        chkSpFlagPersistXML.CheckState = System.Windows.Forms.CheckState.Unchecked

        'reset DebugTxtbox text
        DebugTxtBox.Text = CStr(Nothing)

        'reset skip text box
        '<<<RUN>>>'SkipTxtBox.Text = "0"

        nudSkip.Value = 0

        'UPGRADE_ISSUE: MSComctlLib.ImageList method MouthImgList.Overlay was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '<<<RUN>>>' VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICFULL")

        ' if it's paused, call Resume to reset state
        If m_bPaused Then
            Voice.Resume()
            switchGIF("Speaker1.gif")
        End If


        SetSpeakingState(False, False)
    End Sub

    Private Sub SkipBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SkipBtn.Click
        On Error GoTo ErrHandler
        Dim SkipType As String
        Dim SkipNum As Short

        AddDebugInfo("Skip")

        ' skip by the number specified
        '<<<RUN>>>' SkipNum = CShort(SkipTxtBox.Text)
        SkipNum = CShort(nudSkip.Value)
        SkipType = "Sentence"

        Voice.Skip(SkipType, SkipNum)
        Exit Sub

ErrHandler:
        'MsgBox Err.Description & ":" & Err.Number, vbOKOnly, "Skip Error"
        AddDebugInfo("Skip Error: ", Err.Description)
        Exit Sub
    End Sub

    Private Sub SpeakBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SpeakBtn.Click
        On Error GoTo ErrHandler
        TimerElape.Enabled = True
        AddDebugInfo(("Speak"))

        ' exit if there's nothing to speak
        If txtMainBox.Text = "" Then
            Exit Sub
        End If

        ' If it's paused and some text still remains to be spoken, Speak button
        ' acts the same as Resume button. However a programmer can choose to
        ' speak from the beginning again or any other behavior.
        ' In other cases, we speak the text with given flags.
        If Not (m_bPaused And m_bSpeaking) Then
            ' just speak the text with the given flags
            Voice.Speak(txtMainBox.Text, m_speakFlags)
            switchGIF("Speaker.gif")
        End If

        ' Resume if Voice is paused
        If m_bPaused Then
            Voice.Resume()
            switchGIF("Speaker1.gif")
        End If


        ' set the state of menu items and buttons
        SetSpeakingState(True, False)
        Exit Sub

ErrHandler:
        AddDebugInfo("Speak Error: ", Err.Description)
        switchGIF("Speaker1.gif")
        SetSpeakingState(False, m_bPaused)
    End Sub

    Private Sub StopBtn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles StopBtn.Click
        On Error GoTo ErrHandler
        switchGIF("Speaker1.gif")
        AddDebugInfo(("Stop"))


        ' when string to speak is NULL and dwFlags is set to SPF_PURGEBEFORESPEAK
        ' it indicates to SAPI that any remaining data to be synthesized should
        ' be discarded.
        Voice.Speak(vbNullString, SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
        If m_bPaused Then
            Voice.Resume()
            switchGIF("Speaker1.gif")
        End If


        SetSpeakingState(False, False)
        Exit Sub

ErrHandler:
        AddDebugInfo("Speak Error: ", Err.Description)
        switchGIF("Speaker1.gif")
    End Sub


#End Region '"AI Control Events"

#Region "AI Speech Voice"

    Private Sub Voice_AudioLevel(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal AudioLevel As Integer) Handles Voice.AudioLevel
        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPosition. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("AudioLevel", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "AudioLevel=" & AudioLevel)
    End Sub

    Private Sub Voice_Bookmark(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal Bookmark As String, ByVal BookmarkId As Integer) Handles Voice.Bookmark
        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPosition. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("BookMark", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "Bookmark=" & Bookmark, "BookmarkId=" & BookmarkId)
    End Sub

    Private Sub Voice_EndStream(ByVal StreamNum As Integer, ByVal StreamPos As Object) Handles Voice.EndStream
        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("EndStream", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos)

        ' select all text to indicate that we are done
        HighLightSpokenWords(0, Len(txtMainBox.Text))
        switchGIF("Speaker1.gif")

        ' reset the mouth
        'UPGRADE_ISSUE: MSComctlLib.ImageList method MouthImgList.Overlay was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '<<<RUN>>>' VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICFULL")

        ' reset the state of buttons, checkboxes and menu items
        SetSpeakingState(False, m_bPaused)
    End Sub

    Private Sub Voice_EnginePrivate(ByVal StreamNumber As Integer, ByVal StreamPosition As Integer, ByVal lParam As Object) Handles Voice.EnginePrivate
        'UPGRADE_WARNING: Couldn't resolve default property of object lParam. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("EnginePrivate", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "lParam=" & lParam)
    End Sub

    Private Sub Voice_Phoneme(ByVal StreamNumber As Integer, ByVal StreamPosition As Object, ByVal Duration As Integer, ByVal NextPhoneId As Short, ByVal Feature As SpeechLib.SpeechVisemeFeature, ByVal CurrentPhoneId As Short) Handles Voice.Phoneme
        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPosition. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("Phoneme", "StreamNumber=" & StreamNumber, "StreamPosition=" & StreamPosition, "NextPhoneId=" & NextPhoneId, "Feature=" & Feature, "CurrentPhoneId=" & CurrentPhoneId)
    End Sub

    Private Sub Voice_Sentence(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Pos As Integer, ByVal Length As Integer) Handles Voice.Sentence
        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("Sentence", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Pos=" & Pos, "Length=" & Length)
    End Sub

    Private Sub Voice_StartStream(ByVal StreamNum As Integer, ByVal StreamPos As Object) Handles Voice.StartStream
        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("StartStream", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos)
        switchGIF("Speaker.gif")
        ' reset the state of buttons, checkboxes and menu items
        SetSpeakingState(True, m_bPaused)
    End Sub

    Private Sub Voice_Viseme(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Duration As Integer, ByVal VisemeType As SpeechLib.SpeechVisemeType, ByVal Feature As SpeechLib.SpeechVisemeFeature, ByVal VisemeId As Integer) Handles Voice.Viseme

        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("Viseme", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Duration=" & Duration, "VisemeType=" & VisemeType, "Feature=" & Feature, "VisemeId=" & VisemeId)

        ' Here we are going to show different mouth positions according to the viseme.
        ' The picture we show doesn't necessarily match the real mouth position.
        ' Just trying to make it more interesting.
        If VisemeId = 0 Then
            VisemeId = VisemeId + 1
        End If
        'UPGRADE_ISSUE: MSComctlLib.ImageList method MouthImgList.Overlay was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '<<<RUN>>>' VisemePicture.Image = MouthImgList.Overlay("MICFULL", VisemeId)
        If (VisemeId Mod 6 = 2) Then
            'UPGRADE_ISSUE: MSComctlLib.ImageList method MouthImgList.Overlay was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            '<<<RUN>>>' VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICEYECLOSED")
        Else
            If (VisemeId Mod 6 = 5) Then
                'UPGRADE_ISSUE: MSComctlLib.ImageList method MouthImgList.Overlay was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                '<<<RUN>>>' VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICEYENARROW")
            End If
        End If
    End Sub

    Private Sub Voice_VoiceChange(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Token As SpeechLib.ISpeechObjectToken)

        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("VoiceChange", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Token=" & Token.GetDescription)

        ' Let's sync up the combo box with the new value
        Dim i As Integer
        For i = 0 To VoiceCB.Items.Count - 1
            If VB6.GetItemString(VoiceCB, i) = Token.GetDescription() Then
                VoiceCB.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub Voice_Word(ByVal StreamNum As Integer, ByVal StreamPos As Object, ByVal Pos As Integer, ByVal Length As Integer) Handles Voice.Word

        'UPGRADE_WARNING: Couldn't resolve default property of object StreamPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ShowEvent("Word", "StreamNum=" & StreamNum, "StreamPos=" & StreamPos, "Pos=" & Pos, "Length=" & Length)

        Debug.Print(VB6.TabLayout(Pos, Length, txtMainBox.SelectionStart, txtMainBox.SelectionLength))

        ' Select the word that's currently being spoken.
        HighLightSpokenWords(Pos, Length)
    End Sub

    'UPGRADE_WARNING: Event VoiceCB.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub VoiceCB_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VoiceCB.SelectedIndexChanged
        ' change the voice to the selected one
        Voice.Voice = Voice.GetVoices().Item(VoiceCB.SelectedIndex)
    End Sub

    Private Sub VolumeSldr_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VolumeSldr.Scroll
        Voice.Volume = VolumeSldr.Value
        lblVolume.Text = VolumeSldr.Value

        ToolTip1.UseAnimation = True
        ToolTip1.SetToolTip(VolumeSldr, VolumeSldr.Value)
    End Sub

    ' The following functions are simply to sync up the speak flags.
    ' When the check box is checked, the corresponding bit is set in the flags.
    'UPGRADE_WARNING: Event chkSpFlagAync.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkSpFlagAync_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagAync.CheckStateChanged
        m_speakFlags = SetOrClearFlag(chkSpFlagAync.CheckState, m_speakFlags, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub

    'UPGRADE_WARNING: Event chkSpFlagIsFilename.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkSpFlagIsFilename_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagIsFilename.CheckStateChanged
        m_speakFlags = SetOrClearFlag(chkSpFlagIsFilename.CheckState, m_speakFlags, SpeechLib.SpeechVoiceSpeakFlags.SVSFIsFilename)
    End Sub

    'UPGRADE_WARNING: Event chkSpFlagIsXML.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkSpFlagIsXML_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagIsXML.CheckStateChanged
        ' Note: special case here. There are two flags,SVSFIsXML and SVSFIsNotXML.
        ' When neither is set, SAPI will guess by peeking at beginning characters.
        ' In this sample, we explicitly set one of them.

        If chkSpFlagIsXML.CheckState = 0 Then
            ' clear SVSFIsXML bit and set SVSFIsNotXML bit
            m_speakFlags = m_speakFlags And Not SpeechLib.SpeechVoiceSpeakFlags.SVSFIsXML
            m_speakFlags = m_speakFlags Or SpeechLib.SpeechVoiceSpeakFlags.SVSFIsNotXML
        Else
            ' clear SVSFIsNotXML bit and set SVSFIsXML bit
            m_speakFlags = m_speakFlags And Not SpeechLib.SpeechVoiceSpeakFlags.SVSFIsNotXML
            m_speakFlags = m_speakFlags Or SpeechLib.SpeechVoiceSpeakFlags.SVSFIsXML
        End If
    End Sub

    'UPGRADE_WARNING: Event chkSpFlagNLPSpeakPunc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkSpFlagNLPSpeakPunc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagNLPSpeakPunc.CheckStateChanged
        m_speakFlags = SetOrClearFlag(chkSpFlagNLPSpeakPunc.CheckState, m_speakFlags, SpeechLib.SpeechVoiceSpeakFlags.SVSFNLPSpeakPunc)
    End Sub

    'UPGRADE_WARNING: Event chkSpFlagPersistXML.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkSpFlagPersistXML_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagPersistXML.CheckStateChanged
        m_speakFlags = SetOrClearFlag(chkSpFlagPersistXML.CheckState, m_speakFlags, SpeechLib.SpeechVoiceSpeakFlags.SVSFPersistXML)
    End Sub

    'UPGRADE_WARNING: Event chkSpFlagPurgeBeforeSpeak.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkSpFlagPurgeBeforeSpeak_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkSpFlagPurgeBeforeSpeak.CheckStateChanged
        m_speakFlags = SetOrClearFlag(chkSpFlagPurgeBeforeSpeak.CheckState, m_speakFlags, SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak)
    End Sub


    'UPGRADE_NOTE: name was upgraded to name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub AddFmts(ByRef name_Renamed As String, ByVal fmt As SpeechLib.SpeechAudioFormatType)
        Dim index As String

        ' get the count of existing list so that we are adding to the bottom of the list
        index = CStr(FormatCB.Items.Count)

        ' add the name to the list box and associate the format type with the item
        FormatCB.Items.Insert(index, name_Renamed)
        VB6.SetItemData(FormatCB, index, fmt)
    End Sub

    Private Sub AddItemToFmtCB()
        AddFmts("SAFT8kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT8kHz16BitMono)
        AddFmts("SAFT8kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT8kHz8BitStereo)
        AddFmts("SAFT8kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT8kHz16BitMono)
        AddFmts("SAFT8kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT8kHz16BitStereo)

        AddFmts("SAFT11kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT11kHz8BitMono)
        AddFmts("SAFT11kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT11kHz8BitStereo)
        AddFmts("SAFT11kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT11kHz16BitMono)
        AddFmts("SAFT11kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT11kHz16BitStereo)

        AddFmts("SAFT12kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT12kHz8BitMono)
        AddFmts("SAFT12kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT12kHz8BitStereo)
        AddFmts("SAFT12kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT12kHz16BitMono)
        AddFmts("SAFT12kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT12kHz16BitStereo)

        AddFmts("SAFT16kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT16kHz8BitMono)
        AddFmts("SAFT16kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT16kHz8BitStereo)
        AddFmts("SAFT16kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT16kHz16BitMono)
        AddFmts("SAFT16kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT16kHz16BitStereo)

        AddFmts("SAFT22kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT22kHz8BitMono)
        AddFmts("SAFT22kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT22kHz8BitStereo)
        AddFmts("SAFT22kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT22kHz16BitMono)
        AddFmts("SAFT22kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT22kHz16BitStereo)

        AddFmts("SAFT24kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT24kHz8BitMono)
        AddFmts("SAFT24kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT24kHz8BitStereo)
        AddFmts("SAFT24kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT24kHz16BitMono)
        AddFmts("SAFT24kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT24kHz16BitStereo)

        AddFmts("SAFT32kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT32kHz8BitMono)
        AddFmts("SAFT32kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT32kHz8BitStereo)
        AddFmts("SAFT32kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT32kHz16BitMono)
        AddFmts("SAFT32kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT32kHz16BitStereo)

        AddFmts("SAFT44kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT44kHz8BitMono)
        AddFmts("SAFT44kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT44kHz8BitStereo)
        AddFmts("SAFT44kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT44kHz16BitMono)
        AddFmts("SAFT44kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT44kHz16BitStereo)

        AddFmts("SAFT48kHz8BitMono", SpeechLib.SpeechAudioFormatType.SAFT48kHz8BitMono)
        AddFmts("SAFT48kHz8BitStereo", SpeechLib.SpeechAudioFormatType.SAFT48kHz8BitStereo)
        AddFmts("SAFT48kHz16BitMono", SpeechLib.SpeechAudioFormatType.SAFT48kHz16BitMono)
        AddFmts("SAFT48kHz16BitStereo", SpeechLib.SpeechAudioFormatType.SAFT48kHz16BitStereo)
    End Sub

#End Region '"AI Speech Voice"

#Region "Load Mouth Images"

    Private Sub LoadMouthImages()
        ' ''		On Error GoTo ErrHandler

        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(1, "MICFULL", VB6.LoadResPicture("MICFULL", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(2,  , VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(3,  , VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(4,  , VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(5,  , VB6.LoadResPicture("MIC10", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(6,  , VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(7,  , VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(8,  , VB6.LoadResPicture("MIC2", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(9,  , VB6.LoadResPicture("MIC13", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(10,  , VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(11,  , VB6.LoadResPicture("MIC12", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(12,  , VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(13,  , VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(14,  , VB6.LoadResPicture("MIC3", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(15,  , VB6.LoadResPicture("MIC6", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(16,  , VB6.LoadResPicture("MIC7", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(17,  , VB6.LoadResPicture("MIC8", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(18,  , VB6.LoadResPicture("MIC5", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(19,  , VB6.LoadResPicture("MIC4", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(20,  , VB6.LoadResPicture("MIC7", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(21,  , VB6.LoadResPicture("MIC9", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(22,  , VB6.LoadResPicture("MIC11", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(23, "MICEYECLOSED", VB6.LoadResPicture("MICEYECLOSED", VB6.LoadResConstants.ResBitmap))
        ' ''		'UPGRADE_ISSUE: Global method LoadResPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
        ' ''		'UPGRADE_WARNING: MSComctlLib.ListImages method MouthImgList.ListImages.Add has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        ' ''		MouthImgList.Images.Add(24, "MICEYENARROW", VB6.LoadResPicture("MICEYENARROW", VB6.LoadResConstants.ResBitmap))

        ' ''		Exit Sub
        ' ''ErrHandler: 
        ' ''		MsgBox(Err.Description & ":" & Err.Number, MsgBoxStyle.OKOnly, "Load Images Error")
    End Sub

#End Region

#Region "Show Events"

    'UPGRADE_NOTE: Error was upgraded to Error_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub AddDebugInfo(ByRef DebugStr As String, Optional ByRef Error_Renamed As String = "")
        ' This function adds debug string to the info window.

        ' First of all, let's delete a few charaters if the text box is about to
        ' overflow. In this sample we are using the default limit of charaters.
        If Len(DebugTxtBox.Text) > 64000 Then
            Debug.Print("Too much stuff in the debug window. Remove first 10K chars")
            DebugTxtBox.SelectionStart = 0
            DebugTxtBox.SelectionLength = 10240
            DebugTxtBox.SelectedText = ""
        End If

        ' append the string to the DebugTxtBox text box and add a newline
        DebugTxtBox.SelectionStart = Len(DebugTxtBox.Text)
        DebugTxtBox.SelectedText = DebugStr & Error_Renamed & vbCrLf
    End Sub

    'UPGRADE_WARNING: ParamArray strArray was changed from ByRef to ByVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="93C6A0DC-8C99-429A-8696-35FC4DCEFCCC"'
    Private Sub ShowEvent(ByVal ParamArray strArray() As Object)
        ' we will only show the events if the ShowEvents box is checked
        Dim strText As String
        If chkShowEvents.CheckState = System.Windows.Forms.CheckState.Checked Then
            strText = Join(strArray, ", ")
            AddDebugInfo("  Event: " & strText)
        End If
    End Sub

    Private Sub HighLightSpokenWords(ByVal Pos As Integer, ByVal Length As Integer)
        On Error GoTo ErrHandler

        ' Only high light when the MainTxtBox is actually showing the spoken text,
        ' instead of file name
        If chkSpFlagIsFilename.CheckState = System.Windows.Forms.CheckState.Unchecked Then
            txtMainBox.SelectionStart = Pos
            txtMainBox.SelectionLength = Length
        End If

        Exit Sub

ErrHandler:
        AddDebugInfo("Failed to high light words. This may be caused by too many charaters in the main text box.")
    End Sub

    ' This following helper function will set or clear a bit (flag) in the given
    ' integer (base) according to the condition (cond). If cond is 0, the bit
    ' is cleared. Otherwise, the bit is set. The resulting integer is returned.
    Private Function SetOrClearFlag(ByVal cond As Integer, ByVal base As Integer, ByVal flag As Integer) As Integer

        If cond = 0 Then
            ' the condition is false, clear the flag
            SetOrClearFlag = base And Not flag
        Else
            ' the condition is false, set the flag
            SetOrClearFlag = base Or flag
        End If
    End Function

    Private Sub SetSpeakingState(ByVal bSpeaking As Boolean, ByVal bPaused As Boolean)
        ' change state of menu items and buttons accordingly
        menuFileOpenText.Enabled = Not bSpeaking
        menuFileSpeakWave.Enabled = Not bSpeaking
        menuFileSaveToWave.Enabled = Not bSpeaking

        SpeakBtn.Enabled = True

        StopBtn.Enabled = bSpeaking
        SkipBtn.Enabled = (bSpeaking And Not bPaused)
        PauseBtn.Enabled = bSpeaking

        If bPaused Then
            PauseBtn.Text = "បន្ត"
            'switchGIF("Speaker1.gif")
        Else
            PauseBtn.Text = "ផ្អាក"
            'switchGIF("Speaker1.gif")
        End If

        m_bSpeaking = bSpeaking
        m_bPaused = bPaused
    End Sub

    Public Function GetDirectory() As String

        Err.Clear()

        On Error GoTo ErrHandler

        Dim DataKey As SpeechLib.ISpeechDataKey
        Dim Category As New SpeechLib.SpObjectTokenCategory

        'Get the sdk installation location from the registry
        'The value is under "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech". The string name is SDKPath"
        Category.SetId(SpeechLib.SpeechStringConstants.SpeechRegistryLocalMachineRoot)
        DataKey = Category.GetDataKey
        GetDirectory = DataKey.GetStringValue("SDKPath")
        GetDirectory = GetDirectory & "samples\common"
ErrHandler:
        If Err.Number <> 0 Then
            GetDirectory = ""
        End If
    End Function

#End Region '"Show Events"

#Region "AI Speech Function"

#Region "Speech Exports"


    Sub openTextFile()

        On Error GoTo ErrHandler ' Set CancelError is True
        OpenFileDialogSpeech.CheckFileExists = True ' Set flags
        OpenFileDialogSpeech.CheckPathExists = True

        OpenFileDialogSpeech.Title = "Open a Text File" ' Set Dialog title
        OpenFileDialogSpeech.FileName = "*.txt"

        OpenFileDialogSpeech.Filter = "Text File (*.txt)|(*.txt)|XML File (*.xml)|*.xml" 'Set filters
        OpenFileDialogSpeech.FilterIndex = 1 ' Specify default filter

        ' Display the Open dialog box
        If OpenFileDialogSpeech.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(OpenFileDialogSpeech.FileName)
            Me.txtMainBox.Text = sr.ReadToEnd.ToString()
            sr.Close()
        End If

        Exit Sub
ErrHandler:
        'User pressed the Cancel button, do not show error
        If Not (Err.Number = 32755) Then
            AddDebugInfo("Open file: ", Err.Description)
        End If
    End Sub

    Private Sub SaveToWav()
        'Create a wave stream
        Dim cpFileStream As New SpeechLib.SpFileStream
        Dim mpFileStream As New SpeechLib.SpFileStream

        '   Set audio format
        cpFileStream.Format.Type = VB6.GetItemData(FormatCB, FormatCB.SelectedIndex)

        On Error GoTo Cancel
        SaveFileDialogSpeech.OverwritePrompt = True
        SaveFileDialogSpeech.CheckPathExists = True
        SaveFileDialogSpeech.Title = "Save to a Wave File"
        SaveFileDialogSpeech.FileName = "*.wav"
        SaveFileDialogSpeech.Filter = "Wave Files (*.wav)|*.wav|" & "MP3 Files (*.mp3)|*.mp3"
        SaveFileDialogSpeech.FilterIndex = 1
        SaveFileDialogSpeech.ShowDialog()
        cpFileStream.Open(SaveFileDialogSpeech.FileName, SpeechLib.SpeechStreamFileMode.SSFMCreateForWrite, False)

        '   Set the .wav file stream as the output for the Voice object
        Voice.AudioOutputStream = cpFileStream
        Voice.Speak(txtMainBox.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
        'fProgressBar.ShowDialog()
        fSaving.ShowDialog()

        cpFileStream.Close() '   Close the file
        cpFileStream = Nothing
        Voice.AudioOutputStream = Nothing
        AddDebugInfo("Save Success!")
        'MsgBox("Saved Success!")

Cancel:
        Exit Sub
    End Sub

    Sub SpeakWavFile()
        ' Set CancelError is True
        On Error GoTo ErrHandler

        OpenFileDialogSpeech.CheckFileExists = True ' Set flags
        OpenFileDialogSpeech.CheckPathExists = True

        OpenFileDialogSpeech.Title = "Speak a Wave File" ' Set Dialog title
        OpenFileDialogSpeech.FileName = "*.wav"

        OpenFileDialogSpeech.Filter = "Wave Files " & "(*.wav)|*.wav" ' Set filters
        OpenFileDialogSpeech.FilterIndex = 1 ' Specify default filter

        OpenFileDialogSpeech.ShowDialog() ' Display the Open dialog box

        AddDebugInfo("Speaking .wav file")

        ' Speak the contents of the wavefile. Notice here we are passing in the
        ' file name so the filename flag is set.
        txtMainBox.Text = OpenFileDialogSpeech.FileName
        chkSpFlagIsFilename.CheckState = System.Windows.Forms.CheckState.Checked
        SpeakBtn_Click(SpeakBtn, New System.EventArgs())
        Exit Sub
ErrHandler:
        'User pressed the Cancel button, do not show error
        If Not (Err.Number = 32755) Then
            AddDebugInfo("Speak Wave Error: ", Err.Description)
        End If

        SetSpeakingState(False, m_bPaused)
        Exit Sub
    End Sub
#End Region

    Sub switchGIF(ByVal gif_name As String)
        wbSpeak.Navigate(New System.Uri(My.Application.Info.DirectoryPath & "\GIF\" & gif_name))
    End Sub

#End Region '"AI Speech Function"

#Region "AI Speech Control Events"

    Private Sub AISpeech_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo ErrHandler
        switchGIF("Speaker1.gif")
        ' Creates the voice object first
        Voice = New SpeechLib.SpVoice

        ' Load the voices combo box
        VoiceCB.Items.Clear()
        Dim Token As SpeechLib.ISpeechObjectToken

        For Each Token In Voice.GetVoices
            VoiceCB.Items.Add((Token.GetDescription()))
        Next Token
        VoiceCB.SelectedIndex = 0

        'load the format combo box
        FormatCB.Items.Clear()
        AddItemToFmtCB()

        ' set rate and volume to the same as the Voice
        RateSldr.Value = Voice.Rate
        VolumeSldr.Value = Voice.Volume

        'set the default format
        FormatCB.Text = DefaultFmt

        ' Load the audio output combo box
        AudioOutputCB.Items.Clear()
        If Voice.GetAudioOutputs.Count > 0 Then
            For Each Token In Voice.GetAudioOutputs
                AudioOutputCB.Items.Add((Token.GetDescription))
            Next Token
        Else
            AudioOutputCB.Items.Add(NoAudioOutput)
            AudioOutputCB.Enabled = False
        End If
        AudioOutputCB.SelectedIndex = 0

        'load image list
        LoadMouthImages()

        MouthImgList.TransparentColor = System.Drawing.Color.Magenta
        'UPGRADE_ISSUE: MSComctlLib.ImageList property MouthImgList.BackColor was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '<<<***RUN***>>>>' MouthImgList.BackColor = GetSysColor(COLOR_3DFACE)
        'UPGRADE_ISSUE: MSComctlLib.ImageList method MouthImgList.Overlay was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '<<<***RUN***>>>>' VisemePicture.Image = MouthImgList.Overlay("MICFULL", "MICFULL")

        ' init speak flags and sync flag check boxes
        m_speakFlags = SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync Or SpeechLib.SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak Or SpeechLib.SpeechVoiceSpeakFlags.SVSFIsXML
        chkSpFlagAync.CheckState = System.Windows.Forms.CheckState.Checked
        chkSpFlagPurgeBeforeSpeak.CheckState = System.Windows.Forms.CheckState.Checked
        chkSpFlagIsXML.CheckState = System.Windows.Forms.CheckState.Checked

        SetSpeakingState(False, False)
        Exit Sub

ErrHandler:
        MsgBox("Error in initialization: " & vbCrLf & vbCrLf & Err.Description & vbCrLf & vbCrLf & "Shutting down.", MsgBoxStyle.OkOnly, "TTSApp")
        'UPGRADE_NOTE: Object Voice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Voice = Nothing
        End
    End Sub

    Private Sub AISpeech_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Voice = Nothing
    End Sub

    Private Sub txtSpeakAsType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSpeakAsType.KeyPress
        ' this will try to speak each word as you type, it does not keep up all that well
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            AddDebugInfo(txtSpeakAsType.Text)
            'Voice.Speak(txtSpeakAsType.Text, m_speakFlags)
            Voice.Speak(txtSpeakAsType.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault)
            txtSpeakAsType.Text = ""
        End If
    End Sub

#End Region

    Private Sub txtSpeakAsType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSpeakAsType.TextChanged

    End Sub
End Class