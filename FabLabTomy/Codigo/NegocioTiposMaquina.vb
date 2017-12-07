Module NegocioTiposMaquina

    Public Function ObtenerTiposMaquina() As DataTable
        Dim gateway As New TiposMaquinaGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodosLosTipos()
    End Function
    'prueba

End Module
