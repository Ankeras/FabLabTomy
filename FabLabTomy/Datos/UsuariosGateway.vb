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

        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try
        Return filas
    End Function



    Public Function Actualizar(nombre As String, apellido As String, fecha As DateTime, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer, observaciones As String, id As Integer) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("UPDATE Usuarios SET nombre='{0}',apellido='{1}',fecha_nacimiento='{2}',telefono='{3}',email='{4}',direccion='{5}',organizacion='{6}',tipo='{7}',observaciones='{8}' WHERE id='{10}')", nombre, apellido, fecha, telefono, email, direccion, organizacion, tipo, observaciones, id)

        If id = 0 Or id = Nothing Then
            Throw New ArgumentException("La id no puede ser 0 ni nulo")
        End If
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
        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try

        Return filas
    End Function



    Public Function Eliminar() As Integer
        Dim filas As Integer
        ''''''''''''''''''''''''''''' HACER CONSULTA ''''''''''''''''''''''''''''''
        Dim consulta As String = ""
        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas
    End Function


    Public Function SelecionarToddos() As DataTable
        Dim consulta As String = String.Format("SELECT * FROM Usuarios")
        Dim resultado As New DataTable
        Dim lector As SqlDataReader


        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()
            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return resultado

    End Function
    Public Function SeleccionarId(id As Integer) As DataTable

        Dim consulta As String = String.Format("SELECT * FROM Usuarios WHERE id={0}", id)
        Dim resultado As New DataTable
        Dim lector As SqlDataReader


        If id = 0 Then
            Throw New ArgumentException("El identificador no puede estar vacío")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()


            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try


        Return resultado

    End Function
    Public Function SelecionarApellido(apellido As String) As DataTable
        Dim consulta As String = String.Format("SELECT * FROM Usuarios WHERE apellido={0}", apellido)
        Dim resultado As New DataTable
        Dim lector As SqlDataReader


        If apellido = "" Or apellido Is Nothing Then
            Throw New ArgumentException("El apellido no puede estar vacío o nulo")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()


            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try


        Return resultado
    End Function

    Public Function SelecionarEdad(edad As Integer) As DataTable
        Dim consulta As String = String.Format("SELECT * FROM Usuarios WHERE edad={0}", edad)
        Dim resultado As New DataTable
        Dim lector As SqlDataReader


        If edad = Nothing Then
            Throw New ArgumentException("La edad no puede ser nulo")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()


            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try


        Return resultado
    End Function

    ''' <summary>
    ''' MIRAAAAR COMENTARIO EN BD !
    ''' </summary>
    ''' <param name="comentario"></param>
    ''' <returns></returns>
    Public Function SelecionarComentario(comentario As String) As DataTable
        Dim consulta As String = String.Format("SELECT * FROM Usuarios WHERE edad={0}", comentario)
        Dim resultado As New DataTable
        Dim lector As SqlDataReader




        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()


            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
    End Function

    'Punto de acceso a base de datos(FabLabDB)
End Class
