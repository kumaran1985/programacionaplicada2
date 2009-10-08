Public Class DAEntMotivoVisita
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable

    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntMotivoVisita

        miEntity.MOVI_Descripcion = mDataTable("MOVI_Descripcion")
        miEntity.MOVI_Motivo = mDataTable("MOVI_Moivo")
        miEntity.MOVI_Key = mDataTable("MOVI_Key")

        Return miEntity

    End Function

End Class
