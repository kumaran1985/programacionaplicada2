Public Class DALocalidades 
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim mientity As New Entities.EntLocalidades
        mientity.LOCA_Codpos = DBVal(mDataTable("LOCA_Codpos"))
        mientity.LOCA_Key = DBVal(mDataTable("LOCA_Key"))
        mientity.LOCA_Nombre = DBVal(mDataTable("LOCA_Nombre"))
        mientity.PROV_Key = DBVal(mDataTable("PROV_Key"))

        Return mientity


    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista
        
        Dim ListOfEntity As New List(Of Entities.EntLocalidades)


        If ValidatedDataSet(mDataSet) Is Nothing Then
            Return Nothing
        End If

        For Each dr As DataRow In mDataSet.Tables(0).Rows 
            ListOfEntity.Add(Me.GenerarEntidad(dr))
        Next
        Return ListOfEntity

    End Function

    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

        Dim mientity As Entities.EntLocalidades = Nothing
        
        mientity = CType(mEntityObject, Entities.EntLocalidades)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Delete From Localidades"

        If String.IsNullOrEmpty(mientity.LOCA_Nombre) = False Then
            strwhere = "AND LOCA_Nombre = '" & mientity.LOCA_Nombre & "'"
        End If
        If mientity.LOCA_Key.HasValue Then
            strwhere = strwhere & "AND LOCA_Key = '" & mientity.LOCA_Key.ToString & " '"
        End If
        If mientity.PROV_Key.HasValue Then
            strwhere = strwhere & "AND PROV_Key = '" & mientity.PROV_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.LOCA_Codpos) = False Then
            strwhere = "AND LOCA_Codpos = '" & mientity.LOCA_Codpos & "'"
        End If

        If strwhere = "" Then
            Throw New Exception("No se puede ejecutar la actualizacion porque no se han especificado todos los valores")
        Else
            
            strwhere = strwhere.Remove(0, 3)
        End If

        strsql = strsql & " Where " & strwhere
        Return ExecuteSQLNonQuery(strsql)

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity
        Dim strsql As String = ""
        strsql = "Delete from Localidades where LOCA_Key = " & mKey
        Return ExecuteSQLNonQuery(strsql)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * from Localidades where LOCA_Key =" & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If
        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("Localidades")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_Localidades")
        ds.Tables.Add(dt)
        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
       
        Dim mientity As Entities.EntLocalidades = Nothing
        
        mientity = CType(mEntityObject, Entities.EntLocalidades)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Select * From Localidades"

       
        If String.IsNullOrEmpty(mientity.LOCA_Nombre) = False Then
            strwhere = "AND LOCA_Nombre = '" & mientity.LOCA_Nombre & "'"
        End If
        If mientity.LOCA_Key.HasValue Then
            strwhere = strwhere & "AND LOCA_Key = '" & mientity.LOCA_Key.ToString & " '"
        End If
        If mientity.PROV_Key.HasValue Then
            strwhere = strwhere & "AND PROV_Key = '" & mientity.PROV_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.LOCA_Codpos) = False Then
            strwhere = strwhere & "AND LOCA_Codpos = '" & mientity.LOCA_Codpos & "' "
        End If

        If strwhere <> "" Then
            strwhere = "where" & strwhere.Remove(0, 3)
        End If

        strsql = strsql & strwhere
        Dim ds As New DataSet("DS_Localidades")

        ds = GetDataSet(strsql)
        Return GetLista(ds)

    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * from Localidades")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("select * from Localidades where LOCA_Key =" & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim mientity As Entities.EntLocalidades = Nothing
        
        mientity = CType(mEntityObject, Entities.EntLocalidades)
        Dim strsql As String = "Insert into Localidades(PROV_Key,LOCA_Nombre,LOCA_Key,LOCA_Codpos)values('" & mientity.PROV_Key.ToString() & "','" & mientity.LOCA_Nombre.ToString() & "','" & mientity.LOCA_Key.ToString() & "','" & mientity.LOCA_Codpos.ToString() & "')"

        Return ExecuteInsertQuery(strsql)

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity

        Dim mientity As Entities.EntLocalidades = Nothing
        
        mientity = CType(mEntityObject, Entities.EntLocalidades)
        Dim strsql As String = ""

        If mientity.LOCA_Key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accción debido a que no se declarado la clave primaria")

        End If

        If String.IsNullOrEmpty(mientity.LOCA_Nombre) = False Then
            strsql = strsql & ",LOCA_Nombre = '" & mientity.LOCA_Nombre & "'"
        End If

        If mientity.PROV_Key.HasValue Then
            strsql = strsql & ",PROV_Key = '" & mientity.PROV_Key.ToString & " '"
        End If

        If String.IsNullOrEmpty(mientity.LOCA_Codpos) = False Then
            strsql = strsql & ",LOCA_Codpos = '" & mientity.LOCA_Codpos & "' "
        End If
        strsql = strsql.Remove(0, 1)

        strsql = "update Localidades set " & strsql & "where LOCA_Key = " & mientity.LOCA_Key.ToString
        Return ExecuteSQLNonQuery(strsql)
    End Function
End Class
