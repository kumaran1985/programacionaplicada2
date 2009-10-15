

Public Class dafacturas
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys




    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntFacturas

        miEntity.Fact_Key = mDataTable("Fact_Key")
        miEntity.Pac_key = mDataTable("Pac_Key")
        miEntity.fact_fechafactura = mDataTable("Fact_Fechafactura")
        miEntity.Fact_Tipo = mDataTable("Fact_Tipo")
        miEntity.Fact_Monto = mDataTable("Fact_Monto")
        miEntity.Fact_TipoDoc = mDataTable("Fact_TipoDoc")
        miEntity.Fact_NumeroDoc = mDataTable("Fact_NumeroDoc")
        miEntity.Fact_Cantidad = mDataTable("Fact_Cantidad")
        miEntity.PM_Key = mDataTable("PM_Key")
        miEntity.Fact_Observacion = mDataTable("Fact_Observacion")
        miEntity.Fact_FechaAlta = mDataTable("Fact_FechaAlta")
        miEntity.Fact_FechaCancelacion = mDataTable("Fact_FechaCancelacion")

        Return miEntity

    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntFacturas)

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
        Dim miEntity As Entities.EntFacturas = Nothing
        miEntity = CType(mEntityObject, Entities.EntFacturas)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From EntFacturas "

        If miEntity.Fact_Key.HasValue Then
            strWhere = strWhere & "AND Fact.Key = '" & miEntity.Fact_Key.ToString & "' "
        End If

        If miEntity.Pac_key.HasValue Then
            strWhere = strWhere & "AND Pac_Key = " & miEntity.Pac_key.ToString & " "
        End If

        If Not miEntity.fact_fechafactura = Date.MinValue Then
            strWhere = strWhere & "AND fact_fechafactura = " & miEntity.fact_fechafactura.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_Tipo) = False Then
            strWhere = "AND Fact_Tipo = '" & miEntity.Fact_Tipo & "' "

        End If

        If miEntity.Fact_Monto.HasValue Then
            strWhere = strWhere & "AND Fact_Monto = " & miEntity.Fact_Monto.ToString & " "

        End If

        If miEntity.Fact_TipoDoc.HasValue Then
            strWhere = strWhere & "AND Fact_TipoDoc = " & miEntity.Fact_TipoDoc.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_TipoDoc) = False Then
            strWhere = "AND Fact_TipoDoc = '" & miEntity.Fact_TipoDoc.ToString & "' "

        End If

        If miEntity.Fact_Cantidad.HasValue Then
            strWhere = strWhere & "AND Fact_Cantidad = " & miEntity.Fact_Cantidad.ToString & " "

        End If

        If miEntity.PM_Key.HasValue Then
            strWhere = strWhere & "AND PM_Key = " & miEntity.PM_Key.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_Observacion) = False Then
            strWhere = "AND Fact_Observacion = '" & miEntity.Fact_Observacion.ToString & "' "

        End If

        If Not miEntity.Fact_FechaAlta = Date.MinValue Then
            strWhere = strWhere & "AND fact_fechaalta = " & miEntity.Fact_FechaAlta.ToString & " "

        End If

        If Not miEntity.Fact_FechaCancelacion = Date.MinValue Then
            strWhere = strWhere & "AND fact_FechaCancelacion = " & miEntity.Fact_FechaCancelacion.ToString & " "

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
        strSQL = "Delete from EntFacturas Where Fact_Key  = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * From EntFacturas Where Fact_Key = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))
    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("EntFacturas")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("EntFacturas")
        ds.Tables.Add(dt)

        Return GetLista(ds)
    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntFacturas = Nothing
        miEntity = CType(mEntityObject, Entities.EntFacturas)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From EntFacturas "

        If miEntity.Fact_Key.HasValue Then
            strWhere = strWhere & "AND Fact.Key = '" & miEntity.Fact_Key.ToString & "' "
        End If

        If miEntity.Pac_key.HasValue Then
            strWhere = strWhere & "AND Pac_Key = " & miEntity.Pac_key.ToString & " "
        End If

        If Not miEntity.fact_fechafactura = Date.MinValue Then
            strWhere = strWhere & "AND fact_fechafactura = " & miEntity.fact_fechafactura.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_Tipo) = False Then
            strWhere = "AND Fact_Tipo = '" & miEntity.Fact_Tipo & "' "

        End If

        If miEntity.Fact_Monto.HasValue Then
            strWhere = strWhere & "AND Fact_Monto = " & miEntity.Fact_Monto.ToString & " "

        End If

        If miEntity.Fact_TipoDoc.HasValue Then
            strWhere = strWhere & "AND Fact_TipoDoc = " & miEntity.Fact_TipoDoc.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_TipoDoc) = False Then
            strWhere = "AND Fact_TipoDoc = '" & miEntity.Fact_TipoDoc.ToString & "' "

        End If

        If miEntity.Fact_Cantidad.HasValue Then
            strWhere = strWhere & "AND Fact_Cantidad = " & miEntity.Fact_Cantidad.ToString & " "

        End If

        If miEntity.PM_Key.HasValue Then
            strWhere = strWhere & "AND PM_Key = " & miEntity.PM_Key.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_Observacion) = False Then
            strWhere = "AND Fact_Observacion = '" & miEntity.Fact_Observacion.ToString & "' "

        End If

        If Not miEntity.Fact_FechaAlta = Date.MinValue Then
            strWhere = strWhere & "AND fact_fechaalta = " & miEntity.Fact_FechaAlta.ToString & " "

        End If

        If Not miEntity.Fact_FechaCancelacion = Date.MinValue Then
            strWhere = strWhere & "AND fact_FechaCancelacion = " & miEntity.Fact_FechaCancelacion.ToString & " "

        End If

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_EntFacturas")

        ds = GetDataSet(strSql)


        Return GetLista(ds)

    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * EntFacturas")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * EntFacturas Where Fact_Key = " & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim miEntity As Entities.EntFacturas = Nothing
        miEntity = CType(mEntityObject, Entities.EntFacturas)
        Dim strSql As String = ""
        strSql = "Insert Into EntFacturas (Sys_ROLE_Description,Sys_Role_Enabled) Values ('" & miEntity.SYS_ROLE_Descripcion & "', " & miEntity.SYS_ROLE_Enabled.ToString & ")"

        Return ExecuteInsertQuery(strSql)
    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntFacturas = Nothing
        miEntity = CType(mEntityObject, Entities.EntFacturas)

        If miEntity.Fact_Key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If

        If miEntity.Pac_key.HasValue Then
            strSql = ", Pac_key = '" & miEntity.Pac_key.ToString & "' "
        End If

        If Not miEntity.fact_fechafactura = Date.MinValue Then
            strSql = ", fact_fechafactura = '" & miEntity.fact_fechafactura & "' "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_Tipo) = False Then
            strSql = ", Fact_Tipo = '" & miEntity.Fact_Tipo & "' "

        End If

        If miEntity.Fact_Monto.HasValue Then
            strSql = ", Fact_Monto = " & miEntity.Fact_Monto.ToString & " "

        End If

        If miEntity.Fact_TipoDoc.HasValue Then
            strSql = ", Fact_TipoDoc = " & miEntity.Fact_TipoDoc.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_TipoDoc) = False Then
            strSql = ", Fact_TipoDoc = '" & miEntity.Fact_TipoDoc.ToString & "' "

        End If

        If miEntity.Fact_Cantidad.HasValue Then
            strSql = ", Fact_Cantidad = " & miEntity.Fact_Cantidad.ToString & " "

        End If

        If miEntity.PM_Key.HasValue Then
            strSql = ", PM_Key = " & miEntity.PM_Key.ToString & " "

        End If

        If String.IsNullOrEmpty(miEntity.Fact_Observacion) = False Then
            strSql = ", Fact_Observacion = '" & miEntity.Fact_Observacion.ToString & "' "

        End If

        If Not miEntity.Fact_FechaAlta = Date.MinValue Then
            strSql = ", fact_fechaalta = " & miEntity.Fact_FechaAlta.ToString & " "

        End If

        If Not miEntity.Fact_FechaCancelacion = Date.MinValue Then
            strSql = ", fact_FechaCancelacion = " & miEntity.Fact_FechaCancelacion.ToString & " "

        End If
        strSql = strSql.Remove(0, 1)

        strSql = "Update EntFacturas Set " & strSql & " Where Fact_Key = " & miEntity.Fact_Key.ToString

        Return ExecuteSQLNonQuery(strSql)

    End Function
End Class

