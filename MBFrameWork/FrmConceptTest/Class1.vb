Public Class Class1
    Inherits MBFrameWork.DataAccess.DAOledb

    Public ReadOnly Property MiPropuiedad() As String
        Get
            Return ""
        End Get
    End Property

    Public Function GetAllAsDataTable(ByVal index As String) As DataTable
        Dim dt As DataTable
        dt = GetAllFromTable("clientes")
        Return dt
    End Function


    Public Function GetAllAsObject(ByVal index As String)
        Dim dt As DataTable
        '  dt = GetAllFromTable("clientes")
        Return dt
    End Function

    Public Function Insert(ByVal o As Object) As Boolean
        Return True
    End Function

    Public Function Delete(ByVal index As String) As Boolean
        Return True
    End Function

    Public Function update(ByVal o As Object) As Boolean
        Return True
    End Function

    Public Sub pepe()
        
    End Sub
End Class
