
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Dim usu As New usuario

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                lb_dash.Text = "Panel Inicio"
                lb_services.Text = "Servicios"
                lb_inv.Text = "Inventario"
                lb_catList.Text = "Lista de Categorías"
                lb_prodList.Text = "Lista de Productos"
                lb_vent.Text = "Ventas"
                lb_newVent.Text = "Nueva Venta"
                lb_histVent.Text = "Historial de Ventas"
                lb_account.Text = "Mi Cuenta"
                lb_salir.Text = "Salir"
        End Select

    End Sub

    Private Sub MasterPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            usu = CType(Session("usuario"), usuario)
            If usu Is Nothing Then
                Response.Redirect("login.aspx")
            End If
            Set_lang("esp")
            user_name.Text = usu.Nombre
            user_img.ImageUrl = usu.FotoDir
            estiloCss.Href = "css/masterpage-dark.css"
        End If
    End Sub
End Class

