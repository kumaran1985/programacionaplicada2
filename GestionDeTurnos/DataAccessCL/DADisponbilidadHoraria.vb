
Public Class DADisponbilidadHoraria
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys

    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntDisponibilidadHoraria


        miEntity.DSPH_Key = mDataTable("DSPH_KEY _Description")
        miEntity.Med_Key = mDataTable("DSPH_KEY_Enabled")
        miEntity.DSPH_DiaSemana = mDataTable("DSPH_DIASEMANA_KEY")
        miEntity.DSPH_Duracion = ("DSPH_DURACION")
        miEntity.DSPH_HoraInicio = ("DSPH_HORAINICIO")
        miEntity.DSPH_HoraFin = ("DSPH_HORAFIN")
        miEntity.DSPH_FechaIni = ("DSPH_FECHAINI")
        miEntity.DSPH_FechaFin = ("DSPH_FECHAFIN")
        miEntity.DSPH_Novedades = ("DSPH_NOVEDADES")

        Return miEntity

    End Function



    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista
        Dim ListOfEntity As New List(Of Entities.EntDisponibilidadHoraria)

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
        Dim miEntity As Entities.EntDisponibilidadHoraria = Nothing
        miEntity = CType(mEntityObject, Entities.EntDisponibilidadHoraria)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "DELETE FROM DisponibilidadHoraria "

        If Not IsNothing(miEntity.Med_Key) Then
            strWhere = "AND Med_Key = " & miEntity.Med_Key.ToString()
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_DiaSemana) = False Then
            strWhere = strWhere & "AND DSPH_DiaSemana = '" & miEntity.DSPH_DiaSemana & "' "
        End If

        If Not IsNothing(miEntity.DSPH_Duracion) Then
            strWhere = strWhere & "AND DSPH_Duracion = " & miEntity.DSPH_Duracion.ToString()
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_HoraInicio) = False Then
            strWhere = strWhere & "AND DSPH_HoraInicio = #" & miEntity.DSPH_HoraInicio & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_HoraFin) = False Then
            strWhere = strWhere & "AND DSPH_HoraFin = #" & miEntity.DSPH_HoraFin & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_FechaIni) = False Then
            strWhere = strWhere & "AND DSPH_FechaIni = #" & miEntity.DSPH_FechaIni & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_FechaFin) = False Then
            strWhere = strWhere & "AND DSPH_FechaFin = #" & miEntity.DSPH_FechaFin & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_Novedades) = False Then
            strWhere = strWhere & "AND DSPH_Novedades = '" & miEntity.DSPH_Novedades & "' "
        End If

        'Valido si el WHERE contiene algo
        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " WHERE " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Return ExecuteSQLNonQuery(strSql)
    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity
        Dim strSQL As String
        strSQL = "DELETE FROM DisponibilidadHoraria WHERE DSPH_Key = " & mKey

        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("SELECT * FROM DisponibilidadHoraria WHERE DSPH_Key = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))
    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("DisponibilidadHoraria")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_DisponibilidadHoraria")
        ds.Tables.Add(dt)

        Return GetLista(ds)
    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntDisponibilidadHoraria = Nothing
        miEntity = CType(mEntityObject, Entities.EntDisponibilidadHoraria)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "SELECT * FROM DisponibilidadHoraria "

        If Not IsNothing(miEntity.Med_Key) Then
            strWhere = "AND Med_Key = " & miEntity.Med_Key.ToString()
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_DiaSemana) = False Then
            strWhere = strWhere & "AND DSPH_DiaSemana = '" & miEntity.DSPH_DiaSemana & "' "
        End If

        If Not IsNothing(miEntity.DSPH_Duracion) Then
            strWhere = strWhere & "AND DSPH_Duracion = " & miEntity.DSPH_Duracion.ToString()
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_HoraInicio) = False Then
            strWhere = strWhere & "AND DSPH_HoraInicio = #" & miEntity.DSPH_HoraInicio & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_HoraFin) = False Then
            strWhere = strWhere & "AND DSPH_HoraFin = #" & miEntity.DSPH_HoraFin & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_FechaIni) = False Then
            strWhere = strWhere & "AND DSPH_FechaIni = #" & miEntity.DSPH_FechaIni & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_FechaFin) = False Then
            strWhere = strWhere & "AND DSPH_FechaFin = #" & miEntity.DSPH_FechaFin & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_Novedades) = False Then
            strWhere = strWhere & "AND DSPH_Novedades = '" & miEntity.DSPH_Novedades & "' "
        End If

        'Valido si el WHERE contiene algo
        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " WHERE " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_DisponibilidadHoraria")

        ds = GetDataSet(strSql)


        Return GetLista(ds)
    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("SELECT * FROM DisponibilidadHoraria")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("SELECT * FROM DisponibilidadHoraria WHERE DSPH_Key = " & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim miEntity As Entities.EntDisponibilidadHoraria = Nothing
        miEntity = CType(mEntityObject, Entities.EntDisponibilidadHoraria)

        Dim strSql As String = ""
        strSql = "INSERT INTO DisponibilidadHoraria (Med_Key, DSPH_DiaSemana, DSPH_Duracion, DSPH_HoraInicio, DSPH_HoraFin, DSPH_FechaIni, DSPH_FechaFin, DSPH_Novedades) VALUES " & _
            "(" & miEntity.Med_Key.GetValueOrDefault().ToString() & ", '" & miEntity.DSPH_DiaSemana & "', " & miEntity.DSPH_Duracion.GetValueOrDefault().ToString() & ", #" & miEntity.DSPH_HoraInicio & _
            "#, #" & miEntity.DSPH_HoraFin & "#, #" & miEntity.DSPH_FechaIni & "#, #" & miEntity.DSPH_FechaFin & "#, '" & miEntity.DSPH_Novedades & "')"

        Return ExecuteInsertQuery(strSql)
    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntDisponibilidadHoraria = Nothing
        miEntity = CType(mEntityObject, Entities.EntDisponibilidadHoraria)

        If miEntity.DSPH_Key.HasValue = False Then
            Throw New Exception("No se ha especificado la clave principal")
        End If

        If Not IsNothing(miEntity.Med_Key) Then
            strSql = ", Med_Key = " & miEntity.Med_Key.ToString()
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_DiaSemana) = False Then
            strSql = strSql & ", DSPH_DiaSemana = '" & miEntity.DSPH_DiaSemana & "' "
        End If

        If Not IsNothing(miEntity.DSPH_Duracion) Then
            strSql = strSql & ", DSPH_Duracion = " & miEntity.DSPH_Duracion.ToString()
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_HoraInicio) = False Then
            strSql = strSql & ", DSPH_HoraInicio = #" & miEntity.DSPH_HoraInicio & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_HoraFin) = False Then
            strSql = strSql & ", DSPH_HoraFin = #" & miEntity.DSPH_HoraFin & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_FechaIni) = False Then
            strSql = strSql & ", DSPH_FechaIni = #" & miEntity.DSPH_FechaIni & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_FechaFin) = False Then
            strSql = strSql & ", DSPH_FechaFin = #" & miEntity.DSPH_FechaFin & "# "
        End If

        If String.IsNullOrEmpty(miEntity.DSPH_Novedades) = False Then
            strSql = strSql & ", DSPH_Novedades = #" & miEntity.DSPH_Novedades & "# "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "UPDATE DisponibilidadHoraria SET " & strSql & " WHERE DSPH_Key = " & miEntity.DSPH_Key.ToString()

        Return ExecuteSQLNonQuery(strSql)
    End Function
End Class
