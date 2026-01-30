Imports Microsoft.VisualBasic

Public Class dash_info
    Private con As New conexion

    Private pVentas As Integer
    Private pIngresos As Single
    Private pProductos As Integer
    Private pCategorias As Integer

    Public Property Ventas As Integer
        Get
            Return pVentas
        End Get
        Set(value As Integer)
            pVentas = value
        End Set
    End Property

    Public Property Ingresos As String
        Get
            Return pIngresos
        End Get
        Set(value As String)
            pIngresos = value
        End Set
    End Property

    Public Property Productos As Integer
        Get
            Return pProductos
        End Get
        Set(value As Integer)
            pProductos = value
        End Set
    End Property

    Public Property Categorias As Integer
        Get
            Return pCategorias
        End Get
        Set(value As Integer)
            pCategorias = value
        End Set
    End Property

    Public Sub obtener_datos()
        con.SQL = "exec sp_dashboard"
        con.Llenar()
        llename(con)
    End Sub

    Private Sub llename(con As conexion)
        If Not con.Vacia Then
            pVentas = con.VariableNombreDset("Ventas")
            pIngresos = con.VariableNombreDset("Ingresos")
            pProductos = con.VariableNombreDset("Productos")
            pCategorias = con.VariableNombreDset("Categorias")
        End If
    End Sub


End Class
