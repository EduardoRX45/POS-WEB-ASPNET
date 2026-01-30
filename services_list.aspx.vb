Imports System.Activities.Expressions

Partial Class services_list
    Inherits System.Web.UI.Page
    Dim servs As New servicios

    Private Sub services_list_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            servs.grid(dtg_serv)
        End If
    End Sub

    Sub btnRemove_Click(sender As Object, e As EventArgs)
        Dim btnRemove As Button = sender
        servs.eliminar(btnRemove.CommandArgument)
        servs.grid(dtg_serv)
    End Sub

    Sub btnEdit_Click(sender As Object, e As EventArgs)
        Dim btnEdit As Button = sender
        Dim IdServicio As Integer
        IdServicio = btnEdit.CommandArgument
        Response.Redirect("services_edit.aspx?IdServicio=" & IdServicio)
    End Sub

    Private Sub btn_newServ_Click(sender As Object, e As EventArgs) Handles btn_newServ.Click
        Response.Redirect("services_add.aspx")
    End Sub
End Class
