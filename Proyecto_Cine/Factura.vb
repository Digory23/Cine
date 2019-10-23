Public Class Factura

    Dim total, monPagar, monPagado, monDevuelto, descuentoT As Single
    Dim valNinos, valAdultos, valTotal As Decimal
    Dim boletoCortesia As Integer = 4
    Dim numCortesia As Integer
    Dim boletoNino, boletoAdulto As Integer

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
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
        dia = DatosCompras.GetFecha
        txtAdultos.Text = DatosCompras.GetAdultos
        txtNinos.Text = DatosCompras.GetNiños
        txtSala.Text = Pelicula.GetSala(DatosCompras.GetIndice)
        txtAsientos.Text = DatosCompras.GetAsientos
        cortesia = DatosCompras.GetCortesia()
        tipoPeli = DatosCompras.GetTipoPelicula()
        boletoNino = CInt(txtNinos.Text.ToString)
        boletoAdulto = CInt(txtAdultos.Text.ToString)

        If txtSala.Text = 3 Then
            valNinos = Cliente.numNinos.Value * 5.0
            valAdultos = Cliente.numAdultos.Value * 8.0
        Else
            valNinos = Cliente.numNinos.Value * 2.0
            valAdultos = Cliente.numAdultos.Value * 4.0
        End If

        valTotal = valNinos + valAdultos
        total = CSng(valTotal)


        If dia.DayOfWeek = DayOfWeek.Wednesday Then
            monPagar = total - (total * 0.15)
            descuentoT = total - monPagar
            numCortesia = 0
        ElseIf cortesia = True And tipoPeli.Equals("R") Then
            monPagar = total - boletoCortesia
            numCortesia = 1
        ElseIf cortesia = True And tipoPeli.Equals("R") And txtSala.Text <> 3 Then
            monPagar = total - boletoCortesia
            descuentoT = total - monPagar
            lblMensCortesia.Visible = True
            lblMensCortesia.Text = "Usted ha adquirido un boleto de cortesía."
        Else
            monPagar = total
        End If

        Select Case txtSala.Text
            Case 1
                ReporteTotales.AcumS1(boletoNino, boletoAdulto, total)
                ReporteTotales.Total_Final(numCortesia)
            Case 2
                ReporteTotales.AcumS2(boletoNino, boletoAdulto, total)
                ReporteTotales.Total_Final(numCortesia)
            Case 3
                ReporteTotales.AcumS3(boletoNino, boletoAdulto, total)
                ReporteTotales.Total_Final(numCortesia)
            Case 4
                ReporteTotales.AcumS4(boletoNino, boletoAdulto, total)
                ReporteTotales.Total_Final(numCortesia)
        End Select

        'ReporteTotales.Total_Final(numCortesia)
        fechaPeli.Text = dia.ToString()
        monDevuelto = total - monPagar

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
        'monDevuelto = monPagado - total

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