Imports System.Reflection
Imports System.Linq.Expressions

Module Module12
    ' Public WithEvents ess As New eventsample
    Sub Main()
        'Dim e As New EntAWBuildVersion
        'For Each p As BrainWork.Entities.EntityFieldExtendsAttribute In e.GetEntityFieldExtendsAttributes()
        '    Console.WriteLine(p.FieldName)
        'Next

        'Console.ReadLine()



        'Dim oUser As New BrainWork.Security.ApplicationUser
        'oUser.SessionID = "ss"
        '' Dim ob As New ClaseBL(oUser)
        'ob.Add()


        'Dim da2 As New DataAccess(New BrainWork.Security.ApplicationUser())
        'da.RollBackTransaction()
        'GetPropertyName(Function(da As DataAccess) da.ApplicationUser, da2)
        ' Console.WriteLine(da.UnDataset().ToString)

        'ess.prueba()


        'Dim s As New EntitiClassTest
        's.CampoDeLaBase = "ssdfsdfs"



        'Dim fp As BrainWork.Entities.EntityFieldExtendsAttribute = s.GetFieldProperties("CampoDeLaBase")

        'Dim o As BrainWork.Entities.EntityClassExtendsAttribute = s.ExtendedClassAttributes
        'Console.WriteLine(fp.FieldDescription)
        'Console.WriteLine(o.PrimaryKeyFieldName)

        ' ''[Enum].GetName(s.GetType, s.CampoDeLaBase)
        ' ''System.Reflection.PropertyInfo = s.GetType.getp

        ''Console.WriteLine(GetCustomAttributeValue(s.GetType, s.CampoDeLaBase, "FieldDescription"))


        ''Console.WriteLine(GetCustomAttributeValue(s.GetType, "campoDeLaBase", "FieldDescription"))


        Console.ReadLine()

    End Sub

    'Public Function GetPropertyName(Of T, TReturn)(ByVal expression As Expression(Of Func(Of T, TReturn)), ByVal value As Object) As BrainWork.Entities.EntityFieldExtendsAttribute()
    '    Dim body As MemberExpression = DirectCast(expression.Body, MemberExpression)

    '    Dim att() As BrainWork.Entities.EntityFieldExtendsAttribute


    '    Dim MyMemberInfo As MemberInfo() = value.GetType.GetMember(body.Member.Name) 't.GetProperties()

    '    If MyMemberInfo Is Nothing OrElse MyMemberInfo.Length = 0 Then
    '        Return Nothing
    '    End If
    '    att = Attribute.GetCustomAttributes(MyMemberInfo(0), GetType(BrainWork.Entities.EntityFieldExtendsAttribute))

    '    If att Is Nothing OrElse att.Length = 0 Then
    '        Return Nothing
    '    End If

    '    Return att
    'End Function

    'Public Class eventsample
    '    Public Shared Event oEvent(ByVal o As Object, ByVal e As EventArgs)


    '    Private Sub MiEvent(ByVal o As Object, ByVal e As EventArgs) Handles Me.oEvent



    '    End Sub

    '    Public Sub prueba()
    '        RaiseEvent oEvent(Me, New EventArgs)

    '    End Sub





    'End Class




    ''Public Function GetCustomAttributeValue(ByVal t As Type, ByVal PropertyType As Type, ByVal attributeName As String) As Object
    ''    Dim attArray As BrainWork.Entities.EntityFieldExtendsAttribute()


    ''    attArray = GetPropertyAttribute(t, PropertyType.Name)


    ''    If Not attArray Is Nothing AndAlso attArray.Length > 0 Then

    ''        For Each att As BrainWork.Entities.EntityFieldExtendsAttribute In attArray

    ''            Dim pi() As Reflection.PropertyInfo = att.GetType.GetProperties()

    ''            For Each p As PropertyInfo In pi
    ''                If p.Name.ToLower = attributeName.ToLower Then
    ''                    Return p.GetValue(att, Nothing)
    ''                End If
    ''            Next
    ''        Next
    ''    End If
    ''    Return Nothing
    ''End Function

    ''Public Function GetCustomAttributeValue(ByVal t As Type, ByVal PropertyName As String, ByVal attributeName As String) As Object
    ''    Dim attArray As BrainWork.Entities.EntityFieldExtendsAttribute()

    ''    attArray = GetPropertyAttribute(t, PropertyName)


    ''    If Not attArray Is Nothing AndAlso attArray.Length > 0 Then

    ''        For Each att As BrainWork.Entities.EntityFieldExtendsAttribute In attArray

    ''            Dim pi() As Reflection.PropertyInfo = att.GetType.GetProperties()

    ''            For Each p As PropertyInfo In pi
    ''                If p.Name.ToLower = attributeName.ToLower Then
    ''                    Return p.GetValue(att, Nothing)
    ''                End If
    ''            Next
    ''        Next
    ''    End If
    ''    Return Nothing
    ''End Function


    ''Private Function FindPropertyByExample(ByVal t As Type, ByVal PropertyName As String) As String
    ''    Dim pi As PropertyInfo() = t.GetProperties()
    ''    PropertyName = PropertyName.ToLower

    ''    For Each p As PropertyInfo In t.GetProperties
    ''        If p.Name.ToLower = PropertyName Then
    ''            Return p.Name
    ''        End If
    ''    Next

    ''    Return Nothing
    ''End Function

    ''Public Function GetPropertyAttribute(ByVal t As Type, ByVal MemberName As String) As BrainWork.Entities.EntityFieldExtendsAttribute()

    ''    Dim att() As BrainWork.Entities.EntityFieldExtendsAttribute


    ''    Dim MyMemberInfo As MemberInfo() = t.GetMember(MemberName) 't.GetProperties()

    ''    If MyMemberInfo Is Nothing OrElse MyMemberInfo.Length = 0 Then
    ''        'verifico mayuscula y minuscula
    ''        MemberName = FindPropertyByExample(t, MemberName)
    ''        If MemberName Is Nothing Then
    ''            Return Nothing
    ''        End If
    ''        MyMemberInfo = t.GetMember(MemberName)
    ''    End If
    ''    att = Attribute.GetCustomAttributes(MyMemberInfo(0), GetType(BrainWork.Entities.EntityFieldExtendsAttribute))

    ''    If att Is Nothing OrElse att.Length = 0 Then
    ''        Return Nothing
    ''    End If

    ''    Return att


    ''    'Get the class-level attributes.
    ''    'Put the instance of the attribute on the class level in the att object.
    ''    'att = Attribute.GetCustomAttributes(t, GetType(BrainWork.Entities.EntityFieldExtendsAttribute))

    ''    'If att Is Nothing OrElse att.Length = 0 Then
    ''    '    Console.WriteLine("No attribute in class {0}.", t.ToString())
    ''    '    Console.WriteLine()
    ''    'Else
    ''    '    Console.WriteLine("The Name Attribute on the class level is: {0}.", att(0).DbType)
    ''    '    Console.WriteLine("The Level Attribute on the class level is: {0}.", att(0).Direction)
    ''    '    ' Console.WriteLine("The Reviewed Attribute on the class level is: {0}.", att.Reviewed)
    ''    '    Console.WriteLine()
    ''    'End If

    ''    'Get the method-level attributes.
    ''    'Get all methods in this class and put them
    ''    'in an array of System.Reflection.MemberInfo objects.
    ''    'Loop through all methods in this class that are in the 
    ''    'MyMemberInfo array.
    ''    'Dim i As Integer
    ''    'For i = 0 To MyMemberInfo.Length - 1
    ''    '    att = Attribute.GetCustomAttributes(MyMemberInfo(i), GetType(BrainWork.Entities.EntityFieldExtendsAttribute))
    ''    '    If att Is Nothing Then
    ''    '        Console.WriteLine("No attribute in member function {0}.", MyMemberInfo(i).ToString())
    ''    '        Console.WriteLine()
    ''    '    Else
    ''    '        Console.WriteLine("The Name Attribute for the {0} member is: {1}.", MyMemberInfo(i).ToString(), att(0).DbType)
    ''    '        Console.WriteLine("The Level Attribute for the {0} member is: {1}.", MyMemberInfo(i).ToString(), att(0).Direction)
    ''    '        'Console.WriteLine("The Reviewed Attribute for the {0} member is: {1}.", MyMemberInfo(i).ToString(), att.Reviewed)
    ''    '        Console.WriteLine()
    ''    '    End If
    ''    'Next i



    ''    'Dim MyAttribute As BrainWork.Entities.EntityFieldExtendsAttribute() = _
    ''    '    CType(Attribute.GetCustomAttributes(t, GetType(BrainWork.Entities.EntityFieldExtendsAttribute)), BrainWork.Entities.EntityFieldExtendsAttribute())

    ''    'If MyAttribute Is Nothing Then
    ''    '    Console.WriteLine("The attribute was not found.")
    ''    'Else
    ''    '    Dim i As Integer
    ''    '    For i = 0 To MyAttribute.Length - 1
    ''    '        'Get the Name value. 
    ''    '        Console.WriteLine("The Name Attribute is: {0}.", MyAttribute(i).Direction)
    ''    '        'Get the Level value.   
    ''    '        Console.WriteLine("The Level Attribute is: {0}.", MyAttribute(i).DbType)
    ''    '        'Get the Reviewed value.
    ''    '        'Console.WriteLine("The Reviewed Attribute is: {0}.", MyAttribute(i).Reviewed)
    ''    '    Next i
    ''    'End If


    ''    ''Get instance of the attribute.
    ''    'Dim MyAttribute As BrainWork.Entities.EntityFieldExtendsAttribute = _
    ''    'CType(Attribute.GetCustomAttribute(t, GetType(BrainWork.Entities.EntityFieldExtendsAttribute)), BrainWork.Entities.EntityFieldExtendsAttribute)

    ''    'If MyAttribute Is Nothing Then
    ''    '    Console.WriteLine("The attribute was not found.")
    ''    'Else
    ''    '    'Get the Name value.
    ''    '    Console.WriteLine("The Name Attribute is: {0}.", MyAttribute.DbType)
    ''    '    'Get the Level value.
    ''    '    Console.WriteLine("The Level Attribute is: {0}.", MyAttribute.Direction)
    ''    '    'Get the Reviewed value.
    ''    '    'Console.WriteLine("The Reviewed Attribute is: {0}.", MyAttribute.Reviewed)
    ''    'End If
    ''End Function

     
End Module


'Public Class ClaseEntity
'    Inherits BrainWork.Entities.AbstractEntityBase

'End Class

'Public Class ClaseBL
'    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic

'    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
'        MyBase.New(oUser)

'        Me.DataAccess = New ClaseDA(oUser)
'        Me.Entity = New ClaseEntity()
'    End Sub


'    Public Overrides Function ClassValidation(ByRef strError As String, ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean
'        Return True
'    End Function

'    Protected Overrides Sub DeleteEntity()

'    End Sub

'    Protected Overrides Sub DisableEntity()

'    End Sub

'    Protected Overrides Sub LoadEntity()

'    End Sub

'    Protected Overrides Sub UpdateEntity()

'    End Sub





'    Protected Overrides Function GetDataReaderEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Data.IDataReader

'    End Function

'    Protected Overrides Function GetDataSetEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Data.DataSet

'    End Function

'    Protected Overrides Function GetDataTableEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Data.DataTable

'    End Function

'    Protected Overrides Function GetListEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Collections.Generic.List(Of Object)

'    End Function

'    Protected Overrides Sub LoadEntityByPk(ByVal PK As Object)

'    End Sub

'    Protected Overrides Sub AddEntity()
'        Dim oDa As New ClaseDA(Me.ApplicationUser)
'        oDa.Add()

'    End Sub
'End Class

'Public Class ClaseDA

'    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess


'    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
'        MyBase.New(oUser, New Object)
'    End Sub

'    Protected Overrides Sub AddEntity()

'    End Sub

'    Protected Overrides Sub DeleteEntity()

'    End Sub

'    Protected Overrides Sub DisableEntity()

'    End Sub

'    Protected Overrides Property GetEntity() As BrainWork.Entities.AbstractEntityBase
'        Get
'            Return Nothing
'        End Get
'        Set(ByVal value As BrainWork.Entities.AbstractEntityBase)

'        End Set
'    End Property

'    Protected Overrides Sub LoadEntityByPk(ByVal PK As Object)

'    End Sub

'    Protected Overrides Sub LoadEntity()

'    End Sub

'    Protected Overrides Sub SetStoredProcedures()
'        Me.SP_ADD = ""
'        Me.SP_DELETE = ""
'        Me.SP_DISABLE = ""
'        Me.SP_UPDATE = ""
'    End Sub

'    Protected Overrides Sub UpdateEntity()

'    End Sub

'    Protected Overrides Function GetDataReaderEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Data.IDataReader

'    End Function

'    Protected Overrides Function GetDataSetEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Data.DataSet
'        Return Me.GetDataSet(Row, Page)
'    End Function

'    Protected Overrides Function GetDataTableEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Data.DataTable

'    End Function

'    Protected Overrides Function GetListEntity(ByVal Row As Integer, ByVal Page As Integer) As System.Collections.Generic.List(Of Object)

'    End Function

'End Class




'Public Class MiClase
'    Public NombredePropiedad1 As String
'    Public Propiedad2 As Integer

'End Class

'Public Class OtraClaseQueInvoca

'    Public Sub New()
'        Dim m As New MiClase

'        Console.WriteLine(GetPropertyName(m.NombredePropiedad1))
'        'esto me debería mostrar en pantalla: NombredePropiedad1

'    End Sub

'    Public Function GetPropertyName(ByVal o As Object) As String
'        '.....
'    End Function

'End Class
