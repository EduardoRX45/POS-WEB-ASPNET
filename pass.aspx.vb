
Partial Class pass
    Inherits System.Web.UI.Page
    Dim usu As New usuario
    Dim correo1 As New correo
    Dim cryp As New cripto
    Private contraDec As String

    Public Sub Change_lang(lang As String)
        Select Case lang
            Case "esp"
                title.Text = "Olvido su Contraseña?"
                msg.Text = "Ingrese su correo de Sesion y"
                msg2.Text = "le enviaremos su contraseña"
                email.Attributes("placeholder") = "Ingrese su correo"
                btn.Text = "Restablecer Contraseña"
                login_hl.Text = "Iniciar Sesion"
            Case "eng"
                title.Text = "Forgot your Password?"
                msg.Text = "Enter your login email and"
                msg2.Text = "we will send your password"
                email.Attributes("placeholder") = "Enter your email"
                btn.Text = "Reset Password"
                login_hl.Text = "Login"
        End Select
    End Sub

    Private Sub pass_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Change_lang(Request.QueryString("Idioma"))
        End If
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        usu.buscar_Contra(email.Text)
        If email.Text = usu.Correo Then
            correo1.EnviarCorreo("Contraseña", usu.Correo, "Tu contraseña es: " & cryp.Desencriptar(usu.Contra))
            msg_rp.Text = "Datos Enviados"
        Else
            msg_rp.Text = "Usuario no existe"
        End If
    End Sub
End Class
