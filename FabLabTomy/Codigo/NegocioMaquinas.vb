Module NegocioMaquinas

    Public Function ObtenerTodasMaquinas() As DataTable
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodasLasMaquinas()
    End Function

    Public Function InsertarMaquina(modelo As String, precioHora As Decimal, fechaCompra As DateTime,
                             telefonoSAT As String, tipo As Integer, descripcion As String,
                             caracteristicas As String) As Integer

        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.Insertar(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)

    End Function

    Public Function ActualizarMaquina(modelo As String, precioHora As Decimal, fechaCompra As DateTime,
                             telefonoSAT As String, tipo As Integer, descripcion As String,
                             caracteristicas As String, id As Integer) As Integer

        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.Actualizar(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas, id)

    End Function

    Public Function BorrarMaquinaId(id As Integer) As Integer
        Dim gateway As New MaquinasGateway(My.Settings.cadena)
        Dim respuesta As Integer
        Try
            respuesta = gateway.Eliminar(id)
        Catch ex As Exception
            respuesta = -1
        End Try

        Return respuesta
    End Function

    Public Function ObtenerMaquinaPorId(id As Integer) As DataTable
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.SeleccionarMaquinaPorId(id)
    End Function

    Public Function ObtenerMaquinasPorModelo(modelo As String) As DataTable
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.SeleccionarPorModelo(modelo)
    End Function
End Module
