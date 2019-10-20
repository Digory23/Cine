<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peliculas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cmbTanda = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSala = New System.Windows.Forms.ComboBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Género"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanda "
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(119, 15)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 4
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(119, 67)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 5
        '
        'cmbGenero
        '
        Me.cmbGenero.DisplayMember = "Terror "
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Terror ", "Aventura ", "Romance "})
        Me.cmbGenero.Location = New System.Drawing.Point(119, 116)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(121, 21)
        Me.cmbGenero.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(58, 58)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(296, 25)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Ingresar los datos de las películas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbTanda
        '
        Me.cmbTanda.FormattingEnabled = True
        Me.cmbTanda.Items.AddRange(New Object() {"Mañana", "Tarde", "Noche"})
        Me.cmbTanda.Location = New System.Drawing.Point(119, 167)
        Me.cmbTanda.Name = "cmbTanda"
        Me.cmbTanda.Size = New System.Drawing.Size(121, 21)
        Me.cmbTanda.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo "
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Regular ", "Estreno"})
        Me.cmbTipo.Location = New System.Drawing.Point(119, 213)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 10
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnIngresar.Location = New System.Drawing.Point(43, 367)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 11
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Duración"
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(119, 260)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(100, 20)
        Me.txtDuracion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Sala"
        '
        'cmbSala
        '
        Me.cmbSala.FormattingEnabled = True
        Me.cmbSala.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbSala.Location = New System.Drawing.Point(119, 308)
        Me.cmbSala.Name = "cmbSala"
        Me.cmbSala.Size = New System.Drawing.Size(121, 21)
        Me.cmbSala.TabIndex = 19
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Olive
        Me.btnConfirmar.Location = New System.Drawing.Point(165, 367)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 20
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.cmbSala)
        Me.Panel1.Controls.Add(Me.btnConfirmar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.txtDuracion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbTipo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbTanda)
        Me.Panel1.Controls.Add(Me.cmbGenero)
        Me.Panel1.Controls.Add(Me.txtAño)
        Me.Panel1.Controls.Add(Me.txtTitulo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(63, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 439)
        Me.Panel1.TabIndex = 21
        '
        'btnRegresar
        '
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.ForeColor = System.Drawing.Color.Black
        Me.btnRegresar.Location = New System.Drawing.Point(103, 413)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Peliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Proyecto_Cine.My.Resources.Resources.movieframered
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(406, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Peliculas"
        Me.Text = "Peliculas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents cmbTanda As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbSala As ComboBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As Button
End Class
