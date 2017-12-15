Module NegocioTipoUsuario
    Public Function ObtenerTiposUsuario() As DataTable
        Dim gateway As New TiposUsuariosGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodosLosTipos()
    End Function
End Module
