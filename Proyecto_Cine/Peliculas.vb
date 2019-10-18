Public Class Peliculas
    Dim titulo(2) As String
    Dim genero(2) As String
    Dim tanda(2) As String
    Dim tipo(2) As String
    Dim año(2) As String
    Dim duracion(2) As String
    Dim sala(2) As Integer
    Dim cont As Integer
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If (cont = 2) Then
            btnIngresar.Enabled = False
            btnConfirmar.Enabled = True
        End If

        titulo(cont) = txtTitulo.Text
        año(cont) = txtAño.Text
        genero(cont) = cmbGenero.Text
        tanda(cont) = cmbTanda.Text
        tipo(cont) = cmbTipo.Text
        duracion(cont) = txtDuracion.Text
        sala(cont) = cmbSala.Text

        cont = cont + 1

    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Inicio.Show()
    End Sub
End Class