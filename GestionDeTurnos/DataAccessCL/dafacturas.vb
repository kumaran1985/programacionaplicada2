

Public Class dafacturas
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntFacturas

        miEntity.Fact_Key = mDataTable("Fact_Key")
        miEntity.Pac_key = mDataTable("Pac_Key")
        miEntity.fact_fechafactura = mDataTable("Fact_Fechafactura")
        miEntity.Fact_Tipo = mDataTable("Fact_Tipo")
        miEntity.Fact_Monto = mDataTable("Fact_Monto")
        miEntity.Fact_TipoDoc = mDataTable("Fact_TipoDoc")
        miEntity.Fact_NumeroDoc = mDataTable("Fact_NumeroDoc")
        miEntity.Fact_Cantidad = mDataTable("Fact_Cantidad")
        miEntity.PM_Key = mDataTable("PM_Key")
        miEntity.Fact_Observacion = mDataTable("Fact_Observacion")
        miEntity.Fact_FechaAlta = mDataTable("Fact_FechaAlta")
        miEntity.Fact_FechaCancelacion = mDataTable("Fact_FechaCancelacion")

        Return miEntity

    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class

