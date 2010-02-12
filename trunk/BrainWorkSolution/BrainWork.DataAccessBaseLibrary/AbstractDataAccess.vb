Option Explicit On
Option Strict On
Imports System.Reflection
Imports System.Linq.Expressions

<Serializable()> _
Public MustInherit Class AbstractDataAccess
    Implements BrainWork.Connections.Interfaces.IDBrainWorkConnection

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

    Private _Entity As Object
    Public Event OnAdd(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Event OnDelete(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Event OnUpdate(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Event OnDisable(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)

    Public Event OnAlterValues(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Sub _OnAlterValues(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
        RaiseEvent OnAlterValues(p, spName)
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

    Public Function GetDataTable(ByVal Row As Integer, ByVal Page As Integer) As DataTable

        Return GetDataTableEntity(Row, Page)
    End Function

    Public Function GetDataSet(ByVal Row As Integer, ByVal Page As Integer) As DataSet

        Return GetDataSetEntity(0, 0)
    End Function

    Public Function GetDataReader() As IDataReader

        Return GetDataReaderEntity(0, 0)
    End Function

    Public Function GetDataReader(ByVal Row As Integer, ByVal Page As Integer) As IDataReader

        Return GetDataReaderEntity(Row, Page)
    End Function

    Public Function GetList() As IList(Of Object)

        Return GetListEntity(0, 0)
    End Function

    Public Function GetList(ByVal Row As Integer, ByVal Page As Integer) As List(Of Object)

        Return GetListEntity(Row, Page)
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
    Protected Sub New(ByVal oUser As BrainWork.Security.ApplicationUser, ByVal oEntity As BrainWork.Entities.AbstractEntityBase)
        Me._userlogged = oUser

        If Me._userlogged Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedUser
        End If

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
            Return CType(Me._Entity, BrainWork.Entities.AbstractEntityBase)
        End Get
    End Property



    Protected MustOverride Sub SetStoredProcedures()


    Public Function GetEntityFieldExtendsAttributes() As Dictionary(Of String, BrainWork.Entities.PropertysExtendedAtributtes)
        Return Entity.GetExtendedFieldsAttributes()
    End Function


#Region "Funciones Privadas Auxiliares"
    Private Function GetParameterByStored(ByVal spName As String) As System.Data.IDbDataParameter()
        Dim EntFieldList As List(Of BrainWork.Entities.EntityFieldExtendsAttribute) = Me.Entity.GetEntityFieldExtendsAttributes

        Dim pi As List(Of System.Data.IDbDataParameter) = Me.GetStoredProcedureInfo(SP_GETALL)

        Dim p2 As New List(Of System.Data.IDbDataParameter)

        For Each p As System.Data.Common.DbParameter In pi

            For Each entField As BrainWork.Entities.EntityFieldExtendsAttribute In EntFieldList

                If entField.ParameterName.ToLower = p.ParameterName.ToLower Then
                    p2.Add(CType(entField, System.Data.IDbDataParameter))
                    Exit For
                End If
            Next
        Next

        Return p2.ToArray()

    End Function

    Private Sub ParametizeValues(ByRef ParameterList() As System.Data.IDbDataParameter)
        Dim pi() As Reflection.PropertyInfo = Me.GetType.GetProperties()

        For i As Integer = 0 To ParameterList.Length - 1
            For Each PropertyItem As Reflection.PropertyInfo In pi
                If Replace(PropertyItem.Name.ToLower, "@"c, "") = Replace(ParameterList(i).ParameterName.ToLower, "@"c, "") Then
                    ParameterList(i).Value = PropertyItem.GetValue(Me, Nothing)
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Function CreateObjectByRow(ByVal dr As DataRow) As Object
        Static pi() As Reflection.PropertyInfo = Me.GetType.GetProperties()
        Dim p As Object = Activator.CreateInstance(Me.Entity.GetType) ' Crea la instancia del objeto
        For Each PropertyItem As Reflection.PropertyInfo In pi
            Dim att As BrainWork.Entities.EntityFieldExtendsAttribute
            att = Me.Entity.GetFieldProperties(PropertyItem.Name)
            PropertyItem.SetValue(p, dr(att.FieldName), Nothing)
        Next
        Return p
    End Function

    Private Function CreateObjectByReader(ByVal dr As IDataReader) As Object
        Static pi() As Reflection.PropertyInfo = Me.GetType.GetProperties()
        Dim p As Object = Activator.CreateInstance(Me.Entity.GetType) ' Crea la instancia del objeto
        For Each PropertyItem As Reflection.PropertyInfo In pi
            Dim att As BrainWork.Entities.EntityFieldExtendsAttribute
            att = Me.Entity.GetFieldProperties(PropertyItem.Name)
            PropertyItem.SetValue(p, dr(att.FieldName), Nothing)
        Next
        Return p
    End Function


#End Region

#Region "Funciones de ABML"
    Protected Overridable Sub AddEntity(ByRef ParameterList() As System.Data.IDbDataParameter, ByRef SP_Name As String)
        SP_Name = SP_ADD
        ParameterList = GetParameterByStored(SP_ADD)
        ParametizeValues(ParameterList)

        Dim id As Object = Me.ExecuteStoredProcedureReturns(SP_ADD, ParameterList)
        Dim PropertyItem As PropertyInfo = Me.Entity.GetType.GetProperty(Me.GetIDProperty)
        PropertyItem.SetValue(Me._Entity, id, Nothing)
    End Sub

    Protected Overridable Sub UpdateEntity(ByRef ParameterList() As System.Data.IDbDataParameter, ByRef SP_Name As String)
        SP_Name = SP_UPDATE
        ParameterList = GetParameterByStored(SP_Name)
        ParametizeValues(ParameterList)
        Me.ExecuteStoredProcedureNonQuery(SP_UPDATE, ParameterList)
    End Sub

    Protected Overridable Sub DeleteEntity(ByRef ParameterList() As System.Data.IDbDataParameter, ByRef SP_Name As String)
        SP_Name = SP_DELETE
        ParameterList = GetParameterByStored(SP_Name)
        ParametizeValues(ParameterList)
        Me.ExecuteStoredProcedureNonQuery(SP_DELETE, ParameterList)
    End Sub

    Protected Overridable Function GetIDProperty() As String
        Return Me.Entity.ExtendedClassAttributes.DescriptionPropertyName
    End Function

    Protected Overridable Function GetDescriptionProperty() As String
        Return Me.Entity.ExtendedClassAttributes.DescriptionPropertyName
    End Function 

    Protected Overridable Sub LoadEntityByPk(ByVal PK As Object)
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_UPDATE_BY_PK)
        Dim p As System.Data.IDbDataParameter
        p = Me.GetNewParameter

        For i As Integer = 0 To ParameterList.Length - 1
            If ParameterList(i).ParameterName.Replace("@"c, "") = Me.Entity.ExtendedClassAttributes.PrimaryKeyFieldName Then
                p = ParameterList(i)
                p.Value = PK
                Exit For
            End If
        Next

        If p.ParameterName Is Nothing Then
            Throw New Exception("No existe el parámetro")
        End If

        Dim dt As New DataTable
        dt = Me.GetStoredProcedureDataTable(Me.SP_UPDATE_BY_PK)
        Me._Entity = CreateObjectByRow(dt.Rows(0))



    End Sub

    Protected Overridable Function GetOneTable() As DataTable
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETONE)
        ParametizeValues(ParameterList)
        Dim dr As DataTable = Me.GetStoredProcedureDataTable(Me.SP_GETONE, 0, 0, ParameterList)
        Return dr
    End Function

    Protected Overridable Function GetOneEntity() As BrainWork.Entities.Interfaces.IEntityFieldExtendsAttribute
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETONE)
        ParametizeValues(ParameterList)
        Dim dr As IDataReader = Me.GetStoredProcedureDataReader(Me.SP_GETONE, 0, 0, ParameterList)
        Return CType(CreateObjectByReader(dr), BrainWork.Entities.Interfaces.IEntityFieldExtendsAttribute)
    End Function

    Protected Overridable Function GetDataTableEntity(ByVal Row As Integer, ByVal Page As Integer) As DataTable
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL)
        ParametizeValues(ParameterList)
        Return Me.GetStoredProcedureDataTable(Me.SP_GETALL, Row, Page, ParameterList)

    End Function

    Protected Overridable Function GetDataSetEntity(ByVal Row As Integer, ByVal Page As Integer) As DataSet
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL)
        ParametizeValues(ParameterList)
        Return Me.GetStoredProcedureDataSet(Me.SP_GETALL, Row, Page, ParameterList)
    End Function

    Protected Overridable Function GetDataReaderEntity(ByVal Row As Integer, ByVal Page As Integer) As IDataReader
        Dim ParameterList() As System.Data.IDbDataParameter
        ParameterList = GetParameterByStored(SP_GETALL)
        ParametizeValues(ParameterList)
        Return Me.GetStoredProcedureDataReader(Me.SP_GETALL, Row, Page, ParameterList)
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

        Dim pk As Object = propertyItem.GetValue(Me, Nothing)
        Me.LoadEntityByPk(pk)

    End Sub


    Protected MustOverride Sub DisableEntity(ByRef NewParameters() As System.Data.IDbDataParameter, ByRef SP_Name As String)

#End Region


#Region "Connection Manager"

    Private Function CnnManager() As BrainWork.DataManager.ConnectionManager
        If _ConnectionManager Is Nothing Then
            _ConnectionManager = New BrainWork.DataManager.ConnectionManager(_userlogged)
        End If
        Return _ConnectionManager
    End Function

    Public Overloads Sub BeginTransaction() Implements Connections.Interfaces.IDBrainWorkConnection.BeginTransaction
        CnnManager().getConnectionUser().BeginTransaction()
    End Sub

    Protected Sub CloseConnection() Implements Connections.Interfaces.IDBrainWorkConnection.CloseConnection
        CnnManager().getConnectionUser().CloseConnection()
    End Sub

    Public Sub CommitTransaction() Implements Connections.Interfaces.IDBrainWorkConnection.CommitTransaction
        CnnManager().getConnectionUser().CommitTransaction()
    End Sub

    Protected Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
        CnnManager().getConnectionUser().ExecuteStoredProcedureNonQuery(StoredProcedureName, Parameters)
        _OnAlterValues(Parameters, StoredProcedureName)
    End Sub

    Protected Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
        CnnManager().getConnectionUser().ExecuteStoredProcedureNonQuery(StoredProcedureName, params)
        _OnAlterValues(Parameters, StoredProcedureName)
    End Sub

    Protected Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Object Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
        Return CnnManager().getConnectionUser().ExecuteStoredProcedureReturns(sStoredProcedureName, Parameters)
        _OnAlterValues(Parameters, sStoredProcedureName)
    End Function

    Protected Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As Object Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
        Return CnnManager().getConnectionUser().ExecuteStoredProcedureReturns(sStoredProcedureName, params)
        _OnAlterValues(Parameters, sStoredProcedureName)
    End Function

    Protected Function GetNewCommand() As System.Data.IDbCommand Implements Connections.Interfaces.IDBrainWorkConnection.GetNewCommand
        Return CnnManager().getConnectionUser().GetNewCommand()
    End Function

    Protected Function GetNewConnection() As System.Data.IDbConnection Implements Connections.Interfaces.IDBrainWorkConnection.GetNewConnection
        Return CnnManager().getConnectionUser().GetNewConnection()
    End Function

    Protected Function GetOpenConnection() As System.Data.IDbConnection Implements Connections.Interfaces.IDBrainWorkConnection.GetOpenConnection
        Return CnnManager().getConnectionUser().GetOpenConnection()
    End Function

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(StoredProcedureName, RowFrom, RowTo, Parameters)
    End Function

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(StoredProcedureName, Parameters)
    End Function

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(StoredProcedureName, params)
    End Function

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(StoredProcedureName, params, RowFrom, RowTo)
    End Function

    Protected Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Return CnnManager().getConnectionUser().GetStoredProcedureDataTable(StoredProcedureName, RowFrom, RowTo, Parameters)
    End Function

    Protected Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Return CnnManager().getConnectionUser().GetStoredProcedureDataTable(StoredProcedureName, Parameters)
    End Function

    Protected Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Return CnnManager().getConnectionUser().GetStoredProcedureDataTable(StoredProcedureName, params)
    End Function

    Protected Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Return CnnManager().getConnectionUser().GetStoredProcedureDataTable(StoredProcedureName, params, RowFrom, RowTo)
    End Function

    Protected Function GetTable(ByVal TableName As String) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetTable
        Return CnnManager().getConnectionUser().GetTable(TableName)
    End Function

    Protected Function GetTable(ByVal TableName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetTable
        Return CnnManager().getConnectionUser().GetTable(TableName, RowFrom, RowTo)
    End Function

    Private Sub OpenConnection() Implements Connections.Interfaces.IDBrainWorkConnection.OpenConnection
        CnnManager().getConnectionUser().OpenConnection()
    End Sub

    Public Sub RollBackTransaction() Implements Connections.Interfaces.IDBrainWorkConnection.RollBackTransaction
        CnnManager().getConnectionUser().RollBackTransaction()
    End Sub

    Protected ReadOnly Property TransactionCount() As Integer Implements Connections.Interfaces.IDBrainWorkConnection.TransactionCount
        Get
            Return CnnManager().getConnectionUser().TransactionCount
        End Get
    End Property

    Protected Function BeginTransactionFunction() As System.Data.IDbTransaction Implements System.Data.IDbConnection.BeginTransaction
        Return Nothing
    End Function

    Protected Function BeginTransaction1(ByVal il As System.Data.IsolationLevel) As System.Data.IDbTransaction Implements System.Data.IDbConnection.BeginTransaction
        Return Nothing
    End Function

    Private Sub ChangeDatabase(ByVal databaseName As String) Implements System.Data.IDbConnection.ChangeDatabase
        CnnManager().getConnectionUser().ChangeDatabase(databaseName)
    End Sub

    Private Sub Close() Implements System.Data.IDbConnection.Close
        CnnManager().getConnectionUser().Close()
    End Sub

    Private Property ConnectionString() As String Implements System.Data.IDbConnection.ConnectionString
        Get
            Return CnnManager().getConnectionUser().ConnectionString
        End Get
        Set(ByVal value As String)
            CnnManager().getConnectionUser().ConnectionString = value
        End Set
    End Property

    Protected ReadOnly Property ConnectionTimeout() As Integer Implements System.Data.IDbConnection.ConnectionTimeout
        Get
            Return CnnManager().getConnectionUser().ConnectionTimeout
        End Get
    End Property

    Protected Function CreateCommand() As System.Data.IDbCommand Implements System.Data.IDbConnection.CreateCommand
        Return CnnManager().getConnectionUser().CreateCommand
    End Function

    Protected ReadOnly Property Database() As String Implements System.Data.IDbConnection.Database
        Get
            Return CnnManager().getConnectionUser().Database
        End Get
    End Property

    Private Sub Open() Implements System.Data.IDbConnection.Open
        CnnManager().getConnectionUser().Open()
    End Sub

    Protected ReadOnly Property State() As System.Data.ConnectionState Implements System.Data.IDbConnection.State
        Get
            Return CnnManager().getConnectionUser().State
        End Get
    End Property


    Public Function GetStoredProcedureInfo(ByVal SpName As String) As System.Collections.Generic.List(Of System.Data.IDbDataParameter) Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureInfo
        Return CnnManager().getConnectionUser().GetStoredProcedureInfo(SpName)
    End Function

    Public Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String) As System.Data.IDataReader Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
        Return CnnManager().getConnectionUser().GetStoredProcedureDataReader(StoredProcedureName)
    End Function

    Public Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.IDataReader Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
        Return CnnManager().getConnectionUser().GetStoredProcedureDataReader(StoredProcedureName, RowFrom, MaxRecords)
    End Function

    Public Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.IDataReader Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
        Return CnnManager().getConnectionUser().GetStoredProcedureDataReader(StoredProcedureName, RowFrom, MaxRecords, Parameters)
    End Function

    Public Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.IDataReader Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
        Return CnnManager().getConnectionUser().GetStoredProcedureDataReader(StoredProcedureName, params, RowFrom, MaxRecords)
    End Function

    Public Function GetNewParameter() As System.Data.IDbDataParameter Implements Connections.Interfaces.IDBrainWorkConnection.GetNewParameter
        Return CnnManager().getConnectionUser().GetNewParameter
    End Function

#End Region


#Region "IDisposable Support"

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
