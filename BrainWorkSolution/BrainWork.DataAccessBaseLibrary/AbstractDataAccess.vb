Option Explicit On
Option Strict On
Imports System.Reflection
Imports System.Linq.Expressions
Imports BrainWork.Connections

<Serializable()> _
Public MustInherit Class AbstractDataAccess
    ' Implements BrainWork.Connections.Interfaces.IDBrainWorkConnection
    Private _ConnectionManager As BrainWork.DataManager.ConnectionManager
    Private _userlogged As BrainWork.Security.ApplicationUser
    Protected SP_ADD As String = Nothing
    Protected SP_DELETE As String = Nothing
    Protected SP_UPDATE As String = Nothing
    Protected SP_UPDATE_BY_PK As String = Nothing
    Protected SP_DISABLE As String = Nothing
    Protected SP_GETONE As String = Nothing
    Protected SP_GETALL As String = Nothing
    Protected SP_GETALL_FULLDESCRIPTION As String = Nothing

    Private _PAGED_ROW_PARAMETER As String = "@Row"
    Private _PAGED_MAXVALUES_PARAMETER As String = "@MaxValues"
    Private _PAGED_COUNT_PARAMETER As String = "@RecordCount"
    Private _ORDER_BY_PARAMETER As String = "@OrderBy"
    Private _ORDER_BY_DIRECTION_PARAMETER As String = "@OrderByDirection"
    Private _ID_GENERATED_ROW As String = "@ID_Generated_New"
    Protected _CurrentEntity As Object
    Private WithEvents _CurrentConnection As BrainWork.Connections.BrainWorkConnection
    Public Event OnAdd(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Event OnDelete(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Event OnUpdate(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Event OnDisable(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)

    Private _SelectedOrderBy As String
    Private _SelectedDirection As String = "ASC"
    Private _SelectedRow As Int32 = 0
    Private _SelectedMaxRecords As Int32 = 0
    Private _RecordCount As Int64

    Protected Overridable Property ID_GENERATED_ROW() As String
        Get
            Return _ID_GENERATED_ROW
        End Get
        Set(ByVal value As String)
            _ID_GENERATED_ROW = value
        End Set
    End Property

    Protected Overridable Property ORDER_BY_DIRECTION_PARAMETER() As String
        Get
            Return _ORDER_BY_DIRECTION_PARAMETER
        End Get
        Set(ByVal value As String)
            _ORDER_BY_DIRECTION_PARAMETER = value
        End Set
    End Property

    Protected Overridable Property ORDER_BY_PARAMETER() As String
        Get
            Return _ORDER_BY_PARAMETER
        End Get
        Set(ByVal value As String)
            _ORDER_BY_PARAMETER = value
        End Set
    End Property

    Protected Overridable Property PAGED_COUNT_PARAMETER() As String
        Get
            Return _PAGED_COUNT_PARAMETER
        End Get
        Set(ByVal value As String)
            _PAGED_COUNT_PARAMETER = value
        End Set
    End Property

    Protected Overridable Property PAGED_MAXVALUES_PARAMETER() As String
        Get
            Return _PAGED_MAXVALUES_PARAMETER
        End Get
        Set(ByVal value As String)
            _PAGED_MAXVALUES_PARAMETER = value
        End Set
    End Property

    Protected Overridable Property PAGED_ROW_PARAMETER() As String
        Get
            Return _PAGED_ROW_PARAMETER
        End Get
        Set(ByVal value As String)
            _PAGED_ROW_PARAMETER = value
        End Set
    End Property






    Protected Overridable Function GetEntity() As Object
        Return _CurrentEntity
    End Function

    Public Overridable Sub RefreshEntity(ByVal oEnt As Object)

        _CurrentEntity = oEnt
    End Sub



    Protected Overridable Property SelectedMaxRecords() As Int32
        Get
            Return _SelectedMaxRecords
        End Get
        Set(ByVal value As Int32)
            _SelectedMaxRecords = value
        End Set
    End Property


    Protected Overridable Property SelectedRow() As Int32
        Get
            Return _SelectedRow
        End Get
        Set(ByVal value As Int32)
            _SelectedRow = value
        End Set
    End Property


    Protected Overridable Property SelectedDirection() As String
        Get
            Return _SelectedDirection
        End Get
        Set(ByVal value As String)
            _SelectedDirection = value
        End Set
    End Property

    Public Overridable Property RecordCount() As Int64
        Get
            Return _RecordCount
        End Get
        Set(ByVal value As Int64)
            _RecordCount = value
        End Set
    End Property




    Protected Overridable Property SelectedOrderBy() As String
        Get
            If _SelectedOrderBy Is Nothing Then

                For Each item As BrainWork.Entities.EntityFieldExtendsAttribute In Me.Entity.GetEntityFieldExtendsAttributes
                    If item.IsDefaultOrderBy Then
                        _SelectedOrderBy = item.FieldName
                        Exit For
                    End If
                Next

            End If
            Return _SelectedOrderBy
        End Get
        Set(ByVal value As String)
            _SelectedOrderBy = value
        End Set
    End Property


    '--         @Row int,
    Protected Overridable Function GetPAGED_ROW_PARAMETER_parameter() As System.Data.IDbDataParameter
        GetPAGED_ROW_PARAMETER_parameter = Me.CurrentConnection.GetNewParameter
        GetPAGED_ROW_PARAMETER_parameter.Direction = ParameterDirection.Input
        GetPAGED_ROW_PARAMETER_parameter.DbType = DbType.Int32
        GetPAGED_ROW_PARAMETER_parameter.ParameterName = PAGED_ROW_PARAMETER
    End Function

    '--         @MaxValues int,
    Protected Overridable Function GetPAGED_MAXVALUES_PARAMETER_parameter() As System.Data.IDbDataParameter
        GetPAGED_MAXVALUES_PARAMETER_parameter = Me.CurrentConnection.GetNewParameter
        GetPAGED_MAXVALUES_PARAMETER_parameter.Direction = ParameterDirection.Input
        GetPAGED_MAXVALUES_PARAMETER_parameter.DbType = DbType.Int32
        GetPAGED_MAXVALUES_PARAMETER_parameter.ParameterName = PAGED_MAXVALUES_PARAMETER
    End Function

    '--         @RecordCount bigint OUTPUT 
    Protected Overridable Function GetPAGED_COUNT_PARAMETER_parameter() As System.Data.IDbDataParameter
        GetPAGED_COUNT_PARAMETER_parameter = Me.CurrentConnection.GetNewParameter
        GetPAGED_COUNT_PARAMETER_parameter.Direction = ParameterDirection.Output
        GetPAGED_COUNT_PARAMETER_parameter.DbType = DbType.Int64
        GetPAGED_COUNT_PARAMETER_parameter.ParameterName = PAGED_COUNT_PARAMETER
    End Function

    '           @OrderBy varchar(500),
    Protected Overridable Function GetORDER_BY_DIRECTION_PARAMETER_parameter() As System.Data.IDbDataParameter
        GetORDER_BY_DIRECTION_PARAMETER_parameter = Me.CurrentConnection.GetNewParameter
        GetORDER_BY_DIRECTION_PARAMETER_parameter.Direction = ParameterDirection.Input
        GetORDER_BY_DIRECTION_PARAMETER_parameter.DbType = DbType.String
        GetORDER_BY_DIRECTION_PARAMETER_parameter.Size = 500
        GetORDER_BY_DIRECTION_PARAMETER_parameter.ParameterName = ORDER_BY_DIRECTION_PARAMETER
    End Function

    '--         @OrderByDirection varchar(500),
    Protected Overridable Function GetORDER_BY_PARAMETER_parameter() As System.Data.IDbDataParameter
        GetORDER_BY_PARAMETER_parameter = Me.CurrentConnection.GetNewParameter
        GetORDER_BY_PARAMETER_parameter.Direction = ParameterDirection.Input
        GetORDER_BY_PARAMETER_parameter.DbType = DbType.String
        GetORDER_BY_PARAMETER_parameter.Size = 500
        GetORDER_BY_PARAMETER_parameter.ParameterName = ORDER_BY_PARAMETER
    End Function


    Protected Overridable Function GetID_GENERATED_ROW_parameter() As System.Data.IDbDataParameter
        GetID_GENERATED_ROW_parameter = Me.CurrentConnection.GetNewParameter
        GetID_GENERATED_ROW_parameter.Direction = ParameterDirection.Output
        GetID_GENERATED_ROW_parameter.DbType = DbType.Int64
        GetID_GENERATED_ROW_parameter.ParameterName = ID_GENERATED_ROW
    End Function


    Protected Overridable Function HasStandarParametersSettings(ByRef oCmd As IDbCommand, ByVal row As Integer, ByVal page As Integer) As Boolean
        HasStandarParametersSettings = True

        If Not oCmd.Parameters.Contains(PAGED_ROW_PARAMETER) OrElse _
           Not oCmd.Parameters.Contains(PAGED_MAXVALUES_PARAMETER) OrElse _
           Not oCmd.Parameters.Contains(ORDER_BY_PARAMETER) OrElse _
           Not oCmd.Parameters.Contains(ORDER_BY_DIRECTION_PARAMETER) Then
            HasStandarParametersSettings = False
        End If
        'If Not oCmd.Parameters.Contains(PAGED_ROW_PARAMETER) Then
        '    'Dim p As IDbDataParameter = Me.GetNewParameter
        '    'p.ParameterName = PAGED_ROW_PARAMETER
        '    'p.Direction = ParameterDirection.Input
        '    'p.DbType = DbType.Int32
        '    'p.Value = row
        '    HasStandarParametersSettings = False
        'End If

        'If Not oCmd.Parameters.Contains(PAGED_PAGE_PARAMETER) Then
        '    'Dim p As IDbDataParameter = Me.GetNewParameter
        '    'p.ParameterName = PAGED_PAGE_PARAMETER
        '    'p.Direction = ParameterDirection.Input
        '    'p.DbType = DbType.Int32
        '    'p.Value = page
        '    HasStandarParametersSettings = False
        'End If

        'If Not oCmd.Parameters.Contains(ORDER_BY_PARAMETER) Then
        '    'Dim p As IDbDataParameter = Me.GetNewParameter
        '    'p.ParameterName = PAGED_PAGE_PARAMETER
        '    'p.Direction = ParameterDirection.Input
        '    'p.DbType = DbType.String
        '    'p.Value = ""
        '    HasStandarParametersSettings = False
        'End If

    End Function




    Private Function CurrentConnection() As BrainWork.Connections.BrainWorkConnection
        If _CurrentConnection Is Nothing Then
            _ConnectionManager = New BrainWork.DataManager.ConnectionManager(Me.ApplicationUser)
            _CurrentConnection = _ConnectionManager.CurrentConnection
        ElseIf Not _ConnectionManager.ApplicationUser Is Me.ApplicationUser Then
            _ConnectionManager = New BrainWork.DataManager.ConnectionManager(Me.ApplicationUser)
            _CurrentConnection = _ConnectionManager.CurrentConnection
        End If
        Return _CurrentConnection
    End Function

    Public Sub BeginTransaction()
        Me.CurrentConnection.BeginTransaction()
    End Sub
    Public Sub CommitTransaction()
        Me.CurrentConnection.CommitTransaction()
    End Sub
    Public Sub RollBackTransaction()
        Me.CurrentConnection.RollBackTransaction()
    End Sub


    Private Sub _OnAdd(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
        RaiseEvent OnAdd(p, spName)
    End Sub

    Private Sub _OnDelete(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
        RaiseEvent OnDelete(p, spName)
    End Sub
    Private Sub _OnUpdate(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
        RaiseEvent OnUpdate(p, spName)
    End Sub
    Private Sub _OnDisable(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
        RaiseEvent OnDisable(p, spName)
    End Sub




#Region "Propiedades Públicas"
    Public ReadOnly Property ApplicationUser() As BrainWork.Security.ApplicationUser
        Get
            Return _userlogged
        End Get
    End Property
#End Region

#Region "Funciones de ABML Publicas"

    Public Function Add() As Boolean
        Dim strError As String = Nothing

        Try
            Dim NewParameters() As System.Data.IDbDataParameter = Nothing
            Dim SP_Name As String = Nothing
            AddEntity(NewParameters, SP_Name)
            RaiseEvent OnDelete(NewParameters, SP_Name)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function Delete() As Boolean
        Dim strError As String = Nothing

        Try
            Dim NewParameters() As System.Data.IDbDataParameter = Nothing
            Dim SP_Name As String = Nothing
            DeleteEntity(NewParameters, SP_Name)
            RaiseEvent OnDelete(NewParameters, SP_Name)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function Update() As Boolean
        Dim strError As String = Nothing

        Try
            Dim NewParameters() As System.Data.IDbDataParameter = Nothing
            Dim SP_Name As String = Nothing
            UpdateEntity(NewParameters, SP_Name)
            RaiseEvent OnUpdate(NewParameters, SP_Name)

        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function Disable() As Boolean
        Dim strError As String = Nothing

        Try
            Dim NewParameters() As System.Data.IDbDataParameter = Nothing
            Dim SP_Name As String = Nothing
            DisableEntity(NewParameters, SP_Name)
            RaiseEvent OnDisable(NewParameters, SP_Name)

        Catch ex As Exception
            Throw ex
        End Try

        Return True
    End Function

    Public Function GetOne() As Entities.Interfaces.IEntityFieldExtendsAttribute

        Return GetOneEntity()
    End Function

    Public Function GetOneAsTable() As DataTable

        Return GetOneTable()
    End Function

    Public Function GetDataTable() As DataTable

        Return GetDataTableEntity(0, 0)
    End Function

    Public Function GetDataSet() As DataSet
        Return GetDataSetEntity(0, 0)
    End Function

    Public Function GetDataTable(ByVal Row As Integer, ByVal MaxRecords As Integer) As DataTable

        Return GetDataTableEntity(Row, MaxRecords)
    End Function
    '

    Public Function GetDataTableFull(ByVal Row As Integer, ByVal MaxRecords As Integer, ByVal orderByColumn As String) As DataTable

        Return GetDataTableEntityFull(Row, MaxRecords, orderByColumn)
    End Function

    Public Function GetDataTable(ByVal Row As Integer, ByVal MaxRecords As Integer, ByVal orderByColumn As String) As DataTable

        Return GetDataTableEntity(Row, MaxRecords, orderByColumn)
    End Function

    Public Function GetDataSet(ByVal Row As Integer, ByVal MaxRecords As Integer) As DataSet

        Return GetDataSetEntity(Row, MaxRecords)
    End Function

    Public Function GetDataReader() As IDataReader

        Return GetDataReaderEntity(0, 0)
    End Function

    Public Function GetDataReader(ByVal Row As Integer, ByVal MaxRecords As Integer) As IDataReader

        Return GetDataReaderEntity(Row, MaxRecords)
    End Function

    Public Function GetList() As IList(Of Object)

        Return GetListEntity(0, 0)
    End Function

    Public Function GetList(ByVal Row As Integer, ByVal MaxRecords As Integer) As List(Of Object)

        Return GetListEntity(Row, MaxRecords)
    End Function

    Public Sub LoadByPk(ByVal PK As Object)

        LoadEntityByPk(PK)
    End Sub

    Public Sub Load()
        Dim NewParameters() As System.Data.IDbDataParameter = Nothing
        LoadEntity()
    End Sub



#End Region

#Region "Constructores"
    Protected Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        Me._userlogged = oUser

        If Me._userlogged Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedUser
        End If

        'If Entity Is Nothing Then
        '    Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedEntity
        'End If

        'setea los estored
        SetStoredProcedures()

        'Validacion de estored
        If SP_ADD Is Nothing OrElse _
            SP_DELETE Is Nothing OrElse _
            SP_UPDATE Is Nothing OrElse _
            SP_DISABLE Is Nothing OrElse SP_GETONE Is Nothing OrElse _
            SP_GETALL Is Nothing OrElse _
            SP_UPDATE_BY_PK Is Nothing Then

            Throw New Exceptions.ExceptionNotSetedStored
        End If

    End Sub


#End Region

    Protected ReadOnly Property Entity() As BrainWork.Entities.AbstractEntityBase
        Get
            Return CType(GetEntity(), BrainWork.Entities.AbstractEntityBase)
        End Get
    End Property



    Protected MustOverride Sub SetStoredProcedures()


    Public Function GetEntityFieldExtendsAttributes() As Dictionary(Of String, BrainWork.Entities.PropertysExtendedAtributtes)
        Return Entity.GetExtendedFieldsAttributes()
    End Function


#Region "Funciones Privadas Auxiliares"
    Private Function GetParameterByStored(ByVal spName As String) As System.Data.IDbDataParameter()
        Dim EntFieldList As List(Of BrainWork.Entities.EntityFieldExtendsAttribute) = Me.Entity.GetEntityFieldExtendsAttributes

        Dim pi As List(Of System.Data.IDbDataParameter) = Me.CurrentConnection.GetStoredProcedureInfo(spName)

        Dim p2 As New List(Of System.Data.IDbDataParameter)

        For Each p As System.Data.Common.DbParameter In pi

            For Each entField As BrainWork.Entities.EntityFieldExtendsAttribute In EntFieldList
                Me.CurrentConnection.SanitizeParameterName(CType(entField, System.Data.IDbDataParameter))
                If entField.ParameterName.ToLower = p.ParameterName.ToLower Then
                    p2.Add(CType(entField, System.Data.IDbDataParameter))
                    Exit For
                End If
            Next
        Next

        Return p2.ToArray()

    End Function
    'Public Function GetPropertyByNamedValue(ByVal PropertyName As   String)
    '    Dim userType As Type = Me.GetType()
    '    Dim UserProp As PropertyInfo = userType.GetProperty(PropertyName)
    '    Dim myValue As String
    '    myValue = UserProp.GetValue(Me, Nothing)
    '    Return myValue
    'End Function

    Private Function PropertyToDBValue(ByVal PropertyItem As Reflection.PropertyInfo) As Object


        'Dim dataType As Type = PropertyItem.PropertyType
        'If dataType.IsGenericType _
        '    AndAlso dataType.FullName.Contains("System.Nullable") Then 'Is GetType(System.Nullable) Then

        '    dataType = System.Nullable.GetUnderlyingType(dataType)
        'End If
        Dim oValue As Object = PropertyItem.GetValue(Me.Entity, Nothing)
        If oValue Is Nothing Then
            Return DBNull.Value
        End If

        Return oValue

        'If PropertyItem.PropertyType.IsGenericType _
        '                AndAlso PropertyItem.PropertyType.FullName.Contains("System.Nullable") Then 'Is GetType(System.Nullable) Then

        '    Return System.Nullable.GetUnderlyingType(PropertyItem.PropertyType)
        'End If


    End Function

    Private Sub ParametizeValues(ByRef ParameterList() As System.Data.IDbDataParameter, _
                                 Optional ByVal SetOutParameter As Boolean = False)
        Dim pi() As Reflection.PropertyInfo = Me.Entity.GetType.GetProperties()

        For i As Integer = 0 To ParameterList.Length - 1
            For Each PropertyItem As Reflection.PropertyInfo In pi
                Dim pat As BrainWork.Entities.EntityFieldExtendsAttribute = Me.Entity.GetPropertyAttributes(PropertyItem.Name)
                Me.CurrentConnection.SanitizeParameterName(CType(pat, System.Data.IDbDataParameter))
                If pat.ParameterName.ToLower = ParameterList(i).ParameterName.ToLower Then
                    ParameterList(i).Value = PropertyToDBValue(PropertyItem) 'PropertyItem.GetValue(Me.Entity, Nothing)
                    Exit For
                End If
            Next
        Next
        If SetOutParameter Then
            ReDim Preserve ParameterList(ParameterList.Length)
            ParameterList(ParameterList.Length - 1) = GetID_GENERATED_ROW_parameter()
        End If

    End Sub

    Private Sub SetPagedSortParams(ByRef ParameterList() As System.Data.IDbDataParameter, _
                                   ByVal Row As Int32, _
                                   ByVal MaxRecords As Int32, _
                                   ByVal OrderBy As String, _
                                   ByVal Direction As String)

        ReDim Preserve ParameterList(ParameterList.Length + 4)

        ParameterList(ParameterList.Length - 5) = GetORDER_BY_PARAMETER_parameter()
        ParameterList(ParameterList.Length - 5).Value = OrderBy

        ParameterList(ParameterList.Length - 4) = GetORDER_BY_DIRECTION_PARAMETER_parameter()
        ParameterList(ParameterList.Length - 4).Value = Direction

        ParameterList(ParameterList.Length - 3) = GetPAGED_ROW_PARAMETER_parameter()
        ParameterList(ParameterList.Length - 3).Value = Row

        ParameterList(ParameterList.Length - 2) = GetPAGED_MAXVALUES_PARAMETER_parameter()
        ParameterList(ParameterList.Length - 2).Value = MaxRecords

        ParameterList(ParameterList.Length - 1) = GetPAGED_COUNT_PARAMETER_parameter()

    End Sub

    Private Function CreateObjectByRow(ByVal dr As DataRow) As Object
        Static pi() As Reflection.PropertyInfo = Me.Entity.GetType.GetProperties()
        Dim p As Object = Activator.CreateInstance(Me.Entity.GetType) ' Crea la instancia del objeto
        For Each PropertyItem As Reflection.PropertyInfo In pi
            Dim att As BrainWork.Entities.EntityFieldExtendsAttribute
            att = Me.Entity.GetPropertyAttributes(PropertyItem.Name)
            PropertyItem.SetValue(p, dr(att.FieldName), Nothing)
        Next
        Return p
    End Function

    Private Function CreateObjectByReader(ByVal dr As IDataReader) As Object
        Static pi() As Reflection.PropertyInfo = Me.Entity.GetType.GetProperties()
        Dim p As Object = Activator.CreateInstance(Me.Entity.GetType) ' Crea la instancia del objeto
        For Each PropertyItem As Reflection.PropertyInfo In pi
            Dim att As BrainWork.Entities.EntityFieldExtendsAttribute
            att = Me.Entity.GetPropertyAttributes(PropertyItem.Name)
            PropertyItem.SetValue(p, dr(att.FieldName), Nothing)
        Next
        Return p
    End Function


#End Region

    Private Sub MappStoredReturns(ByVal ReturnedTable As Dictionary(Of String, Object))

        For Each Key As String In ReturnedTable.Keys
            For Each item As BrainWork.Entities.EntityFieldExtendsAttribute In Me.Entity.GetEntityFieldExtendsAttributes
                Me.CurrentConnection.SanitizeParameterName(CType(item, System.Data.IDbDataParameter))
                If Key.ToLower = item.ParameterName.ToLower Then
                    Dim PropertyItem As PropertyInfo = Me.Entity.GetType.GetProperty(item.PropertyName)
                    Dim ent As Object = GetEntity()
                    PropertyItem.SetValue(ent, ReturnedTable(Key), Nothing)
                    Exit For
                End If
            Next
        Next
    End Sub
#Region "Funciones de ABML"
    Protected Overridable Sub AddEntity(ByRef ParameterList() As System.Data.IDbDataParameter, ByRef SP_Name As String)
        SP_Name = SP_ADD
        ParameterList = GetParameterByStored(SP_Name)
        ParametizeValues(ParameterList, True)

        Dim ReturnedTable As New Dictionary(Of String, Object)
        ReturnedTable = Me.CurrentConnection.ExecuteStoredProcedureReturns(SP_Name, ParameterList)
        MappStoredReturns(ReturnedTable)

    End Sub

    Protected Overridable Sub UpdateEntity(ByRef ParameterList() As System.Data.IDbDataParameter, ByRef SP_Name As String)
        SP_Name = SP_UPDATE
        ParameterList = GetParameterByStored(SP_Name)
        ParametizeValues(ParameterList)
        Me.CurrentConnection.ExecuteStoredProcedureNonQuery(SP_Name, ParameterList)
    End Sub

    Protected Overridable Sub DeleteEntity(ByRef ParameterList() As System.Data.IDbDataParameter, ByRef SP_Name As String)
        SP_Name = SP_DELETE
        ParameterList = GetParameterByStored(SP_Name)
        ParametizeValues(ParameterList)
        Me.CurrentConnection.ExecuteStoredProcedureNonQuery(SP_Name, ParameterList)
    End Sub

    Protected Overridable Function GetIDProperty() As String
        Return Me.Entity.ExtendedClassAttributes.PrimaryKeyPropertyName
    End Function

    Protected Overridable Function GetDescriptionProperty() As String
        Return Me.Entity.ExtendedClassAttributes.DescriptionPropertyName
    End Function

    Protected Overridable Sub LoadEntityByPk(ByVal PK As Object)
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETONE)

        Me.ParametizeValues(ParameterList)
        'Dim p As System.Data.IDbDataParameter
        'p = Me.CurrentConnection.GetNewParameter

        'For i As Integer = 0 To ParameterList.Length - 1
        '    If ParameterList(i).ParameterName.Replace("@"c, "") = Me.Entity.ExtendedClassAttributes.PrimaryKeyFieldName Then
        '        p = ParameterList(i)
        '        p.Value = PK
        '        Exit For
        '    End If
        'Next

        'If p.ParameterName Is Nothing Then
        '    Throw New Exception("No existe el parámetro")
        'End If

        Dim dt As New DataTable
        dt = Me.CurrentConnection.GetStoredProcedureDataTable(Me.SP_GETONE, ParameterList)
        Me._CurrentEntity = CreateObjectByRow(dt.Rows(0))



    End Sub

    Protected Overridable Function GetOneTable() As DataTable
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETONE)
        ParametizeValues(ParameterList)

        Dim dr As DataTable = Me.CurrentConnection.GetStoredProcedureDataTable(Me.SP_GETONE, ParameterList)
        Return dr
    End Function

    Protected Overridable Function GetOneEntity() As BrainWork.Entities.Interfaces.IEntityFieldExtendsAttribute
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETONE)
        ParametizeValues(ParameterList)
        Dim dr As IDataReader = Me.CurrentConnection.GetStoredProcedureDataReader(Me.SP_GETONE, ParameterList)
        Return CType(CreateObjectByReader(dr), BrainWork.Entities.Interfaces.IEntityFieldExtendsAttribute)
    End Function

    Protected Overridable Function GetDataTableEntityFull(ByVal Row As Integer, ByVal MaxRecords As Integer, ByVal orderByColumn As String) As DataTable

        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL_FULLDESCRIPTION)
        ParametizeValues(ParameterList, False)

        Dim listReturnsValues As New Dictionary(Of String, Object)
        SetPagedSortParams(ParameterList, Row, MaxRecords, Me.SelectedOrderBy, Me.SelectedDirection)
        GetDataTableEntityFull = Me.CurrentConnection.GetStoredProcedureDataTable(Me.SP_GETALL_FULLDESCRIPTION, listReturnsValues, ParameterList)

        Me.RecordCount = CLng(IIf(listReturnsValues(Me.PAGED_COUNT_PARAMETER) Is DBNull.Value, 0, listReturnsValues(Me.PAGED_COUNT_PARAMETER)))

    End Function
    Protected Overridable Function GetDataTableEntity(ByVal Row As Integer, ByVal MaxRecords As Integer, ByVal orderByColumn As String) As DataTable

        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL)
        ParametizeValues(ParameterList, False)

        Dim listReturnsValues As New Dictionary(Of String, Object)
        SetPagedSortParams(ParameterList, Row, MaxRecords, Me.SelectedOrderBy, Me.SelectedDirection)
        GetDataTableEntity = Me.CurrentConnection.GetStoredProcedureDataTable(Me.SP_GETALL, listReturnsValues, ParameterList)

        Me.RecordCount = CLng(listReturnsValues(Me.PAGED_COUNT_PARAMETER))

    End Function

    Protected Overridable Function GetDataTableEntity(ByVal Row As Integer, ByVal MaxRecords As Integer) As DataTable

        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL)
        ParametizeValues(ParameterList, False)

        Dim listReturnsValues As New Dictionary(Of String, Object)
        SetPagedSortParams(ParameterList, Row, MaxRecords, Me.SelectedOrderBy, Me.SelectedDirection)
        GetDataTableEntity = Me.CurrentConnection.GetStoredProcedureDataTable(Me.SP_GETALL, listReturnsValues, ParameterList)

        Me.RecordCount = CLng(listReturnsValues(Me.PAGED_COUNT_PARAMETER))

    End Function

    Protected Overridable Function GetDataSetEntity(ByVal Row As Integer, ByVal MaxRecords As Integer) As DataSet
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL)
        ParametizeValues(ParameterList, False)

        Dim listReturnsValues As New Dictionary(Of String, Object)
        SetPagedSortParams(ParameterList, Row, MaxRecords, Me.SelectedOrderBy, Me.SelectedDirection)
        GetDataSetEntity = Me.CurrentConnection.GetStoredProcedureDataSet(Me.SP_GETALL, listReturnsValues, ParameterList)

        Me.RecordCount = CLng(listReturnsValues(Me.PAGED_COUNT_PARAMETER))

    End Function

    Protected Overridable Function GetDataReaderEntity(ByVal Row As Integer, ByVal MaxRecords As Integer) As IDataReader
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL)
        ParametizeValues(ParameterList, False)

        Dim listReturnsValues As New Dictionary(Of String, Object)
        SetPagedSortParams(ParameterList, Row, MaxRecords, Me.SelectedOrderBy, Me.SelectedDirection)
        GetDataReaderEntity = Me.CurrentConnection.GetStoredProcedureDataReader(Me.SP_GETALL, listReturnsValues, ParameterList)

        Me.RecordCount = CLng(listReturnsValues(Me.PAGED_COUNT_PARAMETER))
    End Function

    Protected Overridable Function GetListEntity(ByVal Row As Integer, ByVal Page As Integer) As List(Of Object)

        Dim dt As DataTable = GetDataTableEntity(Row, Page)

        GetListEntity = New List(Of Object)

        For Each dr As DataRow In dt.Rows

            GetListEntity.Add(CreateObjectByRow(dr))
        Next

    End Function

    Protected Overridable Sub LoadEntity()

        Dim propertyItem As PropertyInfo = Me.Entity.GetType.GetProperty(Me.GetIDProperty)

        Dim pk As Object = propertyItem.GetValue(Me.Entity, Nothing)
        Me.LoadEntityByPk(pk)

    End Sub


    Protected Overridable Sub DisableEntity(ByRef NewParameters() As System.Data.IDbDataParameter, ByRef SP_Name As String)
        SP_Name = SP_DISABLE
        NewParameters = GetParameterByStored(SP_Name)
        ParametizeValues(NewParameters)
        Me.CurrentConnection.ExecuteStoredProcedureNonQuery(SP_Name, NewParameters)

    End Sub

#End Region


#Region "Connection Manager"


#End Region



End Class
