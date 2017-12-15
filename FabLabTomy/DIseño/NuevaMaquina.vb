Public Class NuevaMaquina
    Public id As Integer
    Public Enum RolAcceso As Integer

        Consultar = 1
        Editar = 2
    End Enum
    Public rol As RolAcceso
    Private Sub NuevaMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case rol
            Case RolAcceso.Consultar
                Dim resultado As DataTable = ObtenerMaquinaPorId(id)
                Dim fila As DataRow = resultado.Rows().Item(0)
                ModeloTextBox.Text = CStr(fila("modelo"))
                ModeloTextBox.Enabled = False
                PrecioHoraTextBox.Text = CStr(fila("precio_hora"))
                PrecioHoraTextBox.Enabled = False
                FechaCompraDateTimePicker.Value = CType(fila("fecha_compra"), Date)
                FechaCompraDateTimePicker.Enabled = False
                TelefonoSATTextBox.Text = CStr(fila("telefono_sat"))
                TelefonoSATTextBox.Enabled = False
                TipoMaquinaComboBox.Text = CStr(fila("tipo"))
                TipoMaquinaComboBox.Enabled = False
                AnadirTipoButton.Enabled = False
                DescripcionTextBox.Text = CStr(fila("descripcion"))
                DescripcionTextBox.Enabled = False
                CaracteristicasTextBox.Text = CStr(fila("caracteristicas"))
                CaracteristicasTextBox.Enabled = False
                ExaminarButton.Enabled = False
            Case RolAcceso.Editar
                Dim resultado As DataTable = ObtenerMaquinaPorId(id)
                Dim fila As DataRow = resultado.Rows().Item(0)
                ModeloTextBox.Text = CStr(fila("modelo"))
                ModeloTextBox.Enabled = True
                PrecioHoraTextBox.Text = CStr(fila("precio_hora"))
                PrecioHoraTextBox.Enabled = True
                FechaCompraDateTimePicker.Value = CType(fila("fecha_compra"), Date)
                FechaCompraDateTimePicker.Enabled = True
                TelefonoSATTextBox.Text = CStr(fila("telefono_sat"))
                TelefonoSATTextBox.Enabled = True
                TipoMaquinaComboBox.Text = CStr(fila("tipo"))
                TipoMaquinaComboBox.Enabled = True
                DescripcionTextBox.Text = CStr(fila("descripcion"))
                DescripcionTextBox.Enabled = True
                CaracteristicasTextBox.Text = CStr(fila("caracteristicas"))
                CaracteristicasTextBox.Enabled = True
                AnadirTipoButton.Enabled = True
                ExaminarButton.Enabled = True
                RellenarComboBox()
            Case Else
                ModeloTextBox.Clear()
                ModeloTextBox.Enabled = True
                PrecioHoraTextBox.Clear()
                PrecioHoraTextBox.Enabled = True
                FechaCompraDateTimePicker.Value = Date.Today
                FechaCompraDateTimePicker.Enabled = True
                TelefonoSATTextBox.Clear()
                TelefonoSATTextBox.Enabled = True
                TipoMaquinaComboBox.Enabled = True
                DescripcionTextBox.Clear()
                DescripcionTextBox.Enabled = True
                CaracteristicasTextBox.Clear()
                CaracteristicasTextBox.Enabled = True
                AnadirTipoButton.Enabled = True
                ExaminarButton.Enabled = True
                RellenarComboBox()
        End Select
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
        dialogo.from = Me
        dialogo.ShowDialog()
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        Select Case rol
            Case RolAcceso.Editar
                ActualizarMaquina(ModeloTextBox.Text, CType(PrecioHoraTextBox.Text, Decimal), FechaCompraDateTimePicker.Value, TelefonoSATTextBox.Text, CInt(TipoMaquinaComboBox.SelectedValue), DescripcionTextBox.Text, CaracteristicasTextBox.Text, id)

                MessageBox.Show("Máquina actualizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 0
                InsertarMaquina(ModeloTextBox.Text, CType(PrecioHoraTextBox.Text, Decimal), FechaCompraDateTimePicker.Value, TelefonoSATTextBox.Text, CInt(TipoMaquinaComboBox.SelectedValue), DescripcionTextBox.Text, CaracteristicasTextBox.Text)

                MessageBox.Show("Máquina añadida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim padre As Principal = CType(Me.MdiParent, Principal)
                Dim valor As Integer = CInt(padre.ValorMaquinasToolStripStatusLabel.Text) + 1
                padre.ValorMaquinasToolStripStatusLabel.Text = CStr(valor)
        End Select

        Me.Close()
    End Sub
End Class