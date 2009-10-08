Public Class DASysRoles
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntSys_Roles

        miEntity.SYS_ROLE_Descripcion = mDataTable("SYS_ROLE_Description")
        miEntity.SYS_ROLE_Enabled = mDataTable("SYS_ROLE_Enabled")
        miEntity.SYS_ROLE_KEY = mDataTable("SYS_ROLE_KEY")

        Return miEntity

    End Function

    'Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of MBFrameWork.Entities.EntityBase) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    '    Dim miEntity As New List(Of Entities.EntSys_Roles)

    '    Dim miEntity2 As New List(Of MBFrameWork.Entities.EntityBase)


    '    Return miEntity2



    'End Function
End Class
