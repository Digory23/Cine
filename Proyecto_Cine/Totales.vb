Public Class Totales
    'Asignando acumuladores a los textboxs
    Private Sub Totales_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtS1TotalNiños.Text = ReporteTotales.GetAcumNiñosS1()
        txtS2TotalNiños.Text = ReporteTotales.GetAcumNiñosS2()
        txtS3TotalNiños.Text = ReporteTotales.GetAcumNiñosS3()
        txtS4TotalNiños.Text = ReporteTotales.GetAcumNiñosS4()
        txtS1TotalAdultos.Text = ReporteTotales.GetAcumAdultosS1()
        txtS2TotalAdultos.Text = ReporteTotales.GetAcumAdultosS2()
        txtS3TotalAdultos.Text = ReporteTotales.GetAcumAdultosS3()
        txtS4TotalAdultos.Text = ReporteTotales.GetAcumAdultosS4()
        txtS1TotalRecaudado.Text = ReporteTotales.GetAcumTotalS1()
        txtS2TotalRecaudado.Text = ReporteTotales.GetAcumTotalS2()
        txtS3TotalRecaudado.Text = ReporteTotales.GetAcumTotalS3()
        txtS4TotalRecaudado.Text = ReporteTotales.GetAcumTotalS4()
        txtRecaudado.Text = ReporteTotales.GetTotalRecaudado()
        txtNoRecaudado.Text = ReporteTotales.GetTotalNoRecaudado()
        txtClientesCortesia.Text = ReporteTotales.GetTotalCortesia()
        txtTotalA.Text = ReporteTotales.GetTotalAdultos()
        txtTotalN.Text = ReporteTotales.GetTotalNiños()

    End Sub
End Class