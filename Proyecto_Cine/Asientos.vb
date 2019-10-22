Public Class Asientos
    Private Sub Asientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAsientos.Text = DatosCompras.GetAsientos
    End Sub
End Class