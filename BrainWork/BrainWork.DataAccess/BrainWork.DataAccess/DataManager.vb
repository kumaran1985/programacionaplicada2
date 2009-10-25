
Public Class DataManager


    Function Connect() As Boolean

    End Function

    Function Disconect() As Boolean

    End Function
    Function ExecuteNonQuery(ByVal strSql As String) As Object

    End Function

    Function ExecuteNonQuery(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As BrainWork.DataAccess.DBParams) As Object

    End Function

    Function GetDataTable(ByVal strSQL As String) As DataTable

    End Function

    Function GetDataTable(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters As BrainWork.DataAccess.DBParams()) As DataTable

    End Function

    Function GetDataSet(ByVal strSQL As String) As DataSet

    End Function

    Function GetDataSet(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters As BrainWork.DataAccess.DBParams()) As DataSet

    End Function
    Property ConnectionString() As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property


End Class
