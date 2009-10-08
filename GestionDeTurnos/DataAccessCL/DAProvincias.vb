Public Class DAProvincias
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable

    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntProvincias

        miEntity.PROV_Key = mDataTable("PROV_Key")
        miEntity.PROV_Nombre = mDataTable("PROV_Nombre")
        Return miEntity
    End Function

    
End Class
