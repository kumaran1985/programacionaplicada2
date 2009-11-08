Public Class DAPracticasMedicasxPlan
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys



    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPracticasMedicasxPlan

        miEntity.PMxP_Key = mDataTable("PMxP_Key")
        miEntity.Plan_Key = mDataTable("Plan_Key")
        miEntity.OS_Key = mDataTable("OS_Key")
        miEntity.PMxP_PorcentajeDescuento = mDataTable("PMxP_PorcentajeDescuento")

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntPracticasMedicasxPlan)

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
        Dim miEntity As Entities.EntPracticasMedicasxPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicasxPlan)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From PracticaMedicaxPlan "

        If miEntity.PMxP_Key.HasValue Then
            strWhere = strWhere & "AND PMxP_Key = " & miEntity.PMxP_Key.ToString & " "
        End If

        If miEntity.Plan_Key.HasValue Then
            strWhere = strWhere & "AND Plan_Key = " & miEntity.Plan_Key.ToString & " "
        End If

        If miEntity.OS_Key.HasValue Then
            strWhere = strWhere & "AND OS_Key = " & miEntity.OS_Key.ToString & " "
        End If

        If miEntity.PMxP_PorcentajeDescuento.HasValue Then
            strWhere = strWhere & "AND PMxP_PorcentajeDescuento = " & miEntity.PMxP_PorcentajeDescuento.ToString & " "
        End If

        If strWhere = "" Then
            Throw New Exception("Debe ingresar Valores para actualizar")
        Else
            'Elimino la palabra "AND" del where
            strWhere = strWhere.Remove(0, 3)
        End If

        strSql = strSql & "Where" & strWhere

        Return ExecuteSQLNonQuery(strSql)

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity
        Dim strSQL As String = ""
        strSQL = "Delete from PracticaMedicaxPlan Where PMxP_Key = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function
    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity


        Dim dt As DataTable
        dt = GetDataTable("Select * From PracticaMedicaxPlan Where PMxP_Key = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))


    End Function
    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("PracticaMedicaxPlan")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_PracticaMedicaxPlan")
        ds.Tables.Add(dt)

        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntPracticasMedicasxPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicasxPlan)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From PracticaMedicaxPlan"

        If miEntity.PMxP_Key.HasValue Then
            strWhere = strWhere & "AND PMxP_Key = " & miEntity.PMxP_Key.ToString & " "
        End If

        If miEntity.Plan_Key.HasValue Then
            strWhere = strWhere & "AND Plan_Key = " & miEntity.Plan_Key.ToString & " "
        End If

        If miEntity.OS_Key.HasValue Then
            strWhere = strWhere & "AND OS_Key = " & miEntity.OS_Key.ToString & " "
        End If

        If miEntity.PMxP_PorcentajeDescuento.HasValue Then
            strWhere = strWhere & "AND PMxP_PorcentajeDescuento = " & miEntity.PMxP_PorcentajeDescuento.ToString & " "
        End If

        'valido si la expresion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where" & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_PracticaMedicaxPlan")

        ds = GetDataSet(strSql)

        Return GetLista(ds)


    End Function
    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From PracticaMedicaxPlan")
        Return dt

    End Function
    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From PracticaMedicaxPlan Where PMxP_Key = " & mKey)
        Return dt
    End Function
    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntPracticasMedicasxPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicasxPlan)

        If miEntity.PMxP_Key.HasValue = False Then
            Throw New Exception("Se debe Debe ingresar Clave Principal para realizar la actualizacion")
        End If

        If miEntity.Plan_Key.HasValue = False Then
            Throw New Exception("Se debe Debe ingresar Clave del Plan para realizar la actualizacion")
        End If

        If miEntity.OS_Key.HasValue = False Then
            Throw New Exception("Se debe Debe ingresar Clave de Obra Social para realizar la actualizacion")
        End If

        If miEntity.PMxP_PorcentajeDescuento.ToString Then
            strSql = strSql & ", PMxP_PorcentajeDescuento = " & miEntity.PMxP_PorcentajeDescuento.ToString & " "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update PracticaMedicaxPlan Set " & strSql & " Where PMxP_KEY = " & miEntity.PMxP_Key.ToString

        Return ExecuteSQLNonQuery(strSql)


    End Function

    Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity

        Dim miEntity As Entities.EntPracticasMedicasxPlan = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicasxPlan)

        Dim strSql As String = ""
        strSql = "Insert Into PracticaMedicaxPlan (PMxP_Key,Plan_Key,OS_Key) Values (" & miEntity.PMxP_Key.ToString & " , " & miEntity.Plan_Key.ToString & " , " & miEntity.OS_Key.ToString & ")"

        Return ExecuteInsertQuery(strSql)


    End Function


End Class
