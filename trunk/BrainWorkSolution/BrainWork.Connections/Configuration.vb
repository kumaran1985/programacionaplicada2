Public Class Configuration

    Public Shared Function GetConnectionString(ByVal oUser As BrainWork.Security.ApplicationUser)
        Return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=testDataBase;Data Source=localhost\sqlexpress"
    End Function

End Class
