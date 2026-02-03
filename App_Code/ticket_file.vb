Imports System.Drawing
Imports System.Runtime.InteropServices.WindowsRuntime
Imports Microsoft.VisualBasic

Public Class ticket_file
    Private con As New conexion
    Private pIdVenta As Integer
    Private pVendedor As String
    Private pTotal As Double
    Private pFecha As Date
    Private pHora As String

    Public Property IdVenta As Integer
        Get
            Return pIdVenta
        End Get
        Set(value As Integer)
            pIdVenta = value
        End Set
    End Property

    Public Property Vendedor As String
        Get
            Return pVendedor
        End Get
        Set(value As String)
            pVendedor = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return pTotal
        End Get
        Set(value As Double)
            pTotal = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return pFecha
        End Get
        Set(value As Date)
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


    Public Sub buscarDV_ID(IdVenta As String)
        con.SQL = "exec sp_TicketDatos " & IdVenta
        con.Llenar()
        llename(con)
    End Sub

    Public Sub repeater(repDVProds As Repeater)
        con.SQL = "exec sp_TicketProds " & pIdVenta
        con.repeater(repDVProds)
    End Sub

    Private Sub llename(con As conexion)
        If Not con.Vacia Then
            pIdVenta = con.VariableNombreDset("IdVenta")
            pVendedor = con.VariableNombreDset("Vendedor")
            pTotal = con.VariableNombreDset("Total")
            pFecha = con.VariableNombreDset("Fecha")
            pHora = con.VariableNombreDset("Hora")
        End If
    End Sub

End Class
