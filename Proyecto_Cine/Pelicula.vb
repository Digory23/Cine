Module Pelicula

    Private peli(2) As pelicula 'Arreglo donde se almacenaran los datos de la pelicula


    Public Sub Cargar(tit As String, gen As String, tanda As String, tipo As String, año As String, duracion As String, sala As Char, cont As Integer)
        peli(cont).titulo = tit
        peli(cont).genero = gen
        peli(cont).tanda = tanda
        peli(cont).tipo = tipo
        peli(cont).año = año
        peli(cont).duracion = duracion
        peli(cont).sala = sala
    End Sub

    Public Function GetTitulo(cont As Integer)
        Return peli(cont).titulo
    End Function

    Structure pelicula
        Dim titulo, genero, tanda, tipo, año, duracion As String
        Dim sala As Char
    End Structure
End Module
