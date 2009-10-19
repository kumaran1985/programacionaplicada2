Public Class DAPlanes
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys



    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPlanes
        miEntity.OS_Key = mDataTable("OS_Key")
        miEntity.Plan_Descripcion = mDataTable("Plan_Descripcion")
        miEntity.Plan_FechaAlta = mDataTable("Plan_FechaAlta")
        miEntity.Plan_FechaCancelacion = mDataTable("Plan_FechaCancelacion")
        miEntity.Plan_FechaFinConvenio = mDataTable("Plan_FinConvenio")
        miEntity.Plan_Key = mDataTable("Plan_key")
        miEntity.Plan_Nombre = mDataTable("Plan_Nombre")
        Return miEntity


    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntPlanes)

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

        Dim miEntity As Entities.EntPlanes = Nothing
        miEntity = CType(mEntityObject, Entities.EntPlanes)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From Planes "

        If miEntity.Plan_Key.HasValue Then
            strWhere = strWhere & "AND Plan_Key ='" & miEntity.Plan_Key.ToString & " "
        End If

        If miEntity.OS_Key.HasValue Then
            strWhere = strWhere & "AND OS_Key ='" & miEntity.OS_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Plan_Nombre) = False Then
            strWhere = "AND Plan_Nombre = '" & miEntity.Plan_Nombre & "' "
        End If


        If String.IsNullOrEmpty(miEntity.Plan_Descripcion) = False Then
            strWhere = "AND Plan_Descripcion = '" & miEntity.Plan_Descripcion & "' "
        End If

        If miEntity.Plan_FechaFinConvenio = Date.MinValue Then
            strWhere = strWhere & "AND Plan_FechaFinConvenio = " & miEntity.Plan_FechaFinConvenio.Date & ""
        End If

        If miEntity.Plan_FechaAlta = Date.MinValue Then
            strWhere = strWhere & "AND Plan_FechaAlta = " & miEntity.Plan_FechaAlta.Date & ""
        End If

        If miEntity.Plan_FechaCancelacion = Date.MinValue Then
            strWhere = strWhere & "AND Plan_FechaCancelacion = " & miEntity.Plan_FechaCancelacion.Date & ""
        End If



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
        strSQL = "Delete from Planes Where _Plan_Key = " & mKey
        Return ExecuteSQLNonQuery(strSQL)

    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity

        Dim dt As DataTable
        dt = GetDataTable("Select * From Planes Where _Plan_KEY = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

        Dim dt As DataTable = GetAllFromTable("Planes")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_Planes")
        ds.Tables.Add(dt)

        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntPlanes = Nothing
        miEntity = CType(mEntityObject, Entities.EntPlanes)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From Planes "

        If miEntity.Plan_Key.HasValue Then
            strWhere = strWhere & "AND Plan_Key ='" & miEntity.Plan_Key.ToString & " "
        End If

        If miEntity.OS_Key.HasValue Then
            strWhere = strWhere & "AND OS_Key ='" & miEntity.OS_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Plan_Nombre) = False Then
            strWhere = "AND Plan_Nombre = '" & miEntity.Plan_Nombre & "' "
        End If


        If String.IsNullOrEmpty(miEntity.Plan_Descripcion) = False Then
            strWhere = "AND Plan_Descripcion = '" & miEntity.Plan_Descripcion & "' "
        End If

        If miEntity.Plan_FechaFinConvenio = Date.MinValue Then
            strWhere = strWhere & "AND Plan_FechaFinConvenio = " & miEntity.Plan_FechaFinConvenio.Date & ""
        End If

        If miEntity.Plan_FechaAlta = Date.MinValue Then
            strWhere = strWhere & "AND Plan_FechaAlta = " & miEntity.Plan_FechaAlta.Date & ""
        End If

        If miEntity.Plan_FechaCancelacion = Date.MinValue Then
            strWhere = strWhere & "AND Plan_FechaCancelacion = " & miEntity.Plan_FechaCancelacion.Date & ""

        End If

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_Planes")

        ds = GetDataSet(strSql)


        Return GetLista(ds)


    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

        Dim dt As DataTable
        dt = GetDataTable("Select * From Planes")
        Return dt

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

        Dim dt As DataTable
        dt = GetDataTable("Select * From Planes Where _Plan_Key = " & mKey)
        Return dt

    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity


        Dim miEntity As Entities.EntPlanes = Nothing
        miEntity = CType(mEntityObject, Entities.EntPlanes)
        Dim strSql As String = ""
        strSql = "Insert Into Planes (_OS_Key,_Plan_Nombre,_Plan_Descripcion,_Plan_FechaFinConvenio,_Plan_FechaAlta,_Plan_FechaCancelacion) Values ('" & miEntity.OS_Key.ToString & "', " & miEntity.Plan_Nombre & ", " & miEntity.Plan_Descripcion & ", " & miEntity.Plan_FechaFinConvenio & ", " & miEntity.Plan_FechaAlta & ", " & miEntity.Plan_FechaCancelacion & ")"

        Return ExecuteInsertQuery(strSql)

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity

        Dim strSql As String = ""
        Dim miEntity As Entities.EntPlanes = Nothing
        miEntity = CType(mEntityObject, Entities.EntPlanes)

        If miEntity.Plan_Key.HasValue Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If

        If miEntity.OS_Key.HasValue Then
            strSql = strSql & ", OS_Key = " & miEntity.OS_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Plan_Nombre) = False Then
            strSql = ", Plan_Nombre = '" & miEntity.Plan_Nombre & "' "
        End If


        If String.IsNullOrEmpty(miEntity.Plan_Descripcion) = False Then
            strSql = ", Plan_Descripcion = '" & miEntity.Plan_Descripcion & "' "
        End If

        If miEntity.Plan_FechaFinConvenio = Date.MinValue Then
            strSql = strSql & ", Plan_FechaFinConvenio = " & miEntity.Plan_FechaFinConvenio.ToString & " "
        End If

        If miEntity.Plan_FechaAlta = Date.MinValue Then
            strSql = strSql & ", Plan_FechaAlta = " & miEntity.Plan_FechaAlta.ToString & " "
        End If

        If miEntity.Plan_FechaCancelacion = Date.MinValue Then
            strSql = strSql & ", Plan_FechaCancelacion = " & miEntity.Plan_FechaCancelacion.ToString & " "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update Planes Set " & strSql & " Where Plan_key = " & miEntity.Plan_Key.ToString

        Return ExecuteSQLNonQuery(strSql)


    End Function


End Class
