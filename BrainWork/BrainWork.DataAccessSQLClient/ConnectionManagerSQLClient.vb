Imports BrainWork.DataAccessTrunk
Public Class ConnectionManagerSQLClient
    Implements BrainWork.IDataAccess.IConnectionManager

    Private Shared _oConn As SqlClient.SqlConnection = Nothing
    Private _Trans As SqlClient.SqlTransaction = Nothing
    Private Shared _strConnectionString As String
    Private Shared IsInTransaction As Boolean = False

    Public Property strConnectionString() As String
        Get
            Return _strConnectionString
        End Get
        Set(ByVal value As String)
            _strConnectionString = value
        End Set
    End Property

    Private ReadOnly Property oConn() As SqlClient.SqlConnection
        Get
            If _oConn Is Nothing Then
                _oConn.ConnectionString = Me.strConnectionString
                _oConn.Open()
                IsInTransaction = False
            End If
            Return _oConn
        End Get
    End Property



    Public Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.Disposed

    Public Function GetBlankCommand() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetBlankCommand
        Return New SqlClient.SqlCommand
    End Function

    Public Function GetCommand() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommand
        Dim oCmd As New SqlClient.SqlCommand
        oCmd.Connection = Me.oConn
        If IsInTransaction Then
            oCmd.Transaction = _Trans
        End If

        Return oCmd
    End Function

    Public Function GetCommandForStoredProcedure() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommandForStoredProcedure
        GetCommandForStoredProcedure = Me.GetCommand
        GetCommandForStoredProcedure.CommandType = CommandType.StoredProcedure
    End Function

    Public Function GetCommandForTableDirect() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommandForTableDirect
        GetCommandForTableDirect = Me.GetCommand
        GetCommandForTableDirect.CommandType = CommandType.TableDirect
    End Function

    Public Function GetCommandForText() As System.Data.IDbCommand Implements IDataAccess.IConnectionManager.GetCommandForText
        GetCommandForText = Me.GetCommand
        GetCommandForText.CommandType = CommandType.Text
    End Function



    Public Sub TransactionCommit() Implements IDataAccess.IConnectionManager.TransactionCommit
        _Trans.Commit()
        IsInTransaction = False
    End Sub

    Public Function TransactionConnect() As System.Data.IDbConnection Implements IDataAccess.IConnectionManager.TransactionConnect
        _oConn = New SqlClient.SqlConnection(Me.strConnectionString)
        _oConn.Open()
        _Trans = _oConn.BeginTransaction()


        IsInTransaction = True
        Return _oConn
    End Function

    Public Sub TransactionRollBack() Implements IDataAccess.IConnectionManager.TransactionRollBack
        _Trans.Rollback()
        IsInTransaction = False
    End Sub

    Public Function Connect() As Boolean Implements IDataAccess.IConnectionManager.Connect
        If Not _oConn Is Nothing Then
            If _oConn.State = ConnectionState.Open Then
                _oConn.Close()
            End If
            _oConn = Nothing
        End If
    End Function



    Public Function Disconect() As Boolean Implements IDataAccess.IConnectionManager.Disconect
        If Not _oConn Is Nothing Then
            If IsInTransaction Then
                _Trans.Rollback()
            End If
            _oConn.Close()
        End If
    End Function

    Public Function ExecuteNonQuery(ByVal strSql As String) As Object Implements IDataAccess.IConnectionManager.ExecuteNonQuery
        Dim oCmd As SqlClient.SqlCommand = Me.GetCommandForText
        oCmd.CommandText = strSql
        Return oCmd.ExecuteNonQuery()
    End Function

    Public Function GetCurrentTransactionConnection() As System.Data.IDbConnection Implements IDataAccess.IConnectionManager.GetCurrentTransactionConnection
        If Not IsInTransaction Then
            Return Me.TransactionConnect()
        Else
            Return _oConn
        End If
    End Function

    Public Function GetDataSet(ByVal strSQL As String) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet
        Dim oCmd As SqlClient.SqlCommand = Me.GetCommandForText
        oCmd.CommandText = strSQL
        Dim oDa As New SqlClient.SqlDataAdapter(oCmd)
        Dim ds As New DataSet
        oDa.Fill(ds)
        Return ds
    End Function

    Public Function GetDataTable(ByVal strSQL As String) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable
        Return GetDataSet(strSQL).Tables(0)
    End Function

    Public Function GetOpenConnection() As IDataAccess.IConnectionManager Implements IDataAccess.IConnectionManager.GetOpenConnection
        Return Me.oConn
    End Function


    Public ReadOnly Property CurrentConnection() As System.Data.IDbConnection Implements IDataAccess.IConnectionManager.CurrentConnection
        Get
            Return _oConn
        End Get

    End Property


    Public Event AfterExecuteStatement(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.AfterExecuteStatement

    Public Event BeforeExecuteStatement(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.BeforeExecuteStatement

    Public Event Connected(ByVal sender As Object, ByVal e As System.EventArgs) Implements IDataAccess.IConnectionManager.Connected



    Public Function ExecuteNonQuery(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As Object Implements IDataAccess.IConnectionManager.ExecuteNonQuery
        

    End Function

    Public Function GetDataSet(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet

    End Function


    Public Function GetDataTable(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable

    End Function



    Public Function NewArrayFromStored(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DataAccessTrunk.DBParams) Implements IDataAccess.IConnectionManager.NewArrayFromStored
        Dim strSql As String = ""
        strSql = strSql & "	Declare	@StoredName AS VARCHAR(500)                                              "
        strSql = strSql & "	set @StoredName = '" & StoredName.Trim() & "'                                           "
        strSql = strSql & "	SET NOCOUNT ON;                                                                  "
        strSql = strSql & "    SELECT                                                                        "
        strSql = strSql & "		PARAMETERS.NAME Name,                                                          "
        strSql = strSql & "		PARAMETERS.IS_OUTPUT Output,                                                   "
        strSql = strSql & "		TYPES.NAME Type,                                                               "
        strSql = strSql & "		PARAMETERS.MAX_LENGTH Size                                                     "
        strSql = strSql & "	FROM                                                                             "
        strSql = strSql & "		SYS.PROCEDURES STORED INNER JOIN                                               "
        strSql = strSql & "		SYS.PARAMETERS PARAMETERS ON STORED.OBJECT_ID = PARAMETERS.OBJECT_ID INNER JOIN "
        strSql = strSql & "		SYS.TYPES TYPES ON PARAMETERS.USER_TYPE_ID = TYPES.USER_TYPE_ID                "
        strSql = strSql & "	WHERE                                                                            "
        strSql = strSql & "		STORED.NAME = @StoredName                                                      "
        strSql = strSql & "	ORDER BY                                                                         "
        strSql = strSql & "		PARAMETERS.PARAMETER_ID                                                        "

        Dim dt As New DataTable
        dt = Me.GetDataTable(strSql)
        Dim dc As New System.Collections.Generic.Dictionary(Of String, DataAccessTrunk.DBParams)

        If Not dt.Rows.Count < 1 Then
            For Each dr As Data.DataRow In dt.Rows
                Dim d As ParameterDirection = CType(IIf(dr("Output").ToString = "1", ParameterDirection.Output, ParameterDirection.Input), ParameterDirection)
                Dim t As SqlDbType = CType("SqlDbType." & dr("Type").ToString(), SqlDbType)
                Dim param As New DataAccessTrunk.DBParams(dr("name").ToString(), CType(t, DbType), d, Nothing, CLng(dr("Size")))
                dc.Add(param.ParamName, param)
            Next
        End If
        Return dc
    End Function

    Public Function NewArrayFromTable(ByVal StoredName As String) As System.Collections.Generic.Dictionary(Of String, DataAccessTrunk.DBFields) Implements IDataAccess.IConnectionManager.NewArrayFromTable

    End Function

    Public Function GetDataSet(ByVal oEntity As Object) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet

    End Function

    Public Function GetDataSet(ByVal StoredProcedureName As String, ByVal oEntity As Object, ByVal EntityType As System.Type) As System.Data.DataSet Implements IDataAccess.IConnectionManager.GetDataSet

    End Function

    Public Function GetDataTable(ByVal oEntity As Object) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable

    End Function

    Public Function GetDataTable(ByVal StoredProcedureName As String, ByVal oEntity As Object, ByVal EntityType As System.Type) As System.Data.DataTable Implements IDataAccess.IConnectionManager.GetDataTable

    End Function

    Public Function GetObject(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As Object Implements IDataAccess.IConnectionManager.GetObject

    End Function

    Public Function GetObjectList(ByVal StoredProcedureName As String, ByVal ParamArray DBParameters() As DataAccessTrunk.DBParams) As System.Collections.IList Implements IDataAccess.IConnectionManager.GetObjectList

    End Function

    Public Function ParamObjectArrayToDBParam(ByVal param() As DataAccessTrunk.DBParams) As System.Data.IDataParameterCollection Implements IDataAccess.IConnectionManager.ParamObjectArrayToDBParam
        Dim col As SqlClient.SqlParameterCollection = Nothing
        For Each DBParameter As DataAccessTrunk.DBParams In param
            col.Add(ParamObjectToDBParam(DBParameter))
        Next
        Return col
    End Function

    Public Function ParamObjectToDBParam(ByVal param As DataAccessTrunk.DBParams) As System.Data.IDataParameter Implements IDataAccess.IConnectionManager.ParamObjectToDBParam

        Dim o As New SqlClient.SqlParameter()
        o.DbType = param.FieldType
        o.Direction = param.ParamDirection
        o.ParameterName = param.ParamName
        o.Value = param.ParamValue
        Return o
    End Function
End Class
