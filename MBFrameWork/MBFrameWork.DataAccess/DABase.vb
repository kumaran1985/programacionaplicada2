Imports MBFrameWork.GlobalReferences
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class DABase
     
    Private _InterfaceConnection As IDbConnection
    Private _OpenOledbConnection As OleDbConnection
    Private _OpenSqlConnection As SqlConnection
    Private _OpenODBCConnection As OdbcConnection
    Private _ConnectionType As Constants.ConnectionTypeEnum = Nothing
    Private _IsSetConnection As Boolean = False
    Private _ActiveCommand As IDbCommand
    Private _SPParams As ISPParams = Nothing



    Private Function GetCommandForStoredProcedure() As System.Data.IDbCommand
        GetCommandForStoredProcedure = GetCommand()
        GetCommandForStoredProcedure.CommandType = CommandType.StoredProcedure
    End Function

    Private Function GetCommandForText() As System.Data.IDbCommand
        GetCommandForText = GetCommand()
        GetCommandForText.CommandType = CommandType.Text
    End Function

    Private Function GetCommandForTableDirect() As System.Data.IDbCommand
        GetCommandForTableDirect = GetCommand()
        GetCommandForTableDirect.CommandType = CommandType.TableDirect
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
        GetCommand.Connection = Me.GetOpenConnection()
    End Function



    Public ReadOnly Property GetOpenConnection() As IDbConnection
        Get

            Dim oCon As IDbConnection

            'Verifico si ya ha sido seteada la conexion

            oCon = GetConnection
            If oCon Is Nothing Then

                oCon.ConnectionString = Me.GetConnectionString
                oCon.Open()
                Return oCon
            End If

            Select Case oCon.State

                Case ConnectionState.Closed
                    oCon.ConnectionString = Me.GetConnectionString
                    oCon.Open()
                Case ConnectionState.Open

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

            Dim oCon As IDbConnection

            'Verifico si ya ha sido seteada la conexion

            oCon = GetConnection

            If (Not oCon Is Nothing) AndAlso oCon.State = ConnectionState.Closed Then
                oCon.ConnectionString = Me.GetConnectionString
                oCon.Open()
            End If

            Return oCon
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
                        ErrorManager.NewError("No se puede obtener la conexión activa")

                End Select
                'Cambio el estado para saber que la conexion está sereADA
                IsSetConnection = True
                _InterfaceConnection = oCon
                Return oCon
            Else
                Return _InterfaceConnection
            End If

        End Get

    End Property



    Private Function GetConnectionString() As String
        Try
            Return Constants.ConnectionString
        Catch ex As Exception
            ErrorManager.NewError(ex)
        End Try

        Return Nothing
    End Function


    Public Property ConnectionType() As Constants.ConnectionTypeEnum
        Get
            Return _ConnectionType
        End Get
        Set(ByVal value As Constants.ConnectionTypeEnum)
            _ConnectionType = value
        End Set
    End Property

    Private Property IsSetConnection() As Boolean
        Get
            Return _IsSetConnection
        End Get
        Set(ByVal value As Boolean)
            _IsSetConnection = value
        End Set
    End Property

    Private Function GetParamsFromSP(ByVal spName As String) As List(Of Entities.StoredProcedureFields)

        If SPParams Is Nothing Then
            Throw New Exception("No se encuentra la clase issppparams")
        End If

        Return SPParams.getParams(spName, Me.GetOpenConnection)


    End Function

    Private Function ExecuteStoredProcedureNonQuery(ByVal pStoredName As String, ByVal pParams As List(Of Entities.StoredProcedureFields)) As Boolean

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
        Dim oDataAdapter As System.Data.IDataAdapter = Nothing
        Dim ds As New DataSet
        Select Case ConnectionType
            Case Constants.ConnectionTypeEnum.Odbc
                Dim oCommand As OdbcCommand = CType(pCommand, OdbcCommand)
                oDataAdapter = New Odbc.OdbcDataAdapter(oCommand)

            Case Constants.ConnectionTypeEnum.OleDb
                Dim oCommand As OleDbCommand = CType(pCommand, OleDbCommand)
                oDataAdapter = New OleDb.OleDbDataAdapter(oCommand)

            Case Constants.ConnectionTypeEnum.Sql
                Dim oCommand As SqlCommand = CType(pCommand, SqlCommand)
                oDataAdapter = New SqlDataAdapter(oCommand)

            Case Constants.ConnectionTypeEnum.SqlClient
                Dim oCommand As SqlCommand = CType(pCommand, SqlCommand)
                oDataAdapter = New SqlClient.SqlDataAdapter(oCommand)

            Case Else
                ErrorManager.NewError("No se puede obtener el comando")

        End Select

        oDataAdapter.Fill(ds)

        Return ValidatedDataSet(ds)
    End Function


    Private Function ValidatedDataSet(ByVal ds As Data.DataSet) As DataSet
        If ds Is Nothing OrElse ds.Tables.Count < 1 Then
            Return Nothing
        Else
            Return ds
        End If
    End Function

    Public Property ActiveCommand() As IDbCommand
        Get
            Return _ActiveCommand
        End Get
        Set(ByVal value As IDbCommand)
            _ActiveCommand = value
        End Set
    End Property



    Public Shared Function GetValue(ByVal vVal As Object) As Object
        Return IIf(vVal Is DBNull.Value, Nothing, CType(vVal, Object))
    End Function
    

    Public Property SPParams() As ISPParams
        Get
            Return _SPParams
        End Get
        Set(ByVal value As ISPParams)
            _SPParams = value
        End Set
    End Property

End Class
