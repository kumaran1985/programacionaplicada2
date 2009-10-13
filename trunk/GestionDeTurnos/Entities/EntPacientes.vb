Public Class EntPacientes
    Private _Pac_key As Nullable(Of Integer)
    Private _TDOC_Key As Nullable(Of Integer)
    Private _Pac_NumeroDoc As String
    Private _Pac_Nombres As String
    Private _Pac_Apellidos As String
    Private _Pac_Calle As String
    Private _Pac_NumeroExt As String
    Private _Pac_NumeroInt As String
    Private _LOCA_Key As Nullable(Of Integer)
    Private _Pac_Telefonos As String
    Private _Pac_Celular As String
    Private _Pac_Email As String
    Private _Pac_FechaNacimiento As Date
    Private _Pac_FechaAlta As Date
    Private _Pac_FechaCancelacion As Date
    Private _Pac_Sexo As Boolean
    Private _Pac_EstadoCivil As String
    Private _Pac_Ocupacion As String
    Private _Pac_Nacionalidad As String

    Public Property Pac_key() As Nullable(Of Integer)
        Get
            Return _Pac_key
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Pac_key = value
        End Set
    End Property
    Public Property TDOC_Key() As Nullable(Of Integer)
        Get
            Return _TDOC_Key
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _TDOC_Key = value
        End Set
    End Property
    Public Property Pac_NumeroDoc() As String
        Get
            Return _Pac_NumeroDoc
        End Get
        Set(ByVal value As String)
            _Pac_NumeroDoc = value
        End Set
    End Property
    Public Property Pac_Nombres() As String
        Get
            Return _Pac_Nombres
        End Get
        Set(ByVal value As String)
            _Pac_Nombres = value
        End Set
    End Property
    Public Property Pac_Apellidos() As String
        Get
            Return _Pac_Apellidos
        End Get
        Set(ByVal value As String)
            _Pac_Apellidos = value
        End Set
    End Property
    Public Property Pac_Calle() As String
        Get
            Return _Pac_Calle
        End Get
        Set(ByVal value As String)
            _Pac_Calle = value
        End Set
    End Property
    Public Property Pac_NumeroExt() As String
        Get
            Return _Pac_NumeroExt
        End Get
        Set(ByVal value As String)
            _Pac_NumeroExt = value
        End Set
    End Property
    Public Property Pac_NumeroInt() As String
        Get
            Return _Pac_NumeroInt
        End Get
        Set(ByVal value As String)
            _Pac_NumeroInt = value
        End Set
    End Property
    Public Property LOCA_Key() As Nullable(Of Integer)
        Get
            Return _LOCA_Key
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _LOCA_Key = value
        End Set
    End Property
    Public Property Pac_Telefonos() As String
        Get
            Return _Pac_Telefonos
        End Get
        Set(ByVal value As String)
            _Pac_Telefonos = value
        End Set
    End Property
    Public Property Pac_Celular() As String
        Get
            Return _Pac_Celular
        End Get
        Set(ByVal value As String)
            _Pac_Celular = value
        End Set
    End Property
    Public Property Pac_Email() As String
        Get
            Return _Pac_Email
        End Get
        Set(ByVal value As String)
            _Pac_Email = value
        End Set
    End Property
    Public Property Pac_FechaNacimiento() As Date
        Get
            Return _Pac_FechaNacimiento
        End Get
        Set(ByVal value As Date)
            _Pac_FechaNacimiento = value
        End Set
    End Property
    Public Property Pac_FechaAlta() As Date
        Get
            Return _Pac_FechaAlta
        End Get
        Set(ByVal value As Date)
            _Pac_FechaAlta = value
        End Set
    End Property
    Public Property Pac_FechaCancelacion() As Date
        Get
            Return _Pac_FechaCancelacion
        End Get
        Set(ByVal value As Date)
            _Pac_FechaCancelacion = value
        End Set
    End Property
    Public Property Pac_Sexo() As Boolean
        Get
            Return _Pac_Sexo
        End Get
        Set(ByVal value As Boolean)
            _Pac_Sexo = value
        End Set
    End Property
    Public Property Pac_EstadoCivil() As String
        Get
            Return _Pac_EstadoCivil
        End Get
        Set(ByVal value As String)
            _Pac_EstadoCivil = value
        End Set
    End Property
    Public Property Pac_Ocupacion() As String
        Get
            Return _Pac_Ocupacion
        End Get
        Set(ByVal value As String)
            _Pac_Ocupacion = value
        End Set
    End Property
    Public Property Pac_Nacionalidad() As String
        Get
            Return _Pac_Nacionalidad
        End Get
        Set(ByVal value As String)
            _Pac_Nacionalidad = value
        End Set
    End Property
End Class
