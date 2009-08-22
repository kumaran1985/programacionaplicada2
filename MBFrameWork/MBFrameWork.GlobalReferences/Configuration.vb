Imports System.Configuration
Public Class Configuration
    Shared Function GetAppConfig(ByVal sKey As String) As String
        Try
            Return ConfigurationManager.AppSettings(sKey)
        Catch ex As Exception
            ErrorManager.NewError(ex)
            Return Nothing
        End Try
    End Function

    'Public Function GetAppConfig(ByRef oKey As Object) As Object
    '    Try

    '        Return CType(ConfigurationManager.AppSettings(oKey), Object)
    '    Catch ex As Exception
    '        ErrorManager.NewError(ex)
    '        Return Nothing
    '    End Try
    'End Function

    Shared Function GetConnectionString(ByVal sKey As String) As String
        Try
            Return ConfigurationManager.ConnectionStrings(sKey).ToString
        Catch ex As Exception
            ErrorManager.NewError(ex)
            Return Nothing
        End Try
    End Function
End Class
