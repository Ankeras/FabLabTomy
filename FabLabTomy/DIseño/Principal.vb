Public Class Principal

    ''' <summary>
    ''' Al cargar el formulario aparecerá el Splash y se llamará a los métodos correspondientes para ver cuántos usuarios y
    ''' máquinas hay en la base de datos y reflejarlo en el StatusLabel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Pricipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New SplashV2
        Dim numeroUsuarios = ObtenerTodosUsuarios().Rows.Count
        Dim numeroMaquinas = ObtenerTodasMaquinas().Rows.Count

        ValorUsuariosToolStripStatusLabel1.Text = CStr(NumeroUsuarios)
        ValorMaquinasToolStripStatusLabel.Text = CStr(NumeroMaquinas)
        form.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que maneja el click en la opción del menú de nuevo usuario y abre un nuevo form de la clase NuevoUsuario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim usuario As New NuevoUsuario
        usuario.MdiParent = Me
        usuario.Text = "Nuevo Usuario"
        usuario.Show()
    End Sub

    ''' <summary>
    ''' Método que maneja el click en los item de la opción del menú de ventanas, la opción vertical organizará los formularios de forma vertical,
    ''' la horizontal en horizontal y la opción cascada en cascada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click, HorizontalToolStripMenuItem.Click, CascadaToolStripMenuItem.Click
        Dim opcion As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Select Case opcion.Name
            Case "VerticalToolStripMenuItem"
                Me.LayoutMdi(MdiLayout.TileVertical)

            Case "HorizontalToolStripMenuItem"
                Me.LayoutMdi(MdiLayout.TileHorizontal)

            Case "CascadaToolStripMenuItem"
                Me.LayoutMdi(MdiLayout.Cascade)
        End Select
    End Sub

    ''' <summary>
    ''' Método que maneja el click en la opción del menú nueva máquina, abrirá un nuevo formulario de la clase NuevaMaquina
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NuevaMaquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripMenuItem.Click
        Dim usuario As New NuevaMaquina
        usuario.MdiParent = Me
        usuario.Text = "Nuevo Máquina"
        usuario.Show()
    End Sub

    ''' <summary>
    ''' Método que maneja el click en la opción del menú gestión máquinas, abrirá un nuevo formulario de la clase GestionMaquinas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GestionMaquinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionMaquinasToolStripMenuItem.Click
        Dim usuario As New GestionMaquinas
        usuario.MdiParent = Me
        usuario.Text = "Gestión de Máquinas"
        usuario.Show()
    End Sub

    ''' <summary>
    ''' Método que maneja el click en la opción del menú gestión usuarios, abrirá un nuevo formulario de la clase GestionUsuarios
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        Dim usuario As New GestionUsuarios
        usuario.MdiParent = Me
        usuario.Text = "Gestión de Usuarios"
        usuario.Show()
    End Sub

    ''' <summary>
    ''' Método que maneja el click del botón Acerca De en la opción del menú Ayuda, abrirá un diálogo de la clase AcercaDe
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim form As New AcercaDe
        form.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que maneja el click en el botón minimizar todas del item ventanas del menú, minimizará todos los formularios hijos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MinimizarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarTodasToolStripMenuItem.Click
        For Each item In Me.MdiChildren
            item.WindowState = FormWindowState.Minimized
        Next
    End Sub

    ''' <summary>
    ''' Al mostrarse el formulario se mostrará en estado maximizado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Principal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WindowState = FormWindowState.Maximized
    End Sub

    ''' <summary>
    ''' Método que maneja el click sobre el botón gestión usuarios del ToolBar y ejecutará click sobre el botón gestión usuarios del menú
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GestionUsuariosToolStripButton_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripButton.Click
        GestionUsuariosToolStripMenuItem.PerformClick()
    End Sub

    ''' <summary>
    ''' Método que maneja el click sobre el botón gestión máquinas del ToolBar y ejecutará click sobre el botón gestión máquinas del menú
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GestionMaquinasToolStripButton_Click(sender As Object, e As EventArgs) Handles GestionMaquinasToolStripButton.Click
        GestionMaquinasToolStripMenuItem.PerformClick()
    End Sub

    ''' <summary>
    ''' Método que maneja el click sobre el botón nuevo usuario del ToolBar y ejecutará click sobre el botón nuevo usuario del menú
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NuevoUsuarioToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripButton.Click
        NuevoUsuarioToolStripMenuItem.PerformClick()
    End Sub

    ''' <summary>
    ''' Método que maneja el click sobre el botón nueva máquina del ToolBar y ejecutará click sobre el botón nueva máquina del menú
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NuevaMaquinaToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripButton.Click
        NuevaMaquinaToolStripMenuItem.PerformClick()
    End Sub
End Class