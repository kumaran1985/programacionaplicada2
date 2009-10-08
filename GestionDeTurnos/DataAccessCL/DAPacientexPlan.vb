Public Class DAPacientexPlan
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable



    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPacientexPlan
        miEntity.iNroHC = mDataTable("iNroHC")
        miEntity.iPlan = mDataTable("iPlan")
        miEntity.iObraSocial = mDataTable("iObraSocial")
        miEntity.tFechaFin = mDataTable("tFechaFin")
        miEntity.tFechaInicio = mDataTable("tFechaInicio")

        Return miEntity


    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class
