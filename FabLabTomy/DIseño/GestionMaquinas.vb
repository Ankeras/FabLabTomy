Public Class GestionMaquinas
    Private Sub ConsultarButton_Click(sender As Object, e As EventArgs) Handles ConsultarButton.Click

        DatosDataGridView.DataSource = NegocioMaquinas.ObtenerTodasMaquinas
    End Sub
End Class