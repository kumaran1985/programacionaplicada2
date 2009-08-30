Public Class SPParamsSQL
    Inherits DABase
    Implements ISPParams



    Public Function getTypeFromDB(ByVal sDBType As String) As Entities.StoredProcedureFields.ParamTypeEnum Implements ISPParams.getTypeFromDB
        Select Case sDBType
            Case Is = "bit"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbDate
            Case Is = "smallint"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbInt16
            Case Is = "int"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbInt32
            Case Is = "tinyint"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbInt16
            Case Is = "bigint"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbInt64
            Case Is = "smallmoney"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbFloat
            Case Is = "money"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbFloat
            Case Is = "numeric"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbFloat
            Case Is = "float"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbFloat
            Case Is = "real"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbFloat
            Case Is = "decimal"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbFloat
            Case Is = "date"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbDate
            Case Is = "datetimeoffset"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbDate
            Case Is = "datetime2"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbDate
            Case Is = "smalldatetime"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbDate
            Case Is = "datetime"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbDate
            Case Is = "time"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbTime
            Case Is = "char"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbString
            Case Is = "varchar"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbString
            Case Is = "text"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbString
            Case Is = "nchar"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbChar
            Case Is = "nvarchar"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbString
            Case Is = "ntext"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbString
            Case Is = "xml"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbXML
            Case Is = "binary"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "varbinary"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "image"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "cursor"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "timestamp"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "hierarchyid"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "uniqueidentifier"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "sql_variant"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Is = "table"
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
            Case Else
                Return Entities.StoredProcedureFields.ParamTypeEnum.dbObject
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



            oParam.FieldName = GetValue(ds.Tables(1).Rows(i)("Parameter_name")).ToString


            If Not ds.Tables(1).Rows(i)("Type") Is DBNull.Value Then
                'oParam.ParamType = ds.Tables(1).Rows(i)("Parameter_name").ToString
            End If


            If Not ds.Tables(1).Rows(i)("Length") Is DBNull.Value Then
                oParam.FieldLength = CInt(ds.Tables(1).Rows(i)("Length"))
            End If

            If Not ds.Tables(1).Rows(i)("Prec") Is DBNull.Value Then
                oParam.FieldPrecision = CInt(GetValue((ds.Tables(1).Rows(i)("Prec"))))
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
