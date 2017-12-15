Module APIs


    Public Sub ComputerVisionAPI(ruta As String)
        'Dim thumbnail = GetThumbnail(ruta)


    End Sub
    Public Async Function GetThumbnail(ByVal path As String) As Task
        Try

            Dim client As New Microsoft.ProjectOxford.Vision.VisionServiceClient("eb00e6ae53e64100b5ffd6d5c43bf619", "https://westcentralus.api.cognitive.microsoft.com/vision/v1.0")
            Dim stream As System.IO.Stream = System.IO.File.OpenRead(path)
            Dim thumbnail As Byte() = Await client.GetThumbnailAsync(stream, 200, 200, True)
            Dim writer As System.IO.StreamWriter = New IO.StreamWriter(My.Settings.rutaFotosUsuario & "123.jpg")
            writer.Write(thumbnail)
            writer.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally

        End Try



    End Function
End Module
