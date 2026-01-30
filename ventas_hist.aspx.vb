
Partial Class ventas_hist
    Inherits System.Web.UI.Page
    Dim current_usu As New usuario
    Dim venta As New ventas

    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content_title.Text = "Historial de Ventas"
                dtg_ventasHistorial.Columns(0).HeaderText = "ID Venta"
                dtg_ventasHistorial.Columns(1).HeaderText = "Vendedor"
                dtg_ventasHistorial.Columns(2).HeaderText = "Fecha"
                dtg_ventasHistorial.Columns(3).HeaderText = "Estado"
                dtg_ventasHistorial.Columns(4).HeaderText = "Cant. Prods."
                dtg_ventasHistorial.Columns(5).HeaderText = "Total"
        End Select
    End Sub

    Private Sub ventas_hist_Load(sender As Object, e As EventArgs) Handles Me.Load
        current_usu = CType(Session("usuario"), usuario)
        Set_lang(current_usu.Idioma)
        venta.Grid(dtg_ventasHistorial)
    End Sub
End Class
