
Public Interface IConnectionManager

    Event Connected As EventHandler

    Event Disposed As EventHandler

    Event BeforeExecuteStatement As EventHandler

    Event AfterExecuteStatement As EventHandler

    Property CurrentConnection() As IDbConnection

    Property ConnectionType() As EnumConnectionType
 
    Function TransactionConnect() As System.Data.IDbConnection

    Sub TransactionCommit()

    Sub TransactionRollBack()

    Function GetOpenConnection() As IDbConnection

    Function GetCommand() As IDbCommand

    Function GetCommandForStoredProcedure() As IDbCommand

    Function GetCommandForTableDirect() As IDbCommand

    Function GetCommandForText() As IDbCommand 

    Function NewArrayFromStored(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DBParams)
  
    Function NewArrayFromTable(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DBFields)












End Interface
