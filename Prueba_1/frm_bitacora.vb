Imports MySql.Data.MySqlClient

Public Class frm_bitacora
    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        Try
            CN.Close()
            Dim SSQL As String
            SSQL = "SELECT * FROM acceso"
            Dim dapter As New MySqlDataAdapter(SSQL, CN)
            Dim tb_ver As New DataSet
            dapter.Fill(tb_ver, "acceso")
            DataGridView1.DataSource = tb_ver.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class