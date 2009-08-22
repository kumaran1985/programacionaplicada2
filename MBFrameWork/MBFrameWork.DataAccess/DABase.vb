Imports MBFrameWork.GlobalReferences
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class DABase
    Private _OpenOledbConnection As OleDbConnection
    Private _OpenSqlConnection As SqlConnection
    Private _OpenODBCConnection As OdbcConnection

    Public ReadOnly Property GetOpenConnection() As IDbConnection
        Get
            Dim conType As Constants.ConnectionTypeEnum
            Dim oCon As IDbConnection

            conType = Constants.ConnectionType
            Select Case conType
                Case Constants.ConnectionTypeEnum.Odbc
                    oCon = _OpenODBCConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New OdbcConnection
                    End If
                Case Constants.ConnectionTypeEnum.OleDb
                    oCon = _OpenOledbConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New OleDbConnection
                    End If
                Case Constants.ConnectionTypeEnum.Sql
                    oCon = _OpenSqlConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New SqlConnection
                    End If
                Case Constants.ConnectionTypeEnum.SqlClient
                    oCon = _OpenSqlConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New SqlConnection
                    End If
                Case Else
                    ErrorManager.NewError("No se puede obtener la conexión activa"

            End Select

            If oCon.State = ConnectionState.Closed Then
                oCon.ConnectionString = Me.GetConnectionString
                oCon.Open()
            End If
            Return oCon
        End Get

    End Property

    Public ReadOnly Property GetOpenConnection() As IDbConnection
        Get
            Dim conType As Constants.ConnectionTypeEnum
            Dim oCon As IDbConnection

            conType = Constants.ConnectionType
            Select Case conType
                Case Constants.ConnectionTypeEnum.Odbc
                    oCon = _OpenODBCConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New OdbcConnection
                    End If
                Case Constants.ConnectionTypeEnum.OleDb
                    oCon = _OpenOledbConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New OleDbConnection
                    End If
                Case Constants.ConnectionTypeEnum.Sql
                    oCon = _OpenSqlConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New SqlConnection
                    End If
                Case Constants.ConnectionTypeEnum.SqlClient
                    oCon = _OpenSqlConnection
                    If oCon.State = ConnectionState.Closed Then
                        oCon = New SqlConnection
                    End If
                Case Else
                    ErrorManager.NewError("No se puede obtener la conexión activa")

            End Select

            If oCon.State = ConnectionState.Closed Then
                oCon.ConnectionString = Me.GetConnectionString
                oCon.Open()
            End If
            Return oCon
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


End Class
