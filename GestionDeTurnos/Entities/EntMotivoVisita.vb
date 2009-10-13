Public Class EntMotivoVisita

    Private _MOVI_Key As Nullable(Of Integer)
    Private _MOVI_Motivo As String
    Private _MOVI_Descripcion As String

    Public Property MOVI_Key() As Nullable(Of Integer)
        Get
            Return _MOVI_Key
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _MOVI_Key = value
        End Set
    End Property

    Public Property MOVI_Motivo() As String
        Get
            Return _MOVI_Motivo
        End Get
        Set(ByVal value As String)
            _MOVI_Motivo = value
        End Set
    End Property

    Public Property MOVI_Descripcion() As String
        Get
            Return _MOVI_Descripcion
        End Get
        Set(ByVal value As String)
            _MOVI_Descripcion = value
        End Set
    End Property

End Class
