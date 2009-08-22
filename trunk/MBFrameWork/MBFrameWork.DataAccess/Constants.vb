Imports MBFrameWork.GlobalReferences

Public Class Constants

    Public Enum ConnectionTypeEnum
        OleDb
        SqlClient
        Odbc
        Sql
    End Enum
    Private Const CNNKey As String = "cnnString"
    Private Const CNNTypeKey As String = "CNNTypeKey"

    Shared ReadOnly Property ConnectionString() As String
        Get
            Return Configuration.GetConnectionString(CNNKey)
        End Get
    End Property

    Shared ReadOnly Property ConnectionType() As ConnectionTypeEnum
        Get
            Dim sValue As String
            sValue = Configuration.GetAppConfig(CNNTypeKey)
            Select Case sValue.ToLower
                Case "oledb"
                    Return ConnectionTypeEnum.OleDb
                Case "sqlclient"
                    Return ConnectionTypeEnum.SqlClient
                Case "odbc"
                    Return ConnectionTypeEnum.Odbc
                Case "sql"
                    Return ConnectionTypeEnum.Sql
                Case Else
                    ErrorManager.NewError("No se puede obtener el tipo de cadena de conexión")
            End Select
        End Get
    End Property

End Class
