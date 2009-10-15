Public Class EntUsuarios
    Private _SYS_User_Login As String
    Private _SYS_ROLE_KEY As Nullable(Of Integer)
    Private _SYS_User_Pass As String
    Private _SYS_User_Autorizacion As Nullable(Of Integer)
    Private _SYS_User_Nombre As String
    Private _SYS_User_Apellido As String
    Private _TDOC_Key As Nullable(Of Integer)
    Private _SYS_User_DNI As String
    Private _SYS_User_Telefono As String
    Private _SYS_User_email As String
    Private _SYS_User_Direccion As String
    Private _SYS_User_Celular As String

    'Login

    Public Property Login() As String
        Get
            Return _SYS_User_Login
        End Get
        Set(ByVal value As String)
            _SYS_User_Login = value
        End Set
    End Property

    'Key
    Public Property ROLE_KEY() As Nullable(Of Integer)
        Get
            Return _SYS_ROLE_KEY
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _SYS_ROLE_KEY = value
        End Set
    End Property
    'PASSWORD
    Public Property User_Pass() As String
        Get
            Return _SYS_User_Pass
        End Get
        Set(ByVal value As String)
            _SYS_User_Pass = value
        End Set
    End Property
    'Autorizacion

    Public Property User_Autorizacion() As Nullable(Of Integer)
        Get
            Return _SYS_User_Autorizacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _SYS_User_Autorizacion = value
        End Set
    End Property

    ' Nombre
    Public Property User_Nombre() As String
        Get
            Return _SYS_User_Nombre
        End Get
        Set(ByVal value As String)
            _SYS_User_Nombre = value
        End Set
    End Property

    ' Apellido
    Public Property User_Apellido() As String
        Get
            Return _SYS_User_Apellido
        End Get
        Set(ByVal value As String)
            _SYS_User_Apellido = value
        End Set
    End Property

    ' Key DOC
    Public Property TDOC_Key() As Integer
        Get
            Return _TDOC_Key
        End Get
        Set(ByVal value As Integer)
            _TDOC_Key = value
        End Set
    End Property


    ' Telefono
    Public Property User_Telefono() As String
        Get
            Return _SYS_User_Telefono
        End Get
        Set(ByVal value As String)
            _SYS_User_Telefono = value
        End Set
    End Property

    ' email
    Public Property User_Email() As String
        Get
            Return _SYS_User_email
        End Get
        Set(ByVal value As String)
            _SYS_User_email = value
        End Set
    End Property

    ' Direccion
    Public Property User_Direccion() As String
        Get
            Return _SYS_User_Direccion
        End Get
        Set(ByVal value As String)
            _SYS_User_Direccion = value
        End Set
    End Property

    ' Celular
    Public Property User_Celular() As String
        Get
            Return _SYS_User_Celular
        End Get
        Set(ByVal value As String)
            _SYS_User_Celular = value
        End Set
    End Property


    ' Dni _SYS_User_DNI
    Public Property User_DNI() As String
        Get
            Return _SYS_User_DNI
        End Get
        Set(ByVal value As String)
            _SYS_User_DNI = value
        End Set
    End Property

End Class
