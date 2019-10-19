Public Class Inicio 'En este formulario se muestra el menu principal

    Dim peli(2) As pelicula 'Arreglo donde se almacenaran los datos de la pelicula


    Public Sub Cargar(tit As String, gen As String, tanda As String, tipo As String, año As String, duracion As String, sala As Char, cont As Integer)
        peli(cont).titulo = tit
        peli(cont).genero = gen
        peli(cont).tanda = tanda
        peli(cont).tipo = tipo
        peli(cont).año = año
        peli(cont).duracion = duracion
        peli(cont).sala = sala
    End Sub



    Private Sub btnTandas_Click(sender As Object, e As EventArgs) Handles btnTandas.Click
        Peliculas.Show()

        btnTandas.Enabled = False
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        MsgBox(peli(1).titulo)

        Hide()
    End Sub

    Private Sub BtnRevisar_Click(sender As Object, e As EventArgs) Handles btnRevisar.Click

    End Sub

    Structure pelicula
        Dim titulo, genero, tanda, tipo, año, duracion As String
        Dim sala As Char
    End Structure
End Class