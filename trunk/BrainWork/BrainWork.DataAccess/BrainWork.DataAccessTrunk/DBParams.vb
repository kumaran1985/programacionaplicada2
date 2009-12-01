
Public Class DBParams
    Inherits AbstractFields


    Private _DefaultValue As Object
    Private _ForeingTable As String
    Private _IsForeingKey As Boolean
    Private _FieldType As EnumFieldType
    Private _ParamDescription As String
    Private _ParamDirection As ParameterDirection
    Private _ParamName As String
    Private _ParamValue As Object
     

    Public Sub New(ByVal Name As String, ByVal dType As DbType, ByVal direction As ParameterDirection, ByVal value As Object, ByVal size As Long)
        MyBase.new()
        Me.ParamName = Name
        Me.FieldType = dType
        Me.ParamValue = value
        Me.ParamDirection = direction
        Me.FieldSize = size
    End Sub

    Public Property ParamName() As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property





    Public Property ParamDirection() As ParameterDirection
        Get

        End Get
        Set(ByVal value As ParameterDirection)

        End Set
    End Property

    Public Property ParamValue() As DbType
        Get

        End Get
        Set(ByVal value As DbType)

        End Set
    End Property




    Public Property ParamType() As EnumFieldType
        Get

        End Get
        Set(ByVal value As EnumFieldType)

        End Set
    End Property




    Public Property DefaultValue() As Object
        Get

        End Get
        Set(ByVal value As Object)

        End Set
    End Property
































End Class
