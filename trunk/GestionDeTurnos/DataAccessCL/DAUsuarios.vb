Public Class DAUsuarios

    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys




    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad

        Dim miEntity As New Entities.EntUsuarios

        miEntity.Login = mDataTable("SYS_User_Login")
        miEntity.ROLE_KEY = mDataTable("SYS_ROLE_KEY")
        miEntity.TDOC_Key = mDataTable("TDOC_Key")
        miEntity.User_Apellido = mDataTable("SYS_User_Apellido")
        miEntity.User_Autorizacion = mDataTable("SYS_User_Autorizacion")
        miEntity.User_Celular = mDataTable("SYS_User_Celular")
        miEntity.User_Direccion = mDataTable("SYS_User_Direccion")
        miEntity.User_Email = mDataTable("SYS_User_email")
        miEntity.User_Nombre = mDataTable("SYS_User_Nombre")
        miEntity.User_Pass = mDataTable("SYS_User_Pass")
        miEntity.User_Telefono = mDataTable("SYS_User_Telefono")
        miEntity.User_DNI = mDataTable("SYS_User_DNI")

        Return miEntity


    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntUsuarios)

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
        Dim miEntity As Entities.EntUsuarios = Nothing
        miEntity = CType(mEntityObject, Entities.EntUsuarios)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Delete From SYS_Usuarios "

        If String.IsNullOrEmpty(miEntity.Login) = False Then
            strWhere = "AND SYS_User_Login = '" & miEntity.Login & "' "
        End If

        If miEntity.ROLE_KEY.HasValue Then
            strWhere = strWhere & "AND SYS_ROLE_KEY = " & miEntity.ROLE_KEY.ToString & " "
        End If

        If miEntity.TDOC_Key.ToString Then
            strWhere = strWhere & "AND TDOC_Key = " & miEntity.TDOC_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Apellido) Then
            strWhere = strWhere & "SYS_User_Apellido = " & miEntity.User_Apellido.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Celular) Then
            strWhere = strWhere & "SYS_User_Celular = " & miEntity.User_Celular.ToString & " "
        End If

        If miEntity.User_Autorizacion.ToString Then
            strWhere = strWhere & "AND SYS_User_Autorizacion = " & miEntity.User_Autorizacion.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Direccion) Then
            strWhere = strWhere & "SYS_User_Direccion = " & miEntity.User_Direccion.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Email) Then
            strWhere = strWhere & "SYS_User_Email = " & miEntity.User_Email.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Nombre) Then
            strWhere = strWhere & "SYS_User_Nombre = " & miEntity.User_Nombre.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Pass) Then
            strWhere = strWhere & "SYS_User_Pass = " & miEntity.User_Pass.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Telefono) Then
            strWhere = strWhere & "SYS_User_Telefono = " & miEntity.User_Telefono.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_DNI) Then
            strWhere = strWhere & "SYS_User_DNI = " & miEntity.User_DNI.ToString & " "
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
        strSQL = "Delete from SYS_Usuarios Where SYS_User_Login = " & mKey
        Return ExecuteSQLNonQuery(strSQL)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity

        Dim dt As DataTable
        dt = GetDataTable("Select * From SYS_Usuarios Where SYS_User_Login = " & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If

        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("SYS_Usuarios")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_sys_Usuarios")
        ds.Tables.Add(dt)

        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim miEntity As Entities.EntUsuarios = Nothing
        miEntity = CType(mEntityObject, Entities.EntUsuarios)
        Dim strSql As String = ""
        Dim strWhere As String = ""
        strSql = "Select * From SYS_Usuarios "

        If String.IsNullOrEmpty(miEntity.Login) = False Then
            strWhere = "AND SYS_User_Login = '" & miEntity.Login & "' "
        End If

        If miEntity.ROLE_KEY.HasValue Then
            strWhere = strWhere & "AND SYS_ROLE_KEY = " & miEntity.ROLE_KEY.ToString & " "
        End If

        If miEntity.TDOC_Key.ToString Then
            strWhere = strWhere & "AND TDOC_Key = " & miEntity.TDOC_Key.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Apellido) Then
            strWhere = strWhere & "SYS_User_Apellido = " & miEntity.User_Apellido.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Celular) Then
            strWhere = strWhere & "SYS_User_Celular = " & miEntity.User_Celular.ToString & " "
        End If

        If miEntity.User_Autorizacion.ToString Then
            strWhere = strWhere & "AND SYS_User_Autorizacion = " & miEntity.User_Autorizacion.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Direccion) Then
            strWhere = strWhere & "SYS_User_Direccion = " & miEntity.User_Direccion.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Email) Then
            strWhere = strWhere & "SYS_User_Email = " & miEntity.User_Email.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Nombre) Then
            strWhere = strWhere & "SYS_User_Nombre = " & miEntity.User_Nombre.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Pass) Then
            strWhere = strWhere & "SYS_User_Pass = " & miEntity.User_Pass.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_Telefono) Then
            strWhere = strWhere & "SYS_User_Telefono = " & miEntity.User_Telefono.ToString & " "
        End If

        If String.IsNullOrEmpty(miEntity.User_DNI) Then
            strWhere = strWhere & "SYS_User_DNI = " & miEntity.User_DNI.ToString & " "
        End If
        

        'valido si la exprsion del where tiene contenido

        If strWhere <> "" Then
            'Elimino la palabra "AND" del where
            strWhere = " Where " & strWhere.Remove(0, 3)
        End If

        strSql = strSql & strWhere

        Dim ds As New DataSet("DS_SYS_Usuarios")

        ds = GetDataSet(strSql)


        Return GetLista(ds)

    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * SYS_Usuarios")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * SYS_Usuarios Where SYS_User_Login = " & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim miEntity As Entities.EntUsuarios = Nothing
        miEntity = CType(mEntityObject, _
                        Entities.EntUsuarios)
        Dim strSql As String = ""
        strSql = "Insert Into SYS_Usuarios (SYS_USER_LOGION,SYS_ROLE_KEY,TDOC_Key," & _
                 " SYS_User_Apellido,SYS_User_Autorizacion,SYS_User_Celular," & _
                 " SYS_User_Direccion, SYS_User_email, SYS_User_Nombre, SYS_User_Pass," & _
                 " SYS_User_Telefono, SYS_User_DNI) Values ('" & miEntity.Login & "', " & miEntity.ROLE_KEY.ToString & ", " & miEntity.TDOC_Key.ToString & _
                 " , " & miEntity.User_Apellido.ToString & ", " & miEntity.User_Autorizacion.ToString & _
                 ", " & miEntity.User_Celular.ToString & ", " & miEntity.User_Direccion.ToString & _
                 ", " & miEntity.User_DNI.ToString & ", " & miEntity.User_Email.ToString & _
                 ", " & miEntity.User_Nombre.ToString & ", " & miEntity.User_Pass.ToString & _
                 ", " & miEntity.User_Pass.ToString & ", " & miEntity.User_Telefono.ToString & ")"

        Return ExecuteInsertQuery(strSql)

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        Dim strSql As String = ""
        Dim miEntity As Entities.EntUsuarios = Nothing
        miEntity = CType(mEntityObject, Entities.EntUsuarios)

        If String.IsNullOrEmpty(miEntity.Login) = False Then
            Throw New Exception("No se puede ejecutar la accion debido a que no se ha declarado la clave principal")
        End If

        If miEntity.ROLE_KEY.HasValue Then
            strSql = ", SYS_ROLE_Key = '" & miEntity.ROLE_KEY.ToString & "' "
        End If

        If miEntity.TDOC_Key.ToString Then
            strSql = ", TDOC_Key = '" & miEntity.TDOC_Key & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_Apellido) Then
            strSql = ", SYS_User_Apellido = '" & miEntity.User_Apellido & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_Celular) Then
            strSql = ", SYS_User_Celular = '" & miEntity.User_Celular & "' "
        End If

        If miEntity.User_Autorizacion.ToString Then
            strSql = ", SYS_User_Autorizacion = '" & miEntity.User_Autorizacion.ToString & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_Direccion) Then
            strSql = ", SYS_User_Direccion = '" & miEntity.User_Direccion & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_Email) Then
            strSql = ", SYS_User_Email = '" & miEntity.User_Email & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_Nombre) Then
            strSql = ", SYS_User_Nombre = '" & miEntity.User_Nombre & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_Pass) Then
            strSql = ", SYS_User_Pass = '" & miEntity.User_Pass & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_Telefono) Then
            strSql = ", SYS_User_Telefono = '" & miEntity.User_Telefono & "' "
        End If

        If String.IsNullOrEmpty(miEntity.User_DNI) Then
            strSql = ", SYS_User_DNI = '" & miEntity.User_DNI & "' "
        End If

        strSql = strSql.Remove(0, 1)

        strSql = "Update SYS_Usuarios Set " & strSql & " Where SYS_User_Login = " & miEntity.Login.ToString

        Return ExecuteSQLNonQuery(strSql)

    End Function
End Class
