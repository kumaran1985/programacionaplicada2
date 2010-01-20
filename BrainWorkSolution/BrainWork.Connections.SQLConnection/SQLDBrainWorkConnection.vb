
Public NotInheritable Class SQLDBrainWorkConnection
    Inherits BrainWorkConnection
    Implements BrainWork.Connections.Interfaces.IDBrainWorkConnection

    Private oConnection As SqlClient.SqlConnection
    Private oTransaction As SqlClient.SqlTransaction
    Private _ConnectionString As String
    Private Enum enumTransaction
        Start
        Begin
        Commit
        Rollback
    End Enum

    Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser)
    End Sub

    Protected Overrides Function CastParameter(ByVal p As System.Data.Common.DbParameter) As System.Data.Common.DbParameter
        Dim GetNewParameter As System.Data.SqlClient.SqlParameter

        Select Case p.DbType

            Case DbType.String
                Dim Longitud As Integer
                'Tipo de dato VARCHAR2 de ORACLE
                If p.Value Is Nothing Then
                    Longitud = 4000
                Else
                    Longitud = p.Value.ToString.Length
                End If

                If Longitud > 32000 Then
                    Longitud = 32000
                ElseIf Longitud = 0 Then
                    Longitud = 4000

                End If

                GetNewParameter = New System.Data.SqlClient.SqlParameter(p.ParameterName, SqlDbType.VarChar, Longitud)
                GetNewParameter.Direction = p.Direction
                GetNewParameter.Value = p.Value

            Case DbType.Int32
                'Tipo de Dato INTEGER de ORACLE
                GetNewParameter = New System.Data.SqlClient.SqlParameter(p.ParameterName, SqlDbType.Int, 22, _
                                                                               p.Direction, False, 38, 0, "", System.Data.DataRowVersion.Current, _
                                                                               p.Value)
            Case DbType.Boolean
                'Tipo de Dato NUMBER de ORACLE
                Dim intNumero As Int16
                If CType(p.Value, Boolean) Then
                    intNumero = 1
                Else
                    intNumero = 0
                End If
                GetNewParameter = New System.Data.SqlClient.SqlParameter(p.ParameterName, SqlDbType.Bit, _
                                                                                1, p.Direction, False, 0, 0, "", _
                                                                               System.Data.DataRowVersion.Current, intNumero)
            Case DbType.Double
                'Tipo de Dato FLOAT de ORACLE
                GetNewParameter = New System.Data.SqlClient.SqlParameter(p.ParameterName, SqlDbType.Float, _
                                                                               22, p.Direction, False, 15, 0, "", _
                                                                               System.Data.DataRowVersion.Current, p.Value)
            Case DbType.Date
                'Tipo de Dato DATE de ORACLE
                GetNewParameter = New System.Data.SqlClient.SqlParameter(p.ParameterName, SqlDbType.DateTime, _
                                                                               7, p.Direction, False, 0, 0, "", _
                                                                               System.Data.DataRowVersion.Current, p.Value)
            Case DbType.DateTime
                'Tipo de Dato DATE de ORACLE
                GetNewParameter = New System.Data.SqlClient.SqlParameter(p.ParameterName, SqlDbType.DateTime, _
                                                                               7, p.Direction, False, 0, 0, "", _
                                                                               System.Data.DataRowVersion.Current, p.Value)
            Case Else
                GetNewParameter = New System.Data.SqlClient.SqlParameter
                GetNewParameter.Direction = p.Direction
                GetNewParameter.DbType = p.DbType
                GetNewParameter.ParameterName = p.ParameterName
        End Select





        Return GetNewParameter
    End Function

    Private Sub CastParameterArray(ByVal p() As System.Data.Common.DbParameter, _
                                        ByRef sp As SqlClient.SqlParameterCollection)

        If p Is Nothing Then Exit Sub
        For Each dbp As System.Data.Common.DbParameter In p
            sp.Add(CastParameter(dbp))
        Next

    End Sub


    Private Sub CastParameterCollection(ByVal p As System.Data.Common.DbParameterCollection, _
                                        ByRef sp As SqlClient.SqlParameterCollection)

        If p Is Nothing Then Exit Sub
        For Each dbp As System.Data.Common.DbParameter In p
            sp.Add(CastParameter(dbp))
        Next

    End Sub



    Public Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) Implements Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
        Me.OpenConnection()
        Dim oCommand As SqlClient.SqlCommand

        oCommand = CType(GetNewCommand(), SqlClient.SqlCommand)
        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandText = StoredProcedureName
        Me.CastParameterArray(Parameters, oCommand.Parameters)
        oCommand.Connection = GetOpenConnection()

        Try
            MyBase.DBConnection_OnModifyValues(StoredProcedureName, New EventArgs())
            oCommand.ExecuteNonQuery()
        Catch oException As Exception

            Throw oException
        Finally
            Me.CloseConnection()
        End Try
    End Sub

    Public Sub ExecuteStoredProcedureNonQuery(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) Implements Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureNonQuery
        Me.OpenConnection()
        Dim oCommand As SqlClient.SqlCommand

        oCommand = CType(GetNewCommand(), SqlClient.SqlCommand)
        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandText = StoredProcedureName
        CastParameterCollection(params, oCommand.Parameters)
        oCommand.Connection = GetOpenConnection()

        Try
            oCommand.ExecuteNonQuery()
        Catch oException As Exception

            Throw oException
        Finally
            Me.CloseConnection()
        End Try
    End Sub

    Public Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As Object Implements Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
        Me.OpenConnection()
        Dim oCommand As SqlClient.SqlCommand

        oCommand = CType(GetNewCommand(), SqlClient.SqlCommand)
        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandText = sStoredProcedureName
        Me.CastParameterArray(Parameters, oCommand.Parameters)
        oCommand.Connection = GetOpenConnection()

        Try
            oCommand.ExecuteNonQuery()
        Catch oException As Exception

            Throw oException
        Finally
            Me.CloseConnection()
        End Try

        Dim objectToReturn As String = ""
        For Each p As SqlClient.SqlParameter In oCommand.Parameters
            If p.Direction = ParameterDirection.Output OrElse p.Direction = ParameterDirection.InputOutput Then
                objectToReturn = p.ParameterName & "=" & p.Value & ";"
            End If
        Next
        If objectToReturn = "" Then
            Return Nothing
        Else
            Return objectToReturn.Split(";"c)
        End If

    End Function

    Public Function ExecuteStoredProcedureReturns(ByVal sStoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As Object Implements Interfaces.IDBrainWorkConnection.ExecuteStoredProcedureReturns
        Me.OpenConnection()
        Dim oCommand As SqlClient.SqlCommand
        oCommand = CType(GetNewCommand(), SqlClient.SqlCommand)
        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandText = sStoredProcedureName
        Me.CastParameterCollection(params, oCommand.Parameters)
        oCommand.Connection = GetOpenConnection()

        Try
            oCommand.ExecuteNonQuery()
            Dim objectToReturn As String = ""
            For Each p As SqlClient.SqlParameter In oCommand.Parameters
                If p.Direction = ParameterDirection.Output OrElse p.Direction = ParameterDirection.InputOutput Then
                    objectToReturn = p.ParameterName & "=" & p.Value & ";"
                End If
            Next
            If objectToReturn = "" Then
                Return Nothing
            Else
                Return objectToReturn.Split(";"c)
            End If
        Catch oException As Exception

            Throw oException
        Finally
            Me.CloseConnection()
        End Try

       
    End Function

    Public Function GetNewCommand() As System.Data.IDbCommand Implements Interfaces.IDBrainWorkConnection.GetNewCommand
        Return New SqlClient.SqlCommand()
    End Function

    Public Function GetNewConnection() As System.Data.IDbConnection Implements Interfaces.IDBrainWorkConnection.GetNewConnection
        oConnection = New SqlClient.SqlConnection(Me.ConnectionString)
        Return oConnection
    End Function

    Public Function GetOpenConnection() As System.Data.IDbConnection Implements Interfaces.IDBrainWorkConnection.GetOpenConnection
        If oConnection Is Nothing Then
            GetOpenConnection = GetNewConnection()
        Else
            GetOpenConnection = oConnection
        End If
    End Function

    Private Sub DAFillDataSet(ByRef ds As DataSet, _
                              ByVal cmd As SqlClient.SqlCommand, _
                              Optional ByVal RowFrom As Int32 = 0, _
                              Optional ByVal RowTo As Int32 = 0)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        If RowFrom = 0 AndAlso RowFrom = RowTo Then
            da.Fill(ds)
        Else
            da.Fill(ds, RowFrom, RowTo, "DataFiltered")
        End If
    End Sub

    Private Function GetDataSet(ByVal ocmd As SqlClient.SqlCommand, _
                                Optional ByVal RowFrom As Int32 = 0, _
                              Optional ByVal RowTo As Int32 = 0) As DataSet

        Dim ds As New DataSet
        DAFillDataSet(ds, ocmd, RowFrom, RowTo)

        Return ds

    End Function

    Public Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataSet Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return GetStoredProcedureDataSet(StoredProcedureName, 0, 0, Parameters)
    End Function

    Public Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataSet Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Return GetStoredProcedureDataSet(StoredProcedureName, params, 0, 0)
    End Function

    Public Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer, ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataSet Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Me.OpenConnection()
        Try
            Dim oCommand As SqlClient.SqlCommand

            oCommand = CType(GetNewCommand(), SqlClient.SqlCommand)
            oCommand.CommandType = CommandType.StoredProcedure
            oCommand.CommandText = StoredProcedureName
            oCommand.Connection = Me.GetOpenConnection
            Me.CastParameterArray(Parameters, oCommand.Parameters)

            Return GetDataSet(oCommand, RowFrom, RowTo)
        Catch ex As Exception

            Throw ex
        Finally
            Me.CloseConnection()
        End Try
    End Function

    Public Function GetStoredProcedureDataSet(ByVal StoredProcedureName As String, _
                                              ByVal params As System.Data.Common.DbParameterCollection, _
                                              ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataSet Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataSet
        Me.OpenConnection()
        Try
            Dim oCommand As SqlClient.SqlCommand

            oCommand = CType(GetNewCommand(), SqlClient.SqlCommand)
            oCommand.CommandType = CommandType.StoredProcedure
            oCommand.CommandText = StoredProcedureName
            Me.CastParameterCollection(params, oCommand.Parameters)

            Return GetDataSet(oCommand, RowFrom, RowTo)
        Catch ex As Exception

            Throw ex
        Finally
            Me.CloseConnection()
        End Try
    End Function


    Public Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                                ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataTable Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Return GetStoredProcedureDataTable(StoredProcedureName, 0, 0, Parameters)
    End Function

    Public Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                                ByVal params As System.Data.Common.DbParameterCollection) As System.Data.DataTable Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Return GetStoredProcedureDataTable(StoredProcedureName, params, 0, 0)
    End Function

    Public Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                                ByVal RowFrom As Integer, _
                                                ByVal RowTo As Integer, _
                                                ByVal ParamArray Parameters() As System.Data.Common.DbParameter) As System.Data.DataTable Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Dim ds As DataSet = GetStoredProcedureDataSet(StoredProcedureName, RowFrom, RowTo, Parameters)
        If Not ds Is Nothing AndAlso ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        Else
            Return Nothing
        End If

    End Function

    Public Function GetStoredProcedureDataTable(ByVal StoredProcedureName As String, _
                                                ByVal params As System.Data.Common.DbParameterCollection, _
                                                ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataTable Implements Interfaces.IDBrainWorkConnection.GetStoredProcedureDataTable
        Dim ds As DataSet = GetStoredProcedureDataSet(StoredProcedureName, params, RowFrom, RowTo)
        If Not ds Is Nothing AndAlso ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        Else
            Return Nothing
        End If

    End Function



    Private Function CreateStoredProcedure(ByVal SP_Name As String, _
                                           ByVal params() As SqlClient.SqlParameter, _
                                           ByVal strSql As String, _
                                           ByVal ReplaceIfExists As Boolean)

        Dim ds As DataSet = ExecuteStringDataSet("SELECT Name FROM sys.procedures Where Name Like '" & SP_Name.Trim & "'")

        If Not ds Is Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then 'existe
            If Not ReplaceIfExists Then
                Return False
            Else
                ExecuteStringNonQuery("drop procedure spTests")
            End If
        End If

        Dim strSqlExec As New System.Text.StringBuilder

        strSqlExec.AppendLine("CREATE PROCEDURE " & SP_Name & "")

        For Each p As SqlClient.SqlParameter In params
            If p.Direction = ParameterDirection.Output Then
                strSqlExec.AppendLine("@" & p.ParameterName & " " & p.SqlDbType.ToString & " " & p.Direction.ToString & " (" & p.Size & ")".Replace("()", "").Replace("(0)", ""))
            Else
                strSqlExec.AppendLine("@" & p.ParameterName & " " & p.SqlDbType.ToString & " (" & p.Size & ")".Replace("()", "").Replace("(0)", ""))
            End If

        Next
        strSqlExec.AppendLine("AS")
        strSqlExec.AppendLine("BEGIN")
        strSqlExec.AppendLine(strSql)
        strSqlExec.AppendLine("END")
        ExecuteStringNonQuery(strSqlExec.ToString())

        Return True
    End Function



    Private Function ExecuteStringDataSet(ByVal strSql As String) As DataSet
        Me.OpenConnection()
        Dim ds As DataSet
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = GetOpenConnection()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql

            ds = Me.GetDataSet(cmd)

        Catch ex As Exception
            Throw ex
        Finally
            Me.CloseConnection()
        End Try
        Return ds
    End Function

    Private Function ExecuteStringNonQuery(ByVal strSql As String) As Boolean
        Me.OpenConnection()

        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = GetOpenConnection()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            Me.CloseConnection()
        End Try
        Return True
    End Function

    Public Function GetTable(ByVal TableName As String) As System.Data.DataTable Implements Interfaces.IDBrainWorkConnection.GetTable

        Dim pc(0) As SqlClient.SqlParameter
        pc(0) = New SqlClient.SqlParameter("TABLE_NAME", SqlDbType.VarChar, 500, ParameterDirection.Input)

        CreateStoredProcedure("aux_GetTable", pc, "Declare @SQL VarChar(max) " & vbCrLf & " set @SQL = 'Select * From ' + @TABLE_NAME " & vbCrLf & "execute(@SQL)", False)

        Dim p As New SqlClient.SqlParameter
        p.ParameterName = "TABLE_NAME"
        p.Value = TableName


        Return GetStoredProcedureDataTable("aux_GetTable", p)


    End Function

    Public Function GetTable(ByVal TableName As String, ByVal RowFrom As Integer, ByVal RowTo As Integer) As System.Data.DataTable Implements Interfaces.IDBrainWorkConnection.GetTable
        Dim p As New SqlClient.SqlParameter
        p.ParameterName = "TABLE_NAME"
        p.Value = TableName
        Return GetStoredProcedureDataTable("aux_GetTable", p)
    End Function



    Public Sub OpenConnection() Implements Interfaces.IDBrainWorkConnection.OpenConnection
        Try
            If IsInTransaction Then
                Me.BeginTransaction()
            End If

            Select Case True

                'Conexión Abierta
                Case (Not Me.oConnection Is Nothing AndAlso Me.oConnection.State = ConnectionState.Open)
                    Return

                    'Conexión vacía
                Case (Me.oConnection Is Nothing)
                    Me.oConnection = New SqlClient.SqlConnection(Me.ConnectionString)
                    Me.oConnection.Open()

                    'Conexión ocupada
                Case ((Me.oConnection.State = ConnectionState.Fetching) OrElse (Me.oConnection.State = ConnectionState.Executing))
                    Dim i As Int32 = 0

                    While i < 3
                        i += 1
                        System.Threading.Thread.Sleep(800)
                    End While

                    If (Me.oConnection.State = ConnectionState.Fetching) OrElse (Me.oConnection.State = ConnectionState.Executing) Then
                        Me.oConnection.Dispose()
                        Me.oConnection = New SqlClient.SqlConnection(Me.ConnectionString)
                        Me.oConnection.Open()
                    End If

                    'conexión cerrada
                Case Me.oConnection.State = ConnectionState.Closed
                    Me.oConnection.Open()

                Case Else 'otros
                    Try
                        Me.oConnection.Close()
                        Me.oConnection = Nothing
                        Me.oConnection = New SqlClient.SqlConnection(Me.ConnectionString)
                        Me.oConnection.Open()
                    Catch ex As Exception
                        Me.oConnection = Nothing
                        Me.oConnection = New SqlClient.SqlConnection(Me.ConnectionString)
                        Me.oConnection.Open()
                    End Try
            End Select
 

        Catch oException As Exception

            Throw oException
        End Try
    End Sub

    Public Sub RollBackTransaction() Implements Interfaces.IDBrainWorkConnection.RollBackTransaction
        TransactionManager(enumTransaction.Rollback)
    End Sub
    Public Overloads Sub BeginTransaction() Implements Interfaces.IDBrainWorkConnection.BeginTransaction
        If Me.TransactionCounter = 0 Then 'es la primera transacción
            TransactionManager(enumTransaction.Start)
        Else
            TransactionManager(enumTransaction.Begin)
        End If
    End Sub

    Public Sub CloseConnection() Implements Interfaces.IDBrainWorkConnection.CloseConnection
        If IsInTransaction Then
            Me.CommitTransaction()
        Else
            Me.Close()
        End If
    End Sub

    Public Sub CommitTransaction() Implements Interfaces.IDBrainWorkConnection.CommitTransaction
        TransactionManager(enumTransaction.Commit)
    End Sub
   

    Private Sub TransactionManager(ByVal TransactionAction As enumTransaction)


        Select Case TransactionAction

            Case enumTransaction.Commit

                Me.TransactionCounter += -1

                If Not IsInTransaction Then
                    oTransaction.Commit()
                    oConnection.Close()
                    oTransaction = Nothing
                End If

            Case enumTransaction.Rollback

                Me.TransactionCounter = 0
                Me.oTransaction.Rollback()
                Me.oConnection.Close()
                Me.oTransaction = Nothing

            Case enumTransaction.Start
                Me.oTransaction = CType(Me.GetOpenConnection.BeginTransaction(), SqlClient.SqlTransaction)
                Me.TransactionCounter = 1

            Case enumTransaction.Begin
                Me.TransactionCounter += 1
        End Select

    End Sub
     
    Public ReadOnly Property TransactionCount() As Integer Implements Interfaces.IDBrainWorkConnection.TransactionCount
        Get
            Return Me.TransactionCounter
        End Get
    End Property


    <Obsolete("Este método no debe ser utilzado")> _
    Private Function BeginTransactionFUnction() As System.Data.IDbTransaction Implements System.Data.IDbConnection.BeginTransaction
        Return Nothing
    End Function

    <Obsolete("Este método no debe ser utilzado")> _
    Private Function BeginTransactionIsolation(ByVal il As System.Data.IsolationLevel) As System.Data.IDbTransaction Implements System.Data.IDbConnection.BeginTransaction
        Return Nothing
    End Function

    Public Sub ChangeDatabase(ByVal databaseName As String) Implements System.Data.IDbConnection.ChangeDatabase
        Me.oConnection.ChangeDatabase(databaseName)
    End Sub

    Public Sub Close() Implements System.Data.IDbConnection.Close
        If IsInTransaction Then
            Return
        End If

        If Not Me.oConnection Is Nothing AndAlso Me.oConnection.State <> ConnectionState.Closed Then
            Me.oConnection.Close()
        End If
    End Sub

    Public Property ConnectionString() As String Implements System.Data.IDbConnection.ConnectionString
        Get

            Return BrainWork.Connections.Configuration.GetConnectionString(Me.ApplicationUser)
        End Get
        Set(ByVal value As String)
            _ConnectionString = value
        End Set
    End Property

    Public ReadOnly Property ConnectionTimeout() As Integer Implements System.Data.IDbConnection.ConnectionTimeout
        Get
            Return Me.oConnection.ConnectionTimeout
        End Get
    End Property

    Public Function CreateCommand() As System.Data.IDbCommand Implements System.Data.IDbConnection.CreateCommand
        Return oConnection.CreateCommand
    End Function

    Public ReadOnly Property Database() As String Implements System.Data.IDbConnection.Database
        Get
            Return oConnection.Database
        End Get
    End Property

    Public Sub Open() Implements System.Data.IDbConnection.Open
        Me.oConnection.Open()
    End Sub

    Public ReadOnly Property State() As System.Data.ConnectionState Implements System.Data.IDbConnection.State
        Get
            Return oConnection.State
        End Get
    End Property

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: free other state (managed objects).
            End If

            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region



End Class
