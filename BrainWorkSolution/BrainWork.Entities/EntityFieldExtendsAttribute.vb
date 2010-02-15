Option Strict On
Option Explicit On

<System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple:=False), System.Serializable()> _
Public Class EntityFieldExtendsAttribute : Inherits System.Attribute
    Implements Interfaces.IEntityFieldExtendsAttribute


    Private _DefaultValue As String
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
    Private _TypeName As String
    Private _MaxValue As Double
    Private _MinValue As Double

    Private _CustomValidationExpression As String
    Private _ForeingCRUD As String
    Private _Order As Integer
    Private _RelationType As EnumRelationType = EnumRelationType.TextBox
    Private _Visibility As EnumVisibility = EnumVisibility.Normal

    Private _EntityClassContainer As String
    Private _IsDescription As Boolean
    Private _ForeingFieldName As String
    Private _IsDefaultOrderBy As Boolean

    Private _PropertyName As String


    Public Property PropertyName() As String Implements Interfaces.IEntityFieldExtendsAttribute.PropertyName
        Get
            Return _PropertyName
        End Get
        Set(ByVal value As String)
            _PropertyName = value
        End Set
    End Property

    Public ReadOnly Property IsPK() As Boolean
        Get
            Return Me.FieldType = EnumFieldType.PrimaryKey
        End Get
    End Property

    Public Property EntityClassContainer() As String Implements Interfaces.IEntityFieldExtendsAttribute.EntityClassContainer
        Get
            Return _EntityClassContainer
        End Get
        Set(ByVal value As String)
            _EntityClassContainer = value
        End Set
    End Property

    Public Property FieldName() As String Implements Interfaces.IEntityFieldExtendsAttribute.FieldName
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property

    Public Property FieldDescription() As String Implements Interfaces.IEntityFieldExtendsAttribute.FieldDescription

        Get
            Return _FieldDescription
        End Get
        Set(ByVal value As String)
            _FieldDescription = value
        End Set
    End Property

    Public Property FieldType() As EnumFieldType Implements Interfaces.IEntityFieldExtendsAttribute.FieldType
        Get
            Return _FieldType
        End Get
        Set(ByVal value As EnumFieldType)
            _FieldType = value
        End Set
    End Property

    Public Property ForeingTable() As String Implements Interfaces.IEntityFieldExtendsAttribute.ForeingTable
        Get
            Return _ForeingTable
        End Get
        Set(ByVal value As String)
            _ForeingTable = value
        End Set
    End Property

    Public Property DefaultValue() As String Implements Interfaces.IEntityFieldExtendsAttribute.DefaultValue
        Get
            Return _DefaultValue
        End Get
        Set(ByVal value As String)
            _DefaultValue = value
        End Set
    End Property

    Public Property MainTable() As String Implements Interfaces.IEntityFieldExtendsAttribute.MainTable
        Get
            Return _MainTable
        End Get
        Set(ByVal value As String)
            _MainTable = value
        End Set
    End Property

    Private Property Constraint() As String Implements Interfaces.IEntityFieldExtendsAttribute.Constraint
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
    Public WriteOnly Property SetNullable() As Boolean
        Set(ByVal value As Boolean)
            _IsNullable = value
        End Set
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



    Public Property CustomValidationExpression() As String Implements Interfaces.IEntityFieldExtendsAttribute.CustomValidationExpression
        Get
            Return _CustomValidationExpression
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property ForeingCRUD() As String Implements Interfaces.IEntityFieldExtendsAttribute.ForeingCRUD
        Get
            Return _ForeingCRUD
        End Get
        Set(ByVal value As String)
            _ForeingCRUD = value
        End Set
    End Property

    Public Property Order() As Integer Implements Interfaces.IEntityFieldExtendsAttribute.Order
        Get
            Return _Order
        End Get
        Set(ByVal value As Integer)
            _Order = value
        End Set
    End Property

    Public Property RelationType() As EnumRelationType Implements Interfaces.IEntityFieldExtendsAttribute.RelationType
        Get
            Return _RelationType
        End Get
        Set(ByVal value As EnumRelationType)
            _RelationType = value
        End Set
    End Property

    Public Property Visibility() As EnumVisibility Implements Interfaces.IEntityFieldExtendsAttribute.Visibility
        Get
            Return _Visibility
        End Get
        Set(ByVal value As EnumVisibility)
            _Visibility = value
        End Set
    End Property

    Public Property TypeName() As String Implements Interfaces.IEntityFieldExtendsAttribute.TypeName
        Get
            Return _TypeName
        End Get
        Set(ByVal value As String)
            _TypeName = value
        End Set
    End Property


    Public Property MaxValue() As Double Implements Interfaces.IEntityFieldExtendsAttribute.MaxValue
        Get
            Return _MaxValue
        End Get
        Set(ByVal value As Double)
            _MaxValue = value
        End Set
    End Property

    Public Property MinValue() As Double Implements Interfaces.IEntityFieldExtendsAttribute.MinValue
        Get
            Return _MinValue
        End Get
        Set(ByVal value As Double)
            _MinValue = value
        End Set
    End Property


    Public Property IsDescription() As Boolean Implements Interfaces.IEntityFieldExtendsAttribute.IsDescription
        Get
            Return _IsDescription
        End Get
        Set(ByVal value As Boolean)
            _IsDescription = value
        End Set
    End Property

    Public Property ForeingFieldName() As String Implements Interfaces.IEntityFieldExtendsAttribute.ForeingFieldName
        Get
            Return _ForeingFieldName
        End Get
        Set(ByVal value As String)
            _ForeingFieldName = value
        End Set
    End Property

    Public Property IsDefaultOrderBy() As Boolean Implements Entities.Interfaces.IEntityFieldExtendsAttribute.IsDefaultOrderBy
        Get
            Return _IsDefaultOrderBy
        End Get
        Set(ByVal value As Boolean)
            _IsDefaultOrderBy = value
        End Set
    End Property

    Private _IsEnableField As Boolean
    Public Property IsEnableField() As Boolean Implements Interfaces.IEntityFieldExtendsAttribute.IsEnableField
        Get
            Return _IsEnableField
        End Get
        Set(ByVal value As Boolean)
            _IsEnableField = value
        End Set
    End Property


End Class
