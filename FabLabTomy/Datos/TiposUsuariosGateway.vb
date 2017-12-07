Imports System.Data.SqlClient

Public Class TiposUsuariosGateway


    ''' <summary>
    ''' Objeto con el que abriremos la conexión
    ''' </summary>
    Private conexion As SqlConnection

    ''' <summary>
    ''' Objeto con el que ejecutaremos las consultas
    ''' </summary>
    Private comando As SqlCommand

    ''' <summary>
    ''' Constructor de la clase, crea el acceso a la base de datos
    ''' </summary>
    ''' <param name="cadenaConexion">Cadena de conexion de la base de datos</param>
    Public Sub New(cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand()
        comando.Connection = conexion
    End Sub

    Public Function Insertar(tipo As String) As Integer
        'Variable que devolveremos indicando el número de filas afectadas
        Dim filas As Integer

        'Sentencia de inserción de SQL
        Dim consulta As String = "INSERT INTO TiposUsuario(tipo) VALUES(@tipo)"

        'Comprobamos que es válido el parámetro y lo añadimos
        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El tipo no puede estar vacío")
        Else
            comando.Parameters.Add("@tipo", SqlDbType.VarChar)
            comando.Parameters("@tipo").Value = tipo
        End If

        'Ejecutamos la sentencia y guardamos las filas afectadas en la variable
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

        'Devolvemos la variable
        Return filas
    End Function

 ¡
    Public Function SeleccionarTodosLosTipos() As DataTable
        'Consulta SQL
        Dim consulta As String = "SELECT * FROM TiposUsuarios"
        'Objeto que devolveremos
        Dim resultado As New DataTable
        'Lector de la consulta
        Dim lector As SqlDataReader

        'Ejecución de la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader

            'Carga del resultado
            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try

        Return resultado
    End Function
End Class
