<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.btnTandas = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTandas
        '
        Me.btnTandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTandas.ForeColor = System.Drawing.Color.Maroon
        Me.btnTandas.Location = New System.Drawing.Point(339, 56)
        Me.btnTandas.Name = "btnTandas"
        Me.btnTandas.Size = New System.Drawing.Size(166, 29)
        Me.btnTandas.TabIndex = 1
        Me.btnTandas.Text = "Actualizar Tandas y Horarios"
        Me.btnTandas.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnConsultar.Location = New System.Drawing.Point(339, 122)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(166, 27)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar Tandas y Horarios"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnRevisar
        '
        Me.btnRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevisar.Location = New System.Drawing.Point(339, 188)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(166, 25)
        Me.btnRevisar.TabIndex = 5
        Me.btnRevisar.Text = "Consultar Asientos Disponibles"
        Me.btnRevisar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(249, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(57, 60)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(249, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(57, 58)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(249, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(57, 55)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Selecciona una opción"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Cine.My.Resources.Resources.moviebg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(733, 385)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRevisar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnTandas)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTandas As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnRevisar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
