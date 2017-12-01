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

    ''' <summary>
    ''' Método para insertar un registro(máquina) en la tabla Máquinas de la base de datos
    ''' </summary>
    ''' <param name="modelo">Modelo de la máquina</param>
    ''' <param name="precioHora">Precio por hora de alquiler</param>
    ''' <param name="fechaCompra">Fecha de la compra de la máquina</param>
    ''' <param name="telefonoSAT">Teléfono de Servicio de Atención Técnica</param>
    ''' <param name="tipo">Entero que indica el tipo de máquina</param>
    ''' <param name="descripcion">Descripción de la máquina</param>
    ''' <param name="caracteristicas">Características técnicas</param>
    ''' <returns></returns>
    Public Function Insertar(modelo As String, precioHora As Decimal, fechaCompra As DateTime,
                             telefonoSAT As String, tipo As Integer, descripcion As String,
                             caracteristicas As String) As Integer
        'Variable que devolveremos indicando el número de filas afectadas
        Dim filas As Integer

        'Sentencia de inserción de SQL
        Dim consulta As String = "INSERT INTO Maquinas(modelo,precio_hora,fecha_compra,telefono_sat" &
            ",tipo,descripcion,caracteristicas) VALUES(@modelo,@precioHora,@fechaCompra,@telefonoSAT," &
            "@tipo,@descripcion,@caracteristicas)"

        'Filtramos los parámetros y en caso de nulos o vacíos lanzamos excepción si procede, si tienen valor lo asignamos
        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        Else
            comando.Parameters.Add("@modelo", SqlDbType.VarChar)
            comando.Parameters("@modelo").Value = modelo
        End If

        If precioHora <= 0 Then
            Throw New ArgumentException("El precio por hora no puede estar vacío o ser menor que 0")
        Else
            comando.Parameters.Add("@precioHora", SqlDbType.Money)
            comando.Parameters("@precioHora").Value = precioHora
        End If

        If fechaCompra = DateTime.MinValue Then
            Throw New ArgumentException("La fecha de compra no puede estar vacía")
        Else
            comando.Parameters.Add("@fechaCompra", SqlDbType.Date)
            comando.Parameters("@fechaCompra").Value = fechaCompra
        End If

        comando.Parameters.Add("@telefonoSAT", SqlDbType.VarChar)
        If telefonoSAT = "" Or telefonoSAT Is Nothing Then
            comando.Parameters("@telefonoSAT").Value = DBNull.Value
        Else
            comando.Parameters("@telefonoSAT").Value = telefonoSAT
        End If

        If tipo < 1 Then
            Throw New ArgumentException("Se debe especificar un tipo")
        Else
            comando.Parameters.Add("@tipo", SqlDbType.Int)
            comando.Parameters("@tipo").Value = tipo
        End If

        comando.Parameters.Add("@descripcion", SqlDbType.Text)
        If descripcion = "" Or descripcion Is Nothing Then
            comando.Parameters("@descripcion").Value = DBNull.Value
        Else
            comando.Parameters("@descripcion").Value = descripcion
        End If

        comando.Parameters.Add("@caracteristicas", SqlDbType.Text)
        If caracteristicas = "" Or caracteristicas Is Nothing Then
            comando.Parameters("@caracteristicas").Value = DBNull.Value
        Else
            comando.Parameters("@caracteristicas").Value = caracteristicas
        End If

        'Ejecución de la consulta
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

        'Devolvemos la variable
        Return filas
    End Function

End Class
