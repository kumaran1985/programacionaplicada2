
Public Class DAMedicos
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim mientity As New Entities.EntMedicos
        mientity.Med_key = DBVal(mDataTable("Med_Key"))
        mientity.LOCA_Key = DBVal(mDataTable("LOCA_Key"))
        mientity.Med_Apellidos = DBVal(mDataTable("Med_Apellidos"))
        mientity.Med_Nombres = DBVal(mDataTable("Med_Nombres"))
        mientity.Med_Calle = DBVal(mDataTable("Med_Calle"))
        mientity.Med_Celular = DBVal(mDataTable("Med_Celular"))
        mientity.Med_Email = DBVal(mDataTable("Med_Email"))
        mientity.Med_Especialidad = DBVal(mDataTable("Med_Especialidad"))
        mientity.Med_EstadoCivil = DBVal(mDataTable("Med_EstadoCivil"))
        mientity.Med_FechaIngreso = DBVal(mDataTable("Med_FechaIngreso"))
        mientity.Med_FechaNacimiento = DBVal(mDataTable("Med_FechaNacimiento"))
        mientity.Med_Matricula = DBVal(mDataTable("Med_Matricula"))
        mientity.Med_Matricula1 = DBVal(mDataTable("Med_Matricula1"))
        mientity.Med_NumeroDoc = DBVal(mDataTable("Med_NumeroDoc"))
        mientity.Med_NumeroExt = DBVal(mDataTable("Med_NumeroExt"))
        mientity.Med_NumeroInt = DBVal(mDataTable("Med_NumeroInt"))
        mientity.Med_Sexo = DBVal(mDataTable("Med_Sexo"))
        mientity.Med_Telefonos = DBVal(mDataTable("Med_Telefonos"))
        mientity.TDOC_Key = DBVal(mDataTable("TDOC_Key"))

        Return mientity


    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista
        'voy a generar una lista con cada fila de mi datatable,se pasa un dataset como paramentro
        'para no hacer tan restrictivo el método y hacerlo lo más generico posible
        Dim ListOfEntity As New List(Of Entities.EntMedicos)

        'valida si existen elementos en el dataset
        If ValidatedDataSet(mDataSet) Is Nothing Then
            Return Nothing
        End If

        For Each dr As DataRow In mDataSet.Tables(0).Rows 'le estoy pasando una sola tabla
            'agrego la entidad a la lista con el metodo generar entidad
            ListOfEntity.Add(Me.GenerarEntidad(dr))
        Next
        Return ListOfEntity

    End Function

    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

        Dim mientity As Entities.EntMedicos = Nothing
        'aplico ctype para cambiar la entidad que paso como parametro 
        'en este metodo, que es de tipo object a una entidad del tipo EntMedicos
        mientity = CType(mEntityObject, Entities.EntMedicos)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Delete From Medicos"

        'verifico que la cadena correspondiente a Med_Apellidos tenga un valor para comparar
        'es decir que en el filtro que voy a usar para eliminar la entidad voy a usar el campo en cuestión

        If String.IsNullOrEmpty(mientity.Med_Apellidos) = False Then
            strwhere = "AND Med_Apellidos = '" & mientity.Med_Apellidos & "'"
        End If
        If mientity.Med_key.HasValue Then
            strwhere = strwhere & "AND Med_Key = '" & mientity.Med_key.ToString & " '"
        End If
        If mientity.TDOC_Key.HasValue Then
            strwhere = strwhere & "AND TDOC_Key = '" & mientity.TDOC_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_NumeroDoc) = False Then
            strwhere = strwhere & "AND Med_NumeroDoc= '" & mientity.Med_NumeroDoc & "' "
        End If

        If String.IsNullOrEmpty(mientity.Med_Nombres) = False Then
            strwhere = strwhere & "AND Med_Nombres= '" & mientity.Med_Nombres & "' "
        End If

        If mientity.LOCA_Key.HasValue Then
            strwhere = strwhere & "AND LOCA_Key = '" & mientity.LOCA_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_Calle) = False Then
            strwhere = strwhere & "AND Med_Calle= '" & mientity.Med_Calle & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_NumeroExt) = False Then
            strwhere = strwhere & "AND Med_NumeroExt= '" & mientity.Med_NumeroExt & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_NumeroInt) = False Then
            strwhere = strwhere & "AND Med_NumeroInt= '" & mientity.Med_NumeroInt & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Telefonos) = False Then
            strwhere = strwhere & "AND Med_Telefonos = '" & mientity.Med_Telefonos & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Celular) = False Then
            strwhere = strwhere & "AND Med_Celular = '" & mientity.Med_Celular & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Sexo) = False Then
            strwhere = strwhere & "AND Med_Sexo = '" & mientity.Med_Sexo & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Email) = False Then
            strwhere = strwhere & "AND Med_Email = '" & mientity.Med_Email & "' "
        End If

        If mientity.Med_Especialidad.HasValue Then
            strwhere = strwhere & "AND Med_Especialidad = '" & mientity.Med_Especialidad.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_Matricula) = False Then
            strwhere = strwhere & "AND Med_Matricula = '" & mientity.Med_Matricula & "' "
        End If


        If Not mientity.Med_FechaNacimiento = Date.MinValue Then
            strwhere = strwhere & "AND Med_FechaNacimiento = '" & mientity.Med_FechaNacimiento.ToString & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_EstadoCivil) = False Then
            strwhere = strwhere & "AND Med_EstadoCivil= '" & mientity.Med_EstadoCivil & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_FechaIngreso) = False Then
            strwhere = strwhere & "AND Med_FechaIngreso= '" & mientity.Med_FechaIngreso & "' "
        End If

        If mientity.Med_Matricula1.HasValue Then
            strwhere = strwhere & "AND Med_Matricula1 = '" & mientity.Med_Matricula1.ToString & " '"
        End If

        'valido si la expresion del where tiene contenido
        If strwhere = "" Then
            Throw New Exception("No se puede ejecutar la actualizacion porque no se han especificado todos los valores")
        Else
            'Elimino la palabra "AND" del where
            'remove(0,3) en la posición 0, elimino 3 caracteres que son los que corresponde a AND
            strwhere = strwhere.Remove(0, 3)
        End If

        strsql = strsql & " Where " & strwhere
        Return ExecuteSQLNonQuery(strsql)

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity
        Dim strsql As String = ""
        strsql = "Delete from Medicos where Med_Key = " & mKey
        Return ExecuteSQLNonQuery(strsql)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * from Medicos where Med_Key =" & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If
        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("Medicos")
        If dt Is Nothing Then
            Return Nothing
        End If
        'debo crear un data set que constara solo de esta tabla, para de esta forma, poder
        'pasarlo como parametro en la función getlista
        Dim ds As New DataSet("DS_Medicos")
        ds.Tables.Add(dt)
        'lo que hago es pasar a una lista, todas las filas con datos de la tabla
        'por lo cual invoco a la función getlista
        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        'vamos a realizar algo parecido en la función deletentity pero acá el objetivo, es obtener
        'todas las filas que cumpla con una condición de busqueda
        Dim mientity As Entities.EntMedicos = Nothing
        'aplico ctype para cambiar la entidad que paso como parametro 
        'en este metodo, que es de tipo object a una entidad del tipo EntMedicos
        mientity = CType(mEntityObject, Entities.EntMedicos)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Select * From Medicos "

        'verifico que la cadena correspondiente a Med_Apellidos tenga un valor para comparar
        'es decir que en el filtro que voy a usar para traer la entidad voy a usar el campo en cuestión

        If String.IsNullOrEmpty(mientity.Med_Apellidos) = False Then
            strwhere = "AND Med_Apellidos = '" & mientity.Med_Apellidos & " '"
        End If
        If mientity.Med_key.HasValue Then
            strwhere = strwhere & "AND Med_Key = '" & mientity.Med_key.ToString & " '"
        End If
        If mientity.TDOC_Key.HasValue Then
            strwhere = strwhere & "AND TDOC_Key = '" & mientity.TDOC_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_NumeroDoc) = False Then
            strwhere = strwhere & "AND Med_NumeroDoc= '" & mientity.Med_NumeroDoc & "' "
        End If

        If String.IsNullOrEmpty(mientity.Med_Nombres) = False Then
            strwhere = strwhere & "AND Med_Nombres= '" & mientity.Med_Nombres & "' "
        End If

        If mientity.LOCA_Key.HasValue Then
            strwhere = strwhere & "AND LOCA_Key = '" & mientity.LOCA_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_Calle) = False Then
            strwhere = strwhere & "AND Med_Calle= '" & mientity.Med_Calle & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_NumeroExt) = False Then
            strwhere = strwhere & "AND Med_NumeroExt= '" & mientity.Med_NumeroExt & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_NumeroInt) = False Then
            strwhere = strwhere & "AND Med_NumeroInt= '" & mientity.Med_NumeroInt & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Telefonos) = False Then
            strwhere = strwhere & "AND Med_Telefonos = '" & mientity.Med_Telefonos & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Celular) = False Then
            strwhere = strwhere & "AND Med_Celular = '" & mientity.Med_Celular & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Sexo) = False Then
            strwhere = strwhere & "AND Med_Sexo = '" & mientity.Med_Sexo & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Email) = False Then
            strwhere = strwhere & "AND Med_Email = '" & mientity.Med_Email & "' "
        End If

        If mientity.Med_Especialidad.HasValue Then
            strwhere = strwhere & "AND Med_Especialidad = '" & mientity.Med_Especialidad.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_Matricula) = False Then
            strwhere = strwhere & "AND Med_Matricula = '" & mientity.Med_Matricula & "' "
        End If

        If Not mientity.Med_FechaNacimiento = Date.MinValue Then
            strwhere = strwhere & "AND Med_FechaNacimiento = '" & mientity.Med_FechaNacimiento.ToString & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_EstadoCivil) = False Then
            strwhere = strwhere & "AND Med_EstadoCivil= '" & mientity.Med_EstadoCivil & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_FechaIngreso) = False Then
            strwhere = strwhere & "AND Med_FechaIngreso= '" & mientity.Med_FechaIngreso & "' "
        End If

        If mientity.Med_Matricula1.HasValue Then
            strwhere = strwhere & "AND Med_Matricula1 = '" & mientity.Med_Matricula1.ToString & " '"
        End If

        'valido si la expresion del where tiene contenido
        If strwhere <> "" Then
            strwhere = "where" & strwhere.Remove(0, 3) 'elimino el AND de la cadena strwhere y le agrego el where
        End If

        strsql = strsql & strwhere
        Dim ds As New DataSet("DS_Medicos")
        'lo que hago es pasar a un dataset, todas las filas con datos de la tabla que cumplan las
        'condiciones de busqueda, y luego lo paso a una lista por lo cual invoco a la función getlista
        ds = GetDataSet(strsql)
        Return GetLista(ds)

    End Function



    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        'genero un datatable con todos las filas de la tabla medicos
        dt = GetDataTable("Select * from Medicos")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        'genero un datatable con la fila de la tabla medicos que cumpla la condición especificada
        dt = GetDataTable("select * from Medicos where Med_Key =" & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim mientity As Entities.EntMedicos = Nothing
        'aplico ctype para cambiar la entidad que paso como parametro 
        'en este metodo, que es de tipo object a una entidad del tipo EntMedicos
        mientity = CType(mEntityObject, Entities.EntMedicos)
        Dim strsql As String = ""

        'Dim sb As New Text.StringBuilder

        'strsql = sb.ToString

        'sb.AppendLine("Insert into Medicos ")
        'sb.AppendLine("(LOCA_Key,Med_Apellidos,")
        'sb.AppendLine("Med_Nombres,Med_Calle,Med_Celular,Med_Email,")
        'sb.AppendLine("Med_Especialidad,Med_EstadoCivil,Med_FechaIngreso,")
        'sb.AppendLine("Med_FechaNacimiento,")
        'sb.AppendLine("Med_Matricula,Med_Matricula1,Med_NumeroDoc,Med_NumeroExt,Med_NumeroInt")
        'sb.AppendLine(",Med_Sexo,Med_Telefonos,TDOC_Key)")
        'sb.AppendLine("values ('" & mientity.Med_Apellidos & "','" & mientity.Med_Nombres & "')")
        'sb.AppendLine(",'" & mientity.Med_Calle & "','" & mientity.Med_Celular & "' ,'" & mientity.Med_EstadoCivil & "','" & mientity.Med_Email & "',")
        'sb.AppendLine(mientity.Med_Especialidad.ToString)
        'sb.AppendLine(",'" & mientity.Med_FechaIngreso & "','" & mientity.Med_FechaNacimiento & "','" & mientity.Med_Matricula & "',")
        'sb.AppendLine(mientity.Med_Matricula1.ToString)
        'sb.AppendLine(",'" & mientity.Med_NumeroDoc & "','" & mientity.Med_NumeroExt & "','")
        'sb.AppendLine(mientity.Med_NumeroInt & " ','" & mientity.Med_Sexo & "','" & mientity.Med_Telefonos & "',")
        'sb.AppendLine(mientity.TDOC_Key.ToString)
        'sb.AppendLine(")")
        'strsql = sb.ToString
        'strsql = "select max(med_key) from medicos"

        strsql = "Insert into Medicos (LOCA_Key,Med_Especialidad,Med_Matricula1,TDOC_key,Med_Apellidos,Med_Calle,Med_Celular,Med_Email,Med_EstadoCivil,Med_FechaIngreso,Med_FechaNacimiento,Med_Matricula,Med_Nombres,Med_NumeroDoc,Med_NumeroExt,Med_NumeroInt,Med_Sexo,Med_Telefonos) values (" & mientity.LOCA_Key.ToString & "," & mientity.Med_Especialidad.ToString & "," & mientity.Med_Matricula1.ToString & "," & mientity.TDOC_Key.ToString & ",'" & mientity.Med_Apellidos & "','" & mientity.Med_Calle & "','" & mientity.Med_Celular & "','" & mientity.Med_Email & "','" & mientity.Med_EstadoCivil & "','" & mientity.Med_FechaIngreso & "','" & mientity.Med_FechaNacimiento & "','" & mientity.Med_Matricula & "','" & mientity.Med_Nombres & "','" & mientity.Med_NumeroDoc & "','" & mientity.Med_NumeroExt & "','" & mientity.Med_NumeroInt & "','" & mientity.Med_Sexo & "','" & mientity.Med_Telefonos & "')"


       
        Return ExecuteInsertQuery(strsql)

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity
        
        Dim mientity As Entities.EntMedicos = Nothing
        'aplico ctype para cambiar la entidad que paso como parametro 
        'en este metodo, que es de tipo object a una entidad del tipo EntMedicos
        mientity = CType(mEntityObject, Entities.EntMedicos)
        Dim strsql As String = ""

        'verifico que la cadena correspondiente a Med_Apellidos tenga un valor para comparar
        'es decir que en el filtro que voy a usar para traer la entidad voy a usar el campo en cuestión
        If mientity.Med_key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accción debido a que no se declarado la clave primaria")

        End If

        If String.IsNullOrEmpty(mientity.Med_Apellidos) = False Then
            strsql = strsql & ",Med_Apellidos = '" & mientity.Med_Apellidos & "'"
        End If
       
        If mientity.TDOC_Key.HasValue Then
            strsql = strsql & ",TDOC_Key = '" & mientity.TDOC_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_NumeroDoc) = False Then
            strsql = strsql & ",Med_NumeroDoc= '" & mientity.Med_NumeroDoc & "' "
        End If

        If String.IsNullOrEmpty(mientity.Med_Nombres) = False Then
            strsql = strsql & ",Med_Nombres= '" & mientity.Med_Nombres & "' "
        End If

        If mientity.LOCA_Key.HasValue Then
            strsql = strsql & ",LOCA_Key = '" & mientity.LOCA_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_Calle) = False Then
            strsql = strsql & ",Med_Calle= '" & mientity.Med_Calle & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_NumeroExt) = False Then
            strsql = strsql & ",Med_NumeroExt= '" & mientity.Med_NumeroExt & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_NumeroInt) = False Then
            strsql = strsql & ",Med_NumeroInt= '" & mientity.Med_NumeroInt & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Telefonos) = False Then
            strsql = strsql & ",Med_Telefonos = '" & mientity.Med_Telefonos & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Celular) = False Then
            strsql = strsql & ",Med_Celular = '" & mientity.Med_Celular & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Sexo) = False Then
            strsql = strsql & ",Med_Sexo = '" & mientity.Med_Sexo & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_Email) = False Then
            strsql = strsql & ",Med_Email = '" & mientity.Med_Email & "' "
        End If

        If mientity.Med_Especialidad.HasValue Then
            strsql = strsql & ",Med_Especialidad = '" & mientity.Med_Especialidad.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.Med_Matricula) = False Then
            strsql = strsql & ",Med_Matricula = '" & mientity.Med_Matricula & "' "
        End If

        If Not mientity.Med_FechaNacimiento = Date.MinValue Then
            strsql = strsql & ",Med_FechaNacimiento = '" & mientity.Med_FechaNacimiento.ToString & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_EstadoCivil) = False Then
            strsql = strsql & ",Med_EstadoCivil= '" & mientity.Med_EstadoCivil & "' "
        End If
        If String.IsNullOrEmpty(mientity.Med_FechaIngreso) = False Then
            strsql = strsql & ",Med_FechaIngreso= '" & mientity.Med_FechaIngreso & "' "
        End If

        If mientity.Med_Matricula1.HasValue Then
            strsql = strsql & ",Med_Matricula1 = '" & mientity.Med_Matricula1.ToString & " '"
        End If

        'elimino la primera coma
        strsql = strsql.Remove(0, 1)
        'concateno todo para poder crear la setencia update
        strsql = "update Medicos set " & strsql & "where Med_Key = " & mientity.Med_key.ToString
        Return ExecuteSQLNonQuery(strsql)
    End Function
End Class
