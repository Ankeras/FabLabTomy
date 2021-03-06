﻿Imports System.Data.SqlClient


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
    ''' <returns>Número de filas cambiadas al ejecutar la consulta</returns>
    Public Function Insertar(modelo As String, precioHora As Decimal, fechaCompra As DateTime,
                             telefonoSAT As String, tipo As Integer, descripcion As String,
                             caracteristicas As String) As Integer
        'Variable que devolveremos indicando el número de filas afectadas
        Dim filas As Integer

        'Filtro primero que no se repita con los datos de otra máquina
        If FiltrarNuevaMaquina(modelo, fechaCompra) <> 0 Then
            Throw New ArgumentException("El modelo y la fecha no pueden coincidir con los de otra máquina")
        Else
            'Sentencia de inserción de SQL
            Dim consulta As String = "INSERT INTO Maquinas(modelo,precio_hora,fecha_compra,telefono_sat" &
            ",tipo,descripcion,caracteristicas) VALUES(@modelo,@precioHora,@fechaCompra,@telefonoSAT," &
            "@tipo,@descripcion,@caracteristicas)"

            'Filtro primero que los valores no sean nulos o no válidos y los añado a los parámetros
            If precioHora <= 0 Then
                Throw New ArgumentException("El precio por hora no puede estar vacío o ser menor que 0")
            Else
                comando.Parameters.Add("@precioHora", SqlDbType.Money)
                comando.Parameters("@precioHora").Value = precioHora
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
        End If
        'Devolvemos la variable
        Return filas
    End Function

    ''' <summary>
    ''' Método para actualizar un registro de la tabla Maquinas de la base de datos
    ''' </summary>
    ''' <param name="modelo">Modelo de la máquina</param>
    ''' <param name="precioHora">Precio por hora de alquiler</param>
    ''' <param name="fechaCompra">Fecha de la compra de la máquina</param>
    ''' <param name="telefonoSAT">Teléfono de Servicio de Atención Técnica</param>
    ''' <param name="tipo">Entero que indica el tipo de máquina</param>
    ''' <param name="descripcion">Descripción de la máquina</param>
    ''' <param name="caracteristicas">Características técnicas</param>
    ''' <param name="id">Id del registro que se va a actualizar</param>
    ''' <returns>Número de filas cambiadas al ejecutar la consulta</returns>
    Public Function Actualizar(modelo As String, precioHora As Decimal, fechaCompra As DateTime,
                             telefonoSAT As String, tipo As Integer, descripcion As String,
                             caracteristicas As String, id As Integer) As Integer
        'Variable que devolveremos indicando el número de filas afectadas
        Dim filas As Integer

        'Filtro que no coincida con los datos de otra máquina
        If FiltrarNuevaMaquina(modelo, fechaCompra) <> 1 Then
            Throw New ArgumentException("El modelo y la fecha no pueden coincidir con los de otra máquina")
        Else

            'Consulta SQL a ejecutar
            Dim consulta As String = "UPDATE Maquinas SET modelo=@modelo,precio_hora=@precioHora,fecha_compra=@fechaCompra," &
            "telefono_sat=@telefonoSAT,tipo=@tipo,descripcion=@descripcion,caracteristicas=@caracteristicas WHERE id=@id"


            'Filtramos los parámetros y en caso de nulos o vacíos lanzamos excepción si procede, si tienen valor lo asignamos
            If precioHora <= 0 Then
                Throw New ArgumentException("El precio por hora no puede estar vacío o ser menor que 0")
            Else
                comando.Parameters.Add("@precioHora", SqlDbType.Money)
                comando.Parameters("@precioHora").Value = precioHora
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

            If id <= 0 Then
                Throw New ArgumentException("El id no puede ser menor que 1")
            Else
                comando.Parameters.Add("@id", SqlDbType.Int)
                comando.Parameters("@id").Value = id
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
        End If
        'Devolvemos la variable
        Return filas
    End Function

    ''' <summary>
    ''' Método para eliminar un registro de la tabla Maquinas de la base de datos
    ''' </summary>
    ''' <param name="id">Id del registro que se va a eliminar</param>
    ''' <returns>Filas afectadas al ejecutar la consulta</returns>
    Public Function Eliminar(id As Integer) As Integer
        'Variable que devolveremos indicando el número de filas afectadas
        Dim filas As Integer

        'Consulta SQL a ejecutar
        Dim consulta As String = "DELETE FROM Maquinas WHERE id=@id"

        'Compruebo que el id no es 0 o menor y lo añado a los parámetros
        If id <= 0 Then
            Throw New ArgumentException("El id no puede ser menor que 1")
        Else
            comando.Parameters.Add("@id", SqlDbType.Int)
            comando.Parameters("@id").Value = id
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

    ''' <summary>
    ''' Método para seleccionar todos los campos de la tabla Maquinas
    ''' </summary>
    ''' <returns>Devuelve los datos de la tabla en un objeto DataTable</returns>
    Public Function SeleccionarTodasLasMaquinas() As DataTable
        'Consulta SQL
        Dim consulta As String = "SELECT * FROM Maquinas"
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

    ''' <summary>
    ''' Método para seleccionar un registro de la tabla Máquinas
    ''' </summary>
    ''' <param name="id">id de la máquina que se desea mostrar</param>
    ''' <returns>Devuelve los datos de la máquina seleccionada</returns>
    Public Function SeleccionarMaquinaPorId(id As Integer) As DataTable
        'Consulta SQL
        Dim consulta As String = "SELECT * FROM Maquinas WHERE id=@id"

        'Validación del id
        If id <= 0 Then
            Throw New ArgumentException("El id no puede ser menor que 1")
        Else
            comando.Parameters.Add("@id", SqlDbType.Int)
            comando.Parameters("@id").Value = id
        End If

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

    ''' <summary>
    ''' Método que comprueba cuántos registros hay con el modelo y la fecha dadas
    ''' </summary>
    ''' <param name="modelo">modelo de la máquina</param>
    ''' <param name="fechaCompra">fecha de compra de la máquina</param>
    ''' <returns>Devuelve el número de máquinas con el mismo nombre y la misma fecha</returns>
    Public Function FiltrarNuevaMaquina(modelo As String, fechaCompra As DateTime) As Integer
        'Consulta SQL
        Dim consulta As String = "SELECT COUNT(*) FROM Maquinas WHERE modelo = '@modelo' AND fecha_compra = @fechaCompra"
        'Variable que devolveremos
        Dim resultado As Integer = -1

        'Filtro que sean válidos los datos pasados y asigno los parámetros
        If fechaCompra = DateTime.MinValue Then
            Throw New ArgumentException("La fecha de compra no puede estar vacía")
        Else
            comando.Parameters.Add("@fechaCompra", SqlDbType.Date)
            comando.Parameters("@fechaCompra").Value = fechaCompra
        End If

        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        Else
            comando.Parameters.Add("@modelo", SqlDbType.VarChar)
            comando.Parameters("@modelo").Value = modelo
        End If

        comando.CommandText = consulta

        'Ejecución de la consulta
        Try
            conexion.Open()
            resultado = CInt(comando.ExecuteScalar)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try

        'Devuelve el número
        Return resultado
    End Function
End Class
