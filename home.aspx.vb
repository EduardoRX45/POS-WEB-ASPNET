
Partial Class home
    Inherits System.Web.UI.Page
    Dim serv As New servicios

    Private Sub home_Load(sender As Object, e As EventArgs) Handles Me.Load
        serv.repeater(repServicios)
    End Sub
End Class
