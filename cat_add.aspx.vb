
Partial Class cat_add
    Inherits System.Web.UI.Page
    Dim cat As New categorias
    Dim current_usu As New usuario

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title.Text = "Agregar Categoria"
                Label_nombre.Text = "Nombre"
                Label_desc.Text = "Descripción"
                btn_save.Text = "Guardar"
                btn_cancel.Text = "Cerrar"
        End Select
    End Sub

    Private Sub cat_add_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        cat.Nombre = TextBox_nombre.Text
        cat.Descripcion = TextBox_desc.Text
        cat.guardar()
        Response.Redirect("cat_list.aspx")
    End Sub

End Class
