Public Class NuevoTipoMaquina
    'Atributo de la clase que nos permitirá saber qué formulario ha creado el formulario actual
    Friend from As NuevaMaquina

    ''' <summary>
    ''' Método que maneja el click en el botón aceptar el cual llamará al método InsertarTipo de la clase NegocioTiposMaquina,
    ''' después de insertar el tipo se refrescará el ComboBox del formumlario que tenemos guardado en la variable from
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        If InsertarTipo(RespuestaTextBox.Text) = -1 Then
            MessageBox.Show("No se ha podido agregar el tipo de máquina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Tipo de máquina añadido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            from.RellenarComboBox()
        End If

        Me.Close()
    End Sub

    ''' <summary>
    ''' Al pulsar el botón Cancelar se cerrará el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
End Class