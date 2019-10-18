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
        Me.lblTandas = New System.Windows.Forms.Label()
        Me.btnTandas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.lblAsientos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblTandas
        '
        Me.lblTandas.AutoSize = True
        Me.lblTandas.Location = New System.Drawing.Point(23, 250)
        Me.lblTandas.Name = "lblTandas"
        Me.lblTandas.Size = New System.Drawing.Size(142, 13)
        Me.lblTandas.TabIndex = 0
        Me.lblTandas.Text = "Actualizar Tandas y Horarios"
        '
        'btnTandas
        '
        Me.btnTandas.Location = New System.Drawing.Point(54, 276)
        Me.btnTandas.Name = "btnTandas"
        Me.btnTandas.Size = New System.Drawing.Size(75, 41)
        Me.btnTandas.TabIndex = 1
        Me.btnTandas.Text = "Actualizar"
        Me.btnTandas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.Location = New System.Drawing.Point(246, 250)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(140, 13)
        Me.lblConsulta.TabIndex = 2
        Me.lblConsulta.Text = "Consultar Tandas y Horarios"
        '
        'btnRevisar
        '
        Me.btnRevisar.Location = New System.Drawing.Point(484, 276)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(75, 41)
        Me.btnRevisar.TabIndex = 5
        Me.btnRevisar.Text = "Asientos Disponibles"
        Me.btnRevisar.UseVisualStyleBackColor = True
        '
        'lblAsientos
        '
        Me.lblAsientos.AutoSize = True
        Me.lblAsientos.Location = New System.Drawing.Point(449, 250)
        Me.lblAsientos.Name = "lblAsientos"
        Me.lblAsientos.Size = New System.Drawing.Size(151, 13)
        Me.lblAsientos.TabIndex = 4
        Me.lblAsientos.Text = "Consultar Asientos Disponibles"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 199)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(227, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 199)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(433, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(177, 199)
        Me.Panel3.TabIndex = 8
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 350)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRevisar)
        Me.Controls.Add(Me.lblAsientos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblConsulta)
        Me.Controls.Add(Me.btnTandas)
        Me.Controls.Add(Me.lblTandas)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTandas As Label
    Friend WithEvents btnTandas As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblConsulta As Label
    Friend WithEvents btnRevisar As Button
    Friend WithEvents lblAsientos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
