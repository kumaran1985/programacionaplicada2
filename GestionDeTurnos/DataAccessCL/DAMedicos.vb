Public Class DAMedicos
    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable




    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad
        Dim mientity As New Entities.EntMedicos
        mientity.Med_key = mDataTable("Med_Key")
        mientity.LOCA_Key = mDataTable("LOCA_Key")
        mientity.Med_Apellidos = mDataTable("Med_Apellidos")
        mientity.Med_Calle = mDataTable("Med_Calle")
        mientity.Med_Celular = mDataTable("Med_Celular")
        mientity.Med_Email = mDataTable("Med_Email")
        mientity.Med_Especialidad = mDataTable("Med_Especialidad")
        mientity.Med_EstadoCivil = mDataTable("Med_EstadoCivil")
        mientity.Med_FechaIngreso = mDataTable("Med_FechaIngreso")
        mientity.Med_FechaNacimiento = mDataTable("Med_FechaNacimiento")
        mientity.Med_Matricula = mDataTable("Med_Matricula")
        mientity.Med_Matricula1 = mDataTable("Med_Matricula1")
        mientity.Med_Nombres = mDataTable("Med_Nombres")
        mientity.Med_NumeroDoc = mDataTable("Med_NumeroDoc")
        mientity.Med_NumeroExt = mDataTable("Med_NumeroExt")
        mientity.Med_NumeroInt = mDataTable("Med_NumeroInt")
        mientity.Med_Sexo = mDataTable("Med_Sexo")
        mientity.Med_Telefonos = mDataTable("Med_Telefonos")
        mientity.TDOC_Key = mDataTable("TDOC_Key")

        Return mientity


    End Function
 
    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function
End Class
