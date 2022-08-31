Imports MySql.Data.MySqlClient

Public Class frm_crear_usuario
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_nombre.Text <> "" And txt_contraseña.Text <> "" Then
            Dim SSQL As String  'variable donde se guardara la consulta sql
            Dim TABLE As New DataTable 'variale para el manejo de tale
            CN.Close() 'se cierra porque la conexion queda abierta en el login
            SSQL = "INSERT INTO computec.tm_tusuarios"
            SSQL = SSQL + "(NOM_USUARIO, PAS_CLAVE, IND_ESTADO, PERFIL_USUARIO) "
            SSQL = SSQL + "VALUES ('" & txt_nombre.Text & "', '" & txt_contraseña.Text & "', "
            SSQL = SSQL + " '" & "V" & "', '" & txt_tipo.Text & "')"
            Dim adaptador As New MySqlDataAdapter(SSQL, CN)
            adaptador.Fill(TABLE)
            MsgBox("Registro Guardado con exito")
        Else
            MsgBox("Todos los campos deben estar completos")
        End If
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        Try
            CN.Close()
            Dim SSQL As String
            SSQL = "SELECT * FROM tm_tusuarios"
            Dim dapter As New MySqlDataAdapter(SSQL, CN)
            Dim tb_ver As New DataSet
            dapter.Fill(tb_ver, "tm_tusuarios")
            DataGridView1.DataSource = tb_ver.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Visible = False
        frm_menu.Show()

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class