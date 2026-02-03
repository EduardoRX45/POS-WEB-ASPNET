
Imports System.Activities.Expressions
Imports System.Data

Partial Class ventas_new
    Inherits System.Web.UI.Page
    Dim current_usu As New usuario
    Dim venta As New ventas
    Dim prods As New productos
    Dim detvent As New detalleventa
    Dim IdVenta As String
    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title1.Text = "Productos"
                dtg_prodsDetVent.Columns(0).HeaderText = "Accion"
                dtg_prodsDetVent.Columns(1).HeaderText = "Productos"
                dtg_prodsDetVent.Columns(2).HeaderText = "Cantidad"
                dtg_prodsDetVent.Columns(3).HeaderText = "Precio Unitario"
                dtg_prodsDetVent.Columns(4).HeaderText = "Total"
                content_title2.Text = "Detalles"
                Label_cantArt.Text = "Cantidad Prods: "
                Label_total.Text = "Gran Total: $"
                btn_conf.Text = "Terminar Venta"
                btn_cancel.Text = "Cancelar Venta"
        End Select
    End Sub

    Private Sub ventas_new_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            prods.combo(ddl_prods)
            Dim regDateTime As DateTime = DateTime.Now()
            'IdVenta = current_usu.IdUsuario & regDateTime.ToString("ddMMyy") & regDateTime.ToString("HHmmss")
            IdVenta = current_usu.IdUsuario & regDateTime.ToString("ddMM") & regDateTime.ToString("HHmm")
            Label_idVent.Text = IdVenta
            Label_cantArtNo.Text = "0"
            Label_totalNo.Text = "0"
            venta.IdVenta = IdVenta
            venta.IdUsuario = current_usu.IdUsuario
            venta.Fecha = regDateTime.ToString("yyyyMMdd")
            venta.Hora = regDateTime.ToString("HH:mm:ss")
            venta.NuevaVenta()
        Else
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            IdVenta = Label_idVent.Text
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Convert.ToInt32(TextBox_cant.Text) = 0 Then
            lb_checkMSG.Text = "Ingresa una Cantidad"
        Else
            prods.buscarId(ddl_prods.SelectedValue)
            If prods.StockAux = 0 Then
                lb_checkMSG.Text = "No hay Producto en Existencia"
            ElseIf Convert.ToInt32(TextBox_cant.Text) > prods.StockAux Then
                lb_checkMSG.Text = "Solo hay " & prods.StockAux & " en Existencia"
            Else
                detvent.IdVenta = IdVenta
                detvent.IdProducto = prods.IdProducto
                detvent.ProductNom = prods.Nombre
                detvent.Cantidad = TextBox_cant.Text
                detvent.PrecioUnit = prods.Precio
                detvent.Total = detvent.Cantidad * detvent.PrecioUnit
                detvent.Beneficios = detvent.Total - (detvent.Cantidad * prods.Costo)
                prods.StockAux = prods.StockAux - TextBox_cant.Text
                prods.restarStockAux()
                detvent.AgregarProdDV()
                detvent.Grid(IdVenta, dtg_prodsDetVent)
                Label_cantArtNo.Text = detvent.CantProdsTot(IdVenta)
                Label_totalNo.Text = detvent.TotalVenta(IdVenta)
            End If
        End If
    End Sub

    Sub btnRemove_Click(sender As Object, e As EventArgs)
        Dim btnRemove As Button = sender
        detvent.EliminarProdDV(IdVenta, btnRemove.CommandArgument)
        detvent.Grid(IdVenta, dtg_prodsDetVent)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        venta.CancelarVenta(IdVenta)
        prods.restaurarStockAux()
        Response.Redirect("dashboard.aspx")
    End Sub

    Private Sub btn_conf_Click(sender As Object, e As EventArgs) Handles btn_conf.Click
        Dim url As String = "ticket.aspx?IdVenta=" & IdVenta
        Dim dashboardUrl As String = "dashboard.aspx"
        Dim script As String = "window.open('" & url & "', '_blank'); window.location.href = '" & dashboardUrl & "';"
        If Convert.ToInt32(Label_cantArtNo.Text) >= 1 Then
            venta.CantProds = detvent.CantProdsTot(IdVenta)
            venta.GranTotal = detvent.TotalVenta(IdVenta)
            venta.GranBeneficios = detvent.TotalBeneficios(IdVenta)
            prods.actualizarStock()
            venta.FinalizarVenta(IdVenta)
            ClientScript.RegisterStartupScript(Me.GetType(), "Abrir", script, True)
        Else
            lb_checkMSG.Text = "No tienes productos agregados"
        End If
    End Sub
End Class
