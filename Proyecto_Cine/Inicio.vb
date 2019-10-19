Public Class Inicio 'En este formulario se muestra el menu principal

    Dim titulo(2) As String 'Arreglos donde se almacenaran los datos de la pelicula
    Dim genero(2) As String
    Dim tanda(2) As String
    Dim tipo(2) As String
    Dim año(2) As String
    Dim duracion(2) As String
    Dim sala(2) As Char
    Private Sub btnTandas_Click(sender As Object, e As EventArgs) Handles btnTandas.Click
        Peliculas.Show()
        Hide()
        btnTandas.Enabled = False
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Cartelera.Show()
        Hide()
    End Sub
End Class