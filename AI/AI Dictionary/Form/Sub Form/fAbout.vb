Public Class fAbout

    Private Sub fAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        'Call StopSound()
        Me.Close()
    End Sub

    Private Sub fAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call PlaySound("about.wav")
    End Sub
End Class