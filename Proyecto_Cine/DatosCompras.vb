Module DatosCompras
    Private nom, fec As String
    Private ni, ad, i As Integer
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
    Public Function GetIndice()
        Return i
    End Function
End Module
