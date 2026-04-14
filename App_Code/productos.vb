Imports Microsoft.VisualBasic

Public Class productos
    Private con As New conexion

    Private pIdProducto As Integer
    Private pNombre As String
    Private pMarca As String
    Private pCodBarras As String
    Private pDescripcion As String
    Private pStock As Integer
    Private pStockAux As Integer
    Private pCosto As Single
    Private pPrecio As Single
    Private pImagen As String
    Private pIdCategoria As Integer
    Private pExiste As Boolean

    Public Property IdProducto As Integer
        Get
            Return pIdProducto
        End Get
        Set(value As Integer)
            pIdProducto = value
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

    Public Property Marca As String
        Get
            Return pMarca
        End Get
        Set(value As String)
            pMarca = value
        End Set
    End Property

    Public Property CodBarras As String
        Get
            Return pCodBarras
        End Get
        Set(value As String)
            pCodBarras = value
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

    Public Property Stock As Integer
        Get
            Return pStock
        End Get
        Set(value As Integer)
            pStock = value
        End Set
    End Property

    Public Property StockAux As Integer
        Get
            Return pStockAux
        End Get
        Set(value As Integer)
            pStockAux = value
        End Set
    End Property

    Public Property Costo As Single
        Get
            Return pCosto
        End Get
        Set(value As Single)
            pCosto = value
        End Set
    End Property

    Public Property Precio As Single
        Get
            Return pPrecio
        End Get
        Set(value As Single)
            pPrecio = value
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

    Public Property IdCategoria As Integer
        Get
            Return pIdCategoria
        End Get
        Set(value As Integer)
            pIdCategoria = value
        End Set
    End Property


    'METODOS

    Public Sub grid(dtgProds As DataGrid)
        con.SQL = "exec sp_ProductoList"
        con.Grid(dtgProds)
    End Sub

    Public Sub eliminar(IdProducto As Integer)
        con.SQL = "exec sp_ProductoDelID " & IdProducto
        con.Ejecutar()
    End Sub

    Public Sub buscarId(IdProducto As Integer)
        con.SQL = "exec sp_ProductoSelID " & IdProducto
        con.Llenar()
        llename(con)
    End Sub

    Public Sub restarStockAux()
        con.SQL = "exec sp_ProductoUpdStockAux " & pIdProducto & ", " & pStockAux
        con.Ejecutar()
    End Sub

    Public Sub restaurarStockAux()
        con.SQL = "exec sp_ProductoRestoreStockAux"
        con.Ejecutar()

    End Sub

    Public Sub actualizarStock()
        con.SQL = "exec sp_ProductoUpdStock"
        con.Ejecutar()
    End Sub

    Public Sub verificarExistencia(Nombre As String, CodBarr As String)
        con.SQL = "exec sp_ProductoExiste '" & Nombre & "','" & CodBarr & "';"
        con.Llenar()
        llename(con)
    End Sub

    Public Sub guardar()
        con.SQL = "exec sp_ProductoAddUpd " & pIdProducto & ",'" & pNombre & "','" & pMarca & "','" & pCodBarras & "','" & pDescripcion & "'," & pStock & "," & pCosto & "," & pPrecio & ",'" & pImagen & "'," & pIdCategoria & ";"
        con.Ejecutar()
    End Sub

    Public Sub combo(ddlProds As DropDownList)
        con.SQL = "exec sp_ProductoSelAll"
        con.Combo(ddlProds, "Nombre", "IdProducto")
    End Sub

    Public Sub repeater(repProds As Repeater)
        con.SQL = "exec sp_ProductoSelAll"
        con.repeater(repProds)
    End Sub



    Private Sub llename(con As conexion)
        If Not con.Vacia Then
            pIdProducto = con.VariableNombreDset("IdProducto")
            pNombre = con.VariableNombreDset("Nombre")
            pMarca = con.VariableNombreDset("Marca")
            pCodBarras = con.VariableNombreDset("CodBarras")
            pDescripcion = con.VariableNombreDset("Descripcion")
            pStock = con.VariableNombreDset("Stock")
            pStockAux = con.VariableNombreDset("StockAux")
            pCosto = con.VariableNombreDset("Costo")
            pPrecio = con.VariableNombreDset("Precio")
            pImagen = con.VariableNombreDset("Imagen")
            pIdCategoria = con.VariableNombreDset("IdCategoria")
        End If
    End Sub


End Class
