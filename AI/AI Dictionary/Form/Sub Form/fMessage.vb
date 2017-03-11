Public Class fMessage

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call StopSound()
        Me.Close()
    End Sub

    Private Sub fMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PlaySound("sms.wav")
    End Sub
End Class