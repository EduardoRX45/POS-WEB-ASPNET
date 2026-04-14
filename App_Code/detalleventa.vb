Imports Microsoft.VisualBasic

Public Class detalleventa
    Private con As New conexion
    Private pIdDetalleVenta As Integer
    Private pIdVenta As String
    Private pIdProducto As Integer
    Private pIdGUIDProducto As String
    Private pProductoNom As String
    Private pCantidad As Integer
    Private pPrecioUnit As Single
    Private pTotal As Single
    Private pBeneficios As Single

    Public Property IdDetalleVenta As Integer
        Get
            Return pIdDetalleVenta
        End Get
        Set(value As Integer)
            pIdDetalleVenta = value
        End Set
    End Property

    Public Property IdVenta As String
        Get
            Return pIdVenta
        End Get
        Set(value As String)
            pIdVenta = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return pIdProducto
        End Get
        Set(value As Integer)
            pIdProducto = value
        End Set
    End Property

    Public Property IdGUIDProducto As String
        Get
            Return pIdGUIDProducto
        End Get
        Set(value As String)
            pIdGUIDProducto = value
        End Set
    End Property

    Public Property ProductNom As String
        Get
            Return pProductoNom
        End Get
        Set(value As String)
            pProductoNom = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return pCantidad
        End Get
        Set(value As Integer)
            pCantidad = value
        End Set
    End Property

    Public Property PrecioUnit As Single
        Get
            Return pPrecioUnit
        End Get
        Set(value As Single)
            pPrecioUnit = value
        End Set
    End Property

    Public Property Total As Single
        Get
            Return pTotal
        End Get
        Set(value As Single)
            pTotal = value
        End Set
    End Property

    Public Property Beneficios As Single
        Get
            Return pBeneficios
        End Get
        Set(value As Single)
            pBeneficios = value
        End Set
    End Property

    Public Sub AgregarProdDV()
        con.SQL = "exec sp_DetVentAddProd '" & pIdVenta & "'," & pIdProducto & ",'" & pIdGUIDProducto & "','" & pProductoNom & "'," & pCantidad & "," & pPrecioUnit & "," & pTotal & "," & pBeneficios & ";"
        con.Ejecutar()
    End Sub

    Public Sub EliminarProdDV(IdVenta As String, IdGUIDProducto As String)
        con.SQL = "exec sp_DetVentDelProd '" & IdVenta & "','" & IdGUIDProducto & "';"
        con.Ejecutar()
    End Sub

    Public Sub Grid(IdVenta As String, dtgProdsDetVent As DataGrid)
        con.SQL = "SELECT * FROM DetalleVentas WHERE IdVenta = '" & IdVenta & "';"
        con.Grid(dtgProdsDetVent)
    End Sub

    Public Function CantProdsTot(IdVenta As String) As Integer
        con.SQL = "SELECT SUM(Cantidad) AS CantidadArt FROM DetalleVentas WHERE IdVenta = '" & IdVenta & "';"
        con.Llenar()
        If con.VariableNombreDset("CantidadArt") = "" Then
            Return 0
        Else
            Return con.VariableNombreDset("CantidadArt")
        End If
    End Function

    Public Function TotalVenta(IdVenta As String) As Single
        con.SQL = "SELECT SUM(Total) AS GranTotal FROM DetalleVentas WHERE IdVenta = '" & IdVenta & "';"
        con.Llenar()
        If con.VariableNombreDset("GranTotal") = "" Then
            Return 0
        Else
            Return con.VariableNombreDset("GranTotal")
        End If
    End Function

    Public Function TotalBeneficios(IdVenta As String) As Single
        con.SQL = "SELECT SUM(Beneficios) AS Beneficios FROM DetalleVentas WHERE IdVenta= '" & IdVenta & "';"
        con.Llenar()
        Return con.VariableNombreDset("Beneficios")
    End Function

End Class
