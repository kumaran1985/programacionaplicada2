Public Class DBTools
    Public Function CastField(ByVal FieldValue As Object, ByVal FieldType As DbType) As Object

        Select Case FieldType
            Case DbType.AnsiString
            Case DbType.AnsiStringFixedLength
            Case DbType.Binary
            Case DbType.Boolean
            Case DbType.Byte
            Case DbType.Currency
            Case DbType.Date
            Case DbType.DateTime
            Case DbType.DateTime2
            Case DbType.DateTimeOffset

        End Select

    End Function

    Public Function EntityToParamArray(ByVal Entity As Object) As List(Of DBParams)

    End Function

    Public Function EntityToDBFields(ByVal Entity As Object) As List(Of DBFields)

    End Function

    
End Class
