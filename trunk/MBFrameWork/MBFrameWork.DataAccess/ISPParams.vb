Public Interface ISPParams
    Function getParams(ByVal spName As String, ByVal oConn As IDbConnection) As List(Of Entities.StoredProcedureFields)
    Function getTypeFromDB(ByVal sDBType As String) As Entities.Fields.ParamTypeEnum


End Interface
