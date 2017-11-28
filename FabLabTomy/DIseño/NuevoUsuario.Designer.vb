<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
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
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.OrganizacionLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.DPostalLabel = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(309, 54)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(50, 13)
        Me.NombreLabel.TabIndex = 0
        Me.NombreLabel.Text = "Nombre :"
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Location = New System.Drawing.Point(309, 118)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(55, 13)
        Me.TelefonoLabel.TabIndex = 1
        Me.TelefonoLabel.Text = "Telefono :"
        '
        'OrganizacionLabel
        '
        Me.OrganizacionLabel.AutoSize = True
        Me.OrganizacionLabel.Location = New System.Drawing.Point(309, 189)
        Me.OrganizacionLabel.Name = "OrganizacionLabel"
        Me.OrganizacionLabel.Size = New System.Drawing.Size(75, 13)
        Me.OrganizacionLabel.TabIndex = 2
        Me.OrganizacionLabel.Text = "Organizacion :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(386, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(386, 111)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(386, 186)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(641, 54)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(537, 54)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(50, 13)
        Me.ApellidoLabel.TabIndex = 6
        Me.ApellidoLabel.Text = "Apellido :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(641, 111)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(537, 118)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(38, 13)
        Me.EmailLabel.TabIndex = 8
        Me.EmailLabel.Text = "Email :"
        '
        'DPostalLabel
        '
        Me.DPostalLabel.AutoSize = True
        Me.DPostalLabel.Location = New System.Drawing.Point(537, 189)
        Me.DPostalLabel.Name = "DPostalLabel"
        Me.DPostalLabel.Size = New System.Drawing.Size(84, 13)
        Me.DPostalLabel.TabIndex = 10
        Me.DPostalLabel.Text = "Direccion Postal"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(641, 186)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 11
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(312, 249)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(108, 13)
        Me.FechaLabel.TabIndex = 12
        Me.FechaLabel.Text = "Fecha de Nacimiento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(439, 243)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(37, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 171)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(320, 346)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(421, 115)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Label1"
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 535)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.DPostalLabel)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ApellidoLabel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.OrganizacionLabel)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.NombreLabel)
        Me.Name = "NuevoUsuario"
        Me.Text = "NuevoUsuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NombreLabel As Label
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents OrganizacionLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ApellidoLabel As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents DPostalLabel As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents FechaLabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
End Class
