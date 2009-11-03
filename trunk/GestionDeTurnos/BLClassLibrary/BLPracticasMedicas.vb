Public Class BLPracticasMedicas

    Inherits MBFrameWork.BussinesLogic.BLBase
    Implements MBFrameWork.BussinesLogic.IStandardQuerys


    Public Function DeleteEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.BussinesLogic.IStandardQuerys.DeleteEntity

        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.DeleteEntity(mEntityObject)

    End Function

    Public Function DeleteEntity(ByVal mKey As String) As Boolean Implements MBFrameWork.BussinesLogic.IStandardQuerys.DeleteEntity
        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.DeleteEntity(mKey)
    End Function

    Public Function GetEntity(ByVal mKey As Object) As Object Implements MBFrameWork.BussinesLogic.IStandardQuerys.GetEntity
        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.GetListOfEntity

    End Function

    Public Function GetListOfEntity() As System.Collections.IList Implements MBFrameWork.BussinesLogic.IStandardQuerys.GetListOfEntity
        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.GetListOfEntity
    End Function

    Public Function GetListOfEntity(ByVal mEntityObject As Object) As System.Collections.IList Implements MBFrameWork.BussinesLogic.IStandardQuerys.GetListOfEntity
        Dim da As New DataAccessCL.DAPracticasMedicas

        Return da.GetListOfEntity(mEntityObject)
    End Function

    Public Function GetTable() As System.Data.DataTable Implements MBFrameWork.BussinesLogic.IStandardQuerys.GetTable
        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.GetTable
    End Function

    Public Function GetTable(ByVal mKey As String) As System.Data.DataTable Implements MBFrameWork.BussinesLogic.IStandardQuerys.GetTable
        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.GetTable(mKey)
    End Function

    Public Function UpdateEntity(ByVal mEntityObject As Object) As Boolean Implements MBFrameWork.BussinesLogic.IStandardQuerys.UpdateEntity
        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.UpdateEntity(mEntityObject)
    End Function

    Public Function InsertEntity(ByVal mEntityObject As Object) As Object Implements MBFrameWork.BussinesLogic.IStandardQuerys.InsertEntity
        Dim da As New DataAccessCL.DAPracticasMedicas
        Return da.InsertEntity(mEntityObject)
    End Function
End Class
