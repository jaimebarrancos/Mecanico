Imports System.Drawing

Public Class Furo
    Dim FuroX
    Dim FuroY
    Dim Width As Int16 = 40
    Dim Height As Int16 = 40
    Dim furoImage As Image
    Dim furoPicture As New PictureBox
    Public temporizadorCombustivel As New Timer

    Dim graph As Graphics
    Dim bitmap As Image

    Public Sub New()
        Level.sonsFurosQuebrar.controls.play()

        bitmap = New Bitmap(10, 10)
        graph = Graphics.FromImage(bitmap)
        furoImage = My.Resources.furo 'Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\furo.png")

        Dim region1 As Region = New Region(New Rectangle(10, 105, 175, 200)) 'regiao onde por furos

        Dim rectangleRegion = region1.GetBounds(graph)
        FuroX = rectangleRegion.Width * Rnd() + rectangleRegion.Location.X
        FuroY = rectangleRegion.Height * Rnd() + rectangleRegion.Location.Y

        Level.Controls.Add(furoPicture)

        With furoPicture

            .Parent = Level.pictureCombustivel

            .Size = New Size(Width + 20, Height + 20)
            .Location = New Point(FuroX, FuroY)

            .BackgroundImage = furoImage

            .BringToFront()
            .BackgroundImageLayout = ImageLayout.Stretch

        End With

        AddHandler furoPicture.MouseClick, AddressOf furoPicture_click
        AddHandler formGanhou.Load, AddressOf limparFuros
        AddHandler FimDeJogo.Load, AddressOf limparFuros
        AddHandler furoPicture.MouseMove, AddressOf furoPicture_MouseMove

        'temporizador para cada buraco para contabilizar a perda de combustivel
        temporizadorCombustivel.Enabled = True
        AddHandler temporizadorCombustivel.Tick, AddressOf perderCombustivel_Tick
    End Sub

    Private Sub limparFuros(sender As Object, e As EventArgs)
        Level.Controls.Remove(furoPicture)
        furoPicture.Hide()
        temporizadorCombustivel.Enabled = False
    End Sub

    Private Sub furoPicture_MouseMove(sender As Object, e As EventArgs)
        Level.Cursor = Level.CustomCursor
    End Sub

    Private Sub perderCombustivel_Tick(sender As Object, e As EventArgs)
        Level.nivelCombustivel -= 1
        If Level.nivelCombustivel <= 0 Then
            Level.perder()
        End If
        If Level.temporizadorJogo.Enabled Then
            Level.labelCombustivel.Text = "Gás - " & Level.nivelCombustivel
        End If
    End Sub

    Private Sub furoPicture_click(sender As Object, e As EventArgs)
        If Level.ferramentaRato = 0 Then
            Level.temporizadorAviso.Enabled = True
        ElseIf Level.ferramentaRato = 1 Then
            Level.sonsFurosTapar.controls.play()
            Level.Controls.Remove(furoPicture)
            furoPicture.Hide()
            temporizadorCombustivel.Enabled = False
        End If

    End Sub

End Class
