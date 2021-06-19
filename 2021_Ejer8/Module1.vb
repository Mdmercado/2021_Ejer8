
Module Module1
    'Public Const CadCon As String = "Data Source=localhost\sqlexpress;Initial Catalog=Inmobiliaria;Integrated Security=True"
    Public CadCon As String
    Public IdLocalidadSelec As Integer
    Public IdClienteSelec As Integer
    Public IdUsuarioSelec As Integer
    Public Operacion As String
    Public UserLog As String
    Public UserLogGrupo As String
    Public informe As String



    'las siguientes variables las utilizaremos para determinar la localidad buscada (ver formulario de busqueda)
    Public IdLocalidadBus As Integer
    Public LocalidadBus As String
    Public sqlInformes As String




    Public Sub RecuperarSQL(ByVal sql As String, ByRef Tabla As DataTable)
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand

        conexion = New SqlClient.SqlConnection()
        conexion.ConnectionString = CadCon
        conexion.Open()
        comando = New SqlClient.SqlCommand()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        Tabla.Load(comando.ExecuteReader)
        conexion.Close()
    End Sub

    Public Sub EjecutarSQL(ByVal sql As String)
        Dim conexion As SqlClient.SqlConnection
        Dim comando As SqlClient.SqlCommand

        conexion = New SqlClient.SqlConnection()
        conexion.ConnectionString = CadCon
        conexion.Open()
        comando = New SqlClient.SqlCommand()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function TodosPermitidosSQL(ByVal cadena As String) As Boolean
        Dim todook As Boolean = True
        Dim nopermitidos() As String = {"%", "'"}

        For i = 0 To cadena.Length - 1
            For f = 0 To nopermitidos.GetLength(0) - 1
                If (cadena.Substring(i, 1) = nopermitidos(f)) Then
                    todook = False
                End If
            Next
        Next

        Return todook
    End Function

    Public Function GenerarHash256(Cadena As String)
        Dim AlgoritmoHash As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim inputBytes() As Byte
        Dim hashBytes() As Byte
        Dim Salida As String

        inputBytes = System.Text.Encoding.UTF8.GetBytes(Cadena)
        hashBytes = AlgoritmoHash.ComputeHash(inputBytes)

        Salida = ""
        For Each b In hashBytes
            Salida = Salida & b.ToString("x2")
        Next

        Return Salida
    End Function
End Module
