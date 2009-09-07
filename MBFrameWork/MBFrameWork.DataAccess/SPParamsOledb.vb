Public Class SPParamsOledb
    Implements ISPParams


    Public Function getParams(ByVal spName As String, ByVal oConn As System.Data.IDbConnection) As System.Collections.Generic.List(Of Entities.StoredProcedureFields) Implements ISPParams.getParams

    End Function

    Public Function getTypeFromDB(ByVal sDBType As String) As Entities.Fields.ParamTypeEnum Implements ISPParams.getTypeFromDB

    End Function
End Class
