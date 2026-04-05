
Imports System.Security.AccessControl

Partial Class dashboard
    Inherits System.Web.UI.Page
    Dim current_usu As New usuario
    Dim dash As New dash_info

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                total_sales.Text = "TOTAL DE VENTAS"
                total_revenue.Text = "TOTAL DE INGRESOS"
                total_prods.Text = "TOTAL DE PRODUCTOS"
                total_cat.Text = "TOTAL DE CATEGORIAS"
        End Select
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            dash.obtener_datos()
            total_sales_no.Text = dash.Ventas
            total_revenue_no.Text = "$" & dash.Ingresos
            total_prods_no.Text = dash.Productos
            total_cat_no.Text = dash.Categorias
        End If
    End Sub

End Class
