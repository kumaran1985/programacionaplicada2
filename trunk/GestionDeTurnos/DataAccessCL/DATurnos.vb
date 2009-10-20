Public Class DATurnos
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys



    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntTurnos
        miEntity.Turno_Estado = mDataTable("Turno_Estado")
        miEntity.turno_fecha = mDataTable("turno_fecha")
        miEntity.Turno_FechaAlta = mDataTable("Turno_FechaAlta")
        miEntity.Turno_FechaCancelacion = mDataTable("Turno_FechaCancelacion")
        miEntity.turno_hora = mDataTable("turno_hora")
        miEntity.Pac_Key = mDataTable("Pac_Key")
        miEntity.MOVI_Key = mDataTable("MOVI_Key")
        miEntity.Med_Key = mDataTable("Med_Key")
        miEntity.turno_key = mDataTable("Turno_Key")

        Return miEntity

    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntTurnos)
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

        Dim miEntity As Entities.EntTurnos = Nothing
        miEntity = CType(mEntityObject, Entities.EntTurnos)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From turnos "

        If String.IsNullOrEmpty(miEntity.turno_fecha) = False Then
            strWhere = "AND turno_fecha =#" & miEntity.turno_fecha & "# "
        End If

        If miEntity.turno_hora.ToString Then
            strWhere = strWhere & "AND turno_hora = " & miEntity.turno_hora.ToString & " "
        End If

        If miEntity.turno_fecha.ToString Then
            strWhere = strWhere & "AND Pac_Key = " & miEntity.turno_fecha.ToString & " "
        End If

        If miEntity.Med_Key.ToString Then
            strWhere = strWhere & "AND Med_Key = " & miEntity.Med_Key.ToString & " "
        End If

        If miEntity.Pac_Key.ToString Then
            strWhere = strWhere & "AND Pac_Key = " & miEntity.Pac_Key.ToString & " "
        End If

        If miEntity.Turno_Estado.ToString Then
            strWhere = strWhere & "AND Turno_Estado = " & miEntity.Turno_Estado.ToString & " "
        End If

        If miEntity.Turno_FechaAlta.ToString Then
            strWhere = strWhere & "AND Turno_FechaAlta = #" & miEntity.Turno_FechaAlta.ToString & " #"
        End If

        If miEntity.Turno_FechaCancelacion.ToString Then
            strWhere = strWhere & "AND Turno_FechaCancelacion = #" & miEntity.Turno_FechaCancelacion.ToString & "# "
        End If

        If miEntity.MOVI_Key.ToString Then
            strWhere = strWhere & "AND MOVI_Key = " & miEntity.MOVI_Key.ToString & " "
        End If

        If miEntity.turno_key.ToString Then
            strWhere = strWhere & "AND turno_key = " & miEntity.turno_key.ToString & " "
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
        strSQL = "Delete from turno Where turno_key = " & mKey
        Return ExecuteSQLNonQuery(strSQL)

    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity


        Dim dt As DataTable
        dt = GetDataTable("Select * From turnos Where turno_key = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity


        Dim dt As DataTable = GetAllFromTable("turnos")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_turnos")
        ds.Tables.Add(dt)

        Return GetLista(ds)


    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

        Dim miEntity As Entities.EntTurnos = Nothing
        miEntity = CType(mEntityObject, Entities.EntTurnos)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From turnos "

        If String.IsNullOrEmpty(miEntity.turno_key) = True Then
            strWhere = strWhere & " AND turno_key  = " & miEntity.turno_key.ToString & " "
        End If

        If miEntity.turno_hora Then
            strWhere = strWhere & "AND turno_hora = " & miEntity.turno_hora.ToString & " "
        End If

        If miEntity.Pac_Key Then
            strWhere = strWhere & "AND Pac_Key = " & miEntity.Pac_Key.ToString & " "
        End If


        If miEntity.Med_Key Then
            strWhere = strWhere & "AND Med_Key = " & miEntity.Med_Key.ToString & " "
        End If

        If miEntity.Turno_Estado Then
            strWhere = strWhere & "AND Turno_Estado = " & miEntity.Turno_Estado.ToString & " "
        End If


        If Not miEntity.Turno_FechaAlta = Date.MinValue Then
            strWhere = strWhere & "AND Turno_FechaAlta = " & miEntity.Turno_FechaAlta.ToString & " "
        End If

        If Not miEntity.Turno_FechaCancelacion = Date.MinValue Then
            strWhere = strWhere & "AND turno_FechaCancelacion = " & miEntity.Turno_FechaCancelacion.ToString & " "
        End If

        If miEntity.MOVI_Key Then
            strWhere = strWhere & "AND MOVI_Key = " & miEntity.MOVI_Key.ToString & " "
        End If

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_turnos")

        ds = GetDataSet(strSql)


        Return GetLista(ds)


    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable


        Dim dt As DataTable
        dt = GetDataTable("Select * turnos")
        Return dt

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable


        Dim dt As DataTable
        dt = GetDataTable("Select * turnos Where turno_key = " & mKey)
        Return dt


    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity



        Dim miEntity As Entities.EntTurnos = Nothing
        miEntity = CType(mEntityObject, Entities.EntTurnos)
        Dim strSql As String = ""
        strSql = "Insert Into turnos (turno_fecha,turno_hora,Pac_Key,Med_Key,Turno_Estado,Turno_FechaAlta,turno_FechaCancelacion,MOVI_Key) Values ('" & miEntity.turno_fecha & "', " & miEntity.turno_hora.ToString & "," & miEntity.Pac_Key.ToString & "," & miEntity.Med_Key.ToString & "  " & miEntity.Turno_Estado.ToString & "," & miEntity.Turno_FechaAlta.ToString & " ," & miEntity.Turno_FechaCancelacion.ToString & "," & miEntity.MOVI_Key.ToString & "       )"

        Return ExecuteInsertQuery(strSql)


    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity

        Dim strSql As String = ""
        Dim miEntity As Entities.EntTurnos = Nothing
        miEntity = CType(mEntityObject, Entities.EntTurnos)

        If miEntity.turno_key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If


        If String.IsNullOrEmpty(miEntity.turno_fecha) = False Then
            strSql = ", turno_fecha = '" & miEntity.turno_fecha & "' "
        End If

        If String.IsNullOrEmpty(miEntity.turno_hora) = False Then
            strSql = ", turno_hora = '" & miEntity.turno_hora & "' "
        End If


        If String.IsNullOrEmpty(miEntity.Pac_Key) = False Then
            strSql = ", Pac_Key = " & miEntity.Pac_Key.ToString & ""
        End If



        If String.IsNullOrEmpty(miEntity.Med_Key) = False Then
            strSql = " Med_Key = '" & miEntity.Med_Key.ToString & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Turno_Estado) = False Then
            strSql = ", Turno_Estado = '" & miEntity.Turno_Estado.ToString & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Turno_FechaAlta) = False Then
            strSql = ", turno_FechaAlta = '" & miEntity.Turno_FechaAlta & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Turno_FechaCancelacion) = False Then
            strSql = ", Turno_FechaCancelacion = '" & miEntity.Turno_FechaCancelacion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.MOVI_Key) = False Then
            strSql = ", MOVI_Key = '" & miEntity.MOVI_Key.ToString & "' "
        End If


        If miEntity.turno_fecha.ToString Then
            strSql = strSql & ", turno_fecha = " & miEntity.turno_fecha.ToString & " "
        End If

        If miEntity.turno_hora.ToString Then
            strSql = strSql & ", turno_hora = " & miEntity.turno_hora.ToString & " "
        End If

        If miEntity.Pac_Key.HasValue Then
            strSql = strSql & ", Pac_Key = " & miEntity.Pac_Key.ToString & " "
        End If

        If miEntity.Med_Key.HasValue Then
            strSql = strSql & ", Med_Key = " & miEntity.Med_Key.ToString & " "
        End If

        If miEntity.Turno_Estado.HasValue Then
            strSql = strSql & ", Turno_Estado = " & miEntity.Turno_Estado.ToString & " "
        End If

        If miEntity.Turno_FechaAlta.ToString Then
            strSql = strSql & ", turno_FechaAlta = " & miEntity.Turno_FechaAlta.ToString & " "
        End If

        If miEntity.Turno_FechaCancelacion.ToString Then
            strSql = strSql & ", Turno_FechaCancelacion = " & miEntity.Turno_FechaCancelacion.ToString & " "
        End If

        If miEntity.MOVI_Key.ToString Then
            strSql = strSql & ", MOVI_Key = " & miEntity.MOVI_Key.ToString & " "
        End If

        

        strSql = strSql.Remove(0, 1)

        strSql = "Update turno Set " & strSql & " Where turno_key = " & miEntity.turno_key.ToString




        Return ExecuteSQLNonQuery(strSql)

    End Function
End Class

