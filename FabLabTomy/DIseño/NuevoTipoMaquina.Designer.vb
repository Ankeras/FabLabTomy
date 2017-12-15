<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoTipoMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoTipoMaquina))
        Me.PreguntaLabel = New System.Windows.Forms.Label()
        Me.RespuestaTextBox = New System.Windows.Forms.TextBox()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PreguntaLabel
        '
        Me.PreguntaLabel.AutoSize = True
        Me.PreguntaLabel.Location = New System.Drawing.Point(60, 32)
        Me.PreguntaLabel.Name = "PreguntaLabel"
        Me.PreguntaLabel.Size = New System.Drawing.Size(164, 13)
        Me.PreguntaLabel.TabIndex = 0
        Me.PreguntaLabel.Text = "Escribe el nuevo tipo de máquina"
        '
        'RespuestaTextBox
        '
        Me.RespuestaTextBox.Location = New System.Drawing.Point(63, 60)
        Me.RespuestaTextBox.Name = "RespuestaTextBox"
        Me.RespuestaTextBox.Size = New System.Drawing.Size(161, 20)
        Me.RespuestaTextBox.TabIndex = 1
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(63, 95)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 2
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(149, 95)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 3
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'NuevoTipoMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 151)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.RespuestaTextBox)
        Me.Controls.Add(Me.PreguntaLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 190)
        Me.MinimumSize = New System.Drawing.Size(300, 190)
        Me.Name = "NuevoTipoMaquina"
        Me.Text = "Nuevo Tipo de Máquina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PreguntaLabel As Label
    Friend WithEvents RespuestaTextBox As TextBox
    Friend WithEvents AceptarButton As Button
    Friend WithEvents CancelarButton As Button
End Class
