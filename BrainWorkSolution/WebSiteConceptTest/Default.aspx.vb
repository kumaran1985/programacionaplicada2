
Partial Class _Default
    Inherits System.Web.UI.Page
  

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.CustomTextBox1.OnBlur.Add("alert('hola');")
        Dim c As New Pop
        c.javier = "jasdjadsjadjadja"

        c.GetExtendedFieldsAttributes()






    End Sub
End Class
<BrainWork.Entities.EntityClassExtends(DescriptionFieldName:="javier", PrimaryKeyFieldName:="javier", RootContainerName:="Tabla")> _
Public Class Pop
    Inherits BrainWork.Entities.AbstractEntityBase
    Private _javier As String
    '<BrainWork.Entities.EntityFieldExtends(DbType:=Data.DbType.String, DefaultValue:="", Direction:=Data.ParameterDirection.Input, _
    '                                       FieldDescription:="", FieldName:="TBL_CAMPO", FieldType:=BrainWork.Entities.EnumFieldType.PrimaryKey, _
    '                                       ForeingCRUD:=Nothing, ForeingTable:="", MainTable:="")> _
    '
    '<BrainWork.Entities.EntityFieldExtendsAttribute(FieldName:="CJA_Estado", FieldType:=Field, MainTable:=APERTURA_CAJA, Order:=8, ParameterName:=CJA_Estado, SourceColumn:=CJA_Estad)> _

    <BrainWork.Entities.EntityFieldExtendsAttribute(FieldName:="CJA_Estado", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="APERTURA_CAJA", Order:=8, ParameterName:="CJA_Estado", SourceColumn:="CJA_Estado")> _
    Public Property javier() As String
        Get
            Return _javier
        End Get
        Set(ByVal value As String)
            _javier = value
        End Set
    End Property

End Class