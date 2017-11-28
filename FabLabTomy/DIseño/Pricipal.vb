Public Class Pricipal
    Private Sub Pricipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form2 As SplashV2 = New SplashV2
        form2.Show()

    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim usuario As New NuevoUsuario
        usuario.MdiParent = Me
        usuario.Text = "Nuevo Usuario"
        usuario.Show()
    End Sub

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

    Private Sub NuevaMaquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripMenuItem.Click
        Dim usuario As New NuevaMaquina
        usuario.MdiParent = Me
        usuario.Text = "Nuevo Máquina"
        usuario.Show()
    End Sub

    Private Sub GestionMaquinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionMaquinasToolStripMenuItem.Click
        Dim usuario As New GestionMaquinas
        usuario.MdiParent = Me
        usuario.Text = "Gestión de Máquinas"
        usuario.Show()
    End Sub

    Private Sub GestionUsuariosçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosçToolStripMenuItem.Click
        Dim usuario As New GestionUsuarios
        usuario.MdiParent = Me
        usuario.Text = "Gestión de Usuarios"
        usuario.Show()
    End Sub
End Class