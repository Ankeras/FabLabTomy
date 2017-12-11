Module NegocioMaquinas
    Public Function ObtenerTodasMaquinas() As DataTable
        Dim gateway As New MaquinasGateway(My.Settings.cadena)
        Return gateway.SeleccionarTodasLasMaquinas()
    End Function

End Module
