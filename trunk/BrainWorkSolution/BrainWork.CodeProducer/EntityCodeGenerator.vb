Imports System.Globalization

Partial Public Class EntityCodeGenerator
    Private _Connection As SqlClient.SqlConnection
    Private TablesFields As New Dictionary(Of String, List(Of BrainWork.Entities.EntityFieldExtendsAttribute))
    Private Tables As New Dictionary(Of String, BrainWork.Entities.EntityClassExtendsAttribute)
    Private dtKeys As DataTable
    Private VBPrimaryKeys() As String = New String() {"AddHandler", "AddressOf", "Alias", "And", "AndAlso", "Ansi", "As", "Assembly", "Auto", "Boolean", "ByRef", "Byte", "ByVal", "Call", "Case", "Catch", "CBool", "CByte", "CChar", "CDate", "CDec", "CDbl", "Char", "CInt", "Class", "CLng", "CObj", "Const", "CShort", "CSng", "CStr", "CType", "Date", "Decimal", "Declare", "Default", "Delegate", "Dim", "DirectCast", "Do", "Double", "Each", "Else", "ElseIf", "End", "Enum", "Erase", "Error", "Event", "Exit", "False", "Finally", "For", "Friend", "Function", "Get", "GetType", "GoSub", "GoTo", "Handles", "If", "Implements", "Imports", "In", "Inherits", "Integer", "Interface", "Is", "Let", "Lib", "Like", "Long", "Loop", "Me", "Mod", "Module", "MustInherit", "MustOverride", "MyBase", "MyClass", "Namespace", "New", "Next", "Not", "Nothing", "NotInheritable", "NotOverridable", "Object", "On", "Option", "Optional", "Or", "OrElse", "Overloads", "Overridable", "Overrides", "ParamArray", "Preserve", "Private", "Property", "Protected", "Public", "RaiseEvent", "ReadOnly", "ReDim", "REM", "RemoveHandler", "Resume", "Return", "Select", "Set", "Shadows", "Shared", "Short", "Single", "Static", "Step", "Stop", "String", "Structure", "Sub", "SyncLock", "Then", "Throw", "To", "True", "Try", "TypeOf", "Unicode", "Until", "Variant", "When", "While", "With", "WithEvents", "WriteOnly", "Xor"}
    Private _cnnString As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks;Data Source=localhost\sqlexpress"
    Private TEMPORAL_CLASS As String = ""
    Private TEMPORAL_STORED_PROCEDURES As String = ""
    Private DECLARATION_REGION As String = "GeneratedCode Declaration"
    Private METHOD_REGION As String = "GeneratedCode Methods"
    Private PROPERTYS_REGION As String = "GeneratedCode Propertys"
    Private CONSTRUCTOR_REGION As String = "GeneratedCode Constructor"
    Private ReadOnly Property STORED_BrainworkSupport_GetTable_QUERY() As String
        Get
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("CREATE PROCEDURE [dbo].[BrainworkSupport_GetTable]                                     ")
            sb.AppendLine("				@tablaname varChar(max)			                                                    ")
            sb.AppendLine("AS                                                                                     ")
            sb.AppendLine("BEGIN                                                                                  ")
            sb.AppendLine("	SET NOCOUNT ON;                                                                       ")
            sb.AppendLine("	                                                                                      ")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("declare @propiedades as table(COLUMN_NAME sql_variant, COLUMN_DESCRIPTION sql_variant) ")
            sb.AppendLine("Insert Into @propiedades                                                               ")
            sb.AppendLine("SELECT      c.name AS COLUMN_NAME ,                                                    ")
            sb.AppendLine("            ep.value AS COLUMN_DESCRIPTION                                             ")
            sb.AppendLine("FROM        sys.objects o INNER JOIN sys.extended_properties ep                        ")
            sb.AppendLine("            ON o.object_id = ep.major_id                                               ")
            sb.AppendLine("            INNER JOIN sys.schemas s                                                   ")
            sb.AppendLine("            ON o.schema_id = s.schema_id                                               ")
            sb.AppendLine("            LEFT JOIN syscolumns c                                                     ")
            sb.AppendLine("            ON ep.minor_id = c.colid                                                   ")
            sb.AppendLine("            AND ep.major_id = c.id                                                     ")
            sb.AppendLine("WHERE        o.type IN ('V', 'U', 'P') and o.Name like @tablaname                      ")
            sb.AppendLine("ORDER BY   COLUMN_NAME                                                                 ")
            sb.AppendLine("---------------------------------------------------------------------------------------")
            sb.AppendLine("declare @detalle as table(COLUMN_NAME sql_variant, COLUMN_DEFAULT sql_variant,IS_NULLABLE sql_variant,DATA_TYPE sql_variant ,ORDINAL_POSITION sql_variant, CHARACTER_MAXIMUM_LENGTH sql_variant, NUMERIC_PRECISION sql_variant,NUMERIC_SCALE sql_variant)")
            sb.AppendLine("Insert Into @detalle                                                                                                                                                                                                                                     ")
            sb.AppendLine("SELECT  isq.COLUMN_NAME, isq.COLUMN_DEFAULT, isq.IS_NULLABLE, isq.DATA_TYPE ,                                                                                                                                                                            ")
            sb.AppendLine("		isq.ORDINAL_POSITION,                                                                                                                                                                                                                                 ")
            sb.AppendLine("		isq.CHARACTER_MAXIMUM_LENGTH,                                                                                                                                                                                                                         ")
            sb.AppendLine("		isq.NUMERIC_PRECISION,                                                                                                                                                                                                                                ")
            sb.AppendLine("		isq.NUMERIC_SCALE                                                                                                                                                                                                                                     ")
            sb.AppendLine("FROM        sys.objects o                                                                                                                                                                                                                                ")
            sb.AppendLine("			LEFT JOIN sys.schemas s                                                                                                                                                                                                                             ")
            sb.AppendLine("				ON o.schema_id = s.schema_id                                                                                                                                                                                                                      ")
            sb.AppendLine("			LEFT Join INFORMATION_SCHEMA.COLUMNS isq 			                                                                                                                                                                                                      ")
            sb.AppendLine("				On isq.TABLE_NAME =  o.Name                                                                                                                                                                                                                       ")
            sb.AppendLine("                                                                                                                                                                                                                                                         ")
            sb.AppendLine("WHERE o.type IN ('U')AND isq.TABLE_NAME = @tablaname                                                                                                                                                                                                     ")
            sb.AppendLine("Order By COLUMN_NAME                                                                                                                                                                                                                                     ")
            sb.AppendLine("---------------------------------------------------------------------------------------                                                                                                                                                                  ")
            sb.AppendLine("declare @claves as table(COLUMN_NAME sql_variant, COLUMN_KEY int)                                                                                                                                                                                        ")
            sb.AppendLine("Insert Into @claves                                                                                                                                                                                                                                      ")
            sb.AppendLine("select  c.name as COLUMN_NAME, 1 As COLUMN_KEY                                                                                                                                                                                                           ")
            sb.AppendLine("from sys.key_constraints as k                                                                                                                                                                                                                            ")
            sb.AppendLine("		join sys.tables as t                                                                                                                                                                                                                                  ")
            sb.AppendLine("			on t.object_id = k.parent_object_id                                                                                                                                                                                                                 ")
            sb.AppendLine("		join sys.schemas as s                                                                                                                                                                                                                                 ")
            sb.AppendLine("			on s.schema_id = t.schema_id                                                                                                                                                                                                                        ")
            sb.AppendLine("		join sys.index_columns as ic                                                                                                                                                                                                                          ")
            sb.AppendLine("			on ic.object_id = t.object_id and ic.index_id = k.unique_index_id                                                                                                                                                                                   ")
            sb.AppendLine("		join sys.columns as c                                                                                                                                                                                                                                 ")
            sb.AppendLine("			on c.object_id = t.object_id and c.column_id = ic.column_id                                                                                                                                                                                         ")
            sb.AppendLine("Where t.name LIKE @tablaname order by COLUMN_NAME                                                                                                                                                                                                        ")
            sb.AppendLine("---------------------------------------------------------------------------------------                                                                                                                                                                  ")
            sb.AppendLine("declare @foraneas as Table (K_Table sql_variant, FK_Column sql_variant, PK_Table sql_variant, PK_Column sql_variant, Constraint_Name sql_variant)                                                                                                        ")
            sb.AppendLine("insert into @foraneas                                                                                                                                                                                                                                    ")
            sb.AppendLine("SELECT                                                                                                                                                                                                                                                   ")
            sb.AppendLine("       K_Table  = FK.TABLE_NAME,                                                                                                                                                                                                                         ")
            sb.AppendLine("       FK_Column = CU.COLUMN_NAME,                                                                                                                                                                                                                       ")
            sb.AppendLine("       PK_Table  = PK.TABLE_NAME,                                                                                                                                                                                                                        ")
            sb.AppendLine("       PK_Column = PT.COLUMN_NAME,                                                                                                                                                                                                                       ")
            sb.AppendLine("       Constraint_Name = C.CONSTRAINT_NAME                                                                                                                                                                                                               ")
            sb.AppendLine("FROM       INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS C                                                                                                                                                                                                  ")
            sb.AppendLine("INNER JOIN  INFORMATION_SCHEMA.TABLE_CONSTRAINTS FK ON C.CONSTRAINT_NAME = FK.CONSTRAINT_NAME                                                                                                                                                            ")
            sb.AppendLine("INNER JOIN      INFORMATION_SCHEMA.TABLE_CONSTRAINTS PK ON C.UNIQUE_CONSTRAINT_NAME = PK.CONSTRAINT_NAME                                                                                                                                                 ")
            sb.AppendLine("INNER JOIN      INFORMATION_SCHEMA.KEY_COLUMN_USAGE CU ON C.CONSTRAINT_NAME = CU.CONSTRAINT_NAME                                                                                                                                                         ")
            sb.AppendLine("INNER JOIN  (                                                                                                                                                                                                                                            ")
            sb.AppendLine("       SELECT      i1.TABLE_NAME, i2.COLUMN_NAME                                                                                                                                                                                                         ")
            sb.AppendLine("       FROM        INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1                                                                                                                                                                                               ")
            sb.AppendLine("           INNER JOIN      INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME                                                                                                                                             ")
            sb.AppendLine("               WHERE       i1.CONSTRAINT_TYPE = 'PRIMARY KEY'                                                                                                                                                                                            ")
            sb.AppendLine("       ) PT ON PT.TABLE_NAME = PK.TABLE_NAME                                                                                                                                                                                                             ")
            sb.AppendLine("Where FK.TABLE_NAME Like @tablaname                                                                                                                                                                                                                      ")
            sb.AppendLine("---------------------------------------------------------------------------------------                                                                                                                                                                  ")
            sb.AppendLine("Select d.COLUMN_NAME ,d.COLUMN_DEFAULT                                                                                                                                                                                                                   ")
            sb.AppendLine("	   , d.IS_NULLABLE, d.DATA_TYPE                                                                                                                                                                                                                         ")
            sb.AppendLine("	   , d.ORDINAL_POSITION                                                                                                                                                                                                                                 ")
            sb.AppendLine("                                                                                                                                                                                                                                                         ")
            sb.AppendLine("		,Case                                                                                                                                                                                                                                                 ")
            sb.AppendLine("			When Not d.CHARACTER_MAXIMUM_LENGTH is Null Then d.CHARACTER_MAXIMUM_LENGTH                                                                                                                                                                         ")
            sb.AppendLine("			When Not d.NUMERIC_PRECISION is Null Then d.NUMERIC_PRECISION                                                                                                                                                                                       ")
            sb.AppendLine("			Else                                                                                                                                                                                                                                                ")
            sb.AppendLine("				Case When  Convert(varchar(50), d.DATA_TYPE) like '%varchar' Then 4000                                                                                                                                                                            ")
            sb.AppendLine("					Else NULL                                                                                                                                                                                                                                       ")
            sb.AppendLine("				End                                                                                                                                                                                                                                               ")
            sb.AppendLine("		End As [Precision]                                                                                                                                                                                                                                    ")
            sb.AppendLine("                                                                                                                                                                                                                                                         ")
            sb.AppendLine("	   , d.NUMERIC_SCALE ,                                                                                                                                                                                                                                  ")
            sb.AppendLine("			Case When p.COLUMN_DESCRIPTION is Null then d.COLUMN_NAME Else p.COLUMN_DESCRIPTION End as COLUMN_DESCRIPTION,                                                                                                                                      ")
            sb.AppendLine("			Case When c.COLUMN_KEY is Null then 0 else 1 End As COLUMN_KEY,K_Table ,                                                                                                                                                                            ")
            sb.AppendLine("			FK_Column, PK_Table, PK_Column, Constraint_Name                                                                                                                                                                                                     ")
            sb.AppendLine("	From @detalle d                                                                                                                                                                                                                                         ")
            sb.AppendLine("		Left join @claves c On c.COLUMN_NAME = d.COLUMN_NAME                                                                                                                                                                                                  ")
            sb.AppendLine("		Left Join @propiedades p on p.COLUMN_NAME = d.COLUMN_NAME                                                                                                                                                                                             ")
            sb.AppendLine("		Left Join @foraneas f On d.COLUMN_NAME = f.FK_COLUMN                                                                                                                                                                                                  ")
            sb.AppendLine("---------------------------------------------------------------------------------------                                                                                                                                                                  ")
            sb.AppendLine("                                                                                                                                                                                                                                                         ")
            sb.AppendLine("                                                                                                                                                                                                                                                         ")
            sb.AppendLine("                                                                                                                                                                                                                                                         ")
            sb.AppendLine("END                                                                                                                                                                                                                                                      ")

            Return sb.ToString
        End Get

    End Property
    Public ABM_Prefix As String = "ABM_"
    Public ENTITY_Prefix As String = "Ent"
    Public OUTPUTPAT As String = "c:\PruebaGenerador\"
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
                    pField.EntityClassContainer = ENTITY_Prefix & PK_Table
                Else
                    If dtKeys.Select("COLUMN_NAME = '" & COLUMN_NAME & "'").Length > 0 Then
                        Dim drAux() As DataRow = dtKeys.Select("COLUMN_NAME = '" & COLUMN_NAME & "'")
                        PK_Table = drAux(0)("TABLE_NAME").ToString
                        pField.RelationType = Entities.EnumRelationType.Combo
                        pField.ForeingTable = PK_Table
                        pField.ForeingCRUD = ABM_Prefix & PK_Table
                        pField.FieldType = Entities.EnumFieldType.ForeingKey
                        pField.EntityClassContainer = ENTITY_Prefix & PK_Table

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

                If COLUMN_NAME.ToUpper.EndsWith("_D") Then
                    DescriptionFieldName = DescriptionFieldName & COLUMN_NAME & ","
                End If


                Dim ci As Data.DataColumn = GetColumnExtendInformation(TableNameString, COLUMN_NAME)
                pField.TypeName = ci.DataType.Name

                pField.DbType = GetDbType(ci.DataType.Name)

                If pField.TypeName.Contains("Byte[]") Then
                    pField.TypeName = "Byte"
                End If

                ' pField.TypeName = Me.GetColumnExtendInformation(Tabla, COLUMN_NAME)




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
            Me.Tables.Add(TableNameString, AuxiliaryClassExtends)
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
            AuxString = AuxString & "size:=" & Efield.Size.ToString & ","
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
        If Not Efield.Visibility = Nothing Then
            AuxString = AuxString & "TypeName:=""" & Efield.TypeName & ""","
        End If



        'If Not Efield.CustomValidationExpression Is Nothing Then
        '    AuxString = AuxString & "CustomValidationExpression:=""" & Efield.CustomValidationExpression.ToString & ""","
        'End If




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

    Private Function CreateInsertProcedeure(ByRef sbInsertProcedure As System.Text.StringBuilder, _
                                       ByRef TableName As String, _
                                       ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String
        CreateInsertProcedeure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_Insert"
        sbInsertProcedure.AppendLine("Create PROCEDURE  " & CreateInsertProcedeure)
        sbInsertProcedure.AppendLine("                                                                    ")

        Dim auxDeclarationVariables As String = ""

        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            Dim ci As DataColumn
            ci = GetColumnExtendInformation(TableName, pField.FieldName)

            auxDeclarationVariables += vbCrLf & "         @" & pField.FieldName.Replace(" "c, "_") & " As " & [Enum].GetName(GetSqlDBType(ci.DataType).GetType, GetSqlDBType(ci.DataType)) & IIf((Not pField.Size = Nothing AndAlso pField.Size > 0), "(" & pField.Size & ")", "").ToString & ","

        Next

        auxDeclarationVariables = auxDeclarationVariables.Substring(0, auxDeclarationVariables.Length - 1)

        sbInsertProcedure.Append(auxDeclarationVariables & vbCrLf)

        sbInsertProcedure.AppendLine("AS")
        sbInsertProcedure.AppendLine("BEGIN")
        sbInsertProcedure.AppendLine("    SET NOCOUNT ON;")
        sbInsertProcedure.AppendLine("")

        sbInsertProcedure.AppendLine("    BEGIN TRY")
        sbInsertProcedure.AppendLine("        INSERT INTO " & TableName)
        sbInsertProcedure.AppendLine("            ( ")

        auxDeclarationVariables = ""
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            auxDeclarationVariables += vbCrLf & "              [" & pField.FieldName & "],"

        Next
        auxDeclarationVariables = auxDeclarationVariables.Substring(0, auxDeclarationVariables.Length - 1)
        sbInsertProcedure.Append(auxDeclarationVariables & vbCrLf)


        sbInsertProcedure.AppendLine("             )")
        sbInsertProcedure.AppendLine("        VALUES ")
        sbInsertProcedure.AppendLine("              (")

        auxDeclarationVariables = ""
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield 
            auxDeclarationVariables += vbCrLf & "              @" & pField.FieldName.Replace(" "c, "_") & ","

        Next
        auxDeclarationVariables = auxDeclarationVariables.Substring(0, auxDeclarationVariables.Length - 1)
        sbInsertProcedure.Append(auxDeclarationVariables & vbCrLf)

        sbInsertProcedure.AppendLine("              );")
        sbInsertProcedure.AppendLine("    END TRY")
        sbInsertProcedure.AppendLine("    BEGIN CATCH")
        sbInsertProcedure.AppendLine("       DECLARE @Error_Message_Value NVARCHAR(4000);")
        sbInsertProcedure.AppendLine("		 SELECT @Error_Message_Value = ERROR_MESSAGE();")
        sbInsertProcedure.AppendLine("		 RAISERROR (@Error_Message_Value, 16, 1);")
        sbInsertProcedure.AppendLine("    END CATCH;")
        sbInsertProcedure.AppendLine("END;")

        sbInsertProcedure.AppendLine("GO")

    End Function

    Private Function CreateUpdateProcedeure(ByRef sbUpdateProcedure As System.Text.StringBuilder, _
                                      ByRef TableName As String, _
                                      ByVal listefield As List(Of BrainWork.Entities.EntityFieldExtendsAttribute)) As String

        CreateUpdateProcedeure = "prc_" & TableName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "") & "_Update"
        sbUpdateProcedure.AppendLine("Create PROCEDURE  " & CreateUpdateProcedeure)
        sbUpdateProcedure.AppendLine("                                                                    ")

        Dim auxDeclarationVariables As String = ""

        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield

            Dim ci As DataColumn
            ci = GetColumnExtendInformation(TableName, pField.FieldName)

            auxDeclarationVariables += vbCrLf & "         @" & pField.FieldName.Replace(" "c, "_") & " As " & [Enum].GetName(GetSqlDBType(ci.DataType).GetType, GetSqlDBType(ci.DataType)) & IIf((Not pField.Size = Nothing AndAlso pField.Size > 0), "(" & pField.Size & ")", "").ToString & ","

        Next

        auxDeclarationVariables = auxDeclarationVariables.Substring(0, auxDeclarationVariables.Length - 1)

        sbUpdateProcedure.Append(auxDeclarationVariables & vbCrLf)

        sbUpdateProcedure.AppendLine("AS")
        sbUpdateProcedure.AppendLine("BEGIN")
        sbUpdateProcedure.AppendLine("    SET NOCOUNT ON;")
        sbUpdateProcedure.AppendLine("")

        sbUpdateProcedure.AppendLine("    BEGIN TRY")
        sbUpdateProcedure.AppendLine("        Update " & TableName)
        sbUpdateProcedure.AppendLine("            SET ")

        auxDeclarationVariables = ""
        Dim WhereExpression As String = ""
        Dim isFirst As Boolean = True
        For Each pField As BrainWork.Entities.EntityFieldExtendsAttribute In listefield
            'default where con el primero que encuentra
            If isFirst Then
                isFirst = False
                WhereExpression = vbCrLf & "              Where [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
            End If

            If pField.FieldType <> Entities.EnumFieldType.PrimaryKey Then
                auxDeclarationVariables += vbCrLf & "              [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_") & ","
            Else
                WhereExpression = vbCrLf & "              Where [" & pField.FieldName & "] = @" & pField.FieldName.Replace(" "c, "_")
            End If

        Next
        auxDeclarationVariables = auxDeclarationVariables.Substring(0, auxDeclarationVariables.Length - 1)
        sbUpdateProcedure.Append(auxDeclarationVariables & vbCrLf)



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

    Private Sub AppendProperty(ByRef sbPropertysRegion As System.Text.StringBuilder, _
                               ByRef sbDeclarationRegion As System.Text.StringBuilder, _
                               ByRef sbConstructorMethod As System.Text.StringBuilder, _
                               ByVal efield As BrainWork.Entities.EntityFieldExtendsAttribute, _
                               ByVal Attributes As String)

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
        sbConstructorMethod.AppendLine(PrivateDim & " = Nothing")


        'inserta el campo en el area de la declaracion  
        sbDeclarationRegion.AppendLine(vbTab & "Private  " & PrivateDim & " As " & sType)

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

    Private Function GenerateClass(ByRef sbPropertysRegion As System.Text.StringBuilder, _
                               ByRef sbDeclarationRegion As System.Text.StringBuilder, _
                               ByRef sbMethodRegion As System.Text.StringBuilder, _
                               ByRef sbConstructorMethod As System.Text.StringBuilder, _
                               ByVal ClassName As String, _
                               Optional ByVal NamespaceName As String = Nothing) As String

        Dim ClassString As String
        ClassName = ClassName.Replace("["c, "").Replace("]"c, "").Replace("dbo.", "").Replace("."c, "_"c)
        ClassString = "''' <summary>"
        ClassString += "''' Auto Generated:  " & Date.Now.ToString() & vbCrLf
        ClassString += "''' </summary>"
        ClassString += " ''' <remarks></remarks>"

        If NamespaceName <> Nothing Then
            ClassString += "Namespace " & NamespaceName & vbCrLf
            ClassString += vbTab & "Public Class " & ClassName & vbCrLf
        Else
            ClassString += "Public Class " & ClassName & vbCrLf
        End If



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

        For Each Key As String In Me.TablesFields.Keys
            Dim sbInsertProcedure As New System.Text.StringBuilder
            Dim sbUpdateProcedure As New System.Text.StringBuilder

            Dim listefield As New List(Of BrainWork.Entities.EntityFieldExtendsAttribute)
            listefield = Me.TablesFields.Item(Key)
            ' CreateInsertProcedeure(sbInsertProcedure, Key, listefield)
            Dim sAux As String

            sAux = CreateInsertProcedeure(sbInsertProcedure, Key, listefield)
            PublishStoredProcedures(OUTPUTPAT, sbInsertProcedure.ToString, sAux)

            sAux = CreateUpdateProcedeure(sbUpdateProcedure, Key, listefield)
            PublishStoredProcedures(OUTPUTPAT, sbUpdateProcedure.ToString, sAux)

             

        Next


    End Sub

    Public Sub PublishStoredProcedures(ByVal directorio As String, ByVal storedProceduresString As String, ByVal procedureName As String)
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
                Me.AppendProperty(sbPropertysRegion, sbDeclarationRegion, sbConstructorMethod, efield, sbAuxiliary.ToString)
            Next

            sbConstructorMethod.AppendLine(vbTab & "End Sub")

            Dim classString = Me.GenerateClass(sbPropertysRegion, sbDeclarationRegion, sbMethodRegion, sbConstructorMethod, Key)
            PublishClass_Entitys(OUTPUTPAT, classString, Me.ENTITY_Prefix & Key)
        Next






    End Sub

    Private Sub PublishClass_Entitys(ByVal directorio As String, ByVal classString As String, ByVal ClassName As String)

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














































































