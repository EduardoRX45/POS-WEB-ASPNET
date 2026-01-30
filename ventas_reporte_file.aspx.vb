
Partial Class ventas_reporte_file
    Inherits System.Web.UI.Page
    Dim reporte As New reporte_venta

    Private Sub ventas_reporte_file_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim f1 As Date
        Dim f2 As Date
        f1 = Request.QueryString("Fecha1")
        f2 = Request.QueryString("Fecha2")
        Label1.Text = "Fecha de Inicio: " & f1.ToString("dd/MM/yyyy")
        Label2.Text = "Fecha de Fin: " & f2.ToString("dd/MM/yyyy")
        reporte.Fecha1 = f1.ToString("yyyy-MM-dd")
        reporte.Fecha2 = f2.ToString("yyyy-MM-dd")
        reporte.generar(dtg_repvent)
        reporte.datosReporte()
        Label3.Text = "Producto más Vendido: " & reporte.ProductoMV
        Label4.Text = "Vendedor con más Ventas: " & reporte.VendedorMV
        Label5.Text = "Total de Ingresos: $" & reporte.Ingresos
        Label6.Text = "Total de Beneficios $" & reporte.Beneficios
    End Sub
End Class
