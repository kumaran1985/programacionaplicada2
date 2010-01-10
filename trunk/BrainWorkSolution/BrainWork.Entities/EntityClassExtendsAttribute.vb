<System.AttributeUsage(System.AttributeTargets.Class Or System.AttributeTargets.Module, AllowMultiple:=False), System.Serializable()> _
Public Class EntityClassExtendsAttribute : Inherits System.Attribute

    Private _RootContainerName As String
    Private _PrimaryKeyFieldName As String
    Private _DescriptionFieldName As String
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
