Public Class Form1

    Dim Nombre, Apellido, Estudios As String
    Dim Cuil, Dni As Integer


    Private Sub btnCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarga.Click
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        Estudios = txtEstudios.Text
        Cuil = txtCuil.Text
        Dni = txtDni.Text
        
      

        If txtCuil.Text <> "" And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDni.Text <> "" And txtEstudios.Text <> "" Then
            MessageBox.Show("El usuario " + Nombre + " " + Apellido + " con DNI " + txtDni.Text & " con número de CUIL " & txtCuil.Text & " completó sus estudios de " & txtEstudios.Text)
        End If
        


        If txtCuil.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtDni.Text = "" Or txtEstudios.Text = "" Then
            MessageBox.Show(" Complete todos los datos pedidos por favor ")

        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtEstudios.Text = ""
        txtCuil.Text = ""
        txtDni.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
