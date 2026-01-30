Imports Microsoft.VisualBasic

Public Class reporte_venta
    Private con As New conexion
    Private pFecha1 As String
    Private pFecha2 As String
    Private pProductoMV As String
    Private pVendedorMV As String
    Private pIngresos As Single
    Private pBeneficios As Single


    Public Property Fecha1 As String
        Get
            Return pFecha1
        End Get
        Set(value As String)
            pFecha1 = value
        End Set
    End Property

    Public Property Fecha2 As String
        Get
            Return pFecha2
        End Get
        Set(value As String)
            pFecha2 = value
        End Set
    End Property

    Public Property ProductoMV As String
        Get
            Return pProductoMV
        End Get
        Set(value As String)
            pProductoMV = value
        End Set
    End Property

    Public Property VendedorMV As String
        Get
            Return pVendedorMV
        End Get
        Set(value As String)
            pVendedorMV = value
        End Set
    End Property

    Public Property Ingresos As Single
        Get
            Return pIngresos
        End Get
        Set(value As Single)
            pIngresos = value
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

    Public Sub generar(dtgRepVent As DataGrid)
        con.SQL = "exec sp_VentasReporteFecha '" & pFecha1 & "','" & pFecha2 & "';"
        con.Grid(dtgRepVent)
    End Sub

    Public Sub datosReporte()
        con.SQL = "exec sp_VentasReporteDatosFecha2 '" & pFecha1 & "','" & pFecha2 & "';"
        con.Llenar()
        llename(con)
    End Sub

    Private Sub llename(con As conexion)
        If Not con.Vacia Then
            pIngresos = con.VariableNombreDset("Ingresos")
            pBeneficios = con.VariableNombreDset("Beneficios")
            pVendedorMV = con.VariableNombreDset("UsuarioMasVentas")
            pProductoMV = con.VariableNombreDset("ProductoMasVendido")
        End If
    End Sub

End Class
