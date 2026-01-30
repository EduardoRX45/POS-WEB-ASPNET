Imports Microsoft.VisualBasic
Imports System.Net
Imports System.Net.Mail

Public Class correo
    Private myCorreo As New MailMessage
    Private smtp As New SmtpClient

    Sub EnviarCorreo(Asunto As String, Destinatario As String, CuerpoMail As String)
        myCorreo.To.Clear()
        myCorreo.CC.Clear()
        myCorreo.To.Add(Destinatario)
        myCorreo.Subject = Asunto
        myCorreo.Body = CuerpoMail
        myCorreo.IsBodyHtml = True
        myCorreo.Priority = MailPriority.Normal
        myCorreo.From = New MailAddress("eduardorx450@gmail.com")

        'para ver en donde se va a mandar'
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.Host = "smtp.gmail.com"

        smtp.Credentials = New NetworkCredential("eduardorx450@gmail.com", "vwyu khhp kgep ssqq")
        smtp.Send(myCorreo)

    End Sub
End Class
