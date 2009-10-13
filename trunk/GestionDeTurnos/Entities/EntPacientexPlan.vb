Public Class EntPacientexPlan
    Private _iNroHC As Nullable(Of Integer)
    Private _iPlan As Nullable(Of Integer)
    Private _iObraSocial As Nullable(Of Integer)
    Private _tFechaInicio As Date
    Private _tFechaFin As Date
    Public Property iNroHC() As Nullable(Of Integer)
        Get
            Return _iNroHC

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _iNroHC = value

        End Set
    End Property
    Public Property iPlan() As Nullable(Of Integer)
        Get
            Return _iPlan
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _iPlan = value

        End Set
    End Property
    Public Property iObraSocial() As Nullable(Of Integer)
        Get
            Return _iObraSocial
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _iObraSocial = value

        End Set
    End Property
    Public Property tFechaInicio() As Date
        Get
            Return _tFechaInicio
        End Get
        Set(ByVal value As Date)
            _tFechaInicio = value

        End Set
    End Property
    Public Property tFechaFin() As Date
        Get
            Return _tFechaFin
        End Get
        Set(ByVal value As Date)
            _tFechaFin = value

        End Set
    End Property

End Class
