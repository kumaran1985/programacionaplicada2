<Serializable()> _
Public MustInherit Class BrainWorkConnection
    Inherits AbstractConnection
    Private _TransactionCounter As Integer


    Public CurrentRow As Integer
    Public CurrentMaxRecord As Integer


    Protected MustOverride Function CastParameter(ByVal p As System.Data.IDbDataParameter) As System.Data.IDbDataParameter
    'Public MustOverride Function GetNewParameter() As IDbDataParameter

    Public MustOverride Sub SanitizeParameterName(ByRef p As System.Data.IDbDataParameter)


    Public Property TransactionCounter() As Int32
        Get
            Return _TransactionCounter
        End Get
        Set(ByVal value As Int32)
            _TransactionCounter = value
        End Set
    End Property

    Protected ReadOnly Property IsInTransaction() As Boolean
        Get
            Return (TransactionCounter > 0)
        End Get
    End Property

    Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser)
    End Sub


    Protected MustOverride Overrides Sub CloseConnection()

    Protected MustOverride Overrides Function CreateCommand() As System.Data.IDbCommand



    Public MustOverride Overrides ReadOnly Property Database() As String


    Protected Friend MustOverride Overrides Sub ExecuteStoredProcedureNonQuery_Internal(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection)


    Protected Friend MustOverride Overrides Sub ExecuteStoredProcedureNonQuery_Internal(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter)



    Protected Friend MustOverride Overrides Function ExecuteStoredProcedureReturns_Internal(ByVal sStoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Collections.Generic.Dictionary(Of String, Object)


    Protected Friend MustOverride Overrides Function ExecuteStoredProcedureReturns_Internal(ByVal sStoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Collections.Generic.Dictionary(Of String, Object)



    Public MustOverride Overrides Function GetNewParameter() As System.Data.IDbDataParameter


    Protected MustOverride Overrides Function GetOpenConnection() As System.Data.IDbConnection


    Public MustOverride Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String) As System.Data.IDataReader


    Public MustOverride Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.IDataReader

    Public MustOverride Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.IDataReader

    Public MustOverride Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.IDataReader

    Public MustOverride Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.IDataReader


    Public MustOverride Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataSet


    Public MustOverride Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataSet


    Public MustOverride Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.DataSet


    Public MustOverride Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataSet


    Public MustOverride Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable


    Public MustOverride Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataTable

    Public MustOverride Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.DataTable


    Public MustOverride Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable


    Protected MustOverride Overrides Function GetStoredProcedureInfo_Internal(ByVal SpName As String) As System.Collections.Generic.List(Of System.Data.IDbDataParameter)

    Public MustOverride Overrides Function GetTable(ByVal TableName As String) As System.Data.DataTable


    Public MustOverride Overrides Function GetTable(ByVal TableName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As System.Data.DataTable

    Protected MustOverride Overrides Sub OpenConnection()





    Public MustOverride Overrides ReadOnly Property State() As System.Data.ConnectionState


    Public MustOverride Overrides ReadOnly Property TransactionCount() As Integer

    Protected MustOverride Overrides Sub BeginTransaction_Internal()



    Protected MustOverride Overrides Sub CommitTransaction_Internal()


    Protected MustOverride Overrides Property ConnectionString() As String


    Protected MustOverride Overrides Function GetNewConnection_Internal() As System.Data.IDbConnection


    Protected MustOverride Overrides Sub RollBackTransaction_Internal()

    Public MustOverride Overloads Overrides Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByRef ListReturnedValues As System.Collections.Generic.Dictionary(Of String, Object), ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.IDataReader



    Public MustOverride Overloads Overrides Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByRef ListReturnedValues As System.Collections.Generic.Dictionary(Of String, Object), ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataSet


    Public MustOverride Overloads Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByRef ListReturnedValues As System.Collections.Generic.Dictionary(Of String, Object), ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable

    Public MustOverride Overloads Overrides Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal OrderByField As String, ByRef ListReturnedValues As System.Collections.Generic.Dictionary(Of String, Object), ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As System.Data.DataTable


    Public MustOverride Overloads Overrides Function GetTable(ByVal TableName As String, ByRef ListReturnedValues As System.Collections.Generic.Dictionary(Of String, Object)) As System.Data.DataTable

End Class
