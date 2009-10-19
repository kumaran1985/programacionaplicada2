
Public Class DADetalleHistoriaClinica
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntDetalleHistoriaClinica
        miEntity.Deta_key = DBVal(mDataTable("Deta_Key"))
        miEntity.Pac_key = DBVal(mDataTable("Pac_key"))
        miEntity.Deta_FechaConsulta = DBVal(mDataTable("Deta_FechaConsulta"))
        miEntity.Deta_Especialidad = DBVal(mDataTable("Deta_Especialidad"))
        miEntity.Deta_NombresMedico = DBVal(mDataTable("Deta_NombresMedico"))
        miEntity.Deta_ApellidosMedico = DBVal(mDataTable("Deta_ApellidosMedico"))
        miEntity.Deta_Descripcion = DBVal(mDataTable("Deta_Descripcion"))
        miEntity.Deta_Observacion = DBVal(mDataTable("Deta_Observacion"))
        miEntity.Deta_Diagnostico = DBVal(mDataTable("Deta_Diagnostico"))
        miEntity.Deta_Medicacion = DBVal(mDataTable("Deta_Medicacion"))
        miEntity.Deta_Tratamiento = DBVal(mDataTable("Deta_Tratamiento"))
        miEntity.Deta_DuracionTratamiento = DBVal(mDataTable("Deta_DuracionTratamiento"))


        Return miEntity


    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntDetalleHistoriaClinica)

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

        Dim miEntity As Entities.EntDetalleHistoriaClinica = Nothing
        miEntity = CType(mEntityObject, Entities.EntDetalleHistoriaClinica)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From EntDetalleHistoriaClinica"

        If miEntity.Deta_key.HasValue Then
            strWhere = strWhere & "AND Deta_Key" & miEntity.Deta_key.ToString & " "
        End If

        If miEntity.Pac_key.HasValue Then
            strWhere = strWhere & "AND Pac_key = " & miEntity.Pac_key.ToString & " "
        End If

        If Not miEntity.Deta_FechaConsulta = Date.MinValue Then
            strWhere = "AND Deta_FechaConsulta = '" & miEntity.Deta_FechaConsulta & "' "
        End If


        If miEntity.Deta_Especialidad.HasValue Then
            strWhere = strWhere & "AND Deta_Especialidad = " & miEntity.Deta_Especialidad.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_NombresMedico) = False Then
            strWhere = "AND Deta_NombresMedico = '" & miEntity.Deta_NombresMedico & "' "
        End If


        If String.IsNullOrEmpty(miEntity.Deta_ApellidosMedico) = False Then
            strWhere = "AND Deta_ApellidosMedico = '" & miEntity.Deta_ApellidosMedico & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Descripcion) = False Then
            strWhere = "AND Deta_Descripcion = '" & miEntity.Deta_Descripcion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Observacion) = False Then
            strWhere = "AND Deta_Observacion = '" & miEntity.Deta_Observacion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Diagnostico) = False Then
            strWhere = "AND Deta_Diagnostico = '" & miEntity.Deta_Diagnostico & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Medicacion) = False Then
            strWhere = "AND Deta_Medicacion  = '" & miEntity.Deta_Medicacion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Tratamiento) = False Then
            strWhere = "AND Deta_Tratamiento = '" & miEntity.Deta_Tratamiento & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_DuracionTratamiento) = False Then
            strWhere = "AND Deta_DuracionTratamiento = '" & miEntity.Deta_DuracionTratamiento & "' "
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
        strSQL = "Delete from DetalleHistoriaClinica Where  Deta_key= " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function



    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity

        Dim dt As DataTable
        dt = GetDataTable("Select * From DetalleHistoriaClinica Where Deta_key = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

        Dim dt As DataTable = GetAllFromTable("DetalleHistoriaClinica")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_DetalleHistoriaClinica")
        ds.Tables.Add(dt)

        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntDetalleHistoriaClinica = Nothing
        miEntity = CType(mEntityObject, Entities.EntDetalleHistoriaClinica)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From DetalleHistoriaClinica "

        If miEntity.Deta_key.HasValue Then
            strWhere = strWhere & "AND Deta_key = " & miEntity.Deta_key.ToString & " "
        End If

        If miEntity.Pac_key.HasValue Then
            strWhere = strWhere & "AND Pac_key = " & miEntity.Pac_key.ToString & " "
        End If

        If Not miEntity.Deta_FechaConsulta = Date.MinValue Then
            strWhere = "AND Deta_FechaConsulta = '" & miEntity.Deta_FechaConsulta.ToString & "' "
        End If


        If miEntity.Deta_Especialidad.HasValue Then
            strWhere = strWhere & "AND Deta_Especialidad = " & miEntity.Deta_Especialidad.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_NombresMedico) = False Then
            strWhere = "AND Deta_NombresMedico = '" & miEntity.Deta_NombresMedico & "' "
        End If


        If String.IsNullOrEmpty(miEntity.Deta_ApellidosMedico) = False Then
            strWhere = "AND Deta_ApellidosMedico = '" & miEntity.Deta_ApellidosMedico & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Descripcion) = False Then
            strWhere = "AND Deta_Descripcion = '" & miEntity.Deta_Descripcion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Observacion) = False Then
            strWhere = "AND Deta_Observacion = '" & miEntity.Deta_Observacion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Diagnostico) = False Then
            strWhere = "AND Deta_Diagnostico = '" & miEntity.Deta_Diagnostico & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Medicacion) = False Then
            strWhere = "AND Deta_Medicacion  = '" & miEntity.Deta_Medicacion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Tratamiento) = False Then
            strWhere = "AND Deta_Tratamiento = '" & miEntity.Deta_Tratamiento & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_DuracionTratamiento) = False Then
            strWhere = "AND Deta_DuracionTratamiento = '" & miEntity.Deta_DuracionTratamiento & "' "
        End If

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_DetalleHistoriaClinica")

        ds = GetDataSet(strSql)


        Return GetLista(ds)




    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

        Dim dt As DataTable
        dt = GetDataTable("Select * DetalleHistoriaClinica")
        Return dt

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

        Dim dt As DataTable
        dt = GetDataTable("Select * DetalleHistoriaClinica Where Deta_key = " & mKey)
        Return dt

    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity

        Dim miEntity As Entities.EntDetalleHistoriaClinica = Nothing
        miEntity = CType(mEntityObject, Entities.EntDetalleHistoriaClinica)
        Dim strSql As String = ""
        strSql = "Insert Into DetalleHistoriaClinica (Pac_key, Deta_FechaConsulta, Deta_Especialidad, Deta_NombresMedico, Deta_ApellidosMedico, Deta_Descripcion, Deta_Observacion, Deta_Diagnostico, Deta_Medicacion, Deta_Tratamiento, Deta_DuracionTratamiento) Values ('" & miEntity.Pac_key.ToString & "', " & miEntity.Deta_FechaConsulta.ToString & " " & miEntity.Deta_Especialidad.ToString & "," & miEntity.Deta_NombresMedico.ToString & "," & miEntity.Deta_ApellidosMedico & "," & miEntity.Deta_Descripcion & "," & miEntity.Deta_Observacion & " , " & miEntity.Deta_Diagnostico & " , " & miEntity.Deta_Medicacion & " , " & miEntity.Deta_Tratamiento & "  , " & miEntity.Deta_DuracionTratamiento & ")"


        Return ExecuteInsertQuery(strSql)


    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity

        Dim strSql As String = ""
        Dim miEntity As Entities.EntDetalleHistoriaClinica = Nothing
        miEntity = CType(mEntityObject, Entities.EntDetalleHistoriaClinica)

        If miEntity.Deta_key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If

        If miEntity.Pac_key.HasValue Then
            strSql = strSql & ", Deta_Especialidad = " & miEntity.Deta_Especialidad.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_FechaConsulta) = False Then
            strSql = ", Deta_FechaConsulta = '" & miEntity.Deta_FechaConsulta & "' "
        End If

        If miEntity.Deta_Especialidad.HasValue Then
            strSql = strSql & ", Deta_Especialidad = " & miEntity.Deta_Especialidad.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_NombresMedico) = False Then
            strSql = ", Deta_NombresMedico = '" & miEntity.Deta_NombresMedico & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_ApellidosMedico) = False Then
            strSql = ", Deta_ApellidosMedico = '" & miEntity.Deta_ApellidosMedico & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Descripcion) = False Then
            strSql = ", Deta_Descripcion = '" & miEntity.Deta_Descripcion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Observacion) = False Then
            strSql = ", Deta_Observacion = '" & miEntity.Deta_Observacion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Diagnostico) = False Then
            strSql = ", Deta_Diagnostico = '" & miEntity.Deta_Diagnostico & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Medicacion) = False Then
            strSql = ", Deta_Medicacion = '" & miEntity.Deta_Tratamiento & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_Tratamiento) = False Then
            strSql = ", Deta_Tratamiento = '" & miEntity.Deta_Tratamiento & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Deta_DuracionTratamiento) = False Then
            strSql = ", Deta_DuracionTratamiento = '" & miEntity.Deta_DuracionTratamiento & "' "
        End If



        strSql = strSql.Remove(0, 1)

        strSql = "Update  Set " & strSql & " Where Pac_KEY = " & miEntity.Pac_key.ToString

        Return ExecuteSQLNonQuery(strSql)



    End Function
End Class
