Public Class NuevaMaquina
    'Atributo de la clase que especificará la máquina a la que queremos acceder
    Public id As Integer
    'Enum para diferenciar con qué intención abrimos el formulario
    Public Enum RolAcceso As Integer

        Consultar = 1
        Editar = 2
    End Enum
    'Atributo que nos permitirá hacer distintas funciones con la clase
    Public rol As RolAcceso

    ''' <summary>
    ''' Al cargar el formulario filtramos con qué rol se accede, con Consultar se llamará al método AccionesConsultar(), con Editar
    ''' se llamará al método AccionesEditar y en otro caso se llamará al método AccionesNuevoUsuario()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NuevaMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case rol
            Case RolAcceso.Consultar
                AccionesConsultar()
            Case RolAcceso.Editar
                AccionesEditar()
            Case Else
                AccionesNuevoUsuario()
        End Select
    End Sub

    ''' <summary>
    ''' Método con el cual se deshabilitarán los TextBox y algunos botones, también se mostrarán los datos de la máquina que queremos consultar
    ''' </summary>
    Private Sub AccionesConsultar()
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
    End Sub

    ''' <summary>
    ''' Método con el cual se habilitan los TextBox y los botones y carga los datos de la máquina que queremos editar
    ''' </summary>
    Private Sub AccionesEditar()
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
    End Sub

    ''' <summary>
    ''' Método que habilita los TextBox y los botones y limpia el texto de los controles
    ''' </summary>
    Public Sub AccionesNuevoUsuario()
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

    ''' <summary>
    ''' Método que maneja el click de AñadirTipoMáquina y abre un formulario de la clase NuevoTipoMaquina
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AnadirTipoButton_Click(sender As Object, e As EventArgs) Handles AnadirTipoButton.Click
        Dim dialogo As New NuevoTipoMaquina
        dialogo.from = Me
        dialogo.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que maneja el click del botón Aceptar, en el caso del rol Editar llamará al método ActualizarMaquina de NegocioMaquinas, en el rol
    ''' Consultar el botón estará deshabilitado y en el rol 0 que será el de nuevo usuario llamará al método InsertarMaquina de NegocioMaquinas
    ''' y cambiará el label del StatusLabel del form principal, en cualquier rol después de su acción se cerrará el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>
    ''' En el TextBox de telefonoSAT solo se podrán escribir dígitos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TelefonoSATTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonoSATTextBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' En el TextBox de PrecioHora solo se podrán escribir dígitos y ',' o '.'
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PrecioHoraTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioHoraTextBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ","c Or e.KeyChar = "."c) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Método para cargar dinámicamente las fotos en el panel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    Private Async Function ExaminarButton_ClickAsync(sender As Object, e As EventArgs) As Task Handles ExaminarButton.Click
        Dim foto As New PictureBox()

        Dim resultDialog As DialogResult = OpenFileDialog1.ShowDialog()
        If resultDialog = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            foto.ImageLocation = path
            ImagenesFlowLayoutPanel.Controls.Add(foto)
            'Await ComputerVisionAPI(path, "usuario")
        End If
    End Function
End Class