Public Class EntLocalidades

    Private _LOCA_Key As Integer
    Private _PROV_Key As Integer
    Private _LOCA_Nombre As String
    Private _LOCA_Codpos As String


    Property LOCA_Key() As Integer
        Get
            Return _LOCA_Key
        End Get

        Set(ByVal value As Integer)
            _LOCA_Key = value
        End Set
    End Property

    Property PROV_Key() As Integer

        Get
            Return _PROV_Key
        End Get
        Set(ByVal value As Integer)
            _PROV_Key = value
        End Set
    End Property

    Property LOCA_Nombre() As String

        Get
            Return _LOCA_Nombre
        End Get
        Set(ByVal value As String)
            _LOCA_Nombre = value
        End Set
    End Property

    Property LOCA_Codpos() As String

        Get
            Return _LOCA_Codpos
        End Get
        Set(ByVal value As String)
            _LOCA_Codpos = value
        End Set
    End Property
End Class
