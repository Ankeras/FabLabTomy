﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SdadsadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaMaquinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionMaquinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsdadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.UsuariosToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ValorUsuariosToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MaquinasToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ValorMaquinasToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoUsuarioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GestionUsuariosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GestionMaquinasToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NuevaMaquinaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SadaToolStripMenuItem, Me.SdadsadToolStripMenuItem, Me.AsdadToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SadaToolStripMenuItem
        '
        Me.SadaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.GestionUsuariosToolStripMenuItem})
        Me.SadaToolStripMenuItem.Name = "SadaToolStripMenuItem"
        Me.SadaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.SadaToolStripMenuItem.Text = "&Usuarios"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Image = Global.FabLabTomy.My.Resources.Resources.add_user
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "&Nuevo Usuario"
        '
        'GestionUsuariosToolStripMenuItem
        '
        Me.GestionUsuariosToolStripMenuItem.Image = Global.FabLabTomy.My.Resources.Resources.man
        Me.GestionUsuariosToolStripMenuItem.Name = "GestionUsuariosToolStripMenuItem"
        Me.GestionUsuariosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.GestionUsuariosToolStripMenuItem.Text = "&Gestion Usuarios"
        '
        'SdadsadToolStripMenuItem
        '
        Me.SdadsadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaMaquinaToolStripMenuItem, Me.GestionMaquinasToolStripMenuItem})
        Me.SdadsadToolStripMenuItem.Name = "SdadsadToolStripMenuItem"
        Me.SdadsadToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SdadsadToolStripMenuItem.Text = "&Maquinas"
        '
        'NuevaMaquinaToolStripMenuItem
        '
        Me.NuevaMaquinaToolStripMenuItem.Image = Global.FabLabTomy.My.Resources.Resources.add_printer_button
        Me.NuevaMaquinaToolStripMenuItem.Name = "NuevaMaquinaToolStripMenuItem"
        Me.NuevaMaquinaToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.NuevaMaquinaToolStripMenuItem.Text = "&Nueva Maquina"
        '
        'GestionMaquinasToolStripMenuItem
        '
        Me.GestionMaquinasToolStripMenuItem.Image = Global.FabLabTomy.My.Resources.Resources.settings
        Me.GestionMaquinasToolStripMenuItem.Name = "GestionMaquinasToolStripMenuItem"
        Me.GestionMaquinasToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.GestionMaquinasToolStripMenuItem.Text = "&Gestion Maquinas"
        '
        'AsdadToolStripMenuItem
        '
        Me.AsdadToolStripMenuItem.Name = "AsdadToolStripMenuItem"
        Me.AsdadToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AsdadToolStripMenuItem.Text = "&Informes"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizarVentanasToolStripMenuItem, Me.MinimizarTodasToolStripMenuItem, Me.ToolStripSeparator1})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VentanaToolStripMenuItem.Text = "&Ventana"
        '
        'OrganizarVentanasToolStripMenuItem
        '
        Me.OrganizarVentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem, Me.CascadaToolStripMenuItem})
        Me.OrganizarVentanasToolStripMenuItem.Name = "OrganizarVentanasToolStripMenuItem"
        Me.OrganizarVentanasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OrganizarVentanasToolStripMenuItem.Text = "&Organizar Ventanas"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.VerticalToolStripMenuItem.Text = "&Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HorizontalToolStripMenuItem.Text = "&Horizontal"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CascadaToolStripMenuItem.Text = "&Cascada"
        '
        'MinimizarTodasToolStripMenuItem
        '
        Me.MinimizarTodasToolStripMenuItem.Name = "MinimizarTodasToolStripMenuItem"
        Me.MinimizarTodasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MinimizarTodasToolStripMenuItem.Text = "&Minimizar Todas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = Global.FabLabTomy.My.Resources.Resources.about
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca &de"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripStatusLabel, Me.ValorUsuariosToolStripStatusLabel1, Me.MaquinasToolStripStatusLabel, Me.ValorMaquinasToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 396)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(900, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'UsuariosToolStripStatusLabel
        '
        Me.UsuariosToolStripStatusLabel.Name = "UsuariosToolStripStatusLabel"
        Me.UsuariosToolStripStatusLabel.Size = New System.Drawing.Size(58, 17)
        Me.UsuariosToolStripStatusLabel.Text = "Usuarios: "
        '
        'ValorUsuariosToolStripStatusLabel1
        '
        Me.ValorUsuariosToolStripStatusLabel1.Name = "ValorUsuariosToolStripStatusLabel1"
        Me.ValorUsuariosToolStripStatusLabel1.Size = New System.Drawing.Size(13, 17)
        Me.ValorUsuariosToolStripStatusLabel1.Text = "0"
        '
        'MaquinasToolStripStatusLabel
        '
        Me.MaquinasToolStripStatusLabel.Name = "MaquinasToolStripStatusLabel"
        Me.MaquinasToolStripStatusLabel.Size = New System.Drawing.Size(65, 17)
        Me.MaquinasToolStripStatusLabel.Text = "Maquinas: "
        '
        'ValorMaquinasToolStripStatusLabel
        '
        Me.ValorMaquinasToolStripStatusLabel.Name = "ValorMaquinasToolStripStatusLabel"
        Me.ValorMaquinasToolStripStatusLabel.Size = New System.Drawing.Size(13, 17)
        Me.ValorMaquinasToolStripStatusLabel.Text = "0"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripButton, Me.GestionUsuariosToolStripButton, Me.GestionMaquinasToolStripButton, Me.NuevaMaquinaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(900, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoUsuarioToolStripButton
        '
        Me.NuevoUsuarioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoUsuarioToolStripButton.Image = Global.FabLabTomy.My.Resources.Resources.add_user
        Me.NuevoUsuarioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoUsuarioToolStripButton.Name = "NuevoUsuarioToolStripButton"
        Me.NuevoUsuarioToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoUsuarioToolStripButton.Text = "Nuevo Usuario"
        '
        'GestionUsuariosToolStripButton
        '
        Me.GestionUsuariosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GestionUsuariosToolStripButton.Image = Global.FabLabTomy.My.Resources.Resources.man
        Me.GestionUsuariosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GestionUsuariosToolStripButton.Name = "GestionUsuariosToolStripButton"
        Me.GestionUsuariosToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GestionUsuariosToolStripButton.Text = "Gestión de usuarios"
        '
        'GestionMaquinasToolStripButton
        '
        Me.GestionMaquinasToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GestionMaquinasToolStripButton.Image = Global.FabLabTomy.My.Resources.Resources.settings
        Me.GestionMaquinasToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GestionMaquinasToolStripButton.Name = "GestionMaquinasToolStripButton"
        Me.GestionMaquinasToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GestionMaquinasToolStripButton.Text = "Gestión de máquinas"
        '
        'NuevaMaquinaToolStripButton
        '
        Me.NuevaMaquinaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevaMaquinaToolStripButton.Image = Global.FabLabTomy.My.Resources.Resources.add_printer_button
        Me.NuevaMaquinaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevaMaquinaToolStripButton.Name = "NuevaMaquinaToolStripButton"
        Me.NuevaMaquinaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevaMaquinaToolStripButton.Text = "Nueva Máquina"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 418)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SdadsadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsdadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaMaquinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionMaquinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents UsuariosToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents MaquinasToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GestionUsuariosToolStripButton As ToolStripButton
    Friend WithEvents GestionMaquinasToolStripButton As ToolStripButton
    Friend WithEvents ValorUsuariosToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ValorMaquinasToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents NuevoUsuarioToolStripButton As ToolStripButton
    Friend WithEvents NuevaMaquinaToolStripButton As ToolStripButton
End Class
