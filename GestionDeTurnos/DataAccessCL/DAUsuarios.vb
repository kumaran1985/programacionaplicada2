Public Class DAUsuarios

    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable


    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad

        Dim miEntity As New Entities.EntUsuarios
        miEntity.Login = mDataTable("Login")
        miEntity.ROLE_KEY = mDataTable("ROLE_KEY")
        miEntity.TDOC_Key = mDataTable("TDOC_Key")
        miEntity.User_Apellido = mDataTable("User_Apellido")
        miEntity.User_Autorizacion = mDataTable("User_Autorizacion")
        miEntity.User_Celular = mDataTable("User_Celular")
        miEntity.User_Direccion = mDataTable("User_Direccion")
        miEntity.User_Email = mDataTable("User_Email")
        miEntity.User_Nombre = mDataTable("User_Nombre")
        miEntity.User_Pass = mDataTable("User_Pass")
        miEntity.User_Telefono = mDataTable("User_Telefono")
        miEntity.User_DNI = mDataTable("User_DNI")



    End Function

    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.Generic.List(Of Object) Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function


End Class
