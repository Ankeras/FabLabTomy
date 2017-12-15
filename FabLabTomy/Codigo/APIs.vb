Module APIs



    Public Async Function ComputerVisionAPI(ByVal path As String, directorio As String) As Task
        Try

            Dim client As New Microsoft.ProjectOxford.Vision.VisionServiceClient("eb00e6ae53e64100b5ffd6d5c43bf619", "https://westcentralus.api.cognitive.microsoft.com/vision/v1.0")
            Dim stream As System.IO.Stream = System.IO.File.OpenRead(path)
            Dim thumbnail As Byte() = Await client.GetThumbnailAsync(stream, 200, 200, True)
            Select Case directorio
                Case "usuario"
                    System.IO.File.WriteAllBytes(My.Settings.rutaFotosUsuario & "123.jpg", thumbnail)
                Case "maquina"
                    System.IO.File.WriteAllBytes(My.Settings.rutaFotosMaquina & "123.jpg", thumbnail)
            End Select




        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally

        End Try
    End Function


End Module
