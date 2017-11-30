Imports System.Data.SqlClient


Module MaquinasGateway

    'cadena de conexion que se usará cada vex que se abra conexión
    Dim conexion As New SqlConnection(My.Settings.cadena)

End Module
