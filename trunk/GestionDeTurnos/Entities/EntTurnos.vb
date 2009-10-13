Public Class EntTurnos
    Private _turno_fecha As Date
    Private _turno_hora As String
    Private _Pac_Key As Nullable(Of Integer)
    Private _Med_Key As Nullable(Of Integer)
    Private _Turno_Estado As Nullable(Of Integer)
    Private _Turno_FechaAlta As Date
    Private _Turno_FechaCancelacion As Date
    Private _MOVI_Key As Nullable(Of Integer)

    Public Property turno_fecha() As Date
        Get
            Return _turno_fecha


        End Get
        Set(ByVal value As Date)
            _turno_fecha = value
        End Set
    End Property

    Public Property turno_hora() As String
        Get
            Return _turno_hora

        End Get
        Set(ByVal value As String)
            _turno_hora = value


        End Set
    End Property

    Public Property Pac_Key() As Nullable(Of Integer)
        Get
            Return _Pac_Key


        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Pac_Key = value


        End Set
    End Property

    Public Property Med_Key() As Nullable(Of Integer)
        Get
            Return _Med_Key


        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Med_Key = value


        End Set
    End Property

    Public Property Turno_Estado() As Nullable(Of Integer)
        Get
            Return _Turno_Estado


        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Turno_Estado = value


        End Set
    End Property

    Public Property Turno_FechaAlta() As Date
        Get
            Return _Turno_FechaAlta


        End Get
        Set(ByVal value As Date)
            _Turno_FechaAlta = value


        End Set
    End Property

    Public Property Turno_FechaCancelacion() As Date
        Get
            Return _Turno_FechaCancelacion


        End Get
        Set(ByVal value As Date)
            _Turno_FechaCancelacion = value


        End Set
    End Property

    Public Property MOVI_Key() As Nullable(Of Integer)
        Get
            Return _MOVI_Key


        End Get
        Set(ByVal value As Nullable(Of Integer))
            _MOVI_Key = value


        End Set
    End Property


End Class
