<Serializable()> _
Public Class Configuration

    Public Shared Function GetConnectionString(ByVal oUser As BrainWork.Security.ApplicationUser)
        Return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks;Data Source=localhost\sqlexpress"
    End Function

End Class
