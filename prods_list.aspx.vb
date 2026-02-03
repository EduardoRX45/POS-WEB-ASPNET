
Imports System.Activities.Expressions

Partial Class prods_list
    Inherits System.Web.UI.Page
    Dim current_usu As New usuario
    Dim prod As New productos

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title.Text = "Lista de Productos"
                btn_newProd.Text = "Nuevo Producto"
                btn_reportProd.Text = "Reporte de Inventario"
                dtg_prods.Columns(0).HeaderText = "Imagen"
                dtg_prods.Columns(1).HeaderText = "Código Barras"
                dtg_prods.Columns(2).HeaderText = "Nombre"
                dtg_prods.Columns(3).HeaderText = "Marca"
                dtg_prods.Columns(4).HeaderText = "Descripción"
                dtg_prods.Columns(5).HeaderText = "Categoría"
                dtg_prods.Columns(6).HeaderText = "Stock"
                dtg_prods.Columns(7).HeaderText = "Costo"
                dtg_prods.Columns(8).HeaderText = "Precio"
                dtg_prods.Columns(9).HeaderText = "Acción"
        End Select
    End Sub

    Private Sub prods_list_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            prod.grid(dtg_prods)
        End If
    End Sub

    Private Sub btn_newProd_Click(sender As Object, e As EventArgs) Handles btn_newProd.Click
        Response.Redirect("prods_add.aspx")
    End Sub

    Sub btnRemove_Click(sender As Object, e As EventArgs)
        Dim btnRemove As Button = sender
        prod.eliminar(btnRemove.CommandArgument)
        prod.grid(dtg_prods)
    End Sub

    Sub btnEdit_Click(sender As Object, e As EventArgs)
        Dim btnEdit As Button = sender
        Dim IdProducto As Integer
        IdProducto = btnEdit.CommandArgument
        Response.Redirect("prods_edit.aspx?IdProducto=" & IdProducto)
    End Sub

    Private Sub btn_reportProd_Click(sender As Object, e As EventArgs) Handles btn_reportProd.Click
        Dim url = "prods_reporte_file.aspx"
        Dim script As String = "window.open('" & url & "', '_blank');"
        ClientScript.RegisterStartupScript(Me.GetType(), "Abrir", script, True)
        'Response.Redirect("prods_reporte_file.aspx")
    End Sub

End Class
