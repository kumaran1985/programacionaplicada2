<Serializable()> _
Public Class NotUserLoggedException
    Inherits System.Exception

    Sub New()
        MyBase.New("No hay usuario logueado")
    End Sub

End Class
