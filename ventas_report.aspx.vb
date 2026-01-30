
Partial Class ventas_report

    Inherits System.Web.UI.Page

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Dim url = "ventas_reporte_file.aspx?Fecha1=" & TextBox_Fecha1.Text & "&Fecha2=" & TextBox_Fecha2.Text
        Dim script As String = "window.open('" & url & "', '_blank');"
        ClientScript.RegisterStartupScript(Me.GetType(), "Abrir", script, True)
        'Response.Redirect("ventas_reporte_file.aspx?Fecha1=" & TextBox_Fecha1.Text & "&Fecha2=" & TextBox_Fecha2.Text)
    End Sub
End Class
