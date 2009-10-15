Public Class DAEntConsultorios
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys

    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntConsultorios

        miEntity.Cons_Descripcion = mDataTable("Cons_Descripcion")
        miEntity.Cons_Ubicacion = mDataTable("Cons_Ubicacion")
        miEntity.Cons_Key = mDataTable("Cons_Key")

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista
        Dim ListOfEntity As New List(Of Entities.EntConsultorios)

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
        Dim miEntity As Entities.EntConsultorios = Nothing
        miEntity = CType(mEntityObject, Entities.EntConsultorios)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From Consultorios "

        If String.IsNullOrEmpty(miEntity.Cons_Descripcion) = False Then
            strWhere = "AND Cons_Description = '" & miEntity.Cons_Descripcion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Cons_Ubicacion) = False Then
            strWhere = "AND Cons_Ubicacion = '" & miEntity.Cons_Ubicacion & "' "
        End If

        If miEntity.Cons_Key.HasValue Then
            strWhere = strWhere & "AND Cons_KEY = " & miEntity.Cons_Key.ToString & " "
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
        strSQL = "Delete from Consultorios Where Cons_KEY = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * From Consultorios Where Cons_KEY = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))
    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("Consultorios")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_Consultorios")
        ds.Tables.Add(dt)

        Return GetLista(ds)
    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntConsultorios = Nothing
        miEntity = CType(mEntityObject, Entities.EntConsultorios)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From Consultorios "

        If String.IsNullOrEmpty(miEntity.Cons_Descripcion) = False Then
            strWhere = "AND Cons_Descripcion = '" & miEntity.Cons_Descripcion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Cons_Ubicacion) = False Then
            strWhere = "AND Cons_Ubicacion = '" & miEntity.Cons_Ubicacion & "' "
        End If
        If miEntity.Cons_Key.HasValue Then
            strWhere = strWhere & "AND Cons_KEY = " & miEntity.Cons_Key.ToString & " "
        End If

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_Consultorios")

        ds = GetDataSet(strSql)


        Return GetLista(ds)
    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * from Consultorios")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * from Consultorios Where Cons_KEY = " & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim miEntity As Entities.EntConsultorios = Nothing
        miEntity = CType(mEntityObject, Entities.EntConsultorios)
        Dim strSql As String = ""
        strSql = "Insert Into Consultorio (Cons_Descripcion,Cons_Ubicacion) Values ('" & miEntity.Cons_Descripcion & "', '" & miEntity.Cons_Ubicacion & "')"

        Return ExecuteInsertQuery(strSql)
    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntConsultorios = Nothing
        miEntity = CType(mEntityObject, Entities.EntConsultorios)

        If miEntity.Cons_Key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If

        If String.IsNullOrEmpty(miEntity.Cons_Descripcion) = False Then
            strSql = ", Cons_Description = '" & miEntity.Cons_Descripcion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Cons_Ubicacion) = False Then
            strSql = ", Cons_Ubicacion = '" & miEntity.Cons_Ubicacion & "' "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update Consultorios Set " & strSql & " Where Cons_KEY = " & miEntity.Cons_Key.ToString

        Return ExecuteSQLNonQuery(strSql)
    End Function
End Class
