Imports WMPLib
Imports System.Media

Public Class MenuPrincipal
    Public musicaMenu As WindowsMediaPlayer = New WindowsMediaPlayer

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        musicaMenu.URL = "Audios\musicaMenu.mp3"
        musicaMenu.controls.play()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Level.Show()
        Me.Hide()

        'Nível um nao inclui combustivel portanto nem fita cola
        Level.FitaColaHolder.Dispose()
        Level.pictureCombustivel.Dispose()
        Level.labelCombustivel.Dispose()
        Level.deveMostrarMedidorTemperatura = True
        Level.temporizadorFuroCombustivel.Enabled = False

        Level.nivelCombustivel = Level.nivelCombustivelMax

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Level.Show()
        Me.Hide()

        'Nível dois nao inclui motor portanto nem chave inglesa nem medidor de temperatura
        Level.WrenchHolder.Dispose()
        Level.pictureEngine.Dispose()
        Level.furoMotorTemporizador.Enabled = False
        Level.deveMostrarMedidorTemperatura = False

        Level.temporizadorFuroCombustivel.Enabled = True
        Level.nivelCombustivel = Level.nivelCombustivelMax

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Nível três com tudo junto
        Level.temporizadorFuroCombustivel.Enabled = True
        Level.deveMostrarMedidorTemperatura = True
        Level.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub buttonRegras_Click(sender As Object, e As EventArgs) Handles buttonRegras.Click
        formRegras.Show()
    End Sub
End Class