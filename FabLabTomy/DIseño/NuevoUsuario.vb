Imports System.Text.RegularExpressions

Public Class NuevoUsuario
    Public id As Integer
    Public Enum RolAcceso As Integer
        Nuevo = 0
        Consultar = 1
        Editar = 2
    End Enum
    Public rol As RolAcceso


    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        If TelefonoMaskedTextBox.Text.Length < 11 And EmailTextBox.Text = "" Then
            MessageBox.Show("Es nesesacio introducir un telefono o email")
        Else
            NegocioUsuarios.InsertarUsuario(NombreTextBox.Text, ApellidoTextBox.Text, FechaDateTimePicker.Value, TelefonoMaskedTextBox.Text, EmailTextBox.Text, DireccionPostalTextBox.Text, OrganizacionTextBox.Text, 1, ObservacionesRichTextBox.Text)

            Dim padre As Principal = CType(Me.MdiParent, Principal)
            Dim valor As Integer = CInt(padre.ValorUsuariosToolStripStatusLabel1.Text) + 1
            padre.ValorUsuariosToolStripStatusLabel1.Text = CStr(valor)
        End If


    End Sub

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If rol = 1 Or rol = 2 Then
            Dim resultado As DataTable = NegocioUsuarios.ObtenerUsuarioId(id)

            For Each row As DataRow In resultado.Rows

                NombreTextBox.Text = CStr(row("nombre"))
                ApellidoTextBox.Text = CStr(row("apellidos"))
                FechaDateTimePicker.Value = CDate(row("fecha_nacimiento"))
                If row.IsNull("organizacion") Then
                    OrganizacionTextBox.Text = " "
                Else
                    OrganizacionTextBox.Text = CStr(row("organizacion"))
                End If

                If row.IsNull("direccion") Then
                    DireccionPostalTextBox.Text = " "
                Else
                    DireccionPostalTextBox.Text = CStr(row("direccion"))
                End If

                If row.IsNull("telefono") Then
                    TelefonoMaskedTextBox.Text = " "
                Else
                    TelefonoMaskedTextBox.Text = CStr(row("telefono"))
                End If

                If row.IsNull("email") Then
                    EmailTextBox.Text = " "
                Else
                    EmailTextBox.Text = CStr(row("email"))
                End If

                If rol = 1 Then
                    PanelSuperiorTableLayoutPanel.Enabled = False
                    PanelInferiorTableLayoutPanel.Enabled = False
                End If


            Next
        End If
    End Sub

    Private Async Function CargarButton_ClickAsync(sender As Object, e As EventArgs) As Task Handles CargarButton.Click

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName

            Dim fotoUrl As String = Await ComputerVisionAPI(path, NombreTextBox.Text, ApellidoTextBox.Text)
            PictureBox1.ImageLocation = fotoUrl

        End If



    End Function



    Private Sub TelefonoMaskedTextBox_Validating_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TelefonoMaskedTextBox.Validating
        If TelefonoMaskedTextBox.Text.Length < 11 Then
            e.Cancel = True
            ErrorProvider1.SetError(TelefonoMaskedTextBox, "Introduce un numero de telefono valido")
        End If
    End Sub

    Private Sub TelefonoMaskedTextBox_Validated(sender As Object, e As EventArgs) Handles TelefonoMaskedTextBox.Validated
        ErrorProvider1.SetError(TelefonoMaskedTextBox, "")
    End Sub

    Private Sub EmailTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailTextBox.Validating

        If Regex.IsMatch(EmailTextBox.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") = False Then
            e.Cancel = True
            ErrorProvider1.SetError(EmailTextBox, "Introduce un email valido")
        End If

    End Sub

    Private Sub EmailTextBox_Validated(sender As Object, e As EventArgs) Handles EmailTextBox.Validated
        ErrorProvider1.SetError(EmailTextBox, "")
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub


    Friend Sub RellenarComboBox()
        TipoUsuarioComboBox.DataSource = ObtenerTiposUsuario()
        TipoUsuarioComboBox.DisplayMember = "tipo"
        TipoUsuarioComboBox.ValueMember = "id"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class