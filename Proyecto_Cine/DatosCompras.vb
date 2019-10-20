Module DatosCompras
    Private nom, fec, asi, pelic As String
    Private ni, ad, i As Integer
    Private cort As Boolean
    'Sets de los Datos de Compra
    Public Sub SetNombre(n As String)
        nom = n
    End Sub
    Public Sub SetFecha(f As String)
        fec = f
    End Sub
    Public Sub SetNiños(n As Integer)
        ni = n
    End Sub
    Public Sub SetAdultos(a As Integer)
        ad = a
    End Sub
    Public Sub SetAsientos(asientos As String)
        asi = asientos
    End Sub
    Public Sub SetCortesia(b As Boolean)
        cort = b
    End Sub
    Public Sub SetTipoPelicula(b As String)
        pelic = b
    End Sub
    Public Sub SetIndice(ind As Integer)
        i = ind
    End Sub

    'Gets de los Datos de Compra
    Public Function GetNombre()
        Return nom
    End Function
    Public Function GetFecha()
        Return fec
    End Function
    Public Function GetNiños()
        Return ni
    End Function
    Public Function GetAdultos()
        Return ad
    End Function
    Public Function GetAsientos()
        Return asi
    End Function
    Public Function GetCortesia()
        Return cort
    End Function
    Public Function GetTipoPelicula()
        Return pelic
    End Function
    Public Function GetIndice()
        Return i
    End Function
End Module
