''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SystemInformationID",PrimaryKeyFieldName:="SystemInformationID",RootContainerName:="[dbo].[AWBuildVersion]")> _
Public Class EntAWBuildVersion

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Version As String
	Private  _ModifiedDate As DateTime
	Private  _SystemInformationID As Byte
	Private  _VersionDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Database Version",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[AWBuildVersion]",Order:=2,ParameterName:="Database Version",Size:=25,SourceColumn:="Database Version",TypeName:="String",MaxValue:=25,EntityClassContainer:="Ent[dbo].[AWBuildVersion]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Version() As String
	Get 
		Return   _Version
	End Get 
	Set(ByVal value As String)
		_Version = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[AWBuildVersion]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[dbo].[AWBuildVersion]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="SystemInformationID",ForeingCRUD:="ABM_AWBuildVersion",ForeingTable:="AWBuildVersion",MainTable:="[dbo].[AWBuildVersion]",Order:=1,ParameterName:="SystemInformationID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="SystemInformationID",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="EntAWBuildVersion",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SystemInformationID() As Byte
	Get 
		Return   _SystemInformationID
	End Get 
	Set(ByVal value As Byte)
		_SystemInformationID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="VersionDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[AWBuildVersion]",Order:=3,ParameterName:="VersionDate",SourceColumn:="VersionDate",TypeName:="DateTime",EntityClassContainer:="Ent[dbo].[AWBuildVersion]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property VersionDate() As DateTime
	Get 
		Return   _VersionDate
	End Get 
	Set(ByVal value As DateTime)
		_VersionDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Version = Nothing
_ModifiedDate = Nothing
_SystemInformationID = Nothing
_VersionDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="DatabaseLogID",PrimaryKeyFieldName:="DatabaseLogID",RootContainerName:="[dbo].[DatabaseLog]")> _
Public Class EntDatabaseLog

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _DatabaseLogID As Int32
	Private  _DatabaseUser As String
	Private  [_Event] As String
	Private  [_Object] As String
	Private  _PostTime As DateTime
	Private  _Schema As String
	Private  _TSQL As String
	Private  _XmlEvent As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="DatabaseLogID",ForeingCRUD:="ABM_DatabaseLog",ForeingTable:="DatabaseLog",MainTable:="[dbo].[DatabaseLog]",Order:=1,ParameterName:="DatabaseLogID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="DatabaseLogID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntDatabaseLog",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property DatabaseLogID() As Int32
	Get 
		Return   _DatabaseLogID
	End Get 
	Set(ByVal value As Int32)
		_DatabaseLogID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="DatabaseUser",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[DatabaseLog]",Order:=3,ParameterName:="DatabaseUser",Size:=128,SourceColumn:="DatabaseUser",TypeName:="String",MaxValue:=128,EntityClassContainer:="Ent[dbo].[DatabaseLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DatabaseUser() As String
	Get 
		Return   _DatabaseUser
	End Get 
	Set(ByVal value As String)
		_DatabaseUser = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Event",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[DatabaseLog]",Order:=4,ParameterName:="Event",Size:=128,SourceColumn:="Event",TypeName:="String",MaxValue:=128,EntityClassContainer:="Ent[dbo].[DatabaseLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property [Event]() As String
	Get 
		Return   [_Event]
	End Get 
	Set(ByVal value As String)
		[_Event] = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Object",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[DatabaseLog]",Order:=6,ParameterName:="Object",SetNullable:=True,Size:=128,SourceColumn:="Object",TypeName:="String",MaxValue:=128,EntityClassContainer:="Ent[dbo].[DatabaseLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property [Object]() As String
	Get 
		Return   [_Object]
	End Get 
	Set(ByVal value As String)
		[_Object] = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="PostTime",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[DatabaseLog]",Order:=2,ParameterName:="PostTime",SourceColumn:="PostTime",TypeName:="DateTime",EntityClassContainer:="Ent[dbo].[DatabaseLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PostTime() As DateTime
	Get 
		Return   _PostTime
	End Get 
	Set(ByVal value As DateTime)
		_PostTime = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Schema",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[DatabaseLog]",Order:=5,ParameterName:="Schema",SetNullable:=True,Size:=128,SourceColumn:="Schema",TypeName:="String",MaxValue:=128,EntityClassContainer:="Ent[dbo].[DatabaseLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Schema() As String
	Get 
		Return   _Schema
	End Get 
	Set(ByVal value As String)
		_Schema = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="TSQL",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[DatabaseLog]",Order:=7,ParameterName:="TSQL",Size:=-1,SourceColumn:="TSQL",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[dbo].[DatabaseLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TSQL() As String
	Get 
		Return   _TSQL
	End Get 
	Set(ByVal value As String)
		_TSQL = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="XmlEvent",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[DatabaseLog]",Order:=8,ParameterName:="XmlEvent",Size:=-1,SourceColumn:="XmlEvent",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[dbo].[DatabaseLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property XmlEvent() As String
	Get 
		Return   _XmlEvent
	End Get 
	Set(ByVal value As String)
		_XmlEvent = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_DatabaseLogID = Nothing
_DatabaseUser = Nothing
[_Event] = Nothing
[_Object] = Nothing
_PostTime = Nothing
_Schema = Nothing
_TSQL = Nothing
_XmlEvent = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ErrorLogID",PrimaryKeyFieldName:="ErrorLogID",RootContainerName:="[dbo].[ErrorLog]")> _
Public Class EntErrorLog

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ErrorLine As Int32
	Private  _ErrorLogID As Int32
	Private  _ErrorMessage As String
	Private  _ErrorNumber As Int32
	Private  _ErrorProcedure As String
	Private  _ErrorSeverity As Int32
	Private  _ErrorState As Int32
	Private  _ErrorTime As DateTime
	Private  _UserName As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ErrorLine",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=8,ParameterName:="ErrorLine",SetNullable:=True,Size:=10,SourceColumn:="ErrorLine",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ErrorLine() As Int32
	Get 
		Return   _ErrorLine
	End Get 
	Set(ByVal value As Int32)
		_ErrorLine = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ErrorLogID",ForeingCRUD:="ABM_ErrorLog",ForeingTable:="ErrorLog",MainTable:="[dbo].[ErrorLog]",Order:=1,ParameterName:="ErrorLogID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ErrorLogID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntErrorLog",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ErrorLogID() As Int32
	Get 
		Return   _ErrorLogID
	End Get 
	Set(ByVal value As Int32)
		_ErrorLogID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ErrorMessage",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=9,ParameterName:="ErrorMessage",Size:=4000,SourceColumn:="ErrorMessage",TypeName:="String",MaxValue:=4000,EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ErrorMessage() As String
	Get 
		Return   _ErrorMessage
	End Get 
	Set(ByVal value As String)
		_ErrorMessage = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ErrorNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=4,ParameterName:="ErrorNumber",Size:=10,SourceColumn:="ErrorNumber",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ErrorNumber() As Int32
	Get 
		Return   _ErrorNumber
	End Get 
	Set(ByVal value As Int32)
		_ErrorNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ErrorProcedure",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=7,ParameterName:="ErrorProcedure",SetNullable:=True,Size:=126,SourceColumn:="ErrorProcedure",TypeName:="String",MaxValue:=126,EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ErrorProcedure() As String
	Get 
		Return   _ErrorProcedure
	End Get 
	Set(ByVal value As String)
		_ErrorProcedure = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ErrorSeverity",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=5,ParameterName:="ErrorSeverity",SetNullable:=True,Size:=10,SourceColumn:="ErrorSeverity",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ErrorSeverity() As Int32
	Get 
		Return   _ErrorSeverity
	End Get 
	Set(ByVal value As Int32)
		_ErrorSeverity = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ErrorState",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=6,ParameterName:="ErrorState",SetNullable:=True,Size:=10,SourceColumn:="ErrorState",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ErrorState() As Int32
	Get 
		Return   _ErrorState
	End Get 
	Set(ByVal value As Int32)
		_ErrorState = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ErrorTime",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=2,ParameterName:="ErrorTime",SourceColumn:="ErrorTime",TypeName:="DateTime",EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ErrorTime() As DateTime
	Get 
		Return   _ErrorTime
	End Get 
	Set(ByVal value As DateTime)
		_ErrorTime = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="UserName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[ErrorLog]",Order:=3,ParameterName:="UserName",Size:=128,SourceColumn:="UserName",TypeName:="String",MaxValue:=128,EntityClassContainer:="Ent[dbo].[ErrorLog]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property UserName() As String
	Get 
		Return   _UserName
	End Get 
	Set(ByVal value As String)
		_UserName = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ErrorLine = Nothing
_ErrorLogID = Nothing
_ErrorMessage = Nothing
_ErrorNumber = Nothing
_ErrorProcedure = Nothing
_ErrorSeverity = Nothing
_ErrorState = Nothing
_ErrorTime = Nothing
_UserName = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="aaa",PrimaryKeyFieldName:="Aaa",RootContainerName:="[dbo].[Table_1]")> _
Public Class EntTable_1

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Aaa As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="aaa",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[dbo].[Table_1]",Order:=1,ParameterName:="aaa",SetNullable:=True,Size:=10,SourceColumn:="aaa",TypeName:="String",MaxValue:=10,EntityClassContainer:="Ent[dbo].[Table_1]",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property Aaa() As String
	Get 
		Return   _Aaa
	End Get 
	Set(ByVal value As String)
		_Aaa = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Aaa = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="DepartmentID",PrimaryKeyFieldName:="DepartmentID",RootContainerName:="[HumanResources].[Department]")> _
Public Class EntHumanResources_Department

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _DepartmentID As Int16
	Private  _GroupName As String
	Private  _ModifiedDate As DateTime
	Private  _Name As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="DepartmentID",ForeingCRUD:="ABM_Department",ForeingTable:="Department",MainTable:="[HumanResources].[Department]",Order:=1,ParameterName:="DepartmentID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=5,SourceColumn:="DepartmentID",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntDepartment",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property DepartmentID() As Int16
	Get 
		Return   _DepartmentID
	End Get 
	Set(ByVal value As Int16)
		_DepartmentID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="GroupName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Department]",Order:=3,ParameterName:="GroupName",Size:=50,SourceColumn:="GroupName",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[HumanResources].[Department]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property GroupName() As String
	Get 
		Return   _GroupName
	End Get 
	Set(ByVal value As String)
		_GroupName = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Department]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[Department]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Department]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[HumanResources].[Department]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_DepartmentID = Nothing
_GroupName = Nothing
_ModifiedDate = Nothing
_Name = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="EmployeeID",PrimaryKeyFieldName:="EmployeeID",RootContainerName:="[HumanResources].[Employee]")> _
Public Class EntHumanResources_Employee

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _BirthDate As DateTime
	Private  _ContactID As Int32
	Private  _CurrentFlag As Boolean
	Private  _EmployeeID As Int32
	Private  _Gender As String
	Private  _HireDate As DateTime
	Private  _LoginID As String
	Private  _ManagerID As Int32
	Private  _MaritalStatus As String
	Private  _ModifiedDate As DateTime
	Private  _NationalIDNumber As String
	Private  _Rowguid As Guid
	Private  _SalariedFlag As Boolean
	Private  _SickLeaveHours As Int16
	Private  _Title As String
	Private  _VacationHours As Int16
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="BirthDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=7,ParameterName:="BirthDate",SourceColumn:="BirthDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property BirthDate() As DateTime
	Get 
		Return   _BirthDate
	End Get 
	Set(ByVal value As DateTime)
		_BirthDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Contact",ForeingTable:="Contact",MainTable:="[HumanResources].[Employee]",Order:=3,ParameterName:="ContactID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContact",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ContactID() As Int32
	Get 
		Return   _ContactID
	End Get 
	Set(ByVal value As Int32)
		_ContactID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="CurrentFlag",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=14,ParameterName:="CurrentFlag",SourceColumn:="CurrentFlag",TypeName:="Boolean",EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CurrentFlag() As Boolean
	Get 
		Return   _CurrentFlag
	End Get 
	Set(ByVal value As Boolean)
		_CurrentFlag = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="EmployeeID",ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[HumanResources].[Employee]",Order:=1,ParameterName:="EmployeeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="EmployeeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property EmployeeID() As Int32
	Get 
		Return   _EmployeeID
	End Get 
	Set(ByVal value As Int32)
		_EmployeeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Gender",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=9,ParameterName:="Gender",Size:=1,SourceColumn:="Gender",TypeName:="String",MaxValue:=1,EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Gender() As String
	Get 
		Return   _Gender
	End Get 
	Set(ByVal value As String)
		_Gender = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="HireDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=10,ParameterName:="HireDate",SourceColumn:="HireDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property HireDate() As DateTime
	Get 
		Return   _HireDate
	End Get 
	Set(ByVal value As DateTime)
		_HireDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="LoginID",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=4,ParameterName:="LoginID",Size:=256,SourceColumn:="LoginID",TypeName:="String",MaxValue:=256,EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LoginID() As String
	Get 
		Return   _LoginID
	End Get 
	Set(ByVal value As String)
		_LoginID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ManagerID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[HumanResources].[Employee]",Order:=5,ParameterName:="ManagerID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="ManagerID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,ForeingFieldName:="ManagerID",DefaultOrderBy:= False )> _
	Public Property ManagerID() As Int32
	Get 
		Return   _ManagerID
	End Get 
	Set(ByVal value As Int32)
		_ManagerID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="MaritalStatus",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=8,ParameterName:="MaritalStatus",Size:=1,SourceColumn:="MaritalStatus",TypeName:="String",MaxValue:=1,EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property MaritalStatus() As String
	Get 
		Return   _MaritalStatus
	End Get 
	Set(ByVal value As String)
		_MaritalStatus = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=16,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="NationalIDNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=2,ParameterName:="NationalIDNumber",Size:=15,SourceColumn:="NationalIDNumber",TypeName:="String",MaxValue:=15,EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property NationalIDNumber() As String
	Get 
		Return   _NationalIDNumber
	End Get 
	Set(ByVal value As String)
		_NationalIDNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=15,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="SalariedFlag",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=11,ParameterName:="SalariedFlag",SourceColumn:="SalariedFlag",TypeName:="Boolean",EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalariedFlag() As Boolean
	Get 
		Return   _SalariedFlag
	End Get 
	Set(ByVal value As Boolean)
		_SalariedFlag = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,DefaultValue:="((0))",FieldName:="SickLeaveHours",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=13,ParameterName:="SickLeaveHours",Size:=5,SourceColumn:="SickLeaveHours",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SickLeaveHours() As Int16
	Get 
		Return   _SickLeaveHours
	End Get 
	Set(ByVal value As Int16)
		_SickLeaveHours = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Title",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=6,ParameterName:="Title",Size:=50,SourceColumn:="Title",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Title() As String
	Get 
		Return   _Title
	End Get 
	Set(ByVal value As String)
		_Title = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,DefaultValue:="((0))",FieldName:="VacationHours",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Employee]",Order:=12,ParameterName:="VacationHours",Size:=5,SourceColumn:="VacationHours",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[HumanResources].[Employee]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property VacationHours() As Int16
	Get 
		Return   _VacationHours
	End Get 
	Set(ByVal value As Int16)
		_VacationHours = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_BirthDate = Nothing
_ContactID = Nothing
_CurrentFlag = Nothing
_EmployeeID = Nothing
_Gender = Nothing
_HireDate = Nothing
_LoginID = Nothing
_ManagerID = Nothing
_MaritalStatus = Nothing
_ModifiedDate = Nothing
_NationalIDNumber = Nothing
_Rowguid = Nothing
_SalariedFlag = Nothing
_SickLeaveHours = Nothing
_Title = Nothing
_VacationHours = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="EmployeeID",PrimaryKeyFieldName:="EmployeeID",RootContainerName:="[HumanResources].[EmployeeAddress]")> _
Public Class EntHumanResources_EmployeeAddress

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AddressID As Int32
	Private  _EmployeeID As Int32
	Private  _ModifiedDate As DateTime
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AddressID",ForeingCRUD:="ABM_Address",ForeingTable:="Address",MainTable:="[HumanResources].[EmployeeAddress]",Order:=2,ParameterName:="AddressID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="AddressID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddress",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property AddressID() As Int32
	Get 
		Return   _AddressID
	End Get 
	Set(ByVal value As Int32)
		_AddressID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="EmployeeID",ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[HumanResources].[EmployeeAddress]",Order:=1,ParameterName:="EmployeeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="EmployeeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EmployeeID() As Int32
	Get 
		Return   _EmployeeID
	End Get 
	Set(ByVal value As Int32)
		_EmployeeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[EmployeeAddress]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[EmployeeAddress]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[EmployeeAddress]",Order:=3,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[HumanResources].[EmployeeAddress]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AddressID = Nothing
_EmployeeID = Nothing
_ModifiedDate = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StartDate",PrimaryKeyFieldName:="StartDate",RootContainerName:="[HumanResources].[EmployeeDepartmentHistory]")> _
Public Class EntHumanResources_EmployeeDepartmentHistory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _DepartmentID As Int16
	Private  _EmployeeID As Int32
	Private  _EndDate As DateTime
	Private  _ModifiedDate As DateTime
	Private  _ShiftID As Byte
	Private  _StartDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="DepartmentID",ForeingCRUD:="ABM_Department",ForeingTable:="Department",MainTable:="[HumanResources].[EmployeeDepartmentHistory]",Order:=2,ParameterName:="DepartmentID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=5,SourceColumn:="DepartmentID",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntDepartment",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property DepartmentID() As Int16
	Get 
		Return   _DepartmentID
	End Get 
	Set(ByVal value As Int16)
		_DepartmentID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="EmployeeID",ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[HumanResources].[EmployeeDepartmentHistory]",Order:=1,ParameterName:="EmployeeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="EmployeeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EmployeeID() As Int32
	Get 
		Return   _EmployeeID
	End Get 
	Set(ByVal value As Int32)
		_EmployeeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[EmployeeDepartmentHistory]",Order:=5,ParameterName:="EndDate",SetNullable:=True,SourceColumn:="EndDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[EmployeeDepartmentHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndDate() As DateTime
	Get 
		Return   _EndDate
	End Get 
	Set(ByVal value As DateTime)
		_EndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[EmployeeDepartmentHistory]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[EmployeeDepartmentHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="ShiftID",ForeingCRUD:="ABM_Shift",ForeingTable:="Shift",MainTable:="[HumanResources].[EmployeeDepartmentHistory]",Order:=3,ParameterName:="ShiftID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="ShiftID",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="EntShift",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShiftID() As Byte
	Get 
		Return   _ShiftID
	End Get 
	Set(ByVal value As Byte)
		_ShiftID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="StartDate",ForeingCRUD:="ABM_ProductCostHistory",ForeingTable:="ProductCostHistory",MainTable:="[HumanResources].[EmployeeDepartmentHistory]",Order:=4,ParameterName:="StartDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="StartDate",TypeName:="DateTime",EntityClassContainer:="EntProductCostHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartDate() As DateTime
	Get 
		Return   _StartDate
	End Get 
	Set(ByVal value As DateTime)
		_StartDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_DepartmentID = Nothing
_EmployeeID = Nothing
_EndDate = Nothing
_ModifiedDate = Nothing
_ShiftID = Nothing
_StartDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="RateChangeDate",PrimaryKeyFieldName:="RateChangeDate",RootContainerName:="[HumanResources].[EmployeePayHistory]")> _
Public Class EntHumanResources_EmployeePayHistory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _EmployeeID As Int32
	Private  _ModifiedDate As DateTime
	Private  _PayFrequency As Byte
	Private  _Rate As Decimal
	Private  _RateChangeDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="EmployeeID",ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[HumanResources].[EmployeePayHistory]",Order:=1,ParameterName:="EmployeeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="EmployeeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property EmployeeID() As Int32
	Get 
		Return   _EmployeeID
	End Get 
	Set(ByVal value As Int32)
		_EmployeeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[EmployeePayHistory]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[EmployeePayHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="PayFrequency",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[EmployeePayHistory]",Order:=4,ParameterName:="PayFrequency",Size:=3,SourceColumn:="PayFrequency",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[HumanResources].[EmployeePayHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PayFrequency() As Byte
	Get 
		Return   _PayFrequency
	End Get 
	Set(ByVal value As Byte)
		_PayFrequency = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="Rate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[EmployeePayHistory]",Order:=3,ParameterName:="Rate",Scale:=4,Size:=19,SourceColumn:="Rate",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[HumanResources].[EmployeePayHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rate() As Decimal
	Get 
		Return   _Rate
	End Get 
	Set(ByVal value As Decimal)
		_Rate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="RateChangeDate",ForeingCRUD:="ABM_EmployeePayHistory",ForeingTable:="EmployeePayHistory",MainTable:="[HumanResources].[EmployeePayHistory]",Order:=2,ParameterName:="RateChangeDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="RateChangeDate",TypeName:="DateTime",EntityClassContainer:="EntEmployeePayHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property RateChangeDate() As DateTime
	Get 
		Return   _RateChangeDate
	End Get 
	Set(ByVal value As DateTime)
		_RateChangeDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_EmployeeID = Nothing
_ModifiedDate = Nothing
_PayFrequency = Nothing
_Rate = Nothing
_RateChangeDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="JobCandidateID",PrimaryKeyFieldName:="JobCandidateID",RootContainerName:="[HumanResources].[JobCandidate]")> _
Public Class EntHumanResources_JobCandidate

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _EmployeeID As Int32
	Private  _JobCandidateID As Int32
	Private  _ModifiedDate As DateTime
	Private  [_Resume] As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="EmployeeID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[HumanResources].[JobCandidate]",Order:=2,ParameterName:="EmployeeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="EmployeeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EmployeeID() As Int32
	Get 
		Return   _EmployeeID
	End Get 
	Set(ByVal value As Int32)
		_EmployeeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="JobCandidateID",ForeingCRUD:="ABM_JobCandidate",ForeingTable:="JobCandidate",MainTable:="[HumanResources].[JobCandidate]",Order:=1,ParameterName:="JobCandidateID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="JobCandidateID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntJobCandidate",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property JobCandidateID() As Int32
	Get 
		Return   _JobCandidateID
	End Get 
	Set(ByVal value As Int32)
		_JobCandidateID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[JobCandidate]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[JobCandidate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Resume",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[JobCandidate]",Order:=3,ParameterName:="Resume",SetNullable:=True,Size:=-1,SourceColumn:="Resume",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[HumanResources].[JobCandidate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property [Resume]() As String
	Get 
		Return   [_Resume]
	End Get 
	Set(ByVal value As String)
		[_Resume] = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_EmployeeID = Nothing
_JobCandidateID = Nothing
_ModifiedDate = Nothing
[_Resume] = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ShiftID",PrimaryKeyFieldName:="ShiftID",RootContainerName:="[HumanResources].[Shift]")> _
Public Class EntHumanResources_Shift

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _EndTime As DateTime
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _ShiftID As Byte
	Private  _StartTime As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndTime",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Shift]",Order:=4,ParameterName:="EndTime",SourceColumn:="EndTime",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[Shift]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndTime() As DateTime
	Get 
		Return   _EndTime
	End Get 
	Set(ByVal value As DateTime)
		_EndTime = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Shift]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[Shift]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Shift]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[HumanResources].[Shift]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="ShiftID",ForeingCRUD:="ABM_Shift",ForeingTable:="Shift",MainTable:="[HumanResources].[Shift]",Order:=1,ParameterName:="ShiftID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="ShiftID",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="EntShift",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ShiftID() As Byte
	Get 
		Return   _ShiftID
	End Get 
	Set(ByVal value As Byte)
		_ShiftID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="StartTime",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[HumanResources].[Shift]",Order:=3,ParameterName:="StartTime",SourceColumn:="StartTime",TypeName:="DateTime",EntityClassContainer:="Ent[HumanResources].[Shift]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartTime() As DateTime
	Get 
		Return   _StartTime
	End Get 
	Set(ByVal value As DateTime)
		_StartTime = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_EndTime = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_ShiftID = Nothing
_StartTime = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="AddressID",PrimaryKeyFieldName:="AddressID",RootContainerName:="[Person].[Address]")> _
Public Class EntPerson_Address

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AddressID As Int32
	Private  _AddressLine1 As String
	Private  _AddressLine2 As String
	Private  _City As String
	Private  _ModifiedDate As DateTime
	Private  _PostalCode As String
	Private  _Rowguid As Guid
	Private  _StateProvinceID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AddressID",ForeingCRUD:="ABM_Address",ForeingTable:="Address",MainTable:="[Person].[Address]",Order:=1,ParameterName:="AddressID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="AddressID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddress",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property AddressID() As Int32
	Get 
		Return   _AddressID
	End Get 
	Set(ByVal value As Int32)
		_AddressID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="AddressLine1",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Address]",Order:=2,ParameterName:="AddressLine1",Size:=60,SourceColumn:="AddressLine1",TypeName:="String",MaxValue:=60,EntityClassContainer:="Ent[Person].[Address]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AddressLine1() As String
	Get 
		Return   _AddressLine1
	End Get 
	Set(ByVal value As String)
		_AddressLine1 = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="AddressLine2",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Address]",Order:=3,ParameterName:="AddressLine2",SetNullable:=True,Size:=60,SourceColumn:="AddressLine2",TypeName:="String",MaxValue:=60,EntityClassContainer:="Ent[Person].[Address]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AddressLine2() As String
	Get 
		Return   _AddressLine2
	End Get 
	Set(ByVal value As String)
		_AddressLine2 = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="City",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Address]",Order:=4,ParameterName:="City",Size:=30,SourceColumn:="City",TypeName:="String",MaxValue:=30,EntityClassContainer:="Ent[Person].[Address]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property City() As String
	Get 
		Return   _City
	End Get 
	Set(ByVal value As String)
		_City = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Address]",Order:=8,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Person].[Address]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="PostalCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Address]",Order:=6,ParameterName:="PostalCode",Size:=15,SourceColumn:="PostalCode",TypeName:="String",MaxValue:=15,EntityClassContainer:="Ent[Person].[Address]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PostalCode() As String
	Get 
		Return   _PostalCode
	End Get 
	Set(ByVal value As String)
		_PostalCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Address]",Order:=7,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Person].[Address]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="StateProvinceID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_StateProvince",ForeingTable:="StateProvince",MainTable:="[Person].[Address]",Order:=5,ParameterName:="StateProvinceID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="StateProvinceID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStateProvince",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StateProvinceID() As Int32
	Get 
		Return   _StateProvinceID
	End Get 
	Set(ByVal value As Int32)
		_StateProvinceID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AddressID = Nothing
_AddressLine1 = Nothing
_AddressLine2 = Nothing
_City = Nothing
_ModifiedDate = Nothing
_PostalCode = Nothing
_Rowguid = Nothing
_StateProvinceID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="AddressTypeID",PrimaryKeyFieldName:="AddressTypeID",RootContainerName:="[Person].[AddressType]")> _
Public Class EntPerson_AddressType

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AddressTypeID As Int32
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AddressTypeID",ForeingCRUD:="ABM_AddressType",ForeingTable:="AddressType",MainTable:="[Person].[AddressType]",Order:=1,ParameterName:="AddressTypeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="AddressTypeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddressType",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property AddressTypeID() As Int32
	Get 
		Return   _AddressTypeID
	End Get 
	Set(ByVal value As Int32)
		_AddressTypeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[AddressType]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Person].[AddressType]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[AddressType]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[AddressType]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[AddressType]",Order:=3,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Person].[AddressType]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AddressTypeID = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ContactID",PrimaryKeyFieldName:="ContactID",RootContainerName:="[Person].[Contact]")> _
Public Class EntPerson_Contact

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AdditionalContactInfo As String
	Private  _ContactID As Int32
	Private  _EmailAddress As String
	Private  _EmailPromotion As Int32
	Private  _FirstName As String
	Private  _LastName As String
	Private  _MiddleName As String
	Private  _ModifiedDate As DateTime
	Private  _NameStyle As Boolean
	Private  _PasswordHash As String
	Private  _PasswordSalt As String
	Private  _Phone As String
	Private  _Rowguid As Guid
	Private  _Suffix As String
	Private  _Title As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="AdditionalContactInfo",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=13,ParameterName:="AdditionalContactInfo",SetNullable:=True,Size:=-1,SourceColumn:="AdditionalContactInfo",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AdditionalContactInfo() As String
	Get 
		Return   _AdditionalContactInfo
	End Get 
	Set(ByVal value As String)
		_AdditionalContactInfo = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactID",ForeingCRUD:="ABM_Contact",ForeingTable:="Contact",MainTable:="[Person].[Contact]",Order:=1,ParameterName:="ContactID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContact",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ContactID() As Int32
	Get 
		Return   _ContactID
	End Get 
	Set(ByVal value As Int32)
		_ContactID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="EmailAddress",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=8,ParameterName:="EmailAddress",SetNullable:=True,Size:=50,SourceColumn:="EmailAddress",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EmailAddress() As String
	Get 
		Return   _EmailAddress
	End Get 
	Set(ByVal value As String)
		_EmailAddress = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,DefaultValue:="((0))",FieldName:="EmailPromotion",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=9,ParameterName:="EmailPromotion",Size:=10,SourceColumn:="EmailPromotion",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EmailPromotion() As Int32
	Get 
		Return   _EmailPromotion
	End Get 
	Set(ByVal value As Int32)
		_EmailPromotion = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="FirstName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=4,ParameterName:="FirstName",Size:=50,SourceColumn:="FirstName",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property FirstName() As String
	Get 
		Return   _FirstName
	End Get 
	Set(ByVal value As String)
		_FirstName = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="LastName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=6,ParameterName:="LastName",Size:=50,SourceColumn:="LastName",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LastName() As String
	Get 
		Return   _LastName
	End Get 
	Set(ByVal value As String)
		_LastName = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="MiddleName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=5,ParameterName:="MiddleName",SetNullable:=True,Size:=50,SourceColumn:="MiddleName",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property MiddleName() As String
	Get 
		Return   _MiddleName
	End Get 
	Set(ByVal value As String)
		_MiddleName = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=15,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((0))",FieldName:="NameStyle",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=2,ParameterName:="NameStyle",SourceColumn:="NameStyle",TypeName:="Boolean",EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property NameStyle() As Boolean
	Get 
		Return   _NameStyle
	End Get 
	Set(ByVal value As Boolean)
		_NameStyle = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="PasswordHash",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=11,ParameterName:="PasswordHash",Size:=128,SourceColumn:="PasswordHash",TypeName:="String",MaxValue:=128,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PasswordHash() As String
	Get 
		Return   _PasswordHash
	End Get 
	Set(ByVal value As String)
		_PasswordHash = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="PasswordSalt",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=12,ParameterName:="PasswordSalt",Size:=10,SourceColumn:="PasswordSalt",TypeName:="String",MaxValue:=10,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PasswordSalt() As String
	Get 
		Return   _PasswordSalt
	End Get 
	Set(ByVal value As String)
		_PasswordSalt = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Phone",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=10,ParameterName:="Phone",SetNullable:=True,Size:=25,SourceColumn:="Phone",TypeName:="String",MaxValue:=25,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Phone() As String
	Get 
		Return   _Phone
	End Get 
	Set(ByVal value As String)
		_Phone = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=14,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Suffix",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=7,ParameterName:="Suffix",SetNullable:=True,Size:=10,SourceColumn:="Suffix",TypeName:="String",MaxValue:=10,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Suffix() As String
	Get 
		Return   _Suffix
	End Get 
	Set(ByVal value As String)
		_Suffix = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Title",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[Contact]",Order:=3,ParameterName:="Title",SetNullable:=True,Size:=8,SourceColumn:="Title",TypeName:="String",MaxValue:=8,EntityClassContainer:="Ent[Person].[Contact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Title() As String
	Get 
		Return   _Title
	End Get 
	Set(ByVal value As String)
		_Title = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AdditionalContactInfo = Nothing
_ContactID = Nothing
_EmailAddress = Nothing
_EmailPromotion = Nothing
_FirstName = Nothing
_LastName = Nothing
_MiddleName = Nothing
_ModifiedDate = Nothing
_NameStyle = Nothing
_PasswordHash = Nothing
_PasswordSalt = Nothing
_Phone = Nothing
_Rowguid = Nothing
_Suffix = Nothing
_Title = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ContactTypeID",PrimaryKeyFieldName:="ContactTypeID",RootContainerName:="[Person].[ContactType]")> _
Public Class EntPerson_ContactType

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ContactTypeID As Int32
	Private  _ModifiedDate As DateTime
	Private  _Name As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactTypeID",ForeingCRUD:="ABM_ContactType",ForeingTable:="ContactType",MainTable:="[Person].[ContactType]",Order:=1,ParameterName:="ContactTypeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactTypeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContactType",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ContactTypeID() As Int32
	Get 
		Return   _ContactTypeID
	End Get 
	Set(ByVal value As Int32)
		_ContactTypeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[ContactType]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Person].[ContactType]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[ContactType]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[ContactType]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ContactTypeID = Nothing
_ModifiedDate = Nothing
_Name = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CountryRegionCode",PrimaryKeyFieldName:="CountryRegionCode",RootContainerName:="[Person].[CountryRegion]")> _
Public Class EntPerson_CountryRegion

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CountryRegionCode As String
	Private  _ModifiedDate As DateTime
	Private  _Name As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CountryRegionCode",ForeingCRUD:="ABM_CountryRegion",ForeingTable:="CountryRegion",MainTable:="[Person].[CountryRegion]",Order:=1,ParameterName:="CountryRegionCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="CountryRegionCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCountryRegion",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CountryRegionCode() As String
	Get 
		Return   _CountryRegionCode
	End Get 
	Set(ByVal value As String)
		_CountryRegionCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[CountryRegion]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Person].[CountryRegion]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[CountryRegion]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[CountryRegion]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CountryRegionCode = Nothing
_ModifiedDate = Nothing
_Name = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StateProvinceID",PrimaryKeyFieldName:="StateProvinceID",RootContainerName:="[Person].[StateProvince]")> _
Public Class EntPerson_StateProvince

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CountryRegionCode As String
	Private  _IsOnlyStateProvinceFlag As Boolean
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _Rowguid As Guid
	Private  _StateProvinceCode As String
	Private  _StateProvinceID As Int32
	Private  _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CountryRegionCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_CountryRegion",ForeingTable:="CountryRegion",MainTable:="[Person].[StateProvince]",Order:=3,ParameterName:="CountryRegionCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="CountryRegionCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCountryRegion",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CountryRegionCode() As String
	Get 
		Return   _CountryRegionCode
	End Get 
	Set(ByVal value As String)
		_CountryRegionCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="IsOnlyStateProvinceFlag",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[StateProvince]",Order:=4,ParameterName:="IsOnlyStateProvinceFlag",SourceColumn:="IsOnlyStateProvinceFlag",TypeName:="Boolean",EntityClassContainer:="Ent[Person].[StateProvince]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property IsOnlyStateProvinceFlag() As Boolean
	Get 
		Return   _IsOnlyStateProvinceFlag
	End Get 
	Set(ByVal value As Boolean)
		_IsOnlyStateProvinceFlag = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[StateProvince]",Order:=8,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Person].[StateProvince]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[StateProvince]",Order:=5,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Person].[StateProvince]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[StateProvince]",Order:=7,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Person].[StateProvince]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="StateProvinceCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Person].[StateProvince]",Order:=2,ParameterName:="StateProvinceCode",Size:=3,SourceColumn:="StateProvinceCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="Ent[Person].[StateProvince]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StateProvinceCode() As String
	Get 
		Return   _StateProvinceCode
	End Get 
	Set(ByVal value As String)
		_StateProvinceCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="StateProvinceID",ForeingCRUD:="ABM_StateProvince",ForeingTable:="StateProvince",MainTable:="[Person].[StateProvince]",Order:=1,ParameterName:="StateProvinceID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="StateProvinceID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStateProvince",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property StateProvinceID() As Int32
	Get 
		Return   _StateProvinceID
	End Get 
	Set(ByVal value As Int32)
		_StateProvinceID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TerritoryID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SalesTerritory",ForeingTable:="SalesTerritory",MainTable:="[Person].[StateProvince]",Order:=6,ParameterName:="TerritoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="TerritoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesTerritory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TerritoryID() As Int32
	Get 
		Return   _TerritoryID
	End Get 
	Set(ByVal value As Int32)
		_TerritoryID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CountryRegionCode = Nothing
_IsOnlyStateProvinceFlag = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_Rowguid = Nothing
_StateProvinceCode = Nothing
_StateProvinceID = Nothing
_TerritoryID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="BillOfMaterialsID",PrimaryKeyFieldName:="BillOfMaterialsID",RootContainerName:="[Production].[BillOfMaterials]")> _
Public Class EntProduction_BillOfMaterials

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _BillOfMaterialsID As Int32
	Private  _BOMLevel As Int16
	Private  _ComponentID As Int32
	Private  _EndDate As DateTime
	Private  _ModifiedDate As DateTime
	Private  _PerAssemblyQty As Decimal
	Private  _ProductAssemblyID As Int32
	Private  _StartDate As DateTime
	Private  _UnitMeasureCode As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="BillOfMaterialsID",ForeingCRUD:="ABM_BillOfMaterials",ForeingTable:="BillOfMaterials",MainTable:="[Production].[BillOfMaterials]",Order:=1,ParameterName:="BillOfMaterialsID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="BillOfMaterialsID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntBillOfMaterials",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property BillOfMaterialsID() As Int32
	Get 
		Return   _BillOfMaterialsID
	End Get 
	Set(ByVal value As Int32)
		_BillOfMaterialsID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="BOMLevel",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[BillOfMaterials]",Order:=7,ParameterName:="BOMLevel",Size:=5,SourceColumn:="BOMLevel",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Production].[BillOfMaterials]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property BOMLevel() As Int16
	Get 
		Return   _BOMLevel
	End Get 
	Set(ByVal value As Int16)
		_BOMLevel = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ComponentID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[BillOfMaterials]",Order:=3,ParameterName:="ComponentID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ComponentID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,ForeingFieldName:="ComponentID",DefaultOrderBy:= False )> _
	Public Property ComponentID() As Int32
	Get 
		Return   _ComponentID
	End Get 
	Set(ByVal value As Int32)
		_ComponentID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[BillOfMaterials]",Order:=5,ParameterName:="EndDate",SetNullable:=True,SourceColumn:="EndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[BillOfMaterials]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndDate() As DateTime
	Get 
		Return   _EndDate
	End Get 
	Set(ByVal value As DateTime)
		_EndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[BillOfMaterials]",Order:=9,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[BillOfMaterials]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((1.00))",FieldName:="PerAssemblyQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[BillOfMaterials]",Order:=8,ParameterName:="PerAssemblyQty",Scale:=2,Size:=8,SourceColumn:="PerAssemblyQty",TypeName:="Decimal",MaxValue:=8,EntityClassContainer:="Ent[Production].[BillOfMaterials]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PerAssemblyQty() As Decimal
	Get 
		Return   _PerAssemblyQty
	End Get 
	Set(ByVal value As Decimal)
		_PerAssemblyQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductAssemblyID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[BillOfMaterials]",Order:=2,ParameterName:="ProductAssemblyID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="ProductAssemblyID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,ForeingFieldName:="ProductAssemblyID",DefaultOrderBy:= False )> _
	Public Property ProductAssemblyID() As Int32
	Get 
		Return   _ProductAssemblyID
	End Get 
	Set(ByVal value As Int32)
		_ProductAssemblyID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="StartDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ProductCostHistory",ForeingTable:="ProductCostHistory",MainTable:="[Production].[BillOfMaterials]",Order:=4,ParameterName:="StartDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="StartDate",TypeName:="DateTime",EntityClassContainer:="EntProductCostHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartDate() As DateTime
	Get 
		Return   _StartDate
	End Get 
	Set(ByVal value As DateTime)
		_StartDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="UnitMeasureCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_UnitMeasure",ForeingTable:="UnitMeasure",MainTable:="[Production].[BillOfMaterials]",Order:=6,ParameterName:="UnitMeasureCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="UnitMeasureCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntUnitMeasure",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property UnitMeasureCode() As String
	Get 
		Return   _UnitMeasureCode
	End Get 
	Set(ByVal value As String)
		_UnitMeasureCode = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_BillOfMaterialsID = Nothing
_BOMLevel = Nothing
_ComponentID = Nothing
_EndDate = Nothing
_ModifiedDate = Nothing
_PerAssemblyQty = Nothing
_ProductAssemblyID = Nothing
_StartDate = Nothing
_UnitMeasureCode = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CultureID",PrimaryKeyFieldName:="CultureID",RootContainerName:="[Production].[Culture]")> _
Public Class EntProduction_Culture

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CultureID As String
	Private  _ModifiedDate As DateTime
	Private  _Name As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CultureID",ForeingCRUD:="ABM_Culture",ForeingTable:="Culture",MainTable:="[Production].[Culture]",Order:=1,ParameterName:="CultureID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=6,SourceColumn:="CultureID",TypeName:="String",MaxValue:=6,EntityClassContainer:="EntCulture",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CultureID() As String
	Get 
		Return   _CultureID
	End Get 
	Set(ByVal value As String)
		_CultureID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Culture]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Culture]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Culture]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[Culture]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CultureID = Nothing
_ModifiedDate = Nothing
_Name = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="DocumentID",PrimaryKeyFieldName:="DocumentID",RootContainerName:="[Production].[Document]")> _
Public Class EntProduction_Document

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ChangeNumber As Int32
	Private  _Document As Byte
	Private  _DocumentID As Int32
	Private  _DocumentSummary As String
	Private  _FileExtension As String
	Private  _FileName As String
	Private  _ModifiedDate As DateTime
	Private  _Revision As String
	Private  _Status As Byte
	Private  _Title As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,DefaultValue:="((0))",FieldName:="ChangeNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=6,ParameterName:="ChangeNumber",Size:=10,SourceColumn:="ChangeNumber",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ChangeNumber() As Int32
	Get 
		Return   _ChangeNumber
	End Get 
	Set(ByVal value As Int32)
		_ChangeNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="Document",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=9,ParameterName:="Document",SetNullable:=True,Size:=-1,SourceColumn:="Document",TypeName:="Byte",MaxValue:=-1,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Document() As Byte
	Get 
		Return   _Document
	End Get 
	Set(ByVal value As Byte)
		_Document = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="DocumentID",ForeingCRUD:="ABM_Document",ForeingTable:="Document",MainTable:="[Production].[Document]",Order:=1,ParameterName:="DocumentID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="DocumentID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntDocument",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property DocumentID() As Int32
	Get 
		Return   _DocumentID
	End Get 
	Set(ByVal value As Int32)
		_DocumentID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="DocumentSummary",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=8,ParameterName:="DocumentSummary",SetNullable:=True,Size:=-1,SourceColumn:="DocumentSummary",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DocumentSummary() As String
	Get 
		Return   _DocumentSummary
	End Get 
	Set(ByVal value As String)
		_DocumentSummary = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="FileExtension",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=4,ParameterName:="FileExtension",Size:=8,SourceColumn:="FileExtension",TypeName:="String",MaxValue:=8,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property FileExtension() As String
	Get 
		Return   _FileExtension
	End Get 
	Set(ByVal value As String)
		_FileExtension = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="FileName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=3,ParameterName:="FileName",Size:=400,SourceColumn:="FileName",TypeName:="String",MaxValue:=400,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property FileName() As String
	Get 
		Return   _FileName
	End Get 
	Set(ByVal value As String)
		_FileName = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=10,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Revision",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=5,ParameterName:="Revision",Size:=5,SourceColumn:="Revision",TypeName:="String",MaxValue:=5,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Revision() As String
	Get 
		Return   _Revision
	End Get 
	Set(ByVal value As String)
		_Revision = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="Status",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=7,ParameterName:="Status",Size:=3,SourceColumn:="Status",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Status() As Byte
	Get 
		Return   _Status
	End Get 
	Set(ByVal value As Byte)
		_Status = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Title",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Document]",Order:=2,ParameterName:="Title",Size:=50,SourceColumn:="Title",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[Document]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Title() As String
	Get 
		Return   _Title
	End Get 
	Set(ByVal value As String)
		_Title = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ChangeNumber = Nothing
_Document = Nothing
_DocumentID = Nothing
_DocumentSummary = Nothing
_FileExtension = Nothing
_FileName = Nothing
_ModifiedDate = Nothing
_Revision = Nothing
_Status = Nothing
_Title = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="IllustrationID",PrimaryKeyFieldName:="IllustrationID",RootContainerName:="[Production].[Illustration]")> _
Public Class EntProduction_Illustration

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Diagram As String
	Private  _IllustrationID As Int32
	Private  _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Diagram",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Illustration]",Order:=2,ParameterName:="Diagram",SetNullable:=True,Size:=-1,SourceColumn:="Diagram",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[Production].[Illustration]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Diagram() As String
	Get 
		Return   _Diagram
	End Get 
	Set(ByVal value As String)
		_Diagram = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="IllustrationID",ForeingCRUD:="ABM_Illustration",ForeingTable:="Illustration",MainTable:="[Production].[Illustration]",Order:=1,ParameterName:="IllustrationID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="IllustrationID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntIllustration",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property IllustrationID() As Int32
	Get 
		Return   _IllustrationID
	End Get 
	Set(ByVal value As Int32)
		_IllustrationID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Illustration]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Illustration]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Diagram = Nothing
_IllustrationID = Nothing
_ModifiedDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="LocationID",PrimaryKeyFieldName:="LocationID",RootContainerName:="[Production].[Location]")> _
Public Class EntProduction_Location

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Availability As Decimal
	Private  _CostRate As Decimal
	Private  _LocationID As Int16
	Private  _ModifiedDate As DateTime
	Private  _Name As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="Availability",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Location]",Order:=4,ParameterName:="Availability",Scale:=2,Size:=8,SourceColumn:="Availability",TypeName:="Decimal",MaxValue:=8,EntityClassContainer:="Ent[Production].[Location]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Availability() As Decimal
	Get 
		Return   _Availability
	End Get 
	Set(ByVal value As Decimal)
		_Availability = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="CostRate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Location]",Order:=3,ParameterName:="CostRate",Scale:=4,Size:=10,SourceColumn:="CostRate",TypeName:="Decimal",MaxValue:=10,EntityClassContainer:="Ent[Production].[Location]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CostRate() As Decimal
	Get 
		Return   _CostRate
	End Get 
	Set(ByVal value As Decimal)
		_CostRate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="LocationID",ForeingCRUD:="ABM_Location",ForeingTable:="Location",MainTable:="[Production].[Location]",Order:=1,ParameterName:="LocationID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=5,SourceColumn:="LocationID",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntLocation",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property LocationID() As Int16
	Get 
		Return   _LocationID
	End Get 
	Set(ByVal value As Int16)
		_LocationID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Location]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Location]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Location]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[Location]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Availability = Nothing
_CostRate = Nothing
_LocationID = Nothing
_ModifiedDate = Nothing
_Name = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductID",PrimaryKeyFieldName:="ProductID",RootContainerName:="[Production].[Product]")> _
Public Class EntProduction_Product

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  [_Class] As String
	Private  _Color As String
	Private  _DaysToManufacture As Int32
	Private  _DiscontinuedDate As DateTime
	Private  _FinishedGoodsFlag As Boolean
	Private  _ListPrice As Decimal
	Private  _MakeFlag As Boolean
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _ProductID As Int32
	Private  _ProductLine As String
	Private  _ProductModelID As Int32
	Private  _ProductNumber As String
	Private  _ProductSubcategoryID As Int32
	Private  _ReorderPoint As Int16
	Private  _Rowguid As Guid
	Private  _SafetyStockLevel As Int16
	Private  _SellEndDate As DateTime
	Private  _SellStartDate As DateTime
	Private  _Size As String
	Private  _SizeUnitMeasureCode As String
	Private  _StandardCost As Decimal
	Private  _Style As String
	Private  _Weight As Decimal
	Private  _WeightUnitMeasureCode As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Class",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=17,ParameterName:="Class",SetNullable:=True,Size:=2,SourceColumn:="Class",TypeName:="String",MaxValue:=2,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property [Class]() As String
	Get 
		Return   [_Class]
	End Get 
	Set(ByVal value As String)
		[_Class] = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Color",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=6,ParameterName:="Color",SetNullable:=True,Size:=15,SourceColumn:="Color",TypeName:="String",MaxValue:=15,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Color() As String
	Get 
		Return   _Color
	End Get 
	Set(ByVal value As String)
		_Color = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="DaysToManufacture",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=15,ParameterName:="DaysToManufacture",Size:=10,SourceColumn:="DaysToManufacture",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DaysToManufacture() As Int32
	Get 
		Return   _DaysToManufacture
	End Get 
	Set(ByVal value As Int32)
		_DaysToManufacture = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="DiscontinuedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=23,ParameterName:="DiscontinuedDate",SetNullable:=True,SourceColumn:="DiscontinuedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DiscontinuedDate() As DateTime
	Get 
		Return   _DiscontinuedDate
	End Get 
	Set(ByVal value As DateTime)
		_DiscontinuedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="FinishedGoodsFlag",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=5,ParameterName:="FinishedGoodsFlag",SourceColumn:="FinishedGoodsFlag",TypeName:="Boolean",EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property FinishedGoodsFlag() As Boolean
	Get 
		Return   _FinishedGoodsFlag
	End Get 
	Set(ByVal value As Boolean)
		_FinishedGoodsFlag = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="ListPrice",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=10,ParameterName:="ListPrice",Scale:=4,Size:=19,SourceColumn:="ListPrice",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ListPrice() As Decimal
	Get 
		Return   _ListPrice
	End Get 
	Set(ByVal value As Decimal)
		_ListPrice = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="MakeFlag",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=4,ParameterName:="MakeFlag",SourceColumn:="MakeFlag",TypeName:="Boolean",EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property MakeFlag() As Boolean
	Get 
		Return   _MakeFlag
	End Get 
	Set(ByVal value As Boolean)
		_MakeFlag = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=25,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[Product]",Order:=1,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ProductLine",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=16,ParameterName:="ProductLine",SetNullable:=True,Size:=2,SourceColumn:="ProductLine",TypeName:="String",MaxValue:=2,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductLine() As String
	Get 
		Return   _ProductLine
	End Get 
	Set(ByVal value As String)
		_ProductLine = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductModelID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ProductModel",ForeingTable:="ProductModel",MainTable:="[Production].[Product]",Order:=20,ParameterName:="ProductModelID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="ProductModelID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductModel",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductModelID() As Int32
	Get 
		Return   _ProductModelID
	End Get 
	Set(ByVal value As Int32)
		_ProductModelID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ProductNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=3,ParameterName:="ProductNumber",Size:=25,SourceColumn:="ProductNumber",TypeName:="String",MaxValue:=25,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductNumber() As String
	Get 
		Return   _ProductNumber
	End Get 
	Set(ByVal value As String)
		_ProductNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductSubcategoryID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ProductSubcategory",ForeingTable:="ProductSubcategory",MainTable:="[Production].[Product]",Order:=19,ParameterName:="ProductSubcategoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="ProductSubcategoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductSubcategory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductSubcategoryID() As Int32
	Get 
		Return   _ProductSubcategoryID
	End Get 
	Set(ByVal value As Int32)
		_ProductSubcategoryID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="ReorderPoint",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=8,ParameterName:="ReorderPoint",Size:=5,SourceColumn:="ReorderPoint",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReorderPoint() As Int16
	Get 
		Return   _ReorderPoint
	End Get 
	Set(ByVal value As Int16)
		_ReorderPoint = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=24,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="SafetyStockLevel",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=7,ParameterName:="SafetyStockLevel",Size:=5,SourceColumn:="SafetyStockLevel",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SafetyStockLevel() As Int16
	Get 
		Return   _SafetyStockLevel
	End Get 
	Set(ByVal value As Int16)
		_SafetyStockLevel = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="SellEndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=22,ParameterName:="SellEndDate",SetNullable:=True,SourceColumn:="SellEndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SellEndDate() As DateTime
	Get 
		Return   _SellEndDate
	End Get 
	Set(ByVal value As DateTime)
		_SellEndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="SellStartDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=21,ParameterName:="SellStartDate",SourceColumn:="SellStartDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SellStartDate() As DateTime
	Get 
		Return   _SellStartDate
	End Get 
	Set(ByVal value As DateTime)
		_SellStartDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Size",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=11,ParameterName:="Size",SetNullable:=True,Size:=5,SourceColumn:="Size",TypeName:="String",MaxValue:=5,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Size() As String
	Get 
		Return   _Size
	End Get 
	Set(ByVal value As String)
		_Size = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="SizeUnitMeasureCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_UnitMeasure",ForeingTable:="UnitMeasure",MainTable:="[Production].[Product]",Order:=12,ParameterName:="SizeUnitMeasureCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=3,SourceColumn:="SizeUnitMeasureCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntUnitMeasure",IsDescription:=False,ForeingFieldName:="SizeUnitMeasureCode",DefaultOrderBy:= False )> _
	Public Property SizeUnitMeasureCode() As String
	Get 
		Return   _SizeUnitMeasureCode
	End Get 
	Set(ByVal value As String)
		_SizeUnitMeasureCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="StandardCost",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=9,ParameterName:="StandardCost",Scale:=4,Size:=19,SourceColumn:="StandardCost",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StandardCost() As Decimal
	Get 
		Return   _StandardCost
	End Get 
	Set(ByVal value As Decimal)
		_StandardCost = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Style",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=18,ParameterName:="Style",SetNullable:=True,Size:=2,SourceColumn:="Style",TypeName:="String",MaxValue:=2,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Style() As String
	Get 
		Return   _Style
	End Get 
	Set(ByVal value As String)
		_Style = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="Weight",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[Product]",Order:=14,ParameterName:="Weight",Scale:=2,SetNullable:=True,Size:=8,SourceColumn:="Weight",TypeName:="Decimal",MaxValue:=8,EntityClassContainer:="Ent[Production].[Product]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Weight() As Decimal
	Get 
		Return   _Weight
	End Get 
	Set(ByVal value As Decimal)
		_Weight = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="WeightUnitMeasureCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_UnitMeasure",ForeingTable:="UnitMeasure",MainTable:="[Production].[Product]",Order:=13,ParameterName:="WeightUnitMeasureCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=3,SourceColumn:="WeightUnitMeasureCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntUnitMeasure",IsDescription:=False,ForeingFieldName:="WeightUnitMeasureCode",DefaultOrderBy:= False )> _
	Public Property WeightUnitMeasureCode() As String
	Get 
		Return   _WeightUnitMeasureCode
	End Get 
	Set(ByVal value As String)
		_WeightUnitMeasureCode = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
[_Class] = Nothing
_Color = Nothing
_DaysToManufacture = Nothing
_DiscontinuedDate = Nothing
_FinishedGoodsFlag = Nothing
_ListPrice = Nothing
_MakeFlag = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_ProductID = Nothing
_ProductLine = Nothing
_ProductModelID = Nothing
_ProductNumber = Nothing
_ProductSubcategoryID = Nothing
_ReorderPoint = Nothing
_Rowguid = Nothing
_SafetyStockLevel = Nothing
_SellEndDate = Nothing
_SellStartDate = Nothing
_Size = Nothing
_SizeUnitMeasureCode = Nothing
_StandardCost = Nothing
_Style = Nothing
_Weight = Nothing
_WeightUnitMeasureCode = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductCategoryID",PrimaryKeyFieldName:="ProductCategoryID",RootContainerName:="[Production].[ProductCategory]")> _
Public Class EntProduction_ProductCategory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _ProductCategoryID As Int32
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductCategory]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductCategory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductCategory]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ProductCategory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductCategoryID",ForeingCRUD:="ABM_ProductCategory",ForeingTable:="ProductCategory",MainTable:="[Production].[ProductCategory]",Order:=1,ParameterName:="ProductCategoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductCategoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductCategory",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductCategoryID() As Int32
	Get 
		Return   _ProductCategoryID
	End Get 
	Set(ByVal value As Int32)
		_ProductCategoryID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductCategory]",Order:=3,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Production].[ProductCategory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Name = Nothing
_ProductCategoryID = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StartDate",PrimaryKeyFieldName:="StartDate",RootContainerName:="[Production].[ProductCostHistory]")> _
Public Class EntProduction_ProductCostHistory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _EndDate As DateTime
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _StandardCost As Decimal
	Private  _StartDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductCostHistory]",Order:=3,ParameterName:="EndDate",SetNullable:=True,SourceColumn:="EndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductCostHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndDate() As DateTime
	Get 
		Return   _EndDate
	End Get 
	Set(ByVal value As DateTime)
		_EndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductCostHistory]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductCostHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[ProductCostHistory]",Order:=1,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="StandardCost",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductCostHistory]",Order:=4,ParameterName:="StandardCost",Scale:=4,Size:=19,SourceColumn:="StandardCost",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[ProductCostHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StandardCost() As Decimal
	Get 
		Return   _StandardCost
	End Get 
	Set(ByVal value As Decimal)
		_StandardCost = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="StartDate",ForeingCRUD:="ABM_ProductCostHistory",ForeingTable:="ProductCostHistory",MainTable:="[Production].[ProductCostHistory]",Order:=2,ParameterName:="StartDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="StartDate",TypeName:="DateTime",EntityClassContainer:="EntProductCostHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartDate() As DateTime
	Get 
		Return   _StartDate
	End Get 
	Set(ByVal value As DateTime)
		_StartDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_EndDate = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
_StandardCost = Nothing
_StartDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductDescriptionID",PrimaryKeyFieldName:="ProductDescriptionID",RootContainerName:="[Production].[ProductDescription]")> _
Public Class EntProduction_ProductDescription

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Description As String
	Private  _ModifiedDate As DateTime
	Private  _ProductDescriptionID As Int32
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Description",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductDescription]",Order:=2,ParameterName:="Description",Size:=400,SourceColumn:="Description",TypeName:="String",MaxValue:=400,EntityClassContainer:="Ent[Production].[ProductDescription]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Description() As String
	Get 
		Return   _Description
	End Get 
	Set(ByVal value As String)
		_Description = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductDescription]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductDescription]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductDescriptionID",ForeingCRUD:="ABM_ProductDescription",ForeingTable:="ProductDescription",MainTable:="[Production].[ProductDescription]",Order:=1,ParameterName:="ProductDescriptionID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductDescriptionID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductDescription",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductDescriptionID() As Int32
	Get 
		Return   _ProductDescriptionID
	End Get 
	Set(ByVal value As Int32)
		_ProductDescriptionID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductDescription]",Order:=3,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Production].[ProductDescription]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Description = Nothing
_ModifiedDate = Nothing
_ProductDescriptionID = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductID",PrimaryKeyFieldName:="ProductID",RootContainerName:="[Production].[ProductDocument]")> _
Public Class EntProduction_ProductDocument

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _DocumentID As Int32
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="DocumentID",ForeingCRUD:="ABM_Document",ForeingTable:="Document",MainTable:="[Production].[ProductDocument]",Order:=2,ParameterName:="DocumentID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="DocumentID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntDocument",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property DocumentID() As Int32
	Get 
		Return   _DocumentID
	End Get 
	Set(ByVal value As Int32)
		_DocumentID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductDocument]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductDocument]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[ProductDocument]",Order:=1,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_DocumentID = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductID",PrimaryKeyFieldName:="ProductID",RootContainerName:="[Production].[ProductInventory]")> _
Public Class EntProduction_ProductInventory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Bin As Byte
	Private  _LocationID As Int16
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _Quantity As Int16
	Private  _Rowguid As Guid
	Private  _Shelf As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="Bin",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductInventory]",Order:=4,ParameterName:="Bin",Size:=3,SourceColumn:="Bin",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Production].[ProductInventory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Bin() As Byte
	Get 
		Return   _Bin
	End Get 
	Set(ByVal value As Byte)
		_Bin = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="LocationID",ForeingCRUD:="ABM_Location",ForeingTable:="Location",MainTable:="[Production].[ProductInventory]",Order:=2,ParameterName:="LocationID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=5,SourceColumn:="LocationID",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntLocation",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property LocationID() As Int16
	Get 
		Return   _LocationID
	End Get 
	Set(ByVal value As Int16)
		_LocationID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductInventory]",Order:=7,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductInventory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[ProductInventory]",Order:=1,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,DefaultValue:="((0))",FieldName:="Quantity",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductInventory]",Order:=5,ParameterName:="Quantity",Size:=5,SourceColumn:="Quantity",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Production].[ProductInventory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Quantity() As Int16
	Get 
		Return   _Quantity
	End Get 
	Set(ByVal value As Int16)
		_Quantity = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductInventory]",Order:=6,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Production].[ProductInventory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Shelf",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductInventory]",Order:=3,ParameterName:="Shelf",Size:=10,SourceColumn:="Shelf",TypeName:="String",MaxValue:=10,EntityClassContainer:="Ent[Production].[ProductInventory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Shelf() As String
	Get 
		Return   _Shelf
	End Get 
	Set(ByVal value As String)
		_Shelf = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Bin = Nothing
_LocationID = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
_Quantity = Nothing
_Rowguid = Nothing
_Shelf = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StartDate",PrimaryKeyFieldName:="StartDate",RootContainerName:="[Production].[ProductListPriceHistory]")> _
Public Class EntProduction_ProductListPriceHistory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _EndDate As DateTime
	Private  _ListPrice As Decimal
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _StartDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductListPriceHistory]",Order:=3,ParameterName:="EndDate",SetNullable:=True,SourceColumn:="EndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductListPriceHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndDate() As DateTime
	Get 
		Return   _EndDate
	End Get 
	Set(ByVal value As DateTime)
		_EndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="ListPrice",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductListPriceHistory]",Order:=4,ParameterName:="ListPrice",Scale:=4,Size:=19,SourceColumn:="ListPrice",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[ProductListPriceHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ListPrice() As Decimal
	Get 
		Return   _ListPrice
	End Get 
	Set(ByVal value As Decimal)
		_ListPrice = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductListPriceHistory]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductListPriceHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[ProductListPriceHistory]",Order:=1,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="StartDate",ForeingCRUD:="ABM_ProductCostHistory",ForeingTable:="ProductCostHistory",MainTable:="[Production].[ProductListPriceHistory]",Order:=2,ParameterName:="StartDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="StartDate",TypeName:="DateTime",EntityClassContainer:="EntProductCostHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartDate() As DateTime
	Get 
		Return   _StartDate
	End Get 
	Set(ByVal value As DateTime)
		_StartDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_EndDate = Nothing
_ListPrice = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
_StartDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductModelID",PrimaryKeyFieldName:="ProductModelID",RootContainerName:="[Production].[ProductModel]")> _
Public Class EntProduction_ProductModel

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CatalogDescription As String
	Private  _Instructions As String
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _ProductModelID As Int32
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CatalogDescription",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductModel]",Order:=3,ParameterName:="CatalogDescription",SetNullable:=True,Size:=-1,SourceColumn:="CatalogDescription",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[Production].[ProductModel]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CatalogDescription() As String
	Get 
		Return   _CatalogDescription
	End Get 
	Set(ByVal value As String)
		_CatalogDescription = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Instructions",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductModel]",Order:=4,ParameterName:="Instructions",SetNullable:=True,Size:=-1,SourceColumn:="Instructions",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[Production].[ProductModel]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Instructions() As String
	Get 
		Return   _Instructions
	End Get 
	Set(ByVal value As String)
		_Instructions = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductModel]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductModel]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductModel]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ProductModel]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductModelID",ForeingCRUD:="ABM_ProductModel",ForeingTable:="ProductModel",MainTable:="[Production].[ProductModel]",Order:=1,ParameterName:="ProductModelID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductModelID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductModel",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductModelID() As Int32
	Get 
		Return   _ProductModelID
	End Get 
	Set(ByVal value As Int32)
		_ProductModelID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductModel]",Order:=5,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Production].[ProductModel]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CatalogDescription = Nothing
_Instructions = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_ProductModelID = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductModelID",PrimaryKeyFieldName:="ProductModelID",RootContainerName:="[Production].[ProductModelIllustration]")> _
Public Class EntProduction_ProductModelIllustration

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _IllustrationID As Int32
	Private  _ModifiedDate As DateTime
	Private  _ProductModelID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="IllustrationID",ForeingCRUD:="ABM_Illustration",ForeingTable:="Illustration",MainTable:="[Production].[ProductModelIllustration]",Order:=2,ParameterName:="IllustrationID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="IllustrationID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntIllustration",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property IllustrationID() As Int32
	Get 
		Return   _IllustrationID
	End Get 
	Set(ByVal value As Int32)
		_IllustrationID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductModelIllustration]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductModelIllustration]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductModelID",ForeingCRUD:="ABM_ProductModel",ForeingTable:="ProductModel",MainTable:="[Production].[ProductModelIllustration]",Order:=1,ParameterName:="ProductModelID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductModelID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductModel",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductModelID() As Int32
	Get 
		Return   _ProductModelID
	End Get 
	Set(ByVal value As Int32)
		_ProductModelID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_IllustrationID = Nothing
_ModifiedDate = Nothing
_ProductModelID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductModelID",PrimaryKeyFieldName:="ProductModelID",RootContainerName:="[Production].[ProductModelProductDescriptionCulture]")> _
Public Class EntProduction_ProductModelProductDescriptionCulture

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CultureID As String
	Private  _ModifiedDate As DateTime
	Private  _ProductDescriptionID As Int32
	Private  _ProductModelID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CultureID",ForeingCRUD:="ABM_Culture",ForeingTable:="Culture",MainTable:="[Production].[ProductModelProductDescriptionCulture]",Order:=3,ParameterName:="CultureID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=6,SourceColumn:="CultureID",TypeName:="String",MaxValue:=6,EntityClassContainer:="EntCulture",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CultureID() As String
	Get 
		Return   _CultureID
	End Get 
	Set(ByVal value As String)
		_CultureID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductModelProductDescriptionCulture]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductModelProductDescriptionCulture]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductDescriptionID",ForeingCRUD:="ABM_ProductDescription",ForeingTable:="ProductDescription",MainTable:="[Production].[ProductModelProductDescriptionCulture]",Order:=2,ParameterName:="ProductDescriptionID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductDescriptionID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductDescription",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductDescriptionID() As Int32
	Get 
		Return   _ProductDescriptionID
	End Get 
	Set(ByVal value As Int32)
		_ProductDescriptionID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductModelID",ForeingCRUD:="ABM_ProductModel",ForeingTable:="ProductModel",MainTable:="[Production].[ProductModelProductDescriptionCulture]",Order:=1,ParameterName:="ProductModelID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductModelID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductModel",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductModelID() As Int32
	Get 
		Return   _ProductModelID
	End Get 
	Set(ByVal value As Int32)
		_ProductModelID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CultureID = Nothing
_ModifiedDate = Nothing
_ProductDescriptionID = Nothing
_ProductModelID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductPhotoID",PrimaryKeyFieldName:="ProductPhotoID",RootContainerName:="[Production].[ProductPhoto]")> _
Public Class EntProduction_ProductPhoto

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _LargePhoto As Byte
	Private  _LargePhotoFileName As String
	Private  _ModifiedDate As DateTime
	Private  _ProductPhotoID As Int32
	Private  _ThumbNailPhoto As Byte
	Private  _ThumbnailPhotoFileName As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="LargePhoto",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductPhoto]",Order:=4,ParameterName:="LargePhoto",SetNullable:=True,Size:=-1,SourceColumn:="LargePhoto",TypeName:="Byte",MaxValue:=-1,EntityClassContainer:="Ent[Production].[ProductPhoto]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LargePhoto() As Byte
	Get 
		Return   _LargePhoto
	End Get 
	Set(ByVal value As Byte)
		_LargePhoto = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="LargePhotoFileName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductPhoto]",Order:=5,ParameterName:="LargePhotoFileName",SetNullable:=True,Size:=50,SourceColumn:="LargePhotoFileName",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ProductPhoto]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LargePhotoFileName() As String
	Get 
		Return   _LargePhotoFileName
	End Get 
	Set(ByVal value As String)
		_LargePhotoFileName = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductPhoto]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductPhoto]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductPhotoID",ForeingCRUD:="ABM_ProductPhoto",ForeingTable:="ProductPhoto",MainTable:="[Production].[ProductPhoto]",Order:=1,ParameterName:="ProductPhotoID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductPhotoID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductPhoto",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductPhotoID() As Int32
	Get 
		Return   _ProductPhotoID
	End Get 
	Set(ByVal value As Int32)
		_ProductPhotoID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="ThumbNailPhoto",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductPhoto]",Order:=2,ParameterName:="ThumbNailPhoto",SetNullable:=True,Size:=-1,SourceColumn:="ThumbNailPhoto",TypeName:="Byte",MaxValue:=-1,EntityClassContainer:="Ent[Production].[ProductPhoto]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ThumbNailPhoto() As Byte
	Get 
		Return   _ThumbNailPhoto
	End Get 
	Set(ByVal value As Byte)
		_ThumbNailPhoto = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ThumbnailPhotoFileName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductPhoto]",Order:=3,ParameterName:="ThumbnailPhotoFileName",SetNullable:=True,Size:=50,SourceColumn:="ThumbnailPhotoFileName",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ProductPhoto]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ThumbnailPhotoFileName() As String
	Get 
		Return   _ThumbnailPhotoFileName
	End Get 
	Set(ByVal value As String)
		_ThumbnailPhotoFileName = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_LargePhoto = Nothing
_LargePhotoFileName = Nothing
_ModifiedDate = Nothing
_ProductPhotoID = Nothing
_ThumbNailPhoto = Nothing
_ThumbnailPhotoFileName = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductPhotoID",PrimaryKeyFieldName:="ProductPhotoID",RootContainerName:="[Production].[ProductProductPhoto]")> _
Public Class EntProduction_ProductProductPhoto

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Primary As Boolean
	Private  _ProductID As Int32
	Private  _ProductPhotoID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductProductPhoto]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductProductPhoto]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((0))",FieldName:="Primary",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductProductPhoto]",Order:=3,ParameterName:="Primary",SourceColumn:="Primary",TypeName:="Boolean",EntityClassContainer:="Ent[Production].[ProductProductPhoto]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Primary() As Boolean
	Get 
		Return   _Primary
	End Get 
	Set(ByVal value As Boolean)
		_Primary = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[ProductProductPhoto]",Order:=1,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductPhotoID",ForeingCRUD:="ABM_ProductPhoto",ForeingTable:="ProductPhoto",MainTable:="[Production].[ProductProductPhoto]",Order:=2,ParameterName:="ProductPhotoID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductPhotoID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductPhoto",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductPhotoID() As Int32
	Get 
		Return   _ProductPhotoID
	End Get 
	Set(ByVal value As Int32)
		_ProductPhotoID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Primary = Nothing
_ProductID = Nothing
_ProductPhotoID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductReviewID",PrimaryKeyFieldName:="ProductReviewID",RootContainerName:="[Production].[ProductReview]")> _
Public Class EntProduction_ProductReview

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Comments As String
	Private  _EmailAddress As String
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _ProductReviewID As Int32
	Private  _Rating As Int32
	Private  _ReviewDate As DateTime
	Private  _ReviewerName As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Comments",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductReview]",Order:=7,ParameterName:="Comments",SetNullable:=True,Size:=3850,SourceColumn:="Comments",TypeName:="String",MaxValue:=3850,EntityClassContainer:="Ent[Production].[ProductReview]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Comments() As String
	Get 
		Return   _Comments
	End Get 
	Set(ByVal value As String)
		_Comments = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="EmailAddress",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductReview]",Order:=5,ParameterName:="EmailAddress",Size:=50,SourceColumn:="EmailAddress",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ProductReview]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EmailAddress() As String
	Get 
		Return   _EmailAddress
	End Get 
	Set(ByVal value As String)
		_EmailAddress = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductReview]",Order:=8,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductReview]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[ProductReview]",Order:=2,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductReviewID",ForeingCRUD:="ABM_ProductReview",ForeingTable:="ProductReview",MainTable:="[Production].[ProductReview]",Order:=1,ParameterName:="ProductReviewID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductReviewID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductReview",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductReviewID() As Int32
	Get 
		Return   _ProductReviewID
	End Get 
	Set(ByVal value As Int32)
		_ProductReviewID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="Rating",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductReview]",Order:=6,ParameterName:="Rating",Size:=10,SourceColumn:="Rating",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[ProductReview]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rating() As Int32
	Get 
		Return   _Rating
	End Get 
	Set(ByVal value As Int32)
		_Rating = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ReviewDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductReview]",Order:=4,ParameterName:="ReviewDate",SourceColumn:="ReviewDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductReview]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReviewDate() As DateTime
	Get 
		Return   _ReviewDate
	End Get 
	Set(ByVal value As DateTime)
		_ReviewDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ReviewerName",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductReview]",Order:=3,ParameterName:="ReviewerName",Size:=50,SourceColumn:="ReviewerName",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ProductReview]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReviewerName() As String
	Get 
		Return   _ReviewerName
	End Get 
	Set(ByVal value As String)
		_ReviewerName = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Comments = Nothing
_EmailAddress = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
_ProductReviewID = Nothing
_Rating = Nothing
_ReviewDate = Nothing
_ReviewerName = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductSubcategoryID",PrimaryKeyFieldName:="ProductSubcategoryID",RootContainerName:="[Production].[ProductSubcategory]")> _
Public Class EntProduction_ProductSubcategory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _ProductCategoryID As Int32
	Private  _ProductSubcategoryID As Int32
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductSubcategory]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ProductSubcategory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductSubcategory]",Order:=3,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ProductSubcategory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductCategoryID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ProductCategory",ForeingTable:="ProductCategory",MainTable:="[Production].[ProductSubcategory]",Order:=2,ParameterName:="ProductCategoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductCategoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductCategory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductCategoryID() As Int32
	Get 
		Return   _ProductCategoryID
	End Get 
	Set(ByVal value As Int32)
		_ProductCategoryID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductSubcategoryID",ForeingCRUD:="ABM_ProductSubcategory",ForeingTable:="ProductSubcategory",MainTable:="[Production].[ProductSubcategory]",Order:=1,ParameterName:="ProductSubcategoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductSubcategoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProductSubcategory",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductSubcategoryID() As Int32
	Get 
		Return   _ProductSubcategoryID
	End Get 
	Set(ByVal value As Int32)
		_ProductSubcategoryID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ProductSubcategory]",Order:=4,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Production].[ProductSubcategory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Name = Nothing
_ProductCategoryID = Nothing
_ProductSubcategoryID = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ScrapReasonID",PrimaryKeyFieldName:="ScrapReasonID",RootContainerName:="[Production].[ScrapReason]")> _
Public Class EntProduction_ScrapReason

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _ScrapReasonID As Int16
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ScrapReason]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[ScrapReason]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[ScrapReason]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[ScrapReason]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="ScrapReasonID",ForeingCRUD:="ABM_ScrapReason",ForeingTable:="ScrapReason",MainTable:="[Production].[ScrapReason]",Order:=1,ParameterName:="ScrapReasonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=5,SourceColumn:="ScrapReasonID",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntScrapReason",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ScrapReasonID() As Int16
	Get 
		Return   _ScrapReasonID
	End Get 
	Set(ByVal value As Int16)
		_ScrapReasonID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Name = Nothing
_ScrapReasonID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TransactionID",PrimaryKeyFieldName:="TransactionID",RootContainerName:="[Production].[TransactionHistory]")> _
Public Class EntProduction_TransactionHistory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ActualCost As Decimal
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _Quantity As Int32
	Private  _ReferenceOrderID As Int32
	Private  _ReferenceOrderLineID As Int32
	Private  _TransactionDate As DateTime
	Private  _TransactionID As Int32
	Private  _TransactionType As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="ActualCost",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistory]",Order:=8,ParameterName:="ActualCost",Scale:=4,Size:=19,SourceColumn:="ActualCost",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[TransactionHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ActualCost() As Decimal
	Get 
		Return   _ActualCost
	End Get 
	Set(ByVal value As Decimal)
		_ActualCost = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistory]",Order:=9,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[TransactionHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[TransactionHistory]",Order:=2,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="Quantity",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistory]",Order:=7,ParameterName:="Quantity",Size:=10,SourceColumn:="Quantity",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[TransactionHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Quantity() As Int32
	Get 
		Return   _Quantity
	End Get 
	Set(ByVal value As Int32)
		_Quantity = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ReferenceOrderID",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistory]",Order:=3,ParameterName:="ReferenceOrderID",Size:=10,SourceColumn:="ReferenceOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[TransactionHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReferenceOrderID() As Int32
	Get 
		Return   _ReferenceOrderID
	End Get 
	Set(ByVal value As Int32)
		_ReferenceOrderID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,DefaultValue:="((0))",FieldName:="ReferenceOrderLineID",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistory]",Order:=4,ParameterName:="ReferenceOrderLineID",Size:=10,SourceColumn:="ReferenceOrderLineID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[TransactionHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReferenceOrderLineID() As Int32
	Get 
		Return   _ReferenceOrderLineID
	End Get 
	Set(ByVal value As Int32)
		_ReferenceOrderLineID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="TransactionDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistory]",Order:=5,ParameterName:="TransactionDate",SourceColumn:="TransactionDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[TransactionHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TransactionDate() As DateTime
	Get 
		Return   _TransactionDate
	End Get 
	Set(ByVal value As DateTime)
		_TransactionDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TransactionID",ForeingCRUD:="ABM_TransactionHistory",ForeingTable:="TransactionHistory",MainTable:="[Production].[TransactionHistory]",Order:=1,ParameterName:="TransactionID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="TransactionID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntTransactionHistory",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property TransactionID() As Int32
	Get 
		Return   _TransactionID
	End Get 
	Set(ByVal value As Int32)
		_TransactionID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="TransactionType",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistory]",Order:=6,ParameterName:="TransactionType",Size:=1,SourceColumn:="TransactionType",TypeName:="String",MaxValue:=1,EntityClassContainer:="Ent[Production].[TransactionHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TransactionType() As String
	Get 
		Return   _TransactionType
	End Get 
	Set(ByVal value As String)
		_TransactionType = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ActualCost = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
_Quantity = Nothing
_ReferenceOrderID = Nothing
_ReferenceOrderLineID = Nothing
_TransactionDate = Nothing
_TransactionID = Nothing
_TransactionType = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TransactionID",PrimaryKeyFieldName:="TransactionID",RootContainerName:="[Production].[TransactionHistoryArchive]")> _
Public Class EntProduction_TransactionHistoryArchive

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ActualCost As Decimal
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _Quantity As Int32
	Private  _ReferenceOrderID As Int32
	Private  _ReferenceOrderLineID As Int32
	Private  _TransactionDate As DateTime
	Private  _TransactionID As Int32
	Private  _TransactionType As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="ActualCost",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistoryArchive]",Order:=8,ParameterName:="ActualCost",Scale:=4,Size:=19,SourceColumn:="ActualCost",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ActualCost() As Decimal
	Get 
		Return   _ActualCost
	End Get 
	Set(ByVal value As Decimal)
		_ActualCost = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistoryArchive]",Order:=9,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[TransactionHistoryArchive]",Order:=2,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="Quantity",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistoryArchive]",Order:=7,ParameterName:="Quantity",Size:=10,SourceColumn:="Quantity",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Quantity() As Int32
	Get 
		Return   _Quantity
	End Get 
	Set(ByVal value As Int32)
		_Quantity = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ReferenceOrderID",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistoryArchive]",Order:=3,ParameterName:="ReferenceOrderID",Size:=10,SourceColumn:="ReferenceOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReferenceOrderID() As Int32
	Get 
		Return   _ReferenceOrderID
	End Get 
	Set(ByVal value As Int32)
		_ReferenceOrderID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,DefaultValue:="((0))",FieldName:="ReferenceOrderLineID",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistoryArchive]",Order:=4,ParameterName:="ReferenceOrderLineID",Size:=10,SourceColumn:="ReferenceOrderLineID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReferenceOrderLineID() As Int32
	Get 
		Return   _ReferenceOrderLineID
	End Get 
	Set(ByVal value As Int32)
		_ReferenceOrderLineID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="TransactionDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistoryArchive]",Order:=5,ParameterName:="TransactionDate",SourceColumn:="TransactionDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TransactionDate() As DateTime
	Get 
		Return   _TransactionDate
	End Get 
	Set(ByVal value As DateTime)
		_TransactionDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TransactionID",ForeingCRUD:="ABM_TransactionHistory",ForeingTable:="TransactionHistory",MainTable:="[Production].[TransactionHistoryArchive]",Order:=1,ParameterName:="TransactionID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="TransactionID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntTransactionHistory",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property TransactionID() As Int32
	Get 
		Return   _TransactionID
	End Get 
	Set(ByVal value As Int32)
		_TransactionID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="TransactionType",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[TransactionHistoryArchive]",Order:=6,ParameterName:="TransactionType",Size:=1,SourceColumn:="TransactionType",TypeName:="String",MaxValue:=1,EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TransactionType() As String
	Get 
		Return   _TransactionType
	End Get 
	Set(ByVal value As String)
		_TransactionType = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ActualCost = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
_Quantity = Nothing
_ReferenceOrderID = Nothing
_ReferenceOrderLineID = Nothing
_TransactionDate = Nothing
_TransactionID = Nothing
_TransactionType = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="UnitMeasureCode",PrimaryKeyFieldName:="UnitMeasureCode",RootContainerName:="[Production].[UnitMeasure]")> _
Public Class EntProduction_UnitMeasure

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _UnitMeasureCode As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[UnitMeasure]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[UnitMeasure]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[UnitMeasure]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Production].[UnitMeasure]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="UnitMeasureCode",ForeingCRUD:="ABM_UnitMeasure",ForeingTable:="UnitMeasure",MainTable:="[Production].[UnitMeasure]",Order:=1,ParameterName:="UnitMeasureCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="UnitMeasureCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntUnitMeasure",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property UnitMeasureCode() As String
	Get 
		Return   _UnitMeasureCode
	End Get 
	Set(ByVal value As String)
		_UnitMeasureCode = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Name = Nothing
_UnitMeasureCode = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="WorkOrderID",PrimaryKeyFieldName:="WorkOrderID",RootContainerName:="[Production].[WorkOrder]")> _
Public Class EntProduction_WorkOrder

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _DueDate As DateTime
	Private  _EndDate As DateTime
	Private  _ModifiedDate As DateTime
	Private  _OrderQty As Int32
	Private  _ProductID As Int32
	Private  _ScrappedQty As Int16
	Private  _ScrapReasonID As Int16
	Private  _StartDate As DateTime
	Private  _StockedQty As Int32
	Private  _WorkOrderID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="DueDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrder]",Order:=8,ParameterName:="DueDate",SourceColumn:="DueDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrder]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DueDate() As DateTime
	Get 
		Return   _DueDate
	End Get 
	Set(ByVal value As DateTime)
		_DueDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrder]",Order:=7,ParameterName:="EndDate",SetNullable:=True,SourceColumn:="EndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrder]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndDate() As DateTime
	Get 
		Return   _EndDate
	End Get 
	Set(ByVal value As DateTime)
		_EndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrder]",Order:=10,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrder]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="OrderQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrder]",Order:=3,ParameterName:="OrderQty",Size:=10,SourceColumn:="OrderQty",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[WorkOrder]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property OrderQty() As Int32
	Get 
		Return   _OrderQty
	End Get 
	Set(ByVal value As Int32)
		_OrderQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[WorkOrder]",Order:=2,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="ScrappedQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrder]",Order:=5,ParameterName:="ScrappedQty",Size:=5,SourceColumn:="ScrappedQty",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Production].[WorkOrder]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ScrappedQty() As Int16
	Get 
		Return   _ScrappedQty
	End Get 
	Set(ByVal value As Int16)
		_ScrappedQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="ScrapReasonID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ScrapReason",ForeingTable:="ScrapReason",MainTable:="[Production].[WorkOrder]",Order:=9,ParameterName:="ScrapReasonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=5,SourceColumn:="ScrapReasonID",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntScrapReason",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ScrapReasonID() As Int16
	Get 
		Return   _ScrapReasonID
	End Get 
	Set(ByVal value As Int16)
		_ScrapReasonID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="StartDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ProductCostHistory",ForeingTable:="ProductCostHistory",MainTable:="[Production].[WorkOrder]",Order:=6,ParameterName:="StartDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="StartDate",TypeName:="DateTime",EntityClassContainer:="EntProductCostHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartDate() As DateTime
	Get 
		Return   _StartDate
	End Get 
	Set(ByVal value As DateTime)
		_StartDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="StockedQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrder]",Order:=4,ParameterName:="StockedQty",Size:=10,SourceColumn:="StockedQty",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Production].[WorkOrder]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StockedQty() As Int32
	Get 
		Return   _StockedQty
	End Get 
	Set(ByVal value As Int32)
		_StockedQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="WorkOrderID",ForeingCRUD:="ABM_WorkOrder",ForeingTable:="WorkOrder",MainTable:="[Production].[WorkOrder]",Order:=1,ParameterName:="WorkOrderID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="WorkOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntWorkOrder",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property WorkOrderID() As Int32
	Get 
		Return   _WorkOrderID
	End Get 
	Set(ByVal value As Int32)
		_WorkOrderID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_DueDate = Nothing
_EndDate = Nothing
_ModifiedDate = Nothing
_OrderQty = Nothing
_ProductID = Nothing
_ScrappedQty = Nothing
_ScrapReasonID = Nothing
_StartDate = Nothing
_StockedQty = Nothing
_WorkOrderID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="WorkOrderID",PrimaryKeyFieldName:="WorkOrderID",RootContainerName:="[Production].[WorkOrderRouting]")> _
Public Class EntProduction_WorkOrderRouting

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ActualCost As Decimal
	Private  _ActualEndDate As DateTime
	Private  _ActualResourceHrs As Decimal
	Private  _ActualStartDate As DateTime
	Private  _LocationID As Int16
	Private  _ModifiedDate As DateTime
	Private  _OperationSequence As Int16
	Private  _PlannedCost As Decimal
	Private  _ProductID As Int32
	Private  _ScheduledEndDate As DateTime
	Private  _ScheduledStartDate As DateTime
	Private  _WorkOrderID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="ActualCost",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=11,ParameterName:="ActualCost",Scale:=4,SetNullable:=True,Size:=19,SourceColumn:="ActualCost",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ActualCost() As Decimal
	Get 
		Return   _ActualCost
	End Get 
	Set(ByVal value As Decimal)
		_ActualCost = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="ActualEndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=8,ParameterName:="ActualEndDate",SetNullable:=True,SourceColumn:="ActualEndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ActualEndDate() As DateTime
	Get 
		Return   _ActualEndDate
	End Get 
	Set(ByVal value As DateTime)
		_ActualEndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="ActualResourceHrs",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=9,ParameterName:="ActualResourceHrs",Scale:=4,SetNullable:=True,Size:=9,SourceColumn:="ActualResourceHrs",TypeName:="Decimal",MaxValue:=9,EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ActualResourceHrs() As Decimal
	Get 
		Return   _ActualResourceHrs
	End Get 
	Set(ByVal value As Decimal)
		_ActualResourceHrs = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="ActualStartDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=7,ParameterName:="ActualStartDate",SetNullable:=True,SourceColumn:="ActualStartDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ActualStartDate() As DateTime
	Get 
		Return   _ActualStartDate
	End Get 
	Set(ByVal value As DateTime)
		_ActualStartDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="LocationID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Location",ForeingTable:="Location",MainTable:="[Production].[WorkOrderRouting]",Order:=4,ParameterName:="LocationID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=5,SourceColumn:="LocationID",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntLocation",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LocationID() As Int16
	Get 
		Return   _LocationID
	End Get 
	Set(ByVal value As Int16)
		_LocationID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=12,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="OperationSequence",ForeingCRUD:="ABM_WorkOrderRouting",ForeingTable:="WorkOrderRouting",MainTable:="[Production].[WorkOrderRouting]",Order:=3,ParameterName:="OperationSequence",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=5,SourceColumn:="OperationSequence",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="EntWorkOrderRouting",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property OperationSequence() As Int16
	Get 
		Return   _OperationSequence
	End Get 
	Set(ByVal value As Int16)
		_OperationSequence = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="PlannedCost",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=10,ParameterName:="PlannedCost",Scale:=4,Size:=19,SourceColumn:="PlannedCost",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PlannedCost() As Decimal
	Get 
		Return   _PlannedCost
	End Get 
	Set(ByVal value As Decimal)
		_PlannedCost = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Production].[WorkOrderRouting]",Order:=2,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="ScheduledEndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=6,ParameterName:="ScheduledEndDate",SourceColumn:="ScheduledEndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ScheduledEndDate() As DateTime
	Get 
		Return   _ScheduledEndDate
	End Get 
	Set(ByVal value As DateTime)
		_ScheduledEndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="ScheduledStartDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Production].[WorkOrderRouting]",Order:=5,ParameterName:="ScheduledStartDate",SourceColumn:="ScheduledStartDate",TypeName:="DateTime",EntityClassContainer:="Ent[Production].[WorkOrderRouting]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ScheduledStartDate() As DateTime
	Get 
		Return   _ScheduledStartDate
	End Get 
	Set(ByVal value As DateTime)
		_ScheduledStartDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="WorkOrderID",ForeingCRUD:="ABM_WorkOrder",ForeingTable:="WorkOrder",MainTable:="[Production].[WorkOrderRouting]",Order:=1,ParameterName:="WorkOrderID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="WorkOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntWorkOrder",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property WorkOrderID() As Int32
	Get 
		Return   _WorkOrderID
	End Get 
	Set(ByVal value As Int32)
		_WorkOrderID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ActualCost = Nothing
_ActualEndDate = Nothing
_ActualResourceHrs = Nothing
_ActualStartDate = Nothing
_LocationID = Nothing
_ModifiedDate = Nothing
_OperationSequence = Nothing
_PlannedCost = Nothing
_ProductID = Nothing
_ScheduledEndDate = Nothing
_ScheduledStartDate = Nothing
_WorkOrderID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID",PrimaryKeyFieldName:="VendorID",RootContainerName:="[Purchasing].[ProductVendor]")> _
Public Class EntPurchasing_ProductVendor

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AverageLeadTime As Int32
	Private  _LastReceiptCost As Decimal
	Private  _LastReceiptDate As DateTime
	Private  _MaxOrderQty As Int32
	Private  _MinOrderQty As Int32
	Private  _ModifiedDate As DateTime
	Private  _OnOrderQty As Int32
	Private  _ProductID As Int32
	Private  _StandardPrice As Decimal
	Private  _UnitMeasureCode As String
	Private  _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AverageLeadTime",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=3,ParameterName:="AverageLeadTime",Size:=10,SourceColumn:="AverageLeadTime",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AverageLeadTime() As Int32
	Get 
		Return   _AverageLeadTime
	End Get 
	Set(ByVal value As Int32)
		_AverageLeadTime = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="LastReceiptCost",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=5,ParameterName:="LastReceiptCost",Scale:=4,SetNullable:=True,Size:=19,SourceColumn:="LastReceiptCost",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LastReceiptCost() As Decimal
	Get 
		Return   _LastReceiptCost
	End Get 
	Set(ByVal value As Decimal)
		_LastReceiptCost = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="LastReceiptDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=6,ParameterName:="LastReceiptDate",SetNullable:=True,SourceColumn:="LastReceiptDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LastReceiptDate() As DateTime
	Get 
		Return   _LastReceiptDate
	End Get 
	Set(ByVal value As DateTime)
		_LastReceiptDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="MaxOrderQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=8,ParameterName:="MaxOrderQty",Size:=10,SourceColumn:="MaxOrderQty",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property MaxOrderQty() As Int32
	Get 
		Return   _MaxOrderQty
	End Get 
	Set(ByVal value As Int32)
		_MaxOrderQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="MinOrderQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=7,ParameterName:="MinOrderQty",Size:=10,SourceColumn:="MinOrderQty",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property MinOrderQty() As Int32
	Get 
		Return   _MinOrderQty
	End Get 
	Set(ByVal value As Int32)
		_MinOrderQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=11,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="OnOrderQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=9,ParameterName:="OnOrderQty",SetNullable:=True,Size:=10,SourceColumn:="OnOrderQty",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property OnOrderQty() As Int32
	Get 
		Return   _OnOrderQty
	End Get 
	Set(ByVal value As Int32)
		_OnOrderQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Purchasing].[ProductVendor]",Order:=1,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="StandardPrice",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ProductVendor]",Order:=4,ParameterName:="StandardPrice",Scale:=4,Size:=19,SourceColumn:="StandardPrice",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[ProductVendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StandardPrice() As Decimal
	Get 
		Return   _StandardPrice
	End Get 
	Set(ByVal value As Decimal)
		_StandardPrice = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="UnitMeasureCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_UnitMeasure",ForeingTable:="UnitMeasure",MainTable:="[Purchasing].[ProductVendor]",Order:=10,ParameterName:="UnitMeasureCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="UnitMeasureCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntUnitMeasure",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property UnitMeasureCode() As String
	Get 
		Return   _UnitMeasureCode
	End Get 
	Set(ByVal value As String)
		_UnitMeasureCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="VendorID",ForeingCRUD:="ABM_Vendor",ForeingTable:="Vendor",MainTable:="[Purchasing].[ProductVendor]",Order:=2,ParameterName:="VendorID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="VendorID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntVendor",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property VendorID() As Int32
	Get 
		Return   _VendorID
	End Get 
	Set(ByVal value As Int32)
		_VendorID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AverageLeadTime = Nothing
_LastReceiptCost = Nothing
_LastReceiptDate = Nothing
_MaxOrderQty = Nothing
_MinOrderQty = Nothing
_ModifiedDate = Nothing
_OnOrderQty = Nothing
_ProductID = Nothing
_StandardPrice = Nothing
_UnitMeasureCode = Nothing
_VendorID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="PurchaseOrderID",PrimaryKeyFieldName:="PurchaseOrderID",RootContainerName:="[Purchasing].[PurchaseOrderDetail]")> _
Public Class EntPurchasing_PurchaseOrderDetail

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _DueDate As DateTime
	Private  _LineTotal As Decimal
	Private  _ModifiedDate As DateTime
	Private  _OrderQty As Int16
	Private  _ProductID As Int32
	Private  _PurchaseOrderDetailID As Int32
	Private  _PurchaseOrderID As Int32
	Private  _ReceivedQty As Decimal
	Private  _RejectedQty As Decimal
	Private  _StockedQty As Decimal
	Private  _UnitPrice As Decimal
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="DueDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=3,ParameterName:="DueDate",SourceColumn:="DueDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DueDate() As DateTime
	Get 
		Return   _DueDate
	End Get 
	Set(ByVal value As DateTime)
		_DueDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="LineTotal",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=7,ParameterName:="LineTotal",Scale:=4,Size:=19,SourceColumn:="LineTotal",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LineTotal() As Decimal
	Get 
		Return   _LineTotal
	End Get 
	Set(ByVal value As Decimal)
		_LineTotal = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=11,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="OrderQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=4,ParameterName:="OrderQty",Size:=5,SourceColumn:="OrderQty",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property OrderQty() As Int16
	Get 
		Return   _OrderQty
	End Get 
	Set(ByVal value As Int16)
		_OrderQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=5,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="PurchaseOrderDetailID",ForeingCRUD:="ABM_PurchaseOrderDetail",ForeingTable:="PurchaseOrderDetail",MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=2,ParameterName:="PurchaseOrderDetailID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="PurchaseOrderDetailID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntPurchaseOrderDetail",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property PurchaseOrderDetailID() As Int32
	Get 
		Return   _PurchaseOrderDetailID
	End Get 
	Set(ByVal value As Int32)
		_PurchaseOrderDetailID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="PurchaseOrderID",ForeingCRUD:="ABM_PurchaseOrderHeader",ForeingTable:="PurchaseOrderHeader",MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=1,ParameterName:="PurchaseOrderID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="PurchaseOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntPurchaseOrderHeader",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PurchaseOrderID() As Int32
	Get 
		Return   _PurchaseOrderID
	End Get 
	Set(ByVal value As Int32)
		_PurchaseOrderID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="ReceivedQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=8,ParameterName:="ReceivedQty",Scale:=2,Size:=8,SourceColumn:="ReceivedQty",TypeName:="Decimal",MaxValue:=8,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReceivedQty() As Decimal
	Get 
		Return   _ReceivedQty
	End Get 
	Set(ByVal value As Decimal)
		_ReceivedQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="RejectedQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=9,ParameterName:="RejectedQty",Scale:=2,Size:=8,SourceColumn:="RejectedQty",TypeName:="Decimal",MaxValue:=8,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property RejectedQty() As Decimal
	Get 
		Return   _RejectedQty
	End Get 
	Set(ByVal value As Decimal)
		_RejectedQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="StockedQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=10,ParameterName:="StockedQty",Scale:=2,Size:=9,SourceColumn:="StockedQty",TypeName:="Decimal",MaxValue:=9,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StockedQty() As Decimal
	Get 
		Return   _StockedQty
	End Get 
	Set(ByVal value As Decimal)
		_StockedQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="UnitPrice",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderDetail]",Order:=6,ParameterName:="UnitPrice",Scale:=4,Size:=19,SourceColumn:="UnitPrice",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property UnitPrice() As Decimal
	Get 
		Return   _UnitPrice
	End Get 
	Set(ByVal value As Decimal)
		_UnitPrice = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_DueDate = Nothing
_LineTotal = Nothing
_ModifiedDate = Nothing
_OrderQty = Nothing
_ProductID = Nothing
_PurchaseOrderDetailID = Nothing
_PurchaseOrderID = Nothing
_ReceivedQty = Nothing
_RejectedQty = Nothing
_StockedQty = Nothing
_UnitPrice = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="PurchaseOrderID",PrimaryKeyFieldName:="PurchaseOrderID",RootContainerName:="[Purchasing].[PurchaseOrderHeader]")> _
Public Class EntPurchasing_PurchaseOrderHeader

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _EmployeeID As Int32
	Private  _Freight As Decimal
	Private  _ModifiedDate As DateTime
	Private  _OrderDate As DateTime
	Private  _PurchaseOrderID As Int32
	Private  _RevisionNumber As Byte
	Private  _ShipDate As DateTime
	Private  _ShipMethodID As Int32
	Private  _Status As Byte
	Private  _SubTotal As Decimal
	Private  _TaxAmt As Decimal
	Private  _TotalDue As Decimal
	Private  _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="EmployeeID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=4,ParameterName:="EmployeeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="EmployeeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EmployeeID() As Int32
	Get 
		Return   _EmployeeID
	End Get 
	Set(ByVal value As Int32)
		_EmployeeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="Freight",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=11,ParameterName:="Freight",Scale:=4,Size:=19,SourceColumn:="Freight",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Freight() As Decimal
	Get 
		Return   _Freight
	End Get 
	Set(ByVal value As Decimal)
		_Freight = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=13,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="OrderDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=7,ParameterName:="OrderDate",SourceColumn:="OrderDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property OrderDate() As DateTime
	Get 
		Return   _OrderDate
	End Get 
	Set(ByVal value As DateTime)
		_OrderDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="PurchaseOrderID",ForeingCRUD:="ABM_PurchaseOrderHeader",ForeingTable:="PurchaseOrderHeader",MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=1,ParameterName:="PurchaseOrderID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="PurchaseOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntPurchaseOrderHeader",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property PurchaseOrderID() As Int32
	Get 
		Return   _PurchaseOrderID
	End Get 
	Set(ByVal value As Int32)
		_PurchaseOrderID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,DefaultValue:="((0))",FieldName:="RevisionNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=2,ParameterName:="RevisionNumber",Size:=3,SourceColumn:="RevisionNumber",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property RevisionNumber() As Byte
	Get 
		Return   _RevisionNumber
	End Get 
	Set(ByVal value As Byte)
		_RevisionNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="ShipDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=8,ParameterName:="ShipDate",SetNullable:=True,SourceColumn:="ShipDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShipDate() As DateTime
	Get 
		Return   _ShipDate
	End Get 
	Set(ByVal value As DateTime)
		_ShipDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ShipMethodID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ShipMethod",ForeingTable:="ShipMethod",MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=6,ParameterName:="ShipMethodID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ShipMethodID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntShipMethod",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShipMethodID() As Int32
	Get 
		Return   _ShipMethodID
	End Get 
	Set(ByVal value As Int32)
		_ShipMethodID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,DefaultValue:="((1))",FieldName:="Status",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=3,ParameterName:="Status",Size:=3,SourceColumn:="Status",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Status() As Byte
	Get 
		Return   _Status
	End Get 
	Set(ByVal value As Byte)
		_Status = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="SubTotal",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=9,ParameterName:="SubTotal",Scale:=4,Size:=19,SourceColumn:="SubTotal",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SubTotal() As Decimal
	Get 
		Return   _SubTotal
	End Get 
	Set(ByVal value As Decimal)
		_SubTotal = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="TaxAmt",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=10,ParameterName:="TaxAmt",Scale:=4,Size:=19,SourceColumn:="TaxAmt",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TaxAmt() As Decimal
	Get 
		Return   _TaxAmt
	End Get 
	Set(ByVal value As Decimal)
		_TaxAmt = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="TotalDue",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=12,ParameterName:="TotalDue",Scale:=4,Size:=19,SourceColumn:="TotalDue",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TotalDue() As Decimal
	Get 
		Return   _TotalDue
	End Get 
	Set(ByVal value As Decimal)
		_TotalDue = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="VendorID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Vendor",ForeingTable:="Vendor",MainTable:="[Purchasing].[PurchaseOrderHeader]",Order:=5,ParameterName:="VendorID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="VendorID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntVendor",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property VendorID() As Int32
	Get 
		Return   _VendorID
	End Get 
	Set(ByVal value As Int32)
		_VendorID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_EmployeeID = Nothing
_Freight = Nothing
_ModifiedDate = Nothing
_OrderDate = Nothing
_PurchaseOrderID = Nothing
_RevisionNumber = Nothing
_ShipDate = Nothing
_ShipMethodID = Nothing
_Status = Nothing
_SubTotal = Nothing
_TaxAmt = Nothing
_TotalDue = Nothing
_VendorID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ShipMethodID",PrimaryKeyFieldName:="ShipMethodID",RootContainerName:="[Purchasing].[ShipMethod]")> _
Public Class EntPurchasing_ShipMethod

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _Rowguid As Guid
	Private  _ShipBase As Decimal
	Private  _ShipMethodID As Int32
	Private  _ShipRate As Decimal
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ShipMethod]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[ShipMethod]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ShipMethod]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Purchasing].[ShipMethod]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ShipMethod]",Order:=5,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Purchasing].[ShipMethod]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="ShipBase",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ShipMethod]",Order:=3,ParameterName:="ShipBase",Scale:=4,Size:=19,SourceColumn:="ShipBase",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[ShipMethod]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShipBase() As Decimal
	Get 
		Return   _ShipBase
	End Get 
	Set(ByVal value As Decimal)
		_ShipBase = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ShipMethodID",ForeingCRUD:="ABM_ShipMethod",ForeingTable:="ShipMethod",MainTable:="[Purchasing].[ShipMethod]",Order:=1,ParameterName:="ShipMethodID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ShipMethodID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntShipMethod",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ShipMethodID() As Int32
	Get 
		Return   _ShipMethodID
	End Get 
	Set(ByVal value As Int32)
		_ShipMethodID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="ShipRate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[ShipMethod]",Order:=4,ParameterName:="ShipRate",Scale:=4,Size:=19,SourceColumn:="ShipRate",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Purchasing].[ShipMethod]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShipRate() As Decimal
	Get 
		Return   _ShipRate
	End Get 
	Set(ByVal value As Decimal)
		_ShipRate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Name = Nothing
_Rowguid = Nothing
_ShipBase = Nothing
_ShipMethodID = Nothing
_ShipRate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID",PrimaryKeyFieldName:="VendorID",RootContainerName:="[Purchasing].[Vendor]")> _
Public Class EntPurchasing_Vendor

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AccountNumber As String
	Private  _ActiveFlag As Boolean
	Private  _CreditRating As Byte
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _PreferredVendorStatus As Boolean
	Private  _PurchasingWebServiceURL As String
	Private  _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="AccountNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[Vendor]",Order:=2,ParameterName:="AccountNumber",Size:=15,SourceColumn:="AccountNumber",TypeName:="String",MaxValue:=15,EntityClassContainer:="Ent[Purchasing].[Vendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AccountNumber() As String
	Get 
		Return   _AccountNumber
	End Get 
	Set(ByVal value As String)
		_AccountNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="ActiveFlag",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[Vendor]",Order:=6,ParameterName:="ActiveFlag",SourceColumn:="ActiveFlag",TypeName:="Boolean",EntityClassContainer:="Ent[Purchasing].[Vendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ActiveFlag() As Boolean
	Get 
		Return   _ActiveFlag
	End Get 
	Set(ByVal value As Boolean)
		_ActiveFlag = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="CreditRating",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[Vendor]",Order:=4,ParameterName:="CreditRating",Size:=3,SourceColumn:="CreditRating",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Purchasing].[Vendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CreditRating() As Byte
	Get 
		Return   _CreditRating
	End Get 
	Set(ByVal value As Byte)
		_CreditRating = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[Vendor]",Order:=8,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[Vendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[Vendor]",Order:=3,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Purchasing].[Vendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="PreferredVendorStatus",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[Vendor]",Order:=5,ParameterName:="PreferredVendorStatus",SourceColumn:="PreferredVendorStatus",TypeName:="Boolean",EntityClassContainer:="Ent[Purchasing].[Vendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PreferredVendorStatus() As Boolean
	Get 
		Return   _PreferredVendorStatus
	End Get 
	Set(ByVal value As Boolean)
		_PreferredVendorStatus = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="PurchasingWebServiceURL",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[Vendor]",Order:=7,ParameterName:="PurchasingWebServiceURL",SetNullable:=True,Size:=1024,SourceColumn:="PurchasingWebServiceURL",TypeName:="String",MaxValue:=1024,EntityClassContainer:="Ent[Purchasing].[Vendor]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PurchasingWebServiceURL() As String
	Get 
		Return   _PurchasingWebServiceURL
	End Get 
	Set(ByVal value As String)
		_PurchasingWebServiceURL = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="VendorID",ForeingCRUD:="ABM_Vendor",ForeingTable:="Vendor",MainTable:="[Purchasing].[Vendor]",Order:=1,ParameterName:="VendorID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="VendorID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntVendor",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property VendorID() As Int32
	Get 
		Return   _VendorID
	End Get 
	Set(ByVal value As Int32)
		_VendorID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AccountNumber = Nothing
_ActiveFlag = Nothing
_CreditRating = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_PreferredVendorStatus = Nothing
_PurchasingWebServiceURL = Nothing
_VendorID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID",PrimaryKeyFieldName:="VendorID",RootContainerName:="[Purchasing].[VendorAddress]")> _
Public Class EntPurchasing_VendorAddress

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AddressID As Int32
	Private  _AddressTypeID As Int32
	Private  _ModifiedDate As DateTime
	Private  _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AddressID",ForeingCRUD:="ABM_Address",ForeingTable:="Address",MainTable:="[Purchasing].[VendorAddress]",Order:=2,ParameterName:="AddressID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="AddressID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddress",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property AddressID() As Int32
	Get 
		Return   _AddressID
	End Get 
	Set(ByVal value As Int32)
		_AddressID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AddressTypeID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_AddressType",ForeingTable:="AddressType",MainTable:="[Purchasing].[VendorAddress]",Order:=3,ParameterName:="AddressTypeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="AddressTypeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddressType",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AddressTypeID() As Int32
	Get 
		Return   _AddressTypeID
	End Get 
	Set(ByVal value As Int32)
		_AddressTypeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[VendorAddress]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[VendorAddress]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="VendorID",ForeingCRUD:="ABM_Vendor",ForeingTable:="Vendor",MainTable:="[Purchasing].[VendorAddress]",Order:=1,ParameterName:="VendorID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="VendorID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntVendor",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property VendorID() As Int32
	Get 
		Return   _VendorID
	End Get 
	Set(ByVal value As Int32)
		_VendorID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AddressID = Nothing
_AddressTypeID = Nothing
_ModifiedDate = Nothing
_VendorID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID",PrimaryKeyFieldName:="VendorID",RootContainerName:="[Purchasing].[VendorContact]")> _
Public Class EntPurchasing_VendorContact

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ContactID As Int32
	Private  _ContactTypeID As Int32
	Private  _ModifiedDate As DateTime
	Private  _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactID",ForeingCRUD:="ABM_Contact",ForeingTable:="Contact",MainTable:="[Purchasing].[VendorContact]",Order:=2,ParameterName:="ContactID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContact",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ContactID() As Int32
	Get 
		Return   _ContactID
	End Get 
	Set(ByVal value As Int32)
		_ContactID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactTypeID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ContactType",ForeingTable:="ContactType",MainTable:="[Purchasing].[VendorContact]",Order:=3,ParameterName:="ContactTypeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactTypeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContactType",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ContactTypeID() As Int32
	Get 
		Return   _ContactTypeID
	End Get 
	Set(ByVal value As Int32)
		_ContactTypeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Purchasing].[VendorContact]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Purchasing].[VendorContact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="VendorID",ForeingCRUD:="ABM_Vendor",ForeingTable:="Vendor",MainTable:="[Purchasing].[VendorContact]",Order:=1,ParameterName:="VendorID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="VendorID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntVendor",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property VendorID() As Int32
	Get 
		Return   _VendorID
	End Get 
	Set(ByVal value As Int32)
		_VendorID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ContactID = Nothing
_ContactTypeID = Nothing
_ModifiedDate = Nothing
_VendorID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CreditCardID",PrimaryKeyFieldName:="CreditCardID",RootContainerName:="[Sales].[ContactCreditCard]")> _
Public Class EntSales_ContactCreditCard

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ContactID As Int32
	Private  _CreditCardID As Int32
	Private  _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactID",ForeingCRUD:="ABM_Contact",ForeingTable:="Contact",MainTable:="[Sales].[ContactCreditCard]",Order:=1,ParameterName:="ContactID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContact",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ContactID() As Int32
	Get 
		Return   _ContactID
	End Get 
	Set(ByVal value As Int32)
		_ContactID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CreditCardID",ForeingCRUD:="ABM_CreditCard",ForeingTable:="CreditCard",MainTable:="[Sales].[ContactCreditCard]",Order:=2,ParameterName:="CreditCardID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CreditCardID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntCreditCard",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CreditCardID() As Int32
	Get 
		Return   _CreditCardID
	End Get 
	Set(ByVal value As Int32)
		_CreditCardID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[ContactCreditCard]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[ContactCreditCard]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ContactID = Nothing
_CreditCardID = Nothing
_ModifiedDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CurrencyCode",PrimaryKeyFieldName:="CurrencyCode",RootContainerName:="[Sales].[CountryRegionCurrency]")> _
Public Class EntSales_CountryRegionCurrency

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CountryRegionCode As String
	Private  _CurrencyCode As String
	Private  _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CountryRegionCode",ForeingCRUD:="ABM_CountryRegion",ForeingTable:="CountryRegion",MainTable:="[Sales].[CountryRegionCurrency]",Order:=1,ParameterName:="CountryRegionCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="CountryRegionCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCountryRegion",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CountryRegionCode() As String
	Get 
		Return   _CountryRegionCode
	End Get 
	Set(ByVal value As String)
		_CountryRegionCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CurrencyCode",ForeingCRUD:="ABM_Currency",ForeingTable:="Currency",MainTable:="[Sales].[CountryRegionCurrency]",Order:=2,ParameterName:="CurrencyCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="CurrencyCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCurrency",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CurrencyCode() As String
	Get 
		Return   _CurrencyCode
	End Get 
	Set(ByVal value As String)
		_CurrencyCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CountryRegionCurrency]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[CountryRegionCurrency]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CountryRegionCode = Nothing
_CurrencyCode = Nothing
_ModifiedDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CreditCardID",PrimaryKeyFieldName:="CreditCardID",RootContainerName:="[Sales].[CreditCard]")> _
Public Class EntSales_CreditCard

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CardNumber As String
	Private  _CardType As String
	Private  _CreditCardID As Int32
	Private  _ExpMonth As Byte
	Private  _ExpYear As Int16
	Private  _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CardNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CreditCard]",Order:=3,ParameterName:="CardNumber",Size:=25,SourceColumn:="CardNumber",TypeName:="String",MaxValue:=25,EntityClassContainer:="Ent[Sales].[CreditCard]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CardNumber() As String
	Get 
		Return   _CardNumber
	End Get 
	Set(ByVal value As String)
		_CardNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CardType",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CreditCard]",Order:=2,ParameterName:="CardType",Size:=50,SourceColumn:="CardType",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[CreditCard]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CardType() As String
	Get 
		Return   _CardType
	End Get 
	Set(ByVal value As String)
		_CardType = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CreditCardID",ForeingCRUD:="ABM_CreditCard",ForeingTable:="CreditCard",MainTable:="[Sales].[CreditCard]",Order:=1,ParameterName:="CreditCardID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CreditCardID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntCreditCard",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CreditCardID() As Int32
	Get 
		Return   _CreditCardID
	End Get 
	Set(ByVal value As Int32)
		_CreditCardID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="ExpMonth",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CreditCard]",Order:=4,ParameterName:="ExpMonth",Size:=3,SourceColumn:="ExpMonth",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Sales].[CreditCard]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ExpMonth() As Byte
	Get 
		Return   _ExpMonth
	End Get 
	Set(ByVal value As Byte)
		_ExpMonth = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="ExpYear",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CreditCard]",Order:=5,ParameterName:="ExpYear",Size:=5,SourceColumn:="ExpYear",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Sales].[CreditCard]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ExpYear() As Int16
	Get 
		Return   _ExpYear
	End Get 
	Set(ByVal value As Int16)
		_ExpYear = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CreditCard]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[CreditCard]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CardNumber = Nothing
_CardType = Nothing
_CreditCardID = Nothing
_ExpMonth = Nothing
_ExpYear = Nothing
_ModifiedDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CurrencyCode",PrimaryKeyFieldName:="CurrencyCode",RootContainerName:="[Sales].[Currency]")> _
Public Class EntSales_Currency

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CurrencyCode As String
	Private  _ModifiedDate As DateTime
	Private  _Name As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CurrencyCode",ForeingCRUD:="ABM_Currency",ForeingTable:="Currency",MainTable:="[Sales].[Currency]",Order:=1,ParameterName:="CurrencyCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="CurrencyCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCurrency",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CurrencyCode() As String
	Get 
		Return   _CurrencyCode
	End Get 
	Set(ByVal value As String)
		_CurrencyCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Currency]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[Currency]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Currency]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[Currency]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CurrencyCode = Nothing
_ModifiedDate = Nothing
_Name = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CurrencyRateID",PrimaryKeyFieldName:="CurrencyRateID",RootContainerName:="[Sales].[CurrencyRate]")> _
Public Class EntSales_CurrencyRate

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AverageRate As Decimal
	Private  _CurrencyRateDate As DateTime
	Private  _CurrencyRateID As Int32
	Private  _EndOfDayRate As Decimal
	Private  _FromCurrencyCode As String
	Private  _ModifiedDate As DateTime
	Private  _ToCurrencyCode As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="AverageRate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CurrencyRate]",Order:=5,ParameterName:="AverageRate",Scale:=4,Size:=19,SourceColumn:="AverageRate",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[CurrencyRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AverageRate() As Decimal
	Get 
		Return   _AverageRate
	End Get 
	Set(ByVal value As Decimal)
		_AverageRate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="CurrencyRateDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CurrencyRate]",Order:=2,ParameterName:="CurrencyRateDate",SourceColumn:="CurrencyRateDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[CurrencyRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CurrencyRateDate() As DateTime
	Get 
		Return   _CurrencyRateDate
	End Get 
	Set(ByVal value As DateTime)
		_CurrencyRateDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CurrencyRateID",ForeingCRUD:="ABM_CurrencyRate",ForeingTable:="CurrencyRate",MainTable:="[Sales].[CurrencyRate]",Order:=1,ParameterName:="CurrencyRateID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CurrencyRateID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntCurrencyRate",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CurrencyRateID() As Int32
	Get 
		Return   _CurrencyRateID
	End Get 
	Set(ByVal value As Int32)
		_CurrencyRateID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="EndOfDayRate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CurrencyRate]",Order:=6,ParameterName:="EndOfDayRate",Scale:=4,Size:=19,SourceColumn:="EndOfDayRate",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[CurrencyRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndOfDayRate() As Decimal
	Get 
		Return   _EndOfDayRate
	End Get 
	Set(ByVal value As Decimal)
		_EndOfDayRate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="FromCurrencyCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Currency",ForeingTable:="Currency",MainTable:="[Sales].[CurrencyRate]",Order:=3,ParameterName:="FromCurrencyCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="FromCurrencyCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCurrency",IsDescription:=False,ForeingFieldName:="FromCurrencyCode",DefaultOrderBy:= False )> _
	Public Property FromCurrencyCode() As String
	Get 
		Return   _FromCurrencyCode
	End Get 
	Set(ByVal value As String)
		_FromCurrencyCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CurrencyRate]",Order:=7,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[CurrencyRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ToCurrencyCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Currency",ForeingTable:="Currency",MainTable:="[Sales].[CurrencyRate]",Order:=4,ParameterName:="ToCurrencyCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="ToCurrencyCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCurrency",IsDescription:=False,ForeingFieldName:="ToCurrencyCode",DefaultOrderBy:= False )> _
	Public Property ToCurrencyCode() As String
	Get 
		Return   _ToCurrencyCode
	End Get 
	Set(ByVal value As String)
		_ToCurrencyCode = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AverageRate = Nothing
_CurrencyRateDate = Nothing
_CurrencyRateID = Nothing
_EndOfDayRate = Nothing
_FromCurrencyCode = Nothing
_ModifiedDate = Nothing
_ToCurrencyCode = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID",PrimaryKeyFieldName:="CustomerID",RootContainerName:="[Sales].[Customer]")> _
Public Class EntSales_Customer

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AccountNumber As String
	Private  _CustomerID As Int32
	Private  _CustomerType As String
	Private  _ModifiedDate As DateTime
	Private  _Rowguid As Guid
	Private  _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="AccountNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Customer]",Order:=3,ParameterName:="AccountNumber",Size:=10,SourceColumn:="AccountNumber",TypeName:="String",MaxValue:=10,EntityClassContainer:="Ent[Sales].[Customer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AccountNumber() As String
	Get 
		Return   _AccountNumber
	End Get 
	Set(ByVal value As String)
		_AccountNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CustomerID",ForeingCRUD:="ABM_Store",ForeingTable:="Store",MainTable:="[Sales].[Customer]",Order:=1,ParameterName:="CustomerID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CustomerID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStore",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CustomerID() As Int32
	Get 
		Return   _CustomerID
	End Get 
	Set(ByVal value As Int32)
		_CustomerID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CustomerType",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Customer]",Order:=4,ParameterName:="CustomerType",Size:=1,SourceColumn:="CustomerType",TypeName:="String",MaxValue:=1,EntityClassContainer:="Ent[Sales].[Customer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CustomerType() As String
	Get 
		Return   _CustomerType
	End Get 
	Set(ByVal value As String)
		_CustomerType = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Customer]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[Customer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Customer]",Order:=5,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[Customer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TerritoryID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SalesTerritory",ForeingTable:="SalesTerritory",MainTable:="[Sales].[Customer]",Order:=2,ParameterName:="TerritoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="TerritoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesTerritory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TerritoryID() As Int32
	Get 
		Return   _TerritoryID
	End Get 
	Set(ByVal value As Int32)
		_TerritoryID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AccountNumber = Nothing
_CustomerID = Nothing
_CustomerType = Nothing
_ModifiedDate = Nothing
_Rowguid = Nothing
_TerritoryID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID",PrimaryKeyFieldName:="CustomerID",RootContainerName:="[Sales].[CustomerAddress]")> _
Public Class EntSales_CustomerAddress

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AddressID As Int32
	Private  _AddressTypeID As Int32
	Private  _CustomerID As Int32
	Private  _ModifiedDate As DateTime
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AddressID",ForeingCRUD:="ABM_Address",ForeingTable:="Address",MainTable:="[Sales].[CustomerAddress]",Order:=2,ParameterName:="AddressID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="AddressID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddress",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property AddressID() As Int32
	Get 
		Return   _AddressID
	End Get 
	Set(ByVal value As Int32)
		_AddressID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="AddressTypeID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_AddressType",ForeingTable:="AddressType",MainTable:="[Sales].[CustomerAddress]",Order:=3,ParameterName:="AddressTypeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="AddressTypeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddressType",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AddressTypeID() As Int32
	Get 
		Return   _AddressTypeID
	End Get 
	Set(ByVal value As Int32)
		_AddressTypeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CustomerID",ForeingCRUD:="ABM_Store",ForeingTable:="Store",MainTable:="[Sales].[CustomerAddress]",Order:=1,ParameterName:="CustomerID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CustomerID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStore",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CustomerID() As Int32
	Get 
		Return   _CustomerID
	End Get 
	Set(ByVal value As Int32)
		_CustomerID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CustomerAddress]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[CustomerAddress]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[CustomerAddress]",Order:=4,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[CustomerAddress]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AddressID = Nothing
_AddressTypeID = Nothing
_CustomerID = Nothing
_ModifiedDate = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID",PrimaryKeyFieldName:="CustomerID",RootContainerName:="[Sales].[Individual]")> _
Public Class EntSales_Individual

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ContactID As Int32
	Private  _CustomerID As Int32
	Private  _Demographics As String
	Private  _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Contact",ForeingTable:="Contact",MainTable:="[Sales].[Individual]",Order:=2,ParameterName:="ContactID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContact",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ContactID() As Int32
	Get 
		Return   _ContactID
	End Get 
	Set(ByVal value As Int32)
		_ContactID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CustomerID",ForeingCRUD:="ABM_Store",ForeingTable:="Store",MainTable:="[Sales].[Individual]",Order:=1,ParameterName:="CustomerID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CustomerID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStore",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CustomerID() As Int32
	Get 
		Return   _CustomerID
	End Get 
	Set(ByVal value As Int32)
		_CustomerID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Demographics",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Individual]",Order:=3,ParameterName:="Demographics",SetNullable:=True,Size:=-1,SourceColumn:="Demographics",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[Sales].[Individual]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Demographics() As String
	Get 
		Return   _Demographics
	End Get 
	Set(ByVal value As String)
		_Demographics = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Individual]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[Individual]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ContactID = Nothing
_CustomerID = Nothing
_Demographics = Nothing
_ModifiedDate = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesOrderID",PrimaryKeyFieldName:="SalesOrderID",RootContainerName:="[Sales].[SalesOrderDetail]")> _
Public Class EntSales_SalesOrderDetail

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CarrierTrackingNumber As String
	Private  _LineTotal As Decimal
	Private  _ModifiedDate As DateTime
	Private  _OrderQty As Int16
	Private  _ProductID As Int32
	Private  _Rowguid As Guid
	Private  _SalesOrderDetailID As Int32
	Private  _SalesOrderID As Int32
	Private  _SpecialOfferID As Int32
	Private  _UnitPrice As Decimal
	Private  _UnitPriceDiscount As Decimal
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CarrierTrackingNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderDetail]",Order:=3,ParameterName:="CarrierTrackingNumber",SetNullable:=True,Size:=25,SourceColumn:="CarrierTrackingNumber",TypeName:="String",MaxValue:=25,EntityClassContainer:="Ent[Sales].[SalesOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CarrierTrackingNumber() As String
	Get 
		Return   _CarrierTrackingNumber
	End Get 
	Set(ByVal value As String)
		_CarrierTrackingNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="LineTotal",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderDetail]",Order:=9,ParameterName:="LineTotal",Scale:=6,Size:=38,SourceColumn:="LineTotal",TypeName:="Decimal",MaxValue:=38,EntityClassContainer:="Ent[Sales].[SalesOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property LineTotal() As Decimal
	Get 
		Return   _LineTotal
	End Get 
	Set(ByVal value As Decimal)
		_LineTotal = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderDetail]",Order:=11,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16,FieldName:="OrderQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderDetail]",Order:=4,ParameterName:="OrderQty",Size:=5,SourceColumn:="OrderQty",TypeName:="Int16",MaxValue:=5,EntityClassContainer:="Ent[Sales].[SalesOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property OrderQty() As Int16
	Get 
		Return   _OrderQty
	End Get 
	Set(ByVal value As Int16)
		_OrderQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SpecialOfferProduct",ForeingTable:="SpecialOfferProduct",MainTable:="[Sales].[SalesOrderDetail]",Order:=5,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSpecialOfferProduct",IsDescription:=False,ForeingFieldName:="ProductID",DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderDetail]",Order:=10,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SalesOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesOrderDetailID",ForeingCRUD:="ABM_SalesOrderDetail",ForeingTable:="SalesOrderDetail",MainTable:="[Sales].[SalesOrderDetail]",Order:=2,ParameterName:="SalesOrderDetailID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesOrderDetailID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesOrderDetail",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SalesOrderDetailID() As Int32
	Get 
		Return   _SalesOrderDetailID
	End Get 
	Set(ByVal value As Int32)
		_SalesOrderDetailID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesOrderID",ForeingCRUD:="ABM_SalesOrderHeader",ForeingTable:="SalesOrderHeader",MainTable:="[Sales].[SalesOrderDetail]",Order:=1,ParameterName:="SalesOrderID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesOrderHeader",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesOrderID() As Int32
	Get 
		Return   _SalesOrderID
	End Get 
	Set(ByVal value As Int32)
		_SalesOrderID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SpecialOfferID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SpecialOfferProduct",ForeingTable:="SpecialOfferProduct",MainTable:="[Sales].[SalesOrderDetail]",Order:=6,ParameterName:="SpecialOfferID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SpecialOfferID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSpecialOfferProduct",IsDescription:=False,ForeingFieldName:="SpecialOfferID",DefaultOrderBy:= False )> _
	Public Property SpecialOfferID() As Int32
	Get 
		Return   _SpecialOfferID
	End Get 
	Set(ByVal value As Int32)
		_SpecialOfferID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="UnitPrice",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderDetail]",Order:=7,ParameterName:="UnitPrice",Scale:=4,Size:=19,SourceColumn:="UnitPrice",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property UnitPrice() As Decimal
	Get 
		Return   _UnitPrice
	End Get 
	Set(ByVal value As Decimal)
		_UnitPrice = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.0))",FieldName:="UnitPriceDiscount",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderDetail]",Order:=8,ParameterName:="UnitPriceDiscount",Scale:=4,Size:=19,SourceColumn:="UnitPriceDiscount",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesOrderDetail]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property UnitPriceDiscount() As Decimal
	Get 
		Return   _UnitPriceDiscount
	End Get 
	Set(ByVal value As Decimal)
		_UnitPriceDiscount = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CarrierTrackingNumber = Nothing
_LineTotal = Nothing
_ModifiedDate = Nothing
_OrderQty = Nothing
_ProductID = Nothing
_Rowguid = Nothing
_SalesOrderDetailID = Nothing
_SalesOrderID = Nothing
_SpecialOfferID = Nothing
_UnitPrice = Nothing
_UnitPriceDiscount = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesOrderID",PrimaryKeyFieldName:="SalesOrderID",RootContainerName:="[Sales].[SalesOrderHeader]")> _
Public Class EntSales_SalesOrderHeader

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _AccountNumber As String
	Private  _BillToAddressID As Int32
	Private  _Comment As String
	Private  _ContactID As Int32
	Private  _CreditCardApprovalCode As String
	Private  _CreditCardID As Int32
	Private  _CurrencyRateID As Int32
	Private  _CustomerID As Int32
	Private  _DueDate As DateTime
	Private  _Freight As Decimal
	Private  _ModifiedDate As DateTime
	Private  _OnlineOrderFlag As Boolean
	Private  _OrderDate As DateTime
	Private  _PurchaseOrderNumber As String
	Private  _RevisionNumber As Byte
	Private  _Rowguid As Guid
	Private  _SalesOrderID As Int32
	Private  _SalesOrderNumber As String
	Private  _SalesPersonID As Int32
	Private  _ShipDate As DateTime
	Private  _ShipMethodID As Int32
	Private  _ShipToAddressID As Int32
	Private  _Status As Byte
	Private  _SubTotal As Decimal
	Private  _TaxAmt As Decimal
	Private  _TerritoryID As Int32
	Private  _TotalDue As Decimal
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="AccountNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=10,ParameterName:="AccountNumber",SetNullable:=True,Size:=15,SourceColumn:="AccountNumber",TypeName:="String",MaxValue:=15,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property AccountNumber() As String
	Get 
		Return   _AccountNumber
	End Get 
	Set(ByVal value As String)
		_AccountNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="BillToAddressID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Address",ForeingTable:="Address",MainTable:="[Sales].[SalesOrderHeader]",Order:=15,ParameterName:="BillToAddressID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="BillToAddressID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddress",IsDescription:=False,ForeingFieldName:="BillToAddressID",DefaultOrderBy:= False )> _
	Public Property BillToAddressID() As Int32
	Get 
		Return   _BillToAddressID
	End Get 
	Set(ByVal value As Int32)
		_BillToAddressID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Comment",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=25,ParameterName:="Comment",SetNullable:=True,Size:=128,SourceColumn:="Comment",TypeName:="String",MaxValue:=128,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Comment() As String
	Get 
		Return   _Comment
	End Get 
	Set(ByVal value As String)
		_Comment = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Contact",ForeingTable:="Contact",MainTable:="[Sales].[SalesOrderHeader]",Order:=12,ParameterName:="ContactID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContact",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ContactID() As Int32
	Get 
		Return   _ContactID
	End Get 
	Set(ByVal value As Int32)
		_ContactID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CreditCardApprovalCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=19,ParameterName:="CreditCardApprovalCode",SetNullable:=True,Size:=15,SourceColumn:="CreditCardApprovalCode",TypeName:="String",MaxValue:=15,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CreditCardApprovalCode() As String
	Get 
		Return   _CreditCardApprovalCode
	End Get 
	Set(ByVal value As String)
		_CreditCardApprovalCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CreditCardID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_CreditCard",ForeingTable:="CreditCard",MainTable:="[Sales].[SalesOrderHeader]",Order:=18,ParameterName:="CreditCardID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="CreditCardID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntCreditCard",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CreditCardID() As Int32
	Get 
		Return   _CreditCardID
	End Get 
	Set(ByVal value As Int32)
		_CreditCardID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CurrencyRateID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_CurrencyRate",ForeingTable:="CurrencyRate",MainTable:="[Sales].[SalesOrderHeader]",Order:=20,ParameterName:="CurrencyRateID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="CurrencyRateID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntCurrencyRate",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CurrencyRateID() As Int32
	Get 
		Return   _CurrencyRateID
	End Get 
	Set(ByVal value As Int32)
		_CurrencyRateID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CustomerID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Store",ForeingTable:="Store",MainTable:="[Sales].[SalesOrderHeader]",Order:=11,ParameterName:="CustomerID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CustomerID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStore",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CustomerID() As Int32
	Get 
		Return   _CustomerID
	End Get 
	Set(ByVal value As Int32)
		_CustomerID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="DueDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=4,ParameterName:="DueDate",SourceColumn:="DueDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DueDate() As DateTime
	Get 
		Return   _DueDate
	End Get 
	Set(ByVal value As DateTime)
		_DueDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="Freight",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=23,ParameterName:="Freight",Scale:=4,Size:=19,SourceColumn:="Freight",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Freight() As Decimal
	Get 
		Return   _Freight
	End Get 
	Set(ByVal value As Decimal)
		_Freight = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=27,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean,DefaultValue:="((1))",FieldName:="OnlineOrderFlag",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=7,ParameterName:="OnlineOrderFlag",SourceColumn:="OnlineOrderFlag",TypeName:="Boolean",EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property OnlineOrderFlag() As Boolean
	Get 
		Return   _OnlineOrderFlag
	End Get 
	Set(ByVal value As Boolean)
		_OnlineOrderFlag = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="OrderDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=3,ParameterName:="OrderDate",SourceColumn:="OrderDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property OrderDate() As DateTime
	Get 
		Return   _OrderDate
	End Get 
	Set(ByVal value As DateTime)
		_OrderDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="PurchaseOrderNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=9,ParameterName:="PurchaseOrderNumber",SetNullable:=True,Size:=25,SourceColumn:="PurchaseOrderNumber",TypeName:="String",MaxValue:=25,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property PurchaseOrderNumber() As String
	Get 
		Return   _PurchaseOrderNumber
	End Get 
	Set(ByVal value As String)
		_PurchaseOrderNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,DefaultValue:="((0))",FieldName:="RevisionNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=2,ParameterName:="RevisionNumber",Size:=3,SourceColumn:="RevisionNumber",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property RevisionNumber() As Byte
	Get 
		Return   _RevisionNumber
	End Get 
	Set(ByVal value As Byte)
		_RevisionNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=26,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesOrderID",ForeingCRUD:="ABM_SalesOrderHeader",ForeingTable:="SalesOrderHeader",MainTable:="[Sales].[SalesOrderHeader]",Order:=1,ParameterName:="SalesOrderID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesOrderHeader",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SalesOrderID() As Int32
	Get 
		Return   _SalesOrderID
	End Get 
	Set(ByVal value As Int32)
		_SalesOrderID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="SalesOrderNumber",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=8,ParameterName:="SalesOrderNumber",Size:=25,SourceColumn:="SalesOrderNumber",TypeName:="String",MaxValue:=25,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesOrderNumber() As String
	Get 
		Return   _SalesOrderNumber
	End Get 
	Set(ByVal value As String)
		_SalesOrderNumber = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesPersonID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SalesPerson",ForeingTable:="SalesPerson",MainTable:="[Sales].[SalesOrderHeader]",Order:=13,ParameterName:="SalesPersonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="SalesPersonID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesPerson",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesPersonID() As Int32
	Get 
		Return   _SalesPersonID
	End Get 
	Set(ByVal value As Int32)
		_SalesPersonID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="ShipDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=5,ParameterName:="ShipDate",SetNullable:=True,SourceColumn:="ShipDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShipDate() As DateTime
	Get 
		Return   _ShipDate
	End Get 
	Set(ByVal value As DateTime)
		_ShipDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ShipMethodID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ShipMethod",ForeingTable:="ShipMethod",MainTable:="[Sales].[SalesOrderHeader]",Order:=17,ParameterName:="ShipMethodID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ShipMethodID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntShipMethod",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShipMethodID() As Int32
	Get 
		Return   _ShipMethodID
	End Get 
	Set(ByVal value As Int32)
		_ShipMethodID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ShipToAddressID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Address",ForeingTable:="Address",MainTable:="[Sales].[SalesOrderHeader]",Order:=16,ParameterName:="ShipToAddressID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ShipToAddressID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntAddress",IsDescription:=False,ForeingFieldName:="ShipToAddressID",DefaultOrderBy:= False )> _
	Public Property ShipToAddressID() As Int32
	Get 
		Return   _ShipToAddressID
	End Get 
	Set(ByVal value As Int32)
		_ShipToAddressID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,DefaultValue:="((1))",FieldName:="Status",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=6,ParameterName:="Status",Size:=3,SourceColumn:="Status",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Status() As Byte
	Get 
		Return   _Status
	End Get 
	Set(ByVal value As Byte)
		_Status = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="SubTotal",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=21,ParameterName:="SubTotal",Scale:=4,Size:=19,SourceColumn:="SubTotal",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SubTotal() As Decimal
	Get 
		Return   _SubTotal
	End Get 
	Set(ByVal value As Decimal)
		_SubTotal = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="TaxAmt",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=22,ParameterName:="TaxAmt",Scale:=4,Size:=19,SourceColumn:="TaxAmt",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TaxAmt() As Decimal
	Get 
		Return   _TaxAmt
	End Get 
	Set(ByVal value As Decimal)
		_TaxAmt = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TerritoryID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SalesTerritory",ForeingTable:="SalesTerritory",MainTable:="[Sales].[SalesOrderHeader]",Order:=14,ParameterName:="TerritoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="TerritoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesTerritory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TerritoryID() As Int32
	Get 
		Return   _TerritoryID
	End Get 
	Set(ByVal value As Int32)
		_TerritoryID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="TotalDue",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeader]",Order:=24,ParameterName:="TotalDue",Scale:=4,Size:=19,SourceColumn:="TotalDue",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesOrderHeader]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TotalDue() As Decimal
	Get 
		Return   _TotalDue
	End Get 
	Set(ByVal value As Decimal)
		_TotalDue = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_AccountNumber = Nothing
_BillToAddressID = Nothing
_Comment = Nothing
_ContactID = Nothing
_CreditCardApprovalCode = Nothing
_CreditCardID = Nothing
_CurrencyRateID = Nothing
_CustomerID = Nothing
_DueDate = Nothing
_Freight = Nothing
_ModifiedDate = Nothing
_OnlineOrderFlag = Nothing
_OrderDate = Nothing
_PurchaseOrderNumber = Nothing
_RevisionNumber = Nothing
_Rowguid = Nothing
_SalesOrderID = Nothing
_SalesOrderNumber = Nothing
_SalesPersonID = Nothing
_ShipDate = Nothing
_ShipMethodID = Nothing
_ShipToAddressID = Nothing
_Status = Nothing
_SubTotal = Nothing
_TaxAmt = Nothing
_TerritoryID = Nothing
_TotalDue = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesReasonID",PrimaryKeyFieldName:="SalesReasonID",RootContainerName:="[Sales].[SalesOrderHeaderSalesReason]")> _
Public Class EntSales_SalesOrderHeaderSalesReason

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _SalesOrderID As Int32
	Private  _SalesReasonID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesOrderHeaderSalesReason]",Order:=3,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesOrderHeaderSalesReason]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesOrderID",ForeingCRUD:="ABM_SalesOrderHeader",ForeingTable:="SalesOrderHeader",MainTable:="[Sales].[SalesOrderHeaderSalesReason]",Order:=1,ParameterName:="SalesOrderID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesOrderID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesOrderHeader",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SalesOrderID() As Int32
	Get 
		Return   _SalesOrderID
	End Get 
	Set(ByVal value As Int32)
		_SalesOrderID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesReasonID",ForeingCRUD:="ABM_SalesReason",ForeingTable:="SalesReason",MainTable:="[Sales].[SalesOrderHeaderSalesReason]",Order:=2,ParameterName:="SalesReasonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesReasonID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesReason",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesReasonID() As Int32
	Get 
		Return   _SalesReasonID
	End Get 
	Set(ByVal value As Int32)
		_SalesReasonID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_SalesOrderID = Nothing
_SalesReasonID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesPersonID",PrimaryKeyFieldName:="SalesPersonID",RootContainerName:="[Sales].[SalesPerson]")> _
Public Class EntSales_SalesPerson

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Bonus As Decimal
	Private  _CommissionPct As Decimal
	Private  _ModifiedDate As DateTime
	Private  _Rowguid As Guid
	Private  _SalesLastYear As Decimal
	Private  _SalesPersonID As Int32
	Private  _SalesQuota As Decimal
	Private  _SalesYTD As Decimal
	Private  _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="Bonus",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPerson]",Order:=4,ParameterName:="Bonus",Scale:=4,Size:=19,SourceColumn:="Bonus",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesPerson]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Bonus() As Decimal
	Get 
		Return   _Bonus
	End Get 
	Set(ByVal value As Decimal)
		_Bonus = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="CommissionPct",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPerson]",Order:=5,ParameterName:="CommissionPct",Scale:=4,Size:=10,SourceColumn:="CommissionPct",TypeName:="Decimal",MaxValue:=10,EntityClassContainer:="Ent[Sales].[SalesPerson]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CommissionPct() As Decimal
	Get 
		Return   _CommissionPct
	End Get 
	Set(ByVal value As Decimal)
		_CommissionPct = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPerson]",Order:=9,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesPerson]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPerson]",Order:=8,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SalesPerson]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="SalesLastYear",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPerson]",Order:=7,ParameterName:="SalesLastYear",Scale:=4,Size:=19,SourceColumn:="SalesLastYear",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesPerson]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesLastYear() As Decimal
	Get 
		Return   _SalesLastYear
	End Get 
	Set(ByVal value As Decimal)
		_SalesLastYear = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesPersonID",ForeingCRUD:="ABM_Employee",ForeingTable:="Employee",MainTable:="[Sales].[SalesPerson]",Order:=1,ParameterName:="SalesPersonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesPersonID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntEmployee",IsDescription:=False,ForeingFieldName:="SalesPersonID",DefaultOrderBy:= True )> _
	Public Property SalesPersonID() As Int32
	Get 
		Return   _SalesPersonID
	End Get 
	Set(ByVal value As Int32)
		_SalesPersonID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="SalesQuota",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPerson]",Order:=3,ParameterName:="SalesQuota",Scale:=4,SetNullable:=True,Size:=19,SourceColumn:="SalesQuota",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesPerson]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesQuota() As Decimal
	Get 
		Return   _SalesQuota
	End Get 
	Set(ByVal value As Decimal)
		_SalesQuota = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="SalesYTD",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPerson]",Order:=6,ParameterName:="SalesYTD",Scale:=4,Size:=19,SourceColumn:="SalesYTD",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesPerson]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesYTD() As Decimal
	Get 
		Return   _SalesYTD
	End Get 
	Set(ByVal value As Decimal)
		_SalesYTD = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TerritoryID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SalesTerritory",ForeingTable:="SalesTerritory",MainTable:="[Sales].[SalesPerson]",Order:=2,ParameterName:="TerritoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="TerritoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesTerritory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TerritoryID() As Int32
	Get 
		Return   _TerritoryID
	End Get 
	Set(ByVal value As Int32)
		_TerritoryID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Bonus = Nothing
_CommissionPct = Nothing
_ModifiedDate = Nothing
_Rowguid = Nothing
_SalesLastYear = Nothing
_SalesPersonID = Nothing
_SalesQuota = Nothing
_SalesYTD = Nothing
_TerritoryID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesPersonID",PrimaryKeyFieldName:="SalesPersonID",RootContainerName:="[Sales].[SalesPersonQuotaHistory]")> _
Public Class EntSales_SalesPersonQuotaHistory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _QuotaDate As DateTime
	Private  _Rowguid As Guid
	Private  _SalesPersonID As Int32
	Private  _SalesQuota As Decimal
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPersonQuotaHistory]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesPersonQuotaHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="QuotaDate",ForeingCRUD:="ABM_SalesPersonQuotaHistory",ForeingTable:="SalesPersonQuotaHistory",MainTable:="[Sales].[SalesPersonQuotaHistory]",Order:=2,ParameterName:="QuotaDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="QuotaDate",TypeName:="DateTime",EntityClassContainer:="EntSalesPersonQuotaHistory",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property QuotaDate() As DateTime
	Get 
		Return   _QuotaDate
	End Get 
	Set(ByVal value As DateTime)
		_QuotaDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPersonQuotaHistory]",Order:=4,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SalesPersonQuotaHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesPersonID",ForeingCRUD:="ABM_SalesPerson",ForeingTable:="SalesPerson",MainTable:="[Sales].[SalesPersonQuotaHistory]",Order:=1,ParameterName:="SalesPersonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesPersonID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesPerson",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesPersonID() As Int32
	Get 
		Return   _SalesPersonID
	End Get 
	Set(ByVal value As Int32)
		_SalesPersonID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,FieldName:="SalesQuota",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesPersonQuotaHistory]",Order:=3,ParameterName:="SalesQuota",Scale:=4,Size:=19,SourceColumn:="SalesQuota",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesPersonQuotaHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesQuota() As Decimal
	Get 
		Return   _SalesQuota
	End Get 
	Set(ByVal value As Decimal)
		_SalesQuota = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_QuotaDate = Nothing
_Rowguid = Nothing
_SalesPersonID = Nothing
_SalesQuota = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesReasonID",PrimaryKeyFieldName:="SalesReasonID",RootContainerName:="[Sales].[SalesReason]")> _
Public Class EntSales_SalesReason

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _ReasonType As String
	Private  _SalesReasonID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesReason]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesReason]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesReason]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[SalesReason]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ReasonType",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesReason]",Order:=3,ParameterName:="ReasonType",Size:=50,SourceColumn:="ReasonType",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[SalesReason]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ReasonType() As String
	Get 
		Return   _ReasonType
	End Get 
	Set(ByVal value As String)
		_ReasonType = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesReasonID",ForeingCRUD:="ABM_SalesReason",ForeingTable:="SalesReason",MainTable:="[Sales].[SalesReason]",Order:=1,ParameterName:="SalesReasonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesReasonID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesReason",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SalesReasonID() As Int32
	Get 
		Return   _SalesReasonID
	End Get 
	Set(ByVal value As Int32)
		_SalesReasonID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Name = Nothing
_ReasonType = Nothing
_SalesReasonID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesTaxRateID",PrimaryKeyFieldName:="SalesTaxRateID",RootContainerName:="[Sales].[SalesTaxRate]")> _
Public Class EntSales_SalesTaxRate

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _Rowguid As Guid
	Private  _SalesTaxRateID As Int32
	Private  _StateProvinceID As Int32
	Private  _TaxRate As Decimal
	Private  _TaxType As Byte
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTaxRate]",Order:=7,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesTaxRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTaxRate]",Order:=5,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[SalesTaxRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTaxRate]",Order:=6,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SalesTaxRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesTaxRateID",ForeingCRUD:="ABM_SalesTaxRate",ForeingTable:="SalesTaxRate",MainTable:="[Sales].[SalesTaxRate]",Order:=1,ParameterName:="SalesTaxRateID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesTaxRateID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesTaxRate",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SalesTaxRateID() As Int32
	Get 
		Return   _SalesTaxRateID
	End Get 
	Set(ByVal value As Int32)
		_SalesTaxRateID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="StateProvinceID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_StateProvince",ForeingTable:="StateProvince",MainTable:="[Sales].[SalesTaxRate]",Order:=2,ParameterName:="StateProvinceID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="StateProvinceID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStateProvince",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StateProvinceID() As Int32
	Get 
		Return   _StateProvinceID
	End Get 
	Set(ByVal value As Int32)
		_StateProvinceID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="TaxRate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTaxRate]",Order:=4,ParameterName:="TaxRate",Scale:=4,Size:=10,SourceColumn:="TaxRate",TypeName:="Decimal",MaxValue:=10,EntityClassContainer:="Ent[Sales].[SalesTaxRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TaxRate() As Decimal
	Get 
		Return   _TaxRate
	End Get 
	Set(ByVal value As Decimal)
		_TaxRate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte,FieldName:="TaxType",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTaxRate]",Order:=3,ParameterName:="TaxType",Size:=3,SourceColumn:="TaxType",TypeName:="Byte",MaxValue:=3,EntityClassContainer:="Ent[Sales].[SalesTaxRate]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TaxType() As Byte
	Get 
		Return   _TaxType
	End Get 
	Set(ByVal value As Byte)
		_TaxType = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_Name = Nothing
_Rowguid = Nothing
_SalesTaxRateID = Nothing
_StateProvinceID = Nothing
_TaxRate = Nothing
_TaxType = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TerritoryID",PrimaryKeyFieldName:="TerritoryID",RootContainerName:="[Sales].[SalesTerritory]")> _
Public Class EntSales_SalesTerritory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CostLastYear As Decimal
	Private  _CostYTD As Decimal
	Private  _CountryRegionCode As String
	Private  _Group As String
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _Rowguid As Guid
	Private  _SalesLastYear As Decimal
	Private  _SalesYTD As Decimal
	Private  _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="CostLastYear",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=8,ParameterName:="CostLastYear",Scale:=4,Size:=19,SourceColumn:="CostLastYear",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CostLastYear() As Decimal
	Get 
		Return   _CostLastYear
	End Get 
	Set(ByVal value As Decimal)
		_CostLastYear = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="CostYTD",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=7,ParameterName:="CostYTD",Scale:=4,Size:=19,SourceColumn:="CostYTD",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CostYTD() As Decimal
	Get 
		Return   _CostYTD
	End Get 
	Set(ByVal value As Decimal)
		_CostYTD = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="CountryRegionCode",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_CountryRegion",ForeingTable:="CountryRegion",MainTable:="[Sales].[SalesTerritory]",Order:=3,ParameterName:="CountryRegionCode",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=3,SourceColumn:="CountryRegionCode",TypeName:="String",MaxValue:=3,EntityClassContainer:="EntCountryRegion",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CountryRegionCode() As String
	Get 
		Return   _CountryRegionCode
	End Get 
	Set(ByVal value As String)
		_CountryRegionCode = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Group",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=4,ParameterName:="Group",Size:=50,SourceColumn:="Group",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Group() As String
	Get 
		Return   _Group
	End Get 
	Set(ByVal value As String)
		_Group = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=10,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=9,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="SalesLastYear",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=6,ParameterName:="SalesLastYear",Scale:=4,Size:=19,SourceColumn:="SalesLastYear",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesLastYear() As Decimal
	Get 
		Return   _SalesLastYear
	End Get 
	Set(ByVal value As Decimal)
		_SalesLastYear = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="SalesYTD",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritory]",Order:=5,ParameterName:="SalesYTD",Scale:=4,Size:=19,SourceColumn:="SalesYTD",TypeName:="Decimal",MaxValue:=19,EntityClassContainer:="Ent[Sales].[SalesTerritory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesYTD() As Decimal
	Get 
		Return   _SalesYTD
	End Get 
	Set(ByVal value As Decimal)
		_SalesYTD = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TerritoryID",ForeingCRUD:="ABM_SalesTerritory",ForeingTable:="SalesTerritory",MainTable:="[Sales].[SalesTerritory]",Order:=1,ParameterName:="TerritoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="TerritoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesTerritory",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property TerritoryID() As Int32
	Get 
		Return   _TerritoryID
	End Get 
	Set(ByVal value As Int32)
		_TerritoryID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CostLastYear = Nothing
_CostYTD = Nothing
_CountryRegionCode = Nothing
_Group = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_Rowguid = Nothing
_SalesLastYear = Nothing
_SalesYTD = Nothing
_TerritoryID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TerritoryID",PrimaryKeyFieldName:="TerritoryID",RootContainerName:="[Sales].[SalesTerritoryHistory]")> _
Public Class EntSales_SalesTerritoryHistory

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _EndDate As DateTime
	Private  _ModifiedDate As DateTime
	Private  _Rowguid As Guid
	Private  _SalesPersonID As Int32
	Private  _StartDate As DateTime
	Private  _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritoryHistory]",Order:=4,ParameterName:="EndDate",SetNullable:=True,SourceColumn:="EndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesTerritoryHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndDate() As DateTime
	Get 
		Return   _EndDate
	End Get 
	Set(ByVal value As DateTime)
		_EndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritoryHistory]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SalesTerritoryHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SalesTerritoryHistory]",Order:=5,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SalesTerritoryHistory]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesPersonID",ForeingCRUD:="ABM_SalesPerson",ForeingTable:="SalesPerson",MainTable:="[Sales].[SalesTerritoryHistory]",Order:=1,ParameterName:="SalesPersonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SalesPersonID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesPerson",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SalesPersonID() As Int32
	Get 
		Return   _SalesPersonID
	End Get 
	Set(ByVal value As Int32)
		_SalesPersonID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="StartDate",ForeingCRUD:="ABM_ProductCostHistory",ForeingTable:="ProductCostHistory",MainTable:="[Sales].[SalesTerritoryHistory]",Order:=3,ParameterName:="StartDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="StartDate",TypeName:="DateTime",EntityClassContainer:="EntProductCostHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartDate() As DateTime
	Get 
		Return   _StartDate
	End Get 
	Set(ByVal value As DateTime)
		_StartDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="TerritoryID",ForeingCRUD:="ABM_SalesTerritory",ForeingTable:="SalesTerritory",MainTable:="[Sales].[SalesTerritoryHistory]",Order:=2,ParameterName:="TerritoryID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="TerritoryID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesTerritory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property TerritoryID() As Int32
	Get 
		Return   _TerritoryID
	End Get 
	Set(ByVal value As Int32)
		_TerritoryID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_EndDate = Nothing
_ModifiedDate = Nothing
_Rowguid = Nothing
_SalesPersonID = Nothing
_StartDate = Nothing
_TerritoryID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ShoppingCartItemID",PrimaryKeyFieldName:="ShoppingCartItemID",RootContainerName:="[Sales].[ShoppingCartItem]")> _
Public Class EntSales_ShoppingCartItem

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _DateCreated As DateTime
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _Quantity As Int32
	Private  _ShoppingCartID As String
	Private  _ShoppingCartItemID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="DateCreated",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[ShoppingCartItem]",Order:=5,ParameterName:="DateCreated",SourceColumn:="DateCreated",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[ShoppingCartItem]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DateCreated() As DateTime
	Get 
		Return   _DateCreated
	End Get 
	Set(ByVal value As DateTime)
		_DateCreated = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[ShoppingCartItem]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[ShoppingCartItem]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Sales].[ShoppingCartItem]",Order:=4,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,DefaultValue:="((1))",FieldName:="Quantity",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[ShoppingCartItem]",Order:=3,ParameterName:="Quantity",Size:=10,SourceColumn:="Quantity",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Sales].[ShoppingCartItem]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Quantity() As Int32
	Get 
		Return   _Quantity
	End Get 
	Set(ByVal value As Int32)
		_Quantity = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="ShoppingCartID",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[ShoppingCartItem]",Order:=2,ParameterName:="ShoppingCartID",Size:=50,SourceColumn:="ShoppingCartID",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[ShoppingCartItem]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ShoppingCartID() As String
	Get 
		Return   _ShoppingCartID
	End Get 
	Set(ByVal value As String)
		_ShoppingCartID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ShoppingCartItemID",ForeingCRUD:="ABM_ShoppingCartItem",ForeingTable:="ShoppingCartItem",MainTable:="[Sales].[ShoppingCartItem]",Order:=1,ParameterName:="ShoppingCartItemID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ShoppingCartItemID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntShoppingCartItem",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ShoppingCartItemID() As Int32
	Get 
		Return   _ShoppingCartItemID
	End Get 
	Set(ByVal value As Int32)
		_ShoppingCartItemID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_DateCreated = Nothing
_ModifiedDate = Nothing
_ProductID = Nothing
_Quantity = Nothing
_ShoppingCartID = Nothing
_ShoppingCartItemID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SpecialOfferID",PrimaryKeyFieldName:="SpecialOfferID",RootContainerName:="[Sales].[SpecialOffer]")> _
Public Class EntSales_SpecialOffer

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _Category As String
	Private  _Description As String
	Private  _DiscountPct As Decimal
	Private  _EndDate As DateTime
	Private  _MaxQty As Int32
	Private  _MinQty As Int32
	Private  _ModifiedDate As DateTime
	Private  _Rowguid As Guid
	Private  _SpecialOfferID As Int32
	Private  _StartDate As DateTime
	Private  _Type As String
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Category",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=5,ParameterName:="Category",Size:=50,SourceColumn:="Category",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Category() As String
	Get 
		Return   _Category
	End Get 
	Set(ByVal value As String)
		_Category = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Description",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=2,ParameterName:="Description",Size:=255,SourceColumn:="Description",TypeName:="String",MaxValue:=255,EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Description() As String
	Get 
		Return   _Description
	End Get 
	Set(ByVal value As String)
		_Description = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal,DefaultValue:="((0.00))",FieldName:="DiscountPct",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=3,ParameterName:="DiscountPct",Scale:=4,Size:=10,SourceColumn:="DiscountPct",TypeName:="Decimal",MaxValue:=10,EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property DiscountPct() As Decimal
	Get 
		Return   _DiscountPct
	End Get 
	Set(ByVal value As Decimal)
		_DiscountPct = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="EndDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=7,ParameterName:="EndDate",SourceColumn:="EndDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property EndDate() As DateTime
	Get 
		Return   _EndDate
	End Get 
	Set(ByVal value As DateTime)
		_EndDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="MaxQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=9,ParameterName:="MaxQty",SetNullable:=True,Size:=10,SourceColumn:="MaxQty",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property MaxQty() As Int32
	Get 
		Return   _MaxQty
	End Get 
	Set(ByVal value As Int32)
		_MaxQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,DefaultValue:="((0))",FieldName:="MinQty",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=8,ParameterName:="MinQty",Size:=10,SourceColumn:="MinQty",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property MinQty() As Int32
	Get 
		Return   _MinQty
	End Get 
	Set(ByVal value As Int32)
		_MinQty = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=11,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=10,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SpecialOfferID",ForeingCRUD:="ABM_SpecialOffer",ForeingTable:="SpecialOffer",MainTable:="[Sales].[SpecialOffer]",Order:=1,ParameterName:="SpecialOfferID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SpecialOfferID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSpecialOffer",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property SpecialOfferID() As Int32
	Get 
		Return   _SpecialOfferID
	End Get 
	Set(ByVal value As Int32)
		_SpecialOfferID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,FieldName:="StartDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ProductCostHistory",ForeingTable:="ProductCostHistory",MainTable:="[Sales].[SpecialOffer]",Order:=6,ParameterName:="StartDate",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SourceColumn:="StartDate",TypeName:="DateTime",EntityClassContainer:="EntProductCostHistory",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property StartDate() As DateTime
	Get 
		Return   _StartDate
	End Get 
	Set(ByVal value As DateTime)
		_StartDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Type",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOffer]",Order:=4,ParameterName:="Type",Size:=50,SourceColumn:="Type",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[SpecialOffer]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Type() As String
	Get 
		Return   _Type
	End Get 
	Set(ByVal value As String)
		_Type = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_Category = Nothing
_Description = Nothing
_DiscountPct = Nothing
_EndDate = Nothing
_MaxQty = Nothing
_MinQty = Nothing
_ModifiedDate = Nothing
_Rowguid = Nothing
_SpecialOfferID = Nothing
_StartDate = Nothing
_Type = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SpecialOfferID",PrimaryKeyFieldName:="SpecialOfferID",RootContainerName:="[Sales].[SpecialOfferProduct]")> _
Public Class EntSales_SpecialOfferProduct

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ModifiedDate As DateTime
	Private  _ProductID As Int32
	Private  _Rowguid As Guid
	Private  _SpecialOfferID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOfferProduct]",Order:=4,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[SpecialOfferProduct]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ProductID",ForeingCRUD:="ABM_Product",ForeingTable:="Product",MainTable:="[Sales].[SpecialOfferProduct]",Order:=2,ParameterName:="ProductID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ProductID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntProduct",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ProductID() As Int32
	Get 
		Return   _ProductID
	End Get 
	Set(ByVal value As Int32)
		_ProductID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[SpecialOfferProduct]",Order:=3,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[SpecialOfferProduct]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SpecialOfferID",ForeingCRUD:="ABM_SpecialOffer",ForeingTable:="SpecialOffer",MainTable:="[Sales].[SpecialOfferProduct]",Order:=1,ParameterName:="SpecialOfferID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="SpecialOfferID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSpecialOffer",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SpecialOfferID() As Int32
	Get 
		Return   _SpecialOfferID
	End Get 
	Set(ByVal value As Int32)
		_SpecialOfferID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ModifiedDate = Nothing
_ProductID = Nothing
_Rowguid = Nothing
_SpecialOfferID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID",PrimaryKeyFieldName:="CustomerID",RootContainerName:="[Sales].[Store]")> _
Public Class EntSales_Store

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _CustomerID As Int32
	Private  _Demographics As String
	Private  _ModifiedDate As DateTime
	Private  _Name As String
	Private  _Rowguid As Guid
	Private  _SalesPersonID As Int32
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CustomerID",ForeingCRUD:="ABM_Store",ForeingTable:="Store",MainTable:="[Sales].[Store]",Order:=1,ParameterName:="CustomerID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CustomerID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStore",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property CustomerID() As Int32
	Get 
		Return   _CustomerID
	End Get 
	Set(ByVal value As Int32)
		_CustomerID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Demographics",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Store]",Order:=4,ParameterName:="Demographics",SetNullable:=True,Size:=-1,SourceColumn:="Demographics",TypeName:="String",MaxValue:=-1,EntityClassContainer:="Ent[Sales].[Store]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Demographics() As String
	Get 
		Return   _Demographics
	End Get 
	Set(ByVal value As String)
		_Demographics = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Store]",Order:=6,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[Store]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String,FieldName:="Name",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Store]",Order:=2,ParameterName:="Name",Size:=50,SourceColumn:="Name",TypeName:="String",MaxValue:=50,EntityClassContainer:="Ent[Sales].[Store]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Name() As String
	Get 
		Return   _Name
	End Get 
	Set(ByVal value As String)
		_Name = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[Store]",Order:=5,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[Store]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="SalesPersonID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_SalesPerson",ForeingTable:="SalesPerson",MainTable:="[Sales].[Store]",Order:=3,ParameterName:="SalesPersonID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,SetNullable:=True,Size:=10,SourceColumn:="SalesPersonID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntSalesPerson",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property SalesPersonID() As Int32
	Get 
		Return   _SalesPersonID
	End Get 
	Set(ByVal value As Int32)
		_SalesPersonID = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_CustomerID = Nothing
_Demographics = Nothing
_ModifiedDate = Nothing
_Name = Nothing
_Rowguid = Nothing
_SalesPersonID = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

''' <summary>
''' Auto Generated:  08/02/2010 04:20:35 a.m.
''' </summary>
 ''' <remarks></remarks>
	<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID",PrimaryKeyFieldName:="CustomerID",RootContainerName:="[Sales].[StoreContact]")> _
Public Class EntSales_StoreContact

		Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
	Private  _ContactID As Int32
	Private  _ContactTypeID As Int32
	Private  _CustomerID As Int32
	Private  _ModifiedDate As DateTime
	Private  _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactID",ForeingCRUD:="ABM_Contact",ForeingTable:="Contact",MainTable:="[Sales].[StoreContact]",Order:=2,ParameterName:="ContactID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContact",IsDescription:=False,DefaultOrderBy:= True )> _
	Public Property ContactID() As Int32
	Get 
		Return   _ContactID
	End Get 
	Set(ByVal value As Int32)
		_ContactID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="ContactTypeID",FieldType:=BrainWork.Entities.EnumFieldType.Field,ForeingCRUD:="ABM_ContactType",ForeingTable:="ContactType",MainTable:="[Sales].[StoreContact]",Order:=3,ParameterName:="ContactTypeID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="ContactTypeID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntContactType",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ContactTypeID() As Int32
	Get 
		Return   _ContactTypeID
	End Get 
	Set(ByVal value As Int32)
		_ContactTypeID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32,FieldName:="CustomerID",ForeingCRUD:="ABM_Store",ForeingTable:="Store",MainTable:="[Sales].[StoreContact]",Order:=1,ParameterName:="CustomerID",RelationType:=BrainWork.Entities.EnumRelationType.Combo,Size:=10,SourceColumn:="CustomerID",TypeName:="Int32",MaxValue:=10,EntityClassContainer:="EntStore",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property CustomerID() As Int32
	Get 
		Return   _CustomerID
	End Get 
	Set(ByVal value As Int32)
		_CustomerID = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime,DefaultValue:="(getdate())",FieldName:="ModifiedDate",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[StoreContact]",Order:=5,ParameterName:="ModifiedDate",SourceColumn:="ModifiedDate",TypeName:="DateTime",EntityClassContainer:="Ent[Sales].[StoreContact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property ModifiedDate() As DateTime
	Get 
		Return   _ModifiedDate
	End Get 
	Set(ByVal value As DateTime)
		_ModifiedDate = value
	End Set
	End Property
	
<BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid,DefaultValue:="(newid())",FieldName:="rowguid",FieldType:=BrainWork.Entities.EnumFieldType.Field,MainTable:="[Sales].[StoreContact]",Order:=4,ParameterName:="rowguid",SourceColumn:="rowguid",TypeName:="Guid",EntityClassContainer:="Ent[Sales].[StoreContact]",IsDescription:=False,DefaultOrderBy:= False )> _
	Public Property Rowguid() As Guid
	Get 
		Return   _Rowguid
	End Get 
	Set(ByVal value As Guid)
		_Rowguid = value
	End Set
	End Property
#End Region

#Region "GeneratedCode Constructor"
	Public Sub New()
_ContactID = Nothing
_ContactTypeID = Nothing
_CustomerID = Nothing
_ModifiedDate = Nothing
_Rowguid = Nothing
	End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class 

Public Class BlAWBuildVersion
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntAWBuildVersion
    Private _myDataAccess As DaAWBuildVersion

    Public Property CurrentEntity() As EntAWBuildVersion
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntAWBuildVersion)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntAWBuildVersion, New DaAWBuildVersion(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntAWBuildVersion)
        Me._myDataAccess = CType(MyBase.DataAccess, DaAWBuildVersion)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.Version  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.SystemInformationID  = Byte.MinValue
			Me.CurrentEntity.VersionDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.Version is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.SystemInformationID  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.VersionDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaAWBuildVersion 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntAWBuildVersion

    Public Property CurrentEntity() As EntAWBuildVersion
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntAWBuildVersion)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntAWBuildVersion)
        Me._CurrentEntity = CType(MyBase.Entity, EntAWBuildVersion)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_AWBuildVersion_Insert"
			Me.SP_DELETE = "prc_AWBuildVersion_Delete"
			Me.SP_DISABLE = "prc_AWBuildVersion_UpdateByPK"
			Me.SP_GETALL = "prc_AWBuildVersion_SelectAll"
			Me.SP_GETONE = "prc_AWBuildVersion_SlectOne"
			Me.SP_UPDATE = "prc_AWBuildVersion_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_AWBuildVersion_UpdateByPK"

    End Sub
End Class


Public Class BlDatabaseLog
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntDatabaseLog
    Private _myDataAccess As DaDatabaseLog

    Public Property CurrentEntity() As EntDatabaseLog
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntDatabaseLog)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntDatabaseLog, New DaDatabaseLog(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntDatabaseLog)
        Me._myDataAccess = CType(MyBase.DataAccess, DaDatabaseLog)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DatabaseLogID  = Int32.MinValue
			Me.CurrentEntity.DatabaseUser  = Nothing
			Me.CurrentEntity.[Event]  = Nothing
			Me.CurrentEntity.PostTime  = Date.MinValue
			Me.CurrentEntity.TSQL  = Nothing
			Me.CurrentEntity.XmlEvent  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DatabaseLogID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.DatabaseUser is Nothing OrElse _ 
			Me.CurrentEntity.[Event] is Nothing OrElse _ 
			Me.CurrentEntity.PostTime = Date.MinValue OrElse _ 
			Me.CurrentEntity.TSQL is Nothing OrElse _ 
			Me.CurrentEntity.XmlEvent is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaDatabaseLog 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntDatabaseLog

    Public Property CurrentEntity() As EntDatabaseLog
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntDatabaseLog)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntDatabaseLog)
        Me._CurrentEntity = CType(MyBase.Entity, EntDatabaseLog)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_DatabaseLog_Insert"
			Me.SP_DELETE = "prc_DatabaseLog_Delete"
			Me.SP_DISABLE = "prc_DatabaseLog_UpdateByPK"
			Me.SP_GETALL = "prc_DatabaseLog_SelectAll"
			Me.SP_GETONE = "prc_DatabaseLog_SlectOne"
			Me.SP_UPDATE = "prc_DatabaseLog_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_DatabaseLog_UpdateByPK"

    End Sub
End Class


Public Class BlErrorLog
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntErrorLog
    Private _myDataAccess As DaErrorLog

    Public Property CurrentEntity() As EntErrorLog
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntErrorLog)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntErrorLog, New DaErrorLog(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntErrorLog)
        Me._myDataAccess = CType(MyBase.DataAccess, DaErrorLog)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ErrorLogID  = Int32.MinValue
			Me.CurrentEntity.ErrorMessage  = Nothing
			Me.CurrentEntity.ErrorNumber  = Int32.MinValue
			Me.CurrentEntity.ErrorTime  = Date.MinValue
			Me.CurrentEntity.UserName  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ErrorLogID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ErrorMessage is Nothing OrElse _ 
			Me.CurrentEntity.ErrorNumber = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ErrorTime = Date.MinValue OrElse _ 
			Me.CurrentEntity.UserName is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaErrorLog 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntErrorLog

    Public Property CurrentEntity() As EntErrorLog
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntErrorLog)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntErrorLog)
        Me._CurrentEntity = CType(MyBase.Entity, EntErrorLog)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ErrorLog_Insert"
			Me.SP_DELETE = "prc_ErrorLog_Delete"
			Me.SP_DISABLE = "prc_ErrorLog_UpdateByPK"
			Me.SP_GETALL = "prc_ErrorLog_SelectAll"
			Me.SP_GETONE = "prc_ErrorLog_SlectOne"
			Me.SP_UPDATE = "prc_ErrorLog_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ErrorLog_UpdateByPK"

    End Sub
End Class


Public Class BlTable_1
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntTable_1
    Private _myDataAccess As DaTable_1

    Public Property CurrentEntity() As EntTable_1
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntTable_1)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntTable_1, New DaTable_1(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntTable_1)
        Me._myDataAccess = CType(MyBase.DataAccess, DaTable_1)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
		
    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaTable_1 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntTable_1

    Public Property CurrentEntity() As EntTable_1
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntTable_1)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntTable_1)
        Me._CurrentEntity = CType(MyBase.Entity, EntTable_1)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_Table_1_Insert"
			Me.SP_DELETE = "prc_Table_1_Delete"
			Me.SP_DISABLE = "prc_Table_1_UpdateByPK"
			Me.SP_GETALL = "prc_Table_1_SelectAll"
			Me.SP_GETONE = "prc_Table_1_SlectOne"
			Me.SP_UPDATE = "prc_Table_1_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_Table_1_UpdateByPK"

    End Sub
End Class


Public Class BlHumanResources_Department
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntHumanResources_Department
    Private _myDataAccess As DaHumanResources_Department

    Public Property CurrentEntity() As EntHumanResources_Department
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_Department)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_Department, New DaHumanResources_Department(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_Department)
        Me._myDataAccess = CType(MyBase.DataAccess, DaHumanResources_Department)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DepartmentID  = Int16.MinValue
			Me.CurrentEntity.GroupName  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DepartmentID  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.GroupName is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaHumanResources_Department 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntHumanResources_Department

    Public Property CurrentEntity() As EntHumanResources_Department
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_Department)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_Department)
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_Department)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_HumanResourcesDepartment_Insert"
			Me.SP_DELETE = "prc_HumanResourcesDepartment_Delete"
			Me.SP_DISABLE = "prc_HumanResourcesDepartment_UpdateByPK"
			Me.SP_GETALL = "prc_HumanResourcesDepartment_SelectAll"
			Me.SP_GETONE = "prc_HumanResourcesDepartment_SlectOne"
			Me.SP_UPDATE = "prc_HumanResourcesDepartment_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_HumanResourcesDepartment_UpdateByPK"

    End Sub
End Class


Public Class BlHumanResources_Employee
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntHumanResources_Employee
    Private _myDataAccess As DaHumanResources_Employee

    Public Property CurrentEntity() As EntHumanResources_Employee
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_Employee)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_Employee, New DaHumanResources_Employee(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_Employee)
        Me._myDataAccess = CType(MyBase.DataAccess, DaHumanResources_Employee)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.BirthDate  = Date.MinValue
			Me.CurrentEntity.ContactID  = Int32.MinValue
			'Me.CurrentEntity.CurrentFlag  = Nothing
			Me.CurrentEntity.EmployeeID  = Int32.MinValue
			Me.CurrentEntity.Gender  = Nothing
			Me.CurrentEntity.HireDate  = Date.MinValue
			Me.CurrentEntity.LoginID  = Nothing
			Me.CurrentEntity.MaritalStatus  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.NationalIDNumber  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing
			'Me.CurrentEntity.SalariedFlag  = Nothing
			Me.CurrentEntity.SickLeaveHours  = Int16.MinValue
			Me.CurrentEntity.Title  = Nothing
			Me.CurrentEntity.VacationHours  = Int16.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.BirthDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ContactID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.EmployeeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Gender is Nothing OrElse _ 
			Me.CurrentEntity.HireDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.LoginID is Nothing OrElse _ 
			Me.CurrentEntity.MaritalStatus is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.NationalIDNumber is Nothing OrElse _ 
			Me.CurrentEntity.SickLeaveHours  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.Title is Nothing OrElse _ 
			Me.CurrentEntity.VacationHours  = Int16.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaHumanResources_Employee 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntHumanResources_Employee

    Public Property CurrentEntity() As EntHumanResources_Employee
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_Employee)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_Employee)
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_Employee)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_HumanResourcesEmployee_Insert"
			Me.SP_DELETE = "prc_HumanResourcesEmployee_Delete"
			Me.SP_DISABLE = "prc_HumanResourcesEmployee_UpdateByPK"
			Me.SP_GETALL = "prc_HumanResourcesEmployee_SelectAll"
			Me.SP_GETONE = "prc_HumanResourcesEmployee_SlectOne"
			Me.SP_UPDATE = "prc_HumanResourcesEmployee_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_HumanResourcesEmployee_UpdateByPK"

    End Sub
End Class


Public Class BlHumanResources_EmployeeAddress
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntHumanResources_EmployeeAddress
    Private _myDataAccess As DaHumanResources_EmployeeAddress

    Public Property CurrentEntity() As EntHumanResources_EmployeeAddress
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_EmployeeAddress)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_EmployeeAddress, New DaHumanResources_EmployeeAddress(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_EmployeeAddress)
        Me._myDataAccess = CType(MyBase.DataAccess, DaHumanResources_EmployeeAddress)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AddressID  = Int32.MinValue
			Me.CurrentEntity.EmployeeID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AddressID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.EmployeeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaHumanResources_EmployeeAddress 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntHumanResources_EmployeeAddress

    Public Property CurrentEntity() As EntHumanResources_EmployeeAddress
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_EmployeeAddress)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_EmployeeAddress)
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_EmployeeAddress)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_HumanResourcesEmployeeAddress_Insert"
			Me.SP_DELETE = "prc_HumanResourcesEmployeeAddress_Delete"
			Me.SP_DISABLE = "prc_HumanResourcesEmployeeAddress_UpdateByPK"
			Me.SP_GETALL = "prc_HumanResourcesEmployeeAddress_SelectAll"
			Me.SP_GETONE = "prc_HumanResourcesEmployeeAddress_SlectOne"
			Me.SP_UPDATE = "prc_HumanResourcesEmployeeAddress_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_HumanResourcesEmployeeAddress_UpdateByPK"

    End Sub
End Class


Public Class BlHumanResources_EmployeeDepartmentHistory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntHumanResources_EmployeeDepartmentHistory
    Private _myDataAccess As DaHumanResources_EmployeeDepartmentHistory

    Public Property CurrentEntity() As EntHumanResources_EmployeeDepartmentHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_EmployeeDepartmentHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_EmployeeDepartmentHistory, New DaHumanResources_EmployeeDepartmentHistory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_EmployeeDepartmentHistory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaHumanResources_EmployeeDepartmentHistory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DepartmentID  = Int16.MinValue
			Me.CurrentEntity.EmployeeID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ShiftID  = Byte.MinValue
			Me.CurrentEntity.StartDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DepartmentID  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.EmployeeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ShiftID  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.StartDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaHumanResources_EmployeeDepartmentHistory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntHumanResources_EmployeeDepartmentHistory

    Public Property CurrentEntity() As EntHumanResources_EmployeeDepartmentHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_EmployeeDepartmentHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_EmployeeDepartmentHistory)
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_EmployeeDepartmentHistory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_HumanResourcesEmployeeDepartmentHistory_Insert"
			Me.SP_DELETE = "prc_HumanResourcesEmployeeDepartmentHistory_Delete"
			Me.SP_DISABLE = "prc_HumanResourcesEmployeeDepartmentHistory_UpdateByPK"
			Me.SP_GETALL = "prc_HumanResourcesEmployeeDepartmentHistory_SelectAll"
			Me.SP_GETONE = "prc_HumanResourcesEmployeeDepartmentHistory_SlectOne"
			Me.SP_UPDATE = "prc_HumanResourcesEmployeeDepartmentHistory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_HumanResourcesEmployeeDepartmentHistory_UpdateByPK"

    End Sub
End Class


Public Class BlHumanResources_EmployeePayHistory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntHumanResources_EmployeePayHistory
    Private _myDataAccess As DaHumanResources_EmployeePayHistory

    Public Property CurrentEntity() As EntHumanResources_EmployeePayHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_EmployeePayHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_EmployeePayHistory, New DaHumanResources_EmployeePayHistory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_EmployeePayHistory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaHumanResources_EmployeePayHistory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.EmployeeID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.PayFrequency  = Byte.MinValue
			Me.CurrentEntity.Rate  =  Decimal.MinValue
			Me.CurrentEntity.RateChangeDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.EmployeeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.PayFrequency  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.Rate  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.RateChangeDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaHumanResources_EmployeePayHistory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntHumanResources_EmployeePayHistory

    Public Property CurrentEntity() As EntHumanResources_EmployeePayHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_EmployeePayHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_EmployeePayHistory)
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_EmployeePayHistory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_HumanResourcesEmployeePayHistory_Insert"
			Me.SP_DELETE = "prc_HumanResourcesEmployeePayHistory_Delete"
			Me.SP_DISABLE = "prc_HumanResourcesEmployeePayHistory_UpdateByPK"
			Me.SP_GETALL = "prc_HumanResourcesEmployeePayHistory_SelectAll"
			Me.SP_GETONE = "prc_HumanResourcesEmployeePayHistory_SlectOne"
			Me.SP_UPDATE = "prc_HumanResourcesEmployeePayHistory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_HumanResourcesEmployeePayHistory_UpdateByPK"

    End Sub
End Class


Public Class BlHumanResources_JobCandidate
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntHumanResources_JobCandidate
    Private _myDataAccess As DaHumanResources_JobCandidate

    Public Property CurrentEntity() As EntHumanResources_JobCandidate
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_JobCandidate)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_JobCandidate, New DaHumanResources_JobCandidate(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_JobCandidate)
        Me._myDataAccess = CType(MyBase.DataAccess, DaHumanResources_JobCandidate)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.JobCandidateID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.JobCandidateID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaHumanResources_JobCandidate 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntHumanResources_JobCandidate

    Public Property CurrentEntity() As EntHumanResources_JobCandidate
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_JobCandidate)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_JobCandidate)
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_JobCandidate)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_HumanResourcesJobCandidate_Insert"
			Me.SP_DELETE = "prc_HumanResourcesJobCandidate_Delete"
			Me.SP_DISABLE = "prc_HumanResourcesJobCandidate_UpdateByPK"
			Me.SP_GETALL = "prc_HumanResourcesJobCandidate_SelectAll"
			Me.SP_GETONE = "prc_HumanResourcesJobCandidate_SlectOne"
			Me.SP_UPDATE = "prc_HumanResourcesJobCandidate_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_HumanResourcesJobCandidate_UpdateByPK"

    End Sub
End Class


Public Class BlHumanResources_Shift
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntHumanResources_Shift
    Private _myDataAccess As DaHumanResources_Shift

    Public Property CurrentEntity() As EntHumanResources_Shift
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_Shift)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_Shift, New DaHumanResources_Shift(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_Shift)
        Me._myDataAccess = CType(MyBase.DataAccess, DaHumanResources_Shift)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.EndTime  = Date.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.ShiftID  = Byte.MinValue
			Me.CurrentEntity.StartTime  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.EndTime = Date.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ShiftID  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.StartTime = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaHumanResources_Shift 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntHumanResources_Shift

    Public Property CurrentEntity() As EntHumanResources_Shift
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntHumanResources_Shift)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntHumanResources_Shift)
        Me._CurrentEntity = CType(MyBase.Entity, EntHumanResources_Shift)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_HumanResourcesShift_Insert"
			Me.SP_DELETE = "prc_HumanResourcesShift_Delete"
			Me.SP_DISABLE = "prc_HumanResourcesShift_UpdateByPK"
			Me.SP_GETALL = "prc_HumanResourcesShift_SelectAll"
			Me.SP_GETONE = "prc_HumanResourcesShift_SlectOne"
			Me.SP_UPDATE = "prc_HumanResourcesShift_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_HumanResourcesShift_UpdateByPK"

    End Sub
End Class


Public Class BlPerson_Address
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPerson_Address
    Private _myDataAccess As DaPerson_Address

    Public Property CurrentEntity() As EntPerson_Address
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_Address)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_Address, New DaPerson_Address(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_Address)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPerson_Address)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AddressID  = Int32.MinValue
			Me.CurrentEntity.AddressLine1  = Nothing
			Me.CurrentEntity.City  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.PostalCode  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.StateProvinceID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AddressID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.AddressLine1 is Nothing OrElse _ 
			Me.CurrentEntity.City is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.PostalCode is Nothing OrElse _ 
			Me.CurrentEntity.StateProvinceID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPerson_Address 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPerson_Address

    Public Property CurrentEntity() As EntPerson_Address
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_Address)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_Address)
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_Address)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PersonAddress_Insert"
			Me.SP_DELETE = "prc_PersonAddress_Delete"
			Me.SP_DISABLE = "prc_PersonAddress_UpdateByPK"
			Me.SP_GETALL = "prc_PersonAddress_SelectAll"
			Me.SP_GETONE = "prc_PersonAddress_SlectOne"
			Me.SP_UPDATE = "prc_PersonAddress_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PersonAddress_UpdateByPK"

    End Sub
End Class


Public Class BlPerson_AddressType
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPerson_AddressType
    Private _myDataAccess As DaPerson_AddressType

    Public Property CurrentEntity() As EntPerson_AddressType
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_AddressType)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_AddressType, New DaPerson_AddressType(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_AddressType)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPerson_AddressType)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AddressTypeID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AddressTypeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPerson_AddressType 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPerson_AddressType

    Public Property CurrentEntity() As EntPerson_AddressType
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_AddressType)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_AddressType)
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_AddressType)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PersonAddressType_Insert"
			Me.SP_DELETE = "prc_PersonAddressType_Delete"
			Me.SP_DISABLE = "prc_PersonAddressType_UpdateByPK"
			Me.SP_GETALL = "prc_PersonAddressType_SelectAll"
			Me.SP_GETONE = "prc_PersonAddressType_SlectOne"
			Me.SP_UPDATE = "prc_PersonAddressType_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PersonAddressType_UpdateByPK"

    End Sub
End Class


Public Class BlPerson_Contact
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPerson_Contact
    Private _myDataAccess As DaPerson_Contact

    Public Property CurrentEntity() As EntPerson_Contact
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_Contact)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_Contact, New DaPerson_Contact(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_Contact)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPerson_Contact)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ContactID  = Int32.MinValue
			Me.CurrentEntity.EmailPromotion  = Int32.MinValue
			Me.CurrentEntity.FirstName  = Nothing
			Me.CurrentEntity.LastName  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.NameStyle  = Nothing
			Me.CurrentEntity.PasswordHash  = Nothing
			Me.CurrentEntity.PasswordSalt  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ContactID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.EmailPromotion = Int32.MinValue OrElse _ 
			Me.CurrentEntity.FirstName is Nothing OrElse _ 
			Me.CurrentEntity.LastName is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.PasswordHash is Nothing OrElse _ 
			Me.CurrentEntity.PasswordSalt is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPerson_Contact 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPerson_Contact

    Public Property CurrentEntity() As EntPerson_Contact
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_Contact)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_Contact)
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_Contact)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PersonContact_Insert"
			Me.SP_DELETE = "prc_PersonContact_Delete"
			Me.SP_DISABLE = "prc_PersonContact_UpdateByPK"
			Me.SP_GETALL = "prc_PersonContact_SelectAll"
			Me.SP_GETONE = "prc_PersonContact_SlectOne"
			Me.SP_UPDATE = "prc_PersonContact_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PersonContact_UpdateByPK"

    End Sub
End Class


Public Class BlPerson_ContactType
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPerson_ContactType
    Private _myDataAccess As DaPerson_ContactType

    Public Property CurrentEntity() As EntPerson_ContactType
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_ContactType)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_ContactType, New DaPerson_ContactType(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_ContactType)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPerson_ContactType)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ContactTypeID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ContactTypeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPerson_ContactType 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPerson_ContactType

    Public Property CurrentEntity() As EntPerson_ContactType
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_ContactType)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_ContactType)
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_ContactType)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PersonContactType_Insert"
			Me.SP_DELETE = "prc_PersonContactType_Delete"
			Me.SP_DISABLE = "prc_PersonContactType_UpdateByPK"
			Me.SP_GETALL = "prc_PersonContactType_SelectAll"
			Me.SP_GETONE = "prc_PersonContactType_SlectOne"
			Me.SP_UPDATE = "prc_PersonContactType_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PersonContactType_UpdateByPK"

    End Sub
End Class


Public Class BlPerson_CountryRegion
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPerson_CountryRegion
    Private _myDataAccess As DaPerson_CountryRegion

    Public Property CurrentEntity() As EntPerson_CountryRegion
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_CountryRegion)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_CountryRegion, New DaPerson_CountryRegion(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_CountryRegion)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPerson_CountryRegion)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CountryRegionCode  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CountryRegionCode is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPerson_CountryRegion 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPerson_CountryRegion

    Public Property CurrentEntity() As EntPerson_CountryRegion
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_CountryRegion)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_CountryRegion)
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_CountryRegion)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PersonCountryRegion_Insert"
			Me.SP_DELETE = "prc_PersonCountryRegion_Delete"
			Me.SP_DISABLE = "prc_PersonCountryRegion_UpdateByPK"
			Me.SP_GETALL = "prc_PersonCountryRegion_SelectAll"
			Me.SP_GETONE = "prc_PersonCountryRegion_SlectOne"
			Me.SP_UPDATE = "prc_PersonCountryRegion_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PersonCountryRegion_UpdateByPK"

    End Sub
End Class


Public Class BlPerson_StateProvince
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPerson_StateProvince
    Private _myDataAccess As DaPerson_StateProvince

    Public Property CurrentEntity() As EntPerson_StateProvince
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_StateProvince)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_StateProvince, New DaPerson_StateProvince(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_StateProvince)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPerson_StateProvince)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CountryRegionCode  = Nothing
			'Me.CurrentEntity.IsOnlyStateProvinceFlag  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.StateProvinceCode  = Nothing
			Me.CurrentEntity.StateProvinceID  = Int32.MinValue
			Me.CurrentEntity.TerritoryID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CountryRegionCode is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.StateProvinceCode is Nothing OrElse _ 
			Me.CurrentEntity.StateProvinceID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.TerritoryID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPerson_StateProvince 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPerson_StateProvince

    Public Property CurrentEntity() As EntPerson_StateProvince
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPerson_StateProvince)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPerson_StateProvince)
        Me._CurrentEntity = CType(MyBase.Entity, EntPerson_StateProvince)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PersonStateProvince_Insert"
			Me.SP_DELETE = "prc_PersonStateProvince_Delete"
			Me.SP_DISABLE = "prc_PersonStateProvince_UpdateByPK"
			Me.SP_GETALL = "prc_PersonStateProvince_SelectAll"
			Me.SP_GETONE = "prc_PersonStateProvince_SlectOne"
			Me.SP_UPDATE = "prc_PersonStateProvince_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PersonStateProvince_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_BillOfMaterials
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_BillOfMaterials
    Private _myDataAccess As DaProduction_BillOfMaterials

    Public Property CurrentEntity() As EntProduction_BillOfMaterials
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_BillOfMaterials)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_BillOfMaterials, New DaProduction_BillOfMaterials(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_BillOfMaterials)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_BillOfMaterials)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.BillOfMaterialsID  = Int32.MinValue
			Me.CurrentEntity.BOMLevel  = Int16.MinValue
			Me.CurrentEntity.ComponentID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.PerAssemblyQty  =  Decimal.MinValue
			Me.CurrentEntity.StartDate  = Date.MinValue
			Me.CurrentEntity.UnitMeasureCode  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.BillOfMaterialsID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.BOMLevel  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.ComponentID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.PerAssemblyQty  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.StartDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.UnitMeasureCode is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_BillOfMaterials 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_BillOfMaterials

    Public Property CurrentEntity() As EntProduction_BillOfMaterials
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_BillOfMaterials)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_BillOfMaterials)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_BillOfMaterials)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionBillOfMaterials_Insert"
			Me.SP_DELETE = "prc_ProductionBillOfMaterials_Delete"
			Me.SP_DISABLE = "prc_ProductionBillOfMaterials_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionBillOfMaterials_SelectAll"
			Me.SP_GETONE = "prc_ProductionBillOfMaterials_SlectOne"
			Me.SP_UPDATE = "prc_ProductionBillOfMaterials_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionBillOfMaterials_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_Culture
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_Culture
    Private _myDataAccess As DaProduction_Culture

    Public Property CurrentEntity() As EntProduction_Culture
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Culture)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Culture, New DaProduction_Culture(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Culture)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_Culture)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CultureID  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CultureID is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_Culture 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_Culture

    Public Property CurrentEntity() As EntProduction_Culture
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Culture)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Culture)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Culture)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionCulture_Insert"
			Me.SP_DELETE = "prc_ProductionCulture_Delete"
			Me.SP_DISABLE = "prc_ProductionCulture_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionCulture_SelectAll"
			Me.SP_GETONE = "prc_ProductionCulture_SlectOne"
			Me.SP_UPDATE = "prc_ProductionCulture_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionCulture_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_Document
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_Document
    Private _myDataAccess As DaProduction_Document

    Public Property CurrentEntity() As EntProduction_Document
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Document)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Document, New DaProduction_Document(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Document)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_Document)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ChangeNumber  = Int32.MinValue
			Me.CurrentEntity.DocumentID  = Int32.MinValue
			Me.CurrentEntity.FileExtension  = Nothing
			Me.CurrentEntity.FileName  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Revision  = Nothing
			Me.CurrentEntity.Status  = Byte.MinValue
			Me.CurrentEntity.Title  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ChangeNumber = Int32.MinValue OrElse _ 
			Me.CurrentEntity.DocumentID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.FileExtension is Nothing OrElse _ 
			Me.CurrentEntity.FileName is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Revision is Nothing OrElse _ 
			Me.CurrentEntity.Status  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.Title is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_Document 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_Document

    Public Property CurrentEntity() As EntProduction_Document
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Document)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Document)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Document)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionDocument_Insert"
			Me.SP_DELETE = "prc_ProductionDocument_Delete"
			Me.SP_DISABLE = "prc_ProductionDocument_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionDocument_SelectAll"
			Me.SP_GETONE = "prc_ProductionDocument_SlectOne"
			Me.SP_UPDATE = "prc_ProductionDocument_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionDocument_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_Illustration
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_Illustration
    Private _myDataAccess As DaProduction_Illustration

    Public Property CurrentEntity() As EntProduction_Illustration
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Illustration)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Illustration, New DaProduction_Illustration(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Illustration)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_Illustration)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.IllustrationID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.IllustrationID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_Illustration 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_Illustration

    Public Property CurrentEntity() As EntProduction_Illustration
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Illustration)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Illustration)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Illustration)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionIllustration_Insert"
			Me.SP_DELETE = "prc_ProductionIllustration_Delete"
			Me.SP_DISABLE = "prc_ProductionIllustration_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionIllustration_SelectAll"
			Me.SP_GETONE = "prc_ProductionIllustration_SlectOne"
			Me.SP_UPDATE = "prc_ProductionIllustration_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionIllustration_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_Location
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_Location
    Private _myDataAccess As DaProduction_Location

    Public Property CurrentEntity() As EntProduction_Location
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Location)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Location, New DaProduction_Location(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Location)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_Location)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.Availability  =  Decimal.MinValue
			Me.CurrentEntity.CostRate  =  Decimal.MinValue
			Me.CurrentEntity.LocationID  = Int16.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.Availability  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.CostRate  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.LocationID  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_Location 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_Location

    Public Property CurrentEntity() As EntProduction_Location
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Location)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Location)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Location)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionLocation_Insert"
			Me.SP_DELETE = "prc_ProductionLocation_Delete"
			Me.SP_DISABLE = "prc_ProductionLocation_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionLocation_SelectAll"
			Me.SP_GETONE = "prc_ProductionLocation_SlectOne"
			Me.SP_UPDATE = "prc_ProductionLocation_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionLocation_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_Product
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_Product
    Private _myDataAccess As DaProduction_Product

    Public Property CurrentEntity() As EntProduction_Product
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Product)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Product, New DaProduction_Product(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Product)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_Product)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DaysToManufacture  = Int32.MinValue
			'Me.CurrentEntity.FinishedGoodsFlag  = Nothing
			Me.CurrentEntity.ListPrice  =  Decimal.MinValue
			'Me.CurrentEntity.MakeFlag  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.ProductNumber  = Nothing
			Me.CurrentEntity.ReorderPoint  = Int16.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SafetyStockLevel  = Int16.MinValue
			Me.CurrentEntity.SellStartDate  = Date.MinValue
			Me.CurrentEntity.StandardCost  =  Decimal.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DaysToManufacture = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ListPrice  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ProductNumber is Nothing OrElse _ 
			Me.CurrentEntity.ReorderPoint  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.SafetyStockLevel  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.SellStartDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.StandardCost  =  Decimal.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_Product 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_Product

    Public Property CurrentEntity() As EntProduction_Product
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_Product)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_Product)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_Product)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProduct_Insert"
			Me.SP_DELETE = "prc_ProductionProduct_Delete"
			Me.SP_DISABLE = "prc_ProductionProduct_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProduct_SelectAll"
			Me.SP_GETONE = "prc_ProductionProduct_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProduct_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProduct_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductCategory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductCategory
    Private _myDataAccess As DaProduction_ProductCategory

    Public Property CurrentEntity() As EntProduction_ProductCategory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductCategory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductCategory, New DaProduction_ProductCategory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductCategory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductCategory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.ProductCategoryID  = Int32.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ProductCategoryID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductCategory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductCategory

    Public Property CurrentEntity() As EntProduction_ProductCategory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductCategory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductCategory)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductCategory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductCategory_Insert"
			Me.SP_DELETE = "prc_ProductionProductCategory_Delete"
			Me.SP_DISABLE = "prc_ProductionProductCategory_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductCategory_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductCategory_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductCategory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductCategory_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductCostHistory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductCostHistory
    Private _myDataAccess As DaProduction_ProductCostHistory

    Public Property CurrentEntity() As EntProduction_ProductCostHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductCostHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductCostHistory, New DaProduction_ProductCostHistory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductCostHistory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductCostHistory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.StandardCost  =  Decimal.MinValue
			Me.CurrentEntity.StartDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.StandardCost  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.StartDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductCostHistory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductCostHistory

    Public Property CurrentEntity() As EntProduction_ProductCostHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductCostHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductCostHistory)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductCostHistory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductCostHistory_Insert"
			Me.SP_DELETE = "prc_ProductionProductCostHistory_Delete"
			Me.SP_DISABLE = "prc_ProductionProductCostHistory_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductCostHistory_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductCostHistory_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductCostHistory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductCostHistory_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductDescription
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductDescription
    Private _myDataAccess As DaProduction_ProductDescription

    Public Property CurrentEntity() As EntProduction_ProductDescription
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductDescription)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductDescription, New DaProduction_ProductDescription(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductDescription)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductDescription)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.Description  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductDescriptionID  = Int32.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.Description is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductDescriptionID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductDescription 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductDescription

    Public Property CurrentEntity() As EntProduction_ProductDescription
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductDescription)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductDescription)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductDescription)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductDescription_Insert"
			Me.SP_DELETE = "prc_ProductionProductDescription_Delete"
			Me.SP_DISABLE = "prc_ProductionProductDescription_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductDescription_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductDescription_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductDescription_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductDescription_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductDocument
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductDocument
    Private _myDataAccess As DaProduction_ProductDocument

    Public Property CurrentEntity() As EntProduction_ProductDocument
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductDocument)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductDocument, New DaProduction_ProductDocument(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductDocument)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductDocument)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DocumentID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DocumentID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductDocument 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductDocument

    Public Property CurrentEntity() As EntProduction_ProductDocument
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductDocument)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductDocument)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductDocument)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductDocument_Insert"
			Me.SP_DELETE = "prc_ProductionProductDocument_Delete"
			Me.SP_DISABLE = "prc_ProductionProductDocument_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductDocument_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductDocument_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductDocument_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductDocument_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductInventory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductInventory
    Private _myDataAccess As DaProduction_ProductInventory

    Public Property CurrentEntity() As EntProduction_ProductInventory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductInventory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductInventory, New DaProduction_ProductInventory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductInventory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductInventory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.Bin  = Byte.MinValue
			Me.CurrentEntity.LocationID  = Int16.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.Quantity  = Int16.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.Shelf  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.Bin  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.LocationID  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Quantity  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.Shelf is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductInventory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductInventory

    Public Property CurrentEntity() As EntProduction_ProductInventory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductInventory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductInventory)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductInventory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductInventory_Insert"
			Me.SP_DELETE = "prc_ProductionProductInventory_Delete"
			Me.SP_DISABLE = "prc_ProductionProductInventory_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductInventory_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductInventory_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductInventory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductInventory_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductListPriceHistory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductListPriceHistory
    Private _myDataAccess As DaProduction_ProductListPriceHistory

    Public Property CurrentEntity() As EntProduction_ProductListPriceHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductListPriceHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductListPriceHistory, New DaProduction_ProductListPriceHistory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductListPriceHistory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductListPriceHistory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ListPrice  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.StartDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ListPrice  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.StartDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductListPriceHistory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductListPriceHistory

    Public Property CurrentEntity() As EntProduction_ProductListPriceHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductListPriceHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductListPriceHistory)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductListPriceHistory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductListPriceHistory_Insert"
			Me.SP_DELETE = "prc_ProductionProductListPriceHistory_Delete"
			Me.SP_DISABLE = "prc_ProductionProductListPriceHistory_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductListPriceHistory_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductListPriceHistory_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductListPriceHistory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductListPriceHistory_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductModel
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductModel
    Private _myDataAccess As DaProduction_ProductModel

    Public Property CurrentEntity() As EntProduction_ProductModel
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductModel)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductModel, New DaProduction_ProductModel(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductModel)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductModel)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.ProductModelID  = Int32.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ProductModelID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductModel 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductModel

    Public Property CurrentEntity() As EntProduction_ProductModel
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductModel)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductModel)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductModel)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductModel_Insert"
			Me.SP_DELETE = "prc_ProductionProductModel_Delete"
			Me.SP_DISABLE = "prc_ProductionProductModel_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductModel_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductModel_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductModel_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductModel_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductModelIllustration
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductModelIllustration
    Private _myDataAccess As DaProduction_ProductModelIllustration

    Public Property CurrentEntity() As EntProduction_ProductModelIllustration
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductModelIllustration)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductModelIllustration, New DaProduction_ProductModelIllustration(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductModelIllustration)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductModelIllustration)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.IllustrationID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductModelID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.IllustrationID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductModelID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductModelIllustration 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductModelIllustration

    Public Property CurrentEntity() As EntProduction_ProductModelIllustration
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductModelIllustration)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductModelIllustration)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductModelIllustration)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductModelIllustration_Insert"
			Me.SP_DELETE = "prc_ProductionProductModelIllustration_Delete"
			Me.SP_DISABLE = "prc_ProductionProductModelIllustration_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductModelIllustration_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductModelIllustration_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductModelIllustration_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductModelIllustration_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductModelProductDescriptionCulture
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductModelProductDescriptionCulture
    Private _myDataAccess As DaProduction_ProductModelProductDescriptionCulture

    Public Property CurrentEntity() As EntProduction_ProductModelProductDescriptionCulture
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductModelProductDescriptionCulture)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductModelProductDescriptionCulture, New DaProduction_ProductModelProductDescriptionCulture(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductModelProductDescriptionCulture)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductModelProductDescriptionCulture)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CultureID  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductDescriptionID  = Int32.MinValue
			Me.CurrentEntity.ProductModelID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CultureID is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductDescriptionID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ProductModelID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductModelProductDescriptionCulture 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductModelProductDescriptionCulture

    Public Property CurrentEntity() As EntProduction_ProductModelProductDescriptionCulture
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductModelProductDescriptionCulture)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductModelProductDescriptionCulture)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductModelProductDescriptionCulture)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductModelProductDescriptionCulture_Insert"
			Me.SP_DELETE = "prc_ProductionProductModelProductDescriptionCulture_Delete"
			Me.SP_DISABLE = "prc_ProductionProductModelProductDescriptionCulture_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductModelProductDescriptionCulture_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductModelProductDescriptionCulture_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductModelProductDescriptionCulture_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductModelProductDescriptionCulture_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductPhoto
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductPhoto
    Private _myDataAccess As DaProduction_ProductPhoto

    Public Property CurrentEntity() As EntProduction_ProductPhoto
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductPhoto)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductPhoto, New DaProduction_ProductPhoto(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductPhoto)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductPhoto)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductPhotoID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductPhotoID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductPhoto 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductPhoto

    Public Property CurrentEntity() As EntProduction_ProductPhoto
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductPhoto)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductPhoto)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductPhoto)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductPhoto_Insert"
			Me.SP_DELETE = "prc_ProductionProductPhoto_Delete"
			Me.SP_DISABLE = "prc_ProductionProductPhoto_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductPhoto_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductPhoto_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductPhoto_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductPhoto_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductProductPhoto
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductProductPhoto
    Private _myDataAccess As DaProduction_ProductProductPhoto

    Public Property CurrentEntity() As EntProduction_ProductProductPhoto
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductProductPhoto)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductProductPhoto, New DaProduction_ProductProductPhoto(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductProductPhoto)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductProductPhoto)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Primary  = Nothing
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.ProductPhotoID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ProductPhotoID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductProductPhoto 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductProductPhoto

    Public Property CurrentEntity() As EntProduction_ProductProductPhoto
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductProductPhoto)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductProductPhoto)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductProductPhoto)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductProductPhoto_Insert"
			Me.SP_DELETE = "prc_ProductionProductProductPhoto_Delete"
			Me.SP_DISABLE = "prc_ProductionProductProductPhoto_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductProductPhoto_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductProductPhoto_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductProductPhoto_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductProductPhoto_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductReview
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductReview
    Private _myDataAccess As DaProduction_ProductReview

    Public Property CurrentEntity() As EntProduction_ProductReview
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductReview)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductReview, New DaProduction_ProductReview(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductReview)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductReview)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.EmailAddress  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.ProductReviewID  = Int32.MinValue
			Me.CurrentEntity.Rating  = Int32.MinValue
			Me.CurrentEntity.ReviewDate  = Date.MinValue
			Me.CurrentEntity.ReviewerName  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.EmailAddress is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ProductReviewID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Rating = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ReviewDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ReviewerName is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductReview 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductReview

    Public Property CurrentEntity() As EntProduction_ProductReview
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductReview)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductReview)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductReview)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductReview_Insert"
			Me.SP_DELETE = "prc_ProductionProductReview_Delete"
			Me.SP_DISABLE = "prc_ProductionProductReview_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductReview_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductReview_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductReview_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductReview_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ProductSubcategory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ProductSubcategory
    Private _myDataAccess As DaProduction_ProductSubcategory

    Public Property CurrentEntity() As EntProduction_ProductSubcategory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductSubcategory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductSubcategory, New DaProduction_ProductSubcategory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductSubcategory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ProductSubcategory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.ProductCategoryID  = Int32.MinValue
			Me.CurrentEntity.ProductSubcategoryID  = Int32.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ProductCategoryID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ProductSubcategoryID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ProductSubcategory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ProductSubcategory

    Public Property CurrentEntity() As EntProduction_ProductSubcategory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ProductSubcategory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ProductSubcategory)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ProductSubcategory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionProductSubcategory_Insert"
			Me.SP_DELETE = "prc_ProductionProductSubcategory_Delete"
			Me.SP_DISABLE = "prc_ProductionProductSubcategory_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionProductSubcategory_SelectAll"
			Me.SP_GETONE = "prc_ProductionProductSubcategory_SlectOne"
			Me.SP_UPDATE = "prc_ProductionProductSubcategory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionProductSubcategory_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_ScrapReason
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_ScrapReason
    Private _myDataAccess As DaProduction_ScrapReason

    Public Property CurrentEntity() As EntProduction_ScrapReason
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ScrapReason)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ScrapReason, New DaProduction_ScrapReason(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ScrapReason)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_ScrapReason)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.ScrapReasonID  = Int16.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ScrapReasonID  = Int16.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_ScrapReason 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_ScrapReason

    Public Property CurrentEntity() As EntProduction_ScrapReason
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_ScrapReason)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_ScrapReason)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_ScrapReason)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionScrapReason_Insert"
			Me.SP_DELETE = "prc_ProductionScrapReason_Delete"
			Me.SP_DISABLE = "prc_ProductionScrapReason_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionScrapReason_SelectAll"
			Me.SP_GETONE = "prc_ProductionScrapReason_SlectOne"
			Me.SP_UPDATE = "prc_ProductionScrapReason_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionScrapReason_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_TransactionHistory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_TransactionHistory
    Private _myDataAccess As DaProduction_TransactionHistory

    Public Property CurrentEntity() As EntProduction_TransactionHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_TransactionHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_TransactionHistory, New DaProduction_TransactionHistory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_TransactionHistory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_TransactionHistory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ActualCost  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.Quantity  = Int32.MinValue
			Me.CurrentEntity.ReferenceOrderID  = Int32.MinValue
			Me.CurrentEntity.ReferenceOrderLineID  = Int32.MinValue
			Me.CurrentEntity.TransactionDate  = Date.MinValue
			Me.CurrentEntity.TransactionID  = Int32.MinValue
			Me.CurrentEntity.TransactionType  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ActualCost  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Quantity = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ReferenceOrderID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ReferenceOrderLineID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.TransactionDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.TransactionID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.TransactionType is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_TransactionHistory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_TransactionHistory

    Public Property CurrentEntity() As EntProduction_TransactionHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_TransactionHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_TransactionHistory)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_TransactionHistory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionTransactionHistory_Insert"
			Me.SP_DELETE = "prc_ProductionTransactionHistory_Delete"
			Me.SP_DISABLE = "prc_ProductionTransactionHistory_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionTransactionHistory_SelectAll"
			Me.SP_GETONE = "prc_ProductionTransactionHistory_SlectOne"
			Me.SP_UPDATE = "prc_ProductionTransactionHistory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionTransactionHistory_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_TransactionHistoryArchive
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_TransactionHistoryArchive
    Private _myDataAccess As DaProduction_TransactionHistoryArchive

    Public Property CurrentEntity() As EntProduction_TransactionHistoryArchive
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_TransactionHistoryArchive)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_TransactionHistoryArchive, New DaProduction_TransactionHistoryArchive(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_TransactionHistoryArchive)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_TransactionHistoryArchive)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ActualCost  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.Quantity  = Int32.MinValue
			Me.CurrentEntity.ReferenceOrderID  = Int32.MinValue
			Me.CurrentEntity.ReferenceOrderLineID  = Int32.MinValue
			Me.CurrentEntity.TransactionDate  = Date.MinValue
			Me.CurrentEntity.TransactionID  = Int32.MinValue
			Me.CurrentEntity.TransactionType  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ActualCost  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Quantity = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ReferenceOrderID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ReferenceOrderLineID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.TransactionDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.TransactionID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.TransactionType is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_TransactionHistoryArchive 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_TransactionHistoryArchive

    Public Property CurrentEntity() As EntProduction_TransactionHistoryArchive
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_TransactionHistoryArchive)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_TransactionHistoryArchive)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_TransactionHistoryArchive)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionTransactionHistoryArchive_Insert"
			Me.SP_DELETE = "prc_ProductionTransactionHistoryArchive_Delete"
			Me.SP_DISABLE = "prc_ProductionTransactionHistoryArchive_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionTransactionHistoryArchive_SelectAll"
			Me.SP_GETONE = "prc_ProductionTransactionHistoryArchive_SlectOne"
			Me.SP_UPDATE = "prc_ProductionTransactionHistoryArchive_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionTransactionHistoryArchive_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_UnitMeasure
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_UnitMeasure
    Private _myDataAccess As DaProduction_UnitMeasure

    Public Property CurrentEntity() As EntProduction_UnitMeasure
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_UnitMeasure)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_UnitMeasure, New DaProduction_UnitMeasure(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_UnitMeasure)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_UnitMeasure)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.UnitMeasureCode  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.UnitMeasureCode is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_UnitMeasure 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_UnitMeasure

    Public Property CurrentEntity() As EntProduction_UnitMeasure
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_UnitMeasure)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_UnitMeasure)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_UnitMeasure)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionUnitMeasure_Insert"
			Me.SP_DELETE = "prc_ProductionUnitMeasure_Delete"
			Me.SP_DISABLE = "prc_ProductionUnitMeasure_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionUnitMeasure_SelectAll"
			Me.SP_GETONE = "prc_ProductionUnitMeasure_SlectOne"
			Me.SP_UPDATE = "prc_ProductionUnitMeasure_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionUnitMeasure_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_WorkOrder
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_WorkOrder
    Private _myDataAccess As DaProduction_WorkOrder

    Public Property CurrentEntity() As EntProduction_WorkOrder
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_WorkOrder)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_WorkOrder, New DaProduction_WorkOrder(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_WorkOrder)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_WorkOrder)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DueDate  = Date.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.OrderQty  = Int32.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.ScrappedQty  = Int16.MinValue
			Me.CurrentEntity.StartDate  = Date.MinValue
			Me.CurrentEntity.StockedQty  = Int32.MinValue
			Me.CurrentEntity.WorkOrderID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DueDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.OrderQty = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ScrappedQty  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.StartDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.StockedQty = Int32.MinValue OrElse _ 
			Me.CurrentEntity.WorkOrderID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_WorkOrder 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_WorkOrder

    Public Property CurrentEntity() As EntProduction_WorkOrder
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_WorkOrder)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_WorkOrder)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_WorkOrder)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionWorkOrder_Insert"
			Me.SP_DELETE = "prc_ProductionWorkOrder_Delete"
			Me.SP_DISABLE = "prc_ProductionWorkOrder_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionWorkOrder_SelectAll"
			Me.SP_GETONE = "prc_ProductionWorkOrder_SlectOne"
			Me.SP_UPDATE = "prc_ProductionWorkOrder_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionWorkOrder_UpdateByPK"

    End Sub
End Class


Public Class BlProduction_WorkOrderRouting
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntProduction_WorkOrderRouting
    Private _myDataAccess As DaProduction_WorkOrderRouting

    Public Property CurrentEntity() As EntProduction_WorkOrderRouting
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_WorkOrderRouting)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_WorkOrderRouting, New DaProduction_WorkOrderRouting(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_WorkOrderRouting)
        Me._myDataAccess = CType(MyBase.DataAccess, DaProduction_WorkOrderRouting)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.LocationID  = Int16.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.OperationSequence  = Int16.MinValue
			Me.CurrentEntity.PlannedCost  =  Decimal.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.ScheduledEndDate  = Date.MinValue
			Me.CurrentEntity.ScheduledStartDate  = Date.MinValue
			Me.CurrentEntity.WorkOrderID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.LocationID  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.OperationSequence  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.PlannedCost  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ScheduledEndDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ScheduledStartDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.WorkOrderID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaProduction_WorkOrderRouting 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntProduction_WorkOrderRouting

    Public Property CurrentEntity() As EntProduction_WorkOrderRouting
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntProduction_WorkOrderRouting)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntProduction_WorkOrderRouting)
        Me._CurrentEntity = CType(MyBase.Entity, EntProduction_WorkOrderRouting)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_ProductionWorkOrderRouting_Insert"
			Me.SP_DELETE = "prc_ProductionWorkOrderRouting_Delete"
			Me.SP_DISABLE = "prc_ProductionWorkOrderRouting_UpdateByPK"
			Me.SP_GETALL = "prc_ProductionWorkOrderRouting_SelectAll"
			Me.SP_GETONE = "prc_ProductionWorkOrderRouting_SlectOne"
			Me.SP_UPDATE = "prc_ProductionWorkOrderRouting_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_ProductionWorkOrderRouting_UpdateByPK"

    End Sub
End Class


Public Class BlPurchasing_ProductVendor
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPurchasing_ProductVendor
    Private _myDataAccess As DaPurchasing_ProductVendor

    Public Property CurrentEntity() As EntPurchasing_ProductVendor
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_ProductVendor)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_ProductVendor, New DaPurchasing_ProductVendor(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_ProductVendor)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPurchasing_ProductVendor)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AverageLeadTime  = Int32.MinValue
			Me.CurrentEntity.MaxOrderQty  = Int32.MinValue
			Me.CurrentEntity.MinOrderQty  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.StandardPrice  =  Decimal.MinValue
			Me.CurrentEntity.UnitMeasureCode  = Nothing
			Me.CurrentEntity.VendorID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AverageLeadTime = Int32.MinValue OrElse _ 
			Me.CurrentEntity.MaxOrderQty = Int32.MinValue OrElse _ 
			Me.CurrentEntity.MinOrderQty = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.StandardPrice  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.UnitMeasureCode is Nothing OrElse _ 
			Me.CurrentEntity.VendorID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPurchasing_ProductVendor 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPurchasing_ProductVendor

    Public Property CurrentEntity() As EntPurchasing_ProductVendor
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_ProductVendor)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_ProductVendor)
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_ProductVendor)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PurchasingProductVendor_Insert"
			Me.SP_DELETE = "prc_PurchasingProductVendor_Delete"
			Me.SP_DISABLE = "prc_PurchasingProductVendor_UpdateByPK"
			Me.SP_GETALL = "prc_PurchasingProductVendor_SelectAll"
			Me.SP_GETONE = "prc_PurchasingProductVendor_SlectOne"
			Me.SP_UPDATE = "prc_PurchasingProductVendor_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PurchasingProductVendor_UpdateByPK"

    End Sub
End Class


Public Class BlPurchasing_PurchaseOrderDetail
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPurchasing_PurchaseOrderDetail
    Private _myDataAccess As DaPurchasing_PurchaseOrderDetail

    Public Property CurrentEntity() As EntPurchasing_PurchaseOrderDetail
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_PurchaseOrderDetail)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_PurchaseOrderDetail, New DaPurchasing_PurchaseOrderDetail(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_PurchaseOrderDetail)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPurchasing_PurchaseOrderDetail)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DueDate  = Date.MinValue
			Me.CurrentEntity.LineTotal  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.OrderQty  = Int16.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.PurchaseOrderDetailID  = Int32.MinValue
			Me.CurrentEntity.PurchaseOrderID  = Int32.MinValue
			Me.CurrentEntity.ReceivedQty  =  Decimal.MinValue
			Me.CurrentEntity.RejectedQty  =  Decimal.MinValue
			Me.CurrentEntity.StockedQty  =  Decimal.MinValue
			Me.CurrentEntity.UnitPrice  =  Decimal.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DueDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.LineTotal  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.OrderQty  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.PurchaseOrderDetailID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.PurchaseOrderID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ReceivedQty  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.RejectedQty  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.StockedQty  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.UnitPrice  =  Decimal.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPurchasing_PurchaseOrderDetail 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPurchasing_PurchaseOrderDetail

    Public Property CurrentEntity() As EntPurchasing_PurchaseOrderDetail
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_PurchaseOrderDetail)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_PurchaseOrderDetail)
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_PurchaseOrderDetail)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PurchasingPurchaseOrderDetail_Insert"
			Me.SP_DELETE = "prc_PurchasingPurchaseOrderDetail_Delete"
			Me.SP_DISABLE = "prc_PurchasingPurchaseOrderDetail_UpdateByPK"
			Me.SP_GETALL = "prc_PurchasingPurchaseOrderDetail_SelectAll"
			Me.SP_GETONE = "prc_PurchasingPurchaseOrderDetail_SlectOne"
			Me.SP_UPDATE = "prc_PurchasingPurchaseOrderDetail_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PurchasingPurchaseOrderDetail_UpdateByPK"

    End Sub
End Class


Public Class BlPurchasing_PurchaseOrderHeader
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPurchasing_PurchaseOrderHeader
    Private _myDataAccess As DaPurchasing_PurchaseOrderHeader

    Public Property CurrentEntity() As EntPurchasing_PurchaseOrderHeader
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_PurchaseOrderHeader)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_PurchaseOrderHeader, New DaPurchasing_PurchaseOrderHeader(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_PurchaseOrderHeader)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPurchasing_PurchaseOrderHeader)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.EmployeeID  = Int32.MinValue
			Me.CurrentEntity.Freight  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.OrderDate  = Date.MinValue
			Me.CurrentEntity.PurchaseOrderID  = Int32.MinValue
			Me.CurrentEntity.RevisionNumber  = Byte.MinValue
			Me.CurrentEntity.ShipMethodID  = Int32.MinValue
			Me.CurrentEntity.Status  = Byte.MinValue
			Me.CurrentEntity.SubTotal  =  Decimal.MinValue
			Me.CurrentEntity.TaxAmt  =  Decimal.MinValue
			Me.CurrentEntity.TotalDue  =  Decimal.MinValue
			Me.CurrentEntity.VendorID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.EmployeeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Freight  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.OrderDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.PurchaseOrderID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.RevisionNumber  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.ShipMethodID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Status  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.SubTotal  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.TaxAmt  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.TotalDue  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.VendorID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPurchasing_PurchaseOrderHeader 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPurchasing_PurchaseOrderHeader

    Public Property CurrentEntity() As EntPurchasing_PurchaseOrderHeader
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_PurchaseOrderHeader)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_PurchaseOrderHeader)
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_PurchaseOrderHeader)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PurchasingPurchaseOrderHeader_Insert"
			Me.SP_DELETE = "prc_PurchasingPurchaseOrderHeader_Delete"
			Me.SP_DISABLE = "prc_PurchasingPurchaseOrderHeader_UpdateByPK"
			Me.SP_GETALL = "prc_PurchasingPurchaseOrderHeader_SelectAll"
			Me.SP_GETONE = "prc_PurchasingPurchaseOrderHeader_SlectOne"
			Me.SP_UPDATE = "prc_PurchasingPurchaseOrderHeader_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PurchasingPurchaseOrderHeader_UpdateByPK"

    End Sub
End Class


Public Class BlPurchasing_ShipMethod
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPurchasing_ShipMethod
    Private _myDataAccess As DaPurchasing_ShipMethod

    Public Property CurrentEntity() As EntPurchasing_ShipMethod
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_ShipMethod)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_ShipMethod, New DaPurchasing_ShipMethod(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_ShipMethod)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPurchasing_ShipMethod)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.ShipBase  =  Decimal.MinValue
			Me.CurrentEntity.ShipMethodID  = Int32.MinValue
			Me.CurrentEntity.ShipRate  =  Decimal.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ShipBase  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ShipMethodID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ShipRate  =  Decimal.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPurchasing_ShipMethod 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPurchasing_ShipMethod

    Public Property CurrentEntity() As EntPurchasing_ShipMethod
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_ShipMethod)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_ShipMethod)
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_ShipMethod)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PurchasingShipMethod_Insert"
			Me.SP_DELETE = "prc_PurchasingShipMethod_Delete"
			Me.SP_DISABLE = "prc_PurchasingShipMethod_UpdateByPK"
			Me.SP_GETALL = "prc_PurchasingShipMethod_SelectAll"
			Me.SP_GETONE = "prc_PurchasingShipMethod_SlectOne"
			Me.SP_UPDATE = "prc_PurchasingShipMethod_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PurchasingShipMethod_UpdateByPK"

    End Sub
End Class


Public Class BlPurchasing_Vendor
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPurchasing_Vendor
    Private _myDataAccess As DaPurchasing_Vendor

    Public Property CurrentEntity() As EntPurchasing_Vendor
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_Vendor)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_Vendor, New DaPurchasing_Vendor(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_Vendor)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPurchasing_Vendor)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AccountNumber  = Nothing
			'Me.CurrentEntity.ActiveFlag  = Nothing
			Me.CurrentEntity.CreditRating  = Byte.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			'Me.CurrentEntity.PreferredVendorStatus  = Nothing
			Me.CurrentEntity.VendorID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AccountNumber is Nothing OrElse _ 
			Me.CurrentEntity.CreditRating  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.VendorID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPurchasing_Vendor 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPurchasing_Vendor

    Public Property CurrentEntity() As EntPurchasing_Vendor
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_Vendor)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_Vendor)
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_Vendor)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PurchasingVendor_Insert"
			Me.SP_DELETE = "prc_PurchasingVendor_Delete"
			Me.SP_DISABLE = "prc_PurchasingVendor_UpdateByPK"
			Me.SP_GETALL = "prc_PurchasingVendor_SelectAll"
			Me.SP_GETONE = "prc_PurchasingVendor_SlectOne"
			Me.SP_UPDATE = "prc_PurchasingVendor_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PurchasingVendor_UpdateByPK"

    End Sub
End Class


Public Class BlPurchasing_VendorAddress
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPurchasing_VendorAddress
    Private _myDataAccess As DaPurchasing_VendorAddress

    Public Property CurrentEntity() As EntPurchasing_VendorAddress
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_VendorAddress)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_VendorAddress, New DaPurchasing_VendorAddress(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_VendorAddress)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPurchasing_VendorAddress)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AddressID  = Int32.MinValue
			Me.CurrentEntity.AddressTypeID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.VendorID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AddressID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.AddressTypeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.VendorID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPurchasing_VendorAddress 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPurchasing_VendorAddress

    Public Property CurrentEntity() As EntPurchasing_VendorAddress
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_VendorAddress)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_VendorAddress)
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_VendorAddress)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PurchasingVendorAddress_Insert"
			Me.SP_DELETE = "prc_PurchasingVendorAddress_Delete"
			Me.SP_DISABLE = "prc_PurchasingVendorAddress_UpdateByPK"
			Me.SP_GETALL = "prc_PurchasingVendorAddress_SelectAll"
			Me.SP_GETONE = "prc_PurchasingVendorAddress_SlectOne"
			Me.SP_UPDATE = "prc_PurchasingVendorAddress_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PurchasingVendorAddress_UpdateByPK"

    End Sub
End Class


Public Class BlPurchasing_VendorContact
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntPurchasing_VendorContact
    Private _myDataAccess As DaPurchasing_VendorContact

    Public Property CurrentEntity() As EntPurchasing_VendorContact
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_VendorContact)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_VendorContact, New DaPurchasing_VendorContact(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_VendorContact)
        Me._myDataAccess = CType(MyBase.DataAccess, DaPurchasing_VendorContact)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ContactID  = Int32.MinValue
			Me.CurrentEntity.ContactTypeID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.VendorID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ContactID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ContactTypeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.VendorID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaPurchasing_VendorContact 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntPurchasing_VendorContact

    Public Property CurrentEntity() As EntPurchasing_VendorContact
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntPurchasing_VendorContact)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntPurchasing_VendorContact)
        Me._CurrentEntity = CType(MyBase.Entity, EntPurchasing_VendorContact)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_PurchasingVendorContact_Insert"
			Me.SP_DELETE = "prc_PurchasingVendorContact_Delete"
			Me.SP_DISABLE = "prc_PurchasingVendorContact_UpdateByPK"
			Me.SP_GETALL = "prc_PurchasingVendorContact_SelectAll"
			Me.SP_GETONE = "prc_PurchasingVendorContact_SlectOne"
			Me.SP_UPDATE = "prc_PurchasingVendorContact_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_PurchasingVendorContact_UpdateByPK"

    End Sub
End Class


Public Class BlSales_ContactCreditCard
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_ContactCreditCard
    Private _myDataAccess As DaSales_ContactCreditCard

    Public Property CurrentEntity() As EntSales_ContactCreditCard
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_ContactCreditCard)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_ContactCreditCard, New DaSales_ContactCreditCard(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_ContactCreditCard)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_ContactCreditCard)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ContactID  = Int32.MinValue
			Me.CurrentEntity.CreditCardID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ContactID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.CreditCardID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_ContactCreditCard 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_ContactCreditCard

    Public Property CurrentEntity() As EntSales_ContactCreditCard
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_ContactCreditCard)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_ContactCreditCard)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_ContactCreditCard)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesContactCreditCard_Insert"
			Me.SP_DELETE = "prc_SalesContactCreditCard_Delete"
			Me.SP_DISABLE = "prc_SalesContactCreditCard_UpdateByPK"
			Me.SP_GETALL = "prc_SalesContactCreditCard_SelectAll"
			Me.SP_GETONE = "prc_SalesContactCreditCard_SlectOne"
			Me.SP_UPDATE = "prc_SalesContactCreditCard_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesContactCreditCard_UpdateByPK"

    End Sub
End Class


Public Class BlSales_CountryRegionCurrency
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_CountryRegionCurrency
    Private _myDataAccess As DaSales_CountryRegionCurrency

    Public Property CurrentEntity() As EntSales_CountryRegionCurrency
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CountryRegionCurrency)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CountryRegionCurrency, New DaSales_CountryRegionCurrency(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CountryRegionCurrency)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_CountryRegionCurrency)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CountryRegionCode  = Nothing
			Me.CurrentEntity.CurrencyCode  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CountryRegionCode is Nothing OrElse _ 
			Me.CurrentEntity.CurrencyCode is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_CountryRegionCurrency 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_CountryRegionCurrency

    Public Property CurrentEntity() As EntSales_CountryRegionCurrency
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CountryRegionCurrency)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CountryRegionCurrency)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CountryRegionCurrency)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesCountryRegionCurrency_Insert"
			Me.SP_DELETE = "prc_SalesCountryRegionCurrency_Delete"
			Me.SP_DISABLE = "prc_SalesCountryRegionCurrency_UpdateByPK"
			Me.SP_GETALL = "prc_SalesCountryRegionCurrency_SelectAll"
			Me.SP_GETONE = "prc_SalesCountryRegionCurrency_SlectOne"
			Me.SP_UPDATE = "prc_SalesCountryRegionCurrency_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesCountryRegionCurrency_UpdateByPK"

    End Sub
End Class


Public Class BlSales_CreditCard
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_CreditCard
    Private _myDataAccess As DaSales_CreditCard

    Public Property CurrentEntity() As EntSales_CreditCard
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CreditCard)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CreditCard, New DaSales_CreditCard(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CreditCard)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_CreditCard)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CardNumber  = Nothing
			Me.CurrentEntity.CardType  = Nothing
			Me.CurrentEntity.CreditCardID  = Int32.MinValue
			Me.CurrentEntity.ExpMonth  = Byte.MinValue
			Me.CurrentEntity.ExpYear  = Int16.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CardNumber is Nothing OrElse _ 
			Me.CurrentEntity.CardType is Nothing OrElse _ 
			Me.CurrentEntity.CreditCardID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ExpMonth  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.ExpYear  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_CreditCard 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_CreditCard

    Public Property CurrentEntity() As EntSales_CreditCard
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CreditCard)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CreditCard)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CreditCard)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesCreditCard_Insert"
			Me.SP_DELETE = "prc_SalesCreditCard_Delete"
			Me.SP_DISABLE = "prc_SalesCreditCard_UpdateByPK"
			Me.SP_GETALL = "prc_SalesCreditCard_SelectAll"
			Me.SP_GETONE = "prc_SalesCreditCard_SlectOne"
			Me.SP_UPDATE = "prc_SalesCreditCard_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesCreditCard_UpdateByPK"

    End Sub
End Class


Public Class BlSales_Currency
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_Currency
    Private _myDataAccess As DaSales_Currency

    Public Property CurrentEntity() As EntSales_Currency
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Currency)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Currency, New DaSales_Currency(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Currency)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_Currency)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CurrencyCode  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CurrencyCode is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_Currency 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_Currency

    Public Property CurrentEntity() As EntSales_Currency
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Currency)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Currency)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Currency)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesCurrency_Insert"
			Me.SP_DELETE = "prc_SalesCurrency_Delete"
			Me.SP_DISABLE = "prc_SalesCurrency_UpdateByPK"
			Me.SP_GETALL = "prc_SalesCurrency_SelectAll"
			Me.SP_GETONE = "prc_SalesCurrency_SlectOne"
			Me.SP_UPDATE = "prc_SalesCurrency_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesCurrency_UpdateByPK"

    End Sub
End Class


Public Class BlSales_CurrencyRate
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_CurrencyRate
    Private _myDataAccess As DaSales_CurrencyRate

    Public Property CurrentEntity() As EntSales_CurrencyRate
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CurrencyRate)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CurrencyRate, New DaSales_CurrencyRate(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CurrencyRate)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_CurrencyRate)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AverageRate  =  Decimal.MinValue
			Me.CurrentEntity.CurrencyRateDate  = Date.MinValue
			Me.CurrentEntity.CurrencyRateID  = Int32.MinValue
			Me.CurrentEntity.EndOfDayRate  =  Decimal.MinValue
			Me.CurrentEntity.FromCurrencyCode  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ToCurrencyCode  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AverageRate  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.CurrencyRateDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.CurrencyRateID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.EndOfDayRate  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.FromCurrencyCode is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ToCurrencyCode is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_CurrencyRate 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_CurrencyRate

    Public Property CurrentEntity() As EntSales_CurrencyRate
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CurrencyRate)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CurrencyRate)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CurrencyRate)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesCurrencyRate_Insert"
			Me.SP_DELETE = "prc_SalesCurrencyRate_Delete"
			Me.SP_DISABLE = "prc_SalesCurrencyRate_UpdateByPK"
			Me.SP_GETALL = "prc_SalesCurrencyRate_SelectAll"
			Me.SP_GETONE = "prc_SalesCurrencyRate_SlectOne"
			Me.SP_UPDATE = "prc_SalesCurrencyRate_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesCurrencyRate_UpdateByPK"

    End Sub
End Class


Public Class BlSales_Customer
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_Customer
    Private _myDataAccess As DaSales_Customer

    Public Property CurrentEntity() As EntSales_Customer
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Customer)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Customer, New DaSales_Customer(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Customer)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_Customer)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AccountNumber  = Nothing
			Me.CurrentEntity.CustomerID  = Int32.MinValue
			Me.CurrentEntity.CustomerType  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AccountNumber is Nothing OrElse _ 
			Me.CurrentEntity.CustomerID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.CustomerType is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_Customer 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_Customer

    Public Property CurrentEntity() As EntSales_Customer
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Customer)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Customer)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Customer)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesCustomer_Insert"
			Me.SP_DELETE = "prc_SalesCustomer_Delete"
			Me.SP_DISABLE = "prc_SalesCustomer_UpdateByPK"
			Me.SP_GETALL = "prc_SalesCustomer_SelectAll"
			Me.SP_GETONE = "prc_SalesCustomer_SlectOne"
			Me.SP_UPDATE = "prc_SalesCustomer_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesCustomer_UpdateByPK"

    End Sub
End Class


Public Class BlSales_CustomerAddress
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_CustomerAddress
    Private _myDataAccess As DaSales_CustomerAddress

    Public Property CurrentEntity() As EntSales_CustomerAddress
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CustomerAddress)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CustomerAddress, New DaSales_CustomerAddress(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CustomerAddress)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_CustomerAddress)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.AddressID  = Int32.MinValue
			Me.CurrentEntity.AddressTypeID  = Int32.MinValue
			Me.CurrentEntity.CustomerID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.AddressID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.AddressTypeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.CustomerID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_CustomerAddress 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_CustomerAddress

    Public Property CurrentEntity() As EntSales_CustomerAddress
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_CustomerAddress)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_CustomerAddress)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_CustomerAddress)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesCustomerAddress_Insert"
			Me.SP_DELETE = "prc_SalesCustomerAddress_Delete"
			Me.SP_DISABLE = "prc_SalesCustomerAddress_UpdateByPK"
			Me.SP_GETALL = "prc_SalesCustomerAddress_SelectAll"
			Me.SP_GETONE = "prc_SalesCustomerAddress_SlectOne"
			Me.SP_UPDATE = "prc_SalesCustomerAddress_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesCustomerAddress_UpdateByPK"

    End Sub
End Class


Public Class BlSales_Individual
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_Individual
    Private _myDataAccess As DaSales_Individual

    Public Property CurrentEntity() As EntSales_Individual
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Individual)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Individual, New DaSales_Individual(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Individual)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_Individual)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ContactID  = Int32.MinValue
			Me.CurrentEntity.CustomerID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ContactID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.CustomerID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_Individual 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_Individual

    Public Property CurrentEntity() As EntSales_Individual
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Individual)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Individual)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Individual)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesIndividual_Insert"
			Me.SP_DELETE = "prc_SalesIndividual_Delete"
			Me.SP_DISABLE = "prc_SalesIndividual_UpdateByPK"
			Me.SP_GETALL = "prc_SalesIndividual_SelectAll"
			Me.SP_GETONE = "prc_SalesIndividual_SlectOne"
			Me.SP_UPDATE = "prc_SalesIndividual_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesIndividual_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesOrderDetail
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesOrderDetail
    Private _myDataAccess As DaSales_SalesOrderDetail

    Public Property CurrentEntity() As EntSales_SalesOrderDetail
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesOrderDetail)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesOrderDetail, New DaSales_SalesOrderDetail(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesOrderDetail)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesOrderDetail)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.LineTotal  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.OrderQty  = Int16.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SalesOrderDetailID  = Int32.MinValue
			Me.CurrentEntity.SalesOrderID  = Int32.MinValue
			Me.CurrentEntity.SpecialOfferID  = Int32.MinValue
			Me.CurrentEntity.UnitPrice  =  Decimal.MinValue
			Me.CurrentEntity.UnitPriceDiscount  =  Decimal.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.LineTotal  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.OrderQty  = Int16.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SalesOrderDetailID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SalesOrderID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SpecialOfferID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.UnitPrice  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.UnitPriceDiscount  =  Decimal.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesOrderDetail 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesOrderDetail

    Public Property CurrentEntity() As EntSales_SalesOrderDetail
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesOrderDetail)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesOrderDetail)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesOrderDetail)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesOrderDetail_Insert"
			Me.SP_DELETE = "prc_SalesSalesOrderDetail_Delete"
			Me.SP_DISABLE = "prc_SalesSalesOrderDetail_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesOrderDetail_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesOrderDetail_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesOrderDetail_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesOrderDetail_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesOrderHeader
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesOrderHeader
    Private _myDataAccess As DaSales_SalesOrderHeader

    Public Property CurrentEntity() As EntSales_SalesOrderHeader
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesOrderHeader)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesOrderHeader, New DaSales_SalesOrderHeader(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesOrderHeader)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesOrderHeader)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.BillToAddressID  = Int32.MinValue
			Me.CurrentEntity.ContactID  = Int32.MinValue
			Me.CurrentEntity.CustomerID  = Int32.MinValue
			Me.CurrentEntity.DueDate  = Date.MinValue
			Me.CurrentEntity.Freight  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.OnlineOrderFlag  = Nothing
			Me.CurrentEntity.OrderDate  = Date.MinValue
			Me.CurrentEntity.RevisionNumber  = Byte.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SalesOrderID  = Int32.MinValue
			Me.CurrentEntity.SalesOrderNumber  = Nothing
			Me.CurrentEntity.ShipMethodID  = Int32.MinValue
			Me.CurrentEntity.ShipToAddressID  = Int32.MinValue
			Me.CurrentEntity.Status  = Byte.MinValue
			Me.CurrentEntity.SubTotal  =  Decimal.MinValue
			Me.CurrentEntity.TaxAmt  =  Decimal.MinValue
			Me.CurrentEntity.TotalDue  =  Decimal.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.BillToAddressID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ContactID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.CustomerID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.DueDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Freight  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.OrderDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.RevisionNumber  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.SalesOrderID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SalesOrderNumber is Nothing OrElse _ 
			Me.CurrentEntity.ShipMethodID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ShipToAddressID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Status  = Byte.MinValue OrElse _ 
			Me.CurrentEntity.SubTotal  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.TaxAmt  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.TotalDue  =  Decimal.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesOrderHeader 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesOrderHeader

    Public Property CurrentEntity() As EntSales_SalesOrderHeader
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesOrderHeader)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesOrderHeader)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesOrderHeader)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesOrderHeader_Insert"
			Me.SP_DELETE = "prc_SalesSalesOrderHeader_Delete"
			Me.SP_DISABLE = "prc_SalesSalesOrderHeader_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesOrderHeader_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesOrderHeader_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesOrderHeader_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesOrderHeader_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesOrderHeaderSalesReason
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesOrderHeaderSalesReason
    Private _myDataAccess As DaSales_SalesOrderHeaderSalesReason

    Public Property CurrentEntity() As EntSales_SalesOrderHeaderSalesReason
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesOrderHeaderSalesReason)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesOrderHeaderSalesReason, New DaSales_SalesOrderHeaderSalesReason(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesOrderHeaderSalesReason)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesOrderHeaderSalesReason)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.SalesOrderID  = Int32.MinValue
			Me.CurrentEntity.SalesReasonID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.SalesOrderID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SalesReasonID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesOrderHeaderSalesReason 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesOrderHeaderSalesReason

    Public Property CurrentEntity() As EntSales_SalesOrderHeaderSalesReason
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesOrderHeaderSalesReason)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesOrderHeaderSalesReason)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesOrderHeaderSalesReason)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesOrderHeaderSalesReason_Insert"
			Me.SP_DELETE = "prc_SalesSalesOrderHeaderSalesReason_Delete"
			Me.SP_DISABLE = "prc_SalesSalesOrderHeaderSalesReason_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesOrderHeaderSalesReason_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesOrderHeaderSalesReason_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesOrderHeaderSalesReason_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesOrderHeaderSalesReason_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesPerson
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesPerson
    Private _myDataAccess As DaSales_SalesPerson

    Public Property CurrentEntity() As EntSales_SalesPerson
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesPerson)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesPerson, New DaSales_SalesPerson(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesPerson)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesPerson)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.Bonus  =  Decimal.MinValue
			Me.CurrentEntity.CommissionPct  =  Decimal.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SalesLastYear  =  Decimal.MinValue
			Me.CurrentEntity.SalesPersonID  = Int32.MinValue
			Me.CurrentEntity.SalesYTD  =  Decimal.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.Bonus  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.CommissionPct  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.SalesLastYear  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.SalesPersonID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SalesYTD  =  Decimal.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesPerson 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesPerson

    Public Property CurrentEntity() As EntSales_SalesPerson
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesPerson)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesPerson)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesPerson)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesPerson_Insert"
			Me.SP_DELETE = "prc_SalesSalesPerson_Delete"
			Me.SP_DISABLE = "prc_SalesSalesPerson_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesPerson_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesPerson_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesPerson_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesPerson_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesPersonQuotaHistory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesPersonQuotaHistory
    Private _myDataAccess As DaSales_SalesPersonQuotaHistory

    Public Property CurrentEntity() As EntSales_SalesPersonQuotaHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesPersonQuotaHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesPersonQuotaHistory, New DaSales_SalesPersonQuotaHistory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesPersonQuotaHistory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesPersonQuotaHistory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.QuotaDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SalesPersonID  = Int32.MinValue
			Me.CurrentEntity.SalesQuota  =  Decimal.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.QuotaDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.SalesPersonID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SalesQuota  =  Decimal.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesPersonQuotaHistory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesPersonQuotaHistory

    Public Property CurrentEntity() As EntSales_SalesPersonQuotaHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesPersonQuotaHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesPersonQuotaHistory)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesPersonQuotaHistory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesPersonQuotaHistory_Insert"
			Me.SP_DELETE = "prc_SalesSalesPersonQuotaHistory_Delete"
			Me.SP_DISABLE = "prc_SalesSalesPersonQuotaHistory_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesPersonQuotaHistory_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesPersonQuotaHistory_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesPersonQuotaHistory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesPersonQuotaHistory_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesReason
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesReason
    Private _myDataAccess As DaSales_SalesReason

    Public Property CurrentEntity() As EntSales_SalesReason
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesReason)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesReason, New DaSales_SalesReason(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesReason)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesReason)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			Me.CurrentEntity.ReasonType  = Nothing
			Me.CurrentEntity.SalesReasonID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.ReasonType is Nothing OrElse _ 
			Me.CurrentEntity.SalesReasonID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesReason 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesReason

    Public Property CurrentEntity() As EntSales_SalesReason
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesReason)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesReason)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesReason)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesReason_Insert"
			Me.SP_DELETE = "prc_SalesSalesReason_Delete"
			Me.SP_DISABLE = "prc_SalesSalesReason_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesReason_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesReason_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesReason_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesReason_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesTaxRate
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesTaxRate
    Private _myDataAccess As DaSales_SalesTaxRate

    Public Property CurrentEntity() As EntSales_SalesTaxRate
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesTaxRate)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesTaxRate, New DaSales_SalesTaxRate(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesTaxRate)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesTaxRate)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SalesTaxRateID  = Int32.MinValue
			Me.CurrentEntity.StateProvinceID  = Int32.MinValue
			Me.CurrentEntity.TaxRate  =  Decimal.MinValue
			Me.CurrentEntity.TaxType  = Byte.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.SalesTaxRateID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.StateProvinceID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.TaxRate  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.TaxType  = Byte.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesTaxRate 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesTaxRate

    Public Property CurrentEntity() As EntSales_SalesTaxRate
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesTaxRate)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesTaxRate)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesTaxRate)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesTaxRate_Insert"
			Me.SP_DELETE = "prc_SalesSalesTaxRate_Delete"
			Me.SP_DISABLE = "prc_SalesSalesTaxRate_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesTaxRate_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesTaxRate_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesTaxRate_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesTaxRate_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesTerritory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesTerritory
    Private _myDataAccess As DaSales_SalesTerritory

    Public Property CurrentEntity() As EntSales_SalesTerritory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesTerritory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesTerritory, New DaSales_SalesTerritory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesTerritory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesTerritory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CostLastYear  =  Decimal.MinValue
			Me.CurrentEntity.CostYTD  =  Decimal.MinValue
			Me.CurrentEntity.CountryRegionCode  = Nothing
			Me.CurrentEntity.Group  = Nothing
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SalesLastYear  =  Decimal.MinValue
			Me.CurrentEntity.SalesYTD  =  Decimal.MinValue
			Me.CurrentEntity.TerritoryID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CostLastYear  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.CostYTD  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.CountryRegionCode is Nothing OrElse _ 
			Me.CurrentEntity.Group is Nothing OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
			Me.CurrentEntity.SalesLastYear  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.SalesYTD  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.TerritoryID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesTerritory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesTerritory

    Public Property CurrentEntity() As EntSales_SalesTerritory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesTerritory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesTerritory)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesTerritory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesTerritory_Insert"
			Me.SP_DELETE = "prc_SalesSalesTerritory_Delete"
			Me.SP_DISABLE = "prc_SalesSalesTerritory_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesTerritory_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesTerritory_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesTerritory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesTerritory_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SalesTerritoryHistory
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SalesTerritoryHistory
    Private _myDataAccess As DaSales_SalesTerritoryHistory

    Public Property CurrentEntity() As EntSales_SalesTerritoryHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesTerritoryHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesTerritoryHistory, New DaSales_SalesTerritoryHistory(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesTerritoryHistory)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SalesTerritoryHistory)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SalesPersonID  = Int32.MinValue
			Me.CurrentEntity.StartDate  = Date.MinValue
			Me.CurrentEntity.TerritoryID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.SalesPersonID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.StartDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.TerritoryID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SalesTerritoryHistory 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SalesTerritoryHistory

    Public Property CurrentEntity() As EntSales_SalesTerritoryHistory
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SalesTerritoryHistory)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SalesTerritoryHistory)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SalesTerritoryHistory)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSalesTerritoryHistory_Insert"
			Me.SP_DELETE = "prc_SalesSalesTerritoryHistory_Delete"
			Me.SP_DISABLE = "prc_SalesSalesTerritoryHistory_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSalesTerritoryHistory_SelectAll"
			Me.SP_GETONE = "prc_SalesSalesTerritoryHistory_SlectOne"
			Me.SP_UPDATE = "prc_SalesSalesTerritoryHistory_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSalesTerritoryHistory_UpdateByPK"

    End Sub
End Class


Public Class BlSales_ShoppingCartItem
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_ShoppingCartItem
    Private _myDataAccess As DaSales_ShoppingCartItem

    Public Property CurrentEntity() As EntSales_ShoppingCartItem
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_ShoppingCartItem)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_ShoppingCartItem, New DaSales_ShoppingCartItem(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_ShoppingCartItem)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_ShoppingCartItem)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.DateCreated  = Date.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			Me.CurrentEntity.Quantity  = Int32.MinValue
			Me.CurrentEntity.ShoppingCartID  = Nothing
			Me.CurrentEntity.ShoppingCartItemID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.DateCreated = Date.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.Quantity = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ShoppingCartID is Nothing OrElse _ 
			Me.CurrentEntity.ShoppingCartItemID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_ShoppingCartItem 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_ShoppingCartItem

    Public Property CurrentEntity() As EntSales_ShoppingCartItem
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_ShoppingCartItem)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_ShoppingCartItem)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_ShoppingCartItem)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesShoppingCartItem_Insert"
			Me.SP_DELETE = "prc_SalesShoppingCartItem_Delete"
			Me.SP_DISABLE = "prc_SalesShoppingCartItem_UpdateByPK"
			Me.SP_GETALL = "prc_SalesShoppingCartItem_SelectAll"
			Me.SP_GETONE = "prc_SalesShoppingCartItem_SlectOne"
			Me.SP_UPDATE = "prc_SalesShoppingCartItem_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesShoppingCartItem_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SpecialOffer
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SpecialOffer
    Private _myDataAccess As DaSales_SpecialOffer

    Public Property CurrentEntity() As EntSales_SpecialOffer
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SpecialOffer)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SpecialOffer, New DaSales_SpecialOffer(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SpecialOffer)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SpecialOffer)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.Category  = Nothing
			Me.CurrentEntity.Description  = Nothing
			Me.CurrentEntity.DiscountPct  =  Decimal.MinValue
			Me.CurrentEntity.EndDate  = Date.MinValue
			Me.CurrentEntity.MinQty  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SpecialOfferID  = Int32.MinValue
			Me.CurrentEntity.StartDate  = Date.MinValue
			Me.CurrentEntity.Type  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.Category is Nothing OrElse _ 
			Me.CurrentEntity.Description is Nothing OrElse _ 
			Me.CurrentEntity.DiscountPct  =  Decimal.MinValue OrElse _ 
			Me.CurrentEntity.EndDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.MinQty = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.SpecialOfferID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.StartDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Type is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SpecialOffer 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SpecialOffer

    Public Property CurrentEntity() As EntSales_SpecialOffer
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SpecialOffer)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SpecialOffer)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SpecialOffer)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSpecialOffer_Insert"
			Me.SP_DELETE = "prc_SalesSpecialOffer_Delete"
			Me.SP_DISABLE = "prc_SalesSpecialOffer_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSpecialOffer_SelectAll"
			Me.SP_GETONE = "prc_SalesSpecialOffer_SlectOne"
			Me.SP_UPDATE = "prc_SalesSpecialOffer_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSpecialOffer_UpdateByPK"

    End Sub
End Class


Public Class BlSales_SpecialOfferProduct
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_SpecialOfferProduct
    Private _myDataAccess As DaSales_SpecialOfferProduct

    Public Property CurrentEntity() As EntSales_SpecialOfferProduct
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SpecialOfferProduct)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SpecialOfferProduct, New DaSales_SpecialOfferProduct(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SpecialOfferProduct)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_SpecialOfferProduct)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.ProductID  = Int32.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing
			Me.CurrentEntity.SpecialOfferID  = Int32.MinValue

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.ProductID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.SpecialOfferID = Int32.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_SpecialOfferProduct 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_SpecialOfferProduct

    Public Property CurrentEntity() As EntSales_SpecialOfferProduct
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_SpecialOfferProduct)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_SpecialOfferProduct)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_SpecialOfferProduct)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesSpecialOfferProduct_Insert"
			Me.SP_DELETE = "prc_SalesSpecialOfferProduct_Delete"
			Me.SP_DISABLE = "prc_SalesSpecialOfferProduct_UpdateByPK"
			Me.SP_GETALL = "prc_SalesSpecialOfferProduct_SelectAll"
			Me.SP_GETONE = "prc_SalesSpecialOfferProduct_SlectOne"
			Me.SP_UPDATE = "prc_SalesSpecialOfferProduct_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesSpecialOfferProduct_UpdateByPK"

    End Sub
End Class


Public Class BlSales_Store
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_Store
    Private _myDataAccess As DaSales_Store

    Public Property CurrentEntity() As EntSales_Store
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Store)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Store, New DaSales_Store(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Store)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_Store)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.CustomerID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			Me.CurrentEntity.Name  = Nothing
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.CustomerID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
			Me.CurrentEntity.Name is Nothing OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_Store 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_Store

    Public Property CurrentEntity() As EntSales_Store
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_Store)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_Store)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_Store)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesStore_Insert"
			Me.SP_DELETE = "prc_SalesStore_Delete"
			Me.SP_DISABLE = "prc_SalesStore_UpdateByPK"
			Me.SP_GETALL = "prc_SalesStore_SelectAll"
			Me.SP_GETONE = "prc_SalesStore_SlectOne"
			Me.SP_UPDATE = "prc_SalesStore_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesStore_UpdateByPK"

    End Sub
End Class


Public Class BlSales_StoreContact
    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic
    Private _CurrentEntity As EntSales_StoreContact
    Private _myDataAccess As DaSales_StoreContact

    Public Property CurrentEntity() As EntSales_StoreContact
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_StoreContact)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_StoreContact, New DaSales_StoreContact(oUser))
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_StoreContact)
        Me._myDataAccess = CType(MyBase.DataAccess, DaSales_StoreContact)
        Me._myDataAccess.CurrentEntity = Me.CurrentEntity
					Me.CurrentEntity.ContactID  = Int32.MinValue
			Me.CurrentEntity.ContactTypeID  = Int32.MinValue
			Me.CurrentEntity.CustomerID  = Int32.MinValue
			Me.CurrentEntity.ModifiedDate  = Date.MinValue
			'Me.CurrentEntity.Rowguid  = Nothing

    End Sub

    Public Overrides Function ClassValidation(ByRef strError As String, _ 
											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean 
		If 			Me.CurrentEntity.ContactID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ContactTypeID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.CustomerID = Int32.MinValue OrElse _ 
			Me.CurrentEntity.ModifiedDate = Date.MinValue OrElse _ 
					 False Then
						strError = "Error de validación general"
						Return False
					Else
						Return True
					End If

    End Function 
End Class
Public Class DaSales_StoreContact 
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess 
    Private _CurrentEntity As EntSales_StoreContact

    Public Property CurrentEntity() As EntSales_StoreContact
        Get
            Return _CurrentEntity
        End Get
        Set(ByVal value As EntSales_StoreContact)
            _CurrentEntity = value
        End Set
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser, New EntSales_StoreContact)
        Me._CurrentEntity = CType(MyBase.Entity, EntSales_StoreContact)
 
    End Sub

    Protected Overrides Sub DisableEntity()

    End Sub

    Protected Overrides Sub SetStoredProcedures()
 			Me.SP_ADD = "prc_SalesStoreContact_Insert"
			Me.SP_DELETE = "prc_SalesStoreContact_Delete"
			Me.SP_DISABLE = "prc_SalesStoreContact_UpdateByPK"
			Me.SP_GETALL = "prc_SalesStoreContact_SelectAll"
			Me.SP_GETONE = "prc_SalesStoreContact_SlectOne"
			Me.SP_UPDATE = "prc_SalesStoreContact_UpdateByPK"
			Me.SP_UPDATE_BY_PK = "prc_SalesStoreContact_UpdateByPK"

    End Sub
End Class


