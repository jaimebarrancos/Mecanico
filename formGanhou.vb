Public Class formGanhou
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Level.Hide()
        Level.Close()
        Level.Dispose() ' limpa timers variaveis etc

        MenuPrincipal.Show()
        MenuPrincipal.musicaMenu.URL = "Audios\musicaMenu.mp3"
        MenuPrincipal.musicaMenu.controls.play()

        Me.Hide()

    End Sub

End Class