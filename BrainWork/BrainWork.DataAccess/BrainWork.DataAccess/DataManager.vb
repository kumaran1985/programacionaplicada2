Imports BrainWork.IDataAccess
Imports BrainWork.DataAccessTrunk
Public Class DataManager
    Implements IConnectionManager

    Private Shared _ConnectionManager As IConnectionManager = Nothing
    Private Shared _GetConnectionType As EnumConnectionType = Nothing
    Private Shared _ConnectionString As String = Nothing
    Sub New(ByVal cnnManager As IConnectionManager)
        _ConnectionManager = cnnManager
    End Sub

    Sub New()

    End Sub

    Protected Overrides Sub Finalize()

    End Sub



    Public ReadOnly Property ConnectionString() As String
        Get
            If _ConnectionString Is Nothing Then
                _ConnectionString = Utils.Config.GetConfigValue("connectionString")
            End If
            Return _ConnectionString
        End Get
    End Property

    Public ReadOnly Property ConnectionManager() As IConnectionManager
        Get
            If _ConnectionManager Is Nothing Then

            End If
            Return _ConnectionManager
        End Get

    End Property

    Public ReadOnly Property GetConnectionType() As EnumConnectionType
        Get
            If _GetConnectionType = Nothing Then
                'Hardcode
                _GetConnectionType = EnumConnectionType.SQLClient
            End If
            Return _GetConnectionType
        End Get

    End Property


    Public Event AfterExecuteStatement(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.AfterExecuteStatement

    Public Event BeforeExecuteStatement(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.BeforeExecuteStatement

    Public Event Connected(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.Connected


    Public Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.Disposed

    Public Function GetCommand() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommand
        Return _ConnectionManager.GetCommand
    End Function

    Public Function GetCommandForStoredProcedure() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommandForStoredProcedure
        Return _ConnectionManager.GetCommandForStoredProcedure
    End Function

    Public Function GetCommandForTableDirect() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommandForTableDirect
        Return _ConnectionManager.GetCommandForTableDirect
    End Function

    Public Function GetCommandForText() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommandForText
        Return _ConnectionManager.GetCommandForText
    End Function


    Public Sub TransactionCommit() Implements IDataAccess.IConnectionManager.TransactionCommit
        _ConnectionManager.TransactionCommit()
    End Sub

    Public Function TransactionConnect() As System.Data.IDbConnection Implements IDataAccess.IConnectionManager.TransactionConnect
        Return _ConnectionManager.TransactionConnect()
    End Function

    Public Sub TransactionRollBack() Implements IDataAccess.IConnectionManager.TransactionRollBack
        _ConnectionManager.TransactionRollBack()
    End Sub

    Public Function Connect() As Boolean Implements IDataAccess.IConnectionManager.Connect
        Return _ConnectionManager.Connect
    End Function



    Public Function Disconect() As Boolean Implements IDataAccess.IConnectionManager.Disconect
        Return _ConnectionManager.Disconect
    End Function

    Public Function ExecuteNonQuery(ByVal strSql As String) As Object Implements IDataAccess.IConnectionManager.ExecuteNonQuery
        Return _ConnectionManager.ExecuteNonQuery(strSql)
    End Function

    Public Function ExecuteInsert(ByVal strSql As String) As Object
        Return _ConnectionManager.ExecuteNonQuery(strSql)
    End Function

    Public Function GetCurrentTransactionConnection() As System.Data.IDbConnection Implements IDataAccess.IConnectionManager.GetCurrentTransactionConnection
        Return _ConnectionManager.GetCurrentTransactionConnection()
    End Function

    Public Function GetDataSet(ByVal strSQL As String) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet
        Return _ConnectionManager.GetDataSet(strSQL)
    End Function

    Public Function GetDataTable(ByVal strSQL As String) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable
        Return _ConnectionManager.GetDataTable(strSQL)
    End Function



    Public Function NewArrayFromStored(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DataAccessTrunk.DBParams) Implements IDataAccess.IConnectionManager.NewArrayFromStored
        Return _ConnectionManager.NewArrayFromStored(StoredName)
    End Function

    Public Function NewArrayFromTable(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DataAccessTrunk.DBFields) Implements IDataAccess.IConnectionManager.NewArrayFromTable
        Return _ConnectionManager.NewArrayFromTable(StoredName)
    End Function



    Public Function GetOpenConnection() As IDataAccess.IConnectionManager Implements IDataAccess.IConnectionManager.GetOpenConnection
        Return _ConnectionManager.GetOpenConnection()
    End Function

    Public ReadOnly Property CurrentConnection() As System.Data.IDbConnection Implements IDataAccess.IConnectionManager.CurrentConnection
        Get
            Return _ConnectionManager.CurrentConnection
        End Get
    End Property

    Public Function GetBlankCommand() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetBlankCommand
        Return _ConnectionManager.GetBlankCommand
    End Function

    Public Function ExecuteNonQuery1(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As Object Implements IDataAccess.IConnectionManager.ExecuteNonQuery

    End Function

    Public Function GetDataSet1(ByVal oEntity As Object) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet

    End Function

    Public Function GetDataSet1(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet

    End Function

    Public Function GetDataSet1(ByVal StoredProcedureName As String, ByVal oEntity As Object, ByVal EntityType As System.Type) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet

    End Function

    Public Function GetDataTable1(ByVal oEntity As Object) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable

    End Function

    Public Function GetDataTable1(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable

    End Function

    Public Function GetDataTable1(ByVal StoredProcedureName As String, ByVal oEntity As Object, ByVal EntityType As System.Type) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable

    End Function

    Public Function GetEntity(ByVal entity As Entity.IEntity) As Object Implements IDataAccess.IConnectionManager.GetEntity

    End Function

    Public Function GetEntity(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity) As Object Implements IDataAccess.IConnectionManager.GetEntity

    End Function

    Public Function GetEntityList(ByVal entity As Entity.IEntity) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal entity As Entity.IEntity, ByVal OrJoin As Boolean) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity, ByVal OrJoin As Boolean) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity, ByVal SpecialFilter As String) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetObject(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As Object Implements IDataAccess.IConnectionManager.GetObject

    End Function

    Public Function GetObjectList(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetObjectList

    End Function

    Public Function ParamObjectArrayToDBParam(ByVal param() As DataAccessTrunk.DBParams) As System.Data.IDataParameterCollection Implements IDataAccess.IConnectionManager.ParamObjectArrayToDBParam

    End Function

    Public Function ParamObjectToDBParam(ByVal param As DataAccessTrunk.DBParams) As System.Data.IDataParameter Implements IDataAccess.IConnectionManager.ParamObjectToDBParam

    End Function

    Public Function GetEntity(ByVal entity As Entity.IEntity) As Object Implements IDataAccess.IConnectionManager.GetEntity

    End Function

    Public Function GetEntity(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity) As Object Implements IDataAccess.IConnectionManager.GetEntity

    End Function

    Public Function GetEntityList(ByVal entity As Entity.IEntity) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal entity As Entity.IEntity, ByVal OrJoin As Boolean) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity, ByVal OrJoin As Boolean) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function

    Public Function GetEntityList(ByVal StoredProcedure As String, ByVal entity As Entity.IEntity, ByVal SpecialFilter As String) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetEntityList

    End Function
End Class
