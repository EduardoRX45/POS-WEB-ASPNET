
Partial Class cat_edit
    Inherits System.Web.UI.Page
    Dim IdCategoria As Integer
    Dim current_usu As New usuario
    Dim cat As New categorias

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title.Text = "Editar Categoria"
                Label_nombre.Text = "Nombre"
                Label_desc.Text = "Descripción"
                btn_save.Text = "Guardar"
                btn_cancel.Text = "Cerrar"
        End Select
    End Sub

    Private Sub cat_edit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            IdCategoria = Request.QueryString("IdCategoria")
            cat.buscarId(IdCategoria)
            TextBox_nombre.Text = cat.Nombre
            TextBox_desc.Text = cat.Descripcion
        Else
            IdCategoria = Request.QueryString("IdCategoria")
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        cat.IdCategoria = IdCategoria
        cat.Nombre = TextBox_nombre.Text
        cat.Descripcion = TextBox_desc.Text
        Response.Redirect("cat_list.aspx")
        cat.guardar()
    End Sub
End Class
