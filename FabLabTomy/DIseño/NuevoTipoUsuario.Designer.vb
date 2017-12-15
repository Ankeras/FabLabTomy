<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoTipoUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoTipoUsuario))
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.RespuestaTextBox = New System.Windows.Forms.TextBox()
        Me.PreguntaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(149, 95)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 6
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(63, 95)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 5
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'RespuestaTextBox
        '
        Me.RespuestaTextBox.Location = New System.Drawing.Point(63, 60)
        Me.RespuestaTextBox.Name = "RespuestaTextBox"
        Me.RespuestaTextBox.Size = New System.Drawing.Size(161, 20)
        Me.RespuestaTextBox.TabIndex = 3
        '
        'PreguntaLabel
        '
        Me.PreguntaLabel.AutoSize = True
        Me.PreguntaLabel.Location = New System.Drawing.Point(60, 32)
        Me.PreguntaLabel.Name = "PreguntaLabel"
        Me.PreguntaLabel.Size = New System.Drawing.Size(158, 13)
        Me.PreguntaLabel.TabIndex = 4
        Me.PreguntaLabel.Text = "Escribe el nuevo tipo de usuario"
        '
        'NuevoTipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 151)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.RespuestaTextBox)
        Me.Controls.Add(Me.PreguntaLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoTipoUsuario"
        Me.Text = "NuevoTipoUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelarButton As Button
    Friend WithEvents AceptarButton As Button
    Friend WithEvents RespuestaTextBox As TextBox
    Friend WithEvents PreguntaLabel As Label
End Class
