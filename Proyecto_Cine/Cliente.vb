Imports System.ComponentModel

Public Class Cliente
    'Muestra el form con el layout de asientos para ver los disponibles
    Private Sub BtnAsientos_Click(sender As Object, e As EventArgs) Handles btnAsientos.Click
        Asientos.Show()
    End Sub

    'Carga automaticamente los datos de la pelicula selecciona en el form de Cartelera
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPelicula.Text = Pelicula.GetTitulo(DatosCompras.GetIndice)
        txtSala.Text = Pelicula.GetSala(DatosCompras.GetIndice)
    End Sub

    'Agrega los asientos seleccionados en el ListBox a un TextBox
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim asientos As String = ""
        For i As Integer = 0 To lstAsientos.SelectedItems.Count - 1

            asientos = asientos + " " + lstAsientos.SelectedItems.Item(i)

        Next
        txtAsientosSelec.Text = asientos
    End Sub

    'Limpia el TextBox y el ListBox
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAsientosSelec.Clear()

        lstAsientos.ClearSelected()
    End Sub

    'Empieza la 'facturacion': guarda los valores en variables y las pasa a DatosCompra
    Private Sub BtnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Dim nombre, fecha, asientos As String
        Dim cantNinos, cantAdultos As Integer
        Dim tipoPelicula As Char
        Dim cortesia As Boolean

        nombre = txtNomCliente.Text.ToString
        fecha = dtpFecha.Value.ToString
        asientos = txtAsientosSelec.Text.ToString
        cantNinos = CInt(numNinos.Value)
        cantAdultos = CInt(numAdultos.Value)

        If rdbEstreno.Checked = True Then
            tipoPelicula = "E"
        Else
            tipoPelicula = "R"
        End If

        If chkCortesia.Checked = True Then
            cortesia = True
        Else
            cortesia = False
        End If

        DatosCompras.SetNombre(nombre)
        DatosCompras.SetFecha(fecha)
        DatosCompras.SetNiños(cantNinos)
        DatosCompras.SetAdultos(cantAdultos)
        DatosCompras.SetAsientos(asientos)
        DatosCompras.SetCortesia(cortesia)
        DatosCompras.SetTipoPelicula(tipoPelicula)
        Factura.Show()
        Me.Close()
    End Sub

    'Validaciones de campos nombre, fecha, cantidad de ninos y adultos y los asientos seleccionados
    Private Sub txtNomCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtNomCliente.Validating
        If txtNomCliente.Text = "" Then
            MsgBox("Por favor, ingrese su nombre.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtAsientosSelec_Validating(sender As Object, e As CancelEventArgs)
        If txtAsientosSelec.Text = "" Then
            MsgBox("Por favor, seleccione al menos un asiento.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub dtpFecha_Validating(sender As Object, e As CancelEventArgs) Handles dtpFecha.Validating
        If dtpFecha.Value < Date.Today Then
            MsgBox("Por favor, seleccione desde hoy en adelante.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub numNinos_Validating(sender As Object, e As CancelEventArgs) Handles numNinos.Validating
        If numNinos.Value < 0 Then
            MsgBox("Por favor, indique una cantidad. Si no hay boletos de niños, coloque 0.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub numAdultos_Validating(sender As Object, e As CancelEventArgs) Handles numAdultos.Validating
        If numAdultos.Value < 0 Then
            MsgBox("Por favor, seleccione por al menos un boleto.", MsgBoxStyle.Critical)
        End If
    End Sub
End Class