


































Public Class dafacturas
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable

    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntFacturas

        miEntity.Fact_Cantidad = mDataTable("FACT_CANTIDAD")
        miEntity.Fact_FechaAlta = mDataTable("FACT_FECHAALTA")
        'miEntity.Fact_FechaCancelacion = mDataTble(
        'miEntity.fact_fechafactura = mDataTble(
        'miEntity.Fact_Key = mDataTble(
        'miEntity.Fact_Monto = mDataTble(
        'miEntity.Fact_NumeroDoc = mDataTble(
        'miEntity.Fact_Observacion = mDataTble(
        'miEntity.Fact_Tipo = mDataTble(
        'miEntity.Fact_TipoDoc = mDataTble(

        'miEntity()




    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class

