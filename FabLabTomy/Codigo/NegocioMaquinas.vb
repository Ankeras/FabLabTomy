Module NegocioMaquinas
    Dim gateway As New MaquinasGateway(My.Settings.cadena)
    Public Function ObtenerTodasMaquinas() As DataTable

        Return gateway.SeleccionarTodasLasMaquinas()
    End Function
    Public Function BorrarMaquinaId(id As Integer) As Integer

        Return gateway.Eliminar(id)
    End Function
End Module
