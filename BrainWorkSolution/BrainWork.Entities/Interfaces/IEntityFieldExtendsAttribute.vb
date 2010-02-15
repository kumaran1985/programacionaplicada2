Namespace Interfaces
    Public Interface IEntityFieldExtendsAttribute
        Inherits System.Data.IDbDataParameter
        Property FieldName() As String

        Property FieldDescription() As String

        Property FieldType() As EnumFieldType

        Property ForeingTable() As String



        Property DefaultValue() As String

        Property MainTable() As String

        Property Constraint() As String

        Property RelationType() As EnumRelationType

        Property ForeingCRUD() As String

        Property Order() As Integer

        Property Visibility() As EnumVisibility

        Property CustomValidationExpression() As String

        Property TypeName() As String

        Property EntityClassContainer() As String

        Property MinValue() As Double

        Property MaxValue() As Double

        Property IsDescription() As Boolean

        Property ForeingFieldName() As String

        Property IsDefaultOrderBy() As Boolean

        Property IsEnableField() As Boolean



        Property PropertyName() As String





    End Interface
End Namespace
