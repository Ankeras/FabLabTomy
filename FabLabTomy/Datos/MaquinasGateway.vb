Imports System.Data.SqlClient


''' <summary>
''' Clase que define un gateway para la tabla Maquinas
''' </summary>
Public Class MaquinasGateway

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


End Class
