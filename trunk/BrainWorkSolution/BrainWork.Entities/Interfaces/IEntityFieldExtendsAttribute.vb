﻿Namespace Interfaces
    Public Interface IEntityFieldExtendsAttribute
        Inherits System.Data.IDbDataParameter
        Property FieldName() As String

        Property FieldDescription() As String

        Property FieldType() As EnumFieldType

        Property ForeingTable() As String

        Property DefaultValue() As Object

        Property MainTable() As String

        Property Constraint() As String

        Property RelationType() As EnumRelationType

        Property ForeingCRUD() As Object

        Property Order() As Integer

        Property Visibility() As EnumVisibility

        Property CustomValidationExpression() As System.Text.RegularExpressions.Regex





    End Interface
End Namespace