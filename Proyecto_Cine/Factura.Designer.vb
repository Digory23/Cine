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
        Me.txtNiños = New System.Windows.Forms.TextBox()
        Me.txtNomPeli = New System.Windows.Forms.TextBox()
        Me.txtNomCliente = New System.Windows.Forms.TextBox()
        Me.txtAsientos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbxDetalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.txtSala)
        Me.gbxDetalle.Controls.Add(Me.txtAdultos)
        Me.gbxDetalle.Controls.Add(Me.txtNiños)
        Me.gbxDetalle.Controls.Add(Me.txtNomPeli)
        Me.gbxDetalle.Controls.Add(Me.txtNomCliente)
        Me.gbxDetalle.Controls.Add(Me.txtAsientos)
        Me.gbxDetalle.Controls.Add(Me.Label8)
        Me.gbxDetalle.Controls.Add(Me.Label7)
        Me.gbxDetalle.Controls.Add(Me.Label6)
        Me.gbxDetalle.Controls.Add(Me.Label4)
        Me.gbxDetalle.Controls.Add(Me.DateTimePicker1)
        Me.gbxDetalle.Controls.Add(Me.Label3)
        Me.gbxDetalle.Controls.Add(Me.Label2)
        Me.gbxDetalle.Controls.Add(Me.Label1)
        Me.gbxDetalle.Location = New System.Drawing.Point(14, 78)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(385, 245)
        Me.gbxDetalle.TabIndex = 0
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle del Consumo"
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(203, 162)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.ReadOnly = True
        Me.txtSala.Size = New System.Drawing.Size(38, 22)
        Me.txtSala.TabIndex = 20
        '
        'txtAdultos
        '
        Me.txtAdultos.Location = New System.Drawing.Point(252, 133)
        Me.txtAdultos.Name = "txtAdultos"
        Me.txtAdultos.ReadOnly = True
        Me.txtAdultos.Size = New System.Drawing.Size(38, 22)
        Me.txtAdultos.TabIndex = 19
        '
        'txtNiños
        '
        Me.txtNiños.Location = New System.Drawing.Point(138, 133)
        Me.txtNiños.Name = "txtNiños"
        Me.txtNiños.ReadOnly = True
        Me.txtNiños.Size = New System.Drawing.Size(38, 22)
        Me.txtNiños.TabIndex = 18
        '
        'txtNomPeli
        '
        Me.txtNomPeli.Location = New System.Drawing.Point(114, 70)
        Me.txtNomPeli.Name = "txtNomPeli"
        Me.txtNomPeli.ReadOnly = True
        Me.txtNomPeli.Size = New System.Drawing.Size(189, 22)
        Me.txtNomPeli.TabIndex = 17
        '
        'txtNomCliente
        '
        Me.txtNomCliente.Location = New System.Drawing.Point(114, 40)
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.ReadOnly = True
        Me.txtNomCliente.Size = New System.Drawing.Size(189, 22)
        Me.txtNomCliente.TabIndex = 16
        '
        'txtAsientos
        '
        Me.txtAsientos.Location = New System.Drawing.Point(122, 192)
        Me.txtAsientos.Name = "txtAsientos"
        Me.txtAsientos.ReadOnly = True
        Me.txtAsientos.Size = New System.Drawing.Size(189, 22)
        Me.txtAsientos.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Asiento(s): "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Adultos: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Niños:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No. Sala: "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 22)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Película: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 131)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total a Pagar"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(212, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(78, 22)
        Me.TextBox3.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(118, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Monto Devuelto:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(211, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(78, 22)
        Me.TextBox2.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(118, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Monto Pagado:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(78, 22)
        Me.TextBox1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monto a pagar:"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(150, 486)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(135, 22)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.gbxDetalle)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 529)
        Me.Panel1.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(112, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Teléfonos: 226-7654 / 226-7655"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(137, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "SOHO Mall, Local B-12A"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(99, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 25)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Cinexxxxx Panamá, S.A."
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(438, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxDetalle As GroupBox
    Friend WithEvents txtSala As TextBox
    Friend WithEvents txtAdultos As TextBox
    Friend WithEvents txtNiños As TextBox
    Friend WithEvents txtNomPeli As TextBox
    Friend WithEvents txtNomCliente As TextBox
    Friend WithEvents txtAsientos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
