
Partial Class prods
    Inherits System.Web.UI.Page
    Dim prods As New productos

    Private Sub productos_Load(sender As Object, e As EventArgs) Handles Me.Load
        prods.repeater(repProductos)
    End Sub
End Class
