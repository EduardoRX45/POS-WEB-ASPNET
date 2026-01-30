
Partial Class registro
    Inherits System.Web.UI.Page
    Dim usu As New usuario

    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        usu.Nombre = TextBox1.Text
        usu.ApellidoPat = TextBox2.Text
        usu.ApellidoMat = TextBox3.Text
        usu.Telefono = TextBox4.Text
        usu.Correo = email.Text
        usu.Contra = pass.Text
        usu.guardar()
        mensaje.Text = "Usuario Registrado con Exito"
    End Sub

    Private Sub btn_link_Click(sender As Object, e As EventArgs) Handles btn_link.Click
        Response.Redirect("login.aspx")
    End Sub
End Class
