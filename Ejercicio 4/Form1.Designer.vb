<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCarga = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblCuil = New System.Windows.Forms.Label()
        Me.lblEstudios = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtEstudios = New System.Windows.Forms.TextBox()
        Me.txtCuil = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCarga
        '
        Me.btnCarga.Location = New System.Drawing.Point(108, 275)
        Me.btnCarga.Name = "btnCarga"
        Me.btnCarga.Size = New System.Drawing.Size(75, 23)
        Me.btnCarga.TabIndex = 5
        Me.btnCarga.Text = "Aceptar"
        Me.btnCarga.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(64, 33)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(64, 80)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 9
        Me.lblApellido.Text = "Apellido"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(64, 122)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(23, 13)
        Me.lblDni.TabIndex = 10
        Me.lblDni.Text = "Dni"
        '
        'lblCuil
        '
        Me.lblCuil.AutoSize = True
        Me.lblCuil.Location = New System.Drawing.Point(64, 162)
        Me.lblCuil.Name = "lblCuil"
        Me.lblCuil.Size = New System.Drawing.Size(24, 13)
        Me.lblCuil.TabIndex = 11
        Me.lblCuil.Text = "Cuil"
        '
        'lblEstudios
        '
        Me.lblEstudios.AutoSize = True
        Me.lblEstudios.Location = New System.Drawing.Point(64, 211)
        Me.lblEstudios.Name = "lblEstudios"
        Me.lblEstudios.Size = New System.Drawing.Size(102, 13)
        Me.lblEstudios.TabIndex = 12
        Me.lblEstudios.Text = "Estudios Realizados"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(193, 77)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 1
        '
        'txtEstudios
        '
        Me.txtEstudios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstudios.Location = New System.Drawing.Point(193, 211)
        Me.txtEstudios.Name = "txtEstudios"
        Me.txtEstudios.Size = New System.Drawing.Size(100, 20)
        Me.txtEstudios.TabIndex = 4
        '
        'txtCuil
        '
        Me.txtCuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuil.Location = New System.Drawing.Point(193, 162)
        Me.txtCuil.Name = "txtCuil"
        Me.txtCuil.Size = New System.Drawing.Size(100, 20)
        Me.txtCuil.TabIndex = 3
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(193, 122)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(193, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(238, 275)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(381, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 310)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.txtCuil)
        Me.Controls.Add(Me.txtEstudios)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblEstudios)
        Me.Controls.Add(Me.lblCuil)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnCarga)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCarga As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lblCuil As System.Windows.Forms.Label
    Friend WithEvents lblEstudios As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtEstudios As System.Windows.Forms.TextBox
    Friend WithEvents txtCuil As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
