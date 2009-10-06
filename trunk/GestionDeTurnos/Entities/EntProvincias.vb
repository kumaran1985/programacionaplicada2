Public Class EntProvincias
    Private _PROV_Key As Integer
    Private _PROV_Nombre As String

    Property PROV_Key() As Integer
        Get
            Return _PROV_Key
        End Get
        Set(ByVal value As Integer)
            _PROV_Key = value
        End Set
    End Property

    Property PROV_Nombre() As String
        Get
            Return _PROV_Nombre
        End Get
        Set(ByVal value As String)
            _PROV_Nombre = value
        End Set
    End Property



End Class
