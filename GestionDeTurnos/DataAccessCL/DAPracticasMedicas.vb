Public Class DAPracticasMedicas
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys




    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPracticasMedicas

        miEntity.PM_Key = mDataTable("PM_Key")
        miEntity.PM_Descripcion = mDataTable("PM_Descripcion")
        miEntity.PM_PrecioUnitario = mDataTable("PM_PrecioUnitario")

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntPracticasMedicas)

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
        Dim miEntity As Entities.EntPracticasMedicas = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicas)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From PracticasMedicas "

        If String.IsNullOrEmpty(miEntity.PM_Descripcion) = False Then
            strWhere = "AND PM_descripcion = '" & miEntity.PM_Descripcion & "' "
        End If

        If miEntity.PM_Key.HasValue Then
            strWhere = strWhere & "AND PM_Key = " & miEntity.PM_Key.ToString & " "
        End If

        If strWhere = "" Then
            Throw New Exception("Debe ingresar Valores para actualizar")
        Else
            'Elimino la palabra "AND" del where
            strWhere = strWhere.Remove(0, 3)
        End If

        strSql = strSql & " Where " & strWhere

        Return ExecuteSQLNonQuery(strSql)

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity
        Dim strSQL As String = ""
        strSQL = "Delete from PracticasMedicas Where PM_KEY = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity


        Dim dt As DataTable
        dt = GetDataTable("Select * From PracticasMedicas Where PM_KEY = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))


    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("PracticasMedicas")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_PracticasMedicas")
        ds.Tables.Add(dt)

        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntPracticasMedicas = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicas)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From PracticasMedicas "

        If String.IsNullOrEmpty(miEntity.PM_Descripcion) = False Then
            strWhere = "AND PM_Descripcion = '" & miEntity.PM_Descripcion & "' "
        End If

        If miEntity.PM_Key.HasValue Then
            strWhere = strWhere & "AND SYS_ROLE_KEY = " & miEntity.PM_Key.ToString & " "
        End If

        'valido si la expresion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_PracticasMedicas")

        ds = GetDataSet(strSql)

        Return GetLista(ds)


    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From PracticasMedicas")
        Return dt

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From PracticasMedicas Where PM_KEY = " & mKey)
        Return dt
    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntPracticasMedicas = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicas)

        If miEntity.PM_Key.HasValue = False Then
            Throw New Exception("Se debe Debe ingresar Clave Principal para realizar la actualizacion")
        End If


        If String.IsNullOrEmpty(miEntity.PM_Descripcion) = False Then
            strSql = ", PM_Description = '" & miEntity.PM_Descripcion & "' "
        End If

        If miEntity.PM_PrecioUnitario.ToString Then
            strSql = strSql & ", PM_PrecioUnitario = " & miEntity.PM_PrecioUnitario.ToString & " "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update PracticasMedicas Set " & strSql & " Where PM_KEY = " & miEntity.PM_Key.ToString

        Return ExecuteSQLNonQuery(strSql)


    End Function

    Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity

        Dim miEntity As Entities.EntPracticasMedicas = Nothing
        miEntity = CType(mEntityObject, Entities.EntPracticasMedicas)

        Dim strSql As String = ""
        strSql = "Insert Into PracticasMedicas (PM_Description,PM_PrecioUnitario) Values ('" & miEntity.PM_Descripcion & "', " & miEntity.PM_PrecioUnitario.ToString & ")"

        Return ExecuteInsertQuery(strSql)


    End Function

End Class
