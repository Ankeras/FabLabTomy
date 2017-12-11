Module NegocioUsuarios
    Dim gateway As New UsuariosGateway(My.Settings.cadena)
    Public Function ObtenerTodosUsuarios() As DataTable


        Return gateway.SelecionarTodos()
    End Function
    Public Sub InsertarUsuario(nombre As String, apellido As String, fecha As DateTime, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer, observaciones As String)
        gateway.Insertar(nombre, apellido, fecha, telefono, email, direccion, observaciones, tipo, observaciones)
    End Sub
    Public Function ObtenerUsuarioId(id As Integer) As DataTable

        Return gateway.SeleccionarId(id)
    End Function
End Module
