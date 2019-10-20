<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomCliente = New System.Windows.Forms.TextBox()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkCortesia = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstAsientos = New System.Windows.Forms.ListBox()
        Me.btnAsientos = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rdbEstreno = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbRegular = New System.Windows.Forms.RadioButton()
        Me.txtSala = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstAsientos2 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Niños"
        '
        'txtNomCliente
        '
        Me.txtNomCliente.Location = New System.Drawing.Point(86, 40)
        Me.txtNomCliente.Name = "txtNomCliente"
        Me.txtNomCliente.Size = New System.Drawing.Size(196, 23)
        Me.txtNomCliente.TabIndex = 4
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(550, 288)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(75, 23)
        Me.btnFacturar.TabIndex = 16
        Me.btnFacturar.Text = "Factura"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lstAsientos2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkCortesia)
        Me.GroupBox1.Controls.Add(Me.btnFacturar)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lstAsientos)
        Me.GroupBox1.Controls.Add(Me.btnAsientos)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtNomCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 339)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(406, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(202, 23)
        Me.TextBox1.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Película"
        '
        'chkCortesia
        '
        Me.chkCortesia.AutoSize = True
        Me.chkCortesia.Location = New System.Drawing.Point(550, 246)
        Me.chkCortesia.Name = "chkCortesia"
        Me.chkCortesia.Size = New System.Drawing.Size(69, 19)
        Me.chkCortesia.TabIndex = 29
        Me.chkCortesia.Text = "Cortesía"
        Me.chkCortesia.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(87, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(195, 23)
        Me.DateTimePicker1.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Fecha:"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(537, 183)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(74, 26)
        Me.btnQuitar.TabIndex = 25
        Me.btnQuitar.Text = "Limpiar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(537, 153)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(74, 26)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Asientos Seleccionados: "
        '
        'lstAsientos
        '
        Me.lstAsientos.FormattingEnabled = True
        Me.lstAsientos.ItemHeight = 15
        Me.lstAsientos.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5"})
        Me.lstAsientos.Location = New System.Drawing.Point(406, 156)
        Me.lstAsientos.Name = "lstAsientos"
        Me.lstAsientos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAsientos.Size = New System.Drawing.Size(100, 49)
        Me.lstAsientos.TabIndex = 21
        '
        'btnAsientos
        '
        Me.btnAsientos.Location = New System.Drawing.Point(432, 82)
        Me.btnAsientos.Name = "btnAsientos"
        Me.btnAsientos.Size = New System.Drawing.Size(158, 26)
        Me.btnAsientos.TabIndex = 20
        Me.btnAsientos.Text = "Consultar Asientos"
        Me.btnAsientos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Seleccione los asientos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SplitContainer1)
        Me.GroupBox3.Location = New System.Drawing.Point(44, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 134)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Película"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 19)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdbEstreno)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdbRegular)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSala)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(216, 101)
        Me.SplitContainer1.SplitterDistance = 107
        Me.SplitContainer1.TabIndex = 18
        '
        'rdbEstreno
        '
        Me.rdbEstreno.AutoSize = True
        Me.rdbEstreno.Location = New System.Drawing.Point(23, 67)
        Me.rdbEstreno.Name = "rdbEstreno"
        Me.rdbEstreno.Size = New System.Drawing.Size(64, 19)
        Me.rdbEstreno.TabIndex = 3
        Me.rdbEstreno.TabStop = True
        Me.rdbEstreno.Text = "Estreno"
        Me.rdbEstreno.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo"
        '
        'rdbRegular
        '
        Me.rdbRegular.AutoSize = True
        Me.rdbRegular.Location = New System.Drawing.Point(23, 44)
        Me.rdbRegular.Name = "rdbRegular"
        Me.rdbRegular.Size = New System.Drawing.Size(65, 19)
        Me.rdbRegular.TabIndex = 2
        Me.rdbRegular.TabStop = True
        Me.rdbRegular.Text = "Regular"
        Me.rdbRegular.UseVisualStyleBackColor = True
        '
        'txtSala
        '
        Me.txtSala.Location = New System.Drawing.Point(16, 44)
        Me.txtSala.Name = "txtSala"
        Me.txtSala.ReadOnly = True
        Me.txtSala.Size = New System.Drawing.Size(75, 23)
        Me.txtSala.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Sala"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(91, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 98)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cantidad de Boletos"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(69, 62)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(50, 23)
        Me.NumericUpDown2.TabIndex = 6
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(68, 32)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(50, 23)
        Me.NumericUpDown1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Adultos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 30)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Compra del boleto"
        '
        'lstAsientos2
        '
        Me.lstAsientos2.FormattingEnabled = True
        Me.lstAsientos2.ItemHeight = 15
        Me.lstAsientos2.Location = New System.Drawing.Point(406, 246)
        Me.lstAsientos2.Name = "lstAsientos2"
        Me.lstAsientos2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstAsientos2.Size = New System.Drawing.Size(100, 49)
        Me.lstAsientos2.TabIndex = 32
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Proyecto_Cine.My.Resources.Resources.mask
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(755, 448)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomCliente As TextBox
    Friend WithEvents btnFacturar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkCortesia As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lstAsientos As ListBox
    Friend WithEvents btnAsientos As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents rdbEstreno As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rdbRegular As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSala As TextBox
    Friend WithEvents lstAsientos2 As ListBox
End Class
