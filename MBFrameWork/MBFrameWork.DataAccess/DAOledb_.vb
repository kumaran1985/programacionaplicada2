Option Strict Off
Imports System.Data.OleDb
Imports MBFrameWork.GlobalReferences
Imports MBFrameWork.DataAccess.Entities.Fields
Imports System.Text
Public Class DAOledb_
    Inherits DABase
    Implements IStandarQuerys

    Public Function GetAll(ByVal tableName As String) As System.Data.DataSet Implements IStandarQuerys.GetAll
        Dim StrSql As String = "Select * from [" & tableName & "]"
        Return Me.GetDataSet(StrSql, CommandType.Text)
    End Function

    Public Function GetAll(ByVal tableName As String, _
                           ByVal pageNumber As Long, _
                           ByVal pageSize As Integer) As System.Data.DataSet Implements IStandarQuerys.GetAll

        Dim cmd As OleDbCommand = Nothing
        cmd = Me.GetCommandForText
        cmd.Connection = Me.GetOpenConnection
        cmd.CommandText = "Select * from [" & tableName & "]"
        Dim da As OleDbDataAdapter = GetNewDataAdapter(cmd)
        Dim ds As DataSet = Nothing
        ds = Me.GetPagedData(da, pageNumber, pageSize)
        Return Me.ValidatedDataSet(ds)

    End Function

    Public Function GetAll(ByVal tableName As String, _
                           ByVal oEntity As Object) As System.Data.DataSet Implements IStandarQuerys.GetAll
        Return Nothing
    End Function

    Public Function GetAll(ByVal tableName As String, _
                           ByVal oEntity As Object, _
                           ByVal pageNumber As Long, _
                           ByVal pageSize As Integer) As System.Data.DataSet Implements IStandarQuerys.GetAll
        Return Nothing
    End Function

    Public Function GetOne(ByVal tableName As String, ByVal oEntity As Object) As System.Data.DataSet Implements IStandarQuerys.GetOne
        Return Nothing
    End Function

    Public Function GetOne(ByVal tableName As String, _
                           ByVal values As System.Collections.Generic.List(Of Entities.Fields)) _
                           As System.Data.DataSet Implements IStandarQuerys.GetOne
        Dim strSql As New StringBuilder
        strSql.AppendLine("Select * From [" & tableName & "]")
        strSql.AppendLine("Where 1=1")

        For Each fld As Entities.Fields In values
            If Not String.IsNullOrEmpty(CStr(fld.FieldValue)) Then

                Select Case fld.FieldType
                    Case ParamTypeEnum.dbInt16, ParamTypeEnum.dbInt32, ParamTypeEnum.dbInt64, ParamTypeEnum.dbChar
                        strSql.AppendLine("And [" & fld.FieldName & "] = " & Cast.toDBValue(CLng(fld.FieldValue)).ToString())

                    Case ParamTypeEnum.dbFloat
                        strSql.AppendLine("And [" & fld.FieldName & "] = '" & Cast.toDBValue(CDbl(fld.FieldValue)).ToString() & "'")

                    Case ParamTypeEnum.dbDate
                        strSql.AppendLine("And [" & fld.FieldName & "] = " & Me.toDBDate(fld.FieldValue) & "")

                    Case ParamTypeEnum.dbString
                        strSql.AppendLine("And [" & fld.FieldName & "] Like '" & fld.FieldValue.ToString() & "'")

                    Case ParamTypeEnum.dbMemo
                        strSql.AppendLine("And [" & fld.FieldName & "] Like '" & fld.FieldValue.ToString() & "'")

                    Case Else
                        strSql.AppendLine("And [" & fld.FieldName & "] = '" & fld.FieldValue.ToString() & "'")

                End Select
            End If
        Next
        Return Me.ValidatedDataSet(Me.GetDataSet(strSql.ToString))

    End Function


    Public Function GetOneByPK(ByVal tableName As String, _
                               ByVal value As Object) As System.Data.DataSet Implements IStandarQuerys.GetOneByPK
        Return Nothing
    End Function

    Public Function GetOneByPK(ByVal tableName As String, _
                               ByVal pk As System.Collections.Generic.List(Of Entities.Fields)) _
                               As System.Data.DataSet Implements IStandarQuerys.GetOneByPK
        Return Nothing
    End Function

    Public Function GetOneByPK(ByVal tableName As String, _
                               ByVal pk As System.Collections.Generic.List(Of Entities.Fields), _
                               ByVal pageNumber As Long, ByVal pageSize As Integer) As System.Data.DataSet Implements IStandarQuerys.GetOneByPK
        Dim strSql As New StringBuilder
        strSql.AppendLine("Select * From [" & tableName & "]")
        strSql.AppendLine("Where 1=1")
        For Each fld As Entities.Fields In pk
            If Not String.IsNullOrEmpty(CStr(fld.FieldValue)) Then

                Select Case fld.FieldType
                    Case ParamTypeEnum.dbInt16, ParamTypeEnum.dbInt32, ParamTypeEnum.dbInt64, ParamTypeEnum.dbChar
                        strSql.AppendLine("And [" & fld.FieldName & "] = " & Cast.toDBValue(CLng(fld.FieldValue)).ToString())

                    Case ParamTypeEnum.dbFloat
                        strSql.AppendLine("And [" & fld.FieldName & "] = '" & Cast.toDBValue(CDbl(fld.FieldValue)).ToString() & "'")

                    Case ParamTypeEnum.dbDate
                        strSql.AppendLine("And [" & fld.FieldName & "] = " & Me.toDBDate(fld.FieldValue) & "")

                    Case ParamTypeEnum.dbString
                        strSql.AppendLine("And [" & fld.FieldName & "] Like '" & fld.FieldValue.ToString() & "'")

                    Case ParamTypeEnum.dbMemo
                        strSql.AppendLine("And [" & fld.FieldName & "] Like '" & fld.FieldValue.ToString() & "'")

                    Case Else
                        strSql.AppendLine("And [" & fld.FieldName & "] = '" & fld.FieldValue.ToString() & "'")

                End Select
            End If
        Next
        Return Me.GetDataSet(strSql.ToString)
    End Function

    Public Function GetTableInfo(ByVal tableName As String) As Entities.TableInfo Implements IStandarQuerys.GetTableInfo
        Dim oCmd As New OleDbCommand()
        oCmd = Me.GetCommandForTableDirect
        oCmd.CommandText = tableName
        oCmd.Connection = Me.GetOpenConnection
        Dim reader As OleDbDataReader = oCmd.ExecuteReader(CommandBehavior.SchemaOnly)

        ' Get references to schema information
        Dim SchemaTable As DataTable = reader.GetSchemaTable()

        ' Close and release the connection before processing results
        reader.Close()
        Me.GetOpenConnection.Close()
        Dim col As DataColumn
        Dim miTabla As New Entities.TableInfo
        miTabla.TableName = tableName
        For Each col In SchemaTable.Columns
            Dim tf As New Entities.TableFields
            tf.isPrimary = col.Unique
            tf.FieldDescription = col.Caption
            tf.FieldLength = col.MaxLength
            tf.FieldName = col.Caption
            tf.FieldOrder = col.Ordinal
            tf.FieldPrecision = 0
            tf.FieldScale = 0
            tf.FieldType = Cast.toDBType(col.DataType)
            tf.FieldDefaultValue = col.DefaultValue
            tf.FieldIsNullable = col.AllowDBNull
            miTabla.TableFields.Add(tf)
        Next
        Return miTabla
    End Function

    Public Function Insert(ByVal tableName As String, _
                           ByVal values As System.Collections.Generic.List(Of Entities.Fields)) As Boolean Implements IStandarQuerys.Insert

    End Function

    Public Function Insert(ByVal tableName As String, _
                           ByVal values As System.Collections.Generic.List(Of Entities.Fields), _
                           ByRef PK As Object) As Boolean Implements IStandarQuerys.Insert

    End Function

    Public Function UpdateByPk(ByVal tableName As String, _
                               ByVal pk As System.Collections.Generic.List(Of Entities.Fields)) As Boolean Implements IStandarQuerys.UpdateByPk

    End Function

    Function GetPagedData(ByVal dataAdapter As IDbDataAdapter, ByVal pageNumber As Integer, ByVal pageSize As Integer) As DataSet Implements IStandarQuerys.GetPagedData
        Dim da As OleDbDataAdapter = CType(dataAdapter, OleDbDataAdapter)
        Dim ds As DataSet = Nothing
        Try
            ds = New DataSet
            da.Fill(ds, pageNumber, pageSize)
        Catch e As Exception
            ErrorManager.NewError("No se puede obtener el comando")
        End Try
        Return ds
    End Function

    'Function GetPagedData(ByVal da As SqlDataAdapter, ByVal idx As Integer, ByVal size As Integer) As DataSet
    '    Dim ds As DataSet = New DataSet
    '    Try
    '        da.Fill(ds, idx, size, "Orders")
    '    Catch e As Exception
    '        ErrorManager.NewError("No se puede obtener el comando")
    '    End Try
    '    Return ds
    'End Function
    Function toDBDate(ByVal strValue As Object) As String Implements IStandarQuerys.toDBDate
        Dim dt As Date
        dt = CDate(strValue)
        Return Constants.DateSeparator & Format(dt, "yyyyMMdd") & " " & dt.Hour & ":" & dt.Minute & ":" & dt.Second & "." & dt.Millisecond & Constants.DateSeparator
    End Function

    Function DeleteByPK(ByVal da As IDbDataAdapter, ByVal pk As Object) As Boolean Implements IStandarQuerys.DeleteByPK
        Return True
    End Function

End Class
