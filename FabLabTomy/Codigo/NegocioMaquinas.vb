Module NegocioMaquinas

    Public Function ObtenerTodasMaquinas() As DataTable
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.SeleccionarTodasLasMaquinas()
    End Function

    Public Function BorrarMaquinaId(id As Integer) As Integer
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.Eliminar(id)
    End Function

    Public Function ObtenerMaquinaPorId(id As Integer) As DataTable
        Dim gateway As New MaquinasGateway(My.Settings.cadena)

        Return gateway.SeleccionarMaquinaPorId(id)
    End Function
End Module
