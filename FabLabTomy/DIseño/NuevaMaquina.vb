Public Class NuevaMaquina
    Public id As Integer
    Public Enum RolAcceso As Integer

        Consultar = 1
        Editar = 2
    End Enum
    Public rol As RolAcceso
    Private Sub NuevaMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rol = 1 Then
            'Dim resultado As DataTable = NegocioMaquinas.(id) ' Completar
            '  For Each row As DataRow In resultado.Rows
            'ModeloTextBox.Text = CStr(row("modelo"))
            ' Next

        End If
        RellenarComboBox()
    End Sub

    ''' <summary>
    ''' Método para cargar el ComboBox con los tipos de máquinas
    ''' </summary>
    Friend Sub RellenarComboBox()
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
        Dim dialogo As New NuevoTipoMaquina
        dialogo.MdiParent = Me.MdiParent
        dialogo.Show()


    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        InsertarMaquina(ModeloTextBox.Text, CType(PrecioHoraTextBox.Text, Decimal), FechaCompraDateTimePicker.Value, TelefonoSATTextBox.Text, CInt(TipoMaquinaComboBox.SelectedValue), DescripcionTextBox.Text, CaracteristicasTextBox.Text)

        MessageBox.Show("Usuario añadido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub NuevaMaquina_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        RellenarComboBox()
    End Sub
End Class