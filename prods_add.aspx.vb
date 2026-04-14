
Partial Class prods_add
    Inherits System.Web.UI.Page
    Dim current_usu As New usuario
    Dim prod As New productos
    Dim cat As New categorias
    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title.Text = "Nuevo Producto"
                Label_codbarr.Text = "Codigo de Barras"
                Label_nombre.Text = "Nombre"
                Label_marca.Text = "Marca"
                Label_desc.Text = "Descripción"
                Label_cat.Text = "Categoria"
                Label_stock.Text = "Stock"
                Label_costo.Text = "Costo"
                Label_precio.Text = "Precio"
                btn_save.Text = "Guardar"
                btn_cancel.Text = "Cerrar"
        End Select
    End Sub

    Private Sub prods_add_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            cat.combo(DropDownList_cat)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        prod.verificarExistencia(TextBox_nombre.Text, TextBox_codbarr.Text)
        If TextBox_stock.Text < 0 Or TextBox_costo.Text <= 0 Or TextBox_precio.Text <= 0 Then
            lb_checkMSG.Text = "Los campos deben ser mayores a 0"
        Else
            If TextBox_nombre.Text = prod.Nombre Or TextBox_codbarr.Text = prod.CodBarras Then
                lb_checkMSG.Text = "Ya hay un producto registrado con los mismos datos"
            Else
                guardarProd()
            End If
        End If
    End Sub

    Private Sub guardarProd()
        prod.Nombre = TextBox_nombre.Text
        prod.Marca = TextBox_marca.Text
        prod.CodBarras = TextBox_codbarr.Text
        prod.Descripcion = TextBox_desc.Text
        prod.IdCategoria = DropDownList_cat.SelectedValue
        prod.Stock = TextBox_stock.Text
        prod.Costo = TextBox_costo.Text
        prod.Precio = TextBox_precio.Text
        prod.guardar()
        Response.Redirect("prods_list.aspx")
    End Sub
End Class
