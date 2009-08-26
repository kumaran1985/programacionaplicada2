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

                conType = Constants.ConnectionType
                Me.ConnectionType = conType

                Select Case conType
                    Case Constants.ConnectionTypeEnum.Odbc
                        oCon = _OpenODBCConnection
                    Case Constants.ConnectionTypeEnum.OleDb
                        oCon = _OpenOledbConnection

                    Case Constants.ConnectionTypeEnum.Sql
                        oCon = _OpenSqlConnection

                    Case Constants.ConnectionTypeEnum.SqlClient
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

    Private Function GetParamsFromSP() As List(Of Entities.Params)

    End Function

    Private Function ExecuteStoredProcedureNonQuery(ByVal pStoredName As String, ByVal pParams As List(Of Entities.Params)) As Boolean

    End Function


    Public Function GetDataSet() As System.Data.DataSet

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

End Class
