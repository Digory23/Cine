Module ReporteTotales
    Private ac1_niños, ac2_niños, ac3_niños, ac4_niños, ac1_adultos, ac2_adultos, ac3_adultos, ac4_adultos As Integer
    Private total_cortesia, total_niños, total_adultos As Integer
    Private total_Recaudado, total_noRecaudado As Single
    Private total_s1, total_s2, total_s3, total_s4 As Single
    'Acumuladores de los totales de reportes

    'Sala No.1
    Sub AcumS1(x As Integer, y As Integer, z As Single)
        ac1_niños = x + ac1_niños
        ac1_adultos = y + ac1_adultos
        total_s1 = z + total_s1
    End Sub

    'Sala No.2
    Sub AcumS2(x As Integer, y As Integer, z As Single)
        ac2_niños = x + ac2_niños
        ac2_adultos = y + ac2_adultos
        total_s2 = z + total_s2
    End Sub

    'Sala No.3
    Sub AcumS3(x As Integer, y As Integer, z As Single)
        ac3_niños = x + ac3_niños
        ac3_adultos = y + ac3_adultos
        total_s3 = z + total_s3
    End Sub

    'Sala No.4
    Sub AcumS4(x As Integer, y As Integer, z As Single)
        ac4_niños = x + ac4_niños
        ac4_adultos = y + ac4_adultos
        total_s4 = z + total_s4
    End Sub

    'Acumuladores de Todas las Salas
    Sub Total_Final(cor As Integer)
        total_cortesia = cor + total_cortesia
        total_niños = ac1_niños + ac2_niños + ac3_niños + ac4_niños
        total_adultos = ac1_adultos + ac2_adultos + ac3_adultos + ac4_adultos
        total_Recaudado = total_s1 + total_s2 + total_s3 + total_s4
        'total_noRecaudado = ?
    End Sub

    'Gets de cada acumulador

    'Sala No.1
    Function GetAcumNiñosS1()
        Return ac1_niños
    End Function
    Function GetAcumAdultosS1()
        Return ac1_adultos
    End Function
    Function GetAcumTotalS1()
        Return total_s1
    End Function

    'Sala No.2
    Function GetAcumNiñosS2()
        Return ac2_niños
    End Function
    Function GetAcumAdultosS2()
        Return ac2_adultos
    End Function
    Function GetAcumTotalS2()
        Return total_s2
    End Function

    'Sala No.3
    Function GetAcumNiñosS3()
        Return ac3_niños
    End Function
    Function GetAcumAdultosS3()
        Return ac3_adultos
    End Function
    Function GetAcumTotalS3()
        Return total_s3
    End Function

    'Sala No.4
    Function GetAcumNiñosS4()
        Return ac4_niños
    End Function
    Function GetAcumAdultosS4()
        Return ac4_adultos
    End Function
    Function GetAcumTotalS4()
        Return total_s4
    End Function

    'Retornando totales
    Function GetTotalCortesia()
        Return total_cortesia
    End Function
    Function GetTotalNiños()
        Return total_niños
    End Function
    Function GetTotalAdultos()
        Return total_adultos
    End Function
    Function GetTotalRecaudado()
        Return total_Recaudado
    End Function
    Function GetTotalNoRecaudado()
        Return total_noRecaudado
    End Function
End Module
