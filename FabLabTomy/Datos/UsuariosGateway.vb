Imports System.Data.SqlClient
Public Class UsuariosGateway
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(conexionString As String)
        Me.conexion = New SqlConnection(conexionString)
        Me.comando = New SqlCommand
        comando.Connection = conexion

    End Sub

    Public Function Insertar(nombre As String, apellido As String, fecha As DateTime, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer, observaciones As String) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("INSERT INTO Usuarios(nombre,apellido,fecha_nacimiento,telefono,email,direccion,organizacion,tipo,observaciones,fecha_alta) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9})", nombre, apellido, fecha, telefono, email, direccion, organizacion, tipo, observaciones, DateTime.Now.Hour)

        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
        End If

        If apellido = "" Or apellido Is Nothing Then
            Throw New ArgumentException("El apellido no puede estar vacío")
        End If
        If fecha < DateTime.MinValue Or fecha > DateTime.MaxValue Then

        End If

        If telefono = "" Or telefono Is Nothing Then
            Throw New ArgumentException("El telefono no puede estar vacío")
        End If

        Dim er As New System.Text.RegularExpressions.Regex("[0-9]{9}")
        If Not er.IsMatch(telefono) Then
            Throw New ArgumentException("El teléfono debe contener 9 dígitos")
        End If



        Return filas
    End Function



    Public Function Actualizar() As Integer
        Dim filas As Integer


        Return filas
    End Function



    Public Function Eliminar() As Integer
        Dim filas As Integer


        Return filas
    End Function


    Public Function SelecionarToddos() As DataTable
        Dim resultado As DataTable


        Return resultado
    End Function

    Public Function SelecionarApellido() As DataTable
        Dim resultado As DataTable


        Return resultado
    End Function

    Public Function SelecionarEdad() As DataTable
        Dim resultado As DataTable


        Return resultado
    End Function
    Public Function SelecionarComentario() As DataTable
        Dim resultado As DataTable


        Return resultado
    End Function

    'Punto de acceso a base de datos(FabLabDB)
End Class
