

Public Class fProgressBar
    Private AnimatedImage As Image

    Private Sub fProgressBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Timer1.Enabled = True

        'Start the image animator
        'AnimatedImage = New Bitmap("FILECOPY_16.gif") 'Your animated gif file
        ImageAnimator.Animate(AnimatedImage, New EventHandler(AddressOf Me.OnFrameChanged))
    End Sub

    Private Sub OnFrameChanged(ByVal o As Object, ByVal e As EventArgs)
        'Get the next Image and draw it.
        ImageAnimator.UpdateFrames()

        Dim G As Graphics = PictureBox1.CreateGraphics
        G.Clear(PictureBox1.BackColor)
        G.DrawImage(animatedImage, PictureBox1.ClientRectangle)
        G.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        If ProgressBar1.Value >= 100 Then
            ProgressBar1.Value = 100
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ProgressBar1.Value < 100 Then

            ProgressBar1.Value += 5

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If ProgressBar1.Value > 0 Then

            ProgressBar1.Value -= 5


        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ProgressBar1.Value = 100
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ProgressBar1.Value = 0
    End Sub

    Private Sub fProgressBar_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > -1 Then
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value += 1
            End If
        Else
            If ProgressBar1.Value > 0 Then
                ProgressBar1.Value -= 5
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblDateTime.Text = Now.ToLongTimeString.ToString()
    End Sub
End Class