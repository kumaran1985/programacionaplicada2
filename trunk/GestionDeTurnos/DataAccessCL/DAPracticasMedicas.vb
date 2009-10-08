Public Class DAPracticasMedicas
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPracticasMedicas

        miEntity.PM_Key = mDataTable("PM_Key")
        miEntity.PM_Descripcion = mDataTable("PM_Descripcion")
        miEntity.PM_PrecioUnitario = mDataTable("PM_PrecioUnitario")

        Return miEntity

    End Function


End Class
