Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class conexion
    Private pBase As SqlConnection
    Private pComand As SqlCommand
    Private pAdapter As SqlDataAdapter
    Private pTabla As New DataSet

    Private pConstring As String
    Private pSQL As String
    Private pVacia As Boolean

    Public Property Vacia As Boolean
        Get
            Return pVacia
        End Get
        Set(value As Boolean)
            pVacia = value
        End Set
    End Property

    Public Property SQL As String
        Get
            Return pSQL
        End Get
        Set(value As String)
            pSQL = value
        End Set
    End Property

    Public Sub New()
        pConstring = "Initial Catalog=Cardoso; Data Source=.; UID=sa; pwd=root"
    End Sub

    Public Sub Ejecutar()
        pBase = New SqlConnection(pConstring)
        pComand = New SqlCommand(pSQL, pBase)
        pComand.CommandTimeout = 10000
        pComand.Connection.Open()
        pComand.ExecuteNonQuery()
    End Sub

    Public Sub Llenar()
        Try
            pTabla = New DataSet
            pBase = New SqlConnection(pConstring)
            pComand = New SqlCommand(pSQL, pBase)
            pComand.CommandTimeout = 10000
            pAdapter = New SqlDataAdapter(pComand)
            pAdapter.Fill(pTabla)
            If pTabla.Tables(0).Rows.Count = 0 Then pVacia = True Else pVacia = False
            pAdapter.Dispose()
            pBase.Close()
            pBase.Dispose()
        Catch ex As Exception
            pVacia = True
        End Try
    End Sub

    Public Function VariableNombreDset(ByVal Nombre As String) As String
        Dim Variable As String = ""
        If pTabla.Tables(0).Rows.Count > 0 Then
            If Not pTabla.Tables(0).Rows(0).IsNull(Nombre) Then
                Variable = pTabla.Tables(0).Rows(0).Item(Nombre).ToString
            Else
                Variable = ""
            End If
        End If
        Return Variable
    End Function

    Public Sub Combo(ddlDropDown As DropDownList, Texto As String, valor As String)
        Llenar()
        ddlDropDown.DataSource = pTabla.Tables(0).DefaultView
        ddlDropDown.DataTextField = Texto
        ddlDropDown.DataValueField = valor
        ddlDropDown.DataBind()
    End Sub

    Public Sub Grid(dtgGrid As DataGrid)
        Llenar()
        dtgGrid.DataSource = pTabla.Tables(0).DefaultView
        dtgGrid.DataBind()
    End Sub

    Public Sub repeater(repRepeater As Repeater)
        Llenar()
        repRepeater.DataSource = pTabla.Tables(0).DefaultView
        repRepeater.DataBind()
    End Sub

    Public Sub Imagen(ByVal spConsulta As String,
		ByVal Param_IdImagen As String,
		ByVal Param_Imagen As String,
		ByVal IdImagen As Double,
		ByVal Imagen As Byte())
		pBase = New SqlConnection(pConstring)
		pBase.Open()
		Dim sqlCmd As New SqlCommand(spConsulta, pBase)
		sqlCmd.Parameters.AddWithValue(Param_IdImagen, IdImagen)
		sqlCmd.Parameters.AddWithValue(Param_Imagen, Imagen)
		sqlCmd.CommandTimeout = 10000
		sqlCmd.ExecuteNonQuery()
		sqlCmd.Dispose()
		pBase.Close()
		pBase.Dispose()
    End Sub


End Class
