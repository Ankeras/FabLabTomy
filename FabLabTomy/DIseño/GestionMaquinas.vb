Public Class GestionMaquinas
    Dim form1 As New NuevaMaquina
    Private dv As New DataView(NegocioMaquinas.ObtenerTodasMaquinas())
    Private Sub ConsultarButton_Click(sender As Object, e As EventArgs) Handles ConsultarButton.Click

        Dim id As Integer = MaquinaDataGridView.CurrentCell.RowIndex + 1
        form1.rol = NuevaMaquina.RolAcceso.Consultar
        form1.id = id
        form1.ShowDialog()
    End Sub
    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click
        Dim id As Integer = MaquinaDataGridView.CurrentCell.RowIndex + 1
        form1.rol = NuevaMaquina.RolAcceso.Editar
        form1.id = id
        form1.ShowDialog()
    End Sub

    Private Sub NuevaMaquinaButton_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaButton.Click
        form1.ShowDialog()
    End Sub
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MaquinaDataGridView.DataSource = dv
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        Dim result As Integer = MessageBox.Show("Estas a punto de borrar una maquina de la base de datos", "Cudiado!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim id As Integer = MaquinaDataGridView.CurrentCell.RowIndex + 1
            NegocioMaquinas.BorrarMaquinaId(id)
        End If
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        dv.RowFilter = String.Format("modelo Like '%{0}%'", BuscarTextBox.Text)
        MaquinaDataGridView.DataSource = dv
        MaquinaDataGridView.Refresh()
    End Sub
End Class