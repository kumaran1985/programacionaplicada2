Public Class DAPlanes
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPlanes
        miEntity.OS_Key = mDataTable("OS_Key")
        miEntity.Plan_Descripcion = mDataTable("Plan_Descripcion")
        miEntity.Plan_FechaAlta = mDataTable("Plan_FechaAlta")
        miEntity.Plan_FechaCancelacion = mDataTable("Plan_FechaCancelacion")
        miEntity.Plan_FechaFinConvenio = mDataTable("Plan_FinConvenio")
        'miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class