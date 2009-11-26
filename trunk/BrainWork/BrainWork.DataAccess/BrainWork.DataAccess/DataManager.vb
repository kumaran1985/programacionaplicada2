Imports BrainWork.IDataAccess
Public Class DataManager

    Private Shared _ConnectionManager As IConnectionManager = Nothing
    Private Shared _GetConnectionType As EnumConnectionType = Nothing
    Private Shared _ConnectionString As String = Nothing
    Sub New(ByVal cnnManager As IConnectionManager)
        _ConnectionManager = cnnManager
    End Sub

    Sub New()

    End Sub
    Public Function Connect() As Boolean

    End Function

    Public Function Disconect() As Boolean

    End Function

    Public Function GetOpenConnection() As IConnectionManager

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

    Protected Overrides Sub Finalize()

    End Sub
    Public ReadOnly Property ConnectionString() As String
        Get
            If _ConnectionString Is Nothing Then
                _ConnectionString = Utils.Config.GetConfigValue("connectionString")
            End If
            Return _ConnectionString
        End Get
    End Property

    Public ReadOnly Property ConnectionManager() As IConnectionManager
        Get
            If _ConnectionManager Is Nothing Then

            End If
            Return _ConnectionManager
        End Get
        
    End Property

    Public ReadOnly Property GetConnectionType() As EnumConnectionType
        Get
            If _GetConnectionType = Nothing Then
                'Hardcode
                _GetConnectionType = EnumConnectionType.SQLClient
            End If
            Return _GetConnectionType
        End Get

    End Property


End Class
