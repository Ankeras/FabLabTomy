Public Class GestionUsuarios
    ''' <summary>
    ''' Método que maneja el click del botón Nuevo Usuario por el cual se abrirá un nuevo formulario de la clase NuevoUsuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NuevoUsuarioButton_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioButton.Click
        Dim usuario As New NuevoUsuario
        usuario.MdiParent = Me.MdiParent
        usuario.Show()
    End Sub

    ''' <summary>
    ''' Método que maneja el click del botón Consultar por el cual se abrirá un nuevo formulario de la clase NuevoUsuario con el rol de acceso Consultar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ConsultarButton_Click(sender As Object, e As EventArgs) Handles ConsultarButton.Click
        Dim form1 As New NuevoUsuario
        Dim id As Integer = CInt(UsuariosDataGridView.Rows(UsuariosDataGridView.SelectedCells.Item(0).RowIndex).Cells.Item("id").Value)
        form1.rol = NuevoUsuario.RolAcceso.Consultar
        form1.id = id
        form1.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que maneja el click del botón Editar por el cual se abrirá un nuevo formulario de la clase NuevoUsuario con el rol de acceso Editar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click
        Dim form1 As New NuevoUsuario
        Dim id As Integer = CInt(UsuariosDataGridView.Rows(UsuariosDataGridView.SelectedCells.Item(0).RowIndex).Cells.Item("id").Value)
        form1.rol = NuevoUsuario.RolAcceso.Editar
        form1.id = id
        form1.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que maneja la carga del formulario y asigna al DataGridView los datos obtenidos del Método ObtenerTodosUsuarios()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataView As New DataView(NegocioUsuarios.ObtenerTodosUsuarios())
        UsuariosDataGridView.DataSource = dataView
        BuscarTextBox.Focus()
    End Sub

    ''' <summary>
    ''' Método que maneja el click sobre el botón Eliminar y llamrá al método BorrarUsuario y le pasará el id del elemento seleccionado del DataGridView,
    ''' después hará un Refresh() del DataGridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        If MessageBox.Show("¿Eliminar el usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim id As Integer = CInt(UsuariosDataGridView.Rows(UsuariosDataGridView.SelectedCells.Item(0).RowIndex).Cells.Item("id").Value)
            BorrarUsuarioId(id)
            MessageBox.Show("Usuario eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim padre As Principal = CType(Me.MdiParent, Principal)
            Dim valor As Integer = CInt(padre.ValorUsuariosToolStripStatusLabel1.Text) - 1
            padre.ValorUsuariosToolStripStatusLabel1.Text = CStr(valor)
        End If
        UsuariosDataGridView.Refresh()

    End Sub

    ''' <summary>
    ''' Método que maneja el click del botón Buscar por el cual filtrará el DataGridView por la columna nombre con lo escrito en el TextBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        Dim dataView As New DataView(NegocioUsuarios.ObtenerTodosUsuarios())
        dataView.RowFilter = String.Format("nombre Like '%{0}%'", BuscarTextBox.Text)
        UsuariosDataGridView.DataSource = dataView
        UsuariosDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' En el TextBox buscar solo se podrán introducir letras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BuscarTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BuscarTextBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
End Class