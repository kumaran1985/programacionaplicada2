Public Class DAPacientes1
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim miEntity As New Entities.EntPacientes

        miEntity.LOCA_Key = mDataTable("LOCA_Key")
        miEntity.Pac_Apellidos = mDataTable("Pac_Apellidos")
        miEntity.Pac_Calle = mDataTable("Pac_Calle")
        miEntity.Pac_Celular = mDataTable("Pac_Celular")
        miEntity.Pac_Email = mDataTable("Pac_Email")
        miEntity.Pac_EstadoCivil = mDataTable("Pac_EstadoCivil")
        miEntity.Pac_FechaAlta = mDataTable("Pac_FechaAlta")
        miEntity.Pac_FechaCancelacion = mDataTable("Pac_FechaCancelacion")
        miEntity.Pac_FechaNacimiento = mDataTable("Pac_FechaNacimiento")
        miEntity.Pac_key = mDataTable("Pac_key")
        miEntity.Pac_Nacionalidad = mDataTable("Pac_Nacionalidad")
        miEntity.Pac_Nombres = mDataTable("Pac_Nombres")
        miEntity.Pac_NumeroDoc = mDataTable("Pac_NumeroDoc")
        miEntity.Pac_NumeroExt = mDataTable("Pac_NumeroExt")
        miEntity.Pac_NumeroInt = mDataTable("Pac_NumeroInt")
        miEntity.Pac_Ocupacion = mDataTable("Pac_Ocupacion")
        miEntity.Pac_Sexo = mDataTable("Pac_Sexo")
        miEntity.Pac_Telefonos = mDataTable("Pac_Telefonos")
        miEntity.TDOC_Key = mDataTable("TDOC_Key")

        Return miEntity

    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class
