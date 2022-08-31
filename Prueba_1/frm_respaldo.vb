Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports MySql.Data.MySqlClient

Public Class frm_respaldo
    Private Sub btn_conectar_Click(sender As Object, e As EventArgs) Handles btn_Backup.Click
        Try
            'Verifica que exista la carpeta, en caso contrario la crea
            If Not Directory.Exists("c:\Backup") Then
                Directory.CreateDirectory("c:\Backup")
            End If

            Dim NombreBaseDatos As String = txt_nombre.Text & "[" & Format(Now.ToString("ddMMyyyy")) & "]" & "[" & Format(Now.ToString("HHmmss")) & "]" & ".sql"
            Dim cadena = "cmd.exe /k mysqldump -h localhost -u root -pforever " & txt_nombre.Text & " > c:\backup\" & NombreBaseDatos

            Shell(cadena)

            MessageBox.Show("Backup exitoso!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub btn_ruta_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub btn_importar_Click(sender As Object, e As EventArgs) Handles btn_importar.Click

        MessageBox.Show("Se cargo Exitosamente la Base de datos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start("cmd.exe /k mysqldump -S localhost -u root -pforever ""RESTORE DATABASE [" & txtBaseRestaurar.Text & "] FROM DISK = '" & txtRutaRestaurar.Text & "'""")

        'MessageBox.Show("Backup exitoso!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class