Public Class EntPlanes
    Private _Plan_Key As Integer
    Private _OS_Key As Integer
    Private _Plan_Nombre As String
    Private _Plan_Descripcion As String
    Private _Plan_FechaFinConvenio As Date
    Private _Plan_FechaAlta As Date
    Private _Plan_FechaCancelacion As Date


    Public Property Plan_Key() As Integer
        Get
            Return _Plan_Key
        End Get
        Set(ByVal value As Integer)
            _Plan_Key = value

        End Set
    End Property
    Public Property OS_Key() As Integer
        Get
            Return _OS_Key
        End Get
        Set(ByVal value As Integer)
            _OS_Key = value

        End Set
    End Property
    Public Property Plan_Nombre() As String
        Get
            Return _Plan_Nombre
        End Get
        Set(ByVal value As String)
            _Plan_Nombre = value

        End Set
    End Property
    Public Property Plan_Descripcion() As String
        Get
            Return _Plan_Descripcion
        End Get
        Set(ByVal value As String)
            _Plan_Descripcion = value

        End Set
    End Property
    Public Property Plan_FechaFinConvenio() As Date
        Get
            Return _Plan_FechaFinConvenio
        End Get
        Set(ByVal value As Date)
            _Plan_FechaFinConvenio = value

        End Set
    End Property
    Public Property Plan_FechaAlta() As Date
        Get
            Return _Plan_FechaAlta
        End Get
        Set(ByVal value As Date)
            _Plan_FechaAlta = value

        End Set
    End Property
    Public Property Plan_FechaCancelacion() As Date
        Get
            Return _Plan_FechaCancelacion
        End Get
        Set(ByVal value As Date)
            _Plan_FechaCancelacion = value

        End Set
    End Property



End Class
