Module NegocioTiposMaquina

    Public Function ObtenerTiposMaquina() As DataTable
        Dim gateway As New TiposMaquinaGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodosLosTipos()
    End Function

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
