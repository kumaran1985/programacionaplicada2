Public Class EntPracticasMedicasxPlan
    Private _PMxP_Key As Nullable(Of Integer)
    Private _Plan_Key As Nullable(Of Integer)
    Private _OS_Key As Nullable(Of Integer)
    Private _PMxP_PorcentajeDescuento As Nullable(Of Integer)

    Public Property PMxP_Key() As Nullable(Of Integer)
        Get
            Return _PMxP_Key

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _PMxP_Key = value
        End Set
    End Property

    Public Property Plan_Key() As Nullable(Of Integer)
        Get
            Return _Plan_Key

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _Plan_Key = value
        End Set
    End Property

    Public Property OS_Key() As Nullable(Of Integer)
        Get
            Return _OS_Key

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _OS_Key = value
        End Set
    End Property

    Public Property PMxP_PorcentajeDescuento() As Nullable(Of Integer)
        Get
            Return _PMxP_PorcentajeDescuento

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _PMxP_PorcentajeDescuento = value
        End Set
    End Property


End Class
