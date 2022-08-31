Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txt_usuario.Text <> "" And txt_clave.Text <> "" Then
            Dim Pasw As String
            Pasw = txt_clave.Text
            Try
                CMD.Connection = CN
                CN.Open()
                CMD.CommandText = "SELECT COD_USUARIO, NOM_USUARIO, PAS_CLAVE, IND_ESTADO FROM computec.tm_tusuarios WHERE NOM_USUARIO = '" & txt_usuario.Text & "' AND PAS_CLAVE = '" & Pasw & "'"
                DR = CMD.ExecuteReader
                If DR.HasRows Then
                    USUARIO = txt_usuario.Text
                    Me.Visible = False
                    frm_menu.Show()
                Else
                    MessageBox.Show("Datos Invalidos", "Validacion")
                End If
            Catch ex As Exception
                MsgBox("Error de conexion a base de datos")
            End Try
        Else
            MessageBox.Show("Debe ingresar ambos datos", "Validacion")
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub
End Class
