Public Class Inicio 'En este formulario se muestra el menu principal




    Private Sub btnTandas_Click(sender As Object, e As EventArgs) Handles btnTandas.Click
        Peliculas.Show()

        btnTandas.Enabled = False
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Hide()
    End Sub

    Private Sub BtnRevisar_Click(sender As Object, e As EventArgs) Handles btnRevisar.Click

    End Sub


End Class