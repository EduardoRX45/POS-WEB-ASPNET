
Partial Class registro
    Inherits System.Web.UI.Page
    Dim usu As New usuario
    Dim crypto As New cripto

    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        usu.buscar_Correo(email.Text)
        Dim correoExistente As String = usu.Correo
        If email.Text = usu.Correo Then
            mensaje.Text = "Correo ya registrado"
        Else
            If pass.Text.Length >= 8 Then
                usu.Nombre = TextBox1.Text
                usu.ApellidoPat = TextBox2.Text
                usu.ApellidoMat = TextBox3.Text
                usu.Telefono = 0
                usu.Correo = email.Text
                usu.Contra = crypto.Encriptar(pass.Text)
                usu.guardar()
                mensaje.Text = "Usuario Registrado con Exito"
            Else
                mensaje.Text = "La contraseña debe tener 8 o mas digitos"
            End If
        End If
    End Sub

    Private Sub btn_link_Click(sender As Object, e As EventArgs) Handles btn_link.Click
        Response.Redirect("login.aspx")
    End Sub
End Class
