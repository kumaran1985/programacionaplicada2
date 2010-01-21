Namespace Interfaces
    Public Interface IEntityFieldExtendsAttribute
        Inherits System.Data.IDbDataParameter
        Property FieldName() As String

        Property FieldDescription() As String


        Property FieldType() As EnumFieldType


        Property ForeingTable() As String


        Property DefaultValue() As Object


        Property MainTable() As String


        Property Constraint() As String




    End Interface
End Namespace
