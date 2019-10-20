<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cartelera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.cmbPelicula = New System.Windows.Forms.ComboBox()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.pbPeliculas = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pbPeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCartelera
        '
        Me.lblCartelera.AutoSize = True
        Me.lblCartelera.BackColor = System.Drawing.Color.Transparent
        Me.lblCartelera.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartelera.ForeColor = System.Drawing.Color.White
        Me.lblCartelera.Location = New System.Drawing.Point(32, 16)
        Me.lblCartelera.Name = "lblCartelera"
        Me.lblCartelera.Size = New System.Drawing.Size(171, 47)
        Me.lblCartelera.TabIndex = 0
        Me.lblCartelera.Text = "Cartelera"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(21, 28)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(40, 15)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Titulo:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(21, 75)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(113, 15)
        Me.lblAño.TabIndex = 2
        Me.lblAño.Text = "Año de Publicación:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(21, 119)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(48, 15)
        Me.lblGenero.TabIndex = 3
        Me.lblGenero.Text = "Genero:"
        '
        'lblTanda
        '
        Me.lblTanda.AutoSize = True
        Me.lblTanda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanda.Location = New System.Drawing.Point(21, 170)
        Me.lblTanda.Name = "lblTanda"
        Me.lblTanda.Size = New System.Drawing.Size(41, 15)
        Me.lblTanda.TabIndex = 4
        Me.lblTanda.Text = "Tanda:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(21, 219)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(33, 15)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "Tipo:"
        '
        'lblMostrarTitulo1
        '
        Me.lblMostrarTitulo1.AutoSize = True
        Me.lblMostrarTitulo1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarTitulo1.Location = New System.Drawing.Point(148, 27)
        Me.lblMostrarTitulo1.Name = "lblMostrarTitulo1"
        Me.lblMostrarTitulo1.Size = New System.Drawing.Size(41, 15)
        Me.lblMostrarTitulo1.TabIndex = 6
        Me.lblMostrarTitulo1.Text = "Label1"
        '
        'lblAñoPublicacion1
        '
        Me.lblAñoPublicacion1.AutoSize = True
        Me.lblAñoPublicacion1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñoPublicacion1.Location = New System.Drawing.Point(148, 75)
        Me.lblAñoPublicacion1.Name = "lblAñoPublicacion1"
        Me.lblAñoPublicacion1.Size = New System.Drawing.Size(41, 15)
        Me.lblAñoPublicacion1.TabIndex = 7
        Me.lblAñoPublicacion1.Text = "Label2"
        '
        'lblGenero1
        '
        Me.lblGenero1.AutoSize = True
        Me.lblGenero1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero1.Location = New System.Drawing.Point(148, 119)
        Me.lblGenero1.Name = "lblGenero1"
        Me.lblGenero1.Size = New System.Drawing.Size(41, 15)
        Me.lblGenero1.TabIndex = 8
        Me.lblGenero1.Text = "Label3"
        '
        'lblTipo1
        '
        Me.lblTipo1.AutoSize = True
        Me.lblTipo1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo1.Location = New System.Drawing.Point(148, 219)
        Me.lblTipo1.Name = "lblTipo1"
        Me.lblTipo1.Size = New System.Drawing.Size(41, 15)
        Me.lblTipo1.TabIndex = 9
        Me.lblTipo1.Text = "Label4"
        '
        'lblTanda1
        '
        Me.lblTanda1.AutoSize = True
        Me.lblTanda1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanda1.Location = New System.Drawing.Point(148, 170)
        Me.lblTanda1.Name = "lblTanda1"
        Me.lblTanda1.Size = New System.Drawing.Size(41, 15)
        Me.lblTanda1.TabIndex = 10
        Me.lblTanda1.Text = "Label5"
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(40, 447)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(102, 37)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Sala:"
        '
        'lblMostrarSala1
        '
        Me.lblMostrarSala1.AutoSize = True
        Me.lblMostrarSala1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarSala1.Location = New System.Drawing.Point(148, 276)
        Me.lblMostrarSala1.Name = "lblMostrarSala1"
        Me.lblMostrarSala1.Size = New System.Drawing.Size(41, 15)
        Me.lblMostrarSala1.TabIndex = 23
        Me.lblMostrarSala1.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Seleccionar"
        '
        'cmbPelicula
        '
        Me.cmbPelicula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPelicula.FormattingEnabled = True
        Me.cmbPelicula.Location = New System.Drawing.Point(124, 322)
        Me.cmbPelicula.Name = "cmbPelicula"
        Me.cmbPelicula.Size = New System.Drawing.Size(121, 23)
        Me.cmbPelicula.TabIndex = 26
        '
        'btnComprar
        '
        Me.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.ForeColor = System.Drawing.Color.Maroon
        Me.btnComprar.Location = New System.Drawing.Point(398, 447)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(120, 35)
        Me.btnComprar.TabIndex = 28
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'pbPeliculas
        '
        Me.pbPeliculas.BackColor = System.Drawing.Color.Transparent
        Me.pbPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPeliculas.Location = New System.Drawing.Point(330, 66)
        Me.pbPeliculas.Name = "pbPeliculas"
        Me.pbPeliculas.Size = New System.Drawing.Size(239, 363)
        Me.pbPeliculas.TabIndex = 27
        Me.pbPeliculas.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbPelicula)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblMostrarSala1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblTanda1)
        Me.Panel1.Controls.Add(Me.lblTipo1)
        Me.Panel1.Controls.Add(Me.lblGenero1)
        Me.Panel1.Controls.Add(Me.lblAñoPublicacion1)
        Me.Panel1.Controls.Add(Me.lblMostrarTitulo1)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.lblTanda)
        Me.Panel1.Controls.Add(Me.lblGenero)
        Me.Panel1.Controls.Add(Me.lblAño)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(40, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 363)
        Me.Panel1.TabIndex = 29
        '
        'Cartelera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Cine.My.Resources.Resources.movieseats
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(603, 512)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.pbPeliculas)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblCartelera)
        Me.Name = "Cartelera"
        Me.Text = "Cartelera"
        CType(Me.pbPeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents cmbPelicula As ComboBox
    Friend WithEvents pbPeliculas As PictureBox
    Friend WithEvents btnComprar As Button
    Friend WithEvents Panel1 As Panel
End Class
