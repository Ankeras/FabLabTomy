Module NegocioTiposMaquina

    Public Function ObtenerTiposMaquina() As DataTable
        Dim gateway As New TiposMaquinaGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodosLosTipos()
    End Function

    Public Function ObtenerListaTiposMaquina(tablaTiposMaquina As DataTable) As String()
        Dim listaTipos() As String
        'Aprende a manejar array strings puto noob

    End Function

End Module
