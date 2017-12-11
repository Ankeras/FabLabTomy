Public Class EULA
    Private Sub RichTextBox1_VScroll(sender As Object, e As EventArgs) Handles RichTextBox1.VScroll


    End Sub
    Private Sub FinScroll(sender As Object, e As ScrollEventArgs)

        If (e.Type = ScrollEventType.Last) Then
            AceptarButton.Enabled = True
        End If

        'If CInt(RichTextBox1.GetPositionFromCharIndex(punto)) = RichTextBox1.TextLength - 1 Then
        '    
        'End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        Me.Close()
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub


End Class