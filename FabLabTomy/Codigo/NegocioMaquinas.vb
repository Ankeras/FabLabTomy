Module NegocioMaquinas

    ''' <summary>
    ''' Método para acceder al gateway de Maquinas y obtener todos los registros
    ''' </summary>
    ''' <returns>Devuelve todos los registros de la tabla Maquinas</returns>
    Public Function ObtenerTodasMaquinas() As DataTable
        'Conexión al gateway
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodasLasMaquinas()
    End Function

    ''' <summary>
    ''' Método para acceder al gateway de Maquinas para insertar un registro en la tabla
    ''' </summary>
    ''' <param name="modelo">modelo de la máquina</param>
    ''' <param name="precioHora">precio por hora</param>
    ''' <param name="fechaCompra">fecha de la compra</param>
    ''' <param name="telefonoSAT">teléfono de asistencia</param>
    ''' <param name="tipo">tipo de la máquina</param>
    ''' <param name="descripcion">descripción de la máquina</param>
    ''' <param name="caracteristicas">características técnicas</param>
    ''' <returns>Devuelve el número de filas afectadas</returns>
    Public Function InsertarMaquina(modelo As String, precioHora As Decimal, fechaCompra As DateTime,
                             telefonoSAT As String, tipo As Integer, descripcion As String,
                             caracteristicas As String) As Integer
        'Conexión al gateway
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.Insertar(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)

    End Function

    ''' <summary>
    ''' Método que accede al gateway de Maquinas para actualizar un registro
    ''' </summary>
    ''' <param name="modelo">modelo de la máquina</param>
    ''' <param name="precioHora">precio por hora</param>
    ''' <param name="fechaCompra">fecha de la compra</param>
    ''' <param name="telefonoSAT">teléfono de asistencia</param>
    ''' <param name="tipo">tipo de la máquina</param>
    ''' <param name="descripcion">descripción de la máquina</param>
    ''' <param name="caracteristicas">características técnicas</param>
    ''' <param name="id">id de la máquina a actualizar</param>
    ''' <returns>Devuelve el número de filas afectadas</returns>
    Public Function ActualizarMaquina(modelo As String, precioHora As Decimal, fechaCompra As DateTime,
                             telefonoSAT As String, tipo As Integer, descripcion As String,
                             caracteristicas As String, id As Integer) As Integer
        'Conexión al gateway
        Dim gateway As New MaquinasGateway(My.Settings.cadena)
        'Variable que devolveremos
        Dim respuesta As Integer

        Try
            respuesta = gateway.Eliminar(id)
        Catch ex As Exception
            respuesta = -1
        End Try

        Return respuesta
    End Function

    ''' <summary>
    ''' Función que accede al gateway de Maquinas para borrar un registro de la tabla
    ''' </summary>
    ''' <param name="id">id de la máquina a borrar</param>
    ''' <returns>Devuelve el número de filas afectadas, si devuelve -1 significa que no se ha podido ejecutar la consulta</returns>
    Public Function BorrarMaquinaId(id As Integer) As Integer

        'Conexión al gateway
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        'Variable que devolveremos
        Dim respuesta As Integer

        Try
            respuesta = gateway.Eliminar(id)
        Catch ex As Exception
            respuesta = -1
        End Try

        Return respuesta
    End Function

    ''' <summary>
    ''' Método para obtener un registro de la tabla Maquinas por su id
    ''' </summary>
    ''' <param name="id">id de la máquina</param>
    ''' <returns>Devuelve el registro obtenido</returns>
    Public Function ObtenerMaquinaPorId(id As Integer) As DataTable
        'Conexión al gateway
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.SeleccionarMaquinaPorId(id)
    End Function
End Module
