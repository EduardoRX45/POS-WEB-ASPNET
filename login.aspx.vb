Imports System.Activities.Expressions

Partial Class login
    Inherits System.Web.UI.Page
    Public lang As String
    Dim usu As New usuario

    Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                welcome_msg.Text = "Bienvenido"
                email.Attributes("placeholder") = "Correo Electronico"
                pass.Attributes("placeholder") = "Contraseña"
                btn_login.Text = "Ingresar"
                btn_fp.Text = "Registrar Usuario"
                btn_fp2.Text = "Olvido su Contraseña"
        End Select
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Set_lang("esp")
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        usu.buscar_login(email.Text, pass.Text)
        usu.Idioma = "esp"

        If usu.Contra = pass.Text Then
            Session("usuario") = usu
            Response.Redirect("dashboard.aspx")
        Else
            error_msg.Text = "Datos No Validos"
        End If
    End Sub
    Private Sub btn_fp_Click(sender As Object, e As EventArgs) Handles btn_fp.Click
        Response.Redirect("registro.aspx")
    End Sub

    Private Sub btn_fp2_Click(sender As Object, e As EventArgs) Handles btn_fp2.Click
        Response.Redirect("pass.aspx?Idioma=" & "esp")
    End Sub

    Private Sub btn_fp3_Click(sender As Object, e As EventArgs) Handles btn_fp3.Click
        Response.Redirect("home.aspx")
    End Sub

End Class
