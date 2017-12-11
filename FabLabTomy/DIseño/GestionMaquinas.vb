Public Class GestionMaquinas
    Dim form1 As New NuevaMaquina
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
        MaquinaDataGridView.DataSource = NegocioMaquinas.ObtenerTodasMaquinas
    End Sub


End Class