Imports System.Data.OleDb
Imports System.Data
Imports MBFrameWork.GlobalReferences
Public Class DAOledb
    Private Shared _Ocon As System.Data.IDbConnection
    Private Shared _GetConnectionString As String = Nothing

    Private Shared ReadOnly Property GetConnectionString() As String
        Get
            If Not _GetConnectionString Is Nothing Then
                Return _GetConnectionString
            End If
            _GetConnectionString = Constants.ConnectionString
            Return _GetConnectionString
        End Get

    End Property

    Friend Shared Sub NewConnection()
        Try
            _Ocon.Close()
        Catch ex As Exception
            _Ocon = Nothing
        End Try

        _Ocon.ConnectionString = GetConnectionString

    End Sub
    Friend Shared ReadOnly Property GetOpenConnection() As IDbConnection
        Get
            If _Ocon.State = ConnectionState.Open Then
                Return _Ocon
            Else
                Try
                    _Ocon.Close()
                Catch ex As Exception
                    _Ocon = Nothing
                End Try

                _Ocon.ConnectionString = GetConnectionString

                Return _Ocon
            End If
        End Get
    End Property

    Friend Shared Sub CloseConnection()
        Try
            _Ocon.Close()
        Catch ex As Exception
            _Ocon = Nothing
        End Try
    End Sub

    Private Shared Function GetCommand() As System.Data.IDbCommand
        Return New OleDb.OleDbCommand()
    End Function
    Friend Shared Function GetCommandForStoredProcedure() As System.Data.IDbCommand
        GetCommandForStoredProcedure = GetCommand()
        GetCommandForStoredProcedure.CommandType = CommandType.StoredProcedure
    End Function

    Friend Shared Function GetCommandForText() As System.Data.IDbCommand
        GetCommandForText = GetCommand()
        GetCommandForText.CommandType = CommandType.Text
    End Function

    Friend Shared Function GetCommandForTableDirect() As System.Data.IDbCommand
        GetCommandForTableDirect = GetCommand()
        GetCommandForTableDirect.CommandType = CommandType.TableDirect

    End Function

    Friend Shared Function GetDataSet(ByVal strSql As String, ByVal pcType As CommandType, ByRef cn As IDbConnection) As System.Data.DataSet
        Dim oCommand As System.Data.IDbCommand = Nothing
        Dim ds As DataSet = Nothing

        Select Case pcType
            Case CommandType.StoredProcedure
                oCommand = GetCommandForStoredProcedure()
            Case CommandType.TableDirect
                oCommand = GetCommandForTableDirect()
            Case CommandType.Text
                oCommand = GetCommandForText()
        End Select
        oCommand.Connection = cn
        oCommand.CommandText = strSql
        Return GetDataSet(oCommand)

    End Function

    Friend Shared Function GetDataSet(ByVal pCommand As System.Data.IDbCommand) As System.Data.DataSet
        Dim ds As DataSet = Nothing
        Dim NotHadConnection As Boolean = False
        Try
            If pCommand.Connection Is Nothing Then
                NotHadConnection = True
                NewConnection()
                pCommand.Connection = GetOpenConnection()
            End If
            Dim oDataAdapter As System.Data.IDataAdapter = GetNewDataAdapter(pCommand)
            ds = New DataSet
            oDataAdapter.Fill(ds)

        Catch ex As Exception
            MBFrameWork.GlobalReferences.ErrorManager.NewError(ex)

        Finally
            If NotHadConnection Then
                CloseConnection()
            End If
        End Try
        Return ValidatedDataSet(ds)
    End Function

    Friend Shared Function GetDataSet(ByVal strSql As String, ByVal pcType As CommandType) As System.Data.DataSet
        Return GetDataSet(strSql, pcType, GetOpenConnection())
    End Function

    Friend Shared Function GetDataView(ByVal strSql As String, ByVal pcType As CommandType) As System.Data.DataView
        Dim ds As DataSet = Nothing
        ds = GetDataSet(strSql, pcType)
        If ds Is Nothing Then
            Return Nothing
        Else
            Return New DataView(ds.Tables(0))
        End If
    End Function

    Friend Shared Function GetDataView(ByVal pCommand As System.Data.IDbCommand) As System.Data.DataView
        Dim ds As DataSet = Nothing
        ds = GetDataSet(pCommand)
        If ds Is Nothing Then
            Return Nothing
        Else
            Return New DataView(ds.Tables(0))
        End If
    End Function


    Friend Shared Function GetNewDataAdapter(ByRef pCommand As System.Data.IDbCommand) As IDataAdapter

        Dim oCommand As OleDbCommand = CType(pCommand, OleDbCommand)
        Return New OleDb.OleDbDataAdapter(oCommand)

    End Function

    Friend Shared Function GetDataSet(ByVal strSql As String) As DataSet
        Return GetDataSet(strSql, CommandType.Text)
    End Function

    Friend Shared Function GetAllFromTable(ByVal TableName As String) As DataTable
        Dim strSql As String = "Select * From [" & TableName & "]"
        Dim ds As New Data.DataSet()
        ds = GetDataSet(strSql)

        If Not ds Is Nothing Then
            Return ds.Tables(0)
        End If
        Return Nothing
    End Function



    Friend Shared Function ValidatedDataSet(ByVal ds As Data.DataSet) As DataSet
        If ds Is Nothing OrElse ds.Tables.Count < 1 Then
            Return Nothing
        Else
            For Each t As DataTable In ds.Tables
                If t.Rows.Count > 0 Then
                    Return ds
                End If
            Next
        End If
        Return Nothing
    End Function
End Class
