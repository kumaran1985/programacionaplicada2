Public Class EntTiposDocumento

    Private _TDOC_Key As Nullable(Of Integer)
    Private _TDOC_Descripcion As String


    Public Property TDOC_Key() As Nullable(Of Integer)
        Get
            Return _TDOC_Key
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _TDOC_Key = value
        End Set
    End Property

    Public Property TDOC_Descripcion() As String
        Get
            Return _TDOC_Descripcion
        End Get
        Set(ByVal value As String)
            _TDOC_Descripcion = value
        End Set
    End Property

End Class

