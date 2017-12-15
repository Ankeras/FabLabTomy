Public Class GestionUsuarios
    Dim form1 As New NuevoUsuario
    Private dv As New DataView(NegocioUsuarios.ObtenerTodosUsuarios())
    Private Sub NuevoUsuarioButton_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioButton.Click
        Dim usuario As New NuevoUsuario
        usuario.MdiParent = Me.MdiParent
        usuario.Text = "Nuevo Usuario"
        usuario.Show()
    End Sub

    Private Sub ConsultarButton_Click(sender As Object, e As EventArgs) Handles ConsultarButton.Click
        Dim id As Integer = UsuariosDataGridView.CurrentCell.RowIndex + 1
        form1.rol = NuevoUsuario.RolAcceso.Consultar
        form1.id = id
        form1.ShowDialog()


    End Sub
    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click

    End Sub

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarTextBox.Focus()
        UsuariosDataGridView.DataSource = dv
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        dv.RowFilter = String.Format("nombre Like '%{0}%'", BuscarTextBox.Text)
        UsuariosDataGridView.DataSource = dv
        UsuariosDataGridView.Refresh()
    End Sub
End Class