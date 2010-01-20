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

        Function GetTable(ByVal TableName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                             ByVal params As System.Data.Common.DbParameterCollection) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                             ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                            ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Int32, ByVal RowTo As Int32) As Data.DataTable

        Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal RowTo As Int32, _
                                             ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As Data.DataTable



        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                           ByVal params As System.Data.Common.DbParameterCollection, ByVal RowFrom As Int32, ByVal RowTo As Int32) As Data.DataSet

        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Int32, ByVal RowTo As Int32, _
                                           ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As Data.DataSet






        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                           ByVal params As System.Data.Common.DbParameterCollection) As Data.DataSet

        Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                           ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As Data.DataSet





        Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, _
                                           ByVal params As System.Data.Common.DbParameterCollection)

        Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, _
                                           ByVal ParamArray Parameters() As System.Data.Common.DbParameter)



        Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, _
                                               ByVal params As System.Data.Common.DbParameterCollection) As Object
        Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, _
                                               ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As Object



        Function GetNewCommand() As System.Data.IDbCommand



        Function GetOpenConnection() As System.Data.IDbConnection

        Function GetNewConnection() As System.Data.IDbConnection



       








    End Interface

End Namespace