Imports MySql.Data.MySqlClient
Public Class frm_ingclientes
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_rut.Text <> "" And txt_nombre.Text <> "" And txt_email.Text <> "" And txt_fono.Text <> "" And txt_direccion.Text <> "" Then
            Dim SSQL As String  'variable donde se guardara la consulta sql
            Dim TABLE As New DataTable 'variale para el manejo de tale
            CN.Close() 'se cierra porque la conexion queda abierta en el login
            SSQL = "INSERT INTO computec.cliente "
            SSQL = SSQL + "(nombre_cliente, rut_cliente, email, telefono, direccion, ciudad, ind_estado) "
            SSQL = SSQL + "VALUES ('" & txt_nombre.Text & "', '" & txt_rut.Text & "', "
            SSQL = SSQL + " '" & txt_email.Text & "', '" & txt_fono.Text & "', '" & txt_direccion.Text & "', '" & txt_ciudad.Text & "', 'V')"
            Dim adaptador As New MySqlDataAdapter(SSQL, CN)
            adaptador.Fill(TABLE)
            MsgBox("Registro Guardado con exito")
        Else
            MsgBox("Todos los campos deben estar completos")
        End If
    End Sub


    Private Sub txt_rut_LostFocus(sender As Object, e As EventArgs) Handles txt_rut.LostFocus
        Dim SSQL As String
        Dim TABLE As New DataTable
        CN.Close()
        SSQL = "SELECT nombre_cliente, rut_cliente, email, telefono, direccion, ciudad, IND_ESTADO "
        SSQL = SSQL + "FROM cliente WHERE rut_cliente = '" & txt_rut.Text & "' AND IND_ESTADO = 'V'"
        Dim adaptador As New MySqlDataAdapter(SSQL, CN)
        adaptador.Fill(TABLE)
        If TABLE.Rows.Count <> 0 Then
            For Each fila In TABLE.Rows
                txt_nombre.Text = fila.Item(0)
                txt_rut.Text = fila.Item(1)
                txt_email.Text = fila.Item(2)
                txt_fono.Text = fila.Item(3)
                ' txt_direccion = fila.Item(4)
                ' txt_ciudad = fila.Item(5)
                'txt_estado = fila.Item(6)
            Next
        Else
            MsgBox("No existen registros validos para: " & txt_rut.Text)
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        MsgBox("Los datos fueron modificados para: " & txt_rut.Text)
    End Sub

    Private Sub txt_fono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        MsgBox("Los datos fueron ELIMINADO para: " & txt_rut.Text)
    End Sub
End Class