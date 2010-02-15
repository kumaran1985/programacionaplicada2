''' <summary>
''' Auto Generated:  13/02/2010 06:43:33 p.m.
''' </summary>
''' <remarks></remarks>
''' 
<Serializable()> _
 <BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CurrencyCode", PrimaryKeyFieldName:="CurrencyCode", RootContainerName:="[Sales].[Currency]", EnabledPropertyName:="CurrencyCode", PrimaryKeyPropertyName:="CurrencyCode")> _
Public Class EntSales_Currency

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CurrencyCode As String
    Private _ModifiedDate As Nullable(Of DateTime)
    Private _Name As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Clustered index created by a primary key constraint. - The ISO code for the Currency.", FieldName:="CurrencyCode", ForeingCRUD:="ABM_Currency", ForeingTable:="Currency", MainTable:="[Sales].[Currency]", Order:=1, ParameterName:="CurrencyCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="CurrencyCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCurrency", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CurrencyCode() As String
        Get
            Return _CurrencyCode
        End Get
        Set(ByVal value As String)
            _CurrencyCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Currency]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[Currency]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As Nullable(Of DateTime)
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Currency name. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Currency]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[Currency]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _CurrencyCode = Nothing
        _ModifiedDate = Nothing  'Date.UtcNow
        _Name = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class
