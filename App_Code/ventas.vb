Imports Microsoft.VisualBasic
Public Class ventas
    Private con As New conexion
    Private pIdVenta As String
    Private pIdUsuario As Integer
    Private pFecha As String
    Private pHora As String
    Private pEstado As String
    Private pCantProds As Integer
    Private pGranTotal As Single
    Private pGranBeneficios As Single

    Public Property IdVenta As String
        Get
            Return pIdVenta
        End Get
        Set(value As String)
            pIdVenta = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return pIdUsuario
        End Get
        Set(value As Integer)
            pIdUsuario = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return pFecha
        End Get
        Set(value As String)
            pFecha = value
        End Set
    End Property

    Public Property Hora As String
        Get
            Return pHora
        End Get
        Set(value As String)
            pHora = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return pEstado
        End Get
        Set(value As String)
            pEstado = value
        End Set
    End Property

    Public Property CantProds As Integer
        Get
            Return pCantProds
        End Get
        Set(value As Integer)
            pCantProds = value
        End Set
    End Property

    Public Property GranTotal As Single
        Get
            Return pGranTotal
        End Get
        Set(value As Single)
            pGranTotal = value
        End Set
    End Property

    Public Property GranBeneficios As Single
        Get
            Return pGranBeneficios
        End Get
        Set(value As Single)
            pGranBeneficios = value
        End Set
    End Property

    Public Sub NuevaVenta()
        con.SQL = "exec sp_VentasAdd " & pIdVenta & "," & pIdUsuario & ",'" & pFecha & "','" & pHora & "';"
        con.Ejecutar()
    End Sub

    Public Sub CancelarVenta(IdVenta As String)
        con.SQL = "exec sp_VentasCancel '" & IdVenta & "';"
        con.Ejecutar()
    End Sub

    Public Sub FinalizarVenta(IdVenta As String)
        con.SQL = "exec sp_VentasFinish '" & IdVenta & "'," & pCantProds & "," & pGranTotal & "," & pGranBeneficios & ";"
        con.Ejecutar()
    End Sub

    Public Sub Grid(dtgVentas As DataGrid)
        con.SQL = "EXEC sp_VentasGrid"
        con.Grid(dtgVentas)
    End Sub

    Private Sub llename(con As conexion)
        If Not con.Vacia Then
            pIdVenta = con.VariableNombreDset("IdVenta")
            pIdUsuario = con.VariableNombreDset("IdUsuario")
            pFecha = con.VariableNombreDset("Fecha")
            pEstado = con.VariableNombreDset("Estado")
            pGranTotal = con.VariableNombreDset("GranTotal")
            pGranBeneficios = con.VariableNombreDset("GranBeneficios")
        End If
    End Sub

End Class
