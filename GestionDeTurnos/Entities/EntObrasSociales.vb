Public Class EntObrasSociales
    Private _OS_Key As Integer
    Private _OS_Nombre As String
    Private _OS_Descripcion As String
    Private _OS_Calle As String
    Private _OS_NumeroExt As String
    Private _OS_NumeroInt As String
    Private _LOCA_Key As Integer
    Private _OS_Telefonos As String
    Private _OS_FechaFinConvenio As Date
    Private _OS_FechaAlta As Date
    Private _OS_FechaCancelacion As Date

    Public Property OS_Key() As Integer
        Get
            Return _OS_Key

        End Get
        Set(ByVal value As Integer)
            _OS_Key = value
        End Set
    End Property

    Public Property OS_Nombre() As String
        Get
            Return _OS_Nombre

        End Get
        Set(ByVal value As String)
            _OS_Nombre = value
        End Set
    End Property

    Public Property OS_Descripcion() As String
        Get
            Return _OS_Descripcion

        End Get
        Set(ByVal value As String)
            _OS_Descripcion = value
        End Set
    End Property

    Public Property OS_Calle() As String
        Get
            Return _OS_Calle

        End Get
        Set(ByVal value As String)
            _OS_Calle = value
        End Set
    End Property

    Public Property OS_NumeroExt() As String
        Get
            Return _OS_NumeroExt

        End Get
        Set(ByVal value As String)
            _OS_NumeroExt = value
        End Set
    End Property

    Public Property OS_NumeroInt() As String
        Get
            Return _OS_NumeroInt

        End Get
        Set(ByVal value As String)
            _OS_NumeroInt = value
        End Set
    End Property

    Public Property LOCA_Key() As Integer
        Get
            Return _LOCA_Key

        End Get
        Set(ByVal value As Integer)
            _LOCA_Key = value
        End Set
    End Property
    Public Property OS_Telefonos() As String
        Get
            Return _OS_Telefonos

        End Get
        Set(ByVal value As String)
            _OS_Telefonos = value
        End Set
    End Property

    Public Property OS_FechaFinConvenio() As Date
        Get
            Return _OS_FechaFinConvenio

        End Get
        Set(ByVal value As Date)
            _OS_FechaFinConvenio = value
        End Set
    End Property

    Public Property OS_FechaAlta() As Date
        Get
            Return _OS_FechaAlta

        End Get
        Set(ByVal value As Date)
            _OS_FechaAlta = value
        End Set
    End Property

    Public Property OS_FechaCancelacion() As Date
        Get
            Return _OS_FechaCancelacion

        End Get
        Set(ByVal value As Date)
            _OS_FechaCancelacion = value
        End Set
    End Property


End Class
