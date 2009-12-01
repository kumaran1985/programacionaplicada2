Imports BrainWork.DataAccessTrunk
Public Interface IConnectionManager

    Event Connected As EventHandler

    Event Disposed As EventHandler

    Event BeforeExecuteStatement As EventHandler

    Event AfterExecuteStatement As EventHandler

    ReadOnly Property CurrentConnection() As IDbConnection

    'Property ConnectionType() As EnumConnectionType
 
    Function TransactionConnect() As System.Data.IDbConnection

    Function GetCurrentTransactionConnection() As System.Data.IDbConnection

    Function GetBlankCommand() As System.Data.IDbCommand

    Sub TransactionCommit()

    Sub TransactionRollBack()

    Function GetCommand() As IDbCommand

    Function GetCommandForStoredProcedure() As IDbCommand

    Function GetCommandForTableDirect() As IDbCommand

    Function GetCommandForText() As IDbCommand 

    Function NewArrayFromStored(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DBParams)
  
    Function NewArrayFromTable(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DBFields)

    Function Connect() As Boolean



    Function Disconect() As Boolean



    Function GetOpenConnection() As IConnectionManager


    Function ExecuteNonQuery(ByVal strSql As String) As Object



    Function ExecuteNonQuery(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters As BrainWork.DataAccessTrunk.DBParams()) As Object



    Function GetDataTable(ByVal strSQL As String) As DataTable



    Function GetDataTable(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters As BrainWork.DataAccessTrunk.DBParams()) As DataTable



    Function GetDataSet(ByVal strSQL As String) As DataSet



    Function GetDataSet(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters As BrainWork.DataAccessTrunk.DBParams()) As DataSet

    Function GetDataSet(ByVal StoredProcedureName As String, ByVal oEntity As Object, ByVal EntityType As Type) As Data.DataSet

    Function GetDataTable(ByVal StoredProcedureName As String, ByVal oEntity As Object, ByVal EntityType As Type) As Data.DataTable

    Function GetDataSet(ByVal oEntity As Object) As Data.DataSet


    Function GetDataTable(ByVal oEntity As Object) As Data.DataTable

    Function GetObject(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters As BrainWork.DataAccessTrunk.DBParams()) As Object

    Function GetObjectList(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters As BrainWork.DataAccessTrunk.DBParams()) As Collections.IList

    Function ParamObjectToDBParam(ByVal param As DataAccessTrunk.DBParams) As IDataParameter

    Function ParamObjectArrayToDBParam(ByVal param As DataAccessTrunk.DBParams()) As IDataParameterCollection


















End Interface
