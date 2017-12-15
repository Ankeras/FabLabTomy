Public Class NuevoTipoMaquina
    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        If InsertarTipo(RespuestaTextBox.Text) = -1 Then
            MessageBox.Show("No se ha podido agregar el tipo de máquina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Tipo de máquina añadido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Close()
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub NuevoTipoMaquina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Dim padre As NuevaMaquina = CType(Me.ParentForm, NuevaMaquina)
        'padre.RellenarComboBox()
    End Sub
End Class