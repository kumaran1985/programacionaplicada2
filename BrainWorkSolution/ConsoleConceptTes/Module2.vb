''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SystemInformationID", _
                                                PrimaryKeyFieldName:="SystemInformationID", RootContainerName:="[dbo].[AWBuildVersion]", EnabledPropertyName:="SystemInformationID", PrimaryKeyPropertyName:="SystemInformationID")> _
Public Class EntAWBuildVersion

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Version As String
    Private _ModifiedDate As DateTime
    Private _SystemInformationID As Byte
    Private _VersionDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Version number of the database in 9.yy.mm.dd.00 format.", FieldName:="Database Version", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[AWBuildVersion]", Order:=2, ParameterName:="Database Version", Size:=25, SourceColumn:="Database Version", TypeName:="String", MaxValue:=25, EntityClassContainer:="Ent[dbo].[AWBuildVersion]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Version() As String
        Get
            Return _Version
        End Get
        Set(ByVal value As String)
            _Version = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[AWBuildVersion]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[dbo].[AWBuildVersion]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Primary key for AWBuildVersion records. - Clustered index created by a primary key constraint.", FieldName:="SystemInformationID", ForeingCRUD:="ABM_AWBuildVersion", ForeingTable:="AWBuildVersion", MainTable:="[dbo].[AWBuildVersion]", Order:=1, ParameterName:="SystemInformationID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="SystemInformationID", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="EntAWBuildVersion", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SystemInformationID() As Byte
        Get
            Return _SystemInformationID
        End Get
        Set(ByVal value As Byte)
            _SystemInformationID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date and time the record was last updated.", FieldName:="VersionDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[AWBuildVersion]", Order:=3, ParameterName:="VersionDate", SourceColumn:="VersionDate", TypeName:="DateTime", EntityClassContainer:="Ent[dbo].[AWBuildVersion]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property VersionDate() As DateTime
        Get
            Return _VersionDate
        End Get
        Set(ByVal value As DateTime)
            _VersionDate = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _Version = Nothing
        _ModifiedDate = Now
        _SystemInformationID = Nothing
        _VersionDate = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="DatabaseLogID", PrimaryKeyFieldName:="DatabaseLogID", RootContainerName:="[dbo].[DatabaseLog]", EnabledPropertyName:="DatabaseLogID", PrimaryKeyPropertyName:="DatabaseLogID")> _
Public Class EntDatabaseLog

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _DatabaseLogID As Int32
    Private _DatabaseUser As String
    Private [_Event] As String
    Private [_Object] As String
    Private _PostTime As DateTime
    Private _Schema As String
    Private _TSQL As String
    Private _XmlEvent As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for DatabaseLog records.", FieldName:="DatabaseLogID", ForeingCRUD:="ABM_DatabaseLog", ForeingTable:="DatabaseLog", MainTable:="[dbo].[DatabaseLog]", Order:=1, ParameterName:="DatabaseLogID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="DatabaseLogID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntDatabaseLog", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property DatabaseLogID() As Int32
        Get
            Return _DatabaseLogID
        End Get
        Set(ByVal value As Int32)
            _DatabaseLogID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The user who implemented the DDL change.", FieldName:="DatabaseUser", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[DatabaseLog]", Order:=3, ParameterName:="DatabaseUser", Size:=128, SourceColumn:="DatabaseUser", TypeName:="String", MaxValue:=128, EntityClassContainer:="Ent[dbo].[DatabaseLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DatabaseUser() As String
        Get
            Return _DatabaseUser
        End Get
        Set(ByVal value As String)
            _DatabaseUser = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The type of DDL statement that was executed.", FieldName:="Event", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[DatabaseLog]", Order:=4, ParameterName:="Event", Size:=128, SourceColumn:="Event", TypeName:="String", MaxValue:=128, EntityClassContainer:="Ent[dbo].[DatabaseLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property [Event]() As String
        Get
            Return [_Event]
        End Get
        Set(ByVal value As String)
            [_Event] = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The object that was changed by the DDL statment.", FieldName:="Object", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[DatabaseLog]", Order:=6, ParameterName:="Object", SetNullable:=True, Size:=128, SourceColumn:="Object", TypeName:="String", MaxValue:=128, EntityClassContainer:="Ent[dbo].[DatabaseLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property [Object]() As String
        Get
            Return [_Object]
        End Get
        Set(ByVal value As String)
            [_Object] = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="The date and time the DDL change occurred. - Nonclustered index created by a primary key constraint.", FieldName:="PostTime", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[DatabaseLog]", Order:=2, ParameterName:="PostTime", SourceColumn:="PostTime", TypeName:="DateTime", EntityClassContainer:="Ent[dbo].[DatabaseLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PostTime() As DateTime
        Get
            Return _PostTime
        End Get
        Set(ByVal value As DateTime)
            _PostTime = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The schema to which the changed object belongs.", FieldName:="Schema", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[DatabaseLog]", Order:=5, ParameterName:="Schema", SetNullable:=True, Size:=128, SourceColumn:="Schema", TypeName:="String", MaxValue:=128, EntityClassContainer:="Ent[dbo].[DatabaseLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Schema() As String
        Get
            Return _Schema
        End Get
        Set(ByVal value As String)
            _Schema = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The exact Transact-SQL statement that was executed.", FieldName:="TSQL", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[DatabaseLog]", Order:=7, ParameterName:="TSQL", Size:=-1, SourceColumn:="TSQL", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[dbo].[DatabaseLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TSQL() As String
        Get
            Return _TSQL
        End Get
        Set(ByVal value As String)
            _TSQL = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The raw XML data generated by database trigger.", FieldName:="XmlEvent", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[DatabaseLog]", Order:=8, ParameterName:="XmlEvent", Size:=-1, SourceColumn:="XmlEvent", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[dbo].[DatabaseLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property XmlEvent() As String
        Get
            Return _XmlEvent
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
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ErrorLogID", PrimaryKeyFieldName:="ErrorLogID", RootContainerName:="[dbo].[ErrorLog]", EnabledPropertyName:="ErrorLogID", PrimaryKeyPropertyName:="ErrorLogID")> _
Public Class EntErrorLog

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ErrorLine As Int32
    Private _ErrorLogID As Int32
    Private _ErrorMessage As String
    Private _ErrorNumber As Int32
    Private _ErrorProcedure As String
    Private _ErrorSeverity As Int32
    Private _ErrorState As Int32
    Private _ErrorTime As DateTime
    Private _UserName As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="The line number at which the error occurred.", FieldName:="ErrorLine", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=8, ParameterName:="ErrorLine", SetNullable:=True, Size:=10, SourceColumn:="ErrorLine", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ErrorLine() As Int32
        Get
            Return _ErrorLine
        End Get
        Set(ByVal value As Int32)
            _ErrorLine = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for ErrorLog records.", FieldName:="ErrorLogID", ForeingCRUD:="ABM_ErrorLog", ForeingTable:="ErrorLog", MainTable:="[dbo].[ErrorLog]", Order:=1, ParameterName:="ErrorLogID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ErrorLogID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntErrorLog", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ErrorLogID() As Int32
        Get
            Return _ErrorLogID
        End Get
        Set(ByVal value As Int32)
            _ErrorLogID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The message text of the error that occurred.", FieldName:="ErrorMessage", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=9, ParameterName:="ErrorMessage", Size:=4000, SourceColumn:="ErrorMessage", TypeName:="String", MaxValue:=4000, EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ErrorMessage() As String
        Get
            Return _ErrorMessage
        End Get
        Set(ByVal value As String)
            _ErrorMessage = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="The error number of the error that occurred.", FieldName:="ErrorNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=4, ParameterName:="ErrorNumber", Size:=10, SourceColumn:="ErrorNumber", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ErrorNumber() As Int32
        Get
            Return _ErrorNumber
        End Get
        Set(ByVal value As Int32)
            _ErrorNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The name of the stored procedure or trigger where the error occurred.", FieldName:="ErrorProcedure", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=7, ParameterName:="ErrorProcedure", SetNullable:=True, Size:=126, SourceColumn:="ErrorProcedure", TypeName:="String", MaxValue:=126, EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ErrorProcedure() As String
        Get
            Return _ErrorProcedure
        End Get
        Set(ByVal value As String)
            _ErrorProcedure = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="The severity of the error that occurred.", FieldName:="ErrorSeverity", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=5, ParameterName:="ErrorSeverity", SetNullable:=True, Size:=10, SourceColumn:="ErrorSeverity", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ErrorSeverity() As Int32
        Get
            Return _ErrorSeverity
        End Get
        Set(ByVal value As Int32)
            _ErrorSeverity = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="The state number of the error that occurred.", FieldName:="ErrorState", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=6, ParameterName:="ErrorState", SetNullable:=True, Size:=10, SourceColumn:="ErrorState", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ErrorState() As Int32
        Get
            Return _ErrorState
        End Get
        Set(ByVal value As Int32)
            _ErrorState = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="The date and time at which the error occurred.", FieldName:="ErrorTime", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=2, ParameterName:="ErrorTime", SourceColumn:="ErrorTime", TypeName:="DateTime", EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ErrorTime() As DateTime
        Get
            Return _ErrorTime
        End Get
        Set(ByVal value As DateTime)
            _ErrorTime = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The user who executed the batch in which the error occurred.", FieldName:="UserName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[ErrorLog]", Order:=3, ParameterName:="UserName", Size:=128, SourceColumn:="UserName", TypeName:="String", MaxValue:=128, EntityClassContainer:="Ent[dbo].[ErrorLog]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property UserName() As String
        Get
            Return _UserName
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
        _ErrorTime = Now
        _UserName = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="aaa", PrimaryKeyFieldName:="aaa", RootContainerName:="[dbo].[Table_1]", EnabledPropertyName:="Aaa")> _
Public Class EntTable_1

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Aaa As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="aaa", FieldName:="aaa", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[dbo].[Table_1]", Order:=1, ParameterName:="aaa", SetNullable:=True, Size:=10, SourceColumn:="aaa", TypeName:="String", MaxValue:=10, EntityClassContainer:="Ent[dbo].[Table_1]", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property Aaa() As String
        Get
            Return _Aaa
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
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="DepartmentID", PrimaryKeyFieldName:="DepartmentID", RootContainerName:="[HumanResources].[Department]", EnabledPropertyName:="DepartmentID", PrimaryKeyPropertyName:="DepartmentID")> _
Public Class EntHumanResources_Department

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _DepartmentID As Int16
    Private _GroupName As String
    Private _ModifiedDate As DateTime
    Private _Name As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Department records.", FieldName:="DepartmentID", ForeingCRUD:="ABM_Department", ForeingTable:="Department", MainTable:="[HumanResources].[Department]", Order:=1, ParameterName:="DepartmentID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=5, SourceColumn:="DepartmentID", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntDepartment", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property DepartmentID() As Int16
        Get
            Return _DepartmentID
        End Get
        Set(ByVal value As Int16)
            _DepartmentID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Name of the group to which the department belongs.", FieldName:="GroupName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Department]", Order:=3, ParameterName:="GroupName", Size:=50, SourceColumn:="GroupName", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[HumanResources].[Department]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property GroupName() As String
        Get
            Return _GroupName
        End Get
        Set(ByVal value As String)
            _GroupName = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Department]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[Department]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Name of the department.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Department]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[HumanResources].[Department]", IsDescription:=False, IsDefaultOrderBy:=False)> _
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
        _DepartmentID = Nothing
        _GroupName = Nothing
        _ModifiedDate = Now
        _Name = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="EmployeeID", PrimaryKeyFieldName:="EmployeeID", RootContainerName:="[HumanResources].[Employee]", EnabledPropertyName:="EmployeeID", PrimaryKeyPropertyName:="EmployeeID")> _
Public Class EntHumanResources_Employee

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _BirthDate As DateTime
    Private _ContactID As Int32
    Private _CurrentFlag As Boolean
    Private _EmployeeID As Int32
    Private _Gender As String
    Private _HireDate As DateTime
    Private _LoginID As String
    Private _ManagerID As Int32
    Private _MaritalStatus As String
    Private _ModifiedDate As DateTime
    Private _NationalIDNumber As String
    Private _Rowguid As Guid
    Private _SalariedFlag As Boolean
    Private _SickLeaveHours As Int16
    Private _Title As String
    Private _VacationHours As Int16
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date of birth.", FieldName:="BirthDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=7, ParameterName:="BirthDate", SourceColumn:="BirthDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property BirthDate() As DateTime
        Get
            Return _BirthDate
        End Get
        Set(ByVal value As DateTime)
            _BirthDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. - Identifies the employee in the Contact table. Foreign key to Contact.ContactID.", FieldName:="ContactID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Contact", ForeingTable:="Contact", MainTable:="[HumanResources].[Employee]", Order:=3, ParameterName:="ContactID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContact", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ContactID() As Int32
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Int32)
            _ContactID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="0 = Inactive, 1 = Active", FieldName:="CurrentFlag", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=14, ParameterName:="CurrentFlag", SourceColumn:="CurrentFlag", TypeName:="Boolean", EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CurrentFlag() As Boolean
        Get
            Return _CurrentFlag
        End Get
        Set(ByVal value As Boolean)
            _CurrentFlag = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Employee records.", FieldName:="EmployeeID", ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[HumanResources].[Employee]", Order:=1, ParameterName:="EmployeeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="EmployeeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property EmployeeID() As Int32
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Int32)
            _EmployeeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="M = Male, F = Female", FieldName:="Gender", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=9, ParameterName:="Gender", Size:=1, SourceColumn:="Gender", TypeName:="String", MaxValue:=1, EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Employee hired on this date.", FieldName:="HireDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=10, ParameterName:="HireDate", SourceColumn:="HireDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property HireDate() As DateTime
        Get
            Return _HireDate
        End Get
        Set(ByVal value As DateTime)
            _HireDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Network login.", FieldName:="LoginID", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=4, ParameterName:="LoginID", Size:=256, SourceColumn:="LoginID", TypeName:="String", MaxValue:=256, EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LoginID() As String
        Get
            Return _LoginID
        End Get
        Set(ByVal value As String)
            _LoginID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Manager to whom the employee is assigned. Foreign Key to Employee.M - Nonclustered index.", FieldName:="ManagerID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[HumanResources].[Employee]", Order:=5, ParameterName:="ManagerID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="ManagerID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, ForeingFieldName:="ManagerID", IsDefaultOrderBy:=False)> _
     Public Property ManagerID() As Int32
        Get
            Return _ManagerID
        End Get
        Set(ByVal value As Int32)
            _ManagerID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="M = Married, S = Single", FieldName:="MaritalStatus", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=8, ParameterName:="MaritalStatus", Size:=1, SourceColumn:="MaritalStatus", TypeName:="String", MaxValue:=1, EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property MaritalStatus() As String
        Get
            Return _MaritalStatus
        End Get
        Set(ByVal value As String)
            _MaritalStatus = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=16, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Unique national identification number such as a social security number.", FieldName:="NationalIDNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=2, ParameterName:="NationalIDNumber", Size:=15, SourceColumn:="NationalIDNumber", TypeName:="String", MaxValue:=15, EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property NationalIDNumber() As String
        Get
            Return _NationalIDNumber
        End Get
        Set(ByVal value As String)
            _NationalIDNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=15, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.", FieldName:="SalariedFlag", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=11, ParameterName:="SalariedFlag", SourceColumn:="SalariedFlag", TypeName:="Boolean", EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalariedFlag() As Boolean
        Get
            Return _SalariedFlag
        End Get
        Set(ByVal value As Boolean)
            _SalariedFlag = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, DefaultValue:="((0))", FieldDescription:="Number of available sick leave hours.", FieldName:="SickLeaveHours", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=13, ParameterName:="SickLeaveHours", Size:=5, SourceColumn:="SickLeaveHours", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SickLeaveHours() As Int16
        Get
            Return _SickLeaveHours
        End Get
        Set(ByVal value As Int16)
            _SickLeaveHours = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Work title such as Buyer or Sales Representative.", FieldName:="Title", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=6, ParameterName:="Title", Size:=50, SourceColumn:="Title", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, DefaultValue:="((0))", FieldDescription:="Number of available vacation hours.", FieldName:="VacationHours", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Employee]", Order:=12, ParameterName:="VacationHours", Size:=5, SourceColumn:="VacationHours", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[HumanResources].[Employee]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property VacationHours() As Int16
        Get
            Return _VacationHours
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
        _CurrentFlag = 1
        _EmployeeID = Nothing
        _Gender = Nothing
        _HireDate = Nothing
        _LoginID = Nothing
        _ManagerID = Nothing
        _MaritalStatus = Nothing
        _ModifiedDate = Date.UtcNow
        _NationalIDNumber = Nothing
        _Rowguid = newid
        _SalariedFlag = 1
        _SickLeaveHours = 0
        _Title = Nothing
        _VacationHours = 0
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="EmployeeID", PrimaryKeyFieldName:="EmployeeID", RootContainerName:="[HumanResources].[EmployeeAddress]", EnabledPropertyName:="EmployeeID", PrimaryKeyPropertyName:="EmployeeID")> _
Public Class EntHumanResources_EmployeeAddress

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AddressID As Int32
    Private _EmployeeID As Int32
    Private _ModifiedDate As DateTime
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Primary key. Foreign key to Address.AddressID.", FieldName:="AddressID", ForeingCRUD:="ABM_Address", ForeingTable:="Address", MainTable:="[HumanResources].[EmployeeAddress]", Order:=2, ParameterName:="AddressID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="AddressID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddress", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property AddressID() As Int32
        Get
            Return _AddressID
        End Get
        Set(ByVal value As Int32)
            _AddressID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to Employee.EmployeeID. - Clustered index created by a primary key constraint.", FieldName:="EmployeeID", ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[HumanResources].[EmployeeAddress]", Order:=1, ParameterName:="EmployeeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="EmployeeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EmployeeID() As Int32
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Int32)
            _EmployeeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[EmployeeAddress]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[EmployeeAddress]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[EmployeeAddress]", Order:=3, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[HumanResources].[EmployeeAddress]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
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
        _ModifiedDate = Now
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StartDate", PrimaryKeyFieldName:="StartDate", RootContainerName:="[HumanResources].[EmployeeDepartmentHistory]", EnabledPropertyName:="StartDate", PrimaryKeyPropertyName:="StartDate")> _
Public Class EntHumanResources_EmployeeDepartmentHistory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _DepartmentID As Int16
    Private _EmployeeID As Int32
    Private _EndDate As DateTime
    Private _ModifiedDate As DateTime
    Private _ShiftID As Byte
    Private _StartDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Nonclustered index. - Department in which the employee worked including currently. Foreign key to Department.DepartmentID.", FieldName:="DepartmentID", ForeingCRUD:="ABM_Department", ForeingTable:="Department", MainTable:="[HumanResources].[EmployeeDepartmentHistory]", Order:=2, ParameterName:="DepartmentID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=5, SourceColumn:="DepartmentID", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntDepartment", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property DepartmentID() As Int16
        Get
            Return _DepartmentID
        End Get
        Set(ByVal value As Int16)
            _DepartmentID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Employee identification number. Foreign key to Employee.EmployeeID.", FieldName:="EmployeeID", ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[HumanResources].[EmployeeDepartmentHistory]", Order:=1, ParameterName:="EmployeeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="EmployeeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EmployeeID() As Int32
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Int32)
            _EmployeeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the employee left the department. NULL = Current department.", FieldName:="EndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[EmployeeDepartmentHistory]", Order:=5, ParameterName:="EndDate", SetNullable:=True, SourceColumn:="EndDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[EmployeeDepartmentHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndDate() As DateTime
        Get
            Return _EndDate
        End Get
        Set(ByVal value As DateTime)
            _EndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[EmployeeDepartmentHistory]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[EmployeeDepartmentHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID. - Nonclustered index.", FieldName:="ShiftID", ForeingCRUD:="ABM_Shift", ForeingTable:="Shift", MainTable:="[HumanResources].[EmployeeDepartmentHistory]", Order:=3, ParameterName:="ShiftID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="ShiftID", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="EntShift", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShiftID() As Byte
        Get
            Return _ShiftID
        End Get
        Set(ByVal value As Byte)
            _ShiftID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the employee started work in the department.", FieldName:="StartDate", ForeingCRUD:="ABM_ProductCostHistory", ForeingTable:="ProductCostHistory", MainTable:="[HumanResources].[EmployeeDepartmentHistory]", Order:=4, ParameterName:="StartDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="StartDate", TypeName:="DateTime", EntityClassContainer:="EntProductCostHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartDate() As DateTime
        Get
            Return _StartDate
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
        _ModifiedDate = Now
        _ShiftID = Nothing
        _StartDate = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="RateChangeDate", PrimaryKeyFieldName:="RateChangeDate", RootContainerName:="[HumanResources].[EmployeePayHistory]", EnabledPropertyName:="RateChangeDate", PrimaryKeyPropertyName:="RateChangeDate")> _
Public Class EntHumanResources_EmployeePayHistory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _EmployeeID As Int32
    Private _ModifiedDate As DateTime
    Private _PayFrequency As Byte
    Private _Rate As Decimal
    Private _RateChangeDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Employee identification number. Foreign key to Employee.EmployeeID.", FieldName:="EmployeeID", ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[HumanResources].[EmployeePayHistory]", Order:=1, ParameterName:="EmployeeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="EmployeeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property EmployeeID() As Int32
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Int32)
            _EmployeeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[EmployeePayHistory]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[EmployeePayHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="1 = Salary received monthly, 2 = Salary received biweekly", FieldName:="PayFrequency", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[EmployeePayHistory]", Order:=4, ParameterName:="PayFrequency", Size:=3, SourceColumn:="PayFrequency", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[HumanResources].[EmployeePayHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PayFrequency() As Byte
        Get
            Return _PayFrequency
        End Get
        Set(ByVal value As Byte)
            _PayFrequency = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Salary hourly rate.", FieldName:="Rate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[EmployeePayHistory]", Order:=3, ParameterName:="Rate", Scale:=4, Size:=19, SourceColumn:="Rate", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[HumanResources].[EmployeePayHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rate() As Decimal
        Get
            Return _Rate
        End Get
        Set(ByVal value As Decimal)
            _Rate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the change in pay is effective", FieldName:="RateChangeDate", ForeingCRUD:="ABM_EmployeePayHistory", ForeingTable:="EmployeePayHistory", MainTable:="[HumanResources].[EmployeePayHistory]", Order:=2, ParameterName:="RateChangeDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="RateChangeDate", TypeName:="DateTime", EntityClassContainer:="EntEmployeePayHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property RateChangeDate() As DateTime
        Get
            Return _RateChangeDate
        End Get
        Set(ByVal value As DateTime)
            _RateChangeDate = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _EmployeeID = Nothing
        _ModifiedDate = Now
        _PayFrequency = Nothing
        _Rate = Nothing
        _RateChangeDate = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="JobCandidateID", PrimaryKeyFieldName:="JobCandidateID", RootContainerName:="[HumanResources].[JobCandidate]", EnabledPropertyName:="JobCandidateID", PrimaryKeyPropertyName:="JobCandidateID")> _
Public Class EntHumanResources_JobCandidate

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _EmployeeID As Int32
    Private _JobCandidateID As Int32
    Private _ModifiedDate As DateTime
    Private [_Resume] As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Employee identification number if applicant was hired. Foreign key to Employee.EmployeeID.", FieldName:="EmployeeID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[HumanResources].[JobCandidate]", Order:=2, ParameterName:="EmployeeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="EmployeeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EmployeeID() As Int32
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Int32)
            _EmployeeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for JobCandidate records. - Clustered index created by a primary key constraint.", FieldName:="JobCandidateID", ForeingCRUD:="ABM_JobCandidate", ForeingTable:="JobCandidate", MainTable:="[HumanResources].[JobCandidate]", Order:=1, ParameterName:="JobCandidateID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="JobCandidateID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntJobCandidate", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property JobCandidateID() As Int32
        Get
            Return _JobCandidateID
        End Get
        Set(ByVal value As Int32)
            _JobCandidateID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[JobCandidate]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[JobCandidate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Résumé in XML format.", FieldName:="Resume", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[JobCandidate]", Order:=3, ParameterName:="Resume", SetNullable:=True, Size:=-1, SourceColumn:="Resume", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[HumanResources].[JobCandidate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property [Resume]() As String
        Get
            Return [_Resume]
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
        _ModifiedDate = Now
        [_Resume] = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ShiftID", PrimaryKeyFieldName:="ShiftID", RootContainerName:="[HumanResources].[Shift]", EnabledPropertyName:="ShiftID", PrimaryKeyPropertyName:="ShiftID")> _
Public Class EntHumanResources_Shift

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _EndTime As DateTime
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _ShiftID As Byte
    Private _StartTime As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Shift end time.", FieldName:="EndTime", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Shift]", Order:=4, ParameterName:="EndTime", SourceColumn:="EndTime", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[Shift]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndTime() As DateTime
        Get
            Return _EndTime
        End Get
        Set(ByVal value As DateTime)
            _EndTime = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Shift]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[Shift]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Shift description. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Shift]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[HumanResources].[Shift]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Shift records.", FieldName:="ShiftID", ForeingCRUD:="ABM_Shift", ForeingTable:="Shift", MainTable:="[HumanResources].[Shift]", Order:=1, ParameterName:="ShiftID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="ShiftID", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="EntShift", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ShiftID() As Byte
        Get
            Return _ShiftID
        End Get
        Set(ByVal value As Byte)
            _ShiftID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Shift start time. - Unique nonclustered index.", FieldName:="StartTime", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[HumanResources].[Shift]", Order:=3, ParameterName:="StartTime", SourceColumn:="StartTime", TypeName:="DateTime", EntityClassContainer:="Ent[HumanResources].[Shift]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartTime() As DateTime
        Get
            Return _StartTime
        End Get
        Set(ByVal value As DateTime)
            _StartTime = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _EndTime = Nothing
        _ModifiedDate = Now
        _Name = Nothing
        _ShiftID = Nothing
        _StartTime = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="AddressID", PrimaryKeyFieldName:="AddressID", RootContainerName:="[Person].[Address]", EnabledPropertyName:="AddressID", PrimaryKeyPropertyName:="AddressID")> _
Public Class EntPerson_Address

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AddressID As Int32
    Private _AddressLine1 As String
    Private _AddressLine2 As String
    Private _City As String
    Private _ModifiedDate As DateTime
    Private _PostalCode As String
    Private _Rowguid As Guid
    Private _StateProvinceID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Address records.", FieldName:="AddressID", ForeingCRUD:="ABM_Address", ForeingTable:="Address", MainTable:="[Person].[Address]", Order:=1, ParameterName:="AddressID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="AddressID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddress", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property AddressID() As Int32
        Get
            Return _AddressID
        End Get
        Set(ByVal value As Int32)
            _AddressID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="First street address line. - Unique nonclustered index. Used to support replication samples.", FieldName:="AddressLine1", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Address]", Order:=2, ParameterName:="AddressLine1", Size:=60, SourceColumn:="AddressLine1", TypeName:="String", MaxValue:=60, EntityClassContainer:="Ent[Person].[Address]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AddressLine1() As String
        Get
            Return _AddressLine1
        End Get
        Set(ByVal value As String)
            _AddressLine1 = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Nonclustered index. - Second street address line.", FieldName:="AddressLine2", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Address]", Order:=3, ParameterName:="AddressLine2", SetNullable:=True, Size:=60, SourceColumn:="AddressLine2", TypeName:="String", MaxValue:=60, EntityClassContainer:="Ent[Person].[Address]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AddressLine2() As String
        Get
            Return _AddressLine2
        End Get
        Set(ByVal value As String)
            _AddressLine2 = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Name of the city. - Nonclustered index.", FieldName:="City", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Address]", Order:=4, ParameterName:="City", Size:=30, SourceColumn:="City", TypeName:="String", MaxValue:=30, EntityClassContainer:="Ent[Person].[Address]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Address]", Order:=8, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Person].[Address]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Postal code for the street address.", FieldName:="PostalCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Address]", Order:=6, ParameterName:="PostalCode", Size:=15, SourceColumn:="PostalCode", TypeName:="String", MaxValue:=15, EntityClassContainer:="Ent[Person].[Address]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PostalCode() As String
        Get
            Return _PostalCode
        End Get
        Set(ByVal value As String)
            _PostalCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Address]", Order:=7, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Person].[Address]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique identification number for the state or province. Foreign key to StateProvince table.", FieldName:="StateProvinceID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_StateProvince", ForeingTable:="StateProvince", MainTable:="[Person].[Address]", Order:=5, ParameterName:="StateProvinceID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="StateProvinceID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStateProvince", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StateProvinceID() As Int32
        Get
            Return _StateProvinceID
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
        _ModifiedDate = Now
        _PostalCode = Nothing
        _Rowguid = newid
        _StateProvinceID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="AddressTypeID", PrimaryKeyFieldName:="AddressTypeID", RootContainerName:="[Person].[AddressType]", EnabledPropertyName:="AddressTypeID", PrimaryKeyPropertyName:="AddressTypeID")> _
Public Class EntPerson_AddressType

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AddressTypeID As Int32
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for AddressType records.", FieldName:="AddressTypeID", ForeingCRUD:="ABM_AddressType", ForeingTable:="AddressType", MainTable:="[Person].[AddressType]", Order:=1, ParameterName:="AddressTypeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="AddressTypeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddressType", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property AddressTypeID() As Int32
        Get
            Return _AddressTypeID
        End Get
        Set(ByVal value As Int32)
            _AddressTypeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[AddressType]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Person].[AddressType]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Address type description. For example, Billing, Home, or Shipping. - Unique nonclustered index. Used to support replication samples.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[AddressType]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[AddressType]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="Unique nonclustered index. - ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[AddressType]", Order:=3, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Person].[AddressType]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _AddressTypeID = Nothing
        _ModifiedDate = Now
        _Name = Nothing
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ContactID", PrimaryKeyFieldName:="ContactID", RootContainerName:="[Person].[Contact]", EnabledPropertyName:="ContactID", PrimaryKeyPropertyName:="ContactID")> _
Public Class EntPerson_Contact

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AdditionalContactInfo As String
    Private _ContactID As Int32
    Private _EmailAddress As String
    Private _EmailPromotion As Int32
    Private _FirstName As String
    Private _LastName As String
    Private _MiddleName As String
    Private _ModifiedDate As DateTime
    Private _NameStyle As Boolean
    Private _PasswordHash As String
    Private _PasswordSalt As String
    Private _Phone As String
    Private _Rowguid As Guid
    Private _Suffix As String
    Private _Title As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Additional contact information about the person stored in xml format. ", FieldName:="AdditionalContactInfo", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=13, ParameterName:="AdditionalContactInfo", SetNullable:=True, Size:=-1, SourceColumn:="AdditionalContactInfo", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AdditionalContactInfo() As String
        Get
            Return _AdditionalContactInfo
        End Get
        Set(ByVal value As String)
            _AdditionalContactInfo = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for Contact records. - Clustered index created by a primary key constraint.", FieldName:="ContactID", ForeingCRUD:="ABM_Contact", ForeingTable:="Contact", MainTable:="[Person].[Contact]", Order:=1, ParameterName:="ContactID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContact", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ContactID() As Int32
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Int32)
            _ContactID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="E-mail address for the person.", FieldName:="EmailAddress", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=8, ParameterName:="EmailAddress", SetNullable:=True, Size:=50, SourceColumn:="EmailAddress", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EmailAddress() As String
        Get
            Return _EmailAddress
        End Get
        Set(ByVal value As String)
            _EmailAddress = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, DefaultValue:="((0))", FieldDescription:="0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners. ", FieldName:="EmailPromotion", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=9, ParameterName:="EmailPromotion", Size:=10, SourceColumn:="EmailPromotion", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EmailPromotion() As Int32
        Get
            Return _EmailPromotion
        End Get
        Set(ByVal value As Int32)
            _EmailPromotion = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="First name of the person.", FieldName:="FirstName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=4, ParameterName:="FirstName", Size:=50, SourceColumn:="FirstName", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Last name of the person.", FieldName:="LastName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=6, ParameterName:="LastName", Size:=50, SourceColumn:="LastName", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Middle name or middle initial of the person.", FieldName:="MiddleName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=5, ParameterName:="MiddleName", SetNullable:=True, Size:=50, SourceColumn:="MiddleName", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property MiddleName() As String
        Get
            Return _MiddleName
        End Get
        Set(ByVal value As String)
            _MiddleName = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=15, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((0))", FieldDescription:="Unique nonclustered index. Used to support replication samples. - 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.", FieldName:="NameStyle", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=2, ParameterName:="NameStyle", SourceColumn:="NameStyle", TypeName:="Boolean", EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property NameStyle() As Boolean
        Get
            Return _NameStyle
        End Get
        Set(ByVal value As Boolean)
            _NameStyle = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Password for the e-mail account.", FieldName:="PasswordHash", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=11, ParameterName:="PasswordHash", Size:=128, SourceColumn:="PasswordHash", TypeName:="String", MaxValue:=128, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PasswordHash() As String
        Get
            Return _PasswordHash
        End Get
        Set(ByVal value As String)
            _PasswordHash = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Random value concatenated with the password string before the password is hashed.", FieldName:="PasswordSalt", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=12, ParameterName:="PasswordSalt", Size:=10, SourceColumn:="PasswordSalt", TypeName:="String", MaxValue:=10, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PasswordSalt() As String
        Get
            Return _PasswordSalt
        End Get
        Set(ByVal value As String)
            _PasswordSalt = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Phone number associated with the person.", FieldName:="Phone", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=10, ParameterName:="Phone", SetNullable:=True, Size:=25, SourceColumn:="Phone", TypeName:="String", MaxValue:=25, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=14, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Surname suffix. For example, Sr. or Jr.", FieldName:="Suffix", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=7, ParameterName:="Suffix", SetNullable:=True, Size:=10, SourceColumn:="Suffix", TypeName:="String", MaxValue:=10, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Suffix() As String
        Get
            Return _Suffix
        End Get
        Set(ByVal value As String)
            _Suffix = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Nonclustered index. - A courtesy title. For example, Mr. or Ms.", FieldName:="Title", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[Contact]", Order:=3, ParameterName:="Title", SetNullable:=True, Size:=8, SourceColumn:="Title", TypeName:="String", MaxValue:=8, EntityClassContainer:="Ent[Person].[Contact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Title() As String
        Get
            Return _Title
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
        _EmailPromotion = 0
        _FirstName = Nothing
        _LastName = Nothing
        _MiddleName = Nothing
        _ModifiedDate = Now
        _NameStyle = 0
        _PasswordHash = Nothing
        _PasswordSalt = Nothing
        _Phone = Nothing
        _Rowguid = newid
        _Suffix = Nothing
        _Title = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ContactTypeID", PrimaryKeyFieldName:="ContactTypeID", RootContainerName:="[Person].[ContactType]", EnabledPropertyName:="ContactTypeID", PrimaryKeyPropertyName:="ContactTypeID")> _
Public Class EntPerson_ContactType

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ContactTypeID As Int32
    Private _ModifiedDate As DateTime
    Private _Name As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for ContactType records.", FieldName:="ContactTypeID", ForeingCRUD:="ABM_ContactType", ForeingTable:="ContactType", MainTable:="[Person].[ContactType]", Order:=1, ParameterName:="ContactTypeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactTypeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContactType", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ContactTypeID() As Int32
        Get
            Return _ContactTypeID
        End Get
        Set(ByVal value As Int32)
            _ContactTypeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[ContactType]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Person].[ContactType]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Contact type description. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[ContactType]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[ContactType]", IsDescription:=False, IsDefaultOrderBy:=False)> _
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
        _ContactTypeID = Nothing
        _ModifiedDate = Now
        _Name = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CountryRegionCode", PrimaryKeyFieldName:="CountryRegionCode", RootContainerName:="[Person].[CountryRegion]", EnabledPropertyName:="CountryRegionCode", PrimaryKeyPropertyName:="CountryRegionCode")> _
Public Class EntPerson_CountryRegion

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CountryRegionCode As String
    Private _ModifiedDate As DateTime
    Private _Name As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Clustered index created by a primary key constraint. - ISO standard code for countries and regions.", FieldName:="CountryRegionCode", ForeingCRUD:="ABM_CountryRegion", ForeingTable:="CountryRegion", MainTable:="[Person].[CountryRegion]", Order:=1, ParameterName:="CountryRegionCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="CountryRegionCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCountryRegion", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CountryRegionCode() As String
        Get
            Return _CountryRegionCode
        End Get
        Set(ByVal value As String)
            _CountryRegionCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[CountryRegion]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Person].[CountryRegion]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Country or region name. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[CountryRegion]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[CountryRegion]", IsDescription:=False, IsDefaultOrderBy:=False)> _
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
        _CountryRegionCode = Nothing
        _ModifiedDate = Now
        _Name = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StateProvinceID", PrimaryKeyFieldName:="StateProvinceID", RootContainerName:="[Person].[StateProvince]", EnabledPropertyName:="StateProvinceID", PrimaryKeyPropertyName:="StateProvinceID")> _
Public Class EntPerson_StateProvince

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CountryRegionCode As String
    Private _IsOnlyStateProvinceFlag As Boolean
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _Rowguid As Guid
    Private _StateProvinceCode As String
    Private _StateProvinceID As Int32
    Private _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ", FieldName:="CountryRegionCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_CountryRegion", ForeingTable:="CountryRegion", MainTable:="[Person].[StateProvince]", Order:=3, ParameterName:="CountryRegionCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="CountryRegionCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCountryRegion", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CountryRegionCode() As String
        Get
            Return _CountryRegionCode
        End Get
        Set(ByVal value As String)
            _CountryRegionCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode. - Unique nonclustered index. Used to support replication samples.", FieldName:="IsOnlyStateProvinceFlag", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[StateProvince]", Order:=4, ParameterName:="IsOnlyStateProvinceFlag", SourceColumn:="IsOnlyStateProvinceFlag", TypeName:="Boolean", EntityClassContainer:="Ent[Person].[StateProvince]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property IsOnlyStateProvinceFlag() As Boolean
        Get
            Return _IsOnlyStateProvinceFlag
        End Get
        Set(ByVal value As Boolean)
            _IsOnlyStateProvinceFlag = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[StateProvince]", Order:=8, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Person].[StateProvince]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="State or province description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[StateProvince]", Order:=5, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Person].[StateProvince]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[StateProvince]", Order:=7, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Person].[StateProvince]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - ISO standard state or province code.", FieldName:="StateProvinceCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Person].[StateProvince]", Order:=2, ParameterName:="StateProvinceCode", Size:=3, SourceColumn:="StateProvinceCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="Ent[Person].[StateProvince]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StateProvinceCode() As String
        Get
            Return _StateProvinceCode
        End Get
        Set(ByVal value As String)
            _StateProvinceCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for StateProvince records. - Clustered index created by a primary key constraint.", FieldName:="StateProvinceID", ForeingCRUD:="ABM_StateProvince", ForeingTable:="StateProvince", MainTable:="[Person].[StateProvince]", Order:=1, ParameterName:="StateProvinceID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="StateProvinceID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStateProvince", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property StateProvinceID() As Int32
        Get
            Return _StateProvinceID
        End Get
        Set(ByVal value As Int32)
            _StateProvinceID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.", FieldName:="TerritoryID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SalesTerritory", ForeingTable:="SalesTerritory", MainTable:="[Person].[StateProvince]", Order:=6, ParameterName:="TerritoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="TerritoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesTerritory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TerritoryID() As Int32
        Get
            Return _TerritoryID
        End Get
        Set(ByVal value As Int32)
            _TerritoryID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _CountryRegionCode = Nothing
        _IsOnlyStateProvinceFlag = 1
        _ModifiedDate = Now
        _Name = Nothing
        _Rowguid = newid
        _StateProvinceCode = Nothing
        _StateProvinceID = Nothing
        _TerritoryID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="BillOfMaterialsID", PrimaryKeyFieldName:="BillOfMaterialsID", RootContainerName:="[Production].[BillOfMaterials]", EnabledPropertyName:="BillOfMaterialsID", PrimaryKeyPropertyName:="BillOfMaterialsID")> _
Public Class EntProduction_BillOfMaterials

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _BillOfMaterialsID As Int32
    Private _BOMLevel As Int16
    Private _ComponentID As Int32
    Private _EndDate As DateTime
    Private _ModifiedDate As DateTime
    Private _PerAssemblyQty As Decimal
    Private _ProductAssemblyID As Int32
    Private _StartDate As DateTime
    Private _UnitMeasureCode As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index. - Primary key for BillOfMaterials records.", FieldName:="BillOfMaterialsID", ForeingCRUD:="ABM_BillOfMaterials", ForeingTable:="BillOfMaterials", MainTable:="[Production].[BillOfMaterials]", Order:=1, ParameterName:="BillOfMaterialsID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="BillOfMaterialsID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntBillOfMaterials", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property BillOfMaterialsID() As Int32
        Get
            Return _BillOfMaterialsID
        End Get
        Set(ByVal value As Int32)
            _BillOfMaterialsID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Indicates the depth the component is from its parent (AssemblyID).", FieldName:="BOMLevel", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[BillOfMaterials]", Order:=7, ParameterName:="BOMLevel", Size:=5, SourceColumn:="BOMLevel", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Production].[BillOfMaterials]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property BOMLevel() As Int16
        Get
            Return _BOMLevel
        End Get
        Set(ByVal value As Int16)
            _BOMLevel = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Component identification number. Foreign key to Product.ProductID.", FieldName:="ComponentID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[BillOfMaterials]", Order:=3, ParameterName:="ComponentID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ComponentID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, ForeingFieldName:="ComponentID", IsDefaultOrderBy:=False)> _
     Public Property ComponentID() As Int32
        Get
            Return _ComponentID
        End Get
        Set(ByVal value As Int32)
            _ComponentID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the component stopped being used in the assembly item.", FieldName:="EndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[BillOfMaterials]", Order:=5, ParameterName:="EndDate", SetNullable:=True, SourceColumn:="EndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[BillOfMaterials]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndDate() As DateTime
        Get
            Return _EndDate
        End Get
        Set(ByVal value As DateTime)
            _EndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[BillOfMaterials]", Order:=9, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[BillOfMaterials]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((1.00))", FieldDescription:="Quantity of the component needed to create the assembly.", FieldName:="PerAssemblyQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[BillOfMaterials]", Order:=8, ParameterName:="PerAssemblyQty", Scale:=2, Size:=8, SourceColumn:="PerAssemblyQty", TypeName:="Decimal", MaxValue:=8, EntityClassContainer:="Ent[Production].[BillOfMaterials]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PerAssemblyQty() As Decimal
        Get
            Return _PerAssemblyQty
        End Get
        Set(ByVal value As Decimal)
            _PerAssemblyQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index created by a primary key constraint. - Parent product identification number. Foreign key to Product.ProductID.", FieldName:="ProductAssemblyID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[BillOfMaterials]", Order:=2, ParameterName:="ProductAssemblyID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="ProductAssemblyID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, ForeingFieldName:="ProductAssemblyID", IsDefaultOrderBy:=False)> _
     Public Property ProductAssemblyID() As Int32
        Get
            Return _ProductAssemblyID
        End Get
        Set(ByVal value As Int32)
            _ProductAssemblyID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date the component started being used in the assembly item.", FieldName:="StartDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ProductCostHistory", ForeingTable:="ProductCostHistory", MainTable:="[Production].[BillOfMaterials]", Order:=4, ParameterName:="StartDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="StartDate", TypeName:="DateTime", EntityClassContainer:="EntProductCostHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartDate() As DateTime
        Get
            Return _StartDate
        End Get
        Set(ByVal value As DateTime)
            _StartDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Standard code identifying the unit of measure for the quantity.", FieldName:="UnitMeasureCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_UnitMeasure", ForeingTable:="UnitMeasure", MainTable:="[Production].[BillOfMaterials]", Order:=6, ParameterName:="UnitMeasureCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="UnitMeasureCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntUnitMeasure", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property UnitMeasureCode() As String
        Get
            Return _UnitMeasureCode
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
        _ModifiedDate = Now
        _PerAssemblyQty = 1.0
        _ProductAssemblyID = Nothing
        _StartDate = Now
        _UnitMeasureCode = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CultureID", PrimaryKeyFieldName:="CultureID", RootContainerName:="[Production].[Culture]", EnabledPropertyName:="CultureID", PrimaryKeyPropertyName:="CultureID")> _
Public Class EntProduction_Culture

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CultureID As String
    Private _ModifiedDate As DateTime
    Private _Name As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Culture records.", FieldName:="CultureID", ForeingCRUD:="ABM_Culture", ForeingTable:="Culture", MainTable:="[Production].[Culture]", Order:=1, ParameterName:="CultureID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=6, SourceColumn:="CultureID", TypeName:="String", MaxValue:=6, EntityClassContainer:="EntCulture", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CultureID() As String
        Get
            Return _CultureID
        End Get
        Set(ByVal value As String)
            _CultureID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Culture]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Culture]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Culture description. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Culture]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[Culture]", IsDescription:=False, IsDefaultOrderBy:=False)> _
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
        _CultureID = Nothing
        _ModifiedDate = Now
        _Name = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="DocumentID", PrimaryKeyFieldName:="DocumentID", RootContainerName:="[Production].[Document]", EnabledPropertyName:="DocumentID", PrimaryKeyPropertyName:="DocumentID")> _
Public Class EntProduction_Document

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ChangeNumber As Int32
    Private _Document As Byte
    Private _DocumentID As Int32
    Private _DocumentSummary As String
    Private _FileExtension As String
    Private _FileName As String
    Private _ModifiedDate As DateTime
    Private _Revision As String
    Private _Status As Byte
    Private _Title As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, DefaultValue:="((0))", FieldDescription:="Engineering change approval number.", FieldName:="ChangeNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=6, ParameterName:="ChangeNumber", Size:=10, SourceColumn:="ChangeNumber", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ChangeNumber() As Int32
        Get
            Return _ChangeNumber
        End Get
        Set(ByVal value As Int32)
            _ChangeNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Complete document.", FieldName:="Document", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=9, ParameterName:="Document", SetNullable:=True, Size:=-1, SourceColumn:="Document", TypeName:="Byte", MaxValue:=-1, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Document() As Byte
        Get
            Return _Document
        End Get
        Set(ByVal value As Byte)
            _Document = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for Document records. - Clustered index created by a primary key constraint.", FieldName:="DocumentID", ForeingCRUD:="ABM_Document", ForeingTable:="Document", MainTable:="[Production].[Document]", Order:=1, ParameterName:="DocumentID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="DocumentID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntDocument", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property DocumentID() As Int32
        Get
            Return _DocumentID
        End Get
        Set(ByVal value As Int32)
            _DocumentID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Document abstract.", FieldName:="DocumentSummary", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=8, ParameterName:="DocumentSummary", SetNullable:=True, Size:=-1, SourceColumn:="DocumentSummary", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DocumentSummary() As String
        Get
            Return _DocumentSummary
        End Get
        Set(ByVal value As String)
            _DocumentSummary = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="File extension indicating the document type. For example, .doc or .txt.", FieldName:="FileExtension", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=4, ParameterName:="FileExtension", Size:=8, SourceColumn:="FileExtension", TypeName:="String", MaxValue:=8, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property FileExtension() As String
        Get
            Return _FileExtension
        End Get
        Set(ByVal value As String)
            _FileExtension = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Directory path and file name of the document", FieldName:="FileName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=3, ParameterName:="FileName", Size:=400, SourceColumn:="FileName", TypeName:="String", MaxValue:=400, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property FileName() As String
        Get
            Return _FileName
        End Get
        Set(ByVal value As String)
            _FileName = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=10, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Revision number of the document. ", FieldName:="Revision", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=5, ParameterName:="Revision", Size:=5, SourceColumn:="Revision", TypeName:="String", MaxValue:=5, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Revision() As String
        Get
            Return _Revision
        End Get
        Set(ByVal value As String)
            _Revision = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="1 = Pending approval, 2 = Approved, 3 = Obsolete", FieldName:="Status", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=7, ParameterName:="Status", Size:=3, SourceColumn:="Status", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Status() As Byte
        Get
            Return _Status
        End Get
        Set(ByVal value As Byte)
            _Status = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Title of the document.", FieldName:="Title", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Document]", Order:=2, ParameterName:="Title", Size:=50, SourceColumn:="Title", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[Document]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ChangeNumber = 0
        _Document = Nothing
        _DocumentID = Nothing
        _DocumentSummary = Nothing
        _FileExtension = Nothing
        _FileName = Nothing
        _ModifiedDate = Now
        _Revision = Nothing
        _Status = Nothing
        _Title = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="IllustrationID", PrimaryKeyFieldName:="IllustrationID", RootContainerName:="[Production].[Illustration]", EnabledPropertyName:="IllustrationID", PrimaryKeyPropertyName:="IllustrationID")> _
Public Class EntProduction_Illustration

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Diagram As String
    Private _IllustrationID As Int32
    Private _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Illustrations used in manufacturing instructions. Stored as XML.", FieldName:="Diagram", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Illustration]", Order:=2, ParameterName:="Diagram", SetNullable:=True, Size:=-1, SourceColumn:="Diagram", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[Production].[Illustration]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Diagram() As String
        Get
            Return _Diagram
        End Get
        Set(ByVal value As String)
            _Diagram = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Illustration records.", FieldName:="IllustrationID", ForeingCRUD:="ABM_Illustration", ForeingTable:="Illustration", MainTable:="[Production].[Illustration]", Order:=1, ParameterName:="IllustrationID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="IllustrationID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntIllustration", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property IllustrationID() As Int32
        Get
            Return _IllustrationID
        End Get
        Set(ByVal value As Int32)
            _IllustrationID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Illustration]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Illustration]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
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
        _ModifiedDate = Now
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="LocationID", PrimaryKeyFieldName:="LocationID", RootContainerName:="[Production].[Location]", EnabledPropertyName:="LocationID", PrimaryKeyPropertyName:="LocationID")> _
Public Class EntProduction_Location

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Availability As Decimal
    Private _CostRate As Decimal
    Private _LocationID As Int16
    Private _ModifiedDate As DateTime
    Private _Name As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Work capacity (in hours) of the manufacturing location.", FieldName:="Availability", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Location]", Order:=4, ParameterName:="Availability", Scale:=2, Size:=8, SourceColumn:="Availability", TypeName:="Decimal", MaxValue:=8, EntityClassContainer:="Ent[Production].[Location]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Availability() As Decimal
        Get
            Return _Availability
        End Get
        Set(ByVal value As Decimal)
            _Availability = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Standard hourly cost of the manufacturing location.", FieldName:="CostRate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Location]", Order:=3, ParameterName:="CostRate", Scale:=4, Size:=10, SourceColumn:="CostRate", TypeName:="Decimal", MaxValue:=10, EntityClassContainer:="Ent[Production].[Location]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CostRate() As Decimal
        Get
            Return _CostRate
        End Get
        Set(ByVal value As Decimal)
            _CostRate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Primary key for Location records. - Clustered index created by a primary key constraint.", FieldName:="LocationID", ForeingCRUD:="ABM_Location", ForeingTable:="Location", MainTable:="[Production].[Location]", Order:=1, ParameterName:="LocationID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=5, SourceColumn:="LocationID", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntLocation", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property LocationID() As Int16
        Get
            Return _LocationID
        End Get
        Set(ByVal value As Int16)
            _LocationID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Location]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Location]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Location description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Location]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[Location]", IsDescription:=False, IsDefaultOrderBy:=False)> _
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
        _Availability = 0.0
        _CostRate = 0.0
        _LocationID = Nothing
        _ModifiedDate = Now
        _Name = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductID", PrimaryKeyFieldName:="ProductID", RootContainerName:="[Production].[Product]", EnabledPropertyName:="ProductID", PrimaryKeyPropertyName:="ProductID")> _
Public Class EntProduction_Product

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private [_Class] As String
    Private _Color As String
    Private _DaysToManufacture As Int32
    Private _DiscontinuedDate As DateTime
    Private _FinishedGoodsFlag As Boolean
    Private _ListPrice As Decimal
    Private _MakeFlag As Boolean
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _ProductID As Int32
    Private _ProductLine As String
    Private _ProductModelID As Int32
    Private _ProductNumber As String
    Private _ProductSubcategoryID As Int32
    Private _ReorderPoint As Int16
    Private _Rowguid As Guid
    Private _SafetyStockLevel As Int16
    Private _SellEndDate As DateTime
    Private _SellStartDate As DateTime
    Private _Size As String
    Private _SizeUnitMeasureCode As String
    Private _StandardCost As Decimal
    Private _Style As String
    Private _Weight As Decimal
    Private _WeightUnitMeasureCode As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="H = High, M = Medium, L = Low", FieldName:="Class", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=17, ParameterName:="Class", SetNullable:=True, Size:=2, SourceColumn:="Class", TypeName:="String", MaxValue:=2, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property [Class]() As String
        Get
            Return [_Class]
        End Get
        Set(ByVal value As String)
            [_Class] = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Product color.", FieldName:="Color", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=6, ParameterName:="Color", SetNullable:=True, Size:=15, SourceColumn:="Color", TypeName:="String", MaxValue:=15, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Color() As String
        Get
            Return _Color
        End Get
        Set(ByVal value As String)
            _Color = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Number of days required to manufacture the product.", FieldName:="DaysToManufacture", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=15, ParameterName:="DaysToManufacture", Size:=10, SourceColumn:="DaysToManufacture", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DaysToManufacture() As Int32
        Get
            Return _DaysToManufacture
        End Get
        Set(ByVal value As Int32)
            _DaysToManufacture = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the product was discontinued.", FieldName:="DiscontinuedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=23, ParameterName:="DiscontinuedDate", SetNullable:=True, SourceColumn:="DiscontinuedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DiscontinuedDate() As DateTime
        Get
            Return _DiscontinuedDate
        End Get
        Set(ByVal value As DateTime)
            _DiscontinuedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="0 = Product is not a salable item. 1 = Product is salable.", FieldName:="FinishedGoodsFlag", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=5, ParameterName:="FinishedGoodsFlag", SourceColumn:="FinishedGoodsFlag", TypeName:="Boolean", EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property FinishedGoodsFlag() As Boolean
        Get
            Return _FinishedGoodsFlag
        End Get
        Set(ByVal value As Boolean)
            _FinishedGoodsFlag = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Selling price.", FieldName:="ListPrice", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=10, ParameterName:="ListPrice", Scale:=4, Size:=19, SourceColumn:="ListPrice", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ListPrice() As Decimal
        Get
            Return _ListPrice
        End Get
        Set(ByVal value As Decimal)
            _ListPrice = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="Unique nonclustered index. Used to support replication samples. - 0 = Product is purchased, 1 = Product is manufactured in-house.", FieldName:="MakeFlag", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=4, ParameterName:="MakeFlag", SourceColumn:="MakeFlag", TypeName:="Boolean", EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property MakeFlag() As Boolean
        Get
            Return _MakeFlag
        End Get
        Set(ByVal value As Boolean)
            _MakeFlag = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=25, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Name of the product. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Product records.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[Product]", Order:=1, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="R = Road, M = Mountain, T = Touring, S = Standard", FieldName:="ProductLine", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=16, ParameterName:="ProductLine", SetNullable:=True, Size:=2, SourceColumn:="ProductLine", TypeName:="String", MaxValue:=2, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductLine() As String
        Get
            Return _ProductLine
        End Get
        Set(ByVal value As String)
            _ProductLine = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product is a member of this product model. Foreign key to ProductModel.ProductModelID.", FieldName:="ProductModelID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ProductModel", ForeingTable:="ProductModel", MainTable:="[Production].[Product]", Order:=20, ParameterName:="ProductModelID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="ProductModelID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductModel", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductModelID() As Int32
        Get
            Return _ProductModelID
        End Get
        Set(ByVal value As Int32)
            _ProductModelID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique product identification number. - Unique nonclustered index.", FieldName:="ProductNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=3, ParameterName:="ProductNumber", Size:=25, SourceColumn:="ProductNumber", TypeName:="String", MaxValue:=25, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductNumber() As String
        Get
            Return _ProductNumber
        End Get
        Set(ByVal value As String)
            _ProductNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ", FieldName:="ProductSubcategoryID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ProductSubcategory", ForeingTable:="ProductSubcategory", MainTable:="[Production].[Product]", Order:=19, ParameterName:="ProductSubcategoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="ProductSubcategoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductSubcategory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductSubcategoryID() As Int32
        Get
            Return _ProductSubcategoryID
        End Get
        Set(ByVal value As Int32)
            _ProductSubcategoryID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Inventory level that triggers a purchase order or work order. ", FieldName:="ReorderPoint", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=8, ParameterName:="ReorderPoint", Size:=5, SourceColumn:="ReorderPoint", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReorderPoint() As Int16
        Get
            Return _ReorderPoint
        End Get
        Set(ByVal value As Int16)
            _ReorderPoint = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=24, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Minimum inventory quantity. ", FieldName:="SafetyStockLevel", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=7, ParameterName:="SafetyStockLevel", Size:=5, SourceColumn:="SafetyStockLevel", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SafetyStockLevel() As Int16
        Get
            Return _SafetyStockLevel
        End Get
        Set(ByVal value As Int16)
            _SafetyStockLevel = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the product was no longer available for sale.", FieldName:="SellEndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=22, ParameterName:="SellEndDate", SetNullable:=True, SourceColumn:="SellEndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SellEndDate() As DateTime
        Get
            Return _SellEndDate
        End Get
        Set(ByVal value As DateTime)
            _SellEndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the product was available for sale.", FieldName:="SellStartDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=21, ParameterName:="SellStartDate", SourceColumn:="SellStartDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SellStartDate() As DateTime
        Get
            Return _SellStartDate
        End Get
        Set(ByVal value As DateTime)
            _SellStartDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Product size.", FieldName:="Size", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=11, ParameterName:="Size", SetNullable:=True, Size:=5, SourceColumn:="Size", TypeName:="String", MaxValue:=5, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Size() As String
        Get
            Return _Size
        End Get
        Set(ByVal value As String)
            _Size = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unit of measure for Size column.", FieldName:="SizeUnitMeasureCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_UnitMeasure", ForeingTable:="UnitMeasure", MainTable:="[Production].[Product]", Order:=12, ParameterName:="SizeUnitMeasureCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=3, SourceColumn:="SizeUnitMeasureCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntUnitMeasure", IsDescription:=False, ForeingFieldName:="SizeUnitMeasureCode", IsDefaultOrderBy:=False)> _
     Public Property SizeUnitMeasureCode() As String
        Get
            Return _SizeUnitMeasureCode
        End Get
        Set(ByVal value As String)
            _SizeUnitMeasureCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Standard cost of the product.", FieldName:="StandardCost", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=9, ParameterName:="StandardCost", Scale:=4, Size:=19, SourceColumn:="StandardCost", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StandardCost() As Decimal
        Get
            Return _StandardCost
        End Get
        Set(ByVal value As Decimal)
            _StandardCost = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="W = Womens, M = Mens, U = Universal", FieldName:="Style", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=18, ParameterName:="Style", SetNullable:=True, Size:=2, SourceColumn:="Style", TypeName:="String", MaxValue:=2, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Style() As String
        Get
            Return _Style
        End Get
        Set(ByVal value As String)
            _Style = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Product weight.", FieldName:="Weight", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[Product]", Order:=14, ParameterName:="Weight", Scale:=2, SetNullable:=True, Size:=8, SourceColumn:="Weight", TypeName:="Decimal", MaxValue:=8, EntityClassContainer:="Ent[Production].[Product]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Weight() As Decimal
        Get
            Return _Weight
        End Get
        Set(ByVal value As Decimal)
            _Weight = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unit of measure for Weight column.", FieldName:="WeightUnitMeasureCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_UnitMeasure", ForeingTable:="UnitMeasure", MainTable:="[Production].[Product]", Order:=13, ParameterName:="WeightUnitMeasureCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=3, SourceColumn:="WeightUnitMeasureCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntUnitMeasure", IsDescription:=False, ForeingFieldName:="WeightUnitMeasureCode", IsDefaultOrderBy:=False)> _
     Public Property WeightUnitMeasureCode() As String
        Get
            Return _WeightUnitMeasureCode
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
        _FinishedGoodsFlag = 1
        _ListPrice = Nothing
        _MakeFlag = 1
        _ModifiedDate = Now
        _Name = Nothing
        _ProductID = Nothing
        _ProductLine = Nothing
        _ProductModelID = Nothing
        _ProductNumber = Nothing
        _ProductSubcategoryID = Nothing
        _ReorderPoint = Nothing
        _Rowguid = newid
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
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductCategoryID", PrimaryKeyFieldName:="ProductCategoryID", RootContainerName:="[Production].[ProductCategory]", EnabledPropertyName:="ProductCategoryID", PrimaryKeyPropertyName:="ProductCategoryID")> _
Public Class EntProduction_ProductCategory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _ProductCategoryID As Int32
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductCategory]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductCategory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Category description. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductCategory]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ProductCategory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for ProductCategory records.", FieldName:="ProductCategoryID", ForeingCRUD:="ABM_ProductCategory", ForeingTable:="ProductCategory", MainTable:="[Production].[ProductCategory]", Order:=1, ParameterName:="ProductCategoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductCategoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductCategory", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductCategoryID() As Int32
        Get
            Return _ProductCategoryID
        End Get
        Set(ByVal value As Int32)
            _ProductCategoryID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample. - Unique nonclustered index. Used to support replication samples.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductCategory]", Order:=3, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Production].[ProductCategory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Name = Nothing
        _ProductCategoryID = Nothing
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StartDate", PrimaryKeyFieldName:="StartDate", RootContainerName:="[Production].[ProductCostHistory]", EnabledPropertyName:="StartDate", PrimaryKeyPropertyName:="StartDate")> _
Public Class EntProduction_ProductCostHistory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _EndDate As DateTime
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _StandardCost As Decimal
    Private _StartDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Product cost end date.", FieldName:="EndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductCostHistory]", Order:=3, ParameterName:="EndDate", SetNullable:=True, SourceColumn:="EndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductCostHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndDate() As DateTime
        Get
            Return _EndDate
        End Get
        Set(ByVal value As DateTime)
            _EndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductCostHistory]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductCostHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product identification number. Foreign key to Product.ProductID - Clustered index created by a primary key constraint.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[ProductCostHistory]", Order:=1, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Standard cost of the product.", FieldName:="StandardCost", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductCostHistory]", Order:=4, ParameterName:="StandardCost", Scale:=4, Size:=19, SourceColumn:="StandardCost", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[ProductCostHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StandardCost() As Decimal
        Get
            Return _StandardCost
        End Get
        Set(ByVal value As Decimal)
            _StandardCost = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Product cost start date.", FieldName:="StartDate", ForeingCRUD:="ABM_ProductCostHistory", ForeingTable:="ProductCostHistory", MainTable:="[Production].[ProductCostHistory]", Order:=2, ParameterName:="StartDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="StartDate", TypeName:="DateTime", EntityClassContainer:="EntProductCostHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartDate() As DateTime
        Get
            Return _StartDate
        End Get
        Set(ByVal value As DateTime)
            _StartDate = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _EndDate = Nothing
        _ModifiedDate = Now
        _ProductID = Nothing
        _StandardCost = Nothing
        _StartDate = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductDescriptionID", PrimaryKeyFieldName:="ProductDescriptionID", RootContainerName:="[Production].[ProductDescription]", EnabledPropertyName:="ProductDescriptionID", PrimaryKeyPropertyName:="ProductDescriptionID")> _
Public Class EntProduction_ProductDescription

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Description As String
    Private _ModifiedDate As DateTime
    Private _ProductDescriptionID As Int32
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Description of the product.", FieldName:="Description", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductDescription]", Order:=2, ParameterName:="Description", Size:=400, SourceColumn:="Description", TypeName:="String", MaxValue:=400, EntityClassContainer:="Ent[Production].[ProductDescription]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductDescription]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductDescription]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for ProductDescription records. - Clustered index created by a primary key constraint.", FieldName:="ProductDescriptionID", ForeingCRUD:="ABM_ProductDescription", ForeingTable:="ProductDescription", MainTable:="[Production].[ProductDescription]", Order:=1, ParameterName:="ProductDescriptionID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductDescriptionID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductDescription", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductDescriptionID() As Int32
        Get
            Return _ProductDescriptionID
        End Get
        Set(ByVal value As Int32)
            _ProductDescriptionID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductDescription]", Order:=3, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Production].[ProductDescription]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _Description = Nothing
        _ModifiedDate = Now
        _ProductDescriptionID = Nothing
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductID", PrimaryKeyFieldName:="ProductID", RootContainerName:="[Production].[ProductDocument]", EnabledPropertyName:="ProductID", PrimaryKeyPropertyName:="ProductID")> _
Public Class EntProduction_ProductDocument

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _DocumentID As Int32
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Document identification number. Foreign key to Document.DocumentID.", FieldName:="DocumentID", ForeingCRUD:="ABM_Document", ForeingTable:="Document", MainTable:="[Production].[ProductDocument]", Order:=2, ParameterName:="DocumentID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="DocumentID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntDocument", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property DocumentID() As Int32
        Get
            Return _DocumentID
        End Get
        Set(ByVal value As Int32)
            _DocumentID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductDocument]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductDocument]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product identification number. Foreign key to Product.ProductID. - Clustered index created by a primary key constraint.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[ProductDocument]", Order:=1, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _DocumentID = Nothing
        _ModifiedDate = Now
        _ProductID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductID", PrimaryKeyFieldName:="ProductID", RootContainerName:="[Production].[ProductInventory]", EnabledPropertyName:="ProductID", PrimaryKeyPropertyName:="ProductID")> _
Public Class EntProduction_ProductInventory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Bin As Byte
    Private _LocationID As Int16
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _Quantity As Int16
    Private _Rowguid As Guid
    Private _Shelf As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Storage container on a shelf in an inventory location.", FieldName:="Bin", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductInventory]", Order:=4, ParameterName:="Bin", Size:=3, SourceColumn:="Bin", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Production].[ProductInventory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Bin() As Byte
        Get
            Return _Bin
        End Get
        Set(ByVal value As Byte)
            _Bin = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Inventory location identification number. Foreign key to Location.LocationID. ", FieldName:="LocationID", ForeingCRUD:="ABM_Location", ForeingTable:="Location", MainTable:="[Production].[ProductInventory]", Order:=2, ParameterName:="LocationID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=5, SourceColumn:="LocationID", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntLocation", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property LocationID() As Int16
        Get
            Return _LocationID
        End Get
        Set(ByVal value As Int16)
            _LocationID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductInventory]", Order:=7, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductInventory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product identification number. Foreign key to Product.ProductID. - Clustered index created by a primary key constraint.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[ProductInventory]", Order:=1, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, DefaultValue:="((0))", FieldDescription:="Quantity of products in the inventory location.", FieldName:="Quantity", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductInventory]", Order:=5, ParameterName:="Quantity", Size:=5, SourceColumn:="Quantity", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Production].[ProductInventory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Quantity() As Int16
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Int16)
            _Quantity = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductInventory]", Order:=6, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Production].[ProductInventory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Storage compartment within an inventory location.", FieldName:="Shelf", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductInventory]", Order:=3, ParameterName:="Shelf", Size:=10, SourceColumn:="Shelf", TypeName:="String", MaxValue:=10, EntityClassContainer:="Ent[Production].[ProductInventory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Shelf() As String
        Get
            Return _Shelf
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
        _ModifiedDate = Now
        _ProductID = Nothing
        _Quantity = 0
        _Rowguid = newid
        _Shelf = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="StartDate", PrimaryKeyFieldName:="StartDate", RootContainerName:="[Production].[ProductListPriceHistory]", EnabledPropertyName:="StartDate", PrimaryKeyPropertyName:="StartDate")> _
Public Class EntProduction_ProductListPriceHistory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _EndDate As DateTime
    Private _ListPrice As Decimal
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _StartDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="List price end date", FieldName:="EndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductListPriceHistory]", Order:=3, ParameterName:="EndDate", SetNullable:=True, SourceColumn:="EndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductListPriceHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndDate() As DateTime
        Get
            Return _EndDate
        End Get
        Set(ByVal value As DateTime)
            _EndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Product list price.", FieldName:="ListPrice", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductListPriceHistory]", Order:=4, ParameterName:="ListPrice", Scale:=4, Size:=19, SourceColumn:="ListPrice", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[ProductListPriceHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ListPrice() As Decimal
        Get
            Return _ListPrice
        End Get
        Set(ByVal value As Decimal)
            _ListPrice = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductListPriceHistory]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductListPriceHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product identification number. Foreign key to Product.ProductID - Clustered index created by a primary key constraint.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[ProductListPriceHistory]", Order:=1, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="List price start date.", FieldName:="StartDate", ForeingCRUD:="ABM_ProductCostHistory", ForeingTable:="ProductCostHistory", MainTable:="[Production].[ProductListPriceHistory]", Order:=2, ParameterName:="StartDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="StartDate", TypeName:="DateTime", EntityClassContainer:="EntProductCostHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartDate() As DateTime
        Get
            Return _StartDate
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
        _ModifiedDate = Now
        _ProductID = Nothing
        _StartDate = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductModelID", PrimaryKeyFieldName:="ProductModelID", RootContainerName:="[Production].[ProductModel]", EnabledPropertyName:="ProductModelID", PrimaryKeyPropertyName:="ProductModelID")> _
Public Class EntProduction_ProductModel

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CatalogDescription As String
    Private _Instructions As String
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _ProductModelID As Int32
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Detailed product catalog information in xml format. - Unique nonclustered index. Used to support replication samples.", FieldName:="CatalogDescription", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductModel]", Order:=3, ParameterName:="CatalogDescription", SetNullable:=True, Size:=-1, SourceColumn:="CatalogDescription", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[Production].[ProductModel]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CatalogDescription() As String
        Get
            Return _CatalogDescription
        End Get
        Set(ByVal value As String)
            _CatalogDescription = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Manufacturing instructions in xml format.", FieldName:="Instructions", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductModel]", Order:=4, ParameterName:="Instructions", SetNullable:=True, Size:=-1, SourceColumn:="Instructions", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[Production].[ProductModel]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Instructions() As String
        Get
            Return _Instructions
        End Get
        Set(ByVal value As String)
            _Instructions = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductModel]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductModel]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Product model description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductModel]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ProductModel]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for ProductModel records. - Clustered index created by a primary key constraint.", FieldName:="ProductModelID", ForeingCRUD:="ABM_ProductModel", ForeingTable:="ProductModel", MainTable:="[Production].[ProductModel]", Order:=1, ParameterName:="ProductModelID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductModelID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductModel", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductModelID() As Int32
        Get
            Return _ProductModelID
        End Get
        Set(ByVal value As Int32)
            _ProductModelID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductModel]", Order:=5, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Production].[ProductModel]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
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
        _ModifiedDate = Now
        _Name = Nothing
        _ProductModelID = Nothing
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductModelID", PrimaryKeyFieldName:="ProductModelID", RootContainerName:="[Production].[ProductModelIllustration]", EnabledPropertyName:="ProductModelID", PrimaryKeyPropertyName:="ProductModelID")> _
Public Class EntProduction_ProductModelIllustration

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _IllustrationID As Int32
    Private _ModifiedDate As DateTime
    Private _ProductModelID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to Illustration.IllustrationID.", FieldName:="IllustrationID", ForeingCRUD:="ABM_Illustration", ForeingTable:="Illustration", MainTable:="[Production].[ProductModelIllustration]", Order:=2, ParameterName:="IllustrationID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="IllustrationID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntIllustration", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property IllustrationID() As Int32
        Get
            Return _IllustrationID
        End Get
        Set(ByVal value As Int32)
            _IllustrationID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductModelIllustration]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductModelIllustration]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to ProductModel.ProductModelID. - Clustered index created by a primary key constraint.", FieldName:="ProductModelID", ForeingCRUD:="ABM_ProductModel", ForeingTable:="ProductModel", MainTable:="[Production].[ProductModelIllustration]", Order:=1, ParameterName:="ProductModelID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductModelID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductModel", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductModelID() As Int32
        Get
            Return _ProductModelID
        End Get
        Set(ByVal value As Int32)
            _ProductModelID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _IllustrationID = Nothing
        _ModifiedDate = Now
        _ProductModelID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductModelID", PrimaryKeyFieldName:="ProductModelID", RootContainerName:="[Production].[ProductModelProductDescriptionCulture]", EnabledPropertyName:="ProductModelID", PrimaryKeyPropertyName:="ProductModelID")> _
Public Class EntProduction_ProductModelProductDescriptionCulture

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CultureID As String
    Private _ModifiedDate As DateTime
    Private _ProductDescriptionID As Int32
    Private _ProductModelID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Culture identification number. Foreign key to Culture.CultureID.", FieldName:="CultureID", ForeingCRUD:="ABM_Culture", ForeingTable:="Culture", MainTable:="[Production].[ProductModelProductDescriptionCulture]", Order:=3, ParameterName:="CultureID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=6, SourceColumn:="CultureID", TypeName:="String", MaxValue:=6, EntityClassContainer:="EntCulture", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CultureID() As String
        Get
            Return _CultureID
        End Get
        Set(ByVal value As String)
            _CultureID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductModelProductDescriptionCulture]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductModelProductDescriptionCulture]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to ProductDescription.ProductDescriptionID.", FieldName:="ProductDescriptionID", ForeingCRUD:="ABM_ProductDescription", ForeingTable:="ProductDescription", MainTable:="[Production].[ProductModelProductDescriptionCulture]", Order:=2, ParameterName:="ProductDescriptionID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductDescriptionID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductDescription", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductDescriptionID() As Int32
        Get
            Return _ProductDescriptionID
        End Get
        Set(ByVal value As Int32)
            _ProductDescriptionID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to ProductModel.ProductModelID. - Clustered index created by a primary key constraint.", FieldName:="ProductModelID", ForeingCRUD:="ABM_ProductModel", ForeingTable:="ProductModel", MainTable:="[Production].[ProductModelProductDescriptionCulture]", Order:=1, ParameterName:="ProductModelID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductModelID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductModel", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductModelID() As Int32
        Get
            Return _ProductModelID
        End Get
        Set(ByVal value As Int32)
            _ProductModelID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _CultureID = Nothing
        _ModifiedDate = Now
        _ProductDescriptionID = Nothing
        _ProductModelID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductPhotoID", PrimaryKeyFieldName:="ProductPhotoID", RootContainerName:="[Production].[ProductPhoto]", EnabledPropertyName:="ProductPhotoID", PrimaryKeyPropertyName:="ProductPhotoID")> _
Public Class EntProduction_ProductPhoto

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _LargePhoto As Byte
    Private _LargePhotoFileName As String
    Private _ModifiedDate As DateTime
    Private _ProductPhotoID As Int32
    Private _ThumbNailPhoto As Byte
    Private _ThumbnailPhotoFileName As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Large image of the product.", FieldName:="LargePhoto", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductPhoto]", Order:=4, ParameterName:="LargePhoto", SetNullable:=True, Size:=-1, SourceColumn:="LargePhoto", TypeName:="Byte", MaxValue:=-1, EntityClassContainer:="Ent[Production].[ProductPhoto]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LargePhoto() As Byte
        Get
            Return _LargePhoto
        End Get
        Set(ByVal value As Byte)
            _LargePhoto = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Large image file name.", FieldName:="LargePhotoFileName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductPhoto]", Order:=5, ParameterName:="LargePhotoFileName", SetNullable:=True, Size:=50, SourceColumn:="LargePhotoFileName", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ProductPhoto]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LargePhotoFileName() As String
        Get
            Return _LargePhotoFileName
        End Get
        Set(ByVal value As String)
            _LargePhotoFileName = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductPhoto]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductPhoto]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for ProductPhoto records. - Clustered index created by a primary key constraint.", FieldName:="ProductPhotoID", ForeingCRUD:="ABM_ProductPhoto", ForeingTable:="ProductPhoto", MainTable:="[Production].[ProductPhoto]", Order:=1, ParameterName:="ProductPhotoID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductPhotoID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductPhoto", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductPhotoID() As Int32
        Get
            Return _ProductPhotoID
        End Get
        Set(ByVal value As Int32)
            _ProductPhotoID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Small image of the product.", FieldName:="ThumbNailPhoto", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductPhoto]", Order:=2, ParameterName:="ThumbNailPhoto", SetNullable:=True, Size:=-1, SourceColumn:="ThumbNailPhoto", TypeName:="Byte", MaxValue:=-1, EntityClassContainer:="Ent[Production].[ProductPhoto]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ThumbNailPhoto() As Byte
        Get
            Return _ThumbNailPhoto
        End Get
        Set(ByVal value As Byte)
            _ThumbNailPhoto = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Small image file name.", FieldName:="ThumbnailPhotoFileName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductPhoto]", Order:=3, ParameterName:="ThumbnailPhotoFileName", SetNullable:=True, Size:=50, SourceColumn:="ThumbnailPhotoFileName", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ProductPhoto]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ThumbnailPhotoFileName() As String
        Get
            Return _ThumbnailPhotoFileName
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
        _ModifiedDate = Now
        _ProductPhotoID = Nothing
        _ThumbNailPhoto = Nothing
        _ThumbnailPhotoFileName = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductPhotoID", PrimaryKeyFieldName:="ProductPhotoID", RootContainerName:="[Production].[ProductProductPhoto]", EnabledPropertyName:="ProductPhotoID", PrimaryKeyPropertyName:="ProductPhotoID")> _
Public Class EntProduction_ProductProductPhoto

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Primary As Boolean
    Private _ProductID As Int32
    Private _ProductPhotoID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductProductPhoto]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductProductPhoto]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((0))", FieldDescription:="0 = Photo is not the principal image. 1 = Photo is the principal image.", FieldName:="Primary", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductProductPhoto]", Order:=3, ParameterName:="Primary", SourceColumn:="Primary", TypeName:="Boolean", EntityClassContainer:="Ent[Production].[ProductProductPhoto]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Primary() As Boolean
        Get
            Return _Primary
        End Get
        Set(ByVal value As Boolean)
            _Primary = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product identification number. Foreign key to Product.ProductID.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[ProductProductPhoto]", Order:=1, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index created by a primary key constraint. - Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.", FieldName:="ProductPhotoID", ForeingCRUD:="ABM_ProductPhoto", ForeingTable:="ProductPhoto", MainTable:="[Production].[ProductProductPhoto]", Order:=2, ParameterName:="ProductPhotoID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductPhotoID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductPhoto", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductPhotoID() As Int32
        Get
            Return _ProductPhotoID
        End Get
        Set(ByVal value As Int32)
            _ProductPhotoID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Primary = 0
        _ProductID = Nothing
        _ProductPhotoID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductReviewID", PrimaryKeyFieldName:="ProductReviewID", RootContainerName:="[Production].[ProductReview]", EnabledPropertyName:="ProductReviewID", PrimaryKeyPropertyName:="ProductReviewID")> _
Public Class EntProduction_ProductReview

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Comments As String
    Private _EmailAddress As String
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _ProductReviewID As Int32
    Private _Rating As Int32
    Private _ReviewDate As DateTime
    Private _ReviewerName As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Reviewer's comments", FieldName:="Comments", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductReview]", Order:=7, ParameterName:="Comments", SetNullable:=True, Size:=3850, SourceColumn:="Comments", TypeName:="String", MaxValue:=3850, EntityClassContainer:="Ent[Production].[ProductReview]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Comments() As String
        Get
            Return _Comments
        End Get
        Set(ByVal value As String)
            _Comments = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Reviewer's e-mail address.", FieldName:="EmailAddress", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductReview]", Order:=5, ParameterName:="EmailAddress", Size:=50, SourceColumn:="EmailAddress", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ProductReview]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EmailAddress() As String
        Get
            Return _EmailAddress
        End Get
        Set(ByVal value As String)
            _EmailAddress = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductReview]", Order:=8, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductReview]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Product identification number. Foreign key to Product.ProductID.", FieldName:="ProductID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[ProductReview]", Order:=2, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for ProductReview records.", FieldName:="ProductReviewID", ForeingCRUD:="ABM_ProductReview", ForeingTable:="ProductReview", MainTable:="[Production].[ProductReview]", Order:=1, ParameterName:="ProductReviewID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductReviewID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductReview", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductReviewID() As Int32
        Get
            Return _ProductReviewID
        End Get
        Set(ByVal value As Int32)
            _ProductReviewID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.", FieldName:="Rating", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductReview]", Order:=6, ParameterName:="Rating", Size:=10, SourceColumn:="Rating", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[ProductReview]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rating() As Int32
        Get
            Return _Rating
        End Get
        Set(ByVal value As Int32)
            _Rating = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date review was submitted.", FieldName:="ReviewDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductReview]", Order:=4, ParameterName:="ReviewDate", SourceColumn:="ReviewDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductReview]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReviewDate() As DateTime
        Get
            Return _ReviewDate
        End Get
        Set(ByVal value As DateTime)
            _ReviewDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Name of the reviewer.", FieldName:="ReviewerName", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductReview]", Order:=3, ParameterName:="ReviewerName", Size:=50, SourceColumn:="ReviewerName", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ProductReview]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReviewerName() As String
        Get
            Return _ReviewerName
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
        _ModifiedDate = Now
        _ProductID = Nothing
        _ProductReviewID = Nothing
        _Rating = Nothing
        _ReviewDate = Now
        _ReviewerName = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ProductSubcategoryID", PrimaryKeyFieldName:="ProductSubcategoryID", RootContainerName:="[Production].[ProductSubcategory]", EnabledPropertyName:="ProductSubcategoryID", PrimaryKeyPropertyName:="ProductSubcategoryID")> _
Public Class EntProduction_ProductSubcategory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _ProductCategoryID As Int32
    Private _ProductSubcategoryID As Int32
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductSubcategory]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ProductSubcategory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Subcategory description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductSubcategory]", Order:=3, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ProductSubcategory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. - Product category identification number. Foreign key to ProductCategory.ProductCategoryID.", FieldName:="ProductCategoryID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ProductCategory", ForeingTable:="ProductCategory", MainTable:="[Production].[ProductSubcategory]", Order:=2, ParameterName:="ProductCategoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductCategoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductCategory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductCategoryID() As Int32
        Get
            Return _ProductCategoryID
        End Get
        Set(ByVal value As Int32)
            _ProductCategoryID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for ProductSubcategory records. - Clustered index created by a primary key constraint.", FieldName:="ProductSubcategoryID", ForeingCRUD:="ABM_ProductSubcategory", ForeingTable:="ProductSubcategory", MainTable:="[Production].[ProductSubcategory]", Order:=1, ParameterName:="ProductSubcategoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductSubcategoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProductSubcategory", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductSubcategoryID() As Int32
        Get
            Return _ProductSubcategoryID
        End Get
        Set(ByVal value As Int32)
            _ProductSubcategoryID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ProductSubcategory]", Order:=4, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Production].[ProductSubcategory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Name = Nothing
        _ProductCategoryID = Nothing
        _ProductSubcategoryID = Nothing
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ScrapReasonID", PrimaryKeyFieldName:="ScrapReasonID", RootContainerName:="[Production].[ScrapReason]", EnabledPropertyName:="ScrapReasonID", PrimaryKeyPropertyName:="ScrapReasonID")> _
Public Class EntProduction_ScrapReason

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _ScrapReasonID As Int16
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ScrapReason]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[ScrapReason]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Failure description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[ScrapReason]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[ScrapReason]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Primary key for ScrapReason records. - Clustered index created by a primary key constraint.", FieldName:="ScrapReasonID", ForeingCRUD:="ABM_ScrapReason", ForeingTable:="ScrapReason", MainTable:="[Production].[ScrapReason]", Order:=1, ParameterName:="ScrapReasonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=5, SourceColumn:="ScrapReasonID", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntScrapReason", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ScrapReasonID() As Int16
        Get
            Return _ScrapReasonID
        End Get
        Set(ByVal value As Int16)
            _ScrapReasonID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Name = Nothing
        _ScrapReasonID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TransactionID", PrimaryKeyFieldName:="TransactionID", RootContainerName:="[Production].[TransactionHistory]", EnabledPropertyName:="TransactionID", PrimaryKeyPropertyName:="TransactionID")> _
Public Class EntProduction_TransactionHistory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ActualCost As Decimal
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _Quantity As Int32
    Private _ReferenceOrderID As Int32
    Private _ReferenceOrderLineID As Int32
    Private _TransactionDate As DateTime
    Private _TransactionID As Int32
    Private _TransactionType As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Product cost.", FieldName:="ActualCost", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistory]", Order:=8, ParameterName:="ActualCost", Scale:=4, Size:=19, SourceColumn:="ActualCost", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[TransactionHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ActualCost() As Decimal
        Get
            Return _ActualCost
        End Get
        Set(ByVal value As Decimal)
            _ActualCost = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistory]", Order:=9, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[TransactionHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Product identification number. Foreign key to Product.ProductID.", FieldName:="ProductID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[TransactionHistory]", Order:=2, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product quantity.", FieldName:="Quantity", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistory]", Order:=7, ParameterName:="Quantity", Size:=10, SourceColumn:="Quantity", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[TransactionHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Quantity() As Int32
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Int32)
            _Quantity = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Purchase order, sales order, or work order identification number. - Nonclustered index.", FieldName:="ReferenceOrderID", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistory]", Order:=3, ParameterName:="ReferenceOrderID", Size:=10, SourceColumn:="ReferenceOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[TransactionHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReferenceOrderID() As Int32
        Get
            Return _ReferenceOrderID
        End Get
        Set(ByVal value As Int32)
            _ReferenceOrderID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, DefaultValue:="((0))", FieldDescription:="Line number associated with the purchase order, sales order, or work order.", FieldName:="ReferenceOrderLineID", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistory]", Order:=4, ParameterName:="ReferenceOrderLineID", Size:=10, SourceColumn:="ReferenceOrderLineID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[TransactionHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReferenceOrderLineID() As Int32
        Get
            Return _ReferenceOrderLineID
        End Get
        Set(ByVal value As Int32)
            _ReferenceOrderLineID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time of the transaction.", FieldName:="TransactionDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistory]", Order:=5, ParameterName:="TransactionDate", SourceColumn:="TransactionDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[TransactionHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TransactionDate() As DateTime
        Get
            Return _TransactionDate
        End Get
        Set(ByVal value As DateTime)
            _TransactionDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for TransactionHistory records. - Clustered index created by a primary key constraint.", FieldName:="TransactionID", ForeingCRUD:="ABM_TransactionHistory", ForeingTable:="TransactionHistory", MainTable:="[Production].[TransactionHistory]", Order:=1, ParameterName:="TransactionID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="TransactionID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntTransactionHistory", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property TransactionID() As Int32
        Get
            Return _TransactionID
        End Get
        Set(ByVal value As Int32)
            _TransactionID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="W = WorkOrder, S = SalesOrder, P = PurchaseOrder", FieldName:="TransactionType", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistory]", Order:=6, ParameterName:="TransactionType", Size:=1, SourceColumn:="TransactionType", TypeName:="String", MaxValue:=1, EntityClassContainer:="Ent[Production].[TransactionHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TransactionType() As String
        Get
            Return _TransactionType
        End Get
        Set(ByVal value As String)
            _TransactionType = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ActualCost = Nothing
        _ModifiedDate = Now
        _ProductID = Nothing
        _Quantity = Nothing
        _ReferenceOrderID = Nothing
        _ReferenceOrderLineID = 0
        _TransactionDate = Now
        _TransactionID = Nothing
        _TransactionType = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TransactionID", PrimaryKeyFieldName:="TransactionID", RootContainerName:="[Production].[TransactionHistoryArchive]", EnabledPropertyName:="TransactionID", PrimaryKeyPropertyName:="TransactionID")> _
Public Class EntProduction_TransactionHistoryArchive

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ActualCost As Decimal
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _Quantity As Int32
    Private _ReferenceOrderID As Int32
    Private _ReferenceOrderLineID As Int32
    Private _TransactionDate As DateTime
    Private _TransactionID As Int32
    Private _TransactionType As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Product cost.", FieldName:="ActualCost", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistoryArchive]", Order:=8, ParameterName:="ActualCost", Scale:=4, Size:=19, SourceColumn:="ActualCost", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ActualCost() As Decimal
        Get
            Return _ActualCost
        End Get
        Set(ByVal value As Decimal)
            _ActualCost = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistoryArchive]", Order:=9, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Product identification number. Foreign key to Product.ProductID.", FieldName:="ProductID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[TransactionHistoryArchive]", Order:=2, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product quantity.", FieldName:="Quantity", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistoryArchive]", Order:=7, ParameterName:="Quantity", Size:=10, SourceColumn:="Quantity", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Quantity() As Int32
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Int32)
            _Quantity = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Purchase order, sales order, or work order identification number. - Nonclustered index.", FieldName:="ReferenceOrderID", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistoryArchive]", Order:=3, ParameterName:="ReferenceOrderID", Size:=10, SourceColumn:="ReferenceOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReferenceOrderID() As Int32
        Get
            Return _ReferenceOrderID
        End Get
        Set(ByVal value As Int32)
            _ReferenceOrderID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, DefaultValue:="((0))", FieldDescription:="Line number associated with the purchase order, sales order, or work order.", FieldName:="ReferenceOrderLineID", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistoryArchive]", Order:=4, ParameterName:="ReferenceOrderLineID", Size:=10, SourceColumn:="ReferenceOrderLineID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReferenceOrderLineID() As Int32
        Get
            Return _ReferenceOrderLineID
        End Get
        Set(ByVal value As Int32)
            _ReferenceOrderLineID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time of the transaction.", FieldName:="TransactionDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistoryArchive]", Order:=5, ParameterName:="TransactionDate", SourceColumn:="TransactionDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TransactionDate() As DateTime
        Get
            Return _TransactionDate
        End Get
        Set(ByVal value As DateTime)
            _TransactionDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for TransactionHistoryArchive records. - Clustered index created by a primary key constraint.", FieldName:="TransactionID", ForeingCRUD:="ABM_TransactionHistory", ForeingTable:="TransactionHistory", MainTable:="[Production].[TransactionHistoryArchive]", Order:=1, ParameterName:="TransactionID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="TransactionID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntTransactionHistory", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property TransactionID() As Int32
        Get
            Return _TransactionID
        End Get
        Set(ByVal value As Int32)
            _TransactionID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="W = Work Order, S = Sales Order, P = Purchase Order", FieldName:="TransactionType", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[TransactionHistoryArchive]", Order:=6, ParameterName:="TransactionType", Size:=1, SourceColumn:="TransactionType", TypeName:="String", MaxValue:=1, EntityClassContainer:="Ent[Production].[TransactionHistoryArchive]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TransactionType() As String
        Get
            Return _TransactionType
        End Get
        Set(ByVal value As String)
            _TransactionType = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ActualCost = Nothing
        _ModifiedDate = Now
        _ProductID = Nothing
        _Quantity = Nothing
        _ReferenceOrderID = Nothing
        _ReferenceOrderLineID = 0
        _TransactionDate = Now
        _TransactionID = Nothing
        _TransactionType = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="UnitMeasureCode", PrimaryKeyFieldName:="UnitMeasureCode", RootContainerName:="[Production].[UnitMeasure]", EnabledPropertyName:="UnitMeasureCode", PrimaryKeyPropertyName:="UnitMeasureCode")> _
Public Class EntProduction_UnitMeasure

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _UnitMeasureCode As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[UnitMeasure]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[UnitMeasure]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Unit of measure description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[UnitMeasure]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Production].[UnitMeasure]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Primary key. - Clustered index created by a primary key constraint.", FieldName:="UnitMeasureCode", ForeingCRUD:="ABM_UnitMeasure", ForeingTable:="UnitMeasure", MainTable:="[Production].[UnitMeasure]", Order:=1, ParameterName:="UnitMeasureCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="UnitMeasureCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntUnitMeasure", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property UnitMeasureCode() As String
        Get
            Return _UnitMeasureCode
        End Get
        Set(ByVal value As String)
            _UnitMeasureCode = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Name = Nothing
        _UnitMeasureCode = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="WorkOrderID", PrimaryKeyFieldName:="WorkOrderID", RootContainerName:="[Production].[WorkOrder]", EnabledPropertyName:="WorkOrderID", PrimaryKeyPropertyName:="WorkOrderID")> _
Public Class EntProduction_WorkOrder

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _DueDate As DateTime
    Private _EndDate As DateTime
    Private _ModifiedDate As DateTime
    Private _OrderQty As Int32
    Private _ProductID As Int32
    Private _ScrappedQty As Int16
    Private _ScrapReasonID As Int16
    Private _StartDate As DateTime
    Private _StockedQty As Int32
    Private _WorkOrderID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Work order due date.", FieldName:="DueDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrder]", Order:=8, ParameterName:="DueDate", SourceColumn:="DueDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrder]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DueDate() As DateTime
        Get
            Return _DueDate
        End Get
        Set(ByVal value As DateTime)
            _DueDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Work order end date.", FieldName:="EndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrder]", Order:=7, ParameterName:="EndDate", SetNullable:=True, SourceColumn:="EndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrder]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndDate() As DateTime
        Get
            Return _EndDate
        End Get
        Set(ByVal value As DateTime)
            _EndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrder]", Order:=10, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrder]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product quantity to build. - Nonclustered index.", FieldName:="OrderQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrder]", Order:=3, ParameterName:="OrderQty", Size:=10, SourceColumn:="OrderQty", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[WorkOrder]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property OrderQty() As Int32
        Get
            Return _OrderQty
        End Get
        Set(ByVal value As Int32)
            _OrderQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Product identification number. Foreign key to Product.ProductID.", FieldName:="ProductID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[WorkOrder]", Order:=2, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Quantity that failed inspection.", FieldName:="ScrappedQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrder]", Order:=5, ParameterName:="ScrappedQty", Size:=5, SourceColumn:="ScrappedQty", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Production].[WorkOrder]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ScrappedQty() As Int16
        Get
            Return _ScrappedQty
        End Get
        Set(ByVal value As Int16)
            _ScrappedQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Reason for inspection failure.", FieldName:="ScrapReasonID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ScrapReason", ForeingTable:="ScrapReason", MainTable:="[Production].[WorkOrder]", Order:=9, ParameterName:="ScrapReasonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=5, SourceColumn:="ScrapReasonID", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntScrapReason", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ScrapReasonID() As Int16
        Get
            Return _ScrapReasonID
        End Get
        Set(ByVal value As Int16)
            _ScrapReasonID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Work order start date.", FieldName:="StartDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ProductCostHistory", ForeingTable:="ProductCostHistory", MainTable:="[Production].[WorkOrder]", Order:=6, ParameterName:="StartDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="StartDate", TypeName:="DateTime", EntityClassContainer:="EntProductCostHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartDate() As DateTime
        Get
            Return _StartDate
        End Get
        Set(ByVal value As DateTime)
            _StartDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Quantity built and put in inventory.", FieldName:="StockedQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrder]", Order:=4, ParameterName:="StockedQty", Size:=10, SourceColumn:="StockedQty", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Production].[WorkOrder]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StockedQty() As Int32
        Get
            Return _StockedQty
        End Get
        Set(ByVal value As Int32)
            _StockedQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for WorkOrder records.", FieldName:="WorkOrderID", ForeingCRUD:="ABM_WorkOrder", ForeingTable:="WorkOrder", MainTable:="[Production].[WorkOrder]", Order:=1, ParameterName:="WorkOrderID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="WorkOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntWorkOrder", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property WorkOrderID() As Int32
        Get
            Return _WorkOrderID
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
        _ModifiedDate = Now
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
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="WorkOrderID", PrimaryKeyFieldName:="WorkOrderID", RootContainerName:="[Production].[WorkOrderRouting]", EnabledPropertyName:="WorkOrderID", PrimaryKeyPropertyName:="WorkOrderID")> _
Public Class EntProduction_WorkOrderRouting

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ActualCost As Decimal
    Private _ActualEndDate As DateTime
    Private _ActualResourceHrs As Decimal
    Private _ActualStartDate As DateTime
    Private _LocationID As Int16
    Private _ModifiedDate As DateTime
    Private _OperationSequence As Int16
    Private _PlannedCost As Decimal
    Private _ProductID As Int32
    Private _ScheduledEndDate As DateTime
    Private _ScheduledStartDate As DateTime
    Private _WorkOrderID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Actual manufacturing cost.", FieldName:="ActualCost", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=11, ParameterName:="ActualCost", Scale:=4, SetNullable:=True, Size:=19, SourceColumn:="ActualCost", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ActualCost() As Decimal
        Get
            Return _ActualCost
        End Get
        Set(ByVal value As Decimal)
            _ActualCost = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Actual end date.", FieldName:="ActualEndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=8, ParameterName:="ActualEndDate", SetNullable:=True, SourceColumn:="ActualEndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ActualEndDate() As DateTime
        Get
            Return _ActualEndDate
        End Get
        Set(ByVal value As DateTime)
            _ActualEndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Number of manufacturing hours used.", FieldName:="ActualResourceHrs", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=9, ParameterName:="ActualResourceHrs", Scale:=4, SetNullable:=True, Size:=9, SourceColumn:="ActualResourceHrs", TypeName:="Decimal", MaxValue:=9, EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ActualResourceHrs() As Decimal
        Get
            Return _ActualResourceHrs
        End Get
        Set(ByVal value As Decimal)
            _ActualResourceHrs = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Actual start date.", FieldName:="ActualStartDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=7, ParameterName:="ActualStartDate", SetNullable:=True, SourceColumn:="ActualStartDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ActualStartDate() As DateTime
        Get
            Return _ActualStartDate
        End Get
        Set(ByVal value As DateTime)
            _ActualStartDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Manufacturing location where the part is processed. Foreign key to Location.LocationID.", FieldName:="LocationID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Location", ForeingTable:="Location", MainTable:="[Production].[WorkOrderRouting]", Order:=4, ParameterName:="LocationID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=5, SourceColumn:="LocationID", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntLocation", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LocationID() As Int16
        Get
            Return _LocationID
        End Get
        Set(ByVal value As Int16)
            _LocationID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=12, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Primary key. Indicates the manufacturing process sequence.", FieldName:="OperationSequence", ForeingCRUD:="ABM_WorkOrderRouting", ForeingTable:="WorkOrderRouting", MainTable:="[Production].[WorkOrderRouting]", Order:=3, ParameterName:="OperationSequence", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=5, SourceColumn:="OperationSequence", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="EntWorkOrderRouting", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property OperationSequence() As Int16
        Get
            Return _OperationSequence
        End Get
        Set(ByVal value As Int16)
            _OperationSequence = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Estimated manufacturing cost.", FieldName:="PlannedCost", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=10, ParameterName:="PlannedCost", Scale:=4, Size:=19, SourceColumn:="PlannedCost", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PlannedCost() As Decimal
        Get
            Return _PlannedCost
        End Get
        Set(ByVal value As Decimal)
            _PlannedCost = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to Product.ProductID. - Nonclustered index.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Production].[WorkOrderRouting]", Order:=2, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Planned manufacturing end date.", FieldName:="ScheduledEndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=6, ParameterName:="ScheduledEndDate", SourceColumn:="ScheduledEndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ScheduledEndDate() As DateTime
        Get
            Return _ScheduledEndDate
        End Get
        Set(ByVal value As DateTime)
            _ScheduledEndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Planned manufacturing start date.", FieldName:="ScheduledStartDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Production].[WorkOrderRouting]", Order:=5, ParameterName:="ScheduledStartDate", SourceColumn:="ScheduledStartDate", TypeName:="DateTime", EntityClassContainer:="Ent[Production].[WorkOrderRouting]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ScheduledStartDate() As DateTime
        Get
            Return _ScheduledStartDate
        End Get
        Set(ByVal value As DateTime)
            _ScheduledStartDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key. Foreign key to WorkOrder.WorkOrderID.", FieldName:="WorkOrderID", ForeingCRUD:="ABM_WorkOrder", ForeingTable:="WorkOrder", MainTable:="[Production].[WorkOrderRouting]", Order:=1, ParameterName:="WorkOrderID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="WorkOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntWorkOrder", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property WorkOrderID() As Int32
        Get
            Return _WorkOrderID
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
        _ModifiedDate = Now
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
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID", PrimaryKeyFieldName:="VendorID", RootContainerName:="[Purchasing].[ProductVendor]", EnabledPropertyName:="VendorID", PrimaryKeyPropertyName:="VendorID")> _
Public Class EntPurchasing_ProductVendor

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AverageLeadTime As Int32
    Private _LastReceiptCost As Decimal
    Private _LastReceiptDate As DateTime
    Private _MaxOrderQty As Int32
    Private _MinOrderQty As Int32
    Private _ModifiedDate As DateTime
    Private _OnOrderQty As Int32
    Private _ProductID As Int32
    Private _StandardPrice As Decimal
    Private _UnitMeasureCode As String
    Private _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - The average span of time (in days) between placing an order with the vendor and receiving the purchased product.", FieldName:="AverageLeadTime", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=3, ParameterName:="AverageLeadTime", Size:=10, SourceColumn:="AverageLeadTime", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AverageLeadTime() As Int32
        Get
            Return _AverageLeadTime
        End Get
        Set(ByVal value As Int32)
            _AverageLeadTime = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="The selling price when last purchased.", FieldName:="LastReceiptCost", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=5, ParameterName:="LastReceiptCost", Scale:=4, SetNullable:=True, Size:=19, SourceColumn:="LastReceiptCost", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LastReceiptCost() As Decimal
        Get
            Return _LastReceiptCost
        End Get
        Set(ByVal value As Decimal)
            _LastReceiptCost = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the product was last received by the vendor.", FieldName:="LastReceiptDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=6, ParameterName:="LastReceiptDate", SetNullable:=True, SourceColumn:="LastReceiptDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LastReceiptDate() As DateTime
        Get
            Return _LastReceiptDate
        End Get
        Set(ByVal value As DateTime)
            _LastReceiptDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="The minimum quantity that should be ordered.", FieldName:="MaxOrderQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=8, ParameterName:="MaxOrderQty", Size:=10, SourceColumn:="MaxOrderQty", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property MaxOrderQty() As Int32
        Get
            Return _MaxOrderQty
        End Get
        Set(ByVal value As Int32)
            _MaxOrderQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="The maximum quantity that should be ordered.", FieldName:="MinOrderQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=7, ParameterName:="MinOrderQty", Size:=10, SourceColumn:="MinOrderQty", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property MinOrderQty() As Int32
        Get
            Return _MinOrderQty
        End Get
        Set(ByVal value As Int32)
            _MinOrderQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=11, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="The quantity currently on order.", FieldName:="OnOrderQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=9, ParameterName:="OnOrderQty", SetNullable:=True, Size:=10, SourceColumn:="OnOrderQty", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property OnOrderQty() As Int32
        Get
            Return _OnOrderQty
        End Get
        Set(ByVal value As Int32)
            _OnOrderQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key. Foreign key to Product.ProductID.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Purchasing].[ProductVendor]", Order:=1, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="The vendor's usual selling price.", FieldName:="StandardPrice", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ProductVendor]", Order:=4, ParameterName:="StandardPrice", Scale:=4, Size:=19, SourceColumn:="StandardPrice", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[ProductVendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StandardPrice() As Decimal
        Get
            Return _StandardPrice
        End Get
        Set(ByVal value As Decimal)
            _StandardPrice = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="The product's unit of measure.", FieldName:="UnitMeasureCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_UnitMeasure", ForeingTable:="UnitMeasure", MainTable:="[Purchasing].[ProductVendor]", Order:=10, ParameterName:="UnitMeasureCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="UnitMeasureCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntUnitMeasure", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property UnitMeasureCode() As String
        Get
            Return _UnitMeasureCode
        End Get
        Set(ByVal value As String)
            _UnitMeasureCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Primary key. Foreign key to Vendor.VendorID.", FieldName:="VendorID", ForeingCRUD:="ABM_Vendor", ForeingTable:="Vendor", MainTable:="[Purchasing].[ProductVendor]", Order:=2, ParameterName:="VendorID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="VendorID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntVendor", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property VendorID() As Int32
        Get
            Return _VendorID
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
        _ModifiedDate = Now
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
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="PurchaseOrderID", PrimaryKeyFieldName:="PurchaseOrderID", RootContainerName:="[Purchasing].[PurchaseOrderDetail]", EnabledPropertyName:="PurchaseOrderID", PrimaryKeyPropertyName:="PurchaseOrderID")> _
Public Class EntPurchasing_PurchaseOrderDetail

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _DueDate As DateTime
    Private _LineTotal As Decimal
    Private _ModifiedDate As DateTime
    Private _OrderQty As Int16
    Private _ProductID As Int32
    Private _PurchaseOrderDetailID As Int32
    Private _PurchaseOrderID As Int32
    Private _ReceivedQty As Decimal
    Private _RejectedQty As Decimal
    Private _StockedQty As Decimal
    Private _UnitPrice As Decimal
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the product is expected to be received.", FieldName:="DueDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=3, ParameterName:="DueDate", SourceColumn:="DueDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DueDate() As DateTime
        Get
            Return _DueDate
        End Get
        Set(ByVal value As DateTime)
            _DueDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Per product subtotal. Computed as OrderQty * UnitPrice.", FieldName:="LineTotal", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=7, ParameterName:="LineTotal", Scale:=4, Size:=19, SourceColumn:="LineTotal", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LineTotal() As Decimal
        Get
            Return _LineTotal
        End Get
        Set(ByVal value As Decimal)
            _LineTotal = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=11, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Quantity ordered.", FieldName:="OrderQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=4, ParameterName:="OrderQty", Size:=5, SourceColumn:="OrderQty", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property OrderQty() As Int16
        Get
            Return _OrderQty
        End Get
        Set(ByVal value As Int16)
            _OrderQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product identification number. Foreign key to Product.ProductID.", FieldName:="ProductID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=5, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Primary key. One line number per purchased product.", FieldName:="PurchaseOrderDetailID", ForeingCRUD:="ABM_PurchaseOrderDetail", ForeingTable:="PurchaseOrderDetail", MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=2, ParameterName:="PurchaseOrderDetailID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="PurchaseOrderDetailID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntPurchaseOrderDetail", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property PurchaseOrderDetailID() As Int32
        Get
            Return _PurchaseOrderDetailID
        End Get
        Set(ByVal value As Int32)
            _PurchaseOrderDetailID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID. - Clustered index created by a primary key constraint.", FieldName:="PurchaseOrderID", ForeingCRUD:="ABM_PurchaseOrderHeader", ForeingTable:="PurchaseOrderHeader", MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=1, ParameterName:="PurchaseOrderID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="PurchaseOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntPurchaseOrderHeader", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PurchaseOrderID() As Int32
        Get
            Return _PurchaseOrderID
        End Get
        Set(ByVal value As Int32)
            _PurchaseOrderID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Quantity actually received from the vendor.", FieldName:="ReceivedQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=8, ParameterName:="ReceivedQty", Scale:=2, Size:=8, SourceColumn:="ReceivedQty", TypeName:="Decimal", MaxValue:=8, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReceivedQty() As Decimal
        Get
            Return _ReceivedQty
        End Get
        Set(ByVal value As Decimal)
            _ReceivedQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Quantity rejected during inspection.", FieldName:="RejectedQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=9, ParameterName:="RejectedQty", Scale:=2, Size:=8, SourceColumn:="RejectedQty", TypeName:="Decimal", MaxValue:=8, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property RejectedQty() As Decimal
        Get
            Return _RejectedQty
        End Get
        Set(ByVal value As Decimal)
            _RejectedQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.", FieldName:="StockedQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=10, ParameterName:="StockedQty", Scale:=2, Size:=9, SourceColumn:="StockedQty", TypeName:="Decimal", MaxValue:=9, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StockedQty() As Decimal
        Get
            Return _StockedQty
        End Get
        Set(ByVal value As Decimal)
            _StockedQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Vendor's selling price of a single product.", FieldName:="UnitPrice", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderDetail]", Order:=6, ParameterName:="UnitPrice", Scale:=4, Size:=19, SourceColumn:="UnitPrice", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property UnitPrice() As Decimal
        Get
            Return _UnitPrice
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
        _ModifiedDate = Now
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
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="PurchaseOrderID", PrimaryKeyFieldName:="PurchaseOrderID", RootContainerName:="[Purchasing].[PurchaseOrderHeader]", EnabledPropertyName:="PurchaseOrderID", PrimaryKeyPropertyName:="PurchaseOrderID")> _
Public Class EntPurchasing_PurchaseOrderHeader

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _EmployeeID As Int32
    Private _Freight As Decimal
    Private _ModifiedDate As DateTime
    Private _OrderDate As DateTime
    Private _PurchaseOrderID As Int32
    Private _RevisionNumber As Byte
    Private _ShipDate As DateTime
    Private _ShipMethodID As Int32
    Private _Status As Byte
    Private _SubTotal As Decimal
    Private _TaxAmt As Decimal
    Private _TotalDue As Decimal
    Private _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Employee who created the purchase order. Foreign key to Employee.EmployeeID.", FieldName:="EmployeeID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=4, ParameterName:="EmployeeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="EmployeeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EmployeeID() As Int32
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Int32)
            _EmployeeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Shipping cost.", FieldName:="Freight", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=11, ParameterName:="Freight", Scale:=4, Size:=19, SourceColumn:="Freight", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Freight() As Decimal
        Get
            Return _Freight
        End Get
        Set(ByVal value As Decimal)
            _Freight = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=13, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Purchase order creation date.", FieldName:="OrderDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=7, ParameterName:="OrderDate", SourceColumn:="OrderDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property OrderDate() As DateTime
        Get
            Return _OrderDate
        End Get
        Set(ByVal value As DateTime)
            _OrderDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key.", FieldName:="PurchaseOrderID", ForeingCRUD:="ABM_PurchaseOrderHeader", ForeingTable:="PurchaseOrderHeader", MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=1, ParameterName:="PurchaseOrderID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="PurchaseOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntPurchaseOrderHeader", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property PurchaseOrderID() As Int32
        Get
            Return _PurchaseOrderID
        End Get
        Set(ByVal value As Int32)
            _PurchaseOrderID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, DefaultValue:="((0))", FieldDescription:="Incremental number to track changes to the purchase order over time. - Nonclustered index.", FieldName:="RevisionNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=2, ParameterName:="RevisionNumber", Size:=3, SourceColumn:="RevisionNumber", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property RevisionNumber() As Byte
        Get
            Return _RevisionNumber
        End Get
        Set(ByVal value As Byte)
            _RevisionNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Estimated shipment date from the vendor.", FieldName:="ShipDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=8, ParameterName:="ShipDate", SetNullable:=True, SourceColumn:="ShipDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShipDate() As DateTime
        Get
            Return _ShipDate
        End Get
        Set(ByVal value As DateTime)
            _ShipDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Shipping method. Foreign key to ShipMethod.ShipMethodID.", FieldName:="ShipMethodID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ShipMethod", ForeingTable:="ShipMethod", MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=6, ParameterName:="ShipMethodID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ShipMethodID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntShipMethod", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShipMethodID() As Int32
        Get
            Return _ShipMethodID
        End Get
        Set(ByVal value As Int32)
            _ShipMethodID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, DefaultValue:="((1))", FieldDescription:="Nonclustered index. - Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete", FieldName:="Status", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=3, ParameterName:="Status", Size:=3, SourceColumn:="Status", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Status() As Byte
        Get
            Return _Status
        End Get
        Set(ByVal value As Byte)
            _Status = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.", FieldName:="SubTotal", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=9, ParameterName:="SubTotal", Scale:=4, Size:=19, SourceColumn:="SubTotal", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SubTotal() As Decimal
        Get
            Return _SubTotal
        End Get
        Set(ByVal value As Decimal)
            _SubTotal = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Tax amount.", FieldName:="TaxAmt", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=10, ParameterName:="TaxAmt", Scale:=4, Size:=19, SourceColumn:="TaxAmt", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TaxAmt() As Decimal
        Get
            Return _TaxAmt
        End Get
        Set(ByVal value As Decimal)
            _TaxAmt = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Total due to vendor. Computed as Subtotal + TaxAmt + Freight.", FieldName:="TotalDue", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=12, ParameterName:="TotalDue", Scale:=4, Size:=19, SourceColumn:="TotalDue", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[PurchaseOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TotalDue() As Decimal
        Get
            Return _TotalDue
        End Get
        Set(ByVal value As Decimal)
            _TotalDue = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Vendor with whom the purchase order is placed. Foreign key to Vendor.VendorID.", FieldName:="VendorID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Vendor", ForeingTable:="Vendor", MainTable:="[Purchasing].[PurchaseOrderHeader]", Order:=5, ParameterName:="VendorID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="VendorID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntVendor", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property VendorID() As Int32
        Get
            Return _VendorID
        End Get
        Set(ByVal value As Int32)
            _VendorID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _EmployeeID = Nothing
        _Freight = 0.0
        _ModifiedDate = Now
        _OrderDate = Now
        _PurchaseOrderID = Nothing
        _RevisionNumber = 0
        _ShipDate = Nothing
        _ShipMethodID = Nothing
        _Status = 1
        _SubTotal = 0.0
        _TaxAmt = 0.0
        _TotalDue = Nothing
        _VendorID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ShipMethodID", PrimaryKeyFieldName:="ShipMethodID", RootContainerName:="[Purchasing].[ShipMethod]", EnabledPropertyName:="ShipMethodID", PrimaryKeyPropertyName:="ShipMethodID")> _
Public Class EntPurchasing_ShipMethod

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _Rowguid As Guid
    Private _ShipBase As Decimal
    Private _ShipMethodID As Int32
    Private _ShipRate As Decimal
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ShipMethod]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[ShipMethod]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Shipping company name. - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ShipMethod]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Purchasing].[ShipMethod]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ShipMethod]", Order:=5, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Purchasing].[ShipMethod]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Unique nonclustered index. Used to support replication samples. - Minimum shipping charge.", FieldName:="ShipBase", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ShipMethod]", Order:=3, ParameterName:="ShipBase", Scale:=4, Size:=19, SourceColumn:="ShipBase", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[ShipMethod]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShipBase() As Decimal
        Get
            Return _ShipBase
        End Get
        Set(ByVal value As Decimal)
            _ShipBase = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for ShipMethod records. - Clustered index created by a primary key constraint.", FieldName:="ShipMethodID", ForeingCRUD:="ABM_ShipMethod", ForeingTable:="ShipMethod", MainTable:="[Purchasing].[ShipMethod]", Order:=1, ParameterName:="ShipMethodID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ShipMethodID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntShipMethod", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ShipMethodID() As Int32
        Get
            Return _ShipMethodID
        End Get
        Set(ByVal value As Int32)
            _ShipMethodID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Shipping charge per pound.", FieldName:="ShipRate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[ShipMethod]", Order:=4, ParameterName:="ShipRate", Scale:=4, Size:=19, SourceColumn:="ShipRate", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Purchasing].[ShipMethod]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShipRate() As Decimal
        Get
            Return _ShipRate
        End Get
        Set(ByVal value As Decimal)
            _ShipRate = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Name = Nothing
        _Rowguid = newid
        _ShipBase = 0.0
        _ShipMethodID = Nothing
        _ShipRate = 0.0
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID", PrimaryKeyFieldName:="VendorID", RootContainerName:="[Purchasing].[Vendor]", EnabledPropertyName:="VendorID", PrimaryKeyPropertyName:="VendorID")> _
Public Class EntPurchasing_Vendor

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AccountNumber As String
    Private _ActiveFlag As Boolean
    Private _CreditRating As Byte
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _PreferredVendorStatus As Boolean
    Private _PurchasingWebServiceURL As String
    Private _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Vendor account (identification) number.", FieldName:="AccountNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[Vendor]", Order:=2, ParameterName:="AccountNumber", Size:=15, SourceColumn:="AccountNumber", TypeName:="String", MaxValue:=15, EntityClassContainer:="Ent[Purchasing].[Vendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AccountNumber() As String
        Get
            Return _AccountNumber
        End Get
        Set(ByVal value As String)
            _AccountNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="0 = Vendor no longer used. 1 = Vendor is actively used.", FieldName:="ActiveFlag", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[Vendor]", Order:=6, ParameterName:="ActiveFlag", SourceColumn:="ActiveFlag", TypeName:="Boolean", EntityClassContainer:="Ent[Purchasing].[Vendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ActiveFlag() As Boolean
        Get
            Return _ActiveFlag
        End Get
        Set(ByVal value As Boolean)
            _ActiveFlag = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average", FieldName:="CreditRating", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[Vendor]", Order:=4, ParameterName:="CreditRating", Size:=3, SourceColumn:="CreditRating", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Purchasing].[Vendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CreditRating() As Byte
        Get
            Return _CreditRating
        End Get
        Set(ByVal value As Byte)
            _CreditRating = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[Vendor]", Order:=8, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[Vendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Company name.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[Vendor]", Order:=3, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Purchasing].[Vendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.", FieldName:="PreferredVendorStatus", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[Vendor]", Order:=5, ParameterName:="PreferredVendorStatus", SourceColumn:="PreferredVendorStatus", TypeName:="Boolean", EntityClassContainer:="Ent[Purchasing].[Vendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PreferredVendorStatus() As Boolean
        Get
            Return _PreferredVendorStatus
        End Get
        Set(ByVal value As Boolean)
            _PreferredVendorStatus = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Vendor URL.", FieldName:="PurchasingWebServiceURL", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[Vendor]", Order:=7, ParameterName:="PurchasingWebServiceURL", SetNullable:=True, Size:=1024, SourceColumn:="PurchasingWebServiceURL", TypeName:="String", MaxValue:=1024, EntityClassContainer:="Ent[Purchasing].[Vendor]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PurchasingWebServiceURL() As String
        Get
            Return _PurchasingWebServiceURL
        End Get
        Set(ByVal value As String)
            _PurchasingWebServiceURL = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for Vendor records.", FieldName:="VendorID", ForeingCRUD:="ABM_Vendor", ForeingTable:="Vendor", MainTable:="[Purchasing].[Vendor]", Order:=1, ParameterName:="VendorID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="VendorID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntVendor", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property VendorID() As Int32
        Get
            Return _VendorID
        End Get
        Set(ByVal value As Int32)
            _VendorID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _AccountNumber = Nothing
        _ActiveFlag = 1
        _CreditRating = Nothing
        _ModifiedDate = Now
        _Name = Nothing
        _PreferredVendorStatus = 1
        _PurchasingWebServiceURL = Nothing
        _VendorID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID", PrimaryKeyFieldName:="VendorID", RootContainerName:="[Purchasing].[VendorAddress]", EnabledPropertyName:="VendorID", PrimaryKeyPropertyName:="VendorID")> _
Public Class EntPurchasing_VendorAddress

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AddressID As Int32
    Private _AddressTypeID As Int32
    Private _ModifiedDate As DateTime
    Private _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to Address.AddressID. - Nonclustered index.", FieldName:="AddressID", ForeingCRUD:="ABM_Address", ForeingTable:="Address", MainTable:="[Purchasing].[VendorAddress]", Order:=2, ParameterName:="AddressID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="AddressID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddress", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property AddressID() As Int32
        Get
            Return _AddressID
        End Get
        Set(ByVal value As Int32)
            _AddressID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Address type. Foreign key to AddressType.AddressTypeID.", FieldName:="AddressTypeID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_AddressType", ForeingTable:="AddressType", MainTable:="[Purchasing].[VendorAddress]", Order:=3, ParameterName:="AddressTypeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="AddressTypeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddressType", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AddressTypeID() As Int32
        Get
            Return _AddressTypeID
        End Get
        Set(ByVal value As Int32)
            _AddressTypeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[VendorAddress]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[VendorAddress]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to Vendor.VendorID. - Clustered index created by a primary key constraint.", FieldName:="VendorID", ForeingCRUD:="ABM_Vendor", ForeingTable:="Vendor", MainTable:="[Purchasing].[VendorAddress]", Order:=1, ParameterName:="VendorID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="VendorID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntVendor", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property VendorID() As Int32
        Get
            Return _VendorID
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
        _ModifiedDate = Now
        _VendorID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="VendorID", PrimaryKeyFieldName:="VendorID", RootContainerName:="[Purchasing].[VendorContact]", EnabledPropertyName:="VendorID", PrimaryKeyPropertyName:="VendorID")> _
Public Class EntPurchasing_VendorContact

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ContactID As Int32
    Private _ContactTypeID As Int32
    Private _ModifiedDate As DateTime
    Private _VendorID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Contact (Vendor employee) identification number. Foreign key to Contact.ContactID. - Nonclustered index.", FieldName:="ContactID", ForeingCRUD:="ABM_Contact", ForeingTable:="Contact", MainTable:="[Purchasing].[VendorContact]", Order:=2, ParameterName:="ContactID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContact", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ContactID() As Int32
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Int32)
            _ContactID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Nonclustered index. - Contact type such as sales manager, or sales agent.", FieldName:="ContactTypeID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ContactType", ForeingTable:="ContactType", MainTable:="[Purchasing].[VendorContact]", Order:=3, ParameterName:="ContactTypeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactTypeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContactType", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ContactTypeID() As Int32
        Get
            Return _ContactTypeID
        End Get
        Set(ByVal value As Int32)
            _ContactTypeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Purchasing].[VendorContact]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Purchasing].[VendorContact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. - Clustered index created by a primary key constraint.", FieldName:="VendorID", ForeingCRUD:="ABM_Vendor", ForeingTable:="Vendor", MainTable:="[Purchasing].[VendorContact]", Order:=1, ParameterName:="VendorID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="VendorID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntVendor", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property VendorID() As Int32
        Get
            Return _VendorID
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
        _ModifiedDate = Now
        _VendorID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CreditCardID", PrimaryKeyFieldName:="CreditCardID", RootContainerName:="[Sales].[ContactCreditCard]", EnabledPropertyName:="CreditCardID", PrimaryKeyPropertyName:="CreditCardID")> _
Public Class EntSales_ContactCreditCard

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ContactID As Int32
    Private _CreditCardID As Int32
    Private _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Customer identification number. Foreign key to Contact.ContactID.", FieldName:="ContactID", ForeingCRUD:="ABM_Contact", ForeingTable:="Contact", MainTable:="[Sales].[ContactCreditCard]", Order:=1, ParameterName:="ContactID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContact", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ContactID() As Int32
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Int32)
            _ContactID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Credit card identification number. Foreign key to CreditCard.CreditCardID.", FieldName:="CreditCardID", ForeingCRUD:="ABM_CreditCard", ForeingTable:="CreditCard", MainTable:="[Sales].[ContactCreditCard]", Order:=2, ParameterName:="CreditCardID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CreditCardID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntCreditCard", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CreditCardID() As Int32
        Get
            Return _CreditCardID
        End Get
        Set(ByVal value As Int32)
            _CreditCardID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[ContactCreditCard]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[ContactCreditCard]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
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
        _ModifiedDate = Now
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CurrencyCode", PrimaryKeyFieldName:="CurrencyCode", RootContainerName:="[Sales].[CountryRegionCurrency]", EnabledPropertyName:="CurrencyCode", PrimaryKeyPropertyName:="CurrencyCode")> _
Public Class EntSales_CountryRegionCurrency

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CountryRegionCode As String
    Private _CurrencyCode As String
    Private _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Clustered index created by a primary key constraint. - ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.", FieldName:="CountryRegionCode", ForeingCRUD:="ABM_CountryRegion", ForeingTable:="CountryRegion", MainTable:="[Sales].[CountryRegionCurrency]", Order:=1, ParameterName:="CountryRegionCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="CountryRegionCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCountryRegion", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CountryRegionCode() As String
        Get
            Return _CountryRegionCode
        End Get
        Set(ByVal value As String)
            _CountryRegionCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="ISO standard currency code. Foreign key to Currency.CurrencyCode. - Nonclustered index.", FieldName:="CurrencyCode", ForeingCRUD:="ABM_Currency", ForeingTable:="Currency", MainTable:="[Sales].[CountryRegionCurrency]", Order:=2, ParameterName:="CurrencyCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="CurrencyCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCurrency", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CurrencyCode() As String
        Get
            Return _CurrencyCode
        End Get
        Set(ByVal value As String)
            _CurrencyCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CountryRegionCurrency]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[CountryRegionCurrency]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
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
        _ModifiedDate = Now
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CreditCardID", PrimaryKeyFieldName:="CreditCardID", RootContainerName:="[Sales].[CreditCard]", EnabledPropertyName:="CreditCardID", PrimaryKeyPropertyName:="CreditCardID")> _
Public Class EntSales_CreditCard

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CardNumber As String
    Private _CardType As String
    Private _CreditCardID As Int32
    Private _ExpMonth As Byte
    Private _ExpYear As Int16
    Private _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Credit card number.", FieldName:="CardNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CreditCard]", Order:=3, ParameterName:="CardNumber", Size:=25, SourceColumn:="CardNumber", TypeName:="String", MaxValue:=25, EntityClassContainer:="Ent[Sales].[CreditCard]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CardNumber() As String
        Get
            Return _CardNumber
        End Get
        Set(ByVal value As String)
            _CardNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Credit card name.", FieldName:="CardType", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CreditCard]", Order:=2, ParameterName:="CardType", Size:=50, SourceColumn:="CardType", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[CreditCard]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CardType() As String
        Get
            Return _CardType
        End Get
        Set(ByVal value As String)
            _CardType = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for CreditCard records. - Clustered index created by a primary key constraint.", FieldName:="CreditCardID", ForeingCRUD:="ABM_CreditCard", ForeingTable:="CreditCard", MainTable:="[Sales].[CreditCard]", Order:=1, ParameterName:="CreditCardID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CreditCardID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntCreditCard", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CreditCardID() As Int32
        Get
            Return _CreditCardID
        End Get
        Set(ByVal value As Int32)
            _CreditCardID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="Credit card expiration month.", FieldName:="ExpMonth", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CreditCard]", Order:=4, ParameterName:="ExpMonth", Size:=3, SourceColumn:="ExpMonth", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Sales].[CreditCard]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ExpMonth() As Byte
        Get
            Return _ExpMonth
        End Get
        Set(ByVal value As Byte)
            _ExpMonth = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Credit card expiration year.", FieldName:="ExpYear", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CreditCard]", Order:=5, ParameterName:="ExpYear", Size:=5, SourceColumn:="ExpYear", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Sales].[CreditCard]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ExpYear() As Int16
        Get
            Return _ExpYear
        End Get
        Set(ByVal value As Int16)
            _ExpYear = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CreditCard]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[CreditCard]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
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
        _ModifiedDate = Now
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CurrencyCode", PrimaryKeyFieldName:="CurrencyCode", RootContainerName:="[Sales].[Currency]", EnabledPropertyName:="CurrencyCode", PrimaryKeyPropertyName:="CurrencyCode")> _
Public Class EntSales_Currency

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CurrencyCode As String
    Private _ModifiedDate As DateTime
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
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
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
        _ModifiedDate = Now
        _Name = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CurrencyRateID", PrimaryKeyFieldName:="CurrencyRateID", RootContainerName:="[Sales].[CurrencyRate]", EnabledPropertyName:="CurrencyRateID", PrimaryKeyPropertyName:="CurrencyRateID")> _
Public Class EntSales_CurrencyRate

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AverageRate As Decimal
    Private _CurrencyRateDate As DateTime
    Private _CurrencyRateID As Int32
    Private _EndOfDayRate As Decimal
    Private _FromCurrencyCode As String
    Private _ModifiedDate As DateTime
    Private _ToCurrencyCode As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Average exchange rate for the day.", FieldName:="AverageRate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CurrencyRate]", Order:=5, ParameterName:="AverageRate", Scale:=4, Size:=19, SourceColumn:="AverageRate", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[CurrencyRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AverageRate() As Decimal
        Get
            Return _AverageRate
        End Get
        Set(ByVal value As Decimal)
            _AverageRate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date and time the exchange rate was obtained. - Unique nonclustered index.", FieldName:="CurrencyRateDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CurrencyRate]", Order:=2, ParameterName:="CurrencyRateDate", SourceColumn:="CurrencyRateDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[CurrencyRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CurrencyRateDate() As DateTime
        Get
            Return _CurrencyRateDate
        End Get
        Set(ByVal value As DateTime)
            _CurrencyRateDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for CurrencyRate records.", FieldName:="CurrencyRateID", ForeingCRUD:="ABM_CurrencyRate", ForeingTable:="CurrencyRate", MainTable:="[Sales].[CurrencyRate]", Order:=1, ParameterName:="CurrencyRateID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CurrencyRateID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntCurrencyRate", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CurrencyRateID() As Int32
        Get
            Return _CurrencyRateID
        End Get
        Set(ByVal value As Int32)
            _CurrencyRateID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Final exchange rate for the day.", FieldName:="EndOfDayRate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CurrencyRate]", Order:=6, ParameterName:="EndOfDayRate", Scale:=4, Size:=19, SourceColumn:="EndOfDayRate", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[CurrencyRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndOfDayRate() As Decimal
        Get
            Return _EndOfDayRate
        End Get
        Set(ByVal value As Decimal)
            _EndOfDayRate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Exchange rate was converted from this currency code.", FieldName:="FromCurrencyCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Currency", ForeingTable:="Currency", MainTable:="[Sales].[CurrencyRate]", Order:=3, ParameterName:="FromCurrencyCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="FromCurrencyCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCurrency", IsDescription:=False, ForeingFieldName:="FromCurrencyCode", IsDefaultOrderBy:=False)> _
     Public Property FromCurrencyCode() As String
        Get
            Return _FromCurrencyCode
        End Get
        Set(ByVal value As String)
            _FromCurrencyCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CurrencyRate]", Order:=7, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[CurrencyRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Exchange rate was converted to this currency code.", FieldName:="ToCurrencyCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Currency", ForeingTable:="Currency", MainTable:="[Sales].[CurrencyRate]", Order:=4, ParameterName:="ToCurrencyCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="ToCurrencyCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCurrency", IsDescription:=False, ForeingFieldName:="ToCurrencyCode", IsDefaultOrderBy:=False)> _
     Public Property ToCurrencyCode() As String
        Get
            Return _ToCurrencyCode
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
        _ModifiedDate = Now
        _ToCurrencyCode = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID", PrimaryKeyFieldName:="CustomerID", RootContainerName:="[Sales].[Customer]", EnabledPropertyName:="CustomerID", PrimaryKeyPropertyName:="CustomerID")> _
Public Class EntSales_Customer

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AccountNumber As String
    Private _CustomerID As Int32
    Private _CustomerType As String
    Private _ModifiedDate As DateTime
    Private _Rowguid As Guid
    Private _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. - Unique number identifying the customer assigned by the accounting system.", FieldName:="AccountNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Customer]", Order:=3, ParameterName:="AccountNumber", Size:=10, SourceColumn:="AccountNumber", TypeName:="String", MaxValue:=10, EntityClassContainer:="Ent[Sales].[Customer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AccountNumber() As String
        Get
            Return _AccountNumber
        End Get
        Set(ByVal value As String)
            _AccountNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for Customer records. - Clustered index created by a primary key constraint.", FieldName:="CustomerID", ForeingCRUD:="ABM_Store", ForeingTable:="Store", MainTable:="[Sales].[Customer]", Order:=1, ParameterName:="CustomerID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CustomerID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStore", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CustomerID() As Int32
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int32)
            _CustomerID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Customer type: I = Individual, S = Store", FieldName:="CustomerType", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Customer]", Order:=4, ParameterName:="CustomerType", Size:=1, SourceColumn:="CustomerType", TypeName:="String", MaxValue:=1, EntityClassContainer:="Ent[Sales].[Customer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CustomerType() As String
        Get
            Return _CustomerType
        End Get
        Set(ByVal value As String)
            _CustomerType = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Customer]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[Customer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="Nonclustered index. - ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Customer]", Order:=5, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[Customer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID. - Unique nonclustered index. Used to support replication samples.", FieldName:="TerritoryID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SalesTerritory", ForeingTable:="SalesTerritory", MainTable:="[Sales].[Customer]", Order:=2, ParameterName:="TerritoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="TerritoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesTerritory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TerritoryID() As Int32
        Get
            Return _TerritoryID
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
        _ModifiedDate = Now
        _Rowguid = newid
        _TerritoryID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID", PrimaryKeyFieldName:="CustomerID", RootContainerName:="[Sales].[CustomerAddress]", EnabledPropertyName:="CustomerID", PrimaryKeyPropertyName:="CustomerID")> _
Public Class EntSales_CustomerAddress

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AddressID As Int32
    Private _AddressTypeID As Int32
    Private _CustomerID As Int32
    Private _ModifiedDate As DateTime
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Primary key. Foreign key to Address.AddressID.", FieldName:="AddressID", ForeingCRUD:="ABM_Address", ForeingTable:="Address", MainTable:="[Sales].[CustomerAddress]", Order:=2, ParameterName:="AddressID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="AddressID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddress", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property AddressID() As Int32
        Get
            Return _AddressID
        End Get
        Set(ByVal value As Int32)
            _AddressID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Address type. Foreign key to AddressType.AddressTypeID.", FieldName:="AddressTypeID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_AddressType", ForeingTable:="AddressType", MainTable:="[Sales].[CustomerAddress]", Order:=3, ParameterName:="AddressTypeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="AddressTypeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddressType", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AddressTypeID() As Int32
        Get
            Return _AddressTypeID
        End Get
        Set(ByVal value As Int32)
            _AddressTypeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key. Foreign key to Customer.CustomerID.", FieldName:="CustomerID", ForeingCRUD:="ABM_Store", ForeingTable:="Store", MainTable:="[Sales].[CustomerAddress]", Order:=1, ParameterName:="CustomerID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CustomerID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStore", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CustomerID() As Int32
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int32)
            _CustomerID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CustomerAddress]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[CustomerAddress]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[CustomerAddress]", Order:=4, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[CustomerAddress]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
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
        _ModifiedDate = Now
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID", PrimaryKeyFieldName:="CustomerID", RootContainerName:="[Sales].[Individual]", EnabledPropertyName:="CustomerID", PrimaryKeyPropertyName:="CustomerID")> _
Public Class EntSales_Individual

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ContactID As Int32
    Private _CustomerID As Int32
    Private _Demographics As String
    Private _ModifiedDate As DateTime
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Identifies the customer in the Contact table. Foreign key to Contact.ContactID.", FieldName:="ContactID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Contact", ForeingTable:="Contact", MainTable:="[Sales].[Individual]", Order:=2, ParameterName:="ContactID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContact", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ContactID() As Int32
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Int32)
            _ContactID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Unique customer identification number. Foreign key to Customer.CustomerID.", FieldName:="CustomerID", ForeingCRUD:="ABM_Store", ForeingTable:="Store", MainTable:="[Sales].[Individual]", Order:=1, ParameterName:="CustomerID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CustomerID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStore", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CustomerID() As Int32
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int32)
            _CustomerID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.", FieldName:="Demographics", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Individual]", Order:=3, ParameterName:="Demographics", SetNullable:=True, Size:=-1, SourceColumn:="Demographics", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[Sales].[Individual]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Demographics() As String
        Get
            Return _Demographics
        End Get
        Set(ByVal value As String)
            _Demographics = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Individual]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[Individual]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
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
        _ModifiedDate = Now
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesOrderID", PrimaryKeyFieldName:="SalesOrderID", RootContainerName:="[Sales].[SalesOrderDetail]", EnabledPropertyName:="SalesOrderID", PrimaryKeyPropertyName:="SalesOrderID")> _
Public Class EntSales_SalesOrderDetail

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CarrierTrackingNumber As String
    Private _LineTotal As Decimal
    Private _ModifiedDate As DateTime
    Private _OrderQty As Int16
    Private _ProductID As Int32
    Private _Rowguid As Guid
    Private _SalesOrderDetailID As Int32
    Private _SalesOrderID As Int32
    Private _SpecialOfferID As Int32
    Private _UnitPrice As Decimal
    Private _UnitPriceDiscount As Decimal
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Nonclustered index. - Shipment tracking number supplied by the shipper.", FieldName:="CarrierTrackingNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderDetail]", Order:=3, ParameterName:="CarrierTrackingNumber", SetNullable:=True, Size:=25, SourceColumn:="CarrierTrackingNumber", TypeName:="String", MaxValue:=25, EntityClassContainer:="Ent[Sales].[SalesOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CarrierTrackingNumber() As String
        Get
            Return _CarrierTrackingNumber
        End Get
        Set(ByVal value As String)
            _CarrierTrackingNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.", FieldName:="LineTotal", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderDetail]", Order:=9, ParameterName:="LineTotal", Scale:=6, Size:=38, SourceColumn:="LineTotal", TypeName:="Decimal", MaxValue:=38, EntityClassContainer:="Ent[Sales].[SalesOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property LineTotal() As Decimal
        Get
            Return _LineTotal
        End Get
        Set(ByVal value As Decimal)
            _LineTotal = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderDetail]", Order:=11, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int16, FieldDescription:="Quantity ordered per product.", FieldName:="OrderQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderDetail]", Order:=4, ParameterName:="OrderQty", Size:=5, SourceColumn:="OrderQty", TypeName:="Int16", MaxValue:=5, EntityClassContainer:="Ent[Sales].[SalesOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property OrderQty() As Int16
        Get
            Return _OrderQty
        End Get
        Set(ByVal value As Int16)
            _OrderQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product sold to customer. Foreign key to Product.ProductID.", FieldName:="ProductID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SpecialOfferProduct", ForeingTable:="SpecialOfferProduct", MainTable:="[Sales].[SalesOrderDetail]", Order:=5, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSpecialOfferProduct", IsDescription:=False, ForeingFieldName:="ProductID", IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderDetail]", Order:=10, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SalesOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Primary key. One incremental unique number per product sold.", FieldName:="SalesOrderDetailID", ForeingCRUD:="ABM_SalesOrderDetail", ForeingTable:="SalesOrderDetail", MainTable:="[Sales].[SalesOrderDetail]", Order:=2, ParameterName:="SalesOrderDetailID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesOrderDetailID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesOrderDetail", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SalesOrderDetailID() As Int32
        Get
            Return _SalesOrderDetailID
        End Get
        Set(ByVal value As Int32)
            _SalesOrderDetailID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to SalesOrderHeader.SalesOrderID. - Clustered index created by a primary key constraint.", FieldName:="SalesOrderID", ForeingCRUD:="ABM_SalesOrderHeader", ForeingTable:="SalesOrderHeader", MainTable:="[Sales].[SalesOrderDetail]", Order:=1, ParameterName:="SalesOrderID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesOrderHeader", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesOrderID() As Int32
        Get
            Return _SalesOrderID
        End Get
        Set(ByVal value As Int32)
            _SalesOrderID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Promotional code. Foreign key to SpecialOffer.SpecialOfferID.", FieldName:="SpecialOfferID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SpecialOfferProduct", ForeingTable:="SpecialOfferProduct", MainTable:="[Sales].[SalesOrderDetail]", Order:=6, ParameterName:="SpecialOfferID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SpecialOfferID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSpecialOfferProduct", IsDescription:=False, ForeingFieldName:="SpecialOfferID", IsDefaultOrderBy:=False)> _
     Public Property SpecialOfferID() As Int32
        Get
            Return _SpecialOfferID
        End Get
        Set(ByVal value As Int32)
            _SpecialOfferID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Selling price of a single product.", FieldName:="UnitPrice", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderDetail]", Order:=7, ParameterName:="UnitPrice", Scale:=4, Size:=19, SourceColumn:="UnitPrice", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property UnitPrice() As Decimal
        Get
            Return _UnitPrice
        End Get
        Set(ByVal value As Decimal)
            _UnitPrice = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.0))", FieldDescription:="Discount amount.", FieldName:="UnitPriceDiscount", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderDetail]", Order:=8, ParameterName:="UnitPriceDiscount", Scale:=4, Size:=19, SourceColumn:="UnitPriceDiscount", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesOrderDetail]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property UnitPriceDiscount() As Decimal
        Get
            Return _UnitPriceDiscount
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
        _ModifiedDate = Now
        _OrderQty = Nothing
        _ProductID = Nothing
        _Rowguid = newid
        _SalesOrderDetailID = Nothing
        _SalesOrderID = Nothing
        _SpecialOfferID = Nothing
        _UnitPrice = Nothing
        _UnitPriceDiscount = 0.0
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesOrderID", PrimaryKeyFieldName:="SalesOrderID", RootContainerName:="[Sales].[SalesOrderHeader]", EnabledPropertyName:="SalesOrderID", PrimaryKeyPropertyName:="SalesOrderID")> _
Public Class EntSales_SalesOrderHeader

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _AccountNumber As String
    Private _BillToAddressID As Int32
    Private _Comment As String
    Private _ContactID As Int32
    Private _CreditCardApprovalCode As String
    Private _CreditCardID As Int32
    Private _CurrencyRateID As Int32
    Private _CustomerID As Int32
    Private _DueDate As DateTime
    Private _Freight As Decimal
    Private _ModifiedDate As DateTime
    Private _OnlineOrderFlag As Boolean
    Private _OrderDate As DateTime
    Private _PurchaseOrderNumber As String
    Private _RevisionNumber As Byte
    Private _Rowguid As Guid
    Private _SalesOrderID As Int32
    Private _SalesOrderNumber As String
    Private _SalesPersonID As Int32
    Private _ShipDate As DateTime
    Private _ShipMethodID As Int32
    Private _ShipToAddressID As Int32
    Private _Status As Byte
    Private _SubTotal As Decimal
    Private _TaxAmt As Decimal
    Private _TerritoryID As Int32
    Private _TotalDue As Decimal
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Financial accounting number reference.", FieldName:="AccountNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=10, ParameterName:="AccountNumber", SetNullable:=True, Size:=15, SourceColumn:="AccountNumber", TypeName:="String", MaxValue:=15, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property AccountNumber() As String
        Get
            Return _AccountNumber
        End Get
        Set(ByVal value As String)
            _AccountNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Customer billing address. Foreign key to Address.AddressID.", FieldName:="BillToAddressID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Address", ForeingTable:="Address", MainTable:="[Sales].[SalesOrderHeader]", Order:=15, ParameterName:="BillToAddressID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="BillToAddressID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddress", IsDescription:=False, ForeingFieldName:="BillToAddressID", IsDefaultOrderBy:=False)> _
     Public Property BillToAddressID() As Int32
        Get
            Return _BillToAddressID
        End Get
        Set(ByVal value As Int32)
            _BillToAddressID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Sales representative comments.", FieldName:="Comment", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=25, ParameterName:="Comment", SetNullable:=True, Size:=128, SourceColumn:="Comment", TypeName:="String", MaxValue:=128, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Comment() As String
        Get
            Return _Comment
        End Get
        Set(ByVal value As String)
            _Comment = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Customer contact identification number. Foreign key to Contact.ContactID.", FieldName:="ContactID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Contact", ForeingTable:="Contact", MainTable:="[Sales].[SalesOrderHeader]", Order:=12, ParameterName:="ContactID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContact", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ContactID() As Int32
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Int32)
            _ContactID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Approval code provided by the credit card company.", FieldName:="CreditCardApprovalCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=19, ParameterName:="CreditCardApprovalCode", SetNullable:=True, Size:=15, SourceColumn:="CreditCardApprovalCode", TypeName:="String", MaxValue:=15, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CreditCardApprovalCode() As String
        Get
            Return _CreditCardApprovalCode
        End Get
        Set(ByVal value As String)
            _CreditCardApprovalCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Credit card identification number. Foreign key to CreditCard.CreditCardID.", FieldName:="CreditCardID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_CreditCard", ForeingTable:="CreditCard", MainTable:="[Sales].[SalesOrderHeader]", Order:=18, ParameterName:="CreditCardID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="CreditCardID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntCreditCard", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CreditCardID() As Int32
        Get
            Return _CreditCardID
        End Get
        Set(ByVal value As Int32)
            _CreditCardID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.", FieldName:="CurrencyRateID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_CurrencyRate", ForeingTable:="CurrencyRate", MainTable:="[Sales].[SalesOrderHeader]", Order:=20, ParameterName:="CurrencyRateID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="CurrencyRateID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntCurrencyRate", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CurrencyRateID() As Int32
        Get
            Return _CurrencyRateID
        End Get
        Set(ByVal value As Int32)
            _CurrencyRateID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Customer identification number. Foreign key to Customer.CustomerID.", FieldName:="CustomerID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Store", ForeingTable:="Store", MainTable:="[Sales].[SalesOrderHeader]", Order:=11, ParameterName:="CustomerID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CustomerID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStore", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CustomerID() As Int32
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int32)
            _CustomerID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the order is due to the customer.", FieldName:="DueDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=4, ParameterName:="DueDate", SourceColumn:="DueDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DueDate() As DateTime
        Get
            Return _DueDate
        End Get
        Set(ByVal value As DateTime)
            _DueDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Shipping cost.", FieldName:="Freight", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=23, ParameterName:="Freight", Scale:=4, Size:=19, SourceColumn:="Freight", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Freight() As Decimal
        Get
            Return _Freight
        End Get
        Set(ByVal value As Decimal)
            _Freight = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=27, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Boolean, DefaultValue:="((1))", FieldDescription:="0 = Order placed by sales person. 1 = Order placed online by customer.", FieldName:="OnlineOrderFlag", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=7, ParameterName:="OnlineOrderFlag", SourceColumn:="OnlineOrderFlag", TypeName:="Boolean", EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property OnlineOrderFlag() As Boolean
        Get
            Return _OnlineOrderFlag
        End Get
        Set(ByVal value As Boolean)
            _OnlineOrderFlag = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Unique nonclustered index. - Dates the sales order was created.", FieldName:="OrderDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=3, ParameterName:="OrderDate", SourceColumn:="OrderDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property OrderDate() As DateTime
        Get
            Return _OrderDate
        End Get
        Set(ByVal value As DateTime)
            _OrderDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Customer purchase order number reference. ", FieldName:="PurchaseOrderNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=9, ParameterName:="PurchaseOrderNumber", SetNullable:=True, Size:=25, SourceColumn:="PurchaseOrderNumber", TypeName:="String", MaxValue:=25, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property PurchaseOrderNumber() As String
        Get
            Return _PurchaseOrderNumber
        End Get
        Set(ByVal value As String)
            _PurchaseOrderNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, DefaultValue:="((0))", FieldDescription:="Unique nonclustered index. Used to support replication samples. - Incremental number to track changes to the sales order over time.", FieldName:="RevisionNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=2, ParameterName:="RevisionNumber", Size:=3, SourceColumn:="RevisionNumber", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property RevisionNumber() As Byte
        Get
            Return _RevisionNumber
        End Get
        Set(ByVal value As Byte)
            _RevisionNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=26, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. - Clustered index created by a primary key constraint.", FieldName:="SalesOrderID", ForeingCRUD:="ABM_SalesOrderHeader", ForeingTable:="SalesOrderHeader", MainTable:="[Sales].[SalesOrderHeader]", Order:=1, ParameterName:="SalesOrderID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesOrderHeader", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SalesOrderID() As Int32
        Get
            Return _SalesOrderID
        End Get
        Set(ByVal value As Int32)
            _SalesOrderID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique sales order identification number.", FieldName:="SalesOrderNumber", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=8, ParameterName:="SalesOrderNumber", Size:=25, SourceColumn:="SalesOrderNumber", TypeName:="String", MaxValue:=25, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesOrderNumber() As String
        Get
            Return _SalesOrderNumber
        End Get
        Set(ByVal value As String)
            _SalesOrderNumber = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Sales person who created the sales order. Foreign key to SalesPerson.SalePersonID.", FieldName:="SalesPersonID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SalesPerson", ForeingTable:="SalesPerson", MainTable:="[Sales].[SalesOrderHeader]", Order:=13, ParameterName:="SalesPersonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="SalesPersonID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesPerson", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesPersonID() As Int32
        Get
            Return _SalesPersonID
        End Get
        Set(ByVal value As Int32)
            _SalesPersonID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Nonclustered index. - Date the order was shipped to the customer.", FieldName:="ShipDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=5, ParameterName:="ShipDate", SetNullable:=True, SourceColumn:="ShipDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShipDate() As DateTime
        Get
            Return _ShipDate
        End Get
        Set(ByVal value As DateTime)
            _ShipDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Shipping method. Foreign key to ShipMethod.ShipMethodID.", FieldName:="ShipMethodID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ShipMethod", ForeingTable:="ShipMethod", MainTable:="[Sales].[SalesOrderHeader]", Order:=17, ParameterName:="ShipMethodID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ShipMethodID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntShipMethod", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShipMethodID() As Int32
        Get
            Return _ShipMethodID
        End Get
        Set(ByVal value As Int32)
            _ShipMethodID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Customer shipping address. Foreign key to Address.AddressID.", FieldName:="ShipToAddressID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Address", ForeingTable:="Address", MainTable:="[Sales].[SalesOrderHeader]", Order:=16, ParameterName:="ShipToAddressID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ShipToAddressID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntAddress", IsDescription:=False, ForeingFieldName:="ShipToAddressID", IsDefaultOrderBy:=False)> _
     Public Property ShipToAddressID() As Int32
        Get
            Return _ShipToAddressID
        End Get
        Set(ByVal value As Int32)
            _ShipToAddressID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, DefaultValue:="((1))", FieldDescription:="Nonclustered index. - Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled", FieldName:="Status", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=6, ParameterName:="Status", Size:=3, SourceColumn:="Status", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Status() As Byte
        Get
            Return _Status
        End Get
        Set(ByVal value As Byte)
            _Status = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.", FieldName:="SubTotal", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=21, ParameterName:="SubTotal", Scale:=4, Size:=19, SourceColumn:="SubTotal", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SubTotal() As Decimal
        Get
            Return _SubTotal
        End Get
        Set(ByVal value As Decimal)
            _SubTotal = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Tax amount.", FieldName:="TaxAmt", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=22, ParameterName:="TaxAmt", Scale:=4, Size:=19, SourceColumn:="TaxAmt", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TaxAmt() As Decimal
        Get
            Return _TaxAmt
        End Get
        Set(ByVal value As Decimal)
            _TaxAmt = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.", FieldName:="TerritoryID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SalesTerritory", ForeingTable:="SalesTerritory", MainTable:="[Sales].[SalesOrderHeader]", Order:=14, ParameterName:="TerritoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="TerritoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesTerritory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TerritoryID() As Int32
        Get
            Return _TerritoryID
        End Get
        Set(ByVal value As Int32)
            _TerritoryID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Total due from customer. Computed as Subtotal + TaxAmt + Freight.", FieldName:="TotalDue", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeader]", Order:=24, ParameterName:="TotalDue", Scale:=4, Size:=19, SourceColumn:="TotalDue", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesOrderHeader]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TotalDue() As Decimal
        Get
            Return _TotalDue
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
        _Freight = 0.0
        _ModifiedDate = Now
        _OnlineOrderFlag = 1
        _OrderDate = Now
        _PurchaseOrderNumber = Nothing
        _RevisionNumber = 0
        _Rowguid = newid
        _SalesOrderID = Nothing
        _SalesOrderNumber = Nothing
        _SalesPersonID = Nothing
        _ShipDate = Nothing
        _ShipMethodID = Nothing
        _ShipToAddressID = Nothing
        _Status = 1
        _SubTotal = 0.0
        _TaxAmt = 0.0
        _TerritoryID = Nothing
        _TotalDue = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesReasonID", PrimaryKeyFieldName:="SalesReasonID", RootContainerName:="[Sales].[SalesOrderHeaderSalesReason]", EnabledPropertyName:="SalesReasonID", PrimaryKeyPropertyName:="SalesReasonID")> _
Public Class EntSales_SalesOrderHeaderSalesReason

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _SalesOrderID As Int32
    Private _SalesReasonID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesOrderHeaderSalesReason]", Order:=3, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesOrderHeaderSalesReason]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to SalesOrderHeader.SalesOrderID. - Clustered index created by a primary key constraint.", FieldName:="SalesOrderID", ForeingCRUD:="ABM_SalesOrderHeader", ForeingTable:="SalesOrderHeader", MainTable:="[Sales].[SalesOrderHeaderSalesReason]", Order:=1, ParameterName:="SalesOrderID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesOrderID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesOrderHeader", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SalesOrderID() As Int32
        Get
            Return _SalesOrderID
        End Get
        Set(ByVal value As Int32)
            _SalesOrderID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key. Foreign key to SalesReason.SalesReasonID.", FieldName:="SalesReasonID", ForeingCRUD:="ABM_SalesReason", ForeingTable:="SalesReason", MainTable:="[Sales].[SalesOrderHeaderSalesReason]", Order:=2, ParameterName:="SalesReasonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesReasonID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesReason", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesReasonID() As Int32
        Get
            Return _SalesReasonID
        End Get
        Set(ByVal value As Int32)
            _SalesReasonID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _SalesOrderID = Nothing
        _SalesReasonID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesPersonID", PrimaryKeyFieldName:="SalesPersonID", RootContainerName:="[Sales].[SalesPerson]", EnabledPropertyName:="SalesPersonID", PrimaryKeyPropertyName:="SalesPersonID")> _
Public Class EntSales_SalesPerson

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Bonus As Decimal
    Private _CommissionPct As Decimal
    Private _ModifiedDate As DateTime
    Private _Rowguid As Guid
    Private _SalesLastYear As Decimal
    Private _SalesPersonID As Int32
    Private _SalesQuota As Decimal
    Private _SalesYTD As Decimal
    Private _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Bonus due if quota is met.", FieldName:="Bonus", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPerson]", Order:=4, ParameterName:="Bonus", Scale:=4, Size:=19, SourceColumn:="Bonus", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesPerson]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Bonus() As Decimal
        Get
            Return _Bonus
        End Get
        Set(ByVal value As Decimal)
            _Bonus = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Commision percent received per sale.", FieldName:="CommissionPct", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPerson]", Order:=5, ParameterName:="CommissionPct", Scale:=4, Size:=10, SourceColumn:="CommissionPct", TypeName:="Decimal", MaxValue:=10, EntityClassContainer:="Ent[Sales].[SalesPerson]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CommissionPct() As Decimal
        Get
            Return _CommissionPct
        End Get
        Set(ByVal value As Decimal)
            _CommissionPct = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPerson]", Order:=9, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesPerson]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPerson]", Order:=8, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SalesPerson]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Sales total of previous year.", FieldName:="SalesLastYear", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPerson]", Order:=7, ParameterName:="SalesLastYear", Scale:=4, Size:=19, SourceColumn:="SalesLastYear", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesPerson]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesLastYear() As Decimal
        Get
            Return _SalesLastYear
        End Get
        Set(ByVal value As Decimal)
            _SalesLastYear = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for SalesPerson records. - Clustered index created by a primary key constraint.", FieldName:="SalesPersonID", ForeingCRUD:="ABM_Employee", ForeingTable:="Employee", MainTable:="[Sales].[SalesPerson]", Order:=1, ParameterName:="SalesPersonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesPersonID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntEmployee", IsDescription:=False, ForeingFieldName:="SalesPersonID", IsDefaultOrderBy:=True)> _
     Public Property SalesPersonID() As Int32
        Get
            Return _SalesPersonID
        End Get
        Set(ByVal value As Int32)
            _SalesPersonID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Projected yearly sales.", FieldName:="SalesQuota", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPerson]", Order:=3, ParameterName:="SalesQuota", Scale:=4, SetNullable:=True, Size:=19, SourceColumn:="SalesQuota", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesPerson]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesQuota() As Decimal
        Get
            Return _SalesQuota
        End Get
        Set(ByVal value As Decimal)
            _SalesQuota = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Sales total year to date.", FieldName:="SalesYTD", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPerson]", Order:=6, ParameterName:="SalesYTD", Scale:=4, Size:=19, SourceColumn:="SalesYTD", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesPerson]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesYTD() As Decimal
        Get
            Return _SalesYTD
        End Get
        Set(ByVal value As Decimal)
            _SalesYTD = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.", FieldName:="TerritoryID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SalesTerritory", ForeingTable:="SalesTerritory", MainTable:="[Sales].[SalesPerson]", Order:=2, ParameterName:="TerritoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="TerritoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesTerritory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TerritoryID() As Int32
        Get
            Return _TerritoryID
        End Get
        Set(ByVal value As Int32)
            _TerritoryID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _Bonus = 0.0
        _CommissionPct = 0.0
        _ModifiedDate = Now
        _Rowguid = newid
        _SalesLastYear = 0.0
        _SalesPersonID = Nothing
        _SalesQuota = Nothing
        _SalesYTD = 0.0
        _TerritoryID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesPersonID", PrimaryKeyFieldName:="SalesPersonID", RootContainerName:="[Sales].[SalesPersonQuotaHistory]", EnabledPropertyName:="SalesPersonID", PrimaryKeyPropertyName:="SalesPersonID")> _
Public Class EntSales_SalesPersonQuotaHistory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _QuotaDate As DateTime
    Private _Rowguid As Guid
    Private _SalesPersonID As Int32
    Private _SalesQuota As Decimal
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPersonQuotaHistory]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesPersonQuotaHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Sales quota date. - Unique nonclustered index. Used to support replication samples.", FieldName:="QuotaDate", ForeingCRUD:="ABM_SalesPersonQuotaHistory", ForeingTable:="SalesPersonQuotaHistory", MainTable:="[Sales].[SalesPersonQuotaHistory]", Order:=2, ParameterName:="QuotaDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="QuotaDate", TypeName:="DateTime", EntityClassContainer:="EntSalesPersonQuotaHistory", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property QuotaDate() As DateTime
        Get
            Return _QuotaDate
        End Get
        Set(ByVal value As DateTime)
            _QuotaDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPersonQuotaHistory]", Order:=4, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SalesPersonQuotaHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Sales person identification number. Foreign key to SalesPerson.SalesPersonID. - Clustered index created by a primary key constraint.", FieldName:="SalesPersonID", ForeingCRUD:="ABM_SalesPerson", ForeingTable:="SalesPerson", MainTable:="[Sales].[SalesPersonQuotaHistory]", Order:=1, ParameterName:="SalesPersonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesPersonID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesPerson", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesPersonID() As Int32
        Get
            Return _SalesPersonID
        End Get
        Set(ByVal value As Int32)
            _SalesPersonID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, FieldDescription:="Sales quota amount.", FieldName:="SalesQuota", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesPersonQuotaHistory]", Order:=3, ParameterName:="SalesQuota", Scale:=4, Size:=19, SourceColumn:="SalesQuota", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesPersonQuotaHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesQuota() As Decimal
        Get
            Return _SalesQuota
        End Get
        Set(ByVal value As Decimal)
            _SalesQuota = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _QuotaDate = Nothing
        _Rowguid = newid
        _SalesPersonID = Nothing
        _SalesQuota = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesReasonID", PrimaryKeyFieldName:="SalesReasonID", RootContainerName:="[Sales].[SalesReason]", EnabledPropertyName:="SalesReasonID", PrimaryKeyPropertyName:="SalesReasonID")> _
Public Class EntSales_SalesReason

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _ReasonType As String
    Private _SalesReasonID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesReason]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesReason]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Sales reason description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesReason]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[SalesReason]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Category the sales reason belongs to.", FieldName:="ReasonType", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesReason]", Order:=3, ParameterName:="ReasonType", Size:=50, SourceColumn:="ReasonType", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[SalesReason]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ReasonType() As String
        Get
            Return _ReasonType
        End Get
        Set(ByVal value As String)
            _ReasonType = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for SalesReason records.", FieldName:="SalesReasonID", ForeingCRUD:="ABM_SalesReason", ForeingTable:="SalesReason", MainTable:="[Sales].[SalesReason]", Order:=1, ParameterName:="SalesReasonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesReasonID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesReason", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SalesReasonID() As Int32
        Get
            Return _SalesReasonID
        End Get
        Set(ByVal value As Int32)
            _SalesReasonID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Name = Nothing
        _ReasonType = Nothing
        _SalesReasonID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SalesTaxRateID", PrimaryKeyFieldName:="SalesTaxRateID", RootContainerName:="[Sales].[SalesTaxRate]", EnabledPropertyName:="SalesTaxRateID", PrimaryKeyPropertyName:="SalesTaxRateID")> _
Public Class EntSales_SalesTaxRate

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _Rowguid As Guid
    Private _SalesTaxRateID As Int32
    Private _StateProvinceID As Int32
    Private _TaxRate As Decimal
    Private _TaxType As Byte
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTaxRate]", Order:=7, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesTaxRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Tax rate description.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTaxRate]", Order:=5, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[SalesTaxRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTaxRate]", Order:=6, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SalesTaxRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for SalesTaxRate records. - Clustered index created by a primary key constraint.", FieldName:="SalesTaxRateID", ForeingCRUD:="ABM_SalesTaxRate", ForeingTable:="SalesTaxRate", MainTable:="[Sales].[SalesTaxRate]", Order:=1, ParameterName:="SalesTaxRateID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesTaxRateID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesTaxRate", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SalesTaxRateID() As Int32
        Get
            Return _SalesTaxRateID
        End Get
        Set(ByVal value As Int32)
            _SalesTaxRateID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. - State, province, or country/region the sales tax applies to.", FieldName:="StateProvinceID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_StateProvince", ForeingTable:="StateProvince", MainTable:="[Sales].[SalesTaxRate]", Order:=2, ParameterName:="StateProvinceID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="StateProvinceID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStateProvince", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StateProvinceID() As Int32
        Get
            Return _StateProvinceID
        End Get
        Set(ByVal value As Int32)
            _StateProvinceID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Tax rate amount.", FieldName:="TaxRate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTaxRate]", Order:=4, ParameterName:="TaxRate", Scale:=4, Size:=10, SourceColumn:="TaxRate", TypeName:="Decimal", MaxValue:=10, EntityClassContainer:="Ent[Sales].[SalesTaxRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TaxRate() As Decimal
        Get
            Return _TaxRate
        End Get
        Set(ByVal value As Decimal)
            _TaxRate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Byte, FieldDescription:="1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions. - Unique nonclustered index. Used to support replication samples.", FieldName:="TaxType", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTaxRate]", Order:=3, ParameterName:="TaxType", Size:=3, SourceColumn:="TaxType", TypeName:="Byte", MaxValue:=3, EntityClassContainer:="Ent[Sales].[SalesTaxRate]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TaxType() As Byte
        Get
            Return _TaxType
        End Get
        Set(ByVal value As Byte)
            _TaxType = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _Name = Nothing
        _Rowguid = newid
        _SalesTaxRateID = Nothing
        _StateProvinceID = Nothing
        _TaxRate = 0.0
        _TaxType = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TerritoryID", PrimaryKeyFieldName:="TerritoryID", RootContainerName:="[Sales].[SalesTerritory]", EnabledPropertyName:="TerritoryID", PrimaryKeyPropertyName:="TerritoryID")> _
Public Class EntSales_SalesTerritory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CostLastYear As Decimal
    Private _CostYTD As Decimal
    Private _CountryRegionCode As String
    Private _Group As String
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _Rowguid As Guid
    Private _SalesLastYear As Decimal
    Private _SalesYTD As Decimal
    Private _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Business costs in the territory the previous year.", FieldName:="CostLastYear", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=8, ParameterName:="CostLastYear", Scale:=4, Size:=19, SourceColumn:="CostLastYear", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CostLastYear() As Decimal
        Get
            Return _CostLastYear
        End Get
        Set(ByVal value As Decimal)
            _CostLastYear = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Business costs in the territory year to date.", FieldName:="CostYTD", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=7, ParameterName:="CostYTD", Scale:=4, Size:=19, SourceColumn:="CostYTD", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CostYTD() As Decimal
        Get
            Return _CostYTD
        End Get
        Set(ByVal value As Decimal)
            _CostYTD = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.  - Unique nonclustered index. Used to support replication samples.", FieldName:="CountryRegionCode", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_CountryRegion", ForeingTable:="CountryRegion", MainTable:="[Sales].[SalesTerritory]", Order:=3, ParameterName:="CountryRegionCode", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=3, SourceColumn:="CountryRegionCode", TypeName:="String", MaxValue:=3, EntityClassContainer:="EntCountryRegion", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CountryRegionCode() As String
        Get
            Return _CountryRegionCode
        End Get
        Set(ByVal value As String)
            _CountryRegionCode = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Geographic area to which the sales territory belong.", FieldName:="Group", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=4, ParameterName:="Group", Size:=50, SourceColumn:="Group", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Group() As String
        Get
            Return _Group
        End Get
        Set(ByVal value As String)
            _Group = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=10, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Sales territory description - Unique nonclustered index.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=9, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Sales in the territory the previous year.", FieldName:="SalesLastYear", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=6, ParameterName:="SalesLastYear", Scale:=4, Size:=19, SourceColumn:="SalesLastYear", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesLastYear() As Decimal
        Get
            Return _SalesLastYear
        End Get
        Set(ByVal value As Decimal)
            _SalesLastYear = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Sales in the territory year to date.", FieldName:="SalesYTD", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritory]", Order:=5, ParameterName:="SalesYTD", Scale:=4, Size:=19, SourceColumn:="SalesYTD", TypeName:="Decimal", MaxValue:=19, EntityClassContainer:="Ent[Sales].[SalesTerritory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesYTD() As Decimal
        Get
            Return _SalesYTD
        End Get
        Set(ByVal value As Decimal)
            _SalesYTD = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for SalesTerritory records.", FieldName:="TerritoryID", ForeingCRUD:="ABM_SalesTerritory", ForeingTable:="SalesTerritory", MainTable:="[Sales].[SalesTerritory]", Order:=1, ParameterName:="TerritoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="TerritoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesTerritory", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property TerritoryID() As Int32
        Get
            Return _TerritoryID
        End Get
        Set(ByVal value As Int32)
            _TerritoryID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _CostLastYear = 0.0
        _CostYTD = 0.0
        _CountryRegionCode = Nothing
        _Group = Nothing
        _ModifiedDate = Now
        _Name = Nothing
        _Rowguid = newid
        _SalesLastYear = 0.0
        _SalesYTD = 0.0
        _TerritoryID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="TerritoryID", PrimaryKeyFieldName:="TerritoryID", RootContainerName:="[Sales].[SalesTerritoryHistory]", EnabledPropertyName:="TerritoryID", PrimaryKeyPropertyName:="TerritoryID")> _
Public Class EntSales_SalesTerritoryHistory

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _EndDate As DateTime
    Private _ModifiedDate As DateTime
    Private _Rowguid As Guid
    Private _SalesPersonID As Int32
    Private _StartDate As DateTime
    Private _TerritoryID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the sales representative left work in the territory.", FieldName:="EndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritoryHistory]", Order:=4, ParameterName:="EndDate", SetNullable:=True, SourceColumn:="EndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesTerritoryHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndDate() As DateTime
        Get
            Return _EndDate
        End Get
        Set(ByVal value As DateTime)
            _EndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritoryHistory]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SalesTerritoryHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SalesTerritoryHistory]", Order:=5, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SalesTerritoryHistory]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key for SalesTerritoryHistory records.", FieldName:="SalesPersonID", ForeingCRUD:="ABM_SalesPerson", ForeingTable:="SalesPerson", MainTable:="[Sales].[SalesTerritoryHistory]", Order:=1, ParameterName:="SalesPersonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SalesPersonID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesPerson", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SalesPersonID() As Int32
        Get
            Return _SalesPersonID
        End Get
        Set(ByVal value As Int32)
            _SalesPersonID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Date the sales representive started work in the territory.", FieldName:="StartDate", ForeingCRUD:="ABM_ProductCostHistory", ForeingTable:="ProductCostHistory", MainTable:="[Sales].[SalesTerritoryHistory]", Order:=3, ParameterName:="StartDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="StartDate", TypeName:="DateTime", EntityClassContainer:="EntProductCostHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartDate() As DateTime
        Get
            Return _StartDate
        End Get
        Set(ByVal value As DateTime)
            _StartDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID. - Unique nonclustered index. Used to support replication samples.", FieldName:="TerritoryID", ForeingCRUD:="ABM_SalesTerritory", ForeingTable:="SalesTerritory", MainTable:="[Sales].[SalesTerritoryHistory]", Order:=2, ParameterName:="TerritoryID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="TerritoryID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesTerritory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property TerritoryID() As Int32
        Get
            Return _TerritoryID
        End Get
        Set(ByVal value As Int32)
            _TerritoryID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _EndDate = Nothing
        _ModifiedDate = Now
        _Rowguid = newid
        _SalesPersonID = Nothing
        _StartDate = Nothing
        _TerritoryID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="ShoppingCartItemID", PrimaryKeyFieldName:="ShoppingCartItemID", RootContainerName:="[Sales].[ShoppingCartItem]", EnabledPropertyName:="ShoppingCartItemID", PrimaryKeyPropertyName:="ShoppingCartItemID")> _
Public Class EntSales_ShoppingCartItem

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _DateCreated As DateTime
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _Quantity As Int32
    Private _ShoppingCartID As String
    Private _ShoppingCartItemID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date the time the record was created.", FieldName:="DateCreated", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[ShoppingCartItem]", Order:=5, ParameterName:="DateCreated", SourceColumn:="DateCreated", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[ShoppingCartItem]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DateCreated() As DateTime
        Get
            Return _DateCreated
        End Get
        Set(ByVal value As DateTime)
            _DateCreated = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[ShoppingCartItem]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[ShoppingCartItem]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product ordered. Foreign key to Product.ProductID.", FieldName:="ProductID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Sales].[ShoppingCartItem]", Order:=4, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, DefaultValue:="((1))", FieldDescription:="Product quantity ordered.", FieldName:="Quantity", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[ShoppingCartItem]", Order:=3, ParameterName:="Quantity", Size:=10, SourceColumn:="Quantity", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Sales].[ShoppingCartItem]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Quantity() As Int32
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Int32)
            _Quantity = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Nonclustered index. - Shopping cart identification number.", FieldName:="ShoppingCartID", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[ShoppingCartItem]", Order:=2, ParameterName:="ShoppingCartID", Size:=50, SourceColumn:="ShoppingCartID", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[ShoppingCartItem]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ShoppingCartID() As String
        Get
            Return _ShoppingCartID
        End Get
        Set(ByVal value As String)
            _ShoppingCartID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for ShoppingCartItem records. - Clustered index created by a primary key constraint.", FieldName:="ShoppingCartItemID", ForeingCRUD:="ABM_ShoppingCartItem", ForeingTable:="ShoppingCartItem", MainTable:="[Sales].[ShoppingCartItem]", Order:=1, ParameterName:="ShoppingCartItemID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ShoppingCartItemID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntShoppingCartItem", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ShoppingCartItemID() As Int32
        Get
            Return _ShoppingCartItemID
        End Get
        Set(ByVal value As Int32)
            _ShoppingCartItemID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _DateCreated = Now
        _ModifiedDate = Now
        _ProductID = Nothing
        _Quantity = 1
        _ShoppingCartID = Nothing
        _ShoppingCartItemID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SpecialOfferID", PrimaryKeyFieldName:="SpecialOfferID", RootContainerName:="[Sales].[SpecialOffer]", EnabledPropertyName:="SpecialOfferID", PrimaryKeyPropertyName:="SpecialOfferID")> _
Public Class EntSales_SpecialOffer

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _Category As String
    Private _Description As String
    Private _DiscountPct As Decimal
    Private _EndDate As DateTime
    Private _MaxQty As Int32
    Private _MinQty As Int32
    Private _ModifiedDate As DateTime
    Private _Rowguid As Guid
    Private _SpecialOfferID As Int32
    Private _StartDate As DateTime
    Private _Type As String
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Group the discount applies to such as Reseller or Customer.", FieldName:="Category", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=5, ParameterName:="Category", Size:=50, SourceColumn:="Category", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Category() As String
        Get
            Return _Category
        End Get
        Set(ByVal value As String)
            _Category = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Discount description.", FieldName:="Description", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=2, ParameterName:="Description", Size:=255, SourceColumn:="Description", TypeName:="String", MaxValue:=255, EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Decimal, DefaultValue:="((0.00))", FieldDescription:="Discount precentage.", FieldName:="DiscountPct", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=3, ParameterName:="DiscountPct", Scale:=4, Size:=10, SourceColumn:="DiscountPct", TypeName:="Decimal", MaxValue:=10, EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property DiscountPct() As Decimal
        Get
            Return _DiscountPct
        End Get
        Set(ByVal value As Decimal)
            _DiscountPct = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Discount end date.", FieldName:="EndDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=7, ParameterName:="EndDate", SourceColumn:="EndDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property EndDate() As DateTime
        Get
            Return _EndDate
        End Get
        Set(ByVal value As DateTime)
            _EndDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Maximum discount percent allowed.", FieldName:="MaxQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=9, ParameterName:="MaxQty", SetNullable:=True, Size:=10, SourceColumn:="MaxQty", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property MaxQty() As Int32
        Get
            Return _MaxQty
        End Get
        Set(ByVal value As Int32)
            _MaxQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, DefaultValue:="((0))", FieldDescription:="Minimum discount percent allowed.", FieldName:="MinQty", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=8, ParameterName:="MinQty", Size:=10, SourceColumn:="MinQty", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property MinQty() As Int32
        Get
            Return _MinQty
        End Get
        Set(ByVal value As Int32)
            _MinQty = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=11, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=10, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for SpecialOffer records. - Clustered index created by a primary key constraint.", FieldName:="SpecialOfferID", ForeingCRUD:="ABM_SpecialOffer", ForeingTable:="SpecialOffer", MainTable:="[Sales].[SpecialOffer]", Order:=1, ParameterName:="SpecialOfferID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SpecialOfferID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSpecialOffer", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property SpecialOfferID() As Int32
        Get
            Return _SpecialOfferID
        End Get
        Set(ByVal value As Int32)
            _SpecialOfferID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, FieldDescription:="Discount start date.", FieldName:="StartDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ProductCostHistory", ForeingTable:="ProductCostHistory", MainTable:="[Sales].[SpecialOffer]", Order:=6, ParameterName:="StartDate", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SourceColumn:="StartDate", TypeName:="DateTime", EntityClassContainer:="EntProductCostHistory", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property StartDate() As DateTime
        Get
            Return _StartDate
        End Get
        Set(ByVal value As DateTime)
            _StartDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Discount type category.", FieldName:="Type", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOffer]", Order:=4, ParameterName:="Type", Size:=50, SourceColumn:="Type", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[SpecialOffer]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Type() As String
        Get
            Return _Type
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
        _DiscountPct = 0.0
        _EndDate = Nothing
        _MaxQty = Nothing
        _MinQty = 0
        _ModifiedDate = Now
        _Rowguid = newid
        _SpecialOfferID = Nothing
        _StartDate = Nothing
        _Type = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="SpecialOfferID", PrimaryKeyFieldName:="SpecialOfferID", RootContainerName:="[Sales].[SpecialOfferProduct]", EnabledPropertyName:="SpecialOfferID", PrimaryKeyPropertyName:="SpecialOfferID")> _
Public Class EntSales_SpecialOfferProduct

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ModifiedDate As DateTime
    Private _ProductID As Int32
    Private _Rowguid As Guid
    Private _SpecialOfferID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOfferProduct]", Order:=4, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[SpecialOfferProduct]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Product identification number. Foreign key to Product.ProductID. - Unique nonclustered index. Used to support replication samples.", FieldName:="ProductID", ForeingCRUD:="ABM_Product", ForeingTable:="Product", MainTable:="[Sales].[SpecialOfferProduct]", Order:=2, ParameterName:="ProductID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ProductID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntProduct", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ProductID() As Int32
        Get
            Return _ProductID
        End Get
        Set(ByVal value As Int32)
            _ProductID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="Nonclustered index. - ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[SpecialOfferProduct]", Order:=3, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[SpecialOfferProduct]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Primary key for SpecialOfferProduct records. - Clustered index created by a primary key constraint.", FieldName:="SpecialOfferID", ForeingCRUD:="ABM_SpecialOffer", ForeingTable:="SpecialOffer", MainTable:="[Sales].[SpecialOfferProduct]", Order:=1, ParameterName:="SpecialOfferID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="SpecialOfferID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSpecialOffer", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SpecialOfferID() As Int32
        Get
            Return _SpecialOfferID
        End Get
        Set(ByVal value As Int32)
            _SpecialOfferID = value
        End Set
    End Property
#End Region

#Region "GeneratedCode Constructor"
    Public Sub New()
        _ModifiedDate = Now
        _ProductID = Nothing
        _Rowguid = newid
        _SpecialOfferID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID", PrimaryKeyFieldName:="CustomerID", RootContainerName:="[Sales].[Store]", EnabledPropertyName:="CustomerID", PrimaryKeyPropertyName:="CustomerID")> _
Public Class EntSales_Store

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _CustomerID As Int32
    Private _Demographics As String
    Private _ModifiedDate As DateTime
    Private _Name As String
    Private _Rowguid As Guid
    Private _SalesPersonID As Int32
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Primary key. Foreign key to Customer.CustomerID.", FieldName:="CustomerID", ForeingCRUD:="ABM_Store", ForeingTable:="Store", MainTable:="[Sales].[Store]", Order:=1, ParameterName:="CustomerID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CustomerID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStore", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property CustomerID() As Int32
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int32)
            _CustomerID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Demographic informationg about the store such as the number of employees, annual sales and store type.", FieldName:="Demographics", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Store]", Order:=4, ParameterName:="Demographics", SetNullable:=True, Size:=-1, SourceColumn:="Demographics", TypeName:="String", MaxValue:=-1, EntityClassContainer:="Ent[Sales].[Store]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Demographics() As String
        Get
            Return _Demographics
        End Get
        Set(ByVal value As String)
            _Demographics = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Store]", Order:=6, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[Store]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.String, FieldDescription:="Name of the store. - Unique nonclustered index. Used to support replication samples.", FieldName:="Name", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Store]", Order:=2, ParameterName:="Name", Size:=50, SourceColumn:="Name", TypeName:="String", MaxValue:=50, EntityClassContainer:="Ent[Sales].[Store]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[Store]", Order:=5, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[Store]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
        End Get
        Set(ByVal value As Guid)
            _Rowguid = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="ID of the sales person assigned to the customer. Foreign key to SalesPerson.SalesPersonID. - Nonclustered index.", FieldName:="SalesPersonID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_SalesPerson", ForeingTable:="SalesPerson", MainTable:="[Sales].[Store]", Order:=3, ParameterName:="SalesPersonID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, SetNullable:=True, Size:=10, SourceColumn:="SalesPersonID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntSalesPerson", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property SalesPersonID() As Int32
        Get
            Return _SalesPersonID
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
        _ModifiedDate = Now
        _Name = Nothing
        _Rowguid = newid
        _SalesPersonID = Nothing
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

''' <summary>
''' Auto Generated:  13/02/2010 06:06:34 p.m.
''' </summary>
''' <remarks></remarks>
<BrainWork.Entities.EntityClassExtendsAttribute(DescriptionFieldName:="CustomerID", PrimaryKeyFieldName:="CustomerID", RootContainerName:="[Sales].[StoreContact]", EnabledPropertyName:="CustomerID", PrimaryKeyPropertyName:="CustomerID")> _
Public Class EntSales_StoreContact

    Inherits BrainWork.Entities.AbstractEntityBase
#Region "GeneratedCode Declaration"
    Private _ContactID As Int32
    Private _ContactTypeID As Int32
    Private _CustomerID As Int32
    Private _ModifiedDate As DateTime
    Private _Rowguid As Guid
#End Region

#Region "GeneratedCode Propertys"

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Unique nonclustered index. Used to support replication samples. - Contact (store employee) identification number. Foreign key to Contact.ContactID.", FieldName:="ContactID", ForeingCRUD:="ABM_Contact", ForeingTable:="Contact", MainTable:="[Sales].[StoreContact]", Order:=2, ParameterName:="ContactID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContact", IsDescription:=False, IsDefaultOrderBy:=True)> _
     Public Property ContactID() As Int32
        Get
            Return _ContactID
        End Get
        Set(ByVal value As Int32)
            _ContactID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Contact type such as owner or purchasing agent. Foreign key to ContactType.ContactTypeID. - Nonclustered index.", FieldName:="ContactTypeID", FieldType:=BrainWork.Entities.EnumFieldType.Field, ForeingCRUD:="ABM_ContactType", ForeingTable:="ContactType", MainTable:="[Sales].[StoreContact]", Order:=3, ParameterName:="ContactTypeID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="ContactTypeID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntContactType", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ContactTypeID() As Int32
        Get
            Return _ContactTypeID
        End Get
        Set(ByVal value As Int32)
            _ContactTypeID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Int32, FieldDescription:="Clustered index created by a primary key constraint. - Store identification number. Foreign key to Customer.CustomerID.", FieldName:="CustomerID", ForeingCRUD:="ABM_Store", ForeingTable:="Store", MainTable:="[Sales].[StoreContact]", Order:=1, ParameterName:="CustomerID", RelationType:=BrainWork.Entities.EnumRelationType.Combo, Size:=10, SourceColumn:="CustomerID", TypeName:="Int32", MaxValue:=10, EntityClassContainer:="EntStore", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property CustomerID() As Int32
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As Int32)
            _CustomerID = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.DateTime, DefaultValue:="(getdate())", FieldDescription:="Date and time the record was last updated.", FieldName:="ModifiedDate", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[StoreContact]", Order:=5, ParameterName:="ModifiedDate", SourceColumn:="ModifiedDate", TypeName:="DateTime", EntityClassContainer:="Ent[Sales].[StoreContact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property ModifiedDate() As DateTime
        Get
            Return _ModifiedDate
        End Get
        Set(ByVal value As DateTime)
            _ModifiedDate = value
        End Set
    End Property

    <BrainWork.Entities.EntityFieldExtendsAttribute(DbType:=DbType.Guid, DefaultValue:="(newid())", FieldDescription:="ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample. - Nonclustered index.", FieldName:="rowguid", FieldType:=BrainWork.Entities.EnumFieldType.Field, MainTable:="[Sales].[StoreContact]", Order:=4, ParameterName:="rowguid", SourceColumn:="rowguid", TypeName:="Guid", EntityClassContainer:="Ent[Sales].[StoreContact]", IsDescription:=False, IsDefaultOrderBy:=False)> _
     Public Property Rowguid() As Guid
        Get
            Return _Rowguid
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
        _ModifiedDate = Now
        _Rowguid = newid
    End Sub
#End Region

#Region "GeneratedCode Methods"
#End Region
End Class

