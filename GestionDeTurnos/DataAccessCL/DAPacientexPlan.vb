Public Class DAPacientexPlan
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys




    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPacientexPlan
        miEntity.iNroHC = mDataTable("iNroHC")
        miEntity.iPlan = mDataTable("iPlan")
        miEntity.iObraSocial = mDataTable("iObraSocial")
        miEntity.tFechaFin = mDataTable("tFechaFin")
        miEntity.tFechaInicio = mDataTable("tFechaInicio")

        Return miEntity


    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista
        Dim ListOfEntity As New List(Of Entities.EntPacientexPlan)

        'valida si existen los elementos del DataSet
        If ValidatedDataSet(mDataSet) Is Nothing Then
            Return Nothing
        End If

        For Each dr As DataRow In mDataSet.Tables(0).Rows
            'agrego la entidad a la lista con el método GenerarEntidad
            ListOfEntity.Add(Me.GenerarEntidad(dr))
        Next

        Return ListOfEntity
    End Function

    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity
        Dim miEntity As Entities.EntPacientexPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPacientexPlan)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From PacientexPlan "

        If miEntity.iNroHC.HasValue Then
            strWhere = strWhere & "AND _iNroHC = " & miEntity.iNroHC.ToString & " "

        End If

        If miEntity.iPlan.HasValue Then
            strWhere = strWhere & "AND _iPlan = " & miEntity.iPlan.ToString & " "

        End If

        If miEntity.iObraSocial.HasValue Then
            strWhere = strWhere & "AND _iObraSocial = " & miEntity.iObraSocial.ToString & " "

        End If
        If miEntity.tFechaInicio = Date.MinValue Then 'quiere decir que la fecha está vacía
            strWhere = strWhere & "AND _tFechaInicio = #" & miEntity.tFechaInicio.Date & "#"

        End If
        If miEntity.tFechaFin = Date.MinValue Then
            strWhere = strWhere & "AND _tFechaFin = #" & miEntity.tFechaFin.Date & "#"
        End If


        'valido si la exprsion del where tiene contenido

        If strWhere = "" Then
            Throw New Exception("No se puede ejecutar la actualizacion porque no se han especificado todos los valores")
        Else
            'Elimino la palabra "AND" del where
            strWhere = strWhere.Remove(0, 3)
        End If

        strSql = strSql & " Where " & strWhere

        Return ExecuteSQLNonQuery(strSql)

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity
        Dim strSQL As String = ""
        strSQL = "Delete from PacientexPlan Where iNroHC = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * From PacientexPlan Where iNroHC = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))
    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("PacientexPlan")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_PacientexPlan")
        ds.Tables.Add(dt)

        Return GetLista(ds)
    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntPacientexPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPacientexPlan)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From PacientexPlan "

        If miEntity.iNroHC.HasValue Then
            strWhere = strWhere & "AND _iNroHC = " & miEntity.iNroHC.ToString & " "

        End If

        If miEntity.iPlan.HasValue Then
            strWhere = strWhere & "AND _iPlan = " & miEntity.iPlan.ToString & " "

        End If

        If miEntity.iObraSocial.HasValue Then
            strWhere = strWhere & "AND _iObraSocial = " & miEntity.iObraSocial.ToString & " "

        End If
        If miEntity.tFechaInicio = Date.MinValue Then
            strWhere = strWhere & "AND _tFechaInicio = #" & miEntity.tFechaInicio.Date & "#"

        End If
        If miEntity.tFechaFin = Date.MinValue Then
            strWhere = strWhere & "AND _tFechaFin = #" & miEntity.tFechaFin.Date & "#"
        End If

        

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_PacientexPlan")

        ds = GetDataSet(strSql)


        Return GetLista(ds)
    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From PacientexPlan")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From PacientexPlan Where iNroHC = " & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim miEntity As Entities.EntPacientexPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPacientexPlan)
        Dim strSql As String = ""
        strSql = "Insert Into PacientexPlan (iPlan,iObraSocial,tFechaInicio,tFechaFin) Values ('" & miEntity.iPlan.ToString & "', " & miEntity.iObraSocial.ToString & ", " & miEntity.tFechaInicio & ", " & miEntity.tFechaFin & ")"

        Return ExecuteInsertQuery(strSql)
    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntPacientexPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPacientexPlan)

        If miEntity.iNroHC.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If


        If miEntity.iPlan.HasValue Then
            strSql = strSql & ", iPlan = " & miEntity.iPlan.ToString & " "
        End If

        If miEntity.iObraSocial.HasValue Then
            strSql = strSql & ", iObraSocial = " & miEntity.iObraSocial.ToString & " "
        End If

        If miEntity.tFechaInicio.ToString Then
            strSql = strSql & ", tFechaInicio = #" & miEntity.tFechaInicio.ToString & "#"
        End If

        If miEntity.tFechaFin.ToString Then
            strSql = strSql & ", tFechaFin = #" & miEntity.tFechaFin.ToString & "#"
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update PacientexPlan Set " & strSql & " Where PâcienteXPlan = " & miEntity.iNroHC.ToString

        Return ExecuteSQLNonQuery(strSql)
    End Function
End Class
