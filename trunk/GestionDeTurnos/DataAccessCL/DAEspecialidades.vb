Public Class DAEspecialidades
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntEspecialidades

        miEntity.cDescripcion = mDataTable("cDescipcion")
        miEntity.iConsultorio = mDataTable("iConsultorio")
        miEntity.iEspecialidad = mDataTable("iEspecialidad")

        Return miEntity
    End Function
End Class
