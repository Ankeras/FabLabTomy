Imports System.Data.SqlClient

Public Class GestionUsuarios

    Private Sub NuevoUsuarioButton_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioButton.Click
        Dim usuario As New NuevoUsuario
        usuario.MdiParent = Me.MdiParent
        usuario.Show()
    End Sub

    Private Sub ConsultarButton_Click(sender As Object, e As EventArgs) Handles ConsultarButton.Click
        Dim form1 As New NuevoUsuario
        Dim id As Integer = CInt(UsuariosDataGridView.Rows(UsuariosDataGridView.SelectedCells.Item(0).RowIndex).Cells.Item("id").Value)
        form1.rol = NuevoUsuario.RolAcceso.Consultar
        form1.id = id
        form1.ShowDialog()
    End Sub

    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click
        Dim form1 As New NuevoUsuario
        Dim id As Integer = CInt(UsuariosDataGridView.Rows(UsuariosDataGridView.SelectedCells.Item(0).RowIndex).Cells.Item("id").Value)
        form1.rol = NuevoUsuario.RolAcceso.Editar
        form1.id = id
        form1.ShowDialog()
    End Sub

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarTextBox.Focus()
        UsuariosDataGridView.DataSource = NegocioUsuarios.ObtenerTodosUsuarios()
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        If MessageBox.Show("¿Eliminar el usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim id As Integer = CInt(UsuariosDataGridView.Rows(UsuariosDataGridView.SelectedCells.Item(0).RowIndex).Cells.Item("id").Value)
            BorrarUsuarioId(id)
            MessageBox.Show("Usuario eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        UsuariosDataGridView.Refresh()

    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        'No entiendo
        'Dim bindingSource As New BindingSource(ObtenerTodosUsuarios(), "tabla")

        'UsuariosDataGridView.DataSource = bindingSource

        'BindingSource.Filter = "nombre LIKE '%" & BuscarTextBox.Text & "'%"

    End Sub
End Class