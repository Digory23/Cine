<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.txtAdultos = New System.Windows.Forms.TextBox()
        Me.txtNinos = New System.Windows.Forms.TextBox()
        Me.txtNomPeli = New System.Windows.Forms.TextBox()
        Me.txtNomCliente = New System.Windows.Forms.TextBox()
        Me.txtAsientos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDescPeli = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblMensCortesia = New System.Windows.Forms.Label()
        Me.txtMDevuelto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMPagado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMPagar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.Panel()
        Me.fechaHoy = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fechaPeli = New System.Windows.Forms.TextBox()
        Me.gbxDetalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.txtDescuento.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDetalle
        '
        Me.gbxDetalle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxDetalle.Controls.Add(Me.fechaPeli)
        Me.gbxDetalle.Controls.Add(Me.txtSala)
        Me.gbxDetalle.Controls.Add(Me.txtAdultos)
        Me.gbxDetalle.Controls.Add(Me.txtNinos)
        Me.gbxDetalle.Controls.Add(Me.txtNomPeli)
        Me.gbxDetalle.Controls.Add(Me.txtNomCliente)
        Me.gbxDetalle.Controls.Add(Me.txtAsientos)
        Me.gbxDetalle.Controls.Add(Me.Label8)
        Me.gbxDetalle.Controls.Add(Me.Label7)
        Me.gbxDetalle.Controls.Add(Me.Label6)
        Me.gbxDetalle.Controls.Add(Me.Label4)
        Me.gbxDetalle.Controls.Add(Me.Label3)
        Me.gbxDetalle.Controls.Add(Me.Label2)
        Me.gbxDetalle.Controls.Add(Me.Label1)
        Me.gbxDetalle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalle.Location = New System.Drawing.Point(14, 134)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(385, 245)
        Me.gbxDetalle.TabIndex = 0
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle del Consumo"
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(149, 164)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.ReadOnly = True
        Me.txtSala.Size = New System.Drawing.Size(38, 23)
        Me.txtSala.TabIndex = 20
        '
        'txtAdultos
        '
        Me.txtAdultos.Location = New System.Drawing.Point(149, 130)
        Me.txtAdultos.Name = "txtAdultos"
        Me.txtAdultos.ReadOnly = True
        Me.txtAdultos.Size = New System.Drawing.Size(38, 23)
        Me.txtAdultos.TabIndex = 19
        '
        'txtNinos
        '
        Me.txtNinos.Location = New System.Drawing.Point(300, 130)
        Me.txtNinos.Name = "txtNinos"
        Me.txtNinos.ReadOnly = True
        Me.txtNinos.Size = New System.Drawing.Size(38, 23)
        Me.txtNinos.TabIndex = 18
        '
        'txtNomPeli
        '
        Me.txtNomPeli.Location = New System.Drawing.Point(149, 67)
        Me.txtNomPeli.Name = "txtNomPeli"
        Me.txtNomPeli.ReadOnly = True
        Me.txtNomPeli.Size = New System.Drawing.Size(189, 23)
        Me.txtNomPeli.TabIndex = 17
        '
        'txtNomCliente
        '
        Me.txtNomCliente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNomCliente.Location = New System.Drawing.Point(149, 37)
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.ReadOnly = True
        Me.txtNomCliente.Size = New System.Drawing.Size(189, 23)
        Me.txtNomCliente.TabIndex = 16
        '
        'txtAsientos
        '
        Me.txtAsientos.Location = New System.Drawing.Point(149, 195)
        Me.txtAsientos.Name = "txtAsientos"
        Me.txtAsientos.ReadOnly = True
        Me.txtAsientos.Size = New System.Drawing.Size(189, 23)
        Me.txtAsientos.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Asiento(s): "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Adultos: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Niños:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No. Sala: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Película: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtDescPeli)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lblMensCortesia)
        Me.GroupBox1.Controls.Add(Me.txtMDevuelto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtMPagado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMPagar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(419, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 245)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total a Pagar"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(212, 28)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(78, 22)
        Me.txtTotal.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Total:"
        '
        'txtDescPeli
        '
        Me.txtDescPeli.Location = New System.Drawing.Point(212, 58)
        Me.txtDescPeli.Name = "txtDescPeli"
        Me.txtDescPeli.ReadOnly = True
        Me.txtDescPeli.Size = New System.Drawing.Size(78, 22)
        Me.txtDescPeli.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(33, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Descuento:"
        '
        'lblMensCortesia
        '
        Me.lblMensCortesia.AutoSize = True
        Me.lblMensCortesia.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMensCortesia.Location = New System.Drawing.Point(76, 198)
        Me.lblMensCortesia.Name = "lblMensCortesia"
        Me.lblMensCortesia.Size = New System.Drawing.Size(176, 13)
        Me.lblMensCortesia.TabIndex = 26
        Me.lblMensCortesia.Text = "Mensaje si tiene pase de cortesia"
        Me.lblMensCortesia.Visible = False
        '
        'txtMDevuelto
        '
        Me.txtMDevuelto.Location = New System.Drawing.Point(212, 155)
        Me.txtMDevuelto.Name = "txtMDevuelto"
        Me.txtMDevuelto.ReadOnly = True
        Me.txtMDevuelto.Size = New System.Drawing.Size(78, 22)
        Me.txtMDevuelto.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Monto Devuelto:"
        '
        'txtMPagado
        '
        Me.txtMPagado.Location = New System.Drawing.Point(212, 122)
        Me.txtMPagado.Name = "txtMPagado"
        Me.txtMPagado.ReadOnly = True
        Me.txtMPagado.Size = New System.Drawing.Size(78, 22)
        Me.txtMPagado.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Monto Pagado:"
        '
        'txtMPagar
        '
        Me.txtMPagar.Location = New System.Drawing.Point(212, 91)
        Me.txtMPagar.Name = "txtMPagar"
        Me.txtMPagar.ReadOnly = True
        Me.txtMPagar.Size = New System.Drawing.Size(78, 22)
        Me.txtMPagar.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monto a pagar:"
        '
        'btnRegresar
        '
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnRegresar.Location = New System.Drawing.Point(314, 471)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(135, 28)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.White
        Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuento.Controls.Add(Me.fechaHoy)
        Me.txtDescuento.Controls.Add(Me.Label14)
        Me.txtDescuento.Controls.Add(Me.PictureBox1)
        Me.txtDescuento.Controls.Add(Me.Label13)
        Me.txtDescuento.Controls.Add(Me.Label12)
        Me.txtDescuento.Controls.Add(Me.Label11)
        Me.txtDescuento.Controls.Add(Me.btnRegresar)
        Me.txtDescuento.Controls.Add(Me.GroupBox1)
        Me.txtDescuento.Controls.Add(Me.gbxDetalle)
        Me.txtDescuento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(8, 9)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(759, 517)
        Me.txtDescuento.TabIndex = 3
        '
        'fechaHoy
        '
        Me.fechaHoy.AutoSize = True
        Me.fechaHoy.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaHoy.Location = New System.Drawing.Point(341, 89)
        Me.fechaHoy.Name = "fechaHoy"
        Me.fechaHoy.Size = New System.Drawing.Size(85, 17)
        Me.fechaHoy.TabIndex = 8
        Me.fechaHoy.Text = "Fecha de hoy"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(296, 439)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 20)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "¡Gracias por preferirnos!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Proyecto_Cine.My.Resources.Resources.barcode
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(324, 410)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 26)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(280, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Teléfonos: 226-7654 / 226-7655"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(311, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "SOHO Mall, Local B-12A"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(269, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Cinexxxxx Panamá, S.A."
        '
        'fechaPeli
        '
        Me.fechaPeli.Location = New System.Drawing.Point(149, 99)
        Me.fechaPeli.Name = "fechaPeli"
        Me.fechaPeli.ReadOnly = True
        Me.fechaPeli.Size = New System.Drawing.Size(189, 23)
        Me.fechaPeli.TabIndex = 21
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Proyecto_Cine.My.Resources.Resources.movieseats
        Me.ClientSize = New System.Drawing.Size(779, 532)
        Me.Controls.Add(Me.txtDescuento)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.txtDescuento.ResumeLayout(False)
        Me.txtDescuento.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxDetalle As GroupBox
    Friend WithEvents txtSala As TextBox
    Friend WithEvents txtAdultos As TextBox
    Friend WithEvents txtNinos As TextBox
    Friend WithEvents txtNomPeli As TextBox
    Friend WithEvents txtNomCliente As TextBox
    Friend WithEvents txtAsientos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMDevuelto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMPagado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMPagar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtDescuento As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblMensCortesia As Label
    Friend WithEvents fechaHoy As Label
    Friend WithEvents txtDescPeli As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents fechaPeli As TextBox
End Class
