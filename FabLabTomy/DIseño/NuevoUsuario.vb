Public Class NuevoUsuario
    Public id As Integer
    Public Enum RolAcceso As Integer
        Nuevo = 0
        Consultar = 1
        Editar = 2
    End Enum
    Public rol As RolAcceso


    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        NegocioUsuarios.InsertarUsuario(NombreTextBox.Text, ApellidoTextBox.Text, FechaDateTimePicker.Value, TelefonoTextBox.Text, EmailTextBox.Text, DireccionPostalTextBox.Text, OrganizacionTextBox.Text, 1, ObservacionesRichTextBox.Text)
    End Sub

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rol = 1 Then
            Dim resultado As DataTable = NegocioUsuarios.ObtenerUsuarioId(id)
            For Each row As DataRow In resultado.Rows

                NombreTextBox.Text = CStr(row("nombre"))

            Next


        End If
    End Sub
End Class