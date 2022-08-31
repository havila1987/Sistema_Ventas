Imports MySql.Data.MySqlClient
Module conexion
    Public CN As New MySqlConnection("server=localhost;user=root;password=;database=computec;port=3306")
    Public CMD As New MySqlCommand
    Public DR As MySqlDataReader
    Friend USUARIO, PASS, PRIVILEGIO As String
    Sub CONECT()
        Try
            CN.Open()
            'MsgBox("Conectado a Base de Datos", vbExclamation)
        Catch ex As Exception
            MsgBox("No es Posible Conectar a Base de Datos Verifique su Conexión a Internet o Dirijase al Administrador del Sistema", vbExclamation)
            End
        End Try
    End Sub
End Module
