Public Class SPParamsSQL
    Implements ISPParams

 

    Public Function getTypeFromDB(ByVal sDBType As String) As Entities.Params.ParamTypeEnum Implements ISPParams.getTypeFromDB
        Select Case sdbType
            Case Is = "bit"
                Return Entities.ParamsFields.ParamTypeEnum.dbDate
            Case Is = "smallint"
                Return Entities.ParamsFields.ParamTypeEnum.dbInt16
            Case Is = "int"
                Return Entities.ParamsFields.ParamTypeEnum.dbInt32
            Case Is = "tinyint"
                Return Entities.ParamsFields.ParamTypeEnum.dbInt16
            Case Is = "bigint"
                Return Entities.ParamsFields.ParamTypeEnum.dbInt64
            Case Is = "smallmoney"
                Return Entities.ParamsFields.ParamTypeEnum.dbFloat
            Case Is = "money"
                Return Entities.ParamsFields.ParamTypeEnum.dbFloat
            Case Is = "numeric"
                Return Entities.ParamsFields.ParamTypeEnum.dbFloat
            Case Is = "float"
                Return Entities.ParamsFields.ParamTypeEnum.dbFloat
            Case Is = "real"
                Return Entities.ParamsFields.ParamTypeEnum.dbFloat
            Case Is = "decimal"
                Return Entities.ParamsFields.ParamTypeEnum.dbFloat
            Case Is = "date"
                Return Entities.ParamsFields.ParamTypeEnum.dbDate
            Case Is = "datetimeoffset"
                Return Entities.ParamsFields.ParamTypeEnum.dbDate
            Case Is = "datetime2"
                Return Entities.ParamsFields.ParamTypeEnum.dbDate
            Case Is = "smalldatetime"
                Return Entities.ParamsFields.ParamTypeEnum.dbDate
            Case Is = "datetime"
                Return Entities.ParamsFields.ParamTypeEnum.dbDate
            Case Is = "time"
                Return Entities.ParamsFields.ParamTypeEnum.dbTime
            Case Is = "char"
                Return Entities.ParamsFields.ParamTypeEnum.dbString
            Case Is = "varchar"
                Return Entities.ParamsFields.ParamTypeEnum.dbString
            Case Is = "text"
                Return Entities.ParamsFields.ParamTypeEnum.dbString
            Case Is = "nchar"
                Return Entities.ParamsFields.ParamTypeEnum.dbChar
            Case Is = "nvarchar"
                Return Entities.ParamsFields.ParamTypeEnum.dbString
            Case Is = "ntext"
                Return Entities.ParamsFields.ParamTypeEnum.dbString
            Case Is = "xml"
                Return Entities.ParamsFields.ParamTypeEnum.dbXML
            Case Is = "binary"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "varbinary"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "image"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "cursor"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "timestamp"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "hierarchyid"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "uniqueidentifier"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "sql_variant"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Is = "table"
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
            Case Else
                Return Entities.ParamsFields.ParamTypeEnum.dbObject
        End Select
    End Function

    Public Function getParams(ByVal spName As String, _
                              ByVal oConn As System.Data.IDbConnection) As System.Collections.Generic.List(Of Entities.StoredProcedureFields) Implements ISPParams.getParams
        Dim oCommand As New SqlClient.SqlCommand
        Dim ds As New DataSet
        Dim ListParm As New List(Of Entities.StoredProcedureFields)
        Dim oParam As New Entities.StoredProcedureFields

        Dim strSql As String
        strSql = "If Exists(SELECT * FROM sys.objects WHERE type = 'P' AND name = '" & spName & "') " & _
                " Begin " & _
                " exec sp_help " & spName & _
                " End"


        oCommand.CommandType = CommandType.Text
        oCommand.Connection = CType(oConn, SqlClient.SqlConnection)
        oCommand.CommandText = strSql
        Dim da As New SqlClient.SqlDataAdapter(oCommand)
        da.Fill(ds)

        If ds Is Nothing OrElse ds.Tables.Count < 0 OrElse ds.Tables(0).Rows.Count < 1 Then
            Return Nothing
        End If

        For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
            oParam = New Entities.StoredProcedureFields
            If Not ds.Tables(1).Rows(i)("Parameter_name") Is DBNull.Value Then
                oParam.FieldName = ds.Tables(1).Rows(i)("Parameter_name").ToString
            End If

            If Not ds.Tables(1).Rows(i)("Type") Is DBNull.Value Then
                'oParam.ParamType = ds.Tables(1).Rows(i)("Parameter_name").ToString
            End If


            If Not ds.Tables(1).Rows(i)("Length") Is DBNull.Value Then
                oParam.FieldLength = CInt(ds.Tables(1).Rows(i)("Length"))
            End If

            If Not ds.Tables(1).Rows(i)("Prec") Is DBNull.Value Then
                oParam.FieldPrecision = CInt(ds.Tables(1).Rows(i)("Prec").ToString)
            End If

            If Not ds.Tables(1).Rows(i)("Scale") Is DBNull.Value Then
                oParam.FieldScale = CInt(ds.Tables(1).Rows(i)("Scale").ToString)
            End If

            If Not ds.Tables(1).Rows(i)("Param_order") Is DBNull.Value Then
                oParam.FieldOrder = CInt(ds.Tables(1).Rows(i)("Param_order").ToString)
            End If

            ListParm.Add(oParam)
        Next

        Return ListParm

    End Function
End Class
