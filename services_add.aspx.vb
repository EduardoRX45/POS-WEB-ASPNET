
Partial Class services_add
    Inherits System.Web.UI.Page
    Dim servicio As New servicios

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        servicio.Nombre = TextBox_nombre.Text
        servicio.Descripcion = TextBox_desc.Text
        servicio.guardar()
        Response.Redirect("~/services_list.aspx")
    End Sub
End Class
