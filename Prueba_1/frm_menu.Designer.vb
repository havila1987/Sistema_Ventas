<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_bitacora = New System.Windows.Forms.Button()
        Me.btn_ayuda = New System.Windows.Forms.Button()
        Me.btn_usuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Mantenedor Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_backup
        '
        Me.btn_backup.Location = New System.Drawing.Point(36, 109)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(141, 40)
        Me.btn_backup.TabIndex = 1
        Me.btn_backup.Text = "Backup"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(36, 216)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(141, 27)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_bitacora
        '
        Me.btn_bitacora.Location = New System.Drawing.Point(36, 50)
        Me.btn_bitacora.Name = "btn_bitacora"
        Me.btn_bitacora.Size = New System.Drawing.Size(141, 40)
        Me.btn_bitacora.TabIndex = 4
        Me.btn_bitacora.Text = "Bitacora"
        Me.btn_bitacora.UseVisualStyleBackColor = True
        '
        'btn_ayuda
        '
        Me.btn_ayuda.Location = New System.Drawing.Point(36, 165)
        Me.btn_ayuda.Name = "btn_ayuda"
        Me.btn_ayuda.Size = New System.Drawing.Size(141, 34)
        Me.btn_ayuda.TabIndex = 5
        Me.btn_ayuda.Text = "Ayuda"
        Me.btn_ayuda.UseVisualStyleBackColor = True
        '
        'btn_usuario
        '
        Me.btn_usuario.Location = New System.Drawing.Point(215, 109)
        Me.btn_usuario.Name = "btn_usuario"
        Me.btn_usuario.Size = New System.Drawing.Size(140, 43)
        Me.btn_usuario.TabIndex = 6
        Me.btn_usuario.Text = "Mantenedor Usuarios"
        Me.btn_usuario.UseVisualStyleBackColor = True
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 258)
        Me.Controls.Add(Me.btn_usuario)
        Me.Controls.Add(Me.btn_ayuda)
        Me.Controls.Add(Me.btn_bitacora)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_menu"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btn_backup As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_bitacora As Button
    Friend WithEvents btn_ayuda As Button
    Friend WithEvents btn_usuario As Button
End Class
