Public Class DAUsuarios

    Inherits MBFrameWork.DataAccess.DAOledb
    Implements MBFrameWork.DataAccess.IEntityzable
    Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys




    Public Function GenerarEntidad(ByVal mDataTable As System.Data.DataRow) As Object Implements MBFrameWork.DataAccess.IEntityzable.GenerarEntidad

        Dim miEntity As New Entities.EntUsuarios

        miEntity.Login = mDataTable("SYS_User_Login")
        miEntity.ROLE_KEY = mDataTable("ROLE_KEY")
        miEntity.TDOC_Key = mDataTable("TDOC_Key")
        miEntity.User_Apellido = mDataTable("SYS_User_Apellido")
        miEntity.User_Autorizacion = mDataTable("SYS_User_Autorizacion")
        miEntity.User_Celular = mDataTable("SYS_User_Celular")
        miEntity.User_Direccion = mDataTable("SYS_User_Direccion")
        miEntity.User_Email = mDataTable("SYS_User_email")
        miEntity.User_Nombre = mDataTable("SYS_User_Nombre")
        miEntity.User_Pass = mDataTable("SYS_User_Pass")
        miEntity.User_Telefono = mDataTable("SYS_User_Telefono")
        miEntity.User_DNI = mDataTable("SYS_User_DNI")

        Return miEntity


    End Function


    Public Function GetLista(ByVal mDataSet As System.Data.DataSet) As System.Collections.IList Implements MBFrameWork.DataAccess.IEntityzable.GetLista

    End Function

    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.DeleteEntity

    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetEntity

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetListOfEntity

    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.GetTable

    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.InsertEntity

    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.DataAccess.IStandardDataAccessQuerys.UpdateEntity

    End Function
End Class
