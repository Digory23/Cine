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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtS1TotalCortesia = New System.Windows.Forms.TextBox()
        Me.txtS1TotalAdultos = New System.Windows.Forms.TextBox()
        Me.txtS1TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS1TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS1TotalNoIngresado = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtS3TotalNoIngresado = New System.Windows.Forms.TextBox()
        Me.txtS3TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS3TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS3TotalAdultos = New System.Windows.Forms.TextBox()
        Me.txtS3TotalCortesia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtS2TotalNoIngresado = New System.Windows.Forms.TextBox()
        Me.txtS2TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS2TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS2TotalAdultos = New System.Windows.Forms.TextBox()
        Me.txtS2TotalCortesia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtS4TotalNoIngresado = New System.Windows.Forms.TextBox()
        Me.txtS4TotalRecaudado = New System.Windows.Forms.TextBox()
        Me.txtS4TotalNiños = New System.Windows.Forms.TextBox()
        Me.txtS4TotalAdultos = New System.Windows.Forms.TextBox()
        Me.txtS4TotalCortesia = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtS1TotalNoIngresado)
        Me.GroupBox1.Controls.Add(Me.txtS1TotalRecaudado)
        Me.GroupBox1.Controls.Add(Me.txtS1TotalNiños)
        Me.GroupBox1.Controls.Add(Me.txtS1TotalAdultos)
        Me.GroupBox1.Controls.Add(Me.txtS1TotalCortesia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 174)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sala No.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total de Clientes con pase de Cosrtesía: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total de dinero no ingresado por pase de Cosrtesía: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total de Niños: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total de Adutos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total Recaudado: "
        '
        'txtS1TotalCortesia
        '
        Me.txtS1TotalCortesia.Location = New System.Drawing.Point(305, 32)
        Me.txtS1TotalCortesia.Name = "txtS1TotalCortesia"
        Me.txtS1TotalCortesia.ReadOnly = True
        Me.txtS1TotalCortesia.Size = New System.Drawing.Size(78, 20)
        Me.txtS1TotalCortesia.TabIndex = 5
        '
        'txtS1TotalAdultos
        '
        Me.txtS1TotalAdultos.Location = New System.Drawing.Point(305, 101)
        Me.txtS1TotalAdultos.Name = "txtS1TotalAdultos"
        Me.txtS1TotalAdultos.ReadOnly = True
        Me.txtS1TotalAdultos.Size = New System.Drawing.Size(78, 20)
        Me.txtS1TotalAdultos.TabIndex = 7
        '
        'txtS1TotalNiños
        '
        Me.txtS1TotalNiños.Location = New System.Drawing.Point(305, 78)
        Me.txtS1TotalNiños.Name = "txtS1TotalNiños"
        Me.txtS1TotalNiños.ReadOnly = True
        Me.txtS1TotalNiños.Size = New System.Drawing.Size(78, 20)
        Me.txtS1TotalNiños.TabIndex = 8
        '
        'txtS1TotalRecaudado
        '
        Me.txtS1TotalRecaudado.Location = New System.Drawing.Point(305, 125)
        Me.txtS1TotalRecaudado.Name = "txtS1TotalRecaudado"
        Me.txtS1TotalRecaudado.ReadOnly = True
        Me.txtS1TotalRecaudado.Size = New System.Drawing.Size(78, 20)
        Me.txtS1TotalRecaudado.TabIndex = 9
        '
        'txtS1TotalNoIngresado
        '
        Me.txtS1TotalNoIngresado.Location = New System.Drawing.Point(305, 56)
        Me.txtS1TotalNoIngresado.Name = "txtS1TotalNoIngresado"
        Me.txtS1TotalNoIngresado.ReadOnly = True
        Me.txtS1TotalNoIngresado.Size = New System.Drawing.Size(78, 20)
        Me.txtS1TotalNoIngresado.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtS3TotalNoIngresado)
        Me.GroupBox2.Controls.Add(Me.txtS3TotalRecaudado)
        Me.GroupBox2.Controls.Add(Me.txtS3TotalNiños)
        Me.GroupBox2.Controls.Add(Me.txtS3TotalAdultos)
        Me.GroupBox2.Controls.Add(Me.txtS3TotalCortesia)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 174)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sala No.3"
        '
        'txtS3TotalNoIngresado
        '
        Me.txtS3TotalNoIngresado.Location = New System.Drawing.Point(305, 56)
        Me.txtS3TotalNoIngresado.Name = "txtS3TotalNoIngresado"
        Me.txtS3TotalNoIngresado.ReadOnly = True
        Me.txtS3TotalNoIngresado.Size = New System.Drawing.Size(78, 20)
        Me.txtS3TotalNoIngresado.TabIndex = 10
        '
        'txtS3TotalRecaudado
        '
        Me.txtS3TotalRecaudado.Location = New System.Drawing.Point(305, 125)
        Me.txtS3TotalRecaudado.Name = "txtS3TotalRecaudado"
        Me.txtS3TotalRecaudado.ReadOnly = True
        Me.txtS3TotalRecaudado.Size = New System.Drawing.Size(78, 20)
        Me.txtS3TotalRecaudado.TabIndex = 9
        '
        'txtS3TotalNiños
        '
        Me.txtS3TotalNiños.Location = New System.Drawing.Point(305, 78)
        Me.txtS3TotalNiños.Name = "txtS3TotalNiños"
        Me.txtS3TotalNiños.ReadOnly = True
        Me.txtS3TotalNiños.Size = New System.Drawing.Size(78, 20)
        Me.txtS3TotalNiños.TabIndex = 8
        '
        'txtS3TotalAdultos
        '
        Me.txtS3TotalAdultos.Location = New System.Drawing.Point(305, 101)
        Me.txtS3TotalAdultos.Name = "txtS3TotalAdultos"
        Me.txtS3TotalAdultos.ReadOnly = True
        Me.txtS3TotalAdultos.Size = New System.Drawing.Size(78, 20)
        Me.txtS3TotalAdultos.TabIndex = 7
        '
        'txtS3TotalCortesia
        '
        Me.txtS3TotalCortesia.Location = New System.Drawing.Point(305, 32)
        Me.txtS3TotalCortesia.Name = "txtS3TotalCortesia"
        Me.txtS3TotalCortesia.ReadOnly = True
        Me.txtS3TotalCortesia.Size = New System.Drawing.Size(78, 20)
        Me.txtS3TotalCortesia.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Recaudado: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total de Adutos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total de Niños: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total de dinero no ingresado por pase de Cosrtesía: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Total de Clientes con pase de Cosrtesía: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtS2TotalNoIngresado)
        Me.GroupBox3.Controls.Add(Me.txtS2TotalRecaudado)
        Me.GroupBox3.Controls.Add(Me.txtS2TotalNiños)
        Me.GroupBox3.Controls.Add(Me.txtS2TotalAdultos)
        Me.GroupBox3.Controls.Add(Me.txtS2TotalCortesia)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(492, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 174)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sala No.2"
        '
        'txtS2TotalNoIngresado
        '
        Me.txtS2TotalNoIngresado.Location = New System.Drawing.Point(305, 56)
        Me.txtS2TotalNoIngresado.Name = "txtS2TotalNoIngresado"
        Me.txtS2TotalNoIngresado.ReadOnly = True
        Me.txtS2TotalNoIngresado.Size = New System.Drawing.Size(78, 20)
        Me.txtS2TotalNoIngresado.TabIndex = 10
        '
        'txtS2TotalRecaudado
        '
        Me.txtS2TotalRecaudado.Location = New System.Drawing.Point(305, 125)
        Me.txtS2TotalRecaudado.Name = "txtS2TotalRecaudado"
        Me.txtS2TotalRecaudado.ReadOnly = True
        Me.txtS2TotalRecaudado.Size = New System.Drawing.Size(78, 20)
        Me.txtS2TotalRecaudado.TabIndex = 9
        '
        'txtS2TotalNiños
        '
        Me.txtS2TotalNiños.Location = New System.Drawing.Point(305, 78)
        Me.txtS2TotalNiños.Name = "txtS2TotalNiños"
        Me.txtS2TotalNiños.ReadOnly = True
        Me.txtS2TotalNiños.Size = New System.Drawing.Size(78, 20)
        Me.txtS2TotalNiños.TabIndex = 8
        '
        'txtS2TotalAdultos
        '
        Me.txtS2TotalAdultos.Location = New System.Drawing.Point(305, 101)
        Me.txtS2TotalAdultos.Name = "txtS2TotalAdultos"
        Me.txtS2TotalAdultos.ReadOnly = True
        Me.txtS2TotalAdultos.Size = New System.Drawing.Size(78, 20)
        Me.txtS2TotalAdultos.TabIndex = 7
        '
        'txtS2TotalCortesia
        '
        Me.txtS2TotalCortesia.Location = New System.Drawing.Point(305, 32)
        Me.txtS2TotalCortesia.Name = "txtS2TotalCortesia"
        Me.txtS2TotalCortesia.ReadOnly = True
        Me.txtS2TotalCortesia.Size = New System.Drawing.Size(78, 20)
        Me.txtS2TotalCortesia.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Total Recaudado: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Total de Adutos:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Total de Niños: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(255, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Total de dinero no ingresado por pase de Cosrtesía: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(202, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Total de Clientes con pase de Cosrtesía: "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtS4TotalNoIngresado)
        Me.GroupBox4.Controls.Add(Me.txtS4TotalRecaudado)
        Me.GroupBox4.Controls.Add(Me.txtS4TotalNiños)
        Me.GroupBox4.Controls.Add(Me.txtS4TotalAdultos)
        Me.GroupBox4.Controls.Add(Me.txtS4TotalCortesia)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(492, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 174)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sala No.4"
        '
        'txtS4TotalNoIngresado
        '
        Me.txtS4TotalNoIngresado.Location = New System.Drawing.Point(305, 56)
        Me.txtS4TotalNoIngresado.Name = "txtS4TotalNoIngresado"
        Me.txtS4TotalNoIngresado.ReadOnly = True
        Me.txtS4TotalNoIngresado.Size = New System.Drawing.Size(78, 20)
        Me.txtS4TotalNoIngresado.TabIndex = 10
        '
        'txtS4TotalRecaudado
        '
        Me.txtS4TotalRecaudado.Location = New System.Drawing.Point(305, 125)
        Me.txtS4TotalRecaudado.Name = "txtS4TotalRecaudado"
        Me.txtS4TotalRecaudado.ReadOnly = True
        Me.txtS4TotalRecaudado.Size = New System.Drawing.Size(78, 20)
        Me.txtS4TotalRecaudado.TabIndex = 9
        '
        'txtS4TotalNiños
        '
        Me.txtS4TotalNiños.Location = New System.Drawing.Point(305, 78)
        Me.txtS4TotalNiños.Name = "txtS4TotalNiños"
        Me.txtS4TotalNiños.ReadOnly = True
        Me.txtS4TotalNiños.Size = New System.Drawing.Size(78, 20)
        Me.txtS4TotalNiños.TabIndex = 8
        '
        'txtS4TotalAdultos
        '
        Me.txtS4TotalAdultos.Location = New System.Drawing.Point(305, 101)
        Me.txtS4TotalAdultos.Name = "txtS4TotalAdultos"
        Me.txtS4TotalAdultos.ReadOnly = True
        Me.txtS4TotalAdultos.Size = New System.Drawing.Size(78, 20)
        Me.txtS4TotalAdultos.TabIndex = 7
        '
        'txtS4TotalCortesia
        '
        Me.txtS4TotalCortesia.Location = New System.Drawing.Point(305, 32)
        Me.txtS4TotalCortesia.Name = "txtS4TotalCortesia"
        Me.txtS4TotalCortesia.ReadOnly = True
        Me.txtS4TotalCortesia.Size = New System.Drawing.Size(78, 20)
        Me.txtS4TotalCortesia.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(33, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Total Recaudado: "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Total de Adutos:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(33, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Total de Niños: "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(33, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(255, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Total de dinero no ingresado por pase de Cosrtesía: "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(33, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(202, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Total de Clientes con pase de Cosrtesía: "
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(434, 443)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(102, 29)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Totales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 494)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents txtS1TotalCortesia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtS1TotalNoIngresado As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtS3TotalNoIngresado As TextBox
    Friend WithEvents txtS3TotalRecaudado As TextBox
    Friend WithEvents txtS3TotalNiños As TextBox
    Friend WithEvents txtS3TotalAdultos As TextBox
    Friend WithEvents txtS3TotalCortesia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtS2TotalNoIngresado As TextBox
    Friend WithEvents txtS2TotalRecaudado As TextBox
    Friend WithEvents txtS2TotalNiños As TextBox
    Friend WithEvents txtS2TotalAdultos As TextBox
    Friend WithEvents txtS2TotalCortesia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtS4TotalNoIngresado As TextBox
    Friend WithEvents txtS4TotalRecaudado As TextBox
    Friend WithEvents txtS4TotalNiños As TextBox
    Friend WithEvents txtS4TotalAdultos As TextBox
    Friend WithEvents txtS4TotalCortesia As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnRegresar As Button
End Class
