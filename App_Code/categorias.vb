Imports Microsoft.VisualBasic

Public Class categorias
    Dim con As New conexion
    Private pIdCategoria As Integer
    Private pNombre As String
    Private pDescripcion As String

    Public Property IdCategoria As String
        Get
            Return pIdCategoria
        End Get
        Set(value As String)
            pIdCategoria = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return pNombre
        End Get
        Set(value As String)
            pNombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return pDescripcion
        End Get
        Set(value As String)
            pDescripcion = value
        End Set
    End Property


    'METODOS

    Public Sub grid(dtgCat As DataGrid)
        con.SQL = "exec sp_CategoriaSelAll"
        con.Grid(dtgCat)
    End Sub

    Public Sub guardar()
        con.SQL = "exec sp_CategoriaAddUpd " & pIdCategoria & ",'" & pNombre & "','" & pDescripcion & "';"
        con.Ejecutar()
    End Sub

    Public Sub eliminar(IdCategoria As Integer)
        con.SQL = "exec sp_CategoriaDel " & IdCategoria
        con.Ejecutar()
    End Sub
    Public Sub combo(ddlCat As DropDownList)
        con.SQL = "exec sp_CategoriaSelAll"
        con.Combo(ddlCat, "Descripcion", "IdCategoria")
    End Sub

    Public Sub buscarId(IdCategoria As Integer)
        con.SQL = "exec sp_CategoriaSelID " & IdCategoria
        con.Llenar()
        llename(con)
    End Sub

    Private Sub llename(con As conexion)
        If Not con.Vacia Then
            pIdCategoria = con.VariableNombreDset("IdCategoria")
            pNombre = con.VariableNombreDset("Nombre")
            pDescripcion = con.VariableNombreDset("Descripcion")
        End If
    End Sub

End Class
