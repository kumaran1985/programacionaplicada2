Public Class DataAccess
    Inherits BrainWork.DataAccessBaseLibrary.AbstractDataAccess

    Sub New(ByVal oUser As BrainWork.Security.ApplicationUser)
        MyBase.New(oUser)
    End Sub

    Public Function UnDataset() As DataTable
        Dim ds As New DataTable
        Return Me.GetTable("TablaTest")
    End Function

    Public Overrides Function Add(ByVal oEntity As Object) As Boolean

    End Function

    Public Overrides Function Delete(ByVal oEntity As Object) As Boolean

    End Function

    Public Overrides Function Disable(ByVal oEntity As Object) As Boolean

    End Function

    Public Overrides Function Update(ByVal oEntity As Object) As Boolean

    End Function
End Class
