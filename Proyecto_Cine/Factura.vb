Public Class Factura

    Dim total, monPagar, monPagado, monDevuelto, descuentoT As Single
    Dim valNinos, valAdultos, valTotal As Decimal
    Dim boletoCortesia As Integer = 4

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        total = 0
        monPagar = 0
        monPagado = 0
        monDevuelto = 0
        descuentoT = 0
        valNinos = 0
        valAdultos = 0
        valTotal = 0
        Me.Close()
        Cartelera.Close()
        Inicio.Show()
    End Sub

    Dim cortesia As Boolean
    Dim tipoPeli As String
    Dim dia As Date
    Public Function CargarFactura()
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

        If Cliente.dtpFecha.Value.Day = "Wednesday" Or Cliente.dtpFecha.Value.Day = "Miércoles" Then
            monPagar = total - (total * 0.15)
            descuentoT = total - monPagar
        ElseIf cortesia = True And tipoPeli.Equals("R") Then
            monPagar = total - boletoCortesia
            lblMensCortesia.Visible = True
            lblMensCortesia.Text = "Usted ha adquirido un boleto de cortesía."
        Else
            monPagar = total
        End If


        'Cargar Totales 
        If txtSala.Text = 1 Then

        End If


        'monPagado = pago
        'monDevuelto = monPagado - total

        'txtTotal.Text = total
        'txtDescPeli.Text = descuentoT
        'txtMPagar.Text = monPagar
        'txtMPagado.Text = monPagado
        'txtMDevuelto.Text = monDevuelto
        Return monPagar
    End Function

    Sub Asignar(pago As Single)
        monPagado = pago
        monDevuelto = monPagado - total

        txtTotal.Text = total
        txtDescPeli.Text = descuentoT
        txtMPagar.Text = monPagar
        txtMPagado.Text = monPagado
        txtMDevuelto.Text = monDevuelto
    End Sub

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pago As Single
        Dim validar As Boolean


        While validar = False
            pago = InputBox("Su total es de:" & CargarFactura() & vbCrLf & "Ingrese la cantidad que utilizará para pagar: ")
            If IsNumeric(pago) Then
                validar = True
            Else
                validar = False
                MsgBox("El valor ingresado debe ser numérico")
            End If
        End While

        fechaHoy.Text = DateTime.Now
        Asignar(pago)
        'Call CargarFactura(pago)
    End Sub

End Class