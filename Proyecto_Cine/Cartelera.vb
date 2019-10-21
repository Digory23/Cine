Public Class Cartelera
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Inicio.Show()
    End Sub

    'Evento que lo envia al formulario de Cliente
    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim ind As Integer
        ind = cmbPelicula.SelectedIndex 'Obtiene el indice de la pelicula seleccionada
        Cliente.Show()
        DatosCompras.SetIndice(ind)
    End Sub


    'Este evento setea los datos a los labels dependiendo de la pelicula seleccionada
    Private Sub CmbPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        Dim ind As Integer
        ind = cmbPelicula.SelectedIndex
        lblMostrarTitulo1.Text = Pelicula.GetTitulo(ind)
        lblAñoPublicacion1.Text = Pelicula.GetAño(ind)
        lblGenero1.Text = Pelicula.GetGenero(ind)
        lblTanda1.Text = Pelicula.GetTanda(ind)
        lblTipo1.Text = Pelicula.GetTipo(ind)
        lblMostrarSala1.Text = Pelicula.GetSala(ind)
        pbPeliculas.Image = Pelicula.GetRuta(ind)
    End Sub

    Private Sub Cartelera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aqui se cargan las peliculas al combo box
        cmbPelicula.Items.Add(Pelicula.GetTitulo(0))
        cmbPelicula.Items.Add(Pelicula.GetTitulo(1))
        cmbPelicula.Items.Add(Pelicula.GetTitulo(2))
        cmbPelicula.Items.Add(Pelicula.GetTitulo(3))
        cmbPelicula.SelectedIndex = 0
    End Sub
End Class