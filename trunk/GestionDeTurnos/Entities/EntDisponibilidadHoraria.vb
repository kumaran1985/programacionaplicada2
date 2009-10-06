Public Class EntDisponibilidadHoraria
    Private _DSPH_Key As Integer
    Private _Med_Key As Integer
    Private _DSPH_DiaSemana As String
    Private _DSPH_Duracion As Integer
    Private _DSPH_HoraInicio As DateTime
    Private _DSPH_HoraFin As DateTime
    Private _DSPH_FechaIni As DateTime
    Private _DSPH_FechaFin As DateTime
    Private _DSPH_Novedades As String


    Public Property DSPH_Key() As Integer
        Get
            Return _DSPH_Key
        End Get
        Set(ByVal value As Integer)
            _DSPH_Key = value
        End Set
    End Property

    Public Property Med_Key() As Integer
        Get
            Return _Med_Key
        End Get
        Set(ByVal value As Integer)
            _Med_Key = value
        End Set
    End Property

    Public Property DSPH_DiaSemana() As String
        Get
            Return _DSPH_DiaSemana
        End Get
        Set(ByVal value As String)
            _DSPH_DiaSemana = value
        End Set
    End Property

    Public Property DSPH_Duracion() As Integer
        Get
            Return _DSPH_Duracion
        End Get
        Set(ByVal value As Integer)
            _DSPH_Duracion = value
        End Set
    End Property

    Public Property DSPH_HoraInicio() As DateTime
        Get
            Return _DSPH_HoraInicio
        End Get
        Set(ByVal value As DateTime)
            _DSPH_HoraInicio = value
        End Set
    End Property

    Public Property DSPH_HoraFin() As DateTime
        Get
            Return _DSPH_HoraFin
        End Get
        Set(ByVal value As DateTime)
            _DSPH_HoraFin = value
        End Set
    End Property

    Public Property DSPH_FechaIni() As DateTime
        Get
            Return _DSPH_FechaIni
        End Get
        Set(ByVal value As DateTime)
            _DSPH_FechaIni = value
        End Set
    End Property

    Public Property DSPH_FechaFin() As DateTime
        Get
            Return _DSPH_FechaFin
        End Get
        Set(ByVal value As DateTime)
            _DSPH_FechaFin = value
        End Set
    End Property

    Public Property DSPH_Novedades() As String
        Get
            Return _DSPH_Novedades
        End Get
        Set(ByVal value As String)
            _DSPH_Novedades = value
        End Set
    End Property
End Class
