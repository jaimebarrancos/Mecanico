<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Level
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.temporizadorCanvas = New System.Windows.Forms.Timer(Me.components)
        Me.canvas = New System.Windows.Forms.PictureBox()
        Me.temporizadorFuroCombustivel = New System.Windows.Forms.Timer(Me.components)
        Me.WrenchHolder = New System.Windows.Forms.PictureBox()
        Me.FitaColaHolder = New System.Windows.Forms.PictureBox()
        Me.pictureCombustivel = New System.Windows.Forms.PictureBox()
        Me.pictureEngine = New System.Windows.Forms.PictureBox()
        Me.refreshEngineFrame = New System.Windows.Forms.Timer(Me.components)
        Me.parafuso1 = New System.Windows.Forms.PictureBox()
        Me.furoMotorTemporizador = New System.Windows.Forms.Timer(Me.components)
        Me.parafuso3 = New System.Windows.Forms.PictureBox()
        Me.parafuso2 = New System.Windows.Forms.PictureBox()
        Me.parafuso4 = New System.Windows.Forms.PictureBox()
        Me.labelCombustivel = New System.Windows.Forms.Label()
        Me.perderCombustivel = New System.Windows.Forms.Timer(Me.components)
        Me.labelAvisoFerramenta = New System.Windows.Forms.Label()
        Me.temporizadorAviso = New System.Windows.Forms.Timer(Me.components)
        Me.temporizadorJogo = New System.Windows.Forms.Timer(Me.components)
        Me.labelTemporizadorJogo = New System.Windows.Forms.Label()
        CType(Me.canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WrenchHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FitaColaHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureCombustivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEngine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parafuso1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parafuso3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parafuso2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parafuso4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(676, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'temporizadorCanvas
        '
        Me.temporizadorCanvas.Interval = 30
        '
        'canvas
        '
        Me.canvas.Cursor = System.Windows.Forms.Cursors.Default
        Me.canvas.Location = New System.Drawing.Point(-2, 0)
        Me.canvas.Name = "canvas"
        Me.canvas.Size = New System.Drawing.Size(858, 497)
        Me.canvas.TabIndex = 2
        Me.canvas.TabStop = False
        '
        'temporizadorFuroCombustivel
        '
        Me.temporizadorFuroCombustivel.Enabled = True
        Me.temporizadorFuroCombustivel.Interval = 6000
        '
        'WrenchHolder
        '
        Me.WrenchHolder.BackColor = System.Drawing.Color.Transparent
        Me.WrenchHolder.BackgroundImage = CType(resources.GetObject("WrenchHolder.BackgroundImage"), System.Drawing.Image)
        Me.WrenchHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.WrenchHolder.Location = New System.Drawing.Point(676, 199)
        Me.WrenchHolder.Name = "WrenchHolder"
        Me.WrenchHolder.Size = New System.Drawing.Size(138, 124)
        Me.WrenchHolder.TabIndex = 6
        Me.WrenchHolder.TabStop = False
        '
        'FitaColaHolder
        '
        Me.FitaColaHolder.BackColor = System.Drawing.Color.Transparent
        Me.FitaColaHolder.BackgroundImage = CType(resources.GetObject("FitaColaHolder.BackgroundImage"), System.Drawing.Image)
        Me.FitaColaHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FitaColaHolder.Location = New System.Drawing.Point(676, 342)
        Me.FitaColaHolder.Name = "FitaColaHolder"
        Me.FitaColaHolder.Size = New System.Drawing.Size(138, 130)
        Me.FitaColaHolder.TabIndex = 7
        Me.FitaColaHolder.TabStop = False
        '
        'pictureCombustivel
        '
        Me.pictureCombustivel.BackColor = System.Drawing.Color.Transparent
        Me.pictureCombustivel.BackgroundImage = CType(resources.GetObject("pictureCombustivel.BackgroundImage"), System.Drawing.Image)
        Me.pictureCombustivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureCombustivel.Location = New System.Drawing.Point(12, 113)
        Me.pictureCombustivel.Name = "pictureCombustivel"
        Me.pictureCombustivel.Size = New System.Drawing.Size(262, 384)
        Me.pictureCombustivel.TabIndex = 9
        Me.pictureCombustivel.TabStop = False
        '
        'pictureEngine
        '
        Me.pictureEngine.BackColor = System.Drawing.Color.Transparent
        Me.pictureEngine.BackgroundImage = CType(resources.GetObject("pictureEngine.BackgroundImage"), System.Drawing.Image)
        Me.pictureEngine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureEngine.Location = New System.Drawing.Point(300, 99)
        Me.pictureEngine.Name = "pictureEngine"
        Me.pictureEngine.Size = New System.Drawing.Size(258, 398)
        Me.pictureEngine.TabIndex = 10
        Me.pictureEngine.TabStop = False
        '
        'refreshEngineFrame
        '
        Me.refreshEngineFrame.Enabled = True
        Me.refreshEngineFrame.Interval = 500
        '
        'parafuso1
        '
        Me.parafuso1.BackColor = System.Drawing.Color.Transparent
        Me.parafuso1.BackgroundImage = CType(resources.GetObject("parafuso1.BackgroundImage"), System.Drawing.Image)
        Me.parafuso1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.parafuso1.Location = New System.Drawing.Point(372, 244)
        Me.parafuso1.Name = "parafuso1"
        Me.parafuso1.Size = New System.Drawing.Size(37, 39)
        Me.parafuso1.TabIndex = 11
        Me.parafuso1.TabStop = False
        '
        'furoMotorTemporizador
        '
        Me.furoMotorTemporizador.Enabled = True
        Me.furoMotorTemporizador.Interval = 2000
        '
        'parafuso3
        '
        Me.parafuso3.BackColor = System.Drawing.Color.Transparent
        Me.parafuso3.BackgroundImage = CType(resources.GetObject("parafuso3.BackgroundImage"), System.Drawing.Image)
        Me.parafuso3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.parafuso3.Location = New System.Drawing.Point(487, 218)
        Me.parafuso3.Name = "parafuso3"
        Me.parafuso3.Size = New System.Drawing.Size(37, 39)
        Me.parafuso3.TabIndex = 12
        Me.parafuso3.TabStop = False
        '
        'parafuso2
        '
        Me.parafuso2.BackColor = System.Drawing.Color.Transparent
        Me.parafuso2.BackgroundImage = CType(resources.GetObject("parafuso2.BackgroundImage"), System.Drawing.Image)
        Me.parafuso2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.parafuso2.Location = New System.Drawing.Point(417, 323)
        Me.parafuso2.Name = "parafuso2"
        Me.parafuso2.Size = New System.Drawing.Size(37, 39)
        Me.parafuso2.TabIndex = 13
        Me.parafuso2.TabStop = False
        '
        'parafuso4
        '
        Me.parafuso4.BackColor = System.Drawing.Color.Transparent
        Me.parafuso4.BackgroundImage = CType(resources.GetObject("parafuso4.BackgroundImage"), System.Drawing.Image)
        Me.parafuso4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.parafuso4.Location = New System.Drawing.Point(363, 165)
        Me.parafuso4.Name = "parafuso4"
        Me.parafuso4.Size = New System.Drawing.Size(37, 39)
        Me.parafuso4.TabIndex = 14
        Me.parafuso4.TabStop = False
        '
        'labelCombustivel
        '
        Me.labelCombustivel.AutoSize = True
        Me.labelCombustivel.BackColor = System.Drawing.Color.Transparent
        Me.labelCombustivel.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCombustivel.Location = New System.Drawing.Point(86, 41)
        Me.labelCombustivel.Name = "labelCombustivel"
        Me.labelCombustivel.Size = New System.Drawing.Size(75, 38)
        Me.labelCombustivel.TabIndex = 15
        Me.labelCombustivel.Text = "Gas"
        '
        'perderCombustivel
        '
        Me.perderCombustivel.Interval = 10
        '
        'labelAvisoFerramenta
        '
        Me.labelAvisoFerramenta.AutoSize = True
        Me.labelAvisoFerramenta.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAvisoFerramenta.Location = New System.Drawing.Point(243, 437)
        Me.labelAvisoFerramenta.Name = "labelAvisoFerramenta"
        Me.labelAvisoFerramenta.Size = New System.Drawing.Size(0, 25)
        Me.labelAvisoFerramenta.TabIndex = 16
        '
        'temporizadorAviso
        '
        Me.temporizadorAviso.Interval = 50
        '
        'temporizadorJogo
        '
        Me.temporizadorJogo.Enabled = True
        Me.temporizadorJogo.Interval = 1000
        '
        'labelTemporizadorJogo
        '
        Me.labelTemporizadorJogo.AutoSize = True
        Me.labelTemporizadorJogo.BackColor = System.Drawing.Color.Transparent
        Me.labelTemporizadorJogo.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTemporizadorJogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTemporizadorJogo.Location = New System.Drawing.Point(709, 60)
        Me.labelTemporizadorJogo.Name = "labelTemporizadorJogo"
        Me.labelTemporizadorJogo.Size = New System.Drawing.Size(53, 38)
        Me.labelTemporizadorJogo.TabIndex = 17
        Me.labelTemporizadorJogo.Text = "00"
        '
        'Level
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(854, 496)
        Me.Controls.Add(Me.labelTemporizadorJogo)
        Me.Controls.Add(Me.labelAvisoFerramenta)
        Me.Controls.Add(Me.labelCombustivel)
        Me.Controls.Add(Me.parafuso4)
        Me.Controls.Add(Me.parafuso2)
        Me.Controls.Add(Me.parafuso3)
        Me.Controls.Add(Me.parafuso1)
        Me.Controls.Add(Me.pictureEngine)
        Me.Controls.Add(Me.pictureCombustivel)
        Me.Controls.Add(Me.FitaColaHolder)
        Me.Controls.Add(Me.WrenchHolder)
        Me.Controls.Add(Me.canvas)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Level"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "O mecânico"
        CType(Me.canvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WrenchHolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FitaColaHolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureCombustivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEngine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parafuso1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parafuso3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parafuso2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parafuso4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents temporizadorCanvas As Timer
    Friend WithEvents canvas As PictureBox
    Friend WithEvents temporizadorFuroCombustivel As Timer
    Friend WithEvents WrenchHolder As PictureBox
    Friend WithEvents FitaColaHolder As PictureBox
    Friend WithEvents pictureCombustivel As PictureBox
    Friend WithEvents refreshEngineFrame As Timer
    Public WithEvents pictureEngine As PictureBox
    Friend WithEvents parafuso1 As PictureBox
    Friend WithEvents furoMotorTemporizador As Timer
    Friend WithEvents parafuso3 As PictureBox
    Friend WithEvents parafuso2 As PictureBox
    Friend WithEvents parafuso4 As PictureBox
    Friend WithEvents labelCombustivel As Label
    Friend WithEvents perderCombustivel As Timer
    Friend WithEvents labelAvisoFerramenta As Label
    Friend WithEvents temporizadorAviso As Timer
    Friend WithEvents temporizadorJogo As Timer
    Friend WithEvents labelTemporizadorJogo As Label
End Class
