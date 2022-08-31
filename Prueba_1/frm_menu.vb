Imports Mysqlx

Public Class frm_menu
	Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Form1.Hide()
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		frm_ingclientes.Show()
	End Sub

	Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
		frm_respaldo.Show()
	End Sub

	Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
		Me.Visible = False
		Form1.Show()

	End Sub

	Private Sub btn_bitacora_Click(sender As Object, e As EventArgs) Handles btn_bitacora.Click
		Me.Visible = False
		frm_bitacora.Show()
	End Sub

	Private Sub btn_usuario_Click(sender As Object, e As EventArgs) Handles btn_usuario.Click
		Me.Visible = False
		frm_crear_usuario.Show()
	End Sub


End Class