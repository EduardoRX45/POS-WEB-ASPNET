
Partial Class account
    Inherits System.Web.UI.Page
    Dim current_usu As New usuario
    Dim crypto As New cripto
    Dim savePath As String = Server.MapPath("~/img/users/")
    Public Sub Set_lang(lang As String)
        Select Case lang
            Case "esp"
                content1_title.Text = "Mis Datos"
                content2_title.Text = "Cambiar Contraseña"
                btn_save.Text = "Guardar Cambios"
                btn_saveContra.Text = "Guardar Contraseña"
                Label_nombre.Text = "Nombre(s)"
                Label_appat.Text = "Apellido Paterno"
                Label_apmat.Text = "Apellido Materno"
                Label_correo.Text = "Correo"
                Label_telf.Text = "Telefono"
                Label_img.Text = "Foto"
                Label_contra.Text = "Contraseña Actual"
                Label_newContra.Text = "Nueva Contraseña"
                Label_newContraConf.Text = "Confirmar Nueva Contraseña"
            Case "eng"
                content1_title.Text = "My Data"
                content2_title.Text = "Change Password"
                btn_save.Text = "Save Changes"
                btn_saveContra.Text = "Save Password"
                Label_nombre.Text = "Name(s)"
                Label_appat.Text = "Last Name"
                Label_apmat.Text = "Second Last Name"
                Label_correo.Text = "Email"
                Label_telf.Text = "Phone Number"
                Label_img.Text = "Photo"
                Label_contra.Text = "Current Password"
                Label_newContra.Text = "New Password"
                Label_newContraConf.Text = "Confirm New Password"
        End Select
    End Sub


    Private Sub account_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            current_usu = CType(Session("usuario"), usuario)
            Set_lang(current_usu.Idioma)
            user_img.ImageUrl = current_usu.FotoDir
            TextBox_nombre.Text = current_usu.Nombre
            TextBox_appat.Text = current_usu.ApellidoPat
            TextBox_apmat.Text = current_usu.ApellidoMat
            TextBox_correo.Text = current_usu.Correo
            TextBox_telf.Text = current_usu.Telefono
        Else
            current_usu = CType(Session("usuario"), usuario)
        End If

    End Sub

    Private Sub btn_saveContra_Click(sender As Object, e As EventArgs) Handles btn_saveContra.Click
        If crypto.Desencriptar(current_usu.Contra) = TextBox_contra.Text Then
            If TextBox_newContra.Text = TextBox_newContraConf.Text Then
                current_usu.Contra = crypto.Encriptar(TextBox_newContra.Text)
                current_usu.guardar()
                Label_contraMsg.Text = "Contraseñas actualizadas"
            Else
                Label_contraMsg.Text = "Las contraseñas no coinciden"
            End If
        Else
            Label_contraMsg.Text = "Contraseña Actual Incorrecta"
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        current_usu.Nombre = TextBox_nombre.Text
        current_usu.ApellidoPat = TextBox_appat.Text
        current_usu.ApellidoMat = TextBox_apmat.Text
        current_usu.Correo = TextBox_correo.Text
        current_usu.Telefono = TextBox_telf.Text
        current_usu.FotoDir = "~/img/users/" & current_usu.IdUsuario & ".jpg"
        If FileUpload_img.HasFile Then
            FileUpload_img.SaveAs(savePath & current_usu.IdUsuario & ".jpg")
        End If
        Label_accountMsg.Text = "Datos Actualizados"
        current_usu.guardar()
    End Sub
End Class
