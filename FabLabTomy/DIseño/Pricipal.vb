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

    End Sub
End Class