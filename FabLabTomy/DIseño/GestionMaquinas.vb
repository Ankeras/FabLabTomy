﻿Public Class GestionMaquinas
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
        MaquinaDataGridView.DataSource = NegocioMaquinas.ObtenerTodasMaquinas()
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click

        If MessageBox.Show("Estas a punto de borrar una maquina de la base de datos", "Cudiado!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim id As Integer = MaquinaDataGridView.CurrentCell.RowIndex + 1

            If NegocioMaquinas.BorrarMaquinaId(id) = -1 Then
                MessageBox.Show("El registro no ha sido eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Registro eliminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        MaquinaDataGridView.DataSource = ObtenerMaquinasPorModelo(BuscarTextBox.Text)
    End Sub
End Class