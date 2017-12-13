<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Me.BotonesInferiorTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.EditarButton = New System.Windows.Forms.Button()
        Me.ConsultarButton = New System.Windows.Forms.Button()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.SuperiorTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BuscarTextBox = New System.Windows.Forms.TextBox()
        Me.NuevoUsuarioButton = New System.Windows.Forms.Button()
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.BotonesInferiorTableLayoutPanel.SuspendLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperiorTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 610.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BotonesInferiorTableLayoutPanel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.UsuariosDataGridView, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SuperiorTableLayoutPanel, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(769, 451)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BotonesInferiorTableLayoutPanel
        '
        Me.BotonesInferiorTableLayoutPanel.ColumnCount = 4
        Me.BotonesInferiorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BotonesInferiorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BotonesInferiorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BotonesInferiorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.BotonesInferiorTableLayoutPanel.Controls.Add(Me.EliminarButton, 3, 0)
        Me.BotonesInferiorTableLayoutPanel.Controls.Add(Me.EditarButton, 2, 0)
        Me.BotonesInferiorTableLayoutPanel.Controls.Add(Me.ConsultarButton, 1, 0)
        Me.BotonesInferiorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BotonesInferiorTableLayoutPanel.Location = New System.Drawing.Point(81, 383)
        Me.BotonesInferiorTableLayoutPanel.Name = "BotonesInferiorTableLayoutPanel"
        Me.BotonesInferiorTableLayoutPanel.RowCount = 1
        Me.BotonesInferiorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BotonesInferiorTableLayoutPanel.Size = New System.Drawing.Size(604, 65)
        Me.BotonesInferiorTableLayoutPanel.TabIndex = 0
        '
        'EliminarButton
        '
        Me.EliminarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EliminarButton.Location = New System.Drawing.Point(456, 21)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(145, 23)
        Me.EliminarButton.TabIndex = 3
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'EditarButton
        '
        Me.EditarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditarButton.Location = New System.Drawing.Point(305, 21)
        Me.EditarButton.Name = "EditarButton"
        Me.EditarButton.Size = New System.Drawing.Size(145, 23)
        Me.EditarButton.TabIndex = 4
        Me.EditarButton.Text = "Editar"
        Me.EditarButton.UseVisualStyleBackColor = True
        '
        'ConsultarButton
        '
        Me.ConsultarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsultarButton.Location = New System.Drawing.Point(154, 21)
        Me.ConsultarButton.Name = "ConsultarButton"
        Me.ConsultarButton.Size = New System.Drawing.Size(145, 23)
        Me.ConsultarButton.TabIndex = 5
        Me.ConsultarButton.Text = "Consultar"
        Me.ConsultarButton.UseVisualStyleBackColor = True
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(81, 79)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(604, 298)
        Me.UsuariosDataGridView.TabIndex = 1
        '
        'SuperiorTableLayoutPanel
        '
        Me.SuperiorTableLayoutPanel.ColumnCount = 3
        Me.SuperiorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.56775!))
        Me.SuperiorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.43225!))
        Me.SuperiorTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.SuperiorTableLayoutPanel.Controls.Add(Me.BuscarTextBox, 0, 0)
        Me.SuperiorTableLayoutPanel.Controls.Add(Me.NuevoUsuarioButton, 2, 0)
        Me.SuperiorTableLayoutPanel.Controls.Add(Me.BuscarButton, 1, 0)
        Me.SuperiorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperiorTableLayoutPanel.Location = New System.Drawing.Point(81, 3)
        Me.SuperiorTableLayoutPanel.Name = "SuperiorTableLayoutPanel"
        Me.SuperiorTableLayoutPanel.RowCount = 1
        Me.SuperiorTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.SuperiorTableLayoutPanel.Size = New System.Drawing.Size(604, 70)
        Me.SuperiorTableLayoutPanel.TabIndex = 2
        '
        'BuscarTextBox
        '
        Me.BuscarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarTextBox.Location = New System.Drawing.Point(3, 25)
        Me.BuscarTextBox.Name = "BuscarTextBox"
        Me.BuscarTextBox.Size = New System.Drawing.Size(190, 20)
        Me.BuscarTextBox.TabIndex = 1
        '
        'NuevoUsuarioButton
        '
        Me.NuevoUsuarioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevoUsuarioButton.Location = New System.Drawing.Point(453, 23)
        Me.NuevoUsuarioButton.Name = "NuevoUsuarioButton"
        Me.NuevoUsuarioButton.Size = New System.Drawing.Size(148, 23)
        Me.NuevoUsuarioButton.TabIndex = 2
        Me.NuevoUsuarioButton.Text = "Nuevo Usuario"
        Me.NuevoUsuarioButton.UseVisualStyleBackColor = True
        '
        'BuscarButton
        '
        Me.BuscarButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BuscarButton.Location = New System.Drawing.Point(199, 23)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(148, 23)
        Me.BuscarButton.TabIndex = 3
        Me.BuscarButton.Text = "Buscar por nombre"
        Me.BuscarButton.UseVisualStyleBackColor = True
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 451)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(785, 490)
        Me.MinimumSize = New System.Drawing.Size(785, 490)
        Me.Name = "GestionUsuarios"
        Me.Text = "GestionUsuarios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.BotonesInferiorTableLayoutPanel.ResumeLayout(False)
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperiorTableLayoutPanel.ResumeLayout(False)
        Me.SuperiorTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BotonesInferiorTableLayoutPanel As TableLayoutPanel
    Friend WithEvents EliminarButton As Button
    Friend WithEvents EditarButton As Button
    Friend WithEvents ConsultarButton As Button
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents SuperiorTableLayoutPanel As TableLayoutPanel
    Friend WithEvents BuscarTextBox As TextBox
    Friend WithEvents NuevoUsuarioButton As Button
    Friend WithEvents BuscarButton As Button
End Class
