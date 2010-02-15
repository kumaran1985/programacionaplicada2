<Serializable()> _
<System.AttributeUsage(System.AttributeTargets.Class Or System.AttributeTargets.Module, AllowMultiple:=False)> _
Public Class EntityClassExtendsAttribute : Inherits System.Attribute

    Private _RootContainerName As String
    Private _PrimaryKeyFieldName As String
    Private _DescriptionFieldName As String
    Private _PrimaryKeyPropertyName As String
    Private _DescriptionPropertyName As String
    Private _EnableFieldName As String
    Private _EnablePropertyName As String
    Private _EnableCompareValue As String


    Public Property EnableFieldName() As String
        Get
            Return _EnableFieldName
        End Get
        Set(ByVal value As String)
            _EnableFieldName = value
        End Set
    End Property
    Public Property EnabledPropertyName() As String
        Get
            Return _EnablePropertyName
        End Get
        Set(ByVal value As String)
            _EnablePropertyName = value
        End Set
    End Property
    Public Property EnableCompareValue() As String
        Get
            Return _EnableCompareValue
        End Get
        Set(ByVal value As String)
            _EnableCompareValue = value
        End Set
    End Property

    Public Property DescriptionPropertyName() As String
        Get
            Return _DescriptionPropertyName
        End Get
        Set(ByVal value As String)
            _DescriptionPropertyName = value
        End Set
    End Property
    Public Property PrimaryKeyPropertyName() As String
        Get
            Return _PrimaryKeyPropertyName
        End Get
        Set(ByVal value As String)
            _PrimaryKeyPropertyName = value
        End Set
    End Property
    Public Property RootContainerName() As String
        Get
            Return _RootContainerName
        End Get
        Set(ByVal value As String)
            _RootContainerName = value
        End Set
    End Property


    Public Property PrimaryKeyFieldName() As String
        Get
            Return _PrimaryKeyFieldName
        End Get
        Set(ByVal value As String)
            _PrimaryKeyFieldName = value
        End Set
    End Property

    Public Property DescriptionFieldName() As String
        Get
            Return _DescriptionFieldName
        End Get
        Set(ByVal value As String)
            _DescriptionFieldName = value

        End Set
    End Property




End Class
