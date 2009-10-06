Public Class EntConsultorios

    Private _Cons_key As Integer
    Private _Cons_Ubicacion As String
    Private _Cons_Descripcion As String

    Public Property Cons_Key() As Integer
        Get
            Return _Cons_key
        End Get
        Set(ByVal value As Integer)
            _Cons_key = value
        End Set
    End Property

    Public Property Cons_Ubicacion() As String
        Get
            Return _Cons_Ubicacion
        End Get
        Set(ByVal value As String)
            _Cons_Ubicacion = value
        End Set
    End Property

    Public Property Cons_Descripcion() As String
        Get
            Return _Cons_Descripcion
        End Get
        Set(ByVal value As String)
            _Cons_Descripcion = value
        End Set
    End Property


End Class

