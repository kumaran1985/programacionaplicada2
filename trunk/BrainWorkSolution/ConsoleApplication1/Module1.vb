
Imports System.Reflection

Module Module1

    Sub Main()

        Dim s As New EntitiClassTest
        s.CampoDeLaBase = "ssdfsdfs"
        ' s.CampoDeLaBase.GetType().GetCustomAttributes(


        Console.WriteLine(GetCustomAttributeValue(s.GetType, "CampoDeLaBase", "FieldDescription"))



        Console.ReadLine()

    End Sub

    

    Public Function GetCustomAttributeValue(ByVal t As Type, ByVal PropertyName As String, ByVal attributeName As String) As Object
        Dim attArray As EntityFieldExtendsAttribute()

        attArray = GetPropertyAttribute(t, PropertyName)


        If Not attArray Is Nothing AndAlso attArray.Length > 0 Then

            For Each att As EntityFieldExtendsAttribute In attArray

                Dim pi() As Reflection.PropertyInfo = att.GetType.GetProperties()

                For Each p As PropertyInfo In pi
                    If p.Name.ToLower = attributeName.ToLower Then
                        Return p.GetValue(att, Nothing)
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function

    Public Function GetPropertyAttribute(ByVal t As Type, ByVal MemberName As String) As EntityFieldExtendsAttribute()

        Dim att() As EntityFieldExtendsAttribute


        Dim MyMemberInfo As MemberInfo() = t.GetMember(MemberName) 't.GetProperties()

        If MyMemberInfo Is Nothing OrElse MyMemberInfo.Length = 0 Then
            Return Nothing
        End If
        att = Attribute.GetCustomAttributes(MyMemberInfo(0), GetType(EntityFieldExtendsAttribute))

        If att Is Nothing OrElse att.Length = 0 Then
            Return Nothing
        End If

        Return att
    End Function

Public Enum EnumFieldType

    PrimaryKey
    ForeingKey
    Field
End Enum

<System.AttributeUsage(System.AttributeTargets.Property Or System.AttributeTargets.Module, AllowMultiple:=True), System.Serializable()> _
Public Class EntityFieldExtendsAttribute : Inherits System.Attribute
    Implements System.Data.IDbDataParameter

    Private _DefaultValue As Object
    Private _ForeingTable As String
    Private _IsForeingKey As Boolean
    Private _FieldType As EnumFieldType
    Private _FieldName As String
    Private _FieldDescription As String
    Private _MainTable As String
    Private _Constraint As String
    Private _DbType As System.Data.DbType
    Private _Direction As System.Data.ParameterDirection
    Private _IsNullable As Boolean
    Private _ParameterName As String
    Private _SourceColumn As String
    Private _SourceVersion As System.Data.DataRowVersion
    Private _Value As Object
    Private _Precision As Byte
    Private _Scale As Byte
    Private _Size As Integer

    Public Property FieldName() As String
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property

    Public Property FieldDescription() As String
        Get
            Return _FieldDescription
        End Get
        Set(ByVal value As String)
            _FieldDescription = value
        End Set
    End Property

    Public Property FieldType() As EnumFieldType
        Get
            Return _FieldType
        End Get
        Set(ByVal value As EnumFieldType)
            _FieldType = value
        End Set
    End Property

    Public Property ForeingTable() As String
        Get
            Return _ForeingTable
        End Get
        Set(ByVal value As String)
            _ForeingTable = value
        End Set
    End Property

    Public Property DefaultValue() As Object
        Get
            Return _DefaultValue
        End Get
        Set(ByVal value As Object)
            _DefaultValue = value
        End Set
    End Property

    Public Property MainTable() As String
        Get
            Return _MainTable
        End Get
        Set(ByVal value As String)
            _MainTable = value
        End Set
    End Property

    Private Property Constraint() As String
        Get
            Return _Constraint
        End Get
        Set(ByVal value As String)
            _Constraint = value
        End Set
    End Property


    Public Property DbType() As System.Data.DbType Implements System.Data.IDataParameter.DbType
        Get
            Return _DbType
        End Get
        Set(ByVal value As System.Data.DbType)
            _DbType = value
        End Set
    End Property

    Public Property Direction() As System.Data.ParameterDirection Implements System.Data.IDataParameter.Direction
        Get
            Return _Direction
        End Get
        Set(ByVal value As System.Data.ParameterDirection)
            _Direction = value
        End Set
    End Property

    Public ReadOnly Property IsNullable() As Boolean Implements System.Data.IDataParameter.IsNullable
        Get
            Return _IsNullable
        End Get
    End Property

    Public Property ParameterName() As String Implements System.Data.IDataParameter.ParameterName
        Get
            Return _ParameterName
        End Get
        Set(ByVal value As String)
            _ParameterName = value
        End Set
    End Property

    Public Property SourceColumn() As String Implements System.Data.IDataParameter.SourceColumn
        Get
            Return _SourceColumn
        End Get
        Set(ByVal value As String)
            _SourceColumn = value
        End Set
    End Property

    Public Property SourceVersion() As System.Data.DataRowVersion Implements System.Data.IDataParameter.SourceVersion
        Get
            Return _SourceVersion
        End Get
        Set(ByVal value As System.Data.DataRowVersion)
            _SourceVersion = value
        End Set
    End Property

    Public Property Value() As Object Implements System.Data.IDataParameter.Value
        Get
            Return _Value
        End Get
        Set(ByVal values As Object)
            _Value = values
        End Set
    End Property

    Public Property Precision() As Byte Implements System.Data.IDbDataParameter.Precision
        Get
            Return _Precision
        End Get
        Set(ByVal value As Byte)
            _Precision = value
        End Set
    End Property

    Public Property Scale() As Byte Implements System.Data.IDbDataParameter.Scale
        Get
            Return _Scale
        End Get
        Set(ByVal value As Byte)
            _Scale = value
        End Set
    End Property

    Public Property Size() As Integer Implements System.Data.IDbDataParameter.Size
        Get
            Return _Size
        End Get
        Set(ByVal value As Integer)
            _Size = value
        End Set
    End Property
End Class


Public Class EntitiClassTest

    Private _CampoDeLaBase As String
    <EntityFieldExtendsAttribute(FieldDescription:="asdads", defaultvalue:="sadsd", fielddescription:="asd asdasdas")> _
    Public Property CampoDeLaBase() As String
        Get
            Return _CampoDeLaBase
        End Get
        Set(ByVal value As String)
            _CampoDeLaBase = value
        End Set
    End Property
    '<EntityFieldExtendsAttribute(Direction:=ParameterDirection.Output)> _
End Class




End Module


