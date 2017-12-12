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
        If rol = 1 Or rol = 2 Then
            Dim resultado As DataTable = NegocioUsuarios.ObtenerUsuarioId(id)

            For Each row As DataRow In resultado.Rows

                NombreTextBox.Text = CStr(row("nombre"))
                ApellidoTextBox.Text = CStr(row("apellidos"))
                FechaDateTimePicker.Value = CDate(row("fecha_nacimiento"))
                If row.IsNull("organizacion") Then
                    OrganizacionTextBox.Text = " "
                Else
                    OrganizacionTextBox.Text = CStr(row("organizacion"))
                End If

                If row.IsNull("direccion") Then
                    DireccionPostalTextBox.Text = " "
                Else
                    DireccionPostalTextBox.Text = CStr(row("direccion"))
                End If

                If row.IsNull("telefono") Then
                    TelefonoTextBox.Text = " "
                Else
                    TelefonoTextBox.Text = CStr(row("telefono"))
                End If

                If row.IsNull("email") Then
                    EmailTextBox.Text = " "
                Else
                    EmailTextBox.Text = CStr(row("email"))
                End If

                If rol = 1 Then
                    PanelSuperiorTableLayoutPanel.Enabled = False
                    PanelInferiorTableLayoutPanel.Enabled = False
                End If


            Next
        End If
    End Sub
End Class