Public Class fLoadData

    Private Sub fLoadData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBarLoadData.Minimum = 0
        ProgressBarLoadData.Maximum = 100
        ProgressBarLoadData.Value = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBarLoadData.Value += 2
        If ProgressBarLoadData.Value >= 100 Then
            ProgressBarLoadData.Value = 100
            Timer1.Enabled = False
        End If
    End Sub
End Class