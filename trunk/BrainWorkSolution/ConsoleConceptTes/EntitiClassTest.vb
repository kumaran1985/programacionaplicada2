Imports BrainWork.Entities
<EntityClassExtends(DescriptionFieldName:="CASA", _
PrimaryKeyFieldName:="ccccc", _
RootContainerName:="sadsd")> _
Public Class EntitiClassTest
    Inherits BrainWork.Entities.AbstractEntityBase
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
