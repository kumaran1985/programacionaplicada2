Namespace Interfaces

    Public Interface IDBrainWorkConnection
        Inherits System.Data.IDbConnection
        Inherits IDisposable

        Overloads Sub BeginTransaction()

        Sub CloseConnection()

        Sub CommitTransaction()

        Sub OpenConnection()

        Sub RollBackTransaction()

        ReadOnly Property TransactionCount() As Integer

        Function GetTable(ByVal TableName As String) As Data.DataTable

        Function GetTable(ByVal TableName As String, ByVal RowFrom As Integer, ByVal MaxRecords As Integer) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                             ByVal params As System.Data.Common.DbParameterCollection) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                             ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                            ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32, _
                                             ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataTable



        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                           ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.DataSet

        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32, _
                                           ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataSet



        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                           ByVal params As System.Data.Common.DbParameterCollection) As Data.DataSet

        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                           ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.DataSet


        Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32, _
                                           ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Data.IDataReader
        Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.IDataReader
        Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String) As Data.IDataReader
        Function GetStoredProcedureDataReader(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection, _
                                             ByVal RowFrom As Int32, ByVal MaxRecords As Int32) As Data.IDataReader



        Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, _
                                           ByVal params As System.Data.Common.DbParameterCollection)

        Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, _
                                           ByVal ParamArray Parameters() As System.Data.IDbDataParameter)



        Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, _
                                               ByVal params As System.Data.Common.DbParameterCollection) As Object
        Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, _
                                               ByVal ParamArray Parameters() As System.Data.IDbDataParameter) As Object



        Function GetNewCommand() As System.Data.IDbCommand



        Function GetOpenConnection() As System.Data.IDbConnection

        Function GetNewConnection() As System.Data.IDbConnection

        Function GetStoredProcedureInfo(ByVal SpName As String) As List(Of System.Data.IDbDataParameter)

        Function GetNewParameter() As System.Data.IDbDataParameter






       








    End Interface

End Namespace