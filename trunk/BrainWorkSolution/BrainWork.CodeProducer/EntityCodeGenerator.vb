Imports System.Globalization

Partial Public Class EntityCodeGenerator
    Private _Connection As SqlClient.SqlConnection
    Private TablesFields As New Dictionary(Of String, List(Of BrainWork.Entities.EntityFieldExtendsAttribute))
    Private Tables As New Dictionary(Of String, BrainWork.Entities.EntityClassExtendsAttribute)
    Private dtKeys As DataTable
    Private VBPrimaryKeys() As String = New String() {"AddHandler", "AddressOf", "Alias", "And", "AndAlso", "Ansi", "As", "Assembly", "Auto", "Boolean", "ByRef", "Byte", "ByVal", "Call", "Case", "Catch", "CBool", "CByte", "CChar", "CDate", "CDec", "CDbl", "Char", "CInt", "Class", "CLng", "CObj", "Const", "CShort", "CSng", "CStr", "CType", "Date", "Decimal", "Declare", "Default", "Delegate", "Dim", "DirectCast", "Do", "Double", "Each", "Else", "ElseIf", "End", "Enum", "Erase", "Error", "Event", "Exit", "False", "Finally", "For", "Friend", "Function", "Get", "GetType", "GoSub", "GoTo", "Handles", "If", "Implements", "Imports", "In", "Inherits", "Integer", "Interface", "Is", "Let", "Lib", "Like", "Long", "Loop", "Me", "Mod", "Module", "MustInherit", "MustOverride", "MyBase", "MyClass", "Namespace", "New", "Next", "Not", "Nothing", "NotInheritable", "NotOverridable", "Object", "On", "Option", "Optional", "Or", "OrElse", "Overloads", "Overridable", "Overrides", "ParamArray", "Preserve", "Private", "Property", "Protected", "Public", "RaiseEvent", "ReadOnly", "ReDim", "REM", "RemoveHandler", "Resume", "Return", "Select", "Set", "Shadows", "Shared", "Short", "Single", "Static", "Step", "Stop", "String", "Structure", "Sub", "SyncLock", "Then", "Throw", "To", "True", "Try", "TypeOf", "Unicode", "Until", "Variant", "When", "While", "With", "WithEvents", "WriteOnly", "Xor"}
    Private _cnnString As String = ""
    Private TEMPORAL_CLASS As String = ""
    Private TEMPORAL_STORED_PROCEDURES As String = ""
    Private DECLARATION_REGION As String = "GeneratedCode Declaration"
    Private METHOD_REGION As String = "GeneratedCode Methods"
    Private PROPERTYS_REGION As String = "GeneratedCode Propertys"
    Private CONSTRUCTOR_REGION As String = "GeneratedCode Constructor"

    Protected Const PAGED_ROW_PARAMETER As String = "@Row"
    Protected Const PAGED_MAXVALUES_PARAMETER As String = "@MaxValues"
    Protected Const PAGED_COUNT_PARAMETER As String = "@RecordCount"
    Protected Const ORDER_BY_PARAMETER As String = "@OrderBy"
    Protected Const ORDER_BY_DIRECTION_PARAMETER As String = "@OrderByDirection"
    Private _GeneratedStored As String = ""

    Dim TableProcedureInsert As New Dictionary(Of String, String)
    Dim TableProcedureSelectAll As New Dictionary(Of String, String)
    Dim TableProcedureSelectAllFullDescription As New Dictionary(Of String, String)
    Dim TableProcedureDelete As New Dictionary(Of String, String)
    Dim TableProcedureSelectOne As New Dictionary(Of String, String)
    Dim TableProcedureUpdate As New Dictionary(Of String, String)
    Dim TableProcedureUpdateByPK As New Dictionary(Of String, String)
    Dim TableProcedureDisable As New Dictionary(Of String, String)
    Public DESCRIPTIONENDWITH As String = "_D"
    Public ENABLEDDENDWITH As String = "HABILITADO"

    Public ReadOnly Property GeneratedStored() As String
        Get
            Return _GeneratedStored
        End Get
    End Property
    Private _GeneratedEntity As String
    Public ReadOnly Property GeneratedEntity() As String
        Get
            Return _GeneratedEntity
        End Get
    End Property
    Private _GeneratedBussines As String
    Public ReadOnly Property GeneratedBussines() As String
        Get
            Return _GeneratedBussines
        End Get
    End Property
    Private _GeneratedDataAccess As String
    Public ReadOnly Property GeneratedDataAccess() As String
        Get
            Return _GeneratedDataAccess
        End Get
    End Property

    Private ReadOnly Property GetDATemplate() As String
        Get
            Dim strTemplate As String = "Public Class ____daClass____ " & vbCrLf
            strTemplate += "    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess " & vbCrLf
            strTemplate += "    Private _CurrentEntity As ____entClass____" & vbCrLf
            strTemplate += "" & vbCrLf
            strTemplate += "    Public Property CurrentEntity() As ____entClass____" & vbCrLf
            strTemplate += "        Get" & vbCrLf
            strTemplate += "            Return _CurrentEntity" & vbCrLf
            strTemplate += "        End Get" & vbCrLf
            strTemplate += "        Set(ByVal value As ____entClass____)" & vbCrLf
            strTemplate += "            _CurrentEntity = value" & vbCrLf
            strTemplate += "        End Set" & vbCrLf
            strTemplate += "    End Property" & vbCrLf
            strTemplate += "" & vbCrLf
            strTemplate += "    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)" & vbCrLf
            strTemplate += "        MyBase.New(oUser, New ____entClass____)" & vbCrLf
            strTemplate += "        Me._CurrentEntity = CType(MyBase.Entity, ____entClass____)" & vbCrLf
            strTemplate += " ____ConstructorValues____" & vbCrLf
            strTemplate += "    End Sub" & vbCrLf
            strTemplate += "" & vbCrLf
            strTemplate += "    Protected Overrides Sub DisableEntity()" & vbCrLf
            strTemplate += "" & vbCrLf
            strTemplate += "    End Sub" & vbCrLf
            strTemplate += "" & vbCrLf
            strTemplate += "    Protected Overrides Sub SetStoredProcedures()" & vbCrLf
            strTemplate += " ____SetStoredProcedures____" & vbCrLf
            strTemplate += "    End Sub" & vbCrLf
            strTemplate += "End Class" & vbCrLf
            strTemplate += "" & vbCrLf
            Return strTemplate
        End Get
    End Property

    Private Function GetDaClass(ByVal TableName As String, _
                                ByVal className As String, _
                                ByVal entClassName As String, _
                                ByVal SetStoredProcedures As String, _
                                ByVal ConstructorValues As String) As String
        Dim strTemplate As String = Me.GetDATemplate.ToString
        strTemplate = strTemplate.Replace("____daClass____", className)
        strTemplate = strTemplate.Replace("____entClass____", entClassName)
        strTemplate = strTemplate.Replace("____ConstructorValues____", ConstructorValues)
        strTemplate = strTemplate.Replace("____SetStoredProcedures____", SetStoredProcedures)

        Return strTemplate
    End Function

    Private ReadOnly Property GetBLTemplate() As String
        Get
            Dim strTemplate As String = "Public Class ____blClassName____"
            strTemplate += vbCrLf & "    Inherits BrainWork.BussinesLogicBaseLibrary.AbstractBussinesLogic"
            strTemplate += vbCrLf & "    Private _CurrentEntity As ____entClassName____"
            strTemplate += vbCrLf & "    Private _myDataAccess As ____daClassName____"
            strTemplate += vbCrLf & ""
            strTemplate += vbCrLf & "    Public Property CurrentEntity() As ____entClassName____"
            strTemplate += vbCrLf & "        Get"
            strTemplate += vbCrLf & "            Return _CurrentEntity"
            strTemplate += vbCrLf & "        End Get"
            strTemplate += vbCrLf & "        Set(ByVal value As ____entClassName____)"
            strTemplate += vbCrLf & "            _CurrentEntity = value"
            strTemplate += vbCrLf & "        End Set"
            strTemplate += vbCrLf & "    End Property"
            strTemplate += vbCrLf & ""
            strTemplate += vbCrLf & "    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)"
            strTemplate += vbCrLf & "        MyBase.New(oUser, New ____entClassName____, New ____daClassName____(oUser))"
            strTemplate += vbCrLf & "        Me._CurrentEntity = CType(MyBase.Entity, ____entClassName____)"
            strTemplate += vbCrLf & "        Me._myDataAccess = CType(MyBase.DataAccess, ____daClassName____)"
            strTemplate += vbCrLf & "        Me._myDataAccess.CurrentEntity = Me.CurrentEntity"
            strTemplate += vbCrLf & "____ConstructorValues____"

            strTemplate += vbCrLf & "    End Sub"
            strTemplate += vbCrLf & ""
            strTemplate += vbCrLf & "    Public Overrides Function ClassValidation(ByRef strError As String, _ "
            strTemplate += vbCrLf & "											  ByVal validationType As BrainWork.BussinesLogicBaseLibrary.Enums.enumValidationType) As Boolean "
            strTemplate += vbCrLf & "____ClassValidationString____"
            strTemplate += vbCrLf & "    End Function "
            strTemplate += vbCrLf & "End Class"
            Return strTemplate
        End Get
    End Property

    Private Function GetBlClass(ByVal TableName As String, _
                                ByVal className As String, _
                                ByVal entClassName As String, _
                                ByVal daClassName As String, _
                                ByVal ClassValidationString As String, _
                                ByVal ConstructorValues As String) As String
        Dim strTemplate As String = Me.GetBLTemplate.ToString
        strTemplate = strTemplate.Replace("____blClassName____", className)
        strTemplate = strTemplate.Replace("____entClassName____", entClassName)
        strTemplate = strTemplate.Replace("____daClassName____", daClassName)
        strTemplate = strTemplate.Replace("____ClassValidationString____", ClassValidationString)
        strTemplate = strTemplate.Replace("____ConstructorValues____", ConstructorValues)

        Return strTemplate
    End Function

    Private ReadOnly Property STORED_BrainworkSupport_GetTable_QUERY() As String
        Get
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("")
            sb.AppendLine("CREATE PROCEDURE [dbo].[BrainworkSupport_GetTable]")
            sb.AppendLine("				@tablaname varChar(max)			")
            sb.AppendLine("AS")
            sb.AppendLine("BEGIN")
            sb.AppendLine("	SET NOCOUNT ON;")
            sb.AppendLine("	")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("declare @propiedades2 as table(COLUMN_NAME sql_variant, COLUMN_DESCRIPTION sql_variant)")
            sb.AppendLine("declare @propiedades  as table(COLUMN_NAME sql_variant, COLUMN_DESCRIPTION sql_variant)")
            sb.AppendLine("Insert Into @propiedades2")
            sb.AppendLine("SELECT")
            sb.AppendLine("		c.name AS COLUMN_NAME ,")
            sb.AppendLine("		ep.value AS COLUMN_DESCRIPTION")
            sb.AppendLine("")
            sb.AppendLine("FROM        sys.schemas o")
            sb.AppendLine("			left join sys.tables b on (b.schema_id = o.schema_id)")
            sb.AppendLine("			INNER JOIN sys.extended_properties ep  ON b.object_id = ep.major_id")
            sb.AppendLine("            --INNER JOIN sys.schemas s ON o.schema_id = s.schema_id")
            sb.AppendLine("            LEFT JOIN syscolumns c  ON ep.minor_id = c.colid")
            sb.AppendLine("            AND ep.major_id = c.id")
            sb.AppendLine(" WHERE      o.name is not null and b.name is not null")
            sb.AppendLine("			And quotename(o.name) + '.' + quotename(b.name)  =   @tablaname")
            sb.AppendLine("ORDER BY   COLUMN_NAME")
            sb.AppendLine("")
            sb.AppendLine("Declare @COLUMN_NAME as sql_variant")
            sb.AppendLine("Declare @COLUMN_DESCRIPTION as sql_variant")
            sb.AppendLine("Declare @COLUMN_NAME_ANTERIOR as sql_variant")
            sb.AppendLine("DECLARE CUR_MOVENTRADAS CURSOR")
            sb.AppendLine("FOR")
            sb.AppendLine("	Select COLUMN_NAME, COLUMN_DESCRIPTION From @propiedades2")
            sb.AppendLine("")
            sb.AppendLine("OPEN CUR_MOVENTRADAS")
            sb.AppendLine("")
            sb.AppendLine("FETCH NEXT FROM CUR_MOVENTRADAS INTO @COLUMN_NAME,  @COLUMN_DESCRIPTION")
            sb.AppendLine("")
            sb.AppendLine("WHILE (@@FETCH_STATUS = 0)")
            sb.AppendLine("BEGIN")
            sb.AppendLine("	")
            sb.AppendLine("   if @COLUMN_NAME_ANTERIOR = @COLUMN_NAME Begin")
            sb.AppendLine("	   Update @propiedades Set COLUMN_DESCRIPTION =  Convert(sql_variant, Convert(varchar(5000),@COLUMN_DESCRIPTION) + ' - '  + Convert(varchar(5000), COLUMN_DESCRIPTION)) Where  COLUMN_NAME = @COLUMN_NAME")
            sb.AppendLine("   End")
            sb.AppendLine("   Else")
            sb.AppendLine("		Begin")
            sb.AppendLine("			insert Into @propiedades ( COLUMN_NAME, COLUMN_DESCRIPTION) Values (@COLUMN_NAME,@COLUMN_DESCRIPTION)")
            sb.AppendLine("		End")
            sb.AppendLine("")
            sb.AppendLine("	set @COLUMN_NAME_ANTERIOR = @COLUMN_NAME")
            sb.AppendLine("	-- Avanzamos otro registro")
            sb.AppendLine("	fetch next from CUR_MOVENTRADAS")
            sb.AppendLine("    into  @COLUMN_NAME, @COLUMN_DESCRIPTION")
            sb.AppendLine("END")
            sb.AppendLine("")
            sb.AppendLine("-- cerramos el cursor")
            sb.AppendLine("close CUR_MOVENTRADAS")
            sb.AppendLine("deallocate CUR_MOVENTRADAS")
            sb.AppendLine("")
            sb.AppendLine("")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("declare @detalle as table(COLUMN_NAME sql_variant, COLUMN_DEFAULT sql_variant,IS_NULLABLE sql_variant,DATA_TYPE sql_variant ,ORDINAL_POSITION sql_variant, CHARACTER_MAXIMUM_LENGTH sql_variant, NUMERIC_PRECISION sql_variant,NUMERIC_SCALE sql_variant)")
            sb.AppendLine("Insert Into @detalle")
            sb.AppendLine("SELECT  isq.COLUMN_NAME, isq.COLUMN_DEFAULT, isq.IS_NULLABLE, isq.DATA_TYPE ,")
            sb.AppendLine("		isq.ORDINAL_POSITION,")
            sb.AppendLine("		isq.CHARACTER_MAXIMUM_LENGTH,")
            sb.AppendLine("		isq.NUMERIC_PRECISION,")
            sb.AppendLine("		isq.NUMERIC_SCALE")
            sb.AppendLine("FROM        sys.objects o")
            sb.AppendLine("			LEFT JOIN sys.schemas s")
            sb.AppendLine("				ON o.schema_id = s.schema_id")
            sb.AppendLine("			LEFT Join INFORMATION_SCHEMA.COLUMNS isq 			")
            sb.AppendLine("				On isq.TABLE_NAME =  o.Name")
            sb.AppendLine("")
            sb.AppendLine("WHERE o.type IN ('U')AND quotename(isq.TABLE_SCHEMA) + '.' + quotename(isq.TABLE_NAME) = @tablaname")
            sb.AppendLine("Order By COLUMN_NAME")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("declare @claves as table(COLUMN_NAME sql_variant, COLUMN_KEY int)")
            sb.AppendLine("Insert Into @claves")
            sb.AppendLine("select  c.name as COLUMN_NAME, 1 As COLUMN_KEY")
            sb.AppendLine("from sys.key_constraints as k")
            sb.AppendLine("		join sys.tables as t")
            sb.AppendLine("			on t.object_id = k.parent_object_id")
            sb.AppendLine("		join sys.schemas as s")
            sb.AppendLine("			on s.schema_id = t.schema_id")
            sb.AppendLine("		join sys.index_columns as ic")
            sb.AppendLine("			on ic.object_id = t.object_id and ic.index_id = k.unique_index_id")
            sb.AppendLine("		join sys.columns as c")
            sb.AppendLine("			on c.object_id = t.object_id and c.column_id = ic.column_id")
            sb.AppendLine("Where quotename(s.name) + '.' + quotename(t.name)  = @tablaname order by COLUMN_NAME")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("declare @foraneas as Table (K_Table sql_variant, FK_Column sql_variant, PK_Table sql_variant, PK_Column sql_variant, Constraint_Name sql_variant)")
            sb.AppendLine("insert into @foraneas")
            sb.AppendLine("SELECT")
            sb.AppendLine("       K_Table  = FK.TABLE_NAME,")
            sb.AppendLine("       FK_Column = CU.COLUMN_NAME,")
            sb.AppendLine("       PK_Table  = PK.TABLE_NAME,")
            sb.AppendLine("       PK_Column = PT.COLUMN_NAME,")
            sb.AppendLine("       Constraint_Name = C.CONSTRAINT_NAME")
            sb.AppendLine("FROM       INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS C")
            sb.AppendLine("INNER JOIN  INFORMATION_SCHEMA.TABLE_CONSTRAINTS FK ON C.CONSTRAINT_NAME = FK.CONSTRAINT_NAME")
            sb.AppendLine("INNER JOIN      INFORMATION_SCHEMA.TABLE_CONSTRAINTS PK ON C.UNIQUE_CONSTRAINT_NAME = PK.CONSTRAINT_NAME")
            sb.AppendLine("INNER JOIN      INFORMATION_SCHEMA.KEY_COLUMN_USAGE CU ON C.CONSTRAINT_NAME = CU.CONSTRAINT_NAME")
            sb.AppendLine("INNER JOIN  (")
            sb.AppendLine("       SELECT      i1.TABLE_NAME, i2.COLUMN_NAME")
            sb.AppendLine("       FROM        INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1")
            sb.AppendLine("           INNER JOIN      INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME")
            sb.AppendLine("               WHERE       i1.CONSTRAINT_TYPE = 'PRIMARY KEY'")
            sb.AppendLine("       ) PT ON PT.TABLE_NAME = PK.TABLE_NAME")
            sb.AppendLine("Where CU.COLUMN_NAME <> PT.COLUMN_NAME AND quotename(FK.TABLE_SCHEMA) + '.' + quotename(FK.TABLE_NAME)  = @tablaname  --FK.TABLE_NAME Like 'ProductVendor'")
            sb.AppendLine("")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("Select d.COLUMN_NAME ,d.COLUMN_DEFAULT")
            sb.AppendLine("	   , d.IS_NULLABLE, d.DATA_TYPE")
            sb.AppendLine("	   , d.ORDINAL_POSITION")
            sb.AppendLine("")
            sb.AppendLine("		,Case")
            sb.AppendLine("			When Not d.CHARACTER_MAXIMUM_LENGTH is Null Then d.CHARACTER_MAXIMUM_LENGTH")
            sb.AppendLine("			When Not d.NUMERIC_PRECISION is Null Then d.NUMERIC_PRECISION")
            sb.AppendLine("			Else")
            sb.AppendLine("				Case When  Convert(varchar(50), d.DATA_TYPE) like '%varchar' Then 4000")
            sb.AppendLine("					Else NULL")
            sb.AppendLine("				End")
            sb.AppendLine("		End As [Precision]")
            sb.AppendLine("")
            sb.AppendLine("	   , d.NUMERIC_SCALE ,")
            sb.AppendLine("			Case When p.COLUMN_DESCRIPTION is Null then d.COLUMN_NAME Else p.COLUMN_DESCRIPTION End as COLUMN_DESCRIPTION,")
            sb.AppendLine("			Case When c.COLUMN_KEY is Null then 0 else 1 End As COLUMN_KEY,K_Table ,")
            sb.AppendLine("			FK_Column, PK_Table, PK_Column, Constraint_Name")
            sb.AppendLine("	From @detalle d")
            sb.AppendLine("		Left join @claves c On c.COLUMN_NAME = d.COLUMN_NAME")
            sb.AppendLine("		Left Join @propiedades p on p.COLUMN_NAME = d.COLUMN_NAME")
            sb.AppendLine("		Left Join @foraneas f On d.COLUMN_NAME = f.FK_COLUMN")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("")
            sb.AppendLine("")
            sb.AppendLine("")
            sb.AppendLine("END")

            Return sb.ToString
        End Get

    End Property
    Public ABM_Prefix As String = "ABM_"
    Public ENTITY_Prefix As String = "Ent"
    Public BUSSINES_LOGIC_Prefix As String = "Bl"
    Public DATA_ACCESS_Prefix As String = "Da"
    Private _OUTPUTPAT As String = "c:\PruebaGenerador\"

    Public Property OUTPUTPAT() As String
        Get
            Return _OUTPUTPAT
        End Get
        Set(ByVal value As String)
            _OUTPUTPAT = value
        End Set
    End Property
    Public SUBDIR_CLASS_ENTITY As String = "Entity"
    Public SUBDIR_CLASS_BUSSINES As String = "BussinesLogic"
    Public SUBDIR_CLASS_DATAACCES As String = "DataAccess"
    Public SUBDIR_CLASS_PROCEDURES As String = "StoredProcedures"

    Public Property Connection() As SqlClient.SqlConnection
        Get
            Return _Connection
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            _Connection = value
        End Set
    End Property

    Public Property CnnString() As String
        Get
            Return _cnnString
        End Get
        Set(ByVal value As String)
            _cnnString = value
        End Set
    End Property

    Private Sub OpenConnection()
        If Me._Connection Is Nothing Then
            Me._Connection = New SqlClient.SqlConnection(CnnString)
        End If
        Me._Connection.Open()
    End Sub




    Friend Shared Function GetDbType(ByVal type As Type) As DbType

        Return GetDbType(type.Name)
    End Function

    Friend Shared Function GetSqlDBType(ByVal theType As Type) As SqlDbType

        If theType.Name.ToLower.Contains("byte") Then
            Return SqlDbType.Binary
        End If


        Dim p1 As SqlClient.SqlParameter
        Dim tc As System.ComponentModel.TypeConverter
        p1 = New SqlClient.SqlParameter()
        tc = System.ComponentModel.TypeDescriptor.GetConverter(p1.DbType)
        If tc.CanConvertFrom(theType) Then
            p1.DbType = tc.ConvertFrom(theType.Name)
        Else
            'Try brute force
            Try
                p1.DbType = tc.ConvertFrom(theType.Name)
            Catch ex As Exception
                'Do Nothing
            End Try
        End If
        Return p1.SqlDbType

    End Function

    Friend Shared Function GetDbType(ByVal name As String) As DbType


        If name.ToLower.Contains("byte") Then
            Return DbType.Byte
        End If
        ' default value
        Dim val As DbType = DbType.String
        Try
            val = DirectCast([Enum].Parse(GetType(DbType), name, True), DbType)
        Catch generatedExceptionName As Exception
            Throw generatedExceptionName
        End Try
        Return val
    End Function



    Private Function GetColumnExtendInformation(ByVal tableName As String, ByVal field As String) As Data.DataColumn
        Dim query As String = "SELECT [" & field & "]  FROM " & tableName & "   WHERE  1=0"
        Dim dt As DataTable = New DataTable
        Dim fd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, Me.Connection)
        fd.Fill(dt)

        Return dt.Columns(0)



    End Function

    Public Sub FillTables()
        OpenConnection()
        Dim query As String
        Dim oCmd As SqlClient.SqlCommand
        Dim fd As SqlClient.SqlDataAdapter
        Dim dt As New DataTable


        query = "SELECT Name FROM sys.procedures Where Name Like 'BrainworkSupport_GetTable'"
        fd = New SqlClient.SqlDataAdapter(query, Me.Connection)

        fd.Fill(dt)
        If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
            oCmd = New SqlClient.SqlCommand(Me.STORED_BrainworkSupport_GetTable_QUERY, Me.Connection)
            oCmd.ExecuteNonQuery()
        End If


        ''''completo la tabla interna con todas las primarys keys'''''''''''''''
        query = "select 	c.COLUMN_NAME, c.TABLE_NAME, c.CONSTRAINT_NAME " & vbCrLf
        query += "from 	INFORMATION_SCHEMA.TABLE_CONSTRAINTS pk ," & vbCrLf
        query += "	INFORMATION_SCHEMA.KEY_COLUMN_USAGE c" & vbCrLf
        query += "where	CONSTRAINT_TYPE = 'PRIMARY KEY'" & vbCrLf
        query += "and	c.TABLE_NAME = pk.TABLE_NAME" & vbCrLf
        query += "and	c.CONSTRAINT_NAME = pk.CONSTRAINT_NAME" & vbCrLf
        query += "Order By c.COLUMN_NAME , LEN(c.CONSTRAINT_NAME)" & vbCrLf

        Me.dtKeys = New DataTable
        fd = New SqlClient.SqlDataAdapter(query, Me.Connection)
        fd.Fill(dtKeys)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''




        'query = "SELECT Distinct  o.Name AS ObjectName FROM sys.objects o WHERE  o.type IN ('U') Order By o.Name"
        query = "select Distinct quotename(a.name) + '.' + quotename(b.name) as ObjectName   from sys.schemas a   left join sys.tables b on (b.schema_id = a.schema_id)  where a.name is not null and b.name is not null   order by ObjectName"
        dt = New DataTable
        fd = New SqlClient.SqlDataAdapter(query, Me.Connection)
        fd.Fill(dt)

        For Each dr As DataRow In dt.Rows
            Dim TableNameString As String

            TableNameString = dr("ObjectName")
            query = "EXEC BrainworkSupport_GetTable N'" & TableNameString & "'"

            oCmd = New SqlClient.SqlCommand()
            oCmd.Connection = Me.Connection
            oCmd.CommandType = CommandType.Text
            oCmd.CommandText = query
            Dim dt2 As New DataTable
            fd = New SqlClient.SqlDataAdapter(oCmd)
            fd.Fill(dt2)


            Dim AuxiliaryClassExtends As New BrainWork.Entities.EntityClassExtendsAttribute
            Dim AuxiliaryFieldExtends As New List(Of BrainWork.Entities.EntityFieldExtendsAttribute)

            Dim DescriptionFieldName As String = ""
            Dim EnabledField As String = Nothing
            Dim PrimaryKeyFieldName As String = ""
            Dim IsFirstRecord As Boolean = True


            For i As Integer = 0 To dt2.Rows.Count - 1
                Dim COLUMN_NAME As String = CType((dt2.Rows(i)("COLUMN_NAME")), String)
                Dim COLUMN_DEFAULT As String = CType(dbValue(dt2.Rows(i)("COLUMN_DEFAULT")), String)
                Dim IS_NULLABLE As String = CType(dbValue(dt2.Rows(i)("IS_NULLABLE")), String)
                Dim DATA_TYPE As String = CType(dbValue(dt2.Rows(i)("DATA_TYPE")), String)
                Dim COLUMN_DESCRIPTION As String = CType(dbValue(dt2.Rows(i)("COLUMN_DESCRIPTION")), String)
                Dim COLUMN_KEY As String = dbValue(dt2.Rows(i)("COLUMN_KEY"))
                Dim K_Table As String = CType(dbValue(dt2.Rows(i)("K_Table")), String)
                Dim FK_Column As String = CType(dbValue(dt2.Rows(i)("FK_Column")), String)
                Dim PK_Table As String = CType(dbValue(dt2.Rows(i)("PK_Table")), String)
                Dim PK_Column As String = CType(dbValue(dt2.Rows(i)("PK_Column")), String)
                Dim Constraint_Name As String = CType(dbValue(dt2.Rows(i)("Constraint_Name")), String)
                Dim ORDINAL_POSITION As String = dbValue(dt2.Rows(i)("ORDINAL_POSITION"))
                Dim Precision As String = dbValue(dt2.Rows(i)("Precision"))

                If IsFirstRecord Then
                    PrimaryKeyFieldName = COLUMN_NAME
                    IsFirstRecord = False
                End If

                Dim pField As New BrainWork.Entities.EntityFieldExtendsAttribute

                pField.FieldDescription = COLUMN_DESCRIPTION

                pField.FieldName = COLUMN_NAME
                pField.DefaultValue = COLUMN_DEFAULT
                pField.MainTable = TableNameString
                pField.ParameterName = COLUMN_NAME
                pField.Order = ORDINAL_POSITION
                pField.Size = Precision
                If Not String.IsNullOrEmpty(PK_Table) Then
                    pField.RelationType = Entities.EnumRelationType.Combo
                    pField.ForeingTable = PK_Table
                    pField.ForeingCRUD = ABM_Prefix & PK_Table
                    pField.FieldType = Entities.EnumFieldType.ForeingKey
                    pField.EntityClassContainer = ENTITY_Prefix & Me.SanitizeClassName(PK_Table)
                    pField.ForeingFieldName = FK_Column
                Else
                    If dtKeys.Select("COLUMN_NAME = '" & COLUMN_NAME & "'").Length > 0 Then
                        Dim drAux() As DataRow = dtKeys.Select("COLUMN_NAME = '" & COLUMN_NAME & "'")
                        PK_Table = drAux(0)("TABLE_NAME").ToString
                        pField.RelationType = Entities.EnumRelationType.Combo
                        pField.ForeingTable = PK_Table
                        pField.ForeingCRUD = ABM_Prefix & PK_Table
                        pField.FieldType = Entities.EnumFieldType.ForeingKey
                        pField.EntityClassContainer = ENTITY_Prefix & Me.SanitizeClassName(PK_Table)
                        pField.ForeingFieldName = FK_Column


                    Else
                        pField.RelationType = Entities.EnumRelationType.TextBox
                        pField.EntityClassContainer = ENTITY_Prefix & TableNameString
                    End If

                End If


                pField.SetNullable = IS_NULLABLE.ToUpper = "YES"

                If COLUMN_KEY = "1" Then
                    pField.FieldType = Entities.EnumFieldType.PrimaryKey
                    PrimaryKeyFieldName = COLUMN_NAME
                Else
                    pField.FieldType = Entities.EnumFieldType.Field
                End If

                pField.Scale = CType(dbValue(dt2.Rows(i)("NUMERIC_SCALE")), Byte)
                pField.SourceColumn = COLUMN_NAME

                If COLUMN_NAME.ToUpper.EndsWith(DESCRIPTIONENDWITH) Then
                    DescriptionFieldName = DescriptionFieldName & COLUMN_NAME & ","
                    pField.IsDescription = True
                End If


                If COLUMN_NAME.ToUpper.EndsWith(ENABLEDDENDWITH) Then
                    EnabledField = COLUMN_NAME
                    pField.IsDescription = True
                End If


                Dim ci As Data.DataColumn = GetColumnExtendInformation(TableNameString, COLUMN_NAME)
                pField.TypeName = ci.DataType.Name

                pField.DbType = GetDbType(ci.DataType.Name)

                If pField.TypeName.Contains("Byte[]") Then
                    pField.TypeName = "Byte"
                End If

                pField.MinValue = 0
                pField.MaxValue = Precision
                AuxiliaryFieldExtends.Add(pField)
            Next


            If DescriptionFieldName.EndsWith(","c) Then
                DescriptionFieldName = Mid(DescriptionFieldName, 1, DescriptionFieldName.Length - 1)
            End If

            If DescriptionFieldName = "" Then
                DescriptionFieldName = PrimaryKeyFieldName
            End If



            AuxiliaryClassExtends.DescriptionFieldName = DescriptionFieldName
            AuxiliaryClassExtends.PrimaryKeyFieldName = PrimaryKeyFieldName
            AuxiliaryClassExtends.RootContainerName = TableNameString
            AuxiliaryClassExtends.EnableFieldName = EnabledField

            Me.Tables.Add(TableNameString, AuxiliaryClassExtends)

            Dim esPrimero As Boolean = True
            Dim defaultOrderByItem As Integer = 0
            For i As Integer = 0 To AuxiliaryFieldExtends.Count - 1
                Dim item As BrainWork.Entities.EntityFieldExtendsAttribute = AuxiliaryFieldExtends(i)

                If item.FieldType = Entities.EnumFieldType.PrimaryKey Then
                    defaultOrderByItem = i
                    Exit For
                End If
            Next
            AuxiliaryFieldExtends.Item(defaultOrderByItem).DefaultOrderBy = True


            Me.TablesFields.Add(TableNameString, AuxiliaryFieldExtends)

        Next


    End Sub


    Private Sub AddFieldsAttributes(ByRef sbB As System.Text.StringBuilder, ByVal Efield As BrainWork.Entities.EntityFieldExtendsAttribute)
        Dim AuxString As String = ""
        sbB.AppendLine()
        sbB.Append("<BrainWork.Entities.EntityFieldExtendsAttribute(")


        '"DbType:=DbType.String, 
        If Not Efield.DbType = Nothing Then
            AuxString = AuxString & "DbType:=DbType." & [Enum].GetName(Efield.DbType.GetType, Efield.DbType) & ","
        End If

        'DefaultValue:="", 
        If Not Efield.DefaultValue Is Nothing Then
            AuxString = AuxString & "DefaultValue:=""" & Efield.DefaultValue.ToString & ""","
        End If

        'Direction:=ParameterDirection.Input, 
        If Not Efield.Direction = Nothing Then
            AuxString = AuxString & "Direction:=Direction." & [Enum].GetName(Efield.Direction.GetType, Efield.Direction) & ","
        End If

        'FieldDescription:="", 
        If Not Efield.FieldDescription Is Nothing Then
            AuxString = AuxString & "FieldDescription:=""" & Efield.FieldDescription & ""","
        End If

        'FieldName:="", 
        If Not Efield.FieldName Is Nothing Then
            AuxString = AuxString & "FieldName:=""" & Efield.FieldName & ""","
        End If

        'FieldType:=EnumFieldType.Field, 
        If Not Efield.FieldType = Nothing Then
            AuxString = AuxString & "FieldType:=BrainWork.Entities.EnumFieldType." & [Enum].GetName(Efield.FieldType.GetType, Efield.FieldType) & ","
        End If
        'ForeingCRUD:="", 
        If Not Efield.ForeingCRUD Is Nothing Then
            AuxString = AuxString & "ForeingCRUD:=""" & Efield.ForeingCRUD & ""","
        End If

        'ForeingTable:="", 
        If Not Efield.ForeingTable Is Nothing Then
            AuxString = AuxString & "ForeingTable:=""" & Efield.ForeingTable & ""","
        End If

        'MainTable:="", 
        If Not Efield.MainTable Is Nothing Then
            AuxString = AuxString & "MainTable:=""" & Efield.MainTable & ""","
        End If

        'Order:=0, 
        If Not Efield.Order = Nothing Then
            AuxString = AuxString & "Order:=" & Efield.Order & ","
        End If

        'ParameterName:="", 
        If Not Efield.ParameterName Is Nothing Then
            AuxString = AuxString & "ParameterName:=""" & Efield.ParameterName & ""","
        End If

        'Precision:="", 
        If Not Efield.Precision = Nothing Then
            AuxString = AuxString & "Precision:=" & Efield.Precision & ","
        End If

        'RelationType:=EnumRelationType.PopUp, 
        If Not Efield.RelationType = Nothing Then
            AuxString = AuxString & "RelationType:=BrainWork.Entities.EnumRelationType." & [Enum].GetName(Efield.RelationType.GetType, Efield.RelationType) & ","
        End If

        'Scale:=0, 
        If Not Efield.Scale = Nothing Then
            AuxString = AuxString & "Scale:=" & Efield.Scale.ToString & ","
        End If

        'SetNullable:=True, 
        If Not Efield.IsNullable = Nothing Then
            AuxString = AuxString & "SetNullable:=" & Efield.IsNullable.ToString & ","
        End If

        'size:=0, 
        If Not Efield.Size = Nothing Then
            AuxString = AuxString & "Size:=" & Efield.Size.ToString & ","
        End If

        'SourceColumn:="", 
        If Not Efield.SourceColumn Is Nothing Then
            AuxString = AuxString & "SourceColumn:=""" & Efield.SourceColumn & ""","
        End If

        'SourceVersion:=DataRowVersion.Current, 
        If Not Efield.SourceVersion = Nothing Then
            AuxString = AuxString & "SourceVersion:=" & [Enum].GetName(Efield.SourceVersion.GetType, Efield.SourceVersion) & ","
        End If

        'Value:=0, 
        If Not Efield.Value Is Nothing Then
            AuxString = AuxString & "Value:=""" & Efield.Value.ToString & ""","
        End If

        'Visibility:=EnumVisibility.Normal)> _"
        If Not Efield.Visibility = Nothing Then
            AuxString = AuxString & "Visibility:=BrainWork.Entities.EnumVisibility." & [Enum].GetName(Efield.Visibility.GetType, Efield.Visibility) & ","
        End If

        'TypeName:="")> _"
        If Not Efield.TypeName = Nothing Then
            AuxString = AuxString & "TypeName:=""" & Efield.TypeName & ""","
        End If


        'MinValue:="")> _"
        If Not Efield.MinValue = Nothing Then
            AuxString = AuxString & "MinValue:=" & Efield.MinValue & ","
        End If

        'MaxValue:="")> _"
        If Not Efield.MaxValue = Nothing Then
            AuxString = AuxString & "MaxValue:=" & Efield.MaxValue & ","
        End If

        'EntityClassContainer
        If Not Efield.EntityClassContainer Is Nothing Then
            AuxString = AuxString & "EntityClassContainer:=""" & Efield.EntityClassContainer.ToString & ""","
        End If

        'CustomValidationExpression:="")> _"
        If Not Efield.CustomValidationExpression Is Nothing Then
            AuxString = AuxString & "CustomValidationExpression:=""" & Efield.CustomValidationExpression.ToString & ""","
        End If

        'IsDescription:="")> _"
        ' If Not Efield.IsDescription Is Nothing Then
        AuxString = AuxString & "IsDescription:=" & Efield.IsDescription.ToString & ","
        '  End If


        'ForeingFieldName:="")> _"
        If Not Efield.ForeingFieldName Is Nothing Then
            AuxString = AuxString & "ForeingFieldName:=""" & Efield.ForeingFieldName.ToString & ""","
        End If

        'DefaultOrderBy:="")> _"
        AuxString = AuxString & "DefaultOrderBy:= " & Efield.DefaultOrderBy.ToString & " ,"


        sbB.Append(AuxString.Substring(0, AuxString.Length - 1))
        sbB.Append(")> _")




    End Sub

    Private Function SanitizeVariable(ByVal value As String) As String
        For i As Integer = 0 To VBPrimaryKeys.Length - 1
            If value.ToLower = VBPrimaryKeys(i).ToLower Then
                value = "[" & value & "]"
                Return value
                Exit For
            End If
        Next
        Return value
    End Function


    Private Sub PutInRegion(ByRef sb As System.Text.StringBuilder, ByVal RegionName As String)

        sb.Insert(0, "#Region """ & RegionName & """" & vbCrLf)
        sb.AppendLine("#End Region")

    End Sub

    Private Function FirstLetter(ByVal value As String) As String
        Return UCase(value.Substring(0, 1)) & value.Substring(1)
    End Function


    Private Function createSP_Param(ByVal pField As BrainWork.Entities.EntityFieldExtendsAttribute, ByVal ci As DataColumn) As String
        'smallint
        Dim variableDeclaration As String = [Enum].GetName(GetSqlDBType(ci.DataType).GetType, GetSqlDBType(ci.DataType))

        Dim SizeDeclaration As String = IIf(((variableDeclaration.ToLower <> "int") AndAlso (variableDeclaration.ToLower <> "smallint")) AndAlso (Not pField.Size = Nothing AndAlso pField.Size > 0), "(" & pField.Size & ")", "").ToString

        Return "@" & pField.FieldName.Replace(" "c, "_") & " As " & variableDeclaration & SizeDeclaration

    End Function



    Private Function createOrderBy(ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute), ByVal TableName As String) As String
        Dim strValue As String = ""

        Dim variableDeclarationAsc As String = ""
        Dim variableDeclarationDesc As String = ""
        Dim hasPassedVerification As Boolean = False
        variableDeclarationAsc += "					CASE " & vbCrLf
        variableDeclarationDesc += "					CASE " & vbCrLf
        For Each item As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            Dim ci As DataColumn = GetColumnExtendInformation(TableName, item.FieldName)
            If isValidWhereFieldQuery("as " & [Enum].GetName(GetSqlDBType(ci.DataType).GetType, GetSqlDBType(ci.DataType))) Then
                hasPassedVerification = True
                Dim vdec() As String = item.FieldName.Split("."c)
                Dim dec As String = vdec(vdec.Length - 1)
                If Not dec.Trim.Contains("["c) Then
                    dec = "[" & dec & "]"
                End If


                variableDeclarationDesc += "                         WHEN  Upper(" & ORDER_BY_DIRECTION_PARAMETER & ") = Upper('" & item.FieldName & "') THEN (RANK() OVER (ORDER BY " & dec & " DESC))  " & vbCrLf

                variableDeclarationAsc += "                         WHEN  Upper(" & ORDER_BY_DIRECTION_PARAMETER & ") = Upper('" & item.FieldName & "') THEN (RANK() OVER (ORDER BY " & dec & " ))  " & vbCrLf


            End If
        Next
        variableDeclarationAsc += "                    END " & vbCrLf
        variableDeclarationDesc += "                    END " & vbCrLf

        strValue += "   ORDER BY " & vbCrLf
        strValue += "		 CASE WHEN NOT " & ORDER_BY_PARAMETER & " IS NULL THEN " & vbCrLf
        strValue += "				CASE WHEN  " & ORDER_BY_DIRECTION_PARAMETER & " IS NULL THEN " & vbCrLf

        strValue += variableDeclarationAsc

        strValue += "				ELSE " & vbCrLf

        strValue += variableDeclarationDesc

        strValue += "				END " & vbCrLf
        strValue += "		 END " & vbCrLf

        If hasPassedVerification Then
            Return strValue
        Else
            Return ""
        End If


    End Function

    Private Function CreateParametersForProcedure(ByVal sbProcedure As System.Text.StringBuilder, _
                                                  ByVal TableName As String, _
                                                  ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute), _
                                                  Optional ByVal CreateStandarValues As Boolean = False, _
                                                  Optional ByVal OnlyPrimaryKeys As Boolean = False) As String
        Dim auxDeclarationVariables As String = ""

        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            Dim ci As DataColumn
            ci = GetColumnExtendInformation(TableName, pField.FieldName)


            'IIf((Not pField.Size = Nothing AndAlso pField.Size > 0), "(" & pField.Size & ")", "").ToString
            If OnlyPrimaryKeys Then
                If pField.FieldType = Entities.EnumFieldType.PrimaryKey Then
                    auxDeclarationVariables += vbCrLf & "          " & createSP_Param(pField, ci) & ","
                End If
            Else
                auxDeclarationVariables += vbCrLf & "          " & createSP_Param(pField, ci) & ","
            End If


        Next


        If CreateStandarValues Then
            auxDeclarationVariables += vbCrLf & "         " & ORDER_BY_PARAMETER & " varchar(500),"
            auxDeclarationVariables += vbCrLf & "         " & ORDER_BY_DIRECTION_PARAMETER & " varchar(500),"
            auxDeclarationVariables += vbCrLf & "         " & PAGED_ROW_PARAMETER & " int,"
            auxDeclarationVariables += vbCrLf & "         " & PAGED_MAXVALUES_PARAMETER & " int,"
            auxDeclarationVariables += vbCrLf & "         " & PAGED_COUNT_PARAMETER & " bigint OUTPUT "
            '
        Else
            If String.IsNullOrEmpty(auxDeclarationVariables) Then

                Dim ci As DataColumn
                ci = GetColumnExtendInformation(TableName, listefield(0).FieldName)


                auxDeclarationVariables += vbCrLf & "         " & Me.createSP_Param(listefield(0), ci) & ","


            End If
            auxDeclarationVariables = auxDeclarationVariables.Substring(0, auxDeclarationVariables.Length - 1)
        End If


        Return auxDeclarationVariables
    End Function

    Private Function SanitizeTableName(ByVal tablename As String) As String
        Return "tbl" & tablename.Replace("[dbo].", "").Replace("."c, "_"c).Replace(" "c, "_").Replace("["c, "").Replace("]"c, "")
    End Function

    Private Function CreateSelectForProcedure(ByVal TableName As String, _
                                                    ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute), _
                                                    Optional ByVal prefix As String = "", _
                                                    Optional ByVal WithDescriptionField As Boolean = True) As String
        Dim auxDeclarationVariables As String = prefix & "SELECT "

        Dim innerJoinValues As String = ""
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            Dim ci As DataColumn
            ci = GetColumnExtendInformation(TableName, pField.FieldName)

            auxDeclarationVariables += vbCrLf & prefix & SanitizeTableName(TableName) & ".[" & pField.FieldName & "] ,"

            If pField.FieldType = Entities.EnumFieldType.ForeingKey Then ' si es clave externa
                innerJoinValues += vbCrLf & prefix & vbTab & " Inner Join " & pField.ForeingTable & " " & SanitizeTableName(pField.ForeingTable)

                innerJoinValues += vbCrLf & prefix & vbTab & vbTab & " On " & SanitizeTableName(TableName) & ".[" & pField.FieldName & "] "

                innerJoinValues += " = " & SanitizeTableName(pField.ForeingTable) & ".[" & pField.ForeingFieldName & "]   "

                If WithDescriptionField Then
                    For Each item As BrainWork.Entities.EntityFieldExtendsAttribute In TablesFields(pField.ForeingTable)
                        If item.IsDescription Then
                            If auxDeclarationVariables.Contains(SanitizeTableName(pField.ForeingTable) & ".[" & pField.FieldName & "] ,") Then
                                auxDeclarationVariables += vbCrLf & prefix & SanitizeTableName(pField.ForeingTable) & ".[" & pField.FieldName & "] As " & SanitizeTableName(pField.ForeingTable) & pField.FieldName.Replace(" "c, "_") & ","
                            Else
                                auxDeclarationVariables += vbCrLf & prefix & SanitizeTableName(pField.ForeingTable) & ".[" & pField.FieldName & "] ,"
                            End If

                        End If
                    Next
                End If

            End If



        Next

        auxDeclarationVariables = auxDeclarationVariables.Substring(0, auxDeclarationVariables.Length - 1)
        auxDeclarationVariables += vbCrLf & prefix & " From " & TableName & " " & SanitizeTableName(TableName) & innerJoinValues


        Return auxDeclarationVariables
    End Function


    Private Function CreateInsertProcedeure(ByRef sbInsertProcedure As System.Text.StringBuilder, _
                                       ByRef TableName As String, _
                                       ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String
        CreateInsertProcedeure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_Insert"
        sbInsertProcedure.AppendLine("Create PROCEDURE  " & CreateInsertProcedeure)
        ' sbInsertProcedure.AppendLine("                                                                    ")



        sbInsertProcedure.AppendLine(CreateParametersForProcedure(sbInsertProcedure, TableName, listefield, False))

        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            If pField.FieldType = Entities.EnumFieldType.PrimaryKey Then
                Dim ci As DataColumn = Me.GetColumnExtendInformation(TableName, pField.FieldName)
                Dim variableDeclaration As String = [Enum].GetName(GetSqlDBType(ci.DataType).GetType, GetSqlDBType(ci.DataType))

                Dim SizeDeclaration As String = IIf(((variableDeclaration.ToLower <> "int") AndAlso (variableDeclaration.ToLower <> "smallint")) AndAlso (Not pField.Size = Nothing AndAlso pField.Size > 0), "(" & pField.Size & ")", "").ToString

                sbInsertProcedure.AppendLine(vbCrLf & "           , @ID_Generated_New As " & _
                                            variableDeclaration & _
                                            SizeDeclaration & " output")
                Exit For
            End If

        Next
        sbInsertProcedure.AppendLine()


        sbInsertProcedure.AppendLine("AS")
        sbInsertProcedure.AppendLine("BEGIN")
        sbInsertProcedure.AppendLine("    SET NOCOUNT ON;")
        sbInsertProcedure.AppendLine("")

        sbInsertProcedure.AppendLine("    BEGIN TRY")
        sbInsertProcedure.AppendLine("        INSERT INTO " & TableName)
        sbInsertProcedure.AppendLine("            ( ")

        Dim auxValues As String = ""
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            auxValues += vbCrLf & "              [" & pField.FieldName & "],"

        Next
        auxValues = auxValues.Substring(0, auxValues.Length - 1)
        sbInsertProcedure.Append(auxValues & vbCrLf)


        sbInsertProcedure.AppendLine("             )")
        sbInsertProcedure.AppendLine("        VALUES ")
        sbInsertProcedure.AppendLine("              (")

        auxValues = ""
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            auxValues += vbCrLf & "              @" & pField.FieldName.Replace(" "c, "_") & ","

        Next
        auxValues = auxValues.Substring(0, auxValues.Length - 1)
        sbInsertProcedure.Append(auxValues & vbCrLf)

        sbInsertProcedure.AppendLine("              );")

        If sbInsertProcedure.ToString.Contains("@ID_Generated_New") Then
            sbInsertProcedure.AppendLine("              Set @ID_Generated_New = SCOPE_IDENTITY();")
        End If


        sbInsertProcedure.AppendLine("    END TRY")
        sbInsertProcedure.AppendLine("    BEGIN CATCH")
        sbInsertProcedure.AppendLine("       DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbInsertProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbInsertProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbInsertProcedure.AppendLine("    END CATCH;")
        sbInsertProcedure.AppendLine("END;")

        sbInsertProcedure.AppendLine("GO")

    End Function



    Private Function isValidWhereFieldQuery(ByVal saux As String) As Boolean
        Return Not (saux.ToLower.Contains("as text") _
              OrElse saux.ToLower.Contains("as nvarchar") _
              OrElse saux.ToLower.Contains("as xml"))
    End Function


    Private Function CreateUpdateProcedeure(ByRef sbUpdateProcedure As System.Text.StringBuilder, _
                                      ByRef TableName As String, _
                                      ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String

        CreateUpdateProcedeure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_Update"
        sbUpdateProcedure.AppendLine("Create PROCEDURE  " & CreateUpdateProcedeure)
        'sbUpdateProcedure.AppendLine("                                                                    ")

        Dim auxValues As String = ""

        sbUpdateProcedure.Append(CreateParametersForProcedure(sbUpdateProcedure, TableName, listefield, False) & vbCrLf)


        sbUpdateProcedure.AppendLine("AS")
        sbUpdateProcedure.AppendLine("BEGIN")
        sbUpdateProcedure.AppendLine("    SET NOCOUNT ON;")
        sbUpdateProcedure.AppendLine("")

        sbUpdateProcedure.AppendLine("    BEGIN TRY")
        sbUpdateProcedure.AppendLine("        Update " & TableName)
        sbUpdateProcedure.AppendLine("            SET ")

        auxValues = ""
        Dim WhereExpression As String = ""
        Dim isFirst As Boolean = True
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
            If isValidWhereFieldQuery(saux) Then


                'default where con el primero que encuentra
                If isFirst Then
                    isFirst = False
                    WhereExpression = vbCrLf & "              Where [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
                End If

                Dim sAuxa As String = createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))

                If pField.FieldType <> Entities.EnumFieldType.PrimaryKey Then
                    auxValues += vbCrLf & "              [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ","
                ElseIf isValidWhereFieldQuery(saux) Then
                    WhereExpression = vbCrLf & "              Where [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
                End If

            End If

        Next
        Dim PasedByValidValues As Boolean = False
        If Not String.IsNullOrEmpty(auxValues) Then
            auxValues = auxValues.Substring(0, auxValues.Length - 1)
            PasedByValidValues = True
        Else
            auxValues += vbCrLf & "              [" & listefield(0).FieldName & "] = @" & listefield(0).FieldName.Replace(" "c, "_")
        End If

        If String.IsNullOrEmpty(WhereExpression) OrElse String.IsNullOrEmpty(auxValues) Then
            PasedByValidValues = False
        End If

        sbUpdateProcedure.Append(auxValues & vbCrLf)



        sbUpdateProcedure.AppendLine("              " & WhereExpression & ";")
        If Not PasedByValidValues Then
            sbUpdateProcedure.AppendLine("		 RAISERROR ('No se han declarado valores para el filtro correspondiente' , 16, 1);")
        End If
        sbUpdateProcedure.AppendLine("    END TRY")
        sbUpdateProcedure.AppendLine("    BEGIN CATCH")
        sbUpdateProcedure.AppendLine("       DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbUpdateProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbUpdateProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbUpdateProcedure.AppendLine("    END CATCH;")
        sbUpdateProcedure.AppendLine("END;")

        sbUpdateProcedure.AppendLine("GO")

    End Function


    Private Function CreateUpdateByPKProcedeure(ByRef sbUpdateProcedure As System.Text.StringBuilder, _
                                      ByRef TableName As String, _
                                      ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String

        CreateUpdateByPKProcedeure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_UpdateByPK"
        sbUpdateProcedure.AppendLine("Create PROCEDURE  " & CreateUpdateByPKProcedeure)
        Dim auxValues As String = ""

        sbUpdateProcedure.Append(CreateParametersForProcedure(sbUpdateProcedure, TableName, listefield, False) & vbCrLf)


        sbUpdateProcedure.AppendLine("AS")
        sbUpdateProcedure.AppendLine("BEGIN")
        sbUpdateProcedure.AppendLine("    SET NOCOUNT ON;")
        sbUpdateProcedure.AppendLine("")

        sbUpdateProcedure.AppendLine("    BEGIN TRY")
        sbUpdateProcedure.AppendLine("        Update " & TableName)
        sbUpdateProcedure.AppendLine("            SET ")

        auxValues = ""
        Dim WhereExpression As String = ""
        Dim isFirst As Boolean = True
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            'default where con el primero que encuentra
            If isFirst Then
                WhereExpression = vbCrLf & "              Where [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
            End If
            Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))



            If pField.FieldType = Entities.EnumFieldType.PrimaryKey Then
                If isFirst Then
                    isFirst = False
                    WhereExpression = ""
                End If
                Dim pval As String
                If WhereExpression.Contains("Where") Then
                    pval = "AND"
                Else
                    pval = "Where"
                End If
                If isValidWhereFieldQuery(saux) Then
                    WhereExpression += vbCrLf & "              " & pval & " [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
                End If
            Else

                auxValues += vbCrLf & "              [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ","

            End If



        Next
        auxValues = auxValues.Substring(0, auxValues.Length - 1)
        sbUpdateProcedure.Append(auxValues & vbCrLf)



        sbUpdateProcedure.AppendLine("              " & WhereExpression & ";")
        sbUpdateProcedure.AppendLine("    END TRY")
        sbUpdateProcedure.AppendLine("    BEGIN CATCH")
        sbUpdateProcedure.AppendLine("       DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbUpdateProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbUpdateProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbUpdateProcedure.AppendLine("    END CATCH;")
        sbUpdateProcedure.AppendLine("END;")

        sbUpdateProcedure.AppendLine("GO")

    End Function

    Private Function CreateDisableProcedeure(ByRef sbUpdateProcedure As System.Text.StringBuilder, _
                                     ByRef TableName As String, _
                                     ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String

        CreateDisableProcedeure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_Disable"
        sbUpdateProcedure.AppendLine("Create PROCEDURE  " & CreateDisableProcedeure)
        Dim auxValues As String = ""

        sbUpdateProcedure.Append(CreateParametersForProcedure(sbUpdateProcedure, TableName, listefield, False, True) & vbCrLf)


        sbUpdateProcedure.AppendLine("AS")
        sbUpdateProcedure.AppendLine("BEGIN")
        sbUpdateProcedure.AppendLine("    SET NOCOUNT ON;")
        sbUpdateProcedure.AppendLine("")

        sbUpdateProcedure.AppendLine("    BEGIN TRY")
        sbUpdateProcedure.AppendLine("        Update " & TableName)
        sbUpdateProcedure.AppendLine("            SET ")

        auxValues = ""
        Dim WhereExpression As String = ""

        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield



            Dim pval As String
            If WhereExpression.Contains("Where") Then
                pval = "AND"
            Else
                pval = "Where"
            End If

            If pField.IsPK Then
                WhereExpression += vbCrLf & "              " & pval & " [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
            End If


            If pField.IsEnableField = True AndAlso pField.FieldType <> Entities.EnumFieldType.PrimaryKey AndAlso isValidWhereFieldQuery(Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))) Then
                auxValues += vbCrLf & "              [" & pField.FieldName & "] = " & pField.DefaultValue.ToString & ","
            End If


        Next
        If auxValues = "" Then
            auxValues = "/*Atención debe seleccionar un valor para deshabilitar*/              [" & listefield(0).FieldName & "] = NULL,"
        End If
        '& vbCrLf & 


        If String.IsNullOrEmpty(WhereExpression) Then
            WhereExpression = vbCrLf & "              Where [" & listefield(0).FieldName & "] = @" & listefield(0).FieldName.Replace(" "c, "_")
        End If
        auxValues = auxValues.Substring(0, auxValues.Length - 1)
        sbUpdateProcedure.Append(auxValues & vbCrLf)



        sbUpdateProcedure.AppendLine("              " & WhereExpression & ";")

        If auxValues.Contains("/*Atención debe seleccionar un valor para deshabilitar*/") Then
            sbUpdateProcedure.AppendLine(" RAISERROR ('Atención debe seleccionar un valor para deshabilitar', 16, 1)")
        End If

        sbUpdateProcedure.AppendLine("    END TRY")


        sbUpdateProcedure.AppendLine("    BEGIN CATCH")
        sbUpdateProcedure.AppendLine("       DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbUpdateProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbUpdateProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbUpdateProcedure.AppendLine("    END CATCH;")
        sbUpdateProcedure.AppendLine("END;")

        sbUpdateProcedure.AppendLine("GO")

    End Function


    Private Function CreateDeleteProcedeure(ByRef sbUpdateProcedure As System.Text.StringBuilder, _
                                            ByRef TableName As String, _
                                            ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String

        CreateDeleteProcedeure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_Delete"
        sbUpdateProcedure.AppendLine("Create PROCEDURE  " & CreateDeleteProcedeure)
        'sbUpdateProcedure.AppendLine("                                                                    ")

        Dim auxValues As String = ""

        sbUpdateProcedure.Append(CreateParametersForProcedure(sbUpdateProcedure, TableName, listefield, False, True) & vbCrLf)


        sbUpdateProcedure.AppendLine("AS")
        sbUpdateProcedure.AppendLine("BEGIN")
        sbUpdateProcedure.AppendLine("    SET NOCOUNT ON;")
        sbUpdateProcedure.AppendLine("")

        sbUpdateProcedure.AppendLine("    BEGIN TRY")
        sbUpdateProcedure.AppendLine("        Delete From " & TableName)


        Dim WhereExpression As String = ""
        Dim isFirst As Boolean = True
        Dim isPassedByValidValue As Boolean = False
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            'default where con el primero que encuentra
            If isFirst Then
                WhereExpression = vbCrLf & "              Where [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
            End If

            Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
            If isValidWhereFieldQuery(saux) AndAlso pField.IsPK Then


                If pField.FieldType = Entities.EnumFieldType.PrimaryKey Then
                    If isFirst Then
                        isFirst = False
                        WhereExpression = ""
                    End If
                    Dim pval As String
                    If WhereExpression.Contains("Where") Then
                        pval = "AND"
                    Else
                        pval = "Where"
                    End If
                    isPassedByValidValue = True
                    WhereExpression += vbCrLf & "              " & pval & " [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")

                End If

            End If
        Next
        If Not isPassedByValidValue Then
            WhereExpression = " RAISERROR ('No se han declarado filtros', 16, 1)"
        End If

        sbUpdateProcedure.AppendLine("              " & WhereExpression & ";")
        sbUpdateProcedure.AppendLine("    END TRY")
        sbUpdateProcedure.AppendLine("    BEGIN CATCH")
        sbUpdateProcedure.AppendLine("       DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbUpdateProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbUpdateProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbUpdateProcedure.AppendLine("    END CATCH;")
        sbUpdateProcedure.AppendLine("END;")

        sbUpdateProcedure.AppendLine("GO")

    End Function


    'Private Function CreateSelectAllProcedure(ByRef sbSelectProcedure As System.Text.StringBuilder, _
    '                                  ByRef TableName As String, _
    '                                  ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute), _
    '                                  Optional ByRef IncludeRowCount As Boolean = False) As String

    '    CreateSelectAllProcedure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_SelectAll"
    '    sbSelectProcedure.AppendLine("Create PROCEDURE  " & CreateSelectAllProcedure)
    '    'sbSelectProcedure.AppendLine("                                                                    ")

    '    sbSelectProcedure.Append(CreateParametersForProcedure(sbSelectProcedure, TableName, listefield, True) & vbCrLf)


    '    sbSelectProcedure.AppendLine("AS")
    '    sbSelectProcedure.AppendLine("BEGIN")
    '    sbSelectProcedure.AppendLine("    SET NOCOUNT ON;")
    '    sbSelectProcedure.AppendLine("")

    '    sbSelectProcedure.AppendLine("    BEGIN TRY")

    '    If IncludeRowCount Then
    '        sbSelectProcedure.AppendLine("          BEGIN ")

    '        sbSelectProcedure.AppendLine("              Set  " & PAGED_COUNT_PARAMETER & _
    '                                                " = (Select Count(*) From " & TableName & " " & SanitizeTableName(TableName))
    '        Dim WhereExpression2 As String = ""
    '        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
    '            Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
    '            If isValidWhereFieldQuery(saux) Then
    '                WhereExpression2 += vbTab & vbTab & vbTab & vbCrLf & "               ("
    '                WhereExpression2 += "(@" & pField.FieldName.Replace(" "c, "_") & " is Null)"
    '                WhereExpression2 += " OR "
    '                WhereExpression2 += " ([" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ")"
    '                WhereExpression2 += ") AND"
    '            End If
    '        Next

    '        Dim raiseerrortrue2 As Boolean = False
    '        If WhereExpression2 = vbTab & vbTab & vbTab & " AND (" Then
    '            WhereExpression2 += "1=0AND"
    '            raiseerrortrue2 = True
    '        End If

    '        WhereExpression2 = WhereExpression2.Substring(0, WhereExpression2.Length - 3)
    '        WhereExpression2 += ")"
    '        sbSelectProcedure.Append(vbTab & vbTab & "  Where (" & WhereExpression2 & vbCrLf & vbTab & vbTab & "   ) " & vbCrLf)
    '        If raiseerrortrue2 Then
    '            sbSelectProcedure.AppendLine("              RAISERROR ('NO SE HAN SELECCIONADO FILTROS WHERE', 16, 1);")
    '        End If

    '        sbSelectProcedure.AppendLine("          END ")
    '    End If



    '    sbSelectProcedure.AppendLine("          BEGIN ")

    '    Dim selectClause As String = CreateSelectForProcedure(TableName, listefield, vbTab & vbTab & vbTab)

    '    Dim isFirst As Boolean = True
    '    Dim auxstr As String = ""

    '    For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

    '        If isFirst Then
    '            auxstr = vbTab & vbTab & vbTab & " ,ROW_NUMBER() OVER (ORDER BY " & SanitizeTableName(TableName) & ".[" & pField.FieldName & "]) AS 'RowNumber'"
    '        End If

    '        If pField.DefaultOrderBy Then
    '            auxstr = vbTab & vbTab & vbTab & " ,ROW_NUMBER() OVER (ORDER BY " & SanitizeTableName(TableName) & ".[" & pField.FieldName & "]) AS 'RowNumber'"
    '            Exit For
    '        End If
    '    Next


    '    auxstr = " WITH PagedTableAuxiliary AS" & _
    '            vbCrLf & vbTab & vbTab & vbTab & "(" & vbCrLf & _
    '                selectClause.Replace(vbTab & vbTab & vbTab & " From ", auxstr & vbCrLf & vbTab & vbTab & vbTab & " From ") & _
    '            vbCrLf & vbTab & vbTab & vbTab & ")" & vbCrLf

    '    sbSelectProcedure.AppendLine(vbTab & vbTab & vbTab & auxstr)
    '    sbSelectProcedure.AppendLine(vbTab & vbTab & vbTab & "SELECT * FROM PagedTableAuxiliary " & _
    '                                 vbCrLf & vbTab & vbTab & vbTab & "WHERE RowNumber BETWEEN " & PAGED_ROW_PARAMETER & " AND (" & PAGED_MAXVALUES_PARAMETER & " + " & PAGED_ROW_PARAMETER & ") ")


    '    Dim WhereExpression As String = vbTab & vbTab & vbTab & " AND ("
    '    For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
    '        Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
    '        If isValidWhereFieldQuery(saux) Then


    '            WhereExpression += vbTab & vbTab & vbTab & vbCrLf & "               ("
    '            WhereExpression += "(@" & pField.FieldName.Replace(" "c, "_") & " is Null)"
    '            WhereExpression += " OR "
    '            WhereExpression += " ([" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ")"
    '            WhereExpression += ") AND"
    '        End If
    '    Next
    '    Dim raiseerrortrue As Boolean = False
    '    If WhereExpression = vbTab & vbTab & vbTab & " AND (" Then
    '        WhereExpression += "1=0AND"
    '        raiseerrortrue = True
    '    End If

    '    WhereExpression = WhereExpression.Substring(0, WhereExpression.Length - 3)
    '    WhereExpression += ")"


    '    sbSelectProcedure.Append(WhereExpression & vbCrLf)
    '    sbSelectProcedure.AppendLine(createOrderBy(listefield, TableName))
    '    If raiseerrortrue Then
    '        sbSelectProcedure.AppendLine(" RAISERROR ('NO SE HAN SELECCIONADO FILTROS WHERE', 16, 1);")
    '    End If
    '    sbSelectProcedure.AppendLine("          END")
    '    sbSelectProcedure.AppendLine("    END TRY")
    '    sbSelectProcedure.AppendLine("    BEGIN CATCH")
    '    sbSelectProcedure.AppendLine("		 DECLARE @Error_Message_Value NVARCHAR(4000);")
    '    sbSelectProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
    '    sbSelectProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
    '    sbSelectProcedure.AppendLine("    END CATCH;")
    '    sbSelectProcedure.AppendLine("END;")

    '    sbSelectProcedure.AppendLine("GO")

    'End Function

    '

    Private Function CreateSelectAllProcedure(ByRef sbSelectAllProcedure As System.Text.StringBuilder, _
                                    ByRef TableName As String, _
                                    ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute), _
                                    Optional ByRef IncludeRowCount As Boolean = False) As String

        CreateSelectAllProcedure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_SelectAll"
        sbSelectAllProcedure.AppendLine("Create PROCEDURE  " & CreateSelectAllProcedure)
        'sbSelectProcedure.AppendLine("                                                                    ")

        sbSelectAllProcedure.Append(CreateParametersForProcedure(sbSelectAllProcedure, TableName, listefield, True) & vbCrLf)


        sbSelectAllProcedure.AppendLine("AS")
        sbSelectAllProcedure.AppendLine("BEGIN")
        sbSelectAllProcedure.AppendLine("    SET NOCOUNT ON;")
        sbSelectAllProcedure.AppendLine("")

        sbSelectAllProcedure.AppendLine("    BEGIN TRY")

        If IncludeRowCount Then
            sbSelectAllProcedure.AppendLine("          BEGIN ")

            sbSelectAllProcedure.AppendLine("              Set  " & PAGED_COUNT_PARAMETER & _
                                                    " = (Select Count(*) From " & TableName & " " & SanitizeTableName(TableName))
            Dim WhereExpression2 As String = ""
            For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
                Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
                If isValidWhereFieldQuery(saux) Then
                    WhereExpression2 += vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbCrLf & "               ("
                    WhereExpression2 += "(@" & pField.FieldName.Replace(" "c, "_") & " is Null)"
                    WhereExpression2 += " OR "
                    WhereExpression2 += " ([" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ")"
                    WhereExpression2 += ") AND"
                End If
            Next

            Dim raiseerrortrue2 As Boolean = False
            If WhereExpression2 = vbTab & vbTab & vbTab & vbTab & " AND (" Then
                WhereExpression2 += "1=0AND"
                raiseerrortrue2 = True
            End If

            WhereExpression2 = WhereExpression2.Substring(0, WhereExpression2.Length - 3)
            WhereExpression2 += ")"
            sbSelectAllProcedure.Append(vbTab & vbTab & vbTab & vbTab & "  Where (" & WhereExpression2 & vbCrLf & vbTab & vbTab & vbTab & vbTab & "   ) " & vbCrLf)
            If raiseerrortrue2 Then
                sbSelectAllProcedure.AppendLine("              RAISERROR ('NO SE HAN SELECCIONADO FILTROS WHERE', 16, 1);")
            End If

            sbSelectAllProcedure.AppendLine("          END ")
        End If


        sbSelectAllProcedure.AppendLine("  		  IF (@MaxValues = 0) OR (@MaxValues Is Null) BEGIN ")
        sbSelectAllProcedure.AppendLine("			    Set @MaxValues = @RecordCount ")
        sbSelectAllProcedure.AppendLine("		  END ")
        sbSelectAllProcedure.AppendLine("		  IF (@Row Is Null) BEGIN ")
        sbSelectAllProcedure.AppendLine("				Set @Row = 0 ")
        sbSelectAllProcedure.AppendLine("		  END ")
        sbSelectAllProcedure.AppendLine("")

        sbSelectAllProcedure.AppendLine("         BEGIN ")

        Dim selectClause As String = CreateSelectForProcedure(TableName, listefield, vbTab & vbTab & vbTab, False)

        Dim isFirst As Boolean = True
        Dim auxstr As String = ""

        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            If isFirst Then
                auxstr = vbTab & vbTab & vbTab & " ,ROW_NUMBER() OVER (ORDER BY " & SanitizeTableName(TableName) & ".[" & pField.FieldName & "]) AS 'RowNumber'"
            End If

            If pField.DefaultOrderBy Then
                auxstr = vbTab & vbTab & vbTab & " ,ROW_NUMBER() OVER (ORDER BY " & SanitizeTableName(TableName) & ".[" & pField.FieldName & "]) AS 'RowNumber'"
                Exit For
            End If
        Next


        auxstr = " WITH PagedTableAuxiliary AS" & _
                vbCrLf & vbTab & vbTab & vbTab & "(" & vbCrLf & _
                    selectClause.Replace(vbTab & vbTab & vbTab & " From ", auxstr & vbCrLf & vbTab & vbTab & vbTab & " From ") & _
                vbCrLf & vbTab & vbTab & vbTab & ")" & vbCrLf

        sbSelectAllProcedure.AppendLine(vbTab & vbTab & vbTab & auxstr)
        sbSelectAllProcedure.AppendLine(vbTab & vbTab & vbTab & "SELECT * FROM PagedTableAuxiliary " & _
                                     vbCrLf & vbTab & vbTab & vbTab & "WHERE RowNumber BETWEEN " & PAGED_ROW_PARAMETER & " AND (" & PAGED_MAXVALUES_PARAMETER & " + " & PAGED_ROW_PARAMETER & ") ")


        Dim WhereExpression As String = vbTab & vbTab & vbTab & " AND ("
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
            If isValidWhereFieldQuery(saux) Then


                WhereExpression += vbTab & vbTab & vbTab & vbCrLf & "               ("
                WhereExpression += "(@" & pField.FieldName.Replace(" "c, "_") & " is Null)"
                WhereExpression += " OR "
                WhereExpression += " ([" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ")"
                WhereExpression += ") AND"
            End If
        Next
        Dim raiseerrortrue As Boolean = False
        If WhereExpression = vbTab & vbTab & vbTab & " AND (" Then
            WhereExpression += "1=0AND"
            raiseerrortrue = True
        End If

        WhereExpression = WhereExpression.Substring(0, WhereExpression.Length - 3)
        WhereExpression += ")"


        sbSelectAllProcedure.Append(WhereExpression & vbCrLf)
        sbSelectAllProcedure.AppendLine(createOrderBy(listefield, TableName))
        If raiseerrortrue Then
            sbSelectAllProcedure.AppendLine(" RAISERROR ('NO SE HAN SELECCIONADO FILTROS WHERE', 16, 1);")
        End If
        sbSelectAllProcedure.AppendLine("          END")
        sbSelectAllProcedure.AppendLine("    END TRY")
        sbSelectAllProcedure.AppendLine("    BEGIN CATCH")
        sbSelectAllProcedure.AppendLine("		 DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbSelectAllProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbSelectAllProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbSelectAllProcedure.AppendLine("    END CATCH;")
        sbSelectAllProcedure.AppendLine("END;")

        sbSelectAllProcedure.AppendLine("GO")


    End Function


    Private Function CreateSelectAllFullDescription(ByRef sbSearchAllProcedure As System.Text.StringBuilder, _
                                      ByRef TableName As String, _
                                      ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute), _
                                      Optional ByRef IncludeRowCount As Boolean = False) As String

        CreateSelectAllFullDescription = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_SelectFullDescriptionAll"
        sbSearchAllProcedure.AppendLine("Create PROCEDURE  " & CreateSelectAllFullDescription)
        'sbSelectProcedure.AppendLine("                                                                    ")

        sbSearchAllProcedure.Append(CreateParametersForProcedure(sbSearchAllProcedure, TableName, listefield, True) & vbCrLf)


        sbSearchAllProcedure.AppendLine("AS")
        sbSearchAllProcedure.AppendLine("BEGIN")
        sbSearchAllProcedure.AppendLine("    SET NOCOUNT ON;")
        sbSearchAllProcedure.AppendLine("")

        sbSearchAllProcedure.AppendLine("    BEGIN TRY")

        If IncludeRowCount Then
            sbSearchAllProcedure.AppendLine("          BEGIN ")

            sbSearchAllProcedure.AppendLine("              Set  " & PAGED_COUNT_PARAMETER & _
                                                    " = (Select Count(*) From " & TableName & " " & SanitizeTableName(TableName))
            Dim WhereExpression2 As String = ""
            For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
                Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
                If isValidWhereFieldQuery(saux) Then
                    WhereExpression2 += vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbCrLf & "               ("
                    WhereExpression2 += "(@" & pField.FieldName.Replace(" "c, "_") & " is Null)"
                    WhereExpression2 += " OR "
                    WhereExpression2 += " ([" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ")"
                    WhereExpression2 += ") AND"
                End If
            Next

            Dim raiseerrortrue2 As Boolean = False
            If WhereExpression2 = vbTab & vbTab & vbTab & vbTab & " AND (" Then
                WhereExpression2 += "1=0AND"
                raiseerrortrue2 = True
            End If

            WhereExpression2 = WhereExpression2.Substring(0, WhereExpression2.Length - 3)
            WhereExpression2 += ")"
            sbSearchAllProcedure.Append(vbTab & vbTab & vbTab & vbTab & "  Where (" & WhereExpression2 & vbCrLf & vbTab & vbTab & vbTab & vbTab & "   ) " & vbCrLf)
            If raiseerrortrue2 Then
                sbSearchAllProcedure.AppendLine("              RAISERROR ('NO SE HAN SELECCIONADO FILTROS WHERE', 16, 1);")
            End If

            sbSearchAllProcedure.AppendLine("          END ")
        End If


        sbSearchAllProcedure.AppendLine("  		  IF (@MaxValues = 0) OR (@MaxValues Is Null) BEGIN ")
        sbSearchAllProcedure.AppendLine("			    Set @MaxValues = @RecordCount ")
        sbSearchAllProcedure.AppendLine("		  END ")
        sbSearchAllProcedure.AppendLine("		  IF (@Row Is Null) BEGIN ")
        sbSearchAllProcedure.AppendLine("				Set @Row = 0 ")
        sbSearchAllProcedure.AppendLine("		  END ")
        sbSearchAllProcedure.AppendLine("")

        sbSearchAllProcedure.AppendLine("         BEGIN ")

        Dim selectClause As String = CreateSelectForProcedure(TableName, listefield, vbTab & vbTab & vbTab)

        Dim isFirst As Boolean = True
        Dim auxstr As String = ""

        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            If isFirst Then
                auxstr = vbTab & vbTab & vbTab & " ,ROW_NUMBER() OVER (ORDER BY " & SanitizeTableName(TableName) & ".[" & pField.FieldName & "]) AS 'RowNumber'"
            End If

            If pField.DefaultOrderBy Then
                auxstr = vbTab & vbTab & vbTab & " ,ROW_NUMBER() OVER (ORDER BY " & SanitizeTableName(TableName) & ".[" & pField.FieldName & "]) AS 'RowNumber'"
                Exit For
            End If
        Next


        auxstr = " WITH PagedTableAuxiliary AS" & _
                vbCrLf & vbTab & vbTab & vbTab & "(" & vbCrLf & _
                    selectClause.Replace(vbTab & vbTab & vbTab & " From ", auxstr & vbCrLf & vbTab & vbTab & vbTab & " From ") & _
                vbCrLf & vbTab & vbTab & vbTab & ")" & vbCrLf

        sbSearchAllProcedure.AppendLine(vbTab & vbTab & vbTab & auxstr)
        sbSearchAllProcedure.AppendLine(vbTab & vbTab & vbTab & "SELECT * FROM PagedTableAuxiliary " & _
                                     vbCrLf & vbTab & vbTab & vbTab & "WHERE RowNumber BETWEEN " & PAGED_ROW_PARAMETER & " AND (" & PAGED_MAXVALUES_PARAMETER & " + " & PAGED_ROW_PARAMETER & ") ")


        Dim WhereExpression As String = vbTab & vbTab & vbTab & " AND ("
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
            If isValidWhereFieldQuery(saux) Then


                WhereExpression += vbTab & vbTab & vbTab & vbCrLf & "               ("
                WhereExpression += "(@" & pField.FieldName.Replace(" "c, "_") & " is Null)"
                WhereExpression += " OR "
                WhereExpression += " ([" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ")"
                WhereExpression += ") AND"
            End If
        Next
        Dim raiseerrortrue As Boolean = False
        If WhereExpression = vbTab & vbTab & vbTab & " AND (" Then
            WhereExpression += "1=0AND"
            raiseerrortrue = True
        End If

        WhereExpression = WhereExpression.Substring(0, WhereExpression.Length - 3)
        WhereExpression += ")"


        sbSearchAllProcedure.Append(WhereExpression & vbCrLf)
        sbSearchAllProcedure.AppendLine(createOrderBy(listefield, TableName))
        If raiseerrortrue Then
            sbSearchAllProcedure.AppendLine(" RAISERROR ('NO SE HAN SELECCIONADO FILTROS WHERE', 16, 1);")
        End If
        sbSearchAllProcedure.AppendLine("          END")
        sbSearchAllProcedure.AppendLine("    END TRY")
        sbSearchAllProcedure.AppendLine("    BEGIN CATCH")
        sbSearchAllProcedure.AppendLine("		 DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbSearchAllProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbSearchAllProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbSearchAllProcedure.AppendLine("    END CATCH;")
        sbSearchAllProcedure.AppendLine("END;")

        sbSearchAllProcedure.AppendLine("GO")


    End Function






    Private Function CreateSelectOneProcedure(ByRef sbSelectProcedure As System.Text.StringBuilder, _
                                              ByRef TableName As String, _
                                              ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String

        CreateSelectOneProcedure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_SlectOne"
        sbSelectProcedure.AppendLine("Create PROCEDURE  " & CreateSelectOneProcedure)
        'sbSelectProcedure.AppendLine("                                                                    ")

        Dim params As String = CreateParametersForProcedure(sbSelectProcedure, TableName, listefield, False, True)
        sbSelectProcedure.Append(params & vbCrLf)


        sbSelectProcedure.AppendLine("AS")
        sbSelectProcedure.AppendLine("BEGIN")
        sbSelectProcedure.AppendLine("    SET NOCOUNT ON;")
        sbSelectProcedure.AppendLine("")

        sbSelectProcedure.AppendLine("    BEGIN TRY")
        sbSelectProcedure.AppendLine("             " & CreateSelectForProcedure(TableName, listefield, "             "))



        Dim WhereExpression As String = vbCrLf & " WHERE("
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            Dim saux As String = Me.createSP_Param(pField, Me.GetColumnExtendInformation(TableName, pField.FieldName))
            If isValidWhereFieldQuery(saux) Then


                If params.Contains("@" & pField.FieldName.Replace(" "c, "_") & " ") Then

                    WhereExpression += " ([" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ") AND"

                End If
            End If
        Next

        If WhereExpression = vbCrLf & " WHERE(" Then
            WhereExpression = "where (1=0AND"
        End If

        WhereExpression = WhereExpression.Substring(0, WhereExpression.Length - 3)
        WhereExpression += ")"

        sbSelectProcedure.Append(WhereExpression & vbCrLf)

        If WhereExpression = "where (1=0)" Then
            sbSelectProcedure.AppendLine(" RAISERROR ('NO SE HAN SELECCIONADO FILTROS WHERE', 16, 1);")
        End If
        sbSelectProcedure.AppendLine("    END TRY")
        sbSelectProcedure.AppendLine("    BEGIN CATCH")
        sbSelectProcedure.AppendLine("       DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbSelectProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbSelectProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbSelectProcedure.AppendLine("    END CATCH;")
        sbSelectProcedure.AppendLine("END;")

        sbSelectProcedure.AppendLine("GO")
    End Function


    Private Sub AppendProperty(ByRef sbPropertysRegion As System.Text.StringBuilder, _
                               ByRef sbDeclarationRegion As System.Text.StringBuilder, _
                               ByRef sbConstructorMethod As System.Text.StringBuilder, _
                               ByVal efield As BrainWork.Entities.EntityFieldExtendsAttribute, _
                               ByVal Attributes As String, _
                               ByVal TableName As String)

        Dim propertyName As String = efield.FieldName.Replace(" "c, "_")
        Dim sType As String = efield.TypeName
        If propertyName.Contains("_"c) Then
            propertyName = Mid(propertyName, propertyName.IndexOf("_"c) + 2)
        End If


        Dim i As Integer = 0
        propertyName = SanitizeVariable(propertyName)

        Dim propAux As String = propertyName
        While sbDeclarationRegion.ToString.ToLower.Contains(" _" & propAux.ToLower)
            i += 1
            If Not efield.ForeingTable Is Nothing Then
                If efield.ForeingTable & FirstLetter(propertyName) = propAux Then
                    propAux = efield.ForeingTable & FirstLetter(propertyName) & "_" & i
                Else
                    propAux = efield.ForeingTable & FirstLetter(propertyName)
                End If
            Else
                propAux = propertyName & "_" & i
            End If
        End While

        propertyName = propAux


        'Agrego la capitalizacion
        propertyName = FirstLetter(propertyName)

        'Nombre del Campo
        Dim PrivateDim As String = IIf(propertyName.Contains("["), "[_" & propertyName.Substring(1), "_" & propertyName).ToString

        'agrgo al constructor

        If efield.DefaultValue Is Nothing Then
            sbConstructorMethod.AppendLine(PrivateDim & " = Nothing")
        ElseIf efield.TypeName.ToLower.Contains("date") Then
            If IsDate(efield.DefaultValue) Then
                sbConstructorMethod.AppendLine(PrivateDim & " = #" & efield.DefaultValue.ToString & "#")
            ElseIf efield.DefaultValue.ToString.ToLower.Contains("date") Then
                sbConstructorMethod.AppendLine(PrivateDim & " = Now")
            End If
        Else

            sbConstructorMethod.AppendLine(PrivateDim & " = " & efield.DefaultValue.ToString.Replace("("c, "").Replace(")"c, ""))
        End If




        'inserta el campo en el area de la declaracion  
        sbDeclarationRegion.AppendLine(vbTab & "Private  " & PrivateDim & " As " & sType)

        'agrego el nombre de la propiedad a la EntityClassExtends
        If Me.Tables(TableName).DescriptionFieldName = efield.FieldName Then
            Me.Tables(TableName).DescriptionPropertyName = propertyName
            Me.Tables(TableName).EnabledPropertyName = propertyName
        End If
        If Me.Tables(TableName).PrimaryKeyFieldName = efield.FieldName Then
            Me.Tables(TableName).PrimaryKeyPropertyName = propertyName
        End If

        'genero la property
        sbPropertysRegion.AppendLine(vbTab & Attributes)
        sbPropertysRegion.AppendLine(vbTab & "Public Property " & propertyName & "() As " & sType)
        sbPropertysRegion.AppendLine(vbTab & "Get ")
        sbPropertysRegion.AppendLine(vbTab & vbTab & "Return   " & PrivateDim)
        sbPropertysRegion.AppendLine(vbTab & "End Get ")
        sbPropertysRegion.AppendLine(vbTab & "Set(ByVal value As " & sType & ")")
        sbPropertysRegion.AppendLine(vbTab & vbTab & PrivateDim & " = value")
        sbPropertysRegion.AppendLine(vbTab & "End Set")
        sbPropertysRegion.AppendLine(vbTab & "End Property")

    End Sub

    Private Function SanitizeClassName(ByVal clsName As String) As String
        Return clsName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "_"c)
    End Function

    Private Function GetClassExtends(ByVal tableName As String) As String
        Dim sbb As String

        sbb = "<BrainWork.Entities.EntityClassExtendsAttribute("


        If Not Me.Tables(tableName).DescriptionFieldName Is Nothing Then
            sbb += "DescriptionFieldName:=""" & Me.Tables(tableName).DescriptionFieldName & ""","
        End If


        If Not Me.Tables(tableName).PrimaryKeyFieldName Is Nothing Then
            sbb += "PrimaryKeyFieldName:=""" & Me.Tables(tableName).PrimaryKeyFieldName & ""","
        End If




        If Not Me.Tables(tableName).RootContainerName Is Nothing Then
            sbb += "RootContainerName:=""" & Me.Tables(tableName).RootContainerName & """"
        End If


        sbb += ")> _"
        Return sbb


    End Function

    Private Function GenerateClass(ByRef sbPropertysRegion As System.Text.StringBuilder, _
                               ByRef sbDeclarationRegion As System.Text.StringBuilder, _
                               ByRef sbMethodRegion As System.Text.StringBuilder, _
                               ByRef sbConstructorMethod As System.Text.StringBuilder, _
                               ByVal ClassName As String, _
                               ByVal TableName As String, _
                               Optional ByVal NamespaceName As String = Nothing) As String

        Dim ClassString As String
        ClassName = Me.ENTITY_Prefix & SanitizeClassName(ClassName)
        ClassString = "''' <summary>" & vbCrLf
        ClassString += "''' Auto Generated:  " & Date.Now.ToString() & vbCrLf
        ClassString += "''' </summary>" & vbCrLf
        ClassString += " ''' <remarks></remarks>" & vbCrLf

        If NamespaceName <> Nothing Then
            ClassString += "Namespace " & NamespaceName & vbCrLf
            ClassString += vbTab & Me.GetClassExtends(TableName) & vbCrLf
            ClassString += vbTab & "Public Class " & ClassName & vbCrLf
        Else
            ClassString += vbTab & Me.GetClassExtends(TableName) & vbCrLf
            ClassString += "Public Class " & ClassName & vbCrLf
        End If
        ClassString += vbCrLf & vbTab & vbTab & "Inherits BrainWork.Entities.AbstractEntityBase" & vbCrLf


        PutInRegion(sbDeclarationRegion, DECLARATION_REGION)
        PutInRegion(sbMethodRegion, METHOD_REGION)
        PutInRegion(sbPropertysRegion, PROPERTYS_REGION)
        PutInRegion(sbConstructorMethod, CONSTRUCTOR_REGION)

        ClassString += sbDeclarationRegion.ToString & vbCrLf & sbPropertysRegion.ToString & vbCrLf & sbConstructorMethod.ToString & vbCrLf & sbMethodRegion.ToString

        If NamespaceName <> Nothing Then
            ClassString += vbTab & "End Class " & vbCrLf
            ClassString += "End Namespace " & vbCrLf
        Else
            ClassString += "End Class " & vbCrLf
        End If

        Return ClassString
    End Function


    Public Sub CreateProcedures()
        'CreateInsertProcedeure()
        If Not System.IO.Directory.Exists(OUTPUTPAT) Then
            System.IO.Directory.CreateDirectory(OUTPUTPAT)
        End If
        _GeneratedStored = ""
        For Each Key As String In Me.TablesFields.Keys
            Dim sbInsertProcedure As New System.Text.StringBuilder
            Dim sbUpdateProcedure As New System.Text.StringBuilder
            Dim sbSelectAllProcedure As New System.Text.StringBuilder
            Dim sbSelectAllFullDescription As New System.Text.StringBuilder
            Dim sbSelectOneProcedure As New System.Text.StringBuilder
            Dim sbDeleteProcedure As New System.Text.StringBuilder
            Dim sbDisableProcedure As New System.Text.StringBuilder
            Dim sbUpdateByPKProcedure As New System.Text.StringBuilder

            Dim listefield As New List(Of BrainWork.Entities.EntityFieldExtendsAttribute)
            listefield = Me.TablesFields.Item(Key)
            ' CreateInsertProcedeure(sbInsertProcedure, Key, listefield)
            Dim sAux As String



            sAux = CreateInsertProcedeure(sbInsertProcedure, Key, listefield)
            TableProcedureInsert.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbInsertProcedure.ToString, sAux)

            sAux = CreateUpdateProcedeure(sbUpdateProcedure, Key, listefield)
            TableProcedureUpdate.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbUpdateProcedure.ToString, sAux)


            sAux = CreateSelectAllFullDescription(sbSelectAllFullDescription, Key, listefield, True)
            TableProcedureSelectAllFullDescription.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbSelectAllFullDescription.ToString, sAux)



            sAux = CreateSelectAllProcedure(sbSelectAllProcedure, Key, listefield, True)
            TableProcedureSelectAll.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbSelectAllProcedure.ToString, sAux)





            sAux = CreateSelectOneProcedure(sbSelectOneProcedure, Key, listefield)
            TableProcedureSelectOne.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbSelectOneProcedure.ToString, sAux)

            sAux = CreateDeleteProcedeure(sbDeleteProcedure, Key, listefield)
            TableProcedureDelete.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbDeleteProcedure.ToString, sAux)


            sAux = CreateDisableProcedeure(sbDisableProcedure, Key, listefield)
            TableProcedureDisable.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbDisableProcedure.ToString, sAux)

            sAux = CreateUpdateByPKProcedeure(sbUpdateByPKProcedure, Key, listefield)
            TableProcedureUpdateByPK.Add(Key, sAux)
            PublishStoredProcedures(OUTPUTPAT, sbUpdateByPKProcedure.ToString, sAux)



        Next


    End Sub


    Public Sub PublishStoredProcedures(ByVal directorio As String, ByVal storedProceduresString As String, ByVal procedureName As String)
        _GeneratedStored += storedProceduresString & vbCrLf
        directorio = directorio & Me.SUBDIR_CLASS_PROCEDURES
        If Not System.IO.Directory.Exists(directorio) Then
            System.IO.Directory.CreateDirectory(directorio)
        End If

        If Not directorio.EndsWith("\") Then
            directorio = directorio & "\"
        End If

        'Dim fs As New System.IO.FileStream, IO.FileMode.Create)
        Dim sw As New System.IO.StreamWriter(directorio & procedureName & ".sql", False, System.Text.Encoding.Default)
        sw.Write(storedProceduresString)
        sw.Flush()
        sw.Close()
    End Sub
    '

    Public Sub CreateBLAndDAClass()
        If Not System.IO.Directory.Exists(OUTPUTPAT) Then
            System.IO.Directory.CreateDirectory(OUTPUTPAT)
        End If




        For Each Key As String In Me.TablesFields.Keys


            Dim listefield As New List(Of BrainWork.Entities.EntityFieldExtendsAttribute)
            listefield = Me.TablesFields.Item(Key)
            Dim classValidationString As String = vbTab & vbTab & "If "

            Dim ConstructorValues As String = vbTab & vbTab & ""

            Dim sCurrentPropertys As String = ""

            For Each efield As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
                Dim propertyName As String = efield.FieldName.Replace(" "c, "_")
                Dim sType As String = efield.TypeName
                If propertyName.Contains("_"c) Then
                    propertyName = Mid(propertyName, propertyName.IndexOf("_"c) + 2)
                End If

                Dim i As Integer = 0
                propertyName = SanitizeVariable(propertyName)

                Dim propAux As String = propertyName
                While sCurrentPropertys.ToLower.Contains(" _" & propAux.ToLower)
                    i += 1
                    If Not efield.ForeingTable Is Nothing Then
                        If efield.ForeingTable & FirstLetter(propertyName) = propAux Then
                            propAux = efield.ForeingTable & FirstLetter(propertyName) & "_" & i
                        Else
                            propAux = efield.ForeingTable & FirstLetter(propertyName)
                        End If
                    Else
                        propAux = propertyName & "_" & i
                    End If
                End While

                propertyName = propAux


                'Agrego la capitalizacion
                propertyName = FirstLetter(propertyName)

                sCurrentPropertys += propertyName & vbCrLf

                If Not efield.IsNullable Then



                    Select Case True

                        Case efield.TypeName.ToLower.Contains("decimal")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  =  Decimal.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  =  Decimal.MinValue" & vbCrLf


                        Case efield.TypeName.ToLower.Contains("guid")
                            ConstructorValues += vbTab & vbTab & vbTab & "'Me.CurrentEntity." & propertyName & "  = Nothing" & vbCrLf


                        Case efield.TypeName.ToLower.Contains("bool")
                            ConstructorValues += vbTab & vbTab & vbTab & "'Me.CurrentEntity." & propertyName & "  = Nothing" & vbCrLf


                        Case efield.TypeName.ToLower.Contains("byte")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Byte.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Byte.MinValue" & vbCrLf

                        Case efield.TypeName.ToLower.Contains("int16")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Int16.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Int16.MinValue" & vbCrLf

                        Case efield.TypeName.ToLower.Contains("int32")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & " = Int32.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Int32.MinValue" & vbCrLf

                        Case efield.TypeName.ToLower.Contains("int64")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & " = Int64.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Int64.MinValue" & vbCrLf

                        Case efield.TypeName.ToLower.Contains("integer")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & " = Int32.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Int32.MinValue" & vbCrLf

                        Case efield.TypeName.ToLower.Contains("double")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & " = Int64.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Int64.MinValue" & vbCrLf

                        Case efield.TypeName.ToLower.Contains("date")
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & " = Date.MinValue OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Date.MinValue" & vbCrLf

                        Case Else
                            classValidationString += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & " is Nothing OrElse _ " & vbCrLf
                            ConstructorValues += vbTab & vbTab & vbTab & "Me.CurrentEntity." & propertyName & "  = Nothing" & vbCrLf
                    End Select

                End If

            Next

            classValidationString += vbTab & vbTab & vbTab & vbTab & vbTab & " False Then" & vbCrLf
            '
            classValidationString += vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "strError = ""Error de validación general""" & vbCrLf
            classValidationString += vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "Return False" & vbCrLf
            classValidationString += vbTab & vbTab & vbTab & vbTab & vbTab & "Else" & vbCrLf
            classValidationString += vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "Return True" & vbCrLf
            classValidationString += vbTab & vbTab & vbTab & vbTab & vbTab & "End If" & vbCrLf

            Dim strBLClass As String = GetBlClass(Key, _
                                       Me.BUSSINES_LOGIC_Prefix & SanitizeClassName(Key), _
                                       Me.ENTITY_Prefix & SanitizeClassName(Key), _
                                       Me.DATA_ACCESS_Prefix & SanitizeClassName(Key), _
                                       classValidationString, _
                                       ConstructorValues)

            Dim ConstructorValuesDataAccess As String = ""
            Dim SetStoredProcedures As String
            SetStoredProcedures = vbTab & vbTab & vbTab & "Me.SP_ADD = """ & Me.TableProcedureInsert(Key) & """" & vbCrLf
            SetStoredProcedures += vbTab & vbTab & vbTab & "Me.SP_DELETE = """ & Me.TableProcedureDelete(Key) & """" & vbCrLf
            SetStoredProcedures += vbTab & vbTab & vbTab & "Me.SP_DISABLE = """ & Me.TableProcedureDisable(Key) & """" & vbCrLf
            SetStoredProcedures += vbTab & vbTab & vbTab & "Me.SP_GETALL = """ & Me.TableProcedureSelectAll(Key) & """" & vbCrLf
            SetStoredProcedures += vbTab & vbTab & vbTab & "Me.SP_GETALL_FULLDESCRIPTION = """ & Me.TableProcedureSelectAllFullDescription(Key) & """" & vbCrLf
            SetStoredProcedures += vbTab & vbTab & vbTab & "Me.SP_GETONE = """ & Me.TableProcedureSelectOne(Key) & """" & vbCrLf
            SetStoredProcedures += vbTab & vbTab & vbTab & "Me.SP_UPDATE = """ & Me.TableProcedureUpdate(Key) & """" & vbCrLf
            SetStoredProcedures += vbTab & vbTab & vbTab & "Me.SP_UPDATE_BY_PK = """ & Me.TableProcedureUpdateByPK(Key) & """" & vbCrLf

            PublishBLDA(OUTPUTPAT & Me.SUBDIR_CLASS_BUSSINES, strBLClass, (Me.BUSSINES_LOGIC_Prefix & SanitizeClassName(Key)))
            _GeneratedBussines += strBLClass & vbCrLf

            Dim strDaClass As String = GetDaClass(Key, _
                                                 DATA_ACCESS_Prefix & SanitizeClassName(Key), _
                                                 Me.ENTITY_Prefix & SanitizeClassName(Key), _
                                                 SetStoredProcedures, _
                                                 ConstructorValuesDataAccess)

            PublishBLDA(OUTPUTPAT & Me.SUBDIR_CLASS_DATAACCES, strDaClass, (Me.DATA_ACCESS_Prefix & SanitizeClassName(Key)))

            _GeneratedDataAccess += strDaClass & vbCrLf
        Next




    End Sub

    ' Dim tempblda As String = ""
    Public Sub PublishBLDA(ByVal directorio As String, ByVal classString As String, ByVal ClassName As String)

        ' Return
        ' directorio = directorio & Me.SUBDIR_CLASS_ENTITY
        If Not System.IO.Directory.Exists(directorio) Then
            System.IO.Directory.CreateDirectory(directorio)
        End If

        If Not directorio.EndsWith("\") Then
            directorio = directorio & "\"
        End If

        'Dim fs As New System.IO.FileStream, IO.FileMode.Create)
        Dim sw As New System.IO.StreamWriter(directorio & ClassName & ".vb", False, System.Text.Encoding.Default)
        sw.Write(classString)
        sw.Flush()
        sw.Close()
    End Sub


    Public Sub CreateEntityClass()
        If Not System.IO.Directory.Exists(OUTPUTPAT) Then
            System.IO.Directory.CreateDirectory(OUTPUTPAT)
        End If




        For Each Key As String In Me.TablesFields.Keys
            Dim sbDeclarationRegion As New System.Text.StringBuilder
            Dim sbPropertysRegion As New System.Text.StringBuilder
            Dim sbMethodRegion As New System.Text.StringBuilder
            Dim sbConstructorMethod As New System.Text.StringBuilder

            Dim sbAuxiliary As System.Text.StringBuilder


            Dim listefield As New List(Of BrainWork.Entities.EntityFieldExtendsAttribute)
            listefield = Me.TablesFields.Item(Key)

            sbConstructorMethod.AppendLine(vbTab & "Public Sub New()")

            For Each efield As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
                sbAuxiliary = New System.Text.StringBuilder
                Me.AddFieldsAttributes(sbAuxiliary, efield)
                Me.AppendProperty(sbPropertysRegion, sbDeclarationRegion, sbConstructorMethod, efield, sbAuxiliary.ToString, Key)
            Next

            sbConstructorMethod.AppendLine(vbTab & "End Sub")

            Dim classString = Me.GenerateClass(sbPropertysRegion, sbDeclarationRegion, sbMethodRegion, sbConstructorMethod, Key, Key)
            PublishClass_Entitys(OUTPUTPAT, classString, (Me.ENTITY_Prefix & SanitizeClassName(Key)))
        Next






    End Sub

    ' Private temp As String
    Private Sub PublishClass_Entitys(ByVal directorio As String, ByVal classString As String, ByVal ClassName As String)
        Me._GeneratedEntity += classString & vbCrLf

        directorio = directorio & Me.SUBDIR_CLASS_ENTITY
        If Not System.IO.Directory.Exists(directorio) Then
            System.IO.Directory.CreateDirectory(directorio)
        End If

        If Not directorio.EndsWith("\") Then
            directorio = directorio & "\"
        End If

        'Dim fs As New System.IO.FileStream, IO.FileMode.Create)
        Dim sw As New System.IO.StreamWriter(directorio & ClassName & ".vb", False, System.Text.Encoding.Default)
        sw.Write(classString)
        sw.Flush()
        sw.Close()



    End Sub



    Private Function dbValue(ByVal value As Object) As Object
        If value Is DBNull.Value Then
            Return Nothing
        End If
        Return value
    End Function





End Class














































































