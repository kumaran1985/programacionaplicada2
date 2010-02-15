Imports BrainWork.Security
<Serializable()> _
Public MustInherit Class AbstractConnection
    Implements System.Data.IDbConnection

    Public _ApplicationUser As ApplicationUser
    Public Event OnConnect(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnDisconect(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnOpenConnection(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnCloseConnection(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnBeginTransaction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnCommitTransaction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnRollBackTransaction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnExecuteAction(ByVal source As Object, ByVal e As System.EventArgs)
    Public Event OnModifyValues(ByVal source As Object, ByVal e As System.EventArgs)

    Public Function ConvertParamCollectionToArray(ByVal oParam As System.Data.Common.DbParameterCollection) As System.Data.IDbCommand()

        Dim Parameters() As System.Data.IDbCommand
        ReDim Parameters(oParam.Count - 1)

        For i As Integer = 0 To oParam.Count - 1
            Dim oCmd As System.Data.IDbCommand = Me.GetNewCommand()
            oCmd = CType(oParam(i), System.Data.IDbCommand)
            Parameters(i) = oCmd
        Next
        Return Parameters


    End Function


    Private Sub DBConnection_OnConnect(ByVal source As Object, ByVal e As System.EventArgs)

        RaiseEvent OnConnect(source, e)

    End Sub
    Private Sub DBConnection_OnDisconect(ByVal source As Object, ByVal e As System.EventArgs)
        RaiseEvent OnDisconect(source, e)
    End Sub
    Private Sub DBConnection_OnOpenConnection(ByVal source As Object, ByVal e As System.EventArgs)
        RaiseEvent OnOpenConnection(source, e)
    End Sub
    Private Sub DBConnection_OnCloseConnection(ByVal source As Object, ByVal e As System.EventArgs)
        RaiseEvent OnCloseConnection(source, e)
    End Sub
    Private Sub DBConnection_OnBeginTransaction(ByVal source As Object, ByVal e As System.EventArgs)
        RaiseEvent OnBeginTransaction(source, e)
    End Sub
    Private Sub DBConnection_OnCommitTransaction(ByVal source As Object, ByVal e As System.EventArgs)
        RaiseEvent OnCommitTransaction(source, e)
    End Sub
    Private Sub DBConnection_OnExecuteAction(ByVal source As Object, ByVal e As System.EventArgs)
        RaiseEvent OnExecuteAction(source, e)
    End Sub
    Private Sub DBConnection_OnModifyValues(ByVal source As Object, ByVal e As System.EventArgs)
        RaiseEvent OnModifyValues(source, e)
    End Sub




    Public Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, _
                                       ByVal params As System.Data.Common.DbParameterCollection)
        Me.ExecuteStoredProcedureNonQuery_Internal(StoredProcedureName, params)
        Dim e As New BrainWork.Connections.ModifyQueryEventArgs(StoredProcedureName, ConvertParamCollectionToArray(params))
        DBConnection_OnModifyValues(Me, e)

    End Sub

    Public Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, _
                                       ByVal ParamArray Parameters() As System.Data.IDbDataParameter)
        Me.ExecuteStoredProcedureNonQuery_Internal(StoredProcedureName, Parameters)
        DBConnection_OnModifyValues(Me, New BrainWork.Connections.ModifyQueryEventArgs(StoredProcedureName, Parameters))
    End Sub


    Public Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, _
                                          ByVal params As System.Data.Common.DbParameterCollection) As Dictionary(Of String, Object)
        Return Me.ExecuteStoredProcedureReturns_Internal(sStoredProcedureName, params)

        DBConnection_OnModifyValues(Me, New BrainWork.Connections.ModifyQueryEventArgs(sStoredProcedureName, ConvertParamCollectionToArray(params)))
    End Function
    Public Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, _
                                          ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Dictionary(Of String, Object)
        Return Me.ExecuteStoredProcedureReturns_Internal(sStoredProcedureName, Parameters)
        DBConnection_OnModifyValues(Me, New BrainWork.Connections.ModifyQueryEventArgs(sStoredProcedureName, Parameters))
    End Function

    Public Function GetStoredProcedureInfo(ByVal SpName As String) As List(Of System.Data.IDbDataParameter)
        Return Me.GetStoredProcedureInfo_Internal(SpName)
    End Function

    Public Sub Open() Implements System.Data.IDbConnection.Open
        Me.OpenConnection()
    End Sub


    Public Sub Close() Implements System.Data.IDbConnection.Close
        Me.CloseConnection()

        DBConnection_OnModifyValues(Me, New BrainWork.Connections.GenericEventArgs("Closing Connection at: " & Date.Now.ToString & " By :" & ApplicationUser.GetUserIDentification))
    End Sub


    Public ReadOnly Property ApplicationUser() As ApplicationUser
        Get
            Return _ApplicationUser
        End Get
    End Property

    Public Sub New(ByVal oUser As ApplicationUser)
        If oUser Is Nothing Then
            Throw New NotUserLoggedException
        End If
        _ApplicationUser = oUser
        'AddHandler Me.OnModifyValues, AddressOf DBConnection_OnModifyValues
        'AddHandler Me.OnExecuteAction, AddressOf DBConnection_OnExecuteAction
        'AddHandler Me.OnCommitTransaction, AddressOf DBConnection_OnCommitTransaction
        'AddHandler Me.OnBeginTransaction, AddressOf DBConnection_OnBeginTransaction
        'AddHandler Me.OnCloseConnection, AddressOf DBConnection_OnCloseConnection
        'AddHandler Me.OnOpenConnection, AddressOf DBConnection_OnOpenConnection
        'AddHandler Me.OnDisconect, AddressOf DBConnection_OnDisconect
        'AddHandler Me.OnConnect, AddressOf DBConnection_OnConnect

    End Sub

    Public Sub BeginTransaction()
        Me.BeginTransaction_Internal()
    End Sub

    Public Sub CommitTransaction()
        Me.CommitTransaction_Internal()
    End Sub

    Public Sub RollBackTransaction()
        Me.RollBackTransaction_Internal()
    End Sub

    Protected MustOverride Sub BeginTransaction_Internal()
    Protected MustOverride Sub CommitTransaction_Internal()
    Protected MustOverride Sub RollBackTransaction_Internal()




    Protected MustOverride Sub CloseConnection()



    Protected MustOverride Sub OpenConnection()



    Public MustOverride ReadOnly Property TransactionCount() As Integer

    Public MustOverride Function GetTable(ByVal TableName As String) As Data.DataTable

    Public MustOverride Function GetTable(ByVal TableName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As Data.DataTable

    Public MustOverride Function GetTable(ByVal TableName As String, _
                                          ByRef ListReturnedValues As Dictionary(Of String, Object)) As Data.DataTable


    '------------------------------------------------------------------------------
    Public MustOverride Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                        ByVal params As System.Data.Common.DbParameterCollection) As Data.DataTable

    Public MustOverride Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                        ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataTable

    Public MustOverride Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                       ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.DataTable

    Public MustOverride Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32, _
                                        ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataTable

    Public MustOverride Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                                             ByRef ListReturnedValues As Dictionary(Of String, Object), _
                                                             ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataTable
    '-----------------------------------------------------------------------------------------------

    Public MustOverride Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                      ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.DataSet

    Public MustOverride Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32, _
                                      ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataSet

    Public MustOverride Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                      ByVal params As System.Data.Common.DbParameterCollection) As Data.DataSet

    Public MustOverride Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                                           ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataSet
    Public MustOverride Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                                           ByRef ListReturnedValues As Dictionary(Of String, Object), _
                                                           ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataSet




    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public MustOverride Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, _
                                                              ByRef ListReturnedValues As Dictionary(Of String, Object), _
                                                              ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.IDataReader

    Public MustOverride Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, _
                                      ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.IDataReader

    Public MustOverride Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32, _
                                      ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.IDataReader

    Public MustOverride Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.IDataReader

    Public MustOverride Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String) As Data.IDataReader

    Public MustOverride Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, _
                                        ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.IDataReader



    Protected Friend MustOverride Sub ExecuteStoredProcedureNonQuery_Internal(ByVal StoredProcedureName As String, _
                                       ByVal params As System.Data.Common.DbParameterCollection)

    Protected Friend MustOverride Sub ExecuteStoredProcedureNonQuery_Internal(ByVal StoredProcedureName As String, _
                                       ByVal ParamArray Parameters() As System.Data.IDbDataParameter)



    Protected Friend MustOverride Function ExecuteStoredProcedureReturns_Internal(ByVal sStoredProcedureName As String, _
                                          ByVal params As System.Data.Common.DbParameterCollection) As Dictionary(Of String, Object)
    Protected Friend MustOverride Function ExecuteStoredProcedureReturns_Internal(ByVal sStoredProcedureName As String, _
                                          ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Dictionary(Of String, Object)



    Public Function GetNewCommand() As System.Data.IDbCommand
        Return CreateCommand()
    End Function



    Protected MustOverride Function CreateCommand() As System.Data.IDbCommand Implements System.Data.IDbConnection.CreateCommand

    Protected MustOverride Function GetOpenConnection() As System.Data.IDbConnection

    Public Function GetNewConnection() As System.Data.IDbConnection

        Return Me.GetNewConnection_Internal
        Me.DBConnection_OnConnect(Me, New BrainWork.Connections.GenericEventArgs("Opened Connection at: " & Date.Now.ToString & " By :" & ApplicationUser.SessionID))

    End Function
    Protected MustOverride Function GetNewConnection_Internal() As System.Data.IDbConnection

    Protected MustOverride Function GetStoredProcedureInfo_Internal(ByVal SpName As String) As List(Of System.Data.IDbDataParameter)

    Public MustOverride Function GetNewParameter() As System.Data.IDbDataParameter

    Protected Overridable Function BeginTransactionReturns() As System.Data.IDbTransaction Implements System.Data.IDbConnection.BeginTransaction
        Return Nothing
    End Function




    Protected Overridable Function BeginTransactionFunction(ByVal il As System.Data.IsolationLevel) As System.Data.IDbTransaction Implements System.Data.IDbConnection.BeginTransaction
        Return Nothing
    End Function



    Protected Overridable Sub ChangeDatabase(ByVal databaseName As String) Implements System.Data.IDbConnection.ChangeDatabase

    End Sub





    Protected MustOverride Property ConnectionString() As String Implements System.Data.IDbConnection.ConnectionString


    Protected Overridable ReadOnly Property ConnectionTimeout() As Integer Implements System.Data.IDbConnection.ConnectionTimeout
        Get
            Return Nothing
        End Get
    End Property



    Public MustOverride ReadOnly Property Database() As String Implements System.Data.IDbConnection.Database





    Public MustOverride ReadOnly Property State() As System.Data.ConnectionState Implements System.Data.IDbConnection.State



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
