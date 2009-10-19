Public Class DAProvincias
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim mientity As New Entities.EntProvincias
        mientity.PROV_Key = DBVal(mDataTable("PROV_Key"))
        mientity.PROV_Nombre = DBVal(mDataTable("PROV_Nombre"))
       
        Return mientity


    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

        Dim ListOfEntity As New List(Of Entities.EntProvincias)


        If ValidatedDataSet(mDataSet) Is Nothing Then
            Return Nothing
        End If

        For Each dr As DataRow In mDataSet.Tables(0).Rows
            ListOfEntity.Add(Me.GenerarEntidad(dr))
        Next
        Return ListOfEntity

    End Function

    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

        Dim mientity As Entities.EntProvincias = Nothing

        mientity = CType(mEntityObject, Entities.EntProvincias)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Delete From Provincias"

        If String.IsNullOrEmpty(mientity.PROV_Nombre) = False Then
            strwhere = "AND PROV_Nombre = '" & mientity.PROV_Nombre & "'"
        End If
        If mientity.PROV_Key.HasValue Then
            strwhere = strwhere & "AND PROV_Key = '" & mientity.PROV_Key.ToString & " '"
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
        strsql = "Delete from Provincias where PROV_Key = " & mKey
        Return ExecuteSQLNonQuery(strsql)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity
        Dim dt As DataTable
        dt = GetDataTable("Select * from Provincias where PROV_Key =" & mKey)
        If dt Is Nothing Then
            Return Nothing
        End If
        Return GenerarEntidad(dt.Rows(0))

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity
        Dim dt As DataTable = GetAllFromTable("Provincias")
        If dt Is Nothing Then
            Return Nothing
        End If
        Dim ds As New DataSet("DS_Provincias")
        ds.Tables.Add(dt)
        Return GetLista(ds)

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

        Dim mientity As Entities.EntProvincias = Nothing

        mientity = CType(mEntityObject, Entities.EntProvincias)
        Dim strsql As String = ""
        Dim strwhere As String = ""
        strsql = "Select * From Provincias"


        If String.IsNullOrEmpty(mientity.PROV_Nombre) = False Then
            strwhere = "AND PROV_Nombre = '" & mientity.PROV_Nombre & "'"
        End If
        If mientity.PROV_Key.HasValue Then
            strwhere = strwhere & "AND PROV_Key = '" & mientity.PROV_Key.ToString & " '"
        End If

        If strwhere <> "" Then
            strwhere = "where" & strwhere.Remove(0, 3)
        End If

        strsql = strsql & strwhere
        Dim ds As New DataSet("DS_Provincias")

        ds = GetDataSet(strsql)
        Return GetLista(ds)

    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("Select * from Provincias")
        Return dt
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable
        Dim dt As DataTable
        dt = GetDataTable("select * from Provincias where PROV_Key =" & mKey)
        Return dt
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity
        Dim mientity As Entities.EntProvincias = Nothing

        mientity = CType(mEntityObject, Entities.EntProvincias)
        Dim strsql As String = ""

        Dim sb As New Text.StringBuilder

        strsql = sb.ToString

        sb.AppendLine("Insert into Provincias(PROV_Key,PROV_Nombre)values('" & mientity.PROV_Key & "','" & mientity.PROV_Nombre & "')")


        strsql = sb.ToString



        Return ExecuteInsertQuery(strsql)

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity

        Dim mientity As Entities.EntProvincias = Nothing

        mientity = CType(mEntityObject, Entities.EntProvincias)
        Dim strsql As String = ""

        If mientity.PROV_Key.HasValue = False Then
            Throw New Exception("No se puede ejecutar la accción debido a que no se declarado la clave primaria")

        End If

        If String.IsNullOrEmpty(mientity.PROV_Nombre) = False Then
            strsql = strsql & ",PROV_Nombre = '" & mientity.PROV_Nombre & "'"
        End If

        strsql = strsql.Remove(0, 1)

        strsql = "update Provincias set " & strsql & "where PROV_Key = " & mientity.PROV_Key.ToString()
        Return ExecuteSQLNonQuery(strsql)
    End Function
End Class
