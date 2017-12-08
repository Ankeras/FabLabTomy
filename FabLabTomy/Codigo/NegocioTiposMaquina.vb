Module NegocioTiposMaquina

    Public Function ObtenerTiposMaquina() As DataTable
        Dim gateway As New TiposMaquinaGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodosLosTipos()
    End Function

    Public Function InsertarTipo(nuevoTipo As String) As Integer
        Dim gateway As New TiposMaquinaGateway(My.Settings.cadena)

        Return gateway.Insertar(nuevoTipo)
    End Function
End Module
