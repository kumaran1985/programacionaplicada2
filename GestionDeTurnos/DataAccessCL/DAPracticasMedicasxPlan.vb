Public Class DAPracticasMedicasxPlan
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPracticasMedicasxPlan

        miEntity.PMxP_Key = mDataTable("PMxP_Key")
        miEntity.Plan_Key = mDataTable("Plan_Key")
        miEntity.OS_Key = mDataTable("OS_Key")
        miEntity.PMxP_PorcentajeDescuento = mDataTable("PMxP_PorcentajeDescuento")

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista


    End Function

End Class
