Public Class DAObrasSociales
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys


    Public Function GenerarEntidad(ByVal mDataRow As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntObrasSociales


        miEntity.LOCA_Key = DBVal(mDataRow("LOCA_Key"))
        miEntity.OS_Key = DBVal(mDataRow("OS_key"))
        miEntity.OS_Nombre = DBVal(mDataRow("OS_Nombre"))
        miEntity.OS_Descripcion = DBVal(mDataRow("OS_Descripcion"))
        miEntity.OS_Calle = DBVal(mDataRow("OS_Calle"))
        miEntity.OS_NumeroExt = DBVal(mDataRow("OS_NumeroExt"))
        miEntity.OS_NumeroInt = DBVal(mDataRow("OS_NumeroInt"))
        miEntity.OS_Telefonos = DBVal(mDataRow("OS_Telefonos"))
        miEntity.OS_FechaFinConvenio = DBVal(mDataRow("OS_FechaFinConvenio"))
        miEntity.OS_FechaAlta = DBVal(mDataRow("OS_FechaAlta"))
       
        Return miEntity
    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntObrasSociales)


        If ValidatedDataSet(mDataSet) Is Nothing Then
            Return Nothing
        End If

        For Each dr As DataRow In mDataSet.Tables(0).Rows

            ListOfEntity.Add(Me.GenerarEntidad(dr))
        Next
        Return ListOfEntity


    End Function




    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

        Dim MiEntity As Entities.EntObraSocial = Nothing

        MiEntity = CType(mEntityObject, Entities.EntObrasSociales)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Delete From ObrasSociales"

        If String.IsNullOrEmpty(MiEntity.OS_Nombre) = False Then
            strwhere = "AND OS_Nombre = '" & MiEntity.OS_Nombre &
        "'"
        End If

        If MiEntity.OS_Key.HasValue Then
         strwhere = strwhere & "AND OS_Key = '" &
       MiEntity.OS_Key.ToString & "'"

        End If

        If MiEntity.LOCA_Key.HasValue Then
         strwhere = strwhere & "AND LOCA_Key = '" &
       MiEntity.LOCA_Key.ToString & "'"

        End If

        If String.IsNullOrEmpty(MiEntity.OS_Descripcion) = False Then
            strwhere = strwhere & "AND OS_Descripcion = '" & MiEntity.OS_Descripcion &
        "'"
        End If

        If String.IsNullOrEmpty(MiEntity.OS_Calle) = False Then
            strwhere = strwhere & "AND OS_Calle = '" & MiEntity.OS_Calle &
        "'"
        End If

        If String.IsNullOrEmpty(MiEntity.OS_NumeroExt) = False Then
            strwhere = strwhere & "AND OS_NumeroExt = '" & MiEntity.OS_NumeroExt &
        "'"
        End If

        If String.IsNullOrEmpty(MiEntity.OS_NumeroInt) = False Then
            strwhere = strwhere & "AND OS_NumeroInt = '" & MiEntity.OS_NumeroInt &
        "'"
        End If

        If String.IsNullOrEmpty(MiEntity.OS_Telefonos) = False Then
            strwhere = strwhere & "AND OS_Telefonos = '" & MiEntity.OS_Telefonos &
        "'"
        End If

        If String.IsNullOrEmpty(MiEntity.OS_FechaFinConvenio) = False Then
            strwhere = strwhere & "AND OS_FechaFinConvenio = '" & MiEntity.OS_FechaFinConvenio &
        "'"
        End If

        If String.IsNullOrEmpty(MiEntity.OS_FechaAlta) = False Then
            strwhere = strwhere & "AND OS_FechaAlta = '" & MiEntity.OS_FechaAlta &
        "'"
        End If

        If String.IsNullOrEmpty(MiEntity.OS_FechaCancelacion) = False Then
            strwhere = strwhere & "AND OS_FechaCancelacion = '" & MiEntity.OS_FechaCancelacion &
        "'"
        End If

        If strwhere = "" Then

            Throw New Exception("No se puede ejecutar la actualizacion porque no se han especificado todos los valores")
        Else


            strwhere = strwhere.Remove(0, 3)
        End If

        strsql = strsql & " Where" & strwhere
        Return ExecuteSQLNonQuery(strsql)

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

        Dim strsql As String = ""
        strsql = "Delete from ObrasSociales where OS_Key = " & mKey
        Return ExecuteSQLNonQuery(strsql)


    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * from ObrasSociales where OS_Key =" & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If
        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("ObrasSociales")
        If dt Is Nothing Then
            Return Nothing
        End If
        'debo crear un data set que constara solo de esta tabla, para de esta forma, poder
        'pasarlo como parametro en la función getlista
        Dim ds As New DataSet("DS_ObrasSociales")
        ds.Tables.Add(dt)
        'lo que hago es pasar a una lista, todas las filas con datos de la tabla
        'por lo cual invoco a la función getlista
        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        'vamos a realizar algo parecido en la función deletentity pero acá el objetivo, es obtener
        'todas las filas que cumpla con una condición de busqueda
        Dim miEntity As Entities.EntObrasSociales = Nothing
        'aplico ctype para cambiar la entidad que paso como parametro 
        'en este metodo, que es de tipo object a una entidad del tipo EntObrasSociales
        mientity = CType(mEntityObject, Entities.EntObrasSociales)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Select * From ObrasSociales"

        'verifico que la cadena correspondiente a OS_Nombre tenga un valor para comparar
        'es decir que en el filtro que voy a usar para traer la entidad voy a usar el campo en cuestión

        If String.IsNullOrEmpty(mientity.OS_Nombre) = False Then
            strwhere = "AND OS_Nombre = '" & mientity.OS_Nombre & "'"
        End If
        If mientity.OS_Key.HasValue Then
            strwhere = strwhere & "AND OS_Key = '" & mientity.OS_Key.ToString & " '"
        End If
        If mientity.LOCA_Key.HasValue Then
            strwhere = strwhere & "AND LOCA_Key = '" & mientity.LOCA_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.OS_Descripcion) = False Then
            strwhere = strwhere & "AND OS_Descripcion= '" & mientity.OS_Descripcion & "' "
        End If

        If String.IsNullOrEmpty(mientity.OS_Calle) = False Then
            strwhere = strwhere & "AND OS_Calle = '" & mientity.OS_Calle & "' "
        End If


        If String.IsNullOrEmpty(mientity.OS_NumeroExt) = False Then
            strwhere = strwhere & "AND OS_NumeroExt= '" & mientity.OS_NumeroExt & "' "
        End If
        If String.IsNullOrEmpty(mientity.OS_NumeroInt) = False Then
            strwhere = strwhere & "AND OS_NumeroInt= '" & mientity.OS_NumeroInt & "' "
        End If
        If String.IsNullOrEmpty(mientity.OS_Telefonos) = False Then
            strwhere = strwhere & "AND OS_Telefonos= '" & mientity.OS_Telefonos & "' "
        End If
        If String.IsNullOrEmpty(mientity.OS_FechaFinConvenio) = False Then
            strwhere = strwhere & "AND OS_FechaFinConvenio = '" & mientity.OS_FechaFinConvenio & "' "
        End If
        If String.IsNullOrEmpty(mientity.OS_FechaAlta) = False Then
            strwhere = strwhere & "AND OS_FechaAlta = '" & mientity.OS_FechaAlta & "' "
        End If
        If String.IsNullOrEmpty(mientity.OS_FechaCancelacion) = False Then
            strwhere = strwhere & "AND OS_FechaCancelacion = '" & mientity.OS_FechaCancelacion & "' "
        End If

        'valido si la expresion del where tiene contenido
        If strwhere <> "" Then
            strwhere = "where" & strwhere.Remove(0, 3) 'elimino el AND de la cadena strwhere y le agrego el where
        End If

        strsql = strsql & strwhere
        Dim ds As New DataSet("DS_ObrasSociales")
        'lo que hago es pasar a un dataset, todas las filas con datos de la tabla que cumplan las
        'condiciones de busqueda, y luego lo paso a una lista por lo cual invoco a la función getlista
        ds = GetDataSet(strsql)
        Return GetLista(ds)

    End Function



    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        'genero un datatable con todos las filas de la tabla ObrasSociales
        dt = GetDataTable("Select * from ObrasSociales")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        'genero un datatable con la fila de la tabla ObrasSociales que cumpla la condición especificada
        dt = GetDataTable("select * from ObrasSociales where OS_Key =" & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim miEntity As Entities.EntObrasSociales = Nothing
        miEntity = CType(mEntityObject, Entities.EntObrasSociales)
        Dim strSql As String = ""
        strSql = "Insert Into EntObrasSociales (Sys_ROLE_Description,Sys_Role_Enabled) Values ('" & miEntity.SYS_ROLE_Descripcion & "', " & miEntity.SYS_ROLE_Enabled.ToString & ")"

        Return ExecuteInsertQuery(strSql)
    End Function




    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

        Dim mientity As Entities.EntObrasSociales = Nothing
        mientity = CType(mEntityObject, Entities.EntObrasSociales)
        Dim strsql As String = " "
        Dim strwhere As String = " "
        strsql = "Delete from ObrasSociales"
        If mientity.LOCA_Key.HasValue Then
            strwhere = strwhere & "and OS_Key = '" & mientity.OS_Key.ToString & "'"

        End If

    End Function


    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity





    End Function
End Class
