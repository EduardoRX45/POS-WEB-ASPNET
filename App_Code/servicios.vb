Imports Microsoft.VisualBasic

Public Class servicios
    Private con As New conexion
    Private pIdServicio As Integer
    Private pNombre As String
    Private pDescripcion As String
    Private pImagen As String

    Public Property IdServicio As String
        Get
            Return pIdServicio
        End Get
        Set(value As String)
            pIdServicio = value
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

    Public Property Imagen As String
        Get
            Return pImagen
        End Get
        Set(value As String)
            pImagen = value
        End Set
    End Property

    'METODOS

    'GUARDAR NUEVO O ACTUALIZAR SERVICIO
    Public Sub guardar()
        con.SQL = "exec sp_ServiciosAddUpd " & pIdServicio & ",'" & pNombre & "','" & pDescripcion & "','" & pImagen & "';"
        con.Ejecutar()
    End Sub

    'ELIMINAR SERVICIO
    Public Sub eliminar(IdServicio As Integer)
        con.SQL = "exec sp_ServiciosDel " & IdServicio
        con.Ejecutar()
    End Sub

    'BUSCAR POR ID
    Public Sub buscarId(IdServicio As Integer)
        con.SQL = "exec sp_ServiciosSelID " & IdServicio
        con.Llenar()
        llename(con)
    End Sub

    'Llenar DataGrid
    Public Sub grid(dtgServicios As DataGrid)
        con.SQL = "exec sp_ServiciosSelAll"
        con.Grid(dtgServicios)
    End Sub

    'Repeater
    Public Sub repeater(repServ As Repeater)
        con.SQL = "exec sp_ServiciosSelAll"
        con.repeater(repServ)
    End Sub

    Public Sub llename(con As conexion)
        pIdServicio = con.VariableNombreDset("IdServicio")
        pNombre = con.VariableNombreDset("Nombre")
        pDescripcion = con.VariableNombreDset("Descripcion")
        pImagen = con.VariableNombreDset("Imagen")
    End Sub

End Class
