<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_respaldo
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
        Me.btn_Backup = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_importar = New System.Windows.Forms.Button()
        Me.txtBaseRestaurar = New System.Windows.Forms.TextBox()
        Me.txtRutaRestaurar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Backup
        '
        Me.btn_Backup.Location = New System.Drawing.Point(342, 25)
        Me.btn_Backup.Name = "btn_Backup"
        Me.btn_Backup.Size = New System.Drawing.Size(125, 33)
        Me.btn_Backup.TabIndex = 1
        Me.btn_Backup.Text = "Backup"
        Me.btn_Backup.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(147, 29)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(163, 23)
        Me.txt_nombre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre Base de Datos"
        '
        'btn_importar
        '
        Me.btn_importar.Location = New System.Drawing.Point(342, 117)
        Me.btn_importar.Name = "btn_importar"
        Me.btn_importar.Size = New System.Drawing.Size(121, 31)
        Me.btn_importar.TabIndex = 7
        Me.btn_importar.Text = "Restaurar"
        Me.btn_importar.UseVisualStyleBackColor = True
        '
        'txtBaseRestaurar
        '
        Me.txtBaseRestaurar.Location = New System.Drawing.Point(147, 105)
        Me.txtBaseRestaurar.Name = "txtBaseRestaurar"
        Me.txtBaseRestaurar.Size = New System.Drawing.Size(163, 23)
        Me.txtBaseRestaurar.TabIndex = 8
        '
        'txtRutaRestaurar
        '
        Me.txtRutaRestaurar.Location = New System.Drawing.Point(147, 139)
        Me.txtRutaRestaurar.Name = "txtRutaRestaurar"
        Me.txtRutaRestaurar.Size = New System.Drawing.Size(163, 23)
        Me.txtRutaRestaurar.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre Base de Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ruta de la Base de Datos"
        '
        'frm_respaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 180)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRutaRestaurar)
        Me.Controls.Add(Me.txtBaseRestaurar)
        Me.Controls.Add(Me.btn_importar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_Backup)
        Me.Name = "frm_respaldo"
        Me.Text = "Fotmulario Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Backup As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_importar As Button
    Friend WithEvents txtBaseRestaurar As TextBox
    Friend WithEvents txtRutaRestaurar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
