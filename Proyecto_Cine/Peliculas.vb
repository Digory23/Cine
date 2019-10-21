
Imports System.ComponentModel

Public Class Peliculas
    Dim ruta As Image
    Dim cont As Integer

    Dim file As New OpenFileDialog()


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Evento por el cual si ingresan los datos 
        Dim opc As Boolean = True
        Dim titulo, genero, tanda, tipo, año, duracion As String
        Dim sala As Char
        If (cont = 3) Then 'Una vez ingresado los datos se deshabilita el boton 
            btnIngresar.Enabled = False
            btnConfirmar.Enabled = True
        End If

        titulo = txtTitulo.Text
            año = txtAño.Text
            genero = cmbGenero.Text
            tanda = cmbTanda.Text
            tipo = cmbTipo.Text
            duracion = txtDuracion.Text
            sala = cmbSala.Text


            Pelicula.Cargar(titulo, genero, tanda, tipo, año, duracion, sala, cont, ruta)
            Call validar()

            MsgBox(cont, MsgBoxStyle.Critical)
            Call Limpiar()

    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Inicio.Show()
        Close() 'Cuando se habilite el boton este evento cerrara el form actual 
        MsgBox("Los datos de las peliculas fueron ingresados con exito")
    End Sub

    Private Sub Peliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            ruta = Image.FromFile(file.FileName)
        End If
        btnIngresar.Enabled = True
    End Sub

    'Función para limpiar todos los campos 
    Public Function Limpiar()
        txtTitulo.Text = ""
        txtAño.Text = ""
        txtDuracion.Text = ""
        txtTitulo.Text = ""
        cmbGenero.Text = ""
        cmbSala.Text = ""
        cmbTanda.Text = ""
        cmbTipo.Text = ""
    End Function

    'Funcion para validar campos 
    Public Function validar()
        If txtTitulo.Text = "" Or txtAño.Text = "" Or txtDuracion.Text = "" Or txtTitulo.Text = "" Or cmbGenero.Text = "" Or cmbSala.Text = "" Or cmbTanda.Text = "" Or cmbTipo.Text = "" Then
            MsgBox("Error Ingresar Datos", MsgBoxStyle.Critical)
            If (cont > 0) Then 'Para que el contador no quede en -1
                cont = cont - 1
            End If


        ElseIf file.Filter = "" Then
            MsgBox("Seleccione una Imagen", MsgBoxStyle.Critical)
            If (cont > 0) Then
                cont = cont - 1
            End If
        Else
            cont = cont + 1

        End If



    End Function




    'Validaciónes de todos los campos
    Private Sub txtTitulo_Validating(sender As Object, e As CancelEventArgs) Handles txtTitulo.Validating
        If txtTitulo.Text = "" Then
            MsgBox("Error Ingresar Titulo", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub


    Private Sub txtAño_Validating(sender As Object, e As CancelEventArgs) Handles txtAño.Validating
        If txtAño.Text <= 1990 And txtAño.Text >= 2019 Then
            MsgBox("Error", MsgBoxStyle.Critical)
            e.Cancel = True
        End If

    End Sub

    Private Sub cmbGenero_Validating(sender As Object, e As CancelEventArgs) Handles cmbGenero.Validating
        If cmbGenero.Text = "" Then
            MsgBox("Seleccione un Genero", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbTanda_Validating(sender As Object, e As CancelEventArgs) Handles cmbTanda.Validating
        If cmbTanda.Text = "" Then
            MsgBox("Seleccione una Tanda", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbTipo_Validating(sender As Object, e As CancelEventArgs) Handles cmbTipo.Validating
        If cmbTipo.Text = "" Then
            MsgBox("Seleccione un tipo", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtDuracion_Validating(sender As Object, e As CancelEventArgs) Handles txtDuracion.Validating
        If txtDuracion.Text <= 0 Or txtDuracion.Text >= 500 Then
            MsgBox("Error", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbSala_Validating(sender As Object, e As CancelEventArgs) Handles cmbSala.Validating
        If cmbTipo.Text = "" Then
            MsgBox("Seleccione una Sala", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub btnCargar_Validating(sender As Object, e As CancelEventArgs) Handles btnCargar.Validating
        If file.Filter = "" Then
            MsgBox("Seleccione una Imagen", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAño.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("Solo se permiten números", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub txtDuracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDuracion.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MsgBox("Solo se permiten números", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub
End Class