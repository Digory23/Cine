<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cartelera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCartelera = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblTanda = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblMostrarTitulo1 = New System.Windows.Forms.Label()
        Me.lblAñoPublicacion1 = New System.Windows.Forms.Label()
        Me.lblGenero1 = New System.Windows.Forms.Label()
        Me.lblTipo1 = New System.Windows.Forms.Label()
        Me.lblTanda1 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMostrarSala1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.pbPeliculas = New System.Windows.Forms.PictureBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        CType(Me.pbPeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCartelera
        '
        Me.lblCartelera.AutoSize = True
        Me.lblCartelera.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartelera.Location = New System.Drawing.Point(14, 31)
        Me.lblCartelera.Name = "lblCartelera"
        Me.lblCartelera.Size = New System.Drawing.Size(100, 25)
        Me.lblCartelera.TabIndex = 0
        Me.lblCartelera.Text = "Cartelera"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(12, 116)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(36, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Titulo:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(12, 163)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(102, 13)
        Me.lblAño.TabIndex = 2
        Me.lblAño.Text = "Año de Publicación:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(12, 207)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(45, 13)
        Me.lblGenero.TabIndex = 3
        Me.lblGenero.Text = "Genero:"
        '
        'lblTanda
        '
        Me.lblTanda.AutoSize = True
        Me.lblTanda.Location = New System.Drawing.Point(12, 258)
        Me.lblTanda.Name = "lblTanda"
        Me.lblTanda.Size = New System.Drawing.Size(41, 13)
        Me.lblTanda.TabIndex = 4
        Me.lblTanda.Text = "Tanda:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(12, 307)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "Tipo:"
        '
        'lblMostrarTitulo1
        '
        Me.lblMostrarTitulo1.AutoSize = True
        Me.lblMostrarTitulo1.Location = New System.Drawing.Point(215, 115)
        Me.lblMostrarTitulo1.Name = "lblMostrarTitulo1"
        Me.lblMostrarTitulo1.Size = New System.Drawing.Size(39, 13)
        Me.lblMostrarTitulo1.TabIndex = 6
        Me.lblMostrarTitulo1.Text = "Label1"
        '
        'lblAñoPublicacion1
        '
        Me.lblAñoPublicacion1.AutoSize = True
        Me.lblAñoPublicacion1.Location = New System.Drawing.Point(215, 163)
        Me.lblAñoPublicacion1.Name = "lblAñoPublicacion1"
        Me.lblAñoPublicacion1.Size = New System.Drawing.Size(39, 13)
        Me.lblAñoPublicacion1.TabIndex = 7
        Me.lblAñoPublicacion1.Text = "Label2"
        '
        'lblGenero1
        '
        Me.lblGenero1.AutoSize = True
        Me.lblGenero1.Location = New System.Drawing.Point(215, 207)
        Me.lblGenero1.Name = "lblGenero1"
        Me.lblGenero1.Size = New System.Drawing.Size(39, 13)
        Me.lblGenero1.TabIndex = 8
        Me.lblGenero1.Text = "Label3"
        '
        'lblTipo1
        '
        Me.lblTipo1.AutoSize = True
        Me.lblTipo1.Location = New System.Drawing.Point(215, 307)
        Me.lblTipo1.Name = "lblTipo1"
        Me.lblTipo1.Size = New System.Drawing.Size(39, 13)
        Me.lblTipo1.TabIndex = 9
        Me.lblTipo1.Text = "Label4"
        '
        'lblTanda1
        '
        Me.lblTanda1.AutoSize = True
        Me.lblTanda1.Location = New System.Drawing.Point(215, 258)
        Me.lblTanda1.Name = "lblTanda1"
        Me.lblTanda1.Size = New System.Drawing.Size(39, 13)
        Me.lblTanda1.TabIndex = 10
        Me.lblTanda1.Text = "Label5"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(457, 451)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Sala:"
        '
        'lblMostrarSala1
        '
        Me.lblMostrarSala1.AutoSize = True
        Me.lblMostrarSala1.Location = New System.Drawing.Point(215, 364)
        Me.lblMostrarSala1.Name = "lblMostrarSala1"
        Me.lblMostrarSala1.Size = New System.Drawing.Size(39, 13)
        Me.lblMostrarSala1.TabIndex = 23
        Me.lblMostrarSala1.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Seleccionar"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(133, 410)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'pbPeliculas
        '
        Me.pbPeliculas.Location = New System.Drawing.Point(332, 115)
        Me.pbPeliculas.Name = "pbPeliculas"
        Me.pbPeliculas.Size = New System.Drawing.Size(190, 262)
        Me.pbPeliculas.TabIndex = 27
        Me.pbPeliculas.TabStop = False
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(357, 451)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprar.TabIndex = 28
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'Cartelera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 486)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.pbPeliculas)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMostrarSala1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblTanda1)
        Me.Controls.Add(Me.lblTipo1)
        Me.Controls.Add(Me.lblGenero1)
        Me.Controls.Add(Me.lblAñoPublicacion1)
        Me.Controls.Add(Me.lblMostrarTitulo1)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblTanda)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblCartelera)
        Me.Name = "Cartelera"
        Me.Text = "Cartelera"
        CType(Me.pbPeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCartelera As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAño As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblTanda As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblMostrarTitulo1 As Label
    Friend WithEvents lblAñoPublicacion1 As Label
    Friend WithEvents lblGenero1 As Label
    Friend WithEvents lblTipo1 As Label
    Friend WithEvents lblTanda1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMostrarSala1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents pbPeliculas As PictureBox
    Friend WithEvents btnComprar As Button
End Class
