Public Class DAEntConsultorios
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable

    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntConsultorios

        miEntity.Cons_Descripcion = mDataTable("Cons_Descripcion")
        miEntity.Cons_Ubicacion = mDataTable("Cons_Ubicacion")
        miEntity.Cons_Key = mDataTable("Cons_Key")

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class
