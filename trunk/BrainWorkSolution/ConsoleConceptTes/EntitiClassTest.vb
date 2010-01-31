Imports BrainWork.Entities
<EntityClassExtends(DescriptionFieldName:="CASA", _
PrimaryKeyFieldName:="ccccc", _
RootContainerName:="sadsd")> _
Public Class EntitiClassTest
    Inherits BrainWork.Entities.AbstractEntityBase
    Private _CampoDeLaBase As String
    '   <EntityFieldExtendsAttribute(DbType:=DbType.String, DefaultValue:="", Direction:=ParameterDirection.Input, FieldDescription:="", FieldName:="", FieldType:=EnumFieldType.Field, ForeingCRUD:="", ForeingTable:="", MainTable:="", Order:=0, ParameterName:="", Precision:="", RelationType:=EnumRelationType.PopUp, Scale:=0, SetNullable:=True, size:=0, SourceColumn:="", SourceVersion:=DataRowVersion.Current, Value:=0, Visibility:=EnumVisibility.Normal)> _
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

