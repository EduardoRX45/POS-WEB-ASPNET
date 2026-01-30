
Imports Microsoft.VisualBasic.ApplicationServices

Partial Class cat_list
    Inherits System.Web.UI.Page
    Dim cat As New categorias
    Dim current_usu As New usuario

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title.Text = "Lista de Categorias"
                btn_newCat.Text = "Nueva Categoria"
                dtg_cat.Columns(0).HeaderText = "Nombre"
                dtg_cat.Columns(1).HeaderText = "Descripcion"
                dtg_cat.Columns(2).HeaderText = "Accion"
        End Select
    End Sub

    Private Sub cat_list_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            cat.grid(dtg_cat)
        End If
    End Sub

    Private Sub btn_newCat_Click(sender As Object, e As EventArgs) Handles btn_newCat.Click
        Response.Redirect("cat_add.aspx")
    End Sub

    Sub btnRemove_Click(sender As Object, e As EventArgs)
        Dim btnRemove As Button = sender
        cat.eliminar(btnRemove.CommandArgument)
        cat.grid(dtg_cat)
    End Sub

    Sub btnEdit_Click(sender As Object, e As EventArgs)
        Dim btnEdit As Button = sender
        Dim IdCategoria As Integer
        IdCategoria = btnEdit.CommandArgument
        Response.Redirect("cat_edit.aspx?IdCategoria=" & IdCategoria)
    End Sub

End Class
