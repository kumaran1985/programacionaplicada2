Public Class DAEntTiposDocumento
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable



    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntTiposDocumento

        miEntity.TDOC_Descripcion = mDataTable("TDOC_Descripcion")
        miEntity.TDOC_Key = mDataTable("TDOC_Key")

        Return miEntity

    End Function

   

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class
