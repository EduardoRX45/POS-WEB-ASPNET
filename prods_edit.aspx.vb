
Imports System.Activities.Expressions

Partial Class prods_edit
    Inherits System.Web.UI.Page
    Dim IdProducto As Integer
    Dim current_usu As New usuario
    Dim prod As New productos
    Dim cat As New categorias
    Dim savePath As String = Server.MapPath("~/img/prods/")

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title.Text = "Editar Producto"
                Label_nombre.Text = "Nombre"
                Label_marca.Text = "Marca"
                Label_codbarr.Text = "Codigo de Barras"
                Label_desc.Text = "Descripción"
                Label_cat.Text = "Categoria"
                Label_stock.Text = "Stock"
                Label_precio.Text = "Precio"
                Label_costo.Text = "Costo"
                Label_img.Text = "Imagen"
                btn_save.Text = "Guardar"
                btn_cancel.Text = "Cerrar"
        End Select
    End Sub

    Private Sub prods_edit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            IdProducto = Request.QueryString("IdProducto")
            prod.buscarId(IdProducto)
            cat.combo(DropDownList_cat)
            prod_img.ImageUrl = prod.Imagen
            TextBox_nombre.Text = prod.Nombre
            TextBox_marca.Text = prod.Marca
            TextBox_codbarr.Text = prod.CodBarras
            TextBox_desc.Text = prod.Descripcion
            DropDownList_cat.SelectedValue = prod.IdCategoria
            TextBox_stock.Text = prod.Stock
            TextBox_costo.Text = prod.Costo
            TextBox_precio.Text = prod.Precio
        Else
            IdProducto = Request.QueryString("IdProducto")
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        prod.IdProducto = IdProducto
        prod.Nombre = TextBox_nombre.Text
        prod.Marca = TextBox_marca.Text
        prod.CodBarras = TextBox_codbarr.Text
        prod.Descripcion = TextBox_desc.Text
        prod.IdCategoria = DropDownList_cat.SelectedValue
        prod.Stock = TextBox_stock.Text
        prod.Costo = TextBox_costo.Text
        prod.Precio = TextBox_precio.Text
        prod.Imagen = "/img/prods/" & IdProducto & ".jpg"
        If FileUpload_imgProd.HasFiles Then
            FileUpload_imgProd.SaveAs(savePath & IdProducto & ".jpg")
        End If
        prod.guardar()
        Response.Redirect("prods_list.aspx")
    End Sub
End Class
