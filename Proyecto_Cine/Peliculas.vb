﻿
Imports System.ComponentModel

Public Class Peliculas
    Dim ruta As Image
    Dim cont As Integer
    Dim peli As New Inicio
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Evento por el cual si ingresan los datos 

        Dim titulo, genero, tanda, tipo, año, duracion As String
        Dim sala As Char
        If (cont = 2) Then 'Una vez ingresado los datos se deshabilita el boton 
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
        cont = cont + 1

        Call Limpiar()

    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Inicio.Show()
        Close() 'Cuando se habilite el boton este evento cerrara el form actual 

    End Sub

    Private Sub Peliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            ruta = Image.FromFile(file.FileName)
        End If
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

    'Validaciónes de todos los campos
    Private Sub txtTitulo_Validating(sender As Object, e As CancelEventArgs) Handles txtTitulo.Validating
        If txtTitulo.Text = "" Then
            MsgBox("Error Ingresar Titulo", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtAño_Validating(sender As Object, e As CancelEventArgs) Handles txtAño.Validating
        If txtAño.Text > 1990 Or txtAño.Text < 2019 Then
            MsgBox("Año Invalido", MsgBoxStyle.Critical)
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
        If cmbTipo.Text = " " Then
            MsgBox("Seleccione un tipo", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtDuracion_Validating(sender As Object, e As CancelEventArgs) Handles txtDuracion.Validating
        If txtDuracion.Text > 0 Or txtDuracion.Text < 200 Then
            MsgBox("Año Invalido", MsgBoxStyle.Critical)
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

    End Sub
End Class