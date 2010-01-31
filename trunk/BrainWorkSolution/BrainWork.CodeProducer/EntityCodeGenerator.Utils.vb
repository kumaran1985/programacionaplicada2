Partial Public Class EntityCodeGenerator
    'Private Function GetDBType(ByVal theType As System.Type) As SqlDbType
    '    Dim p1 As SqlClient.SqlParameter
    '    Dim tc As System.ComponentModel.TypeConverter
    '    p1 = New SqlClient.SqlParameter()
    '    tc = System.ComponentModel.TypeDescriptor.GetConverter(p1.DbType)
    '    If tc.CanConvertFrom(theType) Then
    '        p1.DbType = tc.ConvertFrom(theType.Name)
    '    Else
    '        'Try brute force
    '        Try
    '            p1.DbType = tc.ConvertFrom(theType.Name)
    '        Catch ex As Exception
    '            'Do Nothing
    '        End Try
    '    End If
    '    Return p1.SqlDbType
    'End Function
End Class
