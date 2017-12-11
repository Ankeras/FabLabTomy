Public Class SplashV2
    Private Sub SplashV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Dim contador As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case contador
            Case 0
                CargandoLabel.Text = "conectando a la base de datos........"
            Case 1
                CargandoLabel.Text = "cargando usarios........"
            Case 2
                CargandoLabel.Text = "cargando maquinas........"
            Case 5
                Timer1.Stop()
                MostrarEULA()
        End Select

        contador = contador + 1
    End Sub

    Public Sub MostrarEULA()
        Dim form As New EULA
        form.ShowDialog()
        Me.Close()
    End Sub
End Class