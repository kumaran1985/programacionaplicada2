
Namespace Exceptions
    <Serializable()> _
    Public MustInherit Class ExceptionBase
        Inherits Exception

        Protected Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

End Namespace
