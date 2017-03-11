Public NotInheritable Class AIWelcome

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub AIWelcome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call openConnection()
        TimerAIWelcome.Enabled = True

    End Sub

    Private Sub TimerAIWelcome_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAIWelcome.Tick
        FadeForm(Me, 150)
        Me.Hide()
        AIDictionary.Show()
        TimerAIWelcome.Enabled = False
        'Call LoadEWord(AIDictionary.listEWord)
    End Sub
End Class
