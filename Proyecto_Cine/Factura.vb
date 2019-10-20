Public Class Factura

    Dim total, monPagar, monPagado, monDevuelto, descuentoT As Single
    Dim valNinos, valAdultos, valTotal As Decimal
    Dim cortesia As Boolean
    Dim tipoPeli As String
    Public Function CargarFactura(pago As Single)
        txtNomCliente.Text = DatosCompras.GetNombre
        txtNomPeli.Text = Pelicula.GetTitulo(DatosCompras.GetIndice)
        fechaPeli.Text = DatosCompras.GetFecha
        txtAdultos.Text = DatosCompras.GetAdultos
        txtNinos.Text = DatosCompras.GetNiños
        txtSala.Text = Pelicula.GetSala(DatosCompras.GetIndice)
        txtAsientos.Text = DatosCompras.GetAsientos
        cortesia = DatosCompras.GetCortesia()
        tipoPeli = DatosCompras.GetTipoPelicula()

        If txtSala.Text = 2 Then
            valNinos = Cliente.numNinos.Value * 5.0
            valAdultos = Cliente.numAdultos.Value * 8.0
        Else
            valNinos = Cliente.numNinos.Value * 2.0
            valAdultos = Cliente.numAdultos.Value * 4.0
        End If

        valTotal = valNinos + valAdultos
        total = CSng(valTotal)


        If fechaPeli.Equals(DayOfWeek.Wednesday) Then
            monPagar = total - (total * 0.15)
            descuentoT = total - monPagar
        ElseIf cortesia = True And tipoPeli.Equals("R") Then
            monPagar = total - CSng(valAdultos)
            lblMensCortesia.Visible = True
            lblMensCortesia.Text = "Usted ha adquirido un boleto de cortesía."
        Else
            monPagar = total
        End If



        monPagado = pago
        monDevuelto = monPagado - total

        txtTotal.Text = total
        txtDescPeli.Text = descuentoT
        txtMPagar.Text = monPagar
        txtMPagado.Text = monPagado
        txtMDevuelto.Text = monDevuelto

    End Function
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pago As Single
        Dim validar As Boolean

        While validar = False
            pago = InputBox("Su total es de:" & monPagar & vbCrLf & "Ingrese la cantidad que utilizará para pagar: ")
            If IsNumeric(pago) Then
                validar = True
            Else
                validar = False
                MsgBox("El valor ingresado debe ser numérico")
            End If
        End While

        fechaHoy.Text = DateTime.Now
        Call CargarFactura(pago)
    End Sub

End Class