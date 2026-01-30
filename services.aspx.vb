
Partial Class services
    Inherits System.Web.UI.Page
    Dim serv As New servicios

    Private Sub services_Load(sender As Object, e As EventArgs) Handles Me.Load
        serv.repeater(repServicios)
    End Sub
End Class
