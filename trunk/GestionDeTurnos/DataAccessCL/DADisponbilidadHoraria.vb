
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

    End Function



    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity

    End Function
End Class
