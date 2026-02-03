
Partial Class prods_reporte_file
    Inherits System.Web.UI.Page
    Dim prods As New productos

    Private Sub prods_reporte_file_Load(sender As Object, e As EventArgs) Handles Me.Load
        prods.grid(dtg_prodsReport)
    End Sub
End Class
