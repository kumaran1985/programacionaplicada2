Public Class DBFields
    Inherits AbstractFields
    Private _DefaultValue As Object
    Private _ForeingTable As String
    Private _IsForeingKey As Boolean
    Private _FieldType As EnumFieldType




    Public Property FieldName() As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property FieldDescription() As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property




    Public Property FieldValue() As DbType
        Get

        End Get
        Set(ByVal value As DbType)

        End Set
    End Property




    Public Property FieldType() As EnumFieldType
        Get

        End Get
        Set(ByVal value As EnumFieldType)

        End Set
    End Property

    Public Property ForeingTable() As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property DefaultValue() As Object
        Get

        End Get
        Set(ByVal value As Object)

        End Set
    End Property

    Public Property MainTable() As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Private Property Constraint() As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property IsNullable() As Boolean
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property





End Class
