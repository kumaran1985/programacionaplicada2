Public Class EntDetalleHistoriaClinica
    Private _Deta_key As Nullable(Of Integer) = Nothing
    Private _Pac_key As Nullable(Of Integer) = Nothing
    Private _Deta_FechaConsulta As Date = Nothing
    Private _Deta_Especialidad As Nullable(Of Integer) = Nothing
    Private _Deta_NombresMedico As String = Nothing
    Private _Deta_ApellidosMedico As String = Nothing
    Private _Deta_Descripcion As String = Nothing
    Private _Deta_Observacion As String = Nothing
    Private _Deta_Diagnostico As String = Nothing
    Private _Deta_Medicacion As String = Nothing
    Private _Deta_Tratamiento As String = Nothing
    Private _Deta_DuracionTratamiento As String = Nothing

    Public Property Deta_key() As Nullable(Of Integer)
        Get
            Return _Deta_key

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Deta_key = value
        End Set
    End Property

    Public Property Pac_key() As Nullable(Of Integer)
        Get
            Return _Pac_key

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Pac_key = value
        End Set
    End Property

    Public Property Deta_FechaConsulta() As Date
        Get
            Return _Deta_FechaConsulta
        End Get
        Set(ByVal value As Date)
            _Deta_FechaConsulta = value
        End Set
    End Property

    Public Property Deta_Especialidad() As Nullable(Of Integer)
        Get
            Return _Deta_Especialidad
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Deta_Especialidad = value
        End Set
    End Property

    Public Property Deta_NombresMedico() As String
        Get
            Return _Deta_NombresMedico
        End Get
        Set(ByVal value As String)
            _Deta_NombresMedico = value
        End Set
    End Property

    Public Property Deta_ApellidosMedico() As String
        Get
            Return _Deta_ApellidosMedico
        End Get
        Set(ByVal value As String)
            _Deta_ApellidosMedico = value
        End Set
    End Property

    Public Property Deta_Descripcion() As String
        Get
            Return _Deta_Descripcion
        End Get
        Set(ByVal value As String)
            _Deta_Descripcion = value
        End Set
    End Property

    Public Property Deta_Observacion() As String
        Get
            Return _Deta_Observacion
        End Get
        Set(ByVal value As String)
            _Deta_Observacion = value
        End Set
    End Property


    Public Property Deta_Diagnostico() As String
        Get
            Return _Deta_Diagnostico
        End Get
        Set(ByVal value As String)
            _Deta_Diagnostico = value
        End Set
    End Property

    Public Property Deta_Medicacion() As String
        Get
            Return _Deta_Medicacion
        End Get
        Set(ByVal value As String)
            _Deta_Medicacion = value
        End Set
    End Property

    Public Property Deta_Tratamiento() As String
        Get
            Return _Deta_Tratamiento
        End Get
        Set(ByVal value As String)
            _Deta_Tratamiento = value
        End Set
    End Property

    Public Property Deta_DuracionTratamiento() As String
        Get
            Return _Deta_DuracionTratamiento
        End Get
        Set(ByVal value As String)
            _Deta_DuracionTratamiento = value
        End Set
    End Property
End Class
