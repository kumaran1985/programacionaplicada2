Public Class EntMedicos
    Private _Med_key As Nullable(Of Integer)
    Private _TDOC_Key As Nullable(Of Integer)
    Private _Med_NumeroDoc As String
    Private _Med_Nombres As String
    Private _Med_Apellidos As String
    Private _Med_Calle As String
    Private _Med_NumeroExt As String
    Private _Med_NumeroInt As String
    Private _LOCA_Key As Nullable(Of Integer)
    Private _Med_Especialidad As Nullable(Of Integer)
    Private _Med_Matricula As String
    Private _Med_FechaNacimiento As Date
    Private _Med_Telefonos As String
    Private _Med_Celular As String
    Private _Med_Email As String
    Private _Med_EstadoCivil As String
    Private _Med_Sexo As String
    Private _Med_FechaIngreso As String
    Private _Med_Matricula1 As Nullable(Of Integer)


    Public Property Med_key() As Nullable(Of Integer)
        Get
            Return _Med_key
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Med_key = value
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
    Public Property Med_NumeroDoc() As String
        Get
            Return _Med_NumeroDoc
        End Get
        Set(ByVal value As String)
            _Med_NumeroDoc = value
        End Set
    End Property
    Public Property Med_Nombres() As String
        Get
            Return _Med_Nombres
        End Get
        Set(ByVal value As String)
            _Med_Nombres = value
        End Set
    End Property
    Public Property Med_Apellidos() As String
        Get
            Return _Med_Apellidos
        End Get
        Set(ByVal value As String)
            _Med_Apellidos = value
        End Set
    End Property
    Public Property Med_Calle() As String
        Get
            Return _Med_Calle
        End Get
        Set(ByVal value As String)
            _Med_Calle = value
        End Set
    End Property
    Public Property Med_NumeroExt() As String
        Get
            Return _Med_NumeroExt
        End Get
        Set(ByVal value As String)
            _Med_NumeroExt = value
        End Set
    End Property
    Public Property Med_NumeroInt() As String
        Get
            Return _Med_NumeroInt
        End Get
        Set(ByVal value As String)
            _Med_NumeroInt = value
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
    Public Property Med_Especialidad() As Nullable(Of Integer)
        Get
            Return _Med_Especialidad
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Med_Especialidad = value
        End Set
    End Property
    Public Property Med_Matricula() As String
        Get
            Return _Med_Matricula
        End Get
        Set(ByVal value As String)
            _Med_Matricula = value
        End Set
    End Property
    Public Property Med_FechaNacimiento() As Date
        Get
            Return _Med_FechaNacimiento
        End Get
        Set(ByVal value As Date)
            _Med_FechaNacimiento = value
        End Set
    End Property
    Public Property Med_Telefonos() As String
        Get
            Return _Med_Telefonos
        End Get
        Set(ByVal value As String)
            _Med_Telefonos = value
        End Set
    End Property
    Public Property Med_Celular() As String
        Get
            Return _Med_Celular
        End Get
        Set(ByVal value As String)
            _Med_Celular = value
        End Set
    End Property
    Public Property Med_Email() As String
        Get
            Return _Med_Email
        End Get
        Set(ByVal value As String)
            _Med_Email = value
        End Set
    End Property

    Public Property Med_EstadoCivil() As String
        Get
            Return _Med_EstadoCivil
        End Get
        Set(ByVal value As String)
            _Med_EstadoCivil = value
        End Set
    End Property

    Public Property Med_Sexo() As String
        Get
            Return _Med_Sexo
        End Get
        Set(ByVal value As String)
            _Med_Sexo = value
        End Set
    End Property

    Public Property Med_FechaIngreso() As String
        Get
            Return _Med_FechaIngreso
        End Get
        Set(ByVal value As String)
            _Med_FechaIngreso = value
        End Set
    End Property
    Public Property Med_Matricula1() As Nullable(Of Integer)
        Get
            Return _Med_Matricula1
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Med_Matricula1 = value
        End Set
    End Property
End Class

