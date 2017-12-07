<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaMaquina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioHoraTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloLabel = New System.Windows.Forms.Label()
        Me.TelefonoSATLabel = New System.Windows.Forms.Label()
        Me.PrecioHoraLabel = New System.Windows.Forms.Label()
        Me.TipoMaquinaLabel = New System.Windows.Forms.Label()
        Me.FechaCompraLabel = New System.Windows.Forms.Label()
        Me.FechaCompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TipoMaquinaComboBox = New System.Windows.Forms.ComboBox()
        Me.TelefonoSATTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.CaracteristicasTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionLabel = New System.Windows.Forms.Label()
        Me.CaracteristicasLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ImagenesLabel = New System.Windows.Forms.Label()
        Me.ExaminarButton = New System.Windows.Forms.Button()
        Me.ImagenesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.AnadirTipoButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(936, 481)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.58673!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77041!))
        Me.TableLayoutPanel2.Controls.Add(Me.ModeloTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PrecioHoraTextBox, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ModeloLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TelefonoSATLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PrecioHoraLabel, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TipoMaquinaLabel, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaCompraLabel, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaCompraDateTimePicker, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TipoMaquinaComboBox, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TelefonoSATTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.AnadirTipoButton, 4, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(930, 138)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ModeloTextBox.Location = New System.Drawing.Point(142, 24)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ModeloTextBox.TabIndex = 11
        '
        'PrecioHoraTextBox
        '
        Me.PrecioHoraTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PrecioHoraTextBox.Location = New System.Drawing.Point(420, 24)
        Me.PrecioHoraTextBox.Name = "PrecioHoraTextBox"
        Me.PrecioHoraTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PrecioHoraTextBox.TabIndex = 6
        '
        'ModeloLabel
        '
        Me.ModeloLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ModeloLabel.AutoSize = True
        Me.ModeloLabel.Location = New System.Drawing.Point(3, 28)
        Me.ModeloLabel.Name = "ModeloLabel"
        Me.ModeloLabel.Size = New System.Drawing.Size(42, 13)
        Me.ModeloLabel.TabIndex = 0
        Me.ModeloLabel.Text = "Modelo"
        '
        'TelefonoSATLabel
        '
        Me.TelefonoSATLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TelefonoSATLabel.AutoSize = True
        Me.TelefonoSATLabel.Location = New System.Drawing.Point(3, 97)
        Me.TelefonoSATLabel.Name = "TelefonoSATLabel"
        Me.TelefonoSATLabel.Size = New System.Drawing.Size(73, 13)
        Me.TelefonoSATLabel.TabIndex = 1
        Me.TelefonoSATLabel.Text = "Telefono SAT"
        '
        'PrecioHoraLabel
        '
        Me.PrecioHoraLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PrecioHoraLabel.AutoSize = True
        Me.PrecioHoraLabel.Location = New System.Drawing.Point(281, 28)
        Me.PrecioHoraLabel.Name = "PrecioHoraLabel"
        Me.PrecioHoraLabel.Size = New System.Drawing.Size(65, 13)
        Me.PrecioHoraLabel.TabIndex = 2
        Me.PrecioHoraLabel.Text = "Precio/Hora"
        '
        'TipoMaquinaLabel
        '
        Me.TipoMaquinaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TipoMaquinaLabel.AutoSize = True
        Me.TipoMaquinaLabel.Location = New System.Drawing.Point(281, 97)
        Me.TipoMaquinaLabel.Name = "TipoMaquinaLabel"
        Me.TipoMaquinaLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoMaquinaLabel.TabIndex = 3
        Me.TipoMaquinaLabel.Text = "Tipo"
        '
        'FechaCompraLabel
        '
        Me.FechaCompraLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FechaCompraLabel.AutoSize = True
        Me.FechaCompraLabel.Location = New System.Drawing.Point(651, 28)
        Me.FechaCompraLabel.Name = "FechaCompraLabel"
        Me.FechaCompraLabel.Size = New System.Drawing.Size(90, 13)
        Me.FechaCompraLabel.TabIndex = 4
        Me.FechaCompraLabel.Text = "Fecha de compra"
        '
        'FechaCompraDateTimePicker
        '
        Me.FechaCompraDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FechaCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaCompraDateTimePicker.Location = New System.Drawing.Point(749, 24)
        Me.FechaCompraDateTimePicker.Name = "FechaCompraDateTimePicker"
        Me.FechaCompraDateTimePicker.Size = New System.Drawing.Size(178, 20)
        Me.FechaCompraDateTimePicker.TabIndex = 9
        '
        'TipoMaquinaComboBox
        '
        Me.TipoMaquinaComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TipoMaquinaComboBox.FormattingEnabled = True
        Me.TipoMaquinaComboBox.Location = New System.Drawing.Point(420, 93)
        Me.TipoMaquinaComboBox.Name = "TipoMaquinaComboBox"
        Me.TipoMaquinaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoMaquinaComboBox.TabIndex = 10
        '
        'TelefonoSATTextBox
        '
        Me.TelefonoSATTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TelefonoSATTextBox.Location = New System.Drawing.Point(142, 93)
        Me.TelefonoSATTextBox.Name = "TelefonoSATTextBox"
        Me.TelefonoSATTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TelefonoSATTextBox.TabIndex = 12
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DescripcionTextBox, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.CaracteristicasTextBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.DescripcionLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CaracteristicasLabel, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 147)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(930, 138)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionTextBox.Location = New System.Drawing.Point(3, 42)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(459, 93)
        Me.DescripcionTextBox.TabIndex = 0
        '
        'CaracteristicasTextBox
        '
        Me.CaracteristicasTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaracteristicasTextBox.Location = New System.Drawing.Point(468, 42)
        Me.CaracteristicasTextBox.Multiline = True
        Me.CaracteristicasTextBox.Name = "CaracteristicasTextBox"
        Me.CaracteristicasTextBox.Size = New System.Drawing.Size(459, 93)
        Me.CaracteristicasTextBox.TabIndex = 1
        '
        'DescripcionLabel
        '
        Me.DescripcionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DescripcionLabel.AutoSize = True
        Me.DescripcionLabel.Location = New System.Drawing.Point(3, 13)
        Me.DescripcionLabel.Name = "DescripcionLabel"
        Me.DescripcionLabel.Size = New System.Drawing.Size(63, 13)
        Me.DescripcionLabel.TabIndex = 2
        Me.DescripcionLabel.Text = "Descripcion"
        '
        'CaracteristicasLabel
        '
        Me.CaracteristicasLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CaracteristicasLabel.AutoSize = True
        Me.CaracteristicasLabel.Location = New System.Drawing.Point(468, 13)
        Me.CaracteristicasLabel.Name = "CaracteristicasLabel"
        Me.CaracteristicasLabel.Size = New System.Drawing.Size(76, 13)
        Me.CaracteristicasLabel.TabIndex = 3
        Me.CaracteristicasLabel.Text = "Caracteristicas"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ImagenesFlowLayoutPanel, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 291)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.28571!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.71429!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(930, 138)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.116883!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.88312!))
        Me.TableLayoutPanel5.Controls.Add(Me.ImagenesLabel, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ExaminarButton, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(924, 41)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'ImagenesLabel
        '
        Me.ImagenesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ImagenesLabel.AutoSize = True
        Me.ImagenesLabel.Location = New System.Drawing.Point(3, 14)
        Me.ImagenesLabel.Name = "ImagenesLabel"
        Me.ImagenesLabel.Size = New System.Drawing.Size(53, 13)
        Me.ImagenesLabel.TabIndex = 0
        Me.ImagenesLabel.Text = "Imagenes"
        '
        'ExaminarButton
        '
        Me.ExaminarButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ExaminarButton.Location = New System.Drawing.Point(78, 9)
        Me.ExaminarButton.Name = "ExaminarButton"
        Me.ExaminarButton.Size = New System.Drawing.Size(75, 23)
        Me.ExaminarButton.TabIndex = 1
        Me.ExaminarButton.Text = "Examinar"
        Me.ExaminarButton.UseVisualStyleBackColor = True
        '
        'ImagenesFlowLayoutPanel
        '
        Me.ImagenesFlowLayoutPanel.AutoScroll = True
        Me.ImagenesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagenesFlowLayoutPanel.Location = New System.Drawing.Point(3, 50)
        Me.ImagenesFlowLayoutPanel.Name = "ImagenesFlowLayoutPanel"
        Me.ImagenesFlowLayoutPanel.Size = New System.Drawing.Size(924, 85)
        Me.ImagenesFlowLayoutPanel.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.AceptarButton, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.CancelarButton, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 435)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(930, 43)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'AceptarButton
        '
        Me.AceptarButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AceptarButton.Location = New System.Drawing.Point(639, 10)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 0
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CancelarButton.Location = New System.Drawing.Point(770, 10)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 1
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'AnadirTipoButton
        '
        Me.AnadirTipoButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AnadirTipoButton.BackgroundImage = Global.FabLabTomy.My.Resources.Resources.plus
        Me.AnadirTipoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnadirTipoButton.Location = New System.Drawing.Point(559, 88)
        Me.AnadirTipoButton.Name = "AnadirTipoButton"
        Me.AnadirTipoButton.Size = New System.Drawing.Size(30, 30)
        Me.AnadirTipoButton.TabIndex = 13
        Me.AnadirTipoButton.UseVisualStyleBackColor = True
        '
        'NuevaMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 481)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "NuevaMaquina"
        Me.Text = "NuevaMaquina"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents PrecioHoraTextBox As TextBox
    Friend WithEvents ModeloLabel As Label
    Friend WithEvents TelefonoSATLabel As Label
    Friend WithEvents PrecioHoraLabel As Label
    Friend WithEvents TipoMaquinaLabel As Label
    Friend WithEvents FechaCompraLabel As Label
    Friend WithEvents FechaCompraDateTimePicker As DateTimePicker
    Friend WithEvents TipoMaquinaComboBox As ComboBox
    Friend WithEvents TelefonoSATTextBox As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents CaracteristicasTextBox As TextBox
    Friend WithEvents DescripcionLabel As Label
    Friend WithEvents CaracteristicasLabel As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ImagenesLabel As Label
    Friend WithEvents ExaminarButton As Button
    Friend WithEvents ImagenesFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents AceptarButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents AnadirTipoButton As Button
End Class
