Public Class Peliculas

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

        peli.Cargar(titulo, genero, tanda, tipo, año, duracion, sala, cont)
        cont = cont + 1

    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Hide() 'Cuando se habilite el boton este evento cerrara el form actual 

    End Sub

    Private Sub Peliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class