<Serializable()> _
Public Class ConnectionManager
    'Inherits BrainWork.Connections.BrainWorkConnection

    Private Shared _singletonSession As Session
    Private WithEvents oDBConnection As BrainWork.Connections.AbstractConnection
    Private oUser As BrainWork.Security.ApplicationUser

    Public Event OnAlterValues(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
    Public Sub _OnAlterValues(ByVal p As System.Data.IDbDataParameter(), ByVal spName As String)
        RaiseEvent OnAlterValues(p, spName)
    End Sub


    Public ReadOnly Property ApplicationUser() As BrainWork.Security.ApplicationUser
        Get
            Return oUser
        End Get
    End Property

    Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        Me.oUser = oUser
        If Me.ApplicationUser Is Nothing Then
            Throw New BrainWork.TrunkLibrary.Exceptions.ExceptionNotSetedUser()
        End If

    End Sub

    ''' <summary>
    ''' Auxilar para saber si actualmente hay una coneccion activa
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property IsTransaction() As Boolean
        Get
            If GetSharedConnection Is Nothing Then
                Return False
            Else
                Return GetSharedConnection.TransactionCount > 0
            End If
        End Get

    End Property

    Private Shared ReadOnly Property UserInstance() As BrainWork.Security.ApplicationUser
        Get
            Return TryCast(_singletonSession("UserLogged"), BrainWork.Security.ApplicationUser)
        End Get
    End Property



    Private ReadOnly Property Session() As Session
        Get

            If ApplicationUser Is Nothing Then
                Throw New Exception("Connection Manager No ha detectado un usuario logueado")
            End If

            If _singletonSession Is Nothing Then
                _singletonSession = New Session(ApplicationUser.SessionID)

            ElseIf Not _singletonSession.ContainsClientIdentification(ApplicationUser.SessionID) Then
                _singletonSession = New Session(ApplicationUser.SessionID)
                _singletonSession.Add("UserLogged", ApplicationUser)
            End If

            _singletonSession.ClientID = ApplicationUser.SessionID


            Return _singletonSession
        End Get
    End Property

    Private ReadOnly Property GetSharedConnection() As BrainWork.Connections.BrainWorkConnection
        Get
            Dim oConexion As BrainWork.Connections.AbstractConnection
            oConexion = TryCast(Session("sharedConnection"), BrainWork.Connections.BrainWorkConnection)

            If oConexion Is Nothing Then
                Session("sharedConnection") = GetConnection(True)
            End If


            Return TryCast(Session("sharedConnection"), BrainWork.Connections.BrainWorkConnection)
        End Get
    End Property
    Private Sub SetSharedConnection()
        If Not Session.ContainsKey("sharedConnection") Then
            Session.Add("sharedConnection", GetConnection())
        End If

    End Sub




    Public Function CurrentConnection() As BrainWork.Connections.BrainWorkConnection
        Dim oConexion As BrainWork.Connections.AbstractConnection
        If IsTransaction Then
            oConexion = GetSharedConnection
            If oConexion Is Nothing Then
                oConexion = GetSharedConnection()
            End If
        Else
            oConexion = GetConnection()
        End If

        Return oConexion

    End Function



    Private Function GetConnection(Optional ByVal createNew As Boolean = False) As BrainWork.Connections.BrainWorkConnection

        If oDBConnection Is Nothing OrElse createNew Then
            oDBConnection = New BrainWork.Connections.SQLConnection.SQLDBrainWorkConnection(Me.ApplicationUser)
        End If
        Return oDBConnection
    End Function

    'Private Sub BeginTransaction() Handles oDBConnection.OnBeginTransaction
    '    GetSharedConnection.BeginTransaction()
    'End Sub

    'Private Sub commitTransactionEvent() Handles oDBConnection.OnBeginTransaction
    '    'GetSharedConnection.CommitTransaction()
    '    If Not Me.IsTransaction Then
    '        Session("sharedConnection") = Nothing
    '    End If
    'End Sub

    'Private Sub rollbackTransactionEvent() Handles oDBConnection.OnRollBackTransaction
    '    GetSharedConnection.RollBackTransaction()
    '    If Not Me.IsTransaction Then
    '        Session("sharedConnection") = Nothing
    '    End If

    'End Sub




    'Public Sub BeginTransaction()
    '    CurrentConnection().BeginTransaction()
    'End Sub

    ''Protected Overrides Sub CloseConnection() 'Implements Connections.Interfaces.IDBrainWorkConnection.CloseConnection
    ''    CurrentConnection.CloseConnection()
    ''End Sub

    'Public Overrides Sub CommitTransaction() 'Implements Connections.Interfaces.IDBrainWorkConnection.CommitTransaction
    '    CurrentConnection.CommitTransaction()
    'End Sub

    'Public Overrides Sub ExecuteStoredProcedureNonQuery_Internal(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) 'Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
    '    CurrentConnection.ExecuteStoredProcedureNonQuery_Internal(StoredProcedureName, Parameters)
    '    _OnAlterValues(Parameters, StoredProcedureName)
    'End Sub

    'Protected Overrides Sub ExecuteStoredProcedureNonQuery_Internal(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) 'Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
    '    CurrentConnection.ExecuteStoredProcedureNonQuery_Internal(StoredProcedureName, params)
    '    _OnAlterValues(params, StoredProcedureName)
    'End Sub

    'Public Overrides Function ExecuteStoredProcedureReturns_Internal(ByVal sStoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Object 'Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
    '    Return CurrentConnection.ExecuteStoredProcedureReturns_Internal(sStoredProcedureName, Parameters)
    '    _OnAlterValues(Parameters, sStoredProcedureName)
    'End Function

    'Public Overrides Function ExecuteStoredProcedureReturns_Internal(ByVal sStoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As Object ' Implements Connections.Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
    '    Return CurrentConnection.ExecuteStoredProcedureReturns_Internal(sStoredProcedureName, params)
    '    _OnAlterValues(params, sStoredProcedureName)
    'End Function

    'Public Overrides Function GetNewCommand() As System.Data.IDbCommand 'Implements Connections.Interfaces.IDBrainWorkConnection.GetNewCommand
    '    Return CurrentConnection.GetNewCommand()
    'End Function

    'Public Overrides Function GetNewConnection() As System.Data.IDbConnection 'Implements Connections.Interfaces.IDBrainWorkConnection.GetNewConnection
    '    Return CurrentConnection.GetNewConnection()
    'End Function

    'Public Overrides Function GetOpenConnection() As System.Data.IDbConnection 'Implements Connections.Interfaces.IDBrainWorkConnection.GetOpenConnection
    '    Return CurrentConnection.GetOpenConnection()
    'End Function

    'Public Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataSet 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
    '    Return CurrentConnection.GetStoredProcedureDataSet(StoredProcedureName, RowFrom, RowTo, Parameters)
    'End Function

    'Public Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataSet 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
    '    Return CurrentConnection.GetStoredProcedureDataSet(StoredProcedureName, Parameters)
    'End Function

    'Public Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataSet 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
    '    Return CurrentConnection.GetStoredProcedureDataSet(StoredProcedureName, params)
    'End Function

    'Public Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataSet 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
    '    Return CurrentConnection.GetStoredProcedureDataSet(StoredProcedureName, params, RowFrom, RowTo)
    'End Function

    'Public Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
    '    Return CurrentConnection.GetStoredProcedureDataTable(StoredProcedureName, RowFrom, RowTo, Parameters)
    'End Function

    'Public Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
    '    Return CurrentConnection.GetStoredProcedureDataTable(StoredProcedureName, Parameters)
    'End Function

    'Public Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataTable 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
    '    Return CurrentConnection.GetStoredProcedureDataTable(StoredProcedureName, params)
    'End Function

    'Public Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataTable 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
    '    Return CurrentConnection.GetStoredProcedureDataTable(StoredProcedureName, params, RowFrom, RowTo)
    'End Function

    'Public Overrides Function GetTable(ByVal TableName As String) As System.Data.DataTable 'Implements Connections.Interfaces.IDBrainWorkConnection.GetTable
    '    Return CurrentConnection.GetTable(TableName)
    'End Function

    'Public Overrides Function GetTable(ByVal TableName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataTable 'Implements Connections.Interfaces.IDBrainWorkConnection.GetTable
    '    Return CurrentConnection.GetTable(TableName, RowFrom, RowTo)
    'End Function

    'Public Overrides Sub OpenConnection() 'Implements Connections.Interfaces.IDBrainWorkConnection.OpenConnection
    '    CurrentConnection.OpenConnection()
    'End Sub

    'Public Overrides Sub RollBackTransaction() 'Implements Connections.Interfaces.IDBrainWorkConnection.RollBackTransaction
    '    CurrentConnection.RollBackTransaction()
    'End Sub

    'Public Overrides ReadOnly Property TransactionCount() As Integer 'Implements Connections.Interfaces.IDBrainWorkConnection.TransactionCount
    '    Get
    '        Return CurrentConnection.TransactionCount
    '    End Get
    'End Property

    ''Public Overrides Function BeginTransactionFunction() As System.Data.IDbTransaction ' Implements System.Data.IDbConnection.BeginTransaction
    ''    Return Nothing
    ''End Function

    'Public Function BeginTransaction1(ByVal il As System.Data.IsolationLevel) As System.Data.IDbTransaction 'Implements System.Data.IDbConnection.BeginTransaction
    '    Return Nothing
    'End Function

    'Public Overrides Sub ChangeDatabase(ByVal databaseName As String) 'Implements System.Data.IDbConnection.ChangeDatabase
    '    CurrentConnection.ChangeDatabase(databaseName)
    'End Sub

    'Public Overrides Sub Close() 'Implements System.Data.IDbConnection.Close
    '    CurrentConnection.Close()
    'End Sub

    'Public Overrides Property ConnectionString() As String 'Implements System.Data.IDbConnection.ConnectionString
    '    Get
    '        Return CurrentConnection.ConnectionString
    '    End Get
    '    Set(ByVal value As String)
    '        CurrentConnection.ConnectionString = value
    '    End Set
    'End Property

    'Public Overrides ReadOnly Property ConnectionTimeout() As Integer 'Implements System.Data.IDbConnection.ConnectionTimeout
    '    Get
    '        Return CurrentConnection.ConnectionTimeout
    '    End Get
    'End Property

    'Public Overrides Function CreateCommand() As System.Data.IDbCommand 'Implements System.Data.IDbConnection.CreateCommand
    '    Return CurrentConnection.CreateCommand
    'End Function

    'Public Overrides ReadOnly Property Database() As String 'Implements System.Data.IDbConnection.Database
    '    Get
    '        Return CurrentConnection.Database
    '    End Get
    'End Property

    ''Public Overrides Sub Open() Implements System.Data.IDbConnection.Open
    ''    CurrentConnection.Open()
    ''End Sub

    'Public Overrides ReadOnly Property State() As System.Data.ConnectionState 'Implements System.Data.IDbConnection.State
    '    Get
    '        Return CurrentConnection.State
    '    End Get
    'End Property


    'Public Overrides Function GetStoredProcedureInfo_Internal(ByVal SpName As String) As System.Collections.Generic.List(Of System.Data.IDbDataParameter) 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureInfo
    '    Return CurrentConnection.GetStoredProcedureInfo_Internal(SpName)
    'End Function

    'Public Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String) As System.Data.IDataReader 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
    '    Return CurrentConnection.GetStoredProcedureDataReader(StoredProcedureName)
    'End Function

    'Public Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.IDataReader 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
    '    Return CurrentConnection.GetStoredProcedureDataReader(StoredProcedureName, RowFrom, MaxRecords)
    'End Function

    'Public Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.IDataReader 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
    '    Return CurrentConnection.GetStoredProcedureDataReader(StoredProcedureName, RowFrom, MaxRecords, Parameters)
    'End Function

    'Public Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.IDataReader 'Implements Connections.Interfaces.IDBrainWorkConnection.GetStoredProcedureDataReader
    '    Return CurrentConnection.GetStoredProcedureDataReader(StoredProcedureName, params, RowFrom, MaxRecords)
    'End Function

    'Public Overrides Function GetNewParameter() As System.Data.IDbDataParameter 'Implements Connections.Interfaces.IDBrainWorkConnection.GetNewParameter
    '    Return CurrentConnection.GetNewParameter
    'End Function


    'Protected Overrides Function BeginTransactionFunction(ByVal il As System.Data.IsolationLevel) As System.Data.IDbTransaction
    '    '   Return CurrentConnection.BeginTransactionFunction(il)
    'End Function

    'Protected Overrides Function BeginTransactionReturns() As System.Data.IDbTransaction
    '    Return Nothing
    'End Function

    'Public Overrides Sub CloseConnection()
    '    CurrentConnection.CloseConnection()
    'End Sub

    '' Public Overrides Sub Open()
    '' End Sub

    'Protected Overrides Function CastParameter(ByVal p As System.Data.IDbDataParameter) As System.Data.IDbDataParameter

    'End Function

    'Public Overrides Function GetNewConnection_Internal() As System.Data.IDbConnection

    'End Function

    'Protected Overrides Sub BeginTransaction_Internal()

    'End Sub

    'Protected Overrides Sub CommitTransaction_Internal()

    'End Sub

    'Protected Overrides Sub RollBackTransaction_Internal()

    'End Sub
End Class
