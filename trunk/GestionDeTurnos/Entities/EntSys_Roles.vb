Public Class EntSys_Roles
    Private _SYS_ROLE_KEY As Nullable(Of Integer) = Nothing
    Private _SYS_ROLE_Descripcion As String = Nothing
    Private _SYS_ROLE_Enabled As Nullable(Of Integer) = Nothing


    Public Property SYS_ROLE_KEY() As Nullable(Of Integer)
        Get
            Return _SYS_ROLE_KEY

        End Get
        Set(ByVal value As Nullable(Of Integer))
            _SYS_ROLE_KEY = value
        End Set
    End Property


    Public Property SYS_ROLE_Descripcion() As String
        Get
            Return _SYS_ROLE_Descripcion
        End Get
        Set(ByVal value As String)
            _SYS_ROLE_Descripcion = value
        End Set
    End Property

    Public Property SYS_ROLE_Enabled() As Nullable(Of Integer)
        Get
            Return _SYS_ROLE_Enabled
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _SYS_ROLE_Enabled = value
        End Set
    End Property



End Class
