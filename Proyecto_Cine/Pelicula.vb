Module Pelicula

    Private peli(2) As pelicula 'Arreglo donde se almacenaran los datos de la pelicula

    'Este metodo inserta los datos que provienen de el form peliculas al arreglo
    Public Sub Cargar(tit As String, gen As String, tanda As String, tipo As String, año As String, duracion As String, sala As Char, cont As Integer)
        peli(cont).titulo = tit
        peli(cont).genero = gen
        peli(cont).tanda = tanda
        peli(cont).tipo = tipo
        peli(cont).año = año
        peli(cont).duracion = duracion
        peli(cont).sala = sala
    End Sub
    'De aqui en adelante estan los gets de cada uno de los datos
    Public Function GetTitulo(cont As Integer)
        Return peli(cont).titulo
    End Function

    Public Function GetGenero(cont As Integer)
        Return peli(cont).genero
    End Function
    Public Function GetTanda(cont As Integer)
        Return peli(cont).tanda
    End Function

    Public Function GetTipo(cont As Integer)
        Return peli(cont).tipo
    End Function

    Public Function GetAño(cont As Integer)
        Return peli(cont).año
    End Function

    Public Function GetDuracion(cont As Integer)
        Return peli(cont).duracion
    End Function

    Public Function GetSala(cont As Integer)
        Return peli(cont).sala
    End Function

    Structure pelicula 'Esta estructura contiene cada uno de los datos de una pelicula
        Dim titulo, genero, tanda, tipo, año, duracion As String
        Dim sala As Char
    End Structure
End Module
