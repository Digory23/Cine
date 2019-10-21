Public Class Inicio 'En este formulario se muestra el menu principal




    Private Sub btnTandas_Click(sender As Object, e As EventArgs) Handles btnTandas.Click
        Peliculas.Show()
        Hide()
        btnTandas.Enabled = False
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Hide()
        Cartelera.Show()
        Hide()
    End Sub

    Private Sub BtnRevisar_Click(sender As Object, e As EventArgs) Handles btnRevisar.Click
        Hide()
        Asientos.Show()
    End Sub

    Private Sub BtnTotales_Click(sender As Object, e As EventArgs) Handles btnTotales.Click
        Totales.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class