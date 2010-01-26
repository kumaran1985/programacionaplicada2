Imports System.Reflection
Imports System.Linq.Expressions


Public MustInherit Class AbstractDataAccess
    Implements BrainWork.Connections.Interfaces.IDBrainWorkConnection
    Private _ConnectionManager As BrainWork.DataManager.ConnectionManager
    Private _userlogged As BrainWork.Security.ApplicationUser

    Public ReadOnly Property ApplicationUser() As BrainWork.Security.ApplicationUser
        Get
            Return _userlogged
        End Get
    End Property

    Public Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        Me._userlogged = oUser
    End Sub


    Protected Sub AddEntity(ByVal oEntity As Object)

    End Sub


    Public Function GetEntityFieldExtendsAttributes() As BrainWork.Entities.EntityFieldExtendsAttribute
        Return Nothing
    End Function

    

    Public MustOverride Function Add(ByVal oEntity As Object) As Boolean
    Public MustOverride Function Update(ByVal oEntity As Object) As Boolean
    Public MustOverride Function Disable(ByVal oEntity As Object) As Boolean
    Public MustOverride Function Delete(ByVal oEntity As Object) As Boolean





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

    Protected Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
        CnnManager().getConnectionUser().ExecuteStoredProcedureNonQuery(StoredProcedureName, Parameters)
    End Sub

    Protected Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
        CnnManager().getConnectionUser().ExecuteStoredProcedureNonQuery(StoredProcedureName, params)
    End Sub

    Protected Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As Object Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
        Return CnnManager().getConnectionUser().ExecuteStoredProcedureReturns(sStoredProcedureName, Parameters)
    End Function

    Protected Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As Object Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
        Return CnnManager().getConnectionUser().ExecuteStoredProcedureReturns(sStoredProcedureName, params)
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

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(StoredProcedureName, RowFrom, RowTo, Parameters)
    End Function

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(StoredProcedureName, Parameters)
    End Function

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(State, params)
    End Function

    Protected Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataSet Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return CnnManager().getConnectionUser().GetStoredProcedureDataSet(StoredProcedureName, params, RowFrom, RowTo)
    End Function

    Protected Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Return CnnManager().getConnectionUser().GetStoredProcedureDataTable(StoredProcedureName, RowFrom, RowTo, Parameters)
    End Function

    Protected Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataTable Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
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

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
