<Serializable()> _
Public Class PropertysExtendedAtributtes

    Private _PropertyObject As Object
    Private _PropertyAttributes As EntityFieldExtendsAttribute

    Public Property PropertyObject() As Object
        Get
            Return _PropertyObject

        End Get
        Set(ByVal value As Object)
            _PropertyObject = value
        End Set
    End Property


    Property PropertyAttributes() As EntityFieldExtendsAttribute
        Get
            Return _PropertyAttributes
        End Get
        Set(ByVal value As EntityFieldExtendsAttribute)
            _PropertyAttributes = value
        End Set
    End Property
End Class
