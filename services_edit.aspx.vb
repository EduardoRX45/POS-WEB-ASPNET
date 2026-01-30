
Partial Class services_edit
    Inherits System.Web.UI.Page
    Dim serv As New servicios
    Dim IdServicio As Integer
    Dim savePath As String = Server.MapPath("~/img/servicios/")

    Private Sub services_edit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            IdServicio = Request.QueryString("IdServicio")
            serv.buscarId(IdServicio)
            TextBox_nombre.Text = serv.Nombre
            TextBox_desc.Text = serv.Descripcion
            'serv_img.ImageUrl = serv.Imagen
        Else
            IdServicio = Request.QueryString("IdServicio")
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        serv.IdServicio = IdServicio
        serv.Nombre = TextBox_nombre.Text
        serv.Descripcion = TextBox_desc.Text
        serv.Imagen = "/img/servicios/" & IdServicio & ".jpg"
        'If FileUpload_imgServ.HasFiles Then
        '    FileUpload_imgServ.SaveAs(savePath & IdServicio & ".jpg")
        'End If
        serv.guardar()
        Response.Redirect("services_list.aspx")
    End Sub

End Class
