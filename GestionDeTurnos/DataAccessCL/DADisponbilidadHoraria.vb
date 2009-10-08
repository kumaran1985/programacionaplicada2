
Public Class DADisponbilidadHoraria
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable

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

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class
