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

End Class
