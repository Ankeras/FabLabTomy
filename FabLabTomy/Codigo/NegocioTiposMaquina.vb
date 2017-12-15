Module NegocioTiposMaquina
    ''' <summary>
    ''' Método para acceder al gateway de TiposMaquina y obtener todos los registros
    ''' </summary>
    ''' <returns>Devuelve una tabla con todos los registros</returns>
    Public Function ObtenerTiposMaquina() As DataTable
        'Conexión con el gateway
        Dim gateway As New TiposMaquinaGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodosLosTipos()
    End Function

    ''' <summary>
    ''' Método para acceder al gateway de TiposMaquina e insertar un nuevo tipo
    ''' </summary>
    ''' <param name="nuevoTipo">tipo que queremos insertar</param>
    ''' <returns>Devuelve el número de filas afectadas</returns>
    Public Function InsertarTipo(nuevoTipo As String) As Integer
        Dim gateway As New TiposMaquinaGateway(My.Settings.cadena)
        Dim respuesta As Integer

        Try
            respuesta = gateway.Insertar(nuevoTipo)
        Catch ex As Exception
            respuesta = -1
        End Try

        Return respuesta
    End Function
End Module
