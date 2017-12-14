﻿Public Class Principal

    Public Property NumeroUsuarios As Integer
    Public Property NumeroMaquinas As Integer

    Private Sub Pricipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New SplashV2
        NumeroUsuarios = ObtenerTodosUsuarios().Rows.Count
        NumeroMaquinas = ObtenerTodasMaquinas().Rows.Count

        ValorUsuariosToolStripStatusLabel1.Text = CStr(NumeroUsuarios)
        ValorMaquinasToolStripStatusLabel.Text = CStr(NumeroMaquinas)
        'form.ShowDialog()
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

    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        Dim usuario As New GestionUsuarios
        usuario.MdiParent = Me
        usuario.Text = "Gestión de Usuarios"
        usuario.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim form As New AcercaDe
        form.ShowDialog()
    End Sub

    Private Sub MinimizarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarTodasToolStripMenuItem.Click
        For Each item In Me.MdiChildren
            item.WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub Principal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub GestionUsuariosToolStripButton_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripButton.Click
        GestionUsuariosToolStripMenuItem.PerformClick()
    End Sub

    Private Sub GestionMaquinasToolStripButton_Click(sender As Object, e As EventArgs) Handles GestionMaquinasToolStripButton.Click
        GestionMaquinasToolStripMenuItem.PerformClick()
    End Sub
End Class