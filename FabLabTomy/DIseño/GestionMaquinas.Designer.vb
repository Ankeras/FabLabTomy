<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionMaquinas
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
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.NuevaMaquinaButton = New System.Windows.Forms.Button()
        Me.BuscarLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ConsultarButton = New System.Windows.Forms.Button()
        Me.EditarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.MaquinaDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.MaquinaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MaquinaDataGridView, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-1, -2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(768, 453)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BuscarTextBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NuevaMaquinaButton, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BuscarLabel, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(79, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.94444!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.05556!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(602, 84)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Location = New System.Drawing.Point(3, 50)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(230, 20)
        Me.BuscarTextBox.TabIndex = 1
        '
        'NuevaMaquinaButton
        '
        Me.NuevaMaquinaButton.Location = New System.Drawing.Point(487, 50)
        Me.NuevaMaquinaButton.Name = "NuevaMaquinaButton"
        Me.NuevaMaquinaButton.Size = New System.Drawing.Size(112, 23)
        Me.NuevaMaquinaButton.TabIndex = 2
        Me.NuevaMaquinaButton.Text = "Nueva Maquina"
        Me.NuevaMaquinaButton.UseVisualStyleBackColor = True
        '
        'BuscarLabel
        '
        Me.BuscarLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BuscarLabel.AutoSize = True
        Me.BuscarLabel.Location = New System.Drawing.Point(3, 17)
        Me.BuscarLabel.Name = "BuscarLabel"
        Me.BuscarLabel.Size = New System.Drawing.Size(40, 13)
        Me.BuscarLabel.TabIndex = 0
        Me.BuscarLabel.Text = "Buscar"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ConsultarButton, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EditarButton, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EliminarButton, 3, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(79, 364)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.34146!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.65854!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(580, 86)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'ConsultarButton
        '
        Me.ConsultarButton.Location = New System.Drawing.Point(235, 3)
        Me.ConsultarButton.Name = "ConsultarButton"
        Me.ConsultarButton.Size = New System.Drawing.Size(110, 23)
        Me.ConsultarButton.TabIndex = 3
        Me.ConsultarButton.Text = "Consultar"
        Me.ConsultarButton.UseVisualStyleBackColor = True
        '
        'EditarButton
        '
        Me.EditarButton.Location = New System.Drawing.Point(351, 3)
        Me.EditarButton.Name = "EditarButton"
        Me.EditarButton.Size = New System.Drawing.Size(110, 23)
        Me.EditarButton.TabIndex = 4
        Me.EditarButton.Text = "EditarButton"
        Me.EditarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(467, 3)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(110, 23)
        Me.EliminarButton.TabIndex = 5
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'MaquinaDataGridView
        '
        Me.MaquinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaquinaDataGridView.Location = New System.Drawing.Point(79, 93)
        Me.MaquinaDataGridView.Name = "MaquinaDataGridView"
        Me.MaquinaDataGridView.Size = New System.Drawing.Size(574, 256)
        Me.MaquinaDataGridView.TabIndex = 2
        '
        'GestionMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 451)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "GestionMaquinas"
        Me.Text = "GestionMaquinas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.MaquinaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BuscarLabel As Label
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents NuevaMaquinaButton As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ConsultarButton As Button
    Friend WithEvents EditarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents MaquinaDataGridView As DataGridView
End Class
