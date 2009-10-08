Public Class DATurnos
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


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

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista


    End Function
End Class

