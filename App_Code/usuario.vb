Imports Microsoft.VisualBasic

Public Class usuario
    Private con As New conexion

    Private pIdUsuario As Integer
    Private pNombre As String
    Private pApellidoPat As String
    Private pApellidoMat As String
    Private pTelefono As String
    Private pCorreo As String
    Private pContra As String
    Private pFotoDir As String
    Private pIdioma As String

    Public Property IdUsuario As Integer
        Get
            Return pIdUsuario
        End Get
        Set(value As Integer)
            pIdUsuario = value
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

    Public Property ApellidoPat As String
        Get
            Return pApellidoPat
        End Get
        Set(value As String)
            pApellidoPat = value
        End Set
    End Property

    Public Property ApellidoMat As String
        Get
            Return pApellidoMat
        End Get
        Set(value As String)
            pApellidoMat = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return pTelefono
        End Get
        Set(value As String)
            pTelefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return pCorreo
        End Get
        Set(value As String)
            pCorreo = value
        End Set
    End Property

    Public Property Contra As String
        Get
            Return pContra
        End Get
        Set(value As String)
            pContra = value
        End Set
    End Property

    Public Property FotoDir As String
        Get
            Return pFotoDir
        End Get
        Set(value As String)
            pFotoDir = value
        End Set
    End Property

    Public Property Idioma As String
        Get
            Return pIdioma
        End Get
        Set(value As String)
            pIdioma = value
        End Set
    End Property



    'METODOS
    Public Sub buscar(IdUsuario As Integer)
        con.SQL = "SELECT * FROM USUARIOS WHERE IdUsuario = " & IdUsuario
        con.Llenar()
        llename(con)
    End Sub

    Public Sub buscar_login(Correo As String, Contra As String)
        con.SQL = "SELECT * FROM USUARIOS WHERE Correo = " & "'" & Correo & "' " & "AND Contra= " & "'" & Contra & "';"
        con.Llenar()
        llename(con)
    End Sub

    Public Sub buscar_Contra(Correo As String)
        con.SQL = "SELECT * FROM USUARIOS WHERE Correo = " & "'" & Correo & "';"
        con.Llenar()
        llename(con)
    End Sub

    Public Sub guardar()
        con.SQL = "exec sp_UsuarioAddUpd " & pIdUsuario & ",'" & pNombre & "','" & pApellidoPat & "','" & pApellidoMat & "','" & pTelefono & "','" & pCorreo & "','" & pContra & "','" & pFotoDir & "';"
        con.Ejecutar()
    End Sub

    Public Sub eliminar(IdUsuario As Integer)
        con.SQL = "exec sp_UsuarioDel " & IdUsuario
        con.Ejecutar()
    End Sub

    Public Sub grid(dtgUsers As DataGrid)
        con.SQL = "exec sp_UsuarioSel"
        con.Grid(dtgUsers)
    End Sub

    Private Sub llename(con As conexion)
        If Not con.Vacia Then
            pIdUsuario = con.VariableNombreDset("IdUsuario")
            pNombre = con.VariableNombreDset("Nombre")
            pApellidoPat = con.VariableNombreDset("ApellidoPat")
            pApellidoMat = con.VariableNombreDset("ApellidoMat")
            pTelefono = con.VariableNombreDset("Telefono")
            pCorreo = con.VariableNombreDset("Correo")
            pContra = con.VariableNombreDset("Contra")
            pFotoDir = con.VariableNombreDset("Foto")
        End If
    End Sub


End Class
