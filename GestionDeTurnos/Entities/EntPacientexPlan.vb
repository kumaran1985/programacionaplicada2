Public Class EntPacientexPlan
    Private _iNroHC As Integer
    Private _iPlan As Integer
    Private _iObraSocial As Integer
    Private _tFechaInicio As Date
    Private _tFechaFin As Date
    Public Property iNroHC() As Integer
        Get
            Return _iNroHC

        End Get
        Set(ByVal value As Integer)
            _iNroHC = value

        End Set
    End Property
    Public Property iPlan() As Integer
        Get
            Return _iPlan
        End Get
        Set(ByVal value As Integer)
            _iPlan = value

        End Set
    End Property
    Public Property iObraSocial() As Integer
        Get
            Return _iObraSocial
        End Get
        Set(ByVal value As Integer)
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
