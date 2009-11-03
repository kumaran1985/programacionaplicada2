Public Class DASysRoles
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntSys_Roles

        miEntity.SYS_ROLE_Descripcion = DBVal(mDataTable("SYS_ROLE_Descripcion"))
        miEntity.SYS_ROLE_Enabled = DBVal(mDataTable("SYS_ROLE_Enabled"))
        miEntity.SYS_ROLE_KEY = DBVal(mDataTable("SYS_ROLE_KEY"))

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntSys_Roles)

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
        Dim miEntity As Entities.EntSys_Roles = Nothing
        miEntity = CType(mEntityObject, Entities.EntSys_Roles)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From SYS_Roles "

        If String.IsNullOrEmpty(miEntity.SYS_ROLE_Descripcion) = False Then
            strWhere = "AND Sys_ROLE_Description = '" & miEntity.SYS_ROLE_Descripcion & "' "
        End If

        If miEntity.SYS_ROLE_Enabled.HasValue Then
            strWhere = strWhere & "AND Sys_Role_Enabled = " & miEntity.SYS_ROLE_Enabled.ToString & " "
        End If

        If miEntity.SYS_ROLE_KEY.HasValue Then
            strWhere = strWhere & "AND SYS_ROLE_KEY = " & miEntity.SYS_ROLE_KEY.ToString & " "
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
        strSQL = "Delete from SYS_Roles Where SYS_ROLE_KEY = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity


        Dim dt As DataTable
        dt = GetDataTable("Select * From SYS_Roles Where SYS_ROLE_KEY = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))


    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("SYS_ROLES")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_SYS_ROLES")
        ds.Tables.Add(dt)

        Return GetLista(ds)

    End Function


    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntSys_Roles = Nothing
        miEntity = CType(mEntityObject, Entities.EntSys_Roles)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From SYS_Roles "

        If String.IsNullOrEmpty(miEntity.SYS_ROLE_Descripcion) = False Then
            strWhere = "AND Sys_ROLE_Descripcion = '" & miEntity.SYS_ROLE_Descripcion & "' "
        End If

        If miEntity.SYS_ROLE_Enabled.HasValue Then
            strWhere = strWhere & "AND Sys_Role_Enabled = " & miEntity.SYS_ROLE_Enabled.ToString & " "
        End If

        If miEntity.SYS_ROLE_KEY.HasValue Then
            strWhere = strWhere & "AND SYS_ROLE_KEY = " & miEntity.SYS_ROLE_KEY.ToString & " "
        End If

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_SYS_ROLES")

        ds = GetDataSet(strSql)


        Return GetLista(ds)


    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From SYS_Roles")
        Return dt

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * From SYS_Roles Where SYS_ROLE_KEY = " & mKey)
        Return dt
    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntSys_Roles = Nothing
        miEntity = CType(mEntityObject, Entities.EntSys_Roles)

        If miEntity.SYS_ROLE_KEY.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If


        If String.IsNullOrEmpty(miEntity.SYS_ROLE_Descripcion) = False Then
            strSql = ", Sys_ROLE_Description = '" & miEntity.SYS_ROLE_Descripcion & "' "
        End If

        If miEntity.SYS_ROLE_Enabled.HasValue Then
            strSql = strSql & ", Sys_Role_Enabled = " & miEntity.SYS_ROLE_Enabled.ToString & " "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update SYS_ROLES Set " & strSql & " Where SYS_ROLE_KEY = " & miEntity.SYS_ROLE_KEY.ToString

        Return ExecuteSQLNonQuery(strSql)


    End Function

    Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim miEntity As Entities.EntSys_Roles = Nothing
        miEntity = CType(mEntityObject, Entities.EntSys_Roles)
        Dim strSql As String = ""
        strSql = "Insert Into SYS_ROLES (Sys_ROLE_Descripcion,Sys_Role_Enabled) Values ('" & miEntity.SYS_ROLE_Descripcion & "', " & miEntity.SYS_ROLE_Enabled.ToString & ")"

        Return ExecuteInsertQuery(strSql)


    End Function
End Class
