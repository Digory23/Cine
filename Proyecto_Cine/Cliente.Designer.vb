<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.dudBoletos = New System.Windows.Forms.DomainUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.txtAsientos = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chbAdulto = New System.Windows.Forms.CheckBox()
        Me.chbNiño = New System.Windows.Forms.CheckBox()
        Me.lblCortesia = New System.Windows.Forms.Label()
        Me.ckbCortesia = New System.Windows.Forms.CheckBox()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(12, 23)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(87, 13)
        Me.lblDatos.TabIndex = 0
        Me.lblDatos.Text = "Datos del Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Número de Boletos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(179, 79)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(179, 128)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 5
        '
        'dudBoletos
        '
        Me.dudBoletos.Location = New System.Drawing.Point(179, 182)
        Me.dudBoletos.Name = "dudBoletos"
        Me.dudBoletos.Size = New System.Drawing.Size(120, 20)
        Me.dudBoletos.TabIndex = 6
        Me.dudBoletos.Text = "DomainUpDown1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Asientos"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(52, 298)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 9
        Me.lblEdad.Text = "Edad"
        '
        'txtAsientos
        '
        Me.txtAsientos.Location = New System.Drawing.Point(179, 228)
        Me.txtAsientos.Name = "txtAsientos"
        Me.txtAsientos.Size = New System.Drawing.Size(100, 20)
        Me.txtAsientos.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chbAdulto)
        Me.Panel1.Controls.Add(Me.chbNiño)
        Me.Panel1.Location = New System.Drawing.Point(179, 280)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 67)
        Me.Panel1.TabIndex = 11
        '
        'chbAdulto
        '
        Me.chbAdulto.AutoSize = True
        Me.chbAdulto.Location = New System.Drawing.Point(4, 38)
        Me.chbAdulto.Name = "chbAdulto"
        Me.chbAdulto.Size = New System.Drawing.Size(56, 17)
        Me.chbAdulto.TabIndex = 1
        Me.chbAdulto.Text = "Adulto"
        Me.chbAdulto.UseVisualStyleBackColor = True
        '
        'chbNiño
        '
        Me.chbNiño.AutoSize = True
        Me.chbNiño.Location = New System.Drawing.Point(4, 14)
        Me.chbNiño.Name = "chbNiño"
        Me.chbNiño.Size = New System.Drawing.Size(48, 17)
        Me.chbNiño.TabIndex = 0
        Me.chbNiño.Text = "Niño"
        Me.chbNiño.UseVisualStyleBackColor = True
        '
        'lblCortesia
        '
        Me.lblCortesia.AutoSize = True
        Me.lblCortesia.Location = New System.Drawing.Point(52, 383)
        Me.lblCortesia.Name = "lblCortesia"
        Me.lblCortesia.Size = New System.Drawing.Size(47, 13)
        Me.lblCortesia.TabIndex = 14
        Me.lblCortesia.Text = "Cortesía"
        '
        'ckbCortesia
        '
        Me.ckbCortesia.AutoSize = True
        Me.ckbCortesia.Location = New System.Drawing.Point(178, 382)
        Me.ckbCortesia.Name = "ckbCortesia"
        Me.ckbCortesia.Size = New System.Drawing.Size(66, 17)
        Me.ckbCortesia.TabIndex = 15
        Me.ckbCortesia.Text = "Cortesía"
        Me.ckbCortesia.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(118, 548)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(75, 23)
        Me.btnFacturar.TabIndex = 16
        Me.btnFacturar.Text = "Factura"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(21, 17)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(152, 14)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 18
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.Location = New System.Drawing.Point(21, 94)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(45, 13)
        Me.lblCambio.TabIndex = 19
        Me.lblCambio.Text = "Cambio:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(152, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Pagado:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblCambio)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(31, 415)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 116)
        Me.Panel2.TabIndex = 23
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 583)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.ckbCortesia)
        Me.Controls.Add(Me.lblCortesia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAsientos)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dudBoletos)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDatos)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDatos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents dudBoletos As DomainUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents txtAsientos As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chbAdulto As CheckBox
    Friend WithEvents chbNiño As CheckBox
    Friend WithEvents lblCortesia As Label
    Friend WithEvents ckbCortesia As CheckBox
    Friend WithEvents btnFacturar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblCambio As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
End Class
