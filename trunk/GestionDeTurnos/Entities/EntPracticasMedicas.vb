Public Class EntPracticasMedicas
    Private _PM_Key As Nullable(Of Integer)
    Private _PM_Descripcion As String
    Private _PM_PrecioUnitario As Decimal

    Public Property PM_Key() As Nullable(Of Integer)
        Get
            Return _PM_Key

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _PM_Key = value
        End Set
    End Property

    Public Property PM_Descripcion() As String
        Get
            Return _PM_Descripcion
        End Get
        Set(ByVal value As String)
            _PM_Descripcion = value
        End Set
    End Property

    Public Property PM_PrecioUnitario() As Decimal
        Get
            Return _PM_PrecioUnitario

        End Get
        Set(ByVal value As Decimal)
            _PM_PrecioUnitario = value
        End Set
    End Property

End Class
