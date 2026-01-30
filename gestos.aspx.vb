Imports System.Diagnostics

Partial Class gestos
    Inherits System.Web.UI.Page

    Private Sub btn_com_Click(sender As Object, e As EventArgs) Handles btn_com.Click
        Dim proceso As New Process()
        proceso.StartInfo.FileName = "cmd.exe"
        proceso.StartInfo.Arguments = "/c " & "cd C:\Users\Windows\Documents\Uni\SysVaneM & py mouse.py"
        proceso.StartInfo.RedirectStandardOutput = True
        proceso.StartInfo.RedirectStandardError = True
        proceso.StartInfo.UseShellExecute = False
        proceso.StartInfo.CreateNoWindow = True
        proceso.Start()

    End Sub
End Class
