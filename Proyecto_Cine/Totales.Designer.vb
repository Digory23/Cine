<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Totales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtS1TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS1TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS1TotalAdultos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtS3TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS3TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS3TotalAdultos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtS2TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS2TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS2TotalAdultos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtS4TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS4TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS4TotalAdultos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(40, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtS1TotalRecaudado)
        Me.GroupBox1.Controls.Add(Me.txtS1TotalNiños)
        Me.GroupBox1.Controls.Add(Me.txtS1TotalAdultos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 121)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sala No.1"
        '
        'txtS1TotalRecaudado
        '
        Me.txtS1TotalRecaudado.Location = New System.Drawing.Point(144, 81)
        Me.txtS1TotalRecaudado.Name = "txtS1TotalRecaudado"
        Me.txtS1TotalRecaudado.ReadOnly = True
        Me.txtS1TotalRecaudado.Size = New System.Drawing.Size(78, 22)
        Me.txtS1TotalRecaudado.TabIndex = 9
        '
        'txtS1TotalNiños
        '
        Me.txtS1TotalNiños.Location = New System.Drawing.Point(144, 34)
        Me.txtS1TotalNiños.Name = "txtS1TotalNiños"
        Me.txtS1TotalNiños.ReadOnly = True
        Me.txtS1TotalNiños.Size = New System.Drawing.Size(78, 22)
        Me.txtS1TotalNiños.TabIndex = 8
        '
        'txtS1TotalAdultos
        '
        Me.txtS1TotalAdultos.Location = New System.Drawing.Point(144, 57)
        Me.txtS1TotalAdultos.Name = "txtS1TotalAdultos"
        Me.txtS1TotalAdultos.ReadOnly = True
        Me.txtS1TotalAdultos.Size = New System.Drawing.Size(78, 22)
        Me.txtS1TotalAdultos.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total Recaudado: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total de Adutos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total de Niños: "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtS3TotalRecaudado)
        Me.GroupBox2.Controls.Add(Me.txtS3TotalNiños)
        Me.GroupBox2.Controls.Add(Me.txtS3TotalAdultos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 121)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sala No.3"
        '
        'txtS3TotalRecaudado
        '
        Me.txtS3TotalRecaudado.Location = New System.Drawing.Point(144, 88)
        Me.txtS3TotalRecaudado.Name = "txtS3TotalRecaudado"
        Me.txtS3TotalRecaudado.ReadOnly = True
        Me.txtS3TotalRecaudado.Size = New System.Drawing.Size(78, 22)
        Me.txtS3TotalRecaudado.TabIndex = 9
        '
        'txtS3TotalNiños
        '
        Me.txtS3TotalNiños.Location = New System.Drawing.Point(144, 41)
        Me.txtS3TotalNiños.Name = "txtS3TotalNiños"
        Me.txtS3TotalNiños.ReadOnly = True
        Me.txtS3TotalNiños.Size = New System.Drawing.Size(78, 22)
        Me.txtS3TotalNiños.TabIndex = 8
        '
        'txtS3TotalAdultos
        '
        Me.txtS3TotalAdultos.Location = New System.Drawing.Point(144, 64)
        Me.txtS3TotalAdultos.Name = "txtS3TotalAdultos"
        Me.txtS3TotalAdultos.ReadOnly = True
        Me.txtS3TotalAdultos.Size = New System.Drawing.Size(78, 22)
        Me.txtS3TotalAdultos.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Recaudado: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total de Adutos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total de Niños: "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtS2TotalRecaudado)
        Me.GroupBox3.Controls.Add(Me.txtS2TotalNiños)
        Me.GroupBox3.Controls.Add(Me.txtS2TotalAdultos)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(331, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 121)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sala No.2"
        '
        'txtS2TotalRecaudado
        '
        Me.txtS2TotalRecaudado.Location = New System.Drawing.Point(148, 77)
        Me.txtS2TotalRecaudado.Name = "txtS2TotalRecaudado"
        Me.txtS2TotalRecaudado.ReadOnly = True
        Me.txtS2TotalRecaudado.Size = New System.Drawing.Size(78, 22)
        Me.txtS2TotalRecaudado.TabIndex = 9
        '
        'txtS2TotalNiños
        '
        Me.txtS2TotalNiños.Location = New System.Drawing.Point(148, 30)
        Me.txtS2TotalNiños.Name = "txtS2TotalNiños"
        Me.txtS2TotalNiños.ReadOnly = True
        Me.txtS2TotalNiños.Size = New System.Drawing.Size(78, 22)
        Me.txtS2TotalNiños.TabIndex = 8
        '
        'txtS2TotalAdultos
        '
        Me.txtS2TotalAdultos.Location = New System.Drawing.Point(148, 53)
        Me.txtS2TotalAdultos.Name = "txtS2TotalAdultos"
        Me.txtS2TotalAdultos.ReadOnly = True
        Me.txtS2TotalAdultos.Size = New System.Drawing.Size(78, 22)
        Me.txtS2TotalAdultos.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Total Recaudado: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Total de Adutos:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Total de Niños: "
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtS4TotalRecaudado)
        Me.GroupBox4.Controls.Add(Me.txtS4TotalNiños)
        Me.GroupBox4.Controls.Add(Me.txtS4TotalAdultos)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(331, 214)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 121)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sala No.4"
        '
        'txtS4TotalRecaudado
        '
        Me.txtS4TotalRecaudado.Location = New System.Drawing.Point(148, 88)
        Me.txtS4TotalRecaudado.Name = "txtS4TotalRecaudado"
        Me.txtS4TotalRecaudado.ReadOnly = True
        Me.txtS4TotalRecaudado.Size = New System.Drawing.Size(78, 22)
        Me.txtS4TotalRecaudado.TabIndex = 9
        '
        'txtS4TotalNiños
        '
        Me.txtS4TotalNiños.Location = New System.Drawing.Point(148, 41)
        Me.txtS4TotalNiños.Name = "txtS4TotalNiños"
        Me.txtS4TotalNiños.ReadOnly = True
        Me.txtS4TotalNiños.Size = New System.Drawing.Size(78, 22)
        Me.txtS4TotalNiños.TabIndex = 8
        '
        'txtS4TotalAdultos
        '
        Me.txtS4TotalAdultos.Location = New System.Drawing.Point(148, 64)
        Me.txtS4TotalAdultos.Name = "txtS4TotalAdultos"
        Me.txtS4TotalAdultos.ReadOnly = True
        Me.txtS4TotalAdultos.Size = New System.Drawing.Size(78, 22)
        Me.txtS4TotalAdultos.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 95)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Total Recaudado: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Total de Adutos:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Total de Niños: "
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.DarkRed
        Me.btnSalir.Location = New System.Drawing.Point(272, 458)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(102, 29)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(249, 362)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(521, 388)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(58, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(521, 362)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(58, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(249, 388)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(56, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(249, 418)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(56, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Clientes con pase de cortesia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total de Ninos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 26)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Dinero no recaudado por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pase de cortesia:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Total recaudado:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(328, 391)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Total de Adultos:"
        '
        'Totales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(627, 510)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Totales"
        Me.Text = "Totales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtS1TotalRecaudado As TextBox
    Friend WithEvents txtS1TotalNiños As TextBox
    Friend WithEvents txtS1TotalAdultos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtS3TotalRecaudado As TextBox
    Friend WithEvents txtS3TotalNiños As TextBox
    Friend WithEvents txtS3TotalAdultos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtS2TotalRecaudado As TextBox
    Friend WithEvents txtS2TotalNiños As TextBox
    Friend WithEvents txtS2TotalAdultos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtS4TotalRecaudado As TextBox
    Friend WithEvents txtS4TotalNiños As TextBox
    Friend WithEvents txtS4TotalAdultos As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
End Class
