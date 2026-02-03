
Partial Class ticket
    Inherits System.Web.UI.Page
    Dim tik As New ticket_file

    Private Sub ticket_Load(sender As Object, e As EventArgs) Handles Me.Load
        tik.buscarDV_ID(Convert.ToInt32(Request.QueryString("IdVenta")))
        Label_IDVenta.Text = "NumTicket: " & tik.IdVenta & "     "
        Label_vendedor.Text = "Vendedor: " & tik.Vendedor
        Label_total.Text = "Total: $" & tik.Total
        Label_fecha.Text = "Fecha: " & tik.Fecha.ToString("dd-MM-yyyy")
        Label_hora.Text = "Hora: " & tik.Hora
        tik.repeater(repDVProds)
    End Sub
End Class
