Module Facturas
    Private n1, n2, n3, n4, ad1, ad2, ad3, ad4, acum1, acum2, acum3, acum4, rec, norec, cort, totnin, totadul As Integer

    'Sets de los Datos de Compra
    Public Sub SetAcumNiñosS1(n As Integer)
        n1 = n
    End Sub
    Public Sub SetAcumNiñosS2(f As Integer)
        n2 = f
    End Sub
    Public Sub SetAcumNiñosS3(n As Integer)
        n3 = n
    End Sub
    Public Sub SetAcumNiñosS4(a As Integer)
        n4 = a
    End Sub
    Public Sub SetAcumAdultosS1(s As Integer)
        ad1 = s
    End Sub
    Public Sub SetAcumAdultosS2(b As Integer)
        ad2 = b
    End Sub
    Public Sub SetAcumAdultosS3(b As Integer)
        ad3 = b
    End Sub
    Public Sub SetAcumAdultosS4(ind As Integer)
        ad4 = ind
    End Sub
    Public Sub SetAcumTotalS1(ind As Integer)
        acum1 = ind
    End Sub
    Public Sub SetAcumTotalS2(ind As Integer)
        acum2 = ind
    End Sub
    Public Sub SetAcumTotalS3(ind As Integer)
        acum3 = ind
    End Sub
    Public Sub SetAcumTotalS4(ind As Integer)
        acum4 = ind
    End Sub
    Public Sub SetTotalRecaudado(ind As Integer)
        rec = ind
    End Sub
    Public Sub SetTotalNoRecaudado(ind As Integer)
        norec = ind
    End Sub
    Public Sub SetTotalCortesia(ind As Integer)
        cort = ind
    End Sub
    Public Sub SetTotalAdultos(ind As Integer)
        totadul = ind
    End Sub
    Public Sub SetTotalNiños(ind As Integer)
        totnin = ind
    End Sub


End Module
