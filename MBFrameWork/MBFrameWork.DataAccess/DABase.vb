Imports MBFrameWork.GlobalReferences
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class DABase


    Private _InterfaceConnection As IDbConnection = Nothing
    Private _OpenOledbConnection As OleDbConnection = Nothing
    Private _OpenSqlConnection As SqlConnection = Nothing
    Private _OpenODBCConnection As OdbcConnection = Nothing
    Private _ConnectionType As Constants.ConnectionTypeEnum = Nothing
    Private _IsSetConnection As Boolean = False
    Private _ActiveCommand As IDbCommand = Nothing
    Private _SPParams As ISPParams = Nothing

    Private Property IsSetConnection() As Boolean
        Get
            Return Not _InterfaceConnection Is Nothing
        End Get
        Set(ByVal value As Boolean)
            _IsSetConnection = value
        End Set
    End Property

    Public Sub NewConnection()
        If IsSetConnection Then
            Try
                _InterfaceConnection.Close()
            Catch ex As Exception

            End Try
        End If
        _InterfaceConnection = Nothing
        _InterfaceConnection = GetConnection
        _InterfaceConnection.ConnectionString = GetConnectionString()
        _InterfaceConnection.Open()
    End Sub


    Public Sub CloseConnection()
        If IsSetConnection Then
            Try
                If _InterfaceConnection.State <> ConnectionState.Closed Then
                    _InterfaceConnection.Close()
                End If

            Catch ex As Exception
                MBFrameWork.GlobalReferences.ErrorManager.NewError(ex.Message)
            End Try
        End If
       
    End Sub



    Public ReadOnly Property GetOpenConnection() As IDbConnection
        Get

            If Not Me.IsSetConnection Then
                NewConnection()
            End If
            Dim oCon As IDbConnection = _InterfaceConnection

            Select Case oCon.State

                Case ConnectionState.Closed
                    oCon.ConnectionString = Me.GetConnectionString
                    oCon.Open()
                Case ConnectionState.Open
                    Return oCon
                Case ConnectionState.Connecting
                    Return oCon
                Case ConnectionState.Executing
                    Return oCon
                Case ConnectionState.Fetching
                    Return oCon
                Case ConnectionState.Broken
                    oCon.Dispose()
                    oCon.ConnectionString = Me.GetConnectionString
                    oCon.Open()
                    Return oCon
            End Select

            Return Nothing

        End Get

    End Property


    Public ReadOnly Property GetOpenConnection(ByVal pSPParams As ISPParams) As IDbConnection
        Get
            If Not Me.IsSetConnection Then
                NewConnection()
            End If
            Return Me._InterfaceConnection
        End Get

    End Property

    Public ReadOnly Property GetConnection() As IDbConnection
        Get

            If IsSetConnection = False Then
                Dim conType As Constants.ConnectionTypeEnum
                Dim oCon As IDbConnection
                oCon = Nothing

                conType = Constants.ConnectionType
                Me.ConnectionType = conType

                Select Case conType
                    Case Constants.ConnectionTypeEnum.Odbc
                        If _OpenODBCConnection Is Nothing Then _OpenODBCConnection = New OdbcConnection
                        oCon = _OpenODBCConnection
                    Case Constants.ConnectionTypeEnum.OleDb
                        If _OpenOledbConnection Is Nothing Then _OpenOledbConnection = New OleDbConnection
                        oCon = _OpenOledbConnection

                    Case Constants.ConnectionTypeEnum.Sql, Constants.ConnectionTypeEnum.SqlClient
                        If _OpenSqlConnection Is Nothing Then _OpenSqlConnection = New SqlConnection
                        oCon = _OpenSqlConnection
                    Case Else
                        ErrorManager.NewError("No se puede obtener la conexi�n activa")

                End Select
                'Cambio el estado para saber que la conexion est� sereADA
                IsSetConnection = True
                _InterfaceConnection = oCon
                Return oCon
            Else
                Return _InterfaceConnection
            End If

        End Get

    End Property


    Public Property ConnectionType() As Constants.ConnectionTypeEnum
        Get
            Return _ConnectionType
        End Get
        Set(ByVal value As Constants.ConnectionTypeEnum)
            _ConnectionType = value
        End Set
    End Property

    Private Function GetOpenCommand() As System.Data.IDbCommand
        GetOpenCommand = GetCommand()
        GetOpenCommand.Connection = Me._InterfaceConnection
    End Function

    Private Function GetCommand() As System.Data.IDbCommand
        GetCommand = Nothing
        Select Case ConnectionType
            Case Constants.ConnectionTypeEnum.Odbc
                GetCommand = New Odbc.OdbcCommand()

            Case Constants.ConnectionTypeEnum.OleDb
                GetCommand = New OleDb.OleDbCommand()

            Case Constants.ConnectionTypeEnum.Sql
                GetCommand = New System.Data.SqlClient.SqlCommand()

            Case Constants.ConnectionTypeEnum.SqlClient
                GetCommand = New System.Data.SqlClient.SqlCommand()

            Case Else
                ErrorManager.NewError("No se puede obtener el comando")

        End Select

    End Function



    Friend Function GetCommandForStoredProcedure() As System.Data.IDbCommand
        GetCommandForStoredProcedure = GetCommand()
        GetCommandForStoredProcedure.CommandType = CommandType.StoredProcedure
    End Function

    Friend Function GetCommandForText() As System.Data.IDbCommand
        GetCommandForText = GetCommand()
        GetCommandForText.CommandType = CommandType.Text
    End Function

    Friend Function GetCommandForTableDirect() As System.Data.IDbCommand
        GetCommandForTableDirect = GetCommand()
        GetCommandForTableDirect.CommandType = CommandType.TableDirect

    End Function



    Friend Function GetConnectionString() As String
        Try
            Return Constants.ConnectionString
        Catch ex As Exception
            ErrorManager.NewError(ex)
        End Try

        Return Nothing
    End Function

    Friend Function GetParamsFromSP(ByVal spName As String) As List(Of Entities.StoredProcedureFields)

        If SPParams Is Nothing Then
            Throw New Exception("No se encuentra la clase issppparams")
        End If

        Return SPParams.getParams(spName, Me.GetOpenConnection)


    End Function

    Friend Function ExecuteNonQuery(ByVal strSql As String) As Boolean
        ExecuteNonQuery = False
        Try
            Me.NewConnection()
            Dim cn As IDbConnection = Me.GetOpenConnection()
            Dim cmd As IDbCommand = Me.GetCommandForText()
            cmd.CommandText = strSql
            cmd.ExecuteNonQuery()
            ExecuteNonQuery = True
        Catch ex As Exception
            MBFrameWork.GlobalReferences.ErrorManager.NewError(ex)
        Finally
            Me.CloseConnection()
        End Try
    End Function

    ''' <summary>
    '''   ejecuta la lista de sentencias, retorna la conexi�n actual 
    ''' requiere que se implemente el Bgin trans y el commit
    ''' </summary>
    ''' <param name="strSql">cadena de conexion</param>
    ''' <param name="oCon">conexion activa</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function ExecuteNonQuery(ByVal strSql As List(Of String), ByVal oCon As IDbConnection) As Boolean

        Try
            Me.NewConnection()

            For Each s As String In strSql
                Dim cn As IDbConnection = Me.GetOpenConnection()
                Dim cmd As IDbCommand = Me.GetCommandForText()
                cmd.CommandText = s
                cmd.ExecuteNonQuery()
            Next
            ExecuteNonQuery = True
        Catch ex As Exception
            MBFrameWork.GlobalReferences.ErrorManager.NewError(ex)
            ExecuteNonQuery = False
        Finally
            Me.CloseConnection()
        End Try

    End Function

    Friend Function ExecuteNonQuery(ByVal strSql As String, ByVal pConnection As IDbConnection) As Boolean
        ExecuteNonQuery = False
        Try
            Dim cn As IDbConnection = pConnection
            Dim cmd As IDbCommand = Me.GetCommandForText()
            cmd.CommandText = strSql
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MBFrameWork.GlobalReferences.ErrorManager.NewError(ex)
        End Try
    End Function

    Friend Function ExecuteNonQuery(ByVal strSql As String, ByVal pCommand As IDbCommand) As Boolean
        ExecuteNonQuery = False
        Try
            pCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MBFrameWork.GlobalReferences.ErrorManager.NewError(ex)
        End Try
    End Function




    Friend Function ExecuteStoredProcedureNonQuery(ByVal pStoredName As String, ByVal pParams As List(Of Entities.StoredProcedureFields)) As Boolean

    End Function

    Public Property ActiveCommand() As IDbCommand
        Get
            Return _ActiveCommand
        End Get
        Set(ByVal value As IDbCommand)
            _ActiveCommand = value
        End Set
    End Property


    Public Property SPParams() As ISPParams
        Get
            Return _SPParams
        End Get
        Set(ByVal value As ISPParams)
            _SPParams = value
        End Set
    End Property

    Public Function GetNewDataAdapter(ByRef pCommand As System.Data.IDbCommand) As IDataAdapter
        Select Case ConnectionType
            Case Constants.ConnectionTypeEnum.Odbc
                Dim oCommand As OdbcCommand = CType(pCommand, OdbcCommand)
                Return New Odbc.OdbcDataAdapter(oCommand)

            Case Constants.ConnectionTypeEnum.OleDb
                Dim oCommand As OleDbCommand = CType(pCommand, OleDbCommand)
                Return New OleDb.OleDbDataAdapter(oCommand)

            Case Constants.ConnectionTypeEnum.Sql
                Dim oCommand As SqlCommand = CType(pCommand, SqlCommand)
                Return New SqlDataAdapter(oCommand)

            Case Constants.ConnectionTypeEnum.SqlClient
                Dim oCommand As SqlCommand = CType(pCommand, SqlCommand)
                Return New SqlClient.SqlDataAdapter(oCommand)

            Case Else
                ErrorManager.NewError("No se puede obtener el comando")
                Return Nothing
        End Select
    End Function

   

    Public Function GetDataView(ByVal strSql As String, ByVal pcType As CommandType) As System.Data.DataView
        Dim ds As DataSet = Nothing
        ds = GetDataSet(strSql, pcType)
        If ds Is Nothing Then
            Return Nothing
        Else
            Return New DataView(ds.Tables(0))
        End If
    End Function

    Public Function GetDataView(ByVal pCommand As System.Data.IDbCommand) As System.Data.DataView
        Dim ds As DataSet = Nothing
        ds = GetDataSet(pCommand)
        If ds Is Nothing Then
            Return Nothing
        Else
            Return New DataView(ds.Tables(0))
        End If
    End Function


    Public Function GetDataSet(ByVal strSql As String, ByVal pcType As CommandType) As System.Data.DataSet
        Return GetDataSet(strSql, pcType, GetOpenConnection())
    End Function



    Public Function GetDataSet(ByVal strSql As String, ByVal pcType As CommandType, ByRef cn As IDbConnection) As System.Data.DataSet
        Dim oCommand As System.Data.IDbCommand = Nothing
        Dim ds As DataSet = Nothing

        Select Case pcType
            Case CommandType.StoredProcedure
                oCommand = Me.GetCommandForStoredProcedure()
            Case CommandType.TableDirect
                oCommand = Me.GetCommandForTableDirect()
            Case CommandType.Text
                oCommand = Me.GetCommandForText()
        End Select
        oCommand.Connection = cn
        oCommand.CommandText = strSql
        Return GetDataSet(oCommand)

    End Function
    Public Function GetDataSet(ByVal pCommand As System.Data.IDbCommand) As System.Data.DataSet
        Dim ds As DataSet = Nothing
        Dim NotHadConnection As Boolean = False
        Try
            If pCommand.Connection Is Nothing Then
                NotHadConnection = True
                Me.NewConnection()
                pCommand.Connection = Me.GetOpenConnection()
            End If
            Dim oDataAdapter As System.Data.IDataAdapter = GetNewDataAdapter(pCommand)
            ds = New DataSet
            oDataAdapter.Fill(ds)

        Catch ex As Exception
            MBFrameWork.GlobalReferences.ErrorManager.NewError(ex)

        Finally
            If NotHadConnection Then
                Me.CloseConnection()
            End If
        End Try
        Return ValidatedDataSet(ds)
    End Function

    'Public Function GetDataSet(ByVal pCommand As System.Data.IDbCommand, _
    '                           ByVal pageNumber As Long, _
    '                          ByVal pageSize As Integer) As System.Data.DataSet
    '    Dim ds As New DataSet

    '    Try

    '        Dim oDataAdapter As System.Data.IDataAdapter = GetNewDataAdapter(pCommand)
    '        oDataAdapter.Fill(ds)
    '    Catch ex As Exception
    '        MBFrameWork.GlobalReferences.ErrorManager.NewError(ex)
    '    Finally
    '        Me.CloseConnection()
    '    End Try

    '    Return ValidatedDataSet(ds)
    'End Function

   

    Friend Function ValidatedDataSet(ByVal ds As Data.DataSet) As DataSet
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



    Public Shared Function GetValue(ByVal vVal As Object) As Object
        Return IIf(vVal Is DBNull.Value, Nothing, CType(vVal, Object))
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Me.CloseConnection()
    End Sub
End Class
