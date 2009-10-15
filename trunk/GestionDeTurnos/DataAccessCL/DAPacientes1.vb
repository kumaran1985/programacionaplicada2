Public Class DAPacientes1
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys





    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPacientes

        miEntity.LOCA_Key = mDataTable("LOCA_Key")
        miEntity.Pac_Apellidos = mDataTable("Pac_Apellidos")
        miEntity.Pac_Calle = mDataTable("Pac_Calle")
        miEntity.Pac_Celular = mDataTable("Pac_Celular")
        miEntity.Pac_Email = mDataTable("Pac_Email")
        miEntity.Pac_EstadoCivil = mDataTable("Pac_EstadoCivil")
        miEntity.Pac_FechaAlta = mDataTable("Pac_FechaAlta")
        miEntity.Pac_FechaCancelacion = mDataTable("Pac_FechaCancelacion")
        miEntity.Pac_FechaNacimiento = mDataTable("Pac_FechaNacimiento")
        miEntity.Pac_key = mDataTable("Pac_key")
        miEntity.Pac_Nacionalidad = mDataTable("Pac_Nacionalidad")
        miEntity.Pac_Nombres = mDataTable("Pac_Nombres")
        miEntity.Pac_NumeroDoc = mDataTable("Pac_NumeroDoc")
        miEntity.Pac_NumeroExt = mDataTable("Pac_NumeroExt")
        miEntity.Pac_NumeroInt = mDataTable("Pac_NumeroInt")
        miEntity.Pac_Ocupacion = mDataTable("Pac_Ocupacion")
        miEntity.Pac_Sexo = mDataTable("Pac_Sexo")
        miEntity.Pac_Telefonos = mDataTable("Pac_Telefonos")
        miEntity.TDOC_Key = mDataTable("TDOC_Key")

        Return miEntity

    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntPacientes)

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
        Dim miEntity As Entities.EntPacientes = Nothing
        miEntity = CType(mEntityObject, Entities.EntPacientes)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From Pacientes"

        If miEntity.LOCA_Key.HasValue Then
            strWhere = strWhere & "AND LOCA_Key = " & miEntity.LOCA_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Apellidos) = False Then
            strWhere = "AND Pac_Apellidos = '" & miEntity.Pac_Apellidos & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Calle) = False Then
            strWhere = "AND Pac_Calle = '" & miEntity.Pac_Calle & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Celular) = False Then
            strWhere = "AND Pac_Celular = '" & miEntity.Pac_Celular & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Email) = False Then
            strWhere = "AND Pac_Email = '" & miEntity.Pac_Email & "' "
        End If
        
        If String.IsNullOrEmpty(miEntity.Pac_EstadoCivil) = False Then
            strWhere = "AND Pac_EstadoCivil = '" & miEntity.Pac_EstadoCivil & "' "
        End If

        If Not miEntity.Pac_FechaAlta = Date.MinValue Then
            strWhere = "AND Pac_FechaAlta = '" & miEntity.Pac_FechaAlta & "' "
        End If

        If Not miEntity.Pac_FechaCancelacion = Date.MinValue Then
            strWhere = "AND Pac_FechaCancelacion = '" & miEntity.Pac_FechaCancelacion & "' "
        End If

        If Not miEntity.Pac_FechaNacimiento = Date.MinValue Then
            strWhere = "AND Pac_FechaNacimiento = '" & miEntity.Pac_FechaNacimiento & "' "
        End If

        If miEntity.Pac_key.HasValue Then
            strWhere = strWhere & "AND Pac_key = " & miEntity.Pac_key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Nacionalidad) = False Then
            strWhere = "AND Pac_Nacionalidad = '" & miEntity.Pac_Nacionalidad & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Nombres) = False Then
            strWhere = "AND Pac_Nombres = '" & miEntity.Pac_Nombres & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroDoc) = False Then
            strWhere = "AND Pac_NumeroDoc = '" & miEntity.Pac_NumeroDoc & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroExt) = False Then
            strWhere = "AND Pac_NumeroExt = '" & miEntity.Pac_NumeroExt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroInt) = False Then
            strWhere = "AND Pac_NumeroInt = '" & miEntity.Pac_NumeroInt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroInt) = False Then
            strWhere = "AND Pac_NumeroInt = '" & miEntity.Pac_NumeroInt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Ocupacion) = False Then
            strWhere = "AND Pac_Ocupacion = '" & miEntity.Pac_Ocupacion & "' "
        End If

        If miEntity.Pac_Sexo.HasValue Then
            strWhere = strWhere & "AND Pac_Sexo = " & miEntity.Pac_Sexo.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Telefonos) = False Then
            strWhere = "AND Pac_Telefonos = '" & miEntity.Pac_Telefonos & "' "
        End If

        If miEntity.TDOC_Key.HasValue Then
            strWhere = strWhere & "AND TDOC_Key = " & miEntity.TDOC_Key.ToString & " "
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
        strSQL = "Delete from Pacientes Where Pac_key = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * From Pacientes Where Pac_key = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("Pacientes")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_Pacientes")
        ds.Tables.Add(dt)

        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntPacientes = Nothing
        miEntity = CType(mEntityObject, Entities.EntPacientes)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From Pacientes "

        If miEntity.LOCA_Key.HasValue Then
            strWhere = strWhere & "AND LOCA_Key = " & miEntity.LOCA_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Apellidos) = False Then
            strWhere = "AND Pac_Apellidos = '" & miEntity.Pac_Apellidos & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Calle) = False Then
            strWhere = "AND Pac_Calle = '" & miEntity.Pac_Calle & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Celular) = False Then
            strWhere = "AND Pac_Celular = '" & miEntity.Pac_Celular & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Email) = False Then
            strWhere = "AND Pac_Email = '" & miEntity.Pac_Email & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_EstadoCivil) = False Then
            strWhere = "AND Pac_EstadoCivil = '" & miEntity.Pac_EstadoCivil & "' "
        End If

        If Not miEntity.Pac_FechaAlta = Date.MinValue Then
            strWhere = "AND Pac_FechaAlta = '" & miEntity.Pac_FechaAlta & "' "
        End If

        If Not miEntity.Pac_FechaCancelacion = Date.MinValue Then
            strWhere = "AND Pac_FechaCancelacion = '" & miEntity.Pac_FechaCancelacion & "' "
        End If

        If Not miEntity.Pac_FechaNacimiento = Date.MinValue Then
            strWhere = "AND Pac_FechaNacimiento = '" & miEntity.Pac_FechaNacimiento & "' "
        End If

        If miEntity.Pac_key.HasValue Then
            strWhere = strWhere & "AND Pac_key = " & miEntity.Pac_key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Nacionalidad) = False Then
            strWhere = "AND Pac_Nacionalidad = '" & miEntity.Pac_Nacionalidad & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Nombres) = False Then
            strWhere = "AND Pac_Nombres = '" & miEntity.Pac_Nombres & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroDoc) = False Then
            strWhere = "AND Pac_NumeroDoc = '" & miEntity.Pac_NumeroDoc & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroExt) = False Then
            strWhere = "AND Pac_NumeroExt = '" & miEntity.Pac_NumeroExt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroInt) = False Then
            strWhere = "AND Pac_NumeroInt = '" & miEntity.Pac_NumeroInt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroInt) = False Then
            strWhere = "AND Pac_NumeroInt = '" & miEntity.Pac_NumeroInt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Ocupacion) = False Then
            strWhere = "AND Pac_Ocupacion = '" & miEntity.Pac_Ocupacion & "' "
        End If

        If miEntity.Pac_Sexo.HasValue Then
            strWhere = strWhere & "AND Pac_Sexo = " & miEntity.Pac_Sexo.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Telefonos) = False Then
            strWhere = "AND Pac_Telefonos = '" & miEntity.Pac_Telefonos & "' "
        End If

        If miEntity.TDOC_Key.HasValue Then
            strWhere = strWhere & "AND TDOC_Key = " & miEntity.TDOC_Key.ToString & " "
        End If

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_Pacientes")

        ds = GetDataSet(strSql)


        Return GetLista(ds)

    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * Pacientes")
        Return dt

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * Pacientes Where Pac_key = " & mKey)
        Return dt

    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntPacientes = Nothing
        Dim strWhere As String = ""

        miEntity = CType(mEntityObject, Entities.EntPacientes)

        If miEntity.Pac_key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If

        If miEntity.LOCA_Key.HasValue Then
            strWhere = strWhere & "AND LOCA_Key = " & miEntity.LOCA_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Apellidos) = False Then
            strWhere = "AND Pac_Apellidos = '" & miEntity.Pac_Apellidos & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Calle) = False Then
            strWhere = "AND Pac_Calle = '" & miEntity.Pac_Calle & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Celular) = False Then
            strWhere = "AND Pac_Celular = '" & miEntity.Pac_Celular & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Email) = False Then
            strWhere = "AND Pac_Email = '" & miEntity.Pac_Email & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_EstadoCivil) = False Then
            strWhere = "AND Pac_EstadoCivil = '" & miEntity.Pac_EstadoCivil & "' "
        End If

        If Not miEntity.Pac_FechaAlta = Date.MinValue Then
            strWhere = "AND Pac_FechaAlta = '" & miEntity.Pac_FechaAlta & "' "
        End If

        If Not miEntity.Pac_FechaCancelacion = Date.MinValue Then
            strWhere = "AND Pac_FechaCancelacion = '" & miEntity.Pac_FechaCancelacion & "' "
        End If

        If Not miEntity.Pac_FechaNacimiento = Date.MinValue Then
            strWhere = "AND Pac_FechaNacimiento = '" & miEntity.Pac_FechaNacimiento & "' "
        End If

        If miEntity.Pac_key.HasValue Then
            strWhere = strWhere & "AND Pac_key = " & miEntity.Pac_key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Nacionalidad) = False Then
            strWhere = "AND Pac_Nacionalidad = '" & miEntity.Pac_Nacionalidad & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Nombres) = False Then
            strWhere = "AND Pac_Nombres = '" & miEntity.Pac_Nombres & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroDoc) = False Then
            strWhere = "AND Pac_NumeroDoc = '" & miEntity.Pac_NumeroDoc & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroExt) = False Then
            strWhere = "AND Pac_NumeroExt = '" & miEntity.Pac_NumeroExt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroInt) = False Then
            strWhere = "AND Pac_NumeroInt = '" & miEntity.Pac_NumeroInt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_NumeroInt) = False Then
            strWhere = "AND Pac_NumeroInt = '" & miEntity.Pac_NumeroInt & "' "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Ocupacion) = False Then
            strWhere = "AND Pac_Ocupacion = '" & miEntity.Pac_Ocupacion & "' "
        End If

        If miEntity.Pac_Sexo.HasValue Then
            strWhere = strWhere & "AND Pac_Sexo = " & miEntity.Pac_Sexo.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.Pac_Telefonos) = False Then
            strWhere = "AND Pac_Telefonos = '" & miEntity.Pac_Telefonos & "' "
        End If

        If miEntity.TDOC_Key.HasValue Then
            strWhere = strWhere & "AND TDOC_Key = " & miEntity.TDOC_Key.ToString & " "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update Pacientes Set " & strSql & " Where Pac_key = " & miEntity.Pac_key.ToString

        Return ExecuteSQLNonQuery(strSql)

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim miEntity As Entities.EntPacientes = Nothing
        miEntity = CType(mEntityObject, Entities.EntPacientes)
        Dim strSql As String = ""
        strSql = "Insert Into Pacientes (TDOC_Key,Pac_NumeroDoc,Pac_Nombres,Pac_Apellidos,Pac_Calle,Pac_NumeroExt,Pac_NumeroInt,LOCA_Key,Pac_Telefonos,Pac_Celular,Pac_Email,Pac_FechaNacimiento,Pac_FechaAlta,Pac_FechaCancelacion,Pac_Sexo,Pac_EstadoCivil,Pac_Ocupacion,Pac_Nacionalidad) Values (" & miEntity.TDOC_Key.ToString & ", '" & miEntity.Pac_NumeroDoc & "', '" & miEntity.Pac_Nombres & "', '" & miEntity.Pac_Apellidos & "', '" & miEntity.Pac_Calle & "', '" & miEntity.Pac_NumeroExt & "', '" & miEntity.Pac_NumeroInt & "', " & miEntity.LOCA_Key.ToString & ", '" & miEntity.Pac_Telefonos & "', '" & miEntity.Pac_Celular & "', '" & miEntity.Pac_Email & "', '" & miEntity.Pac_FechaNacimiento & "', '" & miEntity.Pac_FechaAlta & "', '" & miEntity.Pac_FechaCancelacion & "', " & miEntity.Pac_Sexo.ToString & ", '" & miEntity.Pac_EstadoCivil & "', '" & miEntity.Pac_Ocupacion & "', '" & miEntity.Pac_Nacionalidad & "')"

        Return ExecuteInsertQuery(strSql)
    End Function
End Class
