Imports System.IO
Imports System.Media
Imports WMPLib


Public Class Level

    Dim MyPen As New Pen(Color.Black, 4)
    Dim Mybrush As New SolidBrush(Color.Red)
    Dim bmp As Image
    Dim g As Graphics

    Dim barY = 300
    Dim barHeight = 0

    Dim curImageAs As Image = My.Resources.oficina

    Dim speed = 0.2
    Dim tempoJogo = 60

    Dim avisoContador = 10
    Dim avisoContadorMax = 10

    Public musicaPlayer As WindowsMediaPlayer = New WindowsMediaPlayer

    Public sonsFurosQuebrar As WindowsMediaPlayer = New WindowsMediaPlayer
    Public sonsFurosTapar As WindowsMediaPlayer = New WindowsMediaPlayer

    Public sonsParafusosQuebrar As WindowsMediaPlayer = New WindowsMediaPlayer
    Public sonsParafusosArranjar As WindowsMediaPlayer = New WindowsMediaPlayer

    Public somChaveInglesaEquipada As WindowsMediaPlayer = New WindowsMediaPlayer
    Public somFitaColaEquipada As WindowsMediaPlayer = New WindowsMediaPlayer

    Public jogoPerdido As WindowsMediaPlayer = New WindowsMediaPlayer
    Public jogoGanho As WindowsMediaPlayer = New WindowsMediaPlayer

    'rato
    '0 - ferramenta
    '1 - fita cola
    Public ferramentaRato = -1

    Dim mouseBitmap As New Bitmap(60, 60)
    Dim mouseGraphics As Graphics = Graphics.FromImage(mouseBitmap)

    'Dim wrenchImage As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\noBackgroundWrench.png")
    'Dim ductTapeImage As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\noBackgroundDuctTape.png")
    Dim wrenchImage As Image = My.Resources.noBackgroundWrench
    Dim ductTapeImage As Image = My.Resources.noBackgroundDuctTape

    Public CustomCursor As Cursor

    '
    'Motor
    'Dim motorFrame2 As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\EngineFrames\engineFrame2.png")
    'Dim motorDefault As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\EngineFrames\engineDefault.png")
    'Dim motorFrame3 As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\EngineFrames\engineFrame3.png")

    Dim motorFrame2 As Image = My.Resources.engineFrame2
    Dim motorDefault As Image = My.Resources.engineDefault
    Dim motorFrame3 As Image = My.Resources.engineFrame3

    Dim contadorFrames = 1

    '
    'parafusos
    'Dim parafusoImagem As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\parafuso.png")
    'Dim parafusoQuebradoImagem As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\parafusoQuebrado.png")
    Dim parafusoImagem As Image = My.Resources.parafuso
    Dim parafusoQuebradoImagem As Image = My.Resources.parafusoQuebrado

    '
    'contadores de combustivel e motor
    Public nivelCombustivel = 100
    Public nivelCombustivelMax = 100
    Dim contadorAlturaLimite = 300
    'Dim medidorMotorImagem As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\medidor.png")
    Dim medidorMotorImagem As Image = My.Resources.medidor

    'Dim medidorCheioMotorImagem As Image = Image.FromFile("C:\Users\JAIMAO\source\repos\Dart\Dart\Images\medidor_cheio.png")
    Dim medidorCheioMotorImagem As Image = My.Resources.medidor_cheio

    Public deveMostrarMedidorTemperatura

    ''' 
    ''' 
    '''
    Private Sub Level_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '
        'load sons e parar musica menu
        MenuPrincipal.musicaMenu.controls.stop()

        'como url, erradamente, também começa cada audio, tenho que os parar manualmente no inicio
        musicaPlayer.URL = "Audios\musicaJogo.mp3"
        musicaPlayer.controls.play()


        jogoPerdido.URL = "Audios\crash.mp3"
        jogoPerdido.controls.stop()

        jogoGanho.URL = "Audios\jogoGanho.mp3"
        jogoGanho.controls.stop()

        somFitaColaEquipada.URL = "Audios\fitaColaEquipada.mp3"
        somFitaColaEquipada.controls.stop()
        somChaveInglesaEquipada.URL = "Audios\chaveInglesaEquipada.mp3"
        somChaveInglesaEquipada.controls.stop()

        sonsParafusosQuebrar.URL = "Audios\parafusoQuebra.mp3"
        sonsParafusosQuebrar.controls.stop()

        sonsFurosQuebrar.URL = "Audios\furoQuebra.mp3"
        sonsFurosQuebrar.controls.stop()

        sonsParafusosArranjar.URL = "Audios\parafusoArranjado.mp3"
        sonsParafusosArranjar.controls.stop()

        sonsFurosTapar.URL = "Audios\taparFuro.mp3"
        sonsFurosTapar.controls.stop()

        'tirar background de cada componente
        pictureCombustivel.Parent = canvas
        pictureEngine.Parent = canvas
        labelTemporizadorJogo.Parent = canvas
        labelCombustivel.Parent = canvas
        WrenchHolder.Parent = canvas
        FitaColaHolder.Parent = canvas

        Me.DoubleBuffered = True
        bmp = New Bitmap(canvas.Width, canvas.Height)
        canvas.BackgroundImage = bmp.Clone
        labelCombustivel.Text = "Gás - " & nivelCombustivel
        temporizadorCanvas.Enabled = True

        'parafusos

        criarParafuso(parafuso1)
        criarParafuso(parafuso2)
        criarParafuso(parafuso3)
        criarParafuso(parafuso4)

    End Sub

    'retorna as coordenadas do parafuso a partir das coordenadas da picture em que está
    'em vez das coordenadas absulutas do forms
    Function criarParafuso(_parafuso)
        Me.Controls.Add(_parafuso)
        _parafuso.Parent = pictureEngine
        _parafuso.Location = localizacaoEmRegiao(_parafuso)
    End Function

    Function localizacaoEmRegiao(_parafuso)
        Return New Point(_parafuso.Location.X - pictureEngine.Location.X, _parafuso.Location.Y - pictureEngine.Location.Y)
    End Function

    Private Sub temporizadorCanvas_Tick(sender As Object, e As EventArgs) Handles temporizadorCanvas.Tick

        'Update background
        canvas.BackgroundImage = bmp.Clone

        'Update mouse
        mouseGraphics.Clear(Color.Transparent) 'renova graphics para (potencialmente) trocar de ferramenta

        If ferramentaRato = 0 Then
            mouseGraphics.DrawImage(wrenchImage, 0, 0, 70, 70)
            Try
                Dim wrenchIcon As IntPtr = mouseBitmap.GetHicon
                CustomCursor = New Cursor(wrenchIcon)
            Catch
            End Try
        ElseIf ferramentaRato = 1 Then
            mouseGraphics.DrawImage(ductTapeImage, 0, 0, 50, 50)
            Try
                Dim ductTapeIcon As IntPtr = mouseBitmap.GetHicon
                CustomCursor = New Cursor(ductTapeIcon)
            Catch
            End Try
        End If
    End Sub

    Private Sub FuroTemporizador_Tick(sender As Object, e As EventArgs) Handles temporizadorFuroCombustivel.Tick
        Dim botaoFuro As New Furo()
    End Sub

    Private Sub Canvas_Paint(sender As Object, e As PaintEventArgs) Handles canvas.Paint

        g = Graphics.FromImage(bmp)
        g.Clear(BackColor)

        g.DrawImage(curImageAs, 0, 0, 870, 500)

        'medidor de temperatura
        If deveMostrarMedidorTemperatura Then

            aquecer(parafuso1)
            aquecer(parafuso2)
            aquecer(parafuso3)
            aquecer(parafuso4)

            arrefecer()

            'Para desenhar em cada frame:
            Dim coordenadaXdestino = 550
            Dim coordenadaYdestino = 150
            Dim bitVazio As Bitmap = New Bitmap(medidorMotorImagem, 160, 300)
            Dim retanguloDestinoVazio = New Rectangle(coordenadaXdestino, coordenadaYdestino, 160, contadorAlturaLimite)
            Dim retanguloOrigemVazio = New Rectangle(40, 0, 120, contadorAlturaLimite)
            g.DrawImage(bitVazio, retanguloDestinoVazio, retanguloOrigemVazio, GraphicsUnit.Pixel)

            Dim bit As Bitmap = New Bitmap(medidorCheioMotorImagem, 160, 300)
            Dim retanguloDestino = New Rectangle(coordenadaXdestino, coordenadaYdestino + contadorAlturaLimite - CInt(barHeight), 160, CInt(barHeight))
            Dim retanguloOrigem = New Rectangle(40, contadorAlturaLimite - CInt(barHeight), 120, CInt(barHeight))
            g.DrawImage(bit, retanguloDestino, retanguloOrigem, GraphicsUnit.Pixel)
        End If
    End Sub

    Function aquecer(_parafuso)
        If _parafuso.Tag Then 'se estiver quebrado 
            If barHeight >= contadorAlturaLimite Then
                perder()
            Else
                barY -= speed
                barHeight += speed
            End If
        End If
    End Function

    Function arrefecer()
        If verificaTodosParafusosTag() Then ' se todos estiverem bem
            If barHeight <= 0 Then
                barHeight = 0
                barY = 0
            Else
                barY += 2 * speed
                barHeight -= 2 * speed
            End If
        End If
    End Function

    Function verificaTodosParafusosTag()
        If parafuso1.Tag Then
            Return False ' se estiver quebrado retorna false
        End If
        If parafuso2.Tag Then
            Return False
        End If
        If parafuso3.Tag Then
            Return False
        End If
        If parafuso4.Tag Then
            Return False
        Else Return True
        End If

    End Function

    Function mudarFerramenta(_ferramenta) ' para qual: 0 - chave 1 - fita cola
        If _ferramenta = 0 Then
            somChaveInglesaEquipada.controls.play()
            ferramentaRato = 0
        ElseIf _ferramenta = 1 Then
            somFitaColaEquipada.controls.play()
            ferramentaRato = 1
        End If
    End Function

    Private Sub canvas_MouseEnter(sender As Object, e As EventArgs) Handles canvas.MouseMove
        Me.Cursor = CustomCursor
    End Sub

    Private Sub WrenchHolder_MouseMove(sender As Object, e As EventArgs) Handles WrenchHolder.MouseMove
        mudarFerramenta(0)
        Me.Cursor = CustomCursor
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles FitaColaHolder.MouseMove
        mudarFerramenta(1)
        Me.Cursor = CustomCursor
    End Sub
    Private Sub pictureCombustivel_MouseMove(sender As Object, e As EventArgs) Handles pictureCombustivel.MouseMove
        Me.Cursor = CustomCursor
    End Sub

    Private Sub pictureEngine_MouseMove(sender As Object, e As EventArgs) Handles pictureEngine.MouseMove
        Me.Cursor = CustomCursor
    End Sub

    Private Sub parafuso1_MouseMove(sender As Object, e As EventArgs) Handles parafuso1.MouseMove
        Me.Cursor = CustomCursor
    End Sub
    Private Sub parafuso2_MouseMove(sender As Object, e As EventArgs) Handles parafuso2.MouseMove
        Me.Cursor = CustomCursor
    End Sub
    Private Sub parafuso3_MouseMove(sender As Object, e As EventArgs) Handles parafuso3.MouseMove
        Me.Cursor = CustomCursor
    End Sub
    Private Sub parafuso4_MouseMove(sender As Object, e As EventArgs) Handles parafuso4.MouseMove
        Me.Cursor = CustomCursor
    End Sub

    Private Sub refreshEngineFrame_Tick(sender As Object, e As EventArgs) Handles refreshEngineFrame.Tick
        Select Case contadorFrames
            Case 1
                pictureEngine.BackgroundImage = motorDefault
                contadorFrames = 2
            Case 2
                pictureEngine.BackgroundImage = motorFrame2
                contadorFrames = 3
            Case 3
                pictureEngine.BackgroundImage = motorFrame3
                contadorFrames = 1
        End Select

    End Sub

    Private Sub furoMotorTemporizador_Tick(sender As Object, e As EventArgs) Handles furoMotorTemporizador.Tick
        'tag de cada parafuso corresponde ao estado em que se encontra
        'False - parafuso funciona ; True - parafuso está quebrado
        Dim random = CInt(4 * Rnd()) ' para random = numero inteiro

        If parafuso1.Tag = False And random = 1 Then
            parafuso1.BackgroundImage = parafusoQuebradoImagem
            parafuso1.Tag = True
            sonsParafusosQuebrar.controls.play()
        ElseIf parafuso2.Tag = False And random = 2 Then
            parafuso2.BackgroundImage = parafusoQuebradoImagem
            parafuso2.Tag = True
            sonsParafusosQuebrar.controls.play()

        ElseIf parafuso3.Tag = False And random = 3 Then
            parafuso3.BackgroundImage = parafusoQuebradoImagem
            parafuso3.Tag = True
            sonsParafusosQuebrar.controls.play()

        ElseIf parafuso4.Tag = False And random = 4 Then
            parafuso4.BackgroundImage = parafusoQuebradoImagem
            parafuso4.Tag = True
            sonsParafusosQuebrar.controls.play()

        End If
    End Sub

    Function arranjarParafuso(_parafuso)
        If ferramentaRato = 0 Then
            _parafuso.BackgroundImage = parafusoImagem
            sonsParafusosArranjar.controls.play()

            _parafuso.Tag = False
        Else
            temporizadorAviso.Enabled = True
        End If
    End Function

    Private Sub clickedFuroMotor1(sender As Object, e As EventArgs) Handles parafuso1.Click
        arranjarParafuso(parafuso1)
    End Sub
    Private Sub clickedFuroMotor2(sender As Object, e As EventArgs) Handles parafuso2.Click
        arranjarParafuso(parafuso2)
    End Sub
    Private Sub clickedFuroMotor3(sender As Object, e As EventArgs) Handles parafuso3.Click
        arranjarParafuso(parafuso3)
    End Sub
    Private Sub clickedFuroMotor4(sender As Object, e As EventArgs) Handles parafuso4.Click
        arranjarParafuso(parafuso4)
    End Sub

    Private Sub temporizadorAviso_Tick(sender As Object, e As EventArgs) Handles temporizadorAviso.Tick
        labelAvisoFerramenta.Visible = True
        labelAvisoFerramenta.Text = "Ferramenta Errada !!"
        avisoContador -= 1
        If avisoContador <= 0 Then
            avisoContador = avisoContadorMax
            temporizadorAviso.Enabled = False
            labelAvisoFerramenta.Visible = False
        End If
    End Sub

    Private Sub temporizadorJogo_Tick(sender As Object, e As EventArgs) Handles temporizadorJogo.Tick
        labelTemporizadorJogo.Text = tempoJogo
        tempoJogo -= 1
        If tempoJogo <= 0 Then
            ganhar()
        End If
    End Sub

    Function ganhar()
        jogoGanho.controls.play()
        musicaPlayer.controls.stop()
        formGanhou.Show()
        pararJogo()

    End Function

    Function perder()
        jogoPerdido.controls.play()
        FimDeJogo.Show()
        pararJogo()

    End Function

    Function pararJogo()
        musicaPlayer.controls.stop()
        furoMotorTemporizador.Enabled = False
        temporizadorFuroCombustivel.Enabled = False
        temporizadorJogo.Enabled = False
        perderCombustivel.Enabled = False
        deveMostrarMedidorTemperatura = False
        barHeight = 0
        tempoJogo = 60
        barY = 300
    End Function

End Class
