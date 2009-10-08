Public Class DALocalidades 
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable

    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntLocalidades

        miEntity.LOCA_Key = mDataTable("LOCA_Key")
        miEntity.LOCA_Codpos = mDataTable("LOCA_Codpos")
        miEntity.LOCA_Nombre = mDataTable("LOCA_Nombre")
        miEntity.PROV_Key = mDataTable("PROV_Key")
        Return miEntity
    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class
