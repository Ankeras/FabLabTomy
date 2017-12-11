Public Class NuevaMaquina
    Private Sub NuevaMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarComboBox()
    End Sub

    ''' <summary>
    ''' Método para cargar el ComboBox con los tipos de máquinas
    ''' </summary>
    Private Sub RellenarComboBox()
        TipoMaquinaComboBox.DataSource = ObtenerTiposMaquina()
        TipoMaquinaComboBox.DisplayMember = "tipo"
        TipoMaquinaComboBox.ValueMember = "id"
    End Sub

    ''' <summary>
    ''' Al pulsar el botón Cancelar se cerrará el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub AnadirTipoButton_Click(sender As Object, e As EventArgs) Handles AnadirTipoButton.Click
        Dim respuesta As String = InputBox("Escribe el nuevo tipo")
        'Preguntar inputBox
        If respuesta = "" Or respuesta Is Nothing Then
            MessageBox.Show("El tipo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            InsertarTipo(respuesta)
        End If


    End Sub
End Class